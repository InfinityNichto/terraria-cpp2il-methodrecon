using System;
using UnityEngine.Scripting;

namespace UnityEngine
{
	// Token: 0x02000098 RID: 152
	internal static class ClassLibraryInitializer
	{
		// Token: 0x060002AC RID: 684 RVA: 0x00005E44 File Offset: 0x00004044
		[RequiredByNativeCode]
		private static void Init()
		{
			UnityLogWriter.Init();
		}
	}
}
