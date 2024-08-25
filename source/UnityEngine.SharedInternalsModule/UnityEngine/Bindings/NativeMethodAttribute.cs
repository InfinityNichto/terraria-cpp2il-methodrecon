using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace UnityEngine.Bindings
{
	// Token: 0x0200000F RID: 15
	[AttributeUsage(AttributeTargets.Method | AttributeTargets.Property)]
	[VisibleToOtherModules]
	internal class NativeMethodAttribute : Attribute
	{
		// Token: 0x1700000A RID: 10
		// (set) Token: 0x06000019 RID: 25 RVA: 0x000022AC File Offset: 0x000004AC
		public string Name
		{
			[CompilerGenerated]
			set
			{
				this.<Name>k__BackingField = value;
			}
		}

		// Token: 0x1700000B RID: 11
		// (set) Token: 0x0600001A RID: 26 RVA: 0x000022C0 File Offset: 0x000004C0
		public bool IsThreadSafe
		{
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700000C RID: 12
		// (set) Token: 0x0600001B RID: 27 RVA: 0x000022D0 File Offset: 0x000004D0
		public bool IsFreeFunction
		{
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700000D RID: 13
		// (set) Token: 0x0600001C RID: 28 RVA: 0x000022E0 File Offset: 0x000004E0
		public bool ThrowsException
		{
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700000E RID: 14
		// (set) Token: 0x0600001D RID: 29 RVA: 0x000022F0 File Offset: 0x000004F0
		public bool HasExplicitThis
		{
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x0600001E RID: 30 RVA: 0x00002300 File Offset: 0x00000500
		public NativeMethodAttribute()
		{
		}

		// Token: 0x0600001F RID: 31 RVA: 0x00002314 File Offset: 0x00000514
		public NativeMethodAttribute(string name)
		{
			if (name != null)
			{
				bool flag = name == "";
				this.Name = name;
				return;
			}
		}

		// Token: 0x06000020 RID: 32 RVA: 0x00002340 File Offset: 0x00000540
		public NativeMethodAttribute(string name, bool isFreeFunction)
		{
		}

		// Token: 0x06000021 RID: 33 RVA: 0x00002350 File Offset: 0x00000550
		public NativeMethodAttribute(string name, bool isFreeFunction, bool isThreadSafe)
		{
		}

		// Token: 0x0400000C RID: 12
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private string <Name>k__BackingField;

		// Token: 0x0400000D RID: 13
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private bool <IsThreadSafe>k__BackingField;

		// Token: 0x0400000E RID: 14
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private bool <IsFreeFunction>k__BackingField;

		// Token: 0x0400000F RID: 15
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		private bool <ThrowsException>k__BackingField;

		// Token: 0x04000010 RID: 16
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private bool <HasExplicitThis>k__BackingField;
	}
}
