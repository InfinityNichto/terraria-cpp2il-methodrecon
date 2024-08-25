using System;
using UnityEngine;

namespace InControl
{
	// Token: 0x0200004D RID: 77
	public abstract class TouchControl : MonoBehaviour
	{
		// Token: 0x060003B9 RID: 953
		public abstract void CreateControl();

		// Token: 0x060003BA RID: 954
		public abstract void DestroyControl();

		// Token: 0x060003BB RID: 955
		public abstract void ConfigureControl();

		// Token: 0x060003BC RID: 956
		public abstract void SubmitControlState(ulong updateTick, float deltaTime);

		// Token: 0x060003BD RID: 957
		public abstract void CommitControlState(ulong updateTick, float deltaTime);

		// Token: 0x060003BE RID: 958
		public abstract void TouchBegan(Touch touch);

		// Token: 0x060003BF RID: 959
		public abstract void TouchMoved(Touch touch);

		// Token: 0x060003C0 RID: 960
		public abstract void TouchEnded(Touch touch);

		// Token: 0x060003C1 RID: 961
		public abstract void DrawGizmos();

		// Token: 0x060003C2 RID: 962 RVA: 0x0000C930 File Offset: 0x0000AB30
		private void OnEnable()
		{
		}

		// Token: 0x060003C3 RID: 963 RVA: 0x0000C940 File Offset: 0x0000AB40
		private void OnDisable()
		{
			AsyncOperation asyncOperation = Resources.UnloadUnusedAssets();
		}

		// Token: 0x060003C4 RID: 964 RVA: 0x0000C958 File Offset: 0x0000AB58
		private void Setup()
		{
			bool enabled = base.enabled;
		}

		// Token: 0x060003C5 RID: 965 RVA: 0x0000C970 File Offset: 0x0000AB70
		protected Vector3 OffsetToWorldPosition(TouchControlAnchor anchor, Vector2 offset, TouchUnitType offsetUnitType, bool lockAspectRatio)
		{
			float pixelToWorld = TouchManager.PixelToWorld;
			Vector3 vector;
			return vector;
		}

		// Token: 0x060003C6 RID: 966 RVA: 0x0000C9A4 File Offset: 0x0000ABA4
		protected void SubmitButtonState(TouchControl.ButtonTarget target, bool state, ulong updateTick, float deltaTime)
		{
			InputDevice device = TouchManager.Device;
			if (target != TouchControl.ButtonTarget.None && device != null)
			{
				InputDevice device2 = TouchManager.Device;
				InputControl inputControl;
				if (inputControl != null)
				{
					if (!true)
					{
					}
					return;
				}
			}
		}

		// Token: 0x060003C7 RID: 967 RVA: 0x0000C9CC File Offset: 0x0000ABCC
		protected void SubmitButtonValue(TouchControl.ButtonTarget target, float value, ulong updateTick, float deltaTime)
		{
			InputDevice device = TouchManager.Device;
			if (target != TouchControl.ButtonTarget.None && device != null)
			{
				InputDevice device2 = TouchManager.Device;
				InputControl inputControl;
				if (inputControl != null)
				{
					if (!true)
					{
					}
					bool flag = inputControl.UpdateWithValue(value, updateTick, deltaTime);
					return;
				}
			}
		}

		// Token: 0x060003C8 RID: 968 RVA: 0x0000CA00 File Offset: 0x0000AC00
		protected void CommitButton(TouchControl.ButtonTarget target)
		{
			InputDevice device = TouchManager.Device;
			if (target != TouchControl.ButtonTarget.None && device != null)
			{
				InputDevice device2 = TouchManager.Device;
				InputControl inputControl;
				if (inputControl != null)
				{
					if (!true)
					{
					}
					inputControl.Commit();
					return;
				}
			}
		}

		// Token: 0x060003C9 RID: 969 RVA: 0x0000CA2C File Offset: 0x0000AC2C
		protected void SubmitAnalogValue(TouchControl.AnalogTarget target, Vector2 value, float lowerDeadZone, float upperDeadZone, ulong updateTick, float deltaTime)
		{
			InputDevice device = TouchManager.Device;
			if (target == TouchControl.AnalogTarget.None || device != null)
			{
			}
		}

		// Token: 0x060003CA RID: 970 RVA: 0x0000CA70 File Offset: 0x0000AC70
		protected void CommitAnalog(TouchControl.AnalogTarget target)
		{
			InputDevice device = TouchManager.Device;
			if (target != TouchControl.AnalogTarget.None && device != null)
			{
				TouchManager.Device.CommitLeftStick();
				TouchManager.Device.CommitRightStick();
				return;
			}
		}

		// Token: 0x060003CB RID: 971 RVA: 0x0000CAA0 File Offset: 0x0000ACA0
		protected void SubmitRawAnalogValue(TouchControl.AnalogTarget target, Vector2 rawValue, ulong updateTick, float deltaTime)
		{
			InputDevice device = TouchManager.Device;
			if (target != TouchControl.AnalogTarget.None && device != null)
			{
				InputDevice device2 = TouchManager.Device;
				long num = 0L;
				device2.UpdateLeftStickWithRawValue(rawValue, (ulong)num, deltaTime);
				InputDevice device3 = TouchManager.Device;
				long num2 = 0L;
				device3.UpdateRightStickWithRawValue(rawValue, (ulong)num2, deltaTime);
				return;
			}
		}

