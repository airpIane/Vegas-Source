using System;
using System.Diagnostics;

// Token: 0x0200003F RID: 63
[Serializable]
internal struct 5CEF7019
{
	// Token: 0x06000183 RID: 387 RVA: 0x000B475A File Offset: 0x000B475A
	[Conditional("DEBUG")]
	private void 034C28D3()
	{
		if (this.0F335050 != null)
		{
			5CEF7019.12DE5532(this.0F335050);
		}
	}

	// Token: 0x1700001D RID: 29
	// (get) Token: 0x06000184 RID: 388 RVA: 0x000B4772 File Offset: 0x000B4772
	private static 5CEF7019 0F554F1C
	{
		get
		{
			return 5CEF7019.46403E78;
		}
	}

	// Token: 0x1700001E RID: 30
	// (get) Token: 0x06000185 RID: 389 RVA: 0x000B4779 File Offset: 0x000B4779
	private bool 24A426A2
	{
		get
		{
			if (this.0F335050 != null)
			{
				return (this.0F335050[0] & 1U) == 0U;
			}
			return (this.75B043B0 & 1) == 0;
		}
	}

	// Token: 0x1700001F RID: 31
	// (get) Token: 0x06000186 RID: 390 RVA: 0x000B479C File Offset: 0x000B479C
	private int 155B35C6
	{
		get
		{
			return (this.75B043B0 >> 31) - (-this.75B043B0 >> 31);
		}
	}

	// Token: 0x06000187 RID: 391 RVA: 0x000B47B2 File Offset: 0x000B47B2
	public bool B0ABA06B(object 634E2713)
	{
		return 634E2713 is 5CEF7019 && this.Equals((5CEF7019)634E2713);
	}

	// Token: 0x06000188 RID: 392 RVA: 0x000D10F0 File Offset: 0x000D10F0
	public int 5ECD51F9()
	{
		if (this.0F335050 == null)
		{
			return this.75B043B0;
		}
		int num = this.75B043B0;
		int num2 = 5CEF7019.12DE5532(this.0F335050);
		while (--num2 >= 0)
		{
			num = 42C923AD.41765F25(num, (int)this.0F335050[num2]);
		}
		return num;
	}

	// Token: 0x06000189 RID: 393 RVA: 0x000D113C File Offset: 0x000D113C
	private int 183352FD(5CEF7019 16D8007B)
	{
		if ((this.75B043B0 ^ 16D8007B.75B043B0) < 0)
		{
			if (this.75B043B0 >= 0)
			{
				return 1;
			}
			return -1;
		}
		else if (this.0F335050 == null)
		{
			if (16D8007B.0F335050 != null)
			{
				return -16D8007B.75B043B0;
			}
			if (this.75B043B0 < 16D8007B.75B043B0)
			{
				return -1;
			}
			if (this.75B043B0 <= 16D8007B.75B043B0)
			{
				return 0;
			}
			return 1;
		}
		else
		{
			int num;
			int num2;
			if (16D8007B.0F335050 == null || (num = 5CEF7019.12DE5532(this.0F335050)) > (num2 = 5CEF7019.12DE5532(16D8007B.0F335050)))
			{
				return this.75B043B0;
			}
			if (num < num2)
			{
				return -this.75B043B0;
			}
			int num3 = 5CEF7019.55BD3AE9(this.0F335050, 16D8007B.0F335050, num);
			if (num3 == 0)
			{
				return 0;
			}
			if (this.0F335050[num3 - 1] >= 16D8007B.0F335050[num3 - 1])
			{
				return this.75B043B0;
			}
			return -this.75B043B0;
		}
	}

	// Token: 0x0600018A RID: 394 RVA: 0x000D1214 File Offset: 0x000D1214
	internal byte[] 3AAB082F()
	{
		if (this.0F335050 == null && this.75B043B0 == 0)
		{
			return new byte[1];
		}
		uint[] array;
		byte b;
		if (this.0F335050 == null)
		{
			array = new uint[]
			{
				(uint)this.75B043B0
			};
			b = ((this.75B043B0 < 0) ? byte.MaxValue : 0);
		}
		else if (this.75B043B0 == -1)
		{
			array = (uint[])this.0F335050.Clone();
			42C923AD.7A8B48FD(array);
			b = byte.MaxValue;
		}
		else
		{
			array = this.0F335050;
			b = 0;
		}
		byte[] array2 = new byte[checked(4 * array.Length)];
		int num = 0;
		foreach (uint num2 in array)
		{
			for (int j = 0; j < 4; j++)
			{
				array2[num++] = (byte)(num2 & 255U);
				num2 >>= 8;
			}
		}
		if ((array2[array2.Length - 1] & 128) == (b & 128))
		{
			return array2;
		}
		byte[] array4 = new byte[array2.Length + 1];
		Array.Copy(array2, array4, array2.Length);
		array4[array4.Length - 1] = b;
		return array4;
	}

