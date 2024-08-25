using System;
using System.Runtime.Serialization;
using Cpp2IlInjected;

namespace System
{
	// Token: 0x0200014D RID: 333
	[Serializable]
	internal sealed class Empty : ISerializable
	{
		// Token: 0x06000D1B RID: 3355 RVA: 0x0001C8C4 File Offset: 0x0001AAC4
		private Empty()
		{
		}

		// Token: 0x06000D1C RID: 3356 RVA: 0x0000207A File Offset: 0x0000027A
		public override string ToString()
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06000D1D RID: 3357 RVA: 0x0001C8D8 File Offset: 0x0001AAD8
		public void GetObjectData(SerializationInfo info, StreamingContext context)
		{
			while (info == null)
			{
			}
		}

		// Token: 0x06000D1E RID: 3358 RVA: 0x0001C8E8 File Offset: 0x0001AAE8
		// Note: this type is marked as 'beforefieldinit'.
		static Empty()
		{
		}

		// Token: 0x0400050D RID: 1293
		public static readonly Empty Value;
	}
}
