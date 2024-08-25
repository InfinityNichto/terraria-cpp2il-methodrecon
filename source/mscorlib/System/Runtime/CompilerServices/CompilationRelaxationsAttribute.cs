using System;
using System.Runtime.InteropServices;

namespace System.Runtime.CompilerServices
{
	// Token: 0x0200049A RID: 1178
	[AttributeUsage(AttributeTargets.Assembly | AttributeTargets.Module | AttributeTargets.Class | AttributeTargets.Method)]
	[ComVisible(true)]
	[Serializable]
	public class CompilationRelaxationsAttribute : Attribute
	{
		// Token: 0x06002287 RID: 8839 RVA: 0x0004DA60 File Offset: 0x0004BC60
		public CompilationRelaxationsAttribute(int relaxations)
		{
			this.m_relaxations = relaxations;
		}

		// Token: 0x06002288 RID: 8840 RVA: 0x0004DA7C File Offset: 0x0004BC7C
		public CompilationRelaxationsAttribute(CompilationRelaxations relaxations)
		{
			this.m_relaxations = (int)relaxations;
		}

		// Token: 0x1700047A RID: 1146
		// (get) Token: 0x06002289 RID: 8841 RVA: 0x0004DA98 File Offset: 0x0004BC98
		public int CompilationRelaxations
		{
			get
			{
				return this.m_relaxations;
			}
		}

		// Token: 0x040012E6 RID: 4838
		private int m_relaxations;
	}
}
