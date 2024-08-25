using System;

namespace System.Globalization
{
	// Token: 0x02000591 RID: 1425
	internal struct HebrewNumberParsingContext
	{
		// Token: 0x06002B1F RID: 11039 RVA: 0x0005E4AC File Offset: 0x0005C6AC
		public HebrewNumberParsingContext(int result)
		{
			this.result = result;
		}

		// Token: 0x04001776 RID: 6006
		internal HebrewNumber.HS state;

		// Token: 0x04001777 RID: 6007
		internal int result;
	}
}
