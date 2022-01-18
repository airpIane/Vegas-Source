using System;
using System.Runtime.InteropServices;
using System.Text;

// Token: 0x0200003E RID: 62
internal static class 079D22D6
{
	// Token: 0x06000173 RID: 371
	[DllImport("kernel32", CharSet = CharSet.Auto, EntryPoint = "CreateFile", SetLastError = true)]
	public static extern IntPtr 26E00E52(string 326342CB, int 28272109, int 35724D3B, IntPtr 50454BA8, int 60ED0C02, int 06872E5D, IntPtr 10963CEC);

	// Token: 0x06000174 RID: 372
	[DllImport("kernel32", CharSet = CharSet.Auto, EntryPoint = "CreateFileMapping", SetLastError = true)]
	public static extern IntPtr 5F3C70EC(IntPtr 5E58687D, IntPtr 19BF0613, 079D22D6.5DC1213C 333B3E0B, int 6CB021B0, int 7554422C, string 65497C32);

	// Token: 0x06000175 RID: 373
	[DllImport("kernel32", EntryPoint = "FlushViewOfFile", SetLastError = true)]
	public static extern bool 200251FD(IntPtr 1F2A05DB, int 0EE9788D);

	// Token: 0x06000176 RID: 374
	[DllImport("kernel32", EntryPoint = "MapViewOfFile", SetLastError = true)]
	public static extern IntPtr 7B4D0ACB(IntPtr 38AB1EDE, 079D22D6.70F72B27 5F8E4ED5, int 0B711AF9, int 2E3D390B, IntPtr 6C433361);

	// Token: 0x06000177 RID: 375
	[DllImport("kernel32", CharSet = CharSet.Auto, EntryPoint = "OpenFileMapping", SetLastError = true)]
	public static extern IntPtr 1E742FBA(int 68A46237, bool 3DDF5473, string 4BFE4BB6);

	// Token: 0x06000178 RID: 376
	[DllImport("kernel32", EntryPoint = "UnmapViewOfFile", SetLastError = true)]
	public static extern bool 1F160FAD(IntPtr 10F64DA6);

	// Token: 0x06000179 RID: 377
	[DllImport("kernel32", EntryPoint = "CloseHandle", SetLastError = true)]
	public static extern bool 495763BC(IntPtr 25371CD6);

	// Token: 0x0600017A RID: 378
	[DllImport("kernel32", EntryPoint = "GetFileSize", SetLastError = true)]
	public static extern uint 41505979(IntPtr 05793DBF, IntPtr 5C5010A0);

	// Token: 0x0600017B RID: 379
	[DllImport("kernel32", EntryPoint = "VirtualAlloc", SetLastError = true)]
	public static extern IntPtr 18C43445(IntPtr 51130F44, UIntPtr 4F0675F5, 079D22D6.46BD2D3D 0EF71932, 079D22D6.5DC1213C 3EAE75DD);

	// Token: 0x0600017C RID: 380
	[DllImport("kernel32", EntryPoint = "VirtualFree")]
	public static extern bool 43896696(IntPtr 3CDB37F2, uint 5564141B, uint 0944728A);

	// Token: 0x0600017D RID: 381
	[DllImport("kernel32", EntryPoint = "VirtualProtect", SetLastError = true)]
	public static extern bool 68544A17(IntPtr 06641E05, UIntPtr 57050011, 079D22D6.5DC1213C 4DB87B92, out 079D22D6.5DC1213C 1A024165);

	// Token: 0x0600017E RID: 382
	[DllImport("kernel32", EntryPoint = "GetVolumeInformation")]
	public static extern bool 38C71601(string 131416B5, StringBuilder 713A0320, uint 33FE4CE9, ref uint 22051BC7, ref uint 79311F0D, ref uint 58993A45, StringBuilder 7B441373, uint 51D37898);

	// Token: 0x0600017F RID: 383
	[DllImport("kernel32", EntryPoint = "IsDebuggerPresent")]
	public static extern bool 12E66D2C();

	// Token: 0x06000180 RID: 384
	[DllImport("kernel32", EntryPoint = "CheckRemoteDebuggerPresent")]
	public static extern bool 7F6E699D();

	// Token: 0x06000181 RID: 385
	[DllImport("ntdll", EntryPoint = "NtQueryInformationProcess")]
	public static extern int 7B9C79A6(IntPtr 3A877E34, int 523506CB, byte[] 6E2E23C6, uint 0E2B0224, out uint 4EB169D0);

