using System;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Net.Cache;
using System.Net.Http;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Cpp2IlInjected;

namespace System.Net
{
	// Token: 0x0200015A RID: 346
	public class WebClient : global::System.ComponentModel.Component
	{
		// Token: 0x060008C9 RID: 2249 RVA: 0x0001EC44 File Offset: 0x0001CE44
		public WebClient()
		{
			Encoding @default = Encoding.Default;
			this._encoding = @default;
			this._contentLength = 1L;
			if (!true)
			{
			}
			base..ctor();
			Type type;
			bool flag = base.GetType() == type;
			GC.SuppressFinalize(this);
		}

		// Token: 0x14000001 RID: 1
		// (add) Token: 0x060008CA RID: 2250 RVA: 0x0001EC84 File Offset: 0x0001CE84
		// (remove) Token: 0x060008CB RID: 2251 RVA: 0x0001ECA8 File Offset: 0x0001CEA8
		public event DownloadStringCompletedEventHandler DownloadStringCompleted
		{
			[CompilerGenerated]
			add
			{
				if (Delegate.Combine(this.DownloadStringCompleted, value) != null)
				{
				}
			}
			[CompilerGenerated]
			remove
			{
				if (Delegate.Remove(this.DownloadStringCompleted, value) != null)
				{
				}
			}
		}

		// Token: 0x14000002 RID: 2
		// (add) Token: 0x060008CC RID: 2252 RVA: 0x0001ECCC File Offset: 0x0001CECC
		// (remove) Token: 0x060008CD RID: 2253 RVA: 0x0001ECF0 File Offset: 0x0001CEF0
		public event DownloadDataCompletedEventHandler DownloadDataCompleted
		{
			[CompilerGenerated]
			add
			{
				if (Delegate.Combine(this.DownloadDataCompleted, value) != null)
				{
				}
			}
			[CompilerGenerated]
			remove
			{
				if (Delegate.Remove(this.DownloadDataCompleted, value) != null)
				{
				}
			}
		}

		// Token: 0x14000003 RID: 3
		// (add) Token: 0x060008CE RID: 2254 RVA: 0x0001ED14 File Offset: 0x0001CF14
		// (remove) Token: 0x060008CF RID: 2255 RVA: 0x0001ED38 File Offset: 0x0001CF38
		public event global::System.ComponentModel.AsyncCompletedEventHandler DownloadFileCompleted
		{
			[CompilerGenerated]
			add
			{
				if (Delegate.Combine(this.DownloadFileCompleted, value) != null)
				{
				}
			}
			[CompilerGenerated]
			remove
			{
				if (Delegate.Remove(this.DownloadFileCompleted, value) != null)
				{
				}
			}
		}

		// Token: 0x14000004 RID: 4
		// (add) Token: 0x060008D0 RID: 2256 RVA: 0x0001ED5C File Offset: 0x0001CF5C
		// (remove) Token: 0x060008D1 RID: 2257 RVA: 0x0001ED80 File Offset: 0x0001CF80
		public event UploadStringCompletedEventHandler UploadStringCompleted
		{
			[CompilerGenerated]
			add
			{
				if (Delegate.Combine(this.UploadStringCompleted, value) != null)
				{
				}
			}
			[CompilerGenerated]
			remove
			{
				if (Delegate.Remove(this.UploadStringCompleted, value) != null)
				{
				}
			}
		}

		// Token: 0x14000005 RID: 5
		// (add) Token: 0x060008D2 RID: 2258 RVA: 0x0001EDA4 File Offset: 0x0001CFA4
		// (remove) Token: 0x060008D3 RID: 2259 RVA: 0x0001EDC8 File Offset: 0x0001CFC8
		public event UploadDataCompletedEventHandler UploadDataCompleted
		{
			[CompilerGenerated]
			add
			{
				if (Delegate.Combine(this.UploadDataCompleted, value) != null)
				{
				}
			}
			[CompilerGenerated]
			remove
			{
				if (Delegate.Remove(this.UploadDataCompleted, value) != null)
				{
				}
			}
		}

		// Token: 0x14000006 RID: 6
		// (add) Token: 0x060008D4 RID: 2260 RVA: 0x0001EDEC File Offset: 0x0001CFEC
		// (remove) Token: 0x060008D5 RID: 2261 RVA: 0x0001EE10 File Offset: 0x0001D010
		public event UploadFileCompletedEventHandler UploadFileCompleted
		{
			[CompilerGenerated]
			add
			{
				if (Delegate.Combine(this.UploadFileCompleted, value) != null)
				{
				}
			}
			[CompilerGenerated]
			remove
			{
				if (Delegate.Remove(this.UploadFileCompleted, value) != null)
				{
				}
			}
		}

		// Token: 0x14000007 RID: 7
		// (add) Token: 0x060008D6 RID: 2262 RVA: 0x0001EE34 File Offset: 0x0001D034
		// (remove) Token: 0x060008D7 RID: 2263 RVA: 0x0001EE58 File Offset: 0x0001D058
		public event UploadValuesCompletedEventHandler UploadValuesCompleted
		{
			[CompilerGenerated]
			add
			{
				if (Delegate.Combine(this.UploadValuesCompleted, value) != null)
				{
				}
			}
			[CompilerGenerated]
			remove
			{
				if (Delegate.Remove(this.UploadValuesCompleted, value) != null)
				{
				}
			}
		}

		// Token: 0x14000008 RID: 8
		// (add) Token: 0x060008D8 RID: 2264 RVA: 0x0001EE7C File Offset: 0x0001D07C
		// (remove) Token: 0x060008D9 RID: 2265 RVA: 0x0001EEA0 File Offset: 0x0001D0A0
		public event OpenReadCompletedEventHandler OpenReadCompleted
		{
			[CompilerGenerated]
			add
			{
				if (Delegate.Combine(this.OpenReadCompleted, value) != null)
				{
				}
			}
			[CompilerGenerated]
			remove
			{
				if (Delegate.Remove(this.OpenReadCompleted, value) != null)
				{
				}
			}
		}

		// Token: 0x14000009 RID: 9
		// (add) Token: 0x060008DA RID: 2266 RVA: 0x0001EEC4 File Offset: 0x0001D0C4
		// (remove) Token: 0x060008DB RID: 2267 RVA: 0x0001EEE8 File Offset: 0x0001D0E8
		public event OpenWriteCompletedEventHandler OpenWriteCompleted
		{
			[CompilerGenerated]
			add
			{
				if (Delegate.Combine(this.OpenWriteCompleted, value) != null)
				{
				}
			}
			[CompilerGenerated]
			remove
			{
				if (Delegate.Remove(this.OpenWriteCompleted, value) != null)
				{
				}
			}
		}

		// Token: 0x1400000A RID: 10
		// (add) Token: 0x060008DC RID: 2268 RVA: 0x0001EF0C File Offset: 0x0001D10C
		// (remove) Token: 0x060008DD RID: 2269 RVA: 0x0001EF30 File Offset: 0x0001D130
		public event DownloadProgressChangedEventHandler DownloadProgressChanged
		{
			[CompilerGenerated]
			add
			{
				if (Delegate.Combine(this.DownloadProgressChanged, value) != null)
				{
				}
			}
			[CompilerGenerated]
			remove
			{
				if (Delegate.Remove(this.DownloadProgressChanged, value) != null)
				{
				}
			}
		}

		// Token: 0x1400000B RID: 11
		// (add) Token: 0x060008DE RID: 2270 RVA: 0x0001EF54 File Offset: 0x0001D154
		// (remove) Token: 0x060008DF RID: 2271 RVA: 0x0001EF78 File Offset: 0x0001D178
		public event UploadProgressChangedEventHandler UploadProgressChanged
		{
			[CompilerGenerated]
			add
			{
				if (Delegate.Combine(this.UploadProgressChanged, value) != null)
				{
				}
			}
			[CompilerGenerated]
			remove
			{
				if (Delegate.Remove(this.UploadProgressChanged, value) != null)
				{
				}
			}
		}

		// Token: 0x060008E0 RID: 2272 RVA: 0x0001EF9C File Offset: 0x0001D19C
		protected virtual void OnDownloadStringCompleted(DownloadStringCompletedEventArgs e)
		{
			DownloadStringCompletedEventHandler downloadStringCompleted = this.DownloadStringCompleted;
			if (downloadStringCompleted != null)
			{
				IntPtr invoke_impl = downloadStringCompleted.invoke_impl;
				IntPtr method_code = downloadStringCompleted.method_code;
				IntPtr method = downloadStringCompleted.method;
				return;
			}
		}

		// Token: 0x060008E1 RID: 2273 RVA: 0x0001EFCC File Offset: 0x0001D1CC
		protected virtual void OnDownloadDataCompleted(DownloadDataCompletedEventArgs e)
		{
			DownloadDataCompletedEventHandler downloadDataCompleted = this.DownloadDataCompleted;
			if (downloadDataCompleted != null)
			{
				IntPtr invoke_impl = downloadDataCompleted.invoke_impl;
				IntPtr method_code = downloadDataCompleted.method_code;
				IntPtr method = downloadDataCompleted.method;
				return;
			}
		}

		// Token: 0x060008E2 RID: 2274 RVA: 0x0001EFFC File Offset: 0x0001D1FC
		protected virtual void OnDownloadFileCompleted(global::System.ComponentModel.AsyncCompletedEventArgs e)
		{
			global::System.ComponentModel.AsyncCompletedEventHandler downloadFileCompleted = this.DownloadFileCompleted;
			if (downloadFileCompleted != null)
			{
				IntPtr invoke_impl = downloadFileCompleted.invoke_impl;
				IntPtr method_code = downloadFileCompleted.method_code;
				IntPtr method = downloadFileCompleted.method;
				return;
			}
		}

		// Token: 0x060008E3 RID: 2275 RVA: 0x0001F02C File Offset: 0x0001D22C
		protected virtual void OnDownloadProgressChanged(DownloadProgressChangedEventArgs e)
		{
			DownloadProgressChangedEventHandler downloadProgressChanged = this.DownloadProgressChanged;
			if (downloadProgressChanged != null)
			{
				IntPtr invoke_impl = downloadProgressChanged.invoke_impl;
				IntPtr method_code = downloadProgressChanged.method_code;
				IntPtr method = downloadProgressChanged.method;
				return;
			}
		}

		// Token: 0x060008E4 RID: 2276 RVA: 0x0001F05C File Offset: 0x0001D25C
		protected virtual void OnUploadStringCompleted(UploadStringCompletedEventArgs e)
		{
			UploadStringCompletedEventHandler uploadStringCompleted = this.UploadStringCompleted;
			if (uploadStringCompleted != null)
			{
				IntPtr invoke_impl = uploadStringCompleted.invoke_impl;
				IntPtr method_code = uploadStringCompleted.method_code;
				IntPtr method = uploadStringCompleted.method;
				return;
			}
		}

		// Token: 0x060008E5 RID: 2277 RVA: 0x0001F08C File Offset: 0x0001D28C
		protected virtual void OnUploadDataCompleted(UploadDataCompletedEventArgs e)
		{
			UploadDataCompletedEventHandler uploadDataCompleted = this.UploadDataCompleted;
			if (uploadDataCompleted != null)
			{
				IntPtr invoke_impl = uploadDataCompleted.invoke_impl;
				IntPtr method_code = uploadDataCompleted.method_code;
				IntPtr method = uploadDataCompleted.method;
				return;
			}
		}

		// Token: 0x060008E6 RID: 2278 RVA: 0x0001F0BC File Offset: 0x0001D2BC
		protected virtual void OnUploadFileCompleted(UploadFileCompletedEventArgs e)
		{
			UploadFileCompletedEventHandler uploadFileCompleted = this.UploadFileCompleted;
			if (uploadFileCompleted != null)
			{
				IntPtr invoke_impl = uploadFileCompleted.invoke_impl;
				IntPtr method_code = uploadFileCompleted.method_code;
				IntPtr method = uploadFileCompleted.method;
				return;
			}
		}

		// Token: 0x060008E7 RID: 2279 RVA: 0x0001F0EC File Offset: 0x0001D2EC
		protected virtual void OnUploadValuesCompleted(UploadValuesCompletedEventArgs e)
		{
			UploadValuesCompletedEventHandler uploadValuesCompleted = this.UploadValuesCompleted;
			if (uploadValuesCompleted != null)
			{
				IntPtr invoke_impl = uploadValuesCompleted.invoke_impl;
				IntPtr method_code = uploadValuesCompleted.method_code;
				IntPtr method = uploadValuesCompleted.method;
				return;
			}
		}

		// Token: 0x060008E8 RID: 2280 RVA: 0x0001F11C File Offset: 0x0001D31C
		protected virtual void OnUploadProgressChanged(UploadProgressChangedEventArgs e)
		{
			UploadProgressChangedEventHandler uploadProgressChanged = this.UploadProgressChanged;
			if (uploadProgressChanged != null)
			{
				IntPtr invoke_impl = uploadProgressChanged.invoke_impl;
				IntPtr method_code = uploadProgressChanged.method_code;
				IntPtr method = uploadProgressChanged.method;
				return;
			}
		}

		// Token: 0x060008E9 RID: 2281 RVA: 0x0001F14C File Offset: 0x0001D34C
		protected virtual void OnOpenReadCompleted(OpenReadCompletedEventArgs e)
		{
			OpenReadCompletedEventHandler openReadCompleted = this.OpenReadCompleted;
			if (openReadCompleted != null)
			{
				IntPtr invoke_impl = openReadCompleted.invoke_impl;
				IntPtr method_code = openReadCompleted.method_code;
				IntPtr method = openReadCompleted.method;
				return;
			}
		}

