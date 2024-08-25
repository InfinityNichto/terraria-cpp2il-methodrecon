using System;
using Cpp2IlInjected;

namespace System.Net
{
	// Token: 0x02000215 RID: 533
	internal struct HeaderVariantInfo
	{
		// Token: 0x06000D29 RID: 3369 RVA: 0x00029F94 File Offset: 0x00028194
		internal HeaderVariantInfo(string name, CookieVariant variant)
		{
			this.m_name = name;
			this.m_variant = variant;
		}

		// Token: 0x170002BF RID: 703
		// (get) Token: 0x06000D2A RID: 3370 RVA: 0x00002050 File Offset: 0x00000250
		internal string Name
		{
			get
			{
				throw new global::Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		// Token: 0x170002C0 RID: 704
		// (get) Token: 0x06000D2B RID: 3371 RVA: 0x00029FB0 File Offset: 0x000281B0
		internal CookieVariant Variant
		{
			get
			{
				return this.m_variant;
			}
		}

		// Token: 0x04000B42 RID: 2882
		private string m_name;

		// Token: 0x04000B43 RID: 2883
		private CookieVariant m_variant;
	}
}
