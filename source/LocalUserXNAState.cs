using System;
using Microsoft.Xna.Framework.Input;

// Token: 0x020002BB RID: 699
public class LocalUserXNAState
{
	// Token: 0x06001033 RID: 4147 RVA: 0x0004FC7C File Offset: 0x0004DE7C
	public LocalUserXNAState()
	{
	}

	// Token: 0x04001EFF RID: 7935
	public static LocalUserXNAState Instance;

	// Token: 0x04001F00 RID: 7936
	public int scrollAccum;

	// Token: 0x04001F01 RID: 7937
	public float _uiX;

	// Token: 0x04001F02 RID: 7938
	public float _uiY;

	// Token: 0x04001F03 RID: 7939
	public float _X;

	// Token: 0x04001F04 RID: 7940
	public float _Y;

	// Token: 0x04001F05 RID: 7941
	public float _worldScreenOffsetY;

	// Token: 0x04001F06 RID: 7942
	public int _mouseX;

	// Token: 0x04001F07 RID: 7943
	public int _mouseY;

	// Token: 0x04001F08 RID: 7944
	public int _lastMouseX;

	// Token: 0x04001F09 RID: 7945
	public int _lastMouseY;

	// Token: 0x04001F0A RID: 7946
	public int _worldMouseX;

	// Token: 0x04001F0B RID: 7947
	public int _worldMouseY;

	// Token: 0x04001F0C RID: 7948
	public bool _mouseLeft;

	// Token: 0x04001F0D RID: 7949
	public bool _mouseRight;

	// Token: 0x04001F0E RID: 7950
	public bool _mouseLeftRelease;

	// Token: 0x04001F0F RID: 7951
	public bool _mouseRightRelease;

	// Token: 0x04001F10 RID: 7952
	public int _overloadScreenWidth;

	// Token: 0x04001F11 RID: 7953
	public int _overloadScreenHeight;

	// Token: 0x04001F12 RID: 7954
	public int _overloadScreenOffsetX;

	// Token: 0x04001F13 RID: 7955
	public int _overloadScreenOffsetY;

	// Token: 0x04001F14 RID: 7956
	public Mouse.OverrideState _virtualCursorOverride;

	// Token: 0x04001F15 RID: 7957
	public ButtonState _virtualCursorOverrideState;

	// Token: 0x04001F16 RID: 7958
	public float _virtualCursorOverrideX;

	// Token: 0x04001F17 RID: 7959
	public float _virtualCursorOverrideY;

	// Token: 0x04001F18 RID: 7960
	public bool _overrideRMB;

	// Token: 0x04001F19 RID: 7961
	public ButtonState _rmbOverrideState;

	// Token: 0x04001F1A RID: 7962
	public float scrollAccumPartial;

	// Token: 0x04001F1B RID: 7963
	public XNAUnityRunner.MouseStateBackup _uiMouseState;

	// Token: 0x04001F1C RID: 7964
	public XNAUnityRunner.MouseStateBackup _worldMouseState;

	// Token: 0x04001F1D RID: 7965
	public int _lastUIFrame = 1;
}
