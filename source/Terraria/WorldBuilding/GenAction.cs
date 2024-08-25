using System;
using Microsoft.Xna.Framework;

namespace Terraria.WorldBuilding
{
	// Token: 0x0200048B RID: 1163
	public abstract class GenAction : GenBase
	{
		// Token: 0x06002F89 RID: 12169
		public abstract bool Apply(Point origin, int x, int y, params object[] args);

		// Token: 0x06002F8A RID: 12170 RVA: 0x001F42E4 File Offset: 0x001F24E4
		protected bool UnitApply(Point origin, int x, int y, params object[] args)
		{
			if (this.OutputData != null)
			{
			}
			if (this.NextAction != null)
			{
				return;
			}
		}

		// Token: 0x06002F8B RID: 12171 RVA: 0x001F4304 File Offset: 0x001F2504
		public GenAction IgnoreFailures()
		{
			return this;
		}

		// Token: 0x06002F8C RID: 12172 RVA: 0x001F4314 File Offset: 0x001F2514
		protected bool Fail()
		{
			/*
An exception occurred when decompiling this method (06002F8C)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean Terraria.WorldBuilding.GenAction::Fail()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:bool(var_0_06, ldfld:bool(GenAction::_returnFalseOnFailure, ldloc:GenAction(this)))
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

		// Token: 0x06002F8D RID: 12173 RVA: 0x001F4328 File Offset: 0x001F2528
		public GenAction Output(ShapeData data)
		{
			this.OutputData = data;
			return this;
		}

		// Token: 0x06002F8E RID: 12174 RVA: 0x001F4340 File Offset: 0x001F2540
		protected GenAction()
		{
		}

		// Token: 0x04003973 RID: 14707
		public GenAction NextAction;

		// Token: 0x04003974 RID: 14708
		public ShapeData OutputData;

		// Token: 0x04003975 RID: 14709
		private bool _returnFalseOnFailure = true;
	}
}
