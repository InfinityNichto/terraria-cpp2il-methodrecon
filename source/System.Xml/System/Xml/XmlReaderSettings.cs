using System;
using System.Runtime.CompilerServices;
using System.Xml.Schema;
using Cpp2IlInjected;

namespace System.Xml
{
	// Token: 0x0200003A RID: 58
	public sealed class XmlReaderSettings
	{
		// Token: 0x0600021A RID: 538 RVA: 0x00006E00 File Offset: 0x00005000
		public XmlReaderSettings()
		{
		}

		// Token: 0x1700005D RID: 93
		// (set) Token: 0x0600021B RID: 539 RVA: 0x00006E14 File Offset: 0x00005014
		public XmlNameTable NameTable
		{
			set
			{
				this.CheckReadOnly("NameTable");
				this.nameTable = value;
			}
		}

		// Token: 0x1700005E RID: 94
		// (set) Token: 0x0600021C RID: 540 RVA: 0x00006E34 File Offset: 0x00005034
		internal bool IsXmlResolverSet
		{
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700005F RID: 95
		// (set) Token: 0x0600021D RID: 541 RVA: 0x00006E44 File Offset: 0x00005044
		public XmlResolver XmlResolver
		{
			set
			{
				this.CheckReadOnly("XmlResolver");
				this.xmlResolver = value;
				this.<IsXmlResolverSet>k__BackingField = true;
			}
		}

		// Token: 0x0600021E RID: 542 RVA: 0x00006E6C File Offset: 0x0000506C
		internal XmlResolver GetXmlResolver()
		{
			return this.xmlResolver;
		}

		// Token: 0x17000060 RID: 96
		// (set) Token: 0x0600021F RID: 543 RVA: 0x00006E80 File Offset: 0x00005080
		public int LineNumberOffset
		{
			set
			{
				this.CheckReadOnly("LineNumberOffset");
				this.lineNumberOffset = value;
			}
		}

		// Token: 0x17000061 RID: 97
		// (set) Token: 0x06000220 RID: 544 RVA: 0x00006EA0 File Offset: 0x000050A0
		public int LinePositionOffset
		{
			set
			{
				this.CheckReadOnly("LinePositionOffset");
				this.linePositionOffset = value;
			}
		}

		// Token: 0x17000062 RID: 98
		// (set) Token: 0x06000221 RID: 545 RVA: 0x00006EC0 File Offset: 0x000050C0
		public ConformanceLevel ConformanceLevel
		{
			set
			{
				this.CheckReadOnly("ConformanceLevel");
				this.conformanceLevel = value;
			}
		}

		// Token: 0x17000063 RID: 99
		// (set) Token: 0x06000222 RID: 546 RVA: 0x00006EE0 File Offset: 0x000050E0
		public bool CheckCharacters
		{
			set
			{
				this.CheckReadOnly("CheckCharacters");
			}
		}

		// Token: 0x17000064 RID: 100
		// (set) Token: 0x06000223 RID: 547 RVA: 0x00006EF8 File Offset: 0x000050F8
		public long MaxCharactersInDocument
		{
			set
			{
				this.CheckReadOnly("MaxCharactersInDocument");
				this.maxCharactersInDocument = value;
			}
		}

		// Token: 0x17000065 RID: 101
		// (set) Token: 0x06000224 RID: 548 RVA: 0x00006F18 File Offset: 0x00005118
		public long MaxCharactersFromEntities
		{
			set
			{
				this.CheckReadOnly("MaxCharactersFromEntities");
				this.maxCharactersFromEntities = value;
			}
		}

		// Token: 0x17000066 RID: 102
		// (set) Token: 0x06000225 RID: 549 RVA: 0x00006F38 File Offset: 0x00005138
		public bool IgnoreWhitespace
		{
			set
			{
				this.CheckReadOnly("IgnoreWhitespace");
			}
		}

		// Token: 0x17000067 RID: 103
		// (set) Token: 0x06000226 RID: 550 RVA: 0x00006F50 File Offset: 0x00005150
		public bool IgnoreProcessingInstructions
		{
			set
			{
				this.CheckReadOnly("IgnoreProcessingInstructions");
			}
		}

		// Token: 0x17000068 RID: 104
		// (set) Token: 0x06000227 RID: 551 RVA: 0x00006F68 File Offset: 0x00005168
		public bool IgnoreComments
		{
			set
			{
				this.CheckReadOnly("IgnoreComments");
			}
		}

		// Token: 0x17000069 RID: 105
		// (set) Token: 0x06000228 RID: 552 RVA: 0x00006F80 File Offset: 0x00005180
		public DtdProcessing DtdProcessing
		{
			set
			{
				this.CheckReadOnly("DtdProcessing");
				this.dtdProcessing = value;
			}
		}

		// Token: 0x1700006A RID: 106
		// (get) Token: 0x06000229 RID: 553 RVA: 0x00006FA0 File Offset: 0x000051A0
		public ValidationType ValidationType
		{
			get
			{
				return this.validationType;
			}
		}

		// Token: 0x1700006B RID: 107
		// (get) Token: 0x0600022A RID: 554 RVA: 0x00006FB4 File Offset: 0x000051B4
		public XmlSchemaSet Schemas
		{
			get
			{
				/*
An exception occurred when decompiling this method (0600022A)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Xml.Schema.XmlSchemaSet System.Xml.XmlReaderSettings::get_Schemas()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0000:
	brtrue(IL_0000, ldfld:XmlSchemaSet[exp:bool](XmlReaderSettings::schemas, ldloc:XmlReaderSettings(this)))
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

		// Token: 0x1700006C RID: 108
		// (set) Token: 0x0600022B RID: 555 RVA: 0x00006FC8 File Offset: 0x000051C8
		internal bool ReadOnly
		{
			set
			{
			}
		}

		// Token: 0x0600022C RID: 556 RVA: 0x00006FD8 File Offset: 0x000051D8
		private void CheckReadOnly(string propertyName)
		{
			/*
An exception occurred when decompiling this method (0600022C)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Void System.Xml.XmlReaderSettings::CheckReadOnly(System.String)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0009:
	stloc:Type(var_0_0F, call:Type(object::GetType, ldloc:XmlReaderSettings[exp:object](this)))
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

		// Token: 0x0600022D RID: 557 RVA: 0x00006FF4 File Offset: 0x000051F4
		private void Initialize()
		{
		}

		// Token: 0x0600022E RID: 558 RVA: 0x00007004 File Offset: 0x00005204
		private void Initialize(XmlResolver resolver)
		{
			XmlResolver xmlResolver;
			if (resolver == null)
			{
				xmlResolver = XmlReaderSettings.CreateDefaultResolver();
			}
			this.checkCharacters = true;
			this.conformanceLevel = ConformanceLevel.Document;
			this.xmlResolver = xmlResolver;
			this.validationFlags = XmlSchemaValidationFlags.ProcessIdentityConstraints | XmlSchemaValidationFlags.AllowXmlAttributes;
		}

		// Token: 0x0600022F RID: 559 RVA: 0x00003FFD File Offset: 0x000021FD
		private static XmlResolver CreateDefaultResolver()
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06000230 RID: 560 RVA: 0x00003FFD File Offset: 0x000021FD
		internal static bool EnableLegacyXmlSettings()
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x040000E2 RID: 226
		private bool useAsync;

		// Token: 0x040000E3 RID: 227
		private XmlNameTable nameTable;

		// Token: 0x040000E4 RID: 228
		private XmlResolver xmlResolver;

		// Token: 0x040000E5 RID: 229
		private int lineNumberOffset;

		// Token: 0x040000E6 RID: 230
		private int linePositionOffset;

		// Token: 0x040000E7 RID: 231
		private ConformanceLevel conformanceLevel;

		// Token: 0x040000E8 RID: 232
		private bool checkCharacters;

		// Token: 0x040000E9 RID: 233
		private long maxCharactersInDocument;

		// Token: 0x040000EA RID: 234
		private long maxCharactersFromEntities;

		// Token: 0x040000EB RID: 235
		private bool ignoreWhitespace;

		// Token: 0x040000EC RID: 236
		private bool ignorePIs;

		// Token: 0x040000ED RID: 237
		private bool ignoreComments;

		// Token: 0x040000EE RID: 238
		private DtdProcessing dtdProcessing;

		// Token: 0x040000EF RID: 239
		private ValidationType validationType;

		// Token: 0x040000F0 RID: 240
		private XmlSchemaValidationFlags validationFlags;

		// Token: 0x040000F1 RID: 241
		private XmlSchemaSet schemas;

		// Token: 0x040000F2 RID: 242
		private bool closeInput;

		// Token: 0x040000F3 RID: 243
		private bool isReadOnly;

		// Token: 0x040000F4 RID: 244
		[CompilerGenerated]
		private bool <IsXmlResolverSet>k__BackingField;

		// Token: 0x040000F5 RID: 245
		private static bool? s_enableLegacyXmlSettings;
	}
}
