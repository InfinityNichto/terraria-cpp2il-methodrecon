using System;
using System.Runtime.CompilerServices;

namespace UnityEngine.EventSystems
{
	// Token: 0x02000090 RID: 144
	public class AxisEventData : BaseEventData
	{
		// Token: 0x17000169 RID: 361
		// (get) Token: 0x06000580 RID: 1408 RVA: 0x00010F04 File Offset: 0x0000F104
		// (set) Token: 0x06000581 RID: 1409 RVA: 0x00010F2C File Offset: 0x0000F12C
		public Vector2 moveVector
		{
			[CompilerGenerated]
			get
			{
				float x = this.<moveVector>k__BackingField.x;
				float y = this.<moveVector>k__BackingField.y;
				Vector2 vector;
				return vector;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700016A RID: 362
		// (get) Token: 0x06000582 RID: 1410 RVA: 0x00010F3C File Offset: 0x0000F13C
		// (set) Token: 0x06000583 RID: 1411 RVA: 0x00010F50 File Offset: 0x0000F150
		public MoveDirection moveDir
		{
			[CompilerGenerated]
			get
			{
				return this.<moveDir>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<moveDir>k__BackingField = value;
			}
		}

		// Token: 0x06000584 RID: 1412 RVA: 0x00010F64 File Offset: 0x0000F164
		public AxisEventData(EventSystem eventSystem)
		{
			this.m_EventSystem = eventSystem;
			this.moveDir = MoveDirection.None;
		}

		// Token: 0x04000287 RID: 647
		[CompilerGenerated]
		private Vector2 <moveVector>k__BackingField;

		// Token: 0x04000288 RID: 648
		[CompilerGenerated]
		private MoveDirection <moveDir>k__BackingField;
	}
}
