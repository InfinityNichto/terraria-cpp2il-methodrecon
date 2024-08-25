using System;
using System.Collections.ObjectModel;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;

namespace Microsoft.Xna.Framework
{
	// Token: 0x0200033A RID: 826
	public sealed class GameComponentCollection : Collection<IGameComponent>
	{
		// Token: 0x1400000C RID: 12
		// (add) Token: 0x060014DA RID: 5338 RVA: 0x0005F68C File Offset: 0x0005D88C
		// (remove) Token: 0x060014DB RID: 5339 RVA: 0x0005F6B4 File Offset: 0x0005D8B4
		public event EventHandler<GameComponentCollectionEventArgs> ComponentAdded
		{
			[CompilerGenerated]
			add
			{
				Delegate @delegate = Delegate.Combine(this.ComponentAdded, value);
				if (@delegate != null && @delegate == null)
				{
					return;
				}
			}
			[CompilerGenerated]
			remove
			{
				Delegate @delegate = Delegate.Remove(this.ComponentAdded, value);
				if (@delegate != null && @delegate == null)
				{
					return;
				}
			}
		}

		// Token: 0x1400000D RID: 13
		// (add) Token: 0x060014DC RID: 5340 RVA: 0x0005F6DC File Offset: 0x0005D8DC
		// (remove) Token: 0x060014DD RID: 5341 RVA: 0x0005F704 File Offset: 0x0005D904
		public event EventHandler<GameComponentCollectionEventArgs> ComponentRemoved
		{
			[CompilerGenerated]
			add
			{
				Delegate @delegate = Delegate.Combine(this.ComponentRemoved, value);
				if (@delegate != null && @delegate == null)
				{
					return;
				}
			}
			[CompilerGenerated]
			remove
			{
				if (Delegate.Remove(this.ComponentRemoved, value) == null)
				{
					return;
				}
			}
		}

		// Token: 0x060014DE RID: 5342 RVA: 0x0005F728 File Offset: 0x0005D928
		protected override void ClearItems()
		{
			int count = base.Count;
			long num = 0L;
			IGameComponent gameComponent = base[(int)num];
			if (this.ComponentRemoved != null)
			{
			}
			int count2 = base.Count;
			base.ClearItems();
		}

		// Token: 0x060014DF RID: 5343 RVA: 0x0005F75C File Offset: 0x0005D95C
		protected override void InsertItem(int index, IGameComponent item)
		{
			if (item != null && this.ComponentAdded != null)
			{
				return;
			}
		}

		// Token: 0x060014E0 RID: 5344 RVA: 0x0005F778 File Offset: 0x0005D978
		private void OnComponentAdded(GameComponentCollectionEventArgs eventArgs)
		{
			if (this.ComponentAdded != null)
			{
				return;
			}
		}

		// Token: 0x060014E1 RID: 5345 RVA: 0x0005F790 File Offset: 0x0005D990
		private void OnComponentRemoved(GameComponentCollectionEventArgs eventArgs)
		{
			if (this.ComponentRemoved != null)
			{
				return;
			}
		}

		// Token: 0x060014E2 RID: 5346 RVA: 0x0005F7A8 File Offset: 0x0005D9A8
		protected override void RemoveItem(int index)
		{
			IGameComponent gameComponent = base[index];
			base.RemoveItem(index);
			if (gameComponent != null && this.ComponentRemoved != null)
			{
				return;
			}
		}

		// Token: 0x060014E3 RID: 5347 RVA: 0x000021DB File Offset: 0x000003DB
		protected override void SetItem(int index, IGameComponent item)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x060014E4 RID: 5348 RVA: 0x0005F7D0 File Offset: 0x0005D9D0
		public GameComponentCollection()
		{
		}

		// Token: 0x040022C2 RID: 8898
		[CompilerGenerated]
		private EventHandler<GameComponentCollectionEventArgs> ComponentAdded;

		// Token: 0x040022C3 RID: 8899
		[CompilerGenerated]
		private EventHandler<GameComponentCollectionEventArgs> ComponentRemoved;
	}
}
