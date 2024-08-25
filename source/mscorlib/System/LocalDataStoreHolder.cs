using System;

namespace System
{
	// Token: 0x0200013F RID: 319
	internal sealed class LocalDataStoreHolder
	{
		// Token: 0x06000CAD RID: 3245 RVA: 0x0001B8DC File Offset: 0x00019ADC
		public LocalDataStoreHolder(LocalDataStore store)
		{
			this.m_Store = store;
		}

		// Token: 0x06000CAE RID: 3246 RVA: 0x0001B8F8 File Offset: 0x00019AF8
		protected override void Finalize()
		{
			LocalDataStore store = this.m_Store;
			if (store != null)
			{
				store.m_Manager.DeleteLocalDataStore(store);
			}
			base.Finalize();
		}

		// Token: 0x17000118 RID: 280
		// (get) Token: 0x06000CAF RID: 3247 RVA: 0x0001B944 File Offset: 0x00019B44
		public LocalDataStore Store
		{
			get
			{
				return this.m_Store;
			}
		}

		// Token: 0x040004E7 RID: 1255
		private LocalDataStore m_Store;
	}
}
