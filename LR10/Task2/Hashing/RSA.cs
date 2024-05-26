using System.Numerics;
using System.Security.Cryptography;

namespace Task2.Hashing;

class RSA
{
	public class KeyPair
	{
		public BigInteger PublicKey { get; set; }
		public BigInteger PrivateKey { get; set; }
		public BigInteger Modulus { get; set; }
	}

	public KeyPair GenerateKeys(int keySize)
	{
		using (var rng = new RNGCryptoServiceProvider())
		{
			BigInteger p = GenerateLargePrime(keySize / 2, rng);
			BigInteger q = GenerateLargePrime(keySize / 2, rng);
			BigInteger n = p * q;
			BigInteger phi = (p - 1) * (q - 1);

			BigInteger e = 65537; // Commonly used prime exponent

			BigInteger d = ModInverse(e, phi);

			return new KeyPair { PublicKey = e, PrivateKey = d, Modulus = n };
		}
	}

	private static BigInteger GenerateLargePrime(int bits, RNGCryptoServiceProvider rng)
	{
		byte[] bytes = new byte[bits / 8];
		BigInteger prime;
		do
		{
			rng.GetBytes(bytes);
			bytes[bytes.Length - 1] &= 0x7F; // force sign bit to positive
			prime = new BigInteger(bytes);
		} while (!IsProbablePrime(prime, 10));
		return prime;
	}

	private static bool IsProbablePrime(BigInteger source, int certainty)
	{
		if (source == 2 || source == 3)
			return true;
		if (source < 2 || source % 2 == 0)
			return false;

		BigInteger d = source - 1;
		int s = 0;

		while (d % 2 == 0)
		{
			d /= 2;
			s += 1;
		}

		Random rng = new Random();
		for (int i = 0; i < certainty; i++)
		{
			BigInteger a = RandomBigInteger(2, source - 2, rng);
			BigInteger x = BigInteger.ModPow(a, d, source);
			if (x == 1 || x == source - 1)
				continue;

			for (int r = 1; r < s; r++)
			{
				x = BigInteger.ModPow(x, 2, source);
				if (x == 1)
					return false;
				if (x == source - 1)
					break;
			}

			if (x != source - 1)
				return false;
		}

		return true;
	}

	private static BigInteger RandomBigInteger(BigInteger minValue, BigInteger maxValue, Random rng)
	{
		byte[] bytes = new byte[maxValue.ToByteArray().LongLength];
		BigInteger a;
		do
		{
			rng.NextBytes(bytes);
			a = new BigInteger(bytes);
		} while (a < minValue || a >= maxValue);
		return a;
	}

	private static BigInteger ModInverse(BigInteger a, BigInteger m)
	{
		BigInteger m0 = m, t, q;
		BigInteger x0 = 0, x1 = 1;

		if (m == 1)
			return 0;

		while (a > 1)
		{
			q = a / m;
			t = m;
			m = a % m;
			a = t;
			t = x0;
			x0 = x1 - q * x0;
			x1 = t;
		}

		if (x1 < 0)
			x1 += m0;

		return x1;
	}

	public BigInteger Encrypt(BigInteger data, BigInteger publicKey, BigInteger modulus)
	{
		return BigInteger.ModPow(data, publicKey, modulus);
	}

	public BigInteger Decrypt(BigInteger data, BigInteger privateKey, BigInteger modulus)
	{
		return BigInteger.ModPow(data, privateKey, modulus);
	}
}
