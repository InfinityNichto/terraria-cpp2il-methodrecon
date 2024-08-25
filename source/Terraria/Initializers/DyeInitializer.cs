using System;
using System.Runtime.CompilerServices;
using Microsoft.Xna.Framework.Graphics;
using Terraria.GameContent.Dyes;
using Terraria.Graphics.Shaders;

namespace Terraria.Initializers
{
	// Token: 0x0200058A RID: 1418
	public static class DyeInitializer
	{
		// Token: 0x06003495 RID: 13461 RVA: 0x00209C30 File Offset: 0x00207E30
		private static void LoadBasicColorDye(int baseDyeItem, int blackDyeItem, int brightDyeItem, int silverDyeItem, float r, float g, float b, float saturation = 1f, int oldShader = 1)
		{
			if (!true)
			{
			}
			ArmorShaderData armorShaderData2;
			ArmorShaderData armorShaderData = armorShaderData2.UseSaturation(saturation);
			ArmorShaderData armorShaderData4;
			ArmorShaderData armorShaderData3 = armorShaderData4.UseSaturation(saturation);
			ArmorShaderData armorShaderData6;
			ArmorShaderData armorShaderData5 = armorShaderData6.UseSaturation(saturation);
			ArmorShaderData armorShaderData8;
			ArmorShaderData armorShaderData7 = armorShaderData8.UseSaturation(saturation);
		}

		// Token: 0x06003496 RID: 13462 RVA: 0x00209C6C File Offset: 0x00207E6C
		private static void LoadBasicColorDye(int baseDyeItem, float r, float g, float b, float saturation = 1f, int oldShader = 1)
		{
		}

		// Token: 0x06003497 RID: 13463 RVA: 0x00209C7C File Offset: 0x00207E7C
		private static void LoadBasicColorDyes()
		{
		}

		// Token: 0x06003498 RID: 13464 RVA: 0x00209C8C File Offset: 0x00207E8C
		private static void LoadArmorDyes()
		{
			if (!true)
			{
			}
			DyeInitializer.LoadBasicColorDyes();
			if (!true)
			{
			}
			string text2;
			string text = "Images/Extra_" + text2;
			DyeInitializer.FixRecipes();
		}

		// Token: 0x06003499 RID: 13465 RVA: 0x00209CB8 File Offset: 0x00207EB8
		private static void LoadHairDyes()
		{
			if (!true)
			{
			}
			DyeInitializer.LoadLegacyHairdyes();
			if (!true)
			{
			}
			TwilightHairDyeShaderData twilightHairDyeShaderData;
			HairShaderData hairShaderData = twilightHairDyeShaderData.UseImage("Images/Misc/noise");
		}

		// Token: 0x0600349A RID: 13466 RVA: 0x00209CDC File Offset: 0x00207EDC
		private static void LoadLegacyHairdyes()
		{
			if (!true)
			{
			}
			if (!true)
			{
			}
			if (!true)
			{
			}
			if (!true)
			{
			}
			if (1073741824 == 0)
			{
			}
			if (1073741824 == 0)
			{
			}
			if (1073741824 == 0)
			{
			}
			if (1073741824 == 0)
			{
			}
			if (1073741824 == 0)
			{
			}
		}

		// Token: 0x0600349B RID: 13467 RVA: 0x00209D18 File Offset: 0x00207F18
		private static void LoadMisc()
		{
			if ("Only TraceListeners can be added to a TraceListenerCollection." == null)
			{
			}
			string text2;
			string text = "Images/Extra_" + text2;
			string text4;
			string text3 = "Images/Extra_" + text4;
			string text6;
			string text5 = "Images/Extra_" + text6;
			string text8;
			string text7 = "Images/Extra_" + text8;
			MiscShaderData miscShaderData2;
			MiscShaderData miscShaderData = miscShaderData2.UseImage2(text7);
			string text10;
			string text9 = "Images/Extra_" + text10;
			MiscShaderData miscShaderData3 = miscShaderData2.UseImage1(text9);
		}