		// Token: 0x060008EA RID: 2282 RVA: 0x0001F17C File Offset: 0x0001D37C
		protected virtual void OnOpenWriteCompleted(OpenWriteCompletedEventArgs e)
		{
			OpenWriteCompletedEventHandler openWriteCompleted = this.OpenWriteCompleted;
			if (openWriteCompleted != null)
			{
				IntPtr invoke_impl = openWriteCompleted.invoke_impl;
				IntPtr method_code = openWriteCompleted.method_code;
				IntPtr method = openWriteCompleted.method;
				return;
			}
		}

		// Token: 0x060008EB RID: 2283 RVA: 0x0001F1AC File Offset: 0x0001D3AC
		private void StartOperation()
		{
			if (this._progress != null)
			{
			}
		}

		// Token: 0x060008EC RID: 2284 RVA: 0x0001F1C8 File Offset: 0x0001D3C8
		private global::System.ComponentModel.AsyncOperation StartAsyncOperation(object userToken)
		{
			if (!this._initWebClientAsync)
			{
				this._initWebClientAsync = true;
			}
			global::System.ComponentModel.AsyncOperation asyncOperation = global::System.ComponentModel.AsyncOperationManager.CreateOperation(userToken);
			this.StartOperation();
			this._asyncOp = asyncOperation;
			return asyncOperation;
		}

		// Token: 0x060008ED RID: 2285 RVA: 0x0001F1FC File Offset: 0x0001D3FC
		private void EndOperation()
		{
		}

		// Token: 0x170001EC RID: 492
		// (get) Token: 0x060008EE RID: 2286 RVA: 0x0001F20C File Offset: 0x0001D40C
		// (set) Token: 0x060008EF RID: 2287 RVA: 0x0001F220 File Offset: 0x0001D420
		public Encoding Encoding
		{
			get
			{
				return this._encoding;
			}
			set
			{
				if (!true)
				{
				}
				WebClient.ThrowIfNull(value, "Encoding");
				this._encoding = value;
			}
		}

