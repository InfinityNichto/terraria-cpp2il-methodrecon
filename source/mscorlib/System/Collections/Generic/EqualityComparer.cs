using System;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;

namespace System.Collections.Generic
{
	// Token: 0x02000655 RID: 1621
	[TypeDependency("System.Collections.Generic.ObjectEqualityComparer`1")]
	[Serializable]
	public abstract class EqualityComparer<T> : IEqualityComparer, IEqualityComparer<T>
	{
		// Token: 0x170007F9 RID: 2041
		// (get) Token: 0x0600317D RID: 12669 RVA: 0x0000207A File Offset: 0x0000027A
		public static EqualityComparer<T> Default
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		// Token: 0x0600317E RID: 12670 RVA: 0x0006B5E4 File Offset: 0x000697E4
		private static EqualityComparer<T> CreateComparer()
		{
			Type type;
			if (type != null)
			{
			}
			Type type2;
			bool flag = type == type2;
			object obj;
			if (obj != null)
			{
			}
			if (obj != null)
			{
			}
			if (obj == null || obj != null)
			{
				Type type3;
				TypeCode typeCode = Type.GetTypeCode(Enum.GetUnderlyingType(type3));
				throw new InvalidCastException();
			}
			throw new ArrayTypeMismatchException();
		}

		// Token: 0x0600317F RID: 12671
		public abstract bool Equals(T x, T y);

		// Token: 0x06003180 RID: 12672
		public abstract int GetHashCode(T obj);

		// Token: 0x06003181 RID: 12673 RVA: 0x0006B630 File Offset: 0x00069830
		internal virtual int IndexOf(T[] array, T value, int startIndex, int count)
		{
			return count;
		}

		// Token: 0x06003182 RID: 12674 RVA: 0x0006B640 File Offset: 0x00069840
		internal virtual int LastIndexOf(T[] array, T value, int startIndex, int count)
		{
			return count;
		}

		// Token: 0x06003183 RID: 12675 RVA: 0x0006B650 File Offset: 0x00069850
		int IEqualityComparer.GetHashCode(object obj)
		{
			if (obj != null)
			{
				if (obj != null)
				{
				}
				ThrowHelper.ThrowArgumentException(ExceptionResource.Argument_InvalidArgumentForComparison);
			}
			throw new InvalidCastException();
		}

		// Token: 0x06003184 RID: 12676 RVA: 0x0006B670 File Offset: 0x00069870
		bool IEqualityComparer.Equals(object x, object y)
		{
			if (x != null && y != null)
			{
				if (x != null && y != null)
				{
					return true;
				}
				ThrowHelper.ThrowArgumentException(ExceptionResource.Argument_InvalidArgumentForComparison);
			}
			throw new InvalidCastException();
		}

		// Token: 0x06003185 RID: 12677 RVA: 0x0006B698 File Offset: 0x00069898
		protected EqualityComparer()
		{
		}

		// Token: 0x04001AA8 RID: 6824
		private static EqualityComparer<T> defaultComparer;
	}
}
