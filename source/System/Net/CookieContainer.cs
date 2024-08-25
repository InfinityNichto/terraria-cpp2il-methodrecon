using System;
using System.Collections;
using System.Collections.Generic;
using System.Net.NetworkInformation;
using System.Runtime.InteropServices;
using System.Threading;

namespace System.Net
{
	// Token: 0x02000216 RID: 534
	[Serializable]
	public class CookieContainer
	{
		// Token: 0x06000D2C RID: 3372 RVA: 0x00029FC4 File Offset: 0x000281C4
		public CookieContainer()
		{
			this.m_maxCookiesPerDomain = 20;
			base..ctor();
			if (global::System.Net.NetworkInformation.IPGlobalProperties.InternalGetIPGlobalProperties() != null)
			{
				string text;
				this.m_fqdnMyDomain = text;
			}
		}

		// Token: 0x06000D2D RID: 3373 RVA: 0x00029FF0 File Offset: 0x000281F0
		public CookieContainer(int capacity)
		{
			this.m_maxCookies = capacity;
		}

		// Token: 0x06000D2E RID: 3374 RVA: 0x0002A010 File Offset: 0x00028210
		public CookieContainer(int capacity, int perDomainCapacity, int maxCookieSize)
		{
			this.m_maxCookiesPerDomain = perDomainCapacity;
			this.m_maxCookieSize = maxCookieSize;
		}

		// Token: 0x170002C1 RID: 705
		// (get) Token: 0x06000D2F RID: 3375 RVA: 0x0002A04C File Offset: 0x0002824C
		// (set) Token: 0x06000D30 RID: 3376 RVA: 0x0002A060 File Offset: 0x00028260
		public int Capacity
		{
			get
			{
				return this.m_maxCookies;
			}
			set
			{
				int maxCookiesPerDomain = this.m_maxCookiesPerDomain;
				int maxCookies = this.m_maxCookies;
				this.m_maxCookies = value;
				this.m_maxCookies = value;
			}
		}

		// Token: 0x170002C2 RID: 706
		// (get) Token: 0x06000D31 RID: 3377 RVA: 0x0002A0A4 File Offset: 0x000282A4
		public int Count
		{
			get
			{
				return this.m_count;
			}
		}

		// Token: 0x170002C3 RID: 707
		// (get) Token: 0x06000D32 RID: 3378 RVA: 0x0002A0B8 File Offset: 0x000282B8
		// (set) Token: 0x06000D33 RID: 3379 RVA: 0x0002A0CC File Offset: 0x000282CC
		public int MaxCookieSize
		{
			get
			{
				return this.m_maxCookieSize;
			}
			set
			{
				this.m_maxCookieSize = value;
			}
		}

		// Token: 0x170002C4 RID: 708
		// (get) Token: 0x06000D34 RID: 3380 RVA: 0x0002A0E0 File Offset: 0x000282E0
		// (set) Token: 0x06000D35 RID: 3381 RVA: 0x0002A0F4 File Offset: 0x000282F4
		public int PerDomainCapacity
		{
			get
			{
				return this.m_maxCookiesPerDomain;
			}
			set
			{
				int maxCookies = this.m_maxCookies;
				int maxCookiesPerDomain = this.m_maxCookiesPerDomain;
				this.m_maxCookiesPerDomain = value;
				this.m_maxCookiesPerDomain = value;
			}
		}

		// Token: 0x06000D36 RID: 3382 RVA: 0x0002A120 File Offset: 0x00028320
		public void Add(Cookie cookie)
		{
			if (cookie != null && cookie.m_domain._stringLength != 0)
			{
				bool secure = cookie.m_secure;
				if (32 == 0)
				{
				}
				if (!cookie.m_domain_implicit)
				{
					string domain = cookie.m_domain;
					long num = 0L;
					char c = domain[(int)num];
				}
				string domain2 = cookie.m_domain;
				int[] port_list = cookie.m_port_list;
				int[] port_list2 = cookie.m_port_list;
				string path = cookie.m_path;
				if (32 == 0)
				{
				}
				Cookie cookie2 = cookie.Clone();
				string text;
				bool flag = this.IsLocalDomain(text);
				string fqdnMyDomain = this.m_fqdnMyDomain;
				return;
			}
			string @string = SR.GetString("The parameter '{0}' cannot be an empty string.");
		}

		// Token: 0x06000D37 RID: 3383 RVA: 0x0002A1BC File Offset: 0x000283BC
		private void AddRemoveDomain(string key, PathList value)
		{
			Hashtable domainTable = this.m_domainTable;
			Hashtable domainTable2 = this.m_domainTable;
			if (value != null)
			{
				return;
			}
			long num = 0L;
			Monitor.Exit(domainTable);
			if (num == 0L)
			{
				return;
			}
			throw new OutOfMemoryException();
		}

		// Token: 0x06000D38 RID: 3384 RVA: 0x0002A20C File Offset: 0x0002840C
		internal void Add(Cookie cookie, bool throwOnError)
		{
			int stringLength = cookie.m_value._stringLength;
			throw new ArrayTypeMismatchException();
		}

