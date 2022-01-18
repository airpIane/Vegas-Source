using System;

// Token: 0x02000031 RID: 49
public class 214E4E91
{
	// Token: 0x060000D7 RID: 215 RVA: 0x000B45BE File Offset: 0x000B45BE
	public 214E4E91()
	{
		this.302E56A8 = 987580101U;
	}

	// Token: 0x060000D8 RID: 216 RVA: 0x000C2518 File Offset: 0x000C2518
	public uint 4F465058(uint 2D7D772D)
	{
		uint num = 2D7D772D ^ this.302E56A8;
		this.302E56A8 = (73B51C4F.4FB068AF(this.302E56A8, 7) ^ num);
		return num;
	}

	// Token: 0x0400013E RID: 318
	private uint 302E56A8;
}
