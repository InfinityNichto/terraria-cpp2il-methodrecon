using System;
using System.Collections;
using System.Xml.Schema;
using Cpp2IlInjected;

namespace System.Xml
{
	// Token: 0x0200006A RID: 106
	public class XmlDocument : XmlNode
	{
		// Token: 0x060004C2 RID: 1218 RVA: 0x00011C08 File Offset: 0x0000FE08
		public XmlDocument()
		{
		}

		// Token: 0x060004C3 RID: 1219 RVA: 0x00011C18 File Offset: 0x0000FE18
		protected internal XmlDocument(XmlImplementation imp)
		{
			this.implementation = imp;
			XmlNameTable nameTable = this.implementation.nameTable;
			this.strDocumentName = nameTable;
			this.strDocumentFragmentName = nameTable;
			this.strCommentName = nameTable;
			this.strTextName = nameTable;
			this.strCDataSectionName = nameTable;
			this.strEntityName = nameTable;
			this.strID = nameTable;
			this.strNonSignificantWhitespaceName = nameTable;
			this.strSignificantWhitespaceName = nameTable;
			this.strXmlns = nameTable;
			this.strXml = nameTable;
			this.strSpace = nameTable;
			this.strLang = nameTable;
			this.strReservedXmlns = nameTable;
			this.strReservedXml = nameTable;
			this.strEmpty = nameTable;
		}

		// Token: 0x1700010C RID: 268
		// (get) Token: 0x060004C4 RID: 1220 RVA: 0x00011CB0 File Offset: 0x0000FEB0
		// (set) Token: 0x060004C5 RID: 1221 RVA: 0x00011CC4 File Offset: 0x0000FEC4
		internal SchemaInfo DtdSchemaInfo
		{
			get
			{
				return this.schemaInfo;
			}
			set
			{
				this.schemaInfo = value;
			}
		}

		// Token: 0x060004C6 RID: 1222 RVA: 0x00011CD8 File Offset: 0x0000FED8
		internal static void CheckName(string name)
		{
			if (!true)
			{
			}
			long num = 0L;
			int num2 = ValidateNames.ParseNmtoken(name, (int)num);
			int stringLength = name._stringLength;
		}

		// Token: 0x060004C7 RID: 1223 RVA: 0x00011D04 File Offset: 0x0000FF04
		internal XmlName AddXmlName(string prefix, string localName, string namespaceURI, IXmlSchemaInfo schemaInfo)
		{
			return this.domNameTable.AddName(prefix, localName, namespaceURI, schemaInfo);
		}

		// Token: 0x060004C8 RID: 1224 RVA: 0x00011D24 File Offset: 0x0000FF24
		internal XmlName GetXmlName(string prefix, string localName, string namespaceURI, IXmlSchemaInfo schemaInfo)
		{
			return this.domNameTable.GetName(prefix, localName, namespaceURI, schemaInfo);
		}

		// Token: 0x060004C9 RID: 1225 RVA: 0x00011D44 File Offset: 0x0000FF44
		internal XmlName AddAttrXmlName(string prefix, string localName, string namespaceURI, IXmlSchemaInfo schemaInfo)
		{
			XmlName xmlName = this.domNameTable.AddName(prefix, localName, namespaceURI, schemaInfo);
			if (!this.isLoading)
			{
				string prefix2 = xmlName.prefix;
				string text = this.strXmlns;
				string ns = xmlName.ns;
				string text2 = this.strEmpty;
				return xmlName;
			}
			return xmlName;
		}

		// Token: 0x060004CA RID: 1226 RVA: 0x00011DA4 File Offset: 0x0000FFA4
		internal bool AddIdInfo(XmlName eleName, XmlName attrName)
		{
			Hashtable hashtable = this.htElementIDAttrDecl;
			if (hashtable != null)
			{
				if (hashtable != null)
				{
				}
				if (this.htElementIDAttrDecl == null)
				{
				}
			}
			return true;
		}

