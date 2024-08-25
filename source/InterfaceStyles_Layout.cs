using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using Newtonsoft.Json;
using Terraria.Localization;

// Token: 0x020001DC RID: 476
[JsonObject(MemberSerialization.OptIn)]
public class InterfaceStyles_Layout : LayoutDefinition
{
	// Token: 0x06000C37 RID: 3127 RVA: 0x0003CF5C File Offset: 0x0003B15C
	private void Awake()
	{
		if (!true)
		{
		}
	}

	// Token: 0x17000155 RID: 341
	// (get) Token: 0x06000C38 RID: 3128 RVA: 0x0003CF6C File Offset: 0x0003B16C
	public static InterfaceProfile_Layout Active
	{
		get
		{
			/*
An exception occurred when decompiling this method (06000C38)

ICSharpCode.Decompiler.DecompilerException: Error decompiling InterfaceProfile_Layout InterfaceStyles_Layout::get_Active()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0000:
	brtrue(IL_0000, ldc.i4:bool(1))
}

   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1852
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1878
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1878
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1846
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.Optimize(DecompilerContext context, ILBlock method, AutoPropertyProvider autoPropertyProvider, StateMachineKind& stateMachineKind, MethodDef& inlinedMethod, AsyncMethodDebugInfo& asyncInfo, ILAstOptimizationStep abortBeforeStep) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 355
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(IEnumerable`1 parameters, MethodDebugInfoBuilder& builder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 123
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 88
   --- End of inner exception stack trace ---
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 92
   at ICSharpCode.Decompiler.Ast.AstBuilder.AddMethodBody(EntityDeclaration methodNode, EntityDeclaration& updatedNode, MethodDef method, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, MethodKind methodKind) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 1683
*/;
		}
	}

	// Token: 0x17000156 RID: 342
	// (get) Token: 0x06000C39 RID: 3129 RVA: 0x000021DB File Offset: 0x000003DB
	// (set) Token: 0x06000C3A RID: 3130 RVA: 0x0003CF7C File Offset: 0x0003B17C
	public static InterfaceProfile_Layout _active
	{
		get
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}
		set
		{
		}
	}

	// Token: 0x06000C3B RID: 3131 RVA: 0x0003CF8C File Offset: 0x0003B18C
	public static void LoadUIResolution()
	{
		if (!true)
		{
		}
		if (!true)
		{
		}
	}

	// Token: 0x06000C3C RID: 3132 RVA: 0x0003CFDC File Offset: 0x0003B1DC
	public static void SetActiveLayout(InterfaceProfile_Layout active)
	{
		long num = 0L;
		active.InvalidateMinResolution();
		InterfaceStyles_Layout.LoadUIResolution();
		if (num != 0L)
		{
			return;
		}
	}

	// Token: 0x06000C3D RID: 3133 RVA: 0x0003D020 File Offset: 0x0003B220
	public InterfaceProfile_Layout GetDefaultProfile(string profileName)
	{
		/*
An exception occurred when decompiling this method (06000C3D)

ICSharpCode.Decompiler.DecompilerException: Error decompiling InterfaceProfile_Layout InterfaceStyles_Layout::GetDefaultProfile(System.String)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:class InterfaceProfile_Layout[](var_0_06, ldfld:class InterfaceProfile_Layout[](InterfaceStyles_Layout::Profiles, ldloc:InterfaceStyles_Layout(this)))
	stloc:int32(var_1_0D, ldfld:int32(InterfaceProfile_Layout::VerticalResolution, ldloc:class InterfaceProfile_Layout[][exp:InterfaceProfile_Layout](var_0_06)))
	stloc:bool(var_2_1A, call:bool(string::op_Equality, ldfld:string(InterfaceProfile_Layout::ProfileName, ldloc:class InterfaceProfile_Layout[][exp:InterfaceProfile_Layout](var_0_06)), ldloc:string(profileName)))
	stloc:class InterfaceProfile_Layout[](var_3_21, ldfld:class InterfaceProfile_Layout[](InterfaceStyles_Layout::Profiles, ldloc:InterfaceStyles_Layout(this)))
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

	// Token: 0x06000C3E RID: 3134 RVA: 0x0003D054 File Offset: 0x0003B254
	public void SaveConfiguration()
	{
	}

	// Token: 0x06000C3F RID: 3135 RVA: 0x0003D07C File Offset: 0x0003B27C
	public void RefreshProfileNames()
	{
		float y = this.CustomProfiles._minResolution.Y;
		string textValue = Language.GetTextValue("Mobile.Fullscreen");
		Dictionary<GUIPageIcons.Category, bool> groupsCollapsed = this.CustomProfiles.GroupsCollapsed;
		string textValue2 = Language.GetTextValue("Mobile.Splitscreen");
		groupsCollapsed._buckets = textValue2;
		bool flag = DrPlatform.IsCurrentPlatform(DrPlatform.DrPlatformType.Mobile);
		string text;
		this.CustomProfiles.LeftGroupings._items = text;
	}

	// Token: 0x06000C40 RID: 3136 RVA: 0x0003D0E0 File Offset: 0x0003B2E0
	public void LoadConfiguration(bool allowLoad)
	{
		float y = this.CustomProfiles._minResolution.Y;
		InterfaceProfile_Layout defaultProfile = this.GetDefaultProfile("Compact");
		InterfaceProfile_Layout[] customProfiles = this.CustomProfiles;
		float y2 = customProfiles._minResolution.Y;
		Dictionary<GUIPageIcons.Category, bool> groupsCollapsed = this.CustomProfiles.GroupsCollapsed;
		InterfaceProfile_Layout defaultProfile2 = this.GetDefaultProfile("Compact");
		InterfaceProfile_Layout[] customProfiles2 = this.CustomProfiles;
		Dictionary<GUIPageIcons.Category, bool> groupsCollapsed2 = customProfiles2.GroupsCollapsed;
		List<GUIPageIconGrouping> leftGroupings = this.CustomProfiles.LeftGroupings;
		InterfaceProfile_Layout defaultProfile3 = this.GetDefaultProfile("TwoPage");
	}

	// Token: 0x06000C41 RID: 3137 RVA: 0x0003D274 File Offset: 0x0003B474
	public InterfaceStyles_Layout()
	{
		if (!true)
		{
		}
		base..ctor();
	}

	// Token: 0x06000C42 RID: 3138 RVA: 0x0003D28C File Offset: 0x0003B48C
	// Note: this type is marked as 'beforefieldinit'.
	static InterfaceStyles_Layout()
	{
	}

	// Token: 0x04001110 RID: 4368
	public static InterfaceStyles_Layout Instance;

	// Token: 0x04001111 RID: 4369
	private static List<GUIPageIcons.Category> refreshCategories;

	// Token: 0x04001112 RID: 4370
	public InterfaceProfile_Layout[] Profiles;

	// Token: 0x04001113 RID: 4371
	[JsonProperty("Profiles")]
	public InterfaceProfile_Layout[] CustomProfiles;
}
