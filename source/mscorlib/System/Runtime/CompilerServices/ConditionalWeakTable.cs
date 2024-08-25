using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Threading;
using Cpp2IlInjected;

namespace System.Runtime.CompilerServices
{
	// Token: 0x020004A0 RID: 1184
	public sealed class ConditionalWeakTable<TKey, TValue> : IEnumerable<KeyValuePair<TKey, TValue>>, IEnumerable where TKey : class where TValue : class
	{
		// Token: 0x06002291 RID: 8849 RVA: 0x0004DB2C File Offset: 0x0004BD2C
		public ConditionalWeakTable()
		{
			if (!true)
			{
			}
		}

		// Token: 0x06002292 RID: 8850 RVA: 0x0004DB44 File Offset: 0x0004BD44
		protected override void Finalize()
		{
			base.Finalize();
		}

		// Token: 0x06002293 RID: 8851 RVA: 0x0004DB58 File Offset: 0x0004BD58
		private void RehashWithoutResize()
		{
			Ephemeron[] array = this.data;
			Ephemeron[] array2 = this.data;
			Ephemeron[] array3 = this.data;
		}

		// Token: 0x06002294 RID: 8852 RVA: 0x0004DB90 File Offset: 0x0004BD90
		private void RecomputeSize()
		{
			Ephemeron[] array = this.data;
			long num = 0L;
			this.size = (int)num;
		}

		// Token: 0x06002295 RID: 8853 RVA: 0x0004DBB0 File Offset: 0x0004BDB0
		private void Rehash()
		{
			int num = 1;
			int num2 = this.size;
			if (num == 0)
			{
			}
			int prime = HashHelpers.GetPrime(int.MinValue);
			Ephemeron[] array = this.data;
		}

		// Token: 0x06002296 RID: 8854 RVA: 0x0004DC14 File Offset: 0x0004BE14
		public void Add(TKey key, TValue value)
		{
			if (key != null)
			{
				object @lock = this._lock;
				Ephemeron[] array = this.data;
				int num = this.size;
				Ephemeron[] array2 = this.data;
				Ephemeron[] array3 = this.data;
				if (array2 == null)
				{
				}
				Ephemeron[] array4 = this.data;
				return;
			}
			throw new OutOfMemoryException();
		}

		// Token: 0x06002297 RID: 8855 RVA: 0x0004DC94 File Offset: 0x0004BE94
		public bool Remove(TKey key)
		{
			if (key != null)
			{
				object @lock = this._lock;
				Ephemeron[] array = this.data;
				Ephemeron[] array2 = this.data;
				long num = 0L;
				if (array2 != null)
				{
					Monitor.Exit(@lock);
				}
				if (num == 0L)
				{
				}
			}
			throw new OutOfMemoryException();
		}

		// Token: 0x06002298 RID: 8856 RVA: 0x0004DCFC File Offset: 0x0004BEFC
		public bool TryGetValue(TKey key, [Out] TValue value)
		{
			if (key != null)
			{
				object @lock = this._lock;
				Ephemeron[] array = this.data;
				Ephemeron[] array2 = this.data;
				long num = 0L;
				int num2 = 9;
				long num3;
				if (num2 != 0)
				{
					if (num2 == 0)
					{
						throw new InvalidCastException();
					}
				}
				else
				{
					num3 = 0L;
				}
				num.m_value = num3;
				if (num2 != 0 && num2 == 0)
				{
					throw new InvalidCastException();
				}
				long num4 = 0L;
				if (array2 != null)
				{
					Monitor.Exit(@lock);
				}
				if (num4 == 0L)
				{
				}
			}
			throw new OutOfMemoryException();
		}

		// Token: 0x06002299 RID: 8857 RVA: 0x0004DD78 File Offset: 0x0004BF78
		public TValue GetValue(TKey key, ConditionalWeakTable<TKey, TValue>.CreateValueCallback createValueCallback)
		{
			if (createValueCallback != null)
			{
				object @lock = this._lock;
				long num = 0L;
				Monitor.Exit(@lock);
				if (num != 0L || 7 == 0)
				{
				}
			}
			throw new OutOfMemoryException();
		}

