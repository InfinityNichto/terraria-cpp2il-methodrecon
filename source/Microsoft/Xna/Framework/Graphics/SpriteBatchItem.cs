using System;
using Terraria.Graphics;
using Unity.IL2CPP.CompilerServices;
using UnityEngine;

namespace Microsoft.Xna.Framework.Graphics
{
	// Token: 0x0200038F RID: 911
	public class SpriteBatchItem
	{
		// Token: 0x0600184D RID: 6221 RVA: 0x00068138 File Offset: 0x00066338
		public static void PushExpandedClippingRegion()
		{
			if (!true)
			{
			}
		}

		// Token: 0x0600184E RID: 6222 RVA: 0x0006814C File Offset: 0x0006634C
		public static void PopExpandedClippingRegion()
		{
			if (!true)
			{
			}
		}

		// Token: 0x0600184F RID: 6223 RVA: 0x00068160 File Offset: 0x00066360
		public static void EnableClipping(Rectangle inner, Rectangle outer, SpriteBatch batcher, bool vertical)
		{
			int num = 1;
			if (num == 0)
			{
			}
			if (num == 0)
			{
			}
		}

		// Token: 0x06001850 RID: 6224 RVA: 0x00068178 File Offset: 0x00066378
		public static void PushClippedImageRegion(Rectangle region, SpriteBatch batcher, bool enableGeometryScale, Vector2 geometryScaleCentre, float geometryScale)
		{
			int num = 1;
			if (num == 0)
			{
			}
			if (num == 0)
			{
			}
		}

		// Token: 0x06001851 RID: 6225 RVA: 0x000681A0 File Offset: 0x000663A0
		public static void PopClippedImageRegion()
		{
			if (!true)
			{
			}
			int num = 1;
			if (num == 0)
			{
			}
			int value = num.m_value;
		}

		// Token: 0x06001852 RID: 6226 RVA: 0x000681C4 File Offset: 0x000663C4
		public static void DisabledClipping()
		{
			if (!true)
			{
			}
		}

		// Token: 0x06001853 RID: 6227 RVA: 0x000681D4 File Offset: 0x000663D4
		public static void SetGeometryOffset(SpriteBatch batcher, bool enabled, Vector2 offset)
		{
			if (!true)
			{
			}
			if (!true)
			{
			}
		}

		// Token: 0x06001854 RID: 6228 RVA: 0x000681E8 File Offset: 0x000663E8
		public SpriteBatchItem()
		{
		}

		// Token: 0x06001855 RID: 6229 RVA: 0x000681FC File Offset: 0x000663FC
		[Il2CppSetOption(Option.NullChecks, false)]
		[Il2CppSetOption(Option.ArrayBoundsChecks, false)]
		public void Set(float x, float y, float dx, float dy, float w, float h, float sin, float cos, Color color, Vector2 texCoordTL, Vector2 texCoordBR)
		{
			int num = 1;
			byte r = color.R;
			if (num == 0)
			{
			}
			byte g = color.G;
			byte b = color.B;
			Texture2D texture = this.Texture;
			if (texture == null)
			{
				bool flag;
				this.vertexTL.Color.a = (flag ? 1 : 0);
				float y2 = texCoordTL.Y;
				this.vertexTR.Color.a = (flag ? 1 : 0);
				float num2;
				this.vertexTL.TextureCoordinate.y = num2;
				float y3 = texCoordTL.Y;
				this.vertexBL.Color.a = (flag ? 1 : 0);
				float num3;
				this.vertexTR.TextureCoordinate.y = num3;
				float y4 = texCoordBR.Y;
				this.vertexBR.Color.a = (flag ? 1 : 0);
				float y5 = texCoordBR.Y;
				this.vertexBR.TextureCoordinate.y = y5;
				return;
			}
			TextureAtlasEntry packedEntry = texture.PackedEntry;
			if (packedEntry != null)
			{
				int unityWidth = texture.UnityWidth;
				int unityHeight = texture.UnityHeight;
				short textureHeight = packedEntry.TextureHeight;
				short textureOffsetX = packedEntry.TextureOffsetX;
				short textureOffsetY = packedEntry.TextureOffsetY;
				int tileDataOffset = packedEntry.TileDataOffset;
				short textureScale = packedEntry.TextureScale;
				float x2 = texCoordBR.X;
				float y6 = texCoordBR.Y;
				bool tileTrimming = packedEntry.TileTrimming;
				float x3 = texCoordTL.X;
				float y7 = texCoordTL.Y;
				float x4 = texCoordBR.X;
				float y8 = texCoordBR.Y;
				if (textureOffsetX == 0)
				{
				}
				return;
			}
		}

