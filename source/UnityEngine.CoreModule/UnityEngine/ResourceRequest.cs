using System;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using UnityEngine.Scripting;

namespace UnityEngine
{
	// Token: 0x020000D4 RID: 212
	[RequiredByNativeCode]
	[StructLayout(0)]
	public class ResourceRequest : AsyncOperation
	{
		// Token: 0x06000456 RID: 1110 RVA: 0x00008154 File Offset: 0x00006354
		protected virtual Object GetResult()
		{
			string path = this.m_Path;
			Type type = this.m_Type;
			return Resources.Load(path, type);
		}

		// Token: 0x170000DF RID: 223
		// (get) Token: 0x06000457 RID: 1111 RVA: 0x000021B3 File Offset: 0x000003B3
		public Object asset
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		// Token: 0x06000458 RID: 1112 RVA: 0x00008178 File Offset: 0x00006378
		public ResourceRequest()
		{
		}

		// Token: 0x040003CB RID: 971
		internal string m_Path;

		// Token: 0x040003CC RID: 972
		internal Type m_Type;
	}
}