	// Token: 0x0600018B RID: 395 RVA: 0x000B47D5 File Offset: 0x000B47D5
	private 5CEF7019(int 1A2E04F3)
	{
		if (1A2E04F3 == -2147483648)
		{
			this = 5CEF7019.15771239;
			return;
		}
		this.75B043B0 = 1A2E04F3;
		this.0F335050 = null;
	}

	// Token: 0x0600018C RID: 396 RVA: 0x000D1324 File Offset: 0x000D1324
	internal 5CEF7019(byte[] 29F8241C)
	{
		if (29F8241C == null)
		{
			throw new ArgumentNullException("value");
		}
		int num = 29F8241C.Length;
		bool flag = num > 0 && (29F8241C[num - 1] & 128) == 128;
		while (num > 0 && 29F8241C[num - 1] == 0)
		{
			num--;
		}
		if (num == 0)
		{
			this.75B043B0 = 0;
			this.0F335050 = null;
			return;
		}
		if (num <= 4)
		{
			if (flag)
			{
				this.75B043B0 = -1;
			}
			else
			{
				this.75B043B0 = 0;
			}
			for (int i = num - 1; i >= 0; i--)
			{
				this.75B043B0 <<= 8;
				this.75B043B0 |= (int)29F8241C[i];
			}
			this.0F335050 = null;
			if (this.75B043B0 < 0 && !flag)
			{
				this.0F335050 = new uint[1];
				this.0F335050[0] = (uint)this.75B043B0;
				this.75B043B0 = 1;
			}
			if (this.75B043B0 == -2147483648)
			{
				this = 5CEF7019.15771239;
				return;
			}
		}
		else
		{
			int num2 = num % 4;
			int num3 = num / 4 + ((num2 == 0) ? 0 : 1);
			bool flag2 = true;
			uint[] array = new uint[num3];
			int j = 3;
			int k;
			for (k = 0; k < num3 - ((num2 == 0) ? 0 : 1); k++)
			{
				for (int l = 0; l < 4; l++)
				{
					if (29F8241C[j] != 0)
					{
						flag2 = false;
					}
					array[k] <<= 8;
					array[k] |= (uint)29F8241C[j];
					j--;
				}
				j += 8;
			}
			if (num2 != 0)
			{
				if (flag)
				{
					array[num3 - 1] = uint.MaxValue;
				}
				for (j = num - 1; j >= num - num2; j--)
				{
					if (29F8241C[j] != 0)
					{
						flag2 = false;
					}
					array[k] <<= 8;
					array[k] |= (uint)29F8241C[j];
				}
			}
			if (flag2)
			{
				this = 5CEF7019.1F544CE6;
				return;
			}
			if (flag)
			{
				42C923AD.7A8B48FD(array);
				int num4 = array.Length;
				while (num4 > 0 && array[num4 - 1] == 0U)
				{
					num4--;
				}
				if (num4 == 1 && array[0] > 0U)
				{
					if (array[0] == 1U)
					{
						this = 5CEF7019.0DAF0107;
						return;
					}
					if (array[0] == 2147483648U)
					{
						this = 5CEF7019.15771239;
						return;
					}
					this.75B043B0 = (int)(uint.MaxValue * array[0]);
					this.0F335050 = null;
					return;
				}
				else
				{
					if (num4 != array.Length)
					{
						this.75B043B0 = -1;
						this.0F335050 = new uint[num4];
						Array.Copy(array, this.0F335050, num4);
						return;
					}
					this.75B043B0 = -1;
					this.0F335050 = array;
					return;
				}
			}
			else
			{
				this.75B043B0 = 1;
				this.0F335050 = array;
			}
		}
	}

