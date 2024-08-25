using System;
using System.Collections;

namespace System.Net
{
	// Token: 0x020001D0 RID: 464
	internal class CaseInsensitiveAscii : IEqualityComparer, IComparer
	{
		// Token: 0x06000B46 RID: 2886 RVA: 0x0002509C File Offset: 0x0002329C
		public int GetHashCode(object myObject)
		{
			if (myObject != null)
			{
				return;
			}
		}

		// Token: 0x06000B47 RID: 2887 RVA: 0x000250B0 File Offset: 0x000232B0
		public int Compare(object firstObject, object secondObject)
		{
			for (;;)
			{
				if (firstObject != null)
				{
				}
				if (secondObject != null)
				{
				}
				if (firstObject != null && secondObject != null)
				{
					return;
				}
			}
		}

		// Token: 0x06000B48 RID: 2888 RVA: 0x000250CC File Offset: 0x000232CC
		private int FastGetHashCode(string myString)
		{
			int num = 1;
			if (myString._stringLength != 0)
			{
				if (num == 0)
				{
				}
				long num2 = 0L;
				char c = myString[(int)num2];
				char c2 = myString[(int)num2];
				return;
			}
		}

		// Token: 0x06000B49 RID: 2889 RVA: 0x000250FC File Offset: 0x000232FC
		public bool Equals(object firstObject, object secondObject)
		{
			if (firstObject != null)
			{
			}
			if (secondObject == null || firstObject == null || secondObject != null)
			{
				return;
			}
		}

		// Token: 0x06000B4A RID: 2890 RVA: 0x0002511C File Offset: 0x0002331C
		public CaseInsensitiveAscii()
		{
		}

		// Token: 0x06000B4B RID: 2891 RVA: 0x00025130 File Offset: 0x00023330
		// Note: this type is marked as 'beforefieldinit'.
		static CaseInsensitiveAscii()
		{
		}

		// Token: 0x040009E6 RID: 2534
		internal static readonly CaseInsensitiveAscii StaticInstance;

		// Token: 0x040009E7 RID: 2535
		internal static readonly byte[] AsciiToLower;
	}
}
