using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;

namespace MstscManage
{
	public class DES
	{
		private static string GetDesKey(string DesKey)
		{
			bool flag = DesKey.Length > 8;
			string result;
			if (flag)
			{
				result = DesKey.Substring(0, 8);
			}
			else
			{
				while (DesKey.Length < 8)
				{
					DesKey += "&";
				}
				result = DesKey;
			}
			return result;
		}

		public static string Encrypt_DES(string str, string DesKey = "")
		{
			bool flag = string.IsNullOrEmpty(DesKey);
			if (flag)
			{
				DesKey = DES.strDesKey;
			}
			else
			{
				DesKey = DES.GetDesKey(DesKey);
			}
			DESCryptoServiceProvider des = new DESCryptoServiceProvider();
			des.Mode = CipherMode.ECB;
			des.Padding = PaddingMode.PKCS7;
			byte[] inputByteArray = Encoding.Default.GetBytes(str);
			des.Key = Encoding.ASCII.GetBytes(DesKey);
			des.IV = Encoding.ASCII.GetBytes(DesKey);
			MemoryStream ms = new MemoryStream();
			CryptoStream cs = new CryptoStream(ms, des.CreateEncryptor(), CryptoStreamMode.Write);
			cs.Write(inputByteArray, 0, inputByteArray.Length);
			cs.FlushFinalBlock();
			StringBuilder sb = new StringBuilder();
			foreach (byte b in ms.ToArray())
			{
				sb.AppendFormat("{0:X2}", b);
			}
			return sb.ToString();
		}

		public static string Decrypt_DES(string str, string DesKey = "")
		{
			bool flag = str.IsNullOrEmpty();
			string result;
			if (flag)
			{
				result = str;
			}
			else
			{
				bool flag2 = string.IsNullOrEmpty(DesKey);
				if (flag2)
				{
					DesKey = DES.strDesKey;
				}
				else
				{
					DesKey = DES.GetDesKey(DesKey);
				}
				DESCryptoServiceProvider des = new DESCryptoServiceProvider();
				byte[] inputByteArray = new byte[str.Length / 2];
				for (int x = 0; x < str.Length / 2; x++)
				{
					inputByteArray[x] = (byte)Convert.ToInt32(str.Substring(x * 2, 2), 16);
				}
				des.Key = Encoding.ASCII.GetBytes(DesKey);
				des.IV = Encoding.ASCII.GetBytes(DesKey);
				des.Mode = CipherMode.ECB;
				des.Padding = PaddingMode.PKCS7;
				MemoryStream ms = new MemoryStream();
				CryptoStream cs = new CryptoStream(ms, des.CreateDecryptor(), CryptoStreamMode.Write);
				cs.Write(inputByteArray, 0, inputByteArray.Length);
				cs.FlushFinalBlock();
				result = Encoding.Default.GetString(ms.ToArray());
			}
			return result;
		}

		public static string Encode(string data)
		{
			byte[] byIV = Encoding.ASCII.GetBytes("123456");
			byte[] Key = Encoding.ASCII.GetBytes(DES.strDesKey);
			DESCryptoServiceProvider cryptoProvider = new DESCryptoServiceProvider();
			cryptoProvider.Key = Key;
			cryptoProvider.Mode = CipherMode.ECB;
			cryptoProvider.Padding = PaddingMode.PKCS7;
			int i = cryptoProvider.KeySize;
			MemoryStream ms = new MemoryStream();
			CryptoStream cst = new CryptoStream(ms, cryptoProvider.CreateEncryptor(Key, byIV), CryptoStreamMode.Write);
			StreamWriter sw = new StreamWriter(cst);
			sw.Write(data);
			sw.Flush();
			cst.FlushFinalBlock();
			sw.Flush();
			return Convert.ToBase64String(ms.GetBuffer(), 0, (int)ms.Length);
		}

		private static readonly string strDesKey = "f26fe8b6";
	}
}
