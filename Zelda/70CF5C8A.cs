using System;
using System.IO;

// Token: 0x02000043 RID: 67
public class 70CF5C8A
{
	// Token: 0x060001C0 RID: 448 RVA: 0x000D227C File Offset: 0x000D227C
	public 70CF5C8A()
	{
		this.02905206 = uint.MaxValue;
		int num = 0;
		while ((long)num < 4L)
		{
			this.0CB939DC[num] = new 399E75EE(6);
			num++;
		}
	}

	// Token: 0x060001C1 RID: 449 RVA: 0x000D2374 File Offset: 0x000D2374
	private void 3CA71C14(uint 288F79F9)
	{
		if (this.02905206 != 288F79F9)
		{
			this.02905206 = 288F79F9;
			this.1FF05B01 = Math.Max(this.02905206, 1U);
			uint 6ACD2A = Math.Max(this.1FF05B01, 4096U);
			this.6C1C2785.09EC4069(6ACD2A);
		}
	}

	// Token: 0x060001C2 RID: 450 RVA: 0x000B49E8 File Offset: 0x000B49E8
	private void 01707DA2(int 0FAD34E7, int 45A737CF)
	{
		if (0FAD34E7 > 8)
		{
			throw new ArgumentException("lp > 8");
		}
		if (45A737CF > 8)
		{
			throw new ArgumentException("lc > 8");
		}
		this.011F167B.400A3F5E(0FAD34E7, 45A737CF);
	}

	// Token: 0x060001C3 RID: 451 RVA: 0x000D23C4 File Offset: 0x000D23C4
	private void 1EAF6B4A(int 43114F49)
	{
		if (43114F49 > 4)
		{
			throw new ArgumentException("pb > Base.KNumPosStatesBitsMax");
		}
		uint num = 1U << 43114F49;
		this.212C79EF.237C57C3(num);
		this.05225C44.237C57C3(num);
		this.6E500E11 = num - 1U;
	}

	// Token: 0x060001C4 RID: 452 RVA: 0x000D240C File Offset: 0x000D240C
	private void 642153D6(Stream 67155707, Stream 5B202537)
	{
		this.254C04A2.74030092(67155707);
		this.6C1C2785.2C837EB7(5B202537, false);
		for (uint num = 0U; num < 12U; num += 1U)
		{
			for (uint num2 = 0U; num2 <= this.6E500E11; num2 += 1U)
			{
				uint num3 = (num << 4) + num2;
				this.62950309[(int)num3].5A48605D();
				this.688B3F88[(int)num3].5A48605D();
			}
			this.283244DA[(int)num].5A48605D();
			this.2B695F5A[(int)num].5A48605D();
			this.751825DA[(int)num].5A48605D();
			this.69955890[(int)num].5A48605D();
		}
		this.011F167B.2AF773A0();
		for (uint num = 0U; num < 4U; num += 1U)
		{
			this.0CB939DC[(int)num].71CB6279();
		}
		for (uint num = 0U; num < 114U; num += 1U)
		{
			this.12C44BC8[(int)num].5A48605D();
		}
		this.212C79EF.457D7552();
		this.05225C44.457D7552();
		this.67784A60.71CB6279();
	}

