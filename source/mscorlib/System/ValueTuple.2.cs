using System;
using System.Collections;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;

namespace System
{
	// Token: 0x0200011C RID: 284
	[Serializable]
	public struct ValueTuple<T1> : IEquatable<ValueTuple<T1>>, IStructuralEquatable, IStructuralComparable, IComparable, IComparable<ValueTuple<T1>>, IValueTupleInternal, ITuple
	{
		// Token: 0x06000B1F RID: 2847 RVA: 0x00018B68 File Offset: 0x00016D68
		public ValueTuple(T1 item1)
		{
		}

		// Token: 0x06000B20 RID: 2848 RVA: 0x00018B78 File Offset: 0x00016D78
		public override bool Equals(object obj)
		{
			if (obj != null)
			{
			}
			bool flag;
			return flag;
		}

		// Token: 0x06000B21 RID: 2849 RVA: 0x0000207A File Offset: 0x0000027A
		public bool Equals(ValueTuple<T1> other)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06000B22 RID: 2850 RVA: 0x00018B94 File Offset: 0x00016D94
		bool IStructuralEquatable.Equals(object other, IEqualityComparer comparer)
		{
			if (other != null)
			{
			}
			throw new InvalidCastException();
		}

		// Token: 0x06000B23 RID: 2851 RVA: 0x00018BAC File Offset: 0x00016DAC
		int IComparable.CompareTo(object other)
		{
			if (other != null)
			{
			}
			return 1;
		}

		// Token: 0x06000B24 RID: 2852 RVA: 0x0000207A File Offset: 0x0000027A
		public int CompareTo(ValueTuple<T1> other)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06000B25 RID: 2853 RVA: 0x00018BC4 File Offset: 0x00016DC4
		int IStructuralComparable.CompareTo(object other, IComparer comparer)
		{
			if (other != null)
			{
			}
			return 1;
		}

		// Token: 0x06000B26 RID: 2854 RVA: 0x00018BE4 File Offset: 0x00016DE4
		public override int GetHashCode()
		{
			int num;
			return num;
		}

		// Token: 0x06000B27 RID: 2855 RVA: 0x0000207A File Offset: 0x0000027A
		int IStructuralEquatable.GetHashCode(IEqualityComparer comparer)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06000B28 RID: 2856 RVA: 0x0000207A File Offset: 0x0000027A
		int IValueTupleInternal.GetHashCode(IEqualityComparer comparer)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06000B29 RID: 2857 RVA: 0x00018BF4 File Offset: 0x00016DF4
		public override string ToString()
		{
			string text;
			return "(" + text + ")";
		}

		// Token: 0x06000B2A RID: 2858 RVA: 0x00018C14 File Offset: 0x00016E14
		string IValueTupleInternal.ToStringEnd()
		{
			string text;
			return text + ")";
		}

		// Token: 0x170000F5 RID: 245
		// (get) Token: 0x06000B2B RID: 2859 RVA: 0x00018C2C File Offset: 0x00016E2C
		int ITuple.Length
		{
			get
			{
				return 1;
			}
		}

		// Token: 0x04000401 RID: 1025
		public T1 Item1;
	}
}