	// Token: 0x0600018D RID: 397 RVA: 0x000B47F9 File Offset: 0x000B47F9
	internal 5CEF7019(int 6E87476C, uint[] 2C3F2775)
	{
		this.75B043B0 = 6E87476C;
		this.0F335050 = 2C3F2775;
	}

	// Token: 0x0600018E RID: 398 RVA: 0x000B4809 File Offset: 0x000B4809
	private static void 6BEA0E14(ref 39F449BA 1035007B, ref 39F449BA 43024897, ref 39F449BA 7ACF5BEF, ref 39F449BA 4F2977D7)
	{
		42C923AD.5BD54B31<39F449BA>(ref 1035007B, ref 4F2977D7);
		1035007B.7BC90251(ref 4F2977D7, ref 43024897);
		1035007B.47094970(ref 7ACF5BEF);
	}

	// Token: 0x0600018F RID: 399 RVA: 0x000B4821 File Offset: 0x000B4821
	private static void 68F257F2(ref 39F449BA 642863D6, ref 39F449BA 6FD95FDC, ref 39F449BA 741C6935)
	{
		42C923AD.5BD54B31<39F449BA>(ref 642863D6, ref 741C6935);
		642863D6.7BC90251(ref 741C6935, ref 741C6935);
		642863D6.47094970(ref 6FD95FDC);
	}

	// Token: 0x06000190 RID: 400 RVA: 0x000B4839 File Offset: 0x000B4839
	private static void 011A045D(uint 185133F6, ref 39F449BA 298964FC, ref 39F449BA 3D1238B1, ref 39F449BA 109B6538, ref 39F449BA 5C433AAB)
	{
		while (185133F6 != 0U)
		{
			if ((185133F6 & 1U) == 1U)
			{
				5CEF7019.6BEA0E14(ref 298964FC, ref 3D1238B1, ref 109B6538, ref 5C433AAB);
			}
			if (185133F6 == 1U)
			{
				break;
			}
			5CEF7019.68F257F2(ref 3D1238B1, ref 109B6538, ref 5C433AAB);
			185133F6 >>= 1;
		}
	}

	// Token: 0x06000191 RID: 401 RVA: 0x000D15AC File Offset: 0x000D15AC
	private static void 1ACF6179(uint 2E4D5A8B, ref 39F449BA 655367A2, ref 39F449BA 452C59D9, ref 39F449BA 43E03DD1, ref 39F449BA 575E2645)
	{
		for (int i = 0; i < 32; i++)
		{
			if ((2E4D5A8B & 1U) == 1U)
			{
				5CEF7019.6BEA0E14(ref 655367A2, ref 452C59D9, ref 43E03DD1, ref 575E2645);
			}
			5CEF7019.68F257F2(ref 452C59D9, ref 43E03DD1, ref 575E2645);
			2E4D5A8B >>= 1;
		}
	}

	// Token: 0x06000192 RID: 402 RVA: 0x000D15E4 File Offset: 0x000D15E4
	internal static 5CEF7019 6F6C5FEC(5CEF7019 11D8057D, 5CEF7019 09E4175C, 5CEF7019 34DE08CB)
	{
		if (09E4175C.155B35C6 < 0)
		{
			throw new ArgumentOutOfRangeException("exponent", "ArgumentOutOfRange must be non negative");
		}
		int num = 1;
		int num2 = 1;
		int num3 = 1;
		bool flag = 09E4175C.24A426A2;
		39F449BA 39F449BA = new 39F449BA(5CEF7019.0F554F1C, ref num);
		39F449BA 39F449BA2 = new 39F449BA(11D8057D, ref num2);
		39F449BA 39F449BA3 = new 39F449BA(34DE08CB, ref num3);
		39F449BA 39F449BA4 = new 39F449BA(39F449BA2.57C9105B);
		39F449BA.47094970(ref 39F449BA3);
		if (09E4175C.0F335050 == null)
		{
			5CEF7019.011A045D((uint)09E4175C.75B043B0, ref 39F449BA, ref 39F449BA2, ref 39F449BA3, ref 39F449BA4);
		}
		else
		{
			int num4 = 5CEF7019.12DE5532(09E4175C.0F335050);
			for (int i = 0; i < num4 - 1; i++)
			{
				5CEF7019.1ACF6179(09E4175C.0F335050[i], ref 39F449BA, ref 39F449BA2, ref 39F449BA3, ref 39F449BA4);
			}
			5CEF7019.011A045D(09E4175C.0F335050[num4 - 1], ref 39F449BA, ref 39F449BA2, ref 39F449BA3, ref 39F449BA4);
		}
		return 39F449BA.30890FAB((11D8057D.75B043B0 > 0) ? 1 : (flag ? 1 : -1));
	}

