using System;
using Cpp2IlInjected;
using Newtonsoft.Json.Shims;

namespace Newtonsoft.Json.Utilities
{
	// Token: 0x0200004D RID: 77
	[Preserve]
	internal sealed class MethodCall<T, TResult> : MulticastDelegate
	{
		// Token: 0x060002EC RID: 748 RVA: 0x00008FAC File Offset: 0x000071AC
		public MethodCall(object @object, IntPtr method)
		{
		}

		// Token: 0x060002ED RID: 749 RVA: 0x0000212A File Offset: 0x0000032A
		public TResult Invoke(T target, params object[] args)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x060002EE RID: 750 RVA: 0x0000212A File Offset: 0x0000032A
		public IAsyncResult BeginInvoke(T target, object[] args, AsyncCallback callback, object @object)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x060002EF RID: 751 RVA: 0x0000212A File Offset: 0x0000032A
		public TResult EndInvoke(IAsyncResult result)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}
	}
}
