using System;
using System.IO;

// Token: 0x02000047 RID: 71
public class 3EE71944
{
	// Token: 0x060001D2 RID: 466 RVA: 0x000B4A5A File Offset: 0x000B4A5A
	public void 09EC4069(uint 6ACD2A75)
	{
		if (this.59CE48D8 != 6ACD2A75)
		{
			this.7FCC0E52 = new byte[6ACD2A75];
		}
		this.59CE48D8 = 6ACD2A75;
		this.41EF17BE = 0U;
		this.1CF93A0B = 0U;
	}

	// Token: 0x060001D3 RID: 467 RVA: 0x000B4A89 File Offset: 0x000B4A89
	public void 2C837EB7(Stream 68BA79E2, bool 576F6CE5)
	{
		this.35057A07();
		this.5EE062F4 = 68BA79E2;
		if (!576F6CE5)
		{
			this.1CF93A0B = 0U;
			this.41EF17BE = 0U;
			this.68B71D15 = 0U;
		}
	}

	// Token: 0x060001D4 RID: 468 RVA: 0x000B4AB3 File Offset: 0x000B4AB3
	public void 35057A07()
	{
		this.672D4F68();
		this.5EE062F4 = null;
	}

	// Token: 0x060001D5 RID: 469 RVA: 0x000D2C38 File Offset: 0x000D2C38
	public void 672D4F68()
	{
		uint num = this.41EF17BE - this.1CF93A0B;
		if (num == 0U)
		{
			return;
		}
		this.5EE062F4.Write(this.7FCC0E52, (int)this.1CF93A0B, (int)num);
		if (this.41EF17BE >= this.59CE48D8)
		{
			this.41EF17BE = 0U;
		}
		this.1CF93A0B = this.41EF17BE;
	}

	// Token: 0x060001D6 RID: 470 RVA: 0x000D2C98 File Offset: 0x000D2C98
	public void 1B1E307C(uint 3E9E7DD3, uint 23064B26)
	{
		uint num = this.41EF17BE - 3E9E7DD3 - 1U;
		if (num >= this.59CE48D8)
		{
			num += this.59CE48D8;
		}
		while (23064B26 > 0U)
		{
			if (num >= this.59CE48D8)
			{
				num = 0U;
			}
			byte[] array = this.7FCC0E52;
			uint num2 = this.41EF17BE;
			this.41EF17BE = num2 + 1U;
			array[(int)num2] = this.7FCC0E52[(int)num++];
			if (this.41EF17BE >= this.59CE48D8)
			{
				this.672D4F68();
			}
			23064B26 -= 1U;
		}
	}

	// Token: 0x060001D7 RID: 471 RVA: 0x000D2D20 File Offset: 0x000D2D20
	public void 35D5089F(byte 0B0B643F)
	{
		byte[] array = this.7FCC0E52;
		uint num = this.41EF17BE;
		this.41EF17BE = num + 1U;
		array[(int)num] = 0B0B643F;
		if (this.41EF17BE >= this.59CE48D8)
		{
			this.672D4F68();
		}
	}

	// Token: 0x060001D8 RID: 472 RVA: 0x000D2D60 File Offset: 0x000D2D60
	public byte 0E2D5071(uint 08EC5938)
	{
		uint num = this.41EF17BE - 08EC5938 - 1U;
		if (num >= this.59CE48D8)
		{
			num += this.59CE48D8;
		}
		return this.7FCC0E52[(int)num];
	}

	// Token: 0x040001C5 RID: 453
	private byte[] 7FCC0E52;

	// Token: 0x040001C6 RID: 454
	private uint 41EF17BE;

	// Token: 0x040001C7 RID: 455
	private uint 59CE48D8;

	// Token: 0x040001C8 RID: 456
	private uint 1CF93A0B;

	// Token: 0x040001C9 RID: 457
	private Stream 5EE062F4;

	// Token: 0x040001CA RID: 458
	private uint 0AF1127F = 1U;

	// Token: 0x040001CB RID: 459
	public uint 68B71D15;
}
