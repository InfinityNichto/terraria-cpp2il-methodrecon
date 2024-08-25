using System;
using Microsoft.Xna.Framework.Graphics;
using Terraria.Graphics;
using UnityEngine;

// Token: 0x02000179 RID: 377
public class GUIWorldOperationProgress
{
	// Token: 0x06000ABA RID: 2746 RVA: 0x00036A64 File Offset: 0x00034C64
	public void Draw()
	{
		if (6899 == 0)
		{
		}
		float num = this.scaleAnimationTime;
		float deltaTime = Time.deltaTime;
		float num2 = this.alphaAnimationTime;
		float deltaTime2 = Time.deltaTime;
		int num3 = 17279;
		if (num3 == 0)
		{
		}
		string text2;
		string text = text2 + "%";
		if (num3 == 0 || num3 == 0)
		{
		}
	}

	// Token: 0x06000ABB RID: 2747 RVA: 0x00036B00 File Offset: 0x00034D00
	private Microsoft.Xna.Framework.Graphics.Texture2D GetIcon()
	{
		if (!true)
		{
		}
		string text;
		return TextureManager.Load(text);
	}

	// Token: 0x06000ABC RID: 2748 RVA: 0x00036B18 File Offset: 0x00034D18
	public GUIWorldOperationProgress()
	{
	}

	// Token: 0x04000B12 RID: 2834
	private float scaleAnimationTime;

	// Token: 0x04000B13 RID: 2835
	private float alphaAnimationTime;

	// Token: 0x04000B14 RID: 2836
	private float HMConversionIconScale = (float)16256;
}
