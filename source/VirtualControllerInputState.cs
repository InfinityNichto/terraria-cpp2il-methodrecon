using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Controller;
using Terraria;
using Terraria.ID;
using Terraria.IO;
using Terraria.Utilities;

// Token: 0x0200017F RID: 383
public class VirtualControllerInputState
{
	// Token: 0x06000AE4 RID: 2788 RVA: 0x000371C4 File Offset: 0x000353C4
	private static void SetupLookups()
	{
		if (!true)
		{
		}
		if (true)
		{
			return;
		}
	}

	// Token: 0x17000117 RID: 279
	// (get) Token: 0x06000AE5 RID: 2789 RVA: 0x000371D8 File Offset: 0x000353D8
	private string ConfigFile
	{
		get
		{
			if (!true)
			{
			}
			return Main.SavePath + "/ItemCategories.csv";
		}
	}

	// Token: 0x06000AE6 RID: 2790 RVA: 0x000371FC File Offset: 0x000353FC
	private static void SaveCodeArrayCategories()
	{
		if (!true)
		{
		}
		if ("\tItemID." == null || "\tItemID." != null)
		{
			if ("\tItemID." == null)
			{
			}
			string text;
			if ((", (int)Category." == null || ", (int)Category." != null) && (text == null || text != null) && ("," == null || "," != null))
			{
				string text2 = Main.SavePath + "/Test.cs";
				return;
			}
		}
		throw new ArrayTypeMismatchException();
	}

	// Token: 0x06000AE7 RID: 2791 RVA: 0x00037274 File Offset: 0x00035474
	public void SaveDefaultCategories()
	{
		long num = 0L;
		string text;
		bool flag = FileUtilities.Exists(text, num != 0L);
		long num2 = 0L;
		string text2;
		FileUtilities.Delete(text2, num2 != 0L);
		VirtualControllerInputState.SetupLookups();
		string text3;
		if (("Item" == null || "Item" != null) && ("Category" == null || "Category" != null) && (text3 == null || text3 != null))
		{
			return;
		}
		throw new ArrayTypeMismatchException();
	}

	// Token: 0x06000AE8 RID: 2792 RVA: 0x000372D8 File Offset: 0x000354D8
	public void LoadDefaultCategories()
	{
	}

