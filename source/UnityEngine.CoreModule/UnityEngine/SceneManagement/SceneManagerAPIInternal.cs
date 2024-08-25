using System;
using UnityEngine.Bindings;

namespace UnityEngine.SceneManagement
{
	// Token: 0x02000125 RID: 293
	[NativeHeader("Runtime/Export/SceneManager/SceneManager.bindings.h")]
	[NativeHeader("Runtime/SceneManager/SceneManager.h")]
	[StaticAccessor("SceneManagerBindings", StaticAccessorType.DoubleColon)]
	internal static class SceneManagerAPIInternal
	{
		// Token: 0x060005DE RID: 1502 RVA: 0x0000A748 File Offset: 0x00008948
		[NativeThrows]
		public static AsyncOperation LoadSceneAsyncNameIndexInternal(string sceneName, int sceneBuildIndex, LoadSceneParameters parameters, bool mustCompleteNextFrame)
		{
			throw new MissingMethodException();
		}

		// Token: 0x060005DF RID: 1503 RVA: 0x0000A75C File Offset: 0x0000895C
		private static AsyncOperation LoadSceneAsyncNameIndexInternal_Injected(string sceneName, int sceneBuildIndex, LoadSceneParameters parameters, bool mustCompleteNextFrame)
		{
			throw new MissingMethodException();
		}
	}
}