		// Token: 0x06001856 RID: 6230 RVA: 0x00068474 File Offset: 0x00066674
		[Il2CppSetOption(Option.NullChecks, false)]
		[Il2CppSetOption(Option.ArrayBoundsChecks, false)]
		public void Set(float x, float y, float dx, float dy, float w, float h, float sin, float cos, VertexColors colors, Vector2 texCoordTL, Vector2 texCoordBR)
		{
			Texture2D texture = this.Texture;
			if (texture == null)
			{
				float num;
				this.vertexTL.Position = num;
				float y2 = texCoordTL.Y;
				float num2;
				this.vertexTL.TextureCoordinate.y = num2;
				byte r = colors.TopRightColor.R;
				this.vertexTR.Color = r;
				byte g = colors.TopRightColor.G;
				this.vertexTR.Color.g = g;
				byte b = colors.TopRightColor.B;
				this.vertexTR.Color.b = b;
				Color topRightColor = colors.TopRightColor;
				this.vertexTR.Color.a = topRightColor;
				float y3 = texCoordTL.Y;
				float num3;
				this.vertexTR.TextureCoordinate.y = num3;
				byte r2 = colors.BottomLeftColor.R;
				this.vertexBL.Color = r2;
				byte g2 = colors.BottomLeftColor.G;
				this.vertexBL.Color.g = g2;
				byte b2 = colors.BottomLeftColor.B;
				this.vertexBL.Color.b = b2;
				Color bottomLeftColor = colors.BottomLeftColor;
				this.vertexBL.Color.a = bottomLeftColor;
				float y4 = texCoordBR.Y;
				this.vertexBL.TextureCoordinate.y = y4;
				this.vertexBR.Position = num3;
				byte r3 = colors.BottomRightColor.R;
				this.vertexBR.Color = r3;
				byte g3 = colors.BottomRightColor.G;
				this.vertexBR.Color.g = g3;
				byte b3 = colors.BottomRightColor.B;
				this.vertexBR.Color.b = b3;
				Color bottomRightColor = colors.BottomRightColor;
				this.vertexBR.Color.a = bottomRightColor;
				float y5 = texCoordBR.Y;
				this.vertexBR.TextureCoordinate.y = y5;
				return;
			}
			TextureAtlasEntry packedEntry = texture.PackedEntry;
			if (packedEntry != null)
			{
				int unityWidth = texture.UnityWidth;
				int unityHeight = texture.UnityHeight;
				short textureHeight = packedEntry.TextureHeight;
				short textureOffsetX = packedEntry.TextureOffsetX;
				short textureOffsetY = packedEntry.TextureOffsetY;
				short textureScale = packedEntry.TextureScale;
				float x2 = texCoordTL.X;
				float y6 = texCoordTL.Y;
				float x3 = texCoordBR.X;
				float y7 = texCoordBR.Y;
				bool tileTrimming = packedEntry.TileTrimming;
				float x4 = texCoordTL.X;
				float y8 = texCoordTL.Y;
				float x5 = texCoordBR.X;
				float y9 = texCoordBR.Y;
				if (textureOffsetX == 0)
				{
				}
				return;
			}
		}

