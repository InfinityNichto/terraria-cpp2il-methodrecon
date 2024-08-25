using System;

namespace System.Runtime.CompilerServices
{
	// Token: 0x0200049B RID: 1179
	[AttributeUsage(AttributeTargets.Assembly, AllowMultiple = true, Inherited = false)]
	public sealed class InternalsVisibleToAttribute : Attribute
	{
		// Token: 0x0600228A RID: 8842 RVA: 0x0004DAAC File Offset: 0x0004BCAC
		public InternalsVisibleToAttribute(string assemblyName)
		{
			this._assemblyName = assemblyName;
		}

		// Token: 0x1700047B RID: 1147
		// (set) Token: 0x0600228B RID: 8843 RVA: 0x0004DAD0 File Offset: 0x0004BCD0
		public bool AllInternalsVisible
		{
			set
			{
			}
		}

		// Token: 0x040012E7 RID: 4839
		private string _assemblyName;

		// Token: 0x040012E8 RID: 4840
		private bool _allInternalsVisible = true;
	}
}
