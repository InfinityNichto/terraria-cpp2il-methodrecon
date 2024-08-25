using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Cpp2IlInjected;

namespace UnityEngine.UI
{
	// Token: 0x02000078 RID: 120
	internal class ReflectionMethodsCache
	{
		// Token: 0x060004F4 RID: 1268 RVA: 0x0000F860 File Offset: 0x0000DA60
		public ReflectionMethodsCache()
		{
			if (!true)
			{
			}
			Type type;
			Type type2;
			Type type3;
			Type type4;
			if ((type == null || type != null) && (type2 == null || type2 != null) && (type3 == null || type3 != null) && (type4 == null || type4 != null))
			{
				Type type5;
				MethodInfo methodInfo;
				Delegate @delegate = Delegate.CreateDelegate(type5, methodInfo);
				if (@delegate != null)
				{
					this.raycast3D = @delegate;
					return;
				}
				this.raycast3D = @delegate;
				Type type6;
				Type type7;
				Type type8;
				if ((type6 == null || type6 != null) && (type7 == null || type7 != null) && (type8 == null || type8 != null))
				{
					Type type9;
					MethodInfo methodInfo2;
					Delegate delegate2 = Delegate.CreateDelegate(type9, methodInfo2);
					if (delegate2 != null)
					{
						this.raycast3DAll = delegate2;
						return;
					}
					this.raycast3DAll = delegate2;
					Type type10;
					Type type11;
					Type type12;
					Type type13;
					if ((type10 == null || type10 != null) && (type11 == null || type11 != null) && (type12 == null || type12 != null) && (type13 == null || type13 != null))
					{
						Type type14;
						MethodInfo methodInfo3;
						Delegate delegate3 = Delegate.CreateDelegate(type14, methodInfo3);
						if (delegate3 != null)
						{
							this.getRaycastNonAlloc = delegate3;
							return;
						}
						this.getRaycastNonAlloc = delegate3;
						Type type15;
						Type type16;
						Type type17;
						Type type18;
						if ((type15 == null || type15 != null) && (type16 == null || type16 != null) && (type17 == null || type17 != null) && (type18 == null || type18 != null))
						{
							Type type19;
							MethodInfo methodInfo4;
							Delegate delegate4 = Delegate.CreateDelegate(type19, methodInfo4);
							if (delegate4 != null)
							{
								this.raycast2D = delegate4;
								return;
							}
							this.raycast2D = delegate4;
							Type type20;
							Type type21;
							Type type22;
							if ((type20 == null || type20 != null) && (type21 == null || type21 != null) && (type22 == null || type22 != null))
							{
								Type type23;
								MethodInfo methodInfo5;
								Delegate delegate5 = Delegate.CreateDelegate(type23, methodInfo5);
								if (delegate5 != null)
								{
									this.getRayIntersectionAll = delegate5;
									return;
								}
								this.getRayIntersectionAll = delegate5;
								Type type24;
								Type type25;
								Type type26;
								Type type27;
								if ((type24 == null || type24 != null) && (type25 == null || type25 != null) && (type26 == null || type26 != null) && (type27 == null || type27 != null))
								{
									Type type28;
									MethodInfo methodInfo6;
									Delegate delegate6 = Delegate.CreateDelegate(type28, methodInfo6);
									if (delegate6 != null)
									{
										this.getRayIntersectionAllNonAlloc = delegate6;
										throw new InvalidCastException();
									}
									this.getRayIntersectionAllNonAlloc = delegate6;
									return;
								}
							}
						}
					}
				}
			}
			throw new ArrayTypeMismatchException();
		}

