using System;
using System.Collections;

namespace System.Configuration
{
	// Token: 0x02000456 RID: 1110
	public class SettingsPropertyCollection : ICollection, IEnumerable, ICloneable
	{
		// Token: 0x06001E10 RID: 7696 RVA: 0x0005040C File Offset: 0x0004E60C
		public SettingsPropertyCollection()
		{
			throw new NotSupportedException();
		}

		// Token: 0x170006C5 RID: 1733
		// (get) Token: 0x06001E11 RID: 7697 RVA: 0x00050420 File Offset: 0x0004E620
		public int Count
		{
			get
			{
				throw new NotSupportedException();
			}
		}

		// Token: 0x170006C6 RID: 1734
		// (get) Token: 0x06001E12 RID: 7698 RVA: 0x00050434 File Offset: 0x0004E634
		public bool IsSynchronized
		{
			get
			{
				throw new NotSupportedException();
			}
		}

		// Token: 0x170006C7 RID: 1735
		public SettingsProperty this[string name]
		{
			get
			{
				throw new NotSupportedException();
			}
		}

		// Token: 0x170006C8 RID: 1736
		// (get) Token: 0x06001E14 RID: 7700 RVA: 0x0005045C File Offset: 0x0004E65C
		public object SyncRoot
		{
			get
			{
				throw new NotSupportedException();
			}
		}

		// Token: 0x06001E15 RID: 7701 RVA: 0x00050470 File Offset: 0x0004E670
		public void Add(SettingsProperty property)
		{
			throw new NotSupportedException();
		}

		// Token: 0x06001E16 RID: 7702 RVA: 0x00050484 File Offset: 0x0004E684
		public void Clear()
		{
			throw new NotSupportedException();
		}

		// Token: 0x06001E17 RID: 7703 RVA: 0x00050498 File Offset: 0x0004E698
		public object Clone()
		{
			throw new NotSupportedException();
		}

		// Token: 0x06001E18 RID: 7704 RVA: 0x000504AC File Offset: 0x0004E6AC
		public void CopyTo(Array array, int index)
		{
			throw new NotSupportedException();
		}

		// Token: 0x06001E19 RID: 7705 RVA: 0x000504C0 File Offset: 0x0004E6C0
		public IEnumerator GetEnumerator()
		{
			throw new NotSupportedException();
		}

		// Token: 0x06001E1A RID: 7706 RVA: 0x000504D4 File Offset: 0x0004E6D4
		protected virtual void OnAdd(SettingsProperty property)
		{
			throw new NotSupportedException();
		}

		// Token: 0x06001E1B RID: 7707 RVA: 0x000504E8 File Offset: 0x0004E6E8
		protected virtual void OnAddComplete(SettingsProperty property)
		{
			throw new NotSupportedException();
		}

		// Token: 0x06001E1C RID: 7708 RVA: 0x000504FC File Offset: 0x0004E6FC
		protected virtual void OnClear()
		{
			throw new NotSupportedException();
		}

		// Token: 0x06001E1D RID: 7709 RVA: 0x00050510 File Offset: 0x0004E710
		protected virtual void OnClearComplete()
		{
			throw new NotSupportedException();
		}

		// Token: 0x06001E1E RID: 7710 RVA: 0x00050524 File Offset: 0x0004E724
		protected virtual void OnRemove(SettingsProperty property)
		{
			throw new NotSupportedException();
		}

		// Token: 0x06001E1F RID: 7711 RVA: 0x00050538 File Offset: 0x0004E738
		protected virtual void OnRemoveComplete(SettingsProperty property)
		{
			throw new NotSupportedException();
		}

		// Token: 0x06001E20 RID: 7712 RVA: 0x0005054C File Offset: 0x0004E74C
		public void Remove(string name)
		{
			throw new NotSupportedException();
		}

		// Token: 0x06001E21 RID: 7713 RVA: 0x00050560 File Offset: 0x0004E760
		public void SetReadOnly()
		{
			throw new NotSupportedException();
		}
	}
}
