using System;
using System.Collections;
using System.Globalization;
using System.Runtime.Serialization;

namespace System.Net
{
	// Token: 0x0200020C RID: 524
	[Serializable]
	public sealed class Cookie
	{
		// Token: 0x06000CC3 RID: 3267 RVA: 0x00028A28 File Offset: 0x00026C28
		public Cookie()
		{
			this.m_cookieVariant = CookieVariant.Plain;
			this.m_domain_implicit = true;
			this.m_path_implicit = true;
			this.m_port_implicit = true;
			DateTime now = DateTime.Now;
			this.m_timeStamp = now;
			base..ctor();
		}

		// Token: 0x06000CC4 RID: 3268 RVA: 0x00028A68 File Offset: 0x00026C68
		public Cookie(string name, string value)
		{
			this.m_cookieVariant = CookieVariant.Plain;
			this.m_domain_implicit = true;
			this.m_path_implicit = true;
			this.m_port_implicit = true;
			DateTime now = DateTime.Now;
			this.m_timeStamp = now;
			base..ctor();
			this.Name = name;
			this.m_value = value;
		}

		// Token: 0x06000CC5 RID: 3269 RVA: 0x00028AB4 File Offset: 0x00026CB4
		public Cookie(string name, string value, string path)
		{
			if (path == null)
			{
			}
		}

		// Token: 0x06000CC6 RID: 3270 RVA: 0x00028AC4 File Offset: 0x00026CC4
		public Cookie(string name, string value, string path, string domain)
		{
			this.Domain = domain;
		}

		// Token: 0x17000299 RID: 665
		// (get) Token: 0x06000CC7 RID: 3271 RVA: 0x00028ADC File Offset: 0x00026CDC
		// (set) Token: 0x06000CC8 RID: 3272 RVA: 0x00028AF0 File Offset: 0x00026CF0
		public string Comment
		{
			get
			{
				return this.m_comment;
			}
			set
			{
				if (value == null)
				{
				}
			}
		}

		// Token: 0x1700029A RID: 666
		// (get) Token: 0x06000CC9 RID: 3273 RVA: 0x00028B00 File Offset: 0x00026D00
		// (set) Token: 0x06000CCA RID: 3274 RVA: 0x00028B14 File Offset: 0x00026D14
		public global::System.Uri CommentUri
		{
			get
			{
				return this.m_commentUri;
			}
			set
			{
				this.m_commentUri = value;
			}
		}

		// Token: 0x1700029B RID: 667
		// (get) Token: 0x06000CCB RID: 3275 RVA: 0x00028B28 File Offset: 0x00026D28
		// (set) Token: 0x06000CCC RID: 3276 RVA: 0x00028B3C File Offset: 0x00026D3C
		public bool HttpOnly
		{
			get
			{
				return this.m_httpOnly;
			}
			set
			{
			}
		}

		// Token: 0x1700029C RID: 668
		// (get) Token: 0x06000CCD RID: 3277 RVA: 0x00028B4C File Offset: 0x00026D4C
		// (set) Token: 0x06000CCE RID: 3278 RVA: 0x00028B60 File Offset: 0x00026D60
		public bool Discard
		{
			get
			{
				return this.m_discard;
			}
			set
			{
			}
		}

		// Token: 0x1700029D RID: 669
		// (get) Token: 0x06000CCF RID: 3279 RVA: 0x00028B70 File Offset: 0x00026D70
		// (set) Token: 0x06000CD0 RID: 3280 RVA: 0x00028B84 File Offset: 0x00026D84
		public string Domain
		{
			get
			{
				return this.m_domain;
			}
			set
			{
				if (value == null)
				{
				}
				this.m_domain = value;
			}
		}

		// Token: 0x1700029E RID: 670
		// (get) Token: 0x06000CD1 RID: 3281 RVA: 0x00028B9C File Offset: 0x00026D9C
		private string _Domain
		{
			get
			{
				string domain;
				do
				{
					CookieVariant cookieVariant = this.m_cookieVariant;
					if (this.m_domain_implicit)
					{
					}
					domain = this.m_domain;
				}
				while (domain._stringLength == 0);
				if (this.IsQuotedDomain)
				{
					return "$Domain=";
				}
				return "$Domain=" + "\"" + domain + "\"";
			}
		}

