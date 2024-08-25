using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Controller;
using Cpp2IlInjected;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.Localization;
using UnityEngine;

// Token: 0x0200025E RID: 606
public class GUIInterfaceEdit
{
	// Token: 0x06000D7D RID: 3453 RVA: 0x000403BC File Offset: 0x0003E5BC
	public void Draw()
	{
		GUIControllerInterfaceEdit controller = this._controller;
		GUIInterfaceEdit.EditMode mode = this.Mode;
	}

	// Token: 0x06000D7E RID: 3454 RVA: 0x000404A4 File Offset: 0x0003E6A4
	private void DrawCategories()
	{
		GUIInterfaceEdit.EditMode mode = this.Mode;
		GUITransactionButton.InputState inputState;
		if (inputState == GUITransactionButton.InputState.Clicked)
		{
			int num = 1;
			this.Mode = (GUIInterfaceEdit.EditMode)num;
		}
		GUIInterfaceEdit.EditMode mode2 = this.Mode;
		GUITransactionButton.InputState inputState2;
		if (inputState2 == GUITransactionButton.InputState.Clicked)
		{
		}
		GUIInterfaceEdit.EditMode mode3 = this.Mode;
		GUITransactionButton.InputState inputState3;
		if (inputState3 != GUITransactionButton.InputState.Clicked)
		{
			return;
		}
		this.ClearControlUndoRedo();
		int num2 = 3;
		this.Mode = (GUIInterfaceEdit.EditMode)num2;
	}

