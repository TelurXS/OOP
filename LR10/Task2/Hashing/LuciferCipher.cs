using System.Security.Cryptography;

namespace Task2.Hashing;

public class LuciferCipher
{
	private const int BlockSize = 16;
	private const int NumRounds = 16;

	public byte[] Encrypt(byte[] plaintext, byte[] key)
	{
		if (key.Length != BlockSize)
			throw new ArgumentException($"Key must be {BlockSize} bytes long");

		var (left, right) = SplitBlock(plaintext);
		for (int round = 0; round < NumRounds; round++)
		{
			var roundKey = GenerateRoundKey(key, round);
			(left, right) = FeistelRound(left, right, roundKey);
		}
		return CombineBlocks(left, right);
	}

	public byte[] Decrypt(byte[] ciphertext, byte[] key)
	{
		if (key.Length != BlockSize)
			throw new ArgumentException($"Key must be {BlockSize} bytes long");

		var (left, right) = SplitBlock(ciphertext);
		for (int round = NumRounds - 1; round >= 0; round--)
		{
			var roundKey = GenerateRoundKey(key, round);
			(left, right) = FeistelRound(right, left, roundKey);
		}
		return CombineBlocks(left, right);
	}

	private (byte[], byte[]) SplitBlock(byte[] block)
	{
		byte[] left = block.Take(BlockSize / 2).ToArray();
		byte[] right = block.Skip(BlockSize / 2).Take(BlockSize / 2).ToArray();
		return (left, right);
	}

	private byte[] CombineBlocks(byte[] left, byte[] right)
	{
		return left.Concat(right).ToArray();
	}

	private (byte[], byte[]) FeistelRound(byte[] left, byte[] right, byte[] roundKey)
	{
		byte[] newRight = XorBytes(left, RoundFunction(right, roundKey));
		return (right, newRight);
	}

	private byte[] RoundFunction(byte[] data, byte[] key)
	{
		using (var sha256 = SHA256.Create())
		{
			var combined = data.Concat(key).ToArray();
			return sha256.ComputeHash(combined).Take(BlockSize / 2).ToArray();
		}
	}

	private byte[] GenerateRoundKey(byte[] key, int round)
	{
		using (var sha256 = SHA256.Create())
		{
			var combined = key.Concat(BitConverter.GetBytes(round)).ToArray();
			return sha256.ComputeHash(combined).Take(BlockSize / 2).ToArray();
		}
	}

	private byte[] XorBytes(byte[] a, byte[] b)
	{
		return a.Zip(b, (x, y) => (byte)(x ^ y)).ToArray();
	}
}