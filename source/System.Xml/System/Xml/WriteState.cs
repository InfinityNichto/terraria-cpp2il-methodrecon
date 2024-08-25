using System;

namespace System.Xml
{
	// Token: 0x0200005B RID: 91
	public enum WriteState
	{
		// Token: 0x0400025D RID: 605
		Start,
		// Token: 0x0400025E RID: 606
		Prolog,
		// Token: 0x0400025F RID: 607
		Element,
		// Token: 0x04000260 RID: 608
		Attribute,
		// Token: 0x04000261 RID: 609
		Content,
		// Token: 0x04000262 RID: 610
		Closed,
		// Token: 0x04000263 RID: 611
		Error
	}
}
