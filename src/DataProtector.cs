using System;
using System.Runtime.InteropServices;

namespace MstscManage
{
	public class DataProtector
	{
		[DllImport("Crypt32.dll", CharSet = CharSet.Auto, SetLastError = true)]
		private static extern bool CryptProtectData(ref DataProtector.DATA_BLOB pDataIn, string szDataDescr, ref DataProtector.DATA_BLOB pOptionalEntropy, IntPtr pvReserved, ref DataProtector.CRYPTPROTECT_PROMPTSTRUCT pPromptStruct, int dwFlags, ref DataProtector.DATA_BLOB pDataOut);

		[DllImport("Crypt32.dll", CharSet = CharSet.Auto, SetLastError = true)]
		private static extern bool CryptUnprotectData(ref DataProtector.DATA_BLOB pDataIn, string szDataDescr, ref DataProtector.DATA_BLOB pOptionalEntropy, IntPtr pvReserved, ref DataProtector.CRYPTPROTECT_PROMPTSTRUCT pPromptStruct, int dwFlags, ref DataProtector.DATA_BLOB pDataOut);

		[DllImport("kernel32.dll", CharSet = CharSet.Auto)]
		private unsafe static extern int FormatMessage(int dwFlags, ref IntPtr lpSource, int dwMessageId, int dwLanguageId, ref string lpBuffer, int nSize, IntPtr* Arguments);

		public DataProtector(DataProtector.Store tempStore)
		{
			this.store = tempStore;
		}

		public byte[] Encrypt(byte[] plainText, byte[] optionalEntropy, string DataDescription)
		{
			DataProtector.DATA_BLOB plainTextBlob = default(DataProtector.DATA_BLOB);
			DataProtector.DATA_BLOB cipherTextBlob = default(DataProtector.DATA_BLOB);
			DataProtector.DATA_BLOB entropyBlob = default(DataProtector.DATA_BLOB);
			DataProtector.CRYPTPROTECT_PROMPTSTRUCT prompt = default(DataProtector.CRYPTPROTECT_PROMPTSTRUCT);
			this.InitPromptstruct(ref prompt);
			try
			{
				try
				{
					int bytesSize = plainText.Length;
					plainTextBlob.pbData = Marshal.AllocHGlobal(bytesSize);
					bool flag = IntPtr.Zero == plainTextBlob.pbData;
					if (flag)
					{
						throw new Exception("Unable to allocate plaintext buffer.");
					}
					plainTextBlob.cbData = bytesSize;
					Marshal.Copy(plainText, 0, plainTextBlob.pbData, bytesSize);
				}
				catch (Exception ex)
				{
					throw new Exception("Exception marshalling data. " + ex.Message);
				}
				bool flag2 = DataProtector.Store.USE_MACHINE_STORE == this.store;
				int dwFlags;
				if (flag2)
				{
					dwFlags = 5;
					bool flag3 = optionalEntropy == null;
					if (flag3)
					{
						optionalEntropy = new byte[0];
					}
					try
					{
						int bytesSize2 = optionalEntropy.Length;
						entropyBlob.pbData = Marshal.AllocHGlobal(optionalEntropy.Length);
						bool flag4 = IntPtr.Zero == entropyBlob.pbData;
						if (flag4)
						{
							throw new Exception("Unable to allocate entropy data buffer.");
						}
						Marshal.Copy(optionalEntropy, 0, entropyBlob.pbData, bytesSize2);
						entropyBlob.cbData = bytesSize2;
					}
					catch (Exception ex2)
					{
						throw new Exception("Exception entropy marshalling data. " + ex2.Message);
					}
				}
				else
				{
					dwFlags = 1;
				}
				bool retVal = DataProtector.CryptProtectData(ref plainTextBlob, DataDescription, ref entropyBlob, IntPtr.Zero, ref prompt, dwFlags, ref cipherTextBlob);
				bool flag5 = !retVal;
				if (flag5)
				{
					throw new Exception("Encryption failed. " + DataProtector.GetErrorMessage(Marshal.GetLastWin32Error()));
				}
				bool flag6 = IntPtr.Zero != plainTextBlob.pbData;
				if (flag6)
				{
					Marshal.FreeHGlobal(plainTextBlob.pbData);
				}
				bool flag7 = IntPtr.Zero != entropyBlob.pbData;
				if (flag7)
				{
					Marshal.FreeHGlobal(entropyBlob.pbData);
				}
			}
			catch (Exception ex3)
			{
				throw new Exception("Exception encrypting. " + ex3.Message);
			}
			byte[] cipherText = new byte[cipherTextBlob.cbData];
			Marshal.Copy(cipherTextBlob.pbData, cipherText, 0, cipherTextBlob.cbData);
			Marshal.FreeHGlobal(cipherTextBlob.pbData);
			return cipherText;
		}

