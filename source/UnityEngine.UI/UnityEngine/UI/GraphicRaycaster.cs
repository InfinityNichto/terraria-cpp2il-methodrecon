using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using UnityEngine.EventSystems;
using UnityEngine.Serialization;

namespace UnityEngine.UI
{
	// Token: 0x0200001D RID: 29
	[RequireComponent(typeof(Canvas))]
	[AddComponentMenu("Event/Graphic Raycaster")]
	public class GraphicRaycaster : BaseRaycaster
	{
		// Token: 0x17000043 RID: 67
		// (get) Token: 0x0600011E RID: 286 RVA: 0x00004808 File Offset: 0x00002A08
		public override int sortOrderPriority
		{
			get
			{
				if (this.canvas.renderMode != RenderMode.ScreenSpaceOverlay)
				{
					return base.sortOrderPriority;
				}
				return this.canvas.sortingOrder;
			}
		}

		// Token: 0x17000044 RID: 68
		// (get) Token: 0x0600011F RID: 287 RVA: 0x00004834 File Offset: 0x00002A34
		public override int renderOrderPriority
		{
			get
			{
				if (this.canvas.renderMode != RenderMode.ScreenSpaceOverlay)
				{
					return base.renderOrderPriority;
				}
				return this.canvas.rootCanvas.renderOrder;
			}
		}

		// Token: 0x17000045 RID: 69
		// (get) Token: 0x06000120 RID: 288 RVA: 0x00004868 File Offset: 0x00002A68
		// (set) Token: 0x06000121 RID: 289 RVA: 0x0000487C File Offset: 0x00002A7C
		public bool ignoreReversedGraphics
		{
			get
			{
				return this.m_IgnoreReversedGraphics;
			}
			set
			{
			}
		}

		// Token: 0x17000046 RID: 70
		// (get) Token: 0x06000122 RID: 290 RVA: 0x0000488C File Offset: 0x00002A8C
		// (set) Token: 0x06000123 RID: 291 RVA: 0x000048A0 File Offset: 0x00002AA0
		public GraphicRaycaster.BlockingObjects blockingObjects
		{
			get
			{
				return this.m_BlockingObjects;
			}
			set
			{
				this.m_BlockingObjects = value;
			}
		}

		// Token: 0x17000047 RID: 71
		// (get) Token: 0x06000124 RID: 292 RVA: 0x000048B4 File Offset: 0x00002AB4
		// (set) Token: 0x06000125 RID: 293 RVA: 0x000048C8 File Offset: 0x00002AC8
		public LayerMask blockingMask
		{
			get
			{
				return this.m_BlockingMask;
			}
			set
			{
				this.m_BlockingMask = value;
			}
		}

		// Token: 0x06000126 RID: 294 RVA: 0x000048DC File Offset: 0x00002ADC
		protected GraphicRaycaster()
		{
			LayerMask layerMask = 0;
			this.m_BlockingMask = layerMask;
			base..ctor();
		}

		// Token: 0x17000048 RID: 72
		// (get) Token: 0x06000127 RID: 295 RVA: 0x00004904 File Offset: 0x00002B04
		private Canvas canvas
		{
			get
			{
				Canvas canvas = this.m_Canvas;
				if (!true)
				{
				}
				return this.m_Canvas;
			}
		}

		// Token: 0x06000128 RID: 296 RVA: 0x00002207 File Offset: 0x00000407
		public override void Raycast(PointerEventData eventData, List<RaycastResult> resultAppendList)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x17000049 RID: 73
		// (get) Token: 0x06000129 RID: 297 RVA: 0x00004934 File Offset: 0x00002B34
		public override Camera eventCamera
		{
			get
			{
				Canvas canvas;
				do
				{
					canvas = this.canvas;
					if (canvas.renderMode == RenderMode.ScreenSpaceOverlay)
					{
						return;
					}
					Camera worldCamera = canvas.worldCamera;
				}
				while (canvas.worldCamera != null);
				return Camera.main;
			}
		}

		// Token: 0x0600012A RID: 298 RVA: 0x00004968 File Offset: 0x00002B68
		private static void Raycast(Canvas canvas, Camera eventCamera, Vector2 pointerPosition, IList<Graphic> foundGraphics, List<Graphic> results)
		{
		}

		// Token: 0x0600012B RID: 299 RVA: 0x000049B4 File Offset: 0x00002BB4
		// Note: this type is marked as 'beforefieldinit'.
		static GraphicRaycaster()
		{
		}

		// Token: 0x0400007F RID: 127
		protected const int kNoEventMaskSet = -1;

		// Token: 0x04000080 RID: 128
		[SerializeField]
		[FormerlySerializedAs("ignoreReversedGraphics")]
		private bool m_IgnoreReversedGraphics = true;

		// Token: 0x04000081 RID: 129
		[SerializeField]
		[FormerlySerializedAs("blockingObjects")]
		private GraphicRaycaster.BlockingObjects m_BlockingObjects;

		// Token: 0x04000082 RID: 130
		[SerializeField]
		protected LayerMask m_BlockingMask;

		// Token: 0x04000083 RID: 131
		private Canvas m_Canvas;

		// Token: 0x04000084 RID: 132
		[NonSerialized]
		private List<Graphic> m_RaycastResults;

		// Token: 0x04000085 RID: 133
		[NonSerialized]
		private static readonly List<Graphic> s_SortedGraphics;

		// Token: 0x0200001E RID: 30
		public enum BlockingObjects
		{
			// Token: 0x04000087 RID: 135
			None,
			// Token: 0x04000088 RID: 136
			TwoD,
			// Token: 0x04000089 RID: 137
			ThreeD,
			// Token: 0x0400008A RID: 138
			All
		}

		// Token: 0x0200001F RID: 31
		[CompilerGenerated]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x0600012C RID: 300 RVA: 0x000049C4 File Offset: 0x00002BC4
			// Note: this type is marked as 'beforefieldinit'.
			static <>c()
			{
			}

			// Token: 0x0600012D RID: 301 RVA: 0x000049D4 File Offset: 0x00002BD4
			public <>c()
			{
			}

			// Token: 0x0600012E RID: 302 RVA: 0x000049E8 File Offset: 0x00002BE8
			internal int <Raycast>b__27_0(Graphic g1, Graphic g2)
			{
				int absoluteDepth = g2.canvasRenderer.absoluteDepth;
				int absoluteDepth2 = g1.canvasRenderer.absoluteDepth;
				return absoluteDepth2.CompareTo(absoluteDepth2);
			}

			// Token: 0x0400008B RID: 139
			public static readonly GraphicRaycaster.<>c <>9;

			// Token: 0x0400008C RID: 140
			public static Comparison<Graphic> <>9__27_0;
		}
	}
}
