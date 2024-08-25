using System;
using UnityEngine;

// Token: 0x0200003F RID: 63
public class iOS_Mouse
{
	// Token: 0x0600015F RID: 351 RVA: 0x000044CC File Offset: 0x000026CC
	public void Setup()
	{
		bool isEditor = Application.isEditor;
	}

	// Token: 0x06000160 RID: 352 RVA: 0x000044E4 File Offset: 0x000026E4
	public void Update()
	{
		bool mouseLeft = this.MouseLeft;
		bool flag = this.wasMouseConnected;
		this.MouseLeftPrev = mouseLeft;
		if (!flag)
		{
			Vector3 mousePosition = Input.mousePosition;
			int width = Screen.width;
			int height = Screen.height;
			this.wasMouseConnected = true;
		}
		bool isEditor = Application.isEditor;
		this.UseSWCursor = true;
		Vector3 mousePosition2 = Input.mousePosition;
		bool mouseButton = Input.GetMouseButton(0);
		this.MouseLeft = true;
		bool mouseButton2 = Input.GetMouseButton(1);
		this.MouseRight = true;
		bool mouseButton3 = Input.GetMouseButton(2);
		this.MouseMiddle = true;
		Vector2 mouseScrollDelta = Input.mouseScrollDelta;
	}

	// Token: 0x06000161 RID: 353 RVA: 0x00004580 File Offset: 0x00002780
	public iOS_Mouse()
	{
	}

	// Token: 0x040000F5 RID: 245
	private bool wasMouseConnected;

	// Token: 0x040000F6 RID: 246
	public Vector3 lastUnityMousePosition;

	// Token: 0x040000F7 RID: 247
	public Vector3 MousePosition;

	// Token: 0x040000F8 RID: 248
	public bool MouseLeft;

	// Token: 0x040000F9 RID: 249
	public bool MouseRight;

	// Token: 0x040000FA RID: 250
	public bool MouseMiddle;

	// Token: 0x040000FB RID: 251
	public bool MouseLeftPrev;

	// Token: 0x040000FC RID: 252
	public bool MouseRightPrev;

	// Token: 0x040000FD RID: 253
	public bool MouseMiddlePrev;

	// Token: 0x040000FE RID: 254
	public float MouseScroll;

	// Token: 0x040000FF RID: 255
	public bool UseSWCursor = true;
}
