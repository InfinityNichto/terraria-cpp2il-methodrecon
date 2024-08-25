using System;
using System.Collections;
using Cpp2IlInjected;

namespace UnityEngine
{
	// Token: 0x020000C8 RID: 200
	public abstract class CustomYieldInstruction : IEnumerator
	{
		// Token: 0x170000B6 RID: 182
		// (get) Token: 0x0600037D RID: 893
		public abstract bool keepWaiting { get; }

		// Token: 0x170000B7 RID: 183
		// (get) Token: 0x0600037E RID: 894 RVA: 0x0000716C File Offset: 0x0000536C
		public object Current
		{
			get
			{
			}
		}

		// Token: 0x0600037F RID: 895 RVA: 0x000021B3 File Offset: 0x000003B3
		public bool MoveNext()
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06000380 RID: 896 RVA: 0x0000717C File Offset: 0x0000537C
		public virtual void Reset()
		{
		}

		// Token: 0x06000381 RID: 897 RVA: 0x0000718C File Offset: 0x0000538C
		protected CustomYieldInstruction()
		{
		}
	}
}
