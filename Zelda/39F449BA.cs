using System;
using System.Diagnostics;

// Token: 0x02000040 RID: 64
internal struct 39F449BA
{
	// Token: 0x0600019E RID: 414 RVA: 0x000B4915 File Offset: 0x000B4915
	[Conditional("DEBUG")]
	private void 0B791BB4(bool 35211C89)
	{
		int num = this.1D8B7CCF;
	}

	// Token: 0x0600019F RID: 415 RVA: 0x000B4920 File Offset: 0x000B4920
	internal 39F449BA(int 3ACB3846)
	{
		this.1D8B7CCF = 0;
		this.582C0544 = 0U;
		if (3ACB3846 > 1)
		{
			this.005F0817 = new uint[3ACB3846];
			this.4544126F = true;
			return;
		}
		this.005F0817 = null;
		this.4544126F = false;
	}

	// Token: 0x060001A0 RID: 416 RVA: 0x000D1720 File Offset: 0x000D1720
	internal 39F449BA(5CEF7019 75FE1D91, ref int 3B164278)
	{
		this.4544126F = false;
		this.005F0817 = 75FE1D91.0B200D48;
		int num = 75FE1D91.6EAF15A5;
		int num2 = num >> 31;
		3B164278 = (3B164278 ^ num2) - num2;
		if (this.005F0817 == null)
		{
			this.1D8B7CCF = 0;
			this.582C0544 = (uint)((num ^ num2) - num2);
			return;
		}
		this.1D8B7CCF = this.005F0817.Length - 1;
		this.582C0544 = this.005F0817[0];
		while (this.1D8B7CCF > 0 && this.005F0817[this.1D8B7CCF] == 0U)
		{
			this.1D8B7CCF--;
		}
	}

	// Token: 0x060001A1 RID: 417 RVA: 0x000D17B8 File Offset: 0x000D17B8
	internal 5CEF7019 30890FAB(int 766F7E6A)
	{
		uint[] 2C3F;
		this.0ED91B41(766F7E6A, out 766F7E6A, out 2C3F);
		return new 5CEF7019(766F7E6A, 2C3F);
	}

	// Token: 0x060001A2 RID: 418 RVA: 0x000D17D8 File Offset: 0x000D17D8
	private void 0ED91B41(int 344A3CE6, out int 294C029B, out uint[] 479B407F)
	{
		if (this.1D8B7CCF == 0)
		{
			if (this.582C0544 <= 2147483647U)
			{
				294C029B = 344A3CE6 * (int)this.582C0544;
				479B407F = null;
				return;
			}
			if (this.005F0817 == null)
			{
				this.005F0817 = new uint[]
				{
					this.582C0544
				};
			}
			else if (this.4544126F)
			{
				this.005F0817[0] = this.582C0544;
			}
			else if (this.005F0817[0] != this.582C0544)
			{
				this.005F0817 = new uint[]
				{
					this.582C0544
				};
			}
		}
		294C029B = 344A3CE6;
		int num = this.005F0817.Length - this.1D8B7CCF - 1;
		if (num <= 1)
		{
			if (num == 0 || this.005F0817[this.1D8B7CCF + 1] == 0U)
			{
				this.4544126F = false;
				479B407F = this.005F0817;
				return;
			}
			if (this.4544126F)
			{
				this.005F0817[this.1D8B7CCF + 1] = 0U;
				this.4544126F = false;
				479B407F = this.005F0817;
				return;
			}
		}
		479B407F = this.005F0817;
		Array.Resize<uint>(ref 479B407F, this.1D8B7CCF + 1);
		if (!this.4544126F)
		{
			this.005F0817 = 479B407F;
		}
	}

	// Token: 0x060001A3 RID: 419 RVA: 0x000B4956 File Offset: 0x000B4956
	private void 791F3374(uint 0E1A0CA7)
	{
		this.582C0544 = 0E1A0CA7;
		this.1D8B7CCF = 0;
	}

