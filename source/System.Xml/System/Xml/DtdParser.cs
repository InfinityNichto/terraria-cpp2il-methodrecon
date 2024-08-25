using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;
using System.Xml.Schema;
using Cpp2IlInjected;

namespace System.Xml
{
	// Token: 0x02000089 RID: 137
	internal class DtdParser : IDtdParser
	{
		// Token: 0x06000644 RID: 1604 RVA: 0x00014BC0 File Offset: 0x00012DC0
		private DtdParser()
		{
			XmlCharType instance = XmlCharType.Instance;
			this.xmlCharType = instance;
			this.normalize = true;
			this.supportNamespaces = true;
			this.literalQuoteChar = '"';
			base..ctor();
		}

		// Token: 0x06000645 RID: 1605 RVA: 0x00003FFD File Offset: 0x000021FD
		internal static IDtdParser Create()
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06000646 RID: 1606 RVA: 0x00014BF8 File Offset: 0x00012DF8
		private void Initialize(IDtdParserAdapter readerAdapter)
		{
			this.readerAdapter = readerAdapter;
			this.readerAdapterWithValidation = readerAdapter;
		}

		// Token: 0x06000647 RID: 1607 RVA: 0x00014C30 File Offset: 0x00012E30
		private void InitializeFreeFloatingDtd(string baseUri, string docTypeName, string publicId, string systemId, string internalSubset, IDtdParserAdapter adapter)
		{
			do
			{
				this.Initialize(adapter);
			}
			while (docTypeName == null || docTypeName._stringLength == 0);
			long num = 0L;
			string text = XmlConvert.VerifyName(docTypeName);
			int num2 = docTypeName.IndexOf((char)num);
			XmlNameTable xmlNameTable = this.nameTable;
			SchemaInfo schemaInfo = this.schemaInfo;
			long num3 = 0L;
			string text2 = docTypeName.Substring((int)num3, num2);
			XmlNameTable xmlNameTable2 = this.nameTable;
		}

