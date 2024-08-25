using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.Localization;
using UnityEngine;

// Token: 0x02000282 RID: 642
public class GUIVirtualInputControllerEdit
{
	// Token: 0x06000E93 RID: 3731 RVA: 0x000475F0 File Offset: 0x000457F0
	public GUIVirtualInputControllerEdit()
	{
		this._inputLayer.Priority = 100;
	}

	// Token: 0x06000E94 RID: 3732 RVA: 0x00047610 File Offset: 0x00045810
	public void DrawBacking()
	{
		if (!true)
		{
		}
		int screenWidth = XNAUnityRunner.ScreenWidth;
		int screenHeight = XNAUnityRunner.ScreenHeight;
		if (!true)
		{
		}
	}

	// Token: 0x06000E95 RID: 3733 RVA: 0x000021DB File Offset: 0x000003DB
	public VirtualControlsAxisConfiguration_Layout.Style GetAxisControlSubStyle(VirtualControlsHardwareConfigurationMapping_Layout.ContolType action)
	{
		throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
	}

	// Token: 0x06000E96 RID: 3734 RVA: 0x0004763C File Offset: 0x0004583C
	public VirtualControlsButtonConfiguration_Layout.Style GetButtonControlSubStyle(VirtualControlsHardwareConfigurationMapping_Layout.ContolType action)
	{
	}

	// Token: 0x06000E97 RID: 3735 RVA: 0x0004764C File Offset: 0x0004584C
	private bool IsOverOptions(Microsoft.Xna.Framework.Vector2 cursorPosition)
	{
		return true;
	}

	// Token: 0x06000E98 RID: 3736 RVA: 0x0004765C File Offset: 0x0004585C
	public void CloseNameEdit()
	{
		if (!true)
		{
		}
		Main.CloseKeyboard();
	}

	// Token: 0x06000E99 RID: 3737 RVA: 0x00047674 File Offset: 0x00045874
	public void CloseProfileOptions()
	{
		GUIInputRegionExclusive optionsBlocker = this._optionsBlocker;
	}

	// Token: 0x06000E9A RID: 3738 RVA: 0x00047688 File Offset: 0x00045888
	private void DrawProfile()
	{
		bool mouseLeft = Main.mouseLeft;
		bool mouseLeftRelease = Main.mouseLeftRelease;
		bool flag = this.editingName;
		if (flag)
		{
			bool mouseLeft2 = Main.mouseLeft;
			bool mouseLeftRelease2 = Main.mouseLeftRelease;
			this.CloseNameEdit();
		}
		if (this.SlotOrder == null)
		{
		}
		int selectedControl = this.SelectedControl;
		GUITransactionButton.InputState inputState;
		if (inputState == GUITransactionButton.InputState.Clicked)
		{
			int num = 1;
			this.editingName = num != 0;
			if (num == 0)
			{
			}
			Main.clrInput();
			VirtualControlsProfile_Layout virtualControlsProfile_Layout;
			string editedName = virtualControlsProfile_Layout.EditedName;
			this.editNameValue = editedName;
		}
		bool flag2 = this.editingName;
		if (!flag2)
		{
			bool flag3 = this.displayProfileOptions;
			GUITransactionButton.InputState inputState2;
			if (inputState2 == GUITransactionButton.InputState.Clicked)
			{
				int num2 = 1;
				bool flag4 = this.displayProfileOptions;
				if (flag4)
				{
					this.CloseProfileOptions();
					return;
				}
				this.displayProfileOptions = num2 != 0;
				if (!flag4)
				{
				}
				Main.mouseLeftRelease = Main.mouseLeftRelease;
				GUIInputRegionExclusive guiinputRegionExclusive;
				this._optionsBlocker = guiinputRegionExclusive;
			}
			GUIInputRegionExclusive optionsBlocker = this._optionsBlocker;
			bool flag5 = this.displayProfileOptions;
			if (optionsBlocker != null)
			{
				if (flag5)
				{
					return;
				}
			}
			else if (flag5)
			{
				if (optionsBlocker == null)
				{
				}
				Main.FlushBatches();
				if (this.displayProfileOptions)
				{
					GUITransactionButton.InputState inputState3;
					if (inputState3 == GUITransactionButton.InputState.Clicked)
					{
						GUIInputRegionExclusive optionsBlocker2 = this._optionsBlocker;
					}
					GUITransactionButton.InputState inputState4;
					if (inputState4 == GUITransactionButton.InputState.Clicked)
					{
						GUIInputRegionExclusive optionsBlocker3 = this._optionsBlocker;
					}
					GUITransactionButton.InputState inputState5;
					if (inputState5 == GUITransactionButton.InputState.Clicked)
					{
						GUIInputRegionExclusive optionsBlocker4 = this._optionsBlocker;
					}
					GUITransactionButton.InputState inputState6;
					if (inputState6 != GUITransactionButton.InputState.Clicked)
					{
						GUIInputRegionExclusive optionsBlocker5 = this._optionsBlocker;
						if (optionsBlocker5 != null)
						{
							int num3 = 1;
							optionsBlocker5.Active = num3 != 0;
							if (optionsBlocker5 == null)
							{
							}
							bool mouseLeft3 = Main.mouseLeft;
							if (optionsBlocker5 == null)
							{
							}
							bool mouseLeftRelease3 = Main.mouseLeftRelease;
							return;
						}
					}
					else
					{
						GUIInputRegionExclusive optionsBlocker6 = this._optionsBlocker;
					}
				}
			}
			return;
		}
		string text = this.editNameValue;
		long num4 = 0L;
		if (!flag2)
		{
		}
		int num5 = 20;
		long num6 = 0L;
		long num7 = 0L;
		long num8 = 0L;
		Rectangle rectangle;
		string inputText = Main.GetInputText(text, rectangle, (int)num4, num5 != 0, num6 != 0L, num7 != 0L, num8 != 0L);
		this.editNameValue = inputText;
		int stringLength = inputText._stringLength;
		int num9 = 20;
		long num10 = 0L;
		string text2 = inputText.Substring((int)num10, num9);
		this.editNameValue = text2;
		if (stringLength == 0)
		{
		}
		if (flag)
		{
			return;
		}
		if (!flag)
		{
		}
		string text3 = this.editNameValue;
		VirtualControlsProfile_Layout virtualControlsProfile_Layout2;
		virtualControlsProfile_Layout2.EditedName = text3;
		int num11 = this.textBlinkerCount;
		this.textBlinkerCount = num11;
		int num12 = this.textBlinkerState;
		this.StlyeOptionsList = num12;
		string text4 = this.editNameValue;
		bool flag6 = string.IsNullOrEmpty(text4);
		SpriteFont spriteFont;
		Microsoft.Xna.Framework.Vector2 vector = spriteFont.MeasureString(text4);
		long num13 = 0L;
		string text5 = "..." + text4;
		SpriteFont spriteFont2;
		Microsoft.Xna.Framework.Vector2 vector2 = spriteFont2.MeasureString(text5);
		int stringLength2 = text4._stringLength;
		int num14 = 1;
		string text6 = text4.Substring(num14, (int)num13);
	}

