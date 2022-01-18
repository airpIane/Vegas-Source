using System;

// Token: 0x02000041 RID: 65
internal static class 42C923AD
{
	// Token: 0x060001B5 RID: 437 RVA: 0x000D2148 File Offset: 0x000D2148
	internal static void 7A8B48FD(uint[] 26375723)
	{
		int i = 0;
		uint num = 0U;
		while (i < 26375723.Length)
		{
			num = ~26375723[i] + 1U;
			26375723[i] = num;
			if (num != 0U)
			{
				i++;
				break;
			}
			i++;
		}
		if (num != 0U)
		{
			while (i < 26375723.Length)
			{
				26375723[i] = ~26375723[i];
				i++;
			}
			return;
		}
		26375723 = 42C923AD.657635D3(26375723, 26375723.Length + 1);
		26375723[26375723.Length - 1] = 1U;
	}

	// Token: 0x060001B6 RID: 438 RVA: 0x000D21A8 File Offset: 0x000D21A8
	private static uint[] 657635D3(uint[] 6E274E6F, int 1588409C)
	{
		if (6E274E6F.Length == 1588409C)
		{
			return 6E274E6F;
		}
		uint[] array = new uint[1588409C];
		int num = Math.Min(6E274E6F.Length, 1588409C);
		for (int i = 0; i < num; i++)
		{
			array[i] = 6E274E6F[i];
		}
		return array;
	}

	// Token: 0x060001B7 RID: 439 RVA: 0x000D21E4 File Offset: 0x000D21E4
	internal static void 5BD54B31<T>(ref T 55B24D29, ref T 158E7735)
	{
		T t = 55B24D29;
		55B24D29 = 158E7735;
		158E7735 = t;
	}

	// Token: 0x060001B8 RID: 440 RVA: 0x000B49AD File Offset: 0x000B49AD
	internal static ulong 24E67C9A(uint 0C292043, uint 290245D0)
	{
		return (ulong)0C292043 << 32 | (ulong)290245D0;
	}

	// Token: 0x060001B9 RID: 441 RVA: 0x000B49B7 File Offset: 0x000B49B7
	internal static uint 727357BC(ulong 77B200DD)
	{
		return (uint)77B200DD;
	}

	// Token: 0x060001BA RID: 442 RVA: 0x000B49BB File Offset: 0x000B49BB
	internal static uint 5A52666D(ulong 21D87EA5)
	{
		return (uint)(21D87EA5 >> 32);
	}

	// Token: 0x060001BB RID: 443 RVA: 0x000B49C2 File Offset: 0x000B49C2
	private static uint 44F7257B(uint 0975240C, uint 071E5994)
	{
		return (0975240C << 7 | 0975240C >> 25) ^ 071E5994;
	}

	// Token: 0x060001BC RID: 444 RVA: 0x000B49CE File Offset: 0x000B49CE
	internal static int 41765F25(int 72A32BD1, int 12260CB9)
	{
		return (int)42C923AD.44F7257B((uint)72A32BD1, (uint)12260CB9);
	}

	// Token: 0x060001BD RID: 445 RVA: 0x000D220C File Offset: 0x000D220C
	internal static int 72A26E3A(uint 2AB72448)
	{
		if (2AB72448 == 0U)
		{
			return 32;
		}
		int num = 0;
		if ((2AB72448 & 4294901760U) == 0U)
		{
			num += 16;
			2AB72448 <<= 16;
		}
		if ((2AB72448 & 4278190080U) == 0U)
		{
			num += 8;
			2AB72448 <<= 8;
		}
		if ((2AB72448 & 4026531840U) == 0U)
		{
			num += 4;
			2AB72448 <<= 4;
		}
		if ((2AB72448 & 3221225472U) == 0U)
		{
			num += 2;
			2AB72448 <<= 2;
		}
		if ((2AB72448 & 2147483648U) == 0U)
		{
			num++;
		}
		return num;
	}

	// Token: 0x04000197 RID: 407
	private const int 06E75342 = 32;
}
