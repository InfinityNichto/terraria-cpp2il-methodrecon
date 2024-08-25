using System;
using System.Runtime.InteropServices;

namespace System
{
	// Token: 0x02000142 RID: 322
	[ComVisible(true)]
	public sealed class LocalDataStoreSlot
	{
		// Token: 0x06000CBA RID: 3258 RVA: 0x0001BB10 File Offset: 0x00019D10
		internal LocalDataStoreSlot(LocalDataStoreMgr mgr, int slot, long cookie)
		{
			this.m_mgr = mgr;
			this.m_slot = slot;
			this.m_cookie = cookie;
		}

		// Token: 0x1700011B RID: 283
		// (get) Token: 0x06000CBB RID: 3259 RVA: 0x0001BB38 File Offset: 0x00019D38
		internal LocalDataStoreMgr Manager
		{
			get
			{
				return this.m_mgr;
			}
		}

		// Token: 0x1700011C RID: 284
		// (get) Token: 0x06000CBC RID: 3260 RVA: 0x0001BB4C File Offset: 0x00019D4C
		internal int Slot
		{
			get
			{
				return this.m_slot;
			}
		}

		// Token: 0x1700011D RID: 285
		// (get) Token: 0x06000CBD RID: 3261 RVA: 0x0001BB60 File Offset: 0x00019D60
		internal long Cookie
		{
			get
			{
				return this.m_cookie;
			}
		}

		// Token: 0x06000CBE RID: 3262 RVA: 0x0001BB74 File Offset: 0x00019D74
		protected override void Finalize()
		{
			LocalDataStoreMgr mgr = this.m_mgr;
			if (mgr != null)
			{
				int slot = this.m_slot;
				long cookie = this.m_cookie;
				mgr.FreeDataSlot(slot, cookie);
			}
			base.Finalize();
		}

		// Token: 0x040004EC RID: 1260
		private LocalDataStoreMgr m_mgr;

		// Token: 0x040004ED RID: 1261
		private int m_slot;

		// Token: 0x040004EE RID: 1262
		private long m_cookie;
	}
}
