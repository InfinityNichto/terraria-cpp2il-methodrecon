using System;
using UnityEngine.Scripting;

namespace UnityEngine
{
	// Token: 0x0200009F RID: 159
	[RequiredByNativeCode]
	[AttributeUsage(AttributeTargets.Method, AllowMultiple = false)]
	public class RuntimeInitializeOnLoadMethodAttribute : PreserveAttribute
	{
		// Token: 0x060002B7 RID: 695 RVA: 0x00005F60 File Offset: 0x00004160
		public RuntimeInitializeOnLoadMethodAttribute()
		{
		}

		// Token: 0x060002B8 RID: 696 RVA: 0x00005F74 File Offset: 0x00004174
		public RuntimeInitializeOnLoadMethodAttribute(RuntimeInitializeLoadType loadType)
		{
			this.m_LoadType = loadType;
		}

		// Token: 0x170000A4 RID: 164
		// (set) Token: 0x060002B9 RID: 697 RVA: 0x00005F90 File Offset: 0x00004190
		private RuntimeInitializeLoadType loadType
		{
			set
			{
				this.m_LoadType = value;
			}
		}

		// Token: 0x04000350 RID: 848
		private RuntimeInitializeLoadType m_LoadType;
	}
}
