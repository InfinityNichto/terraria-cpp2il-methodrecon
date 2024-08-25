using System;
using System.IO;
using Cpp2IlInjected;

namespace Terraria
{
	// Token: 0x02000422 RID: 1058
	public struct BitsByte
	{
		// Token: 0x0600274E RID: 10062 RVA: 0x0018C7D0 File Offset: 0x0018A9D0
		public BitsByte(bool b1 = false, bool b2 = false, bool b3 = false, bool b4 = false, bool b5 = false, bool b6 = false, bool b7 = false, bool b8 = false)
		{
		}

		// Token: 0x0600274F RID: 10063 RVA: 0x0018C7E0 File Offset: 0x0018A9E0
		public void ClearAll()
		{
		}

		// Token: 0x06002750 RID: 10064 RVA: 0x0018C7F0 File Offset: 0x0018A9F0
		public void SetAll()
		{
			this.value = byte.MaxValue;
		}

		// Token: 0x1700055A RID: 1370
		public bool this[int key]
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
			set
			{
			}
		}

		// Token: 0x06002753 RID: 10067 RVA: 0x0018C818 File Offset: 0x0018AA18
		public void Retrieve(bool b0)
		{
		}

		// Token: 0x06002754 RID: 10068 RVA: 0x0018C828 File Offset: 0x0018AA28
		public void Retrieve(bool b0, bool b1)
		{
		}

		// Token: 0x06002755 RID: 10069 RVA: 0x0018C838 File Offset: 0x0018AA38
		public void Retrieve(bool b0, bool b1, bool b2)
		{
		}

		// Token: 0x06002756 RID: 10070 RVA: 0x0018C848 File Offset: 0x0018AA48
		public void Retrieve(bool b0, bool b1, bool b2, bool b3)
		{
		}

		// Token: 0x06002757 RID: 10071 RVA: 0x0018C858 File Offset: 0x0018AA58
		public void Retrieve(bool b0, bool b1, bool b2, bool b3, bool b4)
		{
		}

		// Token: 0x06002758 RID: 10072 RVA: 0x0018C868 File Offset: 0x0018AA68
		public void Retrieve(bool b0, bool b1, bool b2, bool b3, bool b4, bool b5)
		{
		}

		// Token: 0x06002759 RID: 10073 RVA: 0x0018C878 File Offset: 0x0018AA78
		public void Retrieve(bool b0, bool b1, bool b2, bool b3, bool b4, bool b5, bool b6)
		{
		}

		// Token: 0x0600275A RID: 10074 RVA: 0x0018C888 File Offset: 0x0018AA88
		public void Retrieve(bool b0, bool b1, bool b2, bool b3, bool b4, bool b5, bool b6, bool b7)
		{
		}

		// Token: 0x0600275B RID: 10075 RVA: 0x000021DB File Offset: 0x000003DB
		public static implicit operator byte(BitsByte bb)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x0600275C RID: 10076 RVA: 0x000021DB File Offset: 0x000003DB
		public static implicit operator BitsByte(byte b)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x0600275D RID: 10077 RVA: 0x0018C898 File Offset: 0x0018AA98
		public static BitsByte[] ComposeBitsBytesChain(bool optimizeLength, params bool[] flags)
		{
		}

		// Token: 0x0600275E RID: 10078 RVA: 0x0018C8B4 File Offset: 0x0018AAB4
		public static BitsByte[] DecomposeBitsBytesChain(BinaryReader reader)
		{
		}

		// Token: 0x04003397 RID: 13207
		private static bool Null;

		// Token: 0x04003398 RID: 13208
		private byte value;
	}
}
