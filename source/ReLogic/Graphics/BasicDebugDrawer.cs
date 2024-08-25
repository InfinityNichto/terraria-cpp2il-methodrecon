using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace ReLogic.Graphics
{
	// Token: 0x02000B36 RID: 2870
	public class BasicDebugDrawer : IDebugDrawer, IDisposable
	{
		// Token: 0x060053B0 RID: 21424 RVA: 0x00284D1C File Offset: 0x00282F1C
		public BasicDebugDrawer(GraphicsDevice graphicsDevice)
		{
		}

		// Token: 0x060053B1 RID: 21425 RVA: 0x00284D3C File Offset: 0x00282F3C
		public void Begin(Matrix matrix)
		{
			float m = matrix.M11;
			float m2 = matrix.M12;
			float m3 = matrix.M31;
			float m4 = matrix.M32;
			SpriteBatch spriteBatch = this._spriteBatch;
		}

		// Token: 0x060053B2 RID: 21426 RVA: 0x00284D70 File Offset: 0x00282F70
		public void Begin()
		{
			SpriteBatch spriteBatch = this._spriteBatch;
		}

		// Token: 0x060053B3 RID: 21427 RVA: 0x00284D84 File Offset: 0x00282F84
		public void DrawSquare(Vector4 positionAndSize, Color color)
		{
			SpriteBatch spriteBatch = this._spriteBatch;
			Texture2D texture = this._texture;
			if (!true)
			{
			}
			if (!true)
			{
			}
		}

		// Token: 0x060053B4 RID: 21428 RVA: 0x00284DA8 File Offset: 0x00282FA8
		public void DrawSquare(Vector2 position, Vector2 size, Color color)
		{
			SpriteBatch spriteBatch = this._spriteBatch;
			Texture2D texture = this._texture;
			if (!true)
			{
			}
			if (!true)
			{
			}
		}

		// Token: 0x060053B5 RID: 21429 RVA: 0x00284DCC File Offset: 0x00282FCC
		public void DrawSquareFromCenter(Vector2 center, Vector2 size, float rotation, Color color)
		{
			SpriteBatch spriteBatch = this._spriteBatch;
			Texture2D texture = this._texture;
			if (!true)
			{
			}
		}

		// Token: 0x060053B6 RID: 21430 RVA: 0x00284DEC File Offset: 0x00282FEC
		public void DrawLine(Vector2 start, Vector2 end, float width, Color color)
		{
			if (!true)
			{
			}
			if (!true)
			{
			}
			SpriteBatch spriteBatch = this._spriteBatch;
			Texture2D texture = this._texture;
		}

		// Token: 0x060053B7 RID: 21431 RVA: 0x00284E14 File Offset: 0x00283014
		public void End()
		{
			this._spriteBatch.End();
		}

		// Token: 0x060053B8 RID: 21432 RVA: 0x00284E2C File Offset: 0x0028302C
		protected virtual void Dispose(bool disposing)
		{
			if (!this._disposedValue)
			{
				SpriteBatch spriteBatch = this._spriteBatch;
				if (spriteBatch != null)
				{
					spriteBatch.Dispose();
				}
				Texture2D texture = this._texture;
				if (texture != null)
				{
					texture.Dispose();
				}
				this._disposedValue = true;
			}
		}

		// Token: 0x060053B9 RID: 21433 RVA: 0x00284E68 File Offset: 0x00283068
		public void Dispose()
		{
		}

		// Token: 0x04008CE8 RID: 36072
		private SpriteBatch _spriteBatch;

		// Token: 0x04008CE9 RID: 36073
		private Texture2D _texture;

		// Token: 0x04008CEA RID: 36074
		private bool _disposedValue;
	}
}
