using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine
{
	// Token: 0x02000005 RID: 5
	[StaticAccessor("AudioClipBindings", StaticAccessorType.DoubleColon)]
	[NativeHeader("Modules/Audio/Public/ScriptBindings/Audio.bindings.h")]
	public sealed class AudioClip : Object
	{
		// Token: 0x17000003 RID: 3
		// (get) Token: 0x0600000F RID: 15 RVA: 0x00002184 File Offset: 0x00000384
		[NativeProperty("LengthSec")]
		public float length
		{
			get
			{
				throw new MissingMethodException();
			}
		}

		// Token: 0x06000010 RID: 16 RVA: 0x00002198 File Offset: 0x00000398
		[RequiredByNativeCode]
		private void InvokePCMReaderCallback_Internal(float[] data)
		{
			AudioClip.PCMReaderCallback pcmreaderCallback = this.m_PCMReaderCallback;
			if (pcmreaderCallback != null)
			{
				IntPtr invoke_impl = pcmreaderCallback.invoke_impl;
				IntPtr method_code = pcmreaderCallback.method_code;
				IntPtr method = pcmreaderCallback.method;
				return;
			}
		}

		// Token: 0x06000011 RID: 17 RVA: 0x000021C8 File Offset: 0x000003C8
		[RequiredByNativeCode]
		private void InvokePCMSetPositionCallback_Internal(int position)
		{
			AudioClip.PCMSetPositionCallback pcmsetPositionCallback = this.m_PCMSetPositionCallback;
			if (pcmsetPositionCallback != null)
			{
				IntPtr invoke_impl = pcmsetPositionCallback.invoke_impl;
				IntPtr method_code = pcmsetPositionCallback.method_code;
				IntPtr method = pcmsetPositionCallback.method;
				return;
			}
		}

		// Token: 0x04000007 RID: 7
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private AudioClip.PCMReaderCallback m_PCMReaderCallback;

		// Token: 0x04000008 RID: 8
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private AudioClip.PCMSetPositionCallback m_PCMSetPositionCallback;

		// Token: 0x02000006 RID: 6
		public sealed class PCMReaderCallback : MulticastDelegate
		{
			// Token: 0x06000012 RID: 18 RVA: 0x000021F8 File Offset: 0x000003F8
			public PCMReaderCallback(object @object, IntPtr method)
			{
				this.method_ptr = method;
				this.m_target = @object;
				this.method = method;
				this.method_code = this;
			}

			// Token: 0x06000013 RID: 19 RVA: 0x0000224C File Offset: 0x0000044C
			public void Invoke(float[] data)
			{
				IntPtr method_code = this.method_code;
				IntPtr invoke_impl = this.invoke_impl;
				IntPtr method = this.method;
			}
		}

		// Token: 0x02000007 RID: 7
		public sealed class PCMSetPositionCallback : MulticastDelegate
		{
			// Token: 0x06000014 RID: 20 RVA: 0x00002270 File Offset: 0x00000470
			public PCMSetPositionCallback(object @object, IntPtr method)
			{
				this.method_ptr = method;
				this.m_target = @object;
				this.method = method;
				this.method_code = this;
			}

			// Token: 0x06000015 RID: 21 RVA: 0x000022C4 File Offset: 0x000004C4
			public void Invoke(int position)
			{
				IntPtr method_code = this.method_code;
				IntPtr invoke_impl = this.invoke_impl;
				IntPtr method = this.method;
			}
		}
	}
}