	// Token: 0x060001A4 RID: 420 RVA: 0x000D18F0 File Offset: 0x000D18F0
	private void 311778F9(ulong 6A5856EB)
	{
		uint num = 42C923AD.5A52666D(6A5856EB);
		if (num == 0U)
		{
			this.582C0544 = 42C923AD.727357BC(6A5856EB);
			this.1D8B7CCF = 0;
			return;
		}
		this.15D0773E(2);
		this.005F0817[0] = (uint)6A5856EB;
		this.005F0817[1] = num;
	}

	// Token: 0x17000022 RID: 34
	// (get) Token: 0x060001A5 RID: 421 RVA: 0x000B4966 File Offset: 0x000B4966
	internal int 57C9105B
	{
		get
		{
			return this.1D8B7CCF + 1;
		}
	}

	// Token: 0x060001A6 RID: 422 RVA: 0x000D1938 File Offset: 0x000D1938
	private void 04716BB1()
	{
		if (this.1D8B7CCF > 0 && this.005F0817[this.1D8B7CCF] == 0U)
		{
			this.582C0544 = this.005F0817[0];
			int num;
			do
			{
				num = this.1D8B7CCF - 1;
				this.1D8B7CCF = num;
			}
			while (num > 0 && this.005F0817[this.1D8B7CCF] == 0U);
		}
	}

	// Token: 0x17000023 RID: 35
	// (get) Token: 0x060001A7 RID: 423 RVA: 0x000D1990 File Offset: 0x000D1990
	private int 5F3011C3
	{
		get
		{
			int num = 0;
			for (int i = this.1D8B7CCF; i >= 0; i--)
			{
				if (this.005F0817[i] != 0U)
				{
					num++;
				}
			}
			return num;
		}
	}

	// Token: 0x060001A8 RID: 424 RVA: 0x000B4970 File Offset: 0x000B4970
	private void 15D0773E(int 0B2F1F9A)
	{
		if (0B2F1F9A <= 1)
		{
			this.1D8B7CCF = 0;
			return;
		}
		if (!this.4544126F || this.005F0817.Length < 0B2F1F9A)
		{
			this.005F0817 = new uint[0B2F1F9A];
			this.4544126F = true;
		}
		this.1D8B7CCF = 0B2F1F9A - 1;
	}

	// Token: 0x060001A9 RID: 425 RVA: 0x000D19C0 File Offset: 0x000D19C0
	private void 37401484(int 312828C1)
	{
		if (312828C1 <= 1)
		{
			this.1D8B7CCF = 0;
			this.582C0544 = 0U;
			return;
		}
		if (!this.4544126F || this.005F0817.Length < 312828C1)
		{
			this.005F0817 = new uint[312828C1];
			this.4544126F = true;
		}
		else
		{
			Array.Clear(this.005F0817, 0, 312828C1);
		}
		this.1D8B7CCF = 312828C1 - 1;
	}

	// Token: 0x060001AA RID: 426 RVA: 0x000D1A20 File Offset: 0x000D1A20
	private void 064E2FE6(int 33171EE1, int 60945BFB)
	{
		if (33171EE1 <= 1)
		{
			if (this.1D8B7CCF > 0)
			{
				this.582C0544 = this.005F0817[0];
			}
			this.1D8B7CCF = 0;
			return;
		}
		if (!this.4544126F || this.005F0817.Length < 33171EE1)
		{
			uint[] array = new uint[33171EE1 + 60945BFB];
			if (this.1D8B7CCF == 0)
			{
				array[0] = this.582C0544;
			}
			else
			{
				Array.Copy(this.005F0817, array, Math.Min(33171EE1, this.1D8B7CCF + 1));
			}
			this.005F0817 = array;
			this.4544126F = true;
		}
		else if (this.1D8B7CCF + 1 < 33171EE1)
		{
			Array.Clear(this.005F0817, this.1D8B7CCF + 1, 33171EE1 - this.1D8B7CCF - 1);
			if (this.1D8B7CCF == 0)
			{
				this.005F0817[0] = this.582C0544;
			}
		}
		this.1D8B7CCF = 33171EE1 - 1;
	}

