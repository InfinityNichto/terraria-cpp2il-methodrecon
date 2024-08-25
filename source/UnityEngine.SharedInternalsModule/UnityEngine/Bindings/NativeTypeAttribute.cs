using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace UnityEngine.Bindings
{
	// Token: 0x02000014 RID: 20
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Enum)]
	[VisibleToOtherModules]
	internal class NativeTypeAttribute : Attribute
	{
		// Token: 0x17000010 RID: 16
		// (set) Token: 0x06000027 RID: 39 RVA: 0x000023CC File Offset: 0x000005CC
		public string Header
		{
			[CompilerGenerated]
			set
			{
				this.<Header>k__BackingField = value;
			}
		}

		// Token: 0x17000011 RID: 17
		// (set) Token: 0x06000028 RID: 40 RVA: 0x000023E0 File Offset: 0x000005E0
		public string IntermediateScriptingStructName
		{
			[CompilerGenerated]
			set
			{
				this.<IntermediateScriptingStructName>k__BackingField = value;
			}
		}

		// Token: 0x17000012 RID: 18
		// (set) Token: 0x06000029 RID: 41 RVA: 0x000023F4 File Offset: 0x000005F4
		public CodegenOptions CodegenOptions
		{
			[CompilerGenerated]
			set
			{
				this.<CodegenOptions>k__BackingField = value;
			}
		}

		// Token: 0x0600002A RID: 42 RVA: 0x00002408 File Offset: 0x00000608
		public NativeTypeAttribute()
		{
		}

		// Token: 0x0600002B RID: 43 RVA: 0x0000241C File Offset: 0x0000061C
		public NativeTypeAttribute(CodegenOptions codegenOptions)
		{
			this.CodegenOptions = codegenOptions;
		}

		// Token: 0x0600002C RID: 44 RVA: 0x00002438 File Offset: 0x00000638
		public NativeTypeAttribute(string header)
		{
			if (header != null)
			{
				bool flag = header == "";
				this.Header = header;
				return;
			}
		}

		// Token: 0x0600002D RID: 45 RVA: 0x00002464 File Offset: 0x00000664
		public NativeTypeAttribute(CodegenOptions codegenOptions, string intermediateStructName)
		{
			this.CodegenOptions = codegenOptions;
			this.IntermediateScriptingStructName = intermediateStructName;
		}

		// Token: 0x04000019 RID: 25
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		private string <Header>k__BackingField;

		// Token: 0x0400001A RID: 26
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private string <IntermediateScriptingStructName>k__BackingField;

		// Token: 0x0400001B RID: 27
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private CodegenOptions <CodegenOptions>k__BackingField;
	}
}
