using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Cpp2IlInjected;

namespace System
{
	// Token: 0x02000092 RID: 146
	public abstract class UriParser
	{
		// Token: 0x17000088 RID: 136
		// (get) Token: 0x0600028D RID: 653 RVA: 0x0000A39C File Offset: 0x0000859C
		internal string SchemeName
		{
			get
			{
				return this.m_Scheme;
			}
		}

		// Token: 0x17000089 RID: 137
		// (get) Token: 0x0600028E RID: 654 RVA: 0x0000A3B0 File Offset: 0x000085B0
		internal int DefaultPort
		{
			get
			{
				return this.m_Port;
			}
		}

		// Token: 0x0600028F RID: 655 RVA: 0x0000A3C4 File Offset: 0x000085C4
		protected virtual global::System.UriParser OnNewUri()
		{
			return this;
		}

		// Token: 0x06000290 RID: 656 RVA: 0x0000A3D4 File Offset: 0x000085D4
		protected virtual void InitializeAndValidate(global::System.Uri uri, [Out] global::System.UriFormatException parsingError)
		{
			global::System.UriFormatException ex = uri.ParseMinimal();
		}

		// Token: 0x06000291 RID: 657 RVA: 0x0000A3E8 File Offset: 0x000085E8
		protected virtual string Resolve(global::System.Uri baseUri, global::System.Uri relativeUri, [Out] global::System.UriFormatException parsingError)
		{
			bool userDrivenParsing = baseUri.UserDrivenParsing;
			bool isAbsoluteUri = baseUri.IsAbsoluteUri;
			if (!true)
			{
			}
			global::System.Uri uri;
			return uri.OriginalString;
		}

		// Token: 0x06000292 RID: 658 RVA: 0x0000A428 File Offset: 0x00008628
		protected virtual bool IsBaseOf(global::System.Uri baseUri, global::System.Uri relativeUri)
		{
			return baseUri.IsBaseOfHelper(relativeUri);
		}

		// Token: 0x06000293 RID: 659 RVA: 0x0000A43C File Offset: 0x0000863C
		protected virtual string GetComponents(global::System.Uri uri, global::System.UriComponents components, global::System.UriFormat format)
		{
			bool userDrivenParsing = uri.UserDrivenParsing;
			bool isAbsoluteUri = uri.IsAbsoluteUri;
			return uri.GetComponentsHelper(components, format);
		}

		// Token: 0x06000294 RID: 660 RVA: 0x0000A480 File Offset: 0x00008680
		protected virtual bool IsWellFormedOriginalString(global::System.Uri uri)
		{
			return uri.InternalIsWellFormedOriginalString();
		}

