using System;
using UnityEngine.UI.Collections;

namespace UnityEngine.UI
{
	// Token: 0x02000008 RID: 8
	public class CanvasUpdateRegistry
	{
		// Token: 0x0600001F RID: 31 RVA: 0x000022F0 File Offset: 0x000004F0
		protected CanvasUpdateRegistry()
		{
			if (("CanvasUpdate.Prelayout" == null || "CanvasUpdate.Prelayout" != null) && ("CanvasUpdate.Layout" == null || "CanvasUpdate.Layout" != null) && ("CanvasUpdate.PostLayout" == null || "CanvasUpdate.PostLayout" != null) && ("CanvasUpdate.PreRender" == null || "CanvasUpdate.PreRender" != null) && ("CanvasUpdate.LatePreRender" == null || "CanvasUpdate.LatePreRender" != null))
			{
				base..ctor();
				return;
			}
			throw new ArrayTypeMismatchException();
		}

		// Token: 0x1700000A RID: 10
		// (get) Token: 0x06000020 RID: 32 RVA: 0x00002350 File Offset: 0x00000550
		public static CanvasUpdateRegistry instance
		{
			get
			{
				if (!true)
				{
				}
				if (true || !true)
				{
				}
				if (!true)
				{
				}
				return 1;
			}
		}

		// Token: 0x06000021 RID: 33 RVA: 0x0000236C File Offset: 0x0000056C
		private bool ObjectValidForUpdate(ICanvasElement element)
		{
			if (element != null)
			{
			}
			bool flag;
			return flag;
		}

		// Token: 0x06000022 RID: 34 RVA: 0x00002384 File Offset: 0x00000584
		private void CleanInvalidItems()
		{
			IndexedSet<ICanvasElement> layoutRebuildQueue = this.m_LayoutRebuildQueue;
			int enabledObjectCount = layoutRebuildQueue.m_EnabledObjectCount;
			if (layoutRebuildQueue[43171840] != null)
			{
				return;
			}
			this.m_LayoutRebuildQueue.RemoveAt(43171840);
		}

		// Token: 0x06000023 RID: 35 RVA: 0x00002418 File Offset: 0x00000618
		private void PerformUpdate()
		{
			this.CleanInvalidItems();
			int num = 1;
			this.m_PerformingLayoutUpdate = num != 0;
			IndexedSet<ICanvasElement> layoutRebuildQueue = this.m_LayoutRebuildQueue;
			if (num == 0)
			{
			}
			IndexedSet<ICanvasElement> layoutRebuildQueue2 = this.m_LayoutRebuildQueue;
			int enabledObjectCount = layoutRebuildQueue2.m_EnabledObjectCount;
			long num2 = 0L;
			ICanvasElement canvasElement = layoutRebuildQueue2[(int)num2];
		}

		// Token: 0x06000024 RID: 36 RVA: 0x0000250C File Offset: 0x0000070C
		private static int ParentCount(Transform child)
		{
			if (!true)
			{
			}
			throw new MissingMethodException();
		}

		// Token: 0x06000025 RID: 37 RVA: 0x00002524 File Offset: 0x00000724
		private static int SortLayoutList(ICanvasElement x, ICanvasElement y)
		{
			int num;
			return num;
		}

		// Token: 0x06000026 RID: 38 RVA: 0x00002534 File Offset: 0x00000734
		public static void RegisterCanvasElementForLayoutRebuild(ICanvasElement element)
		{
			if (!true)
			{
			}
			bool flag = CanvasUpdateRegistry.instance.InternalRegisterCanvasElementForLayoutRebuild(element);
		}

		// Token: 0x06000027 RID: 39 RVA: 0x00002550 File Offset: 0x00000750
		public static bool TryRegisterCanvasElementForLayoutRebuild(ICanvasElement element)
		{
			if (!true)
			{
			}
			return CanvasUpdateRegistry.instance.InternalRegisterCanvasElementForLayoutRebuild(element);
		}

		// Token: 0x06000028 RID: 40 RVA: 0x0000256C File Offset: 0x0000076C
		private bool InternalRegisterCanvasElementForLayoutRebuild(ICanvasElement element)
		{
			IndexedSet<ICanvasElement> layoutRebuildQueue = this.m_LayoutRebuildQueue;
			bool flag;
			return flag;
		}

		// Token: 0x06000029 RID: 41 RVA: 0x00002584 File Offset: 0x00000784
		public static void RegisterCanvasElementForGraphicRebuild(ICanvasElement element)
		{
			if (!true)
			{
			}
			bool flag = CanvasUpdateRegistry.instance.InternalRegisterCanvasElementForGraphicRebuild(element);
		}

