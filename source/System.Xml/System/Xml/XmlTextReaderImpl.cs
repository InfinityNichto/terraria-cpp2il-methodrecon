using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;
using System.Xml.XmlConfiguration;
using Cpp2IlInjected;

namespace System.Xml
{
	// Token: 0x0200003D RID: 61
	internal class XmlTextReaderImpl : XmlReader, IXmlNamespaceResolver
	{
		// Token: 0x0600024E RID: 590 RVA: 0x000072A8 File Offset: 0x000054A8
		internal XmlTextReaderImpl(XmlNameTable nt)
		{
			int num = 1;
			XmlCharType instance = XmlCharType.Instance;
			this.xmlCharType = instance;
			this.curAttrIndex = num;
			int num2 = 2;
			int num3 = 1;
			this.dtdProcessing = (DtdProcessing)num2;
			int num4 = 9;
			this.supportNamespaces = num3 != 0;
			this.parsingStatesStackTop = num;
			this.fragmentType = (XmlNodeType)num4;
			this.nextEntityId = num3;
			if (num == 0)
			{
			}
			if (num == 0)
			{
			}
			base..ctor();
			int num5 = 1;
			this.outerReader = this;
			this.nameTable = nt;
			this.v1Compat = num5 != 0;
			bool flag = XmlReaderSettings.EnableLegacyXmlSettings();
		}

		// Token: 0x0600024F RID: 591 RVA: 0x00007370 File Offset: 0x00005570
		internal XmlTextReaderImpl(TextReader input, XmlNameTable nt)
		{
		}

		// Token: 0x06000250 RID: 592 RVA: 0x00007380 File Offset: 0x00005580
		internal XmlTextReaderImpl(string url, TextReader input, XmlNameTable nt)
		{
			if (url == null)
			{
			}
			Encoding encoding = this.ps.encoding;
			this.reportedEncoding = encoding;
		}

		// Token: 0x06000251 RID: 593 RVA: 0x000073A4 File Offset: 0x000055A4
		internal XmlTextReaderImpl(string xmlFragment, XmlNodeType fragType, XmlParserContext context)
		{
			if (context == null || context._nt == null)
			{
			}
			if (xmlFragment != null)
			{
				if (context != null)
				{
					string baseURI = context._baseURI;
					this.reportedBaseUri = baseURI;
					return;
				}
			}
			else
			{
				while (context != null)
				{
				}
			}
			Encoding unicode = Encoding.Unicode;
			long num = 0L;
			this.InitFragmentReader(fragType, context, num != 0L);
			Encoding encoding = this.ps.encoding;
			this.reportedEncoding = encoding;
		}

		// Token: 0x06000252 RID: 594 RVA: 0x000073FC File Offset: 0x000055FC
		internal XmlTextReaderImpl(string xmlFragment, XmlParserContext context)
		{
			if (context == null)
			{
				return;
			}
			if (context._nt != null)
			{
				return;
			}
			Encoding unicode = Encoding.Unicode;
			string text = "<?xml " + xmlFragment + "?>";
		}

		// Token: 0x06000253 RID: 595 RVA: 0x00007430 File Offset: 0x00005630
		private void FinishInitUriString()
		{
			XmlTextReaderImpl.LaterInitParam laterInitParam = this.laterInitParam;
			bool useAsync = laterInitParam.useAsync;
			XmlResolver inputUriResolver = laterInitParam.inputUriResolver;
			Uri inputbaseUri = laterInitParam.inputbaseUri;
			if (laterInitParam == null)
			{
			}
			if (useAsync)
			{
				if (inputUriResolver != null)
				{
					XmlParserContext inputContext = this.laterInitParam.inputContext;
					if (inputContext != null)
					{
						Encoding encoding = inputContext._encoding;
						return;
					}
					goto IL_0054;
				}
			}
			else
			{
				while (inputUriResolver != null)
				{
				}
			}
			XmlTextReaderImpl.LaterInitParam laterInitParam2 = this.laterInitParam;
			string inputUriStr = laterInitParam2.inputUriStr;
			IL_0054:
			Uri inputbaseUri2 = laterInitParam2.inputbaseUri;
			int stringLength = inputUriStr._stringLength;
			if (inputUriStr != null)
			{
			}
		}

		// Token: 0x06000254 RID: 596 RVA: 0x000074BC File Offset: 0x000056BC
		private void FinishInitStream()
		{
			XmlTextReaderImpl.LaterInitParam laterInitParam = this.laterInitParam;
			XmlParserContext inputContext = laterInitParam.inputContext;
			if (inputContext != null)
			{
				Encoding encoding = inputContext._encoding;
				return;
			}
			Uri inputbaseUri = laterInitParam.inputbaseUri;
			string text = this.reportedBaseUri;
			Stream inputStream = laterInitParam.inputStream;
			byte[] inputBytes = laterInitParam.inputBytes;
			int inputByteCount = laterInitParam.inputByteCount;
			Encoding encoding2 = this.ps.encoding;
			XmlTextReaderImpl.LaterInitParam laterInitParam2 = this.laterInitParam;
			this.reportedEncoding = encoding2;
			XmlParserContext inputContext2 = laterInitParam2.inputContext;
			if (inputContext2 != null)
			{
				bool hasDtdInfo = inputContext2.HasDtdInfo;
			}
		}

		// Token: 0x06000255 RID: 597 RVA: 0x0000753C File Offset: 0x0000573C
		private void FinishInitTextReader()
		{
			XmlTextReaderImpl.LaterInitParam laterInitParam = this.laterInitParam;
			string text = this.reportedBaseUri;
			TextReader inputTextReader = laterInitParam.inputTextReader;
			Encoding encoding = this.ps.encoding;
			XmlTextReaderImpl.LaterInitParam laterInitParam2 = this.laterInitParam;
			this.reportedEncoding = encoding;
			XmlParserContext inputContext = laterInitParam2.inputContext;
			if (inputContext != null)
			{
				bool hasDtdInfo = inputContext.HasDtdInfo;
			}
		}

