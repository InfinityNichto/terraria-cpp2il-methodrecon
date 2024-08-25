using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Xml.Schema;

namespace System.Xml
{
	// Token: 0x02000073 RID: 115
	internal class XmlLoader
	{
		// Token: 0x06000575 RID: 1397 RVA: 0x00012FE4 File Offset: 0x000111E4
		public XmlLoader()
		{
		}

		// Token: 0x06000576 RID: 1398 RVA: 0x00012FF8 File Offset: 0x000111F8
		internal void Load(XmlDocument doc, XmlReader reader, bool preserveWhitespace)
		{
			this.doc = doc;
			Type type;
			bool flag = reader.GetType() == type;
			if (reader != null)
			{
			}
			if (doc == null)
			{
				return;
			}
			if (reader != null)
			{
				doc.baseURI = reader;
				if (reader != null)
				{
					XmlSchemaSet xmlSchemaSet;
					doc.schemas = xmlSchemaSet;
				}
				XmlReader xmlReader = this.reader;
				XmlReader xmlReader2 = this.reader;
				this.LoadDocSequence(doc);
				return;
			}
			string @string = Res.GetString("There is no reader from which to load the document.");
			throw new InvalidCastException();
		}

		// Token: 0x06000577 RID: 1399 RVA: 0x00013060 File Offset: 0x00011260
		private void LoadDocSequence(XmlDocument parentDoc)
		{
			if (this.LoadNode(true) != null)
			{
				XmlReader xmlReader = this.reader;
			}
		}

		// Token: 0x06000578 RID: 1400 RVA: 0x00013080 File Offset: 0x00011280
		private XmlNode LoadNode(bool skipOverWhitespace)
		{
			XmlReader xmlReader;
			long num;
			XmlDocument xmlDocument8;
			for (;;)
			{
				xmlReader = this.reader;
				num = 0L;
				XmlDocument xmlDocument = this.doc;
				XmlNamedNodeMap entities = xmlDocument.entities;
				xmlDocument.RemoveAll();
				xmlDocument.entities = xmlDocument;
				if (!this.preserveWhitespace)
				{
					break;
				}
				XmlDocument xmlDocument2 = this.doc;
				if (num == 0L)
				{
					return;
				}
				if (xmlReader != null)
				{
					XmlDocument xmlDocument3 = this.doc;
				}
				if (num == 0L)
				{
					return;
				}
				XmlDeclaration xmlDeclaration = this.LoadDeclarationNode();
				long num2 = 0L;
				XmlEntityReference xmlEntityReference = this.LoadEntityReferenceNode(num2 != 0L);
				XmlDocument xmlDocument4 = this.doc;
				XmlAttribute xmlAttribute = this.LoadAttributeNode();
				XmlDocument xmlDocument5 = this.doc;
				XmlDocument xmlDocument6 = this.doc;
				XmlDocument xmlDocument7 = this.doc;
				XmlDocumentType xmlDocumentType = this.LoadDocumentTypeNode();
				xmlDocument8 = this.doc;
				if (num != 0L)
				{
					goto Block_4;
				}
			}
			IL_00D3:
			while (xmlDocument8 != null)
			{
			}
			if (xmlDocument8 == null || xmlDocument8 != null)
			{
				return;
			}
			return;
			Block_4:
			XmlDocument xmlDocument9 = this.doc;
			XmlAttribute xmlAttribute2 = this.LoadAttributeNode();
			while (xmlReader == null)
			{
			}
			XmlDocument xmlDocument10 = this.doc;
			XmlName xmlName;
			xmlDocument8.domNameTable = xmlName;
			while (num != 0L)
			{
			}
			if (num != 0L)
			{
				XmlDocument xmlDocument11 = this.doc;
				goto IL_00D3;
			}
			goto IL_00D3;
		}

		// Token: 0x06000579 RID: 1401 RVA: 0x00013170 File Offset: 0x00011370
		private XmlAttribute LoadAttributeNode()
		{
			XmlReader xmlReader = this.reader;
			return this.LoadDefaultAttribute();
		}

		// Token: 0x0600057A RID: 1402 RVA: 0x000131DC File Offset: 0x000113DC
		private XmlAttribute LoadDefaultAttribute()
		{
			/*
An exception occurred when decompiling this method (0600057A)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Xml.XmlAttribute System.Xml.XmlLoader::LoadDefaultAttribute()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_001D:
	stloc:int64(var_3_1E, ldc.i4:int64(0))
	call:void(XmlLoader::LoadAttributeValue, ldloc:XmlLoader(this), ldloc:XmlDocument[exp:XmlNode](var_0_06), ldloc:int64[exp:bool](var_3_1E))
	brtrue(IL_0000, logicnot:bool(ldloc:XmlDocument[exp:bool](var_0_06)))
}

   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1852
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1878
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1878
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1846
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.Optimize(DecompilerContext context, ILBlock method, AutoPropertyProvider autoPropertyProvider, StateMachineKind& stateMachineKind, MethodDef& inlinedMethod, AsyncMethodDebugInfo& asyncInfo, ILAstOptimizationStep abortBeforeStep) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 355
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(IEnumerable`1 parameters, MethodDebugInfoBuilder& builder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 123
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 88
   --- End of inner exception stack trace ---
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 92
   at ICSharpCode.Decompiler.Ast.AstBuilder.AddMethodBody(EntityDeclaration methodNode, EntityDeclaration& updatedNode, MethodDef method, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, MethodKind methodKind) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 1683
*/;
		}