	// Token: 0x060001C5 RID: 453 RVA: 0x000D253C File Offset: 0x000D253C
	public void 537E0FE3(Stream 0D386615, Stream 3DCE10E6, long 454329F3)
	{
		this.642153D6(0D386615, 3DCE10E6);
		2AFC6122.59D463BB 59D463BB = default(2AFC6122.59D463BB);
		59D463BB.19EE7ED1();
		uint num = 0U;
		uint num2 = 0U;
		uint num3 = 0U;
		uint num4 = 0U;
		ulong num5 = 0UL;
		if (num5 < (ulong)454329F3)
		{
			if (this.62950309[(int)((int)59D463BB.63394958 << 4)].36D4497D(this.254C04A2) != 0U)
			{
				throw new InvalidDataException("IsMatchDecoders");
			}
			59D463BB.702758D7();
			byte 0B0B643F = this.011F167B.60334345(this.254C04A2, 0U, 0);
			this.6C1C2785.35D5089F(0B0B643F);
			num5 += 1UL;
		}
		while (num5 < (ulong)454329F3)
		{
			uint num6 = (uint)num5 & this.6E500E11;
			if (this.62950309[(int)((59D463BB.63394958 << 4) + num6)].36D4497D(this.254C04A2) == 0U)
			{
				byte b = this.6C1C2785.0E2D5071(0U);
				byte 0B0B643F2;
				if (!59D463BB.10C6248F())
				{
					0B0B643F2 = this.011F167B.5FFC48C2(this.254C04A2, (uint)num5, b, this.6C1C2785.0E2D5071(num));
				}
				else
				{
					0B0B643F2 = this.011F167B.60334345(this.254C04A2, (uint)num5, b);
				}
				this.6C1C2785.35D5089F(0B0B643F2);
				59D463BB.702758D7();
				num5 += 1UL;
			}
			else
			{
				uint num8;
				if (this.283244DA[(int)59D463BB.63394958].36D4497D(this.254C04A2) == 1U)
				{
					if (this.2B695F5A[(int)59D463BB.63394958].36D4497D(this.254C04A2) == 0U)
					{
						if (this.688B3F88[(int)((59D463BB.63394958 << 4) + num6)].36D4497D(this.254C04A2) == 0U)
						{
							59D463BB.76222328();
							this.6C1C2785.35D5089F(this.6C1C2785.0E2D5071(num));
							num5 += 1UL;
							continue;
						}
					}
					else
					{
						uint num7;
						if (this.751825DA[(int)59D463BB.63394958].36D4497D(this.254C04A2) == 0U)
						{
							num7 = num2;
						}
						else
						{
							if (this.69955890[(int)59D463BB.63394958].36D4497D(this.254C04A2) == 0U)
							{
								num7 = num3;
							}
							else
							{
								num7 = num4;
								num4 = num3;
							}
							num3 = num2;
						}
						num2 = num;
						num = num7;
					}
					num8 = this.05225C44.70B53C16(this.254C04A2, num6) + 2U;
					59D463BB.65A51B64();
				}
				else
				{
					num4 = num3;
					num3 = num2;
					num2 = num;
					num8 = 2U + this.212C79EF.70B53C16(this.254C04A2, num6);
					59D463BB.52A04BE6();
					uint num9 = this.0CB939DC[(int)2AFC6122.6BA1567D(num8)].3F8D4729(this.254C04A2);
					if (num9 >= 4U)
					{
						int num10 = (int)((num9 >> 1) - 1U);
						num = (2U | (num9 & 1U)) << num10;
						if (num9 < 14U)
						{
							num += 399E75EE.21D3635F(this.12C44BC8, num - num9 - 1U, this.254C04A2, num10);
						}
						else
						{
							num += this.254C04A2.57024787(num10 - 4) << 4;
							num += this.67784A60.0F3E27F6(this.254C04A2);
						}
					}
					else
					{
						num = num9;
					}
				}
				if ((ulong)num >= (ulong)this.6C1C2785.68B71D15 + num5 || num >= this.1FF05B01)
				{
					if (num != 4294967295U)
					{
						throw new InvalidDataException("rep0");
					}
					break;
				}
				else
				{
					this.6C1C2785.1B1E307C(num, num8);
					num5 += (ulong)num8;
				}
			}
		}
		this.6C1C2785.672D4F68();
		this.6C1C2785.35057A07();
		this.254C04A2.7C263D52();
	}

	// Token: 0x060001C6 RID: 454 RVA: 0x000D28D0 File Offset: 0x000D28D0
	public void 71896D41(byte[] 167C6142)
	{
		if (167C6142.Length < 5)
		{
			throw new ArgumentException("properties.Length < 5");
		}
		int 45A737CF = (int)(167C6142[0] % 9);
		byte b = 167C6142[0] / 9;
		int 0FAD34E = (int)(b % 5);
		int num = (int)(b / 5);
		if (num > 4)
		{
			throw new ArgumentException("pb > Base.kNumPosStatesBitsMax");
		}
		uint num2 = 0U;
		for (int i = 0; i < 4; i++)
		{
			num2 += (uint)((uint)167C6142[1 + i] << i * 8);
		}
		this.3CA71C14(num2);
		this.01707DA2(0FAD34E, 45A737CF);
		this.1EAF6B4A(num);
	}

	// Token: 0x040001A8 RID: 424
	private uint 6F3D5C16 = 1U;

	// Token: 0x040001A9 RID: 425
	private readonly 3EE71944 6C1C2785 = new 3EE71944();

