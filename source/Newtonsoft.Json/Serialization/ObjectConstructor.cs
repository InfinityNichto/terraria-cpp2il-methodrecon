using System;
using Cpp2IlInjected;
using Newtonsoft.Json.Shims;

namespace Newtonsoft.Json.Serialization
{
	// Token: 0x020000B6 RID: 182
	[Preserve]
	public sealed class ObjectConstructor<T> : MulticastDelegate
	{
		// Token: 0x060006C0 RID: 1728 RVA: 0x00011EC4 File Offset: 0x000100C4
		public ObjectConstructor(object @object, IntPtr method)
		{
		}

		// Token: 0x060006C1 RID: 1729 RVA: 0x0000212A File Offset: 0x0000032A
		public object Invoke(params object[] args)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x060006C2 RID: 1730 RVA: 0x0000212A File Offset: 0x0000032A
		public IAsyncResult BeginInvoke(object[] args, AsyncCallback callback, object @object)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x060006C3 RID: 1731 RVA: 0x0000212A File Offset: 0x0000032A
		public object EndInvoke(IAsyncResult result)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}
	}
}