		// Token: 0x0600349C RID: 13468 RVA: 0x00209DA8 File Offset: 0x00207FA8
		private static void LoadMiscVertexShaders()
		{
			if (!true)
			{
			}
			string text2;
			string text = "Images/Extra_" + text2;
			string text4;
			string text3 = "Images/Extra_" + text4;
			MiscShaderData miscShaderData2;
			MiscShaderData miscShaderData = miscShaderData2.UseImage1(text3);
			string text6;
			string text5 = "Images/Extra_" + text6;
			MiscShaderData miscShaderData3 = miscShaderData.UseImage2(text5);
			string text8;
			string text7 = "Images/Extra_" + text8;
			MiscShaderData miscShaderData4 = miscShaderData.UseImage0(text7);
			string text10;
			string text9 = "Images/Extra_" + text10;
			MiscShaderData miscShaderData5 = miscShaderData4.UseImage1(text9);
			string text12;
			string text11 = "Images/Extra_" + text12;
			MiscShaderData miscShaderData6 = miscShaderData5.UseImage2(text11);
			string text14;
			string text13 = "Images/Extra_" + text14;
			MiscShaderData miscShaderData7 = miscShaderData5.UseImage0(text13);
			string text16;
			string text15 = "Images/Extra_" + text16;
			MiscShaderData miscShaderData8 = miscShaderData7.UseImage1(text15);
			string text18;
			string text17 = "Images/Extra_" + text18;
			MiscShaderData miscShaderData9 = miscShaderData8.UseImage2(text17);
			string text20;
			string text19 = "Images/Extra_" + text20;
			MiscShaderData miscShaderData10 = miscShaderData8.UseImage0(text19);
			string text22;
			string text21 = "Images/Extra_" + text22;
			MiscShaderData miscShaderData11 = miscShaderData10.UseImage1(text21);
			string text24;
			string text23 = "Images/Extra_" + text24;
			MiscShaderData miscShaderData12 = miscShaderData10.UseImage0(text23);
			string text26;
			string text25 = "Images/Extra_" + text26;
			MiscShaderData miscShaderData13 = miscShaderData12.UseImage1(text25);
			string text27;
			MiscShaderData miscShaderData14 = miscShaderData12.UseImage0(text27);
			string text29;
			string text28 = "Images/Extra_" + text29;
			MiscShaderData miscShaderData15 = miscShaderData14.UseImage1(text28);
			string text31;
			string text30 = "Images/Extra_" + text31;
			MiscShaderData miscShaderData16 = miscShaderData15.UseImage2(text30);
		}

		// Token: 0x0600349D RID: 13469 RVA: 0x00209F2C File Offset: 0x0020812C
		public static void Load()
		{
			DyeInitializer.LoadArmorDyes();
			DyeInitializer.LoadHairDyes();
			DyeInitializer.LoadMisc();
		}

		// Token: 0x0600349E RID: 13470 RVA: 0x00209F48 File Offset: 0x00208148
		private static void FixRecipes()
		{
			if (!true)
			{
			}
		}

		// Token: 0x0200058B RID: 1419
		[CompilerGenerated]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x0600349F RID: 13471 RVA: 0x00209F60 File Offset: 0x00208160
			// Note: this type is marked as 'beforefieldinit'.
			static <>c()
			{
			}

			// Token: 0x060034A0 RID: 13472 RVA: 0x00209F70 File Offset: 0x00208170
			public <>c()
			{
			}

			// Token: 0x060034A1 RID: 13473 RVA: 0x00209F84 File Offset: 0x00208184
			internal Color <LoadLegacyHairdyes>b__5_0(Player player, Color newColor, bool lighting)
			{
				int statLife = player.statLife;
				int statLifeMax = player.statLifeMax2;
				return 17259;
			}

			// Token: 0x060034A2 RID: 13474 RVA: 0x00209FA4 File Offset: 0x002081A4
			internal Color <LoadLegacyHairdyes>b__5_1(Player player, Color newColor, bool lighting)
			{
				int statMana = player.statMana;
				int statManaMax = player.statManaMax2;
				return 17046;
			}

