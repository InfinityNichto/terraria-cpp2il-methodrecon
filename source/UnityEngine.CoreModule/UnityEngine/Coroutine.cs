using System;
using System.Runtime.InteropServices;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine
{
	// Token: 0x020000BF RID: 191
	[NativeHeader("Runtime/Mono/Coroutine.h")]
	[RequiredByNativeCode]
	[StructLayout(0)]
	public sealed class Coroutine : YieldInstruction
	{
		// Token: 0x06000349 RID: 841 RVA: 0x00006C58 File Offset: 0x00004E58
		private Coroutine()
		{
		}

		// Token: 0x0600034A RID: 842 RVA: 0x00006C6C File Offset: 0x00004E6C
		protected override void Finalize()
		{
			IntPtr ptr = this.m_Ptr;
			throw new MissingMethodException();
		}

		// Token: 0x0600034B RID: 843 RVA: 0x00006CB0 File Offset: 0x00004EB0
		[FreeFunction("Coroutine::CleanupCoroutineGC", true)]
		private static void ReleaseCoroutine(IntPtr ptr)
		{
			throw new MissingMethodException();
		}

		// Token: 0x04000373 RID: 883
		internal IntPtr m_Ptr;
	}
}
