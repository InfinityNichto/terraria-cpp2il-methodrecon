using System;
using UnityEngine.Bindings;
using UnityEngineInternal;

namespace UnityEngine
{
	// Token: 0x020000D5 RID: 213
	[NativeHeader("Runtime/Misc/ResourceManagerUtility.h")]
	[NativeHeader("Runtime/Export/Resources/Resources.bindings.h")]
	internal static class ResourcesAPIInternal
	{
		// Token: 0x06000459 RID: 1113 RVA: 0x0000818C File Offset: 0x0000638C
		[FreeFunction("GetShaderNameRegistry().FindShader")]
		public static Shader FindShaderByName(string name)
		{
			throw new MissingMethodException();
		}

		// Token: 0x0600045A RID: 1114 RVA: 0x000081A0 File Offset: 0x000063A0
		[NativeThrows]
		[FreeFunction("Resources_Bindings::Load")]
		[TypeInferenceRule(TypeInferenceRules.TypeReferencedBySecondArgument)]
		public static Object Load(string path, [NotNull("ArgumentNullException")] Type systemTypeInstance)
		{
			throw new MissingMethodException();
		}

		// Token: 0x0600045B RID: 1115 RVA: 0x000081B4 File Offset: 0x000063B4
		[FreeFunction("Resources_Bindings::LoadAll")]
		[NativeThrows]
		public static Object[] LoadAll([NotNull("ArgumentNullException")] string path, [NotNull("ArgumentNullException")] Type systemTypeInstance)
		{
			throw new MissingMethodException();
		}

		// Token: 0x0600045C RID: 1116 RVA: 0x000081C8 File Offset: 0x000063C8
		[FreeFunction("Resources_Bindings::LoadAsyncInternal")]
		internal static ResourceRequest LoadAsyncInternal(string path, Type type)
		{
			throw new MissingMethodException();
		}

		// Token: 0x0600045D RID: 1117 RVA: 0x000081DC File Offset: 0x000063DC
		[FreeFunction("Scripting::UnloadAssetFromScripting")]
		public static void UnloadAsset(Object assetToUnload)
		{
			throw new MissingMethodException();
		}
	}
}
