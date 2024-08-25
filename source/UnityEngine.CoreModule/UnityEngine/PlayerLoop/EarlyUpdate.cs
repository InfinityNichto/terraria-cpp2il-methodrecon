using System;
using UnityEngine.Scripting;
using UnityEngine.Scripting.APIUpdating;

namespace UnityEngine.PlayerLoop
{
	// Token: 0x0200017F RID: 383
	[MovedFrom("UnityEngine.Experimental.PlayerLoop")]
	[RequiredByNativeCode]
	public struct EarlyUpdate
	{
		// Token: 0x02000180 RID: 384
		[RequiredByNativeCode]
		public struct PollPlayerConnection
		{
		}

		// Token: 0x02000181 RID: 385
		[RequiredByNativeCode]
		public struct PollHtcsPlayerConnection
		{
		}

		// Token: 0x02000182 RID: 386
		[RequiredByNativeCode]
		public struct GpuTimestamp
		{
		}

		// Token: 0x02000183 RID: 387
		[RequiredByNativeCode]
		public struct AnalyticsCoreStatsUpdate
		{
		}

		// Token: 0x02000184 RID: 388
		[RequiredByNativeCode]
		public struct UnityWebRequestUpdate
		{
		}

		// Token: 0x02000185 RID: 389
		[RequiredByNativeCode]
		public struct UpdateStreamingManager
		{
		}

		// Token: 0x02000186 RID: 390
		[RequiredByNativeCode]
		public struct ExecuteMainThreadJobs
		{
		}

		// Token: 0x02000187 RID: 391
		[RequiredByNativeCode]
		public struct ProcessMouseInWindow
		{
		}

		// Token: 0x02000188 RID: 392
		[RequiredByNativeCode]
		public struct ClearIntermediateRenderers
		{
		}

		// Token: 0x02000189 RID: 393
		[RequiredByNativeCode]
		public struct ClearLines
		{
		}

		// Token: 0x0200018A RID: 394
		[RequiredByNativeCode]
		public struct PresentBeforeUpdate
		{
		}

		// Token: 0x0200018B RID: 395
		[RequiredByNativeCode]
		public struct ResetFrameStatsAfterPresent
		{
		}

		// Token: 0x0200018C RID: 396
		[RequiredByNativeCode]
		public struct UpdateAsyncReadbackManager
		{
		}

		// Token: 0x0200018D RID: 397
		[RequiredByNativeCode]
		public struct UpdateTextureStreamingManager
		{
		}

		// Token: 0x0200018E RID: 398
		[RequiredByNativeCode]
		public struct UpdatePreloading
		{
		}

		// Token: 0x0200018F RID: 399
		[RequiredByNativeCode]
		public struct RendererNotifyInvisible
		{
		}

		// Token: 0x02000190 RID: 400
		[RequiredByNativeCode]
		public struct PlayerCleanupCachedData
		{
		}

		// Token: 0x02000191 RID: 401
		[RequiredByNativeCode]
		public struct UpdateMainGameViewRect
		{
		}

		// Token: 0x02000192 RID: 402
		[RequiredByNativeCode]
		public struct UpdateCanvasRectTransform
		{
		}

		// Token: 0x02000193 RID: 403
		[RequiredByNativeCode]
		public struct UpdateInputManager
		{
		}

		// Token: 0x02000194 RID: 404
		[RequiredByNativeCode]
		public struct ProcessRemoteInput
		{
		}

		// Token: 0x02000195 RID: 405
		[RequiredByNativeCode]
		public struct XRUpdate
		{
		}

		// Token: 0x02000196 RID: 406
		[RequiredByNativeCode]
		public struct ScriptRunDelayedStartupFrame
		{
		}

		// Token: 0x02000197 RID: 407
		[RequiredByNativeCode]
		public struct UpdateKinect
		{
		}

		// Token: 0x02000198 RID: 408
		[RequiredByNativeCode]
		public struct DeliverIosPlatformEvents
		{
		}

		// Token: 0x02000199 RID: 409
		[RequiredByNativeCode]
		public struct DispatchEventQueueEvents
		{
		}

		// Token: 0x0200019A RID: 410
		[RequiredByNativeCode]
		public struct PhysicsResetInterpolatedTransformPosition
		{
		}

		// Token: 0x0200019B RID: 411
		[RequiredByNativeCode]
		public struct SpriteAtlasManagerUpdate
		{
		}

		// Token: 0x0200019C RID: 412
		[RequiredByNativeCode]
		[Obsolete("TangoUpdate has been deprecated. Use ARCoreUpdate instead (UnityUpgradable) -> UnityEngine.PlayerLoop.EarlyUpdate/ARCoreUpdate", false)]
		public struct TangoUpdate
		{
		}

		// Token: 0x0200019D RID: 413
		[RequiredByNativeCode]
		public struct ARCoreUpdate
		{
		}

		// Token: 0x0200019E RID: 414
		[RequiredByNativeCode]
		public struct PerformanceAnalyticsUpdate
		{
		}
	}
}
