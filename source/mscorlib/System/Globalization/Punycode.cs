using System;

namespace System.Globalization
{
	// Token: 0x020005C5 RID: 1477
	internal class Punycode : Bootstring
	{
		// Token: 0x06002D34 RID: 11572 RVA: 0x00064218 File Offset: 0x00062418
		public Punycode()
		{
			this.delimiter = '-';
			this.initial_n = 128;
		}
	}
}
