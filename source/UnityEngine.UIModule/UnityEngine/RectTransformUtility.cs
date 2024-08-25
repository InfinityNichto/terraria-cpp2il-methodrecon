using System;
using System.Runtime.InteropServices;
using UnityEngine.Bindings;

namespace UnityEngine
{
	// Token: 0x02000002 RID: 2
	[NativeHeader("Modules/UI/RectTransformUtil.h")]
	[NativeHeader("Runtime/Transform/RectTransform.h")]
	[StaticAccessor("UI", StaticAccessorType.DoubleColon)]
	[NativeHeader("Runtime/Camera/Camera.h")]
	[NativeHeader("Modules/UI/Canvas.h")]
	public sealed class RectTransformUtility
	{
		// Token: 0x06000001 RID: 1 RVA: 0x00002050 File Offset: 0x00000250
		public static Vector2 PixelAdjustPoint(Vector2 point, Transform elementTransform, Canvas canvas)
		{
			if (!true)
			{
			}
			throw new MissingMethodException();
		}

		// Token: 0x06000002 RID: 2 RVA: 0x00002068 File Offset: 0x00000268
		public static Rect PixelAdjustRect(RectTransform rectTransform, Canvas canvas)
		{
			if (!true)
			{
			}
			throw new MissingMethodException();
		}

		// Token: 0x06000003 RID: 3 RVA: 0x00002080 File Offset: 0x00000280
		private static bool PointInRectangle(Vector2 screenPoint, RectTransform rect, Camera cam, Vector4 offset)
		{
			if (!true)
			{
			}
			throw new MissingMethodException();
		}

		// Token: 0x06000004 RID: 4 RVA: 0x00002098 File Offset: 0x00000298
		public static bool RectangleContainsScreenPoint(RectTransform rect, Vector2 screenPoint, Camera cam)
		{
			bool flag;
			return flag;
		}

		// Token: 0x06000005 RID: 5 RVA: 0x000020A8 File Offset: 0x000002A8
		public static bool RectangleContainsScreenPoint(RectTransform rect, Vector2 screenPoint, Camera cam, Vector4 offset)
		{
			if (!true)
			{
			}
			bool flag;
			return flag;
		}

		// Token: 0x06000006 RID: 6 RVA: 0x000020BC File Offset: 0x000002BC
		public static bool ScreenPointToWorldPointInRectangle(RectTransform rect, Vector2 screenPoint, Camera cam, [Out] Vector3 worldPoint)
		{
			return true;
		}

		// Token: 0x06000007 RID: 7 RVA: 0x000020D0 File Offset: 0x000002D0
		public static bool ScreenPointToLocalPointInRectangle(RectTransform rect, Vector2 screenPoint, Camera cam, [Out] Vector2 localPoint)
		{
			return true;
		}

		// Token: 0x06000008 RID: 8 RVA: 0x000020E0 File Offset: 0x000002E0
		public static Ray ScreenPointToRay(Camera cam, Vector2 screenPos)
		{
			if (!true)
			{
			}
			Ray ray;
			return ray;
		}

		// Token: 0x06000009 RID: 9 RVA: 0x000020F4 File Offset: 0x000002F4
		public static Vector2 WorldToScreenPoint(Camera cam, Vector3 worldPoint)
		{
			if (!true)
			{
			}
			return 1;
		}

		// Token: 0x0600000A RID: 10 RVA: 0x00002108 File Offset: 0x00000308
		public static void FlipLayoutOnAxis(RectTransform rect, int axis, bool keepPositioning, bool recursive)
		{
			if (!true)
			{
			}
			int childCount = rect.childCount;
			long num = 0L;
			if (rect.GetChild((int)num) != null)
			{
				return;
			}
			int childCount2 = rect.childCount;
			Vector2 pivot = rect.pivot;
			if (axis != 0)
			{
				return;
			}
		}

		// Token: 0x0600000B RID: 11 RVA: 0x00002164 File Offset: 0x00000364
		public static void FlipLayoutAxes(RectTransform rect, bool keepPositioning, bool recursive)
		{
			if (!true)
			{
			}
			int childCount = rect.childCount;
			long num = 0L;
			if (rect.GetChild((int)num) != null)
			{
				return;
			}
			int childCount2 = rect.childCount;
			Vector2 pivot = rect.pivot;
			Vector2 sizeDelta = rect.sizeDelta;
		}

		// Token: 0x0600000C RID: 12 RVA: 0x000021BC File Offset: 0x000003BC
		private static Vector2 GetTransposed(Vector2 input)
		{
			Vector2 vector;
			return vector;
		}

		// Token: 0x0600000D RID: 13 RVA: 0x000021CC File Offset: 0x000003CC
		// Note: this type is marked as 'beforefieldinit'.
		static RectTransformUtility()
		{
		}

		// Token: 0x0600000E RID: 14 RVA: 0x000021DC File Offset: 0x000003DC
		private static void PixelAdjustPoint_Injected(Vector2 point, Transform elementTransform, Canvas canvas, [Out] Vector2 ret)
		{
			throw new MissingMethodException();
		}

		// Token: 0x0600000F RID: 15 RVA: 0x000021F0 File Offset: 0x000003F0
		private static void PixelAdjustRect_Injected(RectTransform rectTransform, Canvas canvas, [Out] Rect ret)
		{
			throw new MissingMethodException();
		}

		// Token: 0x06000010 RID: 16 RVA: 0x00002204 File Offset: 0x00000404
		private static bool PointInRectangle_Injected(Vector2 screenPoint, RectTransform rect, Camera cam, Vector4 offset)
		{
			throw new MissingMethodException();
		}

		// Token: 0x04000001 RID: 1
		private static readonly Vector3[] s_Corners;
	}
}