		// Token: 0x0600002A RID: 42 RVA: 0x000025A0 File Offset: 0x000007A0
		public static bool TryRegisterCanvasElementForGraphicRebuild(ICanvasElement element)
		{
			if (!true)
			{
			}
			return CanvasUpdateRegistry.instance.InternalRegisterCanvasElementForGraphicRebuild(element);
		}

		// Token: 0x0600002B RID: 43 RVA: 0x000025BC File Offset: 0x000007BC
		private bool InternalRegisterCanvasElementForGraphicRebuild(ICanvasElement element)
		{
			if (this.m_PerformingGraphicUpdate)
			{
				string text;
				Debug.LogError(text);
			}
			bool flag;
			return flag;
		}

		// Token: 0x0600002C RID: 44 RVA: 0x000025DC File Offset: 0x000007DC
		public static void UnRegisterCanvasElementForRebuild(ICanvasElement element)
		{
			if (!true)
			{
			}
			CanvasUpdateRegistry instance = CanvasUpdateRegistry.instance;
			CanvasUpdateRegistry instance2 = CanvasUpdateRegistry.instance;
		}

		// Token: 0x0600002D RID: 45 RVA: 0x000025F8 File Offset: 0x000007F8
		public static void DisableCanvasElementForRebuild(ICanvasElement element)
		{
			if (!true)
			{
			}
			CanvasUpdateRegistry.instance.InternalDisableCanvasElementForLayoutRebuild(element);
			CanvasUpdateRegistry.instance.InternalDisableCanvasElementForGraphicRebuild(element);
		}

		// Token: 0x0600002E RID: 46 RVA: 0x00002620 File Offset: 0x00000820
		private void InternalUnRegisterCanvasElementForLayoutRebuild(ICanvasElement element)
		{
			if (this.m_PerformingLayoutUpdate)
			{
				string text;
				Debug.LogError(text);
				return;
			}
		}

		// Token: 0x0600002F RID: 47 RVA: 0x00002648 File Offset: 0x00000848
		private void InternalUnRegisterCanvasElementForGraphicRebuild(ICanvasElement element)
		{
			if (this.m_PerformingGraphicUpdate)
			{
				string text;
				Debug.LogError(text);
				return;
			}
		}

		// Token: 0x06000030 RID: 48 RVA: 0x00002670 File Offset: 0x00000870
		private void InternalDisableCanvasElementForLayoutRebuild(ICanvasElement element)
		{
			if (this.m_PerformingLayoutUpdate)
			{
				string text;
				Debug.LogError(text);
				return;
			}
		}

		// Token: 0x06000031 RID: 49 RVA: 0x00002698 File Offset: 0x00000898
		private void InternalDisableCanvasElementForGraphicRebuild(ICanvasElement element)
		{
			if (this.m_PerformingGraphicUpdate)
			{
				string text;
				Debug.LogError(text);
				return;
			}
		}

		// Token: 0x06000032 RID: 50 RVA: 0x000026C0 File Offset: 0x000008C0
		public static bool IsRebuildingLayout()
		{
			if (!true)
			{
			}
			return CanvasUpdateRegistry.instance.m_PerformingLayoutUpdate;
		}

		// Token: 0x06000033 RID: 51 RVA: 0x000026DC File Offset: 0x000008DC
		public static bool IsRebuildingGraphics()
		{
			if (!true)
			{
			}
			return CanvasUpdateRegistry.instance.m_PerformingGraphicUpdate;
		}

		// Token: 0x06000034 RID: 52 RVA: 0x000026F8 File Offset: 0x000008F8
		// Note: this type is marked as 'beforefieldinit'.
		static CanvasUpdateRegistry()
		{
		}

		// Token: 0x04000018 RID: 24
		private static CanvasUpdateRegistry s_Instance;

		// Token: 0x04000019 RID: 25
		private bool m_PerformingLayoutUpdate;

		// Token: 0x0400001A RID: 26
		private bool m_PerformingGraphicUpdate;

		// Token: 0x0400001B RID: 27
		private string[] m_CanvasUpdateProfilerStrings;

		// Token: 0x0400001C RID: 28
		private const string m_CullingUpdateProfilerString = "ClipperRegistry.Cull";

		// Token: 0x0400001D RID: 29
		private readonly IndexedSet<ICanvasElement> m_LayoutRebuildQueue;

		// Token: 0x0400001E RID: 30
		private readonly IndexedSet<ICanvasElement> m_GraphicRebuildQueue;

		// Token: 0x0400001F RID: 31
		private static readonly Comparison<ICanvasElement> s_SortLayoutFunction;
	}
}
