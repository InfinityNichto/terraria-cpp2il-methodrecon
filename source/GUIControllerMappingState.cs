using System;
using System.Collections.Generic;
using Controller;
using Terraria.IO;

// Token: 0x0200007B RID: 123
public class GUIControllerMappingState
{
	// Token: 0x060002B7 RID: 695 RVA: 0x00008AD8 File Offset: 0x00006CD8
	public void Clear()
	{
		ControllerActionButton[] buttonBindings = this.ButtonBindings;
		ControllerActionButton[] axisButtonBindings = this.AxisButtonBindings;
		ControllerActionAxis[] axisBindings = this.AxisBindings;
	}

	// Token: 0x060002B8 RID: 696 RVA: 0x00008B08 File Offset: 0x00006D08
	public bool IsSame(GUIControllerMappingState other)
	{
		/*
An exception occurred when decompiling this method (060002B8)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean GUIControllerMappingState::IsSame(GUIControllerMappingState)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:class Controller.ControllerActionButton[](var_0_06, ldfld:class Controller.ControllerActionButton[](GUIControllerMappingState::ButtonBindings, ldloc:GUIControllerMappingState(this)))
	stloc:class Controller.ControllerActionButton[](var_1_0D, ldfld:class Controller.ControllerActionButton[](GUIControllerMappingState::ButtonBindings, ldloc:GUIControllerMappingState(other)))
	stloc:class Controller.ControllerActionButton[](var_3_16, ldfld:class Controller.ControllerActionButton[](GUIControllerMappingState::AxisButtonBindings, ldloc:GUIControllerMappingState(this)))
	stloc:class Controller.ControllerActionButton[](var_4_1D, ldfld:class Controller.ControllerActionButton[](GUIControllerMappingState::AxisButtonBindings, ldloc:GUIControllerMappingState(other)))
	stloc:class Controller.ControllerActionAxis[](var_6_28, ldfld:class Controller.ControllerActionAxis[](GUIControllerMappingState::AxisBindings, ldloc:GUIControllerMappingState(this)))
	stloc:class Controller.ControllerActionAxis[](var_7_30, ldfld:class Controller.ControllerActionAxis[](GUIControllerMappingState::AxisBindings, ldloc:GUIControllerMappingState(other)))
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

	// Token: 0x060002B9 RID: 697 RVA: 0x00008B50 File Offset: 0x00006D50
	public void DisableConflictingActions(GUIControllerMappingState other)
	{
		ControllerActionButton[] buttonBindings = this.ButtonBindings;
		ControllerActionButton[] buttonBindings2 = other.ButtonBindings;
		if (buttonBindings2 != null)
		{
		}
		if (this.AxisButtonBindings == null || other.AxisButtonBindings != null || other.AxisBindings._entries != null)
		{
		}
		ControllerActionAxis[] axisBindings = this.AxisBindings;
		ControllerActionButton linkedAction = buttonBindings2.LinkedAction;
		if (linkedAction == null || !linkedAction.Enabled || other.AxisBindings._entries != null)
		{
			return;
		}
		ControllerActionButton[] axisButtonBindings = other.AxisButtonBindings;
	}

	// Token: 0x060002BA RID: 698 RVA: 0x00008BE0 File Offset: 0x00006DE0
	public void SetupWorldRequiredStateOverloads(GUIControllerMappingStateTable altStates)
	{
		int num = 13;
		ControllerActionButton[] buttonBindings = this.ButtonBindings;
		ControllerActionButton[] buttonBindings2 = this.ButtonBindings;
		ControllerActionButton.Entry entry;
		if (entry.RequiredState == null)
		{
			ControllerActionButton[] buttonBindings3 = this.ButtonBindings;
		}
		ControllerActionButton[] buttonBindings4 = this.ButtonBindings;
		ControllerActionButton.Entry entry2;
		ControllerActionButton.RequiredButtonState requiredState = entry2.RequiredState;
		requiredState.Button = (Buttons)num;
		requiredState.Button2 = (Buttons)num;
		if (altStates != null)
		{
			Buttons button = altStates.Left.RequiredState.Button;
			requiredState.Button = button;
			Buttons button2 = altStates.Right.RequiredState.Button;
			requiredState.Button2 = button2;
		}
		int num2 = 13;
		ControllerActionButton[] axisButtonBindings = this.AxisButtonBindings;
		bool flag;
		if (flag)
		{
			ControllerActionButton[] axisButtonBindings2 = this.AxisButtonBindings;
			ControllerActionButton.RequiredButtonState requiredButtonState;
			if (requiredButtonState == null)
			{
				ControllerActionButton[] axisButtonBindings3 = this.AxisButtonBindings;
			}
			ControllerActionButton[] axisButtonBindings4 = this.AxisButtonBindings;
			ControllerActionButton.Entry entry3;
			ControllerActionButton.RequiredButtonState requiredState2 = entry3.RequiredState;
			requiredState2.Button = (Buttons)num2;
			requiredState2.Button2 = (Buttons)num2;
			if (altStates != null)
			{
				Buttons button3 = altStates.Left.RequiredState.Button;
				requiredState2.Button = button3;
				Buttons button4 = altStates.Right.RequiredState.Button;
				requiredState2.Button2 = button4;
			}
		}
		int num3 = 13;
		ControllerActionAxis[] axisBindings = this.AxisBindings;
		bool flag2;
		if (flag2)
		{
			ControllerActionAxis[] axisBindings2 = this.AxisBindings;
			ControllerActionAxis.Entry entry4;
			if (entry4.RequiredState == null)
			{
				ControllerActionAxis[] axisBindings3 = this.AxisBindings;
			}
			ControllerActionAxis[] axisBindings4 = this.AxisBindings;
			ControllerActionAxis.Entry entry5;
			ControllerActionButton.RequiredButtonState requiredState3 = entry5.RequiredState;
			requiredState3.Button = (Buttons)num3;
			requiredState3.Button2 = (Buttons)num3;
			if (altStates != null)
			{
				Buttons button5 = altStates.Left.RequiredState.Button;
				requiredState3.Button = button5;
				Buttons button6 = altStates.Right.RequiredState.Button;
				requiredState3.Button2 = button6;
			}
		}
	}

	// Token: 0x060002BB RID: 699 RVA: 0x00008D78 File Offset: 0x00006F78
	public void Copy(GUIControllerMappingState other)
	{
		ControllerActionButton[] buttonBindings = other.ButtonBindings;
		ControllerActionButton[] buttonBindings2 = this.ButtonBindings;
		if (this != null)
		{
			ControllerActionButton[] axisButtonBindings = other.AxisButtonBindings;
			ControllerActionButton[] axisButtonBindings2 = this.AxisButtonBindings;
			if (this != null)
			{
				ControllerActionAxis[] axisBindings = other.AxisBindings;
				ControllerActionAxis[] axisBindings2 = this.AxisBindings;
				if (this != null)
				{
					return;
				}
			}
		}
		throw new ArrayTypeMismatchException();
	}

	// Token: 0x060002BC RID: 700 RVA: 0x00008DCC File Offset: 0x00006FCC
	public void LoadConfiguration(string prefix, Preferences preferences, bool mappingsCleared, List<ControllerActionButton> allowedButtons, List<ControllerActionAxis> allowedAxis)
	{
		string text2;
		string text = prefix + "Button_" + text2;
		ControllerActionButton[] buttonBindings = this.ButtonBindings;
		ControllerActionButton controllerActionButton;
		if (controllerActionButton != null && controllerActionButton == null)
		{
			return;
		}
		string text4;
		string text3 = prefix + "AxisButton_" + text4;
		ControllerActionButton[] axisButtonBindings = this.AxisButtonBindings;
		ControllerActionButton controllerActionButton2;
		if (controllerActionButton2 != null && controllerActionButton2 == null)
		{
			return;
		}
		string text6;
		string text5 = prefix + "Axis_" + text6;
		ControllerActionAxis[] axisBindings = this.AxisBindings;
		ControllerActionAxis controllerActionAxis;
		if (controllerActionAxis != null && controllerActionAxis == null)
		{
			return;
		}
	}

	// Token: 0x060002BD RID: 701 RVA: 0x00008E84 File Offset: 0x00007084
	public void TransferMapping(ControllerActionButton mapping, GUIControllerMappingState other)
	{
		ControllerActionButton[] buttonBindings = this.ButtonBindings;
		ControllerActionButton[] buttonBindings2 = other.ButtonBindings;
		if (mapping == null || mapping != null)
		{
			ControllerActionButton[] buttonBindings3 = this.ButtonBindings;
			ControllerActionButton[] axisButtonBindings = this.AxisButtonBindings;
			ControllerActionButton[] axisButtonBindings2 = other.AxisButtonBindings;
			if (mapping == null || mapping != null)
			{
				ControllerActionButton[] axisButtonBindings3 = this.AxisButtonBindings;
				return;
			}
		}
		throw new ArrayTypeMismatchException();
	}

	// Token: 0x060002BE RID: 702 RVA: 0x00008ED8 File Offset: 0x000070D8
	public void SaveConfiguration(string prefix, Preferences preferences)
	{
		if (this.ButtonBindings != null)
		{
			string text2;
			string text = prefix + "Button_" + text2;
			string id = this.ButtonBindings.Id;
			preferences.Put(text, id);
			return;
		}
		string text4;
		string text3 = prefix + "Button_" + text4;
		preferences.Clear(text3);
		if (this.AxisButtonBindings != null)
		{
			string text6;
			string text5 = prefix + "AxisButton_" + text6;
			string id2 = this.AxisButtonBindings.Id;
			preferences.Put(text5, id2);
			return;
		}
		string text8;
		string text7 = prefix + "AxisButton_" + text8;
		preferences.Clear(text7);
		if (this.AxisBindings != null)
		{
			string text10;
			string text9 = prefix + "Axis_" + text10;
			string id3 = this.AxisBindings.Id;
			preferences.Put(text9, id3);
			return;
		}
		string text12;
		string text11 = prefix + "Axis_" + text12;
		preferences.Clear(text11);
	}

	// Token: 0x060002BF RID: 703 RVA: 0x00008FBC File Offset: 0x000071BC
	public void SetupMappings(GUIControllerMappingStateTable altStates)
	{
		ControllerActionButton[] buttonBindings = this.ButtonBindings;
		if (altStates != null)
		{
			Buttons button = altStates.Left.RequiredState.Button;
			Buttons button2 = altStates.Right.RequiredState.Button;
			Buttons button3 = altStates.Left.RequiredState.Button;
			Buttons button4 = altStates.Right.RequiredState.Button;
			ControllerActionButton[] buttonBindings2 = this.ButtonBindings;
			return;
		}
		ControllerActionButton.RequiredButtonState requiredState = this.RequiredState;
		ControllerActionButton[] axisButtonBindings = this.AxisButtonBindings;
		bool flag;
		if (flag)
		{
			if (altStates != null)
			{
				Buttons button5 = altStates.Left.RequiredState.Button;
				Buttons button6 = altStates.Right.RequiredState.Button;
				Buttons button7 = altStates.Left.RequiredState.Button;
				Buttons button8 = altStates.Right.RequiredState.Button;
				ControllerActionButton[] axisButtonBindings2 = this.AxisButtonBindings;
				return;
			}
			ControllerActionButton.RequiredButtonState requiredState2 = this.RequiredState;
		}
		ControllerActionAxis[] axisBindings = this.AxisBindings;
		bool flag2;
		if (flag2)
		{
			if (altStates != null)
			{
				Buttons button9 = altStates.Left.RequiredState.Button;
				Buttons button10 = altStates.Right.RequiredState.Button;
				Buttons button11 = altStates.Left.RequiredState.Button;
				Buttons button12 = altStates.Right.RequiredState.Button;
				ControllerActionAxis[] axisBindings2 = this.AxisBindings;
				return;
			}
			ControllerActionButton.RequiredButtonState requiredState3 = this.RequiredState;
		}
	}

	// Token: 0x060002C0 RID: 704 RVA: 0x00009104 File Offset: 0x00007304
	public GUIControllerMappingState()
	{
	}

	// Token: 0x04000318 RID: 792
	public ControllerActionButton.RequiredButtonState RequiredState;

	// Token: 0x04000319 RID: 793
	public ControllerActionButton[] ButtonBindings;

	// Token: 0x0400031A RID: 794
	public ControllerActionButton[] AxisButtonBindings;

	// Token: 0x0400031B RID: 795
	public ControllerActionAxis[] AxisBindings;
}
