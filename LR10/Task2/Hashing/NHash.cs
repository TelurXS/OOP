using System.Security.Cryptography;
using System.Text;

namespace Task2.Hashing;

public class NHash
{
	private static byte[] ComputeMD5Hash(byte[] input)
	{
		using (MD5 md5 = MD5.Create())
		{
			return md5.ComputeHash(input);
		}
	}

	private static byte[] ComputeSHA256Hash(byte[] input)
	{
		using (SHA256 sha256 = SHA256.Create())
		{
			return sha256.ComputeHash(input);
		}
	}

	private static byte[] ComputeSHA512Hash(byte[] input)
	{
		using (SHA512 sha512 = SHA512.Create())
		{
			return sha512.ComputeHash(input);
		}
	}

	public static byte[] ComputeNHash(string input)
	{
		byte[] inputBytes = Encoding.UTF8.GetBytes(input);

		byte[] md5Hash = ComputeMD5Hash(inputBytes);
		byte[] sha256Hash = ComputeSHA256Hash(inputBytes);
		byte[] sha512Hash = ComputeSHA512Hash(inputBytes);

		byte[] combinedHash = new byte[md5Hash.Length + sha256Hash.Length + sha512Hash.Length];
		Buffer.BlockCopy(md5Hash, 0, combinedHash, 0, md5Hash.Length);
		Buffer.BlockCopy(sha256Hash, 0, combinedHash, md5Hash.Length, sha256Hash.Length);
		Buffer.BlockCopy(sha512Hash, 0, combinedHash, md5Hash.Length + sha256Hash.Length, sha512Hash.Length);

		using (SHA256 sha256 = SHA256.Create())
		{
			return sha256.ComputeHash(combinedHash);
		}
	}

	public string ComputeNHashAsString(string input)
	{
		byte[] hashBytes = ComputeNHash(input);
		StringBuilder sb = new StringBuilder();
		foreach (byte b in hashBytes)
		{
			sb.Append(b.ToString("x2"));
		}
		return sb.ToString();
	}

}
