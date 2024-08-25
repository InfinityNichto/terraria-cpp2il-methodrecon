using System;
using Cpp2IlInjected;

namespace MS.Internal.Xml.Cache
{
	// Token: 0x02000172 RID: 370
	internal struct XPathNodeRef
	{
		// Token: 0x06000CC0 RID: 3264 RVA: 0x00021A74 File Offset: 0x0001FC74
		public XPathNodeRef(XPathNode[] page, int idx)
		{
			this._page = page;
			this._idx = idx;
		}

		// Token: 0x17000360 RID: 864
		// (get) Token: 0x06000CC1 RID: 3265 RVA: 0x00003FFD File Offset: 0x000021FD
		public XPathNode[] Page
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		// Token: 0x17000361 RID: 865
		// (get) Token: 0x06000CC2 RID: 3266 RVA: 0x00021A90 File Offset: 0x0001FC90
		public int Index
		{
			get
			{
				return this._idx;
			}
		}

		// Token: 0x06000CC3 RID: 3267 RVA: 0x00021AA4 File Offset: 0x0001FCA4
		public override int GetHashCode()
		{
			/*
An exception occurred when decompiling this method (06000CC3)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Int32 MS.Internal.Xml.Cache.XPathNodeRef::GetHashCode()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:int32(var_0_06, ldfld:int32(XPathNodeRef::_idx, ldloc:valuetype MS.Internal.Xml.Cache.XPathNodeRef&(this)))
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

		// Token: 0x04000691 RID: 1681
		private XPathNode[] _page;

		// Token: 0x04000692 RID: 1682
		private int _idx;
	}
}