	// Token: 0x06000E9B RID: 3739 RVA: 0x0004791C File Offset: 0x00045B1C
	private string TruncateString(TransactionButton_Layout button, string text, float maxWidth)
	{
		Microsoft.Xna.Framework.Vector2 vector = button.Label.GetFont().MeasureString(text);
		String_Layout label = button.Label;
		float scale = label.Scale;
		SpriteFont font = label.GetFont();
		string text2 = text + "...";
		long num = 0L;
		Microsoft.Xna.Framework.Vector2 vector2 = font.MeasureString(text2);
		float scale2 = button.Label.Scale;
		int stringLength = text._stringLength;
		long num2 = 0L;
		string text3 = text.Substring((int)num2, (int)num);
		String_Layout label2 = button.Label;
		return text3;
	}

	// Token: 0x06000E9C RID: 3740 RVA: 0x000479A8 File Offset: 0x00045BA8
	public void ClosePageOptions()
	{
		GUIInputRegionExclusive optionsBlocker = this._optionsBlocker;
	}

	// Token: 0x06000E9D RID: 3741 RVA: 0x000479BC File Offset: 0x00045BBC
	private void DrawPageOptions()
	{
		if (this.displayPageOptions)
		{
		}
		GUIInputRegionExclusive optionsBlocker = this._optionsBlocker;
		bool flag;
		if (optionsBlocker != null)
		{
			flag = this.displayPageOptions;
			if (flag)
			{
			}
		}
		if (optionsBlocker == null)
		{
		}
		bool mouseLeft = Main.mouseLeft;
		if (optionsBlocker == null)
		{
		}
		bool mouseLeftRelease = Main.mouseLeftRelease;
		if (flag)
		{
			return;
		}
		Microsoft.Xna.Framework.Graphics.Texture2D texture2D;
		int width = texture2D.Width;
		bool flag2 = this.displayPageOptions;
		GUITransactionButton.InputState inputState;
		if (inputState == GUITransactionButton.InputState.Clicked)
		{
			int num;
			if (this.displayPageOptions)
			{
				this.ClosePageOptions();
				num = 1;
				return;
			}
			this.displayPageOptions = num != 0;
			GUIInputRegionExclusive guiinputRegionExclusive;
			this._optionsBlocker = guiinputRegionExclusive;
		}
		bool flag3 = this.displayPageOptions;
		if (flag3)
		{
			int width2 = texture2D.Width;
			if (!flag3)
			{
			}
			GUITransactionButton.InputState inputState2;
			if (inputState2 == GUITransactionButton.InputState.Clicked)
			{
				GUIInputRegionExclusive optionsBlocker2 = this._optionsBlocker;
			}
			GUITransactionButton.InputState inputState3;
			if (inputState3 == GUITransactionButton.InputState.Clicked)
			{
				GUIInputRegionExclusive optionsBlocker3 = this._optionsBlocker;
			}
			GUIInputRegionExclusive optionsBlocker4 = this._optionsBlocker;
			if (optionsBlocker4 != null)
			{
				int num2 = 1;
				optionsBlocker4.Active = num2 != 0;
				if (optionsBlocker4 == null)
				{
				}
				bool mouseLeft2 = Main.mouseLeft;
				if (optionsBlocker4 == null)
				{
				}
				bool mouseLeftRelease2 = Main.mouseLeftRelease;
				GUIInputRegionExclusive optionsBlocker5 = this._optionsBlocker;
			}
		}
	}

	// Token: 0x06000E9E RID: 3742 RVA: 0x00047AB8 File Offset: 0x00045CB8
	public void DisablePulldown()
	{
		this._optionsBlocker.Active = true;
	}

	// Token: 0x06000E9F RID: 3743 RVA: 0x00047AD4 File Offset: 0x00045CD4
	private void DrawHardware()
	{
		if (this.displayHardwareOptions)
		{
		}
		GUIInputRegionExclusive optionsBlocker = this._optionsBlocker;
		bool flag;
		if (optionsBlocker != null)
		{
			flag = this.displayHardwareOptions;
			if (flag)
			{
			}
		}
		bool mouseLeft = Main.mouseLeft;
		if (optionsBlocker == null)
		{
		}
		bool mouseLeftRelease = Main.mouseLeftRelease;
		VirtualControlsProfile_Layout virtualControlsProfile_Layout;
		string displayName = virtualControlsProfile_Layout.HardwareConfig.GetDisplayName();
		bool flag2 = this.displayHardwareOptions;
		GUITransactionButton.InputState inputState;
		if (inputState == GUITransactionButton.InputState.Clicked)
		{
			int num = 1;
			if (this.displayHardwareOptions)
			{
				GUIInputRegionExclusive optionsBlocker2 = this._optionsBlocker;
				return;
			}
			this.displayHardwareOptions = num != 0;
			Main.mouseLeftRelease = Main.mouseLeftRelease;
			GUIInputRegionExclusive guiinputRegionExclusive;
			this._optionsBlocker = guiinputRegionExclusive;
		}
		string textValue = Language.GetTextValue("Mobile.ControlsHardwareTitle");
		if (!flag)
		{
		}
		if (this.displayHardwareOptions)
		{
			VirtualControlsHardwareConfiguration_Layout virtualControlsHardwareConfiguration_Layout;
			string displayName2 = virtualControlsHardwareConfiguration_Layout.GetDisplayName();
			VirtualControlsProfile_Layout virtualControlsProfile_Layout2;
			VirtualControlsHardwareConfiguration_Layout hardwareConfig = virtualControlsProfile_Layout2.HardwareConfig;
			GUITransactionButton.InputState inputState2;
			if (inputState2 == GUITransactionButton.InputState.Clicked)
			{
				string id = virtualControlsHardwareConfiguration_Layout.Id;
				VirtualControlsProfile_Layout virtualControlsProfile_Layout3;
				virtualControlsProfile_Layout3.Hardware = id;
				GUIInputRegionExclusive optionsBlocker3 = this._optionsBlocker;
			}
			VirtualControlsHardwareConfiguration_Layout virtualControlsHardwareConfiguration_Layout2;
			string displayName3 = virtualControlsHardwareConfiguration_Layout2.GetDisplayName();
			VirtualControlsProfile_Layout virtualControlsProfile_Layout4;
			VirtualControlsHardwareConfiguration_Layout hardwareConfig2 = virtualControlsProfile_Layout4.HardwareConfig;
			GUITransactionButton.InputState inputState3;
			if (inputState3 == GUITransactionButton.InputState.Clicked)
			{
				string id2 = virtualControlsHardwareConfiguration_Layout2.Id;
				VirtualControlsProfile_Layout virtualControlsProfile_Layout5;
				virtualControlsProfile_Layout5.Hardware = id2;
				GUIInputRegionExclusive optionsBlocker4 = this._optionsBlocker;
			}
			VirtualControlsHardwareConfiguration_Layout virtualControlsHardwareConfiguration_Layout3;
			string displayName4 = virtualControlsHardwareConfiguration_Layout3.GetDisplayName();
			VirtualControlsProfile_Layout virtualControlsProfile_Layout6;
			VirtualControlsHardwareConfiguration_Layout hardwareConfig3 = virtualControlsProfile_Layout6.HardwareConfig;
			GUITransactionButton.InputState inputState4;
			if (inputState4 == GUITransactionButton.InputState.Clicked)
			{
				string id3 = virtualControlsHardwareConfiguration_Layout3.Id;
				VirtualControlsProfile_Layout virtualControlsProfile_Layout7;
				virtualControlsProfile_Layout7.Hardware = id3;
			}
			VirtualControlsProfile_Layout virtualControlsProfile_Layout8;
			VirtualControlsHardwareConfiguration_Layout hardwareConfig4 = virtualControlsProfile_Layout8.HardwareConfig;
			GUITransactionButton.InputState inputState5;
			if (inputState5 != GUITransactionButton.InputState.Clicked)
			{
				GUIInputRegionExclusive optionsBlocker5 = this._optionsBlocker;
				if (optionsBlocker5 != null)
				{
					int num2 = 1;
					optionsBlocker5.Active = num2 != 0;
					if (optionsBlocker5 == null)
					{
					}
					bool mouseLeft2 = Main.mouseLeft;
					if (optionsBlocker5 == null)
					{
					}
					bool mouseLeftRelease2 = Main.mouseLeftRelease;
					return;
				}
			}
			else
			{
				GUIInputRegionExclusive optionsBlocker6 = this._optionsBlocker;
			}
		}
	}

