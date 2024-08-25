using System;
using System.IO;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;

namespace InControl
{
	// Token: 0x0200000A RID: 10
	public class KeyBindingSource : BindingSource
	{
		// Token: 0x1700000F RID: 15
		// (get) Token: 0x06000031 RID: 49 RVA: 0x00002560 File Offset: 0x00000760
		// (set) Token: 0x06000032 RID: 50 RVA: 0x00002570 File Offset: 0x00000770
		public KeyCombo Control
		{
			[CompilerGenerated]
			get
			{
				KeyCombo keyCombo;
				return keyCombo;
			}
			[CompilerGenerated]
			protected set
			{
				int includeSize = value.includeSize;
			}
		}

		// Token: 0x06000033 RID: 51 RVA: 0x00002584 File Offset: 0x00000784
		internal KeyBindingSource()
		{
		}

		// Token: 0x06000034 RID: 52 RVA: 0x00002598 File Offset: 0x00000798
		public KeyBindingSource(KeyCombo keyCombo)
		{
			int includeSize = keyCombo.includeSize;
		}

		// Token: 0x06000035 RID: 53 RVA: 0x000025B4 File Offset: 0x000007B4
		public KeyBindingSource(params Key[] keys)
		{
		}

		// Token: 0x06000036 RID: 54 RVA: 0x000025E1 File Offset: 0x000007E1
		public override float GetValue(InputDevice inputDevice)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06000037 RID: 55 RVA: 0x000025F0 File Offset: 0x000007F0
		public override bool GetState(InputDevice inputDevice)
		{
			bool flag;
			return flag;
		}

		// Token: 0x17000010 RID: 16
		// (get) Token: 0x06000038 RID: 56 RVA: 0x00002600 File Offset: 0x00000800
		public override string Name
		{
			get
			{
				string text;
				return text;
			}
		}

		// Token: 0x17000011 RID: 17
		// (get) Token: 0x06000039 RID: 57 RVA: 0x00002610 File Offset: 0x00000810
		public override string DeviceName
		{
			get
			{
				return "Keyboard";
			}
		}

		// Token: 0x17000012 RID: 18
		// (get) Token: 0x0600003A RID: 58 RVA: 0x00002624 File Offset: 0x00000824
		public override InputDeviceClass DeviceClass
		{
			get
			{
				return InputDeviceClass.Keyboard;
			}
		}

		// Token: 0x17000013 RID: 19
		// (get) Token: 0x0600003B RID: 59 RVA: 0x00002634 File Offset: 0x00000834
		public override InputDeviceStyle DeviceStyle
		{
			get
			{
			}
		}

		// Token: 0x0600003C RID: 60 RVA: 0x00002644 File Offset: 0x00000844
		public override bool Equals(BindingSource other)
		{
			/*
An exception occurred when decompiling this method (0600003C)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean InControl.KeyBindingSource::Equals(InControl.BindingSource)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0003:
	stloc:uint64(var_1_10, ldfld:uint64(KeyCombo::includeData, ldfld:KeyCombo[exp:valuetype InControl.KeyCombo&](KeyBindingSource::<Control>k__BackingField, ldloc:KeyBindingSource(this))))
	stloc:uint64(var_2_1C, ldfld:uint64(KeyCombo::excludeData, ldfld:KeyCombo[exp:valuetype InControl.KeyCombo&](KeyBindingSource::<Control>k__BackingField, ldloc:KeyBindingSource(this))))
}

   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1852
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.Optimize(DecompilerContext context, ILBlock method, AutoPropertyProvider autoPropertyProvider, StateMachineKind& stateMachineKind, MethodDef& inlinedMethod, AsyncMethodDebugInfo& asyncInfo, ILAstOptimizationStep abortBeforeStep) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 355
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(IEnumerable`1 parameters, MethodDebugInfoBuilder& builder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 123
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 88
   --- End of inner exception stack trace ---
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 92
   at ICSharpCode.Decompiler.Ast.AstBuilder.AddMethodBody(EntityDeclaration methodNode, EntityDeclaration& updatedNode, MethodDef method, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, MethodKind methodKind) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 1683
*/;
		}

		// Token: 0x0600003D RID: 61 RVA: 0x00002670 File Offset: 0x00000870
		public override bool Equals(object other)
		{
			/*
An exception occurred when decompiling this method (0600003D)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean InControl.KeyBindingSource::Equals(System.Object)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0003:
	stloc:uint64(var_1_10, ldfld:uint64(KeyCombo::includeData, ldfld:KeyCombo[exp:valuetype InControl.KeyCombo&](KeyBindingSource::<Control>k__BackingField, ldloc:KeyBindingSource(this))))
	stloc:uint64(var_2_1C, ldfld:uint64(KeyCombo::excludeData, ldfld:KeyCombo[exp:valuetype InControl.KeyCombo&](KeyBindingSource::<Control>k__BackingField, ldloc:KeyBindingSource(this))))
}

   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1852
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.Optimize(DecompilerContext context, ILBlock method, AutoPropertyProvider autoPropertyProvider, StateMachineKind& stateMachineKind, MethodDef& inlinedMethod, AsyncMethodDebugInfo& asyncInfo, ILAstOptimizationStep abortBeforeStep) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 355
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(IEnumerable`1 parameters, MethodDebugInfoBuilder& builder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 123
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 88
   --- End of inner exception stack trace ---
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 92
   at ICSharpCode.Decompiler.Ast.AstBuilder.AddMethodBody(EntityDeclaration methodNode, EntityDeclaration& updatedNode, MethodDef method, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, MethodKind methodKind) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 1683
*/;
		}

		// Token: 0x0600003E RID: 62 RVA: 0x0000269C File Offset: 0x0000089C
		public override int GetHashCode()
		{
			int num;
			return num;
		}

		// Token: 0x17000014 RID: 20
		// (get) Token: 0x0600003F RID: 63 RVA: 0x000026AC File Offset: 0x000008AC
		public override BindingSourceType BindingSourceType
		{
			get
			{
				return BindingSourceType.KeyBindingSource;
			}
		}

		// Token: 0x06000040 RID: 64 RVA: 0x000026BC File Offset: 0x000008BC
		public override void Load(BinaryReader reader, ushort dataFormatVersion)
		{
		}

		// Token: 0x06000041 RID: 65 RVA: 0x000026CC File Offset: 0x000008CC
		public override void Save(BinaryWriter writer)
		{
		}

		// Token: 0x040000A5 RID: 165
		[CompilerGenerated]
		private KeyCombo <Control>k__BackingField;
	}
}
