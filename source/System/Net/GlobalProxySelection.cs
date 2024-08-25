using System;
using Cpp2IlInjected;

namespace System.Net
{
	// Token: 0x02000190 RID: 400
	[Obsolete("This class has been deprecated. Please use WebRequest.DefaultWebProxy instead to access and set the global default proxy. Use 'null' instead of GetEmptyWebProxy. https://go.microsoft.com/fwlink/?linkid=14202")]
	public class GlobalProxySelection
	{
		// Token: 0x17000214 RID: 532
		// (get) Token: 0x06000A45 RID: 2629 RVA: 0x00022BB0 File Offset: 0x00020DB0
		// (set) Token: 0x06000A46 RID: 2630 RVA: 0x00022BD0 File Offset: 0x00020DD0
		public static IWebProxy Select
		{
			get
			{
				if (!true)
				{
				}
				IWebProxy defaultWebProxy = WebRequest.DefaultWebProxy;
				if (defaultWebProxy != null)
				{
					return defaultWebProxy;
				}
				return GlobalProxySelection.GetEmptyWebProxy();
			}
			set
			{
				if (!true)
				{
				}
				WebRequest.DefaultWebProxy = value;
			}
		}

		// Token: 0x06000A47 RID: 2631 RVA: 0x00002050 File Offset: 0x00000250
		public static IWebProxy GetEmptyWebProxy()
		{
			throw new global::Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06000A48 RID: 2632 RVA: 0x00022BE8 File Offset: 0x00020DE8
		public GlobalProxySelection()
		{
		}
	}
}