		// Token: 0x06001857 RID: 6231 RVA: 0x00068808 File Offset: 0x00066A08
		[Il2CppSetOption(Option.ArrayBoundsChecks, false)]
		[Il2CppSetOption(Option.NullChecks, false)]
		public void Set(float x, float y, float w, float h, Color color, Vector2 texCoordTL, Vector2 texCoordBR)
		{
			int num = 1;
			byte r = color.R;
			if (num == 0)
			{
			}
			byte g = color.G;
			byte b = color.B;
			Texture2D texture = this.Texture;
			if (texture == null)
			{
				bool flag;
				this.vertexTL.Color.a = (flag ? 1 : 0);
				float y2 = texCoordTL.Y;
				this.vertexTR.Color.a = (flag ? 1 : 0);
				this.vertexTL.TextureCoordinate.y = y2;
				float y3 = texCoordTL.Y;
				this.vertexBL.Color.a = (flag ? 1 : 0);
				this.vertexTR.TextureCoordinate.y = y3;
				float y4 = texCoordBR.Y;
				this.vertexBL.TextureCoordinate.y = y2;
				this.vertexBR.Color.a = (flag ? 1 : 0);
				float y5 = texCoordBR.Y;
				this.vertexBR.TextureCoordinate.y = y5;
				return;
			}
			TextureAtlasEntry packedEntry = texture.PackedEntry;
			if (packedEntry != null)
			{
				int unityWidth = texture.UnityWidth;
				int unityHeight = texture.UnityHeight;
				int tileDataOffset = packedEntry.TileDataOffset;
				short textureHeight = packedEntry.TextureHeight;
				short textureOffsetX = packedEntry.TextureOffsetX;
				short textureOffsetY = packedEntry.TextureOffsetY;
				short textureScale = packedEntry.TextureScale;
				float x2 = texCoordTL.X;
				float y6 = texCoordTL.Y;
				float x3 = texCoordBR.X;
				float y7 = texCoordBR.Y;
				bool tileTrimming = packedEntry.TileTrimming;
				float x4 = texCoordTL.X;
				float y8 = texCoordTL.Y;
				float x5 = texCoordBR.X;
				float y9 = texCoordBR.Y;
				if (textureOffsetX == 0)
				{
				}
				return;
			}
		}

		// Token: 0x06001858 RID: 6232 RVA: 0x00068A90 File Offset: 0x00066C90
		[Il2CppSetOption(Option.NullChecks, false)]
		[Il2CppSetOption(Option.ArrayBoundsChecks, false)]
		public void Set(float x, float y, float w, float h, VertexColors color, Vector2 texCoordTL, Vector2 texCoordBR)
		{
			Texture2D texture = this.Texture;
			if (texture == null)
			{
				float y2 = texCoordTL.Y;
				this.vertexTL.TextureCoordinate.y = y2;
				byte r = color.TopRightColor.R;
				this.vertexTR.Color = r;
				byte g = color.TopRightColor.G;
				this.vertexTR.Color.g = g;
				byte b = color.TopRightColor.B;
				this.vertexTR.Color.b = b;
				Color topRightColor = color.TopRightColor;
				this.vertexTR.Color.a = topRightColor;
				float y3 = texCoordTL.Y;
				this.vertexTR.TextureCoordinate.y = y3;
				byte r2 = color.BottomLeftColor.R;
				this.vertexBL.Color = r2;
				byte g2 = color.BottomLeftColor.G;
				this.vertexBL.Color.g = g2;
				byte b2 = color.BottomLeftColor.B;
				this.vertexBL.Color.b = b2;
				Color bottomLeftColor = color.BottomLeftColor;
				this.vertexBL.Color.a = bottomLeftColor;
				float y4 = texCoordBR.Y;
				this.vertexBL.TextureCoordinate.y = y4;
				byte r3 = color.BottomRightColor.R;
				this.vertexBR.Color = r3;
				byte g3 = color.BottomRightColor.G;
				this.vertexBR.Color.g = g3;
				byte b3 = color.BottomRightColor.B;
				this.vertexBR.Color.b = b3;
				Color bottomRightColor = color.BottomRightColor;
				this.vertexBR.Color.a = bottomRightColor;
				float y5 = texCoordBR.Y;
				this.vertexBR.TextureCoordinate.y = y5;
				return;
			}
			TextureAtlasEntry packedEntry = texture.PackedEntry;
			if (packedEntry != null)
			{
				int unityWidth = texture.UnityWidth;
				int unityHeight = texture.UnityHeight;
				int tileDataOffset = packedEntry.TileDataOffset;
				short textureHeight = packedEntry.TextureHeight;
				short textureOffsetX = packedEntry.TextureOffsetX;
				short textureOffsetY = packedEntry.TextureOffsetY;
				short textureScale = packedEntry.TextureScale;
				float x2 = texCoordTL.X;
				float y6 = texCoordTL.Y;
				float x3 = texCoordBR.X;
				float y7 = texCoordBR.Y;
				bool tileTrimming = packedEntry.TileTrimming;
				float x4 = texCoordTL.X;
				float y8 = texCoordTL.Y;
				float x5 = texCoordBR.X;
				float y9 = texCoordBR.Y;
				if (textureOffsetX == 0)
				{
				}
				return;
			}
		}

