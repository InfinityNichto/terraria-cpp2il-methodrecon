using System;

namespace System.ComponentModel
{
	// Token: 0x02000339 RID: 825
	public sealed class EventHandlerList : IDisposable
	{
		// Token: 0x0600158C RID: 5516 RVA: 0x00040444 File Offset: 0x0003E644
		internal EventHandlerList(Component parent)
		{
			this._parent = parent;
		}

		// Token: 0x0600158D RID: 5517 RVA: 0x00040460 File Offset: 0x0003E660
		public EventHandlerList()
		{
		}

		// Token: 0x170004E9 RID: 1257
		public Delegate this[object key]
		{
			get
			{
				Component parent = this._parent;
				if (parent != null)
				{
					bool canRaiseEventsInternal = parent.CanRaiseEventsInternal;
				}
				EventHandlerList.ListEntry head = this._head;
				EventHandlerList.ListEntry next;
				if (head != null)
				{
					object key2 = head._key;
					next = head._next;
					while (next != null)
					{
					}
				}
				return next._handler;
			}
			set
			{
				EventHandlerList.ListEntry head;
				do
				{
					head = this._head;
					if (head == null)
					{
						break;
					}
					object key2 = head._key;
				}
				while (head._next != null);
			}
		}

		// Token: 0x06001590 RID: 5520 RVA: 0x000404E4 File Offset: 0x0003E6E4
		public void AddHandler(object key, Delegate value)
		{
			EventHandlerList.ListEntry head;
			do
			{
				head = this._head;
				if (head == null)
				{
					break;
				}
				object key2 = head._key;
			}
			while (head._next != null);
		}

		// Token: 0x06001591 RID: 5521 RVA: 0x0004050C File Offset: 0x0003E70C
		public void AddHandlers(EventHandlerList listToAddFrom)
		{
			EventHandlerList.ListEntry head;
			do
			{
				head = listToAddFrom._head;
				if (head == null)
				{
					break;
				}
				object key = head._key;
				Delegate handler = head._handler;
				this.AddHandler(key, handler);
			}
			while (head._next != null);
		}

		// Token: 0x06001592 RID: 5522 RVA: 0x00040544 File Offset: 0x0003E744
		public void Dispose()
		{
		}

		// Token: 0x06001593 RID: 5523 RVA: 0x00040554 File Offset: 0x0003E754
		private EventHandlerList.ListEntry Find(object key)
		{
			EventHandlerList.ListEntry head = this._head;
			if (head != null)
			{
				object key2 = head._key;
			}
			return head;
		}

		// Token: 0x06001594 RID: 5524 RVA: 0x00040574 File Offset: 0x0003E774
		public void RemoveHandler(object key, Delegate value)
		{
			EventHandlerList.ListEntry head = this._head;
			if (head != null)
			{
				object key2 = head._key;
				EventHandlerList.ListEntry next = head._next;
				while (next != null)
				{
				}
				return;
			}
		}

		// Token: 0x0400119A RID: 4506
		private EventHandlerList.ListEntry _head;

		// Token: 0x0400119B RID: 4507
		private Component _parent;

		// Token: 0x0200033A RID: 826
		private sealed class ListEntry
		{
			// Token: 0x06001595 RID: 5525 RVA: 0x000405B4 File Offset: 0x0003E7B4
			public ListEntry(object key, Delegate handler, EventHandlerList.ListEntry next)
			{
				this._next = next;
				this._key = key;
				this._handler = handler;
			}

			// Token: 0x0400119C RID: 4508
			internal EventHandlerList.ListEntry _next;

			// Token: 0x0400119D RID: 4509
			internal object _key;

			// Token: 0x0400119E RID: 4510
			internal Delegate _handler;
		}
	}
}