		// Token: 0x1700007E RID: 126
		// (get) Token: 0x06000256 RID: 598 RVA: 0x00007590 File Offset: 0x00005790
		public override XmlReaderSettings Settings
		{
			get
			{
				/*
An exception occurred when decompiling this method (06000256)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Xml.XmlReaderSettings System.Xml.XmlTextReaderImpl::get_Settings()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_000F:
	stloc:XmlNodeType(var_1_15, ldfld:XmlNodeType(XmlTextReaderImpl::fragmentType, ldloc:XmlTextReaderImpl(this)))
	stloc:bool(var_2_1C, ldfld:bool(XmlTextReaderImpl::checkCharacters, ldloc:XmlTextReaderImpl(this)))
	stloc:int32(var_3_23, ldfld:int32(XmlTextReaderImpl::lineNumberOffset, ldloc:XmlTextReaderImpl(this)))
	stloc:int32(var_4_2A, ldfld:int32(XmlTextReaderImpl::linePositionOffset, ldloc:XmlTextReaderImpl(this)))
	stloc:WhitespaceHandling(var_5_32, ldfld:WhitespaceHandling(XmlTextReaderImpl::whitespaceHandling, ldloc:XmlTextReaderImpl(this)))
	stloc:bool(var_6_3A, ldfld:bool(XmlTextReaderImpl::ignorePIs, ldloc:XmlTextReaderImpl(this)))
	stloc:bool(var_7_42, ldfld:bool(XmlTextReaderImpl::ignoreComments, ldloc:XmlTextReaderImpl(this)))
	stloc:DtdProcessing(var_8_4A, ldfld:DtdProcessing(XmlTextReaderImpl::dtdProcessing, ldloc:XmlTextReaderImpl(this)))
	stloc:int64(var_9_52, ldfld:int64(XmlTextReaderImpl::maxCharactersInDocument, ldloc:XmlTextReaderImpl(this)))
	stloc:int64(var_10_5A, ldfld:int64(XmlTextReaderImpl::maxCharactersFromEntities, ldloc:XmlTextReaderImpl(this)))
	stloc:bool(var_12_64, call:bool(XmlReaderSettings::EnableLegacyXmlSettings))
	stloc:XmlResolver(var_13_6C, ldfld:XmlResolver(XmlTextReaderImpl::xmlResolver, ldloc:XmlTextReaderImpl(this)))
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

		// Token: 0x1700007F RID: 127
		// (get) Token: 0x06000257 RID: 599 RVA: 0x0000760C File Offset: 0x0000580C
		public override XmlNodeType NodeType
		{
			get
			{
				return this.curNode.type;
			}
		}

		// Token: 0x17000080 RID: 128
		// (get) Token: 0x06000258 RID: 600 RVA: 0x00007624 File Offset: 0x00005824
		public override string Name
		{
			get
			{
				XmlTextReaderImpl.NodeData nodeData = this.curNode;
				XmlNameTable xmlNameTable = this.nameTable;
				return nodeData.GetNameWPrefix(xmlNameTable);
			}
		}

		// Token: 0x17000081 RID: 129
		// (get) Token: 0x06000259 RID: 601 RVA: 0x00007648 File Offset: 0x00005848
		public override string LocalName
		{
			get
			{
				return this.curNode.localName;
			}
		}

		// Token: 0x17000082 RID: 130
		// (get) Token: 0x0600025A RID: 602 RVA: 0x00007660 File Offset: 0x00005860
		public override string NamespaceURI
		{
			get
			{
				return this.curNode.ns;
			}
		}

		// Token: 0x17000083 RID: 131
		// (get) Token: 0x0600025B RID: 603 RVA: 0x00007678 File Offset: 0x00005878
		public override string Prefix
		{
			get
			{
				return this.curNode.prefix;
			}
		}

		// Token: 0x17000084 RID: 132
		// (get) Token: 0x0600025C RID: 604 RVA: 0x00007690 File Offset: 0x00005890
		public override string Value
		{
			get
			{
				XmlTextReaderImpl.ParsingFunction parsingFunction = this.parsingFunction;
				this.FinishPartialValue();
				XmlTextReaderImpl.ParsingFunction parsingFunction2 = this.nextParsingFunction;
				this.parsingFunction = parsingFunction2;
				this.FinishOtherValueIterator();
				return this.curNode.StringValue;
			}
		}

		// Token: 0x17000085 RID: 133
		// (get) Token: 0x0600025D RID: 605 RVA: 0x000076CC File Offset: 0x000058CC
		public override string BaseURI
		{
			get
			{
				return this.reportedBaseUri;
			}
		}

		// Token: 0x17000086 RID: 134
		// (get) Token: 0x0600025E RID: 606 RVA: 0x000076E0 File Offset: 0x000058E0
		public override bool IsEmptyElement
		{
			get
			{
				return this.curNode.IsEmptyElement;
			}
		}

		// Token: 0x17000087 RID: 135
		// (get) Token: 0x0600025F RID: 607 RVA: 0x000076F8 File Offset: 0x000058F8
		public override bool IsDefault
		{
			get
			{
				return this.curNode.IsDefaultAttribute;
			}
		}

		// Token: 0x17000088 RID: 136
		// (get) Token: 0x06000260 RID: 608 RVA: 0x00007710 File Offset: 0x00005910
		public override ReadState ReadState
		{
			get
			{
				return this.readState;
			}
		}

		// Token: 0x17000089 RID: 137
		// (get) Token: 0x06000261 RID: 609 RVA: 0x00007724 File Offset: 0x00005924
		public override XmlNameTable NameTable
		{
			get
			{
				return this.nameTable;
			}
		}

		// Token: 0x1700008A RID: 138
		// (get) Token: 0x06000262 RID: 610 RVA: 0x00007738 File Offset: 0x00005938
		public override bool CanResolveEntity
		{
			get
			{
				return true;
			}
		}

		// Token: 0x06000263 RID: 611 RVA: 0x00007748 File Offset: 0x00005948
		public override bool MoveToAttribute(string name)
		{
			/*
An exception occurred when decompiling this method (06000263)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean System.Xml.XmlTextReaderImpl::MoveToAttribute(System.String)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:int32(var_0_02, ldc.i4:int32(58))
	stloc:int32(var_1_0A, call:int32(string::IndexOf, ldloc:string(name), ldloc:int32[exp:char](var_0_02)))
	stloc:int32(var_2_12, call:int32(XmlTextReaderImpl::GetIndexOfAttributeWithPrefix, ldloc:XmlTextReaderImpl(this), ldloc:string(name)))
	stloc:int32(var_3_1A, call:int32(XmlTextReaderImpl::GetIndexOfAttributeWithoutPrefix, ldloc:XmlTextReaderImpl(this), ldloc:string(name)))
	stloc:int32(var_4_21, ldfld:int32(XmlTextReaderImpl::attrCount, ldloc:XmlTextReaderImpl(this)))
	stloc:ParsingFunction(var_5_29, ldfld:ParsingFunction(XmlTextReaderImpl::parsingFunction, ldloc:XmlTextReaderImpl(this)))
	call:void(XmlTextReaderImpl::FinishAttributeValueIterator, ldloc:XmlTextReaderImpl(this))
	stloc:int32(var_6_37, ldfld:int32(XmlTextReaderImpl::index, ldloc:XmlTextReaderImpl(this)))
	stloc:class System.Xml.XmlTextReaderImpl/NodeData[](var_7_3F, ldfld:class System.Xml.XmlTextReaderImpl/NodeData[](XmlTextReaderImpl::nodes, ldloc:XmlTextReaderImpl(this)))
	stfld:int32(XmlTextReaderImpl::curAttrIndex, ldloc:XmlTextReaderImpl(this), ldloc:int32(var_6_37))
	stloc:string(var_9_53, ldfld:string(NodeData::prefix, ldloc:class System.Xml.XmlTextReaderImpl/NodeData[][exp:NodeData](var_7_3F)))
	stfld:NodeData(XmlTextReaderImpl::curNode, ldloc:XmlTextReaderImpl(this), ldloc:string[exp:NodeData](var_9_53))
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

		// Token: 0x06000264 RID: 612 RVA: 0x000077B4 File Offset: 0x000059B4
		public override bool MoveToFirstAttribute()
		{
			if (this.attrCount != 0)
			{
				XmlTextReaderImpl.ParsingFunction parsingFunction = this.parsingFunction;
				this.FinishAttributeValueIterator();
				int num = this.index;
				XmlTextReaderImpl.NodeData[] array = this.nodes;
				this.curNode = num;
				return;
			}
		}

		// Token: 0x06000265 RID: 613 RVA: 0x000077F0 File Offset: 0x000059F0
		public override bool MoveToNextAttribute()
		{
			/*
An exception occurred when decompiling this method (06000265)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean System.Xml.XmlTextReaderImpl::MoveToNextAttribute()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:int32(var_0_06, ldfld:int32(XmlTextReaderImpl::curAttrIndex, ldloc:XmlTextReaderImpl(this)))
	stloc:int32(var_1_0D, ldfld:int32(XmlTextReaderImpl::attrHashtable, ldloc:XmlTextReaderImpl(this)))
	stloc:ParsingFunction(var_2_14, ldfld:ParsingFunction(XmlTextReaderImpl::parsingFunction, ldloc:XmlTextReaderImpl(this)))
	call:void(XmlTextReaderImpl::FinishAttributeValueIterator, ldloc:XmlTextReaderImpl(this))
	stloc:int32(var_3_21, ldfld:int32(XmlTextReaderImpl::curAttrIndex, ldloc:XmlTextReaderImpl(this)))
	stloc:int32(var_4_28, ldfld:int32(XmlTextReaderImpl::index, ldloc:XmlTextReaderImpl(this)))
	stloc:class System.Xml.XmlTextReaderImpl/NodeData[](var_5_30, ldfld:class System.Xml.XmlTextReaderImpl/NodeData[](XmlTextReaderImpl::nodes, ldloc:XmlTextReaderImpl(this)))
	stfld:int32(XmlTextReaderImpl::curAttrIndex, ldloc:XmlTextReaderImpl(this), ldloc:int32(var_3_21))
	stfld:NodeData(XmlTextReaderImpl::curNode, ldloc:XmlTextReaderImpl(this), ldloc:int32[exp:NodeData](var_3_21))
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

		// Token: 0x06000266 RID: 614 RVA: 0x00007844 File Offset: 0x00005A44
		public override bool MoveToElement()
		{
			/*
An exception occurred when decompiling this method (06000266)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean System.Xml.XmlTextReaderImpl::MoveToElement()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:int32(var_0_06, ldfld:int32(XmlTextReaderImpl::attrCount, ldloc:XmlTextReaderImpl(this)))
	stloc:ParsingFunction(var_1_0D, ldfld:ParsingFunction(XmlTextReaderImpl::parsingFunction, ldloc:XmlTextReaderImpl(this)))
	call:void(XmlTextReaderImpl::FinishAttributeValueIterator, ldloc:XmlTextReaderImpl(this))
	stloc:XmlNodeType(var_2_1F, ldfld:XmlNodeType(NodeData::type, ldfld:NodeData(XmlTextReaderImpl::curNode, ldloc:XmlTextReaderImpl(this))))
	stloc:class System.Xml.XmlTextReaderImpl/NodeData[](var_3_26, ldfld:class System.Xml.XmlTextReaderImpl/NodeData[](XmlTextReaderImpl::nodes, ldloc:XmlTextReaderImpl(this)))
	stloc:string(var_5_30, ldfld:string(NodeData::prefix, ldloc:class System.Xml.XmlTextReaderImpl/NodeData[][exp:NodeData](var_3_26)))
	stfld:NodeData(XmlTextReaderImpl::curNode, ldloc:XmlTextReaderImpl(this), ldloc:string[exp:NodeData](var_5_30))
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

		// Token: 0x06000267 RID: 615 RVA: 0x00007890 File Offset: 0x00005A90
		private void FinishInit()
		{
			if (this.laterInitParam.initType == XmlTextReaderImpl.InitInputType.UriString)
			{
				this.FinishInitUriString();
				return;
			}
		}

		// Token: 0x06000268 RID: 616 RVA: 0x000078C0 File Offset: 0x00005AC0
		public override bool Read()
		{
			if (this.laterInitParam != null)
			{
				this.FinishInit();
			}
			XmlTextReaderImpl.ParsingFunction parsingFunction = this.parsingFunction;
			this.OpenUrl();
			XmlTextReaderImpl.ParsingFunction parsingFunction2 = this.nextParsingFunction;
			int num = 1;
			long num2 = 0L;
			this.readState = (ReadState)num;
			this.parsingFunction = parsingFunction2;
			bool flag = this.ParseXmlDeclaration(num2 != 0L);
			Encoding encoding = this.ps.encoding;
			this.reportedEncoding = encoding;
			return flag;
		}

		// Token: 0x06000269 RID: 617 RVA: 0x00007B64 File Offset: 0x00005D64
		public override void Close()
		{
			bool flag = this.closeInput;
			this.Close(flag);
		}

		// Token: 0x0600026A RID: 618 RVA: 0x00007B80 File Offset: 0x00005D80
		public override string LookupNamespace(string prefix)
		{
			if (this.supportNamespaces)
			{
				XmlNamespaceManager xmlNamespaceManager = this.namespaceManager;
				return;
			}
		}

		// Token: 0x0600026B RID: 619 RVA: 0x00007BA0 File Offset: 0x00005DA0
		public override bool ReadAttributeValue()
		{
			XmlTextReaderImpl.ParsingFunction parsingFunction = this.parsingFunction;
			int entityId = this.ps.entityId;
			int num = this.attributeValueBaseEntityId;
			XmlTextReaderImpl.NodeData nextAttrValueChunk = this.curNode.nextAttrValueChunk;
			if (nextAttrValueChunk != null)
			{
				XmlTextReaderImpl.NodeData[] array = this.nodes;
				this.curNode = nextAttrValueChunk;
				int num2 = this.index;
				int num3 = this.attrCount;
				if (nextAttrValueChunk == null)
				{
					throw new ArrayTypeMismatchException();
				}
			}
			bool flag;
			return flag;
		}

		// Token: 0x0600026C RID: 620 RVA: 0x00007C1C File Offset: 0x00005E1C
		public override void ResolveEntity()
		{
			XmlTextReaderImpl.NodeData nodeData = this.curNode;
			XmlNodeType type = nodeData.type;
			XmlTextReaderImpl.ParsingFunction parsingFunction = this.parsingFunction;
			string localName = nodeData.localName;
			int linePos = nodeData.LinePos;
			int num = 1;
			int num2 = 1;
			XmlTextReaderImpl.EntityType entityType = this.HandleGeneralEntityReference(localName, num != 0, num2 != 0, linePos);
			int charPos = this.ps.charPos;
			Encoding encoding = this.ps.encoding;
			int num3 = 1;
			this.emptyEntityInAttributeResolved = num3 != 0;
		}

		// Token: 0x1700008B RID: 139
		// (set) Token: 0x0600026D RID: 621 RVA: 0x00007D30 File Offset: 0x00005F30
		internal XmlReader OuterReader
		{
			set
			{
				this.outerReader = value;
			}
		}

		// Token: 0x0600026E RID: 622 RVA: 0x00003FFD File Offset: 0x000021FD
		string IXmlNamespaceResolver.LookupNamespace(string prefix)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x0600026F RID: 623 RVA: 0x00007D44 File Offset: 0x00005F44
		string IXmlNamespaceResolver.LookupPrefix(string namespaceName)
		{
			/*
An exception occurred when decompiling this method (0600026F)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.String System.Xml.XmlTextReaderImpl::System.Xml.IXmlNamespaceResolver.LookupPrefix(System.String)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:XmlNamespaceManager(var_0_06, ldfld:XmlNamespaceManager(XmlTextReaderImpl::namespaceManager, ldloc:XmlTextReaderImpl(this)))
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

		// Token: 0x06000270 RID: 624 RVA: 0x00007D58 File Offset: 0x00005F58
		internal string LookupPrefix(string namespaceName)
		{
			/*
An exception occurred when decompiling this method (06000270)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.String System.Xml.XmlTextReaderImpl::LookupPrefix(System.String)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:XmlNamespaceManager(var_0_06, ldfld:XmlNamespaceManager(XmlTextReaderImpl::namespaceManager, ldloc:XmlTextReaderImpl(this)))
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

		// Token: 0x1700008C RID: 140
		// (set) Token: 0x06000271 RID: 625 RVA: 0x00007D6C File Offset: 0x00005F6C
		internal bool Namespaces
		{
			set
			{
				/*
An exception occurred when decompiling this method (06000271)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Void System.Xml.XmlTextReaderImpl::set_Namespaces(System.Boolean)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0047:
	stloc:string(var_5_51, call:string(Res::GetString, ldstr:string("Operation is not valid due to the current state of the object.")))
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
		}

		// Token: 0x1700008D RID: 141
		// (set) Token: 0x06000272 RID: 626 RVA: 0x00007DCC File Offset: 0x00005FCC
		internal EntityHandling EntityHandling
		{
			set
			{
				this.entityHandling = value;
			}
		}

		// Token: 0x1700008E RID: 142
		// (set) Token: 0x06000273 RID: 627 RVA: 0x00007DE0 File Offset: 0x00005FE0
		internal XmlResolver XmlResolver
		{
			set
			{
				int num = this.parsingStatesStackTop;
				int num2 = 1;
				this.xmlResolver = value;
				this.xmlResolverIsSet = num2 != 0;
				XmlTextReaderImpl.ParsingState[] array = this.parsingStatesStack;
			}
		}

		// Token: 0x1700008F RID: 143
		// (get) Token: 0x06000274 RID: 628 RVA: 0x00007E10 File Offset: 0x00006010
		internal XmlNameTable DtdParserProxy_NameTable
		{
			get
			{
				return this.nameTable;
			}
		}

		// Token: 0x17000090 RID: 144
		// (get) Token: 0x06000275 RID: 629 RVA: 0x00007E24 File Offset: 0x00006024
		internal IXmlNamespaceResolver DtdParserProxy_NamespaceResolver
		{
			get
			{
				/*
An exception occurred when decompiling this method (06000275)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Xml.IXmlNamespaceResolver System.Xml.XmlTextReaderImpl::get_DtdParserProxy_NamespaceResolver()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:XmlNamespaceManager(var_0_06, ldfld:XmlNamespaceManager(XmlTextReaderImpl::namespaceManager, ldloc:XmlTextReaderImpl(this)))
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

		// Token: 0x17000091 RID: 145
		// (get) Token: 0x06000276 RID: 630 RVA: 0x00007E38 File Offset: 0x00006038
		internal bool DtdParserProxy_DtdValidation
		{
			get
			{
				/*
An exception occurred when decompiling this method (06000276)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean System.Xml.XmlTextReaderImpl::get_DtdParserProxy_DtdValidation()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:IValidationEventHandling(var_0_06, ldfld:IValidationEventHandling(XmlTextReaderImpl::validationEventHandling, ldloc:XmlTextReaderImpl(this)))
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

		// Token: 0x17000092 RID: 146
		// (get) Token: 0x06000277 RID: 631 RVA: 0x00007E4C File Offset: 0x0000604C
		internal bool DtdParserProxy_Normalization
		{
			get
			{
				return this.normalize;
			}
		}

		// Token: 0x17000093 RID: 147
		// (get) Token: 0x06000278 RID: 632 RVA: 0x00007E60 File Offset: 0x00006060
		internal bool DtdParserProxy_Namespaces
		{
			get
			{
				return this.supportNamespaces;
			}
		}

		// Token: 0x17000094 RID: 148
		// (get) Token: 0x06000279 RID: 633 RVA: 0x00007E74 File Offset: 0x00006074
		internal bool DtdParserProxy_V1CompatibilityMode
		{
			get
			{
				return this.v1Compat;
			}
		}

		// Token: 0x17000095 RID: 149
		// (get) Token: 0x0600027A RID: 634 RVA: 0x00007E88 File Offset: 0x00006088
		internal Uri DtdParserProxy_BaseUri
		{
			get
			{
				int stringLength = this.ps.baseUriStr._stringLength;
				Uri baseUri = this.ps.baseUri;
				XmlResolver xmlResolver = this.xmlResolver;
				if (xmlResolver != null)
				{
					string baseUriStr = this.ps.baseUriStr;
					this.ps.baseUri = xmlResolver;
				}
				return this.ps.baseUri;
			}
		}

		// Token: 0x17000096 RID: 150
		// (get) Token: 0x0600027B RID: 635 RVA: 0x00007EE0 File Offset: 0x000060E0
		internal bool DtdParserProxy_IsEof
		{
			get
			{
				return this.ps.isEof;
			}
		}

		// Token: 0x17000097 RID: 151
		// (get) Token: 0x0600027C RID: 636 RVA: 0x00007EF8 File Offset: 0x000060F8
		internal char[] DtdParserProxy_ParsingBuffer
		{
			get
			{
				/*
An exception occurred when decompiling this method (0600027C)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Char[] System.Xml.XmlTextReaderImpl::get_DtdParserProxy_ParsingBuffer()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:ParsingState(var_0_06, ldfld:ParsingState(XmlTextReaderImpl::ps, ldloc:XmlTextReaderImpl(this)))
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

		// Token: 0x17000098 RID: 152
		// (get) Token: 0x0600027D RID: 637 RVA: 0x00007F0C File Offset: 0x0000610C
		internal int DtdParserProxy_ParsingBufferLength
		{
			get
			{
				return this.ps.charsUsed;
			}
		}

		// Token: 0x17000099 RID: 153
		// (get) Token: 0x0600027E RID: 638 RVA: 0x00007F24 File Offset: 0x00006124
		// (set) Token: 0x0600027F RID: 639 RVA: 0x00007F3C File Offset: 0x0000613C
		internal int DtdParserProxy_CurrentPosition
		{
			get
			{
				return this.ps.charPos;
			}
			set
			{
				this.ps.charPos = value;
			}
		}

		// Token: 0x1700009A RID: 154
		// (get) Token: 0x06000280 RID: 640 RVA: 0x00007F58 File Offset: 0x00006158
		internal int DtdParserProxy_EntityStackLength
		{
			get
			{
				/*
An exception occurred when decompiling this method (06000280)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Int32 System.Xml.XmlTextReaderImpl::get_DtdParserProxy_EntityStackLength()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:int32(var_0_06, ldfld:int32(XmlTextReaderImpl::parsingStatesStackTop, ldloc:XmlTextReaderImpl(this)))
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

		// Token: 0x1700009B RID: 155
		// (get) Token: 0x06000281 RID: 641 RVA: 0x00007F6C File Offset: 0x0000616C
		internal bool DtdParserProxy_IsEntityEolNormalized
		{
			get
			{
				return this.ps.eolNormalized;
			}
		}

		// Token: 0x1700009C RID: 156
		// (get) Token: 0x06000282 RID: 642 RVA: 0x00007F84 File Offset: 0x00006184
		internal IValidationEventHandling DtdParserProxy_ValidationEventHandling
		{
			get
			{
				return this.validationEventHandling;
			}
		}

		// Token: 0x06000283 RID: 643 RVA: 0x00007F98 File Offset: 0x00006198
		internal void DtdParserProxy_OnNewLine(int pos)
		{
			int lineNo = this.ps.lineNo;
			this.ps.lineNo = lineNo;
		}

		// Token: 0x1700009D RID: 157
		// (get) Token: 0x06000284 RID: 644 RVA: 0x00007FC0 File Offset: 0x000061C0
		internal int DtdParserProxy_LineNo
		{
			get
			{
				return this.ps.lineNo;
			}
		}

		// Token: 0x1700009E RID: 158
		// (get) Token: 0x06000285 RID: 645 RVA: 0x00007FD8 File Offset: 0x000061D8
		internal int DtdParserProxy_LineStartPosition
		{
			get
			{
				return this.ps.lineStartPos;
			}
		}

		// Token: 0x06000286 RID: 646 RVA: 0x00007FF0 File Offset: 0x000061F0
		internal int DtdParserProxy_ReadData()
		{
			return this.ReadData();
		}

		// Token: 0x06000287 RID: 647 RVA: 0x00008004 File Offset: 0x00006204
		internal int DtdParserProxy_ParseNumericCharRef(StringBuilder internalSubsetBuilder)
		{
			int num;
			return num;
		}

		// Token: 0x06000288 RID: 648 RVA: 0x00008014 File Offset: 0x00006214
		internal int DtdParserProxy_ParseNamedCharRef(bool expand, StringBuilder internalSubsetBuilder)
		{
			return this.ParseNamedCharRef(expand, internalSubsetBuilder);
		}

		// Token: 0x06000289 RID: 649 RVA: 0x0000802C File Offset: 0x0000622C
		internal void DtdParserProxy_ParsePI(StringBuilder sb)
		{
			if (sb != null)
			{
				bool flag = this.ParsePI(sb);
				return;
			}
			XmlTextReaderImpl.ParsingMode parsingMode = this.parsingMode;
			this.parsingMode = XmlTextReaderImpl.ParsingMode.SkipNode;
			bool flag2 = this.ParsePI(sb);
			this.parsingMode = parsingMode;
		}

		// Token: 0x0600028A RID: 650 RVA: 0x00008064 File Offset: 0x00006264
		internal void DtdParserProxy_ParseComment(StringBuilder sb)
		{
			int num2;
			if (sb == null)
			{
				XmlTextReaderImpl.ParsingMode parsingMode = this.parsingMode;
				int num = 1;
				this.parsingMode = (XmlTextReaderImpl.ParsingMode)num;
				num2 = 8;
				this.parsingMode = parsingMode;
				return;
			}
			int num3 = this.index;
			int num4 = this.attrCount;
			XmlTextReaderImpl.NodeData[] array = this.nodes;
			XmlTextReaderImpl.NodeData nodeData = this.curNode;
			if (this != null)
			{
				return;
			}
			XmlTextReaderImpl.NodeData nodeData2 = this.AllocNode(num2, num3);
			this.curNode = nodeData2;
			XmlTextReaderImpl.NodeData nodeData3 = this.curNode;
			this.curNode = nodeData;
		}

		// Token: 0x1700009F RID: 159
		// (get) Token: 0x0600028B RID: 651 RVA: 0x00008100 File Offset: 0x00006300
		private bool IsResolverNull
		{
			get
			{
				if (this.xmlResolver != null)
				{
					bool prohibitDefaultUrlResolver = XmlReaderSection.ProhibitDefaultUrlResolver;
					bool flag = this.xmlResolverIsSet;
					return prohibitDefaultUrlResolver;
				}
				return true;
			}
		}

		// Token: 0x0600028C RID: 652 RVA: 0x0000812C File Offset: 0x0000632C
		private XmlResolver GetTempResolver()
		{
			/*
An exception occurred when decompiling this method (0600028C)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Xml.XmlResolver System.Xml.XmlTextReaderImpl::GetTempResolver()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0000:
	brtrue(IL_0000, ldfld:XmlResolver[exp:bool](XmlTextReaderImpl::xmlResolver, ldloc:XmlTextReaderImpl(this)))
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

		// Token: 0x0600028D RID: 653 RVA: 0x00008140 File Offset: 0x00006340
		internal bool DtdParserProxy_PushEntity(IDtdEntityInfo entity, [Out] int entityId)
		{
			/*
An exception occurred when decompiling this method (0600028D)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean System.Xml.XmlTextReaderImpl::DtdParserProxy_PushEntity(System.Xml.IDtdEntityInfo,System.Int32)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0035:
	stfld:int32(int32::m_value, ldloc:int32[exp:int32&](entityId), ldloc:int32(var_3))
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

		// Token: 0x0600028E RID: 654 RVA: 0x0000818C File Offset: 0x0000638C
		internal bool DtdParserProxy_PopEntity([Out] IDtdEntityInfo oldEntity, [Out] int newEntityId)
		{
			int num = this.parsingStatesStackTop;
			IDtdEntityInfo entity = this.ps.entity;
			this.PopEntity();
			int entityId = this.ps.entityId;
			return true;
		}

		// Token: 0x0600028F RID: 655 RVA: 0x000081C8 File Offset: 0x000063C8
		internal bool DtdParserProxy_PushExternalSubset(string systemId, string publicId)
		{
			if (this.xmlResolver == null)
			{
				return;
			}
			bool prohibitDefaultUrlResolver = XmlReaderSection.ProhibitDefaultUrlResolver;
			if (this.xmlResolverIsSet)
			{
				Uri baseUri = this.ps.baseUri;
				bool flag = string.IsNullOrEmpty(this.ps.baseUriStr);
				XmlResolver xmlResolver = this.xmlResolver;
				string baseUriStr = this.ps.baseUriStr;
				this.ps.baseUri = xmlResolver;
				Uri baseUri2 = this.ps.baseUri;
				bool flag2 = this.v1Compat;
				int charPos = this.ps.charPos;
				if (flag2)
				{
				}
				bool flag3 = this.ParseXmlDeclaration(true);
				this.ps.charPos = charPos;
				return flag3;
			}
		}

		// Token: 0x06000290 RID: 656 RVA: 0x00008274 File Offset: 0x00006474
		internal void DtdParserProxy_PushInternalDtd(string baseUri, string internalDtd)
		{
			this.PushParsingState();
			Encoding unicode = Encoding.Unicode;
			this.InitStringInput(baseUri, unicode, internalDtd);
		}

		// Token: 0x06000291 RID: 657 RVA: 0x00008298 File Offset: 0x00006498
		internal void DtdParserProxy_Throw(Exception e)
		{
			/*
An exception occurred when decompiling this method (06000291)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Void System.Xml.XmlTextReaderImpl::DtdParserProxy_Throw(System.Exception)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	call:void(XmlTextReaderImpl::Throw, ldloc:XmlTextReaderImpl(this), ldloc:Exception(e))
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

		// Token: 0x06000292 RID: 658 RVA: 0x000082AC File Offset: 0x000064AC
		internal void DtdParserProxy_OnSystemId(string systemId, LineInfo keywordLineInfo, LineInfo systemLiteralLineInfo)
		{
			int num = this.index;
			XmlTextReaderImpl.NodeData nodeData;
			nodeData.SetValue(systemId);
			nodeData.lineInfo = keywordLineInfo;
			nodeData.lineInfo2 = systemLiteralLineInfo;
		}

		// Token: 0x06000293 RID: 659 RVA: 0x000082D8 File Offset: 0x000064D8
		internal void DtdParserProxy_OnPublicId(string publicId, LineInfo keywordLineInfo, LineInfo publicLiteralLineInfo)
		{
			int num = this.index;
			XmlTextReaderImpl.NodeData nodeData;
			nodeData.SetValue(publicId);
			nodeData.lineInfo = keywordLineInfo;
			nodeData.lineInfo2 = publicLiteralLineInfo;
		}

		// Token: 0x06000294 RID: 660 RVA: 0x00008304 File Offset: 0x00006504
		private void Throw(int pos, string res, string arg)
		{
			/*
An exception occurred when decompiling this method (06000294)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Void System.Xml.XmlTextReaderImpl::Throw(System.Int32,System.String,System.String)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stfld:int32(ParsingState::charPos, ldfld:ParsingState[exp:valuetype System.Xml.XmlTextReaderImpl/ParsingState&](XmlTextReaderImpl::ps, ldloc:XmlTextReaderImpl(this)), ldloc:int32(pos))
	call:void(XmlTextReaderImpl::Throw, ldloc:XmlTextReaderImpl(this), ldloc:string(res), ldloc:string(arg))
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

		// Token: 0x06000295 RID: 661 RVA: 0x00008324 File Offset: 0x00006524
		private void Throw(int pos, string res, string[] args)
		{
			/*
An exception occurred when decompiling this method (06000295)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Void System.Xml.XmlTextReaderImpl::Throw(System.Int32,System.String,System.String[])

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stfld:int32(ParsingState::charPos, ldfld:ParsingState[exp:valuetype System.Xml.XmlTextReaderImpl/ParsingState&](XmlTextReaderImpl::ps, ldloc:XmlTextReaderImpl(this)), ldloc:int32(pos))
	call:void(XmlTextReaderImpl::Throw, ldloc:XmlTextReaderImpl(this), ldloc:string(res), ldloc:string[](args))
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

		// Token: 0x06000296 RID: 662 RVA: 0x00008344 File Offset: 0x00006544
		private void Throw(int pos, string res)
		{
			/*
An exception occurred when decompiling this method (06000296)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Void System.Xml.XmlTextReaderImpl::Throw(System.Int32,System.String)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stfld:int32(ParsingState::charPos, ldfld:ParsingState[exp:valuetype System.Xml.XmlTextReaderImpl/ParsingState&](XmlTextReaderImpl::ps, ldloc:XmlTextReaderImpl(this)), ldloc:int32(pos))
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

		// Token: 0x06000297 RID: 663 RVA: 0x00003FFD File Offset: 0x000021FD
		private void Throw(string res)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06000298 RID: 664 RVA: 0x0000835C File Offset: 0x0000655C
		private void Throw(string res, int lineNo, int linePos)
		{
			/*
An exception occurred when decompiling this method (06000298)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Void System.Xml.XmlTextReaderImpl::Throw(System.String,System.Int32,System.Int32)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:string(var_0_0B, ldfld:string(ParsingState::baseUriStr, ldfld:ParsingState[exp:valuetype System.Xml.XmlTextReaderImpl/ParsingState&](XmlTextReaderImpl::ps, ldloc:XmlTextReaderImpl(this))))
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

		// Token: 0x06000299 RID: 665 RVA: 0x00008374 File Offset: 0x00006574
		private void Throw(string res, string arg)
		{
			/*
An exception occurred when decompiling this method (06000299)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Void System.Xml.XmlTextReaderImpl::Throw(System.String,System.String)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:int32(var_0_0B, ldfld:int32(ParsingState::lineNo, ldfld:ParsingState[exp:valuetype System.Xml.XmlTextReaderImpl/ParsingState&](XmlTextReaderImpl::ps, ldloc:XmlTextReaderImpl(this))))
	stloc:string(var_2_17, ldfld:string(ParsingState::baseUriStr, ldfld:ParsingState[exp:valuetype System.Xml.XmlTextReaderImpl/ParsingState&](XmlTextReaderImpl::ps, ldloc:XmlTextReaderImpl(this))))
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

		// Token: 0x0600029A RID: 666 RVA: 0x00008398 File Offset: 0x00006598
		private void Throw(string res, string arg, int lineNo, int linePos)
		{
			/*
An exception occurred when decompiling this method (0600029A)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Void System.Xml.XmlTextReaderImpl::Throw(System.String,System.String,System.Int32,System.Int32)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:string(var_0_0B, ldfld:string(ParsingState::baseUriStr, ldfld:ParsingState[exp:valuetype System.Xml.XmlTextReaderImpl/ParsingState&](XmlTextReaderImpl::ps, ldloc:XmlTextReaderImpl(this))))
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

		// Token: 0x0600029B RID: 667 RVA: 0x000083B0 File Offset: 0x000065B0
		private void Throw(string res, string[] args)
		{
			/*
An exception occurred when decompiling this method (0600029B)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Void System.Xml.XmlTextReaderImpl::Throw(System.String,System.String[])

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:int32(var_0_0B, ldfld:int32(ParsingState::lineNo, ldfld:ParsingState[exp:valuetype System.Xml.XmlTextReaderImpl/ParsingState&](XmlTextReaderImpl::ps, ldloc:XmlTextReaderImpl(this))))
	stloc:string(var_2_17, ldfld:string(ParsingState::baseUriStr, ldfld:ParsingState[exp:valuetype System.Xml.XmlTextReaderImpl/ParsingState&](XmlTextReaderImpl::ps, ldloc:XmlTextReaderImpl(this))))
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

		// Token: 0x0600029C RID: 668 RVA: 0x000083D4 File Offset: 0x000065D4
		private void Throw(string res, string arg, Exception innerException)
		{
			throw new ArrayTypeMismatchException();
		}

		// Token: 0x0600029D RID: 669 RVA: 0x000083E8 File Offset: 0x000065E8
		private void Throw(string res, string[] args, Exception innerException)
		{
			/*
An exception occurred when decompiling this method (0600029D)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Void System.Xml.XmlTextReaderImpl::Throw(System.String,System.String[],System.Exception)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:int32(var_0_0B, ldfld:int32(ParsingState::lineNo, ldfld:ParsingState[exp:valuetype System.Xml.XmlTextReaderImpl/ParsingState&](XmlTextReaderImpl::ps, ldloc:XmlTextReaderImpl(this))))
	stloc:string(var_2_17, ldfld:string(ParsingState::baseUriStr, ldfld:ParsingState[exp:valuetype System.Xml.XmlTextReaderImpl/ParsingState&](XmlTextReaderImpl::ps, ldloc:XmlTextReaderImpl(this))))
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

		// Token: 0x0600029E RID: 670 RVA: 0x0000840C File Offset: 0x0000660C
		private void Throw(Exception e)
		{
			/*
An exception occurred when decompiling this method (0600029E)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Void System.Xml.XmlTextReaderImpl::Throw(System.Exception)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:NodeData(var_2_1C, ldfld:NodeData(XmlTextReaderImpl::curNode, ldloc:XmlTextReaderImpl(this)))
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

		// Token: 0x0600029F RID: 671 RVA: 0x00008438 File Offset: 0x00006638
		private void ReThrow(Exception e, int lineNo, int linePos)
		{
			/*
An exception occurred when decompiling this method (0600029F)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Void System.Xml.XmlTextReaderImpl::ReThrow(System.Exception,System.Int32,System.Int32)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:string(var_0_0B, ldfld:string(ParsingState::baseUriStr, ldfld:ParsingState[exp:valuetype System.Xml.XmlTextReaderImpl/ParsingState&](XmlTextReaderImpl::ps, ldloc:XmlTextReaderImpl(this))))
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

		// Token: 0x060002A0 RID: 672 RVA: 0x00008450 File Offset: 0x00006650
		private void ThrowWithoutLineInfo(string res)
		{
			/*
An exception occurred when decompiling this method (060002A0)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Void System.Xml.XmlTextReaderImpl::ThrowWithoutLineInfo(System.String)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:string(var_0_0B, ldfld:string(ParsingState::baseUriStr, ldfld:ParsingState[exp:valuetype System.Xml.XmlTextReaderImpl/ParsingState&](XmlTextReaderImpl::ps, ldloc:XmlTextReaderImpl(this))))
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

		// Token: 0x060002A1 RID: 673 RVA: 0x00008468 File Offset: 0x00006668
		private void ThrowWithoutLineInfo(string res, string arg)
		{
			/*
An exception occurred when decompiling this method (060002A1)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Void System.Xml.XmlTextReaderImpl::ThrowWithoutLineInfo(System.String,System.String)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:string(var_0_0B, ldfld:string(ParsingState::baseUriStr, ldfld:ParsingState[exp:valuetype System.Xml.XmlTextReaderImpl/ParsingState&](XmlTextReaderImpl::ps, ldloc:XmlTextReaderImpl(this))))
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

		// Token: 0x060002A2 RID: 674 RVA: 0x00008480 File Offset: 0x00006680
		private void ThrowWithoutLineInfo(string res, string[] args, Exception innerException)
		{
			/*
An exception occurred when decompiling this method (060002A2)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Void System.Xml.XmlTextReaderImpl::ThrowWithoutLineInfo(System.String,System.String[],System.Exception)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:string(var_0_0B, ldfld:string(ParsingState::baseUriStr, ldfld:ParsingState[exp:valuetype System.Xml.XmlTextReaderImpl/ParsingState&](XmlTextReaderImpl::ps, ldloc:XmlTextReaderImpl(this))))
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

		// Token: 0x060002A3 RID: 675 RVA: 0x0000849C File Offset: 0x0000669C
		private void ThrowInvalidChar(char[] data, int length, int invCharPos)
		{
			/*
An exception occurred when decompiling this method (060002A3)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Void System.Xml.XmlTextReaderImpl::ThrowInvalidChar(System.Char[],System.Int32,System.Int32)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:string[](var_0_08, call:string[](XmlException::BuildCharExceptionArgs, ldloc:char[](data), ldloc:int32(length), ldloc:int32(invCharPos)))
	call:void(XmlTextReaderImpl::Throw, ldloc:XmlTextReaderImpl(this), ldloc:int32(invCharPos), ldstr:string("'{0}', hexadecimal value {1}, is an invalid character."), ldloc:string[](var_0_08))
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

		// Token: 0x060002A4 RID: 676 RVA: 0x000084C0 File Offset: 0x000066C0
		private void SetErrorState()
		{
			this.parsingFunction = XmlTextReaderImpl.ParsingFunction.Error;
			this.readState = ReadState.Error;
		}

		// Token: 0x060002A5 RID: 677 RVA: 0x000084DC File Offset: 0x000066DC
		private void SendValidationEvent(XmlSeverityType severity, string code, string arg, int lineNo, int linePos)
		{
			string baseUriStr = this.ps.baseUriStr;
		}

		// Token: 0x060002A6 RID: 678 RVA: 0x000084F8 File Offset: 0x000066F8
		private void SendValidationEvent(XmlSeverityType severity, XmlSchemaException exception)
		{
			if (this.validationEventHandling != null)
			{
				return;
			}
		}

		// Token: 0x170000A0 RID: 160
		// (get) Token: 0x060002A7 RID: 679 RVA: 0x00008510 File Offset: 0x00006710
		private bool InAttributeValueIterator
		{
			get
			{
				/*
An exception occurred when decompiling this method (060002A7)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean System.Xml.XmlTextReaderImpl::get_InAttributeValueIterator()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:int32(var_0_06, ldfld:int32(XmlTextReaderImpl::attrCount, ldloc:XmlTextReaderImpl(this)))
	stloc:ParsingFunction(var_1_0D, ldfld:ParsingFunction(XmlTextReaderImpl::parsingFunction, ldloc:XmlTextReaderImpl(this)))
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

		// Token: 0x060002A8 RID: 680 RVA: 0x0000852C File Offset: 0x0000672C
		private void FinishAttributeValueIterator()
		{
			XmlTextReaderImpl.ParsingFunction parsingFunction = this.parsingFunction;
			XmlTextReaderImpl.IncrementalReadState incrementalReadState = this.incReadState;
			this.SkipPartialTextValue();
		}

		// Token: 0x170000A1 RID: 161
		// (get) Token: 0x060002A9 RID: 681 RVA: 0x000085A0 File Offset: 0x000067A0
		private bool DtdValidation
		{
			get
			{
				/*
An exception occurred when decompiling this method (060002A9)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean System.Xml.XmlTextReaderImpl::get_DtdValidation()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:IValidationEventHandling(var_0_06, ldfld:IValidationEventHandling(XmlTextReaderImpl::validationEventHandling, ldloc:XmlTextReaderImpl(this)))
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

		// Token: 0x060002AA RID: 682 RVA: 0x000085B4 File Offset: 0x000067B4
		private void InitStreamInput(Uri baseUri, Stream stream, Encoding encoding)
		{
		}

		// Token: 0x060002AB RID: 683 RVA: 0x000085C4 File Offset: 0x000067C4
		private void InitStreamInput(Uri baseUri, string baseUriStr, Stream stream, Encoding encoding)
		{
		}

		// Token: 0x060002AC RID: 684 RVA: 0x000085D4 File Offset: 0x000067D4
		private void InitStreamInput(Uri baseUri, string baseUriStr, Stream stream, byte[] bytes, int byteCount, Encoding encoding)
		{
			this.ps.stream = stream;
			this.ps.baseUriStr = baseUriStr;
			this.ps.baseUri = baseUri;
			if (bytes != null)
			{
				this.ps.bytes = bytes;
				this.ps.bytesUsed = byteCount;
				return;
			}
			XmlTextReaderImpl.LaterInitParam laterInitParam = this.laterInitParam;
			if (laterInitParam != null && laterInitParam.useAsync)
			{
				return;
			}
			int num = XmlReader.CalcBufferSize(stream);
			if (this.ps.bytes != null)
			{
			}
			XmlTextReaderImpl.ParsingState parsingState = this.ps;
			if (parsingState != null)
			{
				bool appendMode = parsingState.appendMode;
				return;
			}
			int bytesUsed = this.ps.bytesUsed;
			byte[] bytes2 = this.ps.bytes;
			Encoding encoding2;
			if (stream != null)
			{
				int bytesUsed2 = this.ps.bytesUsed;
				this.ps.bytesUsed = bytesUsed;
				if (encoding == null)
				{
					encoding2 = this.DetectEncoding();
				}
				this.SetupEncoding(encoding2);
				CodePageDataItem dataItem = this.ps.encoding.dataItem;
				byte[] bytes3 = this.ps.bytes;
				return;
			}
			int num2 = 1;
			this.ps.isStreamEof = num2 != 0;
			while (encoding2 != null)
			{
			}
		}

		// Token: 0x060002AD RID: 685 RVA: 0x00008738 File Offset: 0x00006938
		private void InitTextReaderInput(string baseUriStr, TextReader input)
		{
		}

		// Token: 0x060002AE RID: 686 RVA: 0x00008748 File Offset: 0x00006948
		private void InitTextReaderInput(string baseUriStr, Uri baseUri, TextReader input)
		{
			XmlTextReaderImpl.ParsingState parsingState = this.ps;
			this.ps.textReader = input;
			this.ps.baseUriStr = baseUriStr;
			this.ps.baseUri = baseUri;
			if (parsingState == null)
			{
				XmlTextReaderImpl.LaterInitParam laterInitParam = this.laterInitParam;
				if (laterInitParam != null && laterInitParam.useAsync)
				{
					return;
				}
			}
			Encoding unicode = Encoding.Unicode;
			bool flag = this.normalize;
			this.ps.encoding = unicode;
			this.ps.appendMode = true;
			this.ps.eolNormalized = flag;
			int num = this.ReadData();
		}

		// Token: 0x060002AF RID: 687 RVA: 0x000087D4 File Offset: 0x000069D4
		private void InitStringInput(string baseUriStr, Encoding originalEncoding, string str)
		{
			this.ps.baseUriStr = baseUriStr;
			int stringLength = str._stringLength;
			XmlTextReaderImpl.ParsingState parsingState = this.ps;
			this.ps.charsUsed = baseUriStr;
			int num = 1;
			bool flag = this.normalize;
			this.ps.encoding = originalEncoding;
			this.ps.isEof = num != 0;
			this.ps.eolNormalized = flag;
		}

		// Token: 0x060002B0 RID: 688 RVA: 0x00008834 File Offset: 0x00006A34
		private void InitFragmentReader(XmlNodeType fragmentType, XmlParserContext parserContext, bool allowXmlDeclFragment)
		{
			this.fragmentParserContext = parserContext;
			if (parserContext == null)
			{
				XmlNameTable xmlNameTable = this.nameTable;
				return;
			}
			XmlNamespaceManager nsMgr = parserContext._nsMgr;
			if (nsMgr != null)
			{
				this.namespaceManager = nsMgr;
				this.xmlContext.defaultNamespace = nsMgr;
				return;
			}
			XmlNameTable xmlNameTable2 = this.nameTable;
			XmlTextReaderImpl.XmlContext xmlContext = this.xmlContext;
		}

		// Token: 0x060002B1 RID: 689 RVA: 0x000088AC File Offset: 0x00006AAC
		private void ProcessDtdFromParserContext(XmlParserContext context)
		{
			/*
An exception occurred when decompiling this method (060002B1)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Void System.Xml.XmlTextReaderImpl::ProcessDtdFromParserContext(System.Xml.XmlParserContext)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0010:
	call:void(XmlTextReaderImpl::ThrowWithoutLineInfo, ldloc:XmlTextReaderImpl(this), ldstr:string("For security reasons DTD is prohibited in this XML document. To enable DTD processing set the DtdProcessing property on XmlReaderSettings to Parse and pass the settings into XmlReader.Create method."))
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

		// Token: 0x060002B2 RID: 690 RVA: 0x000088D4 File Offset: 0x00006AD4
		private void OpenUrl()
		{
			XmlResolver tempResolver = this.GetTempResolver();
			Uri baseUri = this.ps.baseUri;
			string text = this.url;
			long num = 0L;
			this.ps.baseUri = tempResolver;
			this.ps.baseUriStr = tempResolver;
			this.OpenUrlDelegate(num);
			if (this.ps.stream != null)
			{
				string baseUriStr = this.ps.baseUriStr;
				Uri baseUri2 = this.ps.baseUri;
				Encoding encoding = this.ps.encoding;
				this.reportedEncoding = encoding;
				return;
			}
			string baseUriStr2 = this.ps.baseUriStr;
			this.ThrowWithoutLineInfo("Cannot resolve '{0}'.", baseUriStr2);
			int num2 = 10;
			int num3 = 2;
			this.parsingFunction = (XmlTextReaderImpl.ParsingFunction)num2;
			this.readState = (ReadState)num3;
			throw new OutOfMemoryException();
		}

		// Token: 0x060002B3 RID: 691 RVA: 0x00008994 File Offset: 0x00006B94
		private void OpenUrlDelegate(object xmlResolver)
		{
			XmlResolver tempResolver = this.GetTempResolver();
			Uri baseUri = this.ps.baseUri;
			if (tempResolver != null)
			{
				this.ps.stream = tempResolver;
				throw new InvalidCastException();
			}
		}

		// Token: 0x060002B4 RID: 692 RVA: 0x000089CC File Offset: 0x00006BCC
		private Encoding DetectEncoding()
		{
			int bytesUsed = this.ps.bytesUsed;
			byte[] bytes = this.ps.bytes;
			return "ebcdic";
		}

		// Token: 0x060002B5 RID: 693 RVA: 0x00008A38 File Offset: 0x00006C38
		private void SetupEncoding(Encoding encoding)
		{
			if (encoding != null)
			{
				this.ps.encoding = encoding;
				return;
			}
			Encoding utf = Encoding.UTF8;
			this.ps.encoding = utf;
		}

		// Token: 0x060002B6 RID: 694 RVA: 0x00008A6C File Offset: 0x00006C6C
		private void SwitchEncoding(Encoding newEncoding)
		{
			Encoding encoding = this.ps.encoding;
			if (!this.afterResetState)
			{
				this.UnDecodeChars();
				this.SetupEncoding(newEncoding);
				int num = this.ReadData();
				return;
			}
		}

		// Token: 0x060002B7 RID: 695 RVA: 0x00008AB0 File Offset: 0x00006CB0
		private Encoding CheckEncoding(string newEncodingName)
		{
			/*
An exception occurred when decompiling this method (060002B7)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Text.Encoding System.Xml.XmlTextReaderImpl::CheckEncoding(System.String)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_007C:
	call:void(XmlTextReaderImpl::Throw, ldloc:XmlTextReaderImpl(this), ldstr:string("'{0}' is an invalid value for the 'encoding' attribute. The encoding cannot be switched after a call to ResetState."), ldloc:string(newEncodingName))
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

		// Token: 0x060002B8 RID: 696 RVA: 0x00008B48 File Offset: 0x00006D48
		private void UnDecodeChars()
		{
			long num = this.maxCharactersInDocument;
			int charPos = this.ps.charPos;
			Encoding encoding = this.ps.encoding;
			long num2 = this.charactersInDocument;
			this.charactersInDocument = (long)charPos;
			long num3 = this.maxCharactersFromEntities;
			int num4 = this.parsingStatesStackTop;
			int charPos2 = this.ps.charPos;
			Encoding encoding2 = this.ps.encoding;
			long num5 = this.charactersFromEntities;
			this.charactersFromEntities = (long)charPos2;
			int charPos3 = this.ps.charPos;
			int num6 = this.documentStartBytePos;
			this.ps.bytePos = num6;
			Encoding encoding3 = this.ps.encoding;
			XmlTextReaderImpl.ParsingState parsingState = this.ps;
			int charPos4 = this.ps.charPos;
			this.ps.charsUsed = charPos4;
		}

		// Token: 0x060002B9 RID: 697 RVA: 0x00008C10 File Offset: 0x00006E10
		private void SwitchEncodingToUTF8()
		{
		}

		// Token: 0x060002BA RID: 698 RVA: 0x00008C20 File Offset: 0x00006E20
		private int ReadData()
		{
			/*
An exception occurred when decompiling this method (060002BA)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Int32 System.Xml.XmlTextReaderImpl::ReadData()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0317:
	stloc:ParsingState(var_55_31D, ldfld:ParsingState(XmlTextReaderImpl::ps, ldloc:XmlTextReaderImpl(this)))
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

		// Token: 0x060002BB RID: 699 RVA: 0x00008F4C File Offset: 0x0000714C
		private int GetChars(int maxCharsCount)
		{
			/*
An exception occurred when decompiling this method (060002BB)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Int32 System.Xml.XmlTextReaderImpl::GetChars(System.Int32)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:int32(var_0_0B, ldfld:int32(ParsingState::bytePos, ldfld:ParsingState[exp:valuetype System.Xml.XmlTextReaderImpl/ParsingState&](XmlTextReaderImpl::ps, ldloc:XmlTextReaderImpl(this))))
	stloc:TextReader(var_1_17, ldfld:TextReader(ParsingState::textReader, ldfld:ParsingState[exp:valuetype System.Xml.XmlTextReaderImpl/ParsingState&](XmlTextReaderImpl::ps, ldloc:XmlTextReaderImpl(this))))
	stloc:Decoder(var_2_23, ldfld:Decoder(ParsingState::decoder, ldfld:ParsingState[exp:valuetype System.Xml.XmlTextReaderImpl/ParsingState&](XmlTextReaderImpl::ps, ldloc:XmlTextReaderImpl(this))))
	stloc:uint8[](var_3_2F, ldfld:uint8[](ParsingState::bytes, ldfld:ParsingState[exp:valuetype System.Xml.XmlTextReaderImpl/ParsingState&](XmlTextReaderImpl::ps, ldloc:XmlTextReaderImpl(this))))
	stloc:ParsingState(var_4_36, ldfld:ParsingState(XmlTextReaderImpl::ps, ldloc:XmlTextReaderImpl(this)))
	stloc:int32(var_5_43, ldfld:int32(ParsingState::charsUsed, ldfld:ParsingState[exp:valuetype System.Xml.XmlTextReaderImpl/ParsingState&](XmlTextReaderImpl::ps, ldloc:XmlTextReaderImpl(this))))
	stloc:int32(var_6_50, ldfld:int32(ParsingState::bytePos, ldfld:ParsingState[exp:valuetype System.Xml.XmlTextReaderImpl/ParsingState&](XmlTextReaderImpl::ps, ldloc:XmlTextReaderImpl(this))))
	stfld:int32(ParsingState::bytePos, ldfld:ParsingState[exp:valuetype System.Xml.XmlTextReaderImpl/ParsingState&](XmlTextReaderImpl::ps, ldloc:XmlTextReaderImpl(this)), ldloc:int32(var_6_50))
	stloc:int32(var_7_6A, ldfld:int32(ParsingState::charsUsed, ldfld:ParsingState[exp:valuetype System.Xml.XmlTextReaderImpl/ParsingState&](XmlTextReaderImpl::ps, ldloc:XmlTextReaderImpl(this))))
	stfld:int32(ParsingState::charsUsed, ldfld:ParsingState[exp:valuetype System.Xml.XmlTextReaderImpl/ParsingState&](XmlTextReaderImpl::ps, ldloc:XmlTextReaderImpl(this)), ldloc:int32(var_7_6A))
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

		// Token: 0x060002BC RID: 700 RVA: 0x00008FD8 File Offset: 0x000071D8
		private void InvalidCharRecovery(int bytesCount, [Out] int charsCount)
		{
			/*
An exception occurred when decompiling this method (060002BC)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Void System.Xml.XmlTextReaderImpl::InvalidCharRecovery(System.Int32,System.Int32)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0053:
	stloc:int32(var_7_5E, ldfld:int32(ParsingState::charsUsed, ldfld:ParsingState[exp:valuetype System.Xml.XmlTextReaderImpl/ParsingState&](XmlTextReaderImpl::ps, ldloc:XmlTextReaderImpl(this))))
	call:void(XmlTextReaderImpl::Throw, ldloc:XmlTextReaderImpl(this), ldloc:int32(var_7_5E), ldstr:string("Invalid character in the given encoding."))
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

		// Token: 0x060002BD RID: 701 RVA: 0x00009054 File Offset: 0x00007254
		internal void Close(bool closeInput)
		{
			XmlTextReaderImpl.ParsingFunction parsingFunction = this.parsingFunction;
			int num = this.parsingStatesStackTop;
			XmlTextReaderImpl.ParsingState[] array = this.parsingStatesStack;
			XmlTextReaderImpl.NodeData none = XmlTextReaderImpl.NodeData.None;
			int num2 = 12;
			this.curNode = none;
			this.parsingFunction = (XmlTextReaderImpl.ParsingFunction)num2;
			int num3 = 4;
			this.readState = (ReadState)num3;
			this.ResetAttributes();
		}

		// Token: 0x060002BE RID: 702 RVA: 0x000090A8 File Offset: 0x000072A8
		private void ShiftBuffer(int sourcePos, int destPos, int count)
		{
			XmlTextReaderImpl.ParsingState parsingState = this.ps;
		}

		// Token: 0x060002BF RID: 703 RVA: 0x000090BC File Offset: 0x000072BC
		private bool ParseXmlDeclaration(bool isTextDecl)
		{
			/*
An exception occurred when decompiling this method (060002BF)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean System.Xml.XmlTextReaderImpl::ParseXmlDeclaration(System.Boolean)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_03FD:
	call:void(XmlTextReaderImpl::Throw, ldloc:XmlTextReaderImpl(this), ldstr:string("There is an unclosed literal string."))
	stloc:int32(var_92_413, ldfld:int32(ParsingState::charPos, ldfld:ParsingState[exp:valuetype System.Xml.XmlTextReaderImpl/ParsingState&](XmlTextReaderImpl::ps, ldloc:XmlTextReaderImpl(this))))
	stloc:ParsingState(var_93_41B, ldfld:ParsingState(XmlTextReaderImpl::ps, ldloc:XmlTextReaderImpl(this)))
	call:void(XmlTextReaderImpl::Throw, ldloc:XmlTextReaderImpl(this), ldstr:string("Version number '{0}' is invalid."), ldloc:string(var_95))
	stloc:int32(var_96_438, ldfld:int32(ParsingState::lineNo, ldfld:ParsingState[exp:valuetype System.Xml.XmlTextReaderImpl/ParsingState&](XmlTextReaderImpl::ps, ldloc:XmlTextReaderImpl(this))))
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

		// Token: 0x060002C0 RID: 704 RVA: 0x00009504 File Offset: 0x00007704
		private bool ParseDocumentContent()
		{
			XmlTextReaderImpl.ParsingState parsingState = this.ps;
			int charsUsed = this.ps.charsUsed;
			return "There are multiple root elements." != null;
		}

		// Token: 0x060002C1 RID: 705 RVA: 0x00009704 File Offset: 0x00007904
		private bool ParseElementContent()
		{
			XmlTextReaderImpl.ParsingState parsingState = this.ps;
			int charsUsed = this.ps.charsUsed;
			return "CDATA[" != null;
		}

		// Token: 0x060002C2 RID: 706 RVA: 0x0000983C File Offset: 0x00007A3C
		private void ThrowUnclosedElements()
		{
			if (this.index == 0)
			{
				XmlNodeType type = this.curNode.type;
			}
			XmlTextReaderImpl.ParsingFunction parsingFunction = this.parsingFunction;
			StringBuilder stringBuilder = this.stringBuilder;
			long num = 0L;
			stringBuilder.Length = (int)num;
			int stringLength = this.nodes.prefix._stringLength;
			XmlNameTable xmlNameTable = this.nameTable;
			string text;
			StringBuilder stringBuilder2 = this.stringBuilder.Append(text);
			StringBuilder stringBuilder3 = this.stringBuilder.Append(", ");
		}

		// Token: 0x060002C3 RID: 707 RVA: 0x000098EC File Offset: 0x00007AEC
		private void ParseElement()
		{
			XmlTextReaderImpl.ParsingState parsingState = this.ps;
			int entityId = this.ps.entityId;
			Decoder decoder = this.ps.decoder;
			if (!this.supportNamespaces)
			{
				return;
			}
			int num = 58;
			long num2 = 0L;
			string[] array = XmlException.BuildCharExceptionArgs((char)num, (char)num2);
			int num3;
			this.Throw(num3, "The '{0}' character, hexadecimal value {1}, cannot be included in a name.", array);
			int charsUsed = this.ps.charsUsed;
		}

		// Token: 0x060002C4 RID: 708 RVA: 0x00009AF4 File Offset: 0x00007CF4
		private void AddDefaultAttributesAndNormalize()
		{
			IDtdInfo dtdInfo = this.dtdInfo;
			XmlTextReaderImpl.NodeData nodeData = this.curNode;
			string localName = nodeData.localName;
			string prefix = nodeData.prefix;
			if (nodeData != null)
			{
			}
		}

		// Token: 0x060002C5 RID: 709 RVA: 0x00009C80 File Offset: 0x00007E80
		private void ParseEndElement()
		{
			Encoding encoding;
			do
			{
				int num = this.index;
				XmlNodeType type = this.nodes.type;
				int charPos = this.ps.charPos;
				encoding = this.ps.encoding;
			}
			while (this.ReadData() != 0);
			int charPos2 = this.ps.charPos;
			XmlTextReaderImpl.ParsingState parsingState = this.ps;
			bool deserializedFromEverett;
			if (encoding != null)
			{
				if (encoding == null)
				{
				}
				deserializedFromEverett = encoding.m_deserializedFromEverett;
				if (!deserializedFromEverett)
				{
				}
				return;
			}
			if (!deserializedFromEverett)
			{
			}
			int lineNo = this.ps.lineNo;
			int charPos3 = this.ps.charPos;
			Encoding encoding2 = this.ps.encoding;
			XmlTextReaderImpl.ParsingState parsingState2 = this.ps;
			int lineNo2 = this.ps.lineNo;
			this.ps.lineNo = lineNo2;
			this.ps.baseUriStr = parsingState;
		}

		// Token: 0x060002C6 RID: 710 RVA: 0x00009DF0 File Offset: 0x00007FF0
		private void ThrowTagMismatch(XmlTextReaderImpl.NodeData startTag)
		{
			XmlNodeType type = startTag.type;
			XmlNameTable xmlNameTable = this.nameTable;
			string nameWPrefix = startTag.GetNameWPrefix(xmlNameTable);
			throw new ArrayTypeMismatchException();
		}

		// Token: 0x060002C7 RID: 711 RVA: 0x00009E64 File Offset: 0x00008064
		private void ParseAttributes()
		{
			XmlTextReaderImpl.ParsingState parsingState = this.ps;
			XmlCharType xmlCharType = this.xmlCharType;
		}

		// Token: 0x060002C8 RID: 712 RVA: 0x0000A144 File Offset: 0x00008344
		private void ElementNamespaceLookup()
		{
			XmlTextReaderImpl.NodeData nodeData = this.curNode;
			int stringLength = nodeData.prefix._stringLength;
			if (stringLength != 0)
			{
				string text = this.LookupNamespace(nodeData);
				nodeData.ns = text;
				return;
			}
			nodeData.ns = stringLength;
		}

		// Token: 0x060002C9 RID: 713 RVA: 0x0000A180 File Offset: 0x00008380
		private void AttributeNamespaceLookup()
		{
			int num = this.index;
			int num2 = this.attrCount;
			int stringLength = this.nodes.prefix._stringLength;
			int num3 = this.index;
			int num4 = this.attrCount;
		}

		// Token: 0x060002CA RID: 714 RVA: 0x0000A1BC File Offset: 0x000083BC
		private void AttributeDuplCheck()
		{
			int num = this.attrCount;
			XmlTextReaderImpl.NodeData[] array = this.attrDuplSortingArray;
			if (array != null)
			{
				string localName = array.localName;
			}
			int num2 = this.attrCount;
			int num3 = this.index;
			XmlTextReaderImpl.NodeData[] array2 = this.nodes;
			XmlTextReaderImpl.NodeData[] array3 = this.attrDuplSortingArray;
			int num4 = this.attrCount;
			int num5 = this.attrCount;
			string prefix = this.attrDuplSortingArray.prefix;
			XmlTextReaderImpl.NodeData[] array4 = this.attrDuplSortingArray;
		}

		// Token: 0x060002CB RID: 715 RVA: 0x0000A2B8 File Offset: 0x000084B8
		private void OnDefaultNamespaceDecl(XmlTextReaderImpl.NodeData attr)
		{
			if (this.supportNamespaces)
			{
				XmlNameTable xmlNameTable = this.nameTable;
				string stringValue = attr.StringValue;
				XmlNameTable xmlNameTable2 = this.nameTable;
				attr.ns = xmlNameTable2;
				if (!this.curNode.xmlContextPushed)
				{
					this.PushXmlContext();
				}
				this.xmlContext.defaultNamespace = xmlNameTable;
				return;
			}
		}

		// Token: 0x060002CC RID: 716 RVA: 0x0000A30C File Offset: 0x0000850C
		private void OnNamespaceDecl(XmlTextReaderImpl.NodeData attr)
		{
			if (this.supportNamespaces)
			{
				XmlNameTable xmlNameTable = this.nameTable;
				string stringValue = attr.StringValue;
				string localName = attr.localName;
				return;
			}
		}

		// Token: 0x060002CD RID: 717 RVA: 0x0000A348 File Offset: 0x00008548
		private void OnXmlReservedAttribute(XmlTextReaderImpl.NodeData attr)
		{
			bool flag = attr.localName == "space";
			if (!this.curNode.xmlContextPushed)
			{
				this.PushXmlContext();
			}
			string text = XmlConvert.TrimString(attr.StringValue);
			bool flag2 = text == "preserve";
			XmlTextReaderImpl.XmlContext xmlContext = this.xmlContext;
		}

		// Token: 0x060002CE RID: 718 RVA: 0x0000A3F8 File Offset: 0x000085F8
		private void ParseAttributeValueSlow(int curPos, char quoteChar, XmlTextReaderImpl.NodeData attr)
		{
			XmlTextReaderImpl.ParsingState parsingState = this.ps;
			string baseUriStr = this.ps.baseUriStr;
			Decoder decoder = this.ps.decoder;
			XmlCharType xmlCharType = this.xmlCharType;
			int charPos = this.ps.charPos;
			StringBuilder stringBuilder = this.stringBuilder;
			this.ps.charPos = charPos;
			int entityId = this.ps.entityId;
			StringBuilder stringBuilder2 = this.stringBuilder;
			int entityId2 = this.ps.entityId;
			int lineNo = this.ps.lineNo;
			this.ps.charPos = charPos;
			if (this.parsingMode == XmlTextReaderImpl.ParsingMode.Full)
			{
				int entityId3 = this.ps.entityId;
				int length = this.stringBuilder.Length;
				int depth = attr.depth;
				StringBuilder stringBuilder3 = this.stringBuilder;
				int charPos2 = this.ps.charPos;
				this.ps.charPos = charPos2;
				string text = this.ParseEntityName();
				int depth2 = attr.depth;
				StringBuilder stringBuilder4 = this.stringBuilder;
				int num = 38;
				StringBuilder stringBuilder5 = stringBuilder4.Append((char)num);
				StringBuilder stringBuilder6 = this.stringBuilder.Append(text);
				StringBuilder stringBuilder7 = this.stringBuilder;
				int num2 = 59;
				StringBuilder stringBuilder8 = stringBuilder7.Append((char)num2);
				int length2 = this.stringBuilder.Length;
				int lineNo2 = this.ps.lineNo;
				int num3 = 1;
				this.fullAttrCleanup = num3 != 0;
				return;
			}
			int charPos3 = this.ps.charPos;
			this.ps.charPos = charPos3;
			string text2 = this.ParseEntityName();
		}

		// Token: 0x060002CF RID: 719 RVA: 0x0000A7F4 File Offset: 0x000089F4
		private void AddAttributeChunkToList(XmlTextReaderImpl.NodeData attr, XmlTextReaderImpl.NodeData chunk, XmlTextReaderImpl.NodeData lastChunk)
		{
		}

		// Token: 0x060002D0 RID: 720 RVA: 0x0000A80C File Offset: 0x00008A0C
		private bool ParseText()
		{
			if (this.parsingMode != XmlTextReaderImpl.ParsingMode.Full)
			{
				XmlTextReaderImpl.ParsingFunction parsingFunction = this.parsingFunction;
				this.SetupEndEntityNodeInContent();
				XmlTextReaderImpl.ParsingFunction parsingFunction2 = this.nextParsingFunction;
				this.parsingFunction = parsingFunction2;
			}
			XmlTextReaderImpl.NodeData nodeData = this.curNode;
			int lineNo = this.ps.lineNo;
			long num = 0L;
			int num2;
			nodeData.SetLineInfo(lineNo, num2);
			return this.ParseText(lineNo, num2, (int)num);
		}

		// Token: 0x060002D1 RID: 721 RVA: 0x0000A9F0 File Offset: 0x00008BF0
		private bool ParseText([Out] int startPos, [Out] int endPos, int outOrChars)
		{
			int charPos = this.ps.charPos;
			XmlTextReaderImpl.ParsingState parsingState = this.ps;
			int lineNo = this.ps.lineNo;
			this.ps.lineNo = lineNo;
			this.ps.baseUriStr = charPos;
			return "']]>' is not allowed in character data." != null;
		}

		// Token: 0x060002D2 RID: 722 RVA: 0x0000ACB8 File Offset: 0x00008EB8
		private void FinishPartialValue()
		{
			XmlTextReaderImpl.NodeData nodeData = this.curNode;
			int num = this.readValueOffset;
			StringBuilder stringBuilder = this.stringBuilder;
			nodeData.CopyTo(num, stringBuilder);
			StringBuilder stringBuilder2 = this.stringBuilder;
			XmlTextReaderImpl.ParsingState parsingState = this.ps;
			StringBuilder stringBuilder3 = this.stringBuilder;
			XmlTextReaderImpl.NodeData nodeData2 = this.curNode;
			StringBuilder stringBuilder4 = this.stringBuilder;
			long num2 = 0L;
			stringBuilder4.Length = (int)num2;
		}

		// Token: 0x060002D3 RID: 723 RVA: 0x0000AD18 File Offset: 0x00008F18
		private void FinishOtherValueIterator()
		{
			XmlTextReaderImpl.ParsingFunction parsingFunction = this.parsingFunction;
			XmlTextReaderImpl.IncrementalReadState incrementalReadState = this.incReadState;
			this.FinishPartialValue();
		}

		// Token: 0x060002D4 RID: 724 RVA: 0x0000AD98 File Offset: 0x00008F98
		private void SkipPartialTextValue()
		{
			XmlTextReaderImpl.ParsingFunction parsingFunction = this.nextParsingFunction;
			this.parsingFunction = parsingFunction;
		}

		// Token: 0x060002D5 RID: 725 RVA: 0x0000ADB4 File Offset: 0x00008FB4
		private void FinishReadValueChunk()
		{
			XmlTextReaderImpl.IncrementalReadState incrementalReadState = this.incReadState;
			this.SkipPartialTextValue();
		}

		// Token: 0x060002D6 RID: 726 RVA: 0x0000ADD8 File Offset: 0x00008FD8
		private void FinishReadContentAsBinary()
		{
			XmlTextReaderImpl.IncrementalReadState incrementalReadState = this.incReadState;
			this.SkipPartialTextValue();
			XmlTextReaderImpl.IncrementalReadState incrementalReadState2 = this.incReadState;
		}

		// Token: 0x060002D7 RID: 727 RVA: 0x0000AE04 File Offset: 0x00009004
		private void FinishReadElementContentAsBinary()
		{
			this.FinishReadContentAsBinary();
			XmlNodeType type = this.curNode.type;
			XmlReader xmlReader = this.outerReader;
		}

		// Token: 0x060002D8 RID: 728 RVA: 0x0000AE38 File Offset: 0x00009038
		private bool ParseRootLevelWhitespace()
		{
			WhitespaceHandling whitespaceHandling = this.whitespaceHandling;
			XmlSpace xmlSpace = this.xmlContext.xmlSpace;
			return "Data at the root level is invalid." != null;
		}

		// Token: 0x060002D9 RID: 729 RVA: 0x0000AF44 File Offset: 0x00009144
		private void ParseEntityReference()
		{
			int charPos = this.ps.charPos;
			XmlTextReaderImpl.NodeData nodeData = this.curNode;
			int lineNo = this.ps.lineNo;
			this.ps.charPos = charPos;
			int num;
			nodeData.SetLineInfo(lineNo, num);
			XmlTextReaderImpl.NodeData nodeData2 = this.curNode;
			string text = this.ParseEntityName();
		}

		// Token: 0x060002DA RID: 730 RVA: 0x0000AF94 File Offset: 0x00009194
		private XmlTextReaderImpl.EntityType HandleEntityReference(bool isInAttributeValue, XmlTextReaderImpl.EntityExpandType expandType, [Out] int charRefEndPos)
		{
			/*
An exception occurred when decompiling this method (060002DA)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Xml.XmlTextReaderImpl/EntityType System.Xml.XmlTextReaderImpl::HandleEntityReference(System.Boolean,System.Xml.XmlTextReaderImpl/EntityExpandType,System.Int32)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_00D8:
	call:void(XmlTextReaderImpl::Throw, ldloc:XmlTextReaderImpl(this), ldstr:string("Unexpected end of file has occurred."))
	stloc:int32(var_20_EE, ldfld:int32(ParsingState::lineNo, ldfld:ParsingState[exp:valuetype System.Xml.XmlTextReaderImpl/ParsingState&](XmlTextReaderImpl::ps, ldloc:XmlTextReaderImpl(this))))
	call:void(XmlTextReaderImpl::Throw, ldloc:XmlTextReaderImpl(this), ldstr:string("An error occurred while parsing EntityName."), ldloc:int32(var_20_EE), ldloc:int32(var_9))
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

		// Token: 0x060002DB RID: 731 RVA: 0x0000B0A4 File Offset: 0x000092A4
		private XmlTextReaderImpl.EntityType HandleGeneralEntityReference(string name, bool isInAttributeValue, bool pushFakeEntityIfNullResolver, int entityStartLinePos)
		{
			/*
An exception occurred when decompiling this method (060002DB)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Xml.XmlTextReaderImpl/EntityType System.Xml.XmlTextReaderImpl::HandleGeneralEntityReference(System.String,System.Boolean,System.Boolean,System.Int32)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_00ED:
	stloc:int32(var_22_F8, ldfld:int32(ParsingState::lineNo, ldfld:ParsingState[exp:valuetype System.Xml.XmlTextReaderImpl/ParsingState&](XmlTextReaderImpl::ps, ldloc:XmlTextReaderImpl(this))))
	call:void(XmlTextReaderImpl::Throw, ldloc:XmlTextReaderImpl(this), ldstr:string("External entity '{0}' reference cannot appear in the attribute value."), ldloc:string(name), ldloc:int32(var_22_F8), ldloc:int32(entityStartLinePos))
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

		// Token: 0x170000A2 RID: 162
		// (get) Token: 0x060002DC RID: 732 RVA: 0x0000B1BC File Offset: 0x000093BC
		private bool InEntity
		{
			get
			{
				/*
An exception occurred when decompiling this method (060002DC)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean System.Xml.XmlTextReaderImpl::get_InEntity()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:int32(var_0_06, ldfld:int32(XmlTextReaderImpl::parsingStatesStackTop, ldloc:XmlTextReaderImpl(this)))
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

		// Token: 0x060002DD RID: 733 RVA: 0x0000B1D0 File Offset: 0x000093D0
		private bool HandleEntityEnd(bool checkEntityNesting)
		{
			/*
An exception occurred when decompiling this method (060002DD)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean System.Xml.XmlTextReaderImpl::HandleEntityEnd(System.Boolean)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0053:
	stloc:string(var_6_5E, ldfld:string(NodeData::prefix, ldfld:class System.Xml.XmlTextReaderImpl/NodeData[][exp:NodeData](XmlTextReaderImpl::nodes, ldloc:XmlTextReaderImpl(this))))
	stloc:int32(var_7_6B, ldfld:int32(ParsingState::entityId, ldfld:ParsingState[exp:valuetype System.Xml.XmlTextReaderImpl/ParsingState&](XmlTextReaderImpl::ps, ldloc:XmlTextReaderImpl(this))))
	call:void(XmlTextReaderImpl::PopEntity, ldloc:XmlTextReaderImpl(this))
	stloc:string(var_8_7E, ldfld:string(ParsingState::baseUriStr, ldfld:ParsingState[exp:valuetype System.Xml.XmlTextReaderImpl/ParsingState&](XmlTextReaderImpl::ps, ldloc:XmlTextReaderImpl(this))))
	stloc:Encoding(var_9_8B, ldfld:Encoding(ParsingState::encoding, ldfld:ParsingState[exp:valuetype System.Xml.XmlTextReaderImpl/ParsingState&](XmlTextReaderImpl::ps, ldloc:XmlTextReaderImpl(this))))
	stfld:string(XmlTextReaderImpl::reportedBaseUri, ldloc:XmlTextReaderImpl(this), ldloc:string(var_8_7E))
	stfld:Encoding(XmlTextReaderImpl::reportedEncoding, ldloc:XmlTextReaderImpl(this), ldloc:Encoding(var_9_8B))
	call:void(XmlTextReaderImpl::Throw, ldloc:XmlTextReaderImpl(this), ldstr:string("An internal error has occurred."))
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

		// Token: 0x060002DE RID: 734 RVA: 0x0000B288 File Offset: 0x00009488
		private void SetupEndEntityNodeInContent()
		{
			Encoding encoding = this.ps.encoding;
			string baseUriStr = this.ps.baseUriStr;
			XmlTextReaderImpl.NodeData[] array = this.nodes;
			IDtdEntityInfo dtdEntityInfo = this.lastEntity;
			this.reportedBaseUri = baseUriStr;
			this.reportedEncoding = encoding;
			bool deserializedFromEverett = encoding.m_deserializedFromEverett;
			this.curNode = deserializedFromEverett;
			if (baseUriStr != null)
			{
			}
		}

		// Token: 0x060002DF RID: 735 RVA: 0x0000B310 File Offset: 0x00009510
		private void SetupEndEntityNodeInAttribute()
		{
			int num = this.index;
			int num2 = this.attrCount;
			XmlTextReaderImpl.NodeData[] array = this.nodes;
			this.curNode = num;
		}

		// Token: 0x060002E0 RID: 736 RVA: 0x0000B33C File Offset: 0x0000953C
		private bool ParsePI()
		{
			bool flag;
			return flag;
		}

		// Token: 0x060002E1 RID: 737 RVA: 0x0000B34C File Offset: 0x0000954C
		private bool ParsePI(StringBuilder piInDtdStringBuilder)
		{
			/*
An exception occurred when decompiling this method (060002E1)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean System.Xml.XmlTextReaderImpl::ParsePI(System.Text.StringBuilder)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0154:
	stloc:int32(var_38_15F, ldfld:int32(ParsingState::charsUsed, ldfld:ParsingState[exp:valuetype System.Xml.XmlTextReaderImpl/ParsingState&](XmlTextReaderImpl::ps, ldloc:XmlTextReaderImpl(this))))
	call:void(XmlTextReaderImpl::Throw, ldloc:XmlTextReaderImpl(this), ldstr:string("The '{0}' character, hexadecimal value {1}, cannot be included in a name."), ldloc:string[](var_39))
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

		// Token: 0x060002E2 RID: 738 RVA: 0x0000B4C8 File Offset: 0x000096C8
		private bool ParsePIValue([Out] int outStartPos, [Out] int outEndPos)
		{
			/*
An exception occurred when decompiling this method (060002E2)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean System.Xml.XmlTextReaderImpl::ParsePIValue(System.Int32,System.Int32)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_01B6:
	stloc:int32(var_27_1C1, ldfld:int32(ParsingState::charsUsed, ldfld:ParsingState[exp:valuetype System.Xml.XmlTextReaderImpl/ParsingState&](XmlTextReaderImpl::ps, ldloc:XmlTextReaderImpl(this))))
	call:void(XmlTextReaderImpl::Throw, ldloc:XmlTextReaderImpl(this), ldloc:int32(var_27_1C1), ldstr:string("Unexpected end of file while parsing {0} has occurred."), ldstr:string("PI"))
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

		// Token: 0x060002E3 RID: 739 RVA: 0x0000B6AC File Offset: 0x000098AC
		private bool ParseComment()
		{
			if (this.ignoreComments)
			{
				XmlTextReaderImpl.ParsingMode parsingMode = this.parsingMode;
				this.parsingMode = XmlTextReaderImpl.ParsingMode.SkipNode;
				this.ParseCDataOrComment(XmlNodeType.Comment);
				this.parsingMode = parsingMode;
			}
			this.ParseCDataOrComment(XmlNodeType.Comment);
			return true;
		}

		// Token: 0x060002E4 RID: 740 RVA: 0x0000B6E8 File Offset: 0x000098E8
		private void ParseCData()
		{
			this.ParseCDataOrComment(XmlNodeType.CDATA);
		}

		// Token: 0x060002E5 RID: 741 RVA: 0x0000B6FC File Offset: 0x000098FC
		private void ParseCDataOrComment(XmlNodeType type)
		{
			if (this.parsingMode != XmlTextReaderImpl.ParsingMode.Full)
			{
				return;
			}
			XmlTextReaderImpl.NodeData nodeData = this.curNode;
			int lineNo = this.ps.lineNo;
			long num = 0L;
			int num2;
			nodeData.SetLineInfo(lineNo, num2);
			bool flag = this.ParseCDataOrComment(type, num2, (int)num);
			XmlTextReaderImpl.NodeData nodeData2 = this.curNode;
			XmlTextReaderImpl.ParsingState parsingState = this.ps;
		}

		// Token: 0x060002E6 RID: 742 RVA: 0x0000B794 File Offset: 0x00009994
		private bool ParseCDataOrComment(XmlNodeType type, [Out] int outStartPos, [Out] int outEndPos)
		{
			/*
An exception occurred when decompiling this method (060002E6)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean System.Xml.XmlTextReaderImpl::ParseCDataOrComment(System.Xml.XmlNodeType,System.Int32,System.Int32)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_01C8:
	call:void(XmlTextReaderImpl::Throw, ldloc:XmlTextReaderImpl(this), ldstr:string("Unexpected end of file while parsing {0} has occurred."), ldstr:string("Unexpected end of file while parsing {0} has occurred."))
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

		// Token: 0x060002E7 RID: 743 RVA: 0x0000B978 File Offset: 0x00009B78
		private bool ParseDoctypeDecl()
		{
			/*
An exception occurred when decompiling this method (060002E7)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean System.Xml.XmlTextReaderImpl::ParseDoctypeDecl()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0112:
	stloc:int32(var_21_11D, ldfld:int32(ParsingState::charPos, ldfld:ParsingState[exp:valuetype System.Xml.XmlTextReaderImpl/ParsingState&](XmlTextReaderImpl::ps, ldloc:XmlTextReaderImpl(this))))
}

   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1852
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1878
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1878
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1846
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

		// Token: 0x060002E8 RID: 744 RVA: 0x0000BAA4 File Offset: 0x00009CA4
		private void ParseDtd()
		{
			IDtdParser dtdParser = DtdParser.Create();
		}

		// Token: 0x060002E9 RID: 745 RVA: 0x0000BB0C File Offset: 0x00009D0C
		private void SkipDtd()
		{
			int num;
			this.ps.charPos = num;
			Stream stream = this.ps.stream;
			int charsUsed = this.ps.charsUsed;
			if (this.ReadData() != 0)
			{
				int charPos = this.ps.charPos;
				return;
			}
			this.Throw("SYSTEM");
		}

		// Token: 0x060002EA RID: 746 RVA: 0x0000BC70 File Offset: 0x00009E70
		private void SkipPublicOrSystemIdLiteral()
		{
			Stream stream = this.ps.stream;
			this.ThrowUnexpectedToken("\"", "'");
			int charPos = this.ps.charPos;
			this.ps.charPos = charPos;
		}

		// Token: 0x060002EB RID: 747 RVA: 0x0000BCB4 File Offset: 0x00009EB4
		private void SkipUntil(char stopChar, bool recognizeLiterals)
		{
			XmlTextReaderImpl.ParsingState parsingState = this.ps;
			int charPos = this.ps.charPos;
			XmlCharType xmlCharType = this.xmlCharType;
			this.ps.charPos = charPos;
		}

		// Token: 0x060002EC RID: 748 RVA: 0x0000BE64 File Offset: 0x0000A064
		private int EatWhitespaces(StringBuilder sb)
		{
			int charPos = this.ps.charPos;
			XmlTextReaderImpl.ParsingState parsingState = this.ps;
			int lineNo = this.ps.lineNo;
			this.ps.lineNo = lineNo;
			this.ps.baseUriStr = charPos;
			return "Unexpected end of file has occurred.";
		}

		// Token: 0x060002ED RID: 749 RVA: 0x0000BFB4 File Offset: 0x0000A1B4
		private int ParseCharRefInline(int startPos, [Out] int charCount, [Out] XmlTextReaderImpl.EntityType entityType)
		{
			Stream stream = this.ps.stream;
			int num;
			return num;
		}

		// Token: 0x060002EE RID: 750 RVA: 0x0000BFE4 File Offset: 0x0000A1E4
		private int ParseNumericCharRef(bool expand, StringBuilder internalSubsetBuilder, [Out] XmlTextReaderImpl.EntityType entityType)
		{
			/*
An exception occurred when decompiling this method (060002EE)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Int32 System.Xml.XmlTextReaderImpl::ParseNumericCharRef(System.Boolean,System.Text.StringBuilder,System.Xml.XmlTextReaderImpl/EntityType)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	call:void(XmlTextReaderImpl::Throw, ldloc:XmlTextReaderImpl(this), ldstr:string("Unexpected end of file while parsing {0} has occurred."))
	stfld:int32(ParsingState::charPos, ldfld:ParsingState[exp:valuetype System.Xml.XmlTextReaderImpl/ParsingState&](XmlTextReaderImpl::ps, ldloc:XmlTextReaderImpl(this)), ldloc:int32(var_0_01))
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

		// Token: 0x060002EF RID: 751 RVA: 0x0000C020 File Offset: 0x0000A220
		private int ParseNumericCharRefInline(int startPos, bool expand, StringBuilder internalSubsetBuilder, [Out] int charCount, [Out] XmlTextReaderImpl.EntityType entityType)
		{
			XmlTextReaderImpl.ParsingState parsingState = this.ps;
			return "'{0}', hexadecimal value {1}, is an invalid character.";
		}

		// Token: 0x060002F0 RID: 752 RVA: 0x0000C19C File Offset: 0x0000A39C
		private int ParseNamedCharRef(bool expand, StringBuilder internalSubsetBuilder)
		{
			int charPos = this.ps.charPos;
			int num = this.ReadData();
			while (num != 0)
			{
			}
			return num;
		}

		// Token: 0x060002F1 RID: 753 RVA: 0x0000C1C4 File Offset: 0x0000A3C4
		private int ParseNamedCharRefInline(int startPos, bool expand, StringBuilder internalSubsetBuilder)
		{
			/*
An exception occurred when decompiling this method (060002F1)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Int32 System.Xml.XmlTextReaderImpl::ParseNamedCharRefInline(System.Int32,System.Boolean,System.Text.StringBuilder)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:int32(var_10_60, ldfld:int32(ParsingState::charPos, ldfld:ParsingState[exp:valuetype System.Xml.XmlTextReaderImpl/ParsingState&](XmlTextReaderImpl::ps, ldloc:XmlTextReaderImpl(this))))
	stfld:Stream(ParsingState::stream, ldfld:ParsingState[exp:valuetype System.Xml.XmlTextReaderImpl/ParsingState&](XmlTextReaderImpl::ps, ldloc:XmlTextReaderImpl(this)), ldloc:int32[exp:Stream](var_8_4D))
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

		// Token: 0x060002F2 RID: 754 RVA: 0x0000C240 File Offset: 0x0000A440
		private int ParseName()
		{
			int num;
			return num;
		}

		// Token: 0x060002F3 RID: 755 RVA: 0x0000C250 File Offset: 0x0000A450
		private int ParseQName([Out] int colonPos)
		{
			long num = 0L;
			return this.ParseQName(true, (int)num, colonPos);
		}

		// Token: 0x060002F4 RID: 756 RVA: 0x0000C268 File Offset: 0x0000A468
		private int ParseQName(bool isQName, int startOffset, [Out] int colonPos)
		{
			int charPos = this.ps.charPos;
			XmlCharType xmlCharType = this.xmlCharType;
			XmlTextReaderImpl.ParsingState parsingState = this.ps;
			int charsUsed = this.ps.charsUsed;
			int num = this.ReadData();
			int charPos2 = this.ps.charPos;
			while (num != 0)
			{
			}
			return num;
		}

		// Token: 0x060002F5 RID: 757 RVA: 0x0000C350 File Offset: 0x0000A550
		private bool ReadDataInName(int pos)
		{
			/*
An exception occurred when decompiling this method (060002F5)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean System.Xml.XmlTextReaderImpl::ReadDataInName(System.Int32)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:int32(var_0_0B, ldfld:int32(ParsingState::charPos, ldfld:ParsingState[exp:valuetype System.Xml.XmlTextReaderImpl/ParsingState&](XmlTextReaderImpl::ps, ldloc:XmlTextReaderImpl(this))))
	stloc:int32(var_1_12, call:int32(XmlTextReaderImpl::ReadData, ldloc:XmlTextReaderImpl(this)))
	stloc:int32(var_2_1E, ldfld:int32(ParsingState::charPos, ldfld:ParsingState[exp:valuetype System.Xml.XmlTextReaderImpl/ParsingState&](XmlTextReaderImpl::ps, ldloc:XmlTextReaderImpl(this))))
	stfld:int32(int32::m_value, ldloc:int32[exp:int32&](pos), ldloc:int32(var_2_1E))
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

		// Token: 0x060002F6 RID: 758 RVA: 0x0000C384 File Offset: 0x0000A584
		private string ParseEntityName()
		{
			/*
An exception occurred when decompiling this method (060002F6)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.String System.Xml.XmlTextReaderImpl::ParseEntityName()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:ParsingState(var_2_08, ldfld:ParsingState(XmlTextReaderImpl::ps, ldloc:XmlTextReaderImpl(this)))
	stloc:XmlNameTable(var_3_0F, ldfld:XmlNameTable(XmlTextReaderImpl::nameTable, ldloc:XmlTextReaderImpl(this)))
	stloc:int32(var_4_1B, ldfld:int32(ParsingState::charPos, ldfld:ParsingState[exp:valuetype System.Xml.XmlTextReaderImpl/ParsingState&](XmlTextReaderImpl::ps, ldloc:XmlTextReaderImpl(this))))
	call:void(XmlTextReaderImpl::Throw, ldloc:XmlTextReaderImpl(this), ldstr:string("An error occurred while parsing EntityName."))
	call:void(XmlTextReaderImpl::Throw, ldloc:XmlTextReaderImpl(this), ldstr:string("An error occurred while parsing EntityName."))
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

		// Token: 0x060002F7 RID: 759 RVA: 0x0000C3C8 File Offset: 0x0000A5C8
		private XmlTextReaderImpl.NodeData AddNode(int nodeIndex, int nodeDepth)
		{
			if (this.nodes.prefix != null)
			{
			}
			XmlTextReaderImpl.NodeData nodeData;
			return nodeData;
		}

		// Token: 0x060002F8 RID: 760 RVA: 0x0000C3E4 File Offset: 0x0000A5E4
		private XmlTextReaderImpl.NodeData AllocNode(int nodeIndex, int nodeDepth)
		{
			string localName = this.nodes.localName;
			XmlTextReaderImpl.NodeData[] array = this.nodes;
			string localName2 = array.localName;
			if (array.prefix == null)
			{
				XmlTextReaderImpl.NodeData[] array2 = this.nodes;
			}
			throw new ArrayTypeMismatchException();
		}

		// Token: 0x060002F9 RID: 761 RVA: 0x0000C420 File Offset: 0x0000A620
		private XmlTextReaderImpl.NodeData AddAttributeNoChecks(string name, int attrDepth)
		{
			int num = this.index;
			int num2 = this.attrCount;
			XmlTextReaderImpl.NodeData[] array = this.nodes;
			XmlTextReaderImpl.NodeData nodeData = this.AllocNode(num, attrDepth);
			XmlNameTable xmlNameTable = this.nameTable;
			int num3 = this.attrCount;
			this.attrCount = num3;
			return nodeData;
		}

		// Token: 0x060002FA RID: 762 RVA: 0x0000C464 File Offset: 0x0000A664
		private XmlTextReaderImpl.NodeData AddAttribute(int endNamePos, int colonPos)
		{
			if (this.supportNamespaces)
			{
				string text = this.lastPrefix;
				int num = 1;
				this.attrNeedNamespaceLookup = num != 0;
				int charPos = this.ps.charPos;
				int stringLength = text._stringLength;
				XmlTextReaderImpl.ParsingState parsingState = this.ps;
				XmlNameTable xmlNameTable = this.nameTable;
				XmlTextReaderImpl.ParsingState parsingState2 = this.ps;
				string text2 = this.lastPrefix;
			}
			XmlNameTable xmlNameTable2 = this.nameTable;
			int charPos2 = this.ps.charPos;
			XmlTextReaderImpl.ParsingState parsingState3 = this.ps;
			XmlNameTable xmlNameTable3 = this.nameTable;
			XmlTextReaderImpl.ParsingState parsingState4 = this.ps;
			XmlNameTable xmlNameTable4 = this.nameTable;
			this.lastPrefix = xmlNameTable3;
			XmlTextReaderImpl.ParsingState parsingState5 = this.ps;
			XmlTextReaderImpl.NodeData nodeData;
			return nodeData;
		}

		// Token: 0x060002FB RID: 763 RVA: 0x0000C504 File Offset: 0x0000A704
		private XmlTextReaderImpl.NodeData AddAttribute(string localName, string prefix, string nameWPrefix)
		{
			int num = this.index;
			int num2 = this.attrCount;
			XmlTextReaderImpl.NodeData[] array = this.nodes;
			long num3 = 0L;
			char c = localName[(int)num3];
			int num4 = this.attrHashtable;
			int num5 = this.attrDuplWalkCount;
			int num6 = this.index;
			int num7 = this.attrCount;
			XmlTextReaderImpl.NodeData[] array2 = this.nodes;
			XmlTextReaderImpl.NodeData nodeData;
			string localName2 = nodeData.localName;
			string prefix2 = array2.prefix;
			int num8 = this.index;
			int num9 = this.attrCount;
			this.attrHashtable = num8;
			int num10 = this.attrCount;
			this.attrCount = num10;
			return nodeData;
		}

		// Token: 0x060002FC RID: 764 RVA: 0x0000C5A8 File Offset: 0x0000A7A8
		private void PopElementContext()
		{
			XmlNamespaceManager xmlNamespaceManager = this.namespaceManager;
			if (this.curNode.xmlContextPushed)
			{
				XmlTextReaderImpl.XmlContext previousContext = this.xmlContext.previousContext;
				this.xmlContext = previousContext;
			}
		}

		// Token: 0x060002FD RID: 765 RVA: 0x0000C5DC File Offset: 0x0000A7DC
		private void OnNewLine(int pos)
		{
			int lineNo = this.ps.lineNo;
			this.ps.lineNo = lineNo;
		}

		// Token: 0x060002FE RID: 766 RVA: 0x0000C604 File Offset: 0x0000A804
		private void OnEof()
		{
			string prefix = this.nodes.prefix;
			this.curNode = prefix;
			XmlTextReaderImpl.NodeData nodeData = this.curNode;
			int lineNo = this.ps.lineNo;
			int num;
			nodeData.SetLineInfo(lineNo, num);
			int num2 = 11;
			int num3 = 3;
			this.parsingFunction = (XmlTextReaderImpl.ParsingFunction)num2;
			this.readState = (ReadState)num3;
		}

		// Token: 0x060002FF RID: 767 RVA: 0x0000C658 File Offset: 0x0000A858
		private string LookupNamespace(XmlTextReaderImpl.NodeData node)
		{
			/*
An exception occurred when decompiling this method (060002FF)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.String System.Xml.XmlTextReaderImpl::LookupNamespace(System.Xml.XmlTextReaderImpl/NodeData)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0011:
	stloc:string(var_2_17, ldfld:string(NodeData::prefix, ldloc:NodeData(node)))
	stloc:int32(var_3_1E, callgetter:int32(NodeData::get_LineNo, ldloc:NodeData(node)))
	stloc:int32(var_4_25, callgetter:int32(NodeData::get_LinePos, ldloc:NodeData(node)))
	call:void(XmlTextReaderImpl::Throw, ldloc:XmlTextReaderImpl(this), ldstr:string("'{0}' is an undeclared prefix."), ldloc:string(var_2_17), ldloc:int32(var_3_1E), ldloc:int32(var_4_25))
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

		// Token: 0x06000300 RID: 768 RVA: 0x0000C69C File Offset: 0x0000A89C
		private void AddNamespace(string prefix, string uri, XmlTextReaderImpl.NodeData attr)
		{
			/*
An exception occurred when decompiling this method (06000300)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Void System.Xml.XmlTextReaderImpl::AddNamespace(System.String,System.String,System.Xml.XmlTextReaderImpl/NodeData)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_007B:
	stloc:LineInfo(var_12_81, ldfld:LineInfo(NodeData::lineInfo2, ldloc:NodeData(attr)))
	stloc:char(var_13_89, ldfld:char(NodeData::quoteChar, ldloc:NodeData(attr)))
	stloc:LineInfo(var_14_91, ldfld:LineInfo(NodeData::lineInfo, ldloc:NodeData(attr)))
	stloc:LineInfo(var_15_99, ldfld:LineInfo(NodeData::lineInfo2, ldloc:NodeData(attr)))
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

		// Token: 0x06000301 RID: 769 RVA: 0x0000C748 File Offset: 0x0000A948
		private void ResetAttributes()
		{
			if (this.fullAttrCleanup)
			{
				int num = this.index;
				int num2 = this.attrCount;
				XmlTextReaderImpl.NodeData[] array = this.nodes;
			}
		}

		// Token: 0x06000302 RID: 770 RVA: 0x0000C774 File Offset: 0x0000A974
		private void FullAttributeCleanup()
		{
			int num = this.index;
			int num2 = this.attrCount;
			XmlTextReaderImpl.NodeData[] array = this.nodes;
		}

		// Token: 0x06000303 RID: 771 RVA: 0x0000C798 File Offset: 0x0000A998
		private void PushXmlContext()
		{
			XmlTextReaderImpl.XmlContext xmlContext = this.xmlContext;
			this.curNode.xmlContextPushed = true;
		}

		// Token: 0x06000304 RID: 772 RVA: 0x0000C7B8 File Offset: 0x0000A9B8
		private void PopXmlContext()
		{
			XmlTextReaderImpl.XmlContext xmlContext = this.xmlContext;
			XmlTextReaderImpl.NodeData nodeData = this.curNode;
			XmlTextReaderImpl.XmlContext previousContext = xmlContext.previousContext;
			this.xmlContext = previousContext;
		}

		// Token: 0x06000305 RID: 773 RVA: 0x0000C7E4 File Offset: 0x0000A9E4
		private XmlNodeType GetWhitespaceType()
		{
			WhitespaceHandling whitespaceHandling = this.whitespaceHandling;
			XmlSpace xmlSpace = this.xmlContext.xmlSpace;
			return XmlNodeType.SignificantWhitespace;
		}

		// Token: 0x06000306 RID: 774 RVA: 0x0000C810 File Offset: 0x0000AA10
		private XmlNodeType GetTextNodeType(int orChars)
		{
			return XmlNodeType.Text;
		}

		// Token: 0x06000307 RID: 775 RVA: 0x0000C828 File Offset: 0x0000AA28
		private void PushExternalEntityOrSubset(string publicId, string systemId, Uri baseUri, string entityName)
		{
			bool flag = string.IsNullOrEmpty(publicId);
			XmlResolver xmlResolver = this.xmlResolver;
			XmlResolver xmlResolver2 = this.xmlResolver;
		}

		// Token: 0x06000308 RID: 776 RVA: 0x0000C890 File Offset: 0x0000AA90
		private bool OpenAndPush(Uri uri)
		{
			int num = 1;
			XmlResolver xmlResolver = this.xmlResolver;
			if (num == 0)
			{
			}
			XmlResolver xmlResolver2 = this.xmlResolver;
			if (xmlResolver2 != null)
			{
				this.PushParsingState();
				if (xmlResolver2 != null)
				{
					this.PushParsingState();
				}
			}
			throw new InvalidCastException();
		}

		// Token: 0x06000309 RID: 777 RVA: 0x0000C8CC File Offset: 0x0000AACC
		private bool PushExternalEntity(IDtdEntityInfo entity)
		{
			/*
An exception occurred when decompiling this method (06000309)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean System.Xml.XmlTextReaderImpl::PushExternalEntity(System.Xml.IDtdEntityInfo)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0080:
	stloc:int32(var_14_81, ldc.i4:int32(1))
	stloc:bool(var_15_8B, call:bool(XmlTextReaderImpl::ParseXmlDeclaration, ldloc:XmlTextReaderImpl(this), ldloc:int32[exp:bool](var_14_81)))
	stfld:int32(ParsingState::charPos, ldfld:ParsingState[exp:valuetype System.Xml.XmlTextReaderImpl/ParsingState&](XmlTextReaderImpl::ps, ldloc:XmlTextReaderImpl(this)), ldloc:int32(var_12_7A))
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

		// Token: 0x0600030A RID: 778 RVA: 0x0000C978 File Offset: 0x0000AB78
		private void PushInternalEntity(IDtdEntityInfo entity)
		{
			Encoding encoding = this.ps.encoding;
			this.PushParsingState();
		}

		// Token: 0x0600030B RID: 779 RVA: 0x0000C9CC File Offset: 0x0000ABCC
		private void PopEntity()
		{
			if (this.ps.stream != null)
			{
			}
			this.UnregisterEntity();
			XmlTextReaderImpl.ParsingState[] array = this.parsingStatesStack;
			XmlTextReaderImpl.NodeData nodeData = this.curNode;
			int entityId = this.ps.entityId;
			nodeData.entityId = entityId;
		}

		// Token: 0x0600030C RID: 780 RVA: 0x0000CA10 File Offset: 0x0000AC10
		private void RegisterEntity(IDtdEntityInfo entity)
		{
			if (this.currentEntities != null)
			{
			}
			int num = this.nextEntityId;
			this.ps.entity = entity;
			this.ps.entityId = num;
			if (entity != null)
			{
				if (this.currentEntities == null)
				{
				}
				return;
			}
		}

		// Token: 0x0600030D RID: 781 RVA: 0x0000CA60 File Offset: 0x0000AC60
		private void UnregisterEntity()
		{
			if (this.ps.entity != null)
			{
				Dictionary<IDtdEntityInfo, IDtdEntityInfo> dictionary = this.currentEntities;
				return;
			}
		}

		// Token: 0x0600030E RID: 782 RVA: 0x0000CA84 File Offset: 0x0000AC84
		private void PushParsingState()
		{
			XmlTextReaderImpl.ParsingState[] array = this.parsingStatesStack;
			if (array != null)
			{
				int num = this.parsingStatesStackTop;
				bool appendMode = array.appendMode;
				bool appendMode2 = this.parsingStatesStack.appendMode;
				return;
			}
			int num2 = this.parsingStatesStackTop;
			this.parsingStatesStackTop = num2;
		}

		// Token: 0x0600030F RID: 783 RVA: 0x0000CACC File Offset: 0x0000ACCC
		private void PopParsingState()
		{
			XmlTextReaderImpl.ParsingState[] array = this.parsingStatesStack;
		}

		// Token: 0x06000310 RID: 784 RVA: 0x0000CAE4 File Offset: 0x0000ACE4
		private int IncrementalRead()
		{
			int num = this.incReadLeftEndPos;
			int num2 = this.incReadLeftStartPos;
			IncrementalReadDecoder incrementalReadDecoder = this.incReadDecoder;
			XmlTextReaderImpl.ParsingState parsingState = this.ps;
			int linePos = this.incReadLineInfo.linePos;
			IncrementalReadDecoder incrementalReadDecoder2 = this.incReadDecoder;
			this.incReadLineInfo.linePos = linePos;
			XmlTextReaderImpl.IncrementalReadState incrementalReadState = this.incReadState;
			int charPos = this.ps.charPos;
			if (this.ReadData() == 0)
			{
				this.ThrowUnclosedElements();
			}
			int charPos2 = this.ps.charPos;
			int charPos3 = this.ps.charPos;
			this.ps.charPos = charPos3;
			int charPos4 = this.ps.charPos;
			int lineNo = this.ps.lineNo;
			XmlCharType xmlCharType = this.xmlCharType;
			XmlTextReaderImpl.IncrementalReadState incrementalReadState2 = this.incReadState;
			int num3;
			return num3;
		}

		// Token: 0x06000311 RID: 785 RVA: 0x0000CE5C File Offset: 0x0000B05C
		private void FinishIncrementalRead()
		{
			int num = this.IncrementalRead();
		}

		// Token: 0x06000312 RID: 786 RVA: 0x0000CE70 File Offset: 0x0000B070
		private bool ParseFragmentAttribute()
		{
			XmlTextReaderImpl.NodeData nodeData = this.curNode;
			if (nodeData.type != XmlNodeType.None)
			{
				this.parsingFunction = XmlTextReaderImpl.ParsingFunction.InReadAttributeValue;
			}
			nodeData.type = XmlNodeType.Attribute;
			int charPos = this.ps.charPos;
			this.parsingFunction = XmlTextReaderImpl.ParsingFunction.FragmentAttribute;
			return true;
		}

		// Token: 0x06000313 RID: 787 RVA: 0x0000CEB8 File Offset: 0x0000B0B8
		private bool ParseAttributeValueChunk()
		{
			XmlTextReaderImpl.ParsingState parsingState = this.ps;
			XmlTextReaderImpl.ParsingFunction parsingFunction = this.parsingFunction;
			XmlTextReaderImpl.ParsingFunction parsingFunction2 = this.nextNextParsingFunction;
			IDtdEntityInfo entity = this.ps.entity;
			return "'{0}', hexadecimal value {1}, is an invalid attribute character." != null;
		}

		// Token: 0x06000314 RID: 788 RVA: 0x0000D0C4 File Offset: 0x0000B2C4
		private void ParseXmlDeclarationFragment()
		{
			long num = 0L;
			bool flag = this.ParseXmlDeclaration(num != 0L);
		}

		// Token: 0x06000315 RID: 789 RVA: 0x0000D0E0 File Offset: 0x0000B2E0
		private void ThrowUnexpectedToken(int pos, string expectedToken)
		{
			this.ps.charPos = pos;
		}

		// Token: 0x06000316 RID: 790 RVA: 0x0000D0FC File Offset: 0x0000B2FC
		private void ThrowUnexpectedToken(string expectedToken1)
		{
		}

		// Token: 0x06000317 RID: 791 RVA: 0x0000D10C File Offset: 0x0000B30C
		private void ThrowUnexpectedToken(int pos, string expectedToken1, string expectedToken2)
		{
			this.ps.charPos = pos;
			this.ThrowUnexpectedToken(expectedToken1, expectedToken2);
		}

		// Token: 0x06000318 RID: 792 RVA: 0x0000D130 File Offset: 0x0000B330
		private void ThrowUnexpectedToken(string expectedToken1, string expectedToken2)
		{
			if (this.ParseUnexpectedToken() == null)
			{
				this.Throw("Unexpected end of file has occurred.");
			}
			if (expectedToken2 == null)
			{
				throw new ArrayTypeMismatchException();
			}
			throw new ArrayTypeMismatchException();
		}

		// Token: 0x06000319 RID: 793 RVA: 0x0000D184 File Offset: 0x0000B384
		private string ParseUnexpectedToken(int pos)
		{
			this.ps.charPos = pos;
			return this.ParseUnexpectedToken();
		}

		// Token: 0x0600031A RID: 794 RVA: 0x0000D1A4 File Offset: 0x0000B3A4
		private string ParseUnexpectedToken()
		{
			int charPos = this.ps.charPos;
			Encoding encoding = this.ps.encoding;
			string text;
			return text;
		}

		// Token: 0x0600031B RID: 795 RVA: 0x0000D1D0 File Offset: 0x0000B3D0
		private void ThrowExpectingWhitespace(int pos)
		{
			/*
An exception occurred when decompiling this method (0600031B)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Void System.Xml.XmlTextReaderImpl::ThrowExpectingWhitespace(System.Int32)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	call:void(XmlTextReaderImpl::Throw, ldloc:XmlTextReaderImpl(this), ldloc:int32(pos), ldstr:string("Unexpected end of file has occurred."))
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

		// Token: 0x0600031C RID: 796 RVA: 0x0000D1FC File Offset: 0x0000B3FC
		private int GetIndexOfAttributeWithoutPrefix(string name)
		{
			/*
An exception occurred when decompiling this method (0600031C)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Int32 System.Xml.XmlTextReaderImpl::GetIndexOfAttributeWithoutPrefix(System.String)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_1:
	stloc:int32(var_4_3A, ldfld:int32(XmlTextReaderImpl::index, ldloc:XmlTextReaderImpl(this)))
	stloc:int32(var_5_42, ldfld:int32(XmlTextReaderImpl::attrCount, ldloc:XmlTextReaderImpl(this)))
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

		// Token: 0x0600031D RID: 797 RVA: 0x0000D24C File Offset: 0x0000B44C
		private int GetIndexOfAttributeWithPrefix(string name)
		{
			/*
An exception occurred when decompiling this method (0600031D)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Int32 System.Xml.XmlTextReaderImpl::GetIndexOfAttributeWithPrefix(System.String)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:int32(var_0_0E, ldfld:int32(XmlTextReaderImpl::index, ldloc:XmlTextReaderImpl(this)))
	stloc:int32(var_1_15, ldfld:int32(XmlTextReaderImpl::attrCount, ldloc:XmlTextReaderImpl(this)))
	stloc:class System.Xml.XmlTextReaderImpl/NodeData[](var_2_1C, ldfld:class System.Xml.XmlTextReaderImpl/NodeData[](XmlTextReaderImpl::nodes, ldloc:XmlTextReaderImpl(this)))
	stloc:XmlNameTable(var_3_23, ldfld:XmlNameTable(XmlTextReaderImpl::nameTable, ldloc:XmlTextReaderImpl(this)))
	stloc:string(var_4_2A, ldfld:string(NodeData::prefix, ldloc:class System.Xml.XmlTextReaderImpl/NodeData[][exp:NodeData](var_2_1C)))
	stloc:int32(var_7_32, ldfld:int32(XmlTextReaderImpl::index, ldloc:XmlTextReaderImpl(this)))
	stloc:int32(var_8_3A, ldfld:int32(XmlTextReaderImpl::attrCount, ldloc:XmlTextReaderImpl(this)))
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

		// Token: 0x0600031E RID: 798 RVA: 0x0000D294 File Offset: 0x0000B494
		private bool ZeroEndingStream(int pos)
		{
			/*
An exception occurred when decompiling this method (0600031E)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean System.Xml.XmlTextReaderImpl::ZeroEndingStream(System.Int32)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_2:
	stloc:int32(var_2_43, ldfld:int32(ParsingState::charsUsed, ldfld:ParsingState[exp:valuetype System.Xml.XmlTextReaderImpl/ParsingState&](XmlTextReaderImpl::ps, ldloc:XmlTextReaderImpl(this))))
	stfld:int32(ParsingState::charsUsed, ldfld:ParsingState[exp:valuetype System.Xml.XmlTextReaderImpl/ParsingState&](XmlTextReaderImpl::ps, ldloc:XmlTextReaderImpl(this)), ldloc:int32(var_2_43))
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

		// Token: 0x0600031F RID: 799 RVA: 0x0000D2F4 File Offset: 0x0000B4F4
		private void ParseDtdFromParserContext()
		{
			IDtdParser dtdParser = DtdParser.Create();
			XmlParserContext xmlParserContext = this.fragmentParserContext;
			string baseURI = xmlParserContext._baseURI;
			string docTypeName = xmlParserContext._docTypeName;
			string pubId = xmlParserContext._pubId;
			string sysId = xmlParserContext._sysId;
			string internalSubset = xmlParserContext._internalSubset;
		}

		// Token: 0x06000320 RID: 800 RVA: 0x0000D36C File Offset: 0x0000B56C
		private bool MoveToNextContentNode(bool moveIfOnContentNode)
		{
			/*
An exception occurred when decompiling this method (06000320)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean System.Xml.XmlTextReaderImpl::MoveToNextContentNode(System.Boolean)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:XmlNodeType(var_0_0B, ldfld:XmlNodeType(NodeData::type, ldfld:NodeData(XmlTextReaderImpl::curNode, ldloc:XmlTextReaderImpl(this))))
	stloc:XmlReader(var_1_12, ldfld:XmlReader(XmlTextReaderImpl::outerReader, ldloc:XmlTextReaderImpl(this)))
	stloc:XmlReader(var_2_19, ldfld:XmlReader(XmlTextReaderImpl::outerReader, ldloc:XmlTextReaderImpl(this)))
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

		// Token: 0x170000A3 RID: 163
		// (get) Token: 0x06000321 RID: 801 RVA: 0x0000D394 File Offset: 0x0000B594
		internal override IDtdInfo DtdInfo
		{
			get
			{
				return this.dtdInfo;
			}
		}

		// Token: 0x06000322 RID: 802 RVA: 0x0000D3A8 File Offset: 0x0000B5A8
		internal void SetDtdInfo(IDtdInfo newDtdInfo)
		{
			this.dtdInfo = newDtdInfo;
			if (newDtdInfo != null)
			{
				if (this.validatingReaderCompatFlag)
				{
					return;
				}
				if (!this.v1Compat)
				{
					return;
				}
			}
		}

		// Token: 0x170000A4 RID: 164
		// (set) Token: 0x06000323 RID: 803 RVA: 0x0000D3E4 File Offset: 0x0000B5E4
		internal bool XmlValidatingReaderCompatibilityMode
		{
			set
			{
				XmlNameTable xmlNameTable = this.nameTable;
				XmlNameTable xmlNameTable2 = this.nameTable;
				XmlNameTable xmlNameTable3 = this.nameTable;
			}
		}

		// Token: 0x06000324 RID: 804 RVA: 0x0000D408 File Offset: 0x0000B608
		private bool AddDefaultAttributeDtd(IDtdDefaultAttributeInfo defAttrInfo, bool definedInDtd, XmlTextReaderImpl.NodeData[] nameSortedNodeData)
		{
			/*
An exception occurred when decompiling this method (06000324)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean System.Xml.XmlTextReaderImpl::AddDefaultAttributeDtd(System.Xml.IDtdDefaultAttributeInfo,System.Boolean,System.Xml.XmlTextReaderImpl/NodeData[])

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_005B:
	stfld:object(NodeData::typedValue, ldloc:NodeData(var_6), ldloc:IDtdDefaultAttributeInfo[exp:object](defAttrInfo))
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

		// Token: 0x06000325 RID: 805 RVA: 0x0000D478 File Offset: 0x0000B678
		private XmlTextReaderImpl.NodeData AddDefaultAttributeInternal(string localName, string ns, string prefix, string value, int lineNo, int linePos, int valueLineNo, int valueLinePos, bool isXmlAttribute)
		{
			int stringLength = prefix._stringLength;
			XmlTextReaderImpl.NodeData nodeData = this.AddAttribute(localName, prefix, prefix);
			if (ns != null)
			{
				nodeData.ns = ns;
			}
			nodeData.SetValue(value);
			int num = 1;
			nodeData.isEmptyOrDefault = num != 0;
			string prefix2 = nodeData.prefix;
			int num4;
			if (prefix2._stringLength != 0)
			{
				string xmlNs = this.XmlNs;
				bool flag = Ref.Equal(prefix2, xmlNs);
				this.OnNamespaceDecl(nodeData);
				if (this.attrNeedNamespaceLookup)
				{
					goto IL_00F2;
				}
				int num2 = this.attrCount;
				string localName2 = nodeData.localName;
				bool flag2 = this.nodes.prefix.Equals(localName2);
				XmlNamespaceManager xmlNamespaceManager = this.namespaceManager;
				XmlTextReaderImpl.NodeData[] array = this.nodes;
				int num3 = this.index;
				num4 = this.attrCount;
			}
			string localName3 = nodeData.localName;
			string xmlNs2 = this.XmlNs;
			bool flag3 = Ref.Equal(localName3, xmlNs2);
			this.OnDefaultNamespaceDecl(nodeData);
			if (!this.attrNeedNamespaceLookup)
			{
				string prefix3 = this.nodes.prefix;
				if (num4 == 0)
				{
					string defaultNamespace = this.xmlContext.defaultNamespace;
					this.OnXmlReservedAttribute(nodeData);
				}
			}
			IL_00F2:
			int num5 = 1;
			this.fullAttrCleanup = num5 != 0;
			return nodeData;
		}

		// Token: 0x170000A5 RID: 165
		// (set) Token: 0x06000326 RID: 806 RVA: 0x0000D584 File Offset: 0x0000B784
		internal bool DisableUndeclaredEntityCheck
		{
			set
			{
			}
		}

		// Token: 0x06000327 RID: 807 RVA: 0x0000D594 File Offset: 0x0000B794
		private void RegisterConsumedCharacters(long characters, bool inEntityReference)
		{
			long num = this.maxCharactersInDocument;
			long num2 = this.charactersInDocument;
			long num3 = this.maxCharactersFromEntities;
			long num4 = this.charactersFromEntities;
		}

		// Token: 0x06000328 RID: 808 RVA: 0x0000D5D0 File Offset: 0x0000B7D0
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

		// Token: 0x06000329 RID: 809 RVA: 0x0000D5EC File Offset: 0x0000B7EC
		internal static void StripSpaces(char[] value, int index, int len)
		{
		}

		// Token: 0x0600032A RID: 810 RVA: 0x0000D608 File Offset: 0x0000B808
		internal static void BlockCopyChars(char[] src, int srcOffset, char[] dst, int dstOffset, int count)
		{
			Buffer.BlockCopy(src, srcOffset, dst, dstOffset, count);
		}

		// Token: 0x0600032B RID: 811 RVA: 0x0000D620 File Offset: 0x0000B820
		internal static void BlockCopy(byte[] src, int srcOffset, byte[] dst, int dstOffset, int count)
		{
			Buffer.BlockCopy(src, srcOffset, dst, dstOffset, count);
		}

		// Token: 0x040000FB RID: 251
		private XmlTextReaderImpl.LaterInitParam laterInitParam;

		// Token: 0x040000FC RID: 252
		private XmlCharType xmlCharType;

		// Token: 0x040000FD RID: 253
		private XmlTextReaderImpl.ParsingState ps;

		// Token: 0x040000FE RID: 254
		private XmlTextReaderImpl.ParsingFunction parsingFunction;

		// Token: 0x040000FF RID: 255
		private XmlTextReaderImpl.ParsingFunction nextParsingFunction;

		// Token: 0x04000100 RID: 256
		private XmlTextReaderImpl.ParsingFunction nextNextParsingFunction;

		// Token: 0x04000101 RID: 257
		private XmlTextReaderImpl.NodeData[] nodes;

		// Token: 0x04000102 RID: 258
		private XmlTextReaderImpl.NodeData curNode;

		// Token: 0x04000103 RID: 259
		private int index;

		// Token: 0x04000104 RID: 260
		private int curAttrIndex;

		// Token: 0x04000105 RID: 261
		private int attrCount;

		// Token: 0x04000106 RID: 262
		private int attrHashtable;

		// Token: 0x04000107 RID: 263
		private int attrDuplWalkCount;

		// Token: 0x04000108 RID: 264
		private bool attrNeedNamespaceLookup;

		// Token: 0x04000109 RID: 265
		private bool fullAttrCleanup;

		// Token: 0x0400010A RID: 266
		private XmlTextReaderImpl.NodeData[] attrDuplSortingArray;

		// Token: 0x0400010B RID: 267
		private XmlNameTable nameTable;

		// Token: 0x0400010C RID: 268
		private bool nameTableFromSettings;

		// Token: 0x0400010D RID: 269
		private XmlResolver xmlResolver;

		// Token: 0x0400010E RID: 270
		private string url;

		// Token: 0x0400010F RID: 271
		private bool normalize;

		// Token: 0x04000110 RID: 272
		private bool supportNamespaces;

		// Token: 0x04000111 RID: 273
		private WhitespaceHandling whitespaceHandling;

		// Token: 0x04000112 RID: 274
		private DtdProcessing dtdProcessing;

		// Token: 0x04000113 RID: 275
		private EntityHandling entityHandling;

		// Token: 0x04000114 RID: 276
		private bool ignorePIs;

		// Token: 0x04000115 RID: 277
		private bool ignoreComments;

		// Token: 0x04000116 RID: 278
		private bool checkCharacters;

		// Token: 0x04000117 RID: 279
		private int lineNumberOffset;

		// Token: 0x04000118 RID: 280
		private int linePositionOffset;

		// Token: 0x04000119 RID: 281
		private bool closeInput;

		// Token: 0x0400011A RID: 282
		private long maxCharactersInDocument;

		// Token: 0x0400011B RID: 283
		private long maxCharactersFromEntities;

		// Token: 0x0400011C RID: 284
		private bool v1Compat;

		// Token: 0x0400011D RID: 285
		private XmlNamespaceManager namespaceManager;

		// Token: 0x0400011E RID: 286
		private string lastPrefix;

		// Token: 0x0400011F RID: 287
		private XmlTextReaderImpl.XmlContext xmlContext;

		// Token: 0x04000120 RID: 288
		private XmlTextReaderImpl.ParsingState[] parsingStatesStack;

		// Token: 0x04000121 RID: 289
		private int parsingStatesStackTop;

		// Token: 0x04000122 RID: 290
		private string reportedBaseUri;

		// Token: 0x04000123 RID: 291
		private Encoding reportedEncoding;

		// Token: 0x04000124 RID: 292
		private IDtdInfo dtdInfo;

		// Token: 0x04000125 RID: 293
		private XmlNodeType fragmentType;

		// Token: 0x04000126 RID: 294
		private XmlParserContext fragmentParserContext;

		// Token: 0x04000127 RID: 295
		private bool fragment;

		// Token: 0x04000128 RID: 296
		private IncrementalReadDecoder incReadDecoder;

		// Token: 0x04000129 RID: 297
		private XmlTextReaderImpl.IncrementalReadState incReadState;

		// Token: 0x0400012A RID: 298
		private LineInfo incReadLineInfo;

		// Token: 0x0400012B RID: 299
		private int incReadDepth;

		// Token: 0x0400012C RID: 300
		private int incReadLeftStartPos;

		// Token: 0x0400012D RID: 301
		private int incReadLeftEndPos;

		// Token: 0x0400012E RID: 302
		private int attributeValueBaseEntityId;

		// Token: 0x0400012F RID: 303
		private bool emptyEntityInAttributeResolved;

		// Token: 0x04000130 RID: 304
		private IValidationEventHandling validationEventHandling;

		// Token: 0x04000131 RID: 305
		private XmlTextReaderImpl.OnDefaultAttributeUseDelegate onDefaultAttributeUse;

		// Token: 0x04000132 RID: 306
		private bool validatingReaderCompatFlag;

		// Token: 0x04000133 RID: 307
		private bool addDefaultAttributesAndNormalize;

		// Token: 0x04000134 RID: 308
		private StringBuilder stringBuilder;

		// Token: 0x04000135 RID: 309
		private bool rootElementParsed;

		// Token: 0x04000136 RID: 310
		private bool standalone;

		// Token: 0x04000137 RID: 311
		private int nextEntityId;

		// Token: 0x04000138 RID: 312
		private XmlTextReaderImpl.ParsingMode parsingMode;

		// Token: 0x04000139 RID: 313
		private ReadState readState;

		// Token: 0x0400013A RID: 314
		private IDtdEntityInfo lastEntity;

		// Token: 0x0400013B RID: 315
		private bool afterResetState;

		// Token: 0x0400013C RID: 316
		private int documentStartBytePos;

		// Token: 0x0400013D RID: 317
		private int readValueOffset;

		// Token: 0x0400013E RID: 318
		private long charactersInDocument;

		// Token: 0x0400013F RID: 319
		private long charactersFromEntities;

		// Token: 0x04000140 RID: 320
		private Dictionary<IDtdEntityInfo, IDtdEntityInfo> currentEntities;

		// Token: 0x04000141 RID: 321
		private bool disableUndeclaredEntityCheck;

		// Token: 0x04000142 RID: 322
		private XmlReader outerReader;

		// Token: 0x04000143 RID: 323
		private bool xmlResolverIsSet;

		// Token: 0x04000144 RID: 324
		private string Xml;

		// Token: 0x04000145 RID: 325
		private string XmlNs;

		// Token: 0x04000146 RID: 326
		private Task<Tuple<int, int, int, bool>> parseText_dummyTask;

		// Token: 0x0200003E RID: 62
		private enum ParsingFunction
		{
			// Token: 0x04000148 RID: 328
			ElementContent,
			// Token: 0x04000149 RID: 329
			NoData,
			// Token: 0x0400014A RID: 330
			OpenUrl,
			// Token: 0x0400014B RID: 331
			SwitchToInteractive,
			// Token: 0x0400014C RID: 332
			SwitchToInteractiveXmlDecl,
			// Token: 0x0400014D RID: 333
			DocumentContent,
			// Token: 0x0400014E RID: 334
			MoveToElementContent,
			// Token: 0x0400014F RID: 335
			PopElementContext,
			// Token: 0x04000150 RID: 336
			PopEmptyElementContext,
			// Token: 0x04000151 RID: 337
			ResetAttributesRootLevel,
			// Token: 0x04000152 RID: 338
			Error,
			// Token: 0x04000153 RID: 339
			Eof,
			// Token: 0x04000154 RID: 340
			ReaderClosed,
			// Token: 0x04000155 RID: 341
			EntityReference,
			// Token: 0x04000156 RID: 342
			InIncrementalRead,
			// Token: 0x04000157 RID: 343
			FragmentAttribute,
			// Token: 0x04000158 RID: 344
			ReportEndEntity,
			// Token: 0x04000159 RID: 345
			AfterResolveEntityInContent,
			// Token: 0x0400015A RID: 346
			AfterResolveEmptyEntityInContent,
			// Token: 0x0400015B RID: 347
			XmlDeclarationFragment,
			// Token: 0x0400015C RID: 348
			GoToEof,
			// Token: 0x0400015D RID: 349
			PartialTextValue,
			// Token: 0x0400015E RID: 350
			InReadAttributeValue,
			// Token: 0x0400015F RID: 351
			InReadValueChunk,
			// Token: 0x04000160 RID: 352
			InReadContentAsBinary,
			// Token: 0x04000161 RID: 353
			InReadElementContentAsBinary
		}

		// Token: 0x0200003F RID: 63
		private enum ParsingMode
		{
			// Token: 0x04000163 RID: 355
			Full,
			// Token: 0x04000164 RID: 356
			SkipNode,
			// Token: 0x04000165 RID: 357
			SkipContent
		}

		// Token: 0x02000040 RID: 64
		private enum EntityType
		{
			// Token: 0x04000167 RID: 359
			CharacterDec,
			// Token: 0x04000168 RID: 360
			CharacterHex,
			// Token: 0x04000169 RID: 361
			CharacterNamed,
			// Token: 0x0400016A RID: 362
			Expanded,
			// Token: 0x0400016B RID: 363
			Skipped,
			// Token: 0x0400016C RID: 364
			FakeExpanded,
			// Token: 0x0400016D RID: 365
			Unexpanded,
			// Token: 0x0400016E RID: 366
			ExpandedInAttribute
		}

		// Token: 0x02000041 RID: 65
		private enum EntityExpandType
		{
			// Token: 0x04000170 RID: 368
			All,
			// Token: 0x04000171 RID: 369
			OnlyGeneral,
			// Token: 0x04000172 RID: 370
			OnlyCharacter
		}

		// Token: 0x02000042 RID: 66
		private enum IncrementalReadState
		{
			// Token: 0x04000174 RID: 372
			Text,
			// Token: 0x04000175 RID: 373
			StartTag,
			// Token: 0x04000176 RID: 374
			PI,
			// Token: 0x04000177 RID: 375
			CDATA,
			// Token: 0x04000178 RID: 376
			Comment,
			// Token: 0x04000179 RID: 377
			Attributes,
			// Token: 0x0400017A RID: 378
			AttributeValue,
			// Token: 0x0400017B RID: 379
			ReadData,
			// Token: 0x0400017C RID: 380
			EndElement,
			// Token: 0x0400017D RID: 381
			End,
			// Token: 0x0400017E RID: 382
			ReadValueChunk_OnCachedValue,
			// Token: 0x0400017F RID: 383
			ReadValueChunk_OnPartialValue,
			// Token: 0x04000180 RID: 384
			ReadContentAsBinary_OnCachedValue,
			// Token: 0x04000181 RID: 385
			ReadContentAsBinary_OnPartialValue,
			// Token: 0x04000182 RID: 386
			ReadContentAsBinary_End
		}

		// Token: 0x02000043 RID: 67
		private class LaterInitParam
		{
			// Token: 0x04000183 RID: 387
			public bool useAsync;

			// Token: 0x04000184 RID: 388
			public Stream inputStream;

			// Token: 0x04000185 RID: 389
			public byte[] inputBytes;

			// Token: 0x04000186 RID: 390
			public int inputByteCount;

			// Token: 0x04000187 RID: 391
			public Uri inputbaseUri;

			// Token: 0x04000188 RID: 392
			public string inputUriStr;

			// Token: 0x04000189 RID: 393
			public XmlResolver inputUriResolver;

			// Token: 0x0400018A RID: 394
			public XmlParserContext inputContext;

			// Token: 0x0400018B RID: 395
			public TextReader inputTextReader;

			// Token: 0x0400018C RID: 396
			public XmlTextReaderImpl.InitInputType initType;
		}

		// Token: 0x02000044 RID: 68
		private enum InitInputType
		{
			// Token: 0x0400018E RID: 398
			UriString,
			// Token: 0x0400018F RID: 399
			Stream,
			// Token: 0x04000190 RID: 400
			TextReader,
			// Token: 0x04000191 RID: 401
			Invalid
		}

		// Token: 0x02000045 RID: 69
		private struct ParsingState
		{
			// Token: 0x0600032C RID: 812 RVA: 0x0000D638 File Offset: 0x0000B838
			internal void Clear()
			{
				this.eolNormalized = true;
			}

			// Token: 0x0600032D RID: 813 RVA: 0x0000D64C File Offset: 0x0000B84C
			internal void Close(bool closeInput)
			{
				Stream stream = this.stream;
				if (stream != null)
				{
					return;
				}
				if (stream != null)
				{
					return;
				}
			}

			// Token: 0x170000A6 RID: 166
			// (get) Token: 0x0600032E RID: 814 RVA: 0x0000D668 File Offset: 0x0000B868
			internal int LineNo
			{
				get
				{
					return this.lineNo;
				}
			}

			// Token: 0x170000A7 RID: 167
			// (get) Token: 0x0600032F RID: 815 RVA: 0x0000D67C File Offset: 0x0000B87C
			internal int LinePos
			{
				get
				{
					/*
An exception occurred when decompiling this method (0600032F)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Int32 System.Xml.XmlTextReaderImpl/ParsingState::get_LinePos()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:int32(var_0_06, ldfld:int32(ParsingState::charPos, ldloc:valuetype System.Xml.XmlTextReaderImpl/ParsingState&(this)))
	stloc:int32(var_1_0D, ldfld:int32(ParsingState::lineStartPos, ldloc:valuetype System.Xml.XmlTextReaderImpl/ParsingState&(this)))
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

			// Token: 0x04000192 RID: 402
			internal char[] chars;

			// Token: 0x04000193 RID: 403
			internal int charPos;

			// Token: 0x04000194 RID: 404
			internal int charsUsed;

			// Token: 0x04000195 RID: 405
			internal Encoding encoding;

			// Token: 0x04000196 RID: 406
			internal bool appendMode;

			// Token: 0x04000197 RID: 407
			internal Stream stream;

			// Token: 0x04000198 RID: 408
			internal Decoder decoder;

			// Token: 0x04000199 RID: 409
			internal byte[] bytes;

			// Token: 0x0400019A RID: 410
			internal int bytePos;

			// Token: 0x0400019B RID: 411
			internal int bytesUsed;

			// Token: 0x0400019C RID: 412
			internal TextReader textReader;

			// Token: 0x0400019D RID: 413
			internal int lineNo;

			// Token: 0x0400019E RID: 414
			internal int lineStartPos;

			// Token: 0x0400019F RID: 415
			internal string baseUriStr;

			// Token: 0x040001A0 RID: 416
			internal Uri baseUri;

			// Token: 0x040001A1 RID: 417
			internal bool isEof;

			// Token: 0x040001A2 RID: 418
			internal bool isStreamEof;

			// Token: 0x040001A3 RID: 419
			internal IDtdEntityInfo entity;

			// Token: 0x040001A4 RID: 420
			internal int entityId;

			// Token: 0x040001A5 RID: 421
			internal bool eolNormalized;

			// Token: 0x040001A6 RID: 422
			internal bool entityResolvedManually;
		}

		// Token: 0x02000046 RID: 70
		private class XmlContext
		{
			// Token: 0x06000330 RID: 816 RVA: 0x0000D698 File Offset: 0x0000B898
			internal XmlContext()
			{
			}

			// Token: 0x06000331 RID: 817 RVA: 0x0000D6AC File Offset: 0x0000B8AC
			internal XmlContext(XmlTextReaderImpl.XmlContext previousContext)
			{
				XmlSpace xmlSpace = previousContext.xmlSpace;
				this.xmlSpace = xmlSpace;
				this.previousContext = previousContext;
			}

			// Token: 0x040001A7 RID: 423
			internal XmlSpace xmlSpace;

			// Token: 0x040001A8 RID: 424
			internal string xmlLang;

			// Token: 0x040001A9 RID: 425
			internal string defaultNamespace;

			// Token: 0x040001AA RID: 426
			internal XmlTextReaderImpl.XmlContext previousContext;
		}

		// Token: 0x02000047 RID: 71
		private class NoNamespaceManager : XmlNamespaceManager
		{
			// Token: 0x06000332 RID: 818 RVA: 0x0000D6D4 File Offset: 0x0000B8D4
			public NoNamespaceManager()
			{
			}

			// Token: 0x170000A8 RID: 168
			// (get) Token: 0x06000333 RID: 819 RVA: 0x00003FFD File Offset: 0x000021FD
			public override string DefaultNamespace
			{
				get
				{
					throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
				}
			}

			// Token: 0x06000334 RID: 820 RVA: 0x0000D6E8 File Offset: 0x0000B8E8
			public override void PushScope()
			{
			}

			// Token: 0x06000335 RID: 821 RVA: 0x0000D6F8 File Offset: 0x0000B8F8
			public override bool PopScope()
			{
			}

			// Token: 0x06000336 RID: 822 RVA: 0x0000D708 File Offset: 0x0000B908
			public override void AddNamespace(string prefix, string uri)
			{
			}

			// Token: 0x06000337 RID: 823 RVA: 0x0000D718 File Offset: 0x0000B918
			public override void RemoveNamespace(string prefix, string uri)
			{
			}

			// Token: 0x06000338 RID: 824 RVA: 0x0000D728 File Offset: 0x0000B928
			public override IEnumerator GetEnumerator()
			{
			}

			// Token: 0x06000339 RID: 825 RVA: 0x00003FFD File Offset: 0x000021FD
			public override string LookupNamespace(string prefix)
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}

			// Token: 0x0600033A RID: 826 RVA: 0x0000D738 File Offset: 0x0000B938
			public override string LookupPrefix(string uri)
			{
			}
		}

		// Token: 0x02000048 RID: 72
		internal class DtdParserProxy : IDtdParserAdapterV1, IDtdParserAdapterWithValidation, IDtdParserAdapter
		{
			// Token: 0x0600033B RID: 827 RVA: 0x0000D748 File Offset: 0x0000B948
			internal DtdParserProxy(XmlTextReaderImpl reader)
			{
				this.reader = reader;
			}

			// Token: 0x170000A9 RID: 169
			// (get) Token: 0x0600033C RID: 828 RVA: 0x0000D764 File Offset: 0x0000B964
			XmlNameTable IDtdParserAdapter.NameTable
			{
				get
				{
					return this.reader.nameTable;
				}
			}

			// Token: 0x170000AA RID: 170
			// (get) Token: 0x0600033D RID: 829 RVA: 0x0000D77C File Offset: 0x0000B97C
			IXmlNamespaceResolver IDtdParserAdapter.NamespaceResolver
			{
				get
				{
					/*
An exception occurred when decompiling this method (0600033D)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Xml.IXmlNamespaceResolver System.Xml.XmlTextReaderImpl/DtdParserProxy::System.Xml.IDtdParserAdapter.get_NamespaceResolver()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:XmlNamespaceManager(var_0_0B, ldfld:XmlNamespaceManager(XmlTextReaderImpl::namespaceManager, ldfld:XmlTextReaderImpl(DtdParserProxy::reader, ldloc:DtdParserProxy(this))))
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

			// Token: 0x170000AB RID: 171
			// (get) Token: 0x0600033E RID: 830 RVA: 0x0000D794 File Offset: 0x0000B994
			Uri IDtdParserAdapter.BaseUri
			{
				get
				{
					return this.reader.DtdParserProxy_BaseUri;
				}
			}

			// Token: 0x170000AC RID: 172
			// (get) Token: 0x0600033F RID: 831 RVA: 0x0000D7AC File Offset: 0x0000B9AC
			bool IDtdParserAdapter.IsEof
			{
				get
				{
					return this.reader.DtdParserProxy_IsEof;
				}
			}

			// Token: 0x170000AD RID: 173
			// (get) Token: 0x06000340 RID: 832 RVA: 0x0000D7C4 File Offset: 0x0000B9C4
			char[] IDtdParserAdapter.ParsingBuffer
			{
				get
				{
					return this.reader.DtdParserProxy_ParsingBuffer;
				}
			}

			// Token: 0x170000AE RID: 174
			// (get) Token: 0x06000341 RID: 833 RVA: 0x0000D7DC File Offset: 0x0000B9DC
			int IDtdParserAdapter.ParsingBufferLength
			{
				get
				{
					return this.reader.DtdParserProxy_ParsingBufferLength;
				}
			}

			// Token: 0x170000AF RID: 175
			// (get) Token: 0x06000342 RID: 834 RVA: 0x0000D7F4 File Offset: 0x0000B9F4
			// (set) Token: 0x06000343 RID: 835 RVA: 0x0000D80C File Offset: 0x0000BA0C
			int IDtdParserAdapter.CurrentPosition
			{
				get
				{
					return this.reader.DtdParserProxy_CurrentPosition;
				}
				set
				{
					this.reader.DtdParserProxy_CurrentPosition = value;
				}
			}

			// Token: 0x170000B0 RID: 176
			// (get) Token: 0x06000344 RID: 836 RVA: 0x0000D828 File Offset: 0x0000BA28
			int IDtdParserAdapter.EntityStackLength
			{
				get
				{
					return this.reader.DtdParserProxy_EntityStackLength;
				}
			}

			// Token: 0x170000B1 RID: 177
			// (get) Token: 0x06000345 RID: 837 RVA: 0x0000D840 File Offset: 0x0000BA40
			bool IDtdParserAdapter.IsEntityEolNormalized
			{
				get
				{
					return this.reader.DtdParserProxy_IsEntityEolNormalized;
				}
			}

			// Token: 0x06000346 RID: 838 RVA: 0x0000D858 File Offset: 0x0000BA58
			void IDtdParserAdapter.OnNewLine(int pos)
			{
				this.reader.DtdParserProxy_OnNewLine(pos);
			}

			// Token: 0x170000B2 RID: 178
			// (get) Token: 0x06000347 RID: 839 RVA: 0x0000D874 File Offset: 0x0000BA74
			int IDtdParserAdapter.LineNo
			{
				get
				{
					return this.reader.DtdParserProxy_LineNo;
				}
			}

			// Token: 0x170000B3 RID: 179
			// (get) Token: 0x06000348 RID: 840 RVA: 0x0000D88C File Offset: 0x0000BA8C
			int IDtdParserAdapter.LineStartPosition
			{
				get
				{
					return this.reader.DtdParserProxy_LineStartPosition;
				}
			}

			// Token: 0x06000349 RID: 841 RVA: 0x0000D8A4 File Offset: 0x0000BAA4
			int IDtdParserAdapter.ReadData()
			{
				return this.reader.DtdParserProxy_ReadData();
			}

			// Token: 0x0600034A RID: 842 RVA: 0x0000D8BC File Offset: 0x0000BABC
			int IDtdParserAdapter.ParseNumericCharRef(StringBuilder internalSubsetBuilder)
			{
				return this.reader.DtdParserProxy_ParseNumericCharRef(internalSubsetBuilder);
			}

			// Token: 0x0600034B RID: 843 RVA: 0x0000D8D8 File Offset: 0x0000BAD8
			int IDtdParserAdapter.ParseNamedCharRef(bool expand, StringBuilder internalSubsetBuilder)
			{
				return this.reader.DtdParserProxy_ParseNamedCharRef(expand, internalSubsetBuilder);
			}

			// Token: 0x0600034C RID: 844 RVA: 0x0000D8F4 File Offset: 0x0000BAF4
			void IDtdParserAdapter.ParsePI(StringBuilder sb)
			{
				this.reader.DtdParserProxy_ParsePI(sb);
			}

			// Token: 0x0600034D RID: 845 RVA: 0x0000D910 File Offset: 0x0000BB10
			void IDtdParserAdapter.ParseComment(StringBuilder sb)
			{
				this.reader.DtdParserProxy_ParseComment(sb);
			}

			// Token: 0x0600034E RID: 846 RVA: 0x0000D92C File Offset: 0x0000BB2C
			bool IDtdParserAdapter.PushEntity(IDtdEntityInfo entity, [Out] int entityId)
			{
				return this.reader.DtdParserProxy_PushEntity(entity, entityId);
			}

			// Token: 0x0600034F RID: 847 RVA: 0x0000D948 File Offset: 0x0000BB48
			bool IDtdParserAdapter.PopEntity([Out] IDtdEntityInfo oldEntity, [Out] int newEntityId)
			{
				return this.reader.DtdParserProxy_PopEntity(oldEntity, newEntityId);
			}

			// Token: 0x06000350 RID: 848 RVA: 0x0000D964 File Offset: 0x0000BB64
			bool IDtdParserAdapter.PushExternalSubset(string systemId, string publicId)
			{
				return this.reader.DtdParserProxy_PushExternalSubset(systemId, publicId);
			}

			// Token: 0x06000351 RID: 849 RVA: 0x0000D980 File Offset: 0x0000BB80
			void IDtdParserAdapter.PushInternalDtd(string baseUri, string internalDtd)
			{
				this.reader.DtdParserProxy_PushInternalDtd(baseUri, internalDtd);
			}

			// Token: 0x06000352 RID: 850 RVA: 0x0000D99C File Offset: 0x0000BB9C
			void IDtdParserAdapter.Throw(Exception e)
			{
				this.reader.DtdParserProxy_Throw(e);
			}

			// Token: 0x06000353 RID: 851 RVA: 0x0000D9B8 File Offset: 0x0000BBB8
			void IDtdParserAdapter.OnSystemId(string systemId, LineInfo keywordLineInfo, LineInfo systemLiteralLineInfo)
			{
				this.reader.DtdParserProxy_OnSystemId(systemId, keywordLineInfo, systemLiteralLineInfo);
			}

			// Token: 0x06000354 RID: 852 RVA: 0x0000D9D4 File Offset: 0x0000BBD4
			void IDtdParserAdapter.OnPublicId(string publicId, LineInfo keywordLineInfo, LineInfo publicLiteralLineInfo)
			{
				this.reader.DtdParserProxy_OnPublicId(publicId, keywordLineInfo, publicLiteralLineInfo);
			}

			// Token: 0x170000B4 RID: 180
			// (get) Token: 0x06000355 RID: 853 RVA: 0x0000D9F0 File Offset: 0x0000BBF0
			bool IDtdParserAdapterWithValidation.DtdValidation
			{
				get
				{
					return this.reader.DtdParserProxy_DtdValidation;
				}
			}

			// Token: 0x170000B5 RID: 181
			// (get) Token: 0x06000356 RID: 854 RVA: 0x0000DA08 File Offset: 0x0000BC08
			IValidationEventHandling IDtdParserAdapterWithValidation.ValidationEventHandling
			{
				get
				{
					return this.reader.validationEventHandling;
				}
			}

			// Token: 0x170000B6 RID: 182
			// (get) Token: 0x06000357 RID: 855 RVA: 0x0000DA20 File Offset: 0x0000BC20
			bool IDtdParserAdapterV1.Normalization
			{
				get
				{
					return this.reader.normalize;
				}
			}

			// Token: 0x170000B7 RID: 183
			// (get) Token: 0x06000358 RID: 856 RVA: 0x0000DA38 File Offset: 0x0000BC38
			bool IDtdParserAdapterV1.Namespaces
			{
				get
				{
					return this.reader.supportNamespaces;
				}
			}

			// Token: 0x170000B8 RID: 184
			// (get) Token: 0x06000359 RID: 857 RVA: 0x0000DA50 File Offset: 0x0000BC50
			bool IDtdParserAdapterV1.V1CompatibilityMode
			{
				get
				{
					return this.reader.v1Compat;
				}
			}

			// Token: 0x040001AB RID: 427
			private XmlTextReaderImpl reader;
		}

		// Token: 0x02000049 RID: 73
		private class NodeData : IComparable
		{
			// Token: 0x170000B9 RID: 185
			// (get) Token: 0x0600035A RID: 858 RVA: 0x00003FFD File Offset: 0x000021FD
			internal static XmlTextReaderImpl.NodeData None
			{
				get
				{
					throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
				}
			}

			// Token: 0x0600035B RID: 859 RVA: 0x0000DA68 File Offset: 0x0000BC68
			internal NodeData()
			{
			}

			// Token: 0x170000BA RID: 186
			// (get) Token: 0x0600035C RID: 860 RVA: 0x0000DA7C File Offset: 0x0000BC7C
			internal int LineNo
			{
				get
				{
					/*
An exception occurred when decompiling this method (0600035C)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Int32 System.Xml.XmlTextReaderImpl/NodeData::get_LineNo()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:LineInfo(var_0_06, ldfld:LineInfo(NodeData::lineInfo, ldloc:NodeData(this)))
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

			// Token: 0x170000BB RID: 187
			// (get) Token: 0x0600035D RID: 861 RVA: 0x0000DA90 File Offset: 0x0000BC90
			internal int LinePos
			{
				get
				{
					return this.lineInfo.linePos;
				}
			}

			// Token: 0x170000BC RID: 188
			// (get) Token: 0x0600035E RID: 862 RVA: 0x0000DAA8 File Offset: 0x0000BCA8
			// (set) Token: 0x0600035F RID: 863 RVA: 0x0000DAC4 File Offset: 0x0000BCC4
			internal bool IsEmptyElement
			{
				get
				{
					/*
An exception occurred when decompiling this method (0600035E)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean System.Xml.XmlTextReaderImpl/NodeData::get_IsEmptyElement()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:XmlNodeType(var_0_06, ldfld:XmlNodeType(NodeData::type, ldloc:NodeData(this)))
	stloc:bool(var_1_0D, ldfld:bool(NodeData::isEmptyOrDefault, ldloc:NodeData(this)))
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
				set
				{
				}
			}

			// Token: 0x170000BD RID: 189
			// (get) Token: 0x06000360 RID: 864 RVA: 0x0000DAD4 File Offset: 0x0000BCD4
			// (set) Token: 0x06000361 RID: 865 RVA: 0x0000DAF0 File Offset: 0x0000BCF0
			internal bool IsDefaultAttribute
			{
				get
				{
					/*
An exception occurred when decompiling this method (06000360)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean System.Xml.XmlTextReaderImpl/NodeData::get_IsDefaultAttribute()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:XmlNodeType(var_0_06, ldfld:XmlNodeType(NodeData::type, ldloc:NodeData(this)))
	stloc:bool(var_1_0D, ldfld:bool(NodeData::isEmptyOrDefault, ldloc:NodeData(this)))
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
				set
				{
				}
			}

			// Token: 0x170000BE RID: 190
			// (get) Token: 0x06000362 RID: 866 RVA: 0x0000DB00 File Offset: 0x0000BD00
			internal bool ValueBuffered
			{
				get
				{
					/*
An exception occurred when decompiling this method (06000362)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean System.Xml.XmlTextReaderImpl/NodeData::get_ValueBuffered()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:string(var_0_06, ldfld:string(NodeData::value, ldloc:NodeData(this)))
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

			// Token: 0x170000BF RID: 191
			// (get) Token: 0x06000363 RID: 867 RVA: 0x0000DB14 File Offset: 0x0000BD14
			internal string StringValue
			{
				get
				{
					string text;
					if (this.value == null)
					{
						char[] array = this.chars;
						int num = this.valueStartPos;
						LineInfo lineInfo = this.lineInfo;
						this.value = text;
					}
					return text;
				}
			}

			// Token: 0x06000364 RID: 868 RVA: 0x0000DB48 File Offset: 0x0000BD48
			internal void TrimSpacesInValue()
			{
				string text = this.value;
				if (text != null)
				{
					string text2 = XmlTextReaderImpl.StripSpaces(text);
					this.value = text2;
					return;
				}
				char[] array = this.chars;
				int num = this.valueStartPos;
			}

			// Token: 0x06000365 RID: 869 RVA: 0x0000DB7C File Offset: 0x0000BD7C
			internal void Clear(XmlNodeType type)
			{
				this.type = type;
			}

			// Token: 0x06000366 RID: 870 RVA: 0x0000DB90 File Offset: 0x0000BD90
			internal void ClearName()
			{
			}

			// Token: 0x06000367 RID: 871 RVA: 0x0000DBA0 File Offset: 0x0000BDA0
			internal void SetLineInfo(int lineNo, int linePos)
			{
			}

			// Token: 0x06000368 RID: 872 RVA: 0x0000DBB0 File Offset: 0x0000BDB0
			internal void SetLineInfo2(int lineNo, int linePos)
			{
			}

			// Token: 0x06000369 RID: 873 RVA: 0x0000DBC0 File Offset: 0x0000BDC0
			internal void SetValueNode(XmlNodeType type, string value)
			{
				this.type = type;
				this.value = value;
			}

			// Token: 0x0600036A RID: 874 RVA: 0x0000DBDC File Offset: 0x0000BDDC
			internal void SetValueNode(XmlNodeType type, char[] chars, int startPos, int len)
			{
				this.type = type;
				this.chars = chars;
				this.valueStartPos = startPos;
				this.lineInfo = len;
			}

			// Token: 0x0600036B RID: 875 RVA: 0x0000DC08 File Offset: 0x0000BE08
			internal void SetNamedNode(XmlNodeType type, string localName)
			{
				this.nameWPrefix = localName;
				this.type = type;
				this.localName = localName;
			}

			// Token: 0x0600036C RID: 876 RVA: 0x0000DC2C File Offset: 0x0000BE2C
			internal void SetNamedNode(XmlNodeType type, string localName, string prefix, string nameWPrefix)
			{
				this.type = type;
				this.localName = localName;
				this.prefix = prefix;
				this.nameWPrefix = nameWPrefix;
			}

			// Token: 0x0600036D RID: 877 RVA: 0x0000DC58 File Offset: 0x0000BE58
			internal void SetValue(string value)
			{
				this.value = value;
			}

			// Token: 0x0600036E RID: 878 RVA: 0x0000DC6C File Offset: 0x0000BE6C
			internal void SetValue(char[] chars, int startPos, int len)
			{
				this.chars = chars;
				this.valueStartPos = startPos;
				this.lineInfo = len;
			}

			// Token: 0x0600036F RID: 879 RVA: 0x0000DC90 File Offset: 0x0000BE90
			internal void OnBufferInvalidated()
			{
				string text = this.value;
				if (text == null)
				{
					char[] array = this.chars;
					int num = this.valueStartPos;
					LineInfo lineInfo = this.lineInfo;
					string text2;
					this.value = text2;
				}
				this.valueStartPos = text;
			}

			// Token: 0x06000370 RID: 880 RVA: 0x0000DCD0 File Offset: 0x0000BED0
			internal void CopyTo(int valueOffset, StringBuilder sb)
			{
				string text = this.value;
				if (text != null)
				{
					int stringLength = text._stringLength;
					return;
				}
			}

			// Token: 0x06000371 RID: 881 RVA: 0x0000DCF0 File Offset: 0x0000BEF0
			internal string GetNameWPrefix(XmlNameTable nt)
			{
				string text = this.nameWPrefix;
				if (text != null)
				{
					return text;
				}
				string text2;
				return text2;
			}

			// Token: 0x06000372 RID: 882 RVA: 0x0000DD0C File Offset: 0x0000BF0C
			internal string CreateNameWPrefix(XmlNameTable nt)
			{
				/*
An exception occurred when decompiling this method (06000372)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.String System.Xml.XmlTextReaderImpl/NodeData::CreateNameWPrefix(System.Xml.XmlNameTable)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0023:
	stfld:string(NodeData::nameWPrefix, ldloc:NodeData(this), ldloc:XmlNameTable[exp:string](nt))
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

			// Token: 0x06000373 RID: 883 RVA: 0x0000DD44 File Offset: 0x0000BF44
			int IComparable.CompareTo(object obj)
			{
				if (obj != null)
				{
				}
				return 1;
			}

			// Token: 0x040001AC RID: 428
			private static XmlTextReaderImpl.NodeData s_None;

			// Token: 0x040001AD RID: 429
			internal XmlNodeType type;

			// Token: 0x040001AE RID: 430
			internal string localName;

			// Token: 0x040001AF RID: 431
			internal string prefix;

			// Token: 0x040001B0 RID: 432
			internal string ns;

			// Token: 0x040001B1 RID: 433
			internal string nameWPrefix;

			// Token: 0x040001B2 RID: 434
			private string value;

			// Token: 0x040001B3 RID: 435
			private char[] chars;

			// Token: 0x040001B4 RID: 436
			private int valueStartPos;

			// Token: 0x040001B5 RID: 437
			private int valueLength;

			// Token: 0x040001B6 RID: 438
			internal LineInfo lineInfo;

			// Token: 0x040001B7 RID: 439
			internal LineInfo lineInfo2;

			// Token: 0x040001B8 RID: 440
			internal char quoteChar;

			// Token: 0x040001B9 RID: 441
			internal int depth;

			// Token: 0x040001BA RID: 442
			private bool isEmptyOrDefault;

			// Token: 0x040001BB RID: 443
			internal int entityId;

			// Token: 0x040001BC RID: 444
			internal bool xmlContextPushed;

			// Token: 0x040001BD RID: 445
			internal XmlTextReaderImpl.NodeData nextAttrValueChunk;

			// Token: 0x040001BE RID: 446
			internal object schemaType;

			// Token: 0x040001BF RID: 447
			internal object typedValue;
		}

		// Token: 0x0200004A RID: 74
		private class DtdDefaultAttributeInfoToNodeDataComparer : IComparer<object>
		{
			// Token: 0x170000C0 RID: 192
			// (get) Token: 0x06000374 RID: 884 RVA: 0x0000DD7C File Offset: 0x0000BF7C
			internal static IComparer<object> Instance
			{
				get
				{
					if (!true)
					{
					}
					return 1;
				}
			}

			// Token: 0x06000375 RID: 885 RVA: 0x0000DD90 File Offset: 0x0000BF90
			public int Compare(object x, object y)
			{
				while (x != null && y != null && x == null)
				{
				}
				return 1;
			}

			// Token: 0x06000376 RID: 886 RVA: 0x0000DDC0 File Offset: 0x0000BFC0
			public DtdDefaultAttributeInfoToNodeDataComparer()
			{
			}

			// Token: 0x06000377 RID: 887 RVA: 0x0000DDD4 File Offset: 0x0000BFD4
			// Note: this type is marked as 'beforefieldinit'.
			static DtdDefaultAttributeInfoToNodeDataComparer()
			{
			}

			// Token: 0x040001C0 RID: 448
			private static IComparer<object> s_instance;
		}

		// Token: 0x0200004B RID: 75
		internal sealed class OnDefaultAttributeUseDelegate : MulticastDelegate
		{
			// Token: 0x06000378 RID: 888 RVA: 0x0000DDE4 File Offset: 0x0000BFE4
			public OnDefaultAttributeUseDelegate(object @object, IntPtr method)
			{
				this.method_ptr = method;
				this.m_target = @object;
				this.method = method;
				this.method_code = this;
			}

			// Token: 0x06000379 RID: 889 RVA: 0x0000DE44 File Offset: 0x0000C044
			public void Invoke(IDtdDefaultAttributeInfo defaultAttribute, XmlTextReaderImpl coreReader)
			{
				IntPtr method_code = this.method_code;
				IntPtr invoke_impl = this.invoke_impl;
				IntPtr method = this.method;
			}
		}
	}
}
