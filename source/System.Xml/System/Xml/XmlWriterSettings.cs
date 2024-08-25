using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Cpp2IlInjected;

namespace System.Xml
{
	// Token: 0x02000060 RID: 96
	public sealed class XmlWriterSettings
	{
		// Token: 0x0600043B RID: 1083 RVA: 0x00010CD4 File Offset: 0x0000EED4
		public XmlWriterSettings()
		{
			this.Initialize();
		}

		// Token: 0x170000C9 RID: 201
		// (get) Token: 0x0600043C RID: 1084 RVA: 0x00010CF0 File Offset: 0x0000EEF0
		public bool Async
		{
			get
			{
				return this.useAsync;
			}
		}

		// Token: 0x170000CA RID: 202
		// (get) Token: 0x0600043D RID: 1085 RVA: 0x00010D04 File Offset: 0x0000EF04
		public Encoding Encoding
		{
			get
			{
				return this.encoding;
			}
		}

		// Token: 0x170000CB RID: 203
		// (get) Token: 0x0600043E RID: 1086 RVA: 0x00010D18 File Offset: 0x0000EF18
		// (set) Token: 0x0600043F RID: 1087 RVA: 0x00010D2C File Offset: 0x0000EF2C
		public bool OmitXmlDeclaration
		{
			get
			{
				return this.omitXmlDecl;
			}
			set
			{
				this.CheckReadOnly("OmitXmlDeclaration");
			}
		}

		// Token: 0x170000CC RID: 204
		// (get) Token: 0x06000440 RID: 1088 RVA: 0x00010D44 File Offset: 0x0000EF44
		public NewLineHandling NewLineHandling
		{
			get
			{
				return this.newLineHandling;
			}
		}

		// Token: 0x170000CD RID: 205
		// (get) Token: 0x06000441 RID: 1089 RVA: 0x00010D58 File Offset: 0x0000EF58
		public string NewLineChars
		{
			get
			{
				return this.newLineChars;
			}
		}