		// Token: 0x06000D39 RID: 3385 RVA: 0x0002A3B0 File Offset: 0x000285B0
		private bool AgeCookies(string domain)
		{
			int count;
			if (this.m_maxCookies != 0)
			{
				int maxCookiesPerDomain = this.m_maxCookiesPerDomain;
				if (maxCookiesPerDomain != 0)
				{
					if (maxCookiesPerDomain == 0)
					{
						int maxCookies = this.m_maxCookies;
					}
					count = this.m_count;
				}
			}
			long num = 0L;
			Monitor.Enter(this.m_domainTable, num != 0L);
			Hashtable domainTable = this.m_domainTable;
			if (count != 0)
			{
			}
			if (count != 0)
			{
			}
			Hashtable domainTable2;
			if (domain != null)
			{
				domainTable2 = this.m_domainTable;
			}
			Monitor.Enter(domainTable2._buckets, true);
			Hashtable.bucket[] buckets = domainTable2._buckets;
			if (true)
			{
			}
			object key = buckets.key;
			object val = buckets.val;
			if (true)
			{
			}
			object key2 = buckets.key;
			object val2 = buckets.val;
			if (true)
			{
			}
			object key3 = buckets.key;
			object val3 = buckets.val;
			if (buckets != null)
			{
			}
			int count2 = this.m_count;
			this.m_count = count2;
			if (!true)
			{
			}
			bool flag;
			return flag;
		}

		// Token: 0x06000D3A RID: 3386 RVA: 0x0002A7B0 File Offset: 0x000289B0
		private int ExpireCollection(CookieCollection cc)
		{
			ArrayList list = cc.m_list;
			Cookie cookie;
			bool expired = cookie.Expired;
			ArrayList list2 = cc.m_list;
			ArrayList list3 = cc.m_list;
			long num = 0L;
			Monitor.Exit(cc);
			if (num == 0L)
			{
			}
			throw new OutOfMemoryException();
		}

		// Token: 0x06000D3B RID: 3387 RVA: 0x0002A808 File Offset: 0x00028A08
		public void Add(CookieCollection cookies)
		{
			if (cookies != null)
			{
				IEnumerator enumerator = cookies.GetEnumerator();
				return;
			}
			throw new OutOfMemoryException();
		}

		// Token: 0x06000D3C RID: 3388 RVA: 0x0002A84C File Offset: 0x00028A4C
		internal bool IsLocalDomain(string host)
		{
			int num = 46;
			int num2 = host.IndexOf((char)num);
			bool flag = host == "127.0.0.1";
			bool flag2 = host == "::1";
			bool flag3 = host == "0:0:0:0:0:0:0:1";
			int stringLength = this.m_fqdnMyDomain._stringLength;
			int num3;
			if (num3 == 0)
			{
				return;
			}
			string[] array;
			if (array != null)
			{
				bool flag4 = array == "127";
				return;
			}
		}

		// Token: 0x06000D3D RID: 3389 RVA: 0x0002A8C8 File Offset: 0x00028AC8
		public void Add(global::System.Uri uri, Cookie cookie)
		{
			do
			{
				if (!true)
				{
				}
			}
			while (cookie == null);
			Cookie cookie2 = cookie.Clone();
			string host = uri.Host;
			string fqdnMyDomain = this.m_fqdnMyDomain;
		}

		// Token: 0x06000D3E RID: 3390 RVA: 0x0002A8F4 File Offset: 0x00028AF4
		public void Add(global::System.Uri uri, CookieCollection cookies)
		{
			if (!true)
			{
			}
			if (cookies != null)
			{
				string host = uri.Host;
				bool flag = this.IsLocalDomain(host);
				IEnumerator enumerator = cookies.GetEnumerator();
				return;
			}
			throw new OutOfMemoryException();
		}

		// Token: 0x06000D3F RID: 3391 RVA: 0x0002A988 File Offset: 0x00028B88
		internal CookieCollection CookieCutter(global::System.Uri uri, string headerName, string setCookieHeader, bool isThrow)
		{
			int num = 1;
			if (headerName != null)
			{
				if (num == 0)
				{
				}
				int num2;
				if (num2 == 0)
				{
				}
			}
			string host = uri.Host;
			bool flag = this.IsLocalDomain(host);
			Cookie cookie;
			if (cookie != null)
			{
				bool flag2 = ValidationHelper.IsBlankString(cookie.m_name);
				string fqdnMyDomain = this.m_fqdnMyDomain;
				string @string = SR.GetString("Cookie format error.");
				throw new OutOfMemoryException();
			}
			IEnumerator enumerator;
			if (enumerator != null)
			{
			}
			long num3 = 0L;
			if (enumerator != null)
			{
			}
			if (num3 == 0L)
			{
				throw new InvalidCastException();
			}
			throw new OutOfMemoryException();
		}

