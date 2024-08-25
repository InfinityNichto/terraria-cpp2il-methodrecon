using System;
using System.Collections.Generic;
using UnityEngine.Scripting;

namespace UnityEngine
{
	// Token: 0x02000009 RID: 9
	internal class SendMouseEvents
	{
		// Token: 0x06000031 RID: 49 RVA: 0x00002428 File Offset: 0x00000628
		private static void UpdateMouse()
		{
			if (!true)
			{
			}
		}

		// Token: 0x06000032 RID: 50 RVA: 0x00002454 File Offset: 0x00000654
		[RequiredByNativeCode]
		private static void SetMouseMoved()
		{
			if (!true)
			{
			}
		}

		// Token: 0x06000033 RID: 51 RVA: 0x00002464 File Offset: 0x00000664
		[RequiredByNativeCode]
		private static void DoSendMouseEvents(int skipRTCameras)
		{
			if (!true)
			{
			}
			SendMouseEvents.UpdateMouse();
			int allCamerasCount = Camera.allCamerasCount;
		}

		// Token: 0x06000034 RID: 52 RVA: 0x000024D4 File Offset: 0x000006D4
		private static void SendEvents(int i, SendMouseEvents.HitInfo hit)
		{
			int num = 1;
			if (num == 0)
			{
			}
			bool flag = hit;
			if (num == 0)
			{
			}
		}

		// Token: 0x06000035 RID: 53 RVA: 0x00002520 File Offset: 0x00000720
		// Note: this type is marked as 'beforefieldinit'.
		static SendMouseEvents()
		{
		}

		// Token: 0x04000025 RID: 37
		private static bool s_MouseUsed;

		// Token: 0x04000026 RID: 38
		private static readonly SendMouseEvents.HitInfo[] m_LastHit;

		// Token: 0x04000027 RID: 39
		private static readonly SendMouseEvents.HitInfo[] m_MouseDownHit;

		// Token: 0x04000028 RID: 40
		private static readonly SendMouseEvents.HitInfo[] m_CurrentHit;

		// Token: 0x04000029 RID: 41
		private static Camera[] m_Cameras;

		// Token: 0x0400002A RID: 42
		public static Func<KeyValuePair<int, Vector2>> s_GetMouseState;

		// Token: 0x0400002B RID: 43
		private static Vector2 s_MousePosition;

		// Token: 0x0400002C RID: 44
		private static bool s_MouseButtonPressedThisFrame;

		// Token: 0x0400002D RID: 45
		private static bool s_MouseButtonIsPressed;

		// Token: 0x0200000A RID: 10
		private struct HitInfo
		{
			// Token: 0x06000036 RID: 54 RVA: 0x0000253C File Offset: 0x0000073C
			public void SendMessage(string name)
			{
			}

			// Token: 0x06000037 RID: 55 RVA: 0x0000254C File Offset: 0x0000074C
			public static implicit operator bool(SendMouseEvents.HitInfo exists)
			{
				if (!true)
				{
				}
				if (!true)
				{
				}
				bool flag;
				return flag;
			}

			// Token: 0x06000038 RID: 56 RVA: 0x00002564 File Offset: 0x00000764
			public static bool Compare(SendMouseEvents.HitInfo lhs, SendMouseEvents.HitInfo rhs)
			{
				if (!true)
				{
				}
				if (!true)
				{
				}
				bool flag;
				return flag;
			}

			// Token: 0x0400002E RID: 46
			public GameObject target;

			// Token: 0x0400002F RID: 47
			public Camera camera;
		}
	}
}