	// Token: 0x06000D7F RID: 3455 RVA: 0x000404FC File Offset: 0x0003E6FC
	private bool CanSpawn(List<GUIPageIconGrouping> groups, List<GUIPageIconGrouping> otherGroups, bool left, [Out] Microsoft.Xna.Framework.Vector2 position)
	{
		/*
An exception occurred when decompiling this method (06000D7F)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean GUIInterfaceEdit::CanSpawn(System.Collections.Generic.List`1<GUIPageIconGrouping>,System.Collections.Generic.List`1<GUIPageIconGrouping>,System.Boolean,Microsoft.Xna.Framework.Vector2)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0006:
	stloc:int32(var_0_0C, ldfld:int32(List`1::_size, ldloc:class [mscorlib]System.Collections.Generic.List`1<class GUIPageIconGrouping>[exp:List`1](groups)))
	stloc:int32(var_2_13, callgetter:int32(Rectangle::get_Bottom, ldloc:Rectangle[exp:valuetype Microsoft.Xna.Framework.Rectangle&](var_1)))
	stloc:int32(var_3_1A, ldfld:int32(List`1::_size, ldloc:class [mscorlib]System.Collections.Generic.List`1<class GUIPageIconGrouping>[exp:List`1](groups)))
	stloc:int32(var_5_22, callgetter:int32(Rectangle::get_Bottom, ldloc:Rectangle[exp:valuetype Microsoft.Xna.Framework.Rectangle&](var_4)))
	stloc:int32(var_9_2D, ldfld:int32(List`1::_size, ldloc:class [mscorlib]System.Collections.Generic.List`1<class GUIPageIconGrouping>[exp:List`1](otherGroups)))
	stloc:int32(var_13_38, ldfld:int32(List`1::_size, ldloc:class [mscorlib]System.Collections.Generic.List`1<class GUIPageIconGrouping>[exp:List`1](otherGroups)))
	stloc:int32(var_15_43, ldfld:int32(List`1::_size, ldloc:class [mscorlib]System.Collections.Generic.List`1<class GUIPageIconGrouping>[exp:List`1](groups)))
	stloc:int32(var_18_4F, callgetter:int32(Rectangle::get_Bottom, ldloc:Rectangle[exp:valuetype Microsoft.Xna.Framework.Rectangle&](var_17)))
	stloc:int32(var_20_57, ldfld:int32(List`1::_size, ldloc:class [mscorlib]System.Collections.Generic.List`1<class GUIPageIconGrouping>[exp:List`1](groups)))
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

	// Token: 0x06000D80 RID: 3456 RVA: 0x00040564 File Offset: 0x0003E764
	private bool FindSpaceToSpawn([Out] Microsoft.Xna.Framework.Vector2 position, [Out] bool left)
	{
		if (!true)
		{
		}
		List<GUIPageIconGrouping> rightGroupings = InterfaceStyles_Layout.Active.RightGroupings;
		int size = rightGroupings._size;
		int size2 = InterfaceStyles_Layout.Active.LeftGroupings._size;
		List<GUIPageIconGrouping> rightGroupings2 = InterfaceStyles_Layout.Active.RightGroupings;
		List<GUIPageIconGrouping> leftGroupings = InterfaceStyles_Layout.Active.LeftGroupings;
		bool flag;
		return flag;
	}

	// Token: 0x06000D81 RID: 3457 RVA: 0x00040628 File Offset: 0x0003E828
	public int SortGroupByPosition(GUIPageIconGrouping x, GUIPageIconGrouping y)
	{
		int num;
		do
		{
			float y2 = y.Location.Y;
		}
		while (num != 0);
		List<GUIPageIcons.Category> allowedCategories = x.AllowedCategories;
		List<GUIPageIcons.Category> allowedCategories2 = y.AllowedCategories;
		return 1;
	}

	// Token: 0x06000D82 RID: 3458 RVA: 0x000021DB File Offset: 0x000003DB
	private float PageScale(int index)
	{
		throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
	}

	// Token: 0x06000D83 RID: 3459 RVA: 0x00040654 File Offset: 0x0003E854
	private void PageOver(int index)
	{
		bool mouseLeft = Main.mouseLeft;
		bool mouseLeftRelease = Main.mouseLeftRelease;
		List<GUIPageIconGrouping> leftGroupings = InterfaceStyles_Layout.Active.LeftGroupings;
		int size = leftGroupings._size;
		int size2 = InterfaceStyles_Layout.Active.RightGroupings._size;
		if (size2 == 0)
		{
		}
		bool mouseLeft2 = Main.mouseLeft;
		if (size2 == 0)
		{
		}
		bool mouseLeftRelease2 = Main.mouseLeftRelease;
		if (size2 == 0)
		{
		}
		List<GUIPageIconGrouping> leftGroupings2 = InterfaceStyles_Layout.Active.LeftGroupings;
		int size3 = leftGroupings2._size;
		if (leftGroupings2 == null)
		{
		}
		List<GUIPageIconGrouping> leftGroupings3 = InterfaceStyles_Layout.Active.LeftGroupings;
	}

	// Token: 0x06000D84 RID: 3460 RVA: 0x000406FC File Offset: 0x0003E8FC
	public Microsoft.Xna.Framework.Vector2 ItemSize(int index)
	{
		/*
An exception occurred when decompiling this method (06000D84)

ICSharpCode.Decompiler.DecompilerException: Error decompiling Microsoft.Xna.Framework.Vector2 GUIInterfaceEdit::ItemSize(System.Int32)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0003:
	stloc:class [mscorlib]System.Collections.Generic.List`1<class GUIPageIconGrouping>(var_1_0F, ldfld:class [mscorlib]System.Collections.Generic.List`1<class GUIPageIconGrouping>(InterfaceProfile_Layout::LeftGroupings, callgetter:InterfaceProfile_Layout(InterfaceStyles_Layout::get_Active)))
	stloc:int32(var_3_18, ldfld:int32(List`1::_size, ldloc:class [mscorlib]System.Collections.Generic.List`1<class GUIPageIconGrouping>[exp:List`1](var_1_0F)))
	stloc:int32(var_4_28, ldfld:int32(List`1::_size, ldfld:class [mscorlib]System.Collections.Generic.List`1<class GUIPageIconGrouping>[exp:List`1](InterfaceProfile_Layout::RightGroupings, callgetter:InterfaceProfile_Layout(InterfaceStyles_Layout::get_Active))))
	stloc:int32(var_5_30, ldfld:int32(GUIInterfaceEdit::SelectedItem, ldloc:GUIInterfaceEdit(this)))
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

	// Token: 0x06000D85 RID: 3461 RVA: 0x0004073C File Offset: 0x0003E93C
	private void PageIconDraw(ItemGrid_Layout gridLayout, int index, Microsoft.Xna.Framework.Vector2 position, float scale)
	{
		List<GUIPageIcons.Category> options = this.currentGroup._options;
		float x = this.pageButtonRegionSize.X;
		float y = this.pageButtonRegionSize.Y;
	}

	// Token: 0x06000D86 RID: 3462 RVA: 0x00040770 File Offset: 0x0003E970
	private void PageIconOver(int index)
	{
	}

	// Token: 0x06000D87 RID: 3463 RVA: 0x000021DB File Offset: 0x000003DB
	private float PageIconScale(int index)
	{
		throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
	}

	// Token: 0x06000D88 RID: 3464 RVA: 0x00040780 File Offset: 0x0003E980
	private bool LoadSettingAnchor(GUIPageIconGrouping.SettingCategory category, Rectangle itemRegion)
	{
		List<GUIPageIconGrouping.SettingCategory> settings = this.currentGroup._settings;
		int x = itemRegion.X;
		int width = itemRegion.Width;
		bool leftSideGrouping = this.currentGroup.LeftSideGrouping;
		GUIPageIconGrouping guipageIconGrouping = this.currentGroup;
		List<GUIPageIconGrouping.SettingCategory> settings2 = guipageIconGrouping._settings;
		if (guipageIconGrouping == null)
		{
			return;
		}
	}

	// Token: 0x06000D89 RID: 3465 RVA: 0x000407D0 File Offset: 0x0003E9D0
	private void PageDraw(ItemGrid_Layout gridLayout, int index, Microsoft.Xna.Framework.Vector2 position, float scale)
	{
		List<GUIPageIconGrouping> leftGroupings = InterfaceStyles_Layout.Active.LeftGroupings;
		int size = leftGroupings._size;
		int size2 = InterfaceStyles_Layout.Active.RightGroupings._size;
	}

	// Token: 0x06000D8A RID: 3466 RVA: 0x000021DB File Offset: 0x000003DB
	private bool DrawMenuButton(ControllerActionButton action, string label, TransactionButton_Layout buttonLayout, float scale, bool disabled)
	{
		throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
	}

	// Token: 0x06000D8B RID: 3467 RVA: 0x0004093C File Offset: 0x0003EB3C
	public void RefreshSelected()
	{
		if (!true)
		{
		}
		List<GUIPageIconGrouping> leftGroupings = InterfaceStyles_Layout.Active.LeftGroupings;
		this.SelectedItem = leftGroupings;
	}

	// Token: 0x06000D8C RID: 3468 RVA: 0x000409A8 File Offset: 0x0003EBA8
	private void DrawPgeGroups()
	{
		int num = 1;
		this.pageOver = num;
		if (num == 0)
		{
		}
		List<GUIPageIconGrouping> leftGroupings = InterfaceStyles_Layout.Active.LeftGroupings;
		int size = leftGroupings._size;
		int size2 = InterfaceStyles_Layout.Active.RightGroupings._size;
		this._groupCount = size2;
		int groupCount = this._groupCount;
		this._groupCount = groupCount;
		this.RefreshSelected();
		int groupCount2 = this._groupCount;
	}

	// Token: 0x06000D8D RID: 3469 RVA: 0x000021DB File Offset: 0x000003DB
	private void DrawGroupEditControls()
	{
		throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
	}

	// Token: 0x06000D8E RID: 3470 RVA: 0x00040A10 File Offset: 0x0003EC10
	private void DrawSafeRegionOptions()
	{
		bool mouseLeft = Main.mouseLeft;
		bool mouseLeftRelease = Main.mouseLeftRelease;
		GUITransactionButton.InputState inputState;
		if (inputState == GUITransactionButton.InputState.Clicked)
		{
			this.RestoreDefaults();
		}
		GUITransactionButton.InputState inputState2;
		if (inputState2 == GUITransactionButton.InputState.Clicked)
		{
			this.CancelChanges();
		}
		GUITransactionButton.InputState inputState3;
		if (inputState3 == GUITransactionButton.InputState.Clicked)
		{
			this.ClearControlUndoRedo();
		}
	}

	// Token: 0x06000D8F RID: 3471 RVA: 0x00040A54 File Offset: 0x0003EC54
	private bool CanApply()
	{
		return true;
	}

	// Token: 0x06000D90 RID: 3472 RVA: 0x00040A64 File Offset: 0x0003EC64
	private void DrawOptions()
	{
		bool mouseLeft = Main.mouseLeft;
		if ("Serbian (Cyrillic, Bosnia and Herzegovina)" == null)
		{
		}
		bool mouseLeftRelease = Main.mouseLeftRelease;
		if ("Serbian (Cyrillic, Bosnia and Herzegovina)" == null)
		{
		}
		GUITransactionButton.InputState inputState;
		if (inputState == GUITransactionButton.InputState.Clicked)
		{
		}
		if ("Serbian (Cyrillic, Bosnia and Herzegovina)" == null)
		{
		}
		GUITransactionButton.InputState inputState2;
		if (inputState2 == GUITransactionButton.InputState.Clicked)
		{
		}
	}

	// Token: 0x06000D91 RID: 3473 RVA: 0x00040AA4 File Offset: 0x0003ECA4
	private void DrawControlsOptions()
	{
		bool mouseLeft = Main.mouseLeft;
		bool mouseLeftRelease = Main.mouseLeftRelease;
		GUITransactionButton.InputState inputState;
		if (inputState == GUITransactionButton.InputState.Clicked)
		{
			this.RestoreDefaults();
		}
		GUITransactionButton.InputState inputState2;
		if (inputState2 == GUITransactionButton.InputState.Clicked)
		{
			this.CancelChanges();
		}
		GUITransactionButton.InputState inputState3;
		if (inputState3 == GUITransactionButton.InputState.Clicked)
		{
			this.ClearControlUndoRedo();
		}
	}

	// Token: 0x06000D92 RID: 3474 RVA: 0x00040AE8 File Offset: 0x0003ECE8
	public void CancelChanges()
	{
		this.RestoreBackup();
	}

	// Token: 0x06000D93 RID: 3475 RVA: 0x00040AFC File Offset: 0x0003ECFC
	public void ClampUIScale()
	{
		bool enabled;
		if (this.dragState.wasDragging)
		{
			enabled = this.Enabled;
			if (enabled)
			{
				return;
			}
		}
		if (!enabled)
		{
		}
		int minVerticalResolution = InterfaceStyles_Layout.Active.MinVerticalResolution;
		int minVerticalResolution2 = InterfaceStyles_Layout.Active.MinVerticalResolution;
	}

	// Token: 0x06000D94 RID: 3476 RVA: 0x00040B50 File Offset: 0x0003ED50
	private string GetDisplayName(InterfaceProfile_Layout profile, float maxWidth, bool isTemplate)
	{
		string text;
		string textValue = Language.GetTextValue(text);
		SpriteFont spriteFont;
		Microsoft.Xna.Framework.Vector2 vector = spriteFont.MeasureString(textValue);
		string text2 = textValue + "...";
		long num = 0L;
		SpriteFont spriteFont2;
		Microsoft.Xna.Framework.Vector2 vector2 = spriteFont2.MeasureString(text2);
		int stringLength = textValue._stringLength;
		long num2 = 0L;
		return textValue.Substring((int)num2, (int)num);
	}

	// Token: 0x06000D95 RID: 3477 RVA: 0x00040BB0 File Offset: 0x0003EDB0
	private bool IsOverOptions(Microsoft.Xna.Framework.Vector2 cursorPosition)
	{
		if (this.displayProfileOptions)
		{
			this.CloseProfileOptions();
		}
		if (this.displayTemplateOptions)
		{
			this.CloseTemplateOptions();
		}
		return true;
	}

	// Token: 0x06000D96 RID: 3478 RVA: 0x00040BDC File Offset: 0x0003EDDC
	public void CloseNameEdit()
	{
		if (!true)
		{
		}
		Main.CloseKeyboard();
	}

	// Token: 0x06000D97 RID: 3479 RVA: 0x00040BF4 File Offset: 0x0003EDF4
	public void CloseProfileOptions()
	{
		GUIInputRegionExclusive optionsBlocker = this._optionsBlocker;
	}

	// Token: 0x06000D98 RID: 3480 RVA: 0x00040C08 File Offset: 0x0003EE08
	public void CloseTemplateOptions()
	{
	}

	// Token: 0x06000D99 RID: 3481 RVA: 0x00040C20 File Offset: 0x0003EE20
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
		InterfaceProfile_Layout active = InterfaceStyles_Layout.Active;
		bool flag2 = this.editingName;
		if (flag2)
		{
			string text = this.editNameValue;
			long num = 0L;
			if (!flag2)
			{
			}
			int num2 = 20;
			long num3 = 0L;
			long num4 = 0L;
			long num5 = 0L;
			Rectangle rectangle;
			string inputText = Main.GetInputText(text, rectangle, (int)num, num2 != 0, num3 != 0L, num4 != 0L, num5 != 0L);
			this.editNameValue = inputText;
			int stringLength = inputText._stringLength;
			int num6 = 20;
			long num7 = 0L;
			string text2 = inputText.Substring((int)num7, num6);
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
			InterfaceProfile_Layout active2 = InterfaceStyles_Layout.Active;
			string text3 = this.editNameValue;
			active2.ProfileName = text3;
			int num8 = this.textBlinkerCount;
			this.textBlinkerCount = num8;
			int num9 = this.textBlinkerState;
			this._optionsBlocker = num9;
			string text4 = this.editNameValue;
			bool flag3 = string.IsNullOrEmpty(text4);
			SpriteFont spriteFont;
			Microsoft.Xna.Framework.Vector2 vector = spriteFont.MeasureString(text4);
			long num10 = 0L;
			SpriteFont spriteFont2;
			string text5;
			Microsoft.Xna.Framework.Vector2 vector2 = spriteFont2.MeasureString(text5);
			int stringLength2 = text4._stringLength;
			int num11 = 1;
			string text6 = text4.Substring(num11, (int)num10);
			return;
		}
		else
		{
			GUIInputRegionExclusive optionsBlocker = this._optionsBlocker;
			bool flag4 = this.displayProfileOptions;
			int num12;
			if (optionsBlocker != null)
			{
				if (flag4)
				{
					return;
				}
			}
			else if (flag4)
			{
				if (optionsBlocker == null)
				{
				}
				num12 = 1;
				string text7;
				int stringLength3 = text7._stringLength;
				return;
			}
			if (num12 == 0)
			{
			}
			InterfaceProfile_Layout active3 = InterfaceStyles_Layout.Active;
			bool flag5 = this.displayProfileOptions;
			GUITransactionButton.InputState inputState;
			if (inputState == GUITransactionButton.InputState.Clicked)
			{
				this.CloseProfileOptions();
				return;
			}
			GUIControllerInterfaceEdit guicontrollerInterfaceEdit;
			int pageRow = guicontrollerInterfaceEdit.PageRow;
			return;
		}
	}

	// Token: 0x06000D9A RID: 3482 RVA: 0x00040EEC File Offset: 0x0003F0EC
	private void RefreshTemplate()
	{
		bool flag = this.selectedCustom;
		if (!flag)
		{
			if (!flag)
			{
			}
			InterfaceProfile_Layout active = InterfaceStyles_Layout.Active;
			return;
		}
	}

	// Token: 0x06000D9B RID: 3483 RVA: 0x00040F20 File Offset: 0x0003F120
	public void EnsureSelectedGroupVisible()
	{
		if (!true)
		{
		}
		List<GUIPageIconGrouping> leftGroupings = InterfaceStyles_Layout.Active.LeftGroupings;
		List<GUIPageIconGrouping> rightGroupings = InterfaceStyles_Layout.Active.RightGroupings;
		int size = InterfaceStyles_Layout.Active.LeftGroupings._size;
	}

	// Token: 0x06000D9C RID: 3484 RVA: 0x00040F7C File Offset: 0x0003F17C
	private void DrawTemplate()
	{
		bool mouseLeft = Main.mouseLeft;
		bool mouseLeftRelease = Main.mouseLeftRelease;
		this.RefreshTemplate();
		if (this.currentProfile != null)
		{
			return;
		}
		string textValue = Language.GetTextValue("InterfaceProfiles.Custom");
		GUIInputRegionExclusive optionsBlocker = this._optionsBlocker;
		bool flag = this.displayTemplateOptions;
		if (optionsBlocker == null || flag)
		{
		}
		GUITransactionButton.InputState inputState;
		GUIInputRegionExclusive.IsOverHandler isOver;
		if (inputState == GUITransactionButton.InputState.Clicked)
		{
			if (this.displayTemplateOptions)
			{
				this.CloseTemplateOptions();
				return;
			}
			isOver = optionsBlocker.isOver;
			if (isOver == null)
			{
			}
			if (!true)
			{
			}
			Main.mouseLeftRelease = Main.mouseLeftRelease;
			GUIInputRegionExclusive guiinputRegionExclusive;
			this._optionsBlocker = guiinputRegionExclusive;
		}
		string textValue2 = Language.GetTextValue("Mobile.ProfileTemplate");
		if (isOver == null)
		{
		}
		bool flag2 = this.displayTemplateOptions;
		if (flag2)
		{
			if (!flag2)
			{
			}
			string text;
			string textValue3 = Language.GetTextValue(text);
			int stringLength = textValue2._stringLength;
			string text2;
			string textValue4 = Language.GetTextValue(text2);
			string text3;
			string textValue5 = Language.GetTextValue(text3);
			string textValue6 = Language.GetTextValue("InterfaceProfiles.Custom");
			SpriteFont spriteFont;
			Microsoft.Xna.Framework.Vector2 vector = spriteFont.MeasureString(textValue3);
			SpriteFont spriteFont2;
			Microsoft.Xna.Framework.Vector2 vector2 = spriteFont2.MeasureString(textValue4);
			SpriteFont spriteFont3;
			Microsoft.Xna.Framework.Vector2 vector3 = spriteFont3.MeasureString(textValue5);
			SpriteFont spriteFont4;
			Microsoft.Xna.Framework.Vector2 vector4 = spriteFont4.MeasureString(textValue6);
			Microsoft.Xna.Framework.Graphics.Texture2D texture2D;
			int width = texture2D.Width;
			DrPlatform.DrPlatformType currentPlatform = DrPlatform.CurrentPlatform;
			InterfaceProfile_Layout interfaceProfile_Layout = this.currentProfile;
			return;
		}
	}

	// Token: 0x06000D9D RID: 3485 RVA: 0x00041358 File Offset: 0x0003F558
	public void DrawWidgetOverlays()
	{
		if (!true)
		{
		}
		if (this.displayTemplateOptions && !this.drawnTemplateOptions)
		{
			this.DrawTemplate();
		}
	}

	// Token: 0x06000D9E RID: 3486 RVA: 0x00041380 File Offset: 0x0003F580
	private void DrawUITweaks()
	{
		if (!this.displayTemplateOptions)
		{
			this.drawnTemplateOptions = true;
			this.DrawTemplate();
		}
		if (!true)
		{
		}
		bool mouseLeft = Main.mouseLeft;
		if (!true)
		{
		}
		bool mouseLeftRelease = Main.mouseLeftRelease;
		if (!true)
		{
		}
		this.ClampUIScale();
		if (!true)
		{
		}
		int minVerticalResolution = InterfaceStyles_Layout.Active.MinVerticalResolution;
		if (!true)
		{
		}
		int minVerticalResolution2 = InterfaceStyles_Layout.Active.MinVerticalResolution;
	}

	// Token: 0x06000D9F RID: 3487 RVA: 0x0004151C File Offset: 0x0003F71C
	public void Backup()
	{
		VirtualControlsProfile_Layout virtualControlsProfile_Layout;
		this.BackupActiveProfile = virtualControlsProfile_Layout;
		VirtualControlsHardwareConfiguration_Layout backupHardware = this.BackupHardware1;
		VirtualControlsProfile_Layout virtualControlsProfile_Layout2;
		VirtualControlsHardwareConfiguration_Layout hardwareConfig = virtualControlsProfile_Layout2.HardwareConfig;
		backupHardware.Copy(hardwareConfig);
		VirtualControlsProfile_Layout virtualControlsProfile_Layout3;
		this.BackupProfile1.Copy(virtualControlsProfile_Layout3);
		VirtualControlsHardwareConfiguration_Layout backupHardware2 = this.BackupHardware2;
		VirtualControlsProfile_Layout virtualControlsProfile_Layout4;
		VirtualControlsHardwareConfiguration_Layout hardwareConfig2 = virtualControlsProfile_Layout4.HardwareConfig;
		backupHardware2.Copy(hardwareConfig2);
		VirtualControlsProfile_Layout backupProfile = this.BackupProfile2;
		VirtualControlsHardwareConfiguration_Layout backupHardware3 = this.BackupHardware3;
		VirtualControlsProfile_Layout virtualControlsProfile_Layout5;
		VirtualControlsHardwareConfiguration_Layout hardwareConfig3 = virtualControlsProfile_Layout5.HardwareConfig;
		backupHardware3.Copy(hardwareConfig3);
		VirtualControlsProfile_Layout virtualControlsProfile_Layout6;
		this.BackupProfile3.Copy(virtualControlsProfile_Layout6);
		VirtualControlsHardwareConfiguration_Layout backupHardware4 = this.BackupHardware4;
		VirtualControlsProfile_Layout virtualControlsProfile_Layout7;
		VirtualControlsHardwareConfiguration_Layout hardwareConfig4 = virtualControlsProfile_Layout7.HardwareConfig;
		backupHardware4.Copy(hardwareConfig4);
		VirtualControlsProfile_Layout virtualControlsProfile_Layout8;
		this.BackupProfile4.Copy(virtualControlsProfile_Layout8);
		InterfaceProfile_Layout backupInterfaceProfile = this.BackupInterfaceProfile;
		InterfaceProfile_Layout active = InterfaceStyles_Layout.Active;
		long num = 0L;
		backupInterfaceProfile.Copy(active, num != 0L);
		InterfaceProfile_Layout backupInterfaceProfile2 = this.BackupInterfaceProfile;
		string profileName = InterfaceStyles_Layout.Active.ProfileName;
		backupInterfaceProfile2.ProfileName = profileName;
		this.AddControlUndo();
		Microsoft.Xna.Framework.Vector2 leftControls = ControlAnchor.LeftControls;
		Microsoft.Xna.Framework.Vector2 rightControls = ControlAnchor.RightControls;
		if (profileName == null)
		{
		}
	}

	// Token: 0x06000DA0 RID: 3488 RVA: 0x000021DB File Offset: 0x000003DB
	public void AddControlUndo()
	{
		throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
	}

	// Token: 0x06000DA1 RID: 3489 RVA: 0x000021DB File Offset: 0x000003DB
	public bool HasUndo()
	{
		throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
	}

	// Token: 0x06000DA2 RID: 3490 RVA: 0x000021DB File Offset: 0x000003DB
	public void ControlUndo()
	{
		throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
	}

	// Token: 0x06000DA3 RID: 3491 RVA: 0x00041620 File Offset: 0x0003F820
	public bool HasRedo()
	{
		/*
An exception occurred when decompiling this method (06000DA3)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean GUIInterfaceEdit::HasRedo()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:int32(var_0_0B, ldfld:int32(List`1::_size, ldfld:class [mscorlib]System.Collections.Generic.List`1<class GUIInterfaceEdit/BackupResotrePoint>[exp:List`1](GUIInterfaceEdit::RedoPoints, ldloc:GUIInterfaceEdit(this))))
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

	// Token: 0x06000DA4 RID: 3492 RVA: 0x000021DB File Offset: 0x000003DB
	public void ControlRedo()
	{
		throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
	}

	// Token: 0x06000DA5 RID: 3493 RVA: 0x000021DB File Offset: 0x000003DB
	public void ClearControlRedo()
	{
		throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
	}

	// Token: 0x06000DA6 RID: 3494 RVA: 0x000021DB File Offset: 0x000003DB
	public void ClearControlUndoRedo()
	{
		throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
	}

	// Token: 0x06000DA7 RID: 3495 RVA: 0x00041638 File Offset: 0x0003F838
	public void LoadDefaultProfilePositions(VirtualControlsHardwareConfiguration_Layout configuration)
	{
		if (!true)
		{
		}
		configuration.LeftControlsPosition = 17199;
		configuration.RightControlsPosition = 17199;
		configuration.SettingsPosition = 17175;
		configuration.MenuPosition = 49943;
		configuration.LeftPagePosition = 49962;
		configuration.RightPagePosition = 49965;
	}

	// Token: 0x06000DA8 RID: 3496 RVA: 0x000416D4 File Offset: 0x0003F8D4
	public void RestoreDefaults()
	{
		if (!true)
		{
		}
		VirtualControlsProfile_Layout virtualControlsProfile_Layout;
		VirtualControlsHardwareConfiguration_Layout virtualControlsHardwareConfiguration_Layout;
		virtualControlsProfile_Layout.HardwareConfig.Copy(virtualControlsHardwareConfiguration_Layout);
		VirtualControlsProfile_Layout virtualControlsProfile_Layout2;
		virtualControlsProfile_Layout2.HardwareConfig.LoadControlPositions();
		VirtualControlsProfile_Layout virtualControlsProfile_Layout3;
		VirtualControlsSlotTypeMapping_Layout style = virtualControlsProfile_Layout3.HardwareConfig.Slots.Style;
		VirtualControlsProfile_Layout virtualControlsProfile_Layout4;
		VirtualControlsHardwareConfigurationMapping_Layout.ContolType action = virtualControlsProfile_Layout4.Controls.Action;
		VirtualControlsProfile_Layout virtualControlsProfile_Layout5;
		VirtualControlsBinding_Layout[] controls = virtualControlsProfile_Layout5.Controls;
		VirtualControlsProfile_Layout virtualControlsProfile_Layout6;
		VirtualControlsBinding_Layout[] controls2 = virtualControlsProfile_Layout6.Controls;
		VirtualControlsProfile_Layout virtualControlsProfile_Layout7;
		string slotId = virtualControlsProfile_Layout7.HardwareConfig.Slots.SlotId;
		VirtualControlsProfile_Layout virtualControlsProfile_Layout8;
		VirtualControlsBinding_Layout[] controls3 = virtualControlsProfile_Layout8.Controls;
		VirtualControlsProfile_Layout virtualControlsProfile_Layout9;
		VirtualControlsHardwareConfigurationMapping_Layout.ContolType defaultControl = virtualControlsProfile_Layout9.HardwareConfig.Slots.DefaultControl;
		VirtualControlsProfile_Layout virtualControlsProfile_Layout10;
		VirtualControlsBinding_Layout[] controls4 = virtualControlsProfile_Layout10.Controls;
		if (controls4 == null)
		{
		}
		InterfaceStyles_Layout.Active.InvalidateMinResolution();
		InterfaceStyles_Layout.LoadUIResolution();
		if (controls4 == null)
		{
		}
		int num = 1;
		if (num == 0)
		{
		}
		int value = num.m_value;
		int num2 = 1;
		if (num2 == 0)
		{
		}
		int value2 = num2.m_value;
		this.ClearControlUndoRedo();
	}

	// Token: 0x06000DA9 RID: 3497 RVA: 0x000417B8 File Offset: 0x0003F9B8
	public void RestoreBackup()
	{
		VirtualControlsProfile_Layout backupProfile = this.BackupProfile1;
		VirtualControlsProfile_Layout virtualControlsProfile_Layout;
		virtualControlsProfile_Layout.Copy(backupProfile);
		VirtualControlsProfile_Layout virtualControlsProfile_Layout2;
		VirtualControlsHardwareConfiguration_Layout hardwareConfig = virtualControlsProfile_Layout2.HardwareConfig;
		VirtualControlsHardwareConfiguration_Layout backupHardware = this.BackupHardware1;
		hardwareConfig.Copy(backupHardware);
		VirtualControlsProfile_Layout backupProfile2 = this.BackupProfile2;
		VirtualControlsProfile_Layout virtualControlsProfile_Layout3;
		virtualControlsProfile_Layout3.Copy(backupProfile2);
		VirtualControlsProfile_Layout virtualControlsProfile_Layout4;
		VirtualControlsHardwareConfiguration_Layout hardwareConfig2 = virtualControlsProfile_Layout4.HardwareConfig;
		VirtualControlsHardwareConfiguration_Layout backupHardware2 = this.BackupHardware2;
		hardwareConfig2.Copy(backupHardware2);
		VirtualControlsProfile_Layout backupProfile3 = this.BackupProfile3;
		VirtualControlsProfile_Layout virtualControlsProfile_Layout5;
		virtualControlsProfile_Layout5.Copy(backupProfile3);
		VirtualControlsProfile_Layout virtualControlsProfile_Layout6;
		VirtualControlsHardwareConfiguration_Layout hardwareConfig3 = virtualControlsProfile_Layout6.HardwareConfig;
		VirtualControlsHardwareConfiguration_Layout backupHardware3 = this.BackupHardware3;
		hardwareConfig3.Copy(backupHardware3);
		VirtualControlsProfile_Layout backupProfile4 = this.BackupProfile4;
		VirtualControlsProfile_Layout virtualControlsProfile_Layout7;
		virtualControlsProfile_Layout7.Copy(backupProfile4);
		VirtualControlsProfile_Layout virtualControlsProfile_Layout8;
		VirtualControlsHardwareConfiguration_Layout hardwareConfig4 = virtualControlsProfile_Layout8.HardwareConfig;
		VirtualControlsHardwareConfiguration_Layout backupHardware4 = this.BackupHardware4;
		hardwareConfig4.Copy(backupHardware4);
		VirtualControlsProfile_Layout backupActiveProfile = this.BackupActiveProfile;
		VirtualControlsProfile_Layout virtualControlsProfile_Layout9;
		virtualControlsProfile_Layout9.HardwareConfig.LoadControlPositions();
		InterfaceProfile_Layout active = InterfaceStyles_Layout.Active;
		InterfaceProfile_Layout backupInterfaceProfile = this.BackupInterfaceProfile;
		long num = 0L;
		active.Copy(backupInterfaceProfile, num != 0L);
		InterfaceProfile_Layout active2 = InterfaceStyles_Layout.Active;
		string profileName = this.BackupInterfaceProfile.ProfileName;
		active2.ProfileName = profileName;
		if (profileName == null)
		{
		}
		float xmin = this.backupSafeRegion.m_XMin;
		float ymin = this.backupSafeRegion.m_YMin;
		float width = this.backupSafeRegion.m_Width;
		float height = this.backupSafeRegion.m_Height;
		bool flag = this.backupVPPIOverride;
		InterfaceStyles_Layout.Active.InvalidateMinResolution();
		InterfaceStyles_Layout.LoadUIResolution();
		if (this.backupVPPIOverride)
		{
			float num2 = this.backupVPPI;
		}
		this.ClearControlUndoRedo();
	}

	// Token: 0x06000DAA RID: 3498 RVA: 0x0004192C File Offset: 0x0003FB2C
	public GUIInterfaceEdit()
	{
	}

	// Token: 0x040018EF RID: 6383
	public GUIInterfaceEdit.EditMode Mode;

	// Token: 0x040018F0 RID: 6384
	public bool Enabled;

	// Token: 0x040018F1 RID: 6385
	public GUIControllerInterfaceEdit _controller;

	// Token: 0x040018F2 RID: 6386
	private float InterfacePositionScale;

	// Token: 0x040018F3 RID: 6387
	private float ControlsPositionScale;

	// Token: 0x040018F4 RID: 6388
	private float SafeRegionScale;

	// Token: 0x040018F5 RID: 6389
	private float EditControlScale;

	// Token: 0x040018F6 RID: 6390
	private float TitleScale;

	// Token: 0x040018F7 RID: 6391
	private float defaultsScale;

	// Token: 0x040018F8 RID: 6392
	private float finishScale;

	// Token: 0x040018F9 RID: 6393
	private float resetScale = (float)16256;

	// Token: 0x040018FA RID: 6394
	public float ScrollOffset;

	// Token: 0x040018FB RID: 6395
	private float ScrollMomentum;

	// Token: 0x040018FC RID: 6396
	private int ScrollDragging;

	// Token: 0x040018FD RID: 6397
	private Microsoft.Xna.Framework.Vector2 DragOffset;

	// Token: 0x040018FE RID: 6398
	private int _groupCount;

	// Token: 0x040018FF RID: 6399
	private int pageOver;

	// Token: 0x04001900 RID: 6400
	private Rectangle NewItemtemRegion;

	// Token: 0x04001901 RID: 6401
	private Rectangle SelectedItemRegion;

	// Token: 0x04001902 RID: 6402
	public int SelectedItem;

	// Token: 0x04001903 RID: 6403
	private GUIPageIconGrouping currentGroup;

	// Token: 0x04001904 RID: 6404
	private Microsoft.Xna.Framework.Vector2 pageButtonRegionSize;

	// Token: 0x04001905 RID: 6405
	private Rectangle fullClipRegion;

	// Token: 0x04001906 RID: 6406
	private Rectangle dragClipRegion;

	// Token: 0x04001907 RID: 6407
	public bool CanSpawnState;

	// Token: 0x04001908 RID: 6408
	private float SideControls;

	// Token: 0x04001909 RID: 6409
	private float TopControls;

	// Token: 0x0400190A RID: 6410
	private float BottomControls;

	// Token: 0x0400190B RID: 6411
	private GUISlider.DragState dragState;

	// Token: 0x0400190C RID: 6412
	private float uiScale;

	// Token: 0x0400190D RID: 6413
	private float EditGroupsScale;

	// Token: 0x0400190E RID: 6414
	private global::UnityEngine.Vector2 lastCursorPosition;

	// Token: 0x0400190F RID: 6415
	private int lastDirection;

	// Token: 0x04001910 RID: 6416
	public bool editingName;

	// Token: 0x04001911 RID: 6417
	private string editNameValue;

	// Token: 0x04001912 RID: 6418
	private int textBlinkerCount;

	// Token: 0x04001913 RID: 6419
	private int textBlinkerState;

	// Token: 0x04001914 RID: 6420
	private GUIInputRegionExclusive _optionsBlocker;

	// Token: 0x04001915 RID: 6421
	public bool displayProfileOptions;

	// Token: 0x04001916 RID: 6422
	private bool drawnProfileOptions;

	// Token: 0x04001917 RID: 6423
	private float ProfileScale;

	// Token: 0x04001918 RID: 6424
	private float ProfileRenameScale;

	// Token: 0x04001919 RID: 6425
	private float Profile1Scale;

	// Token: 0x0400191A RID: 6426
	private float Profile2Scale;

	// Token: 0x0400191B RID: 6427
	private float Profile3Scale;

	// Token: 0x0400191C RID: 6428
	private float Profile4Scale;

	// Token: 0x0400191D RID: 6429
	public bool displayTemplateOptions;

	// Token: 0x0400191E RID: 6430
	private bool drawnTemplateOptions;

	// Token: 0x0400191F RID: 6431
	private float TemplateScale;

	// Token: 0x04001920 RID: 6432
	private float Template1Scale;

	// Token: 0x04001921 RID: 6433
	private float Template2Scale;

	// Token: 0x04001922 RID: 6434
	private float Template3Scale;

	// Token: 0x04001923 RID: 6435
	private float Template4Scale;

	// Token: 0x04001924 RID: 6436
	private float Template5Scale;

	// Token: 0x04001925 RID: 6437
	private bool selectedCustom;

	// Token: 0x04001926 RID: 6438
	private InterfaceProfile_Layout currentProfile;

	// Token: 0x04001927 RID: 6439
	public float _pulldownShift;

	// Token: 0x04001928 RID: 6440
	private VirtualControlsHardwareConfiguration_Layout BackupHardware1;

	// Token: 0x04001929 RID: 6441
	private VirtualControlsHardwareConfiguration_Layout BackupHardware2;

	// Token: 0x0400192A RID: 6442
	private VirtualControlsHardwareConfiguration_Layout BackupHardware3;

	// Token: 0x0400192B RID: 6443
	private VirtualControlsHardwareConfiguration_Layout BackupHardware4;

	// Token: 0x0400192C RID: 6444
	private VirtualControlsProfile_Layout BackupProfile1;

	// Token: 0x0400192D RID: 6445
	private VirtualControlsProfile_Layout BackupProfile2;

	// Token: 0x0400192E RID: 6446
	private VirtualControlsProfile_Layout BackupProfile3;

	// Token: 0x0400192F RID: 6447
	private VirtualControlsProfile_Layout BackupProfile4;

	// Token: 0x04001930 RID: 6448
	private VirtualControlsProfile_Layout BackupActiveProfile;

	// Token: 0x04001931 RID: 6449
	private Microsoft.Xna.Framework.Vector2 backupLeftPosition;

	// Token: 0x04001932 RID: 6450
	private Microsoft.Xna.Framework.Vector2 backupRightPosition;

	// Token: 0x04001933 RID: 6451
	private Microsoft.Xna.Framework.Vector2 backupInterfaceLeftPosition;

	// Token: 0x04001934 RID: 6452
	private Microsoft.Xna.Framework.Vector2 backupInterfaceRightPosition;

	// Token: 0x04001935 RID: 6453
	private Rect backupSafeRegion;

	// Token: 0x04001936 RID: 6454
	private bool backupVPPIOverride;

	// Token: 0x04001937 RID: 6455
	private float backupVPPI;

	// Token: 0x04001938 RID: 6456
	private InterfaceProfile_Layout BackupInterfaceProfile;

	// Token: 0x04001939 RID: 6457
	private int SelectedSlot;

	// Token: 0x0400193A RID: 6458
	private List<GUIInterfaceEdit.BackupResotrePoint> RestorePoints;

	// Token: 0x0400193B RID: 6459
	private List<GUIInterfaceEdit.BackupResotrePoint> RedoPoints;

	// Token: 0x0200025F RID: 607
	public enum EditMode
	{
		// Token: 0x0400193D RID: 6461
		SafeRegion,
		// Token: 0x0400193E RID: 6462
		InterfacePosition,
		// Token: 0x0400193F RID: 6463
		InterfacePositionAdjust,
		// Token: 0x04001940 RID: 6464
		EditControls
	}

	// Token: 0x02000260 RID: 608
	public class BackupResotrePoint
	{
		// Token: 0x06000DAB RID: 3499 RVA: 0x0004194C File Offset: 0x0003FB4C
		public BackupResotrePoint(VirtualControlsHardwareConfiguration_Layout hardware, VirtualControlsProfile_Layout profile)
		{
		}

		// Token: 0x04001941 RID: 6465
		public VirtualControlsHardwareConfiguration_Layout Hardware;

		// Token: 0x04001942 RID: 6466
		public VirtualControlsProfile_Layout Profile;
	}
}