		// Token: 0x1700008A RID: 138
		// (get) Token: 0x06000295 RID: 661 RVA: 0x0000A494 File Offset: 0x00008694
		internal static bool ShouldUseLegacyV2Quirks
		{
			get
			{
				/*
An exception occurred when decompiling this method (06000295)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean System.UriParser::get_ShouldUseLegacyV2Quirks()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0000:
	brtrue(IL_0000, ldc.i4:bool(1))
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

		// Token: 0x06000296 RID: 662 RVA: 0x0000A4A4 File Offset: 0x000086A4
		static UriParser()
		{
			if (!true)
			{
			}
			bool shouldUseLegacyV2Quirks = global::System.UriParser.ShouldUseLegacyV2Quirks;
			bool shouldUseLegacyV2Quirks2 = global::System.UriParser.ShouldUseLegacyV2Quirks;
		}

		// Token: 0x1700008B RID: 139
		// (get) Token: 0x06000297 RID: 663 RVA: 0x0000A4C0 File Offset: 0x000086C0
		internal global::System.UriSyntaxFlags Flags
		{
			get
			{
				return this.m_Flags;
			}
		}

		// Token: 0x06000298 RID: 664 RVA: 0x0000A4D4 File Offset: 0x000086D4
		internal bool NotAny(global::System.UriSyntaxFlags flags)
		{
			bool flag;
			return flag;
		}

		// Token: 0x06000299 RID: 665 RVA: 0x0000A4E4 File Offset: 0x000086E4
		internal bool InFact(global::System.UriSyntaxFlags flags)
		{
			bool flag;
			return flag;
		}

		// Token: 0x0600029A RID: 666 RVA: 0x0000A4F4 File Offset: 0x000086F4
		internal bool IsAllSet(global::System.UriSyntaxFlags flags)
		{
			return this.IsFullMatch(flags, flags);
		}

		// Token: 0x0600029B RID: 667 RVA: 0x0000A50C File Offset: 0x0000870C
		private bool IsFullMatch(global::System.UriSyntaxFlags flags, global::System.UriSyntaxFlags expected)
		{
			/*
An exception occurred when decompiling this method (0600029B)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean System.UriParser::IsFullMatch(System.UriSyntaxFlags,System.UriSyntaxFlags)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:UriSyntaxFlags(var_0_0E, ldfld:UriSyntaxFlags(UriParser::m_Flags, ldloc:UriParser(this)))
	stloc:bool(var_1_15, ldfld:bool(UriParser::m_UpdatableFlagsUsed, ldloc:UriParser(this)))
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

		// Token: 0x0600029C RID: 668 RVA: 0x0000A530 File Offset: 0x00008730
		internal UriParser(global::System.UriSyntaxFlags flags)
		{
			this.m_Flags = flags;
		}

		// Token: 0x0600029D RID: 669 RVA: 0x0000A54C File Offset: 0x0000874C
		internal static global::System.UriParser FindOrFetchAsUnknownV1Syntax(string lwrCaseScheme)
		{
			if (!true)
			{
			}
			if (!true)
			{
			}
			if (!true)
			{
			}
			if (!true)
			{
			}
			if (!false)
			{
			}
			throw new OutOfMemoryException();
		}

		// Token: 0x0600029E RID: 670 RVA: 0x0000A588 File Offset: 0x00008788
		internal static global::System.UriParser GetSyntax(string lwrCaseScheme)
		{
			/*
An exception occurred when decompiling this method (0600029E)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.UriParser System.UriParser::GetSyntax(System.String)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	brtrue(IL_0000, ldc.i4:bool(1))
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

		// Token: 0x1700008C RID: 140
		// (get) Token: 0x0600029F RID: 671 RVA: 0x00002050 File Offset: 0x00000250
		internal bool IsSimple
		{
			get
			{
				throw new global::Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		// Token: 0x060002A0 RID: 672 RVA: 0x0000A5A0 File Offset: 0x000087A0
		internal global::System.UriParser InternalOnNewUri()
		{
			string scheme = this.m_Scheme;
			this.m_Scheme = scheme;
			int port = this.m_Port;
			this.m_Port = port;
			global::System.UriSyntaxFlags flags = this.m_Flags;
			this.m_Flags = flags;
			return this;
		}

		// Token: 0x060002A1 RID: 673 RVA: 0x0000A5D8 File Offset: 0x000087D8
		internal void InternalValidate(global::System.Uri thisUri, [Out] global::System.UriFormatException parsingError)
		{
		}

		// Token: 0x060002A2 RID: 674 RVA: 0x00002050 File Offset: 0x00000250
		internal string InternalResolve(global::System.Uri thisBaseUri, global::System.Uri uriLink, [Out] global::System.UriFormatException parsingError)
		{
			throw new global::Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x060002A3 RID: 675 RVA: 0x00002050 File Offset: 0x00000250
		internal bool InternalIsBaseOf(global::System.Uri thisBaseUri, global::System.Uri uriLink)
		{
			throw new global::Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x060002A4 RID: 676 RVA: 0x00002050 File Offset: 0x00000250
		internal string InternalGetComponents(global::System.Uri thisUri, global::System.UriComponents uriComponents, global::System.UriFormat uriFormat)
		{
			throw new global::Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x060002A5 RID: 677 RVA: 0x00002050 File Offset: 0x00000250
		internal bool InternalIsWellFormedOriginalString(global::System.Uri thisUri)
		{
			throw new global::Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x04000229 RID: 553
		private static readonly Dictionary<string, global::System.UriParser> m_Table;

		// Token: 0x0400022A RID: 554
		private static Dictionary<string, global::System.UriParser> m_TempTable;

		// Token: 0x0400022B RID: 555
		private global::System.UriSyntaxFlags m_Flags;

		// Token: 0x0400022C RID: 556
		private global::System.UriSyntaxFlags m_UpdatableFlags;

		// Token: 0x0400022D RID: 557
		private bool m_UpdatableFlagsUsed;

		// Token: 0x0400022E RID: 558
		private int m_Port;

		// Token: 0x0400022F RID: 559
		private string m_Scheme;

		// Token: 0x04000230 RID: 560
		internal static global::System.UriParser HttpUri;

		// Token: 0x04000231 RID: 561
		internal static global::System.UriParser HttpsUri;

		// Token: 0x04000232 RID: 562
		internal static global::System.UriParser WsUri;

		// Token: 0x04000233 RID: 563
		internal static global::System.UriParser WssUri;

		// Token: 0x04000234 RID: 564
		internal static global::System.UriParser FtpUri;

		// Token: 0x04000235 RID: 565
		internal static global::System.UriParser FileUri;

		// Token: 0x04000236 RID: 566
		internal static global::System.UriParser GopherUri;

		// Token: 0x04000237 RID: 567
		internal static global::System.UriParser NntpUri;

		// Token: 0x04000238 RID: 568
		internal static global::System.UriParser NewsUri;

		// Token: 0x04000239 RID: 569
		internal static global::System.UriParser MailToUri;

		// Token: 0x0400023A RID: 570
		internal static global::System.UriParser UuidUri;

		// Token: 0x0400023B RID: 571
		internal static global::System.UriParser TelnetUri;

		// Token: 0x0400023C RID: 572
		internal static global::System.UriParser LdapUri;

		// Token: 0x0400023D RID: 573
		internal static global::System.UriParser NetTcpUri;

		// Token: 0x0400023E RID: 574
		internal static global::System.UriParser NetPipeUri;

		// Token: 0x0400023F RID: 575
		internal static global::System.UriParser VsMacrosUri;

		// Token: 0x04000240 RID: 576
		private static readonly global::System.UriParser.UriQuirksVersion s_QuirksVersion;

		// Token: 0x04000241 RID: 577
		private static readonly global::System.UriSyntaxFlags HttpSyntaxFlags;

		// Token: 0x04000242 RID: 578
		private static readonly global::System.UriSyntaxFlags FileSyntaxFlags;

		// Token: 0x02000093 RID: 147
		private enum UriQuirksVersion
		{
			// Token: 0x04000244 RID: 580
			V2 = 2,
			// Token: 0x04000245 RID: 581
			V3
		}

		// Token: 0x02000094 RID: 148
		private class BuiltInUriParser : global::System.UriParser
		{
			// Token: 0x060002A6 RID: 678 RVA: 0x0000A5E8 File Offset: 0x000087E8
			internal BuiltInUriParser(string lwrCaseScheme, int defaultPort, global::System.UriSyntaxFlags syntaxFlags)
			{
				if (!true)
				{
				}
				this.m_Scheme = lwrCaseScheme;
				this.m_Port = defaultPort;
			}
		}
	}
}