	// Token: 0x06000AE9 RID: 2793 RVA: 0x000372E8 File Offset: 0x000354E8
	public float GetItemDeadZone(Item item)
	{
		/*
An exception occurred when decompiling this method (06000AE9)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Single VirtualControllerInputState::GetItemDeadZone(Terraria.Item)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_000A:
	stloc:Category(var_1_10, call:Category(VirtualControllerInputState::GetItemCategory, ldloc:int32(var_0_06)))
	stloc:class [mscorlib]System.Collections.Generic.Dictionary`2<valuetype VirtualControllerInputState/Category, float32>(var_2_17, ldfld:class [mscorlib]System.Collections.Generic.Dictionary`2<valuetype VirtualControllerInputState/Category, float32>(VirtualControllerInputState::NoFireDeadZoneState, ldloc:VirtualControllerInputState(this)))
	stloc:class [mscorlib]System.Collections.Generic.Dictionary`2<valuetype VirtualControllerInputState/Category, bool>(var_4_1E, ldfld:class [mscorlib]System.Collections.Generic.Dictionary`2<valuetype VirtualControllerInputState/Category, bool>(VirtualControllerInputState::SmartCursorState, ldloc:VirtualControllerInputState(this)))
	stloc:class [mscorlib]System.Collections.Generic.Dictionary`2<valuetype VirtualControllerInputState/Category, bool>(var_5_26, ldfld:class [mscorlib]System.Collections.Generic.Dictionary`2<valuetype VirtualControllerInputState/Category, bool>(VirtualControllerInputState::AimAndUseState, ldloc:VirtualControllerInputState(this)))
	stloc:class [mscorlib]System.Collections.Generic.Dictionary`2<valuetype VirtualControllerInputState/Category, float32>(var_6_2E, ldfld:class [mscorlib]System.Collections.Generic.Dictionary`2<valuetype VirtualControllerInputState/Category, float32>(VirtualControllerInputState::NoFireDeadZoneState, ldloc:VirtualControllerInputState(this)))
	stloc:class [mscorlib]System.Collections.Generic.Dictionary`2<valuetype VirtualControllerInputState/Category, float32>(var_7_36, ldfld:class [mscorlib]System.Collections.Generic.Dictionary`2<valuetype VirtualControllerInputState/Category, float32>(VirtualControllerInputState::NoFireDeadZoneState, ldloc:VirtualControllerInputState(this)))
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

	// Token: 0x06000AEA RID: 2794 RVA: 0x0003732C File Offset: 0x0003552C
	public static VirtualControllerInputState.Category GetItemCategory(int item)
	{
		/*
An exception occurred when decompiling this method (06000AEA)

ICSharpCode.Decompiler.DecompilerException: Error decompiling VirtualControllerInputState/Category VirtualControllerInputState::GetItemCategory(System.Int32)

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

	// Token: 0x06000AEB RID: 2795 RVA: 0x0003733C File Offset: 0x0003553C
	public void UpdateState(int selectedItem)
	{
		if (!true)
		{
		}
		VirtualControllerInputState.Category itemCategory = VirtualControllerInputState.GetItemCategory(selectedItem);
		VirtualControllerInputState.Category currentlyBoundCategory = this.CurrentlyBoundCategory;
	}

	// Token: 0x17000118 RID: 280
	// (get) Token: 0x06000AEC RID: 2796 RVA: 0x00037360 File Offset: 0x00035560
	public bool ForceAutoReuse
	{
		get
		{
			if (this.ForceAutoSwingEnabled)
			{
				VirtualControllerInputState.Category currentlyBoundCategory = this.CurrentlyBoundCategory;
				return this.GetCategoryAutoSwing(currentlyBoundCategory);
			}
		}
	}

	// Token: 0x17000119 RID: 281
	// (get) Token: 0x06000AED RID: 2797 RVA: 0x00037388 File Offset: 0x00035588
	public float NoFireDeadZone
	{
		get
		{
			/*
An exception occurred when decompiling this method (06000AED)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Single VirtualControllerInputState::get_NoFireDeadZone()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:float32(var_0_06, ldfld:float32(VirtualControllerInputState::_noFireDeadZone, ldloc:VirtualControllerInputState(this)))
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

	// Token: 0x1700011A RID: 282
	// (get) Token: 0x06000AEE RID: 2798 RVA: 0x0003739C File Offset: 0x0003559C
	// (set) Token: 0x06000AEF RID: 2799 RVA: 0x000373E0 File Offset: 0x000355E0
	public bool SmartDigEnabled
	{
		get
		{
			return ControllerActionManager.AnyControllerConnected;
		}
		set
		{
		}
	}

	// Token: 0x1700011B RID: 283
	// (get) Token: 0x06000AF0 RID: 2800 RVA: 0x00037418 File Offset: 0x00035618
	// (set) Token: 0x06000AF1 RID: 2801 RVA: 0x00037458 File Offset: 0x00035658
	public bool AimAndUseEnabled
	{
		get
		{
			bool anyControllerConnected = ControllerActionManager.AnyControllerConnected;
			bool flag;
			return flag;
		}
		set
		{
			bool anyControllerConnected = ControllerActionManager.AnyControllerConnected;
			int num = 24;
			this.GlobalAimAndUseEnabled = num != 0;
		}
	}

	// Token: 0x06000AF2 RID: 2802 RVA: 0x000374A4 File Offset: 0x000356A4
	private void SetCatergoryState(VirtualControllerInputState.Category category)
	{
		Dictionary<VirtualControllerInputState.Category, float> noFireDeadZoneState = this.NoFireDeadZoneState;
		Dictionary<VirtualControllerInputState.Category, bool> smartCursorState = this.SmartCursorState;
		Dictionary<VirtualControllerInputState.Category, bool> aimAndUseState = this.AimAndUseState;
		Dictionary<VirtualControllerInputState.Category, bool> smartCursorState2 = this.SmartCursorState;
		Dictionary<VirtualControllerInputState.Category, bool> aimAndUseState2 = this.AimAndUseState;
		Dictionary<VirtualControllerInputState.Category, float> noFireDeadZoneState2 = this.NoFireDeadZoneState;
		Dictionary<VirtualControllerInputState.Category, float> noFireDeadZoneState3 = this.NoFireDeadZoneState;
		Dictionary<VirtualControllerInputState.Category, bool> smartCursorState3 = this.SmartCursorState;
		Dictionary<VirtualControllerInputState.Category, bool> aimAndUseState3 = this.AimAndUseState;
		this.CurrentlyBoundCategory = category;
	}

	// Token: 0x06000AF3 RID: 2803 RVA: 0x00037500 File Offset: 0x00035700
	private bool GetCategoryAutoSwing(VirtualControllerInputState.Category category)
	{
	}

	// Token: 0x06000AF4 RID: 2804 RVA: 0x00037510 File Offset: 0x00035710
	private void GetCategoryDefaults(VirtualControllerInputState.Category category, [Out] bool smartCursor, [Out] bool aimAndUse, [Out] float noFireDeadZone)
	{
		int num = 1;
		smartCursor.m_value = num != 0;
		aimAndUse.m_value = num != 0;
	}

	// Token: 0x06000AF5 RID: 2805 RVA: 0x00037558 File Offset: 0x00035758
	public void ResetConfiguration()
	{
		Dictionary<VirtualControllerInputState.Category, bool> smartCursorState = this.SmartCursorState;
		Dictionary<VirtualControllerInputState.Category, bool> aimAndUseState = this.AimAndUseState;
		Dictionary<VirtualControllerInputState.Category, float> noFireDeadZoneState = this.NoFireDeadZoneState;
	}

	// Token: 0x06000AF6 RID: 2806 RVA: 0x0003757C File Offset: 0x0003577C
	public void LoadConfiguration(Preferences preferences)
	{
		Dictionary<VirtualControllerInputState.Category, bool> smartCursorState = this.SmartCursorState;
		string text2;
		string text = text2 + "_SmartCursor";
		Dictionary<VirtualControllerInputState.Category, bool> aimAndUseState = this.AimAndUseState;
		string text3 = text2 + "_AimAndUse";
		Dictionary<VirtualControllerInputState.Category, float> noFireDeadZoneState = this.NoFireDeadZoneState;
	}

	// Token: 0x06000AF7 RID: 2807 RVA: 0x000375C0 File Offset: 0x000357C0
	public void SaveConfiguration(Preferences preferences)
	{
		bool forceAutoSwingEnabled = this.ForceAutoSwingEnabled;
		string text2;
		string text = text2 + "_SmartCursor";
		Dictionary<VirtualControllerInputState.Category, bool> smartCursorState = this.SmartCursorState;
		string text3 = text2 + "_AimAndUse";
		Dictionary<VirtualControllerInputState.Category, bool> aimAndUseState = this.AimAndUseState;
	}

	// Token: 0x06000AF8 RID: 2808 RVA: 0x00037600 File Offset: 0x00035800
	public VirtualControllerInputState()
	{
	}

	// Token: 0x06000AF9 RID: 2809 RVA: 0x00037624 File Offset: 0x00035824
	// Note: this type is marked as 'beforefieldinit'.
	static VirtualControllerInputState()
	{
		if (!true)
		{
		}
	}

	// Token: 0x04000B34 RID: 2868
	private static string[] IdLookup;

	// Token: 0x04000B35 RID: 2869
	public static int[] ItemCategories;

	// Token: 0x04000B36 RID: 2870
	public bool printMessages;

	// Token: 0x04000B37 RID: 2871
	public bool ForceAutoSwingEnabled;

	// Token: 0x04000B38 RID: 2872
	public VirtualControllerInputState.CursorInputMode TouchSmartCursor;

	// Token: 0x04000B39 RID: 2873
	public VirtualControllerInputState.CursorInputMode TouchAimAndUse;

	// Token: 0x04000B3A RID: 2874
	public VirtualControllerInputState.CursorInputMode ControllerSmartCursor;

	// Token: 0x04000B3B RID: 2875
	public VirtualControllerInputState.CursorInputMode ControllerAimAndUse = VirtualControllerInputState.CursorInputMode.Global;

	// Token: 0x04000B3C RID: 2876
	public VirtualControllerInputState.CursorInputMode MouseSmartCursor;

	// Token: 0x04000B3D RID: 2877
	public bool AutoSelectSmartDigEnabled;

	// Token: 0x04000B3E RID: 2878
	public bool GlobalSmartDigEnabled = true;

	// Token: 0x04000B3F RID: 2879
	public bool GlobalAimAndUseEnabled;

	// Token: 0x04000B40 RID: 2880
	private bool _currentSmartCursor;

	// Token: 0x04000B41 RID: 2881
	private bool _currentAimAndUse;

	// Token: 0x04000B42 RID: 2882
	private float _noFireDeadZone;

	// Token: 0x04000B43 RID: 2883
	private bool _currentAutoReuse;

	// Token: 0x04000B44 RID: 2884
	private Dictionary<VirtualControllerInputState.Category, bool> SmartCursorState;

	// Token: 0x04000B45 RID: 2885
	private Dictionary<VirtualControllerInputState.Category, bool> AimAndUseState;

	// Token: 0x04000B46 RID: 2886
	private Dictionary<VirtualControllerInputState.Category, float> NoFireDeadZoneState;

	// Token: 0x04000B47 RID: 2887
	public VirtualControllerInputState.Category CurrentlyBoundCategory;

	// Token: 0x02000180 RID: 384
	public enum Category
	{
		// Token: 0x04000B49 RID: 2889
		None,
		// Token: 0x04000B4A RID: 2890
		Generic,
		// Token: 0x04000B4B RID: 2891
		Axe,
		// Token: 0x04000B4C RID: 2892
		PickAxe,
		// Token: 0x04000B4D RID: 2893
		Drills,
		// Token: 0x04000B4E RID: 2894
		Chainsaw,
		// Token: 0x04000B4F RID: 2895
		Broadsword,
		// Token: 0x04000B50 RID: 2896
		NonAutoFireMeleeStab,
		// Token: 0x04000B51 RID: 2897
		NonAutoFireMeleeSwing,
		// Token: 0x04000B52 RID: 2898
		AutoFireMeleeSwing,
		// Token: 0x04000B53 RID: 2899
		AutoFireMeleeProjectile,
		// Token: 0x04000B54 RID: 2900
		AutoFireMeleeProjectileNoAim,
		// Token: 0x04000B55 RID: 2901
		Spears,
		// Token: 0x04000B56 RID: 2902
		Boomerangs,
		// Token: 0x04000B57 RID: 2903
		Flails,
		// Token: 0x04000B58 RID: 2904
		FlailsAutoSwing,
		// Token: 0x04000B59 RID: 2905
		Yoyo,
		// Token: 0x04000B5A RID: 2906
		Bow,
		// Token: 0x04000B5B RID: 2907
		AutoFireBow,
		// Token: 0x04000B5C RID: 2908
		Repeaters,
		// Token: 0x04000B5D RID: 2909
		ManualGuns,
		// Token: 0x04000B5E RID: 2910
		AutomaticGuns,
		// Token: 0x04000B5F RID: 2911
		GrapplingHooks,
		// Token: 0x04000B60 RID: 2912
		RocketConsuming,
		// Token: 0x04000B61 RID: 2913
		AutoFireRocketConsuming,
		// Token: 0x04000B62 RID: 2914
		SummoningMinion,
		// Token: 0x04000B63 RID: 2915
		SummoningSentry,
		// Token: 0x04000B64 RID: 2916
		ThrowingWeapons,
		// Token: 0x04000B65 RID: 2917
		MagicWeapons,
		// Token: 0x04000B66 RID: 2918
		AutoFireMagicWeapons,
		// Token: 0x04000B67 RID: 2919
		ControlledMagicWeapons,
		// Token: 0x04000B68 RID: 2920
		AutoFireControlledMagicWeapons,
		// Token: 0x04000B69 RID: 2921
		Torches,
		// Token: 0x04000B6A RID: 2922
		Hammer,
		// Token: 0x04000B6B RID: 2923
		PlacementSingle,
		// Token: 0x04000B6C RID: 2924
		PlacementMulti,
		// Token: 0x04000B6D RID: 2925
		PlacementMultiWalls,
		// Token: 0x04000B6E RID: 2926
		HealingPotion,
		// Token: 0x04000B6F RID: 2927
		ManaPotion,
		// Token: 0x04000B70 RID: 2928
		BuffPotion,
		// Token: 0x04000B71 RID: 2929
		FoodAndDrink,
		// Token: 0x04000B72 RID: 2930
		Flasks,
		// Token: 0x04000B73 RID: 2931
		OtherPotions,
		// Token: 0x04000B74 RID: 2932
		Seeds,
		// Token: 0x04000B75 RID: 2933
		FishingPoles,
		// Token: 0x04000B76 RID: 2934
		ExcludedAutoSwingAimUse,
		// Token: 0x04000B77 RID: 2935
		ExcludedAutoSwing,
		// Token: 0x04000B78 RID: 2936
		NonFireItems,
		// Token: 0x04000B79 RID: 2937
		HousingNPC,
		// Token: 0x04000B7A RID: 2938
		AutoFireMeleeStab,
		// Token: 0x04000B7B RID: 2939
		MiscPlace,
		// Token: 0x04000B7C RID: 2940
		MiscPlaceWalls,
		// Token: 0x04000B7D RID: 2941
		MiscBreak,
		// Token: 0x04000B7E RID: 2942
		Instrument,
		// Token: 0x04000B7F RID: 2943
		GolfClubs,
		// Token: 0x04000B80 RID: 2944
		SummoningWhip,
		// Token: 0x04000B81 RID: 2945
		Glowsticks,
		// Token: 0x04000B82 RID: 2946
		Count
	}

	// Token: 0x02000181 RID: 385
	public struct CaterogryEntry
	{
		// Token: 0x04000B83 RID: 2947
		private ItemID item;

		// Token: 0x04000B84 RID: 2948
		private VirtualControllerInputState.Category category;
	}

	// Token: 0x02000182 RID: 386
	public enum CursorInputMode
	{
		// Token: 0x04000B86 RID: 2950
		Item,
		// Token: 0x04000B87 RID: 2951
		Global,
		// Token: 0x04000B88 RID: 2952
		Disabled,
		// Token: 0x04000B89 RID: 2953
		AlwaysOn
	}

	// Token: 0x02000183 RID: 387
	[CompilerGenerated]
	[Serializable]
	private sealed class <>c
	{
		// Token: 0x06000AFA RID: 2810 RVA: 0x00037634 File Offset: 0x00035834
		// Note: this type is marked as 'beforefieldinit'.
		static <>c()
		{
		}

		// Token: 0x06000AFB RID: 2811 RVA: 0x00037644 File Offset: 0x00035844
		public <>c()
		{
		}

		// Token: 0x06000AFC RID: 2812 RVA: 0x00037658 File Offset: 0x00035858
		internal bool <SetupLookups>b__3_0(FieldInfo f)
		{
			bool flag;
			return flag;
		}

		// Token: 0x06000AFD RID: 2813 RVA: 0x00037668 File Offset: 0x00035868
		internal void <SetupLookups>b__3_1(FieldInfo field)
		{
			if (field == null || field != null)
			{
				return;
			}
			throw new ArrayTypeMismatchException();
		}

		// Token: 0x04000B8A RID: 2954
		public static readonly VirtualControllerInputState.<>c <>9;

		// Token: 0x04000B8B RID: 2955
		public static Func<FieldInfo, bool> <>9__3_0;

		// Token: 0x04000B8C RID: 2956
		public static Action<FieldInfo> <>9__3_1;
	}
}
