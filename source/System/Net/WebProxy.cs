using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Threading;
using Cpp2IlInjected;

namespace System.Net
{
	// Token: 0x02000220 RID: 544
	[Serializable]
	public class WebProxy : IAutoWebProxy, IWebProxy, ISerializable
	{
		// Token: 0x06000D9D RID: 3485 RVA: 0x0002BC00 File Offset: 0x00029E00
		public WebProxy()
		{
		}

		// Token: 0x06000D9E RID: 3486 RVA: 0x0002BC10 File Offset: 0x00029E10
		public WebProxy(global::System.Uri Address)
		{
		}

		// Token: 0x06000D9F RID: 3487 RVA: 0x0002BC20 File Offset: 0x00029E20
		public WebProxy(global::System.Uri Address, bool BypassOnLocal)
		{
		}

		// Token: 0x06000DA0 RID: 3488 RVA: 0x0002BC30 File Offset: 0x00029E30
		public WebProxy(global::System.Uri Address, bool BypassOnLocal, string[] BypassList)
		{
		}

		// Token: 0x06000DA1 RID: 3489 RVA: 0x0002BC40 File Offset: 0x00029E40
		public WebProxy(global::System.Uri Address, bool BypassOnLocal, string[] BypassList, ICredentials Credentials)
		{
			this._ProxyAddress = Address;
			if (BypassList != null)
			{
				this._BypassList = Address;
				this.UpdateRegExList(true);
			}
			this._Credentials = Credentials;
			this.m_EnableAutoproxy = true;
		}

		// Token: 0x06000DA2 RID: 3490 RVA: 0x0002BC7C File Offset: 0x00029E7C
		public WebProxy(string Host, int Port)
		{
			if (!true)
			{
			}
			CultureInfo invariantCulture = CultureInfo.InvariantCulture;
			string text2;
			string text = "http://" + Host + ":" + text2;
		}

		// Token: 0x06000DA3 RID: 3491 RVA: 0x0002BCA8 File Offset: 0x00029EA8
		public WebProxy(string Address)
		{
			global::System.Uri uri = WebProxy.CreateProxyUri(Address);
		}

		// Token: 0x06000DA4 RID: 3492 RVA: 0x0002BCBC File Offset: 0x00029EBC
		public WebProxy(string Address, bool BypassOnLocal)
		{
			global::System.Uri uri = WebProxy.CreateProxyUri(Address);
		}

		// Token: 0x06000DA5 RID: 3493 RVA: 0x0002BCD0 File Offset: 0x00029ED0
		public WebProxy(string Address, bool BypassOnLocal, string[] BypassList)
		{
			global::System.Uri uri = WebProxy.CreateProxyUri(Address);
		}

		// Token: 0x06000DA6 RID: 3494 RVA: 0x0002BCE4 File Offset: 0x00029EE4
		public WebProxy(string Address, bool BypassOnLocal, string[] BypassList, ICredentials Credentials)
		{
			global::System.Uri uri = WebProxy.CreateProxyUri(Address);
		}

		// Token: 0x170002DB RID: 731
		// (get) Token: 0x06000DA7 RID: 3495 RVA: 0x0002BCF8 File Offset: 0x00029EF8
		// (set) Token: 0x06000DA8 RID: 3496 RVA: 0x0002BD0C File Offset: 0x00029F0C
		public global::System.Uri Address
		{
			get
			{
				return this._ProxyAddress;
			}
			set
			{
				AutoWebProxyScriptEngine scriptEngine = this.m_ScriptEngine;
				if (scriptEngine != null)
				{
					scriptEngine.Close();
				}
				this._ProxyAddress = value;
			}
		}

		// Token: 0x170002DC RID: 732
		// (set) Token: 0x06000DA9 RID: 3497 RVA: 0x0002BD30 File Offset: 0x00029F30
		internal bool AutoDetect
		{
			set
			{
				if (this.m_ScriptEngine == null)
				{
				}
			}
		}

