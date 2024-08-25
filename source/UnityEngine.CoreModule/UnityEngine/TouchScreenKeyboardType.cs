using System;

namespace UnityEngine
{
	// Token: 0x02000095 RID: 149
	public enum TouchScreenKeyboardType
	{
		// Token: 0x04000338 RID: 824
		Default,
		// Token: 0x04000339 RID: 825
		ASCIICapable,
		// Token: 0x0400033A RID: 826
		NumbersAndPunctuation,
		// Token: 0x0400033B RID: 827
		URL,
		// Token: 0x0400033C RID: 828
		NumberPad,
		// Token: 0x0400033D RID: 829
		PhonePad,
		// Token: 0x0400033E RID: 830
		NamePhonePad,
		// Token: 0x0400033F RID: 831
		EmailAddress,
		// Token: 0x04000340 RID: 832
		[Obsolete("Wii U is no longer supported as of Unity 2018.1.")]
		NintendoNetworkAccount,
		// Token: 0x04000341 RID: 833
		Social,
		// Token: 0x04000342 RID: 834
		Search,
		// Token: 0x04000343 RID: 835
		DecimalPad,
		// Token: 0x04000344 RID: 836
		OneTimeCode
	}
}