	// Token: 0x06000EA0 RID: 3744 RVA: 0x000021DB File Offset: 0x000003DB
	private void UpdateStyleOptions()
	{
		throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
	}

	// Token: 0x06000EA1 RID: 3745 RVA: 0x00047C64 File Offset: 0x00045E64
	private void ChangeStyle(string configurationId)
	{
		int selectedSlot = this.SelectedSlot;
		VirtualControlsProfile_Layout virtualControlsProfile_Layout;
		VirtualControlsHardwareConfigurationMapping_Layout.ContolType defaultControl = virtualControlsProfile_Layout.HardwareConfig.Slots.DefaultControl;
	}

	// Token: 0x06000EA2 RID: 3746 RVA: 0x00047C98 File Offset: 0x00045E98
	private void DrawUndoRedo()
	{
		GUITransactionButton.InputState inputState;
		if (inputState == GUITransactionButton.InputState.Clicked)
		{
		}
		GUITransactionButton.InputState inputState2;
		if (inputState2 != GUITransactionButton.InputState.Clicked)
		{
			return;
		}
	}

	// Token: 0x06000EA3 RID: 3747 RVA: 0x00047CB4 File Offset: 0x00045EB4
	public void DrawWidgets()
	{
		this.DrawUndoRedo();
		if (!this.displayProfileOptions)
		{
			this.drawnProfileOptions = true;
			this.DrawProfile();
		}
		if (this.displayPageOptions)
		{
			return;
		}
		this.drawnPageOptions = true;
		this.DrawPageOptions();
	}

	// Token: 0x06000EA4 RID: 3748 RVA: 0x00047CF4 File Offset: 0x00045EF4
	public void DrawWidgetOverlays()
	{
		if (!true)
		{
		}
		if (this.displayProfileOptions && !this.drawnProfileOptions)
		{
			this.DrawProfile();
		}
		if (this.displayPageOptions && !this.drawnPageOptions)
		{
			this.DrawPageOptions();
		}
	}

	// Token: 0x06000EA5 RID: 3749 RVA: 0x00047D30 File Offset: 0x00045F30
	public int GetSlotOver(Microsoft.Xna.Framework.Vector2 mousePosition, [Out] Microsoft.Xna.Framework.Vector2 slotPosition)
	{
		/*
An exception occurred when decompiling this method (06000EA5)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Int32 GUIVirtualInputControllerEdit::GetSlotOver(Microsoft.Xna.Framework.Vector2,Microsoft.Xna.Framework.Vector2)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_00A6:
	stloc:class VirtualControlsHardwareConfigurationMapping_Layout[](var_20_AC, ldfld:class VirtualControlsHardwareConfigurationMapping_Layout[](VirtualControlsHardwareConfiguration_Layout::Slots, ldloc:VirtualControlsHardwareConfiguration_Layout(var_1_0C)))
}

   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1852
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.Optimize(DecompilerContext context, ILBlock method, AutoPropertyProvider autoPropertyProvider, StateMachineKind& stateMachineKind, MethodDef& inlinedMethod, AsyncMethodDebugInfo& asyncInfo, ILAstOptimizationStep abortBeforeStep) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 355
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(IEnumerable`1 parameters, MethodDebugInfoBuilder& builder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 123
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 88
   --- End of inner exception stack trace ---
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 92
   at ICSharpCode.Decompiler.Ast.AstBuilder.AddMethodBody(EntityDeclaration methodNode, EntityDeclaration& updatedNode, MethodDef method, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, MethodKind methodKind) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 1683
*/;
	}

