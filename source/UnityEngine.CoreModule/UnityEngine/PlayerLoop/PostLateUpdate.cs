using System;
using UnityEngine.Scripting;
using UnityEngine.Scripting.APIUpdating;

namespace UnityEngine.PlayerLoop
{
	// Token: 0x020001CB RID: 459
	[MovedFrom("UnityEngine.Experimental.PlayerLoop")]
	[RequiredByNativeCode]
	public struct PostLateUpdate
	{
		// Token: 0x020001CC RID: 460
		[RequiredByNativeCode]
		public struct PlayerSendFrameStarted
		{
		}

		// Token: 0x020001CD RID: 461
		[RequiredByNativeCode]
		public struct UpdateRectTransform
		{
		}

		// Token: 0x020001CE RID: 462
		[RequiredByNativeCode]
		public struct UpdateCanvasRectTransform
		{
		}

		// Token: 0x020001CF RID: 463
		[RequiredByNativeCode]
		public struct PlayerUpdateCanvases
		{
		}

		// Token: 0x020001D0 RID: 464
		[RequiredByNativeCode]
		public struct UpdateAudio
		{
		}

		// Token: 0x020001D1 RID: 465
		[RequiredByNativeCode]
		public struct UpdateVideo
		{
		}

		// Token: 0x020001D2 RID: 466
		[RequiredByNativeCode]
		public struct DirectorLateUpdate
		{
		}

		// Token: 0x020001D3 RID: 467
		[RequiredByNativeCode]
		public struct ScriptRunDelayedDynamicFrameRate
		{
		}

		// Token: 0x020001D4 RID: 468
		[RequiredByNativeCode]
		public struct VFXUpdate
		{
		}

		// Token: 0x020001D5 RID: 469
		[RequiredByNativeCode]
		public struct ParticleSystemEndUpdateAll
		{
		}

		// Token: 0x020001D6 RID: 470
		[RequiredByNativeCode]
		public struct EndGraphicsJobsAfterScriptLateUpdate
		{
		}

		// Token: 0x020001D7 RID: 471
		[RequiredByNativeCode]
		public struct UpdateSubstance
		{
		}

		// Token: 0x020001D8 RID: 472
		[RequiredByNativeCode]
		public struct UpdateCustomRenderTextures
		{
		}

		// Token: 0x020001D9 RID: 473
		[RequiredByNativeCode]
		public struct XRPostLateUpdate
		{
		}

		// Token: 0x020001DA RID: 474
		[RequiredByNativeCode]
		public struct UpdateAllRenderers
		{
		}

		// Token: 0x020001DB RID: 475
		[RequiredByNativeCode]
		public struct UpdateLightProbeProxyVolumes
		{
		}

		// Token: 0x020001DC RID: 476
		[RequiredByNativeCode]
		public struct EnlightenRuntimeUpdate
		{
		}

		// Token: 0x020001DD RID: 477
		[RequiredByNativeCode]
		public struct UpdateAllSkinnedMeshes
		{
		}

		// Token: 0x020001DE RID: 478
		[RequiredByNativeCode]
		public struct ProcessWebSendMessages
		{
		}

		// Token: 0x020001DF RID: 479
		[RequiredByNativeCode]
		public struct SortingGroupsUpdate
		{
		}

		// Token: 0x020001E0 RID: 480
		[RequiredByNativeCode]
		public struct UpdateVideoTextures
		{
		}

		// Token: 0x020001E1 RID: 481
		[RequiredByNativeCode]
		public struct DirectorRenderImage
		{
		}

		// Token: 0x020001E2 RID: 482
		[RequiredByNativeCode]
		public struct PlayerEmitCanvasGeometry
		{
		}

		// Token: 0x020001E3 RID: 483
		[RequiredByNativeCode]
		public struct FinishFrameRendering
		{
		}

		// Token: 0x020001E4 RID: 484
		[RequiredByNativeCode]
		public struct BatchModeUpdate
		{
		}

		// Token: 0x020001E5 RID: 485
		[RequiredByNativeCode]
		public struct PlayerSendFrameComplete
		{
		}

		// Token: 0x020001E6 RID: 486
		[RequiredByNativeCode]
		public struct UpdateCaptureScreenshot
		{
		}

		// Token: 0x020001E7 RID: 487
		[RequiredByNativeCode]
		public struct PresentAfterDraw
		{
		}

		// Token: 0x020001E8 RID: 488
		[RequiredByNativeCode]
		public struct ClearImmediateRenderers
		{
		}

		// Token: 0x020001E9 RID: 489
		[RequiredByNativeCode]
		public struct XRPostPresent
		{
		}

		// Token: 0x020001EA RID: 490
		[RequiredByNativeCode]
		public struct UpdateResolution
		{
		}

		// Token: 0x020001EB RID: 491
		[RequiredByNativeCode]
		public struct InputEndFrame
		{
		}

		// Token: 0x020001EC RID: 492
		[RequiredByNativeCode]
		public struct GUIClearEvents
		{
		}

		// Token: 0x020001ED RID: 493
		[RequiredByNativeCode]
		public struct ShaderHandleErrors
		{
		}

		// Token: 0x020001EE RID: 494
		[RequiredByNativeCode]
		public struct ResetInputAxis
		{
		}

		// Token: 0x020001EF RID: 495
		[RequiredByNativeCode]
		public struct ThreadedLoadingDebug
		{
		}

		// Token: 0x020001F0 RID: 496
		[RequiredByNativeCode]
		public struct ProfilerSynchronizeStats
		{
		}

		// Token: 0x020001F1 RID: 497
		[RequiredByNativeCode]
		public struct MemoryFrameMaintenance
		{
		}

		// Token: 0x020001F2 RID: 498
		[RequiredByNativeCode]
		public struct ExecuteGameCenterCallbacks
		{
		}

		// Token: 0x020001F3 RID: 499
		[RequiredByNativeCode]
		public struct XRPreEndFrame
		{
		}

		// Token: 0x020001F4 RID: 500
		[RequiredByNativeCode]
		public struct ProfilerEndFrame
		{
		}

		// Token: 0x020001F5 RID: 501
		[RequiredByNativeCode]
		public struct GraphicsWarmupPreloadedShaders
		{
		}

		// Token: 0x020001F6 RID: 502
		[RequiredByNativeCode]
		public struct PlayerSendFramePostPresent
		{
		}

		// Token: 0x020001F7 RID: 503
		[RequiredByNativeCode]
		public struct PhysicsSkinnedClothBeginUpdate
		{
		}

		// Token: 0x020001F8 RID: 504
		[RequiredByNativeCode]
		public struct PhysicsSkinnedClothFinishUpdate
		{
		}

		// Token: 0x020001F9 RID: 505
		[RequiredByNativeCode]
		public struct TriggerEndOfFrameCallbacks
		{
		}
	}
}
