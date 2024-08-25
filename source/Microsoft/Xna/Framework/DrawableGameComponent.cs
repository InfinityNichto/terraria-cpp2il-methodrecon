using System;
using System.Runtime.CompilerServices;

namespace Microsoft.Xna.Framework
{
	// Token: 0x0200031E RID: 798
	public class DrawableGameComponent : GameComponent, IDrawable
	{
		// Token: 0x14000006 RID: 6
		// (add) Token: 0x0600128E RID: 4750 RVA: 0x0005A0A4 File Offset: 0x000582A4
		// (remove) Token: 0x0600128F RID: 4751 RVA: 0x0005A0CC File Offset: 0x000582CC
		public event EventHandler<EventArgs> DrawOrderChanged
		{
			[CompilerGenerated]
			add
			{
				Delegate @delegate = Delegate.Combine(this.DrawOrderChanged, value);
				if (@delegate != null && @delegate == null)
				{
					return;
				}
			}
			[CompilerGenerated]
			remove
			{
				Delegate @delegate = Delegate.Remove(this.DrawOrderChanged, value);
				if (@delegate != null && @delegate == null)
				{
					return;
				}
			}
		}

		// Token: 0x14000007 RID: 7
		// (add) Token: 0x06001290 RID: 4752 RVA: 0x0005A0F4 File Offset: 0x000582F4
		// (remove) Token: 0x06001291 RID: 4753 RVA: 0x0005A11C File Offset: 0x0005831C
		public event EventHandler<EventArgs> VisibleChanged
		{
			[CompilerGenerated]
			add
			{
				Delegate @delegate = Delegate.Combine(this.VisibleChanged, value);
				if (@delegate != null && @delegate == null)
				{
					return;
				}
			}
			[CompilerGenerated]
			remove
			{
				Delegate @delegate = Delegate.Remove(this.VisibleChanged, value);
				if (@delegate != null && @delegate == null)
				{
					return;
				}
			}
		}

		// Token: 0x06001292 RID: 4754 RVA: 0x0005A144 File Offset: 0x00058344
		public DrawableGameComponent(Game game)
			: base(game)
		{
			this.Visible = true;
		}

		// Token: 0x06001293 RID: 4755 RVA: 0x0005A160 File Offset: 0x00058360
		public override void Initialize()
		{
			if (this._isInitialized)
			{
				return;
			}
			this._isInitialized = true;
		}

		// Token: 0x06001294 RID: 4756 RVA: 0x0005A180 File Offset: 0x00058380
		protected virtual void LoadContent()
		{
		}

		// Token: 0x06001295 RID: 4757 RVA: 0x0005A190 File Offset: 0x00058390
		protected virtual void UnloadContent()
		{
		}

		// Token: 0x170001D5 RID: 469
		// (get) Token: 0x06001296 RID: 4758 RVA: 0x0005A1A0 File Offset: 0x000583A0
		// (set) Token: 0x06001297 RID: 4759 RVA: 0x0005A1B4 File Offset: 0x000583B4
		public int DrawOrder
		{
			get
			{
				return this._drawOrder;
			}
			set
			{
				EventHandler<EventArgs> drawOrderChanged = this.DrawOrderChanged;
				this._drawOrder = value;
				if (drawOrderChanged != null)
				{
				}
			}
		}

		// Token: 0x170001D6 RID: 470
		// (get) Token: 0x06001298 RID: 4760 RVA: 0x0005A1D4 File Offset: 0x000583D4
		// (set) Token: 0x06001299 RID: 4761 RVA: 0x0005A1E8 File Offset: 0x000583E8
		public bool Visible
		{
			get
			{
				return this._isVisible;
			}
			set
			{
				bool isVisible = this._isVisible;
			}
		}

		// Token: 0x0600129A RID: 4762 RVA: 0x0005A20C File Offset: 0x0005840C
		public virtual void Draw(GameTime gameTime)
		{
		}

		// Token: 0x0600129B RID: 4763 RVA: 0x0005A21C File Offset: 0x0005841C
		protected virtual void OnVisibleChanged(object sender, EventArgs args)
		{
		}

		// Token: 0x0600129C RID: 4764 RVA: 0x0005A22C File Offset: 0x0005842C
		protected virtual void OnDrawOrderChanged(object sender, EventArgs args)
		{
		}

		// Token: 0x04002217 RID: 8727
		private bool _isInitialized;

		// Token: 0x04002218 RID: 8728
		private bool _isVisible;

		// Token: 0x04002219 RID: 8729
		private int _drawOrder;

		// Token: 0x0400221A RID: 8730
		[CompilerGenerated]
		private EventHandler<EventArgs> DrawOrderChanged;

		// Token: 0x0400221B RID: 8731
		[CompilerGenerated]
		private EventHandler<EventArgs> VisibleChanged;
	}
}
