using System;
using Controller;
using Cpp2IlInjected;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.Localization;
using UnityEngine;

// Token: 0x02000189 RID: 393
public class GUIKeyboardMappingEntry
{
	// Token: 0x06000B12 RID: 2834 RVA: 0x00037FA4 File Offset: 0x000361A4
	public GUIKeyboardMappingEntry(ControllerActionVector action, int index)
	{
		this.axisAction = action;
		this.actionIndex = index;
		string id = action.Id;
		int num = this.actionIndex;
	}

	// Token: 0x06000B13 RID: 2835 RVA: 0x00038008 File Offset: 0x00036208
	public void Backup()
	{
		KeyCode binding = this.Binding;
		this.backupBinding = binding;
	}

	// Token: 0x06000B14 RID: 2836 RVA: 0x00038024 File Offset: 0x00036224
	public void Restore()
	{
		KeyCode keyCode = this.backupBinding;
		this.Binding = keyCode;
	}

	// Token: 0x06000B15 RID: 2837 RVA: 0x00038040 File Offset: 0x00036240
	public GUIKeyboardMappingEntry(ControllerActionButton action)
	{
		this.buttonAction = action;
		string id = action.Id;
		string text = this.buttonAction.Id.Replace("Keyboard", "");
		string text2 = "KeyboardMappings." + text;
		this.localisationId = text2;
	}

