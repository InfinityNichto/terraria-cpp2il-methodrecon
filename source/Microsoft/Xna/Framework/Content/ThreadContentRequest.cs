using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Threading;
using Cpp2IlInjected;
using UnityEngine;

namespace Microsoft.Xna.Framework.Content
{
	// Token: 0x020003C6 RID: 966
	public class ThreadContentRequest
	{
		// Token: 0x06001A4D RID: 6733 RVA: 0x0006C3F8 File Offset: 0x0006A5F8
		public static T ConstructOnMainThread<T>(string asset, ThreadContentRequest.ObjectCreate createFunction) where T : class
		{
			object obj;
			do
			{
				if (!true)
				{
				}
				IntPtr extra_arg = createFunction.extra_arg;
				IntPtr extra_arg2 = createFunction.extra_arg;
				if (obj == null)
				{
					return;
				}
			}
			while (obj != null);
			throw new InvalidCastException();
		}

		// Token: 0x06001A4E RID: 6734 RVA: 0x0006C424 File Offset: 0x0006A624
		public static T ConstructOnMainThread<T>(string asset, string asset2, ThreadContentRequest.ObjectCreate2 createFunction) where T : class
		{
			object obj;
			do
			{
				if (!true)
				{
				}
				IntPtr extra_arg = createFunction.extra_arg;
				IntPtr extra_arg2 = createFunction.extra_arg;
				if (obj == null)
				{
					return;
				}
			}
			while (obj != null);
			throw new InvalidCastException();
		}

		// Token: 0x06001A4F RID: 6735 RVA: 0x0006C450 File Offset: 0x0006A650
		public static T ConstructOnMainThread<T>(string asset, string asset2, string asset3, ThreadContentRequest.ObjectCreate3 createFunction) where T : class
		{
			object obj;
			do
			{
				if (!true)
				{
				}
				IntPtr extra_arg = createFunction.extra_arg;
				IntPtr extra_arg2 = createFunction.extra_arg;
				if (obj == null)
				{
					return;
				}
			}
			while (obj != null);
			throw new InvalidCastException();
		}

		// Token: 0x06001A50 RID: 6736 RVA: 0x0006C47C File Offset: 0x0006A67C
		public static global::UnityEngine.Object Load(string asset)
		{
			if (!true)
			{
			}
			global::UnityEngine.Object @object;
			return @object;
		}

		// Token: 0x06001A51 RID: 6737 RVA: 0x0006C490 File Offset: 0x0006A690
		public static void UpdatingLoading()
		{
			int num = 1;
			if (num == 0)
			{
			}
			if (num != 0)
			{
				ContentManager.UpdateAysncLoad();
				return;
			}
			throw new MissingMethodException();
		}

		// Token: 0x06001A52 RID: 6738 RVA: 0x0006C4B4 File Offset: 0x0006A6B4
		public ThreadContentRequest(string asset, [Optional] ThreadContentRequest.ObjectCreate createFunction)
		{
			this._asset = asset;
			this._createFunction = createFunction;
		}

		// Token: 0x06001A53 RID: 6739 RVA: 0x0006C4D8 File Offset: 0x0006A6D8
		public ThreadContentRequest(string asset, string asset2, [Optional] ThreadContentRequest.ObjectCreate2 createFunction)
		{
			this._asset = asset;
			this._asset2 = asset2;
			this._createFunction2 = createFunction;
		}

		// Token: 0x06001A54 RID: 6740 RVA: 0x0006C500 File Offset: 0x0006A700
		public ThreadContentRequest(string asset, string asset2, string asset3, [Optional] ThreadContentRequest.ObjectCreate3 createFunction)
		{
			this._asset = asset;
			this._asset2 = asset2;
			this._asset3 = asset3;
			this._createFunction3 = createFunction;
		}

