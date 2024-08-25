using System;
using System.Collections;
using System.Numerics.Hashing;
using System.Runtime.CompilerServices;

namespace System
{
	// Token: 0x0200011B RID: 283
	[Serializable]
	public struct ValueTuple : IEquatable<ValueTuple>, IStructuralEquatable, IStructuralComparable, IComparable, IComparable<ValueTuple>, IValueTupleInternal, ITuple
	{
		// Token: 0x06000B0C RID: 2828 RVA: 0x000189A4 File Offset: 0x00016BA4
		public override bool Equals(object obj)
		{
		}

		// Token: 0x06000B0D RID: 2829 RVA: 0x000189B4 File Offset: 0x00016BB4
		public bool Equals(ValueTuple other)
		{
			return true;
		}

		// Token: 0x06000B0E RID: 2830 RVA: 0x000189C4 File Offset: 0x00016BC4
		bool IStructuralEquatable.Equals(object other, IEqualityComparer comparer)
		{
			if (other != null)
			{
				return;
			}
		}

		// Token: 0x06000B0F RID: 2831 RVA: 0x000189D8 File Offset: 0x00016BD8
		int IComparable.CompareTo(object other)
		{
			if (other != null)
			{
			}
			return 1;
		}

		// Token: 0x06000B10 RID: 2832 RVA: 0x000189EC File Offset: 0x00016BEC
		public int CompareTo(ValueTuple other)
		{
		}

		// Token: 0x06000B11 RID: 2833 RVA: 0x000189FC File Offset: 0x00016BFC
		int IStructuralComparable.CompareTo(object other, IComparer comparer)
		{
			if (other != null)
			{
			}
			return 1;
		}

		// Token: 0x06000B12 RID: 2834 RVA: 0x00018A10 File Offset: 0x00016C10
		public override int GetHashCode()
		{
		}

		// Token: 0x06000B13 RID: 2835 RVA: 0x00018A20 File Offset: 0x00016C20
		int IStructuralEquatable.GetHashCode(IEqualityComparer comparer)
		{
		}

		// Token: 0x06000B14 RID: 2836 RVA: 0x00018A30 File Offset: 0x00016C30
		int IValueTupleInternal.GetHashCode(IEqualityComparer comparer)
		{
		}

		// Token: 0x06000B15 RID: 2837 RVA: 0x00018A40 File Offset: 0x00016C40
		public override string ToString()
		{
			return "()";
		}

		// Token: 0x06000B16 RID: 2838 RVA: 0x00018A54 File Offset: 0x00016C54
		string IValueTupleInternal.ToStringEnd()
		{
			return ")";
		}

		// Token: 0x170000F4 RID: 244
		// (get) Token: 0x06000B17 RID: 2839 RVA: 0x00018A68 File Offset: 0x00016C68
		int ITuple.Length
		{
			get
			{
			}
		}

		// Token: 0x06000B18 RID: 2840 RVA: 0x00018A78 File Offset: 0x00016C78
		internal static int CombineHashCodes(int h1, int h2)
		{
			if (!true)
			{
			}
			return global::System.Numerics.Hashing.HashHelpers.Combine(global::System.Numerics.Hashing.HashHelpers.Combine(1, h1), h1);
		}

		// Token: 0x06000B19 RID: 2841 RVA: 0x00018A98 File Offset: 0x00016C98
		internal static int CombineHashCodes(int h1, int h2, int h3)
		{
			return global::System.Numerics.Hashing.HashHelpers.Combine(ValueTuple.CombineHashCodes(-1073741824, h1), h2);
		}

		// Token: 0x06000B1A RID: 2842 RVA: 0x00018AB8 File Offset: 0x00016CB8
		internal static int CombineHashCodes(int h1, int h2, int h3, int h4)
		{
			return global::System.Numerics.Hashing.HashHelpers.Combine(ValueTuple.CombineHashCodes(-1073741824, h1, h2), h3);
		}

		// Token: 0x06000B1B RID: 2843 RVA: 0x00018AD8 File Offset: 0x00016CD8
		internal static int CombineHashCodes(int h1, int h2, int h3, int h4, int h5)
		{
			return global::System.Numerics.Hashing.HashHelpers.Combine(ValueTuple.CombineHashCodes(-1073741824, h1, h2, h3), h1);
		}

		// Token: 0x06000B1C RID: 2844 RVA: 0x00018AF8 File Offset: 0x00016CF8
		internal static int CombineHashCodes(int h1, int h2, int h3, int h4, int h5, int h6)
		{
			return global::System.Numerics.Hashing.HashHelpers.Combine(ValueTuple.CombineHashCodes(-1073741824, h1, h2, h3, h4), h5);
		}

		// Token: 0x06000B1D RID: 2845 RVA: 0x00018B1C File Offset: 0x00016D1C
		internal static int CombineHashCodes(int h1, int h2, int h3, int h4, int h5, int h6, int h7)
		{
			return global::System.Numerics.Hashing.HashHelpers.Combine(ValueTuple.CombineHashCodes(-1073741824, h1, h2, h3, h4, h5), h6);
		}

		// Token: 0x06000B1E RID: 2846 RVA: 0x00018B40 File Offset: 0x00016D40
		internal static int CombineHashCodes(int h1, int h2, int h3, int h4, int h5, int h6, int h7, int h8)
		{
			return global::System.Numerics.Hashing.HashHelpers.Combine(ValueTuple.CombineHashCodes(-1073741824, h1, h2, h3, h4, h5, h6), h7);
		}
	}
}
