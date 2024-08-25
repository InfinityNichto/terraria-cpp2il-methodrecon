using System;
using System.Runtime.CompilerServices;

namespace System.Diagnostics.Tracing
{
	// Token: 0x020005DA RID: 1498
	public class EventSource : IDisposable
	{
		// Token: 0x06002D80 RID: 11648 RVA: 0x00064B20 File Offset: 0x00062D20
		protected EventSource()
		{
			Type type = base.GetType();
			this.Name = type;
		}

		// Token: 0x06002D81 RID: 11649 RVA: 0x00064B44 File Offset: 0x00062D44
		public EventSource(string eventSourceName)
		{
			this.Name = eventSourceName;
		}

		// Token: 0x06002D82 RID: 11650 RVA: 0x00064B60 File Offset: 0x00062D60
		internal EventSource(Guid eventSourceGuid, string eventSourceName)
		{
		}

		// Token: 0x06002D83 RID: 11651 RVA: 0x00064B74 File Offset: 0x00062D74
		protected override void Finalize()
		{
			base.Finalize();
		}

		// Token: 0x170006ED RID: 1773
		// (set) Token: 0x06002D84 RID: 11652 RVA: 0x00064BA8 File Offset: 0x00062DA8
		private string Name
		{
			[CompilerGenerated]
			set
			{
				this.<Name>k__BackingField = value;
			}
		}

		// Token: 0x06002D85 RID: 11653 RVA: 0x00064BBC File Offset: 0x00062DBC
		public bool IsEnabled()
		{
		}

		// Token: 0x06002D86 RID: 11654 RVA: 0x00064BCC File Offset: 0x00062DCC
		public bool IsEnabled(EventLevel level, EventKeywords keywords)
		{
		}

		// Token: 0x06002D87 RID: 11655 RVA: 0x00064BDC File Offset: 0x00062DDC
		public void Dispose()
		{
			GC.SuppressFinalize(this);
		}

		// Token: 0x06002D88 RID: 11656 RVA: 0x00064BF0 File Offset: 0x00062DF0
		protected virtual void Dispose(bool disposing)
		{
		}

		// Token: 0x06002D89 RID: 11657 RVA: 0x00064C00 File Offset: 0x00062E00
		protected void WriteEvent(int eventId, int arg1)
		{
		}

		// Token: 0x06002D8A RID: 11658 RVA: 0x00064C14 File Offset: 0x00062E14
		protected void WriteEvent(int eventId, int arg1, int arg2)
		{
		}

		// Token: 0x06002D8B RID: 11659 RVA: 0x00064C28 File Offset: 0x00062E28
		protected void WriteEvent(int eventId, int arg1, int arg2, int arg3)
		{
		}

		// Token: 0x06002D8C RID: 11660 RVA: 0x00064C3C File Offset: 0x00062E3C
		protected void WriteEvent(int eventId, params object[] args)
		{
		}

		// Token: 0x06002D8D RID: 11661 RVA: 0x00064C4C File Offset: 0x00062E4C
		protected void WriteEvent(int eventId, string arg1, string arg2, string arg3)
		{
			if ((arg1 == null || arg1 != null) && (arg2 == null || arg2 != null) && (arg3 == null || arg3 != null))
			{
				return;
			}
			throw new ArrayTypeMismatchException();
		}

		// Token: 0x06002D8E RID: 11662 RVA: 0x00064C74 File Offset: 0x00062E74
		[CLSCompliant(false)]
		protected unsafe void WriteEventCore(int eventId, int eventDataCount, EventSource.EventData* data)
		{
		}

		// Token: 0x0400198B RID: 6539
		[CompilerGenerated]
		private string <Name>k__BackingField;

		// Token: 0x020005DB RID: 1499
		protected internal struct EventData
		{
			// Token: 0x170006EE RID: 1774
			// (set) Token: 0x06002D8F RID: 11663 RVA: 0x00064C84 File Offset: 0x00062E84
			public IntPtr DataPointer
			{
				[CompilerGenerated]
				set
				{
					this.<DataPointer>k__BackingField = value;
				}
			}

			// Token: 0x170006EF RID: 1775
			// (set) Token: 0x06002D90 RID: 11664 RVA: 0x00064C98 File Offset: 0x00062E98
			public int Size
			{
				[CompilerGenerated]
				set
				{
					this.<Size>k__BackingField = value;
				}
			}

			// Token: 0x170006F0 RID: 1776
			// (set) Token: 0x06002D91 RID: 11665 RVA: 0x00064CAC File Offset: 0x00062EAC
			internal int Reserved
			{
				[CompilerGenerated]
				set
				{
					this.<Reserved>k__BackingField = value;
				}
			}

			// Token: 0x0400198C RID: 6540
			[CompilerGenerated]
			private IntPtr <DataPointer>k__BackingField;

			// Token: 0x0400198D RID: 6541
			[CompilerGenerated]
			private int <Size>k__BackingField;

			// Token: 0x0400198E RID: 6542
			[CompilerGenerated]
			private int <Reserved>k__BackingField;
		}
	}
}
