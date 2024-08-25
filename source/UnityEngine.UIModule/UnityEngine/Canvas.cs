using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine
{
	// Token: 0x02000005 RID: 5
	[RequireComponent(typeof(RectTransform))]
	[NativeHeader("Modules/UI/Canvas.h")]
	[NativeHeader("Modules/UI/CanvasManager.h")]
	[NativeClass("UI::Canvas")]
	[NativeHeader("Modules/UI/UIStructs.h")]
	public sealed class Canvas : Behaviour
	{
		// Token: 0x14000001 RID: 1
		// (add) Token: 0x0600002F RID: 47 RVA: 0x0000248C File Offset: 0x0000068C
		// (remove) Token: 0x06000030 RID: 48 RVA: 0x000024A4 File Offset: 0x000006A4
		public static event Canvas.WillRenderCanvases preWillRenderCanvases
		{
			[CompilerGenerated]
			add
			{
				Delegate @delegate;
				if (@delegate != null)
				{
				}
			}
			[CompilerGenerated]
			remove
			{
				Delegate @delegate;
				if (@delegate != null)
				{
				}
			}
		}

		// Token: 0x14000002 RID: 2
		// (add) Token: 0x06000031 RID: 49 RVA: 0x000024BC File Offset: 0x000006BC
		// (remove) Token: 0x06000032 RID: 50 RVA: 0x000024D4 File Offset: 0x000006D4
		public static event Canvas.WillRenderCanvases willRenderCanvases
		{
			[CompilerGenerated]
			add
			{
				Delegate @delegate;
				if (@delegate != null)
				{
				}
			}
			[CompilerGenerated]
			remove
			{
				Delegate @delegate;
				if (@delegate != null)
				{
				}
			}
		}

		// Token: 0x17000008 RID: 8
		// (get) Token: 0x06000033 RID: 51 RVA: 0x000024EC File Offset: 0x000006EC
		public RenderMode renderMode
		{
			get
			{
				throw new MissingMethodException();
			}
		}

		// Token: 0x17000009 RID: 9
		// (get) Token: 0x06000034 RID: 52 RVA: 0x00002500 File Offset: 0x00000700
		public bool isRootCanvas
		{
			get
			{
				throw new MissingMethodException();
			}
		}

		// Token: 0x1700000A RID: 10
		// (get) Token: 0x06000035 RID: 53 RVA: 0x00002514 File Offset: 0x00000714
		// (set) Token: 0x06000036 RID: 54 RVA: 0x00002528 File Offset: 0x00000728
		public float scaleFactor
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

		// Token: 0x1700000B RID: 11
		// (get) Token: 0x06000037 RID: 55 RVA: 0x0000253C File Offset: 0x0000073C
		// (set) Token: 0x06000038 RID: 56 RVA: 0x00002550 File Offset: 0x00000750
		public float referencePixelsPerUnit
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

		// Token: 0x1700000C RID: 12
		// (get) Token: 0x06000039 RID: 57 RVA: 0x00002564 File Offset: 0x00000764
		public bool pixelPerfect
		{
			get
			{
				throw new MissingMethodException();
			}
		}

		// Token: 0x1700000D RID: 13
		// (get) Token: 0x0600003A RID: 58 RVA: 0x00002578 File Offset: 0x00000778
		public int renderOrder
		{
			get
			{
				throw new MissingMethodException();
			}
		}

		// Token: 0x1700000E RID: 14
		// (get) Token: 0x0600003B RID: 59 RVA: 0x0000258C File Offset: 0x0000078C
		// (set) Token: 0x0600003C RID: 60 RVA: 0x000025A0 File Offset: 0x000007A0
		public bool overrideSorting
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

		// Token: 0x1700000F RID: 15
		// (get) Token: 0x0600003D RID: 61 RVA: 0x000025B4 File Offset: 0x000007B4
		// (set) Token: 0x0600003E RID: 62 RVA: 0x000025C8 File Offset: 0x000007C8
		public int sortingOrder
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

		// Token: 0x17000010 RID: 16
		// (get) Token: 0x0600003F RID: 63 RVA: 0x000025DC File Offset: 0x000007DC
		public int targetDisplay
		{
			get
			{
				throw new MissingMethodException();
			}
		}

		// Token: 0x17000011 RID: 17
		// (get) Token: 0x06000040 RID: 64 RVA: 0x000025F0 File Offset: 0x000007F0
		// (set) Token: 0x06000041 RID: 65 RVA: 0x00002604 File Offset: 0x00000804
		public int sortingLayerID
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

		// Token: 0x17000012 RID: 18
		// (get) Token: 0x06000042 RID: 66 RVA: 0x00002618 File Offset: 0x00000818
		public Canvas rootCanvas
		{
			get
			{
				throw new MissingMethodException();
			}
		}

		// Token: 0x17000013 RID: 19
		// (get) Token: 0x06000043 RID: 67 RVA: 0x0000262C File Offset: 0x0000082C
		public Vector2 renderingDisplaySize
		{
			get
			{
				throw new MissingMethodException();
			}
		}

		// Token: 0x17000014 RID: 20
		// (get) Token: 0x06000044 RID: 68 RVA: 0x0000263E File Offset: 0x0000083E
		internal static Action<int> externBeginRenderOverlays
		{
			[CompilerGenerated]
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		// Token: 0x17000015 RID: 21
		// (get) Token: 0x06000045 RID: 69 RVA: 0x0000263E File Offset: 0x0000083E
		internal static Action<int, int> externRenderOverlaysBefore
		{
			[CompilerGenerated]
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		// Token: 0x17000016 RID: 22
		// (get) Token: 0x06000046 RID: 70 RVA: 0x0000263E File Offset: 0x0000083E
		internal static Action<int> externEndRenderOverlays
		{
			[CompilerGenerated]
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		// Token: 0x17000017 RID: 23
		// (get) Token: 0x06000047 RID: 71 RVA: 0x0000264C File Offset: 0x0000084C
		[NativeProperty("Camera", false, TargetType.Function)]
		public Camera worldCamera
		{
			get
			{
				throw new MissingMethodException();
			}
		}

		// Token: 0x06000048 RID: 72 RVA: 0x00002660 File Offset: 0x00000860
		[FreeFunction("UI::GetDefaultUIMaterial")]
		public static Material GetDefaultCanvasMaterial()
		{
			throw new MissingMethodException();
		}

		// Token: 0x06000049 RID: 73 RVA: 0x00002674 File Offset: 0x00000874
		[FreeFunction("UI::GetETC1SupportedCanvasMaterial")]
		public static Material GetETC1SupportedCanvasMaterial()
		{
			throw new MissingMethodException();
		}

		// Token: 0x0600004A RID: 74 RVA: 0x00002688 File Offset: 0x00000888
		public static void ForceUpdateCanvases()
		{
			Canvas.SendPreWillRenderCanvases();
			Canvas.SendWillRenderCanvases();
		}

		// Token: 0x0600004B RID: 75 RVA: 0x000026A0 File Offset: 0x000008A0
		[RequiredByNativeCode]
		private static void SendPreWillRenderCanvases()
		{
		}

		// Token: 0x0600004C RID: 76 RVA: 0x000026B0 File Offset: 0x000008B0
		[RequiredByNativeCode]
		private static void SendWillRenderCanvases()
		{
		}

		// Token: 0x0600004D RID: 77 RVA: 0x000026C0 File Offset: 0x000008C0
		[RequiredByNativeCode]
		private static void BeginRenderExtraOverlays(int displayIndex)
		{
		}

		// Token: 0x0600004E RID: 78 RVA: 0x000026D0 File Offset: 0x000008D0
		[RequiredByNativeCode]
		private static void RenderExtraOverlaysBefore(int displayIndex, int sortingOrder)
		{
		}

		// Token: 0x0600004F RID: 79 RVA: 0x000026E0 File Offset: 0x000008E0
		[RequiredByNativeCode]
		private static void EndRenderExtraOverlays(int displayIndex)
		{
		}

		// Token: 0x06000050 RID: 80 RVA: 0x000026F0 File Offset: 0x000008F0
		public Canvas()
		{
		}

		// Token: 0x06000051 RID: 81 RVA: 0x00002704 File Offset: 0x00000904
		private void get_renderingDisplaySize_Injected([Out] Vector2 ret)
		{
			throw new MissingMethodException();
		}

		// Token: 0x04000007 RID: 7
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private static Canvas.WillRenderCanvases preWillRenderCanvases;

		// Token: 0x04000008 RID: 8
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private static Canvas.WillRenderCanvases willRenderCanvases;

		// Token: 0x04000009 RID: 9
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private static Action<int> <externBeginRenderOverlays>k__BackingField;

		// Token: 0x0400000A RID: 10
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		private static Action<int, int> <externRenderOverlaysBefore>k__BackingField;

		// Token: 0x0400000B RID: 11
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private static Action<int> <externEndRenderOverlays>k__BackingField;

		// Token: 0x02000006 RID: 6
		public sealed class WillRenderCanvases : MulticastDelegate
		{
			// Token: 0x06000052 RID: 82 RVA: 0x00002718 File Offset: 0x00000918
			public WillRenderCanvases(object @object, IntPtr method)
			{
				this.method_ptr = method;
				this.m_target = @object;
				this.method = method;
				this.method_code = this;
			}

			// Token: 0x06000053 RID: 83 RVA: 0x00002764 File Offset: 0x00000964
			public void Invoke()
			{
				IntPtr method_code = this.method_code;
				IntPtr invoke_impl = this.invoke_impl;
				IntPtr method = this.method;
			}
		}
	}
}
