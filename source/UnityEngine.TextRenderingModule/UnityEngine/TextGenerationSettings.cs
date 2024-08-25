using System;

namespace UnityEngine
{
	// Token: 0x02000004 RID: 4
	public struct TextGenerationSettings
	{
		// Token: 0x06000001 RID: 1 RVA: 0x00002050 File Offset: 0x00000250
		private bool CompareColors(Color left, Color right)
		{
		}

		// Token: 0x06000002 RID: 2 RVA: 0x00002060 File Offset: 0x00000260
		private bool CompareVector2(Vector2 left, Vector2 right)
		{
		}

		// Token: 0x06000003 RID: 3 RVA: 0x00002070 File Offset: 0x00000270
		public bool Equals(TextGenerationSettings other)
		{
			float r = this.color.r;
			float g = this.color.g;
			float b = this.color.b;
			float a = this.color.a;
			float r2 = other.color.r;
			float g2 = other.color.g;
			float b2 = other.color.b;
			float a2 = other.color.a;
			int num = this.fontSize;
			int num2 = other.fontSize;
			float num3 = this.scaleFactor;
			float num4 = other.scaleFactor;
			int num5 = this.resizeTextMinSize;
			int num6 = other.resizeTextMinSize;
			int num7 = this.resizeTextMaxSize;
			int num8 = other.resizeTextMaxSize;
			float num9 = this.lineSpacing;
			float num10 = other.lineSpacing;
			FontStyle fontStyle = this.fontStyle;
			FontStyle fontStyle2 = other.fontStyle;
			bool flag = other.richText;
			bool flag2 = this.richText;
			TextAnchor textAnchor = this.textAnchor;
			TextAnchor textAnchor2 = other.textAnchor;
			bool flag3 = other.alignByGeometry;
			bool flag4 = this.alignByGeometry;
			bool flag5 = other.resizeTextForBestFit;
			bool flag6 = this.resizeTextForBestFit;
			bool flag7 = other.updateBounds;
			bool flag8 = this.updateBounds;
			HorizontalWrapMode horizontalWrapMode = this.horizontalOverflow;
			HorizontalWrapMode horizontalWrapMode2 = other.horizontalOverflow;
			VerticalWrapMode verticalWrapMode = this.verticalOverflow;
			VerticalWrapMode verticalWrapMode2 = other.verticalOverflow;
			float x = this.generationExtents.x;
			float y = this.generationExtents.y;
			float x2 = other.generationExtents.x;
			float y2 = other.generationExtents.y;
			float x3 = this.pivot.x;
			float y3 = this.pivot.y;
			float x4 = other.pivot.x;
			float y4 = other.pivot.y;
			bool flag9;
			return flag9;
		}

		// Token: 0x0400000B RID: 11
		public Font font;

		// Token: 0x0400000C RID: 12
		public Color color;

		// Token: 0x0400000D RID: 13
		public int fontSize;

		// Token: 0x0400000E RID: 14
		public float lineSpacing;

		// Token: 0x0400000F RID: 15
		public bool richText;

		// Token: 0x04000010 RID: 16
		public float scaleFactor;

		// Token: 0x04000011 RID: 17
		public FontStyle fontStyle;

		// Token: 0x04000012 RID: 18
		public TextAnchor textAnchor;

		// Token: 0x04000013 RID: 19
		public bool alignByGeometry;

		// Token: 0x04000014 RID: 20
		public bool resizeTextForBestFit;

		// Token: 0x04000015 RID: 21
		public int resizeTextMinSize;

		// Token: 0x04000016 RID: 22
		public int resizeTextMaxSize;

		// Token: 0x04000017 RID: 23
		public bool updateBounds;

		// Token: 0x04000018 RID: 24
		public VerticalWrapMode verticalOverflow;

		// Token: 0x04000019 RID: 25
		public HorizontalWrapMode horizontalOverflow;

		// Token: 0x0400001A RID: 26
		public Vector2 generationExtents;

		// Token: 0x0400001B RID: 27
		public Vector2 pivot;

		// Token: 0x0400001C RID: 28
		public bool generateOutOfBounds;
	}
}
