using System;
using System.IO;
using Cpp2IlInjected;

namespace Terraria.IO
{
	// Token: 0x02000560 RID: 1376
	public class FileMetadata
	{
		// Token: 0x06003372 RID: 13170 RVA: 0x001FF6C4 File Offset: 0x001FD8C4
		private FileMetadata()
		{
		}

		// Token: 0x06003373 RID: 13171 RVA: 0x001FF6D8 File Offset: 0x001FD8D8
		public void Write(BinaryWriter writer)
		{
			FileType type = this.Type;
			uint revision = this.Revision;
			bool isFavorite = this.IsFavorite;
			int num = true.ToInt();
		}

		// Token: 0x06003374 RID: 13172 RVA: 0x001FF704 File Offset: 0x001FD904
		public void IncrementAndWrite(BinaryWriter writer)
		{
			uint revision = this.Revision;
			this.Revision = revision;
			this.Write(writer);
		}

		// Token: 0x06003375 RID: 13173 RVA: 0x000021DB File Offset: 0x000003DB
		public static FileMetadata FromCurrentSettings(FileType type)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06003376 RID: 13174 RVA: 0x001FF728 File Offset: 0x001FD928
		public static FileMetadata Read(BinaryReader reader, FileType expectedType)
		{
			throw new ArrayTypeMismatchException();
		}

		// Token: 0x06003377 RID: 13175 RVA: 0x001FF754 File Offset: 0x001FD954
		private void Read(BinaryReader reader)
		{
			Type type;
			Array values = Enum.GetValues(type);
			if (values == null || values != null)
			{
				return;
			}
			throw new InvalidCastException();
		}

		// Token: 0x04003C40 RID: 15424
		public const ulong MAGIC_NUMBER = 27981915666277746UL;

		// Token: 0x04003C41 RID: 15425
		public const int SIZE = 20;

		// Token: 0x04003C42 RID: 15426
		public FileType Type;

		// Token: 0x04003C43 RID: 15427
		public uint Revision;

		// Token: 0x04003C44 RID: 15428
		public bool IsFavorite;
	}
}
