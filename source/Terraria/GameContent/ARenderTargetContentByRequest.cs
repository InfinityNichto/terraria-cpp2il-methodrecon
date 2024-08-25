using System;
using Microsoft.Xna.Framework.Graphics;

namespace Terraria.GameContent
{
	// Token: 0x020007C9 RID: 1993
	public abstract class ARenderTargetContentByRequest : INeedRenderTargetContent
	{
		// Token: 0x170007BD RID: 1981
		// (get) Token: 0x06004098 RID: 16536 RVA: 0x002437DC File Offset: 0x002419DC
		public bool IsReady
		{
			get
			{
				return this._wasPrepared;
			}
		}

		// Token: 0x06004099 RID: 16537 RVA: 0x002437F0 File Offset: 0x002419F0
		public void Request()
		{
			this._wasRequested = true;
		}

		// Token: 0x0600409A RID: 16538 RVA: 0x00243804 File Offset: 0x00241A04
		public RenderTarget2D GetTarget()
		{
			return this._target;
		}

		// Token: 0x0600409B RID: 16539 RVA: 0x00243818 File Offset: 0x00241A18
		public void PrepareRenderTarget(GraphicsDevice device, SpriteBatch spriteBatch)
		{
			if (this._wasRequested)
			{
				return;
			}
		}

		// Token: 0x0600409C RID: 16540
		protected abstract void HandleUseReqest(GraphicsDevice device, SpriteBatch spriteBatch);

		// Token: 0x0600409D RID: 16541 RVA: 0x00243830 File Offset: 0x00241A30
		protected void PrepareARenderTarget_AndListenToEvents(RenderTarget2D target, GraphicsDevice device, int neededWidth, int neededHeight, RenderTargetUsage usage)
		{
		}

		// Token: 0x0600409E RID: 16542 RVA: 0x00243840 File Offset: 0x00241A40
		private void target_Disposing(object sender, EventArgs e)
		{
		}

		// Token: 0x0600409F RID: 16543 RVA: 0x00243850 File Offset: 0x00241A50
		private void target_ContentLost(object sender, EventArgs e)
		{
		}

		// Token: 0x060040A0 RID: 16544 RVA: 0x00243860 File Offset: 0x00241A60
		public void Reset()
		{
		}

		// Token: 0x060040A1 RID: 16545 RVA: 0x00243870 File Offset: 0x00241A70
		protected void PrepareARenderTarget_WithoutListeningToEvents(RenderTarget2D target, GraphicsDevice device, int neededWidth, int neededHeight, RenderTargetUsage usage)
		{
		}

		// Token: 0x060040A2 RID: 16546 RVA: 0x00243880 File Offset: 0x00241A80
		protected ARenderTargetContentByRequest()
		{
		}

		// Token: 0x04007E51 RID: 32337
		protected RenderTarget2D _target;

		// Token: 0x04007E52 RID: 32338
		protected bool _wasPrepared;

		// Token: 0x04007E53 RID: 32339
		private bool _wasRequested;
	}
}
