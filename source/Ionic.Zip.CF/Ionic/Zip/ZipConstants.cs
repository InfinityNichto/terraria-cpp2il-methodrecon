using System;

namespace Ionic.Zip
{
	// Token: 0x02000019 RID: 25
	internal static class ZipConstants
	{
		// Token: 0x04000037 RID: 55
		public const uint PackedToRemovableMedia = 808471376U;

		// Token: 0x04000038 RID: 56
		public const uint Zip64EndOfCentralDirectoryRecordSignature = 101075792U;

		// Token: 0x04000039 RID: 57
		public const uint Zip64EndOfCentralDirectoryLocatorSignature = 117853008U;

		// Token: 0x0400003A RID: 58
		public const uint EndOfCentralDirectorySignature = 101010256U;

		// Token: 0x0400003B RID: 59
		public const int ZipEntrySignature = 67324752;

		// Token: 0x0400003C RID: 60
		public const int ZipEntryDataDescriptorSignature = 134695760;

		// Token: 0x0400003D RID: 61
		public const int SplitArchiveSignature = 134695760;

		// Token: 0x0400003E RID: 62
		public const int ZipDirEntrySignature = 33639248;

		// Token: 0x0400003F RID: 63
		public const int AesKeySize = 192;

		// Token: 0x04000040 RID: 64
		public const int AesBlockSize = 128;

		// Token: 0x04000041 RID: 65
		public const ushort AesAlgId128 = 26126;

		// Token: 0x04000042 RID: 66
		public const ushort AesAlgId192 = 26127;

		// Token: 0x04000043 RID: 67
		public const ushort AesAlgId256 = 26128;
	}
}
