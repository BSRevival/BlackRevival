using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace GameDBDecryptor
{
    internal class Program
    {
		private static string skey = "archbears!@#";

		static void Main(string[] args)
		{
			if (args.Length == 0)
			{
				Console.WriteLine("No Arguments, Drag and Drop a file from your locallow/archbears/steam/ folder");
			}
			else
			{
				foreach (string arg in args)
				{
					if (arg.EndsWith(".json"))
					{
						Console.WriteLine($"Processing file {arg}");
						var json = JsonConvert.DeserializeObject(File.ReadAllText(arg));
						var prettified = JsonConvert.SerializeObject(json, Formatting.Indented);
						File.WriteAllText(arg, prettified);
						Console.WriteLine($"File decrypted as {arg}");
					}
					else
					{
						Console.WriteLine($"Processing file {arg}");
						string decrypted = ReadEncryptFile(arg);
						File.WriteAllText(arg + ".json", decrypted);
						Console.WriteLine($"File decrypted as {arg}.json");
					}
				}
			}
		}

		public static string ReadEncryptFile(string filename)
		{
			string result;
			using (RijndaelManaged rijndaelManaged = new RijndaelManaged())
			{
				string text = null;
				using (FileStream fileStream = new FileStream(filename, FileMode.Open))
				{
					byte[] bytes = Encoding.ASCII.GetBytes(skey.Length.ToString());
					PasswordDeriveBytes passwordDeriveBytes = new PasswordDeriveBytes(skey, bytes);
					using (ICryptoTransform cryptoTransform = rijndaelManaged.CreateDecryptor(passwordDeriveBytes.GetBytes(32), passwordDeriveBytes.GetBytes(16)))
					{
						using (CryptoStream cryptoStream = new CryptoStream(fileStream, cryptoTransform, CryptoStreamMode.Read))
						{
							using (StreamReader streamReader = new StreamReader(cryptoStream, Encoding.UTF8))
							{
								text = streamReader.ReadToEnd();
							}
						}
					}
				}
				result = text;
			}
			return result;
		}
	}
}
