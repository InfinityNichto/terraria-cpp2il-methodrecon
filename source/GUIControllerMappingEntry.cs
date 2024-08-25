using System;
using Controller;
using Cpp2IlInjected;
using Microsoft.Xna.Framework;

// Token: 0x02000073 RID: 115
public class GUIControllerMappingEntry : GUIControllerMappingEntryBase
{
	// Token: 0x0600027A RID: 634 RVA: 0x00006D90 File Offset: 0x00004F90
	public GUIControllerMappingEntry(ControllerActionVector action, GUIControllerMappingStateTable table)
	{
		this.Table = table;
		this.vector = action;
		string id = action.Id;
	}

	// Token: 0x0600027B RID: 635 RVA: 0x00006DB4 File Offset: 0x00004FB4
	public GUIControllerMappingEntry(ControllerActionButton buttonMapping, GUIControllerMappingStateTable table)
	{
		this.button = buttonMapping;
		this.Table = table;
		string id = buttonMapping.Id;
	}

	// Token: 0x17000075 RID: 117
	// (get) Token: 0x0600027C RID: 636 RVA: 0x00006DD8 File Offset: 0x00004FD8
	public bool HasMapping
	{
		get
		{
			ControllerActionVector controllerActionVector = this.vector;
			if (controllerActionVector != null)
			{
				return controllerActionVector.HasMapping;
			}
			ControllerActionButton controllerActionButton = this.button;
			bool hasMapping;
			if (controllerActionButton != null)
			{
				hasMapping = controllerActionButton.HasMapping;
				return hasMapping;
			}
			return hasMapping;
		}
	}

	// Token: 0x0600027D RID: 637 RVA: 0x00006E0C File Offset: 0x0000500C
	public override void DrawOverlay()
	{
		this.drawingOverlay = true;
	}

	// Token: 0x0600027E RID: 638 RVA: 0x00006E20 File Offset: 0x00005020
	public void RemoveBinding()
	{
		ControllerActionVector controllerActionVector = this.vector;
		if (controllerActionVector != null)
		{
			this.RemoveAxisBindings(controllerActionVector);
		}
		ControllerActionButton controllerActionButton = this.button;
		if (controllerActionButton != null)
		{
			this.Table.RemoveButtonBindings(controllerActionButton);
			return;
		}
	}

	// Token: 0x0600027F RID: 639 RVA: 0x00006E58 File Offset: 0x00005058
	private void RemoveAxisBindings(ControllerActionVector actionAxis)
	{
		ControllerActionAxis[] axisBindings = this.Table.Left.AxisBindings;
		ControllerActionAxis x = actionAxis.X;
		ControllerActionAxis y = actionAxis.Y;
		GUIControllerMappingStateTable table = this.Table;
		ControllerActionAxis x2 = actionAxis.X;
		ControllerActionAxis[] axisBindings2 = table.Right.AxisBindings;
		ControllerActionAxis y2 = actionAxis.Y;
		GUIControllerMappingStateTable table2 = this.Table;
		ControllerActionAxis x3 = actionAxis.X;
		ControllerActionAxis[] axisBindings3 = table2.Normal.AxisBindings;
		ControllerActionAxis y3 = actionAxis.Y;
	}

	// Token: 0x06000280 RID: 640 RVA: 0x00006ED4 File Offset: 0x000050D4
	private void RebindAxis(ControllerActionVector actionAxis, Axis x, Axis y, int stateIndex)
	{
		this.RemoveAxisBindings(actionAxis);
		GUIControllerMappingStateTable table = this.Table;
		long num = 0L;
		table.ClearLinkedAxisBindings(stateIndex, x, y, num != 0L);
		GUIControllerMappingStateTable table2 = this.Table;
	}

	// Token: 0x06000281 RID: 641 RVA: 0x00006F68 File Offset: 0x00005168
	private void RebindButton(ControllerActionButton actionButton, AxisButtons axisButton, int stateIndex)
	{
		this.Table.RemoveButtonBindings(actionButton);
		GUIControllerMappingStateTable table = this.Table;
	}

	// Token: 0x06000282 RID: 642 RVA: 0x00006FD4 File Offset: 0x000051D4
	private void RebindButton(ControllerActionButton actionButton, Buttons axisButton, int stateIndex)
	{
		this.Table.RemoveButtonBindings(actionButton);
		GUIControllerMappingStateTable table = this.Table;
	}