		// Token: 0x1700029F RID: 671
		// (get) Token: 0x06000CD2 RID: 3282 RVA: 0x00028BEC File Offset: 0x00026DEC
		// (set) Token: 0x06000CD3 RID: 3283 RVA: 0x00028C00 File Offset: 0x00026E00
		internal bool DomainImplicit
		{
			get
			{
				return this.m_domain_implicit;
			}
			set
			{
			}
		}

		// Token: 0x170002A0 RID: 672
		// (get) Token: 0x06000CD4 RID: 3284 RVA: 0x00028C10 File Offset: 0x00026E10
		// (set) Token: 0x06000CD5 RID: 3285 RVA: 0x00028C40 File Offset: 0x00026E40
		public bool Expired
		{
			get
			{
				int num = 1;
				DateTime expires = this.m_expires;
				if (num == 0)
				{
				}
				DateTime now = DateTime.Now;
				DateTime dateTime;
				return dateTime <= now;
			}
			set
			{
				DateTime now = DateTime.Now;
				this.m_expires = now;
			}
		}

		// Token: 0x170002A1 RID: 673
		// (get) Token: 0x06000CD6 RID: 3286 RVA: 0x00028C5C File Offset: 0x00026E5C
		// (set) Token: 0x06000CD7 RID: 3287 RVA: 0x00028C74 File Offset: 0x00026E74
		public DateTime Expires
		{
			get
			{
				DateTime expires = this.m_expires;
				DateTime dateTime;
				return dateTime;
			}
			set
			{
				this.m_expires = value;
			}
		}

		// Token: 0x170002A2 RID: 674
		// (get) Token: 0x06000CD8 RID: 3288 RVA: 0x00028C88 File Offset: 0x00026E88
		// (set) Token: 0x06000CD9 RID: 3289 RVA: 0x00028C9C File Offset: 0x00026E9C
		public string Name
		{
			get
			{
				return this.m_name;
			}
			set
			{
				if (!true)
				{
				}
				bool flag = ValidationHelper.IsBlankString(value);
				bool flag2 = this.InternalSetName(value);
			}
		}

		// Token: 0x06000CDA RID: 3290 RVA: 0x00028CD8 File Offset: 0x00026ED8
		internal bool InternalSetName(string value)
		{
			if (!true)
			{
			}
			bool flag = ValidationHelper.IsBlankString(value);
			long num = 0L;
			char c = value[(int)num];
			if (!true)
			{
			}
			return true;
		}

		// Token: 0x170002A3 RID: 675
		// (get) Token: 0x06000CDB RID: 3291 RVA: 0x00028D00 File Offset: 0x00026F00
		// (set) Token: 0x06000CDC RID: 3292 RVA: 0x00028D14 File Offset: 0x00026F14
		public string Path
		{
			get
			{
				return this.m_path;
			}
			set
			{
			}
		}

		// Token: 0x170002A4 RID: 676
		// (get) Token: 0x06000CDD RID: 3293 RVA: 0x00028D24 File Offset: 0x00026F24
		private string _Path
		{
			get
			{
				do
				{
					CookieVariant cookieVariant = this.m_cookieVariant;
					if (this.m_path_implicit)
					{
					}
				}
				while (this.m_path._stringLength == 0);
				string text;
				return text;
			}
		}

