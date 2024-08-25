using System;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;

namespace Microsoft.Xna.Framework.Input
{
	// Token: 0x0200034E RID: 846
	public struct JoystickHat
	{
		// Token: 0x1700025D RID: 605
		// (get) Token: 0x060015AE RID: 5550 RVA: 0x000021DB File Offset: 0x000003DB
		// (set) Token: 0x060015AF RID: 5551 RVA: 0x00060ED0 File Offset: 0x0005F0D0
		public ButtonState Down
		{
			[CompilerGenerated]
			readonly get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
			[CompilerGenerated]
			internal set
			{
				this.<Down>k__BackingField = value;
			}
		}

		// Token: 0x1700025E RID: 606
		// (get) Token: 0x060015B0 RID: 5552 RVA: 0x00060EE4 File Offset: 0x0005F0E4
		// (set) Token: 0x060015B1 RID: 5553 RVA: 0x00060EF8 File Offset: 0x0005F0F8
		public ButtonState Left
		{
			[CompilerGenerated]
			readonly get
			{
				return this.<Left>k__BackingField;
			}
			[CompilerGenerated]
			internal set
			{
				this.<Left>k__BackingField = value;
			}
		}

		// Token: 0x1700025F RID: 607
		// (get) Token: 0x060015B2 RID: 5554 RVA: 0x00060F0C File Offset: 0x0005F10C
		// (set) Token: 0x060015B3 RID: 5555 RVA: 0x00060F20 File Offset: 0x0005F120
		public ButtonState Right
		{
			[CompilerGenerated]
			readonly get
			{
				return this.<Right>k__BackingField;
			}
			[CompilerGenerated]
			internal set
			{
				this.<Right>k__BackingField = value;
			}
		}

		// Token: 0x17000260 RID: 608
		// (get) Token: 0x060015B4 RID: 5556 RVA: 0x00060F34 File Offset: 0x0005F134
		// (set) Token: 0x060015B5 RID: 5557 RVA: 0x00060F48 File Offset: 0x0005F148
		public ButtonState Up
		{
			[CompilerGenerated]
			readonly get
			{
				return this.<Up>k__BackingField;
			}
			[CompilerGenerated]
			internal set
			{
				this.<Up>k__BackingField = value;
			}
		}

		// Token: 0x060015B6 RID: 5558 RVA: 0x00060F5C File Offset: 0x0005F15C
		public static bool operator ==(JoystickHat left, JoystickHat right)
		{
		}

		// Token: 0x060015B7 RID: 5559 RVA: 0x00060F6C File Offset: 0x0005F16C
		public static bool operator !=(JoystickHat left, JoystickHat right)
		{
			return true;
		}

		// Token: 0x060015B8 RID: 5560 RVA: 0x00060F7C File Offset: 0x0005F17C
		public override bool Equals(object obj)
		{
			/*
An exception occurred when decompiling this method (060015B8)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean Microsoft.Xna.Framework.Input.JoystickHat::Equals(System.Object)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:ButtonState(var_0_06, ldfld:ButtonState(JoystickHat::<Right>k__BackingField, ldloc:valuetype Microsoft.Xna.Framework.Input.JoystickHat&(this)))
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

		// Token: 0x060015B9 RID: 5561 RVA: 0x00060F94 File Offset: 0x0005F194
		public override int GetHashCode()
		{
			/*
An exception occurred when decompiling this method (060015B9)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Int32 Microsoft.Xna.Framework.Input.JoystickHat::GetHashCode()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:ButtonState(var_0_06, ldfld:ButtonState(JoystickHat::<Down>k__BackingField, ldloc:valuetype Microsoft.Xna.Framework.Input.JoystickHat&(this)))
	stloc:ButtonState(var_1_0D, ldfld:ButtonState(JoystickHat::<Right>k__BackingField, ldloc:valuetype Microsoft.Xna.Framework.Input.JoystickHat&(this)))
	stloc:ButtonState(var_2_14, ldfld:ButtonState(JoystickHat::<Right>k__BackingField, ldloc:valuetype Microsoft.Xna.Framework.Input.JoystickHat&(this)))
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

		// Token: 0x060015BA RID: 5562 RVA: 0x00060FB8 File Offset: 0x0005F1B8
		public override string ToString()
		{
			ButtonState buttonState = this.<Left>k__BackingField;
			ButtonState buttonState2 = this.<Up>k__BackingField;
			ButtonState buttonState3 = this.<Right>k__BackingField;
			string text;
			string text2;
			string text3;
			string text4;
			return text + text2 + text3 + text4;
		}

		// Token: 0x0400232A RID: 9002
		[CompilerGenerated]
		private ButtonState <Down>k__BackingField;

		// Token: 0x0400232B RID: 9003
		[CompilerGenerated]
		private ButtonState <Left>k__BackingField;

		// Token: 0x0400232C RID: 9004
		[CompilerGenerated]
		private ButtonState <Right>k__BackingField;

		// Token: 0x0400232D RID: 9005
		[CompilerGenerated]
		private ButtonState <Up>k__BackingField;
	}
}
