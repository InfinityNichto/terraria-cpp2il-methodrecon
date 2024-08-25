using System;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;

namespace Microsoft.Xna.Framework.Input
{
	// Token: 0x0200034F RID: 847
	public struct JoystickState
	{
		// Token: 0x17000261 RID: 609
		// (get) Token: 0x060015BB RID: 5563 RVA: 0x000021DB File Offset: 0x000003DB
		// (set) Token: 0x060015BC RID: 5564 RVA: 0x00060FE8 File Offset: 0x0005F1E8
		public bool IsConnected
		{
			[CompilerGenerated]
			readonly get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
			[CompilerGenerated]
			internal set
			{
			}
		}

		// Token: 0x17000262 RID: 610
		// (get) Token: 0x060015BD RID: 5565 RVA: 0x00060FF8 File Offset: 0x0005F1F8
		// (set) Token: 0x060015BE RID: 5566 RVA: 0x0006100C File Offset: 0x0005F20C
		public int[] Axes
		{
			[CompilerGenerated]
			readonly get
			{
				return this.<Axes>k__BackingField;
			}
			[CompilerGenerated]
			internal set
			{
				this.<Axes>k__BackingField = value;
			}
		}

		// Token: 0x17000263 RID: 611
		// (get) Token: 0x060015BF RID: 5567 RVA: 0x00061020 File Offset: 0x0005F220
		// (set) Token: 0x060015C0 RID: 5568 RVA: 0x00061034 File Offset: 0x0005F234
		public ButtonState[] Buttons
		{
			[CompilerGenerated]
			readonly get
			{
				return this.<Buttons>k__BackingField;
			}
			[CompilerGenerated]
			internal set
			{
				this.<Buttons>k__BackingField = value;
			}
		}

		// Token: 0x17000264 RID: 612
		// (get) Token: 0x060015C1 RID: 5569 RVA: 0x00061048 File Offset: 0x0005F248
		// (set) Token: 0x060015C2 RID: 5570 RVA: 0x0006105C File Offset: 0x0005F25C
		public JoystickHat[] Hats
		{
			[CompilerGenerated]
			readonly get
			{
				return this.<Hats>k__BackingField;
			}
			[CompilerGenerated]
			internal set
			{
				this.<Hats>k__BackingField = value;
			}
		}

		// Token: 0x060015C3 RID: 5571 RVA: 0x00061070 File Offset: 0x0005F270
		public static bool operator ==(JoystickState left, JoystickState right)
		{
			int[] array = left.<Axes>k__BackingField;
			ButtonState[] array2 = left.<Buttons>k__BackingField;
			JoystickHat[] array3 = left.<Hats>k__BackingField;
			bool flag;
			return flag;
		}

		// Token: 0x060015C4 RID: 5572 RVA: 0x00061098 File Offset: 0x0005F298
		public static bool operator !=(JoystickState left, JoystickState right)
		{
			bool flag = left.<IsConnected>k__BackingField;
			bool flag2;
			return flag2;
		}

		// Token: 0x060015C5 RID: 5573 RVA: 0x000610B0 File Offset: 0x0005F2B0
		public override bool Equals(object obj)
		{
			if (obj != null)
			{
			}
			bool flag = this.<IsConnected>k__BackingField;
			bool flag2;
			return flag2;
		}

		// Token: 0x060015C6 RID: 5574 RVA: 0x000610CC File Offset: 0x0005F2CC
		public override int GetHashCode()
		{
			/*
An exception occurred when decompiling this method (060015C6)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Int32 Microsoft.Xna.Framework.Input.JoystickState::GetHashCode()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:int32[](var_0_06, ldfld:int32[](JoystickState::<Axes>k__BackingField, ldloc:valuetype Microsoft.Xna.Framework.Input.JoystickState&(this)))
	stloc:valuetype Microsoft.Xna.Framework.Input.ButtonState[](var_6_1D, ldfld:valuetype Microsoft.Xna.Framework.Input.ButtonState[](JoystickState::<Buttons>k__BackingField, ldloc:valuetype Microsoft.Xna.Framework.Input.JoystickState&(this)))
	stloc:ButtonState(var_8_2D, ldfld:ButtonState(JoystickHat::<Down>k__BackingField, ldfld:valuetype Microsoft.Xna.Framework.Input.JoystickHat[][exp:valuetype Microsoft.Xna.Framework.Input.JoystickHat&](JoystickState::<Hats>k__BackingField, ldloc:valuetype Microsoft.Xna.Framework.Input.JoystickState&(this))))
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

		// Token: 0x060015C7 RID: 5575 RVA: 0x00061108 File Offset: 0x0005F308
		public override string ToString()
		{
			/*
An exception occurred when decompiling this method (060015C7)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.String Microsoft.Xna.Framework.Input.JoystickState::ToString()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:int32[](var_0_06, ldfld:int32[](JoystickState::<Axes>k__BackingField, ldloc:valuetype Microsoft.Xna.Framework.Input.JoystickState&(this)))
	stloc:valuetype Microsoft.Xna.Framework.Input.ButtonState[](var_1_0D, ldfld:valuetype Microsoft.Xna.Framework.Input.ButtonState[](JoystickState::<Buttons>k__BackingField, ldloc:valuetype Microsoft.Xna.Framework.Input.JoystickState&(this)))
	stloc:valuetype Microsoft.Xna.Framework.Input.JoystickHat[](var_2_14, ldfld:valuetype Microsoft.Xna.Framework.Input.JoystickHat[](JoystickState::<Hats>k__BackingField, ldloc:valuetype Microsoft.Xna.Framework.Input.JoystickState&(this)))
	stloc:string(var_4_20, call:string(string::Concat, ldstr:string("[JoystickState: IsConnected="), ldloc:string(var_3)))
	stloc:int32[](var_7_28, ldfld:int32[](JoystickState::<Axes>k__BackingField, ldloc:valuetype Microsoft.Xna.Framework.Input.JoystickState&(this)))
	stloc:valuetype Microsoft.Xna.Framework.Input.ButtonState[](var_15_36, ldfld:valuetype Microsoft.Xna.Framework.Input.ButtonState[](JoystickState::<Buttons>k__BackingField, ldloc:valuetype Microsoft.Xna.Framework.Input.JoystickState&(this)))
	stloc:valuetype Microsoft.Xna.Framework.Input.JoystickHat[](var_19_41, ldfld:valuetype Microsoft.Xna.Framework.Input.JoystickHat[](JoystickState::<Hats>k__BackingField, ldloc:valuetype Microsoft.Xna.Framework.Input.JoystickState&(this)))
	stloc:string(var_22_52, call:string(string::Concat, ldloc:string(var_21), ldstr:string(" ")))
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

		// Token: 0x0400232E RID: 9006
		[CompilerGenerated]
		private bool <IsConnected>k__BackingField;

		// Token: 0x0400232F RID: 9007
		[CompilerGenerated]
		private int[] <Axes>k__BackingField;

		// Token: 0x04002330 RID: 9008
		[CompilerGenerated]
		private ButtonState[] <Buttons>k__BackingField;

		// Token: 0x04002331 RID: 9009
		[CompilerGenerated]
		private JoystickHat[] <Hats>k__BackingField;
	}
}