	// Token: 0x04000182 RID: 386
	public const int 67924C9E = -2147483648;

	// Token: 0x04000183 RID: 387
	public const int 5F720A3C = 3;

	// Token: 0x04000184 RID: 388
	public const int 247A7899 = 128;

	// Token: 0x04000185 RID: 389
	public const int 7BA17C8E = 1;

	// Token: 0x04000186 RID: 390
	public const int 032B1CD1 = 2;

	// Token: 0x04000187 RID: 391
	public static readonly IntPtr 2A5C0975 = new IntPtr(-1);

	// Token: 0x04000188 RID: 392
	public static readonly IntPtr 4F67248D = IntPtr.Zero;

	// Token: 0x04000189 RID: 393
	public static readonly IntPtr 7E1B3CA0 = new IntPtr(-1);

	// Token: 0x02000070 RID: 112
	public enum 46BD2D3D : uint
	{
		// Token: 0x04000203 RID: 515
		14947DEC = 4096U,
		// Token: 0x04000204 RID: 516
		390C715F = 8192U
	}

	// Token: 0x02000071 RID: 113
	public enum 5DC1213C : uint
	{
		// Token: 0x04000206 RID: 518
		6FD03219 = 1U,
		// Token: 0x04000207 RID: 519
		7F5D5868,
		// Token: 0x04000208 RID: 520
		533237C7 = 4U,
		// Token: 0x04000209 RID: 521
		17216DF6 = 8U,
		// Token: 0x0400020A RID: 522
		763A34D3 = 16U,
		// Token: 0x0400020B RID: 523
		39CB53CF = 32U,
		// Token: 0x0400020C RID: 524
		096C2249 = 64U,
		// Token: 0x0400020D RID: 525
		1C87497D = 256U
	}

	// Token: 0x02000072 RID: 114
	public enum 70F72B27 : uint
	{
		// Token: 0x0400020F RID: 527
		6F803C12 = 1U,
		// Token: 0x04000210 RID: 528
		279D696B,
		// Token: 0x04000211 RID: 529
		6E213B48 = 4U,
		// Token: 0x04000212 RID: 530
		54ED0BE6 = 31U
	}

	// Token: 0x02000073 RID: 115
	public enum 05B27CD6 : uint
	{
		// Token: 0x04000214 RID: 532
		2D47470B = 536870912U,
		// Token: 0x04000215 RID: 533
		4A8B02D7 = 1073741824U,
		// Token: 0x04000216 RID: 534
		31F97B2C = 2147483648U
	}

	// Token: 0x02000074 RID: 116
	public enum 3FBC65C6
	{
		// Token: 0x04000218 RID: 536
		4F1A2FA9 = 1,
		// Token: 0x04000219 RID: 537
		64837F10,
		// Token: 0x0400021A RID: 538
		0E0C675F = 4,
		// Token: 0x0400021B RID: 539
		22005201 = 8,
		// Token: 0x0400021C RID: 540
		474228E7 = 16,
		// Token: 0x0400021D RID: 541
		0C2F2462 = 32,
		// Token: 0x0400021E RID: 542
		459854BA = 512,
		// Token: 0x0400021F RID: 543
		7E742D93 = 256,
		// Token: 0x04000220 RID: 544
		463D495E = 768,
		// Token: 0x04000221 RID: 545
		5B110D64 = 131097,
		// Token: 0x04000222 RID: 546
		56145B38 = 131078,
		// Token: 0x04000223 RID: 547
		73A42286 = 131097,
		// Token: 0x04000224 RID: 548
		1E5A7EA2 = 983103
	}

	// Token: 0x02000075 RID: 117
	internal static class 5AF12540
	{
		// Token: 0x04000225 RID: 549
		public static UIntPtr 648A583D = new UIntPtr(2147483650U);

		// Token: 0x04000226 RID: 550
		public static UIntPtr 03E25A63 = new UIntPtr(2147483649U);
	}

	// Token: 0x02000076 RID: 118
	public static class 417D2788
	{
		// Token: 0x06000368 RID: 872
		[DllImport("advapi32", EntryPoint = "RegOpenKeyEx")]
		private static extern uint 51CC7280(UIntPtr 74672F50, string 788B6523, uint 63F10174, int 64142FEE, out UIntPtr 41A27B6B);

