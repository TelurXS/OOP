using System.Numerics;
using System.Security.Cryptography;
using System.Windows.Forms;
using Task2.Hashing;
using RSA = Task2.Hashing.RSA;

namespace Task2;

public partial class Form1 : Form
{
	public Form1()
	{
		InitializeComponent();
		FirstThread = new Thread(new ThreadStart(LuciferAlgorythm));
		SecondThread = new Thread(new ThreadStart(NHashAlgorythm));
		ThirdThread = new Thread(new ThreadStart(RSAAlgorythm));

		Cipher = new LuciferCipher();
		NHash = new NHash();
		RSA = new RSA();
	}

	private Thread FirstThread { get; }
	private Thread SecondThread { get; }
	private Thread ThirdThread { get; }

	private LuciferCipher Cipher { get; set; }
	private NHash NHash { get; set; }
	private RSA RSA { get; set; }

	private void LuciferAlgorythm()
	{
		while (true)
		{
			byte[] key = new byte[16];
			new RNGCryptoServiceProvider().GetBytes(key);

			byte[] plaintext = new byte[16];
			new RNGCryptoServiceProvider().GetBytes(plaintext);

			RichTextBox_First.Text += "Plaintext: ";
			RichTextBox_First.Text += BitConverter.ToString(plaintext) + "\n";

			RichTextBox_First.Text += "Ciphertext: ";
			byte[] ciphertext = Cipher.Encrypt(plaintext, key);
			RichTextBox_First.Text += BitConverter.ToString(ciphertext) + "\n";

			RichTextBox_First.Text += "Decrypted: ";
			byte[] decrypted = Cipher.Decrypt(ciphertext, key);
			RichTextBox_First.Text += BitConverter.ToString(decrypted) + "\n";

			Thread.Sleep(1000);
		}
	}

	private void NHashAlgorythm()
	{
		while (true)
		{
			string input = Random.Shared.Next().ToString();
			string hash = NHash.ComputeNHashAsString(input);
			RichTextBox_Second.Text += $"N-Hash of '{input}' is: {hash}" + "\n";

			Thread.Sleep(1000);
		}
	}

	private void RSAAlgorythm()
	{
		while (true)
		{
			int keySize = 512;
			var keys = RSA.GenerateKeys(keySize);

			string message = Random.Shared.Next().ToString();
			BigInteger messageData = new BigInteger(System.Text.Encoding.UTF8.GetBytes(message));

			BigInteger encryptedData = RSA.Encrypt(messageData, keys.PublicKey, keys.Modulus);
			RichTextBox_Third.Text += "Encrypted: " + encryptedData + "\n";

			BigInteger decryptedData = RSA.Decrypt(encryptedData, keys.PrivateKey, keys.Modulus);
			RichTextBox_Third.Text += "Decrypted: " + System.Text.Encoding.UTF8.GetString(decryptedData.ToByteArray()) + "\n";

			Thread.Sleep(1000);
		}
	}

	private void Button_First_Start_Click(object sender, EventArgs e)
	{
		FirstThread.Start();
	}

	private void Button_Second_Start_Click(object sender, EventArgs e)
	{
		SecondThread.Start();
	}

	private void Button_Third_Start_Click(object sender, EventArgs e)
	{
		ThirdThread.Start();
	}

	[Obsolete]
	private void Button_First_Stop_Click(object sender, EventArgs e)
	{
		FirstThread.Suspend();
	}

	[Obsolete]
	private void Button_Second_Stop_Click(object sender, EventArgs e)
	{
		SecondThread.Suspend();
	}

	[Obsolete]
	private void Button_Third_Stop_Click(object sender, EventArgs e)
	{
		FirstThread.Suspend();
	}

	private void Button_All_Start_Click(object sender, EventArgs e)
	{
		FirstThread.Start();
		SecondThread.Start();
		ThirdThread.Start();
	}

	[Obsolete]
	private void Button_All_Stop_Click(object sender, EventArgs e)
	{
		FirstThread.Suspend();
		SecondThread.Suspend();
		ThirdThread.Suspend();
	}
}