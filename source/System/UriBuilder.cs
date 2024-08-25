using System;

namespace System
{
	// Token: 0x0200007E RID: 126
	public class UriBuilder
	{
		// Token: 0x060001E1 RID: 481 RVA: 0x0000650C File Offset: 0x0000470C
		public UriBuilder(global::System.Uri uri)
		{
			do
			{
				this._changed = true;
				this._host = "localhost";
				this._path = "/";
				this._scheme = "http";
				if ("http" == null)
				{
				}
				this._schemeDelimiter = "http";
				base..ctor();
			}
			while (uri == null);
			this.Init(uri);
		}

		// Token: 0x060001E2 RID: 482 RVA: 0x00006564 File Offset: 0x00004764
		private void Init(global::System.Uri uri)
		{
			int num = 1;
			string fragment = uri.Fragment;
			this._fragment = fragment;
			string query = uri.Query;
			this._query = query;
			string host = uri.Host;
			this._host = host;
			string absolutePath = uri.AbsolutePath;
			this._path = absolutePath;
			int port = uri.Port;
			this._port = port;
			string scheme = uri.Scheme;
			this._scheme = scheme;
			bool hasAuthority = uri.HasAuthority;
			if (num == 0)
			{
			}
		}

		// Token: 0x17000062 RID: 98
		// (set) Token: 0x060001E3 RID: 483 RVA: 0x00006638 File Offset: 0x00004838
		public string Path
		{
			set
			{
				if (value == null || value._stringLength == 0)
				{
				}
				string text2;
				string text = global::System.Uri.InternalEscapeString(text2);
				this._path = text;
				this._changed = true;
			}
		}

		// Token: 0x17000063 RID: 99
		// (set) Token: 0x060001E4 RID: 484 RVA: 0x00006668 File Offset: 0x00004868
		public string Query
		{
			set
			{
				if (value == null)
				{
				}
				string text;
				this._query = text;
				this._changed = true;
			}
		}

		// Token: 0x17000064 RID: 100
		// (get) Token: 0x060001E5 RID: 485 RVA: 0x00006688 File Offset: 0x00004888
		public global::System.Uri Uri
		{
			get
			{
				if (this._changed)
				{
				}
				return this._uri;
			}
		}

		// Token: 0x060001E6 RID: 486 RVA: 0x000066A4 File Offset: 0x000048A4
		public override bool Equals(object rparam)
		{
			if (rparam != null)
			{
				global::System.Uri uri = this.Uri;
				return;
			}
		}

		// Token: 0x060001E7 RID: 487 RVA: 0x000066BC File Offset: 0x000048BC
		public override int GetHashCode()
		{
			/*
An exception occurred when decompiling this method (060001E7)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Int32 System.UriBuilder::GetHashCode()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:Uri(var_0_06, callgetter:Uri(UriBuilder::get_Uri, ldloc:UriBuilder(this)))
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

		// Token: 0x060001E8 RID: 488 RVA: 0x000066D0 File Offset: 0x000048D0
		private void SetFieldsFromUri(global::System.Uri uri)
		{
			int num = 1;
			string fragment = uri.Fragment;
			this._fragment = fragment;
			string query = uri.Query;
			this._query = query;
			string host = uri.Host;
			this._host = host;
			string absolutePath = uri.AbsolutePath;
			this._path = absolutePath;
			int port = uri.Port;
			this._port = port;
			string scheme = uri.Scheme;
			this._scheme = scheme;
			bool hasAuthority = uri.HasAuthority;
			if (num == 0)
			{
			}
		}

		// Token: 0x060001E9 RID: 489 RVA: 0x0000679C File Offset: 0x0000499C
		public override string ToString()
		{
			if (this._username._stringLength == 0)
			{
				int stringLength = this._password._stringLength;
			}
			string scheme = this._scheme;
			string text;
			if (scheme._stringLength != 0)
			{
				global::System.UriParser syntax = global::System.UriParser.GetSyntax(scheme);
				if (syntax != null)
				{
					global::System.UriSyntaxFlags flags = syntax.m_Flags;
					if (this._host._stringLength != 0)
					{
						goto IL_005A;
					}
				}
				int stringLength2 = this._host._stringLength;
				if (stringLength2 == 0)
				{
					return text;
				}
				IL_005A:
				if (stringLength2 == 0)
				{
				}
			}
			string scheme2 = this._scheme;
			if (scheme2._stringLength != 0)
			{
				string schemeDelimiter = this._schemeDelimiter;
				return scheme2 + schemeDelimiter;
			}
			string username = this._username;
			if (username == null || username != null)
			{
				string password = this._password;
				int stringLength3 = password._stringLength;
				string text2 = ":" + password;
				if (text2 == null)
				{
					return text2;
				}
				int stringLength4 = this._username._stringLength;
				string host = this._host;
				if (host == null || host != null)
				{
					int port = this._port;
					int stringLength5 = this._host._stringLength;
					string text4;
					string text3 = ":" + text4;
					if (text3 == null)
					{
						return text3;
					}
					int stringLength6 = this._host._stringLength;
					string path = this._path;
					if (path._stringLength != 0)
					{
						long num = 0L;
						char c = path[(int)num];
					}
					string path2 = this._path;
					if (path2 == null || path2 != null)
					{
						string query = this._query;
						if (query == null || query != null)
						{
							string fragment = this._fragment;
							if (fragment == null || fragment != null)
							{
								return text;
							}
						}
					}
				}
			}
			throw new ArrayTypeMismatchException();
		}

		// Token: 0x04000160 RID: 352
		private bool _changed;

		// Token: 0x04000161 RID: 353
		private string _fragment;

		// Token: 0x04000162 RID: 354
		private string _host;

		// Token: 0x04000163 RID: 355
		private string _password;

		// Token: 0x04000164 RID: 356
		private string _path;

		// Token: 0x04000165 RID: 357
		private int _port;

		// Token: 0x04000166 RID: 358
		private string _query;

		// Token: 0x04000167 RID: 359
		private string _scheme;

		// Token: 0x04000168 RID: 360
		private string _schemeDelimiter;

		// Token: 0x04000169 RID: 361
		private global::System.Uri _uri;

		// Token: 0x0400016A RID: 362
		private string _username;
	}
}
