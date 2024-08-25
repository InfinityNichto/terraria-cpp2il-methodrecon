using System;
using System.Collections;

namespace System.Xml.Schema
{
	// Token: 0x02000125 RID: 293
	internal class QNameFacetsChecker : FacetsChecker
	{
		// Token: 0x060009FF RID: 2559 RVA: 0x0001CC1C File Offset: 0x0001AE1C
		internal override Exception CheckValueFacets(object value, XmlSchemaDatatype datatype)
		{
			if (datatype != null)
			{
			}
			throw new InvalidCastException();
		}

		// Token: 0x06000A00 RID: 2560 RVA: 0x0001CC34 File Offset: 0x0001AE34
		internal override Exception CheckValueFacets(XmlQualifiedName value, XmlSchemaDatatype datatype)
		{
			/*
An exception occurred when decompiling this method (06000A00)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Exception System.Xml.Schema.QNameFacetsChecker::CheckValueFacets(System.Xml.XmlQualifiedName,System.Xml.Schema.XmlSchemaDatatype)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:string(var_0_09, ldfld:string(XmlQualifiedName::name, ldloc:XmlQualifiedName(value)))
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

		// Token: 0x06000A01 RID: 2561 RVA: 0x0001CC4C File Offset: 0x0001AE4C
		internal override bool MatchEnumeration(object value, ArrayList enumeration, XmlSchemaDatatype datatype)
		{
			if (datatype != null)
			{
			}
			bool flag;
			return flag;
		}

		// Token: 0x06000A02 RID: 2562 RVA: 0x0001CC64 File Offset: 0x0001AE64
		private bool MatchEnumeration(XmlQualifiedName value, ArrayList enumeration)
		{
			throw new InvalidCastException();
		}

		// Token: 0x06000A03 RID: 2563 RVA: 0x0001CC7C File Offset: 0x0001AE7C
		public QNameFacetsChecker()
		{
		}
	}
}
