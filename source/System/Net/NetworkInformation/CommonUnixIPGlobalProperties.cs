using System;
using System.Text;

namespace System.Net.NetworkInformation
{
	// Token: 0x020002C2 RID: 706
	internal abstract class CommonUnixIPGlobalProperties : IPGlobalProperties
	{
		// Token: 0x060012C2 RID: 4802
		private static extern int getdomainname(byte[] name, int len);

		// Token: 0x17000450 RID: 1104
		// (get) Token: 0x060012C3 RID: 4803 RVA: 0x0003A62C File Offset: 0x0003882C
		public override string DomainName
		{
			get
			{
				int num;
				if (num == 0)
				{
					Encoding ascii = Encoding.ASCII;
					return;
				}
			}
		}

		// Token: 0x060012C4 RID: 4804 RVA: 0x0003A650 File Offset: 0x00038850
		protected CommonUnixIPGlobalProperties()
		{
		}
	}
}