		// Token: 0x170001ED RID: 493
		// (get) Token: 0x060008F0 RID: 2288 RVA: 0x0001F244 File Offset: 0x0001D444
		// (set) Token: 0x060008F1 RID: 2289 RVA: 0x0001F264 File Offset: 0x0001D464
		public string BaseAddress
		{
			get
			{
				/*
An exception occurred when decompiling this method (060008F0)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.String System.Net.WebClient::get_BaseAddress()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_000A:
	stloc:Uri(var_2_10, ldfld:Uri(WebClient::_baseAddress, ldloc:WebClient(this)))
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
				bool flag = string.IsNullOrEmpty(value);
			}
		}

		// Token: 0x170001EE RID: 494
		// (get) Token: 0x060008F2 RID: 2290 RVA: 0x0001F27C File Offset: 0x0001D47C
		// (set) Token: 0x060008F3 RID: 2291 RVA: 0x0001F290 File Offset: 0x0001D490
		public ICredentials Credentials
		{
			get
			{
				return this._credentials;
			}
			set
			{
				this._credentials = value;
			}
		}

		// Token: 0x170001EF RID: 495
		// (get) Token: 0x060008F4 RID: 2292 RVA: 0x0001F2A4 File Offset: 0x0001D4A4
		// (set) Token: 0x060008F5 RID: 2293 RVA: 0x0001F2BC File Offset: 0x0001D4BC
		public bool UseDefaultCredentials
		{
			get
			{
				/*
An exception occurred when decompiling this method (060008F4)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean System.Net.WebClient::get_UseDefaultCredentials()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0000:
	stloc:ICredentials(var_0_06, ldfld:ICredentials(WebClient::_credentials, ldloc:WebClient(this)))
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
			set
			{
				if (!true)
				{
				}
			}
		}

		// Token: 0x170001F0 RID: 496
		// (get) Token: 0x060008F6 RID: 2294 RVA: 0x0001F2D8 File Offset: 0x0001D4D8
		// (set) Token: 0x060008F7 RID: 2295 RVA: 0x0001F2EC File Offset: 0x0001D4EC
		public WebHeaderCollection Headers
		{
			get
			{
				/*
An exception occurred when decompiling this method (060008F6)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Net.WebHeaderCollection System.Net.WebClient::get_Headers()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0000:
	brtrue(IL_0000, ldfld:WebHeaderCollection[exp:bool](WebClient::_headers, ldloc:WebClient(this)))
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
				this._headers = value;
			}
		}

		// Token: 0x170001F1 RID: 497
		// (get) Token: 0x060008F8 RID: 2296 RVA: 0x0001F300 File Offset: 0x0001D500
		// (set) Token: 0x060008F9 RID: 2297 RVA: 0x0001F314 File Offset: 0x0001D514
		public global::System.Collections.Specialized.NameValueCollection QueryString
		{
			get
			{
				/*
An exception occurred when decompiling this method (060008F8)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Collections.Specialized.NameValueCollection System.Net.WebClient::get_QueryString()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0000:
	brtrue(IL_0000, ldfld:NameValueCollection[exp:bool](WebClient::_requestParameters, ldloc:WebClient(this)))
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
				this._requestParameters = value;
			}
		}

		// Token: 0x170001F2 RID: 498
		// (get) Token: 0x060008FA RID: 2298 RVA: 0x0001F328 File Offset: 0x0001D528
		public WebHeaderCollection ResponseHeaders
		{
			get
			{
				/*
An exception occurred when decompiling this method (060008FA)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Net.WebHeaderCollection System.Net.WebClient::get_ResponseHeaders()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0000:
	brtrue(IL_0000, logicnot:bool(ldfld:WebResponse[exp:bool](WebClient::_webResponse, ldloc:WebClient(this))))
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

		// Token: 0x170001F3 RID: 499
		// (get) Token: 0x060008FB RID: 2299 RVA: 0x0001F33C File Offset: 0x0001D53C
		// (set) Token: 0x060008FC RID: 2300 RVA: 0x0001F360 File Offset: 0x0001D560
		public IWebProxy Proxy
		{
			get
			{
				if (this._proxySet)
				{
					return this._proxy;
				}
				return WebRequest.DefaultWebProxy;
			}
			set
			{
				this._proxy = value;
				this._proxySet = true;
			}
		}

		// Token: 0x170001F4 RID: 500
		// (get) Token: 0x060008FD RID: 2301 RVA: 0x0001F37C File Offset: 0x0001D57C
		// (set) Token: 0x060008FE RID: 2302 RVA: 0x0001F390 File Offset: 0x0001D590
		public global::System.Net.Cache.RequestCachePolicy CachePolicy
		{
			[CompilerGenerated]
			get
			{
				return this.<CachePolicy>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<CachePolicy>k__BackingField = value;
			}
		}

		// Token: 0x170001F5 RID: 501
		// (get) Token: 0x060008FF RID: 2303 RVA: 0x0001F3A4 File Offset: 0x0001D5A4
		public bool IsBusy
		{
			get
			{
				/*
An exception occurred when decompiling this method (060008FF)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean System.Net.WebClient::get_IsBusy()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:AsyncOperation(var_0_06, ldfld:AsyncOperation(WebClient::_asyncOp, ldloc:WebClient(this)))
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

		// Token: 0x06000900 RID: 2304 RVA: 0x0001F3B8 File Offset: 0x0001D5B8
		protected virtual WebRequest GetWebRequest(global::System.Uri address)
		{
			if (!true)
			{
			}
			WebRequest webRequest = WebRequest.Create(address);
			this.CopyHeadersTo(webRequest);
			if (this._credentials != null)
			{
			}
			if (this._method != null)
			{
			}
			if (this._proxySet)
			{
				IWebProxy proxy = this._proxy;
			}
			if (this.<CachePolicy>k__BackingField != null)
			{
			}
			return webRequest;
		}

		// Token: 0x06000901 RID: 2305 RVA: 0x0001F400 File Offset: 0x0001D600
		protected virtual WebResponse GetWebResponse(WebRequest request)
		{
			/*
An exception occurred when decompiling this method (06000901)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Net.WebResponse System.Net.WebClient::GetWebResponse(System.Net.WebRequest)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stfld:WebResponse(WebClient::_webResponse, ldloc:WebClient(this), ldloc:WebRequest[exp:WebResponse](request))
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

		// Token: 0x06000902 RID: 2306 RVA: 0x0001F414 File Offset: 0x0001D614
		protected virtual WebResponse GetWebResponse(WebRequest request, IAsyncResult result)
		{
			/*
An exception occurred when decompiling this method (06000902)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Net.WebResponse System.Net.WebClient::GetWebResponse(System.Net.WebRequest,System.IAsyncResult)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stfld:WebResponse(WebClient::_webResponse, ldloc:WebClient(this), ldloc:WebRequest[exp:WebResponse](request))
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

		// Token: 0x06000903 RID: 2307 RVA: 0x0001F428 File Offset: 0x0001D628
		private Task<WebResponse> GetWebResponseTaskAsync(WebRequest request)
		{
			/*
An exception occurred when decompiling this method (06000903)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Threading.Tasks.Task`1<System.Net.WebResponse> System.Net.WebClient::GetWebResponseTaskAsync(System.Net.WebRequest)

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

		// Token: 0x06000904 RID: 2308 RVA: 0x0001F438 File Offset: 0x0001D638
		public byte[] DownloadData(string address)
		{
			global::System.Uri uri = this.GetUri(address);
			return this.DownloadData(uri);
		}

		// Token: 0x06000905 RID: 2309 RVA: 0x0001F454 File Offset: 0x0001D654
		public byte[] DownloadData(global::System.Uri address)
		{
			if (!true)
			{
			}
			WebClient.ThrowIfNull(address, "address");
			this.StartOperation();
			byte[] array;
			return array;
		}

		// Token: 0x06000906 RID: 2310 RVA: 0x0001F488 File Offset: 0x0001D688
		private byte[] DownloadDataInternal(global::System.Uri address, [Out] WebRequest request)
		{
			global::System.Uri uri = this.GetUri(address);
			this._webRequest = this;
			byte[] array;
			return array;
		}

		// Token: 0x06000907 RID: 2311 RVA: 0x0001F4B4 File Offset: 0x0001D6B4
		public void DownloadFile(string address, string fileName)
		{
			global::System.Uri uri = this.GetUri(address);
		}

		// Token: 0x06000908 RID: 2312 RVA: 0x0001F4CC File Offset: 0x0001D6CC
		public void DownloadFile(global::System.Uri address, string fileName)
		{
			if (!true)
			{
			}
			WebClient.ThrowIfNull(address, "address");
			WebClient.ThrowIfNull(fileName, "fileName");
			this.StartOperation();
			global::System.Uri uri = this.GetUri(address);
			this._webRequest = this;
			long num = 0L;
			if (!true)
			{
				File.Delete(fileName);
			}
			if (num == 0L)
			{
				return;
			}
			throw new OutOfMemoryException();
		}

		// Token: 0x06000909 RID: 2313 RVA: 0x0001F56C File Offset: 0x0001D76C
		public Stream OpenRead(string address)
		{
			global::System.Uri uri = this.GetUri(address);
			return this.OpenRead(uri);
		}

		// Token: 0x0600090A RID: 2314 RVA: 0x0001F588 File Offset: 0x0001D788
		public Stream OpenRead(global::System.Uri address)
		{
			if (!true)
			{
			}
			WebClient.ThrowIfNull(address, "address");
			this.StartOperation();
			global::System.Uri uri = this.GetUri(address);
			this._webRequest = this;
			this._webResponse = this;
			throw new OutOfMemoryException();
		}

		// Token: 0x0600090B RID: 2315 RVA: 0x0001F630 File Offset: 0x0001D830
		public Stream OpenWrite(string address)
		{
			global::System.Uri uri = this.GetUri(address);
			Stream stream;
			return stream;
		}

		// Token: 0x0600090C RID: 2316 RVA: 0x0001F648 File Offset: 0x0001D848
		public Stream OpenWrite(global::System.Uri address)
		{
			Stream stream;
			return stream;
		}

		// Token: 0x0600090D RID: 2317 RVA: 0x0001F658 File Offset: 0x0001D858
		public Stream OpenWrite(string address, string method)
		{
			global::System.Uri uri = this.GetUri(address);
			return this.OpenWrite(uri, method);
		}

		// Token: 0x0600090E RID: 2318 RVA: 0x0001F678 File Offset: 0x0001D878
		public Stream OpenWrite(global::System.Uri address, string method)
		{
			if (!true)
			{
			}
			WebClient.ThrowIfNull(address, "address");
			string text;
			if (method == null)
			{
				text = this.MapToDefaultMethod(address);
			}
			this.StartOperation();
			this._method = text;
			global::System.Uri uri = this.GetUri(address);
			this._webRequest = this;
			int num = Interlocked.Decrement(-1073741824);
			return -1073741824;
		}

		// Token: 0x0600090F RID: 2319 RVA: 0x0001F764 File Offset: 0x0001D964
		public byte[] UploadData(string address, byte[] data)
		{
			global::System.Uri uri = this.GetUri(address);
			byte[] array;
			return array;
		}

		// Token: 0x06000910 RID: 2320 RVA: 0x0001F77C File Offset: 0x0001D97C
		public byte[] UploadData(global::System.Uri address, byte[] data)
		{
			byte[] array;
			return array;
		}

		// Token: 0x06000911 RID: 2321 RVA: 0x0001F78C File Offset: 0x0001D98C
		public byte[] UploadData(string address, string method, byte[] data)
		{
			global::System.Uri uri = this.GetUri(address);
			return this.UploadData(uri, method, data);
		}

		// Token: 0x06000912 RID: 2322 RVA: 0x0001F7AC File Offset: 0x0001D9AC
		public byte[] UploadData(global::System.Uri address, string method, byte[] data)
		{
			if (!true)
			{
			}
			WebClient.ThrowIfNull(address, "address");
			WebClient.ThrowIfNull(data, "data");
			if (method == null)
			{
				string text = this.MapToDefaultMethod(address);
			}
			this.StartOperation();
			byte[] array;
			return array;
		}

		// Token: 0x06000913 RID: 2323 RVA: 0x0001F7F8 File Offset: 0x0001D9F8
		private byte[] UploadDataInternal(global::System.Uri address, string method, byte[] data, [Out] WebRequest request)
		{
			this._method = method;
			global::System.Uri uri = this.GetUri(address);
			this._webRequest = this;
			byte[] array;
			return array;
		}

		// Token: 0x06000914 RID: 2324 RVA: 0x0001F828 File Offset: 0x0001DA28
		private void OpenFileInternal(bool needsHeaderAndBoundary, string fileName, FileStream fs, byte[] buffer, byte[] formHeaderBytes, byte[] boundaryBytes)
		{
			if (!true)
			{
			}
			string fullPath = Path.GetFullPath(fileName);
			if (this.Headers["Content-Type"] != null)
			{
			}
			string method = this._method;
			long ticks = DateTime.Now.Ticks;
			NumberFormatInfo invariantInfo = NumberFormatInfo.InvariantInfo;
			string text2;
			string text = "---------------------" + text2;
			string text3 = "multipart/form-data; boundary=" + text;
			string text4;
			if (("--" == null || "--" != null) && (text == null || text != null) && ("\r\nContent-Disposition: form-data; name=\"file\"; filename=\"" == null || "\r\nContent-Disposition: form-data; name=\"file\"; filename=\"" != null) && (text4 == null || text4 != null) && ("\"\r\nContent-Type: " == null || "\"\r\nContent-Type: " != null) && ("application/octet-stream" == null || "application/octet-stream" != null) && ("\r\n\r\n" == null || "\r\n\r\n" != null))
			{
				Encoding utf = Encoding.UTF8;
				boundaryBytes.m_value = utf;
				Encoding ascii = Encoding.ASCII;
				string text5 = "\r\n--" + text + "--\r\n";
				return;
			}
			throw new ArrayTypeMismatchException();
		}

		// Token: 0x06000915 RID: 2325 RVA: 0x0001F938 File Offset: 0x0001DB38
		public byte[] UploadFile(string address, string fileName)
		{
			global::System.Uri uri = this.GetUri(address);
			byte[] array;
			return array;
		}

		// Token: 0x06000916 RID: 2326 RVA: 0x0001F950 File Offset: 0x0001DB50
		public byte[] UploadFile(global::System.Uri address, string fileName)
		{
			byte[] array;
			return array;
		}

		// Token: 0x06000917 RID: 2327 RVA: 0x0001F960 File Offset: 0x0001DB60
		public byte[] UploadFile(string address, string method, string fileName)
		{
			global::System.Uri uri = this.GetUri(address);
			return this.UploadFile(uri, method, fileName);
		}

		// Token: 0x06000918 RID: 2328 RVA: 0x0001F980 File Offset: 0x0001DB80
		public byte[] UploadFile(global::System.Uri address, string method, string fileName)
		{
			int num = 1;
			if (num == 0)
			{
			}
			WebClient.ThrowIfNull(address, "address");
			WebClient.ThrowIfNull(fileName, "fileName");
			string text;
			if (method == null)
			{
				text = this.MapToDefaultMethod(address);
			}
			this.StartOperation();
			this._method = text;
			string scheme = this.GetUri(address).Scheme;
			if (num == 0)
			{
			}
			this._webRequest = this;
			byte[] array;
			return array;
		}

		// Token: 0x06000919 RID: 2329 RVA: 0x0001FA4C File Offset: 0x0001DC4C
		private byte[] GetValuesToUpload(global::System.Collections.Specialized.NameValueCollection data)
		{
			/*
An exception occurred when decompiling this method (06000919)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Byte[] System.Net.WebClient::GetValuesToUpload(System.Collections.Specialized.NameValueCollection)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0030:
	stloc:string(var_10_3B, call:string(WebClient::UrlEncode, ldloc:string(var_9)))
	stloc:Encoding(var_13_45, callgetter:Encoding(Encoding::get_ASCII))
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

		// Token: 0x0600091A RID: 2330 RVA: 0x0001FAA0 File Offset: 0x0001DCA0
		public byte[] UploadValues(string address, global::System.Collections.Specialized.NameValueCollection data)
		{
			global::System.Uri uri = this.GetUri(address);
			byte[] array;
			return array;
		}

		// Token: 0x0600091B RID: 2331 RVA: 0x0001FAB8 File Offset: 0x0001DCB8
		public byte[] UploadValues(global::System.Uri address, global::System.Collections.Specialized.NameValueCollection data)
		{
			byte[] array;
			return array;
		}

		// Token: 0x0600091C RID: 2332 RVA: 0x0001FAC8 File Offset: 0x0001DCC8
		public byte[] UploadValues(string address, string method, global::System.Collections.Specialized.NameValueCollection data)
		{
			global::System.Uri uri = this.GetUri(address);
			return this.UploadValues(uri, method, data);
		}

		// Token: 0x0600091D RID: 2333 RVA: 0x0001FAE8 File Offset: 0x0001DCE8
		public byte[] UploadValues(global::System.Uri address, string method, global::System.Collections.Specialized.NameValueCollection data)
		{
			if (!true)
			{
			}
			WebClient.ThrowIfNull(address, "address");
			WebClient.ThrowIfNull(data, "data");
			string text;
			if (method == null)
			{
				text = this.MapToDefaultMethod(address);
			}
			this.StartOperation();
			byte[] valuesToUpload = this.GetValuesToUpload(data);
			this._method = text;
			global::System.Uri uri = this.GetUri(address);
			this._webRequest = this;
			byte[] array;
			return array;
		}

		// Token: 0x0600091E RID: 2334 RVA: 0x0001FBB8 File Offset: 0x0001DDB8
		public string UploadString(string address, string data)
		{
			global::System.Uri uri = this.GetUri(address);
			string text;
			return text;
		}

		// Token: 0x0600091F RID: 2335 RVA: 0x0001FBD0 File Offset: 0x0001DDD0
		public string UploadString(global::System.Uri address, string data)
		{
			string text;
			return text;
		}

		// Token: 0x06000920 RID: 2336 RVA: 0x0001FBE0 File Offset: 0x0001DDE0
		public string UploadString(string address, string method, string data)
		{
			global::System.Uri uri = this.GetUri(address);
			return this.UploadString(uri, method, data);
		}

		// Token: 0x06000921 RID: 2337 RVA: 0x0001FC00 File Offset: 0x0001DE00
		public string UploadString(global::System.Uri address, string method, string data)
		{
			if (!true)
			{
			}
			WebClient.ThrowIfNull(address, "address");
			if (method == null)
			{
				string text = this.MapToDefaultMethod(address);
			}
			this.StartOperation();
			Encoding encoding = this._encoding;
			string text2;
			return text2;
		}

		// Token: 0x06000922 RID: 2338 RVA: 0x0001FC4C File Offset: 0x0001DE4C
		public string DownloadString(string address)
		{
			global::System.Uri uri = this.GetUri(address);
			return this.DownloadString(uri);
		}

		// Token: 0x06000923 RID: 2339 RVA: 0x0001FC68 File Offset: 0x0001DE68
		public string DownloadString(global::System.Uri address)
		{
			if (!true)
			{
			}
			WebClient.ThrowIfNull(address, "address");
			this.StartOperation();
			string text;
			return text;
		}

		// Token: 0x06000924 RID: 2340 RVA: 0x0001FCA0 File Offset: 0x0001DEA0
		private static void AbortRequest(WebRequest request)
		{
			if (request != null)
			{
			}
		}

		// Token: 0x06000925 RID: 2341 RVA: 0x0001FCB4 File Offset: 0x0001DEB4
		private void CopyHeadersTo(WebRequest request)
		{
			WebHeaderCollection headers = this._headers;
			if (headers != null && request != null)
			{
				string text = headers["Accept"];
				string text2 = this._headers["Connection"];
				string text3 = this._headers["Content-Type"];
				string text4 = this._headers["Expect"];
				string text5 = this._headers["Referer"];
				string text6 = this._headers["User-Agent"];
				string text7 = this._headers["Host"];
				WebHeaderCollection headers2 = this._headers;
				WebHeaderCollection headers3 = this._headers;
				WebHeaderCollection headers4 = this._headers;
				WebHeaderCollection headers5 = this._headers;
				WebHeaderCollection headers6 = this._headers;
				WebHeaderCollection headers7 = this._headers;
				WebHeaderCollection headers8 = this._headers;
				WebHeaderCollection headers9 = this._headers;
				bool flag = string.IsNullOrEmpty(text);
				bool flag2 = string.IsNullOrEmpty(text2);
				bool flag3 = string.IsNullOrEmpty(text3);
				bool flag4 = string.IsNullOrEmpty(text6);
				bool flag5 = string.IsNullOrEmpty(text7);
			}
		}

		// Token: 0x06000926 RID: 2342 RVA: 0x0001FDB8 File Offset: 0x0001DFB8
		private global::System.Uri GetUri(string address)
		{
			if (!true)
			{
			}
			WebClient.ThrowIfNull(address, "address");
			global::System.Uri baseAddress = this._baseAddress;
			if (!true)
			{
			}
			global::System.Uri baseAddress2 = this._baseAddress;
			if (!true)
			{
			}
			if (!true)
			{
			}
			string fullPath = Path.GetFullPath(address);
			global::System.Uri uri;
			return uri;
		}

		// Token: 0x06000927 RID: 2343 RVA: 0x0001FDF4 File Offset: 0x0001DFF4
		private global::System.Uri GetUri(global::System.Uri address)
		{
			/*
An exception occurred when decompiling this method (06000927)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Uri System.Net.WebClient::GetUri(System.Uri)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:NameValueCollection(var_7_47, ldfld:NameValueCollection(WebClient::_requestParameters, ldloc:WebClient(this)))
	stloc:int64(var_8_4A, ldc.i4:int64(0))
	stloc:IEqualityComparer(var_10_57, ldfld:IEqualityComparer(NameObjectCollectionBase::_keyComparer, ldfld:NameValueCollection[exp:NameObjectCollectionBase](WebClient::_requestParameters, ldloc:WebClient(this))))
	stloc:int32(var_12_5B, ldc.i4:int32(61))
	stloc:StringBuilder(var_13_66, call:StringBuilder(StringBuilder::Append, ldloc:StringBuilder(var_11), ldloc:int32[exp:char](var_12_5B)))
	stloc:string(var_14_75, callgetter:string(NameValueCollection::get_Item, ldfld:NameValueCollection(WebClient::_requestParameters, ldloc:WebClient(this)), ldloc:int64[exp:int32](var_8_4A)))
	stloc:StringBuilder(var_15_80, call:StringBuilder(StringBuilder::Append, ldloc:StringBuilder(var_13_66), ldloc:string(var_14_75)))
	stloc:NameValueCollection(var_16_88, ldfld:NameValueCollection(WebClient::_requestParameters, ldloc:WebClient(this)))
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

		// Token: 0x06000928 RID: 2344 RVA: 0x0001FE8C File Offset: 0x0001E08C
		private byte[] DownloadBits(WebRequest request, Stream writeStream)
		{
			this._webResponse = this;
			int num;
			if (writeStream != null)
			{
				num = 32768;
			}
			byte[] array;
			if (this != null)
			{
				if (this != null)
				{
				}
				long num2 = 0L;
				int num3 = 13;
				if (num != 0)
				{
				}
				if (num2 != 0L)
				{
					throw new OutOfMemoryException();
				}
				if (num3 != 0)
				{
					return array;
				}
			}
			if (writeStream != null)
			{
			}
			return array;
		}

		// Token: 0x06000929 RID: 2345 RVA: 0x0001FEEC File Offset: 0x0001E0EC
		private void DownloadBitsAsync(WebRequest request, Stream writeStream, global::System.ComponentModel.AsyncOperation asyncOp, Action<byte[], Exception, global::System.ComponentModel.AsyncOperation> completionDelegate)
		{
			AsyncVoidMethodBuilder asyncVoidMethodBuilder = AsyncVoidMethodBuilder.Create();
		}

		// Token: 0x0600092A RID: 2346 RVA: 0x0001FF04 File Offset: 0x0001E104
		private byte[] UploadBits(WebRequest request, Stream readStream, byte[] buffer, int chunkSize, byte[] header, byte[] footer)
		{
			if (header != null)
			{
			}
			if (readStream != null)
			{
				long num = 0L;
				int num2 = 8;
				if (num != 0L)
				{
					throw new OutOfMemoryException();
				}
				if (num2 == 0)
				{
				}
			}
			long num3 = 0L;
			int num4 = 13;
			if (request != null)
			{
			}
			if (num3 == 0L)
			{
				if (num4 == 0)
				{
				}
				byte[] array;
				return array;
			}
			throw new OutOfMemoryException();
		}

		// Token: 0x0600092B RID: 2347 RVA: 0x0001FF7C File Offset: 0x0001E17C
		private void UploadBitsAsync(WebRequest request, Stream readStream, byte[] buffer, int chunkSize, byte[] header, byte[] footer, global::System.ComponentModel.AsyncOperation asyncOp, Action<byte[], Exception, global::System.ComponentModel.AsyncOperation> completionDelegate)
		{
			AsyncVoidMethodBuilder asyncVoidMethodBuilder = AsyncVoidMethodBuilder.Create();
		}

		// Token: 0x0600092C RID: 2348 RVA: 0x0001FF94 File Offset: 0x0001E194
		private static bool ByteArrayHasPrefix(byte[] prefix, byte[] byteArray)
		{
			while (prefix == null)
			{
			}
		}

		// Token: 0x0600092D RID: 2349 RVA: 0x0001FFAC File Offset: 0x0001E1AC
		private string GetStringUsingEncoding(WebRequest request, byte[] data)
		{
			Encoding encoding;
			if (request != null)
			{
				CultureInfo invariantCulture = CultureInfo.InvariantCulture;
				string[] array;
				bool flag = array == "charset";
				if (encoding != null)
				{
					goto IL_0033;
				}
			}
			CodePageDataItem dataItem = encoding.dataItem;
			Encoding encoding2 = this._encoding;
			IL_0033:
			CodePageDataItem dataItem2 = encoding2.dataItem;
			while (encoding2 != null)
			{
			}
		}

		// Token: 0x0600092E RID: 2350 RVA: 0x0001FFFC File Offset: 0x0001E1FC
		private string MapToDefaultMethod(global::System.Uri address)
		{
			/*
An exception occurred when decompiling this method (0600092E)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.String System.Net.WebClient::MapToDefaultMethod(System.Uri)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0011:
	stloc:Uri(var_3_17, ldfld:Uri(WebClient::_baseAddress, ldloc:WebClient(this)))
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

		// Token: 0x0600092F RID: 2351 RVA: 0x00020020 File Offset: 0x0001E220
		private static string UrlEncode(string str)
		{
			/*
An exception occurred when decompiling this method (0600092F)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.String System.Net.WebClient::UrlEncode(System.String)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:Encoding(var_1_07, callgetter:Encoding(Encoding::get_UTF8))
	stloc:Encoding(var_3_0F, callgetter:Encoding(Encoding::get_ASCII))
	stloc:CodePageDataItem(var_4_16, ldfld:CodePageDataItem(Encoding::dataItem, ldloc:Encoding(var_1_07)))
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

		// Token: 0x06000930 RID: 2352 RVA: 0x00020048 File Offset: 0x0001E248
		private static byte[] UrlEncodeBytesToBytesInternal(byte[] bytes, int offset, int count, bool alwaysCreateReturnValue)
		{
			int num = 1;
			if (num == 0)
			{
			}
			if (num == 0)
			{
				return;
			}
		}

		// Token: 0x06000931 RID: 2353 RVA: 0x00002050 File Offset: 0x00000250
		private static char IntToHex(int n)
		{
			throw new global::Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06000932 RID: 2354 RVA: 0x00020064 File Offset: 0x0001E264
		private static bool IsSafe(char ch)
		{
		}

		// Token: 0x06000933 RID: 2355 RVA: 0x00020074 File Offset: 0x0001E274
		private void InvokeOperationCompleted(global::System.ComponentModel.AsyncOperation asyncOp, SendOrPostCallback callback, global::System.ComponentModel.AsyncCompletedEventArgs eventArgs)
		{
		}

		// Token: 0x06000934 RID: 2356 RVA: 0x0002008C File Offset: 0x0001E28C
		public void OpenReadAsync(global::System.Uri address)
		{
			long num = 0L;
			this.OpenReadAsync(address, num);
		}

		// Token: 0x06000935 RID: 2357 RVA: 0x000200A4 File Offset: 0x0001E2A4
		public void OpenReadAsync(global::System.Uri address, object userToken)
		{
			if (!true)
			{
			}
			WebClient.ThrowIfNull(address, "address");
			global::System.ComponentModel.AsyncOperation asyncOperation = this.StartAsyncOperation(userToken);
			global::System.Uri uri = this.GetUri(address);
			this._webRequest = this;
		}

		// Token: 0x06000936 RID: 2358 RVA: 0x000200EC File Offset: 0x0001E2EC
		public void OpenWriteAsync(global::System.Uri address)
		{
		}

		// Token: 0x06000937 RID: 2359 RVA: 0x000200FC File Offset: 0x0001E2FC
		public void OpenWriteAsync(global::System.Uri address, string method)
		{
			long num = 0L;
			this.OpenWriteAsync(address, method, num);
		}

		// Token: 0x06000938 RID: 2360 RVA: 0x00020114 File Offset: 0x0001E314
		public void OpenWriteAsync(global::System.Uri address, string method, object userToken)
		{
			if (!true)
			{
			}
			WebClient.ThrowIfNull(address, "address");
			string text;
			if (method == null)
			{
				text = this.MapToDefaultMethod(address);
			}
			global::System.ComponentModel.AsyncOperation asyncOperation = this.StartAsyncOperation(userToken);
			this._method = text;
			global::System.Uri uri = this.GetUri(address);
			this._webRequest = this;
		}

		// Token: 0x06000939 RID: 2361 RVA: 0x00020170 File Offset: 0x0001E370
		private void DownloadStringAsyncCallback(byte[] returnBytes, Exception exception, object state)
		{
			if (state != null)
			{
			}
			if (returnBytes != null)
			{
				WebRequest webRequest = this._webRequest;
				string stringUsingEncoding = this.GetStringUsingEncoding(webRequest, returnBytes);
			}
			bool canceled = this._canceled;
			SendOrPostCallback downloadStringOperationCompleted = this._downloadStringOperationCompleted;
		}

		// Token: 0x0600093A RID: 2362 RVA: 0x000201AC File Offset: 0x0001E3AC
		public void DownloadStringAsync(global::System.Uri address)
		{
			long num = 0L;
			this.DownloadStringAsync(address, num);
		}

		// Token: 0x0600093B RID: 2363 RVA: 0x000201C4 File Offset: 0x0001E3C4
		public void DownloadStringAsync(global::System.Uri address, object userToken)
		{
			if (!true)
			{
			}
			WebClient.ThrowIfNull(address, "address");
			global::System.ComponentModel.AsyncOperation asyncOperation = this.StartAsyncOperation(userToken);
			global::System.Uri uri = this.GetUri(address);
			this._webRequest = this;
		}

		// Token: 0x0600093C RID: 2364 RVA: 0x00020200 File Offset: 0x0001E400
		private void DownloadDataAsyncCallback(byte[] returnBytes, Exception exception, object state)
		{
			if (state != null)
			{
			}
			bool canceled = this._canceled;
			SendOrPostCallback downloadDataOperationCompleted = this._downloadDataOperationCompleted;
		}

		// Token: 0x0600093D RID: 2365 RVA: 0x00020224 File Offset: 0x0001E424
		public void DownloadDataAsync(global::System.Uri address)
		{
			long num = 0L;
			this.DownloadDataAsync(address, num);
		}

		// Token: 0x0600093E RID: 2366 RVA: 0x0002023C File Offset: 0x0001E43C
		public void DownloadDataAsync(global::System.Uri address, object userToken)
		{
			if (!true)
			{
			}
			WebClient.ThrowIfNull(address, "address");
			global::System.ComponentModel.AsyncOperation asyncOperation = this.StartAsyncOperation(userToken);
			global::System.Uri uri = this.GetUri(address);
			this._webRequest = this;
		}

		// Token: 0x0600093F RID: 2367 RVA: 0x00020278 File Offset: 0x0001E478
		private void DownloadFileAsyncCallback(byte[] returnBytes, Exception exception, object state)
		{
			if (state != null)
			{
			}
			bool canceled = this._canceled;
			SendOrPostCallback downloadFileOperationCompleted = this._downloadFileOperationCompleted;
		}

		// Token: 0x06000940 RID: 2368 RVA: 0x0002029C File Offset: 0x0001E49C
		public void DownloadFileAsync(global::System.Uri address, string fileName)
		{
			long num = 0L;
			this.DownloadFileAsync(address, fileName, num);
		}

		// Token: 0x06000941 RID: 2369 RVA: 0x000202B4 File Offset: 0x0001E4B4
		public void DownloadFileAsync(global::System.Uri address, string fileName, object userToken)
		{
			if (!true)
			{
			}
			WebClient.ThrowIfNull(address, "address");
			WebClient.ThrowIfNull(fileName, "fileName");
			global::System.ComponentModel.AsyncOperation asyncOperation = this.StartAsyncOperation(userToken);
			global::System.Uri uri = this.GetUri(address);
			this._webRequest = this;
		}

		// Token: 0x06000942 RID: 2370 RVA: 0x000202FC File Offset: 0x0001E4FC
		public void UploadStringAsync(global::System.Uri address, string data)
		{
		}

		// Token: 0x06000943 RID: 2371 RVA: 0x0002030C File Offset: 0x0001E50C
		public void UploadStringAsync(global::System.Uri address, string method, string data)
		{
			long num = 0L;
			this.UploadStringAsync(address, method, data, num);
		}

		// Token: 0x06000944 RID: 2372 RVA: 0x00020328 File Offset: 0x0001E528
		public void UploadStringAsync(global::System.Uri address, string method, string data, object userToken)
		{
			if (!true)
			{
			}
			WebClient.ThrowIfNull(address, "address");
			WebClient.ThrowIfNull(data, "data");
			string text;
			if (method == null)
			{
				text = this.MapToDefaultMethod(address);
			}
			global::System.ComponentModel.AsyncOperation asyncOperation = this.StartAsyncOperation(userToken);
			Encoding encoding = this._encoding;
			this._method = text;
			this._contentLength = encoding;
			global::System.Uri uri = this.GetUri(address);
			this._webRequest = this;
		}

		// Token: 0x06000945 RID: 2373 RVA: 0x000203A4 File Offset: 0x0001E5A4
		public void UploadDataAsync(global::System.Uri address, byte[] data)
		{
		}

		// Token: 0x06000946 RID: 2374 RVA: 0x000203B4 File Offset: 0x0001E5B4
		public void UploadDataAsync(global::System.Uri address, string method, byte[] data)
		{
			long num = 0L;
			this.UploadDataAsync(address, method, data, num);
		}

		// Token: 0x06000947 RID: 2375 RVA: 0x000203D0 File Offset: 0x0001E5D0
		public void UploadDataAsync(global::System.Uri address, string method, byte[] data, object userToken)
		{
			int num = 1;
			if (num == 0)
			{
			}
			WebClient.ThrowIfNull(address, "address");
			WebClient.ThrowIfNull(data, "data");
			string text;
			if (method == null)
			{
				text = this.MapToDefaultMethod(address);
			}
			global::System.ComponentModel.AsyncOperation asyncOperation = this.StartAsyncOperation(userToken);
			this._method = text;
			this._contentLength = (long)num;
			global::System.Uri uri = this.GetUri(address);
			UploadProgressChangedEventHandler uploadProgressChanged = this.UploadProgressChanged;
			this._webRequest = this;
			if (uploadProgressChanged != null)
			{
				return;
			}
		}

		// Token: 0x06000948 RID: 2376 RVA: 0x00020454 File Offset: 0x0001E654
		public void UploadFileAsync(global::System.Uri address, string fileName)
		{
		}

		// Token: 0x06000949 RID: 2377 RVA: 0x00020464 File Offset: 0x0001E664
		public void UploadFileAsync(global::System.Uri address, string method, string fileName)
		{
			long num = 0L;
			this.UploadFileAsync(address, method, fileName, num);
		}

		// Token: 0x0600094A RID: 2378 RVA: 0x00020480 File Offset: 0x0001E680
		public void UploadFileAsync(global::System.Uri address, string method, string fileName, object userToken)
		{
			int num = 1;
			if (num == 0)
			{
			}
			WebClient.ThrowIfNull(address, "address");
			WebClient.ThrowIfNull(fileName, "fileName");
			string text;
			if (method == null)
			{
				text = this.MapToDefaultMethod(address);
			}
			global::System.ComponentModel.AsyncOperation asyncOperation = this.StartAsyncOperation(userToken);
			this._method = text;
			string scheme = this.GetUri(address).Scheme;
			if (num == 0)
			{
			}
			this._webRequest = this;
		}

		// Token: 0x0600094B RID: 2379 RVA: 0x000204F4 File Offset: 0x0001E6F4
		public void UploadValuesAsync(global::System.Uri address, global::System.Collections.Specialized.NameValueCollection data)
		{
		}

		// Token: 0x0600094C RID: 2380 RVA: 0x00020504 File Offset: 0x0001E704
		public void UploadValuesAsync(global::System.Uri address, string method, global::System.Collections.Specialized.NameValueCollection data)
		{
			long num = 0L;
			this.UploadValuesAsync(address, method, data, num);
		}

		// Token: 0x0600094D RID: 2381 RVA: 0x00020520 File Offset: 0x0001E720
		public void UploadValuesAsync(global::System.Uri address, string method, global::System.Collections.Specialized.NameValueCollection data, object userToken)
		{
			if (!true)
			{
			}
			WebClient.ThrowIfNull(address, "address");
			WebClient.ThrowIfNull(data, "data");
			string text;
			if (method == null)
			{
				text = this.MapToDefaultMethod(address);
			}
			global::System.ComponentModel.AsyncOperation asyncOperation = this.StartAsyncOperation(userToken);
			byte[] valuesToUpload = this.GetValuesToUpload(data);
			this._method = text;
			global::System.Uri uri = this.GetUri(address);
			UploadProgressChangedEventHandler uploadProgressChanged = this.UploadProgressChanged;
			this._webRequest = this;
			if (uploadProgressChanged != null)
			{
				return;
			}
		}

		// Token: 0x0600094E RID: 2382 RVA: 0x000205A4 File Offset: 0x0001E7A4
		private static Exception GetExceptionToPropagate(Exception e)
		{
		}

		// Token: 0x0600094F RID: 2383 RVA: 0x000205B4 File Offset: 0x0001E7B4
		public void CancelAsync()
		{
			this._canceled = true;
			WebRequest webRequest = this._webRequest;
			if (!true)
			{
			}
			WebClient.AbortRequest(webRequest);
		}

		// Token: 0x06000950 RID: 2384 RVA: 0x000205D8 File Offset: 0x0001E7D8
		public Task<string> DownloadStringTaskAsync(string address)
		{
			global::System.Uri uri = this.GetUri(address);
			return this.DownloadStringTaskAsync(uri);
		}

		// Token: 0x06000951 RID: 2385 RVA: 0x000205F4 File Offset: 0x0001E7F4
		public Task<string> DownloadStringTaskAsync(global::System.Uri address)
		{
			throw new OutOfMemoryException();
		}

		// Token: 0x06000952 RID: 2386 RVA: 0x00020608 File Offset: 0x0001E808
		public Task<Stream> OpenReadTaskAsync(string address)
		{
			global::System.Uri uri = this.GetUri(address);
			return this.OpenReadTaskAsync(uri);
		}

		// Token: 0x06000953 RID: 2387 RVA: 0x00020624 File Offset: 0x0001E824
		public Task<Stream> OpenReadTaskAsync(global::System.Uri address)
		{
			throw new OutOfMemoryException();
		}

		// Token: 0x06000954 RID: 2388 RVA: 0x00020638 File Offset: 0x0001E838
		public Task<Stream> OpenWriteTaskAsync(string address)
		{
			global::System.Uri uri = this.GetUri(address);
			Task<Stream> task;
			return task;
		}

		// Token: 0x06000955 RID: 2389 RVA: 0x00020650 File Offset: 0x0001E850
		public Task<Stream> OpenWriteTaskAsync(global::System.Uri address)
		{
			Task<Stream> task;
			return task;
		}

		// Token: 0x06000956 RID: 2390 RVA: 0x00020660 File Offset: 0x0001E860
		public Task<Stream> OpenWriteTaskAsync(string address, string method)
		{
			global::System.Uri uri = this.GetUri(address);
			return this.OpenWriteTaskAsync(uri, method);
		}

		// Token: 0x06000957 RID: 2391 RVA: 0x00020680 File Offset: 0x0001E880
		public Task<Stream> OpenWriteTaskAsync(global::System.Uri address, string method)
		{
			throw new OutOfMemoryException();
		}

		// Token: 0x06000958 RID: 2392 RVA: 0x00020694 File Offset: 0x0001E894
		public Task<string> UploadStringTaskAsync(string address, string data)
		{
			global::System.Uri uri = this.GetUri(address);
			Task<string> task;
			return task;
		}

		// Token: 0x06000959 RID: 2393 RVA: 0x000206AC File Offset: 0x0001E8AC
		public Task<string> UploadStringTaskAsync(global::System.Uri address, string data)
		{
			Task<string> task;
			return task;
		}

		// Token: 0x0600095A RID: 2394 RVA: 0x000206BC File Offset: 0x0001E8BC
		public Task<string> UploadStringTaskAsync(string address, string method, string data)
		{
			global::System.Uri uri = this.GetUri(address);
			return this.UploadStringTaskAsync(uri, method, data);
		}

		// Token: 0x0600095B RID: 2395 RVA: 0x000206DC File Offset: 0x0001E8DC
		public Task<string> UploadStringTaskAsync(global::System.Uri address, string method, string data)
		{
			throw new OutOfMemoryException();
		}

		// Token: 0x0600095C RID: 2396 RVA: 0x000206F0 File Offset: 0x0001E8F0
		public Task<byte[]> DownloadDataTaskAsync(string address)
		{
			global::System.Uri uri = this.GetUri(address);
			return this.DownloadDataTaskAsync(uri);
		}

		// Token: 0x0600095D RID: 2397 RVA: 0x0002070C File Offset: 0x0001E90C
		public Task<byte[]> DownloadDataTaskAsync(global::System.Uri address)
		{
			throw new OutOfMemoryException();
		}

		// Token: 0x0600095E RID: 2398 RVA: 0x00020720 File Offset: 0x0001E920
		public Task DownloadFileTaskAsync(string address, string fileName)
		{
			global::System.Uri uri = this.GetUri(address);
			return this.DownloadFileTaskAsync(uri, fileName);
		}

		// Token: 0x0600095F RID: 2399 RVA: 0x00020740 File Offset: 0x0001E940
		public Task DownloadFileTaskAsync(global::System.Uri address, string fileName)
		{
			long num = 0L;
			this.DownloadFileAsync(address, fileName, num);
			throw new OutOfMemoryException();
		}

		// Token: 0x06000960 RID: 2400 RVA: 0x00020760 File Offset: 0x0001E960
		public Task<byte[]> UploadDataTaskAsync(string address, byte[] data)
		{
			global::System.Uri uri = this.GetUri(address);
			Task<byte[]> task;
			return task;
		}

		// Token: 0x06000961 RID: 2401 RVA: 0x00020778 File Offset: 0x0001E978
		public Task<byte[]> UploadDataTaskAsync(global::System.Uri address, byte[] data)
		{
			Task<byte[]> task;
			return task;
		}

		// Token: 0x06000962 RID: 2402 RVA: 0x00020788 File Offset: 0x0001E988
		public Task<byte[]> UploadDataTaskAsync(string address, string method, byte[] data)
		{
			global::System.Uri uri = this.GetUri(address);
			return this.UploadDataTaskAsync(uri, method, data);
		}

		// Token: 0x06000963 RID: 2403 RVA: 0x000207A8 File Offset: 0x0001E9A8
		public Task<byte[]> UploadDataTaskAsync(global::System.Uri address, string method, byte[] data)
		{
			throw new OutOfMemoryException();
		}

		// Token: 0x06000964 RID: 2404 RVA: 0x000207BC File Offset: 0x0001E9BC
		public Task<byte[]> UploadFileTaskAsync(string address, string fileName)
		{
			global::System.Uri uri = this.GetUri(address);
			Task<byte[]> task;
			return task;
		}

		// Token: 0x06000965 RID: 2405 RVA: 0x000207D4 File Offset: 0x0001E9D4
		public Task<byte[]> UploadFileTaskAsync(global::System.Uri address, string fileName)
		{
			Task<byte[]> task;
			return task;
		}

		// Token: 0x06000966 RID: 2406 RVA: 0x000207E4 File Offset: 0x0001E9E4
		public Task<byte[]> UploadFileTaskAsync(string address, string method, string fileName)
		{
			global::System.Uri uri = this.GetUri(address);
			return this.UploadFileTaskAsync(uri, method, fileName);
		}

		// Token: 0x06000967 RID: 2407 RVA: 0x00020804 File Offset: 0x0001EA04
		public Task<byte[]> UploadFileTaskAsync(global::System.Uri address, string method, string fileName)
		{
			throw new OutOfMemoryException();
		}

		// Token: 0x06000968 RID: 2408 RVA: 0x00020818 File Offset: 0x0001EA18
		public Task<byte[]> UploadValuesTaskAsync(string address, global::System.Collections.Specialized.NameValueCollection data)
		{
			global::System.Uri uri = this.GetUri(address);
			Task<byte[]> task;
			return task;
		}

		// Token: 0x06000969 RID: 2409 RVA: 0x00020830 File Offset: 0x0001EA30
		public Task<byte[]> UploadValuesTaskAsync(string address, string method, global::System.Collections.Specialized.NameValueCollection data)
		{
			global::System.Uri uri = this.GetUri(address);
			return this.UploadValuesTaskAsync(uri, method, data);
		}

		// Token: 0x0600096A RID: 2410 RVA: 0x00020850 File Offset: 0x0001EA50
		public Task<byte[]> UploadValuesTaskAsync(global::System.Uri address, global::System.Collections.Specialized.NameValueCollection data)
		{
			Task<byte[]> task;
			return task;
		}

		// Token: 0x0600096B RID: 2411 RVA: 0x00020860 File Offset: 0x0001EA60
		public Task<byte[]> UploadValuesTaskAsync(global::System.Uri address, string method, global::System.Collections.Specialized.NameValueCollection data)
		{
			throw new OutOfMemoryException();
		}

		// Token: 0x0600096C RID: 2412 RVA: 0x00020874 File Offset: 0x0001EA74
		private void HandleCompletion<T, TAsyncCompletedEventArgs, TCompletionDelegate>(TaskCompletionSource<T> tcs, TAsyncCompletedEventArgs e, Func<TAsyncCompletedEventArgs, T> getResult, TCompletionDelegate handler, Action<WebClient, TCompletionDelegate> unregisterHandler) where TAsyncCompletedEventArgs : global::System.ComponentModel.AsyncCompletedEventArgs
		{
			long num = 0L;
			if (this != null)
			{
				if (num == 0L)
				{
					return;
				}
			}
			else
			{
				while (num == 0L)
				{
				}
			}
			throw new OutOfMemoryException();
		}

		// Token: 0x0600096D RID: 2413 RVA: 0x000208A8 File Offset: 0x0001EAA8
		private void PostProgressChanged(global::System.ComponentModel.AsyncOperation asyncOp, WebClient.ProgressData progress)
		{
			if (asyncOp != null)
			{
				long bytesSent = progress.BytesSent;
				long bytesReceived = progress.BytesReceived;
				if (progress.HasUploadPhase)
				{
					if (this.UploadProgressChanged != null)
					{
						long totalBytesToReceive = progress.TotalBytesToReceive;
						if (progress.BytesReceived != 0L)
						{
							long totalBytesToSend = progress.TotalBytesToSend;
							if (totalBytesToReceive != 0L)
							{
								long bytesReceived2 = progress.BytesReceived;
								return;
							}
							return;
						}
						else
						{
							if (progress.TotalBytesToSend != 0L)
							{
								return;
							}
							SendOrPostCallback reportUploadProgressChanged = this._reportUploadProgressChanged;
							object userSuppliedState = asyncOp._userSuppliedState;
							long bytesReceived3 = progress.BytesReceived;
							return;
						}
					}
				}
				else if (this.DownloadProgressChanged != null)
				{
					if (progress.TotalBytesToReceive != 0L)
					{
						long bytesReceived4 = progress.BytesReceived;
						return;
					}
					object userSuppliedState2 = asyncOp._userSuppliedState;
					return;
				}
			}
		}

		// Token: 0x0600096E RID: 2414 RVA: 0x00020948 File Offset: 0x0001EB48
		private static void ThrowIfNull(object argument, string parameterName)
		{
			while (argument == null)
			{
			}
		}

		// Token: 0x170001F6 RID: 502
		// (get) Token: 0x0600096F RID: 2415 RVA: 0x00020958 File Offset: 0x0001EB58
		// (set) Token: 0x06000970 RID: 2416 RVA: 0x0002096C File Offset: 0x0001EB6C
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		[Obsolete("This API supports the .NET Framework infrastructure and is not intended to be used directly from your code.", true)]
		public bool AllowReadStreamBuffering
		{
			[CompilerGenerated]
			get
			{
				return this.<AllowReadStreamBuffering>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170001F7 RID: 503
		// (get) Token: 0x06000971 RID: 2417 RVA: 0x0002097C File Offset: 0x0001EB7C
		// (set) Token: 0x06000972 RID: 2418 RVA: 0x00020990 File Offset: 0x0001EB90
		[Obsolete("This API supports the .NET Framework infrastructure and is not intended to be used directly from your code.", true)]
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public bool AllowWriteStreamBuffering
		{
			[CompilerGenerated]
			get
			{
				return this.<AllowWriteStreamBuffering>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1400000C RID: 12
		// (add) Token: 0x06000973 RID: 2419 RVA: 0x000209A0 File Offset: 0x0001EBA0
		// (remove) Token: 0x06000974 RID: 2420 RVA: 0x000209B0 File Offset: 0x0001EBB0
		public event WriteStreamClosedEventHandler WriteStreamClosed
		{
			add
			{
			}
			remove
			{
			}
		}

		// Token: 0x06000975 RID: 2421 RVA: 0x000209C0 File Offset: 0x0001EBC0
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		[Obsolete("This API supports the .NET Framework infrastructure and is not intended to be used directly from your code.", true)]
		protected virtual void OnWriteStreamClosed(WriteStreamClosedEventArgs e)
		{
		}

		// Token: 0x06000976 RID: 2422 RVA: 0x000209D0 File Offset: 0x0001EBD0
		// Note: this type is marked as 'beforefieldinit'.
		static WebClient()
		{
			Encoding utf = Encoding.UTF8;
			if (utf == null || utf != null)
			{
				Encoding utf2 = Encoding.UTF32;
				if (utf2 == null || utf2 != null)
				{
					Encoding unicode = Encoding.Unicode;
					if (unicode == null || unicode != null)
					{
						Encoding bigEndianUnicode = Encoding.BigEndianUnicode;
						if (bigEndianUnicode == null || bigEndianUnicode != null)
						{
							return;
						}
					}
				}
			}
			throw new ArrayTypeMismatchException();
		}

		// Token: 0x06000977 RID: 2423 RVA: 0x00020A24 File Offset: 0x0001EC24
		[CompilerGenerated]
		private void <StartAsyncOperation>b__78_0(object arg)
		{
			if (arg != null)
			{
			}
		}

		// Token: 0x06000978 RID: 2424 RVA: 0x00020A3C File Offset: 0x0001EC3C
		[CompilerGenerated]
		private void <StartAsyncOperation>b__78_1(object arg)
		{
			if (arg != null)
			{
			}
		}

		// Token: 0x06000979 RID: 2425 RVA: 0x00020A54 File Offset: 0x0001EC54
		[CompilerGenerated]
		private void <StartAsyncOperation>b__78_2(object arg)
		{
			if (arg != null)
			{
			}
		}

		// Token: 0x0600097A RID: 2426 RVA: 0x00020A6C File Offset: 0x0001EC6C
		[CompilerGenerated]
		private void <StartAsyncOperation>b__78_3(object arg)
		{
			if (arg != null)
			{
			}
		}

		// Token: 0x0600097B RID: 2427 RVA: 0x00020A84 File Offset: 0x0001EC84
		[CompilerGenerated]
		private void <StartAsyncOperation>b__78_4(object arg)
		{
			if (arg != null)
			{
			}
		}

		// Token: 0x0600097C RID: 2428 RVA: 0x00020A9C File Offset: 0x0001EC9C
		[CompilerGenerated]
		private void <StartAsyncOperation>b__78_5(object arg)
		{
			if (arg != null)
			{
			}
		}

		// Token: 0x0600097D RID: 2429 RVA: 0x00020AB4 File Offset: 0x0001ECB4
		[CompilerGenerated]
		private void <StartAsyncOperation>b__78_6(object arg)
		{
			if (arg != null)
			{
			}
		}

		// Token: 0x0600097E RID: 2430 RVA: 0x00020ACC File Offset: 0x0001ECCC
		[CompilerGenerated]
		private void <StartAsyncOperation>b__78_7(object arg)
		{
			if (arg != null)
			{
			}
		}

		// Token: 0x0600097F RID: 2431 RVA: 0x00020AE4 File Offset: 0x0001ECE4
		[CompilerGenerated]
		private void <StartAsyncOperation>b__78_8(object arg)
		{
			if (arg != null)
			{
			}
		}

		// Token: 0x06000980 RID: 2432 RVA: 0x00020AFC File Offset: 0x0001ECFC
		[CompilerGenerated]
		private void <StartAsyncOperation>b__78_9(object arg)
		{
			if (arg != null)
			{
			}
		}

		// Token: 0x06000981 RID: 2433 RVA: 0x00020B14 File Offset: 0x0001ED14
		[CompilerGenerated]
		private void <StartAsyncOperation>b__78_10(object arg)
		{
			if (arg != null)
			{
			}
		}

		// Token: 0x06000982 RID: 2434 RVA: 0x00020B2C File Offset: 0x0001ED2C
		[CompilerGenerated]
		private void <UploadStringAsync>b__179_0(byte[] bytesResult, Exception error, global::System.ComponentModel.AsyncOperation uploadAsyncOp)
		{
			if (bytesResult != null && error == null)
			{
				WebRequest webRequest = this._webRequest;
				string stringUsingEncoding = this.GetStringUsingEncoding(webRequest, bytesResult);
			}
			SendOrPostCallback uploadStringOperationCompleted = this._uploadStringOperationCompleted;
			bool canceled = this._canceled;
			object userSuppliedState = uploadAsyncOp._userSuppliedState;
		}

		// Token: 0x04000702 RID: 1794
		private const int DefaultCopyBufferLength = 8192;

		// Token: 0x04000703 RID: 1795
		private const int DefaultDownloadBufferLength = 65536;

		// Token: 0x04000704 RID: 1796
		private const string DefaultUploadFileContentType = "application/octet-stream";

		// Token: 0x04000705 RID: 1797
		private const string UploadFileContentType = "multipart/form-data";

		// Token: 0x04000706 RID: 1798
		private const string UploadValuesContentType = "application/x-www-form-urlencoded";

		// Token: 0x04000707 RID: 1799
		private global::System.Uri _baseAddress;

		// Token: 0x04000708 RID: 1800
		private ICredentials _credentials;

		// Token: 0x04000709 RID: 1801
		private WebHeaderCollection _headers;

		// Token: 0x0400070A RID: 1802
		private global::System.Collections.Specialized.NameValueCollection _requestParameters;

		// Token: 0x0400070B RID: 1803
		private WebResponse _webResponse;

		// Token: 0x0400070C RID: 1804
		private WebRequest _webRequest;

		// Token: 0x0400070D RID: 1805
		private Encoding _encoding;

		// Token: 0x0400070E RID: 1806
		private string _method;

		// Token: 0x0400070F RID: 1807
		private long _contentLength;

		// Token: 0x04000710 RID: 1808
		private bool _initWebClientAsync;

		// Token: 0x04000711 RID: 1809
		private bool _canceled;

		// Token: 0x04000712 RID: 1810
		private WebClient.ProgressData _progress;

		// Token: 0x04000713 RID: 1811
		private IWebProxy _proxy;

		// Token: 0x04000714 RID: 1812
		private bool _proxySet;

		// Token: 0x04000715 RID: 1813
		private int _callNesting;

		// Token: 0x04000716 RID: 1814
		private global::System.ComponentModel.AsyncOperation _asyncOp;

		// Token: 0x04000717 RID: 1815
		private SendOrPostCallback _downloadDataOperationCompleted;

		// Token: 0x04000718 RID: 1816
		private SendOrPostCallback _openReadOperationCompleted;

		// Token: 0x04000719 RID: 1817
		private SendOrPostCallback _openWriteOperationCompleted;

		// Token: 0x0400071A RID: 1818
		private SendOrPostCallback _downloadStringOperationCompleted;

		// Token: 0x0400071B RID: 1819
		private SendOrPostCallback _downloadFileOperationCompleted;

		// Token: 0x0400071C RID: 1820
		private SendOrPostCallback _uploadStringOperationCompleted;

		// Token: 0x0400071D RID: 1821
		private SendOrPostCallback _uploadDataOperationCompleted;

		// Token: 0x0400071E RID: 1822
		private SendOrPostCallback _uploadFileOperationCompleted;

		// Token: 0x0400071F RID: 1823
		private SendOrPostCallback _uploadValuesOperationCompleted;

		// Token: 0x04000720 RID: 1824
		private SendOrPostCallback _reportDownloadProgressChanged;

		// Token: 0x04000721 RID: 1825
		private SendOrPostCallback _reportUploadProgressChanged;

		// Token: 0x04000722 RID: 1826
		[CompilerGenerated]
		private DownloadStringCompletedEventHandler DownloadStringCompleted;

		// Token: 0x04000723 RID: 1827
		[CompilerGenerated]
		private DownloadDataCompletedEventHandler DownloadDataCompleted;

		// Token: 0x04000724 RID: 1828
		[CompilerGenerated]
		private global::System.ComponentModel.AsyncCompletedEventHandler DownloadFileCompleted;

		// Token: 0x04000725 RID: 1829
		[CompilerGenerated]
		private UploadStringCompletedEventHandler UploadStringCompleted;

		// Token: 0x04000726 RID: 1830
		[CompilerGenerated]
		private UploadDataCompletedEventHandler UploadDataCompleted;

		// Token: 0x04000727 RID: 1831
		[CompilerGenerated]
		private UploadFileCompletedEventHandler UploadFileCompleted;

		// Token: 0x04000728 RID: 1832
		[CompilerGenerated]
		private UploadValuesCompletedEventHandler UploadValuesCompleted;

		// Token: 0x04000729 RID: 1833
		[CompilerGenerated]
		private OpenReadCompletedEventHandler OpenReadCompleted;

		// Token: 0x0400072A RID: 1834
		[CompilerGenerated]
		private OpenWriteCompletedEventHandler OpenWriteCompleted;

		// Token: 0x0400072B RID: 1835
		[CompilerGenerated]
		private DownloadProgressChangedEventHandler DownloadProgressChanged;

		// Token: 0x0400072C RID: 1836
		[CompilerGenerated]
		private UploadProgressChangedEventHandler UploadProgressChanged;

		// Token: 0x0400072D RID: 1837
		[CompilerGenerated]
		private global::System.Net.Cache.RequestCachePolicy <CachePolicy>k__BackingField;

		// Token: 0x0400072E RID: 1838
		private static readonly char[] s_parseContentTypeSeparators;

		// Token: 0x0400072F RID: 1839
		private static readonly Encoding[] s_knownEncodings;

		// Token: 0x04000730 RID: 1840
		[CompilerGenerated]
		private bool <AllowReadStreamBuffering>k__BackingField;

		// Token: 0x04000731 RID: 1841
		[CompilerGenerated]
		private bool <AllowWriteStreamBuffering>k__BackingField;

		// Token: 0x0200015B RID: 347
		private sealed class ProgressData
		{
			// Token: 0x06000983 RID: 2435 RVA: 0x00020B6C File Offset: 0x0001ED6C
			internal void Reset()
			{
			}

			// Token: 0x06000984 RID: 2436 RVA: 0x00020B7C File Offset: 0x0001ED7C
			public ProgressData()
			{
			}

			// Token: 0x04000732 RID: 1842
			internal long BytesSent;

			// Token: 0x04000733 RID: 1843
			internal long TotalBytesToSend;

			// Token: 0x04000734 RID: 1844
			internal long BytesReceived;

			// Token: 0x04000735 RID: 1845
			internal long TotalBytesToReceive;

			// Token: 0x04000736 RID: 1846
			internal bool HasUploadPhase;
		}

		// Token: 0x0200015C RID: 348
		private sealed class WebClientWriteStream : global::System.Net.Http.DelegatingStream
		{
			// Token: 0x06000985 RID: 2437 RVA: 0x00020B90 File Offset: 0x0001ED90
			public WebClientWriteStream(Stream stream, WebRequest request, WebClient webClient)
				: base(stream)
			{
				this._request = request;
				this._webClient = webClient;
			}

			// Token: 0x06000986 RID: 2438 RVA: 0x00020BB4 File Offset: 0x0001EDB4
			protected override void Dispose(bool disposing)
			{
				WebRequest request = this._request;
				WebClient webClient = this._webClient;
				long num = 0L;
				base.Dispose(num != 0L);
			}

			// Token: 0x04000737 RID: 1847
			private readonly WebRequest _request;

			// Token: 0x04000738 RID: 1848
			private readonly WebClient _webClient;
		}

		// Token: 0x0200015D RID: 349
		[CompilerGenerated]
		[StructLayout(3)]
		private struct <GetWebResponseTaskAsync>d__112 : IAsyncStateMachine
		{
			// Token: 0x06000987 RID: 2439 RVA: 0x00002050 File Offset: 0x00000250
			private void MoveNext()
			{
				throw new global::Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}

			// Token: 0x06000988 RID: 2440 RVA: 0x00020BFC File Offset: 0x0001EDFC
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}

			// Token: 0x04000739 RID: 1849
			public int <>1__state;

			// Token: 0x0400073A RID: 1850
			public AsyncTaskMethodBuilder<WebResponse> <>t__builder;

			// Token: 0x0400073B RID: 1851
			public WebRequest request;

			// Token: 0x0400073C RID: 1852
			public WebClient <>4__this;

			// Token: 0x0400073D RID: 1853
			private WebRequest <>7__wrap1;

			// Token: 0x0400073E RID: 1854
			private object <>u__1;
		}

		// Token: 0x0200015E RID: 350
		[CompilerGenerated]
		[StructLayout(3)]
		private struct <DownloadBitsAsync>d__150 : IAsyncStateMachine
		{
			// Token: 0x06000989 RID: 2441 RVA: 0x00020C0C File Offset: 0x0001EE0C
			private void MoveNext()
			{
				WebClient webClient = this.<>4__this;
				WebRequest webRequest = this.request;
				Task<WebResponse> webResponseTaskAsync = webClient.GetWebResponseTaskAsync(webRequest);
			}

			// Token: 0x0600098A RID: 2442 RVA: 0x00020E88 File Offset: 0x0001F088
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}

			// Token: 0x0400073F RID: 1855
			public int <>1__state;

			// Token: 0x04000740 RID: 1856
			public AsyncVoidMethodBuilder <>t__builder;

			// Token: 0x04000741 RID: 1857
			public WebClient <>4__this;

			// Token: 0x04000742 RID: 1858
			public WebRequest request;

			// Token: 0x04000743 RID: 1859
			public Stream writeStream;

			// Token: 0x04000744 RID: 1860
			public global::System.ComponentModel.AsyncOperation asyncOp;

			// Token: 0x04000745 RID: 1861
			public Action<byte[], Exception, global::System.ComponentModel.AsyncOperation> completionDelegate;

			// Token: 0x04000746 RID: 1862
			private Exception <exception>5__2;

			// Token: 0x04000747 RID: 1863
			private byte[] <copyBuffer>5__3;

			// Token: 0x04000748 RID: 1864
			private ConfiguredTaskAwaitable<WebResponse>.ConfiguredTaskAwaiter <>u__1;

			// Token: 0x04000749 RID: 1865
			private Stream <>7__wrap3;

			// Token: 0x0400074A RID: 1866
			private Stream <readStream>5__5;

			// Token: 0x0400074B RID: 1867
			private ConfiguredValueTaskAwaitable<int>.ConfiguredValueTaskAwaiter <>u__2;

			// Token: 0x0400074C RID: 1868
			private ConfiguredValueTaskAwaitable.ConfiguredValueTaskAwaiter <>u__3;
		}

		// Token: 0x0200015F RID: 351
		[CompilerGenerated]
		[StructLayout(3)]
		private struct <UploadBitsAsync>d__152 : IAsyncStateMachine
		{
			// Token: 0x0600098B RID: 2443 RVA: 0x00020E98 File Offset: 0x0001F098
			private void MoveNext()
			{
				WebClient webClient = this.<>4__this;
				WebClient.ProgressData progress = webClient._progress;
				int num = 1;
				progress.HasUploadPhase = num != 0;
				WebRequest webRequest = this.request;
				WebRequest webRequest2 = this.request;
			}

			// Token: 0x0600098C RID: 2444 RVA: 0x000212B4 File Offset: 0x0001F4B4
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}

			// Token: 0x0400074D RID: 1869
			public int <>1__state;

			// Token: 0x0400074E RID: 1870
			public AsyncVoidMethodBuilder <>t__builder;

			// Token: 0x0400074F RID: 1871
			public WebClient <>4__this;

			// Token: 0x04000750 RID: 1872
			public WebRequest request;

			// Token: 0x04000751 RID: 1873
			public byte[] header;

			// Token: 0x04000752 RID: 1874
			public byte[] footer;

			// Token: 0x04000753 RID: 1875
			public global::System.ComponentModel.AsyncOperation asyncOp;

			// Token: 0x04000754 RID: 1876
			public Stream readStream;

			// Token: 0x04000755 RID: 1877
			public byte[] buffer;

			// Token: 0x04000756 RID: 1878
			public int chunkSize;

			// Token: 0x04000757 RID: 1879
			public Action<byte[], Exception, global::System.ComponentModel.AsyncOperation> completionDelegate;

			// Token: 0x04000758 RID: 1880
			private Exception <exception>5__2;

			// Token: 0x04000759 RID: 1881
			private Stream <writeStream>5__3;

			// Token: 0x0400075A RID: 1882
			private ConfiguredTaskAwaitable<Stream>.ConfiguredTaskAwaiter <>u__1;

			// Token: 0x0400075B RID: 1883
			private ConfiguredValueTaskAwaitable.ConfiguredValueTaskAwaiter <>u__2;

			// Token: 0x0400075C RID: 1884
			private Stream <>7__wrap3;

			// Token: 0x0400075D RID: 1885
			private int <bytesRead>5__5;

			// Token: 0x0400075E RID: 1886
			private ConfiguredValueTaskAwaitable<int>.ConfiguredValueTaskAwaiter <>u__3;

			// Token: 0x0400075F RID: 1887
			private int <toWrite>5__6;
		}

		// Token: 0x02000160 RID: 352
		[CompilerGenerated]
		private sealed class <>c__DisplayClass164_0
		{
			// Token: 0x0600098D RID: 2445 RVA: 0x000212C4 File Offset: 0x0001F4C4
			public <>c__DisplayClass164_0()
			{
			}

			// Token: 0x0600098E RID: 2446 RVA: 0x000212D8 File Offset: 0x0001F4D8
			internal void <OpenReadAsync>b__0(IAsyncResult iar)
			{
				WebClient webClient = this.<>4__this;
				WebRequest webRequest = this.request;
				webClient._webResponse = webClient;
				WebClient webClient2 = this.<>4__this;
				global::System.ComponentModel.AsyncOperation asyncOperation = this.asyncOp;
				SendOrPostCallback openReadOperationCompleted = webClient2._openReadOperationCompleted;
				bool canceled = webClient2._canceled;
				object userSuppliedState = asyncOperation._userSuppliedState;
			}

			// Token: 0x04000760 RID: 1888
			public WebClient <>4__this;

			// Token: 0x04000761 RID: 1889
			public global::System.ComponentModel.AsyncOperation asyncOp;

			// Token: 0x04000762 RID: 1890
			public WebRequest request;
		}

		// Token: 0x02000161 RID: 353
		[CompilerGenerated]
		private sealed class <>c__DisplayClass167_0
		{
			// Token: 0x0600098F RID: 2447 RVA: 0x00021324 File Offset: 0x0001F524
			public <>c__DisplayClass167_0()
			{
			}

			// Token: 0x06000990 RID: 2448 RVA: 0x00021338 File Offset: 0x0001F538
			internal void <OpenWriteAsync>b__0(IAsyncResult iar)
			{
				WebRequest webRequest = this.request;
				WebRequest webRequest2 = this.request;
				WebClient webClient = this.<>4__this;
				WebClient webClient2 = this.<>4__this;
				global::System.ComponentModel.AsyncOperation asyncOperation = this.asyncOp;
				SendOrPostCallback openWriteOperationCompleted = webClient2._openWriteOperationCompleted;
				bool canceled = webClient2._canceled;
				object userSuppliedState = asyncOperation._userSuppliedState;
			}

			// Token: 0x04000763 RID: 1891
			public WebClient <>4__this;

			// Token: 0x04000764 RID: 1892
			public global::System.ComponentModel.AsyncOperation asyncOp;

			// Token: 0x04000765 RID: 1893
			public WebRequest request;
		}

		// Token: 0x02000162 RID: 354
		[CompilerGenerated]
		private sealed class <>c__DisplayClass182_0
		{
			// Token: 0x06000991 RID: 2449 RVA: 0x00021388 File Offset: 0x0001F588
			public <>c__DisplayClass182_0()
			{
			}

			// Token: 0x06000992 RID: 2450 RVA: 0x0002139C File Offset: 0x0001F59C
			internal void <UploadDataAsync>b__0(byte[] result, Exception error, global::System.ComponentModel.AsyncOperation uploadAsyncOp)
			{
				WebClient webClient = this.<>4__this;
				global::System.ComponentModel.AsyncOperation asyncOperation = this.asyncOp;
				object userSuppliedState = uploadAsyncOp._userSuppliedState;
				SendOrPostCallback uploadDataOperationCompleted = webClient._uploadDataOperationCompleted;
				bool canceled = webClient._canceled;
			}

			// Token: 0x04000766 RID: 1894
			public WebClient <>4__this;

			// Token: 0x04000767 RID: 1895
			public global::System.ComponentModel.AsyncOperation asyncOp;
		}

		// Token: 0x02000163 RID: 355
		[CompilerGenerated]
		private sealed class <>c__DisplayClass185_0
		{
			// Token: 0x06000993 RID: 2451 RVA: 0x000213D0 File Offset: 0x0001F5D0
			public <>c__DisplayClass185_0()
			{
			}

			// Token: 0x06000994 RID: 2452 RVA: 0x000213E4 File Offset: 0x0001F5E4
			internal void <UploadFileAsync>b__0(byte[] result, Exception error, global::System.ComponentModel.AsyncOperation uploadAsyncOp)
			{
				WebClient webClient = this.<>4__this;
				global::System.ComponentModel.AsyncOperation asyncOperation = this.asyncOp;
				object userSuppliedState = uploadAsyncOp._userSuppliedState;
				SendOrPostCallback uploadFileOperationCompleted = webClient._uploadFileOperationCompleted;
				bool canceled = webClient._canceled;
			}

			// Token: 0x04000768 RID: 1896
			public WebClient <>4__this;

			// Token: 0x04000769 RID: 1897
			public global::System.ComponentModel.AsyncOperation asyncOp;
		}

		// Token: 0x02000164 RID: 356
		[CompilerGenerated]
		private sealed class <>c__DisplayClass188_0
		{
			// Token: 0x06000995 RID: 2453 RVA: 0x00021418 File Offset: 0x0001F618
			public <>c__DisplayClass188_0()
			{
			}

			// Token: 0x06000996 RID: 2454 RVA: 0x0002142C File Offset: 0x0001F62C
			internal void <UploadValuesAsync>b__0(byte[] result, Exception error, global::System.ComponentModel.AsyncOperation uploadAsyncOp)
			{
				WebClient webClient = this.<>4__this;
				global::System.ComponentModel.AsyncOperation asyncOperation = this.asyncOp;
				object userSuppliedState = uploadAsyncOp._userSuppliedState;
				SendOrPostCallback uploadValuesOperationCompleted = webClient._uploadValuesOperationCompleted;
				bool canceled = webClient._canceled;
			}

			// Token: 0x0400076A RID: 1898
			public WebClient <>4__this;

			// Token: 0x0400076B RID: 1899
			public global::System.ComponentModel.AsyncOperation asyncOp;
		}

		// Token: 0x02000165 RID: 357
		[CompilerGenerated]
		private sealed class <>c__DisplayClass192_0
		{
			// Token: 0x06000997 RID: 2455 RVA: 0x00021460 File Offset: 0x0001F660
			public <>c__DisplayClass192_0()
			{
			}

			// Token: 0x06000998 RID: 2456 RVA: 0x00021474 File Offset: 0x0001F674
			internal void <DownloadStringTaskAsync>b__0(object sender, DownloadStringCompletedEventArgs e)
			{
				WebClient webClient = this.<>4__this;
				TaskCompletionSource<string> taskCompletionSource = this.tcs;
				if (!true)
				{
				}
				if (!true)
				{
				}
				DownloadStringCompletedEventHandler downloadStringCompletedEventHandler = this.handler;
				if (!true)
				{
				}
				if (true || !true)
				{
				}
			}

			// Token: 0x0400076C RID: 1900
			public WebClient <>4__this;

			// Token: 0x0400076D RID: 1901
			public TaskCompletionSource<string> tcs;

			// Token: 0x0400076E RID: 1902
			public DownloadStringCompletedEventHandler handler;
		}

		// Token: 0x02000166 RID: 358
		[CompilerGenerated]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x06000999 RID: 2457 RVA: 0x000214A8 File Offset: 0x0001F6A8
			// Note: this type is marked as 'beforefieldinit'.
			static <>c()
			{
			}

			// Token: 0x0600099A RID: 2458 RVA: 0x000214B8 File Offset: 0x0001F6B8
			public <>c()
			{
			}

			// Token: 0x0600099B RID: 2459 RVA: 0x000214CC File Offset: 0x0001F6CC
			internal string <DownloadStringTaskAsync>b__192_1(DownloadStringCompletedEventArgs args)
			{
				args.RaiseExceptionIfNecessary();
				return args._result;
			}

			// Token: 0x0600099C RID: 2460 RVA: 0x000214E8 File Offset: 0x0001F6E8
			internal void <DownloadStringTaskAsync>b__192_2(WebClient webClient, DownloadStringCompletedEventHandler completion)
			{
				webClient.DownloadStringCompleted -= completion;
			}

			// Token: 0x0600099D RID: 2461 RVA: 0x000214FC File Offset: 0x0001F6FC
			internal Stream <OpenReadTaskAsync>b__194_1(OpenReadCompletedEventArgs args)
			{
				args.RaiseExceptionIfNecessary();
				return args._result;
			}

			// Token: 0x0600099E RID: 2462 RVA: 0x00021518 File Offset: 0x0001F718
			internal void <OpenReadTaskAsync>b__194_2(WebClient webClient, OpenReadCompletedEventHandler completion)
			{
				webClient.OpenReadCompleted -= completion;
			}

			// Token: 0x0600099F RID: 2463 RVA: 0x0002152C File Offset: 0x0001F72C
			internal Stream <OpenWriteTaskAsync>b__198_1(OpenWriteCompletedEventArgs args)
			{
				args.RaiseExceptionIfNecessary();
				return args._result;
			}

			// Token: 0x060009A0 RID: 2464 RVA: 0x00021548 File Offset: 0x0001F748
			internal void <OpenWriteTaskAsync>b__198_2(WebClient webClient, OpenWriteCompletedEventHandler completion)
			{
				webClient.OpenWriteCompleted -= completion;
			}

			// Token: 0x060009A1 RID: 2465 RVA: 0x0002155C File Offset: 0x0001F75C
			internal string <UploadStringTaskAsync>b__202_1(UploadStringCompletedEventArgs args)
			{
				args.RaiseExceptionIfNecessary();
				return args._result;
			}

			// Token: 0x060009A2 RID: 2466 RVA: 0x00021578 File Offset: 0x0001F778
			internal void <UploadStringTaskAsync>b__202_2(WebClient webClient, UploadStringCompletedEventHandler completion)
			{
				webClient.UploadStringCompleted -= completion;
			}

			// Token: 0x060009A3 RID: 2467 RVA: 0x0002158C File Offset: 0x0001F78C
			internal byte[] <DownloadDataTaskAsync>b__204_1(DownloadDataCompletedEventArgs args)
			{
				args.RaiseExceptionIfNecessary();
				return args._result;
			}

			// Token: 0x060009A4 RID: 2468 RVA: 0x000215A8 File Offset: 0x0001F7A8
			internal void <DownloadDataTaskAsync>b__204_2(WebClient webClient, DownloadDataCompletedEventHandler completion)
			{
				webClient.DownloadDataCompleted -= completion;
			}

			// Token: 0x060009A5 RID: 2469 RVA: 0x000215BC File Offset: 0x0001F7BC
			internal object <DownloadFileTaskAsync>b__206_1(global::System.ComponentModel.AsyncCompletedEventArgs args)
			{
			}

			// Token: 0x060009A6 RID: 2470 RVA: 0x000215CC File Offset: 0x0001F7CC
			internal void <DownloadFileTaskAsync>b__206_2(WebClient webClient, global::System.ComponentModel.AsyncCompletedEventHandler completion)
			{
				webClient.DownloadFileCompleted -= completion;
			}

			// Token: 0x060009A7 RID: 2471 RVA: 0x000215E0 File Offset: 0x0001F7E0
			internal byte[] <UploadDataTaskAsync>b__210_1(UploadDataCompletedEventArgs args)
			{
				args.RaiseExceptionIfNecessary();
				return args._result;
			}

			// Token: 0x060009A8 RID: 2472 RVA: 0x000215FC File Offset: 0x0001F7FC
			internal void <UploadDataTaskAsync>b__210_2(WebClient webClient, UploadDataCompletedEventHandler completion)
			{
				webClient.UploadDataCompleted -= completion;
			}

			// Token: 0x060009A9 RID: 2473 RVA: 0x00021610 File Offset: 0x0001F810
			internal byte[] <UploadFileTaskAsync>b__214_1(UploadFileCompletedEventArgs args)
			{
				args.RaiseExceptionIfNecessary();
				return args._result;
			}

			// Token: 0x060009AA RID: 2474 RVA: 0x0002162C File Offset: 0x0001F82C
			internal void <UploadFileTaskAsync>b__214_2(WebClient webClient, UploadFileCompletedEventHandler completion)
			{
				webClient.UploadFileCompleted -= completion;
			}

			// Token: 0x060009AB RID: 2475 RVA: 0x00021640 File Offset: 0x0001F840
			internal byte[] <UploadValuesTaskAsync>b__218_1(UploadValuesCompletedEventArgs args)
			{
				args.RaiseExceptionIfNecessary();
				return args._result;
			}

			// Token: 0x060009AC RID: 2476 RVA: 0x0002165C File Offset: 0x0001F85C
			internal void <UploadValuesTaskAsync>b__218_2(WebClient webClient, UploadValuesCompletedEventHandler completion)
			{
				webClient.UploadValuesCompleted -= completion;
			}

			// Token: 0x0400076F RID: 1903
			public static readonly WebClient.<>c <>9;

			// Token: 0x04000770 RID: 1904
			public static Func<DownloadStringCompletedEventArgs, string> <>9__192_1;

			// Token: 0x04000771 RID: 1905
			public static Action<WebClient, DownloadStringCompletedEventHandler> <>9__192_2;

			// Token: 0x04000772 RID: 1906
			public static Func<OpenReadCompletedEventArgs, Stream> <>9__194_1;

			// Token: 0x04000773 RID: 1907
			public static Action<WebClient, OpenReadCompletedEventHandler> <>9__194_2;

			// Token: 0x04000774 RID: 1908
			public static Func<OpenWriteCompletedEventArgs, Stream> <>9__198_1;

			// Token: 0x04000775 RID: 1909
			public static Action<WebClient, OpenWriteCompletedEventHandler> <>9__198_2;

			// Token: 0x04000776 RID: 1910
			public static Func<UploadStringCompletedEventArgs, string> <>9__202_1;

			// Token: 0x04000777 RID: 1911
			public static Action<WebClient, UploadStringCompletedEventHandler> <>9__202_2;

			// Token: 0x04000778 RID: 1912
			public static Func<DownloadDataCompletedEventArgs, byte[]> <>9__204_1;

			// Token: 0x04000779 RID: 1913
			public static Action<WebClient, DownloadDataCompletedEventHandler> <>9__204_2;

			// Token: 0x0400077A RID: 1914
			public static Func<global::System.ComponentModel.AsyncCompletedEventArgs, object> <>9__206_1;

			// Token: 0x0400077B RID: 1915
			public static Action<WebClient, global::System.ComponentModel.AsyncCompletedEventHandler> <>9__206_2;

			// Token: 0x0400077C RID: 1916
			public static Func<UploadDataCompletedEventArgs, byte[]> <>9__210_1;

			// Token: 0x0400077D RID: 1917
			public static Action<WebClient, UploadDataCompletedEventHandler> <>9__210_2;

			// Token: 0x0400077E RID: 1918
			public static Func<UploadFileCompletedEventArgs, byte[]> <>9__214_1;

			// Token: 0x0400077F RID: 1919
			public static Action<WebClient, UploadFileCompletedEventHandler> <>9__214_2;

			// Token: 0x04000780 RID: 1920
			public static Func<UploadValuesCompletedEventArgs, byte[]> <>9__218_1;

			// Token: 0x04000781 RID: 1921
			public static Action<WebClient, UploadValuesCompletedEventHandler> <>9__218_2;
		}

		// Token: 0x02000167 RID: 359
		[CompilerGenerated]
		private sealed class <>c__DisplayClass194_0
		{
			// Token: 0x060009AD RID: 2477 RVA: 0x00021670 File Offset: 0x0001F870
			public <>c__DisplayClass194_0()
			{
			}

			// Token: 0x060009AE RID: 2478 RVA: 0x00021684 File Offset: 0x0001F884
			internal void <OpenReadTaskAsync>b__0(object sender, OpenReadCompletedEventArgs e)
			{
				WebClient webClient = this.<>4__this;
				TaskCompletionSource<Stream> taskCompletionSource = this.tcs;
				if (!true)
				{
				}
				if (!true)
				{
				}
				OpenReadCompletedEventHandler openReadCompletedEventHandler = this.handler;
				if (!true)
				{
				}
				if (true || !true)
				{
				}
			}

			// Token: 0x04000782 RID: 1922
			public WebClient <>4__this;

			// Token: 0x04000783 RID: 1923
			public TaskCompletionSource<Stream> tcs;

			// Token: 0x04000784 RID: 1924
			public OpenReadCompletedEventHandler handler;
		}

		// Token: 0x02000168 RID: 360
		[CompilerGenerated]
		private sealed class <>c__DisplayClass198_0
		{
			// Token: 0x060009AF RID: 2479 RVA: 0x000216B8 File Offset: 0x0001F8B8
			public <>c__DisplayClass198_0()
			{
			}

			// Token: 0x060009B0 RID: 2480 RVA: 0x000216CC File Offset: 0x0001F8CC
			internal void <OpenWriteTaskAsync>b__0(object sender, OpenWriteCompletedEventArgs e)
			{
				WebClient webClient = this.<>4__this;
				TaskCompletionSource<Stream> taskCompletionSource = this.tcs;
				if (!true)
				{
				}
				if (!true)
				{
				}
				OpenWriteCompletedEventHandler openWriteCompletedEventHandler = this.handler;
				if (!true)
				{
				}
				if (true || !true)
				{
				}
			}

			// Token: 0x04000785 RID: 1925
			public WebClient <>4__this;

			// Token: 0x04000786 RID: 1926
			public TaskCompletionSource<Stream> tcs;

			// Token: 0x04000787 RID: 1927
			public OpenWriteCompletedEventHandler handler;
		}

		// Token: 0x02000169 RID: 361
		[CompilerGenerated]
		private sealed class <>c__DisplayClass202_0
		{
			// Token: 0x060009B1 RID: 2481 RVA: 0x00021700 File Offset: 0x0001F900
			public <>c__DisplayClass202_0()
			{
			}

			// Token: 0x060009B2 RID: 2482 RVA: 0x00021714 File Offset: 0x0001F914
			internal void <UploadStringTaskAsync>b__0(object sender, UploadStringCompletedEventArgs e)
			{
				WebClient webClient = this.<>4__this;
				TaskCompletionSource<string> taskCompletionSource = this.tcs;
				if (!true)
				{
				}
				if (!true)
				{
				}
				UploadStringCompletedEventHandler uploadStringCompletedEventHandler = this.handler;
				if (!true)
				{
				}
				if (true || !true)
				{
				}
			}

			// Token: 0x04000788 RID: 1928
			public WebClient <>4__this;

			// Token: 0x04000789 RID: 1929
			public TaskCompletionSource<string> tcs;

			// Token: 0x0400078A RID: 1930
			public UploadStringCompletedEventHandler handler;
		}

		// Token: 0x0200016A RID: 362
		[CompilerGenerated]
		private sealed class <>c__DisplayClass204_0
		{
			// Token: 0x060009B3 RID: 2483 RVA: 0x00021748 File Offset: 0x0001F948
			public <>c__DisplayClass204_0()
			{
			}

			// Token: 0x060009B4 RID: 2484 RVA: 0x0002175C File Offset: 0x0001F95C
			internal void <DownloadDataTaskAsync>b__0(object sender, DownloadDataCompletedEventArgs e)
			{
				WebClient webClient = this.<>4__this;
				TaskCompletionSource<byte[]> taskCompletionSource = this.tcs;
				if (!true)
				{
				}
				if (!true)
				{
				}
				DownloadDataCompletedEventHandler downloadDataCompletedEventHandler = this.handler;
				if (!true)
				{
				}
				if (true || !true)
				{
				}
			}

			// Token: 0x0400078B RID: 1931
			public WebClient <>4__this;

			// Token: 0x0400078C RID: 1932
			public TaskCompletionSource<byte[]> tcs;

			// Token: 0x0400078D RID: 1933
			public DownloadDataCompletedEventHandler handler;
		}

		// Token: 0x0200016B RID: 363
		[CompilerGenerated]
		private sealed class <>c__DisplayClass206_0
		{
			// Token: 0x060009B5 RID: 2485 RVA: 0x00021790 File Offset: 0x0001F990
			public <>c__DisplayClass206_0()
			{
			}

			// Token: 0x060009B6 RID: 2486 RVA: 0x000217A4 File Offset: 0x0001F9A4
			internal void <DownloadFileTaskAsync>b__0(object sender, global::System.ComponentModel.AsyncCompletedEventArgs e)
			{
				WebClient webClient = this.<>4__this;
				TaskCompletionSource<object> taskCompletionSource = this.tcs;
				if (!true)
				{
				}
				if (!true)
				{
				}
				global::System.ComponentModel.AsyncCompletedEventHandler asyncCompletedEventHandler = this.handler;
				if (!true)
				{
				}
				if (true || !true)
				{
				}
			}

			// Token: 0x0400078E RID: 1934
			public WebClient <>4__this;

			// Token: 0x0400078F RID: 1935
			public TaskCompletionSource<object> tcs;

			// Token: 0x04000790 RID: 1936
			public global::System.ComponentModel.AsyncCompletedEventHandler handler;
		}

		// Token: 0x0200016C RID: 364
		[CompilerGenerated]
		private sealed class <>c__DisplayClass210_0
		{
			// Token: 0x060009B7 RID: 2487 RVA: 0x000217D8 File Offset: 0x0001F9D8
			public <>c__DisplayClass210_0()
			{
			}

			// Token: 0x060009B8 RID: 2488 RVA: 0x000217EC File Offset: 0x0001F9EC
			internal void <UploadDataTaskAsync>b__0(object sender, UploadDataCompletedEventArgs e)
			{
				WebClient webClient = this.<>4__this;
				TaskCompletionSource<byte[]> taskCompletionSource = this.tcs;
				if (!true)
				{
				}
				if (!true)
				{
				}
				UploadDataCompletedEventHandler uploadDataCompletedEventHandler = this.handler;
				if (!true)
				{
				}
				if (true || !true)
				{
				}
			}

			// Token: 0x04000791 RID: 1937
			public WebClient <>4__this;

			// Token: 0x04000792 RID: 1938
			public TaskCompletionSource<byte[]> tcs;

			// Token: 0x04000793 RID: 1939
			public UploadDataCompletedEventHandler handler;
		}

		// Token: 0x0200016D RID: 365
		[CompilerGenerated]
		private sealed class <>c__DisplayClass214_0
		{
			// Token: 0x060009B9 RID: 2489 RVA: 0x00021820 File Offset: 0x0001FA20
			public <>c__DisplayClass214_0()
			{
			}

			// Token: 0x060009BA RID: 2490 RVA: 0x00021834 File Offset: 0x0001FA34
			internal void <UploadFileTaskAsync>b__0(object sender, UploadFileCompletedEventArgs e)
			{
				WebClient webClient = this.<>4__this;
				TaskCompletionSource<byte[]> taskCompletionSource = this.tcs;
				if (!true)
				{
				}
				if (!true)
				{
				}
				UploadFileCompletedEventHandler uploadFileCompletedEventHandler = this.handler;
				if (!true)
				{
				}
				if (true || !true)
				{
				}
			}

			// Token: 0x04000794 RID: 1940
			public WebClient <>4__this;

			// Token: 0x04000795 RID: 1941
			public TaskCompletionSource<byte[]> tcs;

			// Token: 0x04000796 RID: 1942
			public UploadFileCompletedEventHandler handler;
		}

		// Token: 0x0200016E RID: 366
		[CompilerGenerated]
		private sealed class <>c__DisplayClass218_0
		{
			// Token: 0x060009BB RID: 2491 RVA: 0x00021868 File Offset: 0x0001FA68
			public <>c__DisplayClass218_0()
			{
			}

			// Token: 0x060009BC RID: 2492 RVA: 0x0002187C File Offset: 0x0001FA7C
			internal void <UploadValuesTaskAsync>b__0(object sender, UploadValuesCompletedEventArgs e)
			{
				WebClient webClient = this.<>4__this;
				TaskCompletionSource<byte[]> taskCompletionSource = this.tcs;
				if (!true)
				{
				}
				if (!true)
				{
				}
				UploadValuesCompletedEventHandler uploadValuesCompletedEventHandler = this.handler;
				if (!true)
				{
				}
				if (true || !true)
				{
				}
			}

			// Token: 0x04000797 RID: 1943
			public WebClient <>4__this;

			// Token: 0x04000798 RID: 1944
			public TaskCompletionSource<byte[]> tcs;

			// Token: 0x04000799 RID: 1945
			public UploadValuesCompletedEventHandler handler;
		}
	}
}
