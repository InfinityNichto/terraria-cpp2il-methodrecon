using System;
using System.Runtime.InteropServices;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine
{
	// Token: 0x0200007D RID: 125
	[NativeHeader("Runtime/Graphics/RenderTexture.h")]
	[RequireComponent(typeof(Transform))]
	[NativeHeader("Runtime/Camera/Camera.h")]
	[NativeHeader("Runtime/GfxDevice/GfxDeviceTypes.h")]
	[NativeHeader("Runtime/Shaders/Shader.h")]
	[NativeHeader("Runtime/Misc/GameObjectUtility.h")]
	[UsedByNativeCode]
	[NativeHeader("Runtime/Camera/RenderManager.h")]
	[NativeHeader("Runtime/Graphics/CommandBuffer/RenderingCommandBuffer.h")]
	public sealed class Camera : Behaviour
	{
		// Token: 0x060001F7 RID: 503 RVA: 0x00004CF8 File Offset: 0x00002EF8
		public Camera()
		{
		}

		// Token: 0x17000060 RID: 96
		// (get) Token: 0x060001F8 RID: 504 RVA: 0x00004D0C File Offset: 0x00002F0C
		[NativeProperty("Near")]
		public float nearClipPlane
		{
			get
			{
				throw new MissingMethodException();
			}
		}

		// Token: 0x17000061 RID: 97
		// (get) Token: 0x060001F9 RID: 505 RVA: 0x00004D20 File Offset: 0x00002F20
		[NativeProperty("Far")]
		public float farClipPlane
		{
			get
			{
				throw new MissingMethodException();
			}
		}

		// Token: 0x17000062 RID: 98
		// (get) Token: 0x060001FA RID: 506 RVA: 0x00004D34 File Offset: 0x00002F34
		[NativeProperty("VerticalFieldOfView")]
		public float fieldOfView
		{
			get
			{
				throw new MissingMethodException();
			}
		}

		// Token: 0x17000063 RID: 99
		// (get) Token: 0x060001FB RID: 507 RVA: 0x00004D48 File Offset: 0x00002F48
		public float orthographicSize
		{
			get
			{
				throw new MissingMethodException();
			}
		}

		// Token: 0x17000064 RID: 100
		// (get) Token: 0x060001FC RID: 508 RVA: 0x00004D5C File Offset: 0x00002F5C
		public float depth
		{
			get
			{
				throw new MissingMethodException();
			}
		}

		// Token: 0x17000065 RID: 101
		// (get) Token: 0x060001FD RID: 509 RVA: 0x00004D70 File Offset: 0x00002F70
		public float aspect
		{
			get
			{
				throw new MissingMethodException();
			}
		}

		// Token: 0x17000066 RID: 102
		// (get) Token: 0x060001FE RID: 510 RVA: 0x00004D84 File Offset: 0x00002F84
		public int cullingMask
		{
			get
			{
				throw new MissingMethodException();
			}
		}

		// Token: 0x17000067 RID: 103
		// (get) Token: 0x060001FF RID: 511 RVA: 0x00004D98 File Offset: 0x00002F98
		public int eventMask
		{
			get
			{
				throw new MissingMethodException();
			}
		}

		// Token: 0x17000068 RID: 104
		// (set) Token: 0x06000200 RID: 512 RVA: 0x00004DAC File Offset: 0x00002FAC
		public Color backgroundColor
		{
			set
			{
				throw new MissingMethodException();
			}
		}

		// Token: 0x17000069 RID: 105
		// (get) Token: 0x06000201 RID: 513 RVA: 0x00004DC0 File Offset: 0x00002FC0
		// (set) Token: 0x06000202 RID: 514 RVA: 0x00004DD4 File Offset: 0x00002FD4
		public CameraClearFlags clearFlags
		{
			get
			{
				throw new MissingMethodException();
			}
			set
			{
				throw new MissingMethodException();
			}
		}

		// Token: 0x1700006A RID: 106
		// (get) Token: 0x06000203 RID: 515 RVA: 0x00004DE8 File Offset: 0x00002FE8
		// (set) Token: 0x06000204 RID: 516 RVA: 0x00004DFC File Offset: 0x00002FFC
		[NativeProperty("NormalizedViewportRect")]
		public Rect rect
		{
			get
			{
				throw new MissingMethodException();
			}
			set
			{
				throw new MissingMethodException();
			}
		}

		// Token: 0x1700006B RID: 107
		// (get) Token: 0x06000205 RID: 517 RVA: 0x00004E10 File Offset: 0x00003010
		[NativeProperty("ScreenViewportRect")]
		public Rect pixelRect
		{
			get
			{
				throw new MissingMethodException();
			}
		}

		// Token: 0x1700006C RID: 108
		// (get) Token: 0x06000206 RID: 518 RVA: 0x00004E24 File Offset: 0x00003024
		public int pixelWidth
		{
			[FreeFunction("CameraScripting::GetPixelWidth", HasExplicitThis = true)]
			get
			{
				throw new MissingMethodException();
			}
		}

		// Token: 0x1700006D RID: 109
		// (get) Token: 0x06000207 RID: 519 RVA: 0x00004E38 File Offset: 0x00003038
		public int pixelHeight
		{
			[FreeFunction("CameraScripting::GetPixelHeight", HasExplicitThis = true)]
			get
			{
				throw new MissingMethodException();
			}
		}

		// Token: 0x1700006E RID: 110
		// (get) Token: 0x06000208 RID: 520 RVA: 0x00004E4C File Offset: 0x0000304C
		// (set) Token: 0x06000209 RID: 521 RVA: 0x00004E60 File Offset: 0x00003060
		public RenderTexture targetTexture
		{
			get
			{
				throw new MissingMethodException();
			}
			set
			{
				throw new MissingMethodException();
			}
		}

		// Token: 0x1700006F RID: 111
		// (get) Token: 0x0600020A RID: 522 RVA: 0x00004E74 File Offset: 0x00003074
		public int targetDisplay
		{
			get
			{
				throw new MissingMethodException();
			}
		}

		// Token: 0x17000070 RID: 112
		// (set) Token: 0x0600020B RID: 523 RVA: 0x00004E88 File Offset: 0x00003088
		public Matrix4x4 projectionMatrix
		{
			set
			{
				throw new MissingMethodException();
			}
		}

		// Token: 0x0600020C RID: 524 RVA: 0x00004E9C File Offset: 0x0000309C
		public Vector3 WorldToScreenPoint(Vector3 position, Camera.MonoOrStereoscopicEye eye)
		{
			throw new MissingMethodException();
		}

		// Token: 0x0600020D RID: 525 RVA: 0x00004EB0 File Offset: 0x000030B0
		public Vector3 ViewportToWorldPoint(Vector3 position, Camera.MonoOrStereoscopicEye eye)
		{
			throw new MissingMethodException();
		}

		// Token: 0x0600020E RID: 526 RVA: 0x00004EC4 File Offset: 0x000030C4
		public Vector3 ScreenToWorldPoint(Vector3 position, Camera.MonoOrStereoscopicEye eye)
		{
			throw new MissingMethodException();
		}

		// Token: 0x0600020F RID: 527 RVA: 0x00004ED8 File Offset: 0x000030D8
		public Vector3 WorldToScreenPoint(Vector3 position)
		{
			Vector3 vector;
			return vector;
		}

		// Token: 0x06000210 RID: 528 RVA: 0x00004EE8 File Offset: 0x000030E8
		public Vector3 ViewportToWorldPoint(Vector3 position)
		{
			Vector3 vector;
			return vector;
		}

		// Token: 0x06000211 RID: 529 RVA: 0x00004EF8 File Offset: 0x000030F8
		public Vector3 ScreenToWorldPoint(Vector3 position)
		{
			Vector3 vector;
			return vector;
		}

		// Token: 0x06000212 RID: 530 RVA: 0x00004F08 File Offset: 0x00003108
		public Vector3 ScreenToViewportPoint(Vector3 position)
		{
			throw new MissingMethodException();
		}

		// Token: 0x06000213 RID: 531 RVA: 0x00004F1C File Offset: 0x0000311C
		private Ray ScreenPointToRay(Vector2 pos, Camera.MonoOrStereoscopicEye eye)
		{
			throw new MissingMethodException();
		}

		// Token: 0x06000214 RID: 532 RVA: 0x00004F30 File Offset: 0x00003130
		public Ray ScreenPointToRay(Vector3 pos, Camera.MonoOrStereoscopicEye eye)
		{
			Ray ray;
			return ray;
		}

		// Token: 0x06000215 RID: 533 RVA: 0x00004F40 File Offset: 0x00003140
		public Ray ScreenPointToRay(Vector3 pos)
		{
			Ray ray;
			return ray;
		}

		// Token: 0x17000071 RID: 113
		// (get) Token: 0x06000216 RID: 534 RVA: 0x00004F50 File Offset: 0x00003150
		public static Camera main
		{
			[FreeFunction("FindMainCamera")]
			get
			{
				throw new MissingMethodException();
			}
		}

		// Token: 0x17000072 RID: 114
		// (get) Token: 0x06000217 RID: 535 RVA: 0x00004F64 File Offset: 0x00003164
		public static Camera current
		{
			[FreeFunction("GetCurrentCameraPPtr")]
			get
			{
				throw new MissingMethodException();
			}
		}

		// Token: 0x06000218 RID: 536 RVA: 0x00004F78 File Offset: 0x00003178
		[FreeFunction("CameraScripting::GetAllCamerasCount")]
		private static int GetAllCamerasCount()
		{
			throw new MissingMethodException();
		}

		// Token: 0x06000219 RID: 537 RVA: 0x00004F8C File Offset: 0x0000318C
		[FreeFunction("CameraScripting::GetAllCameras")]
		private static int GetAllCamerasImpl([NotNull("ArgumentNullException")] [Out] Camera[] cam)
		{
			throw new MissingMethodException();
		}

		// Token: 0x17000073 RID: 115
		// (get) Token: 0x0600021A RID: 538 RVA: 0x00004FA0 File Offset: 0x000031A0
		public static int allCamerasCount
		{
			get
			{
				throw new MissingMethodException();
			}
		}

		// Token: 0x0600021B RID: 539 RVA: 0x00004FB4 File Offset: 0x000031B4
		public static int GetAllCameras(Camera[] cameras)
		{
			throw new MissingMethodException();
		}

		// Token: 0x0600021C RID: 540 RVA: 0x00004FCC File Offset: 0x000031CC
		[FreeFunction("CameraScripting::Render", HasExplicitThis = true)]
		public void Render()
		{
			throw new MissingMethodException();
		}

		// Token: 0x0600021D RID: 541 RVA: 0x00004FE0 File Offset: 0x000031E0
		[RequiredByNativeCode]
		private static void FireOnPreCull(Camera cam)
		{
		}

		// Token: 0x0600021E RID: 542 RVA: 0x00004FF0 File Offset: 0x000031F0
		[RequiredByNativeCode]
		private static void FireOnPreRender(Camera cam)
		{
		}

		// Token: 0x0600021F RID: 543 RVA: 0x00005000 File Offset: 0x00003200
		[RequiredByNativeCode]
		private static void FireOnPostRender(Camera cam)
		{
		}

		// Token: 0x06000220 RID: 544 RVA: 0x00005010 File Offset: 0x00003210
		private void set_backgroundColor_Injected(Color value)
		{
			throw new MissingMethodException();
		}

		// Token: 0x06000221 RID: 545 RVA: 0x00005024 File Offset: 0x00003224
		private void get_rect_Injected([Out] Rect ret)
		{
			throw new MissingMethodException();
		}

		// Token: 0x06000222 RID: 546 RVA: 0x00005038 File Offset: 0x00003238
		private void set_rect_Injected(Rect value)
		{
			throw new MissingMethodException();
		}

		// Token: 0x06000223 RID: 547 RVA: 0x0000504C File Offset: 0x0000324C
		private void get_pixelRect_Injected([Out] Rect ret)
		{
			throw new MissingMethodException();
		}

		// Token: 0x06000224 RID: 548 RVA: 0x00005060 File Offset: 0x00003260
		private void set_projectionMatrix_Injected(Matrix4x4 value)
		{
			throw new MissingMethodException();
		}

		// Token: 0x06000225 RID: 549 RVA: 0x00005074 File Offset: 0x00003274
		private void WorldToScreenPoint_Injected(Vector3 position, Camera.MonoOrStereoscopicEye eye, [Out] Vector3 ret)
		{
			throw new MissingMethodException();
		}

		// Token: 0x06000226 RID: 550 RVA: 0x00005088 File Offset: 0x00003288
		private void ViewportToWorldPoint_Injected(Vector3 position, Camera.MonoOrStereoscopicEye eye, [Out] Vector3 ret)
		{
			throw new MissingMethodException();
		}

		// Token: 0x06000227 RID: 551 RVA: 0x0000509C File Offset: 0x0000329C
		private void ScreenToWorldPoint_Injected(Vector3 position, Camera.MonoOrStereoscopicEye eye, [Out] Vector3 ret)
		{
			throw new MissingMethodException();
		}

		// Token: 0x06000228 RID: 552 RVA: 0x000050B0 File Offset: 0x000032B0
		private void ScreenToViewportPoint_Injected(Vector3 position, [Out] Vector3 ret)
		{
			throw new MissingMethodException();
		}

		// Token: 0x06000229 RID: 553 RVA: 0x000050C4 File Offset: 0x000032C4
		private void ScreenPointToRay_Injected(Vector2 pos, Camera.MonoOrStereoscopicEye eye, [Out] Ray ret)
		{
			throw new MissingMethodException();
		}

		// Token: 0x040002F1 RID: 753
		public static Camera.CameraCallback onPreCull;

		// Token: 0x040002F2 RID: 754
		public static Camera.CameraCallback onPreRender;

		// Token: 0x040002F3 RID: 755
		public static Camera.CameraCallback onPostRender;

		// Token: 0x0200007E RID: 126
		public enum MonoOrStereoscopicEye
		{
			// Token: 0x040002F5 RID: 757
			Left,
			// Token: 0x040002F6 RID: 758
			Right,
			// Token: 0x040002F7 RID: 759
			Mono
		}

		// Token: 0x0200007F RID: 127
		public enum RenderRequestMode
		{
			// Token: 0x040002F9 RID: 761
			None,
			// Token: 0x040002FA RID: 762
			ObjectId,
			// Token: 0x040002FB RID: 763
			Depth,
			// Token: 0x040002FC RID: 764
			VertexNormal,
			// Token: 0x040002FD RID: 765
			WorldPosition,
			// Token: 0x040002FE RID: 766
			EntityId,
			// Token: 0x040002FF RID: 767
			BaseColor,
			// Token: 0x04000300 RID: 768
			SpecularColor,
			// Token: 0x04000301 RID: 769
			Metallic,
			// Token: 0x04000302 RID: 770
			Emission,
			// Token: 0x04000303 RID: 771
			Normal,
			// Token: 0x04000304 RID: 772
			Smoothness,
			// Token: 0x04000305 RID: 773
			Occlusion,
			// Token: 0x04000306 RID: 774
			DiffuseColor
		}

		// Token: 0x02000080 RID: 128
		public enum RenderRequestOutputSpace
		{
			// Token: 0x04000308 RID: 776
			ScreenSpace = -1,
			// Token: 0x04000309 RID: 777
			UV0,
			// Token: 0x0400030A RID: 778
			UV1,
			// Token: 0x0400030B RID: 779
			UV2,
			// Token: 0x0400030C RID: 780
			UV3,
			// Token: 0x0400030D RID: 781
			UV4,
			// Token: 0x0400030E RID: 782
			UV5,
			// Token: 0x0400030F RID: 783
			UV6,
			// Token: 0x04000310 RID: 784
			UV7,
			// Token: 0x04000311 RID: 785
			UV8
		}

		// Token: 0x02000081 RID: 129
		public struct RenderRequest
		{
			// Token: 0x04000312 RID: 786
			private readonly Camera.RenderRequestMode m_CameraRenderMode;

			// Token: 0x04000313 RID: 787
			private readonly RenderTexture m_ResultRT;

			// Token: 0x04000314 RID: 788
			private readonly Camera.RenderRequestOutputSpace m_OutputSpace;
		}

		// Token: 0x02000082 RID: 130
		public sealed class CameraCallback : MulticastDelegate
		{
			// Token: 0x0600022A RID: 554 RVA: 0x000050D8 File Offset: 0x000032D8
			public CameraCallback(object @object, IntPtr method)
			{
				this.method_ptr = method;
				this.m_target = @object;
				this.method = method;
				this.method_code = this;
			}

			// Token: 0x0600022B RID: 555 RVA: 0x0000512C File Offset: 0x0000332C
			public void Invoke(Camera cam)
			{
				IntPtr method_code = this.method_code;
				IntPtr invoke_impl = this.invoke_impl;
				IntPtr method = this.method;
			}
		}
	}
}
