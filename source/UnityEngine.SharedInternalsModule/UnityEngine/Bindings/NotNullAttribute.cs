using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace UnityEngine.Bindings
{
	// Token: 0x02000015 RID: 21
	[VisibleToOtherModules]
	[AttributeUsage(AttributeTargets.Parameter)]
	internal class NotNullAttribute : Attribute
	{
		// Token: 0x17000013 RID: 19
		// (set) Token: 0x0600002E RID: 46 RVA: 0x00002488 File Offset: 0x00000688
		public string Exception
		{
			[CompilerGenerated]
			set
			{
				this.<Exception>k__BackingField = value;
			}
		}

		// Token: 0x0600002F RID: 47 RVA: 0x0000249C File Offset: 0x0000069C
		public NotNullAttribute(string exception = "ArgumentNullException")
		{
			this.Exception = exception;
		}

		// Token: 0x0400001C RID: 28
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private string <Exception>k__BackingField;
	}
}
