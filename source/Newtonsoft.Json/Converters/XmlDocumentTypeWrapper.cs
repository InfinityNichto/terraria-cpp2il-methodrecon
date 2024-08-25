using System;
using System.Xml;

namespace Newtonsoft.Json.Converters
{
	// Token: 0x0200010C RID: 268
	internal class XmlDocumentTypeWrapper : XmlNodeWrapper, IXmlDocumentType, IXmlNode
	{
		// Token: 0x06000A8B RID: 2699 RVA: 0x00019CF8 File Offset: 0x00017EF8
		public XmlDocumentTypeWrapper(XmlDocumentType documentType)
		{
			this._node = documentType;
			this._documentType = documentType;
		}

		// Token: 0x170001DF RID: 479
		// (get) Token: 0x06000A8C RID: 2700 RVA: 0x00019D1C File Offset: 0x00017F1C
		public string Name
		{
			get
			{
				/*
An exception occurred when decompiling this method (06000A8C)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.String Newtonsoft.Json.Converters.XmlDocumentTypeWrapper::get_Name()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:XmlDocumentType(var_0_06, ldfld:XmlDocumentType(XmlDocumentTypeWrapper::_documentType, ldloc:XmlDocumentTypeWrapper(this)))
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
		}

		// Token: 0x170001E0 RID: 480
		// (get) Token: 0x06000A8D RID: 2701 RVA: 0x00019D30 File Offset: 0x00017F30
		public string System
		{
			get
			{
				return this._documentType.systemId;
			}
		}

		// Token: 0x170001E1 RID: 481
		// (get) Token: 0x06000A8E RID: 2702 RVA: 0x00019D48 File Offset: 0x00017F48
		public string Public
		{
			get
			{
				return this._documentType.publicId;
			}
		}

		// Token: 0x170001E2 RID: 482
		// (get) Token: 0x06000A8F RID: 2703 RVA: 0x00019D60 File Offset: 0x00017F60
		public string InternalSubset
		{
			get
			{
				return this._documentType.internalSubset;
			}
		}

		// Token: 0x170001E3 RID: 483
		// (get) Token: 0x06000A90 RID: 2704 RVA: 0x00019D78 File Offset: 0x00017F78
		public override string LocalName
		{
			get
			{
				return "DOCTYPE";
			}
		}

		// Token: 0x04000410 RID: 1040
		private readonly XmlDocumentType _documentType;
	}
}
