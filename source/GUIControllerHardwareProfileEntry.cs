using System;
using System.Runtime.InteropServices;
using Controller;
using Cpp2IlInjected;
using InControl;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria.Localization;

// Token: 0x020000B1 RID: 177
public class GUIControllerHardwareProfileEntry : GUIControllerMappingEntryBase
{
	// Token: 0x06000430 RID: 1072 RVA: 0x0000D724 File Offset: 0x0000B924
	public GUIControllerHardwareProfileEntry(GUIControllerHardwareProfileEntry.BindingId id, ControllerDevice device)
	{
		InputControlType mappingType = this.GetMappingType();
	}

	// Token: 0x06000431 RID: 1073 RVA: 0x0000D758 File Offset: 0x0000B958
	public void CloseOptions()
	{
		if (this.displayOptions)
		{
			GUIInputRegionExclusive optionsBlocker = this._optionsBlocker;
		}
	}

	// Token: 0x06000432 RID: 1074 RVA: 0x0000D774 File Offset: 0x0000B974
	private string GetMappingName()
	{
		GUIControllerHardwareProfileEntry.BindingId id = this._id;
		return "LB1";
	}

	// Token: 0x06000433 RID: 1075 RVA: 0x0000D820 File Offset: 0x0000BA20
	private InputControlType GetMappingType()
	{
	}