	// Token: 0x06000EA6 RID: 3750 RVA: 0x00047DEC File Offset: 0x00045FEC
	public void UpdateCursor(global::Cursor cursor)
	{
		CursorInputLayer inputLayer = cursor.InputLayer;
		if (inputLayer == null)
		{
			float x = cursor.Position.x;
			float y = cursor.Position.y;
			if (inputLayer == null)
			{
			}
			int num = 32640;
			if (cursor.Down && num == 0)
			{
				InterfaceProfile_Layout active = InterfaceStyles_Layout.Active;
				int size = active.LeftGroupings._size;
				int num2 = 1;
				Rectangle rectangle;
				bool flag = rectangle.Contains(-1073741824, 1073741824);
				CursorInputLayer inputLayer2 = this._inputLayer;
				cursor.InputLayer = inputLayer2;
				List<GUIPageIconGrouping> leftGroupings = active.LeftGroupings;
				cursor.InputLayerData = leftGroupings;
				List<GUIPageIconGrouping> leftGroupings2 = active.LeftGroupings;
				this.selectedGrouping = leftGroupings2;
				int size2 = active.LeftGroupings._size;
				this.draggingInterface = num2 != 0;
				this.dragControlStartInterface = size2;
				int size3 = active.LeftGroupings._size;
				int size4 = active.RightGroupings._size;
				int num3 = 1;
				Rectangle rectangle2;
				bool flag2 = rectangle2.Contains(-1073741824, 1073741824);
				CursorInputLayer inputLayer3 = this._inputLayer;
				cursor.InputLayer = inputLayer3;
				List<GUIPageIconGrouping> rightGroupings = active.RightGroupings;
				cursor.InputLayerData = rightGroupings;
				List<GUIPageIconGrouping> rightGroupings2 = active.RightGroupings;
				this.selectedGrouping = rightGroupings2;
				int size5 = active.RightGroupings._size;
				this.draggingInterface = num3 != 0;
				this.dragControlStartInterface = size5;
				int size6 = active.RightGroupings._size;
				return;
			}
		}
	}

	// Token: 0x06000EA7 RID: 3751 RVA: 0x000021DB File Offset: 0x000003DB
	public void RefreshSlotOrder()
	{
		throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
	}

	// Token: 0x06000EA8 RID: 3752 RVA: 0x000021DB File Offset: 0x000003DB
	public float ControlsItemScale(int index)
	{
		throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
	}

	// Token: 0x06000EA9 RID: 3753 RVA: 0x00048084 File Offset: 0x00046284
	private void ClampSlotToScreen(int index)
	{
		VirtualControlsProfile_Layout virtualControlsProfile_Layout;
		VirtualControlsHardwareConfigurationMapping_Layout.ContolType defaultControl = virtualControlsProfile_Layout.HardwareConfig.Slots.DefaultControl;
		VirtualControlsProfile_Layout virtualControlsProfile_Layout2;
		if (virtualControlsProfile_Layout2.Controls == null)
		{
		}
	}

	// Token: 0x06000EAA RID: 3754 RVA: 0x00048110 File Offset: 0x00046310
	public void ControlsItemOver(int index)
	{
		int num = 1;
		List<int> slotOrder = this.SlotOrder;
		if (num == 0)
		{
		}
		bool mouseLeft = Main.mouseLeft;
		if (num == 0)
		{
		}
		bool mouseLeftRelease = Main.mouseLeftRelease;
		int selectedControl = this.SelectedControl;
		this.SelectedControl = slotOrder;
		int selectedSlot = this.SelectedSlot;
		VirtualControlsProfile_Layout virtualControlsProfile_Layout;
		VirtualControlsHardwareConfiguration_Layout hardwareConfig = virtualControlsProfile_Layout.HardwareConfig;
		VirtualControlsProfile_Layout virtualControlsProfile_Layout2;
		VirtualControlsBinding_Layout[] controls = virtualControlsProfile_Layout2.Controls;
		VirtualControlsHardwareConfigurationMapping_Layout[] slots = hardwareConfig.Slots;
		int selectedControl2 = this.SelectedControl;
		VirtualControlsHardwareConfigurationMapping_Layout.ContolType action = controls.Action;
	}

	// Token: 0x06000EAB RID: 3755 RVA: 0x00048200 File Offset: 0x00046400
	private QuickActionButton_Layout.QuickActionControl GetButtonId(VirtualControlsHardwareConfigurationMapping_Layout.ContolType controlType)
	{
	}

	// Token: 0x06000EAC RID: 3756 RVA: 0x00048210 File Offset: 0x00046410
	private void GetControlTextureFrame(VirtualControlsHardwareConfigurationMapping_Layout.ContolType controlType, [Out] Microsoft.Xna.Framework.Graphics.Texture2D tex, [Out] Rectangle frame)
	{
	}

	// Token: 0x06000EAD RID: 3757 RVA: 0x0004824C File Offset: 0x0004644C
	public string GetControlName(VirtualControlsHardwareConfigurationMapping_Layout.ContolType control)
	{
		return Language.GetTextValue("ControllerMappings.AutoFire");
	}

	// Token: 0x06000EAE RID: 3758 RVA: 0x00048264 File Offset: 0x00046464
	public void ControlsItemDraw(ItemGrid_Layout gridLayout, int index, Microsoft.Xna.Framework.Vector2 position, float scale)
	{
		List<int> slotOrder = this.SlotOrder;
		int selectedControl = this.SelectedControl;
		int selectedSlot = this.SelectedSlot;
		if (this.UIControlDrag)
		{
			VirtualControlsProfile_Layout virtualControlsProfile_Layout;
			VirtualControlsHardwareConfigurationMapping_Layout.ContolType defaultControl = virtualControlsProfile_Layout.HardwareConfig.Slots.DefaultControl;
			return;
		}
		VirtualControlsProfile_Layout virtualControlsProfile_Layout2;
		VirtualControlsHardwareConfiguration_Layout hardwareConfig = virtualControlsProfile_Layout2.HardwareConfig;
		int selectedControl2 = this.SelectedControl;
		if (selectedControl2 == 0)
		{
		}
		if (selectedControl2 == 0)
		{
		}
	}

	// Token: 0x06000EAF RID: 3759 RVA: 0x00048354 File Offset: 0x00046554
	public void DrawControlsGrid()
	{
		if (!this.displayVCControls)
		{
			int size = this.SlotOrder._size;
			int selectedControl = this.SelectedControl;
			float timeSinceControlChange = this.TimeSinceControlChange;
			int selectedControl2 = this.SelectedControl;
			bool pendingUIControlDrag = this.PendingUIControlDrag;
			if (!pendingUIControlDrag)
			{
				if (!pendingUIControlDrag)
				{
				}
				bool mouseLeft = Main.mouseLeft;
				if (!pendingUIControlDrag)
				{
				}
				bool mouseLeftRelease = Main.mouseLeftRelease;
				this.UIControlDrag = true;
				if (!true)
				{
				}
				int mouseX = Main.mouseX;
				int mouseY = Main.mouseY;
				this.DragStartPosition = 1;
				this.DragPosition = 1;
			}
			float timeSinceControlChange2 = this.TimeSinceControlChange;
			float deltaTime = Time.deltaTime;
			this.TimeSinceControlChange = timeSinceControlChange;
		}
	}