	// Token: 0x06000193 RID: 403 RVA: 0x000B4862 File Offset: 0x000B4862
	public static bool 3ED252A2(5CEF7019 4D1C2F8F, 5CEF7019 6AEF7DD4)
	{
		return 4D1C2F8F.183352FD(6AEF7DD4) < 0;
	}

	// Token: 0x06000194 RID: 404 RVA: 0x000B486F File Offset: 0x000B486F
	public static bool 009B09A2(5CEF7019 6E8A76E7, 5CEF7019 0A4556FB)
	{
		return 6E8A76E7.183352FD(0A4556FB) <= 0;
	}

	// Token: 0x06000195 RID: 405 RVA: 0x000B487F File Offset: 0x000B487F
	public static bool 08280877(5CEF7019 77D76DF4, 5CEF7019 787B6D7F)
	{
		return 77D76DF4.183352FD(787B6D7F) > 0;
	}

	// Token: 0x06000196 RID: 406 RVA: 0x000B488C File Offset: 0x000B488C
	public static bool 79D65D01(5CEF7019 7F1A2D07, 5CEF7019 1CF33A4C)
	{
		return 7F1A2D07.183352FD(1CF33A4C) >= 0;
	}

	// Token: 0x06000197 RID: 407 RVA: 0x000B489C File Offset: 0x000B489C
	public static bool 231C01A6(5CEF7019 4C5703A1, 5CEF7019 52751117)
	{
		return 4C5703A1.Equals(52751117);
	}

	// Token: 0x06000198 RID: 408 RVA: 0x000B48B1 File Offset: 0x000B48B1
	public static bool 14664E3E(5CEF7019 78452C2A, 5CEF7019 1C1811A9)
	{
		return !78452C2A.Equals(1C1811A9);
	}

	// Token: 0x06000199 RID: 409 RVA: 0x000D16D8 File Offset: 0x000D16D8
	private static int 12DE5532(uint[] 685567E6)
	{
		int num = 685567E6.Length;
		if (685567E6[num - 1] != 0U)
		{
			return num;
		}
		return num - 1;
	}

	// Token: 0x17000020 RID: 32
	// (get) Token: 0x0600019A RID: 410 RVA: 0x000B48C9 File Offset: 0x000B48C9
	internal int 6EAF15A5
	{
		get
		{
			return this.75B043B0;
		}
	}

	// Token: 0x17000021 RID: 33
	// (get) Token: 0x0600019B RID: 411 RVA: 0x000B48D1 File Offset: 0x000B48D1
	internal uint[] 0B200D48
	{
		get
		{
			return this.0F335050;
		}
	}

	// Token: 0x0600019C RID: 412 RVA: 0x000D16F8 File Offset: 0x000D16F8
	private static int 55BD3AE9(uint[] 2166437B, uint[] 4BEF1726, int 35BB0F84)
	{
		int num = 35BB0F84;
		while (--num >= 0)
		{
			if (2166437B[num] != 4BEF1726[num])
			{
				return num + 1;
			}
		}
		return 0;
	}

	// Token: 0x0400018A RID: 394
	private const uint 7EFF21BB = 2147483648U;

	// Token: 0x0400018B RID: 395
	private const int 6EEE0C4F = 32;

	// Token: 0x0400018C RID: 396
	private readonly int 75B043B0;

	// Token: 0x0400018D RID: 397
	private readonly uint[] 0F335050;

	// Token: 0x0400018E RID: 398
	private static readonly 5CEF7019 15771239 = new 5CEF7019(-1, new uint[]
	{
		2147483648U
	});

	// Token: 0x0400018F RID: 399
	private static readonly 5CEF7019 46403E78 = new 5CEF7019(1);

	// Token: 0x04000190 RID: 400
	private static readonly 5CEF7019 1F544CE6 = new 5CEF7019(0);

	// Token: 0x04000191 RID: 401
	private static readonly 5CEF7019 0DAF0107 = new 5CEF7019(-1);
}
