using System;
using System.Runtime.InteropServices;

// Token: 0x02000030 RID: 48
public class 1E2C790C
{
	// Token: 0x060000D5 RID: 213 RVA: 0x000C2450 File Offset: 0x000C2450
	public 1E2C790C()
	{
		if (1E2C790C.41031D10 == null)
		{
			1E2C790C.41031D10 = new uint[256];
			for (int i = 0; i < 256; i++)
			{
				uint num = (uint)i;
				for (int j = 0; j < 8; j++)
				{
					if ((num & 1U) == 1U)
					{
						num = (num >> 1 ^ 3988292384U);
					}
					else
					{
						num >>= 1;
					}
				}
				1E2C790C.41031D10[i] = num;
			}
		}
	}

	// Token: 0x060000D6 RID: 214 RVA: 0x000C24CC File Offset: 0x000C24CC
	public uint 6E701168(IntPtr 1F804EE9, uint 378E4D31)
	{
		uint num = 0U;
		int num2 = 0;
		while ((long)num2 < (long)((ulong)378E4D31))
		{
			num = (1E2C790C.41031D10[(int)(((uint)Marshal.ReadByte(new IntPtr(1F804EE9.ToInt64() + (long)num2)) ^ num) & 255U)] ^ num >> 8);
			num2++;
		}
		return ~num;
	}

	// Token: 0x0400013D RID: 317
	private static uint[] 41031D10;
}
