using System;
using System.Runtime.InteropServices;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine
{
	// Token: 0x020000A4 RID: 164
	[NativeHeader("Runtime/Export/Scripting/AsyncOperation.bindings.h")]
	[NativeHeader("Runtime/Misc/AsyncOperation.h")]
	[RequiredByNativeCode]
	[StructLayout(0)]
	public class AsyncOperation : YieldInstruction
	{
		// Token: 0x06000302 RID: 770 RVA: 0x0000659C File Offset: 0x0000479C
		protected override void Finalize()
		{
			IntPtr ptr = this.m_Ptr;
			throw new MissingMethodException();
		}

		// Token: 0x06000303 RID: 771 RVA: 0x000065E0 File Offset: 0x000047E0
		[RequiredByNativeCode]
		internal void InvokeCompletionEvent()
		{
			if (this.m_completeCallback != null)
			{
			}
		}

		// Token: 0x06000304 RID: 772 RVA: 0x000065F8 File Offset: 0x000047F8
		[NativeMethod(IsThreadSafe = true)]
		[StaticAccessor("AsyncOperationBindings", StaticAccessorType.DoubleColon)]
		private static void InternalDestroy(IntPtr ptr)
		{
			throw new MissingMethodException();
		}

		// Token: 0x170000AD RID: 173
		// (get) Token: 0x06000305 RID: 773 RVA: 0x0000660C File Offset: 0x0000480C
		public bool isDone
		{
			[NativeMethod("IsDone")]
			get
			{
				throw new MissingMethodException();
			}
		}

		// Token: 0x06000306 RID: 774 RVA: 0x00006620 File Offset: 0x00004820
		public AsyncOperation()
		{
		}

		// Token: 0x04000361 RID: 865
		internal IntPtr m_Ptr;

		// Token: 0x04000362 RID: 866
		private Action<AsyncOperation> m_completeCallback;
	}
}
