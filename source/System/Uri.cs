using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Threading;
using Cpp2IlInjected;

namespace System
{
	// Token: 0x02000083 RID: 131
	[global::System.ComponentModel.TypeConverter(typeof(global::System.UriTypeConverter))]
	[Serializable]
	public class Uri : ISerializable
	{
		// Token: 0x17000065 RID: 101
		// (get) Token: 0x060001FB RID: 507 RVA: 0x00002050 File Offset: 0x00000250
		private bool IsImplicitFile
		{
			get
			{
				throw new global::Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		// Token: 0x17000066 RID: 102
		// (get) Token: 0x060001FC RID: 508 RVA: 0x00002050 File Offset: 0x00000250
		private bool IsUncOrDosPath
		{
			get
			{
				throw new global::Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		// Token: 0x17000067 RID: 103
		// (get) Token: 0x060001FD RID: 509 RVA: 0x00002050 File Offset: 0x00000250
		private bool IsDosPath
		{
			get
			{
				throw new global::Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		// Token: 0x17000068 RID: 104
		// (get) Token: 0x060001FE RID: 510 RVA: 0x00002050 File Offset: 0x00000250
		private bool IsUncPath
		{
			get
			{
				throw new global::Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		// Token: 0x17000069 RID: 105
		// (get) Token: 0x060001FF RID: 511 RVA: 0x00006CAC File Offset: 0x00004EAC
		private global::System.Uri.Flags HostType
		{
			get
			{
				/*
An exception occurred when decompiling this method (060001FF)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Uri/Flags System.Uri::get_HostType()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:Flags(var_0_06, ldfld:Flags(Uri::m_Flags, ldloc:Uri(this)))
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

		// Token: 0x1700006A RID: 106
		// (get) Token: 0x06000200 RID: 512 RVA: 0x00006CC0 File Offset: 0x00004EC0
		private global::System.UriParser Syntax
		{
			get
			{
				return this.m_Syntax;
			}
		}

		// Token: 0x1700006B RID: 107
		// (get) Token: 0x06000201 RID: 513 RVA: 0x00006CD4 File Offset: 0x00004ED4
		private bool IsNotAbsoluteUri
		{
			get
			{
				/*
An exception occurred when decompiling this method (06000201)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean System.Uri::get_IsNotAbsoluteUri()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:UriParser(var_0_06, ldfld:UriParser(Uri::m_Syntax, ldloc:Uri(this)))
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

		// Token: 0x06000202 RID: 514 RVA: 0x00006CE8 File Offset: 0x00004EE8
		internal static bool IriParsingStatic(global::System.UriParser syntax)
		{
			if (!true)
			{
			}
			return true;
		}

		// Token: 0x1700006C RID: 108
		// (get) Token: 0x06000203 RID: 515 RVA: 0x00006CFC File Offset: 0x00004EFC
		private bool AllowIdn
		{
			get
			{
				global::System.UriParser syntax = this.m_Syntax;
				if (syntax != null)
				{
				}
				if (syntax == null)
				{
				}
				return true;
			}
		}

		// Token: 0x06000204 RID: 516 RVA: 0x00006D1C File Offset: 0x00004F1C
		private bool AllowIdnStatic(global::System.UriParser syntax, global::System.Uri.Flags flags)
		{
			if (syntax != null)
			{
			}
			if (!true)
			{
			}
			return true;
		}

		// Token: 0x06000205 RID: 517 RVA: 0x00006D38 File Offset: 0x00004F38
		private bool IsIntranet(string schemeHost)
		{
		}

		// Token: 0x1700006D RID: 109
		// (get) Token: 0x06000206 RID: 518 RVA: 0x00002050 File Offset: 0x00000250
		internal bool UserDrivenParsing
		{
			get
			{
				throw new global::Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		// Token: 0x06000207 RID: 519 RVA: 0x00006D48 File Offset: 0x00004F48
		private void SetUserDrivenParsing()
		{
			global::System.Uri.Flags flags = this.m_Flags;
			this.m_Flags = flags;
		}

		// Token: 0x1700006E RID: 110
		// (get) Token: 0x06000208 RID: 520 RVA: 0x00006D64 File Offset: 0x00004F64
		private ushort SecuredPathIndex
		{
			get
			{
			}
		}

		// Token: 0x06000209 RID: 521 RVA: 0x00006D74 File Offset: 0x00004F74
		private bool NotAny(global::System.Uri.Flags flags)
		{
			/*
An exception occurred when decompiling this method (06000209)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean System.Uri::NotAny(System.Uri/Flags)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:Flags(var_0_06, ldfld:Flags(Uri::m_Flags, ldloc:Uri(this)))
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

		// Token: 0x0600020A RID: 522 RVA: 0x00006D88 File Offset: 0x00004F88
		private bool InFact(global::System.Uri.Flags flags)
		{
			/*
An exception occurred when decompiling this method (0600020A)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean System.Uri::InFact(System.Uri/Flags)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:Flags(var_0_06, ldfld:Flags(Uri::m_Flags, ldloc:Uri(this)))
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

		// Token: 0x0600020B RID: 523 RVA: 0x00002050 File Offset: 0x00000250
		private static bool StaticNotAny(global::System.Uri.Flags allFlags, global::System.Uri.Flags checkFlags)
		{
			throw new global::Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x0600020C RID: 524 RVA: 0x00002050 File Offset: 0x00000250
		private static bool StaticInFact(global::System.Uri.Flags allFlags, global::System.Uri.Flags checkFlags)
		{
			throw new global::Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x0600020D RID: 525 RVA: 0x00006D9C File Offset: 0x00004F9C
		private global::System.Uri.UriInfo EnsureUriInfo()
		{
			global::System.Uri.Flags flags = this.m_Flags;
			this.CreateUriInfo(flags);
			return this.m_Info;
		}

		// Token: 0x0600020E RID: 526 RVA: 0x00006DC0 File Offset: 0x00004FC0
		private void EnsureParseRemaining()
		{
			global::System.Uri.Flags flags = this.m_Flags;
			this.ParseRemaining();
		}

		// Token: 0x0600020F RID: 527 RVA: 0x00006DDC File Offset: 0x00004FDC
		private void EnsureHostString(bool allowDnsOptimization)
		{
			global::System.Uri.Flags flags = this.m_Flags;
			this.CreateUriInfo(flags);
			if (this.m_Info.Host != null)
			{
				return;
			}
			this.CreateHostString();
		}

		// Token: 0x06000210 RID: 528 RVA: 0x00006E0C File Offset: 0x0000500C
		public Uri(string uriString)
		{
			do
			{
				base..ctor();
			}
			while (uriString == null);
			long num = 0L;
			this.CreateThis(uriString, num != 0L, global::System.UriKind.Absolute);
		}

		// Token: 0x06000211 RID: 529 RVA: 0x00006E30 File Offset: 0x00005030
		public Uri(string uriString, global::System.UriKind uriKind)
		{
			do
			{
				base..ctor();
			}
			while (uriString == null);
			long num = 0L;
			this.CreateThis(uriString, num != 0L, uriKind);
		}

		// Token: 0x06000212 RID: 530 RVA: 0x00006E54 File Offset: 0x00005054
		public Uri(global::System.Uri baseUri, string relativeUri)
		{
			do
			{
				base..ctor();
				if (baseUri == null)
				{
					return;
				}
			}
			while (baseUri.m_Syntax == null);
			long num = 0L;
			this.CreateUri(baseUri, relativeUri, num != 0L);
		}

		// Token: 0x06000213 RID: 531 RVA: 0x00006E80 File Offset: 0x00005080
		private void CreateUri(global::System.Uri baseUri, string relativeUri, bool dontEscape)
		{
			do
			{
				bool isSimple = baseUri.m_Syntax.IsSimple;
				if (!true)
				{
				}
			}
			while (relativeUri != null);
			if (true)
			{
				global::System.Uri uri;
				if (uri != null)
				{
					this.CreateThisFromUri(uri);
					return;
				}
			}
			else
			{
				global::System.Uri uri;
				while (uri != null)
				{
				}
			}
			string text;
			long num;
			this.CreateThis(text, num != 0L, global::System.UriKind.Absolute);
		}

		// Token: 0x06000214 RID: 532 RVA: 0x00006EC8 File Offset: 0x000050C8
		public Uri(global::System.Uri baseUri, global::System.Uri relativeUri)
		{
			global::System.Uri.Flags flags;
			for (;;)
			{
				base..ctor();
				if (baseUri == null)
				{
					return;
				}
				if (baseUri.m_Syntax != null)
				{
					this.CreateThisFromUri(relativeUri);
					bool isSimple = baseUri.m_Syntax.IsSimple;
					flags = this.m_Flags;
					if (flags == global::System.Uri.Flags.Zero)
					{
					}
					if (relativeUri == null)
					{
						break;
					}
				}
			}
			if (flags != global::System.Uri.Flags.Zero)
			{
				global::System.Uri uri;
				if (uri != null)
				{
					this.CreateThisFromUri(uri);
					return;
				}
			}
			else
			{
				global::System.Uri uri;
				while (uri != null)
				{
				}
			}
			string text;
			long num;
			this.CreateThis(text, num != 0L, global::System.UriKind.Absolute);
		}

		// Token: 0x06000215 RID: 533 RVA: 0x00006F34 File Offset: 0x00005134
		private static global::System.ParsingError GetCombinedString(global::System.Uri baseUri, string relativeStr, bool dontEscape, string result)
		{
			/*
An exception occurred when decompiling this method (06000215)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.ParsingError System.Uri::GetCombinedString(System.Uri,System.String,System.Boolean,System.String)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0056:
	stloc:int32(var_20_5D, ldfld:int32(string::_stringLength, ldloc:string(var_15)))
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

		// Token: 0x06000216 RID: 534 RVA: 0x00006FA0 File Offset: 0x000051A0
		private static global::System.UriFormatException GetException(global::System.ParsingError err)
		{
			return "Invalid URI: The Authority/Host could not be parsed.";
		}

		// Token: 0x06000217 RID: 535 RVA: 0x00006FC0 File Offset: 0x000051C0
		protected Uri(SerializationInfo serializationInfo, StreamingContext streamingContext)
		{
			string @string;
			for (;;)
			{
				base..ctor();
				if (serializationInfo.GetString("AbsoluteUri")._stringLength != 0)
				{
					break;
				}
				@string = serializationInfo.GetString("RelativeUri");
				if (@string != null)
				{
					goto Block_1;
				}
			}
			return;
			Block_1:
			long num = 0L;
			this.CreateThis(@string, num != 0L, global::System.UriKind.Relative);
		}

		// Token: 0x06000218 RID: 536 RVA: 0x00007000 File Offset: 0x00005200
		void ISerializable.GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext)
		{
			this.GetObjectData(serializationInfo, streamingContext);
		}

		// Token: 0x06000219 RID: 537 RVA: 0x00007018 File Offset: 0x00005218
		protected void GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext)
		{
			if (this.m_Syntax == null)
			{
			}
			string components = this.GetComponents((global::System.UriComponents)32768, global::System.UriFormat.UriEscaped);
			serializationInfo.AddValue("RelativeUri", components);
		}

		// Token: 0x1700006F RID: 111
		// (get) Token: 0x0600021A RID: 538 RVA: 0x00007048 File Offset: 0x00005248
		public string AbsolutePath
		{
			get
			{
				/*
An exception occurred when decompiling this method (0600021A)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.String System.Uri::get_AbsolutePath()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0023:
	stloc:string(var_3_2D, call:string(SR::GetString, ldstr:string("This operation is not supported for a relative URI.")))
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

		// Token: 0x17000070 RID: 112
		// (get) Token: 0x0600021B RID: 539 RVA: 0x00007084 File Offset: 0x00005284
		private string PrivateAbsolutePath
		{
			get
			{
				global::System.Uri.Flags flags = this.m_Flags;
				this.CreateUriInfo(flags);
				global::System.Uri.UriInfo info = this.m_Info;
				if (info.MoreInfo == null)
				{
				}
				string components = this.GetComponents(global::System.UriComponents.Path, global::System.UriFormat.UriEscaped);
				info.MoreInfo.Path = components;
				return components;
			}
		}

		// Token: 0x17000071 RID: 113
		// (get) Token: 0x0600021C RID: 540 RVA: 0x000070C8 File Offset: 0x000052C8
		public string AbsoluteUri
		{
			get
			{
				/*
An exception occurred when decompiling this method (0600021C)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.String System.Uri::get_AbsoluteUri()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_003D:
	stloc:string(var_3_47, call:string(SR::GetString, ldstr:string("This operation is not supported for a relative URI.")))
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

		// Token: 0x17000072 RID: 114
		// (get) Token: 0x0600021D RID: 541 RVA: 0x0000711C File Offset: 0x0000531C
		public string LocalPath
		{
			get
			{
				/*
An exception occurred when decompiling this method (0600021D)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.String System.Uri::get_LocalPath()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_000F:
	stloc:string(var_0_19, call:string(SR::GetString, ldstr:string("This operation is not supported for a relative URI.")))
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

		// Token: 0x17000073 RID: 115
		// (get) Token: 0x0600021E RID: 542 RVA: 0x00007144 File Offset: 0x00005344
		public string Authority
		{
			get
			{
				/*
An exception occurred when decompiling this method (0600021E)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.String System.Uri::get_Authority()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0012:
	stloc:string(var_0_1C, call:string(SR::GetString, ldstr:string("This operation is not supported for a relative URI.")))
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

		// Token: 0x17000074 RID: 116
		// (get) Token: 0x0600021F RID: 543 RVA: 0x00007170 File Offset: 0x00005370
		public global::System.UriHostNameType HostNameType
		{
			get
			{
				/*
An exception occurred when decompiling this method (0600021F)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.UriHostNameType System.Uri::get_HostNameType()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0039:
	stloc:string(var_6_43, call:string(SR::GetString, ldstr:string("This operation is not supported for a relative URI.")))
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

		// Token: 0x17000075 RID: 117
		// (get) Token: 0x06000220 RID: 544 RVA: 0x000071C4 File Offset: 0x000053C4
		public bool IsDefaultPort
		{
			get
			{
				/*
An exception occurred when decompiling this method (06000220)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean System.Uri::get_IsDefaultPort()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0028:
	stloc:string(var_4_32, call:string(SR::GetString, ldstr:string("This operation is not supported for a relative URI.")))
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

		// Token: 0x17000076 RID: 118
		// (get) Token: 0x06000221 RID: 545 RVA: 0x00007204 File Offset: 0x00005404
		public bool IsFile
		{
			get
			{
				/*
An exception occurred when decompiling this method (06000221)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean System.Uri::get_IsFile()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0011:
	stloc:string(var_2_1B, call:string(SR::GetString, ldstr:string("This operation is not supported for a relative URI.")))
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

		// Token: 0x17000077 RID: 119
		// (get) Token: 0x06000222 RID: 546 RVA: 0x0000722C File Offset: 0x0000542C
		public bool IsLoopback
		{
			get
			{
				/*
An exception occurred when decompiling this method (06000222)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean System.Uri::get_IsLoopback()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0011:
	stloc:string(var_1_1B, call:string(SR::GetString, ldstr:string("This operation is not supported for a relative URI.")))
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

		// Token: 0x17000078 RID: 120
		// (get) Token: 0x06000223 RID: 547 RVA: 0x00007254 File Offset: 0x00005454
		public string PathAndQuery
		{
			get
			{
				/*
An exception occurred when decompiling this method (06000223)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.String System.Uri::get_PathAndQuery()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0026:
	stloc:string(var_3_30, call:string(SR::GetString, ldstr:string("This operation is not supported for a relative URI.")))
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

		// Token: 0x17000079 RID: 121
		// (get) Token: 0x06000224 RID: 548 RVA: 0x00007294 File Offset: 0x00005494
		public string[] Segments
		{
			get
			{
				if (this.m_Syntax != null)
				{
					string privateAbsolutePath = this.PrivateAbsolutePath;
					if (privateAbsolutePath._stringLength != 0)
					{
						int stringLength = privateAbsolutePath._stringLength;
						long num = 0L;
						int num2 = 47;
						int num3 = privateAbsolutePath.IndexOf((char)num2, (int)num);
						int stringLength2 = privateAbsolutePath._stringLength;
						string text = privateAbsolutePath.Substring((int)num, (int)num);
						if (privateAbsolutePath._stringLength == 0)
						{
						}
					}
				}
				string @string = SR.GetString("This operation is not supported for a relative URI.");
				throw new InvalidCastException();
			}
		}

		// Token: 0x1700007A RID: 122
		// (get) Token: 0x06000225 RID: 549 RVA: 0x000072FC File Offset: 0x000054FC
		public bool IsUnc
		{
			get
			{
				/*
An exception occurred when decompiling this method (06000225)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean System.Uri::get_IsUnc()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0008:
	stloc:string(var_0_12, call:string(SR::GetString, ldstr:string("This operation is not supported for a relative URI.")))
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

		// Token: 0x1700007B RID: 123
		// (get) Token: 0x06000226 RID: 550 RVA: 0x0000731C File Offset: 0x0000551C
		public string Host
		{
			get
			{
				/*
An exception occurred when decompiling this method (06000226)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.String System.Uri::get_Host()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0011:
	stloc:string(var_0_1B, call:string(SR::GetString, ldstr:string("This operation is not supported for a relative URI.")))
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

		// Token: 0x06000227 RID: 551 RVA: 0x00007344 File Offset: 0x00005544
		private static bool StaticIsFile(global::System.UriParser syntax)
		{
			bool flag;
			return flag;
		}

		// Token: 0x1700007C RID: 124
		// (get) Token: 0x06000228 RID: 552 RVA: 0x00007354 File Offset: 0x00005554
		private static object InitializeLock
		{
			get
			{
				/*
An exception occurred when decompiling this method (06000228)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Object System.Uri::get_InitializeLock()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0005:
	brtrue(IL_0000, ldloc:int32[exp:bool](var_0_01))
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

		// Token: 0x06000229 RID: 553 RVA: 0x00007368 File Offset: 0x00005568
		private static void InitializeUriConfig()
		{
			if (!true)
			{
			}
			if (!true)
			{
			}
			object initializeLock = global::System.Uri.InitializeLock;
			if (!true)
			{
			}
			if (!true)
			{
			}
			long num = 0L;
			if (true)
			{
				Monitor.Exit(initializeLock);
			}
			if (num == 0L)
			{
				return;
			}
			throw new OutOfMemoryException();
		}

		// Token: 0x0600022A RID: 554 RVA: 0x000073B8 File Offset: 0x000055B8
		private string GetLocalPath()
		{
			int num;
			do
			{
				global::System.Uri.Flags flags = this.m_Flags;
				this.ParseRemaining();
				global::System.Uri.UriInfo info = this.m_Info;
				ushort host = info.Offset.Host;
				ushort path = info.Offset.Path;
				bool isFile = this.IsFile;
				bool originalStringSwitched = this.OriginalStringSwitched;
				num = 24;
				bool isLoopback = this.IsLoopback;
				global::System.Uri.UriInfo info2 = this.m_Info;
				ushort host2 = info2.Offset.Host;
				ushort path2 = info2.Offset.Path;
				bool originalStringSwitched2 = this.OriginalStringSwitched;
				ushort path3 = this.m_Info.Offset.Path;
				long num2 = 0L;
				global::System.Uri.Flags flags2 = this.m_Flags;
				if (path3 == 0)
				{
				}
			}
			while (num != 0);
			global::System.Uri.Flags flags3 = this.m_Flags;
			if (false)
			{
				long num3 = 0L;
				this.EnsureHostString(num3 != 0L);
				global::System.Uri.Flags flags4 = this.m_Flags;
				if (8212 == 0)
				{
					global::System.Uri.UriInfo info3 = this.m_Info;
					ushort path4 = info3.Offset.Path;
				}
				else
				{
					global::System.Uri.UriInfo info4 = this.m_Info;
					string host3 = info4.Host;
					ushort path5 = info4.Offset.Path;
					int stringLength = host3._stringLength;
					ushort fragment = info4.Offset.Fragment;
					long num2;
					global::System.Uri.UriInfo info3;
					ushort end;
					if (num2 != 0L)
					{
						int num4 = 2;
						int stringLength2 = host3._stringLength;
						global::System.UriParser syntax = this.m_Syntax;
						if (num4 == 0)
						{
						}
						ushort host4 = info3.Offset.Host;
						ushort host5 = info3.Offset.Host;
						ushort query = info3.Offset.Query;
						end = info3.Offset.End;
						string @string = this.m_String;
						string string2 = this.m_String;
						string string3 = this.m_String;
						global::System.Uri.UriInfo info5 = this.m_Info;
						string string4 = this.m_String;
						ushort query2 = info5.Offset.Query;
						return string4;
					}
					char c = this.m_String[(int)path5];
					char c2 = this.m_String[(int)path5];
					global::System.Uri.Flags flags5 = this.m_Flags;
					global::System.Uri.UriInfo info6 = this.m_Info;
					string string5 = this.m_String;
					global::System.UriParser syntax2 = this.m_Syntax;
					ushort query3 = info6.Offset.Query;
					if (info6 == null)
					{
					}
					global::System.Uri.Flags flags6 = this.m_Flags;
					global::System.UriParser syntax3 = this.m_Syntax;
					if (info3 == null)
					{
					}
					int num5 = 92;
					end.m_value = (ushort)num5;
					string text;
					return text;
				}
			}
			string text2;
			return text2;
		}

		// Token: 0x1700007D RID: 125
		// (get) Token: 0x0600022B RID: 555 RVA: 0x00007664 File Offset: 0x00005864
		public int Port
		{
			get
			{
				/*
An exception occurred when decompiling this method (0600022B)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Int32 System.Uri::get_Port()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0046:
	stloc:string(var_5_50, call:string(SR::GetString, ldstr:string("This operation is not supported for a relative URI.")))
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

		// Token: 0x1700007E RID: 126
		// (get) Token: 0x0600022C RID: 556 RVA: 0x000076C4 File Offset: 0x000058C4
		public string Query
		{
			get
			{
				/*
An exception occurred when decompiling this method (0600022C)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.String System.Uri::get_Query()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_003D:
	stloc:string(var_3_47, call:string(SR::GetString, ldstr:string("This operation is not supported for a relative URI.")))
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

		// Token: 0x1700007F RID: 127
		// (get) Token: 0x0600022D RID: 557 RVA: 0x00007718 File Offset: 0x00005918
		public string Fragment
		{
			get
			{
				/*
An exception occurred when decompiling this method (0600022D)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.String System.Uri::get_Fragment()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_003D:
	stloc:string(var_3_47, call:string(SR::GetString, ldstr:string("This operation is not supported for a relative URI.")))
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

		// Token: 0x17000080 RID: 128
		// (get) Token: 0x0600022E RID: 558 RVA: 0x0000776C File Offset: 0x0000596C
		public string Scheme
		{
			get
			{
				/*
An exception occurred when decompiling this method (0600022E)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.String System.Uri::get_Scheme()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0011:
	stloc:string(var_1_1B, call:string(SR::GetString, ldstr:string("This operation is not supported for a relative URI.")))
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

		// Token: 0x17000081 RID: 129
		// (get) Token: 0x0600022F RID: 559 RVA: 0x00007794 File Offset: 0x00005994
		private bool OriginalStringSwitched
		{
			get
			{
				if (this.m_iriParsing)
				{
				}
				bool allowIdn = this.AllowIdn;
				global::System.Uri.Flags flags = this.m_Flags;
				return allowIdn;
			}
		}

		// Token: 0x17000082 RID: 130
		// (get) Token: 0x06000230 RID: 560 RVA: 0x000077BC File Offset: 0x000059BC
		public string OriginalString
		{
			get
			{
				/*
An exception occurred when decompiling this method (06000230)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.String System.Uri::get_OriginalString()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:bool(var_0_06, callgetter:bool(Uri::get_OriginalStringSwitched, ldloc:Uri(this)))
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

		// Token: 0x17000083 RID: 131
		// (get) Token: 0x06000231 RID: 561 RVA: 0x000077D0 File Offset: 0x000059D0
		public string DnsSafeHost
		{
			get
			{
				/*
An exception occurred when decompiling this method (06000231)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.String System.Uri::get_DnsSafeHost()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_00B4:
	stloc:string(var_16_BE, call:string(SR::GetString, ldstr:string("This operation is not supported for a relative URI.")))
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

		// Token: 0x17000084 RID: 132
		// (get) Token: 0x06000232 RID: 562 RVA: 0x0000789C File Offset: 0x00005A9C
		public bool IsAbsoluteUri
		{
			get
			{
				/*
An exception occurred when decompiling this method (06000232)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean System.Uri::get_IsAbsoluteUri()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:UriParser(var_0_06, ldfld:UriParser(Uri::m_Syntax, ldloc:Uri(this)))
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

		// Token: 0x17000085 RID: 133
		// (get) Token: 0x06000233 RID: 563 RVA: 0x00002050 File Offset: 0x00000250
		public bool UserEscaped
		{
			get
			{
				throw new global::Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		// Token: 0x17000086 RID: 134
		// (get) Token: 0x06000234 RID: 564 RVA: 0x000078B0 File Offset: 0x00005AB0
		public string UserInfo
		{
			get
			{
				/*
An exception occurred when decompiling this method (06000234)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.String System.Uri::get_UserInfo()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0011:
	stloc:string(var_0_1B, call:string(SR::GetString, ldstr:string("This operation is not supported for a relative URI.")))
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

		// Token: 0x06000235 RID: 565 RVA: 0x000078D8 File Offset: 0x00005AD8
		public static global::System.UriHostNameType CheckHostName(string name)
		{
			/*
An exception occurred when decompiling this method (06000235)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.UriHostNameType System.Uri::CheckHostName(System.String)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0021:
	stloc:int32(var_15_28, ldfld:int32(string::_stringLength, ldloc:string(var_11)))
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

		// Token: 0x06000236 RID: 566 RVA: 0x00007914 File Offset: 0x00005B14
		internal static bool IsGenDelim(char ch)
		{
		}

		// Token: 0x06000237 RID: 567 RVA: 0x00007924 File Offset: 0x00005B24
		public static bool IsHexDigit(char character)
		{
		}

		// Token: 0x06000238 RID: 568 RVA: 0x00002050 File Offset: 0x00000250
		public static int FromHex(char digit)
		{
			throw new global::Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06000239 RID: 569 RVA: 0x00007934 File Offset: 0x00005B34
		public override int GetHashCode()
		{
			if (this.m_Syntax != null)
			{
				global::System.Uri.Flags flags = this.m_Flags;
				this.CreateUriInfo(flags);
				global::System.Uri.UriInfo info = this.m_Info;
				if (info.MoreInfo == null)
				{
				}
				int num = global::System.Uri.CalculateCaseInsensitiveHashCode(this.GetComponents(global::System.UriComponents.HttpRequestUrl, global::System.UriFormat.SafeUnescaped));
				info.MoreInfo.Hash = num;
				return num;
			}
			bool originalStringSwitched = this.OriginalStringSwitched;
			if (24 == 0)
			{
			}
			int num2;
			return num2;
		}

		// Token: 0x0600023A RID: 570 RVA: 0x00007990 File Offset: 0x00005B90
		public override string ToString()
		{
			/*
An exception occurred when decompiling this method (0600023A)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.String System.Uri::ToString()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0050:
	stloc:UriInfo(var_6_56, ldfld:UriInfo(Uri::m_Info, ldloc:Uri(this)))
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

		// Token: 0x0600023B RID: 571 RVA: 0x000079F4 File Offset: 0x00005BF4
		public static bool operator ==(global::System.Uri uri1, global::System.Uri uri2)
		{
			if (uri1 != null)
			{
			}
			return true;
		}

		// Token: 0x0600023C RID: 572 RVA: 0x00007A08 File Offset: 0x00005C08
		public static bool operator !=(global::System.Uri uri1, global::System.Uri uri2)
		{
			/*
An exception occurred when decompiling this method (0600023C)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean System.Uri::op_Inequality(System.Uri,System.Uri)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0000:
	brtrue(IL_0000, logicnot:bool(ldloc:Uri[exp:bool](uri1)))
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

		// Token: 0x0600023D RID: 573 RVA: 0x00007A18 File Offset: 0x00005C18
		public override bool Equals(object comparand)
		{
			/*
An exception occurred when decompiling this method (0600023D)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean System.Uri::Equals(System.Object)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_00CA:
	stloc:string(var_26_D6, ldfld:string(MoreInfo::RemoteUrl, ldfld:MoreInfo(UriInfo::MoreInfo, ldloc:UriInfo(var_23_9C))))
	stloc:int32(var_28_DF, ldfld:int32(string::_stringLength, ldloc:string(var_24)))
	stloc:int32(var_29_E8, ldfld:int32(string::_stringLength, ldloc:string(var_25)))
	stloc:int32(var_31_F2, callgetter:int32(RuntimeHelpers::get_OffsetToStringData))
	stloc:int32(var_33_FC, callgetter:int32(RuntimeHelpers::get_OffsetToStringData))
	stloc:UriInfo(var_36_10A, ldfld:UriInfo(Uri::m_Info, ldloc:Uri(this)))
	stloc:uint16(var_37_118, ldfld:uint16(Offset::Host, ldfld:Offset[exp:valuetype System.Uri/Offset&](UriInfo::Offset, ldloc:UriInfo(var_36_10A))))
	stloc:uint16(var_38_126, ldfld:uint16(Offset::Path, ldfld:Offset[exp:valuetype System.Uri/Offset&](UriInfo::Offset, ldloc:UriInfo(var_36_10A))))
	stloc:char(var_39_135, callgetter:char(string::get_Chars, ldfld:string(Uri::m_String, ldloc:Uri(this)), ldloc:uint16[exp:int32](var_37_118)))
	stloc:uint16(var_42_147, ldfld:uint16(Offset::Path, ldfld:Offset[exp:valuetype System.Uri/Offset&](UriInfo::Offset, ldfld:UriInfo(Uri::m_Info, ldloc:Uri(this)))))
	stloc:char(var_43_156, callgetter:char(string::get_Chars, ldfld:string(Uri::m_String, ldloc:Uri(this)), ldloc:uint16[exp:int32](var_37_118)))
	stloc:char(var_44_161, callgetter:char(string::get_Chars, ldloc:string(var_24), ldloc:uint16[exp:int32](var_37_118)))
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

		// Token: 0x0600023E RID: 574 RVA: 0x00007B88 File Offset: 0x00005D88
		private static bool CheckForColonInFirstPathSegment(string uriString)
		{
		}

		// Token: 0x0600023F RID: 575 RVA: 0x00007B98 File Offset: 0x00005D98
		internal static string InternalEscapeString(string rawString)
		{
			char[] array;
			while (array == null)
			{
			}
			string text;
			return text;
		}

		// Token: 0x06000240 RID: 576 RVA: 0x00007BB0 File Offset: 0x00005DB0
		private static global::System.ParsingError ParseScheme(string uriString, global::System.Uri.Flags flags, global::System.UriParser syntax)
		{
			/*
An exception occurred when decompiling this method (06000240)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.ParsingError System.Uri::ParseScheme(System.String,System.Uri/Flags,System.UriParser)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:int32(var_2_0D, callgetter:int32(RuntimeHelpers::get_OffsetToStringData))
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

		// Token: 0x06000241 RID: 577 RVA: 0x00007BD0 File Offset: 0x00005DD0
		internal global::System.UriFormatException ParseMinimal()
		{
			global::System.ParsingError parsingError = this.PrivateParseMinimal();
			if (parsingError != global::System.ParsingError.None)
			{
				global::System.Uri.Flags flags = this.m_Flags;
				this.m_Flags = flags;
				if (flags == global::System.Uri.Flags.Zero)
				{
				}
				return global::System.Uri.GetException(parsingError);
			}
		}

		// Token: 0x06000242 RID: 578 RVA: 0x00007C00 File Offset: 0x00005E00
		private global::System.ParsingError PrivateParseMinimal()
		{
			/*
An exception occurred when decompiling this method (06000242)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.ParsingError System.Uri::PrivateParseMinimal()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0073:
	stloc:UriParser(var_18_79, ldfld:UriParser(Uri::m_Syntax, ldloc:Uri(this)))
	stloc:UriParser(var_20_81, ldfld:UriParser(Uri::m_Syntax, ldloc:Uri(this)))
	stloc:Flags(var_22_89, ldfld:Flags(Uri::m_Flags, ldloc:Uri(this)))
	stloc:UriParser(var_23_91, ldfld:UriParser(Uri::m_Syntax, ldloc:Uri(this)))
	stfld:Flags(Uri::m_Flags, ldloc:Uri(this), ldloc:Flags(var_22_89))
	stloc:UriParser(var_25_A1, ldfld:UriParser(Uri::m_Syntax, ldloc:Uri(this)))
	stloc:UriParser(var_27_A9, ldfld:UriParser(Uri::m_Syntax, ldloc:Uri(this)))
	stloc:UriParser(var_29_B1, ldfld:UriParser(Uri::m_Syntax, ldloc:Uri(this)))
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

		// Token: 0x06000243 RID: 579 RVA: 0x00007CC0 File Offset: 0x00005EC0
		private void PrivateParseMinimalIri(string newHost, ushort idx)
		{
			if (newHost != null)
			{
				this.m_String = newHost;
			}
			if (this.m_iriParsing)
			{
				bool allowIdn = this.AllowIdn;
				global::System.Uri.Flags flags = this.m_Flags;
				return;
			}
			bool allowIdn2 = this.AllowIdn;
			global::System.Uri.Flags flags2 = this.m_Flags;
			string @string = this.m_String;
			string originalUnicodeString = this.m_originalUnicodeString;
			this.m_Flags = flags2;
			int stringLength = originalUnicodeString._stringLength;
			string text2;
			string text = @string + text2;
			this.m_String = text;
			if (this.m_iriParsing)
			{
				global::System.Uri.Flags flags3 = this.m_Flags;
				this.m_Flags = flags3;
				return;
			}
		}

		// Token: 0x06000244 RID: 580 RVA: 0x00007D54 File Offset: 0x00005F54
		private void CreateUriInfo(global::System.Uri.Flags cF)
		{
			int stringLength = this.m_String._stringLength;
			int stringLength2 = this.m_Syntax.m_Scheme._stringLength;
		}

		// Token: 0x06000245 RID: 581 RVA: 0x00007E30 File Offset: 0x00006030
		private void CreateHostString()
		{
			global::System.UriParser syntax = this.m_Syntax;
			long num = 0L;
			bool isSimple = syntax.IsSimple;
			global::System.Uri.UriInfo info = this.m_Info;
			Monitor.Enter(info, num != 0L);
			global::System.Uri.Flags flags = this.m_Flags;
			this.m_Flags = flags;
			this.GetHostViaCustomSyntax();
			global::System.Uri.Flags flags2 = this.m_Flags;
			this.m_Flags = flags2;
		}

		// Token: 0x06000246 RID: 582 RVA: 0x00008010 File Offset: 0x00006210
		private static string CreateHostStringHelper(string str, ushort idx, ushort end, global::System.Uri.Flags flags, string scopeId)
		{
			string text;
			return text;
		}

		// Token: 0x06000247 RID: 583 RVA: 0x00008030 File Offset: 0x00006230
		private void GetHostViaCustomSyntax()
		{
			if (this.m_Info.Host != null)
			{
				return;
			}
			global::System.UriParser syntax = this.m_Syntax;
			if (this.m_Info.Host == null)
			{
				string text;
				int stringLength = text._stringLength;
				global::System.Uri.Flags flags = this.m_Flags;
				int offsetToStringData = RuntimeHelpers.OffsetToStringData;
				int stringLength2 = text._stringLength;
				global::System.UriParser syntax2 = this.m_Syntax;
				int stringLength3 = text._stringLength;
				if (flags == global::System.Uri.Flags.Zero)
				{
				}
				global::System.Uri.Flags flags2 = this.m_Flags;
				int num = 5;
				this.m_Flags = (global::System.Uri.Flags)num;
			}
			global::System.UriParser syntax3 = this.m_Syntax;
			string text2;
			if (text2 != null && text2._stringLength != 0)
			{
				long num2 = 0L;
				char c = text2[(int)num2];
				int stringLength4 = text2._stringLength;
				return;
			}
			global::System.Uri.Flags flags3 = this.m_Flags;
			global::System.Uri.UriInfo info = this.m_Info;
			this.m_Flags = flags3;
		}

		// Token: 0x06000248 RID: 584 RVA: 0x000081F4 File Offset: 0x000063F4
		internal string GetParts(global::System.UriComponents uriParts, global::System.UriFormat formatAs)
		{
			return this.GetComponents(uriParts, formatAs);
		}

		// Token: 0x06000249 RID: 585 RVA: 0x0000820C File Offset: 0x0000640C
		private string GetEscapedParts(global::System.UriComponents uriParts)
		{
			global::System.Uri.Flags flags = this.m_Flags;
			global::System.Uri.UriInfo info = this.m_Info;
			string @string = this.m_String;
			ushort path = info.Offset.Path;
			ushort securedPathIndex = this.SecuredPathIndex;
			string text;
			return text;
		}

		// Token: 0x0600024A RID: 586 RVA: 0x00008254 File Offset: 0x00006454
		private string GetUnescapedParts(global::System.UriComponents uriParts, global::System.UriFormat formatAs)
		{
			global::System.Uri.Flags flags = this.m_Flags;
			global::System.Uri.UriInfo info = this.m_Info;
			string @string = this.m_String;
			ushort path = info.Offset.Path;
			ushort securedPathIndex = this.SecuredPathIndex;
			long num = 0L;
			return this.ReCreateParts(uriParts, (ushort)num, formatAs);
		}

		// Token: 0x0600024B RID: 587 RVA: 0x000082A8 File Offset: 0x000064A8
		private string ReCreateParts(global::System.UriComponents parts, ushort nonCanonical, global::System.UriFormat formatAs)
		{
			long num = 0L;
			this.EnsureHostString(num != 0L);
			global::System.Uri.UriInfo info = this.m_Info;
			global::System.Uri.UriInfo info2 = this.m_Info;
			ushort end = info2.Offset.End;
			ushort user = info2.Offset.User;
			int stringLength = this.m_Syntax.m_Scheme._stringLength;
			global::System.Uri.Flags flags = this.m_Flags;
			global::System.Uri.UriInfo info3 = this.m_Info;
			string @string = this.m_String;
			global::System.UriParser syntax = this.m_Syntax;
			ushort user2 = info3.Offset.User;
			ushort host = info3.Offset.Host;
			if (info3 == null)
			{
			}
			string scheme = this.m_Syntax.m_Scheme;
			int stringLength2 = scheme._stringLength;
			string scheme2 = this.m_Syntax.m_Scheme;
			int num2 = 58;
			int num3 = 47;
			num2.m_value = num3;
			num2.m_value = num3;
			return scheme;
		}

		// Token: 0x0600024C RID: 588 RVA: 0x00008684 File Offset: 0x00006884
		private string GetUriPartsFromUserString(global::System.UriComponents uriParts)
		{
			global::System.Uri.Flags flags = this.m_Flags;
			return ":";
		}

		// Token: 0x0600024D RID: 589 RVA: 0x00008ABC File Offset: 0x00006CBC
		private void ParseRemaining()
		{
			global::System.Uri.Flags flags = this.m_Flags;
			this.CreateUriInfo(flags);
			global::System.Uri.Flags flags2 = this.m_Flags;
			if (this.m_iriParsing)
			{
			}
			global::System.Uri.Offset offset = this.m_Info.Offset;
			string @string = this.m_String;
			global::System.UriParser syntax = this.m_Syntax;
			int stringLength = @string._stringLength;
			global::System.UriSyntaxFlags flags3 = syntax.m_Flags;
			if (@string != null)
			{
				int offsetToStringData = RuntimeHelpers.OffsetToStringData;
			}
			if (syntax == null)
			{
			}
		}

		// Token: 0x0600024E RID: 590 RVA: 0x00008F04 File Offset: 0x00007104
		private unsafe static ushort ParseSchemeCheckImplicitFile(char* uriString, ushort length, global::System.ParsingError err, global::System.Uri.Flags flags, global::System.UriParser syntax)
		{
			/*
An exception occurred when decompiling this method (0600024E)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.UInt16 System.Uri::ParseSchemeCheckImplicitFile(System.Char*,System.UInt16,System.ParsingError,System.Uri/Flags,System.UriParser)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_006C:
	stfld:int32(int32::m_value, ldloc:int32[exp:int32&](var_12), ldloc:ParsingError[exp:int32](var_15))
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

		// Token: 0x0600024F RID: 591 RVA: 0x00008F88 File Offset: 0x00007188
		private unsafe static bool CheckKnownSchemes(long* lptr, ushort nChars, global::System.UriParser syntax)
		{
			if (!true)
			{
			}
			nChars.m_value = 1;
			return true;
		}

		// Token: 0x06000250 RID: 592 RVA: 0x00008FD4 File Offset: 0x000071D4
		private unsafe static global::System.ParsingError CheckSchemeSyntax(char* ptr, ushort length, global::System.UriParser syntax)
		{
			/*
An exception occurred when decompiling this method (06000250)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.ParsingError System.Uri::CheckSchemeSyntax(System.Char*,System.UInt16,System.UriParser)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0009:
	stloc:UriParser(var_4_0F, call:UriParser(UriParser::FindOrFetchAsUnknownV1Syntax, ldloc:string(var_3)))
	stfld:uint16(uint16::m_value, ldloc:uint16[exp:uint16&](length), ldloc:UriParser[exp:uint16](var_4_0F))
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

		// Token: 0x06000251 RID: 593 RVA: 0x00009000 File Offset: 0x00007200
		private unsafe ushort CheckAuthorityHelper(char* pString, ushort idx, ushort length, global::System.ParsingError err, global::System.Uri.Flags flags, global::System.UriParser syntax, string newHost)
		{
			bool flag = global::System.Uri.IriParsingStatic(syntax);
			global::System.UriSyntaxFlags flags2 = syntax.m_Flags;
			int num = 8;
			err.value__ = num;
			return idx;
		}

		// Token: 0x06000252 RID: 594 RVA: 0x00009100 File Offset: 0x00007300
		private unsafe void CheckAuthorityHelperHandleDnsIri(char* pString, ushort start, int end, int startInput, bool iriParsing, bool hasUnicode, global::System.UriParser syntax, string userInfoString, global::System.Uri.Flags flags, bool justNormalized, string newHost, global::System.ParsingError err)
		{
			if (!true)
			{
			}
			int num = 1;
			if (num == 0)
			{
			}
			if (num == 0)
			{
				return;
			}
			if (num != 0)
			{
				return;
			}
			if (num == 0)
			{
			}
			string @string = this.m_String;
			long num2 = 0L;
			this.m_originalUnicodeString = @string;
			long num3;
			string text = @string.Substring((int)num2, (int)num3);
			int num4 = 1;
			if (num4 != 0 && num4 == 0)
			{
				return;
			}
			string text2;
			this.m_DnsSafeHost = text2;
		}

		// Token: 0x06000253 RID: 595 RVA: 0x00009174 File Offset: 0x00007374
		private unsafe void CheckAuthorityHelperHandleAnyHostIri(char* pString, int startInput, int end, bool iriParsing, bool hasUnicode, global::System.UriParser syntax, global::System.Uri.Flags flags, string newHost, global::System.ParsingError err)
		{
			if (true)
			{
				return;
			}
			long num = 0L;
			string text = global::System.DomainNameHelper.UnicodeEquivalent(pString, startInput, end, end != 0, num != 0L);
			string @string = this.m_String;
			long num2 = 0L;
			this.m_originalUnicodeString = @string;
			string text2 = @string.Substring((int)num2, startInput);
			iriParsing.m_value = text2 != null;
		}

		// Token: 0x06000254 RID: 596 RVA: 0x000091DC File Offset: 0x000073DC
		private void FindEndOfComponent(string input, ushort idx, ushort end, char delim)
		{
			if (input != null)
			{
				int offsetToStringData = RuntimeHelpers.OffsetToStringData;
			}
		}

		// Token: 0x06000255 RID: 597 RVA: 0x000091F4 File Offset: 0x000073F4
		private unsafe void FindEndOfComponent(char* str, ushort idx, ushort end, char delim)
		{
			if (this.m_Syntax != null)
			{
			}
		}

		// Token: 0x06000256 RID: 598 RVA: 0x0000920C File Offset: 0x0000740C
		private unsafe global::System.Uri.Check CheckCanonical(char* str, ushort idx, ushort end, char delim)
		{
			if (!this.m_iriParsing || (this.m_Syntax != null && this.m_Syntax == null) || this.m_Syntax != null)
			{
			}
			if (72 == 0)
			{
				return;
			}
		}

		// Token: 0x06000257 RID: 599 RVA: 0x00009264 File Offset: 0x00007464
		private char[] GetCanonicalPath(char[] dest, int pos, global::System.UriFormat formatAs)
		{
			global::System.Uri.UriInfo info = this.m_Info;
			ushort path = info.Offset.Path;
			ushort query = info.Offset.Query;
			ushort securedPathIndex = this.SecuredPathIndex;
			global::System.Uri.Flags flags = this.m_Flags;
			string @string = this.m_String;
			ushort path2 = this.m_Info.Offset.Path;
			ushort path3 = this.m_Info.Offset.Path;
			ushort path4 = this.m_Info.Offset.Path;
			global::System.Uri.UriInfo info2 = this.m_Info;
			ushort path5 = info2.Offset.Path;
			ushort query2 = info2.Offset.Query;
			char[] array;
			return array;
		}

		// Token: 0x06000258 RID: 600 RVA: 0x00009494 File Offset: 0x00007694
		private unsafe static void UnescapeOnly(char* pch, int start, int end, char ch1, char ch2, char ch3)
		{
			if (!true)
			{
			}
			char c = global::System.UriHelper.EscapedAscii(pch, (char)start);
		}

		// Token: 0x06000259 RID: 601 RVA: 0x000094BC File Offset: 0x000076BC
		private static char[] Compress(char[] dest, ushort start, int destLength, global::System.UriParser syntax)
		{
			/*
An exception occurred when decompiling this method (06000259)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Char[] System.Uri::Compress(System.Char[],System.UInt16,System.Int32,System.UriParser)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0017:
	stloc:bool(var_9_1F, callgetter:bool(UriParser::get_ShouldUseLegacyV2Quirks))
	brtrue(IL_0000, logicnot:bool(ldloc:int64[exp:bool](var_3_06)))
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

		// Token: 0x0600025A RID: 602 RVA: 0x000094F0 File Offset: 0x000076F0
		internal static int CalculateCaseInsensitiveHashCode(string text)
		{
			/*
An exception occurred when decompiling this method (0600025A)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Int32 System.Uri::CalculateCaseInsensitiveHashCode(System.String)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0003:
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

		// Token: 0x0600025B RID: 603 RVA: 0x00009504 File Offset: 0x00007704
		private static string CombineUri(global::System.Uri basePart, string relativePart, global::System.UriFormat uriFormat)
		{
			string @string = basePart.m_String;
			string text;
			return text;
		}

		// Token: 0x17000087 RID: 135
		// (get) Token: 0x0600025C RID: 604 RVA: 0x00002050 File Offset: 0x00000250
		internal bool HasAuthority
		{
			get
			{
				throw new global::Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		// Token: 0x0600025D RID: 605 RVA: 0x000096B8 File Offset: 0x000078B8
		private static bool IsLWS(char ch)
		{
		}

		// Token: 0x0600025E RID: 606 RVA: 0x000096C8 File Offset: 0x000078C8
		private static bool IsAsciiLetter(char character)
		{
		}

		// Token: 0x0600025F RID: 607 RVA: 0x000096D8 File Offset: 0x000078D8
		internal static bool IsAsciiLetterOrDigit(char character)
		{
			if (!true)
			{
				return;
			}
		}

		// Token: 0x06000260 RID: 608 RVA: 0x000096EC File Offset: 0x000078EC
		internal static bool IsBidiControlCharacter(char ch)
		{
		}

		// Token: 0x06000261 RID: 609 RVA: 0x000096FC File Offset: 0x000078FC
		internal unsafe static string StripBidiControlCharacter(char* strToClean, int start, int length)
		{
			string text;
			return text;
		}

		// Token: 0x06000262 RID: 610 RVA: 0x00009714 File Offset: 0x00007914
		private void CreateThis(string uri, bool dontEscape, global::System.UriKind uriKind)
		{
			do
			{
				if (uri == null)
				{
				}
				global::System.Uri.Flags flags = this.m_Flags;
				this.m_Flags = flags;
			}
			while (uriKind != global::System.UriKind.RelativeOrAbsolute);
		}

		// Token: 0x06000263 RID: 611 RVA: 0x00009740 File Offset: 0x00007940
		private void InitializeUri(global::System.ParsingError err, global::System.UriKind uriKind, [Out] global::System.UriFormatException e)
		{
			int num = 1;
			if (err != global::System.ParsingError.None)
			{
				if (num == 0)
				{
				}
				global::System.UriFormatException exception = global::System.Uri.GetException(err);
				return;
			}
			if (num == 0)
			{
			}
			string @string = this.m_String;
			if (num == 0)
			{
			}
			global::System.Uri.InitializeUriConfig();
			if (num == 0)
			{
			}
			if (this.m_Syntax != null)
			{
				this.m_iriParsing = num != 0;
				return;
			}
			int num2 = 1;
			this.m_iriParsing = num2 != 0;
			string string2 = this.m_String;
			string string3 = this.m_String;
			global::System.Uri.Flags flags = this.m_Flags;
			string string4 = this.m_String;
			this.m_originalUnicodeString = string4;
			this.m_Flags = flags;
		}

		// Token: 0x06000264 RID: 612 RVA: 0x0000992C File Offset: 0x00007B2C
		private bool CheckForConfigLoad(string data)
		{
			int stringLength = data._stringLength;
			if (data != null)
			{
				int offsetToStringData = RuntimeHelpers.OffsetToStringData;
				return;
			}
		}

		// Token: 0x06000265 RID: 613 RVA: 0x00009954 File Offset: 0x00007B54
		private bool CheckForUnicode(string data)
		{
			/*
An exception occurred when decompiling this method (06000265)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean System.Uri::CheckForUnicode(System.String)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:int32(var_0_06, ldfld:int32(string::_stringLength, ldloc:string(data)))
	stloc:int32(var_1_0D, ldfld:int32(string::_stringLength, ldloc:string(data)))
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

		// Token: 0x06000266 RID: 614 RVA: 0x0000997C File Offset: 0x00007B7C
		private bool CheckForEscapedUnreserved(string data)
		{
			/*
An exception occurred when decompiling this method (06000266)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean System.Uri::CheckForEscapedUnreserved(System.String)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_000B:
	stloc:int32(var_2_11, ldfld:int32(string::_stringLength, ldloc:string(data)))
	stloc:bool(var_5_1B, call:bool(UriHelper::Is3986Unreserved, ldloc:char(var_4)))
	stloc:int32(var_6_23, ldfld:int32(string::_stringLength, ldloc:string(data)))
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

		// Token: 0x06000267 RID: 615 RVA: 0x000099B4 File Offset: 0x00007BB4
		public static bool TryCreate(string uriString, global::System.UriKind uriKind, [Out] global::System.Uri result)
		{
			do
			{
				if (!true)
				{
				}
				global::System.Uri uri;
				uriKind.value__ = uri;
			}
			while (true);
			if (!true)
			{
				return;
			}
		}

		// Token: 0x06000268 RID: 616 RVA: 0x000099D4 File Offset: 0x00007BD4
		public static bool TryCreate(global::System.Uri baseUri, string relativeUri, [Out] global::System.Uri result)
		{
			if (!true)
			{
			}
			global::System.UriParser syntax = baseUri.m_Syntax;
			if (syntax != null)
			{
				return true;
			}
			if (syntax == null)
			{
			}
			bool flag;
			return flag;
		}

		// Token: 0x06000269 RID: 617 RVA: 0x000099F8 File Offset: 0x00007BF8
		public static bool TryCreate(global::System.Uri baseUri, global::System.Uri relativeUri, [Out] global::System.Uri result)
		{
			/*
An exception occurred when decompiling this method (06000269)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean System.Uri::TryCreate(System.Uri,System.Uri,System.Uri)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0018:
	brtrue(IL_0000, ldloc:Flags[exp:bool](var_2))
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

		// Token: 0x0600026A RID: 618 RVA: 0x00009A20 File Offset: 0x00007C20
		public string GetComponents(global::System.UriComponents components, global::System.UriFormat format)
		{
			global::System.UriParser syntax = this.m_Syntax;
			if (syntax != null)
			{
				bool isSimple = syntax.IsSimple;
				return this.GetComponentsHelper(components, format);
			}
			return this.GetRelativeSerializationString(format);
		}

		// Token: 0x0600026B RID: 619 RVA: 0x00009A74 File Offset: 0x00007C74
		public bool IsWellFormedOriginalString()
		{
			global::System.UriParser syntax = this.m_Syntax;
			if (syntax != null)
			{
				bool isSimple = syntax.IsSimple;
			}
			return this.InternalIsWellFormedOriginalString();
		}

		// Token: 0x0600026C RID: 620 RVA: 0x00009AA8 File Offset: 0x00007CA8
		public static bool IsWellFormedUriString(string uriString, global::System.UriKind uriKind)
		{
			if (!true)
			{
			}
			bool flag;
			return flag;
		}

		// Token: 0x0600026D RID: 621 RVA: 0x00009ABC File Offset: 0x00007CBC
		internal bool InternalIsWellFormedOriginalString()
		{
			if (this.m_String != null)
			{
				int offsetToStringData = RuntimeHelpers.OffsetToStringData;
			}
			if (this.m_Syntax != null)
			{
				global::System.Uri.Flags flags = this.m_Flags;
				this.ParseRemaining();
				global::System.Uri.Flags flags2 = this.m_Flags;
				if (!this.m_iriParsing)
				{
					goto IL_017A;
				}
				global::System.Uri.UriInfo info = this.m_Info;
				ushort query = info.Offset.Query;
				ushort path = info.Offset.Path;
				global::System.Uri.UriInfo info2 = this.m_Info;
				string @string = this.m_String;
				ushort path2 = info2.Offset.Path;
				ushort securedPathIndex = this.SecuredPathIndex;
				global::System.Uri.Flags flags3 = this.m_Flags;
				global::System.Uri.UriInfo info3 = this.m_Info;
				ushort user = info3.Offset.User;
				ushort path3 = info3.Offset.Path;
				if (!this.m_iriParsing)
				{
					goto IL_017D;
				}
				global::System.Uri.Flags flags4 = this.m_Flags;
				int stringLength = this.m_Syntax.m_Scheme._stringLength;
				int stringLength2 = this.m_String._stringLength;
			}
			bool shouldUseLegacyV2Quirks = global::System.UriParser.ShouldUseLegacyV2Quirks;
			bool flag = global::System.Uri.CheckForColonInFirstPathSegment(this.m_String);
			int stringLength3 = this.m_String._stringLength;
			global::System.UriParser syntax = this.m_Syntax;
			global::System.Uri.UriInfo info4 = this.m_Info;
			string scheme = syntax.m_Scheme;
			global::System.Uri.Offset offset = info4.Offset;
			int stringLength4 = scheme._stringLength;
			ushort user2 = info4.Offset.User;
			string string2 = this.m_String;
			string string3 = this.m_String;
			IL_017A:
			IL_017D:
			global::System.Uri.Flags flags5 = this.m_Flags;
			ushort user3 = this.m_Info.Offset.User;
			string string4 = this.m_String;
			string string5 = this.m_String;
			global::System.Uri.Flags flags6 = this.m_Flags;
			Type type = base.GetType();
			throw new ArrayTypeMismatchException();
		}

		// Token: 0x0600026E RID: 622 RVA: 0x00009C88 File Offset: 0x00007E88
		public static string UnescapeDataString(string stringToUnescape)
		{
			while (!true)
			{
			}
			int offsetToStringData = RuntimeHelpers.OffsetToStringData;
			string text;
			return text;
		}

		// Token: 0x0600026F RID: 623 RVA: 0x00009CAC File Offset: 0x00007EAC
		public static string EscapeDataString(string stringToEscape)
		{
			char[] array;
			while (array == null)
			{
			}
			string text;
			return text;
		}

		// Token: 0x06000270 RID: 624 RVA: 0x00009CC4 File Offset: 0x00007EC4
		internal string EscapeUnescapeIri(string input, int start, int end, global::System.UriComponents component)
		{
			if (input != null)
			{
				int offsetToStringData = RuntimeHelpers.OffsetToStringData;
			}
			string text;
			return text;
		}

		// Token: 0x06000271 RID: 625 RVA: 0x00009CE0 File Offset: 0x00007EE0
		private Uri(global::System.Uri.Flags flags, global::System.UriParser uriParser, string uri)
		{
			this.m_Flags = flags;
			this.m_Syntax = uriParser;
			this.m_String = uri;
		}

		// Token: 0x06000272 RID: 626 RVA: 0x00009D08 File Offset: 0x00007F08
		internal static global::System.Uri CreateHelper(string uriString, bool dontEscape, global::System.UriKind uriKind, global::System.UriFormatException e)
		{
			if (!true)
			{
			}
			global::System.ParsingError parsingError;
			if (parsingError != global::System.ParsingError.None)
			{
			}
			throw new ArrayTypeMismatchException();
		}

		// Token: 0x06000273 RID: 627 RVA: 0x00009D24 File Offset: 0x00007F24
		internal static global::System.Uri ResolveHelper(global::System.Uri baseUri, global::System.Uri relativeUri, string newUriString, bool userEscaped, [Out] global::System.UriFormatException e)
		{
			int num;
			while (baseUri != null)
			{
				global::System.UriParser syntax = baseUri.m_Syntax;
				if (syntax != null)
				{
					if (syntax == null)
					{
					}
					if (syntax != null)
					{
						continue;
					}
					bool originalStringSwitched = baseUri.OriginalStringSwitched;
				}
				bool originalStringSwitched2 = baseUri.OriginalStringSwitched;
				num = 24;
				global::System.Uri.Flags flags = baseUri.m_Flags;
				break;
			}
			if (num == 0)
			{
			}
			if (num == 0)
			{
			}
			string text;
			if (text._stringLength != 0)
			{
				long num2 = 0L;
				char c = text[(int)num2];
				long num3 = 0L;
				char c2 = text[(int)num3];
				string text3;
				string text2 = text3 + text;
				int stringLength = text._stringLength;
				int num4 = 1;
				char c3 = text[num4];
				int num5 = 1;
				char c4 = text[num5];
				long num6 = 0L;
				char c5 = text[(int)num6];
				if (num == 0)
				{
				}
				int num7 = 2;
				char c6 = text[num7];
				int num8 = 2;
				char c7 = text[num8];
				return;
			}
		}

		// Token: 0x06000274 RID: 628 RVA: 0x00009DF8 File Offset: 0x00007FF8
		private string GetRelativeSerializationString(global::System.UriFormat format)
		{
			if (this.m_String._stringLength == 0)
			{
				return 3;
			}
			char[] array;
			if (array != null)
			{
				string @string = this.m_String;
				return global::System.Uri.UnescapeDataString(@string);
			}
			return 3;
		}

		// Token: 0x06000275 RID: 629 RVA: 0x00009E48 File Offset: 0x00008048
		internal string GetComponentsHelper(global::System.UriComponents uriComponents, global::System.UriFormat uriFormat)
		{
			return this.m_Syntax.m_Scheme;
		}

		// Token: 0x06000276 RID: 630 RVA: 0x00009EC4 File Offset: 0x000080C4
		public bool IsBaseOf(global::System.Uri uri)
		{
			while (uri == null)
			{
			}
			global::System.UriParser syntax = this.m_Syntax;
			bool flag;
			if (syntax != null)
			{
				bool isSimple = syntax.IsSimple;
				flag = this.IsBaseOfHelper(uri);
				return flag;
			}
			return flag;
		}

		// Token: 0x06000277 RID: 631 RVA: 0x00009F00 File Offset: 0x00008100
		internal bool IsBaseOfHelper(global::System.Uri uriLink)
		{
			global::System.UriParser syntax;
			string text;
			string text2;
			for (;;)
			{
				if (this.m_Syntax != null)
				{
					if (uriLink.m_Syntax != null)
					{
						syntax = this.m_Syntax;
						global::System.UriParser syntax2 = uriLink.m_Syntax;
						string scheme = syntax.m_Scheme;
						string scheme2 = syntax2.m_Scheme;
						bool flag = scheme != scheme2;
						if (text == null)
						{
							break;
						}
						int offsetToStringData = RuntimeHelpers.OffsetToStringData;
						if (text2 == null)
						{
							goto IL_0064;
						}
						int offsetToStringData2 = RuntimeHelpers.OffsetToStringData;
					}
					if (syntax == null)
					{
					}
					if (syntax == null)
					{
						continue;
					}
				}
				if (!false)
				{
					goto Block_4;
				}
			}
			IL_0060:
			while (text2 != null)
			{
			}
			goto IL_0064;
			Block_4:
			if (syntax == null)
			{
			}
			while (syntax != null)
			{
			}
			goto IL_0060;
			IL_0064:
			int stringLength = text._stringLength;
			int stringLength2 = text2._stringLength;
			bool flag2;
			return flag2;
		}

		// Token: 0x06000278 RID: 632 RVA: 0x00009F88 File Offset: 0x00008188
		private void CreateThisFromUri(global::System.Uri otherUri)
		{
			global::System.Uri.Flags flags = otherUri.m_Flags;
			this.m_Flags = flags;
			ushort path = otherUri.m_Info.Offset.Path;
			char c = otherUri.m_String[(int)path];
			ushort host = otherUri.m_Info.Offset.Host;
			string @string = otherUri.m_String;
		}

		// Token: 0x06000279 RID: 633 RVA: 0x0000A06C File Offset: 0x0000826C
		// Note: this type is marked as 'beforefieldinit'.
		static Uri()
		{
			if (!true)
			{
			}
			bool flag = Environment.GetEnvironmentVariable("MONO_URI_IRIPARSING") == "false";
			bool flag2 = Environment.GetEnvironmentVariable("MONO_URI_DOTNETRELATIVEORABSOLUTE") == "true";
		}

		// Token: 0x0400017A RID: 378
		public static readonly string UriSchemeFile;

		// Token: 0x0400017B RID: 379
		public static readonly string UriSchemeFtp;

		// Token: 0x0400017C RID: 380
		public static readonly string UriSchemeGopher;

		// Token: 0x0400017D RID: 381
		public static readonly string UriSchemeHttp;

		// Token: 0x0400017E RID: 382
		public static readonly string UriSchemeHttps;

		// Token: 0x0400017F RID: 383
		internal static readonly string UriSchemeWs;

		// Token: 0x04000180 RID: 384
		internal static readonly string UriSchemeWss;

		// Token: 0x04000181 RID: 385
		public static readonly string UriSchemeMailto;

		// Token: 0x04000182 RID: 386
		public static readonly string UriSchemeNews;

		// Token: 0x04000183 RID: 387
		public static readonly string UriSchemeNntp;

		// Token: 0x04000184 RID: 388
		public static readonly string UriSchemeNetTcp;

		// Token: 0x04000185 RID: 389
		public static readonly string UriSchemeNetPipe;

		// Token: 0x04000186 RID: 390
		public static readonly string SchemeDelimiter;

		// Token: 0x04000187 RID: 391
		private string m_String;

		// Token: 0x04000188 RID: 392
		private string m_originalUnicodeString;

		// Token: 0x04000189 RID: 393
		private global::System.UriParser m_Syntax;

		// Token: 0x0400018A RID: 394
		private string m_DnsSafeHost;

		// Token: 0x0400018B RID: 395
		private global::System.Uri.Flags m_Flags;

		// Token: 0x0400018C RID: 396
		private global::System.Uri.UriInfo m_Info;

		// Token: 0x0400018D RID: 397
		private bool m_iriParsing;

		// Token: 0x0400018E RID: 398
		private static bool s_ConfigInitialized;

		// Token: 0x0400018F RID: 399
		private static bool s_ConfigInitializing;

		// Token: 0x04000190 RID: 400
		private static global::System.UriIdnScope s_IdnScope;

		// Token: 0x04000191 RID: 401
		private static bool s_IriParsing;

		// Token: 0x04000192 RID: 402
		private static bool useDotNetRelativeOrAbsolute;

		// Token: 0x04000193 RID: 403
		internal static readonly bool IsWindowsFileSystem;

		// Token: 0x04000194 RID: 404
		private static object s_initLock;

		// Token: 0x04000195 RID: 405
		internal static readonly char[] HexLowerChars;

		// Token: 0x04000196 RID: 406
		private static readonly char[] _WSchars;

		// Token: 0x02000084 RID: 132
		[Flags]
		private enum Flags : ulong
		{
			// Token: 0x04000198 RID: 408
			Zero = 0UL,
			// Token: 0x04000199 RID: 409
			SchemeNotCanonical = 1UL,
			// Token: 0x0400019A RID: 410
			UserNotCanonical = 2UL,
			// Token: 0x0400019B RID: 411
			HostNotCanonical = 4UL,
			// Token: 0x0400019C RID: 412
			PortNotCanonical = 8UL,
			// Token: 0x0400019D RID: 413
			PathNotCanonical = 16UL,
			// Token: 0x0400019E RID: 414
			QueryNotCanonical = 32UL,
			// Token: 0x0400019F RID: 415
			FragmentNotCanonical = 64UL,
			// Token: 0x040001A0 RID: 416
			CannotDisplayCanonical = 127UL,
			// Token: 0x040001A1 RID: 417
			E_UserNotCanonical = 128UL,
			// Token: 0x040001A2 RID: 418
			E_HostNotCanonical = 256UL,
			// Token: 0x040001A3 RID: 419
			E_PortNotCanonical = 512UL,
			// Token: 0x040001A4 RID: 420
			E_PathNotCanonical = 1024UL,
			// Token: 0x040001A5 RID: 421
			E_QueryNotCanonical = 2048UL,
			// Token: 0x040001A6 RID: 422
			E_FragmentNotCanonical = 4096UL,
			// Token: 0x040001A7 RID: 423
			E_CannotDisplayCanonical = 8064UL,
			// Token: 0x040001A8 RID: 424
			ShouldBeCompressed = 8192UL,
			// Token: 0x040001A9 RID: 425
			FirstSlashAbsent = 16384UL,
			// Token: 0x040001AA RID: 426
			BackslashInPath = 32768UL,
			// Token: 0x040001AB RID: 427
			IndexMask = 65535UL,
			// Token: 0x040001AC RID: 428
			HostTypeMask = 458752UL,
			// Token: 0x040001AD RID: 429
			HostNotParsed = 0UL,
			// Token: 0x040001AE RID: 430
			IPv6HostType = 65536UL,
			// Token: 0x040001AF RID: 431
			IPv4HostType = 131072UL,
			// Token: 0x040001B0 RID: 432
			DnsHostType = 196608UL,
			// Token: 0x040001B1 RID: 433
			UncHostType = 262144UL,
			// Token: 0x040001B2 RID: 434
			BasicHostType = 327680UL,
			// Token: 0x040001B3 RID: 435
			UnusedHostType = 393216UL,
			// Token: 0x040001B4 RID: 436
			UnknownHostType = 458752UL,
			// Token: 0x040001B5 RID: 437
			UserEscaped = 524288UL,
			// Token: 0x040001B6 RID: 438
			AuthorityFound = 1048576UL,
			// Token: 0x040001B7 RID: 439
			HasUserInfo = 2097152UL,
			// Token: 0x040001B8 RID: 440
			LoopbackHost = 4194304UL,
			// Token: 0x040001B9 RID: 441
			NotDefaultPort = 8388608UL,
			// Token: 0x040001BA RID: 442
			UserDrivenParsing = 16777216UL,
			// Token: 0x040001BB RID: 443
			CanonicalDnsHost = 33554432UL,
			// Token: 0x040001BC RID: 444
			ErrorOrParsingRecursion = 67108864UL,
			// Token: 0x040001BD RID: 445
			DosPath = 134217728UL,
			// Token: 0x040001BE RID: 446
			UncPath = 268435456UL,
			// Token: 0x040001BF RID: 447
			ImplicitFile = 536870912UL,
			// Token: 0x040001C0 RID: 448
			MinimalUriInfoSet = 1073741824UL,
			// Token: 0x040001C1 RID: 449
			AllUriInfoSet = 2147483648UL,
			// Token: 0x040001C2 RID: 450
			IdnHost = 4294967296UL,
			// Token: 0x040001C3 RID: 451
			HasUnicode = 8589934592UL,
			// Token: 0x040001C4 RID: 452
			HostUnicodeNormalized = 17179869184UL,
			// Token: 0x040001C5 RID: 453
			RestUnicodeNormalized = 34359738368UL,
			// Token: 0x040001C6 RID: 454
			UnicodeHost = 68719476736UL,
			// Token: 0x040001C7 RID: 455
			IntranetUri = 137438953472UL,
			// Token: 0x040001C8 RID: 456
			UseOrigUncdStrOffset = 274877906944UL,
			// Token: 0x040001C9 RID: 457
			UserIriCanonical = 549755813888UL,
			// Token: 0x040001CA RID: 458
			PathIriCanonical = 1099511627776UL,
			// Token: 0x040001CB RID: 459
			QueryIriCanonical = 2199023255552UL,
			// Token: 0x040001CC RID: 460
			FragmentIriCanonical = 4398046511104UL,
			// Token: 0x040001CD RID: 461
			IriCanonical = 8246337208320UL,
			// Token: 0x040001CE RID: 462
			CompressedSlashes = 17592186044416UL
		}

		// Token: 0x02000085 RID: 133
		private class UriInfo
		{
			// Token: 0x0600027A RID: 634 RVA: 0x0000A0A8 File Offset: 0x000082A8
			public UriInfo()
			{
			}

			// Token: 0x040001CF RID: 463
			public string Host;

			// Token: 0x040001D0 RID: 464
			public string ScopeId;

			// Token: 0x040001D1 RID: 465
			public string String;

			// Token: 0x040001D2 RID: 466
			public global::System.Uri.Offset Offset;

			// Token: 0x040001D3 RID: 467
			public string DnsSafeHost;

			// Token: 0x040001D4 RID: 468
			public global::System.Uri.MoreInfo MoreInfo;
		}

		// Token: 0x02000086 RID: 134
		[StructLayout(0, Pack = 1, Size = 16)]
		private struct Offset
		{
			// Token: 0x040001D5 RID: 469
			public ushort Scheme;

			// Token: 0x040001D6 RID: 470
			public ushort User;

			// Token: 0x040001D7 RID: 471
			public ushort Host;

			// Token: 0x040001D8 RID: 472
			public ushort PortValue;

			// Token: 0x040001D9 RID: 473
			public ushort Path;

			// Token: 0x040001DA RID: 474
			public ushort Query;

			// Token: 0x040001DB RID: 475
			public ushort Fragment;

			// Token: 0x040001DC RID: 476
			public ushort End;
		}

		// Token: 0x02000087 RID: 135
		private class MoreInfo
		{
			// Token: 0x0600027B RID: 635 RVA: 0x0000A0BC File Offset: 0x000082BC
			public MoreInfo()
			{
			}

			// Token: 0x040001DD RID: 477
			public string Path;

			// Token: 0x040001DE RID: 478
			public string Query;

			// Token: 0x040001DF RID: 479
			public string Fragment;

			// Token: 0x040001E0 RID: 480
			public string AbsoluteUri;

			// Token: 0x040001E1 RID: 481
			public int Hash;

			// Token: 0x040001E2 RID: 482
			public string RemoteUrl;
		}

		// Token: 0x02000088 RID: 136
		[Flags]
		private enum Check
		{
			// Token: 0x040001E4 RID: 484
			None = 0,
			// Token: 0x040001E5 RID: 485
			EscapedCanonical = 1,
			// Token: 0x040001E6 RID: 486
			DisplayCanonical = 2,
			// Token: 0x040001E7 RID: 487
			DotSlashAttn = 4,
			// Token: 0x040001E8 RID: 488
			DotSlashEscaped = 128,
			// Token: 0x040001E9 RID: 489
			BackslashInPath = 16,
			// Token: 0x040001EA RID: 490
			ReservedFound = 32,
			// Token: 0x040001EB RID: 491
			NotIriCanonical = 64,
			// Token: 0x040001EC RID: 492
			FoundNonAscii = 8
		}
	}
}
