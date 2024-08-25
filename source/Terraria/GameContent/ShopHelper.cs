using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Xna.Framework;
using Terraria.GameContent.Personalities;
using Terraria.Localization;

namespace Terraria.GameContent
{
	// Token: 0x020007EE RID: 2030
	public class ShopHelper
	{
		// Token: 0x0600412A RID: 16682 RVA: 0x00244C90 File Offset: 0x00242E90
		public ShopHelper()
		{
			PersonalityDatabase database = this._database;
		}

		// Token: 0x0600412B RID: 16683 RVA: 0x00244CB0 File Offset: 0x00242EB0
		public ShoppingSettings GetShoppingSettings(Player player, NPC npc)
		{
			/*
An exception occurred when decompiling this method (0600412B)

ICSharpCode.Decompiler.DecompilerException: Error decompiling Terraria.ShoppingSettings Terraria.GameContent.ShopHelper::GetShoppingSettings(Terraria.Player,Terraria.NPC)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stfld:NPC(ShopHelper::_currentNPCBeingTalkedTo, ldloc:ShopHelper(this), ldloc:NPC(npc))
	stfld:Player(ShopHelper::_currentPlayerTalking, ldloc:ShopHelper(this), ldloc:Player(player))
	call:void(ShopHelper::ProcessMood, ldloc:ShopHelper(this), ldloc:Player(player), ldloc:NPC(npc))
	stloc:float32(var_0_1C, ldfld:float32(ShopHelper::_currentPriceAdjustment, ldloc:ShopHelper(this)))
	stloc:string(var_1_23, ldfld:string(ShopHelper::_currentHappiness, ldloc:ShopHelper(this)))
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

		// Token: 0x0600412C RID: 16684 RVA: 0x00244CE0 File Offset: 0x00242EE0
		private float GetSkeletonMerchantPrices(NPC npc)
		{
			/*
An exception occurred when decompiling this method (0600412C)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Single Terraria.GameContent.ShopHelper::GetSkeletonMerchantPrices(Terraria.NPC)

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

		// Token: 0x0600412D RID: 16685 RVA: 0x00244CF0 File Offset: 0x00242EF0
		private float GetTravelingMerchantPrices(NPC npc)
		{
			/*
An exception occurred when decompiling this method (0600412D)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Single Terraria.GameContent.ShopHelper::GetTravelingMerchantPrices(Terraria.NPC)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_000F:
	stloc:int32(var_4_16, callgetter:int32(Main::get_spawnTileX))
	stloc:int32(var_6_20, callgetter:int32(Main::get_spawnTileY))
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

		// Token: 0x0600412E RID: 16686 RVA: 0x00244D24 File Offset: 0x00242F24
		private void ProcessMood(Player player, NPC npc)
		{
			int num = 16256;
			this._currentHappiness = "";
			this._currentPriceAdjustment = (float)num;
			if ("" == null)
			{
			}
			if ("" == null)
			{
				int type = npc.type;
				int num2 = 16256;
				this._currentPriceAdjustment = (float)num2;
				return;
			}
		}

		// Token: 0x0600412F RID: 16687 RVA: 0x00244EB0 File Offset: 0x002430B0
		private float LimitAndRoundMultiplier(float priceAdjustment)
		{
			/*
An exception occurred when decompiling this method (0600412F)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Single Terraria.GameContent.ShopHelper::LimitAndRoundMultiplier(System.Single)

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

		// Token: 0x06004130 RID: 16688 RVA: 0x00244EC0 File Offset: 0x002430C0
		private static string BiomeNameByKey(string biomeNameKey)
		{
			return Language.GetTextValue("TownNPCMoodBiomes." + biomeNameKey);
		}

		// Token: 0x06004131 RID: 16689 RVA: 0x00244EE0 File Offset: 0x002430E0
		private void AddHappinessReportText(string textKeyInCategory, [Optional] object substitutes)
		{
			if (!true)
			{
			}
			string text;
			string textValueWith = Language.GetTextValueWith("TownNPCMood_" + text + "Transformed" + "." + textKeyInCategory, substitutes);
			string text2 = textValueWith + textValueWith + " ";
		}

		// Token: 0x06004132 RID: 16690 RVA: 0x00244F24 File Offset: 0x00243124
		public void LikeBiome(string nameKey)
		{
			string text = ShopHelper.BiomeNameByKey(nameKey);
			float currentPriceAdjustment = this._currentPriceAdjustment;
			this._currentPriceAdjustment = currentPriceAdjustment;
		}

		// Token: 0x06004133 RID: 16691 RVA: 0x00244F48 File Offset: 0x00243148
		public void LoveBiome(string nameKey)
		{
			string text = ShopHelper.BiomeNameByKey(nameKey);
		}

		// Token: 0x06004134 RID: 16692 RVA: 0x00244F5C File Offset: 0x0024315C
		public void DislikeBiome(string nameKey)
		{
			string text = ShopHelper.BiomeNameByKey(nameKey);
			float currentPriceAdjustment = this._currentPriceAdjustment;
			this._currentPriceAdjustment = currentPriceAdjustment;
		}

		// Token: 0x06004135 RID: 16693 RVA: 0x00244F80 File Offset: 0x00243180
		public void HateBiome(string nameKey)
		{
			string text = ShopHelper.BiomeNameByKey(nameKey);
			float currentPriceAdjustment = this._currentPriceAdjustment;
			this._currentPriceAdjustment = currentPriceAdjustment;
		}

		// Token: 0x06004136 RID: 16694 RVA: 0x00244FA4 File Offset: 0x002431A4
		public void LikeNPC(int npcType)
		{
			if (!true)
			{
			}
			string fullnameByID = NPC.GetFullnameByID(npcType);
			float currentPriceAdjustment = this._currentPriceAdjustment;
			this._currentPriceAdjustment = currentPriceAdjustment;
		}

		// Token: 0x06004137 RID: 16695 RVA: 0x00244FCC File Offset: 0x002431CC
		public void LoveNPCByTypeName(int npcType)
		{
			if (!true)
			{
			}
			string text2;
			string text = "LoveNPC_" + text2;
			string fullnameByID = NPC.GetFullnameByID(npcType);
			float currentPriceAdjustment = this._currentPriceAdjustment;
			this._currentPriceAdjustment = currentPriceAdjustment;
		}

		// Token: 0x06004138 RID: 16696 RVA: 0x00245000 File Offset: 0x00243200
		public void LikePrincess()
		{
			if (!true)
			{
			}
			string fullnameByID = NPC.GetFullnameByID(663);
			float currentPriceAdjustment = this._currentPriceAdjustment;
			this._currentPriceAdjustment = currentPriceAdjustment;
		}

		// Token: 0x06004139 RID: 16697 RVA: 0x0024502C File Offset: 0x0024322C
		public void LoveNPC(int npcType)
		{
			if (!true)
			{
			}
			string fullnameByID = NPC.GetFullnameByID(npcType);
			float currentPriceAdjustment = this._currentPriceAdjustment;
			this._currentPriceAdjustment = currentPriceAdjustment;
		}

		// Token: 0x0600413A RID: 16698 RVA: 0x00245054 File Offset: 0x00243254
		public void DislikeNPC(int npcType)
		{
			if (!true)
			{
			}
			string fullnameByID = NPC.GetFullnameByID(npcType);
			float currentPriceAdjustment = this._currentPriceAdjustment;
			this._currentPriceAdjustment = currentPriceAdjustment;
		}

		// Token: 0x0600413B RID: 16699 RVA: 0x0024507C File Offset: 0x0024327C
		public void HateNPC(int npcType)
		{
			if (!true)
			{
			}
			string fullnameByID = NPC.GetFullnameByID(npcType);
			float currentPriceAdjustment = this._currentPriceAdjustment;
			this._currentPriceAdjustment = currentPriceAdjustment;
		}

		// Token: 0x0600413C RID: 16700 RVA: 0x002450A4 File Offset: 0x002432A4
		private List<NPC> GetNearbyResidentNPCs(NPC npc, [Out] int npcsWithinHouse, [Out] int npcsWithinVillage)
		{
			int whoAmI;
			do
			{
				int homeTileX = npc.homeTileX;
				int homeTileY = npc.homeTileY;
				if (npc.homeless)
				{
					Vector2 center = npc.Center;
				}
				whoAmI = npc.whoAmI;
				if (whoAmI == 0)
				{
				}
			}
			while (whoAmI == 0 || whoAmI == 0);
			if (whoAmI == 0)
			{
			}
			if (whoAmI != 0)
			{
				if (whoAmI == 0)
				{
				}
			}
			if (whoAmI == 0)
			{
				return;
			}
		}

		// Token: 0x0600413D RID: 16701 RVA: 0x002450FC File Offset: 0x002432FC
		private bool RuinMoodIfHomeless(NPC npc)
		{
			if (npc.homeless)
			{
				long num = 0L;
				this.AddHappinessReportText("NoHome", num);
				bool homeless = npc.homeless;
				return;
			}
		}

		// Token: 0x0600413E RID: 16702 RVA: 0x00245128 File Offset: 0x00243328
		private bool IsFarFromHome(NPC npc)
		{
			int homeTileX = npc.homeTileX;
			int homeTileY = npc.homeTileY;
			Vector2 center = npc.Center;
			Vector2 center2 = npc.Center;
			if (15744 == 0)
			{
			}
			long num = 0L;
			this.AddHappinessReportText("FarFromHome", num);
			return true;
		}

		// Token: 0x0600413F RID: 16703 RVA: 0x00245170 File Offset: 0x00243370
		private bool IsPlayerInEvilBiomes(Player player)
		{
			/*
An exception occurred when decompiling this method (0600413F)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean Terraria.GameContent.ShopHelper::IsPlayerInEvilBiomes(Terraria.Player)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:class Terraria.GameContent.Personalities.AShoppingBiome[](var_0_06, ldfld:class Terraria.GameContent.Personalities.AShoppingBiome[](ShopHelper::_dangerousBiomes, ldloc:ShopHelper(this)))
	stloc:class Terraria.GameContent.Personalities.AShoppingBiome[](var_2_0F, ldfld:class Terraria.GameContent.Personalities.AShoppingBiome[](ShopHelper::_dangerousBiomes, ldloc:ShopHelper(this)))
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

		// Token: 0x06004140 RID: 16704 RVA: 0x00245194 File Offset: 0x00243394
		private bool IsNotReallyTownNPC(NPC npc)
		{
			int type = npc.type;
			return true;
		}

		// Token: 0x04007EDF RID: 32479
		public const float LowestPossiblePriceMultiplier = 0.75f;

		// Token: 0x04007EE0 RID: 32480
		public const float MaxHappinessAchievementPriceMultiplier = 0.82f;

		// Token: 0x04007EE1 RID: 32481
		public const float HighestPossiblePriceMultiplier = 1.5f;

		// Token: 0x04007EE2 RID: 32482
		private string _currentHappiness;

		// Token: 0x04007EE3 RID: 32483
		private float _currentPriceAdjustment;

		// Token: 0x04007EE4 RID: 32484
		private NPC _currentNPCBeingTalkedTo;

		// Token: 0x04007EE5 RID: 32485
		private Player _currentPlayerTalking;

		// Token: 0x04007EE6 RID: 32486
		private PersonalityDatabase _database;

		// Token: 0x04007EE7 RID: 32487
		private AShoppingBiome[] _dangerousBiomes;

		// Token: 0x04007EE8 RID: 32488
		private const float likeValue = 0.94f;

		// Token: 0x04007EE9 RID: 32489
		private const float dislikeValue = 1.06f;

		// Token: 0x04007EEA RID: 32490
		private const float loveValue = 0.88f;

		// Token: 0x04007EEB RID: 32491
		private const float hateValue = 1.12f;
	}
}