		// Token: 0x060003CC RID: 972 RVA: 0x0000CAE0 File Offset: 0x0000ACE0
		protected static Vector3 SnapTo(Vector2 vector, TouchControl.SnapAngles snapAngles)
		{
			if (vector != null)
			{
				return 17332;
			}
			return 17332;
		}

		// Token: 0x060003CD RID: 973 RVA: 0x0000CAFC File Offset: 0x0000ACFC
		protected static Vector3 SnapTo(Vector2 vector, float snapAngle)
		{
			if (!true)
			{
			}
			if (!true)
			{
			}
			return 1;
		}

		// Token: 0x060003CE RID: 974 RVA: 0x0000CB20 File Offset: 0x0000AD20
		private void OnDrawGizmosSelected()
		{
			bool enabled = base.enabled;
			TouchManager.GizmoShowOption controlsShowGizmos = TouchManager.ControlsShowGizmos;
			bool flag = Utility.GameObjectIsCulledOnCurrentCamera(base.gameObject);
		}

		// Token: 0x060003CF RID: 975 RVA: 0x0000CB50 File Offset: 0x0000AD50
		private void OnDrawGizmos()
		{
			bool enabled = base.enabled;
			TouchManager.GizmoShowOption controlsShowGizmos = TouchManager.ControlsShowGizmos;
			bool isPlaying = Application.isPlaying;
		}

		// Token: 0x060003D0 RID: 976 RVA: 0x0000CB94 File Offset: 0x0000AD94
		protected TouchControl()
		{
		}

		// Token: 0x0200004E RID: 78
		public enum ButtonTarget
		{
			// Token: 0x04000357 RID: 855
			None,
			// Token: 0x04000358 RID: 856
			DPadDown = 12,
			// Token: 0x04000359 RID: 857
			DPadLeft,
			// Token: 0x0400035A RID: 858
			DPadRight,
			// Token: 0x0400035B RID: 859
			DPadUp = 11,
			// Token: 0x0400035C RID: 860
			LeftTrigger = 15,
			// Token: 0x0400035D RID: 861
			RightTrigger,
			// Token: 0x0400035E RID: 862
			LeftBumper,
			// Token: 0x0400035F RID: 863
			RightBumper,
			// Token: 0x04000360 RID: 864
			Action1,
			// Token: 0x04000361 RID: 865
			Action2,
			// Token: 0x04000362 RID: 866
			Action3,
			// Token: 0x04000363 RID: 867
			Action4,
			// Token: 0x04000364 RID: 868
			Action5,
			// Token: 0x04000365 RID: 869
			Action6,
			// Token: 0x04000366 RID: 870
			Action7,
			// Token: 0x04000367 RID: 871
			Action8,
			// Token: 0x04000368 RID: 872
			Action9,
			// Token: 0x04000369 RID: 873
			Action10,
			// Token: 0x0400036A RID: 874
			Action11,
			// Token: 0x0400036B RID: 875
			Action12,
			// Token: 0x0400036C RID: 876
			Menu = 106,
			// Token: 0x0400036D RID: 877
			Button0 = 500,
			// Token: 0x0400036E RID: 878
			Button1,
			// Token: 0x0400036F RID: 879
			Button2,
			// Token: 0x04000370 RID: 880
			Button3,
			// Token: 0x04000371 RID: 881
			Button4,
			// Token: 0x04000372 RID: 882
			Button5,
			// Token: 0x04000373 RID: 883
			Button6,
			// Token: 0x04000374 RID: 884
			Button7,
			// Token: 0x04000375 RID: 885
			Button8,
			// Token: 0x04000376 RID: 886
			Button9,
			// Token: 0x04000377 RID: 887
			Button10,
			// Token: 0x04000378 RID: 888
			Button11,
			// Token: 0x04000379 RID: 889
			Button12,
			// Token: 0x0400037A RID: 890
			Button13,
			// Token: 0x0400037B RID: 891
			Button14,
			// Token: 0x0400037C RID: 892
			Button15,
			// Token: 0x0400037D RID: 893
			Button16,
			// Token: 0x0400037E RID: 894
			Button17,
			// Token: 0x0400037F RID: 895
			Button18,
			// Token: 0x04000380 RID: 896
			Button19
		}

		// Token: 0x0200004F RID: 79
		public enum AnalogTarget
		{
			// Token: 0x04000382 RID: 898
			None,
			// Token: 0x04000383 RID: 899
			LeftStick,
			// Token: 0x04000384 RID: 900
			RightStick,
			// Token: 0x04000385 RID: 901
			Both
		}

		// Token: 0x02000050 RID: 80
		public enum SnapAngles
		{
			// Token: 0x04000387 RID: 903
			None,
			// Token: 0x04000388 RID: 904
			Four = 4,
			// Token: 0x04000389 RID: 905
			Eight = 8,
			// Token: 0x0400038A RID: 906
			Sixteen = 16
		}
	}
}
