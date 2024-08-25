using System;
using System.Collections;
using System.Runtime.CompilerServices;
using Newtonsoft.Json.Shims;

namespace System.ComponentModel
{
	// Token: 0x02000007 RID: 7
	[Preserve]
	public class NotifyCollectionChangedEventArgs
	{
		// Token: 0x17000002 RID: 2
		// (get) Token: 0x0600000D RID: 13 RVA: 0x00002148 File Offset: 0x00000348
		// (set) Token: 0x0600000E RID: 14 RVA: 0x0000215C File Offset: 0x0000035C
		internal NotifyCollectionChangedAction Action
		{
			[CompilerGenerated]
			get
			{
				return this.<Action>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<Action>k__BackingField = value;
			}
		}

		// Token: 0x17000003 RID: 3
		// (get) Token: 0x0600000F RID: 15 RVA: 0x00002170 File Offset: 0x00000370
		// (set) Token: 0x06000010 RID: 16 RVA: 0x00002184 File Offset: 0x00000384
		internal IList NewItems
		{
			[CompilerGenerated]
			get
			{
				return this.<NewItems>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<NewItems>k__BackingField = value;
			}
		}

		// Token: 0x17000004 RID: 4
		// (get) Token: 0x06000011 RID: 17 RVA: 0x00002198 File Offset: 0x00000398
		// (set) Token: 0x06000012 RID: 18 RVA: 0x000021AC File Offset: 0x000003AC
		internal int NewStartingIndex
		{
			[CompilerGenerated]
			get
			{
				return this.<NewStartingIndex>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<NewStartingIndex>k__BackingField = value;
			}
		}

		// Token: 0x17000005 RID: 5
		// (get) Token: 0x06000013 RID: 19 RVA: 0x000021C0 File Offset: 0x000003C0
		// (set) Token: 0x06000014 RID: 20 RVA: 0x000021D4 File Offset: 0x000003D4
		internal IList OldItems
		{
			[CompilerGenerated]
			get
			{
				return this.<OldItems>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<OldItems>k__BackingField = value;
			}
		}

		// Token: 0x17000006 RID: 6
		// (get) Token: 0x06000015 RID: 21 RVA: 0x000021E8 File Offset: 0x000003E8
		// (set) Token: 0x06000016 RID: 22 RVA: 0x000021FC File Offset: 0x000003FC
		internal int OldStartingIndex
		{
			[CompilerGenerated]
			get
			{
				return this.<OldStartingIndex>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<OldStartingIndex>k__BackingField = value;
			}
		}

		// Token: 0x06000017 RID: 23 RVA: 0x00002210 File Offset: 0x00000410
		internal NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction action)
		{
			this.Action = action;
		}

		// Token: 0x06000018 RID: 24 RVA: 0x0000222C File Offset: 0x0000042C
		internal NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction action, IList changedItems)
		{
			this.Action = action;
			this.NewItems = changedItems;
		}

		// Token: 0x06000019 RID: 25 RVA: 0x00002250 File Offset: 0x00000450
		internal NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction action, object changedItem)
		{
			this.Action = action;
		}

		// Token: 0x0600001A RID: 26 RVA: 0x00002270 File Offset: 0x00000470
		internal NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction action, IList newItems, IList oldItems)
		{
			this.Action = action;
			this.NewItems = newItems;
			this.OldItems = oldItems;
		}

		// Token: 0x0600001B RID: 27 RVA: 0x00002298 File Offset: 0x00000498
		internal NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction action, IList changedItems, int startingIndex)
		{
			this.Action = action;
			this.NewItems = changedItems;
			this.NewStartingIndex = startingIndex;
		}

		// Token: 0x0600001C RID: 28 RVA: 0x000022C0 File Offset: 0x000004C0
		internal NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction action, object changedItem, int index)
		{
			this.NewStartingIndex = index;
		}

		// Token: 0x0600001D RID: 29 RVA: 0x000022D4 File Offset: 0x000004D4
		internal NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction action, object newItem, object oldItem)
		{
		}

		// Token: 0x0600001E RID: 30 RVA: 0x000022E4 File Offset: 0x000004E4
		internal NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction action, IList newItems, IList oldItems, int startingIndex)
		{
			this.Action = action;
			this.NewItems = newItems;
			this.OldItems = oldItems;
			this.NewStartingIndex = startingIndex;
		}

		// Token: 0x0600001F RID: 31 RVA: 0x00002314 File Offset: 0x00000514
		internal NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction action, IList changedItems, int index, int oldIndex)
		{
			this.Action = action;
			this.NewItems = changedItems;
			this.NewStartingIndex = index;
			this.OldStartingIndex = oldIndex;
		}

		// Token: 0x06000020 RID: 32 RVA: 0x00002344 File Offset: 0x00000544
		internal NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction action, object changedItem, int index, int oldIndex)
		{
			this.NewStartingIndex = index;
			this.OldStartingIndex = oldIndex;
		}

		// Token: 0x06000021 RID: 33 RVA: 0x00002360 File Offset: 0x00000560
		internal NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction action, object newItem, object oldItem, int index)
		{
			this.NewStartingIndex = index;
		}

		// Token: 0x04000008 RID: 8
		[CompilerGenerated]
		private NotifyCollectionChangedAction <Action>k__BackingField;

		// Token: 0x04000009 RID: 9
		[CompilerGenerated]
		private IList <NewItems>k__BackingField;

		// Token: 0x0400000A RID: 10
		[CompilerGenerated]
		private int <NewStartingIndex>k__BackingField;

		// Token: 0x0400000B RID: 11
		[CompilerGenerated]
		private IList <OldItems>k__BackingField;

		// Token: 0x0400000C RID: 12
		[CompilerGenerated]
		private int <OldStartingIndex>k__BackingField;
	}
}