	// Token: 0x06000EB0 RID: 3760 RVA: 0x000483FC File Offset: 0x000465FC
	private void RemoveSlot(int selectedSlot)
	{
		VirtualControlsProfile_Layout virtualControlsProfile_Layout;
		VirtualControlsHardwareConfiguration_Layout hardwareConfig = virtualControlsProfile_Layout.HardwareConfig;
		VirtualControlsHardwareConfiguration_Layout virtualControlsHardwareConfiguration_Layout;
		if (virtualControlsHardwareConfiguration_Layout != null)
		{
			string text2;
			string text = "S" + text2;
			string text4;
			string text3 = "S" + text4;
			return;
		}
		throw new ArrayTypeMismatchException();
	}

	// Token: 0x06000EB1 RID: 3761 RVA: 0x00048434 File Offset: 0x00046634
	private int CreateNewSlot(VirtualControlsSlotTypeMapping_Layout.SlotType controlType, string styleId, Microsoft.Xna.Framework.Vector2 position)
	{
		VirtualControlsProfile_Layout virtualControlsProfile_Layout;
		VirtualControlsSlotTypeMapping_Layout style = virtualControlsProfile_Layout.HardwareConfig.Slots.Style;
		string text2;
		string text = "S" + text2;
		string text4;
		string text3 = "S" + text4;
		throw new ArrayTypeMismatchException();
	}

	// Token: 0x06000EB2 RID: 3762 RVA: 0x000021DB File Offset: 0x000003DB
	public void DrawSlotsGrid()
	{
		throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
	}

	// Token: 0x06000EB3 RID: 3763 RVA: 0x00048478 File Offset: 0x00046678
	public void DrawControlCategories()
	{
		bool flag = this.displayVCControls;
		GUITransactionButton.InputState inputState;
		if (inputState == GUITransactionButton.InputState.Clicked)
		{
		}
		bool flag2 = this.displayVCControls;
		GUITransactionButton.InputState inputState2;
		if (inputState2 == GUITransactionButton.InputState.Clicked)
		{
			int num = 1;
			this.displayVCControls = num != 0;
		}
	}

	// Token: 0x06000EB4 RID: 3764 RVA: 0x000484B0 File Offset: 0x000466B0
	private void GetDefaultControlSetup(VirtualControlsHardwareConfigurationMapping_Layout.ContolType control, [Out] VirtualControlsSlotTypeMapping_Layout.SlotType type, [Out] string configurationId)
	{
	}

	// Token: 0x06000EB5 RID: 3765 RVA: 0x000484CC File Offset: 0x000466CC
	private void HandleSlotChangeType(VirtualControlsHardwareConfiguration_Layout hardware, int slot, VirtualControlsSlotTypeMapping_Layout.SlotType type)
	{
		VirtualControlsHardwareConfigurationMapping_Layout.ContolType defaultControl = hardware.Slots.DefaultControl;
	}

	// Token: 0x06000EB6 RID: 3766 RVA: 0x000484E8 File Offset: 0x000466E8
	private void LoadSlotPosition(Microsoft.Xna.Framework.Vector2 position, int slot)
	{
		if (!true)
		{
		}
		VirtualControlsProfile_Layout virtualControlsProfile_Layout;
		VirtualControlsHardwareConfiguration_Layout hardwareConfig = virtualControlsProfile_Layout.HardwareConfig;
		if (!true)
		{
		}
	}

	// Token: 0x06000EB7 RID: 3767 RVA: 0x000021DB File Offset: 0x000003DB
	public void Draw()
	{
		throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
	}

	// Token: 0x06000EB8 RID: 3768 RVA: 0x000021DB File Offset: 0x000003DB
	public float ItemScale(int index)
	{
		throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
	}

	// Token: 0x06000EB9 RID: 3769 RVA: 0x00048518 File Offset: 0x00046718
	public void ItemOver(int index)
	{
	}

	// Token: 0x06000EBA RID: 3770 RVA: 0x00048528 File Offset: 0x00046728
	public void ItemDraw(ItemGrid_Layout gridLayout, int slot, Microsoft.Xna.Framework.Vector2 position, float scale)
	{
	}

	// Token: 0x06000EBB RID: 3771 RVA: 0x00048538 File Offset: 0x00046738
	private void DrawAvailableControls()
	{
	}

	// Token: 0x06000EBC RID: 3772 RVA: 0x00048548 File Offset: 0x00046748
	public void SetPageControlsAndAdjust(GUIPageIcons.PageControlsType newType)
	{
	}

	// Token: 0x06000EBD RID: 3773 RVA: 0x0004864C File Offset: 0x0004684C
	public void ClampControls(bool editingControls = true)
	{
	}

	// Token: 0x06000EBE RID: 3774 RVA: 0x0004865C File Offset: 0x0004685C
	private void DrawInterfaceBacking()
	{
		if (!true)
		{
		}
	}

	// Token: 0x06000EBF RID: 3775 RVA: 0x00048718 File Offset: 0x00046918
	private global::Cursor GetCursor(GUIPageIconGrouping grouping)
	{
		/*
An exception occurred when decompiling this method (06000EBF)

ICSharpCode.Decompiler.DecompilerException: Error decompiling Cursor GUIVirtualInputControllerEdit::GetCursor(GUIPageIconGrouping)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:CursorInputLayer(var_3_08, ldfld:CursorInputLayer(Cursor::InputLayer, ldloc:Cursor(var_2)))
	stloc:CursorInputLayer(var_4_0F, ldfld:CursorInputLayer(GUIVirtualInputControllerEdit::_inputLayer, ldloc:GUIVirtualInputControllerEdit(this)))
	stloc:object(var_5_17, ldfld:object(Cursor::InputLayerData, ldloc:Cursor(var_2)))
}

   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1852
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.Optimize(DecompilerContext context, ILBlock method, AutoPropertyProvider autoPropertyProvider, StateMachineKind& stateMachineKind, MethodDef& inlinedMethod, AsyncMethodDebugInfo& asyncInfo, ILAstOptimizationStep abortBeforeStep) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 355
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(IEnumerable`1 parameters, MethodDebugInfoBuilder& builder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 123
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 88
   --- End of inner exception stack trace ---
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 92
   at ICSharpCode.Decompiler.Ast.AstBuilder.AddMethodBody(EntityDeclaration methodNode, EntityDeclaration& updatedNode, MethodDef method, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, MethodKind methodKind) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 1683
*/;
	}

