using System;
using Mono.Security.X509;

namespace System.Security.Cryptography.X509Certificates
{
	// Token: 0x0200011C RID: 284
	public sealed class X509Store : IDisposable
	{
		// Token: 0x060006B8 RID: 1720 RVA: 0x00018A30 File Offset: 0x00016C30
		public X509Store(StoreName storeName, StoreLocation storeLocation)
		{
			this._name = "CA";
		}

		// Token: 0x17000174 RID: 372
		// (get) Token: 0x060006B9 RID: 1721 RVA: 0x00018A60 File Offset: 0x00016C60
		public X509Certificate2Collection Certificates
		{
			get
			{
				X509Certificate2Collection x509Certificate2Collection;
				do
				{
					x509Certificate2Collection = this.list;
				}
				while (x509Certificate2Collection == null || this.store != null);
				x509Certificate2Collection.Clear();
				X509Certificate2Collection x509Certificate2Collection2 = this.list;
				return x509Certificate2Collection;
			}
		}

		// Token: 0x17000175 RID: 373
		// (get) Token: 0x060006BA RID: 1722 RVA: 0x00018A90 File Offset: 0x00016C90
		private X509Stores Factory
		{
			get
			{
				StoreLocation location = this._location;
				return X509StoreManager.CurrentUser;
			}
		}

		// Token: 0x17000176 RID: 374
		// (get) Token: 0x060006BB RID: 1723 RVA: 0x00018AB4 File Offset: 0x00016CB4
		internal X509Store Store
		{
			get
			{
				return this.store;
			}
		}

		// Token: 0x060006BC RID: 1724 RVA: 0x00018AC8 File Offset: 0x00016CC8
		public void Close()
		{
			X509Certificate2Collection x509Certificate2Collection = this.list;
			if (x509Certificate2Collection != null)
			{
				x509Certificate2Collection.Clear();
				return;
			}
		}

		// Token: 0x060006BD RID: 1725 RVA: 0x00018AE8 File Offset: 0x00016CE8
		public void Dispose()
		{
			X509Certificate2Collection x509Certificate2Collection = this.list;
			if (x509Certificate2Collection != null)
			{
				x509Certificate2Collection.Clear();
				return;
			}
		}

		// Token: 0x060006BE RID: 1726 RVA: 0x00018B08 File Offset: 0x00016D08
		public void Open(OpenFlags flags)
		{
			bool flag = string.IsNullOrEmpty(this._name);
			string name = this._name;
			bool flag2 = name == "Root";
			StoreLocation location = this._location;
			X509Stores currentUser = X509StoreManager.CurrentUser;
		}

		// Token: 0x04000534 RID: 1332
		private string _name;

		// Token: 0x04000535 RID: 1333
		private StoreLocation _location;

		// Token: 0x04000536 RID: 1334
		private X509Certificate2Collection list;

		// Token: 0x04000537 RID: 1335
		private OpenFlags _flags;

		// Token: 0x04000538 RID: 1336
		private X509Store store;
	}
}