		// Token: 0x06001A55 RID: 6741 RVA: 0x0006C530 File Offset: 0x0006A730
		private void BeginLoad()
		{
			ResourceRequest resourceRequest = Resources.LoadAsync(this._asset);
			string asset = this._asset2;
			this._loadRequest = resourceRequest;
			bool flag = string.IsNullOrEmpty(asset);
			ResourceRequest resourceRequest2 = Resources.LoadAsync(this._asset2);
			this._loadRequest2 = resourceRequest2;
			bool flag2 = string.IsNullOrEmpty(this._asset3);
			ResourceRequest resourceRequest3 = Resources.LoadAsync(this._asset3);
			this._loadRequest3 = resourceRequest3;
		}

		// Token: 0x06001A56 RID: 6742 RVA: 0x0006C594 File Offset: 0x0006A794
		private bool UpdateLoad()
		{
			bool isDone = this._loadRequest.isDone;
			ResourceRequest loadRequest = this._loadRequest2;
			if (loadRequest != null)
			{
				bool isDone2 = loadRequest.isDone;
			}
			ResourceRequest loadRequest2 = this._loadRequest3;
			long num;
			if (loadRequest2 != null)
			{
				num = 0L;
				bool isDone3 = loadRequest2.isDone;
			}
			object lockObject = this._lockObject;
			Monitor.Enter(lockObject, num != 0L);
			ResourceRequest loadRequest3 = this._loadRequest;
			this._loaded = true;
			global::UnityEngine.Object asset = loadRequest3.asset;
			ResourceRequest loadRequest4 = this._loadRequest2;
			this._resource = asset;
			if (loadRequest4 != null)
			{
				global::UnityEngine.Object asset2 = loadRequest4.asset;
				this._resource2 = asset2;
			}
			ResourceRequest loadRequest5 = this._loadRequest3;
			if (loadRequest5 != null)
			{
				global::UnityEngine.Object asset3 = loadRequest5.asset;
				this._resource3 = asset3;
			}
			ThreadContentRequest.ObjectCreate createFunction = this._createFunction;
			if (createFunction != null)
			{
				global::UnityEngine.Object resource = this._resource;
				IntPtr method_code = createFunction.method_code;
				IntPtr invoke_impl = createFunction.invoke_impl;
				IntPtr method = createFunction.method;
				this._constructedObject = method_code;
			}
			ThreadContentRequest.ObjectCreate2 createFunction2 = this._createFunction2;
			if (createFunction2 != null)
			{
				global::UnityEngine.Object resource2 = this._resource;
				global::UnityEngine.Object resource3 = this._resource2;
				IntPtr method_code2 = createFunction2.method_code;
				IntPtr invoke_impl2 = createFunction2.invoke_impl;
				IntPtr method2 = createFunction2.method;
				this._constructedObject = method_code2;
			}
			ThreadContentRequest.ObjectCreate3 createFunction3 = this._createFunction3;
			if (createFunction3 != null)
			{
				global::UnityEngine.Object resource4 = this._resource;
				global::UnityEngine.Object resource5 = this._resource2;
				IntPtr method_code3 = createFunction3.method_code;
				global::UnityEngine.Object resource6 = this._resource3;
				IntPtr invoke_impl3 = createFunction3.invoke_impl;
				IntPtr method3 = createFunction3.method;
				this._constructedObject = method_code3;
			}
			long num2 = 0L;
			if (createFunction3 != null)
			{
				Monitor.Exit(lockObject);
			}
			if (num2 == 0L)
			{
				return true;
			}
			throw new OutOfMemoryException();
		}

		// Token: 0x06001A57 RID: 6743 RVA: 0x0006C738 File Offset: 0x0006A938
		public global::UnityEngine.Object LoadFromMainThread()
		{
			long num = 0L;
			long num2 = 0L;
			Thread.Sleep((int)num);
			object lockObject = this._lockObject;
			Monitor.Enter(lockObject, num2 != 0L);
			bool loaded = this._loaded;
			long num3 = 0L;
			if (loaded)
			{
				Monitor.Exit(lockObject);
			}
			if (num3 == 0L)
			{
				throw new OutOfMemoryException();
			}
			throw new OutOfMemoryException();
		}