		// Token: 0x170002DD RID: 733
		// (set) Token: 0x06000DAA RID: 3498 RVA: 0x0002BD48 File Offset: 0x00029F48
		internal global::System.Uri ScriptLocation
		{
			set
			{
				if (this.m_ScriptEngine == null)
				{
				}
			}
		}

		// Token: 0x170002DE RID: 734
		// (get) Token: 0x06000DAB RID: 3499 RVA: 0x0002BD60 File Offset: 0x00029F60
		// (set) Token: 0x06000DAC RID: 3500 RVA: 0x0002BD74 File Offset: 0x00029F74
		public bool BypassProxyOnLocal
		{
			get
			{
				return this._BypassOnLocal;
			}
			set
			{
				AutoWebProxyScriptEngine scriptEngine = this.m_ScriptEngine;
				if (scriptEngine != null)
				{
					scriptEngine.Close();
				}
			}
		}

		// Token: 0x170002DF RID: 735
		// (get) Token: 0x06000DAD RID: 3501 RVA: 0x0002BD94 File Offset: 0x00029F94
		// (set) Token: 0x06000DAE RID: 3502 RVA: 0x0002BDB0 File Offset: 0x00029FB0
		public string[] BypassList
		{
			get
			{
				if (this._BypassList == null)
				{
				}
				throw new InvalidCastException();
			}
			set
			{
				AutoWebProxyScriptEngine scriptEngine = this.m_ScriptEngine;
				if (scriptEngine != null)
				{
					scriptEngine.Close();
				}
				this.UpdateRegExList(true);
			}
		}

		// Token: 0x170002E0 RID: 736
		// (get) Token: 0x06000DAF RID: 3503 RVA: 0x0002BDD4 File Offset: 0x00029FD4
		// (set) Token: 0x06000DB0 RID: 3504 RVA: 0x0002BDE8 File Offset: 0x00029FE8
		public ICredentials Credentials
		{
			get
			{
				return this._Credentials;
			}
			set
			{
				this._Credentials = value;
			}
		}

		// Token: 0x170002E1 RID: 737
		// (get) Token: 0x06000DB1 RID: 3505 RVA: 0x0002BDFC File Offset: 0x00029FFC
		// (set) Token: 0x06000DB2 RID: 3506 RVA: 0x0002BE14 File Offset: 0x0002A014
		public bool UseDefaultCredentials
		{
			get
			{
				if (this._Credentials != null)
				{
					return;
				}
			}
			set
			{
				if (!true)
				{
				}
			}
		}

