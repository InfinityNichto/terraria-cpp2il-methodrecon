using System;
using Cpp2IlInjected;
using Newtonsoft.Json.Shims;
using Newtonsoft.Json.Utilities;

namespace Newtonsoft.Json.Serialization
{
	// Token: 0x02000086 RID: 134
	[Preserve]
	internal class DefaultReferenceResolver : IReferenceResolver
	{
		// Token: 0x060004C7 RID: 1223 RVA: 0x0000C958 File Offset: 0x0000AB58
		private BidirectionalDictionary<string, object> GetMappings(object context)
		{
			while (context == null)
			{
			}
			JsonSerializerInternalBase jsonSerializerInternalBase;
			return jsonSerializerInternalBase.DefaultReferenceMappings;
		}

		// Token: 0x060004C8 RID: 1224 RVA: 0x0000212A File Offset: 0x0000032A
		public object ResolveReference(object context, string reference)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x060004C9 RID: 1225 RVA: 0x0000C970 File Offset: 0x0000AB70
		public string GetReference(object context, object value)
		{
			/*
An exception occurred when decompiling this method (060004C9)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.String Newtonsoft.Json.Serialization.DefaultReferenceResolver::GetReference(System.Object,System.Object)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0008:
	stloc:CultureInfo(var_3_0F, callgetter:CultureInfo(CultureInfo::get_InvariantCulture))
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

		// Token: 0x060004CA RID: 1226 RVA: 0x0000C98C File Offset: 0x0000AB8C
		public void AddReference(object context, string reference, object value)
		{
		}

		// Token: 0x060004CB RID: 1227 RVA: 0x0000C99C File Offset: 0x0000AB9C
		public bool IsReferenced(object context, object value)
		{
			bool flag;
			return flag;
		}

		// Token: 0x060004CC RID: 1228 RVA: 0x0000C9AC File Offset: 0x0000ABAC
		public DefaultReferenceResolver()
		{
		}

		// Token: 0x04000222 RID: 546
		private int _referenceCount;
	}
}
