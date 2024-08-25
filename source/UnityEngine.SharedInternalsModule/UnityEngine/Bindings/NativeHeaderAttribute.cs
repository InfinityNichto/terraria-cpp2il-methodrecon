using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace UnityEngine.Bindings
{
	// Token: 0x0200000C RID: 12
	[VisibleToOtherModules]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Enum | AttributeTargets.Method | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Parameter | AttributeTargets.ReturnValue, AllowMultiple = true)]
	internal class NativeHeaderAttribute : Attribute
	{
		// Token: 0x17000007 RID: 7
		// (set) Token: 0x06000013 RID: 19 RVA: 0x00002200 File Offset: 0x00000400
		public string Header
		{
			[CompilerGenerated]
			set
			{
				this.<Header>k__BackingField = value;
			}
		}

		// Token: 0x06000014 RID: 20 RVA: 0x00002214 File Offset: 0x00000414
		public NativeHeaderAttribute(string header)
		{
			if (header != null)
			{
				bool flag = header == "";
				this.Header = header;
				return;
			}
		}

		// Token: 0x04000009 RID: 9
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		private string <Header>k__BackingField;
	}
}
