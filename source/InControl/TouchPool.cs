using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Cpp2IlInjected;

namespace InControl
{
	// Token: 0x02000056 RID: 86
	public class TouchPool
	{
		// Token: 0x0600040C RID: 1036 RVA: 0x0000D478 File Offset: 0x0000B678
		public TouchPool(int capacity)
		{
		}

		// Token: 0x0600040D RID: 1037 RVA: 0x0000D498 File Offset: 0x0000B698
		public TouchPool()
		{
		}

		// Token: 0x0600040E RID: 1038 RVA: 0x000025E1 File Offset: 0x000007E1
		public Touch FindOrCreateTouch(int fingerId)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x0600040F RID: 1039 RVA: 0x000025E1 File Offset: 0x000007E1
		public Touch FindTouch(int fingerId)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06000410 RID: 1040 RVA: 0x0000D4A8 File Offset: 0x0000B6A8
		private Touch NewTouch()
		{
			/*
An exception occurred when decompiling this method (06000410)

ICSharpCode.Decompiler.DecompilerException: Error decompiling InControl.Touch InControl.TouchPool::NewTouch()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:int32(var_0_0B, ldfld:int32(List`1::_size, ldfld:class [mscorlib]System.Collections.Generic.List`1<class InControl.Touch>[exp:List`1](TouchPool::freeTouches, ldloc:TouchPool(this))))
	stloc:class [mscorlib]System.Collections.Generic.List`1<class InControl.Touch>(var_1_12, ldfld:class [mscorlib]System.Collections.Generic.List`1<class InControl.Touch>(TouchPool::freeTouches, ldloc:TouchPool(this)))
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

		// Token: 0x06000411 RID: 1041 RVA: 0x000025E1 File Offset: 0x000007E1
		public void FreeTouch(Touch touch)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06000412 RID: 1042 RVA: 0x0000D4C8 File Offset: 0x0000B6C8
		public void FreeEndedTouches()
		{
			List<Touch> list = this.usedTouches;
			int size = list._size;
			int size2 = list._size;
			List<Touch> list2 = this.usedTouches;
			List<Touch> list3 = this.usedTouches;
		}

		// Token: 0x040003B1 RID: 945
		public readonly ReadOnlyCollection<Touch> Touches;

		// Token: 0x040003B2 RID: 946
		private List<Touch> usedTouches;

		// Token: 0x040003B3 RID: 947
		private List<Touch> freeTouches;
	}
}
