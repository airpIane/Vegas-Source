using System;

// Token: 0x02000032 RID: 50
public class 73B51C4F
{
	// Token: 0x060000D9 RID: 217 RVA: 0x000C2544 File Offset: 0x000C2544
	public static uint 4FB068AF(uint 522249B1, int 76135071)
	{
		uint num = 522249B1 << 76135071;
		uint num2 = 522249B1 >> 32 - 76135071;
		return num | num2;
	}

	// Token: 0x060000DA RID: 218 RVA: 0x000C2564 File Offset: 0x000C2564
	public static uint 143A3E36(uint 18B917EC, int 37A3503C)
	{
		uint num = 18B917EC >> 37A3503C;
		uint num2 = 18B917EC << 32 - 37A3503C;
		return num | num2;
	}

	// Token: 0x060000DB RID: 219 RVA: 0x000C2584 File Offset: 0x000C2584
	public static uint 49DA1BD5(uint 70232089)
	{
		uint num = 70232089 & 16711935U;
		uint num2 = 70232089 & 4278255360U;
		return (num >> 8 | num << 24) + (num2 << 8 | num2 >> 24);
	}

	// Token: 0x060000DC RID: 220 RVA: 0x000C25B4 File Offset: 0x000C25B4
	public 73B51C4F()
	{
		uint num = 1517715308U;
		if (1002778062 << (int)num != 0)
		{
			num = 66812164U + num;
			base..ctor();
		}
	}

	// Token: 0x0400013F RID: 319
	public const int 37763106 = 32;
}
