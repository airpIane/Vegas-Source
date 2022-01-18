using System;

// Token: 0x02000045 RID: 69
internal struct 7E536D48
{
	// Token: 0x060001CB RID: 459 RVA: 0x000B4A33 File Offset: 0x000B4A33
	public void 5A48605D()
	{
		this.6C624234 = 1024U;
	}

	// Token: 0x060001CC RID: 460 RVA: 0x000D2A24 File Offset: 0x000D2A24
	public uint 36D4497D(6C2E7A66 1EC948BB)
	{
		uint num = (1EC948BB.017C24AA >> 11) * this.6C624234;
		if (1EC948BB.3FAD2333 < num)
		{
			1EC948BB.017C24AA = num;
			this.6C624234 += 2048U - this.6C624234 >> 5;
			if (1EC948BB.017C24AA < 16777216U)
			{
				1EC948BB.3FAD2333 = (1EC948BB.3FAD2333 << 8 | (uint)((byte)1EC948BB.54630140.ReadByte()));
				1EC948BB.017C24AA <<= 8;
			}
			return 0U;
		}
		1EC948BB.017C24AA -= num;
		1EC948BB.3FAD2333 -= num;
		this.6C624234 -= this.6C624234 >> 5;
		if (1EC948BB.017C24AA < 16777216U)
		{
			1EC948BB.3FAD2333 = (1EC948BB.3FAD2333 << 8 | (uint)((byte)1EC948BB.54630140.ReadByte()));
			1EC948BB.017C24AA <<= 8;
		}
		return 1U;
	}

	// Token: 0x040001BF RID: 447
	private const int 1854206E = 11;

	// Token: 0x040001C0 RID: 448
	private const uint 45DF7500 = 2048U;

	// Token: 0x040001C1 RID: 449
	private const int 3F317818 = 5;

	// Token: 0x040001C2 RID: 450
	private uint 6C624234;
}