		// Token: 0x170002A5 RID: 677
		// (get) Token: 0x06000CDE RID: 3294 RVA: 0x00028D50 File Offset: 0x00026F50
		internal bool Plain
		{
			get
			{
				/*
An exception occurred when decompiling this method (06000CDE)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean System.Net.Cookie::get_Plain()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:CookieVariant(var_0_06, ldfld:CookieVariant(Cookie::m_cookieVariant, ldloc:Cookie(this)))
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

		// Token: 0x06000CDF RID: 3295 RVA: 0x00028D64 File Offset: 0x00026F64
		internal Cookie Clone()
		{
			/*
An exception occurred when decompiling this method (06000CDF)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Net.Cookie System.Net.Cookie::Clone()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_004C:
	stloc:Uri(var_6_52, ldfld:Uri(Cookie::m_commentUri, ldloc:Cookie(this)))
	stloc:bool(var_7_5A, ldfld:bool(Cookie::m_httpOnly, ldloc:Cookie(this)))
	stloc:bool(var_8_62, ldfld:bool(Cookie::m_discard, ldloc:Cookie(this)))
	stloc:DateTime(var_9_6A, ldfld:DateTime(Cookie::m_expires, ldloc:Cookie(this)))
	stloc:int32(var_10_72, ldfld:int32(Cookie::m_version, ldloc:Cookie(this)))
	stloc:bool(var_11_7A, ldfld:bool(Cookie::m_secure, ldloc:Cookie(this)))
	stloc:CookieVariant(var_12_82, ldfld:CookieVariant(Cookie::m_cookieVariant, ldloc:Cookie(this)))
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

		// Token: 0x06000CE0 RID: 3296 RVA: 0x00028DF4 File Offset: 0x00026FF4
		private static bool IsDomainEqualToHost(string domain, string host)
		{
			for (;;)
			{
				int stringLength = domain._stringLength;
				int num;
				if (num != 0)
				{
					return;
				}
			}
		}

		// Token: 0x06000CE1 RID: 3297 RVA: 0x00028E0C File Offset: 0x0002700C
		internal bool VerifySetDefaults(CookieVariant variant, global::System.Uri uri, bool isLocalDomain, string localDomain, bool set_default, bool isThrow)
		{
			string host = uri.Host;
			int port = uri.Port;
			string absolutePath = uri.AbsolutePath;
			if (this.m_version != 0)
			{
			}
			int num = 1;
			this.m_cookieVariant = (CookieVariant)num;
			string name = this.m_name;
			if (name != null)
			{
				int stringLength = name._stringLength;
				if (stringLength != 0)
				{
					long num2 = 0L;
					char c = name[(int)num2];
					string name2 = this.m_name;
					if (stringLength == 0)
					{
					}
				}
			}
			string value = this.m_value;
			if (value != null)
			{
				int stringLength2 = value._stringLength;
				long num3 = 0L;
				char c2 = value[(int)num3];
				string value2 = this.m_value;
				int stringLength3 = value2._stringLength;
				char c3 = value2[(int)num3];
				string value3 = this.m_value;
				if (stringLength3 == 0)
				{
				}
			}
			if ("Value" != null && "Value" == null)
			{
				throw new ArrayTypeMismatchException();
			}
			string value4 = this.m_value;
			if (value4 != null)
			{
				string value5 = this.m_value;
				return "The '{0}'='{1}' part of the cookie is invalid." != null;
			}
			return "<null>" != null;
		}

		// Token: 0x06000CE2 RID: 3298 RVA: 0x0002906C File Offset: 0x0002726C
		private static bool DomainCharsTest(string name)
		{
		}

		// Token: 0x170002A6 RID: 678
		// (get) Token: 0x06000CE3 RID: 3299 RVA: 0x00029080 File Offset: 0x00027280
		// (set) Token: 0x06000CE4 RID: 3300 RVA: 0x00029094 File Offset: 0x00027294
		public string Port
		{
			get
			{
				return this.m_port;
			}
			set
			{
				if (value != null && value._stringLength != 0)
				{
					long num = 0L;
					char c = value[(int)num];
					int stringLength = value._stringLength;
					char c2 = value[(int)num];
					if (stringLength == 0)
					{
					}
					return;
				}
			}
		}

		// Token: 0x170002A7 RID: 679
		// (get) Token: 0x06000CE5 RID: 3301 RVA: 0x000290FC File Offset: 0x000272FC
		internal int[] PortList
		{
			get
			{
				return this.m_port_list;
			}
		}

		// Token: 0x170002A8 RID: 680
		// (get) Token: 0x06000CE6 RID: 3302 RVA: 0x00029110 File Offset: 0x00027310
		private string _Port
		{
			get
			{
				if (this.m_port_implicit)
				{
				}
				if (this.m_port._stringLength != 0)
				{
					string text;
					return text;
				}
				string text2;
				return text2;
			}
		}

		// Token: 0x170002A9 RID: 681
		// (get) Token: 0x06000CE7 RID: 3303 RVA: 0x00029138 File Offset: 0x00027338
		// (set) Token: 0x06000CE8 RID: 3304 RVA: 0x0002914C File Offset: 0x0002734C
		public bool Secure
		{
			get
			{
				return this.m_secure;
			}
			set
			{
			}
		}

		// Token: 0x170002AA RID: 682
		// (get) Token: 0x06000CE9 RID: 3305 RVA: 0x0002915C File Offset: 0x0002735C
		public DateTime TimeStamp
		{
			get
			{
				DateTime timeStamp = this.m_timeStamp;
				DateTime dateTime;
				return dateTime;
			}
		}

		// Token: 0x170002AB RID: 683
		// (get) Token: 0x06000CEA RID: 3306 RVA: 0x00029174 File Offset: 0x00027374
		// (set) Token: 0x06000CEB RID: 3307 RVA: 0x00029188 File Offset: 0x00027388
		public string Value
		{
			get
			{
				return this.m_value;
			}
			set
			{
				if (value == null)
				{
				}
			}
		}

		// Token: 0x170002AC RID: 684
		// (get) Token: 0x06000CEC RID: 3308 RVA: 0x00029198 File Offset: 0x00027398
		// (set) Token: 0x06000CED RID: 3309 RVA: 0x000291AC File Offset: 0x000273AC
		internal CookieVariant Variant
		{
			get
			{
				return this.m_cookieVariant;
			}
			set
			{
				this.m_cookieVariant = value;
			}
		}

		// Token: 0x170002AD RID: 685
		// (get) Token: 0x06000CEE RID: 3310 RVA: 0x000291C0 File Offset: 0x000273C0
		internal string DomainKey
		{
			get
			{
				/*
An exception occurred when decompiling this method (06000CEE)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.String System.Net.Cookie::get_DomainKey()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:bool(var_0_06, ldfld:bool(Cookie::m_domain_implicit, ldloc:Cookie(this)))
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

		// Token: 0x170002AE RID: 686
		// (get) Token: 0x06000CEF RID: 3311 RVA: 0x000291D4 File Offset: 0x000273D4
		// (set) Token: 0x06000CF0 RID: 3312 RVA: 0x000291E8 File Offset: 0x000273E8
		public int Version
		{
			get
			{
				return this.m_version;
			}
			set
			{
				this.m_version = value;
				if (value != 0)
				{
					CookieVariant cookieVariant = this.m_cookieVariant;
					this.m_cookieVariant = CookieVariant.Rfc2109;
				}
			}
		}

		// Token: 0x170002AF RID: 687
		// (get) Token: 0x06000CF1 RID: 3313 RVA: 0x00029210 File Offset: 0x00027410
		private string _Version
		{
			get
			{
				if (this.m_version != 0 && this.IsQuotedVersion)
				{
					return "\"";
				}
				NumberFormatInfo invariantInfo = NumberFormatInfo.InvariantInfo;
				if (this.IsQuotedVersion)
				{
					string text;
					return text;
				}
				string text2;
				return text2;
			}
		}

		// Token: 0x06000CF2 RID: 3314 RVA: 0x00029248 File Offset: 0x00027448
		internal static IComparer GetComparer()
		{
			/*
An exception occurred when decompiling this method (06000CF2)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Collections.IComparer System.Net.Cookie::GetComparer()

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

		// Token: 0x06000CF3 RID: 3315 RVA: 0x00029258 File Offset: 0x00027458
		public override bool Equals(object comparand)
		{
			/*
An exception occurred when decompiling this method (06000CF3)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean System.Net.Cookie::Equals(System.Object)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0032:
	stloc:int32(var_9_38, ldfld:int32(Cookie::m_version, ldloc:Cookie(this)))
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

		// Token: 0x06000CF4 RID: 3316 RVA: 0x000292A0 File Offset: 0x000274A0
		public override int GetHashCode()
		{
			string name = this.m_name;
			if ((name == null || name != null) && ("=" == null || "=" != null))
			{
				string value = this.m_value;
				if ((value == null || value != null) && (";" == null || ";" != null))
				{
					string path = this.m_path;
					if ((path == null || path != null) && ("; " == null || "; " != null))
					{
						string domain = this.m_domain;
						if ((domain == null || domain != null) && ("; " == null || "; " != null))
						{
							int version = this.m_version;
							string text;
							if (text == null || text != null)
							{
							}
						}
					}
				}
			}
			throw new ArrayTypeMismatchException();
		}

		// Token: 0x06000CF5 RID: 3317 RVA: 0x00029334 File Offset: 0x00027534
		public override string ToString()
		{
			string domain = this._Domain;
			string path = this._Path;
			string port = this._Port;
			string version = this._Version;
			if (version._stringLength != 0)
			{
				string text = version + "; ";
				if (text == null)
				{
					return text;
				}
			}
			string name = this.m_name;
			if ((name == null || name != null) && ("=" == null || "=" != null))
			{
				string value = this.m_value;
				if (value == null || value != null)
				{
					if (path._stringLength != 0)
					{
						string text2 = "; " + path;
						if (text2 == null)
						{
							return text2;
						}
					}
					if (domain._stringLength != 0)
					{
						string text3 = "; " + domain;
						if (text3 == null)
						{
							return text3;
						}
					}
					if (port._stringLength != 0)
					{
						string text4 = "; " + port;
						if (text4 == null)
						{
							return text4;
						}
					}
					string text5;
					bool flag = text5 == "=";
				}
			}
			throw new ArrayTypeMismatchException();
		}

		// Token: 0x06000CF6 RID: 3318 RVA: 0x00029414 File Offset: 0x00027614
		internal string ToServerString()
		{
			string name = this.m_name;
			string value = this.m_value;
			string text = name + "=" + value;
			string comment = this.m_comment;
			if (comment != null)
			{
				int stringLength = comment._stringLength;
				string text2 = text + "; Comment=" + comment;
			}
			global::System.Uri commentUri = this.m_commentUri;
			if ("; Comment=" == null)
			{
			}
			global::System.Uri commentUri2 = this.m_commentUri;
			string text3;
			if (this.m_discard)
			{
				string text4;
				text3 = text4 + "; Discard";
			}
			bool domain_implicit = this.m_domain_implicit;
			string text7;
			string text9;
			if (domain_implicit)
			{
				DateTime expires = this.m_expires;
				if (!domain_implicit)
				{
				}
				DateTime expires2 = this.m_expires;
				DateTime now = DateTime.Now;
				DateTime dateTime;
				double totalSeconds = (dateTime - now).TotalSeconds;
				NumberFormatInfo invariantInfo = NumberFormatInfo.InvariantInfo;
				string text6;
				string text5 = text3 + "; Max-Age=" + text6;
				if (!this.m_path_implicit)
				{
					string path = this.m_path;
					while (path == null)
					{
					}
					int stringLength2 = path._stringLength;
					return text7 + "; Path=" + path;
				}
				CookieVariant cookieVariant = this.m_cookieVariant;
				string text8;
				if (!this.m_port_implicit)
				{
					string port = this.m_port;
					if (port != null)
					{
						int stringLength3 = port._stringLength;
						text8 = text5 + "; Port=" + port;
					}
				}
				int version = this.m_version;
				NumberFormatInfo invariantInfo2 = NumberFormatInfo.InvariantInfo;
				string text10;
				text9 = text8 + "; Version=" + text10;
				bool flag = text9 == "=";
			}
			string domain = this.m_domain;
			while (domain == null)
			{
			}
			int stringLength4 = domain._stringLength;
			text7 = text9 + "; Domain=" + domain;
			return text7;
		}

		// Token: 0x06000CF7 RID: 3319 RVA: 0x0002959C File Offset: 0x0002779C
		// Note: this type is marked as 'beforefieldinit'.
		static Cookie()
		{
		}

		// Token: 0x04000AE6 RID: 2790
		internal const int MaxSupportedVersion = 1;

		// Token: 0x04000AE7 RID: 2791
		internal const string CommentAttributeName = "Comment";

		// Token: 0x04000AE8 RID: 2792
		internal const string CommentUrlAttributeName = "CommentURL";

		// Token: 0x04000AE9 RID: 2793
		internal const string DiscardAttributeName = "Discard";

		// Token: 0x04000AEA RID: 2794
		internal const string DomainAttributeName = "Domain";

		// Token: 0x04000AEB RID: 2795
		internal const string ExpiresAttributeName = "Expires";

		// Token: 0x04000AEC RID: 2796
		internal const string MaxAgeAttributeName = "Max-Age";

		// Token: 0x04000AED RID: 2797
		internal const string PathAttributeName = "Path";

		// Token: 0x04000AEE RID: 2798
		internal const string PortAttributeName = "Port";

		// Token: 0x04000AEF RID: 2799
		internal const string SecureAttributeName = "Secure";

		// Token: 0x04000AF0 RID: 2800
		internal const string VersionAttributeName = "Version";

		// Token: 0x04000AF1 RID: 2801
		internal const string HttpOnlyAttributeName = "HttpOnly";

		// Token: 0x04000AF2 RID: 2802
		internal const string SeparatorLiteral = "; ";

		// Token: 0x04000AF3 RID: 2803
		internal const string EqualsLiteral = "=";

		// Token: 0x04000AF4 RID: 2804
		internal const string QuotesLiteral = "\"";

		// Token: 0x04000AF5 RID: 2805
		internal const string SpecialAttributeLiteral = "$";

		// Token: 0x04000AF6 RID: 2806
		internal static readonly char[] PortSplitDelimiters;

		// Token: 0x04000AF7 RID: 2807
		internal static readonly char[] Reserved2Name;

		// Token: 0x04000AF8 RID: 2808
		internal static readonly char[] Reserved2Value;

		// Token: 0x04000AF9 RID: 2809
		private static Comparer staticComparer;

		// Token: 0x04000AFA RID: 2810
		private string m_comment;

		// Token: 0x04000AFB RID: 2811
		private global::System.Uri m_commentUri;

		// Token: 0x04000AFC RID: 2812
		private CookieVariant m_cookieVariant;

		// Token: 0x04000AFD RID: 2813
		private bool m_discard;

		// Token: 0x04000AFE RID: 2814
		private string m_domain;

		// Token: 0x04000AFF RID: 2815
		private bool m_domain_implicit;

		// Token: 0x04000B00 RID: 2816
		private DateTime m_expires;

		// Token: 0x04000B01 RID: 2817
		private string m_name;

		// Token: 0x04000B02 RID: 2818
		private string m_path;

		// Token: 0x04000B03 RID: 2819
		private bool m_path_implicit;

		// Token: 0x04000B04 RID: 2820
		private string m_port;

		// Token: 0x04000B05 RID: 2821
		private bool m_port_implicit;

		// Token: 0x04000B06 RID: 2822
		private int[] m_port_list;

		// Token: 0x04000B07 RID: 2823
		private bool m_secure;

		// Token: 0x04000B08 RID: 2824
		[OptionalField]
		private bool m_httpOnly;

		// Token: 0x04000B09 RID: 2825
		private DateTime m_timeStamp;

		// Token: 0x04000B0A RID: 2826
		private string m_value;

		// Token: 0x04000B0B RID: 2827
		private int m_version;

		// Token: 0x04000B0C RID: 2828
		private string m_domainKey;

		// Token: 0x04000B0D RID: 2829
		internal bool IsQuotedVersion;

		// Token: 0x04000B0E RID: 2830
		internal bool IsQuotedDomain;
	}
}
