using System;
using System.Runtime.CompilerServices;

namespace System.Reflection
{
	// Token: 0x020004C4 RID: 1220
	[AttributeUsage(AttributeTargets.Assembly, Inherited = false)]
	public sealed class AssemblyKeyFileAttribute : Attribute
	{
		// Token: 0x06002366 RID: 9062 RVA: 0x00050350 File Offset: 0x0004E550
		public AssemblyKeyFileAttribute(string keyFile)
		{
			this.<KeyFile>k__BackingField = keyFile;
		}

		// Token: 0x0400135F RID: 4959
		[CompilerGenerated]
		private readonly string <KeyFile>k__BackingField;
	}
}
