using System;

namespace System.Runtime.CompilerServices
{
	// Token: 0x0200049D RID: 1181
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Interface, AllowMultiple = true, Inherited = false)]
	internal sealed class TypeDependencyAttribute : Attribute
	{
		// Token: 0x0600228D RID: 8845 RVA: 0x0004DAF4 File Offset: 0x0004BCF4
		public TypeDependencyAttribute(string typeName)
		{
			do
			{
				base..ctor();
			}
			while (typeName == null);
			this.typeName = typeName;
		}

		// Token: 0x040012E9 RID: 4841
		private string typeName;
	}
}