		// Token: 0x06000648 RID: 1608 RVA: 0x00014D14 File Offset: 0x00012F14
		IDtdInfo IDtdParser.ParseInternalDtd(IDtdParserAdapter adapter, bool saveInternalSubset)
		{
			/*
An exception occurred when decompiling this method (06000648)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Xml.IDtdInfo System.Xml.DtdParser::System.Xml.IDtdParser.ParseInternalDtd(System.Xml.IDtdParserAdapter,System.Boolean)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	call:void(DtdParser::Initialize, ldloc:DtdParser(this), ldloc:IDtdParserAdapter(adapter))
	stloc:SchemaInfo(var_0_0D, ldfld:SchemaInfo(DtdParser::schemaInfo, ldloc:DtdParser(this)))
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

		// Token: 0x06000649 RID: 1609 RVA: 0x00014D30 File Offset: 0x00012F30
		IDtdInfo IDtdParser.ParseFreeFloatingDtd(string baseUri, string docTypeName, string publicId, string systemId, string internalSubset, IDtdParserAdapter adapter)
		{
			/*
An exception occurred when decompiling this method (06000649)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Xml.IDtdInfo System.Xml.DtdParser::System.Xml.IDtdParser.ParseFreeFloatingDtd(System.String,System.String,System.String,System.String,System.String,System.Xml.IDtdParserAdapter)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	call:void(DtdParser::InitializeFreeFloatingDtd, ldloc:DtdParser(this), ldloc:string(baseUri), ldloc:string(docTypeName), ldloc:string(publicId), ldloc:string(systemId), ldloc:string(internalSubset), ldloc:IDtdParserAdapter(adapter))
	stloc:int64(var_0_10, ldc.i4:int64(0))
	call:void(DtdParser::Parse, ldloc:DtdParser(this), ldloc:int64[exp:bool](var_0_10))
	stloc:SchemaInfo(var_1_1E, ldfld:SchemaInfo(DtdParser::schemaInfo, ldloc:DtdParser(this)))
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

		// Token: 0x170001AE RID: 430
		// (get) Token: 0x0600064A RID: 1610 RVA: 0x00014D5C File Offset: 0x00012F5C
		private bool ParsingInternalSubset
		{
			get
			{
				/*
An exception occurred when decompiling this method (0600064A)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean System.Xml.DtdParser::get_ParsingInternalSubset()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:int32(var_0_06, ldfld:int32(DtdParser::externalEntitiesDepth, ldloc:DtdParser(this)))
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

		// Token: 0x170001AF RID: 431
		// (get) Token: 0x0600064B RID: 1611 RVA: 0x00014D70 File Offset: 0x00012F70
		private bool IgnoreEntityReferences
		{
			get
			{
				/*
An exception occurred when decompiling this method (0600064B)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean System.Xml.DtdParser::get_IgnoreEntityReferences()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:ScanningFunction(var_0_06, ldfld:ScanningFunction(DtdParser::scanningFunction, ldloc:DtdParser(this)))
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

		// Token: 0x170001B0 RID: 432
		// (get) Token: 0x0600064C RID: 1612 RVA: 0x00014D84 File Offset: 0x00012F84
		private bool SaveInternalSubsetValue
		{
			get
			{
				/*
An exception occurred when decompiling this method (0600064C)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean System.Xml.DtdParser::get_SaveInternalSubsetValue()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_000A:
	stloc:StringBuilder(var_1_10, ldfld:StringBuilder(DtdParser::internalSubsetValueSb, ldloc:DtdParser(this)))
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

		// Token: 0x170001B1 RID: 433
		// (get) Token: 0x0600064D RID: 1613 RVA: 0x00014DA4 File Offset: 0x00012FA4
		private bool ParsingTopLevelMarkup
		{
			get
			{
				if (this.scanningFunction != DtdParser.ScanningFunction.SubsetContent)
				{
					DtdParser.ScanningFunction scanningFunction = this.savedScanningFunction;
				}
				return true;
			}
		}

		// Token: 0x170001B2 RID: 434
		// (get) Token: 0x0600064E RID: 1614 RVA: 0x00014DC4 File Offset: 0x00012FC4
		private bool SupportNamespaces
		{
			get
			{
				return this.supportNamespaces;
			}
		}

		// Token: 0x170001B3 RID: 435
		// (get) Token: 0x0600064F RID: 1615 RVA: 0x00014DD8 File Offset: 0x00012FD8
		private bool Normalize
		{
			get
			{
				return this.normalize;
			}
		}

		// Token: 0x06000650 RID: 1616 RVA: 0x00014DEC File Offset: 0x00012FEC
		private void Parse(bool saveInternalSubset)
		{
			if (this.freeFloatingDtd)
			{
				this.ParseFreeFloatingDtd();
				return;
			}
			this.ParseInDocumentDtd(saveInternalSubset);
			this.schemaInfo.Finish();
			if (this.validate && this.undeclaredNotations != null)
			{
				string baseUriStr = this.BaseUriStr;
				return;
			}
		}

		// Token: 0x06000651 RID: 1617 RVA: 0x00014E48 File Offset: 0x00013048
		private void ParseInDocumentDtd(bool saveInternalSubset)
		{
			this.LoadParsingBuffer();
			long num = 0L;
			DtdParser.Token token = this.GetToken(num != 0L);
			this.OnUnexpectedError();
			SchemaInfo schemaInfo = this.schemaInfo;
			int num2 = 1;
			XmlQualifiedName nameQualified = this.GetNameQualified(num2 != 0);
			schemaInfo.docTypeName = nameQualified;
			long num3 = 0L;
			DtdParser.Token token2 = this.GetToken(num3 != 0L);
			long num4 = 0L;
			DtdParser.Token token3 = this.GetToken(num4 != 0L);
			int num5 = this.curPos;
			this.SaveParsingBuffer(num5);
			this.ParseSubset();
		}

		// Token: 0x06000652 RID: 1618 RVA: 0x00014EE8 File Offset: 0x000130E8
		private void ParseFreeFloatingDtd()
		{
			if (this.hasFreeFloatingInternalSubset)
			{
				this.LoadParsingBuffer();
				this.ParseSubset();
				int num = this.curPos;
				this.SaveParsingBuffer(num);
			}
			string text = this.systemId;
			if (text != null)
			{
				int stringLength = text._stringLength;
				this.ParseExternalSubset();
				return;
			}
		}

		// Token: 0x06000653 RID: 1619 RVA: 0x00014F30 File Offset: 0x00013130
		private void ParseInternalSubset()
		{
			this.ParseSubset();
		}

		// Token: 0x06000654 RID: 1620 RVA: 0x00014F44 File Offset: 0x00013144
		private void ParseExternalSubset()
		{
			IDtdParserAdapter dtdParserAdapter = this.readerAdapter;
			string text = this.systemId;
			string text2 = this.publicId;
		}

		// Token: 0x06000655 RID: 1621 RVA: 0x00014F94 File Offset: 0x00013194
		private void ParseSubset()
		{
		}

		// Token: 0x06000656 RID: 1622 RVA: 0x00014FB8 File Offset: 0x000131B8
		private void ParseAttlistDecl()
		{
			int num = 1;
			DtdParser.Token token = this.GetToken(num != 0);
			int num2 = 1;
			XmlQualifiedName nameQualified = this.GetNameQualified(num2 != 0);
			Dictionary<XmlQualifiedName, SchemaElementDecl> elementDecls = this.schemaInfo.elementDecls;
			Dictionary<XmlQualifiedName, SchemaElementDecl> undeclaredElementDecls = this.schemaInfo.undeclaredElementDecls;
			string ns = nameQualified.ns;
			Dictionary<XmlQualifiedName, SchemaElementDecl> undeclaredElementDecls2 = this.schemaInfo.undeclaredElementDecls;
			long num3 = 0L;
			DtdParser.Token token2 = this.GetToken(num3 != 0L);
			int num4 = 1;
			string ns2 = this.GetNameQualified(num4 != 0).ns;
			int num5 = this.externalEntitiesDepth;
			int lineNo = this.LineNo;
			int linePos = this.LinePos;
			int num6 = this.curPos;
			int num7 = this.tokenStartPos;
			string text;
			int stringLength = text._stringLength;
			string text2;
			bool flag = text2.Equals("xml");
			SchemaAttDef schemaAttDef;
			if (this.v1Compat)
			{
				string text4;
				string text3 = text4.Trim();
				bool flag2 = text3.Equals("preserve");
				bool flag3 = text3.Equals("default");
				while (schemaAttDef != null)
				{
				}
				return;
			}
			if (this.validate)
			{
				IDtdParserAdapterWithValidation dtdParserAdapterWithValidation = this.readerAdapterWithValidation;
				if (num7 != 0)
				{
				}
				return;
			}
			while (schemaAttDef != null)
			{
			}
		}

		// Token: 0x06000657 RID: 1623 RVA: 0x000150EC File Offset: 0x000132EC
		private void ParseAttlistType(SchemaAttDef attrDef, SchemaElementDecl elementDecl, bool ignoreErrors)
		{
			int num = 1;
			int num2 = 1;
			if (this.GetToken(num != 0) != DtdParser.Token.CDATA)
			{
				elementDecl.hasNonCDataAttribute = num2 != 0;
			}
			XmlSchemaDatatype datatype = attrDef.datatype;
			XmlSchemaSimpleType xmlSchemaSimpleType;
			attrDef.schemaType = xmlSchemaSimpleType;
			if (this.validate && elementDecl.isIdDeclared)
			{
				XmlQualifiedName name = attrDef.name;
				SchemaAttDef attDef = elementDecl.GetAttDef(name);
				if (attDef != null)
				{
					XmlSchemaDatatype datatype2 = attDef.datatype;
				}
				XmlQualifiedName name2 = elementDecl.name;
			}
			int num3 = 1;
			elementDecl.isIdDeclared = num3 != 0;
		}

		// Token: 0x06000658 RID: 1624 RVA: 0x000152D8 File Offset: 0x000134D8
		private void ParseAttlistDefault(SchemaAttDef attrDef, bool ignoreErrors)
		{
			int num = 1;
			DtdParser.Token token = this.GetToken(num != 0);
		}

		// Token: 0x06000659 RID: 1625 RVA: 0x0001538C File Offset: 0x0001358C
		private void ParseElementDecl()
		{
			int num = 1;
			DtdParser.Token token = this.GetToken(num != 0);
			int num2 = 1;
			XmlQualifiedName nameQualified = this.GetNameQualified(num2 != 0);
			Dictionary<XmlQualifiedName, SchemaElementDecl> elementDecls = this.schemaInfo.elementDecls;
			if (this.validate)
			{
				string name = nameQualified.name;
				int num3 = this.curPos;
				int num4 = this.tokenStartPos;
				char[] array = this.chars;
				int stringLength = name._stringLength;
				return;
			}
			int num5 = this.externalEntitiesDepth;
			int num6 = 1;
			DtdParser.Token token2 = this.GetToken(num6 != 0);
			if (num5 == 0)
			{
			}
		}

		// Token: 0x0600065A RID: 1626 RVA: 0x00003FFD File Offset: 0x000021FD
		private void ParseElementOnlyContent(ParticleContentValidator pcv, int startParenEntityId)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x0600065B RID: 1627 RVA: 0x0001546C File Offset: 0x0001366C
		private void ParseHowMany(ParticleContentValidator pcv)
		{
			long num = 0L;
			DtdParser.Token token = this.GetToken(num != 0L);
			pcv.AddStar();
		}

		// Token: 0x0600065C RID: 1628 RVA: 0x00015498 File Offset: 0x00013698
		private void ParseElementMixedContent(ParticleContentValidator pcv, int startParenEntityId)
		{
			int num = this.currentEntityId;
			long num2 = 0L;
			DtdParser.Token token = this.GetToken(num2 != 0L);
		}

		// Token: 0x0600065D RID: 1629 RVA: 0x00015564 File Offset: 0x00013764
		private void ParseEntityDecl()
		{
		}

		// Token: 0x0600065E RID: 1630 RVA: 0x000155A8 File Offset: 0x000137A8
		private void ParseNotationDecl()
		{
			int num = 1;
			DtdParser.Token token = this.GetToken(num != 0);
			this.OnUnexpectedError();
			long num2 = 0L;
			XmlQualifiedName nameQualified = this.GetNameQualified(num2 != 0L);
			Dictionary<string, SchemaNotation> notations = this.schemaInfo.Notations;
			string name = nameQualified.name;
			if (this.validate)
			{
				string name2 = nameQualified.name;
				int num3 = this.curPos;
				int stringLength = name2._stringLength;
			}
		}

		// Token: 0x0600065F RID: 1631 RVA: 0x0001564C File Offset: 0x0001384C
		private void AddUndeclaredNotation(string notationName)
		{
			if (this.undeclaredNotations == null)
			{
			}
			int lineNo = this.LineNo;
			int linePos = this.LinePos;
			int stringLength = notationName._stringLength;
			Dictionary<string, DtdParser.UndeclaredNotation> dictionary = this.undeclaredNotations;
		}

		// Token: 0x06000660 RID: 1632 RVA: 0x00015688 File Offset: 0x00013888
		private void ParseComment()
		{
			int num = this.curPos;
			this.SaveParsingBuffer(num);
			bool saveInternalSubsetValue = this.SaveInternalSubsetValue;
			IDtdParserAdapter dtdParserAdapter = this.readerAdapter;
			StringBuilder stringBuilder = this.internalSubsetValueSb;
		}

		// Token: 0x06000661 RID: 1633 RVA: 0x000156EC File Offset: 0x000138EC
		private void ParsePI()
		{
			int num = this.curPos;
			this.SaveParsingBuffer(num);
			bool saveInternalSubsetValue = this.SaveInternalSubsetValue;
			IDtdParserAdapter dtdParserAdapter = this.readerAdapter;
			StringBuilder stringBuilder = this.internalSubsetValueSb;
		}

		// Token: 0x06000662 RID: 1634 RVA: 0x00015738 File Offset: 0x00013938
		private void ParseCondSection()
		{
			int num = this.currentEntityId;
			long num2 = 0L;
			DtdParser.Token token = this.GetToken(num2 != 0L);
			long num3 = 0L;
			DtdParser.Token token2 = this.GetToken(num3 != 0L);
			if (this.validate)
			{
				int num4 = this.currentEntityId;
				int num5 = this.curPos;
				if (this.validate)
				{
					if (this.condSectionEntityIds != null)
					{
						int num6 = this.condSectionDepth;
						int[] array = this.condSectionEntityIds;
						return;
					}
				}
			}
			int num7 = this.condSectionDepth;
			this.condSectionDepth = num7;
		}

		// Token: 0x06000663 RID: 1635 RVA: 0x00015804 File Offset: 0x00013A04
		private void ParseExternalId(DtdParser.Token idTokenType, DtdParser.Token declType, [Out] string publicId, [Out] string systemId)
		{
			int lineNo = this.LineNo;
			int linePos = this.LinePos;
			int num = 1;
			DtdParser.Token token = this.GetToken(num != 0);
			int num2 = this.curPos;
			this.ThrowUnexpectedToken(num2, "\"", "'");
			string value = this.GetValue();
			int num3 = 35;
			int num4 = value.IndexOf((char)num3);
			int num5 = this.curPos;
			string text;
			if (text != null && text == null)
			{
				throw new ArrayTypeMismatchException();
			}
			if (!this.freeFloatingDtd)
			{
				int linePos2 = this.literalLineInfo.linePos;
				IDtdParserAdapter dtdParserAdapter = this.readerAdapter;
				this.literalLineInfo.linePos = linePos2;
				return;
			}
		}

		// Token: 0x06000664 RID: 1636 RVA: 0x00015990 File Offset: 0x00013B90
		private DtdParser.Token GetToken(bool needWhiteSpace)
		{
			for (;;)
			{
				int num = 1;
				int num2 = 1;
				char[] array = this.chars;
				int num3 = this.curPos;
				if (num != 0)
				{
					break;
				}
				int num4 = this.charsUsed;
				IDtdParserAdapter dtdParserAdapter = this.readerAdapter;
				this.whitespaceSeen = num2 != 0;
				DtdParser.ScanningFunction scanningFunction;
				if (scanningFunction != DtdParser.ScanningFunction.SubsetContent)
				{
					int num5 = this.charsUsed;
					IDtdParserAdapter dtdParserAdapter2 = this.readerAdapter;
					if (scanningFunction != DtdParser.ScanningFunction.SubsetContent)
					{
					}
					if (scanningFunction != DtdParser.ScanningFunction.SubsetContent)
					{
					}
					int num6 = this.curPos;
					char[] array2 = this.chars;
					IDtdParserAdapter dtdParserAdapter3 = this.readerAdapter;
					this.curPos = dtdParserAdapter2;
					if (scanningFunction != DtdParser.ScanningFunction.SubsetContent)
					{
					}
				}
				IDtdParserAdapter dtdParserAdapter4 = this.readerAdapter;
				if (scanningFunction != DtdParser.ScanningFunction.SubsetContent)
				{
				}
				if (this.ReadData() == 0)
				{
					goto Block_2;
				}
			}
			return "'{0}' is an unexpected token. Expecting white space.";
			Block_2:
			long num7 = 0L;
			bool flag = this.HandleEntityEnd(num7 != 0L);
			if (this.scanningFunction != DtdParser.ScanningFunction.SubsetContent)
			{
				int num8 = this.curPos;
				this.Throw(num8, "Incomplete DTD content.");
				if (!this.whitespaceSeen)
				{
					DtdParser.ScanningFunction scanningFunction2 = this.scanningFunction;
					int num9 = this.curPos;
					string text;
					this.Throw(num9, "'{0}' is an unexpected token. Expecting white space.", text);
				}
				int num10 = this.curPos;
				DtdParser.ScanningFunction scanningFunction3 = this.nextScaningFunction;
				int num11 = 1;
				this.tokenStartPos = num10;
				DtdParser.ScanningFunction scanningFunction4 = this.savedScanningFunction;
				this.whitespaceSeen = num11 != 0;
				this.scanningFunction = scanningFunction4;
				return this.ScanSubsetContent();
			}
			long num12 = 0L;
			this.ScanQName(num12 != 0L);
			DtdParser.ScanningFunction scanningFunction5 = this.nextScaningFunction;
			bool flag2 = this.supportNamespaces;
			this.ScanQName(flag2);
			DtdParser.ScanningFunction scanningFunction6 = this.nextScaningFunction;
			this.ScanNmtoken();
			DtdParser.ScanningFunction scanningFunction7 = this.nextScaningFunction;
			this.scanningFunction = scanningFunction7;
			return this.ScanDoctype1();
		}

		// Token: 0x06000665 RID: 1637 RVA: 0x00015C64 File Offset: 0x00013E64
		private DtdParser.Token ScanSubsetContent()
		{
			char[] array = this.chars;
			int num = this.charsUsed;
			return "Expected DTD markup was not found.";
		}

		// Token: 0x06000666 RID: 1638 RVA: 0x00015E00 File Offset: 0x00014000
		private DtdParser.Token ScanNameExpected()
		{
			long num = 0L;
			this.ScanQName(num != 0L);
			DtdParser.ScanningFunction scanningFunction = this.nextScaningFunction;
			this.scanningFunction = scanningFunction;
			return DtdParser.Token.Name;
		}

		// Token: 0x06000667 RID: 1639 RVA: 0x00015E28 File Offset: 0x00014028
		private DtdParser.Token ScanQNameExpected()
		{
			bool flag = this.supportNamespaces;
			this.ScanQName(flag);
			DtdParser.ScanningFunction scanningFunction = this.nextScaningFunction;
			this.scanningFunction = scanningFunction;
			return DtdParser.Token.QName;
		}

		// Token: 0x06000668 RID: 1640 RVA: 0x00015E54 File Offset: 0x00014054
		private DtdParser.Token ScanNmtokenExpected()
		{
			this.ScanNmtoken();
			DtdParser.ScanningFunction scanningFunction = this.nextScaningFunction;
			this.scanningFunction = scanningFunction;
			return DtdParser.Token.Nmtoken;
		}

		// Token: 0x06000669 RID: 1641 RVA: 0x00015E78 File Offset: 0x00014078
		private DtdParser.Token ScanDoctype1()
		{
			/*
An exception occurred when decompiling this method (06000669)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Xml.DtdParser/Token System.Xml.DtdParser::ScanDoctype1()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:char[](var_0_06, ldfld:char[](DtdParser::chars, ldloc:DtdParser(this)))
	stloc:bool(var_1_0D, call:bool(DtdParser::EatPublicKeyword, ldloc:DtdParser(this)))
	stloc:int32(var_2_14, ldfld:int32(DtdParser::curPos, ldloc:DtdParser(this)))
	call:void(DtdParser::Throw, ldloc:DtdParser(this), ldloc:int32(var_2_14), ldstr:string("Expecting external ID, '[' or '>'."))
	call:void(DtdParser::Throw, ldloc:DtdParser(this), ldloc:int32(var_2_14), ldstr:string("Expecting external ID, '[' or '>'."))
	stloc:bool(var_7_42, call:bool(DtdParser::EatSystemKeyword, ldloc:DtdParser(this)))
	stloc:int32(var_8_4A, ldfld:int32(DtdParser::curPos, ldloc:DtdParser(this)))
	call:void(DtdParser::Throw, ldloc:DtdParser(this), ldloc:int32(var_8_4A), ldstr:string("Expecting external ID, '[' or '>'."))
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

		// Token: 0x0600066A RID: 1642 RVA: 0x00015EE4 File Offset: 0x000140E4
		private DtdParser.Token ScanDoctype2()
		{
			/*
An exception occurred when decompiling this method (0600066A)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Xml.DtdParser/Token System.Xml.DtdParser::ScanDoctype2()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:char[](var_0_06, ldfld:char[](DtdParser::chars, ldloc:DtdParser(this)))
	stfld:int32(DtdParser::curPos, ldloc:DtdParser(this), ldloc:char[][exp:int32](var_0_06))
	stfld:int32(DtdParser::curPos, ldloc:DtdParser(this), ldloc:char[][exp:int32](var_0_06))
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

		// Token: 0x0600066B RID: 1643 RVA: 0x00015F10 File Offset: 0x00014110
		private DtdParser.Token ScanClosingTag()
		{
			/*
An exception occurred when decompiling this method (0600066B)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Xml.DtdParser/Token System.Xml.DtdParser::ScanClosingTag()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:char[](var_0_06, ldfld:char[](DtdParser::chars, ldloc:DtdParser(this)))
	stloc:int32(var_1_0D, ldfld:int32(DtdParser::curPos, ldloc:DtdParser(this)))
	stfld:int32(DtdParser::curPos, ldloc:DtdParser(this), ldstr:string[exp:int32](">"))
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

		// Token: 0x0600066C RID: 1644 RVA: 0x00015F38 File Offset: 0x00014138
		private DtdParser.Token ScanElement1()
		{
			/*
An exception occurred when decompiling this method (0600066C)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Xml.DtdParser/Token System.Xml.DtdParser::ScanElement1()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:int32(var_3_23, ldfld:int32(DtdParser::curPos, ldloc:DtdParser(this)))
	call:void(DtdParser::Throw, ldloc:DtdParser(this), ldloc:int32(var_3_23), ldstr:string("Incomplete DTD content."))
	stloc:int32(var_4_32, ldc.i4:int32(31))
	stfld:int32(DtdParser::curPos, ldloc:DtdParser(this), ldloc:char[][exp:int32](var_0_06))
	stfld:ScanningFunction(DtdParser::nextScaningFunction, ldloc:DtdParser(this), ldloc:int32[exp:ScanningFunction](var_4_32))
	stloc:int32(var_6_48, ldc.i4:int32(7))
	stfld:int32(DtdParser::curPos, ldloc:DtdParser(this), ldloc:int32(var_4_32))
	stfld:ScanningFunction(DtdParser::nextScaningFunction, ldloc:DtdParser(this), ldloc:int32[exp:ScanningFunction](var_6_48))
	stloc:int32(var_8_60, ldc.i4:int32(31))
	stfld:int32(DtdParser::curPos, ldloc:DtdParser(this), ldloc:int32(var_6_48))
	stfld:ScanningFunction(DtdParser::nextScaningFunction, ldloc:DtdParser(this), ldloc:int32[exp:ScanningFunction](var_8_60))
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

		// Token: 0x0600066D RID: 1645 RVA: 0x00015FBC File Offset: 0x000141BC
		private DtdParser.Token ScanElement2()
		{
			/*
An exception occurred when decompiling this method (0600066D)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Xml.DtdParser/Token System.Xml.DtdParser::ScanElement2()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0029:
	stloc:int32(var_3_2F, ldfld:int32(DtdParser::charsUsed, ldloc:DtdParser(this)))
	stloc:ScanningFunction(var_4_36, ldfld:ScanningFunction(DtdParser::scanningFunction, ldloc:DtdParser(this)))
	stloc:char[](var_5_3E, ldfld:char[](DtdParser::chars, ldloc:DtdParser(this)))
	stfld:int32(DtdParser::curPos, ldloc:DtdParser(this), ldloc:ScanningFunction[exp:int32](var_4_36))
	call:void(DtdParser::Throw, ldloc:DtdParser(this), ldloc:int32(var_2), ldstr:string("Expecting 'PCDATA'."))
	stloc:int32(var_8_5D, ldc.i4:int32(8))
	stfld:ScanningFunction(DtdParser::scanningFunction, ldloc:DtdParser(this), ldloc:int32[exp:ScanningFunction](var_8_5D))
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

		// Token: 0x0600066E RID: 1646 RVA: 0x00016030 File Offset: 0x00014230
		private DtdParser.Token ScanElement3()
		{
			/*
An exception occurred when decompiling this method (0600066E)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Xml.DtdParser/Token System.Xml.DtdParser::ScanElement3()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:char[](var_0_06, ldfld:char[](DtdParser::chars, ldloc:DtdParser(this)))
	stloc:bool(var_3_13, ldfld:bool(DtdParser::supportNamespaces, ldloc:DtdParser(this)))
	call:void(DtdParser::ScanQName, ldloc:DtdParser(this), ldloc:bool(var_3_13))
	stloc:int32(var_4_1D, ldc.i4:int32(9))
	stfld:ScanningFunction(DtdParser::scanningFunction, ldloc:DtdParser(this), ldloc:int32[exp:ScanningFunction](var_4_1D))
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

		// Token: 0x0600066F RID: 1647 RVA: 0x00016068 File Offset: 0x00014268
		private DtdParser.Token ScanElement4()
		{
			char[] array = this.chars;
			int num = 10;
			this.scanningFunction = (DtdParser.ScanningFunction)num;
			return "White space not allowed before '?', '*', or '+'.";
		}

		// Token: 0x06000670 RID: 1648 RVA: 0x000160B0 File Offset: 0x000142B0
		private DtdParser.Token ScanElement5()
		{
			/*
An exception occurred when decompiling this method (06000670)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Xml.DtdParser/Token System.Xml.DtdParser::ScanElement5()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:char[](var_0_06, ldfld:char[](DtdParser::chars, ldloc:DtdParser(this)))
	stloc:int32(var_1_08, ldc.i4:int32(8))
	stfld:int32(DtdParser::curPos, ldloc:DtdParser(this), ldloc:char[][exp:int32](var_0_06))
	stfld:ScanningFunction(DtdParser::nextScaningFunction, ldloc:DtdParser(this), ldloc:int32[exp:ScanningFunction](var_1_08))
	stloc:int32(var_3_1B, ldc.i4:int32(8))
	stfld:int32(DtdParser::curPos, ldloc:DtdParser(this), ldloc:char[][exp:int32](var_0_06))
	stfld:ScanningFunction(DtdParser::nextScaningFunction, ldloc:DtdParser(this), ldloc:int32[exp:ScanningFunction](var_3_1B))
	stloc:int32(var_6_34, ldc.i4:int32(9))
	stfld:int32(DtdParser::curPos, ldloc:DtdParser(this), ldstr:string[exp:int32]("Expecting '?', '*', or '+'."))
	stfld:ScanningFunction(DtdParser::nextScaningFunction, ldloc:DtdParser(this), ldloc:int32[exp:ScanningFunction](var_6_34))
	stfld:int32(DtdParser::curPos, ldloc:DtdParser(this), ldstr:string[exp:int32]("Expecting '?', '*', or '+'."))
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

		// Token: 0x06000671 RID: 1649 RVA: 0x00016118 File Offset: 0x00014318
		private DtdParser.Token ScanElement6()
		{
			/*
An exception occurred when decompiling this method (06000671)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Xml.DtdParser/Token System.Xml.DtdParser::ScanElement6()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:char[](var_0_06, ldfld:char[](DtdParser::chars, ldloc:DtdParser(this)))
	stloc:int32(var_1_09, ldc.i4:int32(12))
	stfld:int32(DtdParser::curPos, ldloc:DtdParser(this), ldloc:char[][exp:int32](var_0_06))
	stfld:ScanningFunction(DtdParser::nextScaningFunction, ldloc:DtdParser(this), ldloc:int32[exp:ScanningFunction](var_1_09))
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

		// Token: 0x06000672 RID: 1650 RVA: 0x00016148 File Offset: 0x00014348
		private DtdParser.Token ScanElement7()
		{
			char[] array = this.chars;
			int num = 31;
			this.scanningFunction = (DtdParser.ScanningFunction)num;
			if (this.whitespaceSeen)
			{
				return;
			}
		}

		// Token: 0x06000673 RID: 1651 RVA: 0x00016174 File Offset: 0x00014374
		private DtdParser.Token ScanAttlist1()
		{
			/*
An exception occurred when decompiling this method (06000673)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Xml.DtdParser/Token System.Xml.DtdParser::ScanAttlist1()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_002F:
	stloc:bool(var_3_35, ldfld:bool(DtdParser::supportNamespaces, ldloc:DtdParser(this)))
	call:void(DtdParser::ScanQName, ldloc:DtdParser(this), ldloc:bool(var_3_35))
	stloc:int32(var_5_43, ldc.i4:int32(14))
	stfld:ScanningFunction(DtdParser::scanningFunction, ldloc:DtdParser(this), ldloc:int32[exp:ScanningFunction](var_5_43))
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

		// Token: 0x06000674 RID: 1652 RVA: 0x000161D0 File Offset: 0x000143D0
		private DtdParser.Token ScanAttlist2()
		{
			char[] array = this.chars;
			return "Invalid attribute type.";
		}

		// Token: 0x06000675 RID: 1653 RVA: 0x0001639C File Offset: 0x0001459C
		private DtdParser.Token ScanAttlist3()
		{
			/*
An exception occurred when decompiling this method (06000675)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Xml.DtdParser/Token System.Xml.DtdParser::ScanAttlist3()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:char[](var_0_06, ldfld:char[](DtdParser::chars, ldloc:DtdParser(this)))
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

		// Token: 0x06000676 RID: 1654 RVA: 0x000163B8 File Offset: 0x000145B8
		private DtdParser.Token ScanAttlist4()
		{
			/*
An exception occurred when decompiling this method (06000676)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Xml.DtdParser/Token System.Xml.DtdParser::ScanAttlist4()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:char[](var_0_06, ldfld:char[](DtdParser::chars, ldloc:DtdParser(this)))
	stloc:int32(var_1_09, ldc.i4:int32(18))
	stfld:int32(DtdParser::curPos, ldloc:DtdParser(this), ldloc:char[][exp:int32](var_0_06))
	stfld:ScanningFunction(DtdParser::nextScaningFunction, ldloc:DtdParser(this), ldloc:int32[exp:ScanningFunction](var_1_09))
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

		// Token: 0x06000677 RID: 1655 RVA: 0x000163E8 File Offset: 0x000145E8
		private DtdParser.Token ScanAttlist5()
		{
		}

		// Token: 0x06000678 RID: 1656 RVA: 0x00016400 File Offset: 0x00014600
		private DtdParser.Token ScanAttlist6()
		{
			/*
An exception occurred when decompiling this method (06000678)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Xml.DtdParser/Token System.Xml.DtdParser::ScanAttlist6()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:int32(var_1_15, ldfld:int32(DtdParser::curPos, ldloc:DtdParser(this)))
	call:void(DtdParser::Throw, ldloc:DtdParser(this), ldloc:int32(var_1_15), ldstr:string("Incomplete DTD content."))
	stloc:int64(var_2_23, ldc.i4:int64(0))
	stloc:int32(var_5_2A, ldc.i4:int32(13))
	stfld:ScanningFunction(DtdParser::scanningFunction, ldloc:DtdParser(this), ldloc:int32[exp:ScanningFunction](var_5_2A))
	call:void(DtdParser::Throw, ldloc:DtdParser(this), ldloc:int64[exp:int32](var_2_23), ldstr:string("Expecting an attribute type."))
	stloc:int32(var_6_46, ldfld:int32(DtdParser::curPos, ldloc:DtdParser(this)))
	stfld:int32(DtdParser::curPos, ldloc:DtdParser(this), ldloc:int32(var_5_2A))
	stloc:int32(var_8_56, ldc.i4:int32(19))
	call:void(DtdParser::Throw, ldloc:DtdParser(this), ldloc:int32(var_6_46), ldstr:string("Expecting an attribute type."))
	stloc:int32(var_9_6B, ldfld:int32(DtdParser::curPos, ldloc:DtdParser(this)))
	call:void(DtdParser::Throw, ldloc:DtdParser(this), ldloc:int32(var_9_6B), ldstr:string("Expecting an attribute type."))
	stloc:int32(var_11_84, ldfld:int32(DtdParser::curPos, ldloc:DtdParser(this)))
	stfld:int32(DtdParser::curPos, ldloc:DtdParser(this), ldloc:int32(var_8_56))
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

		// Token: 0x06000679 RID: 1657 RVA: 0x000164A0 File Offset: 0x000146A0
		private DtdParser.Token ScanAttlist7()
		{
			/*
An exception occurred when decompiling this method (06000679)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Xml.DtdParser/Token System.Xml.DtdParser::ScanAttlist7()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:char[](var_0_06, ldfld:char[](DtdParser::chars, ldloc:DtdParser(this)))
	stloc:int32(var_2_09, ldc.i4:int32(13))
	stfld:ScanningFunction(DtdParser::scanningFunction, ldloc:DtdParser(this), ldloc:int32[exp:ScanningFunction](var_2_09))
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

		// Token: 0x0600067A RID: 1658 RVA: 0x000164C4 File Offset: 0x000146C4
		private DtdParser.Token ScanLiteral(DtdParser.LiteralType literalType)
		{
			/*
An exception occurred when decompiling this method (0600067A)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Xml.DtdParser/Token System.Xml.DtdParser::ScanLiteral(System.Xml.DtdParser/LiteralType)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_8:
	stfld:int32(DtdParser::tokenStartPos, ldloc:DtdParser(this), ldloc:IDtdParserAdapter[exp:int32](var_60))
	stfld:int32(DtdParser::curPos, ldloc:DtdParser(this), ldloc:IDtdParserAdapter[exp:int32](var_60))
	stloc:int32(var_84_3B4, ldfld:int32(DtdParser::curPos, ldloc:DtdParser(this)))
	stfld:int32(DtdParser::curPos, ldloc:DtdParser(this), ldloc:int32(var_84_3B4))
	stloc:XmlQualifiedName(var_85_3C4, call:XmlQualifiedName(DtdParser::ScanEntityName, ldloc:DtdParser(this)))
	stloc:int32(var_86_3C7, ldc.i4:int32(1))
	stloc:int32(var_87_3D4, callgetter:int32(StringBuilder::get_Length, ldfld:StringBuilder(DtdParser::stringBuilder, ldloc:DtdParser(this))))
	stloc:int32(var_88_3DC, ldfld:int32(DtdParser::tokenStartPos, ldloc:DtdParser(this)))
	stloc:int32(var_89_3E4, ldfld:int32(DtdParser::curPos, ldloc:DtdParser(this)))
	stloc:StringBuilder(var_90_3EC, ldfld:StringBuilder(DtdParser::stringBuilder, ldloc:DtdParser(this)))
	stloc:char[](var_91_3F4, ldfld:char[](DtdParser::chars, ldloc:DtdParser(this)))
	stloc:StringBuilder(var_92_403, call:StringBuilder(StringBuilder::Append, ldloc:StringBuilder(var_90_3EC), ldloc:char[](var_91_3F4), ldloc:int32(var_88_3DC), ldloc:int32(var_86_3C7)))
	stloc:int32(var_93_40B, ldfld:int32(DtdParser::curPos, ldloc:DtdParser(this)))
	stfld:int32(DtdParser::curPos, ldloc:DtdParser(this), ldloc:int32(var_93_40B))
	stloc:char[](var_95_41F, ldfld:char[](DtdParser::chars, ldloc:DtdParser(this)))
	stloc:int32(var_96_427, ldfld:int32(DtdParser::charsUsed, ldloc:DtdParser(this)))
	stloc:ScanningFunction(var_97_42F, ldfld:ScanningFunction(DtdParser::scanningFunction, ldloc:DtdParser(this)))
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

		// Token: 0x0600067B RID: 1659 RVA: 0x00016908 File Offset: 0x00014B08
		private XmlQualifiedName ScanEntityName()
		{
			long num = 0L;
			this.ScanQName(num != 0L);
			char[] array = this.chars;
			long num2 = 0L;
			XmlQualifiedName nameQualified = this.GetNameQualified(num2 != 0L);
			int num3 = this.curPos;
			this.curPos = num3;
			return nameQualified;
		}

		// Token: 0x0600067C RID: 1660 RVA: 0x00016944 File Offset: 0x00014B44
		private DtdParser.Token ScanNotation1()
		{
			/*
An exception occurred when decompiling this method (0600067C)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Xml.DtdParser/Token System.Xml.DtdParser::ScanNotation1()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:char[](var_0_06, ldfld:char[](DtdParser::chars, ldloc:DtdParser(this)))
	stloc:bool(var_1_0D, call:bool(DtdParser::EatPublicKeyword, ldloc:DtdParser(this)))
	stloc:int32(var_2_14, ldfld:int32(DtdParser::curPos, ldloc:DtdParser(this)))
	call:void(DtdParser::Throw, ldloc:DtdParser(this), ldloc:int32(var_2_14), ldstr:string("Expecting external ID, '[' or '>'."))
	stloc:bool(var_4_2A, call:bool(DtdParser::EatSystemKeyword, ldloc:DtdParser(this)))
	stloc:int32(var_5_32, ldfld:int32(DtdParser::curPos, ldloc:DtdParser(this)))
	call:void(DtdParser::Throw, ldloc:DtdParser(this), ldloc:int32(var_5_32), ldstr:string("Expecting external ID, '[' or '>'."))
	call:void(DtdParser::Throw, ldloc:DtdParser(this), ldloc:int32(var_5_32), ldstr:string("Expecting a system identifier or a public identifier."))
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

		// Token: 0x0600067D RID: 1661 RVA: 0x000169A8 File Offset: 0x00014BA8
		private DtdParser.Token ScanSystemId()
		{
			/*
An exception occurred when decompiling this method (0600067D)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Xml.DtdParser/Token System.Xml.DtdParser::ScanSystemId()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:char[](var_0_06, ldfld:char[](DtdParser::chars, ldloc:DtdParser(this)))
	stloc:ScanningFunction(var_2_0D, ldfld:ScanningFunction(DtdParser::nextScaningFunction, ldloc:DtdParser(this)))
	stfld:ScanningFunction(DtdParser::scanningFunction, ldloc:DtdParser(this), ldloc:ScanningFunction(var_2_0D))
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

		// Token: 0x0600067E RID: 1662 RVA: 0x000169CC File Offset: 0x00014BCC
		private DtdParser.Token ScanEntity1()
		{
			/*
An exception occurred when decompiling this method (0600067E)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Xml.DtdParser/Token System.Xml.DtdParser::ScanEntity1()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:char[](var_0_06, ldfld:char[](DtdParser::chars, ldloc:DtdParser(this)))
	stloc:int32(var_1_09, ldc.i4:int32(21))
	stfld:ScanningFunction(DtdParser::nextScaningFunction, ldloc:DtdParser(this), ldloc:int32[exp:ScanningFunction](var_1_09))
	stloc:int64(var_3_15, ldc.i4:int64(0))
	call:void(DtdParser::ScanQName, ldloc:DtdParser(this), ldloc:int64[exp:bool](var_3_15))
	stloc:int32(var_5_23, ldc.i4:int32(21))
	stfld:ScanningFunction(DtdParser::scanningFunction, ldloc:DtdParser(this), ldloc:int32[exp:ScanningFunction](var_5_23))
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

		// Token: 0x0600067F RID: 1663 RVA: 0x00016A08 File Offset: 0x00014C08
		private DtdParser.Token ScanEntity2()
		{
			/*
An exception occurred when decompiling this method (0600067F)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Xml.DtdParser/Token System.Xml.DtdParser::ScanEntity2()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:char[](var_0_06, ldfld:char[](DtdParser::chars, ldloc:DtdParser(this)))
	stloc:int32(var_2_09, ldc.i4:int32(31))
	stfld:ScanningFunction(DtdParser::scanningFunction, ldloc:DtdParser(this), ldloc:int32[exp:ScanningFunction](var_2_09))
	stloc:bool(var_4_1A, call:bool(DtdParser::EatPublicKeyword, ldloc:DtdParser(this)))
	stloc:int32(var_5_22, ldfld:int32(DtdParser::curPos, ldloc:DtdParser(this)))
	call:void(DtdParser::Throw, ldloc:DtdParser(this), ldloc:int32(var_5_22), ldstr:string("Expecting external ID, '[' or '>'."))
	call:void(DtdParser::Throw, ldloc:DtdParser(this), ldloc:int32(var_5_22), ldstr:string("Expecting an external identifier or an entity value."))
	stloc:bool(var_8_4C, call:bool(DtdParser::EatSystemKeyword, ldloc:DtdParser(this)))
	stloc:int32(var_9_54, ldfld:int32(DtdParser::curPos, ldloc:DtdParser(this)))
	call:void(DtdParser::Throw, ldloc:DtdParser(this), ldloc:int32(var_9_54), ldstr:string("Expecting external ID, '[' or '>'."))
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

		// Token: 0x06000680 RID: 1664 RVA: 0x00016A7C File Offset: 0x00014C7C
		private DtdParser.Token ScanEntity3()
		{
			char[] array = this.chars;
			int num = this.charsUsed;
			if (this.ReadData() != 0)
			{
				int num2 = this.charsUsed;
				DtdParser.ScanningFunction scanningFunction = this.scanningFunction;
				char[] array2 = this.chars;
				return;
			}
		}

		// Token: 0x06000681 RID: 1665 RVA: 0x00016ABC File Offset: 0x00014CBC
		private DtdParser.Token ScanPublicId1()
		{
			/*
An exception occurred when decompiling this method (06000681)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Xml.DtdParser/Token System.Xml.DtdParser::ScanPublicId1()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:char[](var_0_06, ldfld:char[](DtdParser::chars, ldloc:DtdParser(this)))
	stloc:int32(var_2_09, ldc.i4:int32(30))
	stfld:ScanningFunction(DtdParser::scanningFunction, ldloc:DtdParser(this), ldloc:int32[exp:ScanningFunction](var_2_09))
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

		// Token: 0x06000682 RID: 1666 RVA: 0x00016ADC File Offset: 0x00014CDC
		private DtdParser.Token ScanPublicId2()
		{
			/*
An exception occurred when decompiling this method (06000682)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Xml.DtdParser/Token System.Xml.DtdParser::ScanPublicId2()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:char[](var_0_06, ldfld:char[](DtdParser::chars, ldloc:DtdParser(this)))
	stloc:ScanningFunction(var_4_13, ldfld:ScanningFunction(DtdParser::nextScaningFunction, ldloc:DtdParser(this)))
	stfld:ScanningFunction(DtdParser::scanningFunction, ldloc:DtdParser(this), ldloc:ScanningFunction(var_4_13))
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

		// Token: 0x06000683 RID: 1667 RVA: 0x00016B08 File Offset: 0x00014D08
		private DtdParser.Token ScanCondSection1()
		{
			/*
An exception occurred when decompiling this method (06000683)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Xml.DtdParser/Token System.Xml.DtdParser::ScanCondSection1()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0040:
	stloc:int32(var_5_46, ldfld:int32(DtdParser::curPos, ldloc:DtdParser(this)))
	stloc:int32(var_7_4E, ldfld:int32(DtdParser::curPos, ldloc:DtdParser(this)))
	stloc:int32(var_10_5A, ldfld:int32(DtdParser::curPos, ldloc:DtdParser(this)))
	stloc:int32(var_12_66, ldfld:int32(DtdParser::curPos, ldloc:DtdParser(this)))
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

		// Token: 0x06000684 RID: 1668 RVA: 0x00016B80 File Offset: 0x00014D80
		private DtdParser.Token ScanCondSection2()
		{
			/*
An exception occurred when decompiling this method (06000684)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Xml.DtdParser/Token System.Xml.DtdParser::ScanCondSection2()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:char[](var_0_06, ldfld:char[](DtdParser::chars, ldloc:DtdParser(this)))
	stloc:int32(var_1_0D, ldfld:int32(DtdParser::curPos, ldloc:DtdParser(this)))
	stloc:ScanningFunction(var_2_14, ldfld:ScanningFunction(DtdParser::nextScaningFunction, ldloc:DtdParser(this)))
	stfld:ScanningFunction(DtdParser::nextScaningFunction, ldloc:DtdParser(this), ldloc:ScanningFunction(var_2_14))
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

		// Token: 0x06000685 RID: 1669 RVA: 0x00016BAC File Offset: 0x00014DAC
		private DtdParser.Token ScanCondSection3()
		{
			int num = 1;
			char[] array = this.chars;
			XmlCharType xmlCharType = this.xmlCharType;
			this.curPos = num;
			return "There is an unclosed conditional section.";
		}

		// Token: 0x06000686 RID: 1670 RVA: 0x00016CD0 File Offset: 0x00014ED0
		private void ScanName()
		{
			long num = 0L;
			this.ScanQName(num != 0L);
		}

		// Token: 0x06000687 RID: 1671 RVA: 0x00016CE8 File Offset: 0x00014EE8
		private void ScanQName()
		{
			bool flag = this.supportNamespaces;
			this.ScanQName(flag);
		}

		// Token: 0x06000688 RID: 1672 RVA: 0x00016D04 File Offset: 0x00014F04
		private void ScanQName(bool isQName)
		{
			int num = this.curPos;
			this.tokenStartPos = num;
			char[] array = this.chars;
			XmlCharType xmlCharType = this.xmlCharType;
			int num2 = this.charsUsed;
			this.curPos = num;
			int num3 = this.ReadData();
			int num4 = this.curPos;
			this.tokenStartPos = num4;
			this.curPos = num;
			while (num3 != 0)
			{
			}
			this.Throw(num, "Unexpected end of file while parsing {0} has occurred.", "Name");
		}

		// Token: 0x06000689 RID: 1673 RVA: 0x00016E44 File Offset: 0x00015044
		private bool ReadDataInName()
		{
			/*
An exception occurred when decompiling this method (06000689)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean System.Xml.DtdParser::ReadDataInName()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:int32(var_0_06, ldfld:int32(DtdParser::curPos, ldloc:DtdParser(this)))
	stloc:int32(var_1_0D, ldfld:int32(DtdParser::tokenStartPos, ldloc:DtdParser(this)))
	stfld:int32(DtdParser::curPos, ldloc:DtdParser(this), ldloc:int32(var_1_0D))
	stloc:int32(var_2_1B, call:int32(DtdParser::ReadData, ldloc:DtdParser(this)))
	stloc:int32(var_3_22, ldfld:int32(DtdParser::curPos, ldloc:DtdParser(this)))
	stfld:int32(DtdParser::tokenStartPos, ldloc:DtdParser(this), ldloc:int32(var_3_22))
	stfld:int32(DtdParser::curPos, ldloc:DtdParser(this), ldloc:int32(var_3_22))
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

		// Token: 0x0600068A RID: 1674 RVA: 0x00016E84 File Offset: 0x00015084
		private void ScanNmtoken()
		{
			int num = this.curPos;
			this.tokenStartPos = num;
			char[] array = this.chars;
			if (this.xmlCharType == null)
			{
				int num2 = this.charsUsed;
				this.curPos = num;
				if (this.ReadData() == 0)
				{
					int num3 = this.curPos;
					this.Throw(num3, "Unexpected end of file while parsing {0} has occurred.", "NmToken");
				}
				int num4 = this.curPos;
				this.tokenStartPos = num4;
				return;
			}
			this.curPos = num;
		}

		// Token: 0x0600068B RID: 1675 RVA: 0x00016F14 File Offset: 0x00015114
		private bool EatPublicKeyword()
		{
			/*
An exception occurred when decompiling this method (0600068B)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean System.Xml.DtdParser::EatPublicKeyword()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:char[](var_2_1C, ldfld:char[](DtdParser::chars, ldloc:DtdParser(this)))
	stfld:int32(DtdParser::curPos, ldloc:DtdParser(this), ldloc:ScanningFunction[exp:int32](var_1_0D))
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

		// Token: 0x0600068C RID: 1676 RVA: 0x00016F4C File Offset: 0x0001514C
		private bool EatSystemKeyword()
		{
			/*
An exception occurred when decompiling this method (0600068C)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean System.Xml.DtdParser::EatSystemKeyword()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:char[](var_2_1C, ldfld:char[](DtdParser::chars, ldloc:DtdParser(this)))
	stfld:int32(DtdParser::curPos, ldloc:DtdParser(this), ldloc:ScanningFunction[exp:int32](var_1_0D))
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

		// Token: 0x0600068D RID: 1677 RVA: 0x00016F84 File Offset: 0x00015184
		private XmlQualifiedName GetNameQualified(bool canHavePrefix)
		{
			int num = this.colonPos;
			XmlNameTable xmlNameTable = this.nameTable;
			int num2 = this.curPos;
			char[] array = this.chars;
			XmlNameTable xmlNameTable2 = this.nameTable;
			int num3 = this.tokenStartPos;
			StringBuilder stringBuilder = this.internalSubsetValueSb;
			char[] array2 = this.chars;
			return 1073741824;
		}

		// Token: 0x0600068E RID: 1678 RVA: 0x00016FE0 File Offset: 0x000151E0
		private string GetNameString()
		{
			int num = this.tokenStartPos;
			int num2 = this.curPos;
			char[] array = this.chars;
			string text;
			return text;
		}

		// Token: 0x0600068F RID: 1679 RVA: 0x00017008 File Offset: 0x00015208
		private string GetNmtokenString()
		{
			int num = this.tokenStartPos;
			int num2 = this.curPos;
			char[] array = this.chars;
			string text;
			return text;
		}

		// Token: 0x06000690 RID: 1680 RVA: 0x00017030 File Offset: 0x00015230
		private string GetValue()
		{
			if (this.stringBuilder.Length != 0)
			{
				StringBuilder stringBuilder = this.stringBuilder;
			}
			int num = this.tokenStartPos;
			int num2 = this.curPos;
			char[] array = this.chars;
			string text;
			return text;
		}

		// Token: 0x06000691 RID: 1681 RVA: 0x0001706C File Offset: 0x0001526C
		private string GetValueWithStrippedSpaces()
		{
			if (this.stringBuilder.Length != 0)
			{
				StringBuilder stringBuilder = this.stringBuilder;
			}
			int num = this.tokenStartPos;
			int num2 = this.curPos;
			char[] array = this.chars;
			string text;
			return DtdParser.StripSpaces(text);
		}

		// Token: 0x06000692 RID: 1682 RVA: 0x000170AC File Offset: 0x000152AC
		private int ReadData()
		{
			/*
An exception occurred when decompiling this method (06000692)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Int32 System.Xml.DtdParser::ReadData()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:int32(var_0_06, ldfld:int32(DtdParser::curPos, ldloc:DtdParser(this)))
	call:void(DtdParser::SaveParsingBuffer, ldloc:DtdParser(this), ldloc:int32(var_0_06))
	stloc:IDtdParserAdapter(var_1_14, ldfld:IDtdParserAdapter(DtdParser::readerAdapter, ldloc:DtdParser(this)))
	call:void(DtdParser::LoadParsingBuffer, ldloc:DtdParser(this))
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

		// Token: 0x06000693 RID: 1683 RVA: 0x000170D4 File Offset: 0x000152D4
		private void LoadParsingBuffer()
		{
			IDtdParserAdapter dtdParserAdapter = this.readerAdapter;
		}

		// Token: 0x06000694 RID: 1684 RVA: 0x00017110 File Offset: 0x00015310
		private void SaveParsingBuffer()
		{
			int num = this.curPos;
			this.SaveParsingBuffer(num);
		}

		// Token: 0x06000695 RID: 1685 RVA: 0x0001712C File Offset: 0x0001532C
		private void SaveParsingBuffer(int internalSubsetValueEndPos)
		{
			bool saveInternalSubsetValue = this.SaveInternalSubsetValue;
			IDtdParserAdapter dtdParserAdapter = this.readerAdapter;
		}

		// Token: 0x06000696 RID: 1686 RVA: 0x00017168 File Offset: 0x00015368
		private bool HandleEntityReference(bool paramEntity, bool inLiteral, bool inAttribute)
		{
			int num = this.curPos;
			this.curPos = num;
			XmlQualifiedName xmlQualifiedName = this.ScanEntityName();
			bool flag;
			return flag;
		}

		// Token: 0x06000697 RID: 1687 RVA: 0x0001718C File Offset: 0x0001538C
		private bool HandleEntityReference(XmlQualifiedName entityName, bool paramEntity, bool inLiteral, bool inAttribute)
		{
			SchemaEntity schemaEntity;
			do
			{
				int num = this.curPos;
				this.SaveParsingBuffer(num);
				if (this.externalEntitiesDepth == 0 && this.scanningFunction != DtdParser.ScanningFunction.SubsetContent && this.savedScanningFunction != DtdParser.ScanningFunction.SubsetContent)
				{
					string name = entityName.name;
					int num2 = this.curPos;
					int stringLength = name._stringLength;
					this.Throw(num, "A parameter entity reference is not allowed in internal markup.");
				}
			}
			while (schemaEntity == null);
			if (schemaEntity.parsingInProgress)
			{
				int stringLength2 = entityName.name._stringLength;
				int num3 = this.curPos;
			}
			if (schemaEntity.isExternal)
			{
				IDtdParserAdapter dtdParserAdapter = this.readerAdapter;
				if ("General entity '{0}' references itself." != null)
				{
				}
			}
			if (schemaEntity.text._stringLength != 0)
			{
				IDtdParserAdapter dtdParserAdapter2 = this.readerAdapter;
				if ("General entity '{0}' references itself." != null)
				{
				}
				int num4 = this.externalEntitiesDepth;
				this.externalEntitiesDepth = num4;
				this.currentEntityId = num4;
				DtdParser.ScanningFunction scanningFunction = this.scanningFunction;
				this.savedScanningFunction = scanningFunction;
				int num5 = 32;
				this.scanningFunction = (DtdParser.ScanningFunction)num5;
				this.LoadParsingBuffer();
				return;
			}
		}

		// Token: 0x06000698 RID: 1688 RVA: 0x00017278 File Offset: 0x00015478
		private bool HandleEntityEnd(bool inLiteral)
		{
			/*
An exception occurred when decompiling this method (06000698)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean System.Xml.DtdParser::HandleEntityEnd(System.Boolean)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_001E:
	stloc:ScanningFunction(var_2_24, ldfld:ScanningFunction(DtdParser::scanningFunction, ldloc:DtdParser(this)))
	stloc:ScanningFunction(var_3_2B, ldfld:ScanningFunction(DtdParser::savedScanningFunction, ldloc:DtdParser(this)))
	stfld:ScanningFunction(DtdParser::scanningFunction, ldloc:DtdParser(this), ldloc:ScanningFunction(var_3_2B))
	stloc:int64(var_5_3C, ldfld:int64(int64::m_value, ldc.i4:int32[exp:int64&](0)))
	stloc:int32(var_6_44, ldfld:int32(DtdParser::externalEntitiesDepth, ldloc:DtdParser(this)))
	stfld:int32(DtdParser::externalEntitiesDepth, ldloc:DtdParser(this), ldloc:int32(var_6_44))
	stloc:ScanningFunction(var_7_54, ldfld:ScanningFunction(DtdParser::scanningFunction, ldloc:DtdParser(this)))
	stfld:ScanningFunction(DtdParser::savedScanningFunction, ldloc:DtdParser(this), ldloc:ScanningFunction(var_7_54))
	stloc:int32(var_8_60, ldc.i4:int32(32))
	stfld:ScanningFunction(DtdParser::scanningFunction, ldloc:DtdParser(this), ldloc:int32[exp:ScanningFunction](var_8_60))
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

		// Token: 0x06000699 RID: 1689 RVA: 0x000172F4 File Offset: 0x000154F4
		private SchemaEntity VerifyEntityReference(XmlQualifiedName entityName, bool paramEntity, bool mustBeDeclared, bool inAttribute)
		{
			int num = 1;
			Dictionary<XmlQualifiedName, SchemaEntity> parameterEntities = this.schemaInfo.ParameterEntities;
			long num2;
			if (num != 0)
			{
				num2 = 0L;
				string name = entityName.name;
				int num3 = this.curPos;
				int stringLength = name._stringLength;
				this.Throw((int)num2, "Reference to unparsed entity '{0}'.", name);
				if ("Reference to unparsed entity '{0}'." != null)
				{
					string name2 = entityName.name;
					int num4 = this.curPos;
					int stringLength2 = name2._stringLength;
					this.Throw((int)num2, "External entity '{0}' reference cannot appear in the attribute value.", name2);
				}
			}
			if (this.validate)
			{
				string name3 = entityName.name;
				if (this.externalEntitiesDepth != 0)
				{
					if (!this.validate)
					{
						return;
					}
					int stringLength3 = entityName.name._stringLength;
					int num5 = this.curPos;
				}
				string name4 = entityName.name;
				int num6 = this.curPos;
				int stringLength4 = name4._stringLength;
				this.Throw((int)num2, "Reference to undeclared entity '{0}'.", name4);
				return;
			}
		}

		// Token: 0x0600069A RID: 1690 RVA: 0x000173C8 File Offset: 0x000155C8
		private void SendValidationEvent(int pos, XmlSeverityType severity, string code, string arg)
		{
			string baseUriStr = this.BaseUriStr;
			int lineNo = this.LineNo;
			int linePos = this.LinePos;
			int num = this.curPos;
		}

		// Token: 0x0600069B RID: 1691 RVA: 0x000173F4 File Offset: 0x000155F4
		private void SendValidationEvent(XmlSeverityType severity, string code, string arg)
		{
			string baseUriStr = this.BaseUriStr;
			int lineNo = this.LineNo;
			int linePos = this.LinePos;
		}

		// Token: 0x0600069C RID: 1692 RVA: 0x00017418 File Offset: 0x00015618
		private void SendValidationEvent(XmlSeverityType severity, XmlSchemaException e)
		{
			IDtdParserAdapterWithValidation dtdParserAdapterWithValidation = this.readerAdapterWithValidation;
		}

		// Token: 0x0600069D RID: 1693 RVA: 0x00003FFD File Offset: 0x000021FD
		private bool IsAttributeValueType(DtdParser.Token token)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x170001B4 RID: 436
		// (get) Token: 0x0600069E RID: 1694 RVA: 0x00017434 File Offset: 0x00015634
		private int LineNo
		{
			get
			{
				/*
An exception occurred when decompiling this method (0600069E)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Int32 System.Xml.DtdParser::get_LineNo()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:IDtdParserAdapter(var_0_06, ldfld:IDtdParserAdapter(DtdParser::readerAdapter, ldloc:DtdParser(this)))
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

		// Token: 0x170001B5 RID: 437
		// (get) Token: 0x0600069F RID: 1695 RVA: 0x00017448 File Offset: 0x00015648
		private int LinePos
		{
			get
			{
				/*
An exception occurred when decompiling this method (0600069F)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Int32 System.Xml.DtdParser::get_LinePos()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:IDtdParserAdapter(var_0_06, ldfld:IDtdParserAdapter(DtdParser::readerAdapter, ldloc:DtdParser(this)))
	stloc:int32(var_1_0D, ldfld:int32(DtdParser::curPos, ldloc:DtdParser(this)))
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

		// Token: 0x170001B6 RID: 438
		// (get) Token: 0x060006A0 RID: 1696 RVA: 0x00017464 File Offset: 0x00015664
		private string BaseUriStr
		{
			get
			{
				/*
An exception occurred when decompiling this method (060006A0)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.String System.Xml.DtdParser::get_BaseUriStr()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:IDtdParserAdapter(var_0_06, ldfld:IDtdParserAdapter(DtdParser::readerAdapter, ldloc:DtdParser(this)))
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

		// Token: 0x060006A1 RID: 1697 RVA: 0x00017478 File Offset: 0x00015678
		private void OnUnexpectedError()
		{
			int num = this.curPos;
			this.Throw(num, "An internal error has occurred.");
		}

		// Token: 0x060006A2 RID: 1698 RVA: 0x00017498 File Offset: 0x00015698
		private void Throw(int curPos, string res)
		{
		}

		// Token: 0x060006A3 RID: 1699 RVA: 0x000174A8 File Offset: 0x000156A8
		private void Throw(int curPos, string res, string arg)
		{
			IDtdParserAdapter dtdParserAdapter = this.readerAdapter;
		}

		// Token: 0x060006A4 RID: 1700 RVA: 0x000174D4 File Offset: 0x000156D4
		private void Throw(int curPos, string res, string[] args)
		{
			IDtdParserAdapter dtdParserAdapter = this.readerAdapter;
			this.curPos = curPos;
		}

		// Token: 0x060006A5 RID: 1701 RVA: 0x00017508 File Offset: 0x00015708
		private void Throw(string res, string arg, int lineNo, int linePos)
		{
			IDtdParserAdapter dtdParserAdapter = this.readerAdapter;
		}

		// Token: 0x060006A6 RID: 1702 RVA: 0x00017528 File Offset: 0x00015728
		private void ThrowInvalidChar(int pos, string data, int invCharPos)
		{
			string[] array = XmlException.BuildCharExceptionArgs(data, invCharPos);
			this.Throw(pos, "'{0}', hexadecimal value {1}, is an invalid character.", array);
		}

		// Token: 0x060006A7 RID: 1703 RVA: 0x0001754C File Offset: 0x0001574C
		private void ThrowInvalidChar(char[] data, int length, int invCharPos)
		{
			string[] array = XmlException.BuildCharExceptionArgs(data, length, invCharPos);
		}

		// Token: 0x060006A8 RID: 1704 RVA: 0x00017564 File Offset: 0x00015764
		private void ThrowUnexpectedToken(int pos, string expectedToken)
		{
		}

		// Token: 0x060006A9 RID: 1705 RVA: 0x00017574 File Offset: 0x00015774
		private void ThrowUnexpectedToken(int pos, string expectedToken1, string expectedToken2)
		{
			string text = this.ParseUnexpectedToken(pos);
			int num = this.curPos;
			if (expectedToken2 != null)
			{
				if ((text == null || text != null) && (expectedToken1 == null || expectedToken1 != null) && expectedToken2 != null)
				{
					return;
				}
			}
			else if ((text == null || text != null) && (expectedToken1 == null || expectedToken1 != null))
			{
				return;
			}
			throw new ArrayTypeMismatchException();
		}

		// Token: 0x060006AA RID: 1706 RVA: 0x000175B8 File Offset: 0x000157B8
		private string ParseUnexpectedToken(int startPos)
		{
			char[] array = this.chars;
			char[] array2 = this.chars;
			char[] array3 = this.chars;
			char[] array4 = this.chars;
			string text;
			return text;
		}

		// Token: 0x060006AB RID: 1707 RVA: 0x000175EC File Offset: 0x000157EC
		internal static string StripSpaces(string value)
		{
			long num = 0L;
			if (!false)
			{
			}
			while (num == 0L)
			{
			}
			string text;
			return text;
		}

		// Token: 0x04000308 RID: 776
		private IDtdParserAdapter readerAdapter;

		// Token: 0x04000309 RID: 777
		private IDtdParserAdapterWithValidation readerAdapterWithValidation;

		// Token: 0x0400030A RID: 778
		private XmlNameTable nameTable;

		// Token: 0x0400030B RID: 779
		private SchemaInfo schemaInfo;

		// Token: 0x0400030C RID: 780
		private XmlCharType xmlCharType;

		// Token: 0x0400030D RID: 781
		private string systemId;

		// Token: 0x0400030E RID: 782
		private string publicId;

		// Token: 0x0400030F RID: 783
		private bool normalize;

		// Token: 0x04000310 RID: 784
		private bool validate;

		// Token: 0x04000311 RID: 785
		private bool supportNamespaces;

		// Token: 0x04000312 RID: 786
		private bool v1Compat;

		// Token: 0x04000313 RID: 787
		private char[] chars;

		// Token: 0x04000314 RID: 788
		private int charsUsed;

		// Token: 0x04000315 RID: 789
		private int curPos;

		// Token: 0x04000316 RID: 790
		private DtdParser.ScanningFunction scanningFunction;

		// Token: 0x04000317 RID: 791
		private DtdParser.ScanningFunction nextScaningFunction;

		// Token: 0x04000318 RID: 792
		private DtdParser.ScanningFunction savedScanningFunction;

		// Token: 0x04000319 RID: 793
		private bool whitespaceSeen;

		// Token: 0x0400031A RID: 794
		private int tokenStartPos;

		// Token: 0x0400031B RID: 795
		private int colonPos;

		// Token: 0x0400031C RID: 796
		private StringBuilder internalSubsetValueSb;

		// Token: 0x0400031D RID: 797
		private int externalEntitiesDepth;

		// Token: 0x0400031E RID: 798
		private int currentEntityId;

		// Token: 0x0400031F RID: 799
		private bool freeFloatingDtd;

		// Token: 0x04000320 RID: 800
		private bool hasFreeFloatingInternalSubset;

		// Token: 0x04000321 RID: 801
		private StringBuilder stringBuilder;

		// Token: 0x04000322 RID: 802
		private int condSectionDepth;

		// Token: 0x04000323 RID: 803
		private LineInfo literalLineInfo;

		// Token: 0x04000324 RID: 804
		private char literalQuoteChar;

		// Token: 0x04000325 RID: 805
		private string documentBaseUri;

		// Token: 0x04000326 RID: 806
		private string externalDtdBaseUri;

		// Token: 0x04000327 RID: 807
		private Dictionary<string, DtdParser.UndeclaredNotation> undeclaredNotations;

		// Token: 0x04000328 RID: 808
		private int[] condSectionEntityIds;

		// Token: 0x0200008A RID: 138
		private enum Token
		{
			// Token: 0x0400032A RID: 810
			CDATA,
			// Token: 0x0400032B RID: 811
			ID,
			// Token: 0x0400032C RID: 812
			IDREF,
			// Token: 0x0400032D RID: 813
			IDREFS,
			// Token: 0x0400032E RID: 814
			ENTITY,
			// Token: 0x0400032F RID: 815
			ENTITIES,
			// Token: 0x04000330 RID: 816
			NMTOKEN,
			// Token: 0x04000331 RID: 817
			NMTOKENS,
			// Token: 0x04000332 RID: 818
			NOTATION,
			// Token: 0x04000333 RID: 819
			None,
			// Token: 0x04000334 RID: 820
			PERef,
			// Token: 0x04000335 RID: 821
			AttlistDecl,
			// Token: 0x04000336 RID: 822
			ElementDecl,
			// Token: 0x04000337 RID: 823
			EntityDecl,
			// Token: 0x04000338 RID: 824
			NotationDecl,
			// Token: 0x04000339 RID: 825
			Comment,
			// Token: 0x0400033A RID: 826
			PI,
			// Token: 0x0400033B RID: 827
			CondSectionStart,
			// Token: 0x0400033C RID: 828
			CondSectionEnd,
			// Token: 0x0400033D RID: 829
			Eof,
			// Token: 0x0400033E RID: 830
			REQUIRED,
			// Token: 0x0400033F RID: 831
			IMPLIED,
			// Token: 0x04000340 RID: 832
			FIXED,
			// Token: 0x04000341 RID: 833
			QName,
			// Token: 0x04000342 RID: 834
			Name,
			// Token: 0x04000343 RID: 835
			Nmtoken,
			// Token: 0x04000344 RID: 836
			Quote,
			// Token: 0x04000345 RID: 837
			LeftParen,
			// Token: 0x04000346 RID: 838
			RightParen,
			// Token: 0x04000347 RID: 839
			GreaterThan,
			// Token: 0x04000348 RID: 840
			Or,
			// Token: 0x04000349 RID: 841
			LeftBracket,
			// Token: 0x0400034A RID: 842
			RightBracket,
			// Token: 0x0400034B RID: 843
			PUBLIC,
			// Token: 0x0400034C RID: 844
			SYSTEM,
			// Token: 0x0400034D RID: 845
			Literal,
			// Token: 0x0400034E RID: 846
			DOCTYPE,
			// Token: 0x0400034F RID: 847
			NData,
			// Token: 0x04000350 RID: 848
			Percent,
			// Token: 0x04000351 RID: 849
			Star,
			// Token: 0x04000352 RID: 850
			QMark,
			// Token: 0x04000353 RID: 851
			Plus,
			// Token: 0x04000354 RID: 852
			PCDATA,
			// Token: 0x04000355 RID: 853
			Comma,
			// Token: 0x04000356 RID: 854
			ANY,
			// Token: 0x04000357 RID: 855
			EMPTY,
			// Token: 0x04000358 RID: 856
			IGNORE,
			// Token: 0x04000359 RID: 857
			INCLUDE
		}

		// Token: 0x0200008B RID: 139
		private enum ScanningFunction
		{
			// Token: 0x0400035B RID: 859
			SubsetContent,
			// Token: 0x0400035C RID: 860
			Name,
			// Token: 0x0400035D RID: 861
			QName,
			// Token: 0x0400035E RID: 862
			Nmtoken,
			// Token: 0x0400035F RID: 863
			Doctype1,
			// Token: 0x04000360 RID: 864
			Doctype2,
			// Token: 0x04000361 RID: 865
			Element1,
			// Token: 0x04000362 RID: 866
			Element2,
			// Token: 0x04000363 RID: 867
			Element3,
			// Token: 0x04000364 RID: 868
			Element4,
			// Token: 0x04000365 RID: 869
			Element5,
			// Token: 0x04000366 RID: 870
			Element6,
			// Token: 0x04000367 RID: 871
			Element7,
			// Token: 0x04000368 RID: 872
			Attlist1,
			// Token: 0x04000369 RID: 873
			Attlist2,
			// Token: 0x0400036A RID: 874
			Attlist3,
			// Token: 0x0400036B RID: 875
			Attlist4,
			// Token: 0x0400036C RID: 876
			Attlist5,
			// Token: 0x0400036D RID: 877
			Attlist6,
			// Token: 0x0400036E RID: 878
			Attlist7,
			// Token: 0x0400036F RID: 879
			Entity1,
			// Token: 0x04000370 RID: 880
			Entity2,
			// Token: 0x04000371 RID: 881
			Entity3,
			// Token: 0x04000372 RID: 882
			Notation1,
			// Token: 0x04000373 RID: 883
			CondSection1,
			// Token: 0x04000374 RID: 884
			CondSection2,
			// Token: 0x04000375 RID: 885
			CondSection3,
			// Token: 0x04000376 RID: 886
			Literal,
			// Token: 0x04000377 RID: 887
			SystemId,
			// Token: 0x04000378 RID: 888
			PublicId1,
			// Token: 0x04000379 RID: 889
			PublicId2,
			// Token: 0x0400037A RID: 890
			ClosingTag,
			// Token: 0x0400037B RID: 891
			ParamEntitySpace,
			// Token: 0x0400037C RID: 892
			None
		}

		// Token: 0x0200008C RID: 140
		private enum LiteralType
		{
			// Token: 0x0400037E RID: 894
			AttributeValue,
			// Token: 0x0400037F RID: 895
			EntityReplText,
			// Token: 0x04000380 RID: 896
			SystemOrPublicID
		}

		// Token: 0x0200008D RID: 141
		private class UndeclaredNotation
		{
			// Token: 0x060006AC RID: 1708 RVA: 0x00017608 File Offset: 0x00015808
			internal UndeclaredNotation(string name, int lineNo, int linePos)
			{
				this.name = name;
				this.lineNo = lineNo;
				this.next = linePos;
			}

			// Token: 0x04000381 RID: 897
			internal string name;

			// Token: 0x04000382 RID: 898
			internal int lineNo;

			// Token: 0x04000383 RID: 899
			internal int linePos;

			// Token: 0x04000384 RID: 900
			internal DtdParser.UndeclaredNotation next;
		}

		// Token: 0x0200008E RID: 142
		private class ParseElementOnlyContent_LocalFrame
		{
			// Token: 0x060006AD RID: 1709 RVA: 0x00017630 File Offset: 0x00015830
			public ParseElementOnlyContent_LocalFrame(int startParentEntityIdParam)
			{
				this.startParenEntityId = startParentEntityIdParam;
			}

			// Token: 0x04000385 RID: 901
			public int startParenEntityId;

			// Token: 0x04000386 RID: 902
			public DtdParser.Token parsingSchema;
		}
	}
}
