using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine
{
	// Token: 0x02000002 RID: 2
	[NativeHeader("Modules/Audio/Public/ScriptBindings/Audio.bindings.h")]
	[StaticAccessor("GetAudioManager()", StaticAccessorType.Dot)]
	public sealed class AudioSettings
	{
		// Token: 0x06000001 RID: 1 RVA: 0x00002050 File Offset: 0x00000250
		[RequiredByNativeCode]
		internal static void InvokeOnAudioConfigurationChanged(bool deviceWasChanged)
		{
		}

		// Token: 0x06000002 RID: 2 RVA: 0x00002060 File Offset: 0x00000260
		[RequiredByNativeCode]
		internal static void InvokeOnAudioSystemShuttingDown()
		{
		}

		// Token: 0x06000003 RID: 3 RVA: 0x00002070 File Offset: 0x00000270
		[RequiredByNativeCode]
		internal static void InvokeOnAudioSystemStartedUp()
		{
		}

		// Token: 0x06000004 RID: 4 RVA: 0x00002080 File Offset: 0x00000280
		internal static bool StartAudioOutput()
		{
			throw new MissingMethodException();
		}

		// Token: 0x06000005 RID: 5 RVA: 0x00002094 File Offset: 0x00000294
		internal static bool StopAudioOutput()
		{
			throw new MissingMethodException();
		}

		// Token: 0x04000001 RID: 1
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		private static AudioSettings.AudioConfigurationChangeHandler OnAudioConfigurationChanged;

		// Token: 0x04000002 RID: 2
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private static Action OnAudioSystemShuttingDown;

		// Token: 0x04000003 RID: 3
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		private static Action OnAudioSystemStartedUp;

		// Token: 0x02000003 RID: 3
		public sealed class AudioConfigurationChangeHandler : MulticastDelegate
		{
			// Token: 0x06000006 RID: 6 RVA: 0x000020A8 File Offset: 0x000002A8
			public AudioConfigurationChangeHandler(object @object, IntPtr method)
			{
				this.method_ptr = method;
				this.m_target = @object;
				this.method = method;
				this.method_code = this;
			}

			// Token: 0x06000007 RID: 7 RVA: 0x000020FC File Offset: 0x000002FC
			public void Invoke(bool deviceWasChanged)
			{
				IntPtr method_code = this.method_code;
				IntPtr invoke_impl = this.invoke_impl;
				IntPtr method = this.method;
			}
		}

		// Token: 0x02000004 RID: 4
		public static class Mobile
		{
			// Token: 0x17000001 RID: 1
			// (get) Token: 0x06000008 RID: 8 RVA: 0x0000211E File Offset: 0x0000031E
			// (set) Token: 0x06000009 RID: 9 RVA: 0x0000212C File Offset: 0x0000032C
			public static bool muteState
			{
				[CompilerGenerated]
				get
				{
					throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
				}
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x17000002 RID: 2
			// (get) Token: 0x0600000A RID: 10 RVA: 0x0000211E File Offset: 0x0000031E
			public static bool stopAudioOutputOnMute
			{
				get
				{
					throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
				}
			}

			// Token: 0x0600000B RID: 11 RVA: 0x0000213C File Offset: 0x0000033C
			[RequiredByNativeCode]
			internal static void InvokeOnMuteStateChanged(bool mute)
			{
				if (true)
				{
					throw new MissingMethodException();
				}
			}

			// Token: 0x0600000C RID: 12 RVA: 0x0000211E File Offset: 0x0000031E
			[RequiredByNativeCode]
			internal static bool InvokeIsStopAudioOutputOnMuteEnabled()
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}

			// Token: 0x0600000D RID: 13 RVA: 0x0000215C File Offset: 0x0000035C
			public static void StartAudioOutput()
			{
				throw new MissingMethodException();
			}

			// Token: 0x0600000E RID: 14 RVA: 0x00002170 File Offset: 0x00000370
			public static void StopAudioOutput()
			{
				throw new MissingMethodException();
			}

			// Token: 0x04000004 RID: 4
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[CompilerGenerated]
			private static bool <muteState>k__BackingField;

			// Token: 0x04000005 RID: 5
			private static bool _stopAudioOutputOnMute;

			// Token: 0x04000006 RID: 6
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[CompilerGenerated]
			private static Action<bool> OnMuteStateChanged;
		}
	}
}
