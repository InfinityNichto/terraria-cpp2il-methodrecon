using System;
using Cpp2IlInjected;

namespace System.Collections.Specialized
{
	// Token: 0x02000417 RID: 1047
	public struct BitVector32
	{
		// Token: 0x17000640 RID: 1600
		public bool this[int bit]
		{
			get
			{
				throw new global::Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
			set
			{
			}
		}

		// Token: 0x06001C22 RID: 7202 RVA: 0x0004D158 File Offset: 0x0004B358
		public static int CreateMask()
		{
			return 1;
		}

		// Token: 0x06001C23 RID: 7203 RVA: 0x0004D168 File Offset: 0x0004B368
		public static int CreateMask(int previous)
		{
			return 1;
		}

		// Token: 0x06001C24 RID: 7204 RVA: 0x0004D178 File Offset: 0x0004B378
		public override bool Equals(object o)
		{
			if (o != null)
			{
				return;
			}
		}

		// Token: 0x06001C25 RID: 7205 RVA: 0x0004D18C File Offset: 0x0004B38C
		public override int GetHashCode()
		{
			int num;
			return num;
		}

		// Token: 0x06001C26 RID: 7206 RVA: 0x00002050 File Offset: 0x00000250
		public static string ToString(BitVector32 value)
		{
			throw new global::Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06001C27 RID: 7207 RVA: 0x0004D19C File Offset: 0x0004B39C
		public override string ToString()
		{
			string text;
			return text;
		}

		// Token: 0x04001395 RID: 5013
		private uint _data;
	}
}