	// Token: 0x040001AA RID: 426
	private readonly 6C2E7A66 254C04A2 = new 6C2E7A66();

	// Token: 0x040001AB RID: 427
	private readonly 7E536D48[] 62950309 = new 7E536D48[192];

	// Token: 0x040001AC RID: 428
	private readonly 7E536D48[] 283244DA = new 7E536D48[12];

	// Token: 0x040001AD RID: 429
	private readonly 7E536D48[] 2B695F5A = new 7E536D48[12];

	// Token: 0x040001AE RID: 430
	private readonly 7E536D48[] 751825DA = new 7E536D48[12];

	// Token: 0x040001AF RID: 431
	private readonly 7E536D48[] 69955890 = new 7E536D48[12];

	// Token: 0x040001B0 RID: 432
	private readonly 7E536D48[] 688B3F88 = new 7E536D48[192];

	// Token: 0x040001B1 RID: 433
	private readonly 399E75EE[] 0CB939DC = new 399E75EE[4];

	// Token: 0x040001B2 RID: 434
	private readonly 7E536D48[] 12C44BC8 = new 7E536D48[114];

	// Token: 0x040001B3 RID: 435
	private 399E75EE 67784A60 = new 399E75EE(4);

	// Token: 0x040001B4 RID: 436
	private readonly 70CF5C8A.40167241 212C79EF = new 70CF5C8A.40167241();

	// Token: 0x040001B5 RID: 437
	private readonly 70CF5C8A.40167241 05225C44 = new 70CF5C8A.40167241();

	// Token: 0x040001B6 RID: 438
	private readonly 70CF5C8A.54650E38 011F167B = new 70CF5C8A.54650E38();

	// Token: 0x040001B7 RID: 439
	private uint 02905206;

	// Token: 0x040001B8 RID: 440
	private uint 1FF05B01;

	// Token: 0x040001B9 RID: 441
	private uint 6E500E11;

	// Token: 0x02000078 RID: 120
	private class 40167241
	{
		// Token: 0x06000376 RID: 886 RVA: 0x000D7FE8 File Offset: 0x000D7FE8
		public void 237C57C3(uint 46C42FFA)
		{
			for (uint num = this.039771C4; num < 46C42FFA; num += 1U)
			{
				this.37700252[(int)num] = new 399E75EE(3);
				this.13891EFC[(int)num] = new 399E75EE(3);
			}
			this.039771C4 = 46C42FFA;
		}

		// Token: 0x06000377 RID: 887 RVA: 0x000D8038 File Offset: 0x000D8038
		public void 457D7552()
		{
			this.795D75C6.5A48605D();
			for (uint num = 0U; num < this.039771C4; num += 1U)
			{
				this.37700252[(int)num].71CB6279();
				this.13891EFC[(int)num].71CB6279();
			}
			this.1F421456.5A48605D();
			this.414D4690.71CB6279();
		}

		// Token: 0x06000378 RID: 888 RVA: 0x000D80A0 File Offset: 0x000D80A0
		public uint 70B53C16(6C2E7A66 298A6A74, uint 77551888)
		{
			if (this.795D75C6.36D4497D(298A6A74) == 0U)
			{
				return this.37700252[(int)77551888].3F8D4729(298A6A74);
			}
			uint num = 8U;
			if (this.1F421456.36D4497D(298A6A74) == 0U)
			{
				num += this.13891EFC[(int)77551888].3F8D4729(298A6A74);
			}
			else
			{
				num += 8U;
				num += this.414D4690.3F8D4729(298A6A74);
			}
			return num;
		}

		// Token: 0x04000228 RID: 552
		private 7E536D48 795D75C6;

		// Token: 0x04000229 RID: 553
		private 7E536D48 1F421456;

		// Token: 0x0400022A RID: 554
		private readonly 399E75EE[] 37700252 = new 399E75EE[16];

		// Token: 0x0400022B RID: 555
		private readonly 399E75EE[] 13891EFC = new 399E75EE[16];

		// Token: 0x0400022C RID: 556
		private 399E75EE 414D4690 = new 399E75EE(8);

		// Token: 0x0400022D RID: 557
		private uint 039771C4;
	}

