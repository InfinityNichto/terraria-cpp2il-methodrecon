using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnityEngine.Bindings;
using UnityEngine.Events;
using UnityEngine.Internal;
using UnityEngine.Scripting;

namespace UnityEngine.SceneManagement
{
	// Token: 0x02000123 RID: 291
	[RequiredByNativeCode]
	[NativeHeader("Runtime/Export/SceneManager/SceneManager.bindings.h")]
	public class SceneManager
	{
		// Token: 0x14000004 RID: 4
		// (add) Token: 0x060005CE RID: 1486 RVA: 0x0000A600 File Offset: 0x00008800
		// (remove) Token: 0x060005CF RID: 1487 RVA: 0x0000A620 File Offset: 0x00008820
		public static event UnityAction<Scene, LoadSceneMode> sceneLoaded
		{
			[CompilerGenerated]
			add
			{
				if (!true)
				{
				}
				Delegate @delegate;
				if (@delegate != null && @delegate == null)
				{
					return;
				}
				if (!true)
				{
				}
			}
			[CompilerGenerated]
			remove
			{
				if (!true)
				{
				}
				Delegate @delegate;
				if (@delegate != null && @delegate == null)
				{
					return;
				}
				if (!true)
				{
				}
			}
		}

		// Token: 0x060005D0 RID: 1488 RVA: 0x0000A640 File Offset: 0x00008840
		[ExcludeFromDocs]
		public static void LoadScene(string sceneName)
		{
			if (!true)
			{
			}
		}

		// Token: 0x060005D1 RID: 1489 RVA: 0x0000A650 File Offset: 0x00008850
		public static Scene LoadScene(string sceneName, LoadSceneParameters parameters)
		{
			if (!true)
			{
			}
			throw new MissingMethodException();
		}

		// Token: 0x060005D2 RID: 1490 RVA: 0x0000A670 File Offset: 0x00008870
		[RequiredByNativeCode]
		private static void Internal_SceneLoaded(Scene scene, LoadSceneMode mode)
		{
			if (!true)
			{
			}
			if (true)
			{
				if (!true)
				{
				}
				return;
			}
		}

		// Token: 0x060005D3 RID: 1491 RVA: 0x0000A688 File Offset: 0x00008888
		[RequiredByNativeCode]
		private static void Internal_SceneUnloaded(Scene scene)
		{
			if (!true)
			{
			}
		}

		// Token: 0x060005D4 RID: 1492 RVA: 0x0000A69C File Offset: 0x0000889C
		[RequiredByNativeCode]
		private static void Internal_ActiveSceneChanged(Scene previousActiveScene, Scene newActiveScene)
		{
			if (!true)
			{
			}
		}

		// Token: 0x17000144 RID: 324
		// (get) Token: 0x060005D5 RID: 1493 RVA: 0x0000A6B0 File Offset: 0x000088B0
		public static int sceneCount
		{
			[StaticAccessor("GetSceneManager()", StaticAccessorType.Dot)]
			[NativeHeader("Runtime/SceneManager/SceneManager.h")]
			[NativeMethod("GetSceneCount")]
			get
			{
				throw new MissingMethodException();
			}
		}

		// Token: 0x060005D6 RID: 1494 RVA: 0x0000A6C4 File Offset: 0x000088C4
		[StaticAccessor("SceneManagerBindings", StaticAccessorType.DoubleColon)]
		[NativeThrows]
		public static Scene GetSceneAt(int index)
		{
			if (!true)
			{
			}
			throw new MissingMethodException();
		}

		// Token: 0x060005D7 RID: 1495 RVA: 0x0000A6DC File Offset: 0x000088DC
		private static AsyncOperation LoadSceneAsyncNameIndexInternal(string sceneName, int sceneBuildIndex, LoadSceneParameters parameters, bool mustCompleteNextFrame)
		{
			if (!true)
			{
			}
			if (true)
			{
				SceneManagerAPI activeAPI = SceneManagerAPI.ActiveAPI;
				return;
			}
		}

		// Token: 0x060005D8 RID: 1496 RVA: 0x0000A6F8 File Offset: 0x000088F8
		[RequiredByNativeCode]
		internal static AsyncOperation LoadFirstScene_Internal(bool async)
		{
			/*
An exception occurred when decompiling this method (060005D8)

ICSharpCode.Decompiler.DecompilerException: Error decompiling UnityEngine.AsyncOperation UnityEngine.SceneManagement.SceneManager::LoadFirstScene_Internal(System.Boolean)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0003:
	stloc:SceneManagerAPI(var_0_08, callgetter:SceneManagerAPI(SceneManagerAPI::get_ActiveAPI))
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

		// Token: 0x060005D9 RID: 1497 RVA: 0x0000A710 File Offset: 0x00008910
		// Note: this type is marked as 'beforefieldinit'.
		static SceneManager()
		{
		}

		// Token: 0x060005DA RID: 1498 RVA: 0x0000A720 File Offset: 0x00008920
		private static void GetSceneAt_Injected(int index, [Out] Scene ret)
		{
			throw new MissingMethodException();
		}

		// Token: 0x040004E2 RID: 1250
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private static UnityAction<Scene, LoadSceneMode> sceneLoaded;

		// Token: 0x040004E3 RID: 1251
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		private static UnityAction<Scene> sceneUnloaded;

		// Token: 0x040004E4 RID: 1252
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private static UnityAction<Scene, Scene> activeSceneChanged;

		// Token: 0x040004E5 RID: 1253
		internal static bool s_AllowLoadScene;
	}
}