		// Token: 0x060004CB RID: 1227 RVA: 0x00011DCC File Offset: 0x0000FFCC
		private XmlName GetIDInfoByElement_(XmlName eleName)
		{
			string prefix = eleName.prefix;
			string localName = eleName.localName;
			DomNameTable domNameTable = this.domNameTable;
			XmlName xmlName;
			if (xmlName == null || this.htElementIDAttrDecl != null)
			{
			}
			throw new InvalidCastException();
		}

		// Token: 0x060004CC RID: 1228 RVA: 0x00011E00 File Offset: 0x00010000
		internal XmlName GetIDInfoByElement(XmlName eleName)
		{
			if (this.htElementIDAttrDecl != null)
			{
				return this.GetIDInfoByElement_(eleName);
			}
		}

		// Token: 0x060004CD RID: 1229 RVA: 0x00011E20 File Offset: 0x00010020
		private WeakReference GetElement(ArrayList elementList, XmlElement elem)
		{
			if (elementList != null)
			{
			}
			long num = 0L;
			int num2 = 5;
			if (elementList != null)
			{
			}
			if (num != 0L)
			{
				throw new OutOfMemoryException();
			}
			if (num2 != 0 || !false)
			{
				throw new InvalidCastException();
			}
			throw new OutOfMemoryException();
		}

		// Token: 0x060004CE RID: 1230 RVA: 0x00011E78 File Offset: 0x00010078
		internal void AddElementWithId(string id, XmlElement elem)
		{
			if (this.htElementIdMap == null)
			{
				Hashtable hashtable = this.htElementIdMap;
				return;
			}
			if (this.htElementIdMap != null)
			{
			}
			WeakReference weakReference;
			if (weakReference != null)
			{
				return;
			}
		}

		// Token: 0x060004CF RID: 1231 RVA: 0x00011EA8 File Offset: 0x000100A8
		internal void RemoveElementWithId(string id, XmlElement elem)
		{
			if (this.htElementIdMap != null)
			{
				Hashtable hashtable = this.htElementIdMap;
				if (hashtable != null)
				{
				}
				WeakReference weakReference;
				if (weakReference != null && hashtable == null)
				{
					Hashtable hashtable2 = this.htElementIdMap;
					return;
				}
			}
		}