	// Token: 0x1700007E RID: 126
	// (get) Token: 0x06000434 RID: 1076 RVA: 0x0000D830 File Offset: 0x0000BA30
	public bool HasMapping
	{
		get
		{
			/*
An exception occurred when decompiling this method (06000434)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean GUIControllerHardwareProfileEntry::get_HasMapping()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:InputControlMapping(var_0_06, ldfld:InputControlMapping(GUIControllerHardwareProfileEntry::Binding, ldloc:GUIControllerHardwareProfileEntry(this)))
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

	// Token: 0x06000435 RID: 1077 RVA: 0x0000D844 File Offset: 0x0000BA44
	public override void DrawOverlay()
	{
		this.drawingOverlay = true;
	}

	// Token: 0x06000436 RID: 1078 RVA: 0x0000D858 File Offset: 0x0000BA58
	public void RemoveBinding()
	{
	}

	// Token: 0x06000437 RID: 1079 RVA: 0x0000D868 File Offset: 0x0000BA68
	private void RemapToAnalogue(int index, float restingValue, float usedValue)
	{
		string mappingName = this.GetMappingName();
		InputControlMapping binding = this.Binding;
		InputControlType mappingType = this.GetMappingType();
		binding.target = mappingType;
		binding.source = 1;
		InputControlMapping binding2 = this.Binding;
		binding2.targetRange = InputRangeType.ZeroToOne;
	}

	// Token: 0x06000438 RID: 1080 RVA: 0x0000D8B4 File Offset: 0x0000BAB4
	private void RemapToButton(int index)
	{
		string mappingName = this.GetMappingName();
		InputControlMapping binding = this.Binding;
		InputControlType mappingType = this.GetMappingType();
		binding.target = mappingType;
		binding.source = 1;
		InputControlMapping binding2 = this.Binding;
	}

	// Token: 0x06000439 RID: 1081 RVA: 0x0000D8EC File Offset: 0x0000BAEC
	private Texture2D GetTexure([Out] Rectangle buttonRegion)
	{
		GUIControllerHardwareProfileEntry.BindingId id = this._id;
		if (id == GUIControllerHardwareProfileEntry.BindingId.LeftStickUp)
		{
		}
		if (id == GUIControllerHardwareProfileEntry.BindingId.LeftStickUp)
		{
		}
		if (id == GUIControllerHardwareProfileEntry.BindingId.LeftStickUp)
		{
		}
		if (id == GUIControllerHardwareProfileEntry.BindingId.LeftStickUp)
		{
		}
		if (id == GUIControllerHardwareProfileEntry.BindingId.LeftStickUp)
		{
		}
		if (id == GUIControllerHardwareProfileEntry.BindingId.LeftStickUp)
		{
		}
		if (id == GUIControllerHardwareProfileEntry.BindingId.LeftStickUp)
		{
		}
		if (id == GUIControllerHardwareProfileEntry.BindingId.LeftStickUp)
		{
		}
		if (id == GUIControllerHardwareProfileEntry.BindingId.LeftStickUp)
		{
		}
		if (id == GUIControllerHardwareProfileEntry.BindingId.LeftStickUp)
		{
		}
		if (id == GUIControllerHardwareProfileEntry.BindingId.LeftStickUp)
		{
		}
		if (id == GUIControllerHardwareProfileEntry.BindingId.LeftStickUp)
		{
		}
		if (id == GUIControllerHardwareProfileEntry.BindingId.LeftStickUp)
		{
		}
		if (id == GUIControllerHardwareProfileEntry.BindingId.LeftStickUp)
		{
		}
		if (id == GUIControllerHardwareProfileEntry.BindingId.LeftStickUp)
		{
		}
		if (id == GUIControllerHardwareProfileEntry.BindingId.LeftStickUp)
		{
		}
		if (id == GUIControllerHardwareProfileEntry.BindingId.LeftStickUp)
		{
		}
		if (id == GUIControllerHardwareProfileEntry.BindingId.LeftStickUp)
		{
		}
		if (id == GUIControllerHardwareProfileEntry.BindingId.LeftStickUp)
		{
		}
		if (id == GUIControllerHardwareProfileEntry.BindingId.LeftStickUp)
		{
		}
		if (id == GUIControllerHardwareProfileEntry.BindingId.LeftStickUp)
		{
		}
		if (id == GUIControllerHardwareProfileEntry.BindingId.LeftStickUp)
		{
		}
		if (id == GUIControllerHardwareProfileEntry.BindingId.LeftStickUp)
		{
		}
		Texture2D texture2D;
		return texture2D;
	}

	// Token: 0x0600043A RID: 1082 RVA: 0x0000D9A0 File Offset: 0x0000BBA0
	public override void Draw()
	{
		bool flag = this.displayOptions;
		if (flag && !this.drawingOverlay)
		{
			Rectangle gridItemRegion = ControlAnchor._gridItemRegion;
			GUIControllerHardwareProfile.RegisterOverlay(this, gridItemRegion);
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
		if (inputState == GUITransactionButton.InputState.Clicked)
		{
			if (!flag2)
			{
			}
			return;
		}
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
			int num2 = 1;
			GUITransactionButton.InputState inputState3;
			if (inputState3 == GUITransactionButton.InputState.Clicked)
			{
				if (num2 == 0)
				{
				}
				GUIInputRegionExclusive optionsBlocker2 = this._optionsBlocker;
			}
			if (this.displayOptions)
			{
				InputDevice device = this._device.Device;
				InputDevice device2 = this._device.Device;
				if (!false)
				{
				}
				return;
			}
		}
		if (this.Binding != null)
		{
			return;
		}
		string <Value>k__BackingField = Language.GetText("Mobile.UnboundControl").<Value>k__BackingField;
		if ("Mobile.BoundControl" == null)
		{
		}
		GUIInputRegionExclusive optionsBlocker3 = this._optionsBlocker;
		if (optionsBlocker3 != null)
		{
			int num3 = 1;
			optionsBlocker3.Active = num3 != 0;
			int num4;
			if (num4 == 0)
			{
				return;
			}
		}
	}

	// Token: 0x0600043B RID: 1083 RVA: 0x000021DB File Offset: 0x000003DB
	public override float GetElementHeight()
	{
		throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
	}

	// Token: 0x0600043C RID: 1084 RVA: 0x0000DAEC File Offset: 0x0000BCEC
	private bool IsOverOptions(Vector2 cursorPosition)
	{
		return true;
	}

	// Token: 0x0600043D RID: 1085 RVA: 0x0000DB04 File Offset: 0x0000BD04
	// Note: this type is marked as 'beforefieldinit'.
	static GUIControllerHardwareProfileEntry()
	{
	}

	// Token: 0x04000411 RID: 1041
	private readonly ControllerDevice _device;

	// Token: 0x04000412 RID: 1042
	public new readonly GUIControllerHardwareProfileEntry.BindingId _id = id;

	// Token: 0x04000413 RID: 1043
	public InputControlMapping Binding;

	// Token: 0x04000414 RID: 1044
	private float buttonScale;

	// Token: 0x04000415 RID: 1045
	private float scale;

	// Token: 0x04000416 RID: 1046
	private bool drawingOverlay;

	// Token: 0x04000417 RID: 1047
	private static int LastButtonMapped;

	// Token: 0x04000418 RID: 1048
	private const float inputTollerance = 0.1f;

	// Token: 0x04000419 RID: 1049
	private static float[] InitialInputRange;

	// Token: 0x0400041A RID: 1050
	public bool displayOptions;

	// Token: 0x0400041B RID: 1051
	private GUIInputRegionExclusive _optionsBlocker;

	// Token: 0x0400041C RID: 1052
	public new KeyboardMappingsCategories_Layout.Category Category;

	// Token: 0x0400041D RID: 1053
	public new int SortOrder;

	// Token: 0x020000B2 RID: 178
	public enum BindingId
	{
		// Token: 0x0400041F RID: 1055
		LeftStickUp,
		// Token: 0x04000420 RID: 1056
		LeftStickDown,
		// Token: 0x04000421 RID: 1057
		LeftStickLeft,
		// Token: 0x04000422 RID: 1058
		LeftStickRight,
		// Token: 0x04000423 RID: 1059
		RightStickUp,
		// Token: 0x04000424 RID: 1060
		RightStickDown,
		// Token: 0x04000425 RID: 1061
		RightStickLeft,
		// Token: 0x04000426 RID: 1062
		RightStickRight,
		// Token: 0x04000427 RID: 1063
		DPadUp,
		// Token: 0x04000428 RID: 1064
		DPadDown,
		// Token: 0x04000429 RID: 1065
		DPadLeft,
		// Token: 0x0400042A RID: 1066
		DPadRight,
		// Token: 0x0400042B RID: 1067
		Action1,
		// Token: 0x0400042C RID: 1068
		Action2,
		// Token: 0x0400042D RID: 1069
		Action3,
		// Token: 0x0400042E RID: 1070
		Action4,
		// Token: 0x0400042F RID: 1071
		Options,
		// Token: 0x04000430 RID: 1072
		Switch,
		// Token: 0x04000431 RID: 1073
		LeftShoulder,
		// Token: 0x04000432 RID: 1074
		LeftTrigger,
		// Token: 0x04000433 RID: 1075
		LeftStickClick,
		// Token: 0x04000434 RID: 1076
		RightShoulder,
		// Token: 0x04000435 RID: 1077
		RightTrigger,
		// Token: 0x04000436 RID: 1078
		RightStickClick,
		// Token: 0x04000437 RID: 1079
		Count
	}
}
