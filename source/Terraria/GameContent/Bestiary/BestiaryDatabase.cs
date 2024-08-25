using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using Terraria.GameContent.ItemDropRules;

namespace Terraria.GameContent.Bestiary
{
	// Token: 0x02000917 RID: 2327
	public class BestiaryDatabase
	{
		// Token: 0x17000810 RID: 2064
		// (get) Token: 0x060046D7 RID: 18135 RVA: 0x0025B2C0 File Offset: 0x002594C0
		public List<BestiaryEntry> Entries
		{
			get
			{
				return this._entries;
			}
		}

		// Token: 0x17000811 RID: 2065
		// (get) Token: 0x060046D8 RID: 18136 RVA: 0x0025B2D4 File Offset: 0x002594D4
		public List<IBestiaryEntryFilter> Filters
		{
			get
			{
				return this._filters;
			}
		}

		// Token: 0x17000812 RID: 2066
		// (get) Token: 0x060046D9 RID: 18137 RVA: 0x0025B2E8 File Offset: 0x002594E8
		public List<IBestiarySortStep> SortSteps
		{
			get
			{
				return this._sortSteps;
			}
		}

		// Token: 0x060046DA RID: 18138 RVA: 0x000021DB File Offset: 0x000003DB
		public BestiaryEntry Register(BestiaryEntry entry)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x060046DB RID: 18139 RVA: 0x000021DB File Offset: 0x000003DB
		public IBestiaryEntryFilter Register(IBestiaryEntryFilter filter)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x060046DC RID: 18140 RVA: 0x000021DB File Offset: 0x000003DB
		public IBestiarySortStep Register(IBestiarySortStep sortStep)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x060046DD RID: 18141 RVA: 0x000021DB File Offset: 0x000003DB
		public BestiaryEntry FindEntryByNPCID(int npcNetId)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x060046DE RID: 18142 RVA: 0x0025B2FC File Offset: 0x002594FC
		public void Merge(ItemDropDatabase dropsDatabase)
		{
		}

		// Token: 0x060046DF RID: 18143 RVA: 0x000021DB File Offset: 0x000003DB
		private void ExtractDropsForNPC(ItemDropDatabase dropsDatabase, int npcId)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x060046E0 RID: 18144 RVA: 0x0025B30C File Offset: 0x0025950C
		public void ApplyPass(BestiaryDatabase.BestiaryEntriesPass pass)
		{
			int size = this._entries._size;
			IntPtr method_code = pass.method_code;
			IntPtr invoke_impl = pass.invoke_impl;
			IntPtr method = pass.method;
			int size2 = this._entries._size;
		}

		// Token: 0x060046E1 RID: 18145 RVA: 0x0025B34C File Offset: 0x0025954C
		public BestiaryDatabase()
		{
		}

		// Token: 0x040082B6 RID: 33462
		private List<BestiaryEntry> _entries;

		// Token: 0x040082B7 RID: 33463
		private List<IBestiaryEntryFilter> _filters;

		// Token: 0x040082B8 RID: 33464
		private List<IBestiarySortStep> _sortSteps;

		// Token: 0x040082B9 RID: 33465
		private Dictionary<int, BestiaryEntry> _byNpcId;

		// Token: 0x040082BA RID: 33466
		private BestiaryEntry _trashEntry;

		// Token: 0x02000918 RID: 2328
		public sealed class BestiaryEntriesPass : MulticastDelegate
		{
			// Token: 0x060046E2 RID: 18146 RVA: 0x0025B360 File Offset: 0x00259560
			public BestiaryEntriesPass(object @object, IntPtr method)
			{
				this.method_ptr = method;
				this.m_target = @object;
				this.method = method;
				this.method_code = this;
			}

			// Token: 0x060046E3 RID: 18147 RVA: 0x0025B3C0 File Offset: 0x002595C0
			public void Invoke(BestiaryEntry entry)
			{
				IntPtr method_code = this.method_code;
				IntPtr invoke_impl = this.invoke_impl;
				IntPtr method = this.method;
			}

			// Token: 0x060046E4 RID: 18148 RVA: 0x000021DB File Offset: 0x000003DB
			public IAsyncResult BeginInvoke(BestiaryEntry entry, AsyncCallback callback, object @object)
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}

			// Token: 0x060046E5 RID: 18149 RVA: 0x0025B3E4 File Offset: 0x002595E4
			public void EndInvoke(IAsyncResult result)
			{
			}
		}
	}
}
