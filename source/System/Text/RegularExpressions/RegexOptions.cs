using System;

namespace System.Text.RegularExpressions
{
	// Token: 0x020000BE RID: 190
	[Flags]
	public enum RegexOptions
	{
		// Token: 0x04000342 RID: 834
		None = 0,
		// Token: 0x04000343 RID: 835
		IgnoreCase = 1,
		// Token: 0x04000344 RID: 836
		Multiline = 2,
		// Token: 0x04000345 RID: 837
		ExplicitCapture = 4,
		// Token: 0x04000346 RID: 838
		Compiled = 8,
		// Token: 0x04000347 RID: 839
		Singleline = 16,
		// Token: 0x04000348 RID: 840
		IgnorePatternWhitespace = 32,
		// Token: 0x04000349 RID: 841
		RightToLeft = 64,
		// Token: 0x0400034A RID: 842
		ECMAScript = 256,
		// Token: 0x0400034B RID: 843
		CultureInvariant = 512
	}
}