		// Token: 0x06001859 RID: 6233 RVA: 0x00068E14 File Offset: 0x00067014
		// Note: this type is marked as 'beforefieldinit'.
		static SpriteBatchItem()
		{
		}

		// Token: 0x0400268D RID: 9869
		private const float uvFixupOffset = 0.031f;

		// Token: 0x0400268E RID: 9870
		private static bool clippingPushedEnabledBackup;

		// Token: 0x0400268F RID: 9871
		private static bool clippingVerticalBackup;

		// Token: 0x04002690 RID: 9872
		private static bool clippingHorzontalBackup;

		// Token: 0x04002691 RID: 9873
		private static Rectangle clippingPushedInnerBackup;

		// Token: 0x04002692 RID: 9874
		private static Rectangle clippingPushedOuterBackup;

		// Token: 0x04002693 RID: 9875
		public static bool clippingEnabled;

		// Token: 0x04002694 RID: 9876
		public static bool geometryOffsetEnabled;

		// Token: 0x04002695 RID: 9877
		private static bool clippingVertical;

		// Token: 0x04002696 RID: 9878
		private static bool clippingHorzontal;

		// Token: 0x04002697 RID: 9879
		private static Rectangle clippingInner;

		// Token: 0x04002698 RID: 9880
		public static Rectangle clippingOuter;

		// Token: 0x04002699 RID: 9881
		private static SpriteBatch clippingBatch;

		// Token: 0x0400269A RID: 9882
		private static Clipper clipperObject;

		// Token: 0x0400269B RID: 9883
		public int BatchKey;

		// Token: 0x0400269C RID: 9884
		public Texture2D Texture;

		// Token: 0x0400269D RID: 9885
		public EffectPass OverloadedEffectPass;

		// Token: 0x0400269E RID: 9886
		public SpriteBatchItem NextBatchItem;

		// Token: 0x0400269F RID: 9887
		public SpriteBatcher.VertexData vertexTL;

		// Token: 0x040026A0 RID: 9888
		public SpriteBatcher.VertexData vertexTR;

		// Token: 0x040026A1 RID: 9889
		public SpriteBatcher.VertexData vertexBL;

		// Token: 0x040026A2 RID: 9890
		public SpriteBatcher.VertexData vertexBR;

		// Token: 0x040026A3 RID: 9891
		public static float ColourScale;

		// Token: 0x040026A4 RID: 9892
		public static bool EnableMaterialTrimming;

		// Token: 0x040026A5 RID: 9893
		public static Vector2 MaterialTrimmingMin;

		// Token: 0x040026A6 RID: 9894
		public static Vector2 MaterialTrimmingMax;
	}
}
