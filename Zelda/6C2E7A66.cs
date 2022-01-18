using System;
using System.IO;

// Token: 0x02000044 RID: 68
internal class 6C2E7A66
{
	// Token: 0x060001C7 RID: 455 RVA: 0x000D2958 File Offset: 0x000D2958
	public void 74030092(Stream 7DA942E2)
	{
		this.54630140 = 7DA942E2;
		this.3FAD2333 = 0U;
		this.017C24AA = uint.MaxValue;
		for (int i = 0; i < 5; i++)
		{
			this.3FAD2333 = (this.3FAD2333 << 8 | (uint)((byte)this.54630140.ReadByte()));
		}
	}

	// Token: 0x060001C8 RID: 456 RVA: 0x000B4A1B File Offset: 0x000B4A1B
	public void 7C263D52()
	{
		this.54630140 = null;
	}

	// Token: 0x060001C9 RID: 457 RVA: 0x000D29A8 File Offset: 0x000D29A8
	public uint 57024787(int 00481518)
	{
		uint num = this.017C24AA;
		uint num2 = this.3FAD2333;
		uint num3 = 0U;
		for (int i = 00481518; i > 0; i--)
		{
			num >>= 1;
			uint num4 = num2 - num >> 31;
			num2 -= (num & num4 - 1U);
			num3 = (num3 << 1 | 1U - num4);
			if (num < 16777216U)
			{
				num2 = (num2 << 8 | (uint)((byte)this.54630140.ReadByte()));
				num <<= 8;
			}
		}
		this.017C24AA = num;
		this.3FAD2333 = num2;
		return num3;
	}

	// Token: 0x040001BA RID: 442
	private uint 5310399D = 1U;

	// Token: 0x040001BB RID: 443
	public const uint 238C502B = 16777216U;

	// Token: 0x040001BC RID: 444
	public uint 017C24AA;

	// Token: 0x040001BD RID: 445
	public uint 3FAD2333;

	// Token: 0x040001BE RID: 446
	public Stream 54630140;
}