	// Token: 0x06000283 RID: 643 RVA: 0x00007040 File Offset: 0x00005240
	public override void Draw()
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
		if (inputState == GUITransactionButton.InputState.Clicked)
		{
			if (!flag2)
			{
			}
			return;
		}
		string title = this.GetTitle();
		if (this.displayOptions)
		{
			int num = 1;
			GUITransactionButton.InputState inputState2;
			if (inputState2 != GUITransactionButton.InputState.Clicked || num == 0)
			{
			}
			GUIInputRegionExclusive optionsBlocker = this._optionsBlocker;
			if (this.displayOptions)
			{
				ControllerDevice controllerDevice;
				if (controllerDevice == null)
				{
					goto IL_0243;
				}
				if (this.vector != null)
				{
					return;
				}
				return;
			}
		}
		ControllerActionVector controllerActionVector = this.vector;
		if (controllerActionVector != null)
		{
			bool hasMappingExcludeLinked = controllerActionVector.HasMappingExcludeLinked;
			ControllerActionButton.RequiredButtonState requiredStateExcludeLinked = this.vector.RequiredStateExcludeLinked;
			float num2;
			if (requiredStateExcludeLinked != null && requiredStateExcludeLinked.state)
			{
				GUIControllerInputButton.LinkedControlType linkedControlType = GUIControlsBanner.FromButton(requiredStateExcludeLinked.Button);
				GUIControllerInputButton.AxisControl axisControl = GUIControlsBanner.FromAxis(this.vector.X.FirstEntry.Axis0, num2);
				return;
			}
			ControllerActionAxis.Entry firstEntry = this.vector.X.FirstEntry;
			ControllerActionVector controllerActionVector2 = this.vector;
			Axis axis = firstEntry.Axis0;
			float threshold = controllerActionVector2.X.FirstEntry.Threshold;
			GUIControllerInputButton.AxisControl axisControl2 = GUIControlsBanner.FromAxis(axis, num2);
			return;
		}
		else
		{
			ControllerActionButton controllerActionButton = this.button;
			if (controllerActionButton != null)
			{
				bool hasMapping = controllerActionButton.HasMapping;
				ControllerActionButton.RequiredButtonState requiredState = this.button.RequiredState;
				if (requiredState != null && requiredState.state)
				{
					GUIControllerInputButton.LinkedControlType linkedControlType2 = GUIControlsBanner.FromButton(requiredState.Button);
					ControllerActionButton.Entry.Type mappingType = this.button.FirstEntry.MappingType;
					GUIControllerInputButton.LinkedControlType linkedControlType3 = GUIControlsBanner.FromButton(this.button.FirstEntry.Button);
					return;
				}
				ControllerActionButton.Entry entry;
				ControllerActionButton.Entry.Type mappingType2 = entry.MappingType;
				ControllerActionButton.Entry entry2;
				GUIControllerInputButton.LinkedControlType linkedControlType4 = GUIControlsBanner.FromButton(entry2.Button);
				return;
			}
		}
		IL_0243:
		int num3;
		if (num3 == 0)
		{
			return;
		}
	}

	// Token: 0x06000284 RID: 644 RVA: 0x000021DB File Offset: 0x000003DB
	public override float GetElementHeight()
	{
		throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
	}

	// Token: 0x06000285 RID: 645 RVA: 0x000072B0 File Offset: 0x000054B0
	private bool IsOverOptions(Vector2 cursorPosition)
	{
		return true;
	}

	// Token: 0x06000286 RID: 646 RVA: 0x000072C8 File Offset: 0x000054C8
	private string GetTitle()
	{
		/*
An exception occurred when decompiling this method (06000286)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.String GUIControllerMappingEntry::GetTitle()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_1:
	stloc:string(var_3_1F, ldfld:string(ControllerActionButton::Id, ldloc:ControllerActionButton(var_2_15)))
	stloc:LocalizedText(var_4_30, call:LocalizedText(Language::GetText, call:string(string::Concat, ldstr:string("ControllerMappings."), ldloc:string(var_3_1F))))
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

	// Token: 0x06000287 RID: 647 RVA: 0x00007308 File Offset: 0x00005508
	// Note: this type is marked as 'beforefieldinit'.
	static GUIControllerMappingEntry()
	{
	}

	// Token: 0x04000237 RID: 567
	private GUIControllerMappingStateTable Table;

	// Token: 0x04000238 RID: 568
	private ControllerActionVector vector;

	// Token: 0x04000239 RID: 569
	private ControllerActionButton button;

	// Token: 0x0400023A RID: 570
	private GUIControllerMappingState _state;

	// Token: 0x0400023B RID: 571
	private float buttonScale;

	// Token: 0x0400023C RID: 572
	private float scale;

	// Token: 0x0400023D RID: 573
	private bool drawingOverlay;

	// Token: 0x0400023E RID: 574
	private static int LastButtonMapped;

	// Token: 0x0400023F RID: 575
	public bool displayOptions;

	// Token: 0x04000240 RID: 576
	private GUIInputRegionExclusive _optionsBlocker;
}
