using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine.Experimental.Audio
{
	// Token: 0x02000011 RID: 17
	[StaticAccessor("AudioSampleProviderBindings", StaticAccessorType.DoubleColon)]
	[NativeType(Header = "Modules/Audio/Public/ScriptBindings/AudioSampleProvider.bindings.h")]
	public class AudioSampleProvider
	{
		// Token: 0x0600002B RID: 43 RVA: 0x00002498 File Offset: 0x00000698
		[RequiredByNativeCode]
		private void InvokeSampleFramesAvailable(int sampleFrameCount)
		{
			AudioSampleProvider.SampleFramesHandler sampleFramesHandler = this.sampleFramesAvailable;
			if (sampleFramesHandler != null)
			{
				IntPtr invoke_impl = sampleFramesHandler.invoke_impl;
				IntPtr method_code = sampleFramesHandler.method_code;
				IntPtr method = sampleFramesHandler.method;
				return;
			}
		}

		// Token: 0x0600002C RID: 44 RVA: 0x000024C8 File Offset: 0x000006C8
		[RequiredByNativeCode]
		private void InvokeSampleFramesOverflow(int droppedSampleFrameCount)
		{
			AudioSampleProvider.SampleFramesHandler sampleFramesHandler = this.sampleFramesOverflow;
			if (sampleFramesHandler != null)
			{
				IntPtr invoke_impl = sampleFramesHandler.invoke_impl;
				IntPtr method_code = sampleFramesHandler.method_code;
				IntPtr method = sampleFramesHandler.method;
				return;
			}
		}

		// Token: 0x0400000C RID: 12
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private AudioSampleProvider.SampleFramesHandler sampleFramesAvailable;

		// Token: 0x0400000D RID: 13
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		private AudioSampleProvider.SampleFramesHandler sampleFramesOverflow;

		// Token: 0x02000012 RID: 18
		public sealed class SampleFramesHandler : MulticastDelegate
		{
			// Token: 0x0600002D RID: 45 RVA: 0x000024F8 File Offset: 0x000006F8
			public SampleFramesHandler(object @object, IntPtr method)
			{
				this.method_ptr = method;
				this.m_target = @object;
				this.method = method;
				this.method_code = this;
			}

			// Token: 0x0600002E RID: 46 RVA: 0x00002558 File Offset: 0x00000758
			public void Invoke(AudioSampleProvider provider, uint sampleFrameCount)
			{
				IntPtr method_code = this.method_code;
				IntPtr invoke_impl = this.invoke_impl;
				IntPtr method = this.method;
			}
		}
	}
}
