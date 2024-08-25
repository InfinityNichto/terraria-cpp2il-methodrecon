using System;
using System.Collections.Generic;

namespace Terraria.GameInput
{
	// Token: 0x020006CD RID: 1741
	public class PlayerInputProfile
	{
		// Token: 0x17000714 RID: 1812
		// (get) Token: 0x060039ED RID: 14829 RVA: 0x0022F564 File Offset: 0x0022D764
		public string ShowName
		{
			get
			{
				return this.Name;
			}
		}

		// Token: 0x17000715 RID: 1813
		// (get) Token: 0x060039EE RID: 14830 RVA: 0x0022F578 File Offset: 0x0022D778
		public bool HotbarAllowsRadial
		{
			get
			{
				/*
An exception occurred when decompiling this method (060039EE)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean Terraria.GameInput.PlayerInputProfile::get_HotbarAllowsRadial()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:int32(var_0_06, ldfld:int32(PlayerInputProfile::HotbarRadialHoldTimeRequired, ldloc:PlayerInputProfile(this)))
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

		// Token: 0x060039EF RID: 14831 RVA: 0x0022F58C File Offset: 0x0022D78C
		public PlayerInputProfile(string name)
		{
			this.Name = name;
		}

		// Token: 0x060039F0 RID: 14832 RVA: 0x0022F5C8 File Offset: 0x0022D7C8
		public void Initialize(PresetProfiles style)
		{
			Dictionary<InputMode, KeyConfiguration> inputModes = this.InputModes;
			if (!true)
			{
			}
		}

		// Token: 0x060039F1 RID: 14833 RVA: 0x0022F5F4 File Offset: 0x0022D7F4
		public void CopyGameplaySettingsFrom(PlayerInputProfile profile, InputMode mode)
		{
		}

		// Token: 0x060039F2 RID: 14834 RVA: 0x0022F604 File Offset: 0x0022D804
		public void CopyHotbarSettingsFrom(PlayerInputProfile profile, InputMode mode)
		{
		}

		// Token: 0x060039F3 RID: 14835 RVA: 0x0022F614 File Offset: 0x0022D814
		public void CopyMapSettingsFrom(PlayerInputProfile profile, InputMode mode)
		{
		}

		// Token: 0x060039F4 RID: 14836 RVA: 0x0022F624 File Offset: 0x0022D824
		public void CopyGamepadSettingsFrom(PlayerInputProfile profile, InputMode mode)
		{
		}

		// Token: 0x060039F5 RID: 14837 RVA: 0x0022F634 File Offset: 0x0022D834
		public void CopyGamepadAdvancedSettingsFrom(PlayerInputProfile profile, InputMode mode)
		{
			float rightThumbstickDeadzoneX = profile.RightThumbstickDeadzoneX;
			this.RightThumbstickDeadzoneX = rightThumbstickDeadzoneX;
			float rightThumbstickDeadzoneY = profile.RightThumbstickDeadzoneY;
			this.RightThumbstickDeadzoneY = rightThumbstickDeadzoneY;
			bool leftThumbstickInvertX = profile.LeftThumbstickInvertX;
			this.LeftThumbstickInvertX = leftThumbstickInvertX;
			bool leftThumbstickInvertY = profile.LeftThumbstickInvertY;
			this.LeftThumbstickInvertY = leftThumbstickInvertY;
			bool rightThumbstickInvertX = profile.RightThumbstickInvertX;
			this.RightThumbstickInvertX = rightThumbstickInvertX;
			bool rightThumbstickInvertY = profile.RightThumbstickInvertY;
			this.RightThumbstickInvertY = rightThumbstickInvertY;
			int inventoryMoveCD = profile.InventoryMoveCD;
			this.InventoryMoveCD = inventoryMoveCD;
		}

		// Token: 0x060039F6 RID: 14838 RVA: 0x0022F6AC File Offset: 0x0022D8AC
		private void CopyKeysFrom(PlayerInputProfile profile, InputMode mode, TriggerNames[] keysToCopy)
		{
			int[] buckets = profile.InputModes._buckets;
			int[] buckets2 = this.InputModes._buckets;
			long num = 0L;
			Array.Clear(buckets2, (int)num, 0);
			int[] buckets3 = this.InputModes._buckets;
		}

		// Token: 0x060039F7 RID: 14839 RVA: 0x0022F6F0 File Offset: 0x0022D8F0
		public bool UsingDpadHotbar()
		{
			/*
An exception occurred when decompiling this method (060039F7)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean Terraria.GameInput.PlayerInputProfile::UsingDpadHotbar()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:int32[](var_0_0B, ldfld:int32[](Dictionary`2::_buckets, ldfld:class [mscorlib]System.Collections.Generic.Dictionary`2<valuetype Terraria.GameInput.InputMode, class Terraria.GameInput.KeyConfiguration>[exp:Dictionary`2](PlayerInputProfile::InputModes, ldloc:PlayerInputProfile(this))))
	stloc:int32[](var_2_17, ldfld:int32[](Dictionary`2::_buckets, ldfld:class [mscorlib]System.Collections.Generic.Dictionary`2<valuetype Terraria.GameInput.InputMode, class Terraria.GameInput.KeyConfiguration>[exp:Dictionary`2](PlayerInputProfile::InputModes, ldloc:PlayerInputProfile(this))))
	stloc:int32[](var_4_23, ldfld:int32[](Dictionary`2::_buckets, ldfld:class [mscorlib]System.Collections.Generic.Dictionary`2<valuetype Terraria.GameInput.InputMode, class Terraria.GameInput.KeyConfiguration>[exp:Dictionary`2](PlayerInputProfile::InputModes, ldloc:PlayerInputProfile(this))))
	stloc:int32[](var_6_30, ldfld:int32[](Dictionary`2::_buckets, ldfld:class [mscorlib]System.Collections.Generic.Dictionary`2<valuetype Terraria.GameInput.InputMode, class Terraria.GameInput.KeyConfiguration>[exp:Dictionary`2](PlayerInputProfile::InputModes, ldloc:PlayerInputProfile(this))))
	stloc:int32[](var_8_3D, ldfld:int32[](Dictionary`2::_buckets, ldfld:class [mscorlib]System.Collections.Generic.Dictionary`2<valuetype Terraria.GameInput.InputMode, class Terraria.GameInput.KeyConfiguration>[exp:Dictionary`2](PlayerInputProfile::InputModes, ldloc:PlayerInputProfile(this))))
	stloc:int32[](var_10_4A, ldfld:int32[](Dictionary`2::_buckets, ldfld:class [mscorlib]System.Collections.Generic.Dictionary`2<valuetype Terraria.GameInput.InputMode, class Terraria.GameInput.KeyConfiguration>[exp:Dictionary`2](PlayerInputProfile::InputModes, ldloc:PlayerInputProfile(this))))
	stloc:int32[](var_12_57, ldfld:int32[](Dictionary`2::_buckets, ldfld:class [mscorlib]System.Collections.Generic.Dictionary`2<valuetype Terraria.GameInput.InputMode, class Terraria.GameInput.KeyConfiguration>[exp:Dictionary`2](PlayerInputProfile::InputModes, ldloc:PlayerInputProfile(this))))
	stloc:int32[](var_14_64, ldfld:int32[](Dictionary`2::_buckets, ldfld:class [mscorlib]System.Collections.Generic.Dictionary`2<valuetype Terraria.GameInput.InputMode, class Terraria.GameInput.KeyConfiguration>[exp:Dictionary`2](PlayerInputProfile::InputModes, ldloc:PlayerInputProfile(this))))
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

		// Token: 0x060039F8 RID: 14840 RVA: 0x0022F768 File Offset: 0x0022D968
		public bool UsingDpadMovekeys()
		{
			/*
An exception occurred when decompiling this method (060039F8)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean Terraria.GameInput.PlayerInputProfile::UsingDpadMovekeys()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:int32[](var_0_0B, ldfld:int32[](Dictionary`2::_buckets, ldfld:class [mscorlib]System.Collections.Generic.Dictionary`2<valuetype Terraria.GameInput.InputMode, class Terraria.GameInput.KeyConfiguration>[exp:Dictionary`2](PlayerInputProfile::InputModes, ldloc:PlayerInputProfile(this))))
	stloc:int32[](var_2_17, ldfld:int32[](Dictionary`2::_buckets, ldfld:class [mscorlib]System.Collections.Generic.Dictionary`2<valuetype Terraria.GameInput.InputMode, class Terraria.GameInput.KeyConfiguration>[exp:Dictionary`2](PlayerInputProfile::InputModes, ldloc:PlayerInputProfile(this))))
	stloc:int32[](var_4_23, ldfld:int32[](Dictionary`2::_buckets, ldfld:class [mscorlib]System.Collections.Generic.Dictionary`2<valuetype Terraria.GameInput.InputMode, class Terraria.GameInput.KeyConfiguration>[exp:Dictionary`2](PlayerInputProfile::InputModes, ldloc:PlayerInputProfile(this))))
	stloc:int32[](var_6_30, ldfld:int32[](Dictionary`2::_buckets, ldfld:class [mscorlib]System.Collections.Generic.Dictionary`2<valuetype Terraria.GameInput.InputMode, class Terraria.GameInput.KeyConfiguration>[exp:Dictionary`2](PlayerInputProfile::InputModes, ldloc:PlayerInputProfile(this))))
	stloc:int32[](var_8_3D, ldfld:int32[](Dictionary`2::_buckets, ldfld:class [mscorlib]System.Collections.Generic.Dictionary`2<valuetype Terraria.GameInput.InputMode, class Terraria.GameInput.KeyConfiguration>[exp:Dictionary`2](PlayerInputProfile::InputModes, ldloc:PlayerInputProfile(this))))
	stloc:int32[](var_10_4A, ldfld:int32[](Dictionary`2::_buckets, ldfld:class [mscorlib]System.Collections.Generic.Dictionary`2<valuetype Terraria.GameInput.InputMode, class Terraria.GameInput.KeyConfiguration>[exp:Dictionary`2](PlayerInputProfile::InputModes, ldloc:PlayerInputProfile(this))))
	stloc:int32[](var_12_57, ldfld:int32[](Dictionary`2::_buckets, ldfld:class [mscorlib]System.Collections.Generic.Dictionary`2<valuetype Terraria.GameInput.InputMode, class Terraria.GameInput.KeyConfiguration>[exp:Dictionary`2](PlayerInputProfile::InputModes, ldloc:PlayerInputProfile(this))))
	stloc:int32[](var_14_64, ldfld:int32[](Dictionary`2::_buckets, ldfld:class [mscorlib]System.Collections.Generic.Dictionary`2<valuetype Terraria.GameInput.InputMode, class Terraria.GameInput.KeyConfiguration>[exp:Dictionary`2](PlayerInputProfile::InputModes, ldloc:PlayerInputProfile(this))))
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

		// Token: 0x04007A20 RID: 31264
		public Dictionary<InputMode, KeyConfiguration> InputModes;

		// Token: 0x04007A21 RID: 31265
		public string Name = "";

		// Token: 0x04007A22 RID: 31266
		public bool AllowEditting = true;

		// Token: 0x04007A23 RID: 31267
		public int HotbarRadialHoldTimeRequired = 16;

		// Token: 0x04007A24 RID: 31268
		public float TriggersDeadzone;

		// Token: 0x04007A25 RID: 31269
		public float InterfaceDeadzoneX;

		// Token: 0x04007A26 RID: 31270
		public float LeftThumbstickDeadzoneX;

		// Token: 0x04007A27 RID: 31271
		public float LeftThumbstickDeadzoneY;

		// Token: 0x04007A28 RID: 31272
		public float RightThumbstickDeadzoneX;

		// Token: 0x04007A29 RID: 31273
		public float RightThumbstickDeadzoneY;

		// Token: 0x04007A2A RID: 31274
		public bool LeftThumbstickInvertX;

		// Token: 0x04007A2B RID: 31275
		public bool LeftThumbstickInvertY;

		// Token: 0x04007A2C RID: 31276
		public bool RightThumbstickInvertX;

		// Token: 0x04007A2D RID: 31277
		public bool RightThumbstickInvertY;

		// Token: 0x04007A2E RID: 31278
		public int InventoryMoveCD = 6;
	}
}