		// Token: 0x06001A58 RID: 6744 RVA: 0x0006C7A0 File Offset: 0x0006A9A0
		public object ConstructFromMainThread()
		{
			long num = 0L;
			long num2 = 0L;
			Thread.Sleep((int)num);
			object lockObject = this._lockObject;
			Monitor.Enter(lockObject, num2 != 0L);
			bool loaded = this._loaded;
			long num3 = 0L;
			if (loaded)
			{
				Monitor.Exit(lockObject);
			}
			if (num3 == 0L)
			{
				return lockObject;
			}
			throw new OutOfMemoryException();
		}

		// Token: 0x06001A59 RID: 6745 RVA: 0x0006C80C File Offset: 0x0006AA0C
		// Note: this type is marked as 'beforefieldinit'.
		static ThreadContentRequest()
		{
		}

		// Token: 0x040027C2 RID: 10178
		private static ConcurrentQueue<ThreadContentRequest> _pendingRequests;

		// Token: 0x040027C3 RID: 10179
		private static List<ThreadContentRequest> _activeRequests;

		// Token: 0x040027C4 RID: 10180
		private object _lockObject;

		// Token: 0x040027C5 RID: 10181
		private readonly string _asset;

		// Token: 0x040027C6 RID: 10182
		private readonly string _asset2;

		// Token: 0x040027C7 RID: 10183
		private readonly string _asset3;

		// Token: 0x040027C8 RID: 10184
		private ResourceRequest _loadRequest;

		// Token: 0x040027C9 RID: 10185
		private ResourceRequest _loadRequest2;

		// Token: 0x040027CA RID: 10186
		private ResourceRequest _loadRequest3;

		// Token: 0x040027CB RID: 10187
		private global::UnityEngine.Object _resource;

		// Token: 0x040027CC RID: 10188
		private global::UnityEngine.Object _resource2;

		// Token: 0x040027CD RID: 10189
		private global::UnityEngine.Object _resource3;

		// Token: 0x040027CE RID: 10190
		private bool _loaded;

		// Token: 0x040027CF RID: 10191
		private ThreadContentRequest.ObjectCreate _createFunction;

		// Token: 0x040027D0 RID: 10192
		private ThreadContentRequest.ObjectCreate2 _createFunction2;

		// Token: 0x040027D1 RID: 10193
		private ThreadContentRequest.ObjectCreate3 _createFunction3;

		// Token: 0x040027D2 RID: 10194
		private object _constructedObject;

		// Token: 0x020003C7 RID: 967
		public sealed class ObjectCreate : MulticastDelegate
		{
			// Token: 0x06001A5A RID: 6746 RVA: 0x0006C81C File Offset: 0x0006AA1C
			public ObjectCreate(object @object, IntPtr method)
			{
				this.method_ptr = method;
				this.m_target = @object;
				this.method = method;
				this.method_code = this;
			}