		// Token: 0x060004D0 RID: 1232 RVA: 0x00011EDC File Offset: 0x000100DC
		public override XmlNode CloneNode(bool deep)
		{
			/*
An exception occurred when decompiling this method (060004D0)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Xml.XmlNode System.Xml.XmlDocument::CloneNode(System.Boolean)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:XmlImplementation(var_0_06, ldfld:XmlImplementation(XmlDocument::implementation, ldloc:XmlDocument(this)))
	stloc:string(var_1_0D, ldfld:string(XmlDocument::baseURI, ldloc:XmlDocument(this)))
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

		// Token: 0x1700010D RID: 269
		// (get) Token: 0x060004D1 RID: 1233 RVA: 0x00011EF8 File Offset: 0x000100F8
		public override XmlNodeType NodeType
		{
			get
			{
				return XmlNodeType.Document;
			}
		}

		// Token: 0x1700010E RID: 270
		// (get) Token: 0x060004D2 RID: 1234 RVA: 0x00011F08 File Offset: 0x00010108
		public override XmlNode ParentNode
		{
			get
			{
			}
		}

		// Token: 0x1700010F RID: 271
		// (get) Token: 0x060004D3 RID: 1235 RVA: 0x00011F18 File Offset: 0x00010118
		public virtual XmlDocumentType DocumentType
		{
			get
			{
				if (this != null)
				{
				}
				throw new InvalidCastException();
			}
		}

		// Token: 0x17000110 RID: 272
		// (get) Token: 0x060004D4 RID: 1236 RVA: 0x00011F30 File Offset: 0x00010130
		internal virtual XmlDeclaration Declaration
		{
			get
			{
				while (this == null)
				{
				}
			}
		}

		// Token: 0x17000111 RID: 273
		// (get) Token: 0x060004D5 RID: 1237 RVA: 0x00011F44 File Offset: 0x00010144
		public XmlImplementation Implementation
		{
			get
			{
				return this.implementation;
			}
		}

		// Token: 0x17000112 RID: 274
		// (get) Token: 0x060004D6 RID: 1238 RVA: 0x00011F58 File Offset: 0x00010158
		public override string Name
		{
			get
			{
				return this.strDocumentName;
			}
		}

		// Token: 0x17000113 RID: 275
		// (get) Token: 0x060004D7 RID: 1239 RVA: 0x00011F6C File Offset: 0x0001016C
		public override string LocalName
		{
			get
			{
				return this.strDocumentName;
			}
		}

		// Token: 0x17000114 RID: 276
		// (get) Token: 0x060004D8 RID: 1240 RVA: 0x00011F80 File Offset: 0x00010180
		public XmlElement DocumentElement
		{
			get
			{
				if (this != null)
				{
				}
				throw new InvalidCastException();
			}
		}

		// Token: 0x17000115 RID: 277
		// (get) Token: 0x060004D9 RID: 1241 RVA: 0x00011F98 File Offset: 0x00010198
		internal override bool IsContainer
		{
			get
			{
				return true;
			}
		}

		// Token: 0x17000116 RID: 278
		// (get) Token: 0x060004DA RID: 1242 RVA: 0x00011FA8 File Offset: 0x000101A8
		// (set) Token: 0x060004DB RID: 1243 RVA: 0x00011FBC File Offset: 0x000101BC
		internal override XmlLinkedNode LastNode
		{
			get
			{
				return this.lastChild;
			}
			set
			{
				this.lastChild = value;
			}
		}

		// Token: 0x17000117 RID: 279
		// (get) Token: 0x060004DC RID: 1244 RVA: 0x00011FD0 File Offset: 0x000101D0
		public override XmlDocument OwnerDocument
		{
			get
			{
			}
		}

		// Token: 0x17000118 RID: 280
		// (set) Token: 0x060004DD RID: 1245 RVA: 0x00011FE0 File Offset: 0x000101E0
		public XmlSchemaSet Schemas
		{
			set
			{
				this.schemas = value;
			}
		}

		// Token: 0x17000119 RID: 281
		// (get) Token: 0x060004DE RID: 1246 RVA: 0x00011FF4 File Offset: 0x000101F4
		internal bool CanReportValidity
		{
			get
			{
				return this.reportValidity;
			}
		}

		// Token: 0x1700011A RID: 282
		// (get) Token: 0x060004DF RID: 1247 RVA: 0x00012008 File Offset: 0x00010208
		internal bool HasSetResolver
		{
			get
			{
				return this.bSetResolver;
			}
		}

		// Token: 0x060004E0 RID: 1248 RVA: 0x0001201C File Offset: 0x0001021C
		internal XmlResolver GetResolver()
		{
			return this.resolver;
		}

		// Token: 0x1700011B RID: 283
		// (set) Token: 0x060004E1 RID: 1249 RVA: 0x00012030 File Offset: 0x00010230
		public virtual XmlResolver XmlResolver
		{
			set
			{
				if (value != null)
				{
				}
				bool flag = this.bSetResolver;
				this.resolver = value;
				if (!flag)
				{
					int num = 1;
					this.bSetResolver = num != 0;
				}
				if (this != null)
				{
				}
			}
		}

		// Token: 0x060004E2 RID: 1250 RVA: 0x00012070 File Offset: 0x00010270
		internal override bool IsValidChildType(XmlNodeType type)
		{
			while (this == null)
			{
			}
			return "This document already has a 'DocumentType' node." != null;
		}

		// Token: 0x060004E3 RID: 1251 RVA: 0x000120A8 File Offset: 0x000102A8
		private bool HasNodeTypeInPrevSiblings(XmlNodeType nt, XmlNode refNode)
		{
			if (refNode != null)
			{
				if (refNode != null && refNode != null)
				{
					while (refNode != null)
					{
					}
				}
			}
			return true;
		}

		// Token: 0x060004E4 RID: 1252 RVA: 0x000120C4 File Offset: 0x000102C4
		private bool HasNodeTypeInNextSiblings(XmlNodeType nt, XmlNode refNode)
		{
			if (refNode != null)
			{
				while (refNode != null)
				{
				}
			}
			return true;
		}

		// Token: 0x060004E5 RID: 1253 RVA: 0x000120DC File Offset: 0x000102DC
		internal override bool CanInsertAfter(XmlNode newChild, XmlNode refChild)
		{
			if (refChild != null || this != null)
			{
			}
			bool flag;
			return flag;
		}

		// Token: 0x060004E6 RID: 1254 RVA: 0x00003FFD File Offset: 0x000021FD
		public XmlAttribute CreateAttribute(string name)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x060004E7 RID: 1255 RVA: 0x000120F8 File Offset: 0x000102F8
		internal void SetDefaultNamespace(string prefix, string localName, string namespaceURI)
		{
			string text = this.strXmlns;
			bool flag = prefix == text;
		}

		// Token: 0x060004E8 RID: 1256 RVA: 0x00012140 File Offset: 0x00010340
		public virtual XmlCDataSection CreateCDataSection(string data)
		{
			/*
An exception occurred when decompiling this method (060004E8)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Xml.XmlCDataSection System.Xml.XmlDocument::CreateCDataSection(System.String)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stfld:bool(XmlDocument::fCDataNodesPresent, ldloc:XmlDocument(this), ldc.i4:bool(1))
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

		// Token: 0x060004E9 RID: 1257 RVA: 0x00003FFD File Offset: 0x000021FD
		public virtual XmlComment CreateComment(string data)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x060004EA RID: 1258 RVA: 0x00003FFD File Offset: 0x000021FD
		public virtual XmlDocumentType CreateDocumentType(string name, string publicId, string systemId, string internalSubset)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x060004EB RID: 1259 RVA: 0x00003FFD File Offset: 0x000021FD
		public virtual XmlDocumentFragment CreateDocumentFragment()
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x060004EC RID: 1260 RVA: 0x00003FFD File Offset: 0x000021FD
		public XmlElement CreateElement(string name)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x060004ED RID: 1261 RVA: 0x00012154 File Offset: 0x00010354
		internal void AddDefaultAttributes(XmlElement elem)
		{
			SchemaInfo schemaInfo = this.schemaInfo;
			SchemaElementDecl schemaElementDecl = this.GetSchemaElementDecl(elem);
			if (schemaElementDecl != null && schemaElementDecl.attdefs != null)
			{
				return;
			}
		}

		// Token: 0x060004EE RID: 1262 RVA: 0x0001218C File Offset: 0x0001038C
		private SchemaElementDecl GetSchemaElementDecl(XmlElement elem)
		{
			/*
An exception occurred when decompiling this method (060004EE)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Xml.Schema.SchemaElementDecl System.Xml.XmlDocument::GetSchemaElementDecl(System.Xml.XmlElement)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0011:
	stloc:class [mscorlib]System.Collections.Generic.Dictionary`2<class System.Xml.XmlQualifiedName, class System.Xml.Schema.SchemaElementDecl>(var_3_19, ldfld:class [mscorlib]System.Collections.Generic.Dictionary`2<class System.Xml.XmlQualifiedName, class System.Xml.Schema.SchemaElementDecl>(SchemaInfo::elementDecls, ldloc:SchemaInfo(var_0_06)))
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

		// Token: 0x060004EF RID: 1263 RVA: 0x000121B4 File Offset: 0x000103B4
		private XmlAttribute PrepareDefaultAttribute(SchemaAttDef attdef, string attrPrefix, string attrLocalname, string attrNamespaceURI)
		{
			/*
An exception occurred when decompiling this method (060004EF)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Xml.XmlAttribute System.Xml.XmlDocument::PrepareDefaultAttribute(System.Xml.Schema.SchemaAttDef,System.String,System.String,System.String)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0000:
	call:void(XmlDocument::SetDefaultNamespace, ldloc:XmlDocument(this), ldloc:string(attrPrefix), ldloc:string(attrLocalname), ldloc:string(attrLocalname))
	stloc:string(var_0_0F, callgetter:string(SchemaDeclBase::get_DefaultValueRaw, ldloc:SchemaAttDef[exp:SchemaDeclBase](attdef)))
	brtrue(IL_0000, logicnot:bool(ldloc:XmlDocument[exp:bool](this)))
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

		// Token: 0x060004F0 RID: 1264 RVA: 0x00003FFD File Offset: 0x000021FD
		public virtual XmlEntityReference CreateEntityReference(string name)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x060004F1 RID: 1265 RVA: 0x00003FFD File Offset: 0x000021FD
		public virtual XmlProcessingInstruction CreateProcessingInstruction(string target, string data)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x060004F2 RID: 1266 RVA: 0x00003FFD File Offset: 0x000021FD
		public virtual XmlDeclaration CreateXmlDeclaration(string version, string encoding, string standalone)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x060004F3 RID: 1267 RVA: 0x00003FFD File Offset: 0x000021FD
		public virtual XmlText CreateTextNode(string text)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x060004F4 RID: 1268 RVA: 0x00003FFD File Offset: 0x000021FD
		public virtual XmlSignificantWhitespace CreateSignificantWhitespace(string text)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x060004F5 RID: 1269 RVA: 0x00003FFD File Offset: 0x000021FD
		public virtual XmlWhitespace CreateWhitespace(string text)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x060004F6 RID: 1270 RVA: 0x000121D4 File Offset: 0x000103D4
		public XmlAttribute CreateAttribute(string qualifiedName, string namespaceURI)
		{
			/*
An exception occurred when decompiling this method (060004F6)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Xml.XmlAttribute System.Xml.XmlDocument::CreateAttribute(System.String,System.String)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	call:void(XmlNode::SplitName, ldloc:string(qualifiedName), ldloc:string(qualifiedName), ldloc:string(namespaceURI))
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

		// Token: 0x060004F7 RID: 1271 RVA: 0x000121E8 File Offset: 0x000103E8
		public XmlElement CreateElement(string qualifiedName, string namespaceURI)
		{
			/*
An exception occurred when decompiling this method (060004F7)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Xml.XmlElement System.Xml.XmlDocument::CreateElement(System.String,System.String)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	call:void(XmlNode::SplitName, ldloc:string(qualifiedName), ldloc:string(qualifiedName), ldloc:string(namespaceURI))
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

		// Token: 0x060004F8 RID: 1272 RVA: 0x000121FC File Offset: 0x000103FC
		private XmlNode ImportNodeInternal(XmlNode node, bool deep)
		{
			if (node != null)
			{
				return node;
			}
			string @string = Res.GetString("Cannot import a null node.");
			throw new InvalidCastException();
		}

		// Token: 0x060004F9 RID: 1273 RVA: 0x00012268 File Offset: 0x00010468
		private void ImportAttributes(XmlNode fromElem, XmlNode toElem)
		{
			int num = 1;
			XmlAttribute xmlAttribute;
			XmlNode xmlNode = this.ImportNodeInternal(xmlAttribute, num != 0);
		}

		// Token: 0x060004FA RID: 1274 RVA: 0x00012284 File Offset: 0x00010484
		private void ImportChildren(XmlNode fromNode, XmlNode toNode, bool deep)
		{
			if (fromNode != null)
			{
				XmlNode xmlNode = this.ImportNodeInternal(fromNode, deep);
				while (fromNode != null)
				{
				}
			}
		}

		// Token: 0x1700011C RID: 284
		// (get) Token: 0x060004FB RID: 1275 RVA: 0x000122A0 File Offset: 0x000104A0
		public XmlNameTable NameTable
		{
			get
			{
				return this.implementation.nameTable;
			}
		}

		// Token: 0x060004FC RID: 1276 RVA: 0x00003FFD File Offset: 0x000021FD
		public virtual XmlAttribute CreateAttribute(string prefix, string localName, string namespaceURI)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x060004FD RID: 1277 RVA: 0x00003FFD File Offset: 0x000021FD
		protected internal virtual XmlAttribute CreateDefaultAttribute(string prefix, string localName, string namespaceURI)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x060004FE RID: 1278 RVA: 0x000122B8 File Offset: 0x000104B8
		public virtual XmlElement CreateElement(string prefix, string localName, string namespaceURI)
		{
			/*
An exception occurred when decompiling this method (060004FE)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Xml.XmlElement System.Xml.XmlDocument::CreateElement(System.String,System.String,System.String)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0000:
	stloc:DomNameTable(var_0_06, ldfld:DomNameTable(XmlDocument::domNameTable, ldloc:XmlDocument(this)))
	brtrue(IL_0000, ldfld:bool(XmlDocument::isLoading, ldloc:XmlDocument(this)))
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

		// Token: 0x1700011D RID: 285
		// (get) Token: 0x060004FF RID: 1279 RVA: 0x000122D4 File Offset: 0x000104D4
		public override bool IsReadOnly
		{
			get
			{
			}
		}

		// Token: 0x1700011E RID: 286
		// (get) Token: 0x06000500 RID: 1280 RVA: 0x000122E4 File Offset: 0x000104E4
		// (set) Token: 0x06000501 RID: 1281 RVA: 0x000122F8 File Offset: 0x000104F8
		internal XmlNamedNodeMap Entities
		{
			get
			{
				/*
An exception occurred when decompiling this method (06000500)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Xml.XmlNamedNodeMap System.Xml.XmlDocument::get_Entities()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0000:
	brtrue(IL_0000, ldfld:XmlNamedNodeMap[exp:bool](XmlDocument::entities, ldloc:XmlDocument(this)))
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
			set
			{
				this.entities = value;
			}
		}

		// Token: 0x1700011F RID: 287
		// (get) Token: 0x06000502 RID: 1282 RVA: 0x0001230C File Offset: 0x0001050C
		// (set) Token: 0x06000503 RID: 1283 RVA: 0x00012320 File Offset: 0x00010520
		internal bool IsLoading
		{
			get
			{
				return this.isLoading;
			}
			set
			{
			}
		}

		// Token: 0x17000120 RID: 288
		// (get) Token: 0x06000504 RID: 1284 RVA: 0x00012330 File Offset: 0x00010530
		internal bool ActualLoadingStatus
		{
			get
			{
				return this.actualLoadingStatus;
			}
		}

		// Token: 0x06000505 RID: 1285 RVA: 0x00012344 File Offset: 0x00010544
		private XmlTextReader SetupReader(XmlTextReader tr)
		{
			tr.impl.XmlValidatingReaderCompatibilityMode = true;
			tr.impl.EntityHandling = EntityHandling.ExpandCharEntities;
			if (this.bSetResolver)
			{
				XmlResolver xmlResolver = this.resolver;
				tr.impl.XmlResolver = xmlResolver;
			}
			return tr;
		}

		// Token: 0x06000506 RID: 1286 RVA: 0x00012388 File Offset: 0x00010588
		public virtual void Load(XmlReader reader)
		{
			this.isLoading = true;
			this.actualLoadingStatus = true;
			this.reportValidity = true;
			bool flag = this.preserveWhitespace;
			this.reportValidity = true;
		}

		// Token: 0x06000507 RID: 1287 RVA: 0x000123DC File Offset: 0x000105DC
		public virtual void LoadXml(string xml)
		{
			XmlNameTable nameTable = this.implementation.nameTable;
			if (!false)
			{
				return;
			}
			throw new OutOfMemoryException();
		}

		// Token: 0x17000121 RID: 289
		// (set) Token: 0x06000508 RID: 1288 RVA: 0x00012410 File Offset: 0x00010610
		public override string InnerText
		{
			set
			{
				/*
An exception occurred when decompiling this method (06000508)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Void System.Xml.XmlDocument::set_InnerText(System.String)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:string(var_0_0A, call:string(Res::GetString, ldstr:string("The 'InnerText' of a 'Document' node is read-only and cannot be set.")))
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

		// Token: 0x17000122 RID: 290
		// (set) Token: 0x06000509 RID: 1289 RVA: 0x00012428 File Offset: 0x00010628
		public override string InnerXml
		{
			set
			{
			}
		}

		// Token: 0x0600050A RID: 1290 RVA: 0x00012438 File Offset: 0x00010638
		internal override XmlNodeChangedEventArgs GetEventArgs(XmlNode node, XmlNode oldParent, XmlNode newParent, string oldValue, string newValue, XmlNodeChangedAction action)
		{
			if (action != XmlNodeChangedAction.Insert || this.onNodeInsertingDelegate != null || this.onNodeInsertedDelegate != null || this.onNodeChangingDelegate != null || this.onNodeChangedDelegate != null || this.onNodeRemovingDelegate != null || this.onNodeRemovedDelegate != null)
			{
				return;
			}
		}

		// Token: 0x0600050B RID: 1291 RVA: 0x0001247C File Offset: 0x0001067C
		internal XmlNodeChangedEventArgs GetInsertEventArgsForLoad(XmlNode node, XmlNode newParent)
		{
			if (this.onNodeInsertingDelegate != null || this.onNodeInsertedDelegate != null)
			{
				return;
			}
		}

		// Token: 0x0600050C RID: 1292 RVA: 0x0001249C File Offset: 0x0001069C
		internal override void BeforeEvent(XmlNodeChangedEventArgs args)
		{
			if (args == null || args.action != XmlNodeChangedAction.Insert)
			{
				return;
			}
			if (this.onNodeInsertingDelegate == null)
			{
				return;
			}
			XmlNodeChangedEventHandler xmlNodeChangedEventHandler;
			IntPtr invoke_impl = xmlNodeChangedEventHandler.invoke_impl;
			IntPtr method_code = xmlNodeChangedEventHandler.method_code;
			IntPtr method = xmlNodeChangedEventHandler.method;
		}

		// Token: 0x0600050D RID: 1293 RVA: 0x000124E8 File Offset: 0x000106E8
		internal override void AfterEvent(XmlNodeChangedEventArgs args)
		{
			if (args == null || args.action != XmlNodeChangedAction.Insert)
			{
				return;
			}
			if (this.onNodeInsertedDelegate == null)
			{
				return;
			}
			XmlNodeChangedEventHandler xmlNodeChangedEventHandler;
			IntPtr invoke_impl = xmlNodeChangedEventHandler.invoke_impl;
			IntPtr method_code = xmlNodeChangedEventHandler.method_code;
			IntPtr method = xmlNodeChangedEventHandler.method;
		}

		// Token: 0x0600050E RID: 1294 RVA: 0x00012534 File Offset: 0x00010734
		internal XmlAttribute GetDefaultAttribute(XmlElement elem, string attrPrefix, string attrLocalname, string attrNamespaceURI)
		{
			SchemaInfo schemaInfo = this.schemaInfo;
			SchemaElementDecl schemaElementDecl = this.GetSchemaElementDecl(elem);
			if (schemaElementDecl != null && schemaElementDecl.attdefs != null)
			{
				SchemaType schemaType = schemaInfo.schemaType;
				SchemaType schemaType2 = schemaInfo.schemaType;
				XmlAttribute xmlAttribute;
				return xmlAttribute;
			}
			throw new InvalidCastException();
		}

		// Token: 0x0600050F RID: 1295 RVA: 0x00012578 File Offset: 0x00010778
		internal XmlEntity GetEntityNode(string name)
		{
			XmlNamedNodeMap xmlNamedNodeMap;
			if (this == null || xmlNamedNodeMap == null || xmlNamedNodeMap != null)
			{
			}
			throw new InvalidCastException();
		}

		// Token: 0x17000123 RID: 291
		// (get) Token: 0x06000510 RID: 1296 RVA: 0x00012594 File Offset: 0x00010794
		public override string BaseURI
		{
			get
			{
				return this.baseURI;
			}
		}

		// Token: 0x06000511 RID: 1297 RVA: 0x000125A8 File Offset: 0x000107A8
		internal void SetBaseURI(string inBaseURI)
		{
			this.baseURI = inBaseURI;
		}

		// Token: 0x06000512 RID: 1298 RVA: 0x000125BC File Offset: 0x000107BC
		internal override XmlNode AppendChildForLoad(XmlNode newChild, XmlDocument doc)
		{
			XmlNodeChangedEventArgs insertEventArgsForLoad = this.GetInsertEventArgsForLoad(newChild, this);
			if (insertEventArgsForLoad != null)
			{
			}
			XmlLinkedNode xmlLinkedNode = this.lastChild;
			if (xmlLinkedNode != null)
			{
				XmlLinkedNode next = xmlLinkedNode.next;
			}
			this.lastChild = newChild;
			if (insertEventArgsForLoad != null)
			{
			}
			return newChild;
		}

		// Token: 0x06000513 RID: 1299 RVA: 0x00012608 File Offset: 0x00010808
		// Note: this type is marked as 'beforefieldinit'.
		static XmlDocument()
		{
		}

		// Token: 0x04000297 RID: 663
		private XmlImplementation implementation;

		// Token: 0x04000298 RID: 664
		private DomNameTable domNameTable;

		// Token: 0x04000299 RID: 665
		private XmlLinkedNode lastChild;

		// Token: 0x0400029A RID: 666
		private XmlNamedNodeMap entities;

		// Token: 0x0400029B RID: 667
		private Hashtable htElementIdMap;

		// Token: 0x0400029C RID: 668
		private Hashtable htElementIDAttrDecl;

		// Token: 0x0400029D RID: 669
		private SchemaInfo schemaInfo;

		// Token: 0x0400029E RID: 670
		private XmlSchemaSet schemas;

		// Token: 0x0400029F RID: 671
		private bool reportValidity;

		// Token: 0x040002A0 RID: 672
		private bool actualLoadingStatus;

		// Token: 0x040002A1 RID: 673
		private XmlNodeChangedEventHandler onNodeInsertingDelegate;

		// Token: 0x040002A2 RID: 674
		private XmlNodeChangedEventHandler onNodeInsertedDelegate;

		// Token: 0x040002A3 RID: 675
		private XmlNodeChangedEventHandler onNodeRemovingDelegate;

		// Token: 0x040002A4 RID: 676
		private XmlNodeChangedEventHandler onNodeRemovedDelegate;

		// Token: 0x040002A5 RID: 677
		private XmlNodeChangedEventHandler onNodeChangingDelegate;

		// Token: 0x040002A6 RID: 678
		private XmlNodeChangedEventHandler onNodeChangedDelegate;

		// Token: 0x040002A7 RID: 679
		internal bool fEntRefNodesPresent;

		// Token: 0x040002A8 RID: 680
		internal bool fCDataNodesPresent;

		// Token: 0x040002A9 RID: 681
		private bool preserveWhitespace;

		// Token: 0x040002AA RID: 682
		private bool isLoading;

		// Token: 0x040002AB RID: 683
		internal string strDocumentName;

		// Token: 0x040002AC RID: 684
		internal string strDocumentFragmentName;

		// Token: 0x040002AD RID: 685
		internal string strCommentName;

		// Token: 0x040002AE RID: 686
		internal string strTextName;

		// Token: 0x040002AF RID: 687
		internal string strCDataSectionName;

		// Token: 0x040002B0 RID: 688
		internal string strEntityName;

		// Token: 0x040002B1 RID: 689
		internal string strID;

		// Token: 0x040002B2 RID: 690
		internal string strXmlns;

		// Token: 0x040002B3 RID: 691
		internal string strXml;

		// Token: 0x040002B4 RID: 692
		internal string strSpace;

		// Token: 0x040002B5 RID: 693
		internal string strLang;

		// Token: 0x040002B6 RID: 694
		internal string strEmpty;

		// Token: 0x040002B7 RID: 695
		internal string strNonSignificantWhitespaceName;

		// Token: 0x040002B8 RID: 696
		internal string strSignificantWhitespaceName;

		// Token: 0x040002B9 RID: 697
		internal string strReservedXmlns;

		// Token: 0x040002BA RID: 698
		internal string strReservedXml;

		// Token: 0x040002BB RID: 699
		internal string baseURI;

		// Token: 0x040002BC RID: 700
		private XmlResolver resolver;

		// Token: 0x040002BD RID: 701
		internal bool bSetResolver;

		// Token: 0x040002BE RID: 702
		internal object objLock;

		// Token: 0x040002BF RID: 703
		internal static EmptyEnumerator EmptyEnumerator;

		// Token: 0x040002C0 RID: 704
		internal static IXmlSchemaInfo NotKnownSchemaInfo;

		// Token: 0x040002C1 RID: 705
		internal static IXmlSchemaInfo ValidSchemaInfo;

		// Token: 0x040002C2 RID: 706
		internal static IXmlSchemaInfo InvalidSchemaInfo;
	}
}
