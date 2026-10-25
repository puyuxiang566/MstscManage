using System;
using System.Text;

namespace MstscManage
{
	public class DataProtectionForRDPWrapper
	{
		public static string Encrypt(string text_password)
		{
			byte[] e = DataProtectionForRDPWrapper.dp.Encrypt(DataProtectionForRDPWrapper.GetBytes(text_password), null, "psw");
			return DataProtectionForRDPWrapper.GetHex(e);
		}

		public static string Decrypt(string enc_password)
		{
			byte[] b = DataProtectionForRDPWrapper.ToByteArray(enc_password);
			byte[] d = DataProtectionForRDPWrapper.dp.Decrypt(b, null, "psw");
			return DataProtectionForRDPWrapper.GetString(d);
		}

		private static byte[] GetBytes(string text)
		{
			return Encoding.Unicode.GetBytes(text);
		}

		private static string GetString(byte[] byt)
		{
			Encoding enc = Encoding.Unicode;
			return enc.GetString(byt);
		}

		private static string GetHex(byte[] byt_text)
		{
			string ret = string.Empty;
			for (int i = 0; i < byt_text.Length; i++)
			{
				ret += Convert.ToString(byt_text[i], 16).PadLeft(2, '0').ToUpper();
			}
			return ret;
		}

		private static byte[] ToByteArray(string HexString)
		{
			byte[] result;
			try
			{
				int NumberChars = HexString.Length;
				byte[] bytes = new byte[NumberChars / 2];
				for (int i = 0; i < NumberChars; i += 2)
				{
					bytes[i / 2] = Convert.ToByte(HexString.Substring(i, 2), 16);
				}
				result = bytes;
			}
			catch (Exception ex)
			{
				throw new Exception("Problem converting Hex to Bytes", ex);
			}
			return result;
		}

		private static DataProtector dp = new DataProtector(DataProtector.Store.USE_USER_STORE);
	}
}