	// Token: 0x06000EC0 RID: 3776 RVA: 0x00048740 File Offset: 0x00046940
	private void UpdateInterfaceMovement()
	{
		InterfaceProfile_Layout active = InterfaceStyles_Layout.Active;
		List<GUIPageIconGrouping> leftGroupings = active.LeftGroupings;
		GUIPageIconGrouping guipageIconGrouping = this.selectedGrouping;
		List<GUIPageIconGrouping> rightGroupings = active.RightGroupings;
		GUIPageIconGrouping guipageIconGrouping2 = this.selectedGrouping;
		int size = active.LeftGroupings._size;
		int size2 = active.RightGroupings._size;
		int size3 = active.LeftGroupings._size;
	}

	// Token: 0x06000EC1 RID: 3777 RVA: 0x000488B0 File Offset: 0x00046AB0
	private void OffsetGroupingX(float offset)
	{
		bool leftSideGrouping = this.selectedGrouping.LeftSideGrouping;
		GUIPageIconGrouping guipageIconGrouping = this.selectedGrouping;
		float x = guipageIconGrouping.Location.X;
		guipageIconGrouping.Location.X = x;
	}

	// Token: 0x06000EC2 RID: 3778 RVA: 0x000488E8 File Offset: 0x00046AE8
	private Rectangle ResolveCollisions(Rectangle originalRegion, Rectangle newRegion, GUIPageIconGrouping group)
	{
		int num = 1;
		if (num == 0)
		{
		}
		InterfaceProfile_Layout active = InterfaceStyles_Layout.Active;
		List<GUIPageIconGrouping> leftGroupings = active.LeftGroupings;
		bool leftSideGrouping = this.selectedGrouping.LeftSideGrouping;
		if (num == 0)
		{
		}
		float y = this.selectedGrouping.Location.Y;
		float y2 = this.selectedGrouping.Location.Y;
		int right = this.selectedGrouping.GetRegion().Right;
		if (this.selectedGrouping == null)
		{
		}
		bool leftSideGrouping2 = this.selectedGrouping.LeftSideGrouping;
		GUIPageIconGrouping guipageIconGrouping = this.selectedGrouping;
		float x = guipageIconGrouping.Location.X;
		guipageIconGrouping.Location.X = x;
		Rectangle region = guipageIconGrouping.GetRegion();
		List<GUIPageIconGrouping> leftGroupings2 = active.LeftGroupings;
		bool leftSideGrouping3 = this.selectedGrouping.LeftSideGrouping;
		if (guipageIconGrouping == null)
		{
		}
		bool leftSideGrouping4 = this.selectedGrouping.LeftSideGrouping;
		GUIPageIconGrouping guipageIconGrouping2 = this.selectedGrouping;
		float x2 = guipageIconGrouping2.Location.X;
		guipageIconGrouping2.Location.X = x2;
		return guipageIconGrouping2.GetRegion();
	}

	// Token: 0x06000EC3 RID: 3779 RVA: 0x000021DB File Offset: 0x000003DB
	private void TryMovingGroup(Microsoft.Xna.Framework.Vector2 newPosition)
	{
		throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
	}

	// Token: 0x06000EC4 RID: 3780 RVA: 0x000021DB File Offset: 0x000003DB
	public float PageItemScale(int index)
	{
		throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
	}

	// Token: 0x06000EC5 RID: 3781 RVA: 0x000489E4 File Offset: 0x00046BE4
	public void PageItemOver(int index)
	{
	}

	// Token: 0x06000EC6 RID: 3782 RVA: 0x000489F4 File Offset: 0x00046BF4
	private bool IsAxisInBadPosition(Axis_Layout AxisLayout, Microsoft.Xna.Framework.Vector2 mousePosition)
	{
		/*
An exception occurred when decompiling this method (06000EC6)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean GUIVirtualInputControllerEdit::IsAxisInBadPosition(Axis_Layout,Microsoft.Xna.Framework.Vector2)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:Texture_Layout(var_0_06, ldfld:Texture_Layout(Axis_Layout::Backing, ldloc:Axis_Layout(AxisLayout)))
	stloc:float32(var_1_0D, ldfld:float32(Axis_Layout::Scale, ldloc:Axis_Layout(AxisLayout)))
	stloc:Vector2(var_2_19, call:Vector2(Utils::Size, callgetter:Texture2D(Texture_Layout::get_Texture, ldloc:Texture_Layout(var_0_06))))
	stloc:float32(var_7_25, ldfld:float32(Vector2::X, ldloc:Vector2[exp:valuetype Microsoft.Xna.Framework.Vector2&](mousePosition)))
	stloc:float32(var_8_2D, ldfld:float32(Vector2::Y, ldloc:Vector2[exp:valuetype Microsoft.Xna.Framework.Vector2&](mousePosition)))
	stloc:float32(var_16_3E, ldfld:float32(Vector2::Y, ldloc:Vector2[exp:valuetype Microsoft.Xna.Framework.Vector2&](mousePosition)))
	stfld:float32(Vector2::Y, ldloc:Vector2[exp:valuetype Microsoft.Xna.Framework.Vector2&](mousePosition), ldloc:float32(var_16_3E))
	stloc:float32(var_18_51, ldfld:float32(Vector2::Y, ldloc:Vector2[exp:valuetype Microsoft.Xna.Framework.Vector2&](mousePosition)))
	stfld:float32(Vector2::Y, ldloc:Vector2[exp:valuetype Microsoft.Xna.Framework.Vector2&](mousePosition), ldloc:float32(var_16_3E))
}

   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1852
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.Optimize(DecompilerContext context, ILBlock method, AutoPropertyProvider autoPropertyProvider, StateMachineKind& stateMachineKind, MethodDef& inlinedMethod, AsyncMethodDebugInfo& asyncInfo, ILAstOptimizationStep abortBeforeStep) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 355
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(IEnumerable`1 parameters, MethodDebugInfoBuilder& builder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 123
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 88
   --- End of inner exception stack trace ---
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 92
   at ICSharpCode.Decompiler.Ast.AstBuilder.AddMethodBody(EntityDeclaration methodNode, EntityDeclaration& updatedNode, MethodDef method, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, MethodKind methodKind) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 1683
*/;
	}

	// Token: 0x06000EC7 RID: 3783 RVA: 0x00048A5C File Offset: 0x00046C5C
	public void CancelDrag()
	{
		int num = 1;
		this.SelectedSlot = num;
		this.SelectedControl = num;
		this.SelectedSlotType = num;
		global::Cursor cursor;
		CursorInputLayer inputLayer = cursor.InputLayer;
		CursorInputLayer inputLayer2 = this._inputLayer;
	}