		// Token: 0x06000369 RID: 873
		[DllImport("advapi32", EntryPoint = "RegCloseKey")]
		private static extern uint 53D63FB2(UIntPtr 55527604);

		// Token: 0x0600036A RID: 874
		[DllImport("advapi32", EntryPoint = "RegQueryValueEx")]
		private static extern int 7DF46958(UIntPtr 7C2C16AA, string 4F3C2094, int 41D04B01, ref uint 22AC541F, StringBuilder 1FDC4016, ref uint 2A064D8A);

		// Token: 0x0600036B RID: 875
		[DllImport("advapi32", EntryPoint = "RegQueryInfoKey")]
		private static extern uint 719D02AD(UIntPtr 3B723312, StringBuilder 681B1572, ref uint 078A649A, IntPtr 0E4D7DBF, IntPtr 1C3A2301, IntPtr 2DF31D7C, IntPtr 133644BC, IntPtr 18FF3EE6, IntPtr 0D932716, IntPtr 35DE73C2, IntPtr 46D00525, out long 4A9F43F4);

		// Token: 0x0600036C RID: 876 RVA: 0x000B4B42 File Offset: 0x000B4B42
		public static string 76527994(UIntPtr 59163AFC, string 03582A4E, string 16BF4922)
		{
			return 079D22D6.417D2788.41452CEE(59163AFC, 03582A4E, 079D22D6.3FBC65C6.7E742D93, 16BF4922);
		}

		// Token: 0x0600036D RID: 877 RVA: 0x000B4B51 File Offset: 0x000B4B51
		public static bool 1D2A1284(UIntPtr 37C553A6, string 1D162C43, ref DateTime 3433542B)
		{
			return 079D22D6.417D2788.199578B7(37C553A6, 1D162C43, 079D22D6.3FBC65C6.7E742D93, ref 3433542B);
		}

		// Token: 0x0600036E RID: 878 RVA: 0x000D7ECC File Offset: 0x000D7ECC
		public static bool 199578B7(UIntPtr 045D5D26, string 099C46F9, 079D22D6.3FBC65C6 51150CDF, ref DateTime 29140BEA)
		{
			UIntPtr zero = UIntPtr.Zero;
			bool result;
			try
			{
				uint num = 079D22D6.417D2788.51CC7280(045D5D26, 099C46F9, 0U, (int)(079D22D6.3FBC65C6.4F1A2FA9 | 51150CDF), out zero);
				if (num != 0U)
				{
					result = false;
				}
				else
				{
					uint num2 = 0U;
					long fileTime;
					num = 079D22D6.417D2788.719D02AD(zero, null, ref num2, IntPtr.Zero, IntPtr.Zero, IntPtr.Zero, IntPtr.Zero, IntPtr.Zero, IntPtr.Zero, IntPtr.Zero, IntPtr.Zero, out fileTime);
					if (num != 0U)
					{
						result = false;
					}
					else
					{
						29140BEA = DateTime.FromFileTime(fileTime);
						result = true;
					}
				}
			}
			finally
			{
				if (UIntPtr.Zero != zero)
				{
					079D22D6.417D2788.53D63FB2(zero);
				}
			}
			return result;
		}

		// Token: 0x0600036F RID: 879 RVA: 0x000D7F6C File Offset: 0x000D7F6C
		public static string 41452CEE(UIntPtr 0A797146, string 4E6317AF, 079D22D6.3FBC65C6 1A4C35A7, string 7DF40A20)
		{
			UIntPtr zero = UIntPtr.Zero;
			string result;
			try
			{
				uint num = 079D22D6.417D2788.51CC7280(0A797146, 4E6317AF, 0U, (int)(079D22D6.3FBC65C6.4F1A2FA9 | 1A4C35A7), out zero);
				if (num != 0U)
				{
					result = null;
				}
				else
				{
					uint num2 = 0U;
					uint capacity = 1024U;
					StringBuilder stringBuilder = new StringBuilder((int)capacity);
					079D22D6.417D2788.7DF46958(zero, 7DF40A20, 0, ref num2, stringBuilder, ref capacity);
					result = stringBuilder.ToString();
				}
			}
			finally
			{
				if (UIntPtr.Zero != zero)
				{
					079D22D6.417D2788.53D63FB2(zero);
				}
			}
			return result;
		}
	}
}
