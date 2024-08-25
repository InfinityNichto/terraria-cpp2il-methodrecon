using System;
using Cpp2IlInjected;
using Newtonsoft.Json.Shims;

namespace Newtonsoft.Json.Utilities
{
	// Token: 0x0200006E RID: 110
	[Preserve]
	internal sealed class Creator<T> : MulticastDelegate
	{
		// Token: 0x060003E1 RID: 993 RVA: 0x0000ADCC File Offset: 0x00008FCC
		public Creator(object @object, IntPtr method)
		{
		}

		// Token: 0x060003E2 RID: 994 RVA: 0x0000212A File Offset: 0x0000032A
		public T Invoke()
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x060003E3 RID: 995 RVA: 0x0000212A File Offset: 0x0000032A
		public IAsyncResult BeginInvoke(AsyncCallback callback, object @object)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x060003E4 RID: 996 RVA: 0x0000212A File Offset: 0x0000032A
		public T EndInvoke(IAsyncResult result)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}
	}
}