		// Token: 0x170002E2 RID: 738
		// (get) Token: 0x06000DB3 RID: 3507 RVA: 0x0002BE2C File Offset: 0x0002A02C
		public ArrayList BypassArrayList
		{
			get
			{
				/*
An exception occurred when decompiling this method (06000DB3)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Collections.ArrayList System.Net.WebProxy::get_BypassArrayList()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0000:
	brtrue(IL_0000, ldfld:ArrayList[exp:bool](WebProxy::_BypassList, ldloc:WebProxy(this)))
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

		// Token: 0x06000DB4 RID: 3508 RVA: 0x0002BE40 File Offset: 0x0002A040
		internal void CheckForChanges()
		{
			AutoWebProxyScriptEngine scriptEngine = this.m_ScriptEngine;
			if (scriptEngine != null)
			{
				scriptEngine.CheckForChanges();
				return;
			}
		}

		// Token: 0x06000DB5 RID: 3509 RVA: 0x0002BE60 File Offset: 0x0002A060
		public global::System.Uri GetProxy(global::System.Uri destination)
		{
			if (!true)
			{
			}
			bool flag = this.IsBypassedManual(destination);
			Hashtable proxyHostAddresses = this._ProxyHostAddresses;
			if (proxyHostAddresses != null)
			{
				string scheme = destination.Scheme;
				if (proxyHostAddresses != null)
				{
				}
			}
			global::System.Uri proxyAddress = this._ProxyAddress;
			return destination;
		}

		// Token: 0x06000DB6 RID: 3510 RVA: 0x0002BE98 File Offset: 0x0002A098
		private static global::System.Uri CreateProxyUri(string address)
		{
			/*
An exception occurred when decompiling this method (06000DB6)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Uri System.Net.WebProxy::CreateProxyUri(System.String)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:string(var_1_0F, call:string(string::Concat, ldstr:string("http://"), ldstr:string("://")))
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

		// Token: 0x06000DB7 RID: 3511 RVA: 0x0002BEB8 File Offset: 0x0002A0B8
		private void UpdateRegExList(bool canThrow)
		{
			ArrayList bypassList = this._BypassList;
			if (bypassList != null)
			{
				if (bypassList != null)
				{
				}
				return;
			}
			long num = 0L;
			this._RegExBypassList = num;
		}

		// Token: 0x06000DB8 RID: 3512 RVA: 0x0002BEFC File Offset: 0x0002A0FC
		private bool IsMatchInBypassList(global::System.Uri input)
		{
			long num = 0L;
			this.UpdateRegExList(num != 0L);
			if (this._RegExBypassList != null)
			{
				string scheme = input.Scheme;
				string host = input.Host;
				return input.IsDefaultPort;
			}
		}

		// Token: 0x06000DB9 RID: 3513 RVA: 0x0002BF80 File Offset: 0x0002A180
		private bool IsLocal(global::System.Uri host)
		{
			string host2 = host.Host;
			bool flag;
			return flag;
		}

		// Token: 0x06000DBA RID: 3514 RVA: 0x0002BFCC File Offset: 0x0002A1CC
		private bool IsLocalInProxyHash(global::System.Uri host)
		{
			Hashtable proxyHostAddresses = this._ProxyHostAddresses;
			if (proxyHostAddresses != null)
			{
				string scheme = host.Scheme;
				if (proxyHostAddresses != null || proxyHostAddresses != null)
				{
				}
			}
			throw new InvalidCastException();
		}

		// Token: 0x06000DBB RID: 3515 RVA: 0x0002BFF8 File Offset: 0x0002A1F8
		public bool IsBypassed(global::System.Uri host)
		{
			if (!true)
			{
			}
			long num = 0L;
			return this.IsBypassedAuto(host, num != 0L);
		}

		// Token: 0x06000DBC RID: 3516 RVA: 0x0002C01C File Offset: 0x0002A21C
		private bool IsBypassedManual(global::System.Uri host)
		{
			bool isLoopback = host.IsLoopback;
			global::System.Uri proxyAddress = this._ProxyAddress;
			if (this._ProxyHostAddresses == null || this._BypassOnLocal)
			{
			}
			return true;
		}

		// Token: 0x06000DBD RID: 3517 RVA: 0x00002050 File Offset: 0x00000250
		[Obsolete("This method has been deprecated. Please use the proxy selected for you by default. http://go.microsoft.com/fwlink/?linkid=14202")]
		public static WebProxy GetDefaultProxy()
		{
			throw new global::Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06000DBE RID: 3518 RVA: 0x0002C050 File Offset: 0x0002A250
		protected WebProxy(SerializationInfo serializationInfo, StreamingContext streamingContext)
		{
			bool boolean = serializationInfo.GetBoolean("_UseRegistry");
			int num = 1;
			this._UseRegistry = num != 0;
		}

		// Token: 0x06000DBF RID: 3519 RVA: 0x0002C0E0 File Offset: 0x0002A2E0
		void ISerializable.GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext)
		{
		}

		// Token: 0x06000DC0 RID: 3520 RVA: 0x0002C0F0 File Offset: 0x0002A2F0
		protected virtual void GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext)
		{
			bool bypassOnLocal = this._BypassOnLocal;
			serializationInfo.AddValue("_BypassOnLocal", bypassOnLocal);
			global::System.Uri proxyAddress = this._ProxyAddress;
			serializationInfo.AddValue("_ProxyAddress", proxyAddress);
			ArrayList bypassList = this._BypassList;
			serializationInfo.AddValue("_BypassList", bypassList);
			bool useDefaultCredentials = this.UseDefaultCredentials;
			if (this._UseRegistry)
			{
				serializationInfo.AddValue("_UseRegistry", true);
				return;
			}
		}

		// Token: 0x170002E3 RID: 739
		// (get) Token: 0x06000DC1 RID: 3521 RVA: 0x0002C154 File Offset: 0x0002A354
		// (set) Token: 0x06000DC2 RID: 3522 RVA: 0x0002C168 File Offset: 0x0002A368
		internal AutoWebProxyScriptEngine ScriptEngine
		{
			get
			{
				return this.m_ScriptEngine;
			}
			set
			{
				this.m_ScriptEngine = value;
			}
		}

		// Token: 0x06000DC3 RID: 3523 RVA: 0x00002050 File Offset: 0x00000250
		public static IWebProxy CreateDefaultProxy()
		{
			throw new global::Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06000DC4 RID: 3524 RVA: 0x0002C17C File Offset: 0x0002A37C
		internal WebProxy(bool enableAutoproxy)
		{
			this._UseRegistry = true;
		}

		// Token: 0x06000DC5 RID: 3525 RVA: 0x0002C198 File Offset: 0x0002A398
		internal void DeleteScriptEngine()
		{
			AutoWebProxyScriptEngine scriptEngine = this.m_ScriptEngine;
			if (scriptEngine != null)
			{
				scriptEngine.Close();
			}
		}

		// Token: 0x06000DC6 RID: 3526 RVA: 0x0002C1B8 File Offset: 0x0002A3B8
		internal void UnsafeUpdateFromRegistry()
		{
			this._UseRegistry = true;
		}

		// Token: 0x06000DC7 RID: 3527 RVA: 0x0002C1CC File Offset: 0x0002A3CC
		internal void Update(WebProxyData webProxyData)
		{
			bool bypassOnLocal = webProxyData.bypassOnLocal;
			bool enableAutoproxy = this.m_EnableAutoproxy;
			this._BypassOnLocal = bypassOnLocal;
			global::System.Uri proxyAddress = webProxyData.proxyAddress;
			this._ProxyAddress = proxyAddress;
			Hashtable proxyHostAddresses = webProxyData.proxyHostAddresses;
			this._ProxyHostAddresses = proxyHostAddresses;
			ArrayList bypassList = webProxyData.bypassList;
			AutoWebProxyScriptEngine scriptEngine = this.m_ScriptEngine;
			this._BypassList = bypassList;
			if (enableAutoproxy)
			{
				bool automaticallyDetectSettings = webProxyData.automaticallyDetectSettings;
				global::System.Uri scriptLocation = webProxyData.scriptLocation;
				return;
			}
			long num = 0L;
			long num2 = 0L;
			long num3 = 0L;
			scriptEngine.<AutomaticallyDetectSettings>k__BackingField = num != 0L;
			scriptEngine.<AutomaticConfigurationScript>k__BackingField = num2;
			if (scriptEngine != null)
			{
				Monitor.Exit(this);
			}
			if (num3 == 0L)
			{
				return;
			}
			throw new OutOfMemoryException();
		}

		// Token: 0x06000DC8 RID: 3528 RVA: 0x0002C288 File Offset: 0x0002A488
		ProxyChain IAutoWebProxy.GetProxies(global::System.Uri destination)
		{
			/*
An exception occurred when decompiling this method (06000DC8)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Net.ProxyChain System.Net.WebProxy::System.Net.IAutoWebProxy.GetProxies(System.Uri)

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

		// Token: 0x06000DC9 RID: 3529 RVA: 0x0002C298 File Offset: 0x0002A498
		private bool GetProxyAuto(global::System.Uri destination, [Out] global::System.Uri proxyUri)
		{
			while (this.m_ScriptEngine == null)
			{
			}
			long value = 0.m_value;
			bool flag;
			return flag;
		}

		// Token: 0x06000DCA RID: 3530 RVA: 0x0002C2B8 File Offset: 0x0002A4B8
		private bool IsBypassedAuto(global::System.Uri destination, [Out] bool isBypassed)
		{
			/*
An exception occurred when decompiling this method (06000DCA)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean System.Net.WebProxy::IsBypassedAuto(System.Uri,System.Boolean)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0015:
	stloc:int64(var_4_16, ldc.i4:int64(0))
	stfld:bool(bool::m_value, ldloc:bool[exp:bool&](isBypassed), ldloc:int64[exp:bool](var_4_16))
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

		// Token: 0x06000DCB RID: 3531 RVA: 0x0002C2E8 File Offset: 0x0002A4E8
		internal global::System.Uri[] GetProxiesAuto(global::System.Uri destination, int syncStatus)
		{
			long num;
			if (this.m_ScriptEngine != null)
			{
				num = 0L;
			}
			long num2 = 0L;
			long value = num.m_value;
			if (num2 != 0L)
			{
			}
			global::System.Uri uri;
			if (uri == null || uri != null)
			{
				return uri;
			}
			throw new ArrayTypeMismatchException();
		}

		// Token: 0x06000DCC RID: 3532 RVA: 0x0002C324 File Offset: 0x0002A524
		internal void AbortGetProxiesAuto(int syncStatus)
		{
			AutoWebProxyScriptEngine scriptEngine = this.m_ScriptEngine;
			if (scriptEngine != null)
			{
				scriptEngine.Abort(syncStatus);
				return;
			}
		}

		// Token: 0x06000DCD RID: 3533 RVA: 0x0002C344 File Offset: 0x0002A544
		internal global::System.Uri GetProxyAutoFailover(global::System.Uri destination)
		{
			Hashtable proxyHostAddresses;
			do
			{
				bool flag = this.IsBypassedManual(destination);
				proxyHostAddresses = this._ProxyHostAddresses;
				if (proxyHostAddresses == null)
				{
					break;
				}
				string scheme = destination.Scheme;
			}
			while (proxyHostAddresses == null);
			return this._ProxyAddress;
		}

		// Token: 0x06000DCE RID: 3534 RVA: 0x0002C378 File Offset: 0x0002A578
		private static bool AreAllBypassed(IEnumerable<string> proxies, bool checkFirstOnly)
		{
			bool flag;
			return flag;
		}

		// Token: 0x06000DCF RID: 3535 RVA: 0x0002C3A0 File Offset: 0x0002A5A0
		private static global::System.Uri ProxyUri(string proxyName)
		{
			if (true)
			{
				string text = "http://" + proxyName;
				return;
			}
		}

		// Token: 0x04000B75 RID: 2933
		private bool _UseRegistry;

		// Token: 0x04000B76 RID: 2934
		private bool _BypassOnLocal;

		// Token: 0x04000B77 RID: 2935
		private bool m_EnableAutoproxy;

		// Token: 0x04000B78 RID: 2936
		private global::System.Uri _ProxyAddress;

		// Token: 0x04000B79 RID: 2937
		private ArrayList _BypassList;

		// Token: 0x04000B7A RID: 2938
		private ICredentials _Credentials;

		// Token: 0x04000B7B RID: 2939
		private global::System.Text.RegularExpressions.Regex[] _RegExBypassList;

		// Token: 0x04000B7C RID: 2940
		private Hashtable _ProxyHostAddresses;

		// Token: 0x04000B7D RID: 2941
		private AutoWebProxyScriptEngine m_ScriptEngine;
	}
}
