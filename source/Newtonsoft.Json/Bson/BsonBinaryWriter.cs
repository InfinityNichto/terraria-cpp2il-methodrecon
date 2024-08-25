using System;
using System.IO;
using System.Runtime.CompilerServices;
using System.Text;
using Cpp2IlInjected;
using Newtonsoft.Json.Shims;

namespace Newtonsoft.Json.Bson
{
	// Token: 0x0200011F RID: 287
	[Preserve]
	internal class BsonBinaryWriter
	{
		// Token: 0x1700022C RID: 556
		// (get) Token: 0x06000B33 RID: 2867 RVA: 0x0001AF18 File Offset: 0x00019118
		// (set) Token: 0x06000B34 RID: 2868 RVA: 0x0001AF2C File Offset: 0x0001912C
		public DateTimeKind DateTimeKindHandling
		{
			[CompilerGenerated]
			get
			{
				return this.<DateTimeKindHandling>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<DateTimeKindHandling>k__BackingField = value;
			}
		}

		// Token: 0x06000B35 RID: 2869 RVA: 0x0001AF40 File Offset: 0x00019140
		public BsonBinaryWriter(BinaryWriter writer)
		{
			this.DateTimeKindHandling = DateTimeKind.Utc;
			this._writer = writer;
		}

		// Token: 0x06000B36 RID: 2870 RVA: 0x0001AF64 File Offset: 0x00019164
		public void Flush()
		{
			BinaryWriter writer = this._writer;
		}

		// Token: 0x06000B37 RID: 2871 RVA: 0x0001AF78 File Offset: 0x00019178
		public void Close()
		{
			BinaryWriter writer = this._writer;
		}

		// Token: 0x06000B38 RID: 2872 RVA: 0x0001AF8C File Offset: 0x0001918C
		public void WriteToken(BsonToken t)
		{
			int num = this.CalculateSize(t);
			this.WriteTokenInternal(t);
		}

		// Token: 0x06000B39 RID: 2873 RVA: 0x0001AFA8 File Offset: 0x000191A8
		private void WriteTokenInternal(BsonToken t)
		{
		}

		// Token: 0x06000B3A RID: 2874 RVA: 0x0001B0E4 File Offset: 0x000192E4
		private void WriteString(string s, int byteCount, int? calculatedlengthPrefix)
		{
			BinaryWriter writer = this._writer;
			this.WriteUtf8Bytes(s, byteCount);
			BinaryWriter writer2 = this._writer;
		}

		// Token: 0x06000B3B RID: 2875 RVA: 0x0001B108 File Offset: 0x00019308
		public void WriteUtf8Bytes(string s, int byteCount)
		{
			if (s != null)
			{
				if (this._largeByteBuffer == null)
				{
				}
				BinaryWriter writer = this._writer;
				return;
			}
		}

		// Token: 0x06000B3C RID: 2876 RVA: 0x0000212A File Offset: 0x0000032A
		private int CalculateSize(int stringByteCount)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06000B3D RID: 2877 RVA: 0x0000212A File Offset: 0x0000032A
		private int CalculateSizeWithLength(int stringByteCount, bool includeSize)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06000B3E RID: 2878 RVA: 0x0001B148 File Offset: 0x00019348
		private int CalculateSize(BsonToken t)
		{
			int num;
			return num;
		}

		// Token: 0x06000B3F RID: 2879 RVA: 0x0001B1E8 File Offset: 0x000193E8
		// Note: this type is marked as 'beforefieldinit'.
		static BsonBinaryWriter()
		{
		}

		// Token: 0x0400042C RID: 1068
		private static readonly Encoding Encoding;

		// Token: 0x0400042D RID: 1069
		private readonly BinaryWriter _writer;

		// Token: 0x0400042E RID: 1070
		private byte[] _largeByteBuffer;

		// Token: 0x0400042F RID: 1071
		[CompilerGenerated]
		private DateTimeKind <DateTimeKindHandling>k__BackingField;
	}
}