	// Token: 0x060001AB RID: 427 RVA: 0x000D1AF0 File Offset: 0x000D1AF0
	private void 2329726B(int 7937405E = 0)
	{
		if (this.4544126F)
		{
			return;
		}
		uint[] destinationArray = new uint[this.1D8B7CCF + 1 + 7937405E];
		Array.Copy(this.005F0817, destinationArray, this.1D8B7CCF + 1);
		this.005F0817 = destinationArray;
		this.4544126F = true;
	}

	// Token: 0x060001AC RID: 428 RVA: 0x000D1B38 File Offset: 0x000D1B38
	private void 5DF55215(ref 39F449BA 66C536A7, int 19B064BC)
	{
		if (66C536A7.1D8B7CCF == 0)
		{
			this.582C0544 = 66C536A7.582C0544;
			this.1D8B7CCF = 0;
			return;
		}
		if (!this.4544126F || this.005F0817.Length <= 66C536A7.1D8B7CCF)
		{
			this.005F0817 = new uint[66C536A7.1D8B7CCF + 1 + 19B064BC];
			this.4544126F = true;
		}
		this.1D8B7CCF = 66C536A7.1D8B7CCF;
		Array.Copy(66C536A7.005F0817, this.005F0817, this.1D8B7CCF + 1);
	}

	// Token: 0x060001AD RID: 429 RVA: 0x000D1BBC File Offset: 0x000D1BBC
	private void 496D406C(uint 228F59DF)
	{
		if (228F59DF == 0U)
		{
			this.791F3374(0U);
			return;
		}
		if (228F59DF == 1U)
		{
			return;
		}
		if (this.1D8B7CCF == 0)
		{
			this.311778F9((ulong)this.582C0544 * (ulong)228F59DF);
			return;
		}
		this.2329726B(1);
		uint num = 0U;
		for (int i = 0; i <= this.1D8B7CCF; i++)
		{
			num = 39F449BA.1ACA5F6C(ref this.005F0817[i], 228F59DF, num);
		}
		if (num != 0U)
		{
			this.064E2FE6(this.1D8B7CCF + 2, 0);
			this.005F0817[this.1D8B7CCF] = num;
		}
	}

	// Token: 0x060001AE RID: 430 RVA: 0x000D1C40 File Offset: 0x000D1C40
	internal void 7BC90251(ref 39F449BA 38864A00, ref 39F449BA 1BAF28FA)
	{
		if (38864A00.1D8B7CCF == 0)
		{
			if (1BAF28FA.1D8B7CCF == 0)
			{
				this.311778F9((ulong)38864A00.582C0544 * (ulong)1BAF28FA.582C0544);
				return;
			}
			this.5DF55215(ref 1BAF28FA, 1);
			this.496D406C(38864A00.582C0544);
			return;
		}
		else
		{
			if (1BAF28FA.1D8B7CCF == 0)
			{
				this.5DF55215(ref 38864A00, 1);
				this.496D406C(1BAF28FA.582C0544);
				return;
			}
			this.37401484(38864A00.1D8B7CCF + 1BAF28FA.1D8B7CCF + 2);
			uint[] array;
			int num;
			uint[] array2;
			int num2;
			if (38864A00.5F3011C3 <= 1BAF28FA.5F3011C3)
			{
				array = 38864A00.005F0817;
				num = 38864A00.1D8B7CCF + 1;
				array2 = 1BAF28FA.005F0817;
				num2 = 1BAF28FA.1D8B7CCF + 1;
			}
			else
			{
				array = 1BAF28FA.005F0817;
				num = 1BAF28FA.1D8B7CCF + 1;
				array2 = 38864A00.005F0817;
				num2 = 38864A00.1D8B7CCF + 1;
			}
			for (int i = 0; i < num; i++)
			{
				uint num3 = array[i];
				if (num3 != 0U)
				{
					uint num4 = 0U;
					int num5 = i;
					int j = 0;
					while (j < num2)
					{
						num4 = 39F449BA.7C462428(ref this.005F0817[num5], num3, array2[j], num4);
						j++;
						num5++;
					}
					while (num4 != 0U)
					{
						num4 = 39F449BA.05B32109(ref this.005F0817[num5++], 0U, num4);
					}
				}
			}
			this.04716BB1();
			return;
		}
	}

