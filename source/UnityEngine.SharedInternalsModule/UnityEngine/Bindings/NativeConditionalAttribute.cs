using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace UnityEngine.Bindings
{
	// Token: 0x0200000B RID: 11
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Method | AttributeTargets.Property)]
	[VisibleToOtherModules]
	internal class NativeConditionalAttribute : Attribute
	{
		// Token: 0x17000005 RID: 5
		// (set) Token: 0x06000010 RID: 16 RVA: 0x000021B8 File Offset: 0x000003B8
		public string Condition
		{
			[CompilerGenerated]
			set
			{
				this.<Condition>k__BackingField = value;
			}
		}

		// Token: 0x17000006 RID: 6
		// (set) Token: 0x06000011 RID: 17 RVA: 0x000021CC File Offset: 0x000003CC
		public bool Enabled
		{
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06000012 RID: 18 RVA: 0x000021DC File Offset: 0x000003DC
		public NativeConditionalAttribute(string condition)
		{
			this.Condition = condition;
			this.<Enabled>k__BackingField = true;
		}

		// Token: 0x04000007 RID: 7
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		private string <Condition>k__BackingField;

		// Token: 0x04000008 RID: 8
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		private bool <Enabled>k__BackingField;
	}
}
