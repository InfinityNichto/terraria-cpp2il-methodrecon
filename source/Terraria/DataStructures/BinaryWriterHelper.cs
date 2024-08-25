using System;
using System.IO;
using System.Runtime.InteropServices;

namespace Terraria.DataStructures
{
	// Token: 0x02000619 RID: 1561
	public struct BinaryWriterHelper
	{
		// Token: 0x060035B9 RID: 13753 RVA: 0x00211810 File Offset: 0x0020FA10
		public void ReservePointToFillLengthLaterByFilling6Bytes(BinaryWriter writer)
		{
			this._placeInWriter = writer;
		}

		// Token: 0x060035BA RID: 13754 RVA: 0x00211824 File Offset: 0x0020FA24
		public void FillReservedPoint(BinaryWriter writer, ushort dataId)
		{
		}

		// Token: 0x060035BB RID: 13755 RVA: 0x00211834 File Offset: 0x0020FA34
		public void FillOnlyIfThereIsLengthOrRevertToSavedPosition(BinaryWriter writer, ushort dataId, [Out] bool wroteSomething)
		{
			int num = 1;
			wroteSomething.m_value = num != 0;
		}

		// Token: 0x04007692 RID: 30354
		private long _placeInWriter;
	}
}