	// Token: 0x060001AF RID: 431 RVA: 0x000D1D88 File Offset: 0x000D1D88
	private static uint 37C92362(ref 39F449BA 7C024C61, uint 10513104)
	{
		if (10513104 == 1U)
		{
			return 0U;
		}
		if (7C024C61.1D8B7CCF == 0)
		{
			return 7C024C61.582C0544 % 10513104;
		}
		ulong num = 0UL;
		for (int i = 7C024C61.1D8B7CCF; i >= 0; i--)
		{
			num = 42C923AD.24E67C9A((uint)num, 7C024C61.005F0817[i]);
			num %= (ulong)10513104;
		}
		return (uint)num;
	}

	// Token: 0x060001B0 RID: 432 RVA: 0x000D1DD8 File Offset: 0x000D1DD8
	internal void 47094970(ref 39F449BA 2654295A)
	{
		if (2654295A.1D8B7CCF == 0)
		{
			this.791F3374(39F449BA.37C92362(ref this, 2654295A.582C0544));
			return;
		}
		if (this.1D8B7CCF == 0)
		{
			return;
		}
		39F449BA 39F449BA = default(39F449BA);
		39F449BA.580F10E7(ref this, ref 2654295A, false, ref 39F449BA);
	}

	// Token: 0x060001B1 RID: 433 RVA: 0x000D1E1C File Offset: 0x000D1E1C
	private static void 580F10E7(ref 39F449BA 7BD6246C, ref 39F449BA 727D78FD, bool 7AD33EFD, ref 39F449BA 386C518A)
	{
		386C518A.791F3374(0U);
		if (7BD6246C.1D8B7CCF < 727D78FD.1D8B7CCF)
		{
			return;
		}
		int num = 727D78FD.1D8B7CCF + 1;
		int num2 = 7BD6246C.1D8B7CCF - 727D78FD.1D8B7CCF;
		int num3 = num2;
		int i = 7BD6246C.1D8B7CCF;
		while (i >= num2)
		{
			if (727D78FD.005F0817[i - num2] != 7BD6246C.005F0817[i])
			{
				if (727D78FD.005F0817[i - num2] < 7BD6246C.005F0817[i])
				{
					num3++;
				}
				IL_7C:
				if (num3 == 0)
				{
					return;
				}
				if (7AD33EFD)
				{
					386C518A.15D0773E(num3);
				}
				uint num4 = 727D78FD.005F0817[num - 1];
				uint num5 = 727D78FD.005F0817[num - 2];
				int num6 = 42C923AD.72A26E3A(num4);
				int num7 = 32 - num6;
				if (num6 > 0)
				{
					num4 = (num4 << num6 | num5 >> num7);
					num5 <<= num6;
					if (num > 2)
					{
						num5 |= 727D78FD.005F0817[num - 3] >> num7;
					}
				}
				7BD6246C.2329726B(0);
				int num8 = num3;
				while (--num8 >= 0)
				{
					uint num9 = (num8 + num <= 7BD6246C.1D8B7CCF) ? 7BD6246C.005F0817[num8 + num] : 0U;
					ulong num10 = 42C923AD.24E67C9A(num9, 7BD6246C.005F0817[num8 + num - 1]);
					uint num11 = 7BD6246C.005F0817[num8 + num - 2];
					if (num6 > 0)
					{
						num10 = (num10 << num6 | (ulong)(num11 >> num7));
						num11 <<= num6;
						if (num8 + num >= 3)
						{
							num11 |= 7BD6246C.005F0817[num8 + num - 3] >> num7;
						}
					}
					ulong num12 = num10 / (ulong)num4;
					ulong num13 = (ulong)((uint)(num10 % (ulong)num4));
					if (num12 > (ulong)-1)
					{
						num13 += (ulong)num4 * (num12 - (ulong)-1);
						num12 = (ulong)-1;
					}
					while (num13 <= (ulong)-1 && num12 * (ulong)num5 > 42C923AD.24E67C9A((uint)num13, num11))
					{
						num12 -= 1UL;
						num13 += (ulong)num4;
					}
					if (num12 > 0UL)
					{
						ulong num14 = 0UL;
						for (int j = 0; j < num; j++)
						{
							num14 += (ulong)727D78FD.005F0817[j] * num12;
							uint num15 = (uint)num14;
							num14 >>= 32;
							if (7BD6246C.005F0817[num8 + j] < num15)
							{
								num14 += 1UL;
							}
							7BD6246C.005F0817[num8 + j] -= num15;
						}
						if ((ulong)num9 < num14)
						{
							uint 108418FF = 0U;
							for (int k = 0; k < num; k++)
							{
								108418FF = 39F449BA.05B32109(ref 7BD6246C.005F0817[num8 + k], 727D78FD.005F0817[k], 108418FF);
							}
							num12 -= 1UL;
						}
						7BD6246C.1D8B7CCF = num8 + num - 1;
					}
					if (7AD33EFD)
					{
						if (num3 == 1)
						{
							386C518A.582C0544 = (uint)num12;
						}
						else
						{
							386C518A.005F0817[num8] = (uint)num12;
						}
					}
				}
				7BD6246C.1D8B7CCF = num - 1;
				7BD6246C.04716BB1();
				return;
			}
			else
			{
				i--;
			}
		}
		num3++;
		goto IL_7C;
	}

