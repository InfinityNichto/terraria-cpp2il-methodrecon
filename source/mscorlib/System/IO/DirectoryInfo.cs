using System;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace System.IO
{
	// Token: 0x0200054B RID: 1355
	[Serializable]
	public sealed class DirectoryInfo : FileSystemInfo
	{
		// Token: 0x06002844 RID: 10308 RVA: 0x000576DC File Offset: 0x000558DC
		public DirectoryInfo(string path)
		{
			if (!true)
			{
			}
			string fullPath = Path.GetFullPath(path);
		}

		// Token: 0x06002845 RID: 10309 RVA: 0x000576FC File Offset: 0x000558FC
		internal DirectoryInfo(string originalPath, [Optional] string fullPath, [Optional] string fileName, bool isNormalized = false)
		{
			this.Init(originalPath, fullPath, fileName, isNormalized);
		}

		// Token: 0x06002846 RID: 10310 RVA: 0x0005771C File Offset: 0x0005591C
		private void Init(string originalPath, [Optional] string fullPath, [Optional] string fileName, bool isNormalized = false)
		{
			while (originalPath == null)
			{
			}
			this.OriginalPath = originalPath;
			if (!true)
			{
			}
			string fullPath2 = Path.GetFullPath(fullPath);
			if (fileName != null)
			{
				ReadOnlySpan<char> readOnlySpan;
				this._name = readOnlySpan;
				this.FullPath = fullPath;
				return;
			}
			if (fullPath != null)
			{
				char rawStringData = fullPath.GetRawStringData();
				int stringLength = fullPath._stringLength;
				return;
			}
			if (!true)
			{
			}
			if (fullPath != null)
			{
				char rawStringData2 = fullPath.GetRawStringData();
				int stringLength2 = fullPath._stringLength;
				return;
			}
		}

		// Token: 0x06002847 RID: 10311 RVA: 0x000577A8 File Offset: 0x000559A8
		public void Create()
		{
			FileSystem.CreateDirectory(this.FullPath);
		}

		// Token: 0x06002848 RID: 10312 RVA: 0x000577C0 File Offset: 0x000559C0
		private DirectoryInfo(SerializationInfo info, StreamingContext context)
			: base(info, context)
		{
		}
	}
}
