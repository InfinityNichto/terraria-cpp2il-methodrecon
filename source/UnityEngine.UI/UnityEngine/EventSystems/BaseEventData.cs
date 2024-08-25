using System;

namespace UnityEngine.EventSystems
{
	// Token: 0x02000092 RID: 146
	public class BaseEventData : AbstractEventData
	{
		// Token: 0x06000589 RID: 1417 RVA: 0x00010FD4 File Offset: 0x0000F1D4
		public BaseEventData(EventSystem eventSystem)
		{
			this.m_EventSystem = eventSystem;
		}

		// Token: 0x1700016C RID: 364
		// (get) Token: 0x0600058A RID: 1418 RVA: 0x00010FF0 File Offset: 0x0000F1F0
		public BaseInputModule currentInputModule
		{
			get
			{
				return this.m_EventSystem.m_CurrentInputModule;
			}
		}

		// Token: 0x1700016D RID: 365
		// (get) Token: 0x0600058B RID: 1419 RVA: 0x00011008 File Offset: 0x0000F208
		// (set) Token: 0x0600058C RID: 1420 RVA: 0x00011020 File Offset: 0x0000F220
		public GameObject selectedObject
		{
			get
			{
				return this.m_EventSystem.m_CurrentSelected;
			}
			set
			{
				this.m_EventSystem.SetSelectedGameObject(value, this);
			}
		}

		// Token: 0x0400028A RID: 650
		private readonly EventSystem m_EventSystem;
	}
}
