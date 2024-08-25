using System;
using Microsoft.Xna.Framework;
using Terraria;

// Token: 0x02000267 RID: 615
public class GUIMenuNameEdit
{
	// Token: 0x17000177 RID: 375
	// (get) Token: 0x06000DBD RID: 3517 RVA: 0x00041F08 File Offset: 0x00040108
	// (set) Token: 0x06000DBE RID: 3518 RVA: 0x00041F1C File Offset: 0x0004011C
	public bool Enabled
	{
		get
		{
			return this._enabled;
		}
		set
		{
			Main.CloseKeyboard();
		}
	}

	// Token: 0x17000178 RID: 376
	// (get) Token: 0x06000DBF RID: 3519 RVA: 0x00041F30 File Offset: 0x00040130
	public string Name
	{
		get
		{
			return this._editedName;
		}
	}

	// Token: 0x06000DC0 RID: 3520 RVA: 0x00041F44 File Offset: 0x00040144
	public void Enable(string nomen)
	{
		this._enabled = true;
		if (!true)
		{
		}
		Main.clrInput();
	}

	// Token: 0x06000DC1 RID: 3521 RVA: 0x00041F64 File Offset: 0x00040164
	public string GetInputText(Rectangle region, int maxCharacters = -1)
	{
		int num = 1;
		string editedName = this._editedName;
		if (num == 0)
		{
		}
		string text;
		this._editedName = text;
		int stringLength = text._stringLength;
		long num2 = 0L;
		string text2 = text.Substring((int)num2, maxCharacters);
		this._editedName = text2;
		if (stringLength == 0)
		{
		}
		string editedName2 = this._editedName;
		if (stringLength == 0)
		{
		}
		string text3;
		return text3;
	}

	// Token: 0x06000DC2 RID: 3522 RVA: 0x00041FB4 File Offset: 0x000401B4
	public GUIMenuNameEdit()
	{
	}

	// Token: 0x04001964 RID: 6500
	private string _editedName;

	// Token: 0x04001965 RID: 6501
	private bool _enabled;
}
