using System;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;

namespace Microsoft.Xna.Framework.Input
{
	// Token: 0x02000348 RID: 840
	public struct GamePadTriggers
	{
		// Token: 0x17000252 RID: 594
		// (get) Token: 0x06001583 RID: 5507 RVA: 0x000021DB File Offset: 0x000003DB
		// (set) Token: 0x06001584 RID: 5508 RVA: 0x00060A48 File Offset: 0x0005EC48
		public float Left
		{
			[CompilerGenerated]
			readonly get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000253 RID: 595
		// (get) Token: 0x06001585 RID: 5509 RVA: 0x00060A58 File Offset: 0x0005EC58
		// (set) Token: 0x06001586 RID: 5510 RVA: 0x00060A6C File Offset: 0x0005EC6C
		public float Right
		{
			[CompilerGenerated]
			readonly get
			{
				/*
An exception occurred when decompiling this method (06001585)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Single Microsoft.Xna.Framework.Input.GamePadTriggers::get_Right()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:float32(var_0_06, ldfld:float32(GamePadTriggers::<Right>k__BackingField, ldloc:valuetype Microsoft.Xna.Framework.Input.GamePadTriggers&(this)))
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
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06001587 RID: 5511 RVA: 0x00060A7C File Offset: 0x0005EC7C
		public GamePadTriggers(float leftTrigger, float rightTrigger)
		{
		}

		// Token: 0x06001588 RID: 5512 RVA: 0x000021DB File Offset: 0x000003DB
		public static bool operator ==(GamePadTriggers left, GamePadTriggers right)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06001589 RID: 5513 RVA: 0x000021DB File Offset: 0x000003DB
		public static bool operator !=(GamePadTriggers left, GamePadTriggers right)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x0600158A RID: 5514 RVA: 0x00060A90 File Offset: 0x0005EC90
		public override bool Equals(object obj)
		{
			/*
An exception occurred when decompiling this method (0600158A)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean Microsoft.Xna.Framework.Input.GamePadTriggers::Equals(System.Object)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0003:
	stloc:float32(var_1_0B, ldfld:float32(GamePadTriggers::<Left>k__BackingField, ldloc:valuetype Microsoft.Xna.Framework.Input.GamePadTriggers&(this)))
	stloc:float32(var_2_12, ldfld:float32(GamePadTriggers::<Right>k__BackingField, ldloc:valuetype Microsoft.Xna.Framework.Input.GamePadTriggers&(this)))
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

		// Token: 0x0600158B RID: 5515 RVA: 0x00060AB0 File Offset: 0x0005ECB0
		public override int GetHashCode()
		{
			int num;
			return num;
		}

		// Token: 0x0600158C RID: 5516 RVA: 0x00060AC0 File Offset: 0x0005ECC0
		public override string ToString()
		{
			string text;
			if (("[GamePadTriggers: Left=" == null || "[GamePadTriggers: Left=" != null) && (text == null || text != null) && (", Right=" == null || ", Right=" != null))
			{
				float num = this.<Right>k__BackingField;
				string text2;
				if ((text2 == null || text2 != null) && ("]" == null || "]" != null))
				{
					string text3;
					return text3;
				}
			}
			throw new ArrayTypeMismatchException();
		}

		// Token: 0x04002313 RID: 8979
		[CompilerGenerated]
		private float <Left>k__BackingField;

		// Token: 0x04002314 RID: 8980
		[CompilerGenerated]
		private float <Right>k__BackingField;
	}
}
