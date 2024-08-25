using System;

namespace Terraria.GameInput
{
	// Token: 0x020006D0 RID: 1744
	public class TriggersPack
	{
		// Token: 0x060039FF RID: 14847 RVA: 0x0022F9FC File Offset: 0x0022DBFC
		public void Initialize()
		{
			bool[] keyStatus = this.Current.KeyStatus;
			bool[] keyStatus2 = this.Old.KeyStatus;
			bool[] keyStatus3 = this.JustPressed.KeyStatus;
			bool[] keyStatus4 = this.JustReleased.KeyStatus;
		}

		// Token: 0x06003A00 RID: 14848 RVA: 0x0022FA3C File Offset: 0x0022DC3C
		public void Reset()
		{
			TriggersSet current = this.Current;
			TriggersSet old = this.Old;
			current.Clone(old);
			bool[] keyStatus = this.Current.KeyStatus;
		}

		// Token: 0x06003A01 RID: 14849 RVA: 0x0022FA6C File Offset: 0x0022DC6C
		public void Update()
		{
			TriggersSet old = this.Old;
			TriggersSet justPressed = this.JustPressed;
			TriggersSet current = this.Current;
			this.CompareDiffs(justPressed, old, current);
			TriggersSet justReleased = this.JustReleased;
			TriggersSet current2 = this.Current;
			TriggersSet old2 = this.Old;
			this.CompareDiffs(justReleased, current2, old2);
		}

		// Token: 0x06003A02 RID: 14850 RVA: 0x0022FABC File Offset: 0x0022DCBC
		public void CompareDiffs(TriggersSet Bearer, TriggersSet oldset, TriggersSet newset)
		{
			bool[] keyStatus = Bearer.KeyStatus;
			bool[] keyStatus2 = newset.KeyStatus;
			bool[] keyStatus3 = oldset.KeyStatus;
		}

		// Token: 0x06003A03 RID: 14851 RVA: 0x0022FAE0 File Offset: 0x0022DCE0
		public TriggersPack()
		{
		}

		// Token: 0x04007A6C RID: 31340
		public TriggersSet Current;

		// Token: 0x04007A6D RID: 31341
		public TriggersSet Old;

		// Token: 0x04007A6E RID: 31342
		public TriggersSet JustPressed;

		// Token: 0x04007A6F RID: 31343
		public TriggersSet JustReleased;
	}
}