		// Token: 0x0600057B RID: 1403 RVA: 0x00013214 File Offset: 0x00011414
		private void LoadAttributeValue(XmlNode parent, bool direct)
		{
			XmlReader xmlReader = this.reader;
			XmlDocument xmlDocument = this.doc;
		}

		// Token: 0x0600057C RID: 1404 RVA: 0x00013278 File Offset: 0x00011478
		private XmlEntityReference LoadEntityReferenceNode(bool direct)
		{
			/*
An exception occurred when decompiling this method (0600057C)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Xml.XmlEntityReference System.Xml.XmlLoader::LoadEntityReferenceNode(System.Boolean)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_1:
	stloc:XmlDocument(var_12_5C, ldfld:XmlDocument(XmlLoader::doc, ldloc:XmlLoader(this)))
	stloc:XmlDocument(var_13_64, ldfld:XmlDocument(XmlLoader::doc, ldloc:XmlLoader(this)))
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

		// Token: 0x0600057D RID: 1405 RVA: 0x000132EC File Offset: 0x000114EC
		private XmlDeclaration LoadDeclarationNode()
		{
			/*
An exception occurred when decompiling this method (0600057D)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Xml.XmlDeclaration System.Xml.XmlLoader::LoadDeclarationNode()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0038:
	stloc:XmlDocument(var_10_3E, ldfld:XmlDocument(XmlLoader::doc, ldloc:XmlLoader(this)))
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

		// Token: 0x0600057E RID: 1406 RVA: 0x00013338 File Offset: 0x00011538
		private XmlDocumentType LoadDocumentTypeNode()
		{
			/*
An exception occurred when decompiling this method (0600057E)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Xml.XmlDocumentType System.Xml.XmlLoader::LoadDocumentTypeNode()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0000:
	stloc:XmlReader(var_0_06, ldfld:XmlReader(XmlLoader::reader, ldloc:XmlLoader(this)))
	stloc:XmlReader(var_1_0D, ldfld:XmlReader(XmlLoader::reader, ldloc:XmlLoader(this)))
	stloc:XmlReader(var_2_14, ldfld:XmlReader(XmlLoader::reader, ldloc:XmlLoader(this)))
	stloc:XmlReader(var_3_1B, ldfld:XmlReader(XmlLoader::reader, ldloc:XmlLoader(this)))
	stloc:XmlReader(var_6_22, ldfld:XmlReader(XmlLoader::reader, ldloc:XmlLoader(this)))
	stloc:XmlReader(var_7_2A, ldfld:XmlReader(XmlLoader::reader, ldloc:XmlLoader(this)))
	stloc:XmlDocument(var_8_32, ldfld:XmlDocument(XmlLoader::doc, ldloc:XmlLoader(this)))
	brtrue(IL_0000, logicnot:bool(ldfld:XmlReader[exp:bool](XmlLoader::reader, ldloc:XmlLoader(this))))
}

   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1852
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1878
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1878
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1846
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.Optimize(DecompilerContext context, ILBlock method, AutoPropertyProvider autoPropertyProvider, StateMachineKind& stateMachineKind, MethodDef& inlinedMethod, AsyncMethodDebugInfo& asyncInfo, ILAstOptimizationStep abortBeforeStep) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 355
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(IEnumerable`1 parameters, MethodDebugInfoBuilder& builder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 123
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 88
   --- End of inner exception stack trace ---
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 92
   at ICSharpCode.Decompiler.Ast.AstBuilder.AddMethodBody(EntityDeclaration methodNode, EntityDeclaration& updatedNode, MethodDef method, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, MethodKind methodKind) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 1683
*/;
		}

