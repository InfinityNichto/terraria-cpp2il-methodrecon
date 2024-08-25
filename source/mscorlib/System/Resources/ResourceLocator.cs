using System;
using Cpp2IlInjected;

namespace System.Resources
{
	// Token: 0x020004B6 RID: 1206
	internal struct ResourceLocator
	{
		// Token: 0x06002326 RID: 8998 RVA: 0x0004F4CC File Offset: 0x0004D6CC
		internal ResourceLocator(int dataPos, object value)
		{
			this._dataPos = dataPos;
			this._value = value;
		}

		// Token: 0x17000492 RID: 1170
		// (get) Token: 0x06002327 RID: 8999 RVA: 0x0004F4E8 File Offset: 0x0004D6E8
		internal int DataPosition
		{
			get
			{
				return this._dataPos;
			}
		}

		// Token: 0x17000493 RID: 1171
		// (get) Token: 0x06002328 RID: 9000 RVA: 0x0000207A File Offset: 0x0000027A
		// (set) Token: 0x06002329 RID: 9001 RVA: 0x0004F4FC File Offset: 0x0004D6FC
		internal object Value
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
			set
			{
				this._value = value;
			}
		}

		// Token: 0x0600232A RID: 9002 RVA: 0x0000207A File Offset: 0x0000027A
		internal static bool CanCache(ResourceTypeCode value)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x0400133D RID: 4925
		internal object _value;

		// Token: 0x0400133E RID: 4926
		internal int _dataPos;
	}
}