		// Token: 0x0600229A RID: 8858 RVA: 0x0004DDD0 File Offset: 0x0004BFD0
		IEnumerator<KeyValuePair<TKey, TValue>> IEnumerable<KeyValuePair<TKey, TValue>>.GetEnumerator()
		{
			object @lock = this._lock;
			int num = this.size;
			if (num != 0)
			{
			}
			if (num != 0)
			{
			}
			long num2 = 0L;
			Monitor.Exit(@lock);
			if (num2 == 0L)
			{
			}
			throw new OutOfMemoryException();
		}

		// Token: 0x0600229B RID: 8859 RVA: 0x0000207A File Offset: 0x0000027A
		IEnumerator IEnumerable.GetEnumerator()
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x040012EC RID: 4844
		private const int INITIAL_SIZE = 13;

		// Token: 0x040012ED RID: 4845
		private const float LOAD_FACTOR = 0.7f;

		// Token: 0x040012EE RID: 4846
		private const float COMPACT_FACTOR = 0.5f;

		// Token: 0x040012EF RID: 4847
		private const float EXPAND_FACTOR = 1.1f;

		// Token: 0x040012F0 RID: 4848
		private Ephemeron[] data;

		// Token: 0x040012F1 RID: 4849
		private object _lock;

		// Token: 0x040012F2 RID: 4850
		private int size;

		// Token: 0x020004A1 RID: 1185
		public sealed class CreateValueCallback : MulticastDelegate
		{
			// Token: 0x0600229C RID: 8860 RVA: 0x0004DE1C File Offset: 0x0004C01C
			public CreateValueCallback(object @object, IntPtr method)
			{
			}

			// Token: 0x0600229D RID: 8861 RVA: 0x0000207A File Offset: 0x0000027A
			public TValue Invoke(TKey key)
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		// Token: 0x020004A2 RID: 1186
		private sealed class Enumerator : IEnumerator<KeyValuePair<TKey, TValue>>, IDisposable, IEnumerator
		{
			// Token: 0x0600229E RID: 8862 RVA: 0x0004DE3C File Offset: 0x0004C03C
			public Enumerator(ConditionalWeakTable<TKey, TValue> table)
			{
				this._table = table;
			}

			// Token: 0x0600229F RID: 8863 RVA: 0x0004DE58 File Offset: 0x0004C058
			protected override void Finalize()
			{
				base.Finalize();
			}

			// Token: 0x060022A0 RID: 8864 RVA: 0x0000207A File Offset: 0x0000027A
			public void Dispose()
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}

			// Token: 0x060022A1 RID: 8865 RVA: 0x0004DE8C File Offset: 0x0004C08C
			public bool MoveNext()
			{
				int num = 1;
				ConditionalWeakTable table = this._table;
				object @lock;
				Ephemeron[] data;
				if (table != null)
				{
					@lock = table._lock;
					if (num == 0)
					{
					}
					data = table.data;
					int currentIndex = this._currentIndex;
					this._currentIndex = currentIndex;
					if (data.value == null)
					{
						throw new InvalidCastException();
					}
					if (table != null && table == null)
					{
						throw new InvalidCastException();
					}
				}
				long num2 = 0L;
				if (data != null)
				{
					Monitor.Exit(@lock);
				}
				if (num2 == 0L)
				{
				}
				throw new OutOfMemoryException();
			}

			// Token: 0x1700047C RID: 1148
			// (get) Token: 0x060022A2 RID: 8866 RVA: 0x0000207A File Offset: 0x0000027A
			public KeyValuePair<TKey, TValue> Current
			{
				get
				{
					throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
				}
			}

			// Token: 0x1700047D RID: 1149
			// (get) Token: 0x060022A3 RID: 8867 RVA: 0x0000207A File Offset: 0x0000027A
			object IEnumerator.Current
			{
				get
				{
					throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
				}
			}

			// Token: 0x060022A4 RID: 8868 RVA: 0x0004DF14 File Offset: 0x0004C114
			public void Reset()
			{
			}

			// Token: 0x040012F3 RID: 4851
			private ConditionalWeakTable<TKey, TValue> _table;

			// Token: 0x040012F4 RID: 4852
			private int _currentIndex;

			// Token: 0x040012F5 RID: 4853
			private KeyValuePair<TKey, TValue> _current;
		}
	}
}
