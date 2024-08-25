using System;
using Newtonsoft.Json;
using Terraria.IO;

// Token: 0x0200024F RID: 591
[JsonObject(MemberSerialization.OptIn)]
public class VirtualControlsStyles_Layout : LayoutDefinition
{
	// Token: 0x06000D46 RID: 3398 RVA: 0x0003F86C File Offset: 0x0003DA6C
	private void Awake()
	{
	}

	// Token: 0x17000172 RID: 370
	// (get) Token: 0x06000D47 RID: 3399 RVA: 0x0003F87C File Offset: 0x0003DA7C
	public VirtualControlsProfile_Layout ActiveProfile
	{
		get
		{
			if (this._activeProfile == null && this.Profiles.EditedName != null)
			{
				string hardware = this.Profiles.Hardware;
				VirtualControlsProfile_Layout profile = this.GetProfile(hardware);
				this.SetActiveProfile(profile);
			}
			return this._activeProfile;
		}
	}

	// Token: 0x06000D48 RID: 3400 RVA: 0x0003F8C0 File Offset: 0x0003DAC0
	public void SetActiveProfile(VirtualControlsProfile_Layout profile)
	{
		this._activeProfile = profile;
		if (profile != null)
		{
			profile.HardwareConfig.LoadControlPositions();
			return;
		}
	}

