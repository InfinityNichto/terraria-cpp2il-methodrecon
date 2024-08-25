using System;

namespace Terraria.WorldBuilding
{
	// Token: 0x020004A7 RID: 1191
	public abstract class GenCondition : GenBase
	{
		// Token: 0x06002FCE RID: 12238 RVA: 0x001F4C98 File Offset: 0x001F2E98
		public bool IsValid(int x, int y)
		{
			/*
An exception occurred when decompiling this method (06002FCE)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean Terraria.WorldBuilding.GenCondition::IsValid(System.Int32,System.Int32)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0054:
	stloc:bool(var_11_5D, ldfld:bool(GenCondition::InvertResults, ldloc:GenCondition(this)))
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

		// Token: 0x06002FCF RID: 12239 RVA: 0x001F4D04 File Offset: 0x001F2F04
		public GenCondition Not()
		{
			bool invertResults = this.InvertResults;
			this.InvertResults = invertResults;
			return this;
		}

		// Token: 0x06002FD0 RID: 12240 RVA: 0x001F4D20 File Offset: 0x001F2F20
		public GenCondition AreaOr(int width, int height)
		{
			this._height = height;
			this._width = width;
			return this;
		}

		// Token: 0x06002FD1 RID: 12241 RVA: 0x001F4D3C File Offset: 0x001F2F3C
		public GenCondition AreaAnd(int width, int height)
		{
			this._height = height;
			this._width = width;
			return this;
		}

		// Token: 0x06002FD2 RID: 12242
		protected abstract bool CheckValidity(int x, int y);

		// Token: 0x06002FD3 RID: 12243 RVA: 0x001F4D58 File Offset: 0x001F2F58
		protected GenCondition()
		{
		}

		// Token: 0x04003992 RID: 14738
		private bool InvertResults;

		// Token: 0x04003993 RID: 14739
		private int _width;

		// Token: 0x04003994 RID: 14740
		private int _height;

		// Token: 0x04003995 RID: 14741
		private GenCondition.AreaType _areaType = GenCondition.AreaType.None;

		// Token: 0x020004A8 RID: 1192
		private enum AreaType
		{
			// Token: 0x04003997 RID: 14743
			And,
			// Token: 0x04003998 RID: 14744
			Or,
			// Token: 0x04003999 RID: 14745
			None
		}
	}
}
