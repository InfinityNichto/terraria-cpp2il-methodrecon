using System;
using System.Runtime.InteropServices;
using System.Runtime.Remoting;
using Cpp2IlInjected;

namespace System
{
	// Token: 0x0200017F RID: 383
	[ComVisible(true)]
	[Serializable]
	[StructLayout(0)]
	public abstract class MarshalByRefObject
	{
		// Token: 0x06000F07 RID: 3847 RVA: 0x000200B4 File Offset: 0x0001E2B4
		protected MarshalByRefObject()
		{
		}

		// Token: 0x1700015C RID: 348
		// (get) Token: 0x06000F08 RID: 3848 RVA: 0x0000207A File Offset: 0x0000027A
		// (set) Token: 0x06000F09 RID: 3849 RVA: 0x0000207A File Offset: 0x0000027A
		internal ServerIdentity ObjectIdentity
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
			set
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		// Token: 0x06000F0A RID: 3850 RVA: 0x0000207A File Offset: 0x0000027A
		public virtual ObjRef CreateObjRef(Type requestedType)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06000F0B RID: 3851 RVA: 0x0000207A File Offset: 0x0000027A
		public virtual object InitializeLifetimeService()
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x0400067C RID: 1660
		[NonSerialized]
		private object _identity;
	}
}
