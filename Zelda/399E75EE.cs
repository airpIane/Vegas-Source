using System;

// Token: 0x02000046 RID: 70
internal struct 399E75EE
{
	// Token: 0x060001CD RID: 461 RVA: 0x000B4A40 File Offset: 0x000B4A40
	public 399E75EE(int 5FC87C15)
	{
		this.38E700D6 = 5FC87C15;
		this.0E7011C3 = new 7E536D48[1 << 5FC87C15];
	}

	// Token: 0x060001CE RID: 462 RVA: 0x000D2B18 File Offset: 0x000D2B18
	public void 71CB6279()
	{
		uint num = 1U;
		while ((ulong)num < (ulong)(1L << (this.38E700D6 & 31)))
		{
			this.0E7011C3[(int)num].5A48605D();
			num += 1U;
		}
	}

	// Token: 0x060001CF RID: 463 RVA: 0x000D2B54 File Offset: 0x000D2B54
	public uint 3F8D4729(6C2E7A66 34865D57)
	{
		uint num = 1U;
		for (int i = this.38E700D6; i > 0; i--)
		{
			num = (num << 1) + this.0E7011C3[(int)num].36D4497D(34865D57);
		}
		return num - (1U << this.38E700D6);
	}

	// Token: 0x060001D0 RID: 464 RVA: 0x000D2BA0 File Offset: 0x000D2BA0
	public uint 0F3E27F6(6C2E7A66 3DE556EE)
	{
		uint num = 1U;
		uint num2 = 0U;
		for (int i = 0; i < this.38E700D6; i++)
		{
			uint num3 = this.0E7011C3[(int)num].36D4497D(3DE556EE);
			num <<= 1;
			num += num3;
			num2 |= num3 << i;
		}
		return num2;
	}

	// Token: 0x060001D1 RID: 465 RVA: 0x000D2BF0 File Offset: 0x000D2BF0
	public static uint 21D3635F(7E536D48[] 38AA361C, uint 1A454B03, 6C2E7A66 090D6650, int 2FCF792D)
	{
		uint num = 1U;
		uint num2 = 0U;
		for (int i = 0; i < 2FCF792D; i++)
		{
			uint num3 = 38AA361C[(int)(1A454B03 + num)].36D4497D(090D6650);
			num <<= 1;
			num += num3;
			num2 |= num3 << i;
		}
		return num2;
	}

	// Token: 0x040001C3 RID: 451
	private readonly 7E536D48[] 0E7011C3;

	// Token: 0x040001C4 RID: 452
	private readonly int 38E700D6;
}
