using System;

namespace System.Globalization
{
	// Token: 0x02000585 RID: 1413
	[Flags]
	public enum CultureTypes
	{
		// Token: 0x040016D0 RID: 5840
		NeutralCultures = 1,
		// Token: 0x040016D1 RID: 5841
		SpecificCultures = 2,
		// Token: 0x040016D2 RID: 5842
		InstalledWin32Cultures = 4,
		// Token: 0x040016D3 RID: 5843
		AllCultures = 7,
		// Token: 0x040016D4 RID: 5844
		UserCustomCulture = 8,
		// Token: 0x040016D5 RID: 5845
		ReplacementCultures = 16,
		// Token: 0x040016D6 RID: 5846
		[Obsolete("This value has been deprecated.  Please use other values in CultureTypes.")]
		WindowsOnlyCultures = 32,
		// Token: 0x040016D7 RID: 5847
		[Obsolete("This value has been deprecated.  Please use other values in CultureTypes.")]
		FrameworkCultures = 64
	}
}
