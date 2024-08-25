using System;

namespace Ionic.Zip
{
	// Token: 0x02000009 RID: 9
	public class ZipProgressEventArgs : EventArgs
	{
		// Token: 0x06000015 RID: 21 RVA: 0x000022B8 File Offset: 0x000004B8
		internal ZipProgressEventArgs()
		{
			if (!true)
			{
			}
			base..ctor();
		}

		// Token: 0x06000016 RID: 22 RVA: 0x000022D0 File Offset: 0x000004D0
		internal ZipProgressEventArgs(string archiveName, ZipProgressEventType flavor)
		{
			if (!true)
			{
			}
			base..ctor();
			this._archiveName = archiveName;
			this._flavor = flavor;
		}

		// Token: 0x17000001 RID: 1
		// (get) Token: 0x06000017 RID: 23 RVA: 0x000022F4 File Offset: 0x000004F4
		// (set) Token: 0x06000018 RID: 24 RVA: 0x00002308 File Offset: 0x00000508
		public int EntriesTotal
		{
			get
			{
				return this._entriesTotal;
			}
			set
			{
				this._entriesTotal = value;
			}
		}

		// Token: 0x17000002 RID: 2
		// (get) Token: 0x06000019 RID: 25 RVA: 0x0000231C File Offset: 0x0000051C
		// (set) Token: 0x0600001A RID: 26 RVA: 0x00002330 File Offset: 0x00000530
		public ZipEntry CurrentEntry
		{
			get
			{
				return this._latestEntry;
			}
			set
			{
				this._latestEntry = value;
			}
		}

		// Token: 0x17000003 RID: 3
		// (get) Token: 0x0600001B RID: 27 RVA: 0x00002344 File Offset: 0x00000544
		// (set) Token: 0x0600001C RID: 28 RVA: 0x00002358 File Offset: 0x00000558
		public bool Cancel
		{
			get
			{
				return this._cancel;
			}
			set
			{
				bool cancel = this._cancel;
				this._cancel = cancel;
			}
		}

		// Token: 0x17000004 RID: 4
		// (get) Token: 0x0600001D RID: 29 RVA: 0x00002374 File Offset: 0x00000574
		// (set) Token: 0x0600001E RID: 30 RVA: 0x00002388 File Offset: 0x00000588
		public ZipProgressEventType EventType
		{
			get
			{
				return this._flavor;
			}
			set
			{
				this._flavor = value;
			}
		}

		// Token: 0x17000005 RID: 5
		// (get) Token: 0x0600001F RID: 31 RVA: 0x0000239C File Offset: 0x0000059C
		// (set) Token: 0x06000020 RID: 32 RVA: 0x000023B0 File Offset: 0x000005B0
		public string ArchiveName
		{
			get
			{
				return this._archiveName;
			}
			set
			{
				this._archiveName = value;
			}
		}

		// Token: 0x17000006 RID: 6
		// (get) Token: 0x06000021 RID: 33 RVA: 0x000023C4 File Offset: 0x000005C4
		// (set) Token: 0x06000022 RID: 34 RVA: 0x000023D8 File Offset: 0x000005D8
		public long BytesTransferred
		{
			get
			{
				return this._bytesTransferred;
			}
			set
			{
				this._bytesTransferred = value;
			}
		}

		// Token: 0x17000007 RID: 7
		// (get) Token: 0x06000023 RID: 35 RVA: 0x000023EC File Offset: 0x000005EC
		// (set) Token: 0x06000024 RID: 36 RVA: 0x00002400 File Offset: 0x00000600
		public long TotalBytesToTransfer
		{
			get
			{
				return this._totalBytesToTransfer;
			}
			set
			{
				this._totalBytesToTransfer = value;
			}
		}

		// Token: 0x0400001E RID: 30
		private int _entriesTotal;

		// Token: 0x0400001F RID: 31
		private bool _cancel;

		// Token: 0x04000020 RID: 32
		private ZipEntry _latestEntry;

		// Token: 0x04000021 RID: 33
		private ZipProgressEventType _flavor;

		// Token: 0x04000022 RID: 34
		private string _archiveName;

		// Token: 0x04000023 RID: 35
		private long _bytesTransferred;

		// Token: 0x04000024 RID: 36
		private long _totalBytesToTransfer;
	}
}
