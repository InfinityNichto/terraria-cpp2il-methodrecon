using System;
using System.Collections;
using Cpp2IlInjected;

namespace System.ComponentModel
{
	// Token: 0x02000405 RID: 1029
	internal sealed class WeakHashtable : Hashtable
	{
		// Token: 0x06001BF1 RID: 7153 RVA: 0x0004CC98 File Offset: 0x0004AE98
		internal WeakHashtable()
		{
			if (!true)
			{
			}
		}

		// Token: 0x06001BF2 RID: 7154 RVA: 0x0004CCA8 File Offset: 0x0004AEA8
		public override void Clear()
		{
			base.Clear();
		}

		// Token: 0x06001BF3 RID: 7155 RVA: 0x0004CCBC File Offset: 0x0004AEBC
		public override void Remove(object key)
		{
			base.Remove(key);
		}

		// Token: 0x06001BF4 RID: 7156 RVA: 0x0004CCD0 File Offset: 0x0004AED0
		public void SetWeak(object key, object value)
		{
			this.ScavengeKeys();
		}

		// Token: 0x06001BF5 RID: 7157 RVA: 0x0004CCE4 File Offset: 0x0004AEE4
		private void ScavengeKeys()
		{
			if (this != null)
			{
				if (this._lastHashCount != 0)
				{
					long totalMemory = GC.GetTotalMemory(false);
					if (this._lastGlobalMem != 0L)
					{
						int lastHashCount = this._lastHashCount;
						return;
					}
					this._lastGlobalMem = totalMemory;
					return;
				}
				else
				{
					this._lastHashCount = this;
				}
			}
		}

		// Token: 0x06001BF6 RID: 7158 RVA: 0x0004CDA8 File Offset: 0x0004AFA8
		// Note: this type is marked as 'beforefieldinit'.
		static WeakHashtable()
		{
		}

		// Token: 0x04001387 RID: 4999
		private static IEqualityComparer _comparer;

		// Token: 0x04001388 RID: 5000
		private long _lastGlobalMem;

		// Token: 0x04001389 RID: 5001
		private int _lastHashCount;

		// Token: 0x02000406 RID: 1030
		private class WeakKeyComparer : IEqualityComparer
		{
			// Token: 0x06001BF7 RID: 7159 RVA: 0x0004CDB8 File Offset: 0x0004AFB8
			bool IEqualityComparer.Equals(object x, object y)
			{
				while (x == null || y == null)
				{
				}
				long num = 0L;
				long num2 = 0L;
				if (num == 0L)
				{
					if (num2 != 0L)
					{
						return;
					}
					while (num == 0L)
					{
					}
				}
				if (num2 != 0L)
				{
					return;
				}
			}

			// Token: 0x06001BF8 RID: 7160 RVA: 0x00002050 File Offset: 0x00000250
			int IEqualityComparer.GetHashCode(object obj)
			{
				throw new global::Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}

			// Token: 0x06001BF9 RID: 7161 RVA: 0x0004CDE0 File Offset: 0x0004AFE0
			public WeakKeyComparer()
			{
			}
		}

		// Token: 0x02000407 RID: 1031
		private sealed class EqualityWeakReference : WeakReference
		{
			// Token: 0x06001BFA RID: 7162 RVA: 0x0004CDF4 File Offset: 0x0004AFF4
			internal EqualityWeakReference(object o)
				: base(o)
			{
				this._hashCode = o;
			}

			// Token: 0x06001BFB RID: 7163 RVA: 0x0004CE10 File Offset: 0x0004B010
			public override bool Equals(object o)
			{
				if (o != null)
				{
					int hashCode = this._hashCode;
				}
				return true;
			}

			// Token: 0x06001BFC RID: 7164 RVA: 0x0004CE2C File Offset: 0x0004B02C
			public override int GetHashCode()
			{
				return this._hashCode;
			}

			// Token: 0x0400138A RID: 5002
			private int _hashCode;
		}
	}
}
