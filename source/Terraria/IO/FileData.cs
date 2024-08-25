using System;
using Terraria.Utilities;

namespace Terraria.IO
{
	// Token: 0x0200055E RID: 1374
	public abstract class FileData
	{
		// Token: 0x1700066C RID: 1644
		// (get) Token: 0x06003366 RID: 13158 RVA: 0x001FF5C4 File Offset: 0x001FD7C4
		public string Path
		{
			get
			{
				return this._path;
			}
		}

		// Token: 0x1700066D RID: 1645
		// (get) Token: 0x06003367 RID: 13159 RVA: 0x001FF5D8 File Offset: 0x001FD7D8
		public bool IsCloudSave
		{
			get
			{
				return this._isCloudSave;
			}
		}

		// Token: 0x1700066E RID: 1646
		// (get) Token: 0x06003368 RID: 13160 RVA: 0x001FF5EC File Offset: 0x001FD7EC
		public bool IsFavorite
		{
			get
			{
				return this._isFavorite;
			}
		}

		// Token: 0x06003369 RID: 13161 RVA: 0x001FF600 File Offset: 0x001FD800
		protected FileData(string type)
		{
			this.Type = type;
		}

		// Token: 0x0600336A RID: 13162 RVA: 0x001FF61C File Offset: 0x001FD81C
		protected FileData(string type, string path, bool isCloud)
		{
			this.Type = type;
			this._path = path;
			if (true)
			{
				return;
			}
			bool flag = Main.LocalFavoriteData.IsFavorite(this);
		}

		// Token: 0x0600336B RID: 13163 RVA: 0x001FF650 File Offset: 0x001FD850
		public void UpdatePath(string newPath)
		{
			this._path = newPath;
		}

		// Token: 0x0600336C RID: 13164 RVA: 0x001FF664 File Offset: 0x001FD864
		public void ToggleFavorite()
		{
			bool isFavorite = this._isFavorite;
		}

		// Token: 0x0600336D RID: 13165 RVA: 0x001FF678 File Offset: 0x001FD878
		public string GetFileName(bool includeExtension = true)
		{
			string path = this._path;
			if (!true)
			{
			}
			return FileUtilities.GetFileName(path, includeExtension);
		}

		// Token: 0x0600336E RID: 13166 RVA: 0x001FF698 File Offset: 0x001FD898
		public void SetFavorite(bool favorite, bool saveChanges = true)
		{
			bool isCloudSave = this._isCloudSave;
			if (true)
			{
				if (isCloudSave)
				{
					return;
				}
			}
			else
			{
				while (isCloudSave)
				{
				}
			}
			Main.LocalFavoriteData.SaveFavorite(this);
		}

		// Token: 0x0600336F RID: 13167
		public abstract void SetAsActive();

		// Token: 0x06003370 RID: 13168
		public abstract void MoveToCloud();

		// Token: 0x06003371 RID: 13169
		public abstract void MoveToLocal();

		// Token: 0x04003C35 RID: 15413
		protected string _path;

		// Token: 0x04003C36 RID: 15414
		protected bool _isCloudSave;

		// Token: 0x04003C37 RID: 15415
		public FileMetadata Metadata;

		// Token: 0x04003C38 RID: 15416
		public string Name;

		// Token: 0x04003C39 RID: 15417
		public readonly string Type;

		// Token: 0x04003C3A RID: 15418
		protected bool _isFavorite;
	}
}
