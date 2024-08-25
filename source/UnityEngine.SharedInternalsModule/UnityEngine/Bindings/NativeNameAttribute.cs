using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace UnityEngine.Bindings
{
	// Token: 0x0200000D RID: 13
	[AttributeUsage(AttributeTargets.Method | AttributeTargets.Property | AttributeTargets.Field)]
	[VisibleToOtherModules]
	internal class NativeNameAttribute : Attribute
	{
		// Token: 0x17000008 RID: 8
		// (set) Token: 0x06000015 RID: 21 RVA: 0x00002240 File Offset: 0x00000440
		public string Name
		{
			[CompilerGenerated]
			set
			{
				this.<Name>k__BackingField = value;
			}
		}

		// Token: 0x06000016 RID: 22 RVA: 0x00002254 File Offset: 0x00000454
		public NativeNameAttribute(string name)
		{
			if (name != null)
			{
				bool flag = name == "";
				this.Name = name;
				return;
			}
		}

		// Token: 0x0400000A RID: 10
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		private string <Name>k__BackingField;
	}
}