			// Token: 0x060034A3 RID: 13475 RVA: 0x00209FC4 File Offset: 0x002081C4
			internal Color <LoadLegacyHairdyes>b__5_2(Player player, Color newColor, bool lighting)
			{
				/*
An exception occurred when decompiling this method (060034A3)

ICSharpCode.Decompiler.DecompilerException: Error decompiling Microsoft.Xna.Framework.Graphics.Color Terraria.Initializers.DyeInitializer/<>c::<LoadLegacyHairdyes>b__5_2(Terraria.Player,Microsoft.Xna.Framework.Graphics.Color,System.Boolean)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0003:
	stloc:Vector2(var_0_09, callgetter:Vector2(Entity::get_Center, ldloc:Player[exp:Entity](player)))
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

			// Token: 0x060034A4 RID: 13476 RVA: 0x00209FFC File Offset: 0x002081FC
			internal Color <LoadLegacyHairdyes>b__5_3(Player player, Color newColor, bool lighting)
			{
				/*
An exception occurred when decompiling this method (060034A4)

ICSharpCode.Decompiler.DecompilerException: Error decompiling Microsoft.Xna.Framework.Graphics.Color Terraria.Initializers.DyeInitializer/<>c::<LoadLegacyHairdyes>b__5_3(Terraria.Player,Microsoft.Xna.Framework.Graphics.Color,System.Boolean)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:class Terraria.Item[](var_0_06, ldfld:class Terraria.Item[](Player::inventory, ldloc:Player(player)))
	stloc:int32(var_4_13, ldc.i4:int32(5))
	stloc:int64(var_5_16, ldc.i4:int64(0))
	stloc:int64(var_6_19, ldc.i4:int64(0))
	stloc:int64(var_7_1C, ldc.i4:int64(0))
	stloc:int32(var_8_2B, call:int32(Item::buyPrice, ldloc:int64[exp:int32](var_5_16), ldloc:int32(var_4_13), ldloc:int64[exp:int32](var_6_19), ldloc:int64[exp:int32](var_7_1C)))
	stloc:int32(var_9_2F, ldc.i4:int32(50))
	stloc:int64(var_10_32, ldc.i4:int64(0))
	stloc:int64(var_11_35, ldc.i4:int64(0))
	stloc:int64(var_12_38, ldc.i4:int64(0))
	stloc:int32(var_13_47, call:int32(Item::buyPrice, ldloc:int64[exp:int32](var_10_32), ldloc:int32(var_9_2F), ldloc:int64[exp:int32](var_11_35), ldloc:int64[exp:int32](var_12_38)))
	stloc:int32(var_14_4A, ldc.i4:int32(2))
	stloc:int64(var_15_4D, ldc.i4:int64(0))
	stloc:int64(var_16_50, ldc.i4:int64(0))
	stloc:int64(var_17_53, ldc.i4:int64(0))
	stloc:int32(var_18_62, call:int32(Item::buyPrice, ldloc:int32(var_14_4A), ldloc:int64[exp:int32](var_15_4D), ldloc:int64[exp:int32](var_16_50), ldloc:int64[exp:int32](var_17_53)))
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

			// Token: 0x060034A5 RID: 13477 RVA: 0x0020A0B8 File Offset: 0x002082B8
			internal Color <LoadLegacyHairdyes>b__5_4(Player player, Color newColor, bool lighting)
			{
				/*
An exception occurred when decompiling this method (060034A5)

ICSharpCode.Decompiler.DecompilerException: Error decompiling Microsoft.Xna.Framework.Graphics.Color Terraria.Initializers.DyeInitializer/<>c::<LoadLegacyHairdyes>b__5_4(Terraria.Player,Microsoft.Xna.Framework.Graphics.Color,System.Boolean)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	brtrue(IL_0000, ldc.i4:bool(1))
}

   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1852
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1878
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1878
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1846
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

			// Token: 0x060034A6 RID: 13478 RVA: 0x0020A0CC File Offset: 0x002082CC
			internal Color <LoadLegacyHairdyes>b__5_5(Player player, Color newColor, bool lighting)
			{
				/*
An exception occurred when decompiling this method (060034A6)

ICSharpCode.Decompiler.DecompilerException: Error decompiling Microsoft.Xna.Framework.Graphics.Color Terraria.Initializers.DyeInitializer/<>c::<LoadLegacyHairdyes>b__5_5(Terraria.Player,Microsoft.Xna.Framework.Graphics.Color,System.Boolean)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0000:
	stloc:int32(var_0_01, ldc.i4:int32(1))
	stloc:int32(var_1_08, ldfld:int32(Player::team, ldloc:Player(player)))
	brtrue(IL_0000, ldloc:int32[exp:bool](var_0_01))
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

			// Token: 0x060034A7 RID: 13479 RVA: 0x0020A0E4 File Offset: 0x002082E4
			internal Color <LoadLegacyHairdyes>b__5_6(Player player, Color newColor, bool lighting)
			{
				/*
An exception occurred when decompiling this method (060034A7)

ICSharpCode.Decompiler.DecompilerException: Error decompiling Microsoft.Xna.Framework.Graphics.Color Terraria.Initializers.DyeInitializer/<>c::<LoadLegacyHairdyes>b__5_6(Terraria.Player,Microsoft.Xna.Framework.Graphics.Color,System.Boolean)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0000:
	stloc:bool(var_0_06, callgetter:bool(Player::get_ZoneShimmer, ldloc:Player(player)))
	stloc:int32(var_3_11, callgetter:int32(Main::get_waterStyle))
	stloc:int32(var_5_1A, callgetter:int32(Main::get_waterStyle))
	stloc:int32(var_7_24, callgetter:int32(Main::get_waterStyle))
	stloc:int32(var_9_2E, callgetter:int32(Main::get_waterStyle))
	stloc:int32(var_11_38, callgetter:int32(Main::get_waterStyle))
	stloc:int32(var_13_42, callgetter:int32(Main::get_waterStyle))
	stloc:int32(var_15_4C, callgetter:int32(Main::get_waterStyle))
	stloc:int32(var_17_56, callgetter:int32(Main::get_waterStyle))
	stloc:int32(var_19_60, callgetter:int32(Main::get_waterStyle))
	stloc:int32(var_21_6A, callgetter:int32(Main::get_waterStyle))
	stloc:int32(var_23_74, callgetter:int32(Main::get_waterStyle))
	brtrue(IL_0000, logicnot:bool(ldfld:Color[exp:bool](Player::hairDyeColor, ldloc:Player(player))))
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

			// Token: 0x060034A8 RID: 13480 RVA: 0x0020A180 File Offset: 0x00208380
			internal Color <LoadLegacyHairdyes>b__5_7(Player player, Color newColor, bool lighting)
			{
				Color color;
				return color;
			}

			// Token: 0x060034A9 RID: 13481 RVA: 0x0020A190 File Offset: 0x00208390
			internal Color <LoadLegacyHairdyes>b__5_8(Player player, Color newColor, bool lighting)
			{
				if (!true)
				{
				}
				return 1;
			}

			// Token: 0x060034AA RID: 13482 RVA: 0x0020A1A4 File Offset: 0x002083A4
			internal Color <LoadLegacyHairdyes>b__5_9(Player player, Color newColor, bool lighting)
			{
				float x = player.velocity.X;
				if (!true)
				{
				}
				float y = player.velocity.Y;
				byte r = player.hairColor.R;
				byte g = player.hairColor.G;
				byte b = player.hairColor.B;
				return 17046;
			}

			// Token: 0x060034AB RID: 13483 RVA: 0x0020A1F8 File Offset: 0x002083F8
			internal Color <LoadLegacyHairdyes>b__5_10(Player player, Color newColor, bool lighting)
			{
				int width = player.width;
				bool wet = player.wet;
				float x = player.position.X;
				float y = player.position.Y;
				if (16304 == 0)
				{
					return;
				}
			}

			// Token: 0x0400415D RID: 16733
			public static readonly DyeInitializer.<>c <>9;

			// Token: 0x0400415E RID: 16734
			public static LegacyHairShaderData.ColorProcessingMethod <>9__5_0;

			// Token: 0x0400415F RID: 16735
			public static LegacyHairShaderData.ColorProcessingMethod <>9__5_1;

			// Token: 0x04004160 RID: 16736
			public static LegacyHairShaderData.ColorProcessingMethod <>9__5_2;

			// Token: 0x04004161 RID: 16737
			public static LegacyHairShaderData.ColorProcessingMethod <>9__5_3;

			// Token: 0x04004162 RID: 16738
			public static LegacyHairShaderData.ColorProcessingMethod <>9__5_4;

			// Token: 0x04004163 RID: 16739
			public static LegacyHairShaderData.ColorProcessingMethod <>9__5_5;

			// Token: 0x04004164 RID: 16740
			public static LegacyHairShaderData.ColorProcessingMethod <>9__5_6;

			// Token: 0x04004165 RID: 16741
			public static LegacyHairShaderData.ColorProcessingMethod <>9__5_7;

			// Token: 0x04004166 RID: 16742
			public static LegacyHairShaderData.ColorProcessingMethod <>9__5_8;

			// Token: 0x04004167 RID: 16743
			public static LegacyHairShaderData.ColorProcessingMethod <>9__5_9;

			// Token: 0x04004168 RID: 16744
			public static LegacyHairShaderData.ColorProcessingMethod <>9__5_10;
		}
	}
}
