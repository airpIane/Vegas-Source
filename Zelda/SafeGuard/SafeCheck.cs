using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace SafeGuard
{
	// Token: 0x0200000B RID: 11
	internal class SafeCheck
	{
		// Token: 0x06000030 RID: 48 RVA: 0x000B4F68 File Offset: 0x000B4F68
		internal static void Md5Check()
		{
			bool flag = SafeCheck.ComputeHash(AppDomain.CurrentDomain.BaseDirectory + "SafeGuard.dll", "MD5") != SafeCheck.CurrentDllMD5;
			if (flag)
			{
				MessageBox.Show("Invalid SafeGuard.dll. Exiting Program.", SafeGuardTitle.safeguardtitle);
				Environment.Exit(2134);
			}
			bool flag2 = SafeCheck.ComputeHash(AppDomain.CurrentDomain.BaseDirectory + "SafeGuard.dll", "SHA1") != SafeCheck.CurrentDllSHA1;
			if (flag2)
			{
				MessageBox.Show("Invalid SafeGuard.dll. Exiting Program.", SafeGuardTitle.safeguardtitle);
				Environment.Exit(2134);
			}
			bool flag3 = SafeCheck.ComputeHash(AppDomain.CurrentDomain.BaseDirectory + "SafeGuard.dll", "SHA256") != SafeCheck.CurrentDllSHA256;
			if (flag3)
			{
				MessageBox.Show("Invalid SafeGuard.dll. Exiting Program.", SafeGuardTitle.safeguardtitle);
				Environment.Exit(2134);
			}
			bool flag4 = SafeCheck.ComputeHash(AppDomain.CurrentDomain.BaseDirectory + "SafeGuard.dll", "SIZE") != SafeCheck.CurrentDllSize;
			if (flag4)
			{
				MessageBox.Show("Invalid SafeGuard.dll. Exiting Program.", SafeGuardTitle.safeguardtitle);
				Environment.Exit(2134);
			}
			bool flag5 = SafeCheck.ComputeHash(AppDomain.CurrentDomain.BaseDirectory + "Newtonsoft.Json.dll", "MD5") != SafeCheck.CurrentNewtonSoftMD5;
			if (flag5)
			{
				MessageBox.Show("Invalid Newtonsoft.Json.dll. Exiting Program.", SafeGuardTitle.safeguardtitle);
				Environment.Exit(2134);
			}
			bool flag6 = SafeCheck.ComputeHash(AppDomain.CurrentDomain.BaseDirectory + "Newtonsoft.Json.dll", "SHA1") != SafeCheck.CurrentNewtonSoftSHA1;
			if (flag6)
			{
				MessageBox.Show("Invalid Newtonsoft.Json.dll. Exiting Program.", SafeGuardTitle.safeguardtitle);
				Environment.Exit(2134);
			}
			bool flag7 = SafeCheck.ComputeHash(AppDomain.CurrentDomain.BaseDirectory + "Newtonsoft.Json.dll", "SHA256") != SafeCheck.CurrentNewtonSoftSHA256;
			if (flag7)
			{
				MessageBox.Show("Invalid Newtonsoft.Json.dll. Exiting Program.", SafeGuardTitle.safeguardtitle);
				Environment.Exit(2134);
			}
			bool flag8 = SafeCheck.ComputeHash(AppDomain.CurrentDomain.BaseDirectory + "Newtonsoft.Json.dll", "SIZE") != SafeCheck.CurrentNewtonSoftSize;
			if (flag8)
			{
				MessageBox.Show("Invalid Newtonsoft.Json.dll. Exiting Program.", SafeGuardTitle.safeguardtitle);
				Environment.Exit(2134);
			}
		}

		// Token: 0x06000031 RID: 49 RVA: 0x000B51C8 File Offset: 0x000B51C8
		internal static string ComputeHash(string s, string hashtype)
		{
			if (!(hashtype == "MD5"))
			{
				if (!(hashtype == "SHA1"))
				{
					if (hashtype == "SHA256")
					{
						goto IL_15F;
					}
					if (!(hashtype == "SIZE"))
					{
						goto IL_224;
					}
					goto IL_1E9;
				}
			}
			else
			{
				using (MD5 md = MD5.Create())
				{
					try
					{
						using (FileStream fileStream = File.OpenRead(s))
						{
							byte[] array = md.ComputeHash(fileStream);
							StringBuilder stringBuilder = new StringBuilder();
							for (int i = 0; i < array.Length; i++)
							{
								stringBuilder.Append(array[i].ToString("X2"));
							}
							return stringBuilder.ToString();
						}
					}
					catch
					{
						return "MD5 Error";
					}
				}
			}
			using (SHA1 sha = SHA1.Create())
			{
				try
				{
					using (FileStream fileStream2 = File.OpenRead(s))
					{
						byte[] array2 = sha.ComputeHash(fileStream2);
						StringBuilder stringBuilder2 = new StringBuilder();
						for (int j = 0; j < array2.Length; j++)
						{
							stringBuilder2.Append(array2[j].ToString("X2"));
						}
						return stringBuilder2.ToString();
					}
				}
				catch
				{
					return "SHA1 Error";
				}
			}
			IL_15F:
			using (SHA256 sha2 = SHA256.Create())
			{
				try
				{
					using (FileStream fileStream3 = File.OpenRead(s))
					{
						byte[] array3 = sha2.ComputeHash(fileStream3);
						StringBuilder stringBuilder3 = new StringBuilder();
						for (int k = 0; k < array3.Length; k++)
						{
							stringBuilder3.Append(array3[k].ToString("X2"));
						}
						return stringBuilder3.ToString();
					}
				}
				catch
				{
					return "SHA256 Error";
				}
			}
			IL_1E9:
			try
			{
				using (File.OpenRead(s))
				{
					return new FileInfo(s).Length.ToString();
				}
			}
			catch
			{
				return "File Size Error";
			}
			IL_224:
			return "Invalid Type";
		}

		// Token: 0x0400001C RID: 28
		internal static string CurrentDllMD5 = "AA88E613FFA57DD5361032348DC4AF9A";

		// Token: 0x0400001D RID: 29
		internal static string CurrentDllSHA1 = "F4652E18B2B5CA43B45580F71AC7A298AA5D831E";

		// Token: 0x0400001E RID: 30
		internal static string CurrentDllSHA256 = "5DF82BA08026D3C13F5D04999C6738D90A3CF68215F88F34D9C27CABAA06E3B4";

		// Token: 0x0400001F RID: 31
		internal static string CurrentDllSize = "5838336";

		// Token: 0x04000020 RID: 32
		internal static string CurrentNewtonSoftMD5 = "6815034209687816D8CF401877EC8133";

		// Token: 0x04000021 RID: 33
		internal static string CurrentNewtonSoftSHA1 = "1248142EB45EED3BEB0D9A2D3B8BED5FE2569B10";

		// Token: 0x04000022 RID: 34
		internal static string CurrentNewtonSoftSHA256 = "7F912B28A07C226E0BE3ACFB2F57F050538ABA0100FA1F0BF2C39F1A1F1DA814";

		// Token: 0x04000023 RID: 35
		internal static string CurrentNewtonSoftSize = "700336";
	}
}
