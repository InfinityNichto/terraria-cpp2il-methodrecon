using System;

namespace UnityEngine.EventSystems
{
	// Token: 0x02000091 RID: 145
	public abstract class AbstractEventData
	{
		// Token: 0x06000585 RID: 1413 RVA: 0x00010F88 File Offset: 0x0000F188
		public virtual void Reset()
		{
		}

		// Token: 0x06000586 RID: 1414 RVA: 0x00010F98 File Offset: 0x0000F198
		public virtual void Use()
		{
			this.m_Used = true;
		}

		// Token: 0x1700016B RID: 363
		// (get) Token: 0x06000587 RID: 1415 RVA: 0x00010FAC File Offset: 0x0000F1AC
		public virtual bool used
		{
			get
			{
				return this.m_Used;
			}
		}

		// Token: 0x06000588 RID: 1416 RVA: 0x00010FC0 File Offset: 0x0000F1C0
		protected AbstractEventData()
		{
		}

		// Token: 0x04000289 RID: 649
		protected bool m_Used;
	}
}
