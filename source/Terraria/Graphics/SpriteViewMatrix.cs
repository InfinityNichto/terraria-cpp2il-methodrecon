using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Terraria.Graphics
{
	// Token: 0x02000733 RID: 1843
	public class SpriteViewMatrix
	{
		// Token: 0x17000775 RID: 1909
		// (get) Token: 0x06003CF8 RID: 15608 RVA: 0x00237F74 File Offset: 0x00236174
		// (set) Token: 0x06003CF9 RID: 15609 RVA: 0x00237F9C File Offset: 0x0023619C
		public Vector2 Zoom
		{
			get
			{
				float x = this._zoom.X;
				float y = this._zoom.Y;
				Vector2 vector;
				return vector;
			}
			set
			{
				float x = this._zoom.X;
				float y = this._zoom.Y;
				if (!true)
				{
				}
				this._needsRebuild = true;
			}
		}

		// Token: 0x17000776 RID: 1910
		// (get) Token: 0x06003CFA RID: 15610 RVA: 0x00237FD0 File Offset: 0x002361D0
		public Vector2 Translation
		{
			get
			{
				bool flag = this.ShouldRebuild();
				this.Rebuild();
				float x = this._translation.X;
				float y = this._translation.Y;
				Vector2 vector;
				return vector;
			}
		}

		// Token: 0x17000777 RID: 1911
		// (get) Token: 0x06003CFB RID: 15611 RVA: 0x00238004 File Offset: 0x00236204
		public Matrix ZoomMatrix
		{
			get
			{
				bool flag = this.ShouldRebuild();
				this.Rebuild();
				float m = this._zoomMatrix.M31;
				float m2 = this._zoomMatrix.M32;
				float m3 = this._zoomMatrix.M11;
				float m4 = this._zoomMatrix.M12;
				Matrix matrix;
				matrix.M31 = m;
				matrix.M32 = m2;
				matrix.M11 = m3;
				matrix.M12 = m4;
				return matrix;
			}
		}

		// Token: 0x17000778 RID: 1912
		// (get) Token: 0x06003CFC RID: 15612 RVA: 0x00238070 File Offset: 0x00236270
		public Matrix TransformationMatrix
		{
			get
			{
				bool flag = this.ShouldRebuild();
				this.Rebuild();
				float m = this._transformationMatrix.M31;
				float m2 = this._transformationMatrix.M32;
				float m3 = this._transformationMatrix.M11;
				float m4 = this._transformationMatrix.M12;
				Matrix matrix;
				matrix.M31 = m;
				matrix.M32 = m2;
				matrix.M11 = m3;
				matrix.M12 = m4;
				return matrix;
			}
		}

		// Token: 0x17000779 RID: 1913
		// (get) Token: 0x06003CFD RID: 15613 RVA: 0x002380DC File Offset: 0x002362DC
		public Matrix NormalizedTransformationmatrix
		{
			get
			{
				bool flag = this.ShouldRebuild();
				this.Rebuild();
				float m = this._normalizedTransformationMatrix.M31;
				float m2 = this._normalizedTransformationMatrix.M32;
				float m3 = this._normalizedTransformationMatrix.M11;
				float m4 = this._normalizedTransformationMatrix.M12;
				Matrix matrix;
				matrix.M31 = m;
				matrix.M32 = m2;
				matrix.M11 = m3;
				matrix.M12 = m4;
				return matrix;
			}
		}

		// Token: 0x1700077A RID: 1914
		// (get) Token: 0x06003CFE RID: 15614 RVA: 0x00238148 File Offset: 0x00236348
		// (set) Token: 0x06003CFF RID: 15615 RVA: 0x0023815C File Offset: 0x0023635C
		public SpriteEffects Effects
		{
			get
			{
				return this._effects;
			}
			set
			{
				SpriteEffects effects = this._effects;
				this._effects = value;
				this._needsRebuild = true;
			}
		}

		// Token: 0x1700077B RID: 1915
		// (get) Token: 0x06003D00 RID: 15616 RVA: 0x00238180 File Offset: 0x00236380
		public Matrix EffectMatrix
		{
			get
			{
				bool flag = this.ShouldRebuild();
				this.Rebuild();
				Matrix matrix;
				float m = matrix.M31;
				float m2 = matrix.M32;
				matrix.M31 = m;
				matrix.M32 = m2;
				return matrix;
			}
		}

		// Token: 0x06003D01 RID: 15617 RVA: 0x002381B8 File Offset: 0x002363B8
		public SpriteViewMatrix(GraphicsDevice graphicsDevice)
		{
			if (!true)
			{
			}
			if (!true)
			{
			}
			this._zoom = 1;
			if (!true)
			{
			}
			this._translation = 1;
			if (!true)
			{
			}
			if (true)
			{
				return;
			}
			if (true)
			{
				return;
			}
			if (!true)
			{
			}
			this._needsRebuild = true;
			base..ctor();
			this._graphicsDevice = graphicsDevice;
		}

		// Token: 0x06003D02 RID: 15618 RVA: 0x00238200 File Offset: 0x00236400
		private void Rebuild()
		{
			bool overrideSystemViewport = this._overrideSystemViewport;
			if (!overrideSystemViewport)
			{
				Viewport viewport = this._graphicsDevice.Viewport;
				this._viewport.minDepth = overrideSystemViewport;
			}
			int width = this._viewport.width;
			int height = this._viewport.height;
			if (!overrideSystemViewport)
			{
			}
			int num = 1;
			if (num == 0)
			{
			}
			int value = num.m_value;
			if (this._effects == SpriteEffects.None)
			{
			}
			SpriteEffects effects = this._effects;
			if (effects == SpriteEffects.None)
			{
			}
			if (effects == SpriteEffects.None)
			{
			}
			float x = this._zoom.X;
			float y = this._zoom.Y;
			if (effects == SpriteEffects.None)
			{
			}
			float x2 = this._zoom.X;
			float y2 = this._zoom.Y;
			this._zoomMatrix.M11 = (float)value;
			this._transformationMatrix.M11 = (float)value;
			Matrix matrix2;
			Matrix matrix = Matrix.Invert(matrix2);
			float m = this._zoomMatrix.M31;
			float m2 = this._zoomMatrix.M32;
			float m3 = this._zoomMatrix.M11;
			float m4 = this._zoomMatrix.M12;
			this._normalizedTransformationMatrix.M31 = m4;
			this._normalizedTransformationMatrix.M32 = m2;
			this._normalizedTransformationMatrix.M11 = m3;
			this._normalizedTransformationMatrix.M12 = m;
		}

		// Token: 0x06003D03 RID: 15619 RVA: 0x00238350 File Offset: 0x00236550
		public void SetViewportOverride(Viewport viewport)
		{
			float minDepth = viewport.minDepth;
			this._overrideSystemViewport = true;
			this._viewport.minDepth = minDepth;
		}

		// Token: 0x06003D04 RID: 15620 RVA: 0x00238378 File Offset: 0x00236578
		public void ClearViewportOverride()
		{
		}

		// Token: 0x06003D05 RID: 15621 RVA: 0x00238388 File Offset: 0x00236588
		private bool ShouldRebuild()
		{
			for (;;)
			{
				bool needsRebuild = this._needsRebuild;
				if (needsRebuild)
				{
					break;
				}
				if (needsRebuild)
				{
					return;
				}
			}
			return true;
		}

		// Token: 0x04007BF3 RID: 31731
		private Vector2 _zoom;

		// Token: 0x04007BF4 RID: 31732
		private Vector2 _translation;

		// Token: 0x04007BF5 RID: 31733
		private Matrix _zoomMatrix;

		// Token: 0x04007BF6 RID: 31734
		private Matrix _transformationMatrix;

		// Token: 0x04007BF7 RID: 31735
		private Matrix _normalizedTransformationMatrix;

		// Token: 0x04007BF8 RID: 31736
		private SpriteEffects _effects;

		// Token: 0x04007BF9 RID: 31737
		private Matrix _effectMatrix;

		// Token: 0x04007BFA RID: 31738
		private GraphicsDevice _graphicsDevice;

		// Token: 0x04007BFB RID: 31739
		private Viewport _viewport;

		// Token: 0x04007BFC RID: 31740
		private bool _overrideSystemViewport;

		// Token: 0x04007BFD RID: 31741
		private bool _needsRebuild;
	}
}
