using System;
using Cpp2IlInjected;

namespace ReLogic.Utilities
{
	// Token: 0x02000B08 RID: 2824
	public struct SlotId
	{
		// Token: 0x170008E0 RID: 2272
		// (get) Token: 0x0600528B RID: 21131 RVA: 0x000021DB File Offset: 0x000003DB
		public bool IsValid
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		// Token: 0x170008E1 RID: 2273
		// (get) Token: 0x0600528C RID: 21132 RVA: 0x000021DB File Offset: 0x000003DB
		internal bool IsActive
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		// Token: 0x170008E2 RID: 2274
		// (get) Token: 0x0600528D RID: 21133 RVA: 0x000021DB File Offset: 0x000003DB
		internal uint Index
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		// Token: 0x170008E3 RID: 2275
		// (get) Token: 0x0600528E RID: 21134 RVA: 0x000021DB File Offset: 0x000003DB
		internal uint Key
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		// Token: 0x0600528F RID: 21135 RVA: 0x0028324C File Offset: 0x0028144C
		internal SlotId ToInactive(uint freeHead)
		{
			return ref this;
		}

		// Token: 0x06005290 RID: 21136 RVA: 0x0028325C File Offset: 0x0028145C
		internal SlotId ToActive(uint index)
		{
			return ref this;
		}

		// Token: 0x06005291 RID: 21137 RVA: 0x0028326C File Offset: 0x0028146C
		public SlotId(uint value)
		{
			this.Value = value;
		}

		// Token: 0x06005292 RID: 21138 RVA: 0x00283280 File Offset: 0x00281480
		public override bool Equals(object obj)
		{
			if (obj != null)
			{
				return;
			}
		}

		// Token: 0x06005293 RID: 21139 RVA: 0x00283294 File Offset: 0x00281494
		public override int GetHashCode()
		{
			int num;
			return num;
		}

		// Token: 0x06005294 RID: 21140 RVA: 0x000021DB File Offset: 0x000003DB
		public static bool operator ==(SlotId lhs, SlotId rhs)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06005295 RID: 21141 RVA: 0x000021DB File Offset: 0x000003DB
		public static bool operator !=(SlotId lhs, SlotId rhs)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06005296 RID: 21142 RVA: 0x000021DB File Offset: 0x000003DB
		public float ToFloat()
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06005297 RID: 21143 RVA: 0x000021DB File Offset: 0x000003DB
		public static SlotId FromFloat(float value)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06005298 RID: 21144 RVA: 0x002832A4 File Offset: 0x002814A4
		// Note: this type is marked as 'beforefieldinit'.
		static SlotId()
		{
		}

		// Token: 0x04008ACF RID: 35535
		public static readonly SlotId Invalid;

		// Token: 0x04008AD0 RID: 35536
		private const uint KEY_INC = 65536U;

		// Token: 0x04008AD1 RID: 35537
		private const uint INDEX_MASK = 65535U;

		// Token: 0x04008AD2 RID: 35538
		private const uint ACTIVE_MASK = 2147483648U;

		// Token: 0x04008AD3 RID: 35539
		private const uint KEY_MASK = 2147418112U;

		// Token: 0x04008AD4 RID: 35540
		public readonly uint Value;
	}
}