	// Token: 0x06000EC8 RID: 3784 RVA: 0x00048A94 File Offset: 0x00046C94
	private bool IsButtonInBadPosition(QuickActionButton_Layout buttonLayout, Microsoft.Xna.Framework.Vector2 mousePosition)
	{
		/*
An exception occurred when decompiling this method (06000EC8)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean GUIVirtualInputControllerEdit::IsButtonInBadPosition(QuickActionButton_Layout,Microsoft.Xna.Framework.Vector2)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_003C:
	stfld:float32(Vector2::X, ldloc:Vector2[exp:valuetype Microsoft.Xna.Framework.Vector2&](mousePosition), ldloc:int32[exp:float32](var_6_2F))
	stfld:float32(Vector2::X, ldloc:Vector2[exp:valuetype Microsoft.Xna.Framework.Vector2&](mousePosition), ldloc:int32[exp:float32](var_6_2F))
	stloc:float32(var_19_61, ldfld:float32(Vector2::Y, ldloc:Vector2[exp:valuetype Microsoft.Xna.Framework.Vector2&](mousePosition)))
	stfld:float32(Vector2::Y, ldloc:Vector2[exp:valuetype Microsoft.Xna.Framework.Vector2&](mousePosition), ldloc:float32(var_19_61))
	stloc:float32(var_21_74, ldfld:float32(Vector2::Y, ldloc:Vector2[exp:valuetype Microsoft.Xna.Framework.Vector2&](mousePosition)))
	stfld:float32(Vector2::Y, ldloc:Vector2[exp:valuetype Microsoft.Xna.Framework.Vector2&](mousePosition), ldloc:float32(var_19_61))
}

   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1852
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.Optimize(DecompilerContext context, ILBlock method, AutoPropertyProvider autoPropertyProvider, StateMachineKind& stateMachineKind, MethodDef& inlinedMethod, AsyncMethodDebugInfo& asyncInfo, ILAstOptimizationStep abortBeforeStep) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 355
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(IEnumerable`1 parameters, MethodDebugInfoBuilder& builder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 123
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 88
   --- End of inner exception stack trace ---
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 92
   at ICSharpCode.Decompiler.Ast.AstBuilder.AddMethodBody(EntityDeclaration methodNode, EntityDeclaration& updatedNode, MethodDef method, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, MethodKind methodKind) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 1683
*/;
	}

	// Token: 0x06000EC9 RID: 3785 RVA: 0x00048B20 File Offset: 0x00046D20
	private bool DraggingControlInBadPosition()
	{
		VirtualControlsProfile_Layout virtualControlsProfile_Layout;
		VirtualControlsHardwareConfiguration_Layout hardwareConfig = virtualControlsProfile_Layout.HardwareConfig;
		VirtualControlsProfile_Layout virtualControlsProfile_Layout2;
		VirtualControlsBinding_Layout[] controls = virtualControlsProfile_Layout2.Controls;
		if (hardwareConfig.Slots == null)
		{
		}
		if (controls != null)
		{
		}
		bool flag;
		return flag;
	}

	// Token: 0x06000ECA RID: 3786 RVA: 0x00048B54 File Offset: 0x00046D54
	private void DrawControls()
	{
		VirtualControlsProfile_Layout virtualControlsProfile_Layout;
		VirtualControlsHardwareConfiguration_Layout hardwareConfig = virtualControlsProfile_Layout.HardwareConfig;
		if (hardwareConfig == null)
		{
			return;
		}
		float[] drawScales = this.DrawScales;
		VirtualControlsHardwareConfigurationMapping_Layout[] slots = hardwareConfig.Slots;
		if (drawScales != null)
		{
			VirtualControlsSlotTypeMapping_Layout style = slots.Style;
			return;
		}
		VirtualControlsSlotTypeMapping_Layout style2 = slots.Style;
		VirtualControlsSlotTypeMapping_Layout style3 = hardwareConfig.Slots.Style;
		VirtualControlsProfile_Layout virtualControlsProfile_Layout2;
		VirtualControlsBinding_Layout[] controls = virtualControlsProfile_Layout2.Controls;
		VirtualControlsHardwareConfigurationMapping_Layout[] slots2 = hardwareConfig.Slots;
		int selectedSlot;
		if (this.DraggingSelectedSlot)
		{
			selectedSlot = this.SelectedSlot;
			return;
		}
		if (selectedSlot == 0)
		{
		}
		if (this.SelectedSlot == 0)
		{
		}
	}

	// Token: 0x04001A83 RID: 6787
	private CursorInputLayer _inputLayer;

	// Token: 0x04001A84 RID: 6788
	private GUIInputRegionExclusive _optionsBlocker;

	// Token: 0x04001A85 RID: 6789
	public bool displayProfileOptions;

	// Token: 0x04001A86 RID: 6790
	private bool displayHardwareOptions;

	// Token: 0x04001A87 RID: 6791
	public bool displayPageOptions;

	// Token: 0x04001A88 RID: 6792
	private bool drawnProfileOptions;

	// Token: 0x04001A89 RID: 6793
	private bool drawnHardwareOptions;

	// Token: 0x04001A8A RID: 6794
	private bool drawnPageOptions;

	// Token: 0x04001A8B RID: 6795
	private float ProfileScale;

	// Token: 0x04001A8C RID: 6796
	private float ProfileRenameScale;

	// Token: 0x04001A8D RID: 6797
	private float Profile1Scale;

	// Token: 0x04001A8E RID: 6798
	private float Profile2Scale;

	// Token: 0x04001A8F RID: 6799
	private float Profile3Scale;

	// Token: 0x04001A90 RID: 6800
	private float Profile4Scale;

	// Token: 0x04001A91 RID: 6801
	private float SideControls;

	// Token: 0x04001A92 RID: 6802
	private float BottomControls;

	// Token: 0x04001A93 RID: 6803
	private float HardwareScale;

	// Token: 0x04001A94 RID: 6804
	private float Hardware1Scale;

	// Token: 0x04001A95 RID: 6805
	private float Hardware2Scale;

	// Token: 0x04001A96 RID: 6806
	private float Hardware3Scale;

	// Token: 0x04001A97 RID: 6807
	private float Hardware4Scale;

	// Token: 0x04001A98 RID: 6808
	public bool displayVCControls;

	// Token: 0x04001A99 RID: 6809
	public bool editingName;

	// Token: 0x04001A9A RID: 6810
	private string editNameValue;

	// Token: 0x04001A9B RID: 6811
	private int textBlinkerCount;

	// Token: 0x04001A9C RID: 6812
	private int textBlinkerState;

	// Token: 0x04001A9D RID: 6813
	private List<GUIVirtualInputControllerEdit.StyleOption> StlyeOptionsList;