	// Token: 0x02000079 RID: 121
	private class 54650E38
	{
		// Token: 0x0600037A RID: 890 RVA: 0x000D8114 File Offset: 0x000D8114
		public void 400A3F5E(int 5FA03DA7, int 391E4DC0)
		{
			if (this.153355AC != null && this.785665C9 == 391E4DC0 && this.580A60A8 == 5FA03DA7)
			{
				return;
			}
			this.580A60A8 = 5FA03DA7;
			this.3B195797 = (1U << 5FA03DA7) - 1U;
			this.785665C9 = 391E4DC0;
			uint num = 1U << this.785665C9 + this.580A60A8;
			this.153355AC = new 70CF5C8A.54650E38.11BB53A5[num];
			for (uint num2 = 0U; num2 < num; num2 += 1U)
			{
				this.153355AC[(int)num2].7B705E25();
			}
		}

		// Token: 0x0600037B RID: 891 RVA: 0x000D81A4 File Offset: 0x000D81A4
		public void 2AF773A0()
		{
			uint num = 1U << this.785665C9 + this.580A60A8;
			for (uint num2 = 0U; num2 < num; num2 += 1U)
			{
				this.153355AC[(int)num2].7FB67623();
			}
		}

		// Token: 0x0600037C RID: 892 RVA: 0x000B4C37 File Offset: 0x000B4C37
		private uint 5EBB57D5(uint 63BB2B5B, byte 6837251F)
		{
			return ((63BB2B5B & this.3B195797) << this.785665C9) + (uint)(6837251F >> 8 - this.785665C9);
		}

		// Token: 0x0600037D RID: 893 RVA: 0x000B4C59 File Offset: 0x000B4C59
		public byte 60334345(6C2E7A66 47E1775B, uint 75211CDD, byte 316E43A0)
		{
			return this.153355AC[(int)this.5EBB57D5(75211CDD, 316E43A0)].18EE1805(47E1775B);
		}

		// Token: 0x0600037E RID: 894 RVA: 0x000B4C74 File Offset: 0x000B4C74
		public byte 5FFC48C2(6C2E7A66 03C66BD1, uint 54272BF3, byte 5B9B2B2A, byte 55D52B00)
		{
			return this.153355AC[(int)this.5EBB57D5(54272BF3, 5B9B2B2A)].37494B14(03C66BD1, 55D52B00);
		}

		// Token: 0x0400022E RID: 558
		private uint 086B0418 = 1U;

		// Token: 0x0400022F RID: 559
		private 70CF5C8A.54650E38.11BB53A5[] 153355AC;

		// Token: 0x04000230 RID: 560
		private int 785665C9;

		// Token: 0x04000231 RID: 561
		private int 580A60A8;

		// Token: 0x04000232 RID: 562
		private uint 3B195797;

		// Token: 0x0200007D RID: 125
		private struct 11BB53A5
		{
			// Token: 0x06000383 RID: 899 RVA: 0x000B4CAC File Offset: 0x000B4CAC
			public void 7B705E25()
			{
				this.3E591C30 = new 7E536D48[768];
			}

			// Token: 0x06000384 RID: 900 RVA: 0x000D81E8 File Offset: 0x000D81E8
			public void 7FB67623()
			{
				for (int i = 0; i < 768; i++)
				{
					this.3E591C30[i].5A48605D();
				}
			}

			// Token: 0x06000385 RID: 901 RVA: 0x000D821C File Offset: 0x000D821C
			public byte 18EE1805(6C2E7A66 255D5639)
			{
				uint num = 1U;
				do
				{
					num = (num << 1 | this.3E591C30[(int)num].36D4497D(255D5639));
				}
				while (num < 256U);
				return (byte)num;
			}

			// Token: 0x06000386 RID: 902 RVA: 0x000D8250 File Offset: 0x000D8250
			public byte 37494B14(6C2E7A66 426F079B, byte 48200E22)
			{
				uint num = 1U;
				for (;;)
				{
					uint num2 = (uint)(48200E22 >> 7 & 1);
					48200E22 = (byte)(48200E22 << 1);
					uint num3 = this.3E591C30[(int)((1U + num2 << 8) + num)].36D4497D(426F079B);
					num = (num << 1 | num3);
					if (num2 != num3)
					{
						break;
					}
					if (num >= 256U)
					{
						goto IL_6B;
					}
				}
				while (num < 256U)
				{
					num = (num << 1 | this.3E591C30[(int)num].36D4497D(426F079B));
				}
				IL_6B:
				return (byte)num;
			}

			// Token: 0x04000235 RID: 565
			private 7E536D48[] 3E591C30;
		}
	}
}
