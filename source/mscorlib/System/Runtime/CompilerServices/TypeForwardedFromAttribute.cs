using System;

namespace System.Runtime.CompilerServices
{
	// Token: 0x02000481 RID: 1153
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Enum | AttributeTargets.Interface | AttributeTargets.Delegate, Inherited = false, AllowMultiple = false)]
	public sealed class TypeForwardedFromAttribute : Attribute
	{
		// Token: 0x0600222B RID: 8747 RVA: 0x0004D060 File Offset: 0x0004B260
		public TypeForwardedFromAttribute(string assemblyFullName)
		{
			bool flag = string.IsNullOrEmpty(assemblyFullName);
			this.AssemblyFullName = assemblyFullName;
		}

		// Token: 0x17000470 RID: 1136
		// (get) Token: 0x0600222C RID: 8748 RVA: 0x0004D084 File Offset: 0x0004B284
		public string AssemblyFullName
		{
			[CompilerGenerated]
			get
			{
				return this.<AssemblyFullName>k__BackingField;
			}
		}

		// Token: 0x040012B8 RID: 4792
		[CompilerGenerated]
		private readonly string <AssemblyFullName>k__BackingField;
	}
}
