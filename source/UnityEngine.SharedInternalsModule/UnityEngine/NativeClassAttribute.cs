using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine.Bindings;

namespace UnityEngine
{
	// Token: 0x02000006 RID: 6
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct, Inherited = false)]
	[VisibleToOtherModules]
	internal sealed class NativeClassAttribute : Attribute
	{
		// Token: 0x17000001 RID: 1
		// (set) Token: 0x06000005 RID: 5 RVA: 0x000020B0 File Offset: 0x000002B0
		private string QualifiedNativeName
		{
			[CompilerGenerated]
			set
			{
				this.<QualifiedNativeName>k__BackingField = value;
			}
		}

		// Token: 0x17000002 RID: 2
		// (set) Token: 0x06000006 RID: 6 RVA: 0x000020C4 File Offset: 0x000002C4
		private string Declaration
		{
			[CompilerGenerated]
			set
			{
				this.<Declaration>k__BackingField = value;
			}
		}

		// Token: 0x06000007 RID: 7 RVA: 0x000020D8 File Offset: 0x000002D8
		public NativeClassAttribute(string qualifiedCppName)
		{
			this.QualifiedNativeName = qualifiedCppName;
			string text = "class " + qualifiedCppName;
			this.Declaration = text;
		}

		// Token: 0x06000008 RID: 8 RVA: 0x00002108 File Offset: 0x00000308
		public NativeClassAttribute(string qualifiedCppName, string declaration)
		{
			this.QualifiedNativeName = qualifiedCppName;
			this.Declaration = declaration;
		}

		// Token: 0x04000003 RID: 3
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		private string <QualifiedNativeName>k__BackingField;

		// Token: 0x04000004 RID: 4
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		private string <Declaration>k__BackingField;
	}
}