		// Token: 0x17000151 RID: 337
		// (get) Token: 0x060004F5 RID: 1269 RVA: 0x0000FA24 File Offset: 0x0000DC24
		public static ReflectionMethodsCache Singleton
		{
			get
			{
				/*
An exception occurred when decompiling this method (060004F5)

ICSharpCode.Decompiler.DecompilerException: Error decompiling UnityEngine.UI.ReflectionMethodsCache UnityEngine.UI.ReflectionMethodsCache::get_Singleton()

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

		// Token: 0x04000257 RID: 599
		public ReflectionMethodsCache.Raycast3DCallback raycast3D;

		// Token: 0x04000258 RID: 600
		public ReflectionMethodsCache.RaycastAllCallback raycast3DAll;

		// Token: 0x04000259 RID: 601
		public ReflectionMethodsCache.GetRaycastNonAllocCallback getRaycastNonAlloc;

		// Token: 0x0400025A RID: 602
		public ReflectionMethodsCache.Raycast2DCallback raycast2D;

		// Token: 0x0400025B RID: 603
		public ReflectionMethodsCache.GetRayIntersectionAllCallback getRayIntersectionAll;

		// Token: 0x0400025C RID: 604
		public ReflectionMethodsCache.GetRayIntersectionAllNonAllocCallback getRayIntersectionAllNonAlloc;

		// Token: 0x0400025D RID: 605
		private static ReflectionMethodsCache s_ReflectionMethodsCache;

		// Token: 0x02000079 RID: 121
		public sealed class Raycast3DCallback : MulticastDelegate
		{
			// Token: 0x060004F6 RID: 1270 RVA: 0x0000FA34 File Offset: 0x0000DC34
			public Raycast3DCallback(object @object, IntPtr method)
			{
				this.method_ptr = method;
				this.m_target = @object;
				this.method = method;
				this.method_code = this;
			}

			// Token: 0x060004F7 RID: 1271 RVA: 0x0000FA88 File Offset: 0x0000DC88
			public bool Invoke(Ray r, [Out] RaycastHit hit, float f, int i)
			{
				/*
An exception occurred when decompiling this method (060004F7)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean UnityEngine.UI.ReflectionMethodsCache/Raycast3DCallback::Invoke(UnityEngine.Ray,UnityEngine.RaycastHit,System.Single,System.Int32)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:float32(var_0_0B, ldfld:float32(Vector3::y, ldfld:Vector3[exp:valuetype [UnityEngine.CoreModule]UnityEngine.Vector3&](Ray::m_Direction, ldloc:Ray[exp:valuetype [UnityEngine.CoreModule]UnityEngine.Ray&](r))))
	stloc:native int(var_1_12, ldfld:native int(Delegate::invoke_impl, ldloc:Raycast3DCallback[exp:Delegate](this)))
	stloc:native int(var_2_19, ldfld:native int(Delegate::method_code, ldloc:Raycast3DCallback[exp:Delegate](this)))
	stloc:native int(var_3_20, ldfld:native int(Delegate::method, ldloc:Raycast3DCallback[exp:Delegate](this)))
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

			// Token: 0x060004F8 RID: 1272 RVA: 0x00002207 File Offset: 0x00000407
			public IAsyncResult BeginInvoke(Ray r, [Out] RaycastHit hit, float f, int i, AsyncCallback callback, object @object)
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}

			// Token: 0x060004F9 RID: 1273 RVA: 0x00002207 File Offset: 0x00000407
			public bool EndInvoke([Out] RaycastHit hit, IAsyncResult result)
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		// Token: 0x0200007A RID: 122
		public sealed class RaycastAllCallback : MulticastDelegate
		{
			// Token: 0x060004FA RID: 1274 RVA: 0x0000FAB8 File Offset: 0x0000DCB8
			public RaycastAllCallback(object @object, IntPtr method)
			{
				this.method_ptr = method;
				this.m_target = @object;
				this.method = method;
				this.method_code = this;
			}

			// Token: 0x060004FB RID: 1275 RVA: 0x0000FB0C File Offset: 0x0000DD0C
			public RaycastHit[] Invoke(Ray r, float f, int i)
			{
				/*
An exception occurred when decompiling this method (060004FB)

ICSharpCode.Decompiler.DecompilerException: Error decompiling UnityEngine.RaycastHit[] UnityEngine.UI.ReflectionMethodsCache/RaycastAllCallback::Invoke(UnityEngine.Ray,System.Single,System.Int32)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:float32(var_0_0B, ldfld:float32(Vector3::y, ldfld:Vector3[exp:valuetype [UnityEngine.CoreModule]UnityEngine.Vector3&](Ray::m_Direction, ldloc:Ray[exp:valuetype [UnityEngine.CoreModule]UnityEngine.Ray&](r))))
	stloc:native int(var_1_12, ldfld:native int(Delegate::invoke_impl, ldloc:RaycastAllCallback[exp:Delegate](this)))
	stloc:native int(var_2_19, ldfld:native int(Delegate::method_code, ldloc:RaycastAllCallback[exp:Delegate](this)))
	stloc:native int(var_3_20, ldfld:native int(Delegate::method, ldloc:RaycastAllCallback[exp:Delegate](this)))
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

			// Token: 0x060004FC RID: 1276 RVA: 0x00002207 File Offset: 0x00000407
			public IAsyncResult BeginInvoke(Ray r, float f, int i, AsyncCallback callback, object @object)
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}

			// Token: 0x060004FD RID: 1277 RVA: 0x00002207 File Offset: 0x00000407
			public RaycastHit[] EndInvoke(IAsyncResult result)
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		// Token: 0x0200007B RID: 123
		public sealed class GetRaycastNonAllocCallback : MulticastDelegate
		{
			// Token: 0x060004FE RID: 1278 RVA: 0x0000FB3C File Offset: 0x0000DD3C
			public GetRaycastNonAllocCallback(object @object, IntPtr method)
			{
				this.method_ptr = method;
				this.m_target = @object;
				this.method = method;
				this.method_code = this;
			}

			// Token: 0x060004FF RID: 1279 RVA: 0x0000FB90 File Offset: 0x0000DD90
			public int Invoke(Ray r, RaycastHit[] results, float f, int i)
			{
				/*
An exception occurred when decompiling this method (060004FF)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Int32 UnityEngine.UI.ReflectionMethodsCache/GetRaycastNonAllocCallback::Invoke(UnityEngine.Ray,UnityEngine.RaycastHit[],System.Single,System.Int32)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:float32(var_0_0B, ldfld:float32(Vector3::y, ldfld:Vector3[exp:valuetype [UnityEngine.CoreModule]UnityEngine.Vector3&](Ray::m_Direction, ldloc:Ray[exp:valuetype [UnityEngine.CoreModule]UnityEngine.Ray&](r))))
	stloc:native int(var_1_12, ldfld:native int(Delegate::invoke_impl, ldloc:GetRaycastNonAllocCallback[exp:Delegate](this)))
	stloc:native int(var_2_19, ldfld:native int(Delegate::method_code, ldloc:GetRaycastNonAllocCallback[exp:Delegate](this)))
	stloc:native int(var_3_20, ldfld:native int(Delegate::method, ldloc:GetRaycastNonAllocCallback[exp:Delegate](this)))
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

			// Token: 0x06000500 RID: 1280 RVA: 0x00002207 File Offset: 0x00000407
			public IAsyncResult BeginInvoke(Ray r, RaycastHit[] results, float f, int i, AsyncCallback callback, object @object)
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}

			// Token: 0x06000501 RID: 1281 RVA: 0x00002207 File Offset: 0x00000407
			public int EndInvoke(IAsyncResult result)
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		// Token: 0x0200007C RID: 124
		public sealed class Raycast2DCallback : MulticastDelegate
		{
			// Token: 0x06000502 RID: 1282 RVA: 0x0000FBC0 File Offset: 0x0000DDC0
			public Raycast2DCallback(object @object, IntPtr method)
			{
				this.method_ptr = method;
				this.m_target = @object;
				this.method = method;
				this.method_code = this;
			}

			// Token: 0x06000503 RID: 1283 RVA: 0x0000FC14 File Offset: 0x0000DE14
			public RaycastHit2D Invoke(Vector2 p1, Vector2 p2, float f, int i)
			{
				IntPtr method_code = this.method_code;
				IntPtr invoke_impl = this.invoke_impl;
				IntPtr method = this.method;
				RaycastHit2D raycastHit2D;
				return raycastHit2D;
			}

			// Token: 0x06000504 RID: 1284 RVA: 0x00002207 File Offset: 0x00000407
			public IAsyncResult BeginInvoke(Vector2 p1, Vector2 p2, float f, int i, AsyncCallback callback, object @object)
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}

			// Token: 0x06000505 RID: 1285 RVA: 0x0000FC38 File Offset: 0x0000DE38
			public RaycastHit2D EndInvoke(IAsyncResult result)
			{
				RaycastHit2D raycastHit2D;
				raycastHit2D.m_Collider = raycastHit2D;
				return raycastHit2D;
			}
		}

		// Token: 0x0200007D RID: 125
		public sealed class GetRayIntersectionAllCallback : MulticastDelegate
		{
			// Token: 0x06000506 RID: 1286 RVA: 0x0000FC50 File Offset: 0x0000DE50
			public GetRayIntersectionAllCallback(object @object, IntPtr method)
			{
				this.method_ptr = method;
				this.m_target = @object;
				this.method = method;
				this.method_code = this;
			}

			// Token: 0x06000507 RID: 1287 RVA: 0x0000FCA4 File Offset: 0x0000DEA4
			public RaycastHit2D[] Invoke(Ray r, float f, int i)
			{
				/*
An exception occurred when decompiling this method (06000507)

ICSharpCode.Decompiler.DecompilerException: Error decompiling UnityEngine.RaycastHit2D[] UnityEngine.UI.ReflectionMethodsCache/GetRayIntersectionAllCallback::Invoke(UnityEngine.Ray,System.Single,System.Int32)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:float32(var_0_0B, ldfld:float32(Vector3::y, ldfld:Vector3[exp:valuetype [UnityEngine.CoreModule]UnityEngine.Vector3&](Ray::m_Direction, ldloc:Ray[exp:valuetype [UnityEngine.CoreModule]UnityEngine.Ray&](r))))
	stloc:native int(var_1_12, ldfld:native int(Delegate::invoke_impl, ldloc:GetRayIntersectionAllCallback[exp:Delegate](this)))
	stloc:native int(var_2_19, ldfld:native int(Delegate::method_code, ldloc:GetRayIntersectionAllCallback[exp:Delegate](this)))
	stloc:native int(var_3_20, ldfld:native int(Delegate::method, ldloc:GetRayIntersectionAllCallback[exp:Delegate](this)))
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

			// Token: 0x06000508 RID: 1288 RVA: 0x00002207 File Offset: 0x00000407
			public IAsyncResult BeginInvoke(Ray r, float f, int i, AsyncCallback callback, object @object)
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}

			// Token: 0x06000509 RID: 1289 RVA: 0x00002207 File Offset: 0x00000407
			public RaycastHit2D[] EndInvoke(IAsyncResult result)
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		// Token: 0x0200007E RID: 126
		public sealed class GetRayIntersectionAllNonAllocCallback : MulticastDelegate
		{
			// Token: 0x0600050A RID: 1290 RVA: 0x0000FCD4 File Offset: 0x0000DED4
			public GetRayIntersectionAllNonAllocCallback(object @object, IntPtr method)
			{
				this.method_ptr = method;
				this.m_target = @object;
				this.method = method;
				this.method_code = this;
			}

			// Token: 0x0600050B RID: 1291 RVA: 0x0000FD28 File Offset: 0x0000DF28
			public int Invoke(Ray r, RaycastHit2D[] results, float f, int i)
			{
				/*
An exception occurred when decompiling this method (0600050B)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Int32 UnityEngine.UI.ReflectionMethodsCache/GetRayIntersectionAllNonAllocCallback::Invoke(UnityEngine.Ray,UnityEngine.RaycastHit2D[],System.Single,System.Int32)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:float32(var_0_0B, ldfld:float32(Vector3::y, ldfld:Vector3[exp:valuetype [UnityEngine.CoreModule]UnityEngine.Vector3&](Ray::m_Direction, ldloc:Ray[exp:valuetype [UnityEngine.CoreModule]UnityEngine.Ray&](r))))
	stloc:native int(var_1_12, ldfld:native int(Delegate::invoke_impl, ldloc:GetRayIntersectionAllNonAllocCallback[exp:Delegate](this)))
	stloc:native int(var_2_19, ldfld:native int(Delegate::method_code, ldloc:GetRayIntersectionAllNonAllocCallback[exp:Delegate](this)))
	stloc:native int(var_3_20, ldfld:native int(Delegate::method, ldloc:GetRayIntersectionAllNonAllocCallback[exp:Delegate](this)))
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

			// Token: 0x0600050C RID: 1292 RVA: 0x00002207 File Offset: 0x00000407
			public IAsyncResult BeginInvoke(Ray r, RaycastHit2D[] results, float f, int i, AsyncCallback callback, object @object)
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}

			// Token: 0x0600050D RID: 1293 RVA: 0x00002207 File Offset: 0x00000407
			public int EndInvoke(IAsyncResult result)
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}
	}
}