	// Token: 0x04001A9E RID: 6814
	private string SelectedStyleValue;

	// Token: 0x04001A9F RID: 6815
	private float UndoScale;

	// Token: 0x04001AA0 RID: 6816
	private float RedoScale;

	// Token: 0x04001AA1 RID: 6817
	public float[] Scale;

	// Token: 0x04001AA2 RID: 6818
	public float SettingsScale;

	// Token: 0x04001AA3 RID: 6819
	public float leftMenuButtonScale;

	// Token: 0x04001AA4 RID: 6820
	private float leftScale;

	// Token: 0x04001AA5 RID: 6821
	private float rightScale;

	// Token: 0x04001AA6 RID: 6822
	private float leftInterfaceScale;

	// Token: 0x04001AA7 RID: 6823
	private float rightInterfaceScale;

	// Token: 0x04001AA8 RID: 6824
	private bool LeftPressed;

	// Token: 0x04001AA9 RID: 6825
	private bool RightPressed;

	// Token: 0x04001AAA RID: 6826
	private bool PendingUIControlDrag;

	// Token: 0x04001AAB RID: 6827
	private Microsoft.Xna.Framework.Vector2 PendingUIControlDragStart;

	// Token: 0x04001AAC RID: 6828
	private bool UIControlDrag;

	// Token: 0x04001AAD RID: 6829
	private int SelectedControl;

	// Token: 0x04001AAE RID: 6830
	private string SelectedControlStyle;

	// Token: 0x04001AAF RID: 6831
	private float TimeSinceControlChange;

	// Token: 0x04001AB0 RID: 6832
	private float TimeSinceSlotChange;

	// Token: 0x04001AB1 RID: 6833
	private int SelectedSlotType;

	// Token: 0x04001AB2 RID: 6834
	private bool PendingUISlotDrag;

	// Token: 0x04001AB3 RID: 6835
	private bool UISlotDrag;

	// Token: 0x04001AB4 RID: 6836
	private Microsoft.Xna.Framework.Vector2 PendingUISlotDragStart;

	// Token: 0x04001AB5 RID: 6837
	private List<int> SlotOrder;

	// Token: 0x04001AB6 RID: 6838
	private bool drawnFromDrag;

	// Token: 0x04001AB7 RID: 6839
	private float smallScale;

	// Token: 0x04001AB8 RID: 6840
	private float mediumScale;

	// Token: 0x04001AB9 RID: 6841
	private float largeScale;

	// Token: 0x04001ABA RID: 6842
	private float extraLargeScale;

	// Token: 0x04001ABB RID: 6843
	private float deleteScale;

	// Token: 0x04001ABC RID: 6844
	private List<VirtualControlsButtonConfiguration_Layout> availableButtonControls;

	// Token: 0x04001ABD RID: 6845
	private List<VirtualControlsAxisConfiguration_Layout> availableAxisControls;

	// Token: 0x04001ABE RID: 6846
	private float MappingsScale;

	// Token: 0x04001ABF RID: 6847
	private float ControlsButtonScale;

	// Token: 0x04001AC0 RID: 6848
	private Microsoft.Xna.Framework.Vector2 dragCursorStartLeft;

	// Token: 0x04001AC1 RID: 6849
	private Microsoft.Xna.Framework.Vector2 dragControlStartLeft;

	// Token: 0x04001AC2 RID: 6850
	private Microsoft.Xna.Framework.Vector2 dragCursorStartRight;

	// Token: 0x04001AC3 RID: 6851
	private Microsoft.Xna.Framework.Vector2 dragControlStartRight;

	// Token: 0x04001AC4 RID: 6852
	private Microsoft.Xna.Framework.Vector2 dragCursorStartInterface;

	// Token: 0x04001AC5 RID: 6853
	private Microsoft.Xna.Framework.Vector2 dragControlStartInterface;

	// Token: 0x04001AC6 RID: 6854
	private bool draggingRegion;

	// Token: 0x04001AC7 RID: 6855
	private bool draggingRight;

	// Token: 0x04001AC8 RID: 6856
	public GUIPageIconGrouping selectedGrouping;

	// Token: 0x04001AC9 RID: 6857
	private bool draggingInterface;

	// Token: 0x04001ACA RID: 6858
	public bool ControlsDirty;

	// Token: 0x04001ACB RID: 6859
	public Rectangle leftControlsRegionCached;

	// Token: 0x04001ACC RID: 6860
	public Rectangle rightControlsRegionCached;

	// Token: 0x04001ACD RID: 6861
	private const float visualBorderRegion = 2f;

	// Token: 0x04001ACE RID: 6862
	private bool DraggingSelectedSlot;

	// Token: 0x04001ACF RID: 6863
	private Microsoft.Xna.Framework.Vector2 SlotStartPosition;

	// Token: 0x04001AD0 RID: 6864
	private Microsoft.Xna.Framework.Vector2 DragStartPosition;

	// Token: 0x04001AD1 RID: 6865
	private Microsoft.Xna.Framework.Vector2 DragPosition;

	// Token: 0x04001AD2 RID: 6866
	private int SelectedSlot;

	// Token: 0x04001AD3 RID: 6867
	private bool SelectedSlotCursorActive;

	// Token: 0x04001AD4 RID: 6868
	private const int dragBufferSize = 15;

	// Token: 0x04001AD5 RID: 6869
	private float DraggingScale;

	// Token: 0x04001AD6 RID: 6870
	private float[] ControlsScales;

	// Token: 0x04001AD7 RID: 6871
	private float[] DrawScales;

	// Token: 0x02000283 RID: 643
	private struct StyleOption
	{
		// Token: 0x04001AD8 RID: 6872
		public string ConfigurationId;

		// Token: 0x04001AD9 RID: 6873
		public string DisplayValue;
	}

	// Token: 0x02000284 RID: 644
	[CompilerGenerated]
	private sealed class <>c__DisplayClass72_0
	{
		// Token: 0x06000ECB RID: 3787 RVA: 0x00048CFC File Offset: 0x00046EFC
		public <>c__DisplayClass72_0()
		{
		}

		// Token: 0x06000ECC RID: 3788 RVA: 0x00048D10 File Offset: 0x00046F10
		internal int <RefreshSlotOrder>b__0(int e1, int e2)
		{
			VirtualInputControllerEdit_Layout.SlotPriority controlPriority = this.layout.ControlPriority;
			VirtualInputControllerEdit_Layout.SlotPriority controlPriority2 = this.layout.ControlPriority;
			int num;
			return num.CompareTo(num);
		}

		// Token: 0x04001ADA RID: 6874
		public VirtualInputControllerEdit_Layout layout;
	}
}