		// Token: 0x06000D40 RID: 3392 RVA: 0x0002AA18 File Offset: 0x00028C18
		public CookieCollection GetCookies(global::System.Uri uri)
		{
			if (!true)
			{
			}
			return this.InternalGetCookies(uri);
		}

		// Token: 0x06000D41 RID: 3393 RVA: 0x0002AA30 File Offset: 0x00028C30
		internal CookieCollection InternalGetCookies(global::System.Uri uri)
		{
			/*
An exception occurred when decompiling this method (06000D41)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Net.CookieCollection System.Net.CookieContainer::InternalGetCookies(System.Uri)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_1:
	stloc:int64(var_9_50, ldc.i4:int64(0))
	stloc:string(var_10_5A, call:string(string::Concat, ldloc:string(var_3_14), ldloc:string(var_8_40)))
	stloc:int32(var_11_62, ldfld:int32(string::_stringLength, ldloc:string(var_3_14)))
	stloc:int32(var_12_66, ldc.i4:int32(46))
	stloc:int32(var_13_72, call:int32(string::LastIndexOf, ldloc:string(var_3_14), ldloc:int32[exp:char](var_12_66), ldloc:int64[exp:int32](var_9_50)))
	stloc:int32(var_14_76, ldc.i4:int32(46))
	stloc:int32(var_15_82, call:int32(string::LastIndexOf, ldloc:string(var_3_14), ldloc:int32[exp:char](var_14_76), ldloc:int64[exp:int32](var_9_50)))
	stloc:int32(var_16_86, ldc.i4:int32(46))
	stloc:int32(var_17_92, call:int32(string::IndexOf, ldloc:string(var_3_14), ldloc:int32[exp:char](var_16_86), ldloc:int64[exp:int32](var_9_50)))
	stloc:string(var_18_9C, call:string(string::Substring, ldloc:string(var_3_14), ldloc:int32(var_17_92)))
	stloc:string(var_19_A4, ldfld:string(CookieContainer::m_fqdnMyDomain, ldloc:CookieContainer(this)))
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

		// Token: 0x06000D42 RID: 3394 RVA: 0x0002AAE4 File Offset: 0x00028CE4
		private void BuildCookieCollectionFromDomainMatches(global::System.Uri uri, bool isSecure, int port, CookieCollection cookies, List<string> domainAttribute, bool matchOnlyPlainCookie)
		{
			int size = domainAttribute._size;
			if (!false)
			{
				return;
			}
			throw new OutOfMemoryException();
		}

		// Token: 0x06000D43 RID: 3395 RVA: 0x0002ABD8 File Offset: 0x00028DD8
		private void MergeUpdateCollections(CookieCollection destination, CookieCollection source, int port, bool isSecure, bool isPlainOnly)
		{
			long num = 0L;
			ArrayList list = source.m_list;
			Cookie cookie = source[(int)num];
			bool expired = cookie.Expired;
			ArrayList list2 = source.m_list;
			int count = this.m_count;
			this.m_count = count;
		}

		// Token: 0x06000D44 RID: 3396 RVA: 0x0002AC84 File Offset: 0x00028E84
		public string GetCookieHeader(global::System.Uri uri)
		{
			string text;
			return text;
		}

		// Token: 0x06000D45 RID: 3397 RVA: 0x0002AC94 File Offset: 0x00028E94
		internal string GetCookieHeader(global::System.Uri uri, [Out] string optCookie2)
		{
			CookieCollection cookieCollection = this.InternalGetCookies(uri);
			IEnumerator enumerator = cookieCollection.GetEnumerator();
			if (enumerator != null)
			{
			}
			string text;
			return text;
		}

		// Token: 0x06000D46 RID: 3398 RVA: 0x0002ACFC File Offset: 0x00028EFC
		public void SetCookies(global::System.Uri uri, string cookieHeader)
		{
			do
			{
				if (!true)
				{
				}
			}
			while (cookieHeader == null);
		}

		// Token: 0x06000D47 RID: 3399 RVA: 0x0002AD10 File Offset: 0x00028F10
		// Note: this type is marked as 'beforefieldinit'.
		static CookieContainer()
		{
		}

		// Token: 0x04000B44 RID: 2884
		public const int DefaultCookieLimit = 300;

		// Token: 0x04000B45 RID: 2885
		public const int DefaultPerDomainCookieLimit = 20;

		// Token: 0x04000B46 RID: 2886
		public const int DefaultCookieLengthLimit = 4096;

		// Token: 0x04000B47 RID: 2887
		private static readonly HeaderVariantInfo[] HeaderInfo;

		// Token: 0x04000B48 RID: 2888
		private Hashtable m_domainTable;

		// Token: 0x04000B49 RID: 2889
		private int m_maxCookieSize;

		// Token: 0x04000B4A RID: 2890
		private int m_maxCookies;

		// Token: 0x04000B4B RID: 2891
		private int m_maxCookiesPerDomain;

		// Token: 0x04000B4C RID: 2892
		private int m_count;

		// Token: 0x04000B4D RID: 2893
		private string m_fqdnMyDomain;
	}
}
