using System;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using ReLogic.Content;

namespace Terraria.GameContent.UI.ResourceSets
{
	// Token: 0x02000A88 RID: 2696
	public struct ResourceDrawSettings
	{
		// Token: 0x06004FA7 RID: 20391 RVA: 0x0027AFEC File Offset: 0x002791EC
		public void Draw(SpriteBatch spriteBatch, bool isHovered)
		{
			int elementCount = this.ElementCount;
			Vector2 topLeftAnchor = this.TopLeftAnchor;
			if (elementCount == 0)
			{
			}
			Vector2 mouseScreen = Main.MouseScreen;
			if (elementCount == 0)
			{
			}
			ResourceDrawSettings.TextureGetter getTextureMethod = this.GetTextureMethod;
			int elementIndexOffset = this.ElementIndexOffset;
			IntPtr invoke_impl = getTextureMethod.invoke_impl;
			IntPtr method_code = getTextureMethod.method_code;
			IntPtr method = getTextureMethod.method;
			if (method == 0)
			{
			}
			if (method != 0)
			{
			}
			float x = this.OffsetSpriteAnchor.X;
			float y = this.OffsetSpriteAnchor.Y;
			Rectangle rectangle;
			Vector2 vector = rectangle.Size();
			float x2 = this.OffsetSpriteAnchorByTexturePercentile.X;
			float y2 = this.OffsetSpriteAnchorByTexturePercentile.Y;
			float x3 = this.OffsetPerDraw.X;
			float y3 = this.OffsetPerDraw.Y;
			Vector2 vector2 = rectangle.Size();
			float x4 = this.OffsetPerDrawByTexturePercentile.X;
			float y4 = this.OffsetPerDrawByTexturePercentile.Y;
		}

		// Token: 0x04008890 RID: 34960
		public Vector2 TopLeftAnchor;

		// Token: 0x04008891 RID: 34961
		public int ElementCount;

		// Token: 0x04008892 RID: 34962
		public int ElementIndexOffset;

		// Token: 0x04008893 RID: 34963
		public ResourceDrawSettings.TextureGetter GetTextureMethod;

		// Token: 0x04008894 RID: 34964
		public Vector2 OffsetPerDraw;

		// Token: 0x04008895 RID: 34965
		public Vector2 OffsetPerDrawByTexturePercentile;

		// Token: 0x04008896 RID: 34966
		public Vector2 OffsetSpriteAnchor;

		// Token: 0x04008897 RID: 34967
		public Vector2 OffsetSpriteAnchorByTexturePercentile;

		// Token: 0x02000A89 RID: 2697
		public sealed class TextureGetter : MulticastDelegate
		{
			// Token: 0x06004FA8 RID: 20392 RVA: 0x0027B0DC File Offset: 0x002792DC
			public TextureGetter(object @object, IntPtr method)
			{
				this.method_ptr = method;
				this.m_target = @object;
				this.method = method;
				this.method_code = this;
			}

			// Token: 0x06004FA9 RID: 20393 RVA: 0x0027B130 File Offset: 0x00279330
			public void Invoke(int elementIndex, int firstElementIndex, int lastElementIndex, [Out] Asset<Texture2D> texture, [Out] Vector2 drawOffset, [Out] float drawScale, [Out] Rectangle? sourceRect)
			{
				IntPtr method_code = this.method_code;
				IntPtr invoke_impl = this.invoke_impl;
				IntPtr method = this.method;
			}

			// Token: 0x06004FAA RID: 20394 RVA: 0x000021DB File Offset: 0x000003DB
			public IAsyncResult BeginInvoke(int elementIndex, int firstElementIndex, int lastElementIndex, [Out] Asset<Texture2D> texture, [Out] Vector2 drawOffset, [Out] float drawScale, [Out] Rectangle? sourceRect, AsyncCallback callback, object @object)
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}

			// Token: 0x06004FAB RID: 20395 RVA: 0x0027B154 File Offset: 0x00279354
			public void EndInvoke([Out] Asset<Texture2D> texture, [Out] Vector2 drawOffset, [Out] float drawScale, [Out] Rectangle? sourceRect, IAsyncResult result)
			{
			}
		}
	}
}