			// Token: 0x06001A5B RID: 6747 RVA: 0x0006C87C File Offset: 0x0006AA7C
			public object Invoke(global::UnityEngine.Object asset)
			{
				/*
An exception occurred when decompiling this method (06001A5B)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Object Microsoft.Xna.Framework.Content.ThreadContentRequest/ObjectCreate::Invoke(UnityEngine.Object)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:native int(var_0_06, ldfld:native int(Delegate::method_code, ldloc:ObjectCreate[exp:Delegate](this)))
	stloc:native int(var_1_0D, ldfld:native int(Delegate::invoke_impl, ldloc:ObjectCreate[exp:Delegate](this)))
	stloc:native int(var_2_14, ldfld:native int(Delegate::method, ldloc:ObjectCreate[exp:Delegate](this)))
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

			// Token: 0x06001A5C RID: 6748 RVA: 0x000021DB File Offset: 0x000003DB
			public IAsyncResult BeginInvoke(global::UnityEngine.Object asset, AsyncCallback callback, object @object)
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}

			// Token: 0x06001A5D RID: 6749 RVA: 0x000021DB File Offset: 0x000003DB
			public object EndInvoke(IAsyncResult result)
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		// Token: 0x020003C8 RID: 968
		public sealed class ObjectCreate2 : MulticastDelegate
		{
			// Token: 0x06001A5E RID: 6750 RVA: 0x0006C8A0 File Offset: 0x0006AAA0
			public ObjectCreate2(object @object, IntPtr method)
			{
				this.method_ptr = method;
				this.m_target = @object;
				this.method = method;
				this.method_code = this;
			}

			// Token: 0x06001A5F RID: 6751 RVA: 0x0006C900 File Offset: 0x0006AB00
			public object Invoke(global::UnityEngine.Object asset, global::UnityEngine.Object asset2)
			{
				/*
An exception occurred when decompiling this method (06001A5F)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Object Microsoft.Xna.Framework.Content.ThreadContentRequest/ObjectCreate2::Invoke(UnityEngine.Object,UnityEngine.Object)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:native int(var_0_06, ldfld:native int(Delegate::method_code, ldloc:ObjectCreate2[exp:Delegate](this)))
	stloc:native int(var_1_0D, ldfld:native int(Delegate::invoke_impl, ldloc:ObjectCreate2[exp:Delegate](this)))
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

			// Token: 0x06001A60 RID: 6752 RVA: 0x000021DB File Offset: 0x000003DB
			public IAsyncResult BeginInvoke(global::UnityEngine.Object asset, global::UnityEngine.Object asset2, AsyncCallback callback, object @object)
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}

			// Token: 0x06001A61 RID: 6753 RVA: 0x000021DB File Offset: 0x000003DB
			public object EndInvoke(IAsyncResult result)
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		// Token: 0x020003C9 RID: 969
		public sealed class ObjectCreate3 : MulticastDelegate
		{
			// Token: 0x06001A62 RID: 6754 RVA: 0x0006C91C File Offset: 0x0006AB1C
			public ObjectCreate3(object @object, IntPtr method)
			{
				this.method_ptr = method;
				this.m_target = @object;
				this.method = method;
				this.method_code = this;
			}

			// Token: 0x06001A63 RID: 6755 RVA: 0x0006C97C File Offset: 0x0006AB7C
			public object Invoke(global::UnityEngine.Object asset, global::UnityEngine.Object asset2, global::UnityEngine.Object asset3)
			{
				/*
An exception occurred when decompiling this method (06001A63)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Object Microsoft.Xna.Framework.Content.ThreadContentRequest/ObjectCreate3::Invoke(UnityEngine.Object,UnityEngine.Object,UnityEngine.Object)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:native int(var_0_06, ldfld:native int(Delegate::method_code, ldloc:ObjectCreate3[exp:Delegate](this)))
	stloc:native int(var_1_0D, ldfld:native int(Delegate::invoke_impl, ldloc:ObjectCreate3[exp:Delegate](this)))
	stloc:native int(var_2_14, ldfld:native int(Delegate::method, ldloc:ObjectCreate3[exp:Delegate](this)))
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

			// Token: 0x06001A64 RID: 6756 RVA: 0x000021DB File Offset: 0x000003DB
			public IAsyncResult BeginInvoke(global::UnityEngine.Object asset, global::UnityEngine.Object asset2, global::UnityEngine.Object asset3, AsyncCallback callback, object @object)
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}

			// Token: 0x06001A65 RID: 6757 RVA: 0x000021DB File Offset: 0x000003DB
			public object EndInvoke(IAsyncResult result)
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}
	}
}
