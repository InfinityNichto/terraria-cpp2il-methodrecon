using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace UnityEngine.Bindings
{
	// Token: 0x02000019 RID: 25
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Method | AttributeTargets.Property)]
	[VisibleToOtherModules]
	internal class StaticAccessorAttribute : Attribute
	{
		// Token: 0x17000014 RID: 20
		// (set) Token: 0x06000034 RID: 52 RVA: 0x00002528 File Offset: 0x00000728
		public string Name
		{
			[CompilerGenerated]
			set
			{
				this.<Name>k__BackingField = value;
			}
		}

		// Token: 0x17000015 RID: 21
		// (set) Token: 0x06000035 RID: 53 RVA: 0x0000253C File Offset: 0x0000073C
		public StaticAccessorType Type
		{
			[CompilerGenerated]
			set
			{
				this.<Type>k__BackingField = value;
			}
		}

		// Token: 0x06000036 RID: 54 RVA: 0x00002550 File Offset: 0x00000750
		[VisibleToOtherModules]
		internal StaticAccessorAttribute(string name)
		{
			this.Name = name;
		}

		// Token: 0x06000037 RID: 55 RVA: 0x0000256C File Offset: 0x0000076C
		public StaticAccessorAttribute(string name, StaticAccessorType type)
		{
			this.Name = name;
			this.Type = type;
		}

		// Token: 0x04000022 RID: 34
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		private string <Name>k__BackingField;

		// Token: 0x04000023 RID: 35
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		private StaticAccessorType <Type>k__BackingField;
	}
}