		public byte[] Decrypt(byte[] cipherText, byte[] optionalEntropy, string DataDescription)
		{
			DataProtector.DATA_BLOB plainTextBlob = default(DataProtector.DATA_BLOB);
			DataProtector.DATA_BLOB cipherBlob = default(DataProtector.DATA_BLOB);
			DataProtector.CRYPTPROTECT_PROMPTSTRUCT prompt = default(DataProtector.CRYPTPROTECT_PROMPTSTRUCT);
			this.InitPromptstruct(ref prompt);
			try
			{
				try
				{
					int cipherTextSize = cipherText.Length;
					cipherBlob.pbData = Marshal.AllocHGlobal(cipherTextSize);
					bool flag = IntPtr.Zero == cipherBlob.pbData;
					if (flag)
					{
						throw new Exception("Unable to allocate cipherText buffer.");
					}
					cipherBlob.cbData = cipherTextSize;
					Marshal.Copy(cipherText, 0, cipherBlob.pbData, cipherBlob.cbData);
				}
				catch (Exception ex)
				{
					throw new Exception("Exception marshalling data. " + ex.Message);
				}
				DataProtector.DATA_BLOB entropyBlob = default(DataProtector.DATA_BLOB);
				bool flag2 = DataProtector.Store.USE_MACHINE_STORE == this.store;
				int dwFlags;
				if (flag2)
				{
					dwFlags = 5;
					bool flag3 = optionalEntropy == null;
					if (flag3)
					{
						optionalEntropy = new byte[0];
					}
					try
					{
						int bytesSize = optionalEntropy.Length;
						entropyBlob.pbData = Marshal.AllocHGlobal(bytesSize);
						bool flag4 = IntPtr.Zero == entropyBlob.pbData;
						if (flag4)
						{
							throw new Exception("Unable to allocate entropy buffer.");
						}
						entropyBlob.cbData = bytesSize;
						Marshal.Copy(optionalEntropy, 0, entropyBlob.pbData, bytesSize);
					}
					catch (Exception ex2)
					{
						throw new Exception("Exception entropy marshalling data. " + ex2.Message);
					}
				}
				else
				{
					dwFlags = 1;
				}
				bool retVal = DataProtector.CryptUnprotectData(ref cipherBlob, DataDescription, ref entropyBlob, IntPtr.Zero, ref prompt, dwFlags, ref plainTextBlob);
				bool flag5 = !retVal;
				if (flag5)
				{
					throw new Exception("Decryption failed. " + DataProtector.GetErrorMessage(Marshal.GetLastWin32Error()));
				}
				bool flag6 = IntPtr.Zero != cipherBlob.pbData;
				if (flag6)
				{
					Marshal.FreeHGlobal(cipherBlob.pbData);
				}
				bool flag7 = IntPtr.Zero != entropyBlob.pbData;
				if (flag7)
				{
					Marshal.FreeHGlobal(entropyBlob.pbData);
				}
			}
			catch (Exception ex3)
			{
				throw new Exception("Exception decrypting. " + ex3.Message);
			}
			byte[] plainText = new byte[plainTextBlob.cbData];
			Marshal.Copy(plainTextBlob.pbData, plainText, 0, plainTextBlob.cbData);
			Marshal.FreeHGlobal(plainTextBlob.pbData);
			return plainText;
		}

		private void InitPromptstruct(ref DataProtector.CRYPTPROTECT_PROMPTSTRUCT ps)
		{
			ps.cbSize = Marshal.SizeOf(typeof(DataProtector.CRYPTPROTECT_PROMPTSTRUCT));
			ps.dwPromptFlags = 0;
			ps.hwndApp = DataProtector.NullPtr;
			ps.szPrompt = null;
		}

		private unsafe static string GetErrorMessage(int errorCode)
		{
			int FORMAT_MESSAGE_ALLOCATE_BUFFER = 256;
			int FORMAT_MESSAGE_IGNORE_INSERTS = 512;
			int FORMAT_MESSAGE_FROM_SYSTEM = 4096;
			int messageSize = 255;
			string lpMsgBuf = "";
			int dwFlags = FORMAT_MESSAGE_ALLOCATE_BUFFER | FORMAT_MESSAGE_FROM_SYSTEM | FORMAT_MESSAGE_IGNORE_INSERTS;
			IntPtr ptrlpSource = IntPtr.Zero;
			IntPtr prtArguments = IntPtr.Zero;
			int retVal = DataProtector.FormatMessage(dwFlags, ref ptrlpSource, errorCode, 0, ref lpMsgBuf, messageSize, &prtArguments);
			bool flag = retVal == 0;
			if (flag)
			{
				throw new Exception("Failed to format message for error code " + errorCode.ToString() + ". ");
			}
			return lpMsgBuf;
		}

		private static IntPtr NullPtr = (IntPtr)0;

		private const int CRYPTPROTECT_UI_FORBIDDEN = 1;

		private const int CRYPTPROTECT_LOCAL_MACHINE = 4;

		private DataProtector.Store store;

		[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
		internal struct DATA_BLOB
		{
			public int cbData;

			public IntPtr pbData;
		}

		[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
		internal struct CRYPTPROTECT_PROMPTSTRUCT
		{
			public int cbSize;

			public int dwPromptFlags;

			public IntPtr hwndApp;

			public string szPrompt;
		}

		public enum Store
		{
			USE_MACHINE_STORE = 1,
			USE_USER_STORE
		}
	}
}
