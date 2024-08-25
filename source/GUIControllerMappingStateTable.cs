using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Controller;
using Cpp2IlInjected;
using Terraria.IO;

// Token: 0x0200007C RID: 124
public class GUIControllerMappingStateTable
{
	// Token: 0x060002C1 RID: 705 RVA: 0x00009118 File Offset: 0x00007318
	public GUIControllerMappingStateTable()
	{
		ControllerActionButton.RequiredButtonState requiredState = this.Left.RequiredState;
		requiredState.Button = Buttons.ShoulderLeft;
		requiredState.state = true;
		ControllerActionButton.RequiredButtonState requiredState2 = this.Right.RequiredState;
		requiredState2.Button = Buttons.ShoulderRight;
		requiredState2.state = true;
	}

	// Token: 0x060002C2 RID: 706 RVA: 0x00009160 File Offset: 0x00007360
	public bool IsAnyLeftButtonConflict(Buttons button)
	{
		if (true)
		{
			return;
		}
	}

	// Token: 0x060002C3 RID: 707 RVA: 0x00009178 File Offset: 0x00007378
	public bool IsAnyRightButtonConflict(Buttons button)
	{
		/*
An exception occurred when decompiling this method (060002C3)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean GUIControllerMappingStateTable::IsAnyRightButtonConflict(Controller.Buttons)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0014:
	stloc:int32(var_1_1F, ldfld:int32(List`1::_size, ldfld:class [mscorlib]System.Collections.Generic.List`1<class GUIControllerMappingStateTable>[exp:List`1](GUIControllerMappingStateTable::LinkedParentStates, ldloc:GUIControllerMappingStateTable(this))))
	stloc:int32(var_4_2D, ldfld:int32(List`1::_size, ldfld:class [mscorlib]System.Collections.Generic.List`1<class GUIControllerMappingStateTable>[exp:List`1](GUIControllerMappingStateTable::LinkedParentStates, ldloc:GUIControllerMappingStateTable(this))))
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

	// Token: 0x060002C4 RID: 708 RVA: 0x000091B8 File Offset: 0x000073B8
	public bool IsAnyLeftAxisButtonConflict(AxisButtons button)
	{
		/*
An exception occurred when decompiling this method (060002C4)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean GUIControllerMappingStateTable::IsAnyLeftAxisButtonConflict(Controller.AxisButtons)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_1:
	stloc:int32(var_4_2D, ldfld:int32(List`1::_size, ldfld:class [mscorlib]System.Collections.Generic.List`1<class GUIControllerMappingStateTable>[exp:List`1](GUIControllerMappingStateTable::LinkedParentStates, ldloc:GUIControllerMappingStateTable(this))))
	stloc:int32(var_7_3D, ldfld:int32(List`1::_size, ldfld:class [mscorlib]System.Collections.Generic.List`1<class GUIControllerMappingStateTable>[exp:List`1](GUIControllerMappingStateTable::LinkedParentStates, ldloc:GUIControllerMappingStateTable(this))))
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

	// Token: 0x060002C5 RID: 709 RVA: 0x00009208 File Offset: 0x00007408
	public bool IsAnyRightAxisButtonConflict(AxisButtons button)
	{
		/*
An exception occurred when decompiling this method (060002C5)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean GUIControllerMappingStateTable::IsAnyRightAxisButtonConflict(Controller.AxisButtons)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_1:
	stloc:int32(var_4_2D, ldfld:int32(List`1::_size, ldfld:class [mscorlib]System.Collections.Generic.List`1<class GUIControllerMappingStateTable>[exp:List`1](GUIControllerMappingStateTable::LinkedParentStates, ldloc:GUIControllerMappingStateTable(this))))
	stloc:int32(var_7_3D, ldfld:int32(List`1::_size, ldfld:class [mscorlib]System.Collections.Generic.List`1<class GUIControllerMappingStateTable>[exp:List`1](GUIControllerMappingStateTable::LinkedParentStates, ldloc:GUIControllerMappingStateTable(this))))
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

	// Token: 0x060002C6 RID: 710 RVA: 0x00009258 File Offset: 0x00007458
	public bool IsAnyLeftAxisConflict(Axis axis)
	{
		/*
An exception occurred when decompiling this method (060002C6)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean GUIControllerMappingStateTable::IsAnyLeftAxisConflict(Controller.Axis)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0043:
	stloc:int32(var_9_4E, ldfld:int32(List`1::_size, ldfld:class [mscorlib]System.Collections.Generic.List`1<class GUIControllerMappingStateTable>[exp:List`1](GUIControllerMappingStateTable::LinkedParentStates, ldloc:GUIControllerMappingStateTable(this))))
	stloc:int32(var_12_5E, ldfld:int32(List`1::_size, ldfld:class [mscorlib]System.Collections.Generic.List`1<class GUIControllerMappingStateTable>[exp:List`1](GUIControllerMappingStateTable::LinkedParentStates, ldloc:GUIControllerMappingStateTable(this))))
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

	// Token: 0x060002C7 RID: 711 RVA: 0x000092C8 File Offset: 0x000074C8
	public bool IsAnyRightAxisConflict(Axis axis)
	{
		/*
An exception occurred when decompiling this method (060002C7)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean GUIControllerMappingStateTable::IsAnyRightAxisConflict(Controller.Axis)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_004B:
	stloc:int32(var_10_56, ldfld:int32(List`1::_size, ldfld:class [mscorlib]System.Collections.Generic.List`1<class GUIControllerMappingStateTable>[exp:List`1](GUIControllerMappingStateTable::LinkedParentStates, ldloc:GUIControllerMappingStateTable(this))))
	stloc:int32(var_13_66, ldfld:int32(List`1::_size, ldfld:class [mscorlib]System.Collections.Generic.List`1<class GUIControllerMappingStateTable>[exp:List`1](GUIControllerMappingStateTable::LinkedParentStates, ldloc:GUIControllerMappingStateTable(this))))
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

	// Token: 0x060002C8 RID: 712 RVA: 0x00009340 File Offset: 0x00007540
	public void Backup()
	{
		GUIControllerMappingState backupNormal = this.BackupNormal;
		GUIControllerMappingState normal = this.Normal;
		backupNormal.Copy(normal);
		GUIControllerMappingState backupLeft = this.BackupLeft;
		GUIControllerMappingState left = this.Left;
		backupLeft.Copy(left);
		GUIControllerMappingState backupRight = this.BackupRight;
		GUIControllerMappingState right = this.Right;
		backupRight.Copy(right);
	}

	// Token: 0x060002C9 RID: 713 RVA: 0x00009390 File Offset: 0x00007590
	public void RestoreBackup()
	{
		GUIControllerMappingState normal = this.Normal;
		GUIControllerMappingState backupNormal = this.BackupNormal;
		normal.Copy(backupNormal);
		GUIControllerMappingState left = this.Left;
		GUIControllerMappingState backupLeft = this.BackupLeft;
		left.Copy(backupLeft);
		GUIControllerMappingState right = this.Right;
		GUIControllerMappingState backupRight = this.BackupRight;
		right.Copy(backupRight);
	}

	// Token: 0x060002CA RID: 714 RVA: 0x000093E0 File Offset: 0x000075E0
	public void ClearMappings()
	{
		ControllerActionAxis[] axisBindings = this.Normal.AxisBindings;
		ControllerActionAxis[] axisBindings2 = this.Left.AxisBindings;
		ControllerActionAxis[] axisBindings3 = this.Right.AxisBindings;
		ControllerActionButton[] buttonBindings = this.Normal.ButtonBindings;
		ControllerActionButton[] buttonBindings2 = this.Left.ButtonBindings;
		ControllerActionButton[] buttonBindings3 = this.Right.ButtonBindings;
		ControllerActionButton[] axisButtonBindings = this.Normal.AxisButtonBindings;
		ControllerActionButton[] axisButtonBindings2 = this.Left.AxisButtonBindings;
		ControllerActionButton[] axisButtonBindings3 = this.Right.AxisButtonBindings;
	}

	// Token: 0x060002CB RID: 715 RVA: 0x0000946C File Offset: 0x0000766C
	public void LoadMappingValues()
	{
		GUIControllerMappingStateTable linkedChildState = this.LinkedChildState;
		GUIControllerMappingState normal = this.Normal;
		GUIControllerMappingState left = this.Left;
		GUIControllerMappingState right = this.Right;
		int size = this.LinkedParentStates._size;
		int size2 = this.LinkedParentStates._size;
	}

	// Token: 0x060002CC RID: 716 RVA: 0x000094B4 File Offset: 0x000076B4
	public void TransferMapping(ControllerActionButton button, GUIControllerMappingStateTable other)
	{
		GUIControllerMappingState normal = this.Normal;
		GUIControllerMappingState normal2 = other.Normal;
		normal.TransferMapping(button, normal2);
		GUIControllerMappingState left = this.Left;
		GUIControllerMappingState left2 = other.Left;
		left.TransferMapping(button, left2);
		GUIControllerMappingState right = this.Right;
		GUIControllerMappingState right2 = other.Right;
		right.TransferMapping(button, right2);
	}

	// Token: 0x060002CD RID: 717 RVA: 0x00009508 File Offset: 0x00007708
	public void SaveConfiguration(string configurationTable, Preferences preferences)
	{
		GUIControllerMappingState normal = this.Normal;
		string text = configurationTable + "_";
		normal.SaveConfiguration(text, preferences);
		GUIControllerMappingState left = this.Left;
		string text2 = configurationTable + "Left_";
		left.SaveConfiguration(text2, preferences);
		GUIControllerMappingState right = this.Right;
		string text3 = configurationTable + "Right_";
		right.SaveConfiguration("Right_", preferences);
	}

	// Token: 0x060002CE RID: 718 RVA: 0x00009570 File Offset: 0x00007770
	public void LoadConfiguration(string configurationTable, Preferences preferences, bool mappingsCleared, List<ControllerActionButton> allowedButtons, List<ControllerActionAxis> allowedAxis)
	{
		GUIControllerMappingState normal = this.Normal;
		string text = configurationTable + "_";
		normal.LoadConfiguration(text, preferences, mappingsCleared, allowedButtons, allowedAxis);
		GUIControllerMappingState left = this.Left;
		string text2 = configurationTable + "Left_";
		left.LoadConfiguration(text2, preferences, mappingsCleared, allowedButtons, allowedAxis);
		GUIControllerMappingState right = this.Right;
		string text3 = configurationTable + "Right_";
		right.LoadConfiguration(text3, preferences, mappingsCleared, allowedButtons, allowedAxis);
	}

	// Token: 0x060002CF RID: 719 RVA: 0x000095E4 File Offset: 0x000077E4
	public bool IsSame(GUIControllerMappingStateTable other)
	{
		GUIControllerMappingState normal = this.Normal;
		GUIControllerMappingState normal2 = other.Normal;
		bool flag = normal.IsSame(normal2);
		GUIControllerMappingState left = this.Left;
		GUIControllerMappingState left2 = other.Left;
		bool flag2 = left.IsSame(left2);
		GUIControllerMappingState right = this.Right;
		GUIControllerMappingState right2 = other.Right;
		return right.IsSame(right2);
	}

	// Token: 0x060002D0 RID: 720 RVA: 0x0000963C File Offset: 0x0000783C
	public void Copy(GUIControllerMappingStateTable other)
	{
		GUIControllerMappingState normal = this.Normal;
		GUIControllerMappingState normal2 = other.Normal;
		normal.Copy(normal2);
		GUIControllerMappingState left = this.Left;
		GUIControllerMappingState left2 = other.Left;
		left.Copy(left2);
		GUIControllerMappingState right = this.Right;
		GUIControllerMappingState right2 = other.Right;
		right.Copy(right2);
	}

	// Token: 0x060002D1 RID: 721 RVA: 0x000021DB File Offset: 0x000003DB
	public void SetChildState(GUIControllerMappingStateTable childState)
	{
		throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
	}

	// Token: 0x060002D2 RID: 722 RVA: 0x0000968C File Offset: 0x0000788C
	public void DisableConflictingActions(GUIControllerMappingStateTable other, bool altDisableFaceBindings = true)
	{
		GUIControllerMappingState normal = this.Normal;
		GUIControllerMappingState normal2 = other.Normal;
		normal.DisableConflictingActions(normal2);
		GUIControllerMappingState left = this.Left;
		GUIControllerMappingState normal3 = other.Normal;
		left.DisableConflictingActions(normal3);
		GUIControllerMappingState right = this.Right;
		GUIControllerMappingState normal4 = other.Normal;
		right.DisableConflictingActions(normal4);
		GUIControllerMappingState left2 = this.Left;
		GUIControllerMappingState left3 = other.Left;
		left2.DisableConflictingActions(left3);
		GUIControllerMappingState right2 = this.Right;
		GUIControllerMappingState right3 = other.Right;
		right2.DisableConflictingActions(right3);
		int size = other.LinkedParentStates._size;
		int size2 = other.LinkedParentStates._size;
	}

	// Token: 0x060002D3 RID: 723 RVA: 0x000021DB File Offset: 0x000003DB
	public GUIControllerMappingState GetState(int stateIndex)
	{
		throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
	}

	// Token: 0x060002D4 RID: 724 RVA: 0x0000972C File Offset: 0x0000792C
	public void ClearLinkedButtonBindings(int stateIndex, Buttons button, [Optional] List<ControllerActionButton> allowedActions)
	{
		if (this.LinkedChildState != null)
		{
			if (allowedActions != null)
			{
				return;
			}
			return;
		}
		else
		{
			int size = this.LinkedParentStates._size;
			if (allowedActions != null)
			{
				return;
			}
			return;
		}
	}

	// Token: 0x060002D5 RID: 725 RVA: 0x000097B8 File Offset: 0x000079B8
	public void ClearLinkedAxisBindings(int stateIndex, Axis x, Axis y, bool tableOnly = false)
	{
	}

	// Token: 0x060002D6 RID: 726 RVA: 0x0000982C File Offset: 0x00007A2C
	public void ClearLinkedButtonBindings(int stateIndex, AxisButtons axisButton, [Optional] List<ControllerActionButton> allowedActions, bool tableOnly = false)
	{
	}

	// Token: 0x060002D7 RID: 727 RVA: 0x00009868 File Offset: 0x00007A68
	public void RemoveButtonBindings(ControllerActionButton actionButton)
	{
		ControllerActionButton[] buttonBindings = this.Left.ButtonBindings;
		ControllerActionButton[] buttonBindings2 = this.Right.ButtonBindings;
		ControllerActionButton[] buttonBindings3 = this.Normal.ButtonBindings;
		ControllerActionButton[] axisButtonBindings = this.Left.AxisButtonBindings;
		ControllerActionButton[] axisButtonBindings2 = this.Right.AxisButtonBindings;
		ControllerActionButton[] axisButtonBindings3 = this.Normal.AxisButtonBindings;
	}

	// Token: 0x0400031C RID: 796
	public GUIControllerMappingState Normal;

	// Token: 0x0400031D RID: 797
	public GUIControllerMappingState Left;

	// Token: 0x0400031E RID: 798
	public GUIControllerMappingState Right;

	// Token: 0x0400031F RID: 799
	public GUIControllerMappingState BackupNormal;

	// Token: 0x04000320 RID: 800
	public GUIControllerMappingState BackupLeft;

	// Token: 0x04000321 RID: 801
	public GUIControllerMappingState BackupRight;

	// Token: 0x04000322 RID: 802
	private GUIControllerMappingStateTable LinkedChildState;

	// Token: 0x04000323 RID: 803
	private List<GUIControllerMappingStateTable> LinkedParentStates;
}