	// Token: 0x06000D49 RID: 3401 RVA: 0x0003F8E4 File Offset: 0x0003DAE4
	public VirtualControlsButtonConfiguration_Layout GetButtonConfiguration(string Id)
	{
		/*
An exception occurred when decompiling this method (06000D49)

ICSharpCode.Decompiler.DecompilerException: Error decompiling VirtualControlsButtonConfiguration_Layout VirtualControlsStyles_Layout::GetButtonConfiguration(System.String)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:class VirtualControlsButtonConfiguration_Layout[](var_0_06, ldfld:class VirtualControlsButtonConfiguration_Layout[](VirtualControlsStyles_Layout::ButtonTypes, ldloc:VirtualControlsStyles_Layout(this)))
	stloc:QuickActionButton_Layout(var_1_0D, ldfld:QuickActionButton_Layout(VirtualControlsButtonConfiguration_Layout::BlueLayout, ldloc:class VirtualControlsButtonConfiguration_Layout[][exp:VirtualControlsButtonConfiguration_Layout](var_0_06)))
	stloc:bool(var_2_1A, call:bool(string::op_Equality, ldfld:string(VirtualControlsButtonConfiguration_Layout::Id, ldloc:class VirtualControlsButtonConfiguration_Layout[][exp:VirtualControlsButtonConfiguration_Layout](var_0_06)), ldloc:string(Id)))
	stloc:class VirtualControlsButtonConfiguration_Layout[](var_3_21, ldfld:class VirtualControlsButtonConfiguration_Layout[](VirtualControlsStyles_Layout::ButtonTypes, ldloc:VirtualControlsStyles_Layout(this)))
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

	// Token: 0x06000D4A RID: 3402 RVA: 0x0003F918 File Offset: 0x0003DB18
	public VirtualControlsAxisConfiguration_Layout GetAxisConfiguration(string Id)
	{
		/*
An exception occurred when decompiling this method (06000D4A)

ICSharpCode.Decompiler.DecompilerException: Error decompiling VirtualControlsAxisConfiguration_Layout VirtualControlsStyles_Layout::GetAxisConfiguration(System.String)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:class VirtualControlsAxisConfiguration_Layout[](var_0_06, ldfld:class VirtualControlsAxisConfiguration_Layout[](VirtualControlsStyles_Layout::AxisTypes, ldloc:VirtualControlsStyles_Layout(this)))
	stloc:Axis_Layout(var_1_0D, ldfld:Axis_Layout(VirtualControlsAxisConfiguration_Layout::BlueLayout, ldloc:class VirtualControlsAxisConfiguration_Layout[][exp:VirtualControlsAxisConfiguration_Layout](var_0_06)))
	stloc:bool(var_2_1A, call:bool(string::op_Equality, ldfld:string(VirtualControlsAxisConfiguration_Layout::Id, ldloc:class VirtualControlsAxisConfiguration_Layout[][exp:VirtualControlsAxisConfiguration_Layout](var_0_06)), ldloc:string(Id)))
	stloc:class VirtualControlsAxisConfiguration_Layout[](var_3_21, ldfld:class VirtualControlsAxisConfiguration_Layout[](VirtualControlsStyles_Layout::AxisTypes, ldloc:VirtualControlsStyles_Layout(this)))
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

	// Token: 0x06000D4B RID: 3403 RVA: 0x0003F94C File Offset: 0x0003DB4C
	public VirtualControlsHardwareConfiguration_Layout GetHardwareConfiguration(string id)
	{
		/*
An exception occurred when decompiling this method (06000D4B)

ICSharpCode.Decompiler.DecompilerException: Error decompiling VirtualControlsHardwareConfiguration_Layout VirtualControlsStyles_Layout::GetHardwareConfiguration(System.String)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:class VirtualControlsHardwareConfiguration_Layout[](var_0_06, ldfld:class VirtualControlsHardwareConfiguration_Layout[](VirtualControlsStyles_Layout::HardwareStyles, ldloc:VirtualControlsStyles_Layout(this)))
	stloc:string(var_1_0D, ldfld:string(VirtualControlsHardwareConfiguration_Layout::EditedName, ldloc:class VirtualControlsHardwareConfiguration_Layout[][exp:VirtualControlsHardwareConfiguration_Layout](var_0_06)))
	stloc:bool(var_2_1A, call:bool(string::op_Equality, ldfld:string(VirtualControlsHardwareConfiguration_Layout::Id, ldloc:class VirtualControlsHardwareConfiguration_Layout[][exp:VirtualControlsHardwareConfiguration_Layout](var_0_06)), ldloc:string(id)))
	stloc:class VirtualControlsHardwareConfiguration_Layout[](var_3_21, ldfld:class VirtualControlsHardwareConfiguration_Layout[](VirtualControlsStyles_Layout::HardwareStyles, ldloc:VirtualControlsStyles_Layout(this)))
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

	// Token: 0x06000D4C RID: 3404 RVA: 0x0003F980 File Offset: 0x0003DB80
	public VirtualControlsProfile_Layout GetProfile(string id)
	{
		/*
An exception occurred when decompiling this method (06000D4C)

ICSharpCode.Decompiler.DecompilerException: Error decompiling VirtualControlsProfile_Layout VirtualControlsStyles_Layout::GetProfile(System.String)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:class VirtualControlsProfile_Layout[](var_0_06, ldfld:class VirtualControlsProfile_Layout[](VirtualControlsStyles_Layout::Profiles, ldloc:VirtualControlsStyles_Layout(this)))
	stloc:string(var_1_0D, ldfld:string(VirtualControlsProfile_Layout::EditedName, ldloc:class VirtualControlsProfile_Layout[][exp:VirtualControlsProfile_Layout](var_0_06)))
	stloc:bool(var_2_1A, call:bool(string::op_Equality, ldfld:string(VirtualControlsProfile_Layout::Id, ldloc:class VirtualControlsProfile_Layout[][exp:VirtualControlsProfile_Layout](var_0_06)), ldloc:string(id)))
	stloc:class VirtualControlsProfile_Layout[](var_3_21, ldfld:class VirtualControlsProfile_Layout[](VirtualControlsStyles_Layout::Profiles, ldloc:VirtualControlsStyles_Layout(this)))
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

	// Token: 0x06000D4D RID: 3405 RVA: 0x0003F9B4 File Offset: 0x0003DBB4
	public void SaveConfiguration(Preferences preferences)
	{
	}

	// Token: 0x06000D4E RID: 3406 RVA: 0x0003F9DC File Offset: 0x0003DBDC
	public void LoadConfiguration(Preferences preferences)
	{
		VirtualControlsHardwareConfiguration_Layout hardwareConfiguration = this.GetHardwareConfiguration("Default");
		VirtualControlsHardwareConfiguration_Layout hardwareConfiguration2 = this.GetHardwareConfiguration("Profile1");
		VirtualControlsHardwareConfiguration_Layout hardwareConfiguration3 = this.GetHardwareConfiguration("Profile2");
		VirtualControlsHardwareConfiguration_Layout hardwareConfiguration4 = this.GetHardwareConfiguration("Profile3");
		VirtualControlsHardwareConfiguration_Layout hardwareConfiguration5 = this.GetHardwareConfiguration("Profile4");
	}

	// Token: 0x06000D4F RID: 3407 RVA: 0x0003FAF4 File Offset: 0x0003DCF4
	public VirtualControlsStyles_Layout()
	{
		if (!true)
		{
		}
		base..ctor();
	}

	// Token: 0x0400185B RID: 6235
	public static VirtualControlsStyles_Layout Instance;

	// Token: 0x0400185C RID: 6236
	public static string LastUsedProfile;

	// Token: 0x0400185D RID: 6237
	public VirtualControlsButtonConfiguration_Layout[] ButtonTypes;

	// Token: 0x0400185E RID: 6238
	public VirtualControlsAxisConfiguration_Layout[] AxisTypes;

	// Token: 0x0400185F RID: 6239
	[JsonProperty("Hardware")]
	public VirtualControlsHardwareConfiguration_Layout[] HardwareStyles;

	// Token: 0x04001860 RID: 6240
	[JsonProperty("Profiles")]
	public VirtualControlsProfile_Layout[] Profiles;

	// Token: 0x04001861 RID: 6241
	private VirtualControlsProfile_Layout _activeProfile;
}