		// Token: 0x0600057F RID: 1407 RVA: 0x00013380 File Offset: 0x00011580
		private XmlNode LoadNodeDirect()
		{
			/*
An exception occurred when decompiling this method (0600057F)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Xml.XmlNode System.Xml.XmlLoader::LoadNodeDirect()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_00FB:
	stloc:XmlReader(var_30_101, ldfld:XmlReader(XmlLoader::reader, ldloc:XmlLoader(this)))
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

		// Token: 0x06000580 RID: 1408 RVA: 0x00013490 File Offset: 0x00011690
		private XmlAttribute LoadAttributeNodeDirect()
		{
			/*
An exception occurred when decompiling this method (06000580)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Xml.XmlAttribute System.Xml.XmlLoader::LoadAttributeNodeDirect()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:XmlReader(var_0_06, ldfld:XmlReader(XmlLoader::reader, ldloc:XmlLoader(this)))
	stloc:XmlDocument(var_1_0D, ldfld:XmlDocument(XmlLoader::doc, ldloc:XmlLoader(this)))
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

		// Token: 0x06000581 RID: 1409 RVA: 0x000134AC File Offset: 0x000116AC
		internal void ParseDocumentType(XmlDocumentType dtNode)
		{
		}

		// Token: 0x06000582 RID: 1410 RVA: 0x000134BC File Offset: 0x000116BC
		private void ParseDocumentType(XmlDocumentType dtNode, bool bUseResolver, XmlResolver resolver)
		{
			this.doc = dtNode;
			XmlDocument xmlDocument = this.doc;
			bool namespaces = dtNode.namespaces;
			IDtdParser dtdParser = DtdParser.Create();
			XmlDocument xmlDocument2 = this.doc;
			string publicId = dtNode.publicId;
			string systemId = dtNode.systemId;
			string internalSubset = dtNode.internalSubset;
		}

		// Token: 0x06000583 RID: 1411 RVA: 0x00013508 File Offset: 0x00011708
		private void LoadDocumentType(IDtdInfo dtdInfo, XmlDocumentType dtNode)
		{
			if (dtdInfo == null)
			{
				return;
			}
			dtNode.schemaInfo = dtdInfo;
			XmlDocument xmlDocument = this.doc;
			xmlDocument.schemaInfo = dtdInfo;
			Dictionary<string, SchemaNotation> dictionary;
			XmlNamedNodeMap notations;
			if (dictionary != null)
			{
				notations = dtNode.Notations;
				XmlDocument xmlDocument2 = this.doc;
				XmlNode parentNode = xmlDocument.parentNode;
				return;
			}
			Dictionary<XmlQualifiedName, SchemaEntity> dictionary2;
			if (dictionary2 != null)
			{
				XmlNode parent = notations.parent;
				XmlNamedNodeMap.SmallXmlNodeList nodes = notations.nodes;
				XmlNode parentNode2 = parent.parentNode;
				return;
			}
			Dictionary<XmlQualifiedName, SchemaEntity> dictionary3;
			if (dictionary3 != null)
			{
				XmlNode parent2 = notations.parent;
				XmlNamedNodeMap.SmallXmlNodeList nodes2 = notations.nodes;
				XmlNode parentNode3 = parent2.parentNode;
				return;
			}
			XmlDocument xmlDocument3 = this.doc;
			XmlNamedNodeMap entities = dtNode.Entities;
			xmlDocument3.entities = entities;
		}

		// Token: 0x06000584 RID: 1412 RVA: 0x00013644 File Offset: 0x00011844
		private XmlParserContext GetContext(XmlNode node)
		{
			XmlDocument xmlDocument = this.doc;
			XmlDocument xmlDocument2 = this.doc;
			XmlNameTable nameTable = this.doc.NameTable;
			if (node != null)
			{
				long num = 0L;
				long num2 = 0L;
				XmlDocument xmlDocument3 = this.doc;
				string strXmlns = this.doc.strXmlns;
				if (node.parentNode == null)
				{
					string strXmlns2 = this.doc.strXmlns;
				}
				if (num2 == 0L)
				{
					string strXml = this.doc.strXml;
					string strSpace = this.doc.strSpace;
				}
				while (num != 0L)
				{
				}
				string strXml2 = this.doc.strXml;
				string strLang = this.doc.strLang;
				while (node != null)
				{
				}
				long num3 = 0L;
				if (node != null)
				{
				}
				while (num3 == 0L)
				{
				}
				throw new InvalidCastException();
			}
			if (node != null)
			{
			}
			if (!false)
			{
			}
			throw new OutOfMemoryException();
		}

		// Token: 0x06000585 RID: 1413 RVA: 0x00013708 File Offset: 0x00011908
		internal XmlNamespaceManager ParsePartialContent(XmlNode parentNode, string innerxmltext, XmlNodeType nt)
		{
			this.doc = parentNode;
			XmlParserContext context = this.GetContext(parentNode);
			XmlDocument xmlDocument = this.doc;
			XmlDocument xmlDocument2 = this.doc;
			XmlReader xmlReader;
			this.reader = xmlReader;
			this.preserveWhitespace = true;
			bool isLoading = xmlDocument2.isLoading;
			xmlDocument2.isLoading = true;
			if (this.LoadNodeDirect() != null)
			{
				XmlDocument xmlDocument3 = this.doc;
				XmlReader xmlReader2 = this.reader;
				if (this.LoadNode(true) != null)
				{
					XmlDocument xmlDocument4 = this.doc;
					XmlReader xmlReader3 = this.reader;
				}
			}
			XmlDocument xmlDocument5 = this.doc;
			long num = 0L;
			xmlDocument5.isLoading = isLoading;
			XmlReader xmlReader4 = this.reader;
			if (num == 0L)
			{
				return context._nsMgr;
			}
			throw new OutOfMemoryException();
		}

		// Token: 0x06000586 RID: 1414 RVA: 0x000137C8 File Offset: 0x000119C8
		internal void LoadInnerXmlElement(XmlElement node, string innerxmltext)
		{
			XmlNamespaceManager xmlNamespaceManager = this.ParsePartialContent(node, innerxmltext, XmlNodeType.Element);
			long num = 0L;
			this.RemoveDuplicateNamespace(node, xmlNamespaceManager, num != 0L);
		}

		// Token: 0x06000587 RID: 1415 RVA: 0x000137EC File Offset: 0x000119EC
		internal void LoadInnerXmlAttribute(XmlAttribute node, string innerxmltext)
		{
			XmlNamespaceManager xmlNamespaceManager = this.ParsePartialContent(node, innerxmltext, XmlNodeType.Attribute);
		}

		// Token: 0x06000588 RID: 1416 RVA: 0x00013804 File Offset: 0x00011A04
		private void RemoveDuplicateNamespace(XmlElement elem, XmlNamespaceManager mgr, bool fCheckElemAttrs)
		{
			string strXmlns = this.doc.strXmlns;
			if (mgr != null)
			{
				return;
			}
			if (elem != null)
			{
				int num = 1;
				this.RemoveDuplicateNamespace(elem, mgr, num != 0);
				while (elem != null)
				{
				}
			}
		}

		// Token: 0x06000589 RID: 1417 RVA: 0x0001384C File Offset: 0x00011A4C
		private string EntitizeName(string name)
		{
			return "&" + name + ";";
		}

		// Token: 0x0600058A RID: 1418 RVA: 0x0001386C File Offset: 0x00011A6C
		internal void ExpandEntity(XmlEntity ent)
		{
			string text;
			XmlNamespaceManager xmlNamespaceManager = this.ParsePartialContent(ent, text, XmlNodeType.Entity);
		}

		// Token: 0x0600058B RID: 1419 RVA: 0x00013884 File Offset: 0x00011A84
		internal void ExpandEntityReference(XmlEntityReference eref)
		{
			this.doc = eref;
			XmlDocument xmlDocument = this.doc;
		}

		// Token: 0x0600058C RID: 1420 RVA: 0x00013938 File Offset: 0x00011B38
		private XmlReader CreateInnerXmlReader(string xmlFragment, XmlNodeType nt, XmlParserContext context, XmlDocument doc)
		{
			/*
An exception occurred when decompiling this method (0600058C)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Xml.XmlReader System.Xml.XmlLoader::CreateInnerXmlReader(System.String,System.Xml.XmlNodeType,System.Xml.XmlParserContext,System.Xml.XmlDocument)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0062:
	stloc:int64(var_9_63, ldc.i4:int64(0))
	stfld:bool(XmlDocument::reportValidity, ldloc:XmlDocument(doc), ldloc:int64[exp:bool](var_9_63))
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

		// Token: 0x0600058D RID: 1421 RVA: 0x000139B4 File Offset: 0x00011BB4
		internal static void ParseXmlDeclarationValue(string strValue, [Out] string version, [Out] string encoding, [Out] string standalone)
		{
		}

		// Token: 0x0600058E RID: 1422 RVA: 0x000139E4 File Offset: 0x00011BE4
		internal static Exception UnexpectedNodeType(XmlNodeType nodetype)
		{
			/*
An exception occurred when decompiling this method (0600058E)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Exception System.Xml.XmlLoader::UnexpectedNodeType(System.Xml.XmlNodeType)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0003:
	stloc:CultureInfo(var_1_0A, callgetter:CultureInfo(CultureInfo::get_InvariantCulture))
	stloc:string(var_2_15, call:string(Res::GetString, ldstr:string("Unexpected XmlNodeType: '{0}'.")))
	stloc:string(var_4_1E, call:string(string::Format, ldloc:CultureInfo[exp:IFormatProvider](var_1_0A), ldloc:string(var_2_15), ldloc:string[exp:object](var_3)))
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

		// Token: 0x040002DF RID: 735
		private XmlDocument doc;

		// Token: 0x040002E0 RID: 736
		private XmlReader reader;

		// Token: 0x040002E1 RID: 737
		private bool preserveWhitespace;
	}
}