	// Token: 0x1700011C RID: 284
	// (get) Token: 0x06000B16 RID: 2838 RVA: 0x00038090 File Offset: 0x00036290
	// (set) Token: 0x06000B17 RID: 2839 RVA: 0x000380DC File Offset: 0x000362DC
	public KeyCode Binding
	{
		get
		{
			/*
An exception occurred when decompiling this method (06000B16)

ICSharpCode.Decompiler.DecompilerException: Error decompiling UnityEngine.KeyCode GUIKeyboardMappingEntry::get_Binding()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:int32(var_1_10, ldfld:int32(GUIKeyboardMappingEntry::actionIndex, ldloc:GUIKeyboardMappingEntry(this)))
	stloc:string(var_2_1C, ldfld:string(ControllerActionAxis::Id, ldfld:ControllerActionAxis(ControllerActionVector::Y, ldloc:ControllerActionVector(var_0_06))))
	stloc:Entry(var_4_28, callgetter:Entry(ControllerActionAxis::get_FirstEntry, ldfld:ControllerActionAxis(ControllerActionVector::X, ldloc:ControllerActionVector(var_0_06))))
	stloc:ControllerActionAxis(var_5_30, ldfld:ControllerActionAxis(ControllerActionVector::Y, ldloc:ControllerActionVector(var_0_06)))
	stloc:Entry(var_6_3D, callgetter:Entry(ControllerActionAxis::get_FirstEntry, ldfld:ControllerActionAxis(ControllerActionVector::X, ldloc:ControllerActionVector(var_0_06))))
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
		set
		{
			ControllerActionVector controllerActionVector = this.axisAction;
			ControllerActionAxis y;
			if (controllerActionVector != null)
			{
				int num = this.actionIndex;
				y = controllerActionVector.Y;
				return;
			}
			string id = y.Id;
			ControllerActionButton.Entry entry;
			entry.InputKey = value;
		}
	}

	// Token: 0x1700011D RID: 285
	// (get) Token: 0x06000B18 RID: 2840 RVA: 0x00038140 File Offset: 0x00036340
	public bool HasMapping
	{
		get
		{
			/*
An exception occurred when decompiling this method (06000B18)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean GUIKeyboardMappingEntry::get_HasMapping()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:KeyCode(var_0_06, callgetter:KeyCode(GUIKeyboardMappingEntry::get_Binding, ldloc:GUIKeyboardMappingEntry(this)))
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
	}

	// Token: 0x06000B19 RID: 2841 RVA: 0x00038154 File Offset: 0x00036354
	public void DrawOverlay()
	{
		this.drawingOverlay = true;
		this.Draw();
	}

	// Token: 0x06000B1A RID: 2842 RVA: 0x00038170 File Offset: 0x00036370
	public void RemoveBinding()
	{
		if (this.displayOptions)
		{
			GUIInputRegionExclusive optionsBlocker = this._optionsBlocker;
		}
	}

	// Token: 0x06000B1B RID: 2843 RVA: 0x0003818C File Offset: 0x0003638C
	public void Draw()
	{
		bool flag = this.displayOptions;
		if (flag && !this.drawingOverlay)
		{
			Rectangle gridItemRegion = ControlAnchor._gridItemRegion;
			return;
		}
		if (this._optionsBlocker != null)
		{
		}
		bool flag2;
		if (flag)
		{
			flag2 = this.displayOptions;
		}
		GUITransactionButton.InputState inputState;
		if (inputState != GUITransactionButton.InputState.Clicked || !flag2)
		{
		}
		string <Value>k__BackingField = Language.GetText(this.localisationId).<Value>k__BackingField;
		if (this.displayOptions)
		{
			int num = 1;
			GUITransactionButton.InputState inputState2;
			if (inputState2 == GUITransactionButton.InputState.Clicked)
			{
				if (num == 0)
				{
				}
				GUIInputRegionExclusive optionsBlocker = this._optionsBlocker;
			}
			GUITransactionButton.InputState inputState3;
			if (inputState3 == GUITransactionButton.InputState.Clicked)
			{
				Main.mouseLeftRelease = false;
				this.RemoveBinding();
			}
			bool flag3 = this.displayOptions;
			if (flag3)
			{
				if (!flag3)
				{
				}
				if (!false)
				{
				}
				GUIInputRegionExclusive optionsBlocker2 = this._optionsBlocker;
				return;
			}
		}
		if (this.Binding != KeyCode.None)
		{
			string text = this.Binding.ToString();
			string textValue = Language.GetTextValue("KeyboardBindings." + text);
			return;
		}
		LocalizedText text2 = Language.GetText("Mobile.UnboundControl");
		string <Value>k__BackingField2 = text2.<Value>k__BackingField;
		if (text2 == null)
		{
		}
		bool mouseLeftRelease = Main.mouseLeftRelease;
		if (text2 == null)
		{
		}
		bool mouseLeft = Main.mouseLeft;
		if (text2 == null)
		{
		}
		GUIInputRegionExclusive optionsBlocker3 = this._optionsBlocker;
		if (optionsBlocker3 != null)
		{
			int num2 = 1;
			optionsBlocker3.Active = num2 != 0;
			GUIInputRegionExclusive optionsBlocker4 = this._optionsBlocker;
		}
	}

	// Token: 0x06000B1C RID: 2844 RVA: 0x000021DB File Offset: 0x000003DB
	public float GetElementHeight()
	{
		throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
	}

	// Token: 0x06000B1D RID: 2845 RVA: 0x00038304 File Offset: 0x00036504
	private bool IsOverOptions(Microsoft.Xna.Framework.Vector2 cursorPosition)
	{
		return true;
	}

	// Token: 0x06000B1E RID: 2846 RVA: 0x0003831C File Offset: 0x0003651C
	private string GetTitle()
	{
		return Language.GetText(this.localisationId).<Value>k__BackingField;
	}

	// Token: 0x06000B1F RID: 2847 RVA: 0x0003833C File Offset: 0x0003653C
	// Note: this type is marked as 'beforefieldinit'.
	static GUIKeyboardMappingEntry()
	{
	}

	// Token: 0x04000B97 RID: 2967
	private ControllerActionButton buttonAction;

	// Token: 0x04000B98 RID: 2968
	private ControllerActionVector axisAction;

	// Token: 0x04000B99 RID: 2969
	private int actionIndex;

	// Token: 0x04000B9A RID: 2970
	private KeyCode backupBinding;

	// Token: 0x04000B9B RID: 2971
	private readonly string localisationId;

	// Token: 0x04000B9C RID: 2972
	private float buttonScale;

	// Token: 0x04000B9D RID: 2973
	private float scale;

	// Token: 0x04000B9E RID: 2974
	private bool drawingOverlay;

	// Token: 0x04000B9F RID: 2975
	private static int LastButtonMapped;

	// Token: 0x04000BA0 RID: 2976
	private static bool ignoreClick;

	// Token: 0x04000BA1 RID: 2977
	public bool displayOptions;

	// Token: 0x04000BA2 RID: 2978
	private GUIInputRegionExclusive _optionsBlocker;

	// Token: 0x04000BA3 RID: 2979
	public KeyboardMappingsCategories_Layout.Category Category;

	// Token: 0x04000BA4 RID: 2980
	public int SortOrder;
}