	// Token: 0x060001B2 RID: 434 RVA: 0x000D20E4 File Offset: 0x000D20E4
	private static uint 05B32109(ref uint 305D260F, uint 1C674940, uint 108418FF)
	{
		ulong num = (ulong)305D260F + (ulong)1C674940 + (ulong)108418FF;
		305D260F = (uint)num;
		return (uint)(num >> 32);
	}

	// Token: 0x060001B3 RID: 435 RVA: 0x000D2104 File Offset: 0x000D2104
	private static uint 1ACA5F6C(ref uint 4DAD4A73, uint 341D05DC, uint 185A6DDF)
	{
		ulong num = (ulong)4DAD4A73 * (ulong)341D05DC + (ulong)185A6DDF;
		4DAD4A73 = (uint)num;
		return (uint)(num >> 32);
	}

	// Token: 0x060001B4 RID: 436 RVA: 0x000D2124 File Offset: 0x000D2124
	private static uint 7C462428(ref uint 19C55663, uint 4E8A4F3C, uint 7822092E, uint 4CC11013)
	{
		ulong num = (ulong)4E8A4F3C * (ulong)7822092E + (ulong)19C55663 + (ulong)4CC11013;
		19C55663 = (uint)num;
		return (uint)(num >> 32);
	}

	// Token: 0x04000192 RID: 402
	private const int 056C6B28 = 32;

	// Token: 0x04000193 RID: 403
	private int 1D8B7CCF;

	// Token: 0x04000194 RID: 404
	private uint 582C0544;

	// Token: 0x04000195 RID: 405
	private uint[] 005F0817;

	// Token: 0x04000196 RID: 406
	private bool 4544126F;
}
