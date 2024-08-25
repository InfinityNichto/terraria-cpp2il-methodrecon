using System;
using Microsoft.Xna.Framework;
using UnityEngine;

// Token: 0x02000255 RID: 597
public class Zoom_Layout : LayoutDefinition
{
	// Token: 0x06000D58 RID: 3416 RVA: 0x0003FBD8 File Offset: 0x0003DDD8
	private void Awake()
	{
	}

	// Token: 0x06000D59 RID: 3417 RVA: 0x0003FBE8 File Offset: 0x0003DDE8
	public Zoom_Layout()
	{
		if (18 == 0)
		{
		}
		if (!true)
		{
		}
		this.SliderBackScale = (float)16256;
		this.SliderLocation = 1;
		this.DefaultMagnifyCursorScale = (float)16256;
		this.SliderDefaultPosition = (float)16000;
		if (!true)
		{
		}
		base..ctor();
	}

	// Token: 0x040018A8 RID: 6312
	public static Zoom_Layout Instance;

	// Token: 0x040018A9 RID: 6313
	public ControlAnchor.ControlId SliderAnchorControl;

	// Token: 0x040018AA RID: 6314
	public LayoutCalculator.AnchorType SliderAnchor = LayoutCalculator.AnchorType.CentreBoth;

	// Token: 0x040018AB RID: 6315
	public Microsoft.Xna.Framework.Vector2 SliderLocation;

	// Token: 0x040018AC RID: 6316
	public float SliderBackScale;

	// Token: 0x040018AD RID: 6317
	public Microsoft.Xna.Framework.Vector2 SliderPickBorder;

	// Token: 0x040018AE RID: 6318
	public float SliderIndicatorScale;

	// Token: 0x040018AF RID: 6319
	public float SliderEndCap;

	// Token: 0x040018B0 RID: 6320
	public float SliderDefaultPosition;

	// Token: 0x040018B1 RID: 6321
	public AnimationCurve SliderToPixelScale;

	// Token: 0x040018B2 RID: 6322
	public float PixelWorldScaleThreshold;

	// Token: 0x040018B3 RID: 6323
	public float DefaultCursorScale;

	// Token: 0x040018B4 RID: 6324
	public bool ScaleCursorWithZoom;

	// Token: 0x040018B5 RID: 6325
	public float DefaultMagnifyCursorScale;

	// Token: 0x040018B6 RID: 6326
	public bool MagnifyScaleCursorWithZoom;

	// Token: 0x040018B7 RID: 6327
	public float ScopeXEdgeTrigger;

	// Token: 0x040018B8 RID: 6328
	public float ScopeYEdgeTrigger;
}