		// Token: 0x170000CE RID: 206
		// (get) Token: 0x06000442 RID: 1090 RVA: 0x00010D6C File Offset: 0x0000EF6C
		// (set) Token: 0x06000443 RID: 1091 RVA: 0x00010D80 File Offset: 0x0000EF80
		public bool Indent
		{
			get
			{
				/*
An exception occurred when decompiling this method (06000442)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean System.Xml.XmlWriterSettings::get_Indent()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:TriState(var_0_06, ldfld:TriState(XmlWriterSettings::indent, ldloc:XmlWriterSettings(this)))
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
				this.CheckReadOnly("Indent");
				this.indent = TriState.True;
			}
		}

		// Token: 0x170000CF RID: 207
		// (get) Token: 0x06000444 RID: 1092 RVA: 0x00010DA0 File Offset: 0x0000EFA0
		public string IndentChars
		{
			get
			{
				return this.indentChars;
			}
		}

		// Token: 0x170000D0 RID: 208
		// (get) Token: 0x06000445 RID: 1093 RVA: 0x00010DB4 File Offset: 0x0000EFB4
		public bool NewLineOnAttributes
		{
			get
			{
				return this.newLineOnAttributes;
			}
		}

		// Token: 0x170000D1 RID: 209
		// (get) Token: 0x06000446 RID: 1094 RVA: 0x00010DC8 File Offset: 0x0000EFC8
		public bool CloseOutput
		{
			get
			{
				return this.closeOutput;
			}
		}

		// Token: 0x170000D2 RID: 210
		// (get) Token: 0x06000447 RID: 1095 RVA: 0x00010DDC File Offset: 0x0000EFDC
		// (set) Token: 0x06000448 RID: 1096 RVA: 0x00010DF0 File Offset: 0x0000EFF0
		public ConformanceLevel ConformanceLevel
		{
			get
			{
				return this.conformanceLevel;
			}
			set
			{
				this.CheckReadOnly("ConformanceLevel");
				this.conformanceLevel = value;
			}
		}

		// Token: 0x170000D3 RID: 211
		// (get) Token: 0x06000449 RID: 1097 RVA: 0x00010E10 File Offset: 0x0000F010
		public bool CheckCharacters
		{
			get
			{
				return this.checkCharacters;
			}
		}

		// Token: 0x170000D4 RID: 212
		// (get) Token: 0x0600044A RID: 1098 RVA: 0x00010E24 File Offset: 0x0000F024
		// (set) Token: 0x0600044B RID: 1099 RVA: 0x00010E38 File Offset: 0x0000F038
		public NamespaceHandling NamespaceHandling
		{
			get
			{
				return this.namespaceHandling;
			}
			set
			{
				this.CheckReadOnly("NamespaceHandling");
				this.namespaceHandling = value;
			}
		}

		// Token: 0x170000D5 RID: 213
		// (get) Token: 0x0600044C RID: 1100 RVA: 0x00010E58 File Offset: 0x0000F058
		public bool WriteEndDocumentOnClose
		{
			get
			{
				return this.writeEndDocumentOnClose;
			}
		}

		// Token: 0x170000D6 RID: 214
		// (get) Token: 0x0600044D RID: 1101 RVA: 0x00010E6C File Offset: 0x0000F06C
		// (set) Token: 0x0600044E RID: 1102 RVA: 0x00010E80 File Offset: 0x0000F080
		public XmlOutputMethod OutputMethod
		{
			get
			{
				return this.outputMethod;
			}
			internal set
			{
				this.outputMethod = value;
			}
		}

		// Token: 0x0600044F RID: 1103 RVA: 0x00010E94 File Offset: 0x0000F094
		public XmlWriterSettings Clone()
		{
			/*
An exception occurred when decompiling this method (0600044F)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Xml.XmlWriterSettings System.Xml.XmlWriterSettings::Clone()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0008:
	stloc:class [mscorlib]System.Collections.Generic.List`1<class System.Xml.XmlQualifiedName>(var_1_10, ldfld:class [mscorlib]System.Collections.Generic.List`1<class System.Xml.XmlQualifiedName>(XmlWriterSettings::cdataSections, ldloc:XmlWriterSettings(this)))
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

		// Token: 0x170000D7 RID: 215
		// (get) Token: 0x06000450 RID: 1104 RVA: 0x00010EB4 File Offset: 0x0000F0B4
		internal List<XmlQualifiedName> CDataSectionElements
		{
			get
			{
				return this.cdataSections;
			}
		}

		// Token: 0x170000D8 RID: 216
		// (get) Token: 0x06000451 RID: 1105 RVA: 0x00010EC8 File Offset: 0x0000F0C8
		public bool DoNotEscapeUriAttributes
		{
			get
			{
				return this.doNotEscapeUriAttributes;
			}
		}

		// Token: 0x170000D9 RID: 217
		// (get) Token: 0x06000452 RID: 1106 RVA: 0x00010EDC File Offset: 0x0000F0DC
		internal bool MergeCDataSections
		{
			get
			{
				return this.mergeCDataSections;
			}
		}

		// Token: 0x170000DA RID: 218
		// (get) Token: 0x06000453 RID: 1107 RVA: 0x00010EF0 File Offset: 0x0000F0F0
		internal string MediaType
		{
			get
			{
				return this.mediaType;
			}
		}

		// Token: 0x170000DB RID: 219
		// (get) Token: 0x06000454 RID: 1108 RVA: 0x00010F04 File Offset: 0x0000F104
		internal string DocTypeSystem
		{
			get
			{
				return this.docTypeSystem;
			}
		}

		// Token: 0x170000DC RID: 220
		// (get) Token: 0x06000455 RID: 1109 RVA: 0x00010F18 File Offset: 0x0000F118
		internal string DocTypePublic
		{
			get
			{
				return this.docTypePublic;
			}
		}

		// Token: 0x170000DD RID: 221
		// (get) Token: 0x06000456 RID: 1110 RVA: 0x00010F2C File Offset: 0x0000F12C
		internal XmlStandalone Standalone
		{
			get
			{
				return this.standalone;
			}
		}

		// Token: 0x170000DE RID: 222
		// (get) Token: 0x06000457 RID: 1111 RVA: 0x00010F40 File Offset: 0x0000F140
		internal bool AutoXmlDeclaration
		{
			get
			{
				return this.autoXmlDecl;
			}
		}

		// Token: 0x170000DF RID: 223
		// (get) Token: 0x06000458 RID: 1112 RVA: 0x00010F54 File Offset: 0x0000F154
		internal TriState IndentInternal
		{
			get
			{
				return this.indent;
			}
		}

		// Token: 0x170000E0 RID: 224
		// (get) Token: 0x06000459 RID: 1113 RVA: 0x00010F68 File Offset: 0x0000F168
		internal bool IsQuerySpecific
		{
			get
			{
				if (this.cdataSections._size != 0 || this.docTypePublic != null || this.docTypeSystem != null)
				{
					return true;
				}
				XmlStandalone xmlStandalone = this.standalone;
				return true;
			}
		}

		// Token: 0x0600045A RID: 1114 RVA: 0x00010F9C File Offset: 0x0000F19C
		internal XmlWriter CreateWriter(Stream output)
		{
			if (output != null)
			{
				Encoding encoding = this.encoding;
				XmlOutputMethod xmlOutputMethod = this.outputMethod;
				TriState triState = this.indent;
				TriState triState2 = this.indent;
				TriState triState3 = this.indent;
				TriState triState4 = this.indent;
				XmlOutputMethod xmlOutputMethod2 = this.outputMethod;
				bool isQuerySpecific = this.IsQuerySpecific;
				if (this.useAsync)
				{
				}
			}
			throw new InvalidCastException();
		}

		// Token: 0x0600045B RID: 1115 RVA: 0x00010FF8 File Offset: 0x0000F1F8
		internal XmlWriter CreateWriter(TextWriter output)
		{
			if (output != null)
			{
				XmlOutputMethod xmlOutputMethod = this.outputMethod;
				TriState triState = this.indent;
				TriState triState2 = this.indent;
				XmlOutputMethod xmlOutputMethod2 = this.outputMethod;
				bool isQuerySpecific = this.IsQuerySpecific;
				if (this.useAsync)
				{
				}
			}
			throw new InvalidCastException();
		}

		// Token: 0x170000E1 RID: 225
		// (set) Token: 0x0600045C RID: 1116 RVA: 0x0001103C File Offset: 0x0000F23C
		internal bool ReadOnly
		{
			set
			{
			}
		}

		// Token: 0x0600045D RID: 1117 RVA: 0x0001104C File Offset: 0x0000F24C
		private void CheckReadOnly(string propertyName)
		{
			/*
An exception occurred when decompiling this method (0600045D)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Void System.Xml.XmlWriterSettings::CheckReadOnly(System.String)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0009:
	stloc:Type(var_0_0F, call:Type(object::GetType, ldloc:XmlWriterSettings[exp:object](this)))
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

		// Token: 0x0600045E RID: 1118 RVA: 0x00003FFD File Offset: 0x000021FD
		private void Initialize()
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x04000271 RID: 625
		private bool useAsync;

		// Token: 0x04000272 RID: 626
		private Encoding encoding;

		// Token: 0x04000273 RID: 627
		private bool omitXmlDecl;

		// Token: 0x04000274 RID: 628
		private NewLineHandling newLineHandling;

		// Token: 0x04000275 RID: 629
		private string newLineChars;

		// Token: 0x04000276 RID: 630
		private TriState indent;

		// Token: 0x04000277 RID: 631
		private string indentChars;

		// Token: 0x04000278 RID: 632
		private bool newLineOnAttributes;

		// Token: 0x04000279 RID: 633
		private bool closeOutput;

		// Token: 0x0400027A RID: 634
		private NamespaceHandling namespaceHandling;

		// Token: 0x0400027B RID: 635
		private ConformanceLevel conformanceLevel;

		// Token: 0x0400027C RID: 636
		private bool checkCharacters;

		// Token: 0x0400027D RID: 637
		private bool writeEndDocumentOnClose;

		// Token: 0x0400027E RID: 638
		private XmlOutputMethod outputMethod;

		// Token: 0x0400027F RID: 639
		private List<XmlQualifiedName> cdataSections;

		// Token: 0x04000280 RID: 640
		private bool doNotEscapeUriAttributes;

		// Token: 0x04000281 RID: 641
		private bool mergeCDataSections;

		// Token: 0x04000282 RID: 642
		private string mediaType;

		// Token: 0x04000283 RID: 643
		private string docTypeSystem;

		// Token: 0x04000284 RID: 644
		private string docTypePublic;

		// Token: 0x04000285 RID: 645
		private XmlStandalone standalone;

		// Token: 0x04000286 RID: 646
		private bool autoXmlDecl;

		// Token: 0x04000287 RID: 647
		private bool isReadOnly;
	}
}
