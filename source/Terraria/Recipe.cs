using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Microsoft.Xna.Framework;
using Terraria.GameContent.Achievements;
using Terraria.Localization;

namespace Terraria
{
	// Token: 0x02000455 RID: 1109
	public class Recipe
	{
		// Token: 0x0600298A RID: 10634 RVA: 0x0019BEF0 File Offset: 0x0019A0F0
		public void RequireGroup(string name)
		{
			if (!true)
			{
			}
			int[] array = this.acceptedGroups;
		}

		// Token: 0x0600298B RID: 10635 RVA: 0x0019BF0C File Offset: 0x0019A10C
		public void RequireGroup(int id)
		{
			int[] array = this.acceptedGroups;
		}

		// Token: 0x0600298C RID: 10636 RVA: 0x0019BF24 File Offset: 0x0019A124
		public bool ProcessGroupsForText(int type, [Out] string theText)
		{
			if (this.acceptedGroups == null)
			{
			}
			if ("" == null)
			{
				return;
			}
		}

		// Token: 0x0600298D RID: 10637 RVA: 0x0019BF48 File Offset: 0x0019A148
		public bool AcceptsGroup(int groupId)
		{
			/*
An exception occurred when decompiling this method (0600298D)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean Terraria.Recipe::AcceptsGroup(System.Int32)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:int32[](var_0_06, ldfld:int32[](Recipe::acceptedGroups, ldloc:Recipe(this)))
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

		// Token: 0x0600298E RID: 10638 RVA: 0x0019BF64 File Offset: 0x0019A164
		public bool AcceptedByItemGroups(int invType, int reqType)
		{
			int[] array = this.acceptedGroups;
			if (array == null)
			{
			}
			if (array == null)
			{
				return;
			}
		}

		// Token: 0x0600298F RID: 10639 RVA: 0x000021DB File Offset: 0x000003DB
		public Item AddCustomShimmerResult(int itemType, int itemStack = 1)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06002990 RID: 10640 RVA: 0x0019BF84 File Offset: 0x0019A184
		public Recipe()
		{
			Item[] array = this.requiredItem;
			int[] array2 = this.requiredTile;
			int[] array3 = this.acceptedGroups;
		}

		// Token: 0x06002991 RID: 10641 RVA: 0x0019BFC4 File Offset: 0x0019A1C4
		public void Create()
		{
			Item[] array = this.requiredItem;
			Vector2 position = array.position;
			if (array != null)
			{
				bool flag = this.alchemy;
				if (flag)
				{
					if (!flag)
					{
					}
					int myPlayer = Main.myPlayer;
					if (flag)
					{
						if (!flag)
						{
						}
						int num;
						if (num == 0)
						{
							return;
						}
					}
				}
				if (!flag)
				{
				}
				int myPlayer2 = Main.myPlayer;
				if (this.anyFragment || this.anyIronBar)
				{
				}
				return;
			}
			AchievementsHelper.NotifyItemCraft(this);
			int myPlayer3 = Main.myPlayer;
			Item item = this.createItem;
			Recipe.FindRecipes(false);
		}

		// Token: 0x06002992 RID: 10642 RVA: 0x0019C188 File Offset: 0x0019A388
		public bool useWood(int invType, int reqType)
		{
			if (this.anyWood)
			{
				return;
			}
		}

		// Token: 0x06002993 RID: 10643 RVA: 0x0019C1AC File Offset: 0x0019A3AC
		public bool useIronBar(int invType, int reqType)
		{
			if (this.anyIronBar)
			{
				return true;
			}
		}

		// Token: 0x06002994 RID: 10644 RVA: 0x0019C1C4 File Offset: 0x0019A3C4
		public bool useSand(int invType, int reqType)
		{
			if (this.anySand)
			{
				return;
			}
		}

		// Token: 0x06002995 RID: 10645 RVA: 0x0019C1E0 File Offset: 0x0019A3E0
		public bool useFragment(int invType, int reqType)
		{
			/*
An exception occurred when decompiling this method (06002995)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean Terraria.Recipe::useFragment(System.Int32,System.Int32)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:bool(var_0_06, ldfld:bool(Recipe::anyFragment, ldloc:Recipe(this)))
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

		// Token: 0x06002996 RID: 10646 RVA: 0x0019C1F8 File Offset: 0x0019A3F8
		public bool usePressurePlate(int invType, int reqType)
		{
			if (this.anyPressurePlate)
			{
				return;
			}
		}

		// Token: 0x06002997 RID: 10647 RVA: 0x0019C220 File Offset: 0x0019A420
		public static void GetThroughDelayedFindRecipes()
		{
			if (!true)
			{
			}
			Recipe.FindRecipes(false);
		}

		// Token: 0x06002998 RID: 10648 RVA: 0x0019C238 File Offset: 0x0019A438
		public static void FindRecipes(bool canDelayCheck = false)
		{
			if (!true)
			{
			}
		}

		// Token: 0x06002999 RID: 10649 RVA: 0x0019C2AC File Offset: 0x0019A4AC
		private static void AddToAvailableRecipes(int recipeIndex)
		{
			if (!true)
			{
			}
			int[] availableRecipe = Main.availableRecipe;
			int numAvailableRecipes = Main.numAvailableRecipes;
			Main.numAvailableRecipes = Main.numAvailableRecipes;
		}

		// Token: 0x0600299A RID: 10650 RVA: 0x0019C2DC File Offset: 0x0019A4DC
		public static bool CollectedEnoughItemsToCraftRecipeOld(Recipe tempRec)
		{
			int num = 1;
			if (num != 0)
			{
				if (num == 0)
				{
				}
				throw new OutOfMemoryException();
			}
			if (!false)
			{
			}
			throw new OutOfMemoryException();
		}

		// Token: 0x0600299B RID: 10651 RVA: 0x0019C308 File Offset: 0x0019A508
		public static bool CollectedEnoughItemsToCraftRecipeNew(Recipe tempRec)
		{
		}

		// Token: 0x0600299C RID: 10652 RVA: 0x0019C31C File Offset: 0x0019A51C
		private static bool PlayerMeetsEnvironmentConditions(Player player, Recipe tempRec)
		{
			/*
An exception occurred when decompiling this method (0600299C)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean Terraria.Recipe::PlayerMeetsEnvironmentConditions(Terraria.Player,Terraria.Recipe)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_3:
	brtrue(IL_0000, ldloc:int32[exp:bool](var_0_0C))
}

   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1852
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1878
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1878
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1846
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1878
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1878
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1846
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

		// Token: 0x0600299D RID: 10653 RVA: 0x0019C34C File Offset: 0x0019A54C
		private static bool PlayerMeetsTileRequirements(Player player, Recipe tempRec)
		{
			/*
An exception occurred when decompiling this method (0600299D)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean Terraria.Recipe::PlayerMeetsTileRequirements(Terraria.Player,Terraria.Recipe)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:Vector2(var_0_06, ldfld:Vector2(Entity::position, ldloc:Player[exp:Entity](player)))
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

		// Token: 0x0600299E RID: 10654 RVA: 0x0019C368 File Offset: 0x0019A568
		private static void CollectItemsToCraftWithFrom(Player player)
		{
			if (!true)
			{
			}
			Item[] inventory = player.inventory;
			int num = 58;
			Recipe.CollectItems(inventory, num);
			bool flag = player.useVoidBag();
			int chest = player.chest;
			Item[] item = player.bank4.item;
			int num2 = 40;
			Recipe.CollectItems(item, num2);
			int chest2 = player.chest;
			int chest3 = player.chest;
			Recipe.AddFakeCountsForItemGroups();
		}

		// Token: 0x0600299F RID: 10655 RVA: 0x0019C3CC File Offset: 0x0019A5CC
		private static void AddFakeCountsForItemGroups()
		{
			int num = 1;
			if (num == 0)
			{
			}
			if (num == 0)
			{
			}
		}

		// Token: 0x060029A0 RID: 10656 RVA: 0x0019C3F8 File Offset: 0x0019A5F8
		private static void CollectItems(Item[] currentInventory, int slotCap)
		{
			if (!true)
			{
			}
		}

		// Token: 0x060029A1 RID: 10657 RVA: 0x0019C408 File Offset: 0x0019A608
		private static void CollectGuideRecipes()
		{
			int num = 1;
			if (num == 0)
			{
			}
			int type = Main.guideItem.type;
			if (num == 0)
			{
			}
			if (num != 0 && num != 0)
			{
				if (num == 0)
				{
				}
				Item guideItem = Main.guideItem;
				if (num != 0)
				{
				}
				if (num == 0)
				{
					return;
				}
				if (num == 0)
				{
				}
				int[] availableRecipe = Main.availableRecipe;
				int numAvailableRecipes = Main.numAvailableRecipes;
				Main.numAvailableRecipes = Main.numAvailableRecipes;
			}
		}

		// Token: 0x060029A2 RID: 10658 RVA: 0x0019C474 File Offset: 0x0019A674
		public static void ClearAvailableRecipes()
		{
			if (!true)
			{
			}
			int[] availableRecipe = Main.availableRecipe;
		}

		// Token: 0x060029A3 RID: 10659 RVA: 0x0019C498 File Offset: 0x0019A698
		private static void VisuallyRepositionRecipes(float focusY)
		{
			int num = 1;
			if (num == 0)
			{
			}
			int focusRecipe = Main.focusRecipe;
			if (num == 0)
			{
			}
		}

		// Token: 0x060029A4 RID: 10660 RVA: 0x0019C4B8 File Offset: 0x0019A6B8
		private static void TryRefocusingRecipe(int oldRecipe)
		{
			int num = 1;
			if (num == 0)
			{
			}
			int numAvailableRecipes = Main.numAvailableRecipes;
			if (num == 0)
			{
			}
			int[] availableRecipe = Main.availableRecipe;
		}

		// Token: 0x060029A5 RID: 10661 RVA: 0x0019C528 File Offset: 0x0019A728
		public static void SetupRecipeGroups()
		{
			if (!true)
			{
			}
			if (!true)
			{
			}
			int num;
			if (num == 0)
			{
			}
			int num2;
			if (num2 == 0)
			{
			}
			int num3;
			if (num3 == 0)
			{
			}
			int num4;
			if (num4 == 0)
			{
			}
			int num5;
			if (num5 == 0)
			{
			}
			int num6;
			if (num6 == 0)
			{
			}
			int num7;
			if (num7 == 0)
			{
			}
			int num8;
			if (num8 == 0)
			{
			}
			int num9;
			if (num9 == 0)
			{
			}
			int num10;
			if (num10 == 0)
			{
			}
			int num11;
			if (num11 == 0)
			{
			}
			int num12;
			if (num12 == 0)
			{
			}
			int num13;
			if (num13 == 0)
			{
			}
			int num14;
			if (num14 == 0)
			{
			}
			int num15;
			if (num15 == 0)
			{
			}
			int num16;
			if (num16 == 0)
			{
			}
			int num17;
			if (num17 == 0)
			{
			}
			int num18;
			if (num18 == 0)
			{
			}
			int num19;
			if (num19 == 0)
			{
			}
			int num20;
			if (num20 == 0)
			{
			}
			int num21;
			if (num21 == 0)
			{
			}
			int num22;
			if (num22 == 0)
			{
			}
			int num23;
			if (num23 == 0)
			{
			}
		}

		// Token: 0x060029A6 RID: 10662 RVA: 0x0019C594 File Offset: 0x0019A794
		public static void UpdateItemVariants()
		{
			if (!true)
			{
			}
		}

		// Token: 0x060029A7 RID: 10663 RVA: 0x0019C5B8 File Offset: 0x0019A7B8
		public static void SetupRecipes()
		{
			/*
An exception occurred when decompiling this method (060029A7)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Void Terraria.Recipe::SetupRecipes()

 ---> System.OutOfMemoryException: Exception of type 'System.OutOfMemoryException' was thrown.
   at ICSharpCode.Decompiler.ILAst.ILAstBuilder.VariableSlot.CloneVariableState(VariableSlot[] state) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstBuilder.cs:line 78
   at ICSharpCode.Decompiler.ILAst.ILAstBuilder.StackAnalysis(MethodDef methodDef) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstBuilder.cs:line 407
   at ICSharpCode.Decompiler.ILAst.ILAstBuilder.Build(MethodDef methodDef, Boolean optimize, DecompilerContext context) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstBuilder.cs:line 278
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(IEnumerable`1 parameters, MethodDebugInfoBuilder& builder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 117
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 88
   --- End of inner exception stack trace ---
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 92
   at ICSharpCode.Decompiler.Ast.AstBuilder.AddMethodBody(EntityDeclaration methodNode, EntityDeclaration& updatedNode, MethodDef method, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, MethodKind methodKind) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 1683
*/;
		}

		// Token: 0x060029A8 RID: 10664 RVA: 0x001B018C File Offset: 0x001AE38C
		private static void ReplaceItemUseFlagsWithRecipeGroups()
		{
			int num = 1;
			if (num == 0)
			{
			}
			if (num == 0)
			{
			}
		}

		// Token: 0x060029A9 RID: 10665 RVA: 0x001B01C0 File Offset: 0x001AE3C0
		private void ReplaceItemUseFlagWithGroup(bool flag, int groupId)
		{
			int[] array = this.acceptedGroups;
		}

		// Token: 0x060029AA RID: 10666 RVA: 0x001B01D8 File Offset: 0x001AE3D8
		private static void CreateRequiredItemQuickLookups()
		{
			int num = 1;
			if (num == 0)
			{
			}
			if (num == 0)
			{
			}
			if (num == 0)
			{
			}
		}

		// Token: 0x060029AB RID: 10667 RVA: 0x001B0200 File Offset: 0x001AE400
		private static void UpdateMaterialFieldForAllRecipes()
		{
			int num = 1;
			if (num == 0)
			{
			}
			if (num == 0)
			{
			}
			if (num == 0)
			{
			}
		}

		// Token: 0x060029AC RID: 10668 RVA: 0x001B0220 File Offset: 0x001AE420
		public static void UpdateWhichItemsAreMaterials()
		{
		}

		// Token: 0x060029AD RID: 10669 RVA: 0x001B0230 File Offset: 0x001AE430
		public static void UpdateWhichItemsAreCrafted()
		{
			int num = 1;
			if (num == 0)
			{
			}
			if (num == 0)
			{
			}
			if (num == 0)
			{
			}
		}

		// Token: 0x060029AE RID: 10670 RVA: 0x001B024C File Offset: 0x001AE44C
		private static void AddSolarFurniture()
		{
			if (!true)
			{
			}
			Recipe.AddRecipe();
			Recipe.AddRecipe();
			Recipe.AddRecipe();
			Recipe.AddRecipe();
			Recipe.AddRecipe();
			Recipe.AddRecipe();
			Recipe.AddRecipe();
			Recipe.AddRecipe();
			Recipe.AddRecipe();
			Recipe.AddRecipe();
			Recipe.AddRecipe();
			Recipe.AddRecipe();
			Recipe.AddRecipe();
			Recipe.AddRecipe();
			Recipe.AddRecipe();
			Recipe.AddRecipe();
			Recipe.AddRecipe();
			Recipe.AddRecipe();
			Recipe.AddRecipe();
			Recipe.AddRecipe();
			Recipe.AddRecipe();
		}

		// Token: 0x060029AF RID: 10671 RVA: 0x001B03D8 File Offset: 0x001AE5D8
		private static void AddVortexFurniture()
		{
			if (!true)
			{
			}
			Recipe.AddRecipe();
			Recipe.AddRecipe();
			Recipe.AddRecipe();
			Recipe.AddRecipe();
			Recipe.AddRecipe();
			Recipe.AddRecipe();
			Recipe.AddRecipe();
			Recipe.AddRecipe();
			Recipe.AddRecipe();
			Recipe.AddRecipe();
			Recipe.AddRecipe();
			Recipe.AddRecipe();
			Recipe.AddRecipe();
			Recipe.AddRecipe();
			Recipe.AddRecipe();
			Recipe.AddRecipe();
			Recipe.AddRecipe();
			Recipe.AddRecipe();
			Recipe.AddRecipe();
			Recipe.AddRecipe();
			Recipe.AddRecipe();
		}

		// Token: 0x060029B0 RID: 10672 RVA: 0x001B0564 File Offset: 0x001AE764
		private static void AddNebulaFurniture()
		{
			if (!true)
			{
			}
			Recipe.AddRecipe();
			Recipe.AddRecipe();
			Recipe.AddRecipe();
			Recipe.AddRecipe();
			Recipe.AddRecipe();
			Recipe.AddRecipe();
			Recipe.AddRecipe();
			Recipe.AddRecipe();
			Recipe.AddRecipe();
			Recipe.AddRecipe();
			Recipe.AddRecipe();
			Recipe.AddRecipe();
			Recipe.AddRecipe();
			Recipe.AddRecipe();
			Recipe.AddRecipe();
			Recipe.AddRecipe();
			Recipe.AddRecipe();
			Recipe.AddRecipe();
			Recipe.AddRecipe();
			Recipe.AddRecipe();
			Recipe.AddRecipe();
		}

		// Token: 0x060029B1 RID: 10673 RVA: 0x001B06F0 File Offset: 0x001AE8F0
		private static void AddStardustFurniture()
		{
			if (!true)
			{
			}
			Recipe.AddRecipe();
			Recipe.AddRecipe();
			Recipe.AddRecipe();
			Recipe.AddRecipe();
			Recipe.AddRecipe();
			Recipe.AddRecipe();
			Recipe.AddRecipe();
			Recipe.AddRecipe();
			Recipe.AddRecipe();
			Recipe.AddRecipe();
			Recipe.AddRecipe();
			Recipe.AddRecipe();
			Recipe.AddRecipe();
			Recipe.AddRecipe();
			Recipe.AddRecipe();
			Recipe.AddRecipe();
			Recipe.AddRecipe();
			Recipe.AddRecipe();
			Recipe.AddRecipe();
			Recipe.AddRecipe();
			Recipe.AddRecipe();
		}

		// Token: 0x060029B2 RID: 10674 RVA: 0x001B087C File Offset: 0x001AEA7C
		private static void AddSpiderFurniture()
		{
			if (!true)
			{
			}
			Recipe.AddRecipe();
			Recipe.AddRecipe();
			Recipe.AddRecipe();
			Recipe.AddRecipe();
			Recipe.AddRecipe();
			Recipe.AddRecipe();
			Recipe.AddRecipe();
			Recipe.AddRecipe();
			Recipe.AddRecipe();
			Recipe.AddRecipe();
			Recipe.AddRecipe();
			Recipe.AddRecipe();
			Recipe.AddRecipe();
			Recipe.AddRecipe();
			Recipe.AddRecipe();
			Recipe.AddRecipe();
			Recipe.AddRecipe();
			Recipe.AddRecipe();
			Recipe.AddRecipe();
			Recipe.AddRecipe();
			Recipe.AddRecipe();
		}

		// Token: 0x060029B3 RID: 10675 RVA: 0x001B0A04 File Offset: 0x001AEC04
		private static void AddLesionFurniture()
		{
			if (!true)
			{
			}
			Recipe.AddRecipe();
			Recipe.AddRecipe();
			Recipe.AddRecipe();
			Recipe.AddRecipe();
			Recipe.AddRecipe();
			Recipe.AddRecipe();
			Recipe.AddRecipe();
			Recipe.AddRecipe();
			Recipe.AddRecipe();
			Recipe.AddRecipe();
			Recipe.AddRecipe();
			Recipe.AddRecipe();
			Recipe.AddRecipe();
			Recipe.AddRecipe();
			Recipe.AddRecipe();
			Recipe.AddRecipe();
			Recipe.AddRecipe();
			Recipe.AddRecipe();
			Recipe.AddRecipe();
			Recipe.AddRecipe();
			Recipe.AddRecipe();
		}

		// Token: 0x060029B4 RID: 10676 RVA: 0x001B0BA0 File Offset: 0x001AEDA0
		private static void AddSandstoneFurniture()
		{
			if (!true)
			{
			}
			Recipe.AddRecipe();
			Recipe.AddRecipe();
			Recipe.AddRecipe();
			Recipe.AddRecipe();
			Recipe.AddRecipe();
			Recipe.AddRecipe();
			Recipe.AddRecipe();
			Recipe.AddRecipe();
			Recipe.AddRecipe();
			Recipe.AddRecipe();
			Recipe.AddRecipe();
			Recipe.AddRecipe();
			Recipe.AddRecipe();
			Recipe.AddRecipe();
			Recipe.AddRecipe();
			Recipe.AddRecipe();
			Recipe.AddRecipe();
			Recipe.AddRecipe();
			Recipe.AddRecipe();
			Recipe.AddRecipe();
		}

		// Token: 0x060029B5 RID: 10677 RVA: 0x001B0D14 File Offset: 0x001AEF14
		private static void AddBambooFurniture()
		{
			if (!true)
			{
			}
			Recipe.AddRecipe();
			Recipe.AddRecipe();
			Recipe.AddRecipe();
			Recipe.AddRecipe();
			Recipe.AddRecipe();
			Recipe.AddRecipe();
			Recipe.AddRecipe();
			Recipe.AddRecipe();
			Recipe.AddRecipe();
			Recipe.AddRecipe();
			Recipe.AddRecipe();
			Recipe.AddRecipe();
			Recipe.AddRecipe();
			Recipe.AddRecipe();
			Recipe.AddRecipe();
			Recipe.AddRecipe();
			Recipe.AddRecipe();
			Recipe.AddRecipe();
			Recipe.AddRecipe();
		}

		// Token: 0x060029B6 RID: 10678 RVA: 0x001B0E78 File Offset: 0x001AF078
		private static void AddCoralFurniture()
		{
			if (!true)
			{
			}
			Recipe.AddRecipe();
			Recipe.AddRecipe();
			Recipe.AddRecipe();
			Recipe.AddRecipe();
			Recipe.AddRecipe();
			Recipe.AddRecipe();
			Recipe.AddRecipe();
			Recipe.AddRecipe();
			Recipe.AddRecipe();
			Recipe.AddRecipe();
			Recipe.AddRecipe();
			Recipe.AddRecipe();
			Recipe.AddRecipe();
			Recipe.AddRecipe();
			Recipe.AddRecipe();
			Recipe.AddRecipe();
			Recipe.AddRecipe();
			Recipe.AddRecipe();
			Recipe.AddRecipe();
		}

		// Token: 0x060029B7 RID: 10679 RVA: 0x001B0FDC File Offset: 0x001AF1DC
		private static void AddBalloonFurniture()
		{
			if (!true)
			{
			}
		}

		// Token: 0x060029B8 RID: 10680 RVA: 0x001B1190 File Offset: 0x001AF390
		private static void AddAshWoodFurnitureArmorAndItems()
		{
			if (!true)
			{
			}
			Recipe.AddRecipe();
			Recipe.AddRecipe();
			Recipe.AddRecipe();
			Recipe.AddRecipe();
			Recipe.AddRecipe();
			Recipe.AddRecipe();
			Recipe.AddRecipe();
			Recipe.AddRecipe();
			Recipe.AddRecipe();
			Recipe.AddRecipe();
			Recipe.AddRecipe();
			Recipe.AddRecipe();
			Recipe.AddRecipe();
			Recipe.AddRecipe();
			Recipe.AddRecipe();
			Recipe.AddRecipe();
			Recipe.AddRecipe();
			Recipe.AddRecipe();
			Recipe.AddRecipe();
			Recipe.AddRecipe();
			Recipe.AddRecipe();
			Recipe.AddRecipe();
			Recipe.AddRecipe();
			Recipe.AddRecipe();
			Recipe.AddRecipe();
		}

		// Token: 0x060029B9 RID: 10681 RVA: 0x001B1360 File Offset: 0x001AF560
		private static void CreateReversePlatformRecipes()
		{
			int num = 1;
			if (num == 0)
			{
			}
			if (num == 0)
			{
			}
		}

		// Token: 0x060029BA RID: 10682 RVA: 0x001B1394 File Offset: 0x001AF594
		private static void CreateReverseWallRecipes()
		{
			int num = 1;
			if (num == 0)
			{
			}
			if (num == 0)
			{
			}
			if (num == 0)
			{
			}
			if (num == 0)
			{
				if (num == 0)
				{
				}
				return;
			}
		}

		// Token: 0x060029BB RID: 10683 RVA: 0x001B13D0 File Offset: 0x001AF5D0
		public void SetIngredients(params int[] ingredients)
		{
			Item[] array = this.requiredItem;
			Vector2 position = array.position;
			Item[] array2 = this.requiredItem;
		}

		// Token: 0x060029BC RID: 10684 RVA: 0x001B13FC File Offset: 0x001AF5FC
		public void SetCraftingStation(params int[] tileIDs)
		{
			int[] array = this.requiredTile;
		}

		// Token: 0x060029BD RID: 10685 RVA: 0x001B1414 File Offset: 0x001AF614
		private static void AddRecipe()
		{
			int num = 1;
			if (num == 0)
			{
			}
			if (num == 0)
			{
			}
			if (num == 0)
			{
			}
		}

		// Token: 0x060029BE RID: 10686 RVA: 0x001B143C File Offset: 0x001AF63C
		public static int GetRequiredTileStyle(int tileID)
		{
			if (!true)
			{
				return;
			}
		}

		// Token: 0x060029BF RID: 10687 RVA: 0x001B1450 File Offset: 0x001AF650
		public bool ContainsIngredient(int itemType)
		{
			/*
An exception occurred when decompiling this method (060029BF)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean Terraria.Recipe::ContainsIngredient(System.Int32)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:valuetype Terraria.Recipe/RequiredItemEntry[](var_0_06, ldfld:valuetype Terraria.Recipe/RequiredItemEntry[](Recipe::requiredItemQuickLookup, ldloc:Recipe(this)))
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

		// Token: 0x060029C0 RID: 10688 RVA: 0x001B146C File Offset: 0x001AF66C
		// Note: this type is marked as 'beforefieldinit'.
		static Recipe()
		{
		}

		// Token: 0x040036BB RID: 14011
		public const int maxRequirements = 15;

		// Token: 0x040036BC RID: 14012
		public const int maxRecipes = 3000;

		// Token: 0x040036BD RID: 14013
		public static int numRecipes;

		// Token: 0x040036BE RID: 14014
		private static Recipe currentRecipe;

		// Token: 0x040036BF RID: 14015
		public Item createItem;

		// Token: 0x040036C0 RID: 14016
		public Item[] requiredItem;

		// Token: 0x040036C1 RID: 14017
		public int[] requiredTile;

		// Token: 0x040036C2 RID: 14018
		public int[] acceptedGroups;

		// Token: 0x040036C3 RID: 14019
		private Recipe.RequiredItemEntry[] requiredItemQuickLookup;

		// Token: 0x040036C4 RID: 14020
		public List<Item> customShimmerResults;

		// Token: 0x040036C5 RID: 14021
		public bool needHoney;

		// Token: 0x040036C6 RID: 14022
		public bool needWater;

		// Token: 0x040036C7 RID: 14023
		public bool needLava;

		// Token: 0x040036C8 RID: 14024
		public bool anyWood;

		// Token: 0x040036C9 RID: 14025
		public bool anyIronBar;

		// Token: 0x040036CA RID: 14026
		public bool anyPressurePlate;

		// Token: 0x040036CB RID: 14027
		public bool anySand;

		// Token: 0x040036CC RID: 14028
		public bool anyFragment;

		// Token: 0x040036CD RID: 14029
		public bool alchemy;

		// Token: 0x040036CE RID: 14030
		public bool needSnowBiome;

		// Token: 0x040036CF RID: 14031
		public bool needGraveyardBiome;

		// Token: 0x040036D0 RID: 14032
		public bool needEverythingSeed;

		// Token: 0x040036D1 RID: 14033
		public bool notDecraftable;

		// Token: 0x040036D2 RID: 14034
		public bool crimson;

		// Token: 0x040036D3 RID: 14035
		public bool corruption;

		// Token: 0x040036D4 RID: 14036
		private static Item defaultRecipeItem;

		// Token: 0x040036D5 RID: 14037
		private static bool _hasDelayedFindRecipes;

		// Token: 0x040036D6 RID: 14038
		private static Dictionary<int, int> _ownedItems;

		// Token: 0x02000456 RID: 1110
		private struct RequiredItemEntry
		{
			// Token: 0x040036D7 RID: 14039
			public int itemIdOrRecipeGroup;

			// Token: 0x040036D8 RID: 14040
			public int stack;
		}

		// Token: 0x02000457 RID: 1111
		[CompilerGenerated]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x060029C1 RID: 10689 RVA: 0x001B147C File Offset: 0x001AF67C
			// Note: this type is marked as 'beforefieldinit'.
			static <>c()
			{
			}

			// Token: 0x060029C2 RID: 10690 RVA: 0x001B148C File Offset: 0x001AF68C
			public <>c()
			{
			}

			// Token: 0x060029C3 RID: 10691 RVA: 0x001B14A0 File Offset: 0x001AF6A0
			internal string <SetupRecipeGroups>b__56_0()
			{
				if (!true)
				{
				}
				string npcnameValue = Lang.GetNPCNameValue(74);
				string text;
				return text;
			}

			// Token: 0x060029C4 RID: 10692 RVA: 0x001B14BC File Offset: 0x001AF6BC
			internal string <SetupRecipeGroups>b__56_1()
			{
				if (!true)
				{
				}
				string npcnameValue = Lang.GetNPCNameValue(367);
				string text;
				return text;
			}

			// Token: 0x060029C5 RID: 10693 RVA: 0x001B14D8 File Offset: 0x001AF6D8
			internal string <SetupRecipeGroups>b__56_2()
			{
				if (!true)
				{
				}
				string npcnameValue = Lang.GetNPCNameValue(299);
				string text;
				return text;
			}

			// Token: 0x060029C6 RID: 10694 RVA: 0x001B14F4 File Offset: 0x001AF6F4
			internal string <SetupRecipeGroups>b__56_3()
			{
				if (!true)
				{
				}
				string text;
				return text;
			}

			// Token: 0x060029C7 RID: 10695 RVA: 0x001B1508 File Offset: 0x001AF708
			internal string <SetupRecipeGroups>b__56_4()
			{
				if (!true)
				{
				}
				string text;
				return text;
			}

			// Token: 0x060029C8 RID: 10696 RVA: 0x001B151C File Offset: 0x001AF71C
			internal string <SetupRecipeGroups>b__56_5()
			{
				if (!true)
				{
				}
				string text;
				return text;
			}

			// Token: 0x060029C9 RID: 10697 RVA: 0x001B1530 File Offset: 0x001AF730
			internal string <SetupRecipeGroups>b__56_6()
			{
				if (!true)
				{
				}
				string text;
				return text;
			}

			// Token: 0x060029CA RID: 10698 RVA: 0x001B1544 File Offset: 0x001AF744
			internal string <SetupRecipeGroups>b__56_7()
			{
				if (!true)
				{
				}
				string text;
				return text;
			}

			// Token: 0x060029CB RID: 10699 RVA: 0x001B1558 File Offset: 0x001AF758
			internal string <SetupRecipeGroups>b__56_8()
			{
				if (!true)
				{
				}
				string text;
				return text;
			}

			// Token: 0x060029CC RID: 10700 RVA: 0x001B156C File Offset: 0x001AF76C
			internal string <SetupRecipeGroups>b__56_9()
			{
				if (!true)
				{
				}
				string npcnameValue = Lang.GetNPCNameValue(616);
				string text;
				return text;
			}

			// Token: 0x060029CD RID: 10701 RVA: 0x001B1588 File Offset: 0x001AF788
			internal string <SetupRecipeGroups>b__56_10()
			{
				if (!true)
				{
				}
				string textValue = Language.GetTextValue("Misc.Macaw");
				string text;
				return text;
			}

			// Token: 0x060029CE RID: 10702 RVA: 0x001B15A4 File Offset: 0x001AF7A4
			internal string <SetupRecipeGroups>b__56_11()
			{
				if (!true)
				{
				}
				string textValue = Language.GetTextValue("Misc.Cockatiel");
				string text;
				return text;
			}

			// Token: 0x060029CF RID: 10703 RVA: 0x001B15C0 File Offset: 0x001AF7C0
			internal string <SetupRecipeGroups>b__56_12()
			{
				if (!true)
				{
				}
				string textValue = Language.GetTextValue("Misc.CloudBalloon");
				string text;
				return text;
			}

			// Token: 0x060029D0 RID: 10704 RVA: 0x001B15DC File Offset: 0x001AF7DC
			internal string <SetupRecipeGroups>b__56_13()
			{
				if (!true)
				{
				}
				string textValue = Language.GetTextValue("Misc.BlizzardBalloon");
				string text;
				return text;
			}

			// Token: 0x060029D1 RID: 10705 RVA: 0x001B15F8 File Offset: 0x001AF7F8
			internal string <SetupRecipeGroups>b__56_14()
			{
				if (!true)
				{
				}
				string textValue = Language.GetTextValue("Misc.SandstormBalloon");
				string text;
				return text;
			}

			// Token: 0x060029D2 RID: 10706 RVA: 0x001B1614 File Offset: 0x001AF814
			internal string <SetupRecipeGroups>b__56_15()
			{
				if (!true)
				{
				}
				string textValue = Language.GetTextValue("Misc.CritterGuides");
				string text;
				return text;
			}

			// Token: 0x060029D3 RID: 10707 RVA: 0x001B1630 File Offset: 0x001AF830
			internal string <SetupRecipeGroups>b__56_16()
			{
				if (!true)
				{
				}
				string textValue = Language.GetTextValue("Misc.NatureGuides");
				string text;
				return text;
			}

			// Token: 0x060029D4 RID: 10708 RVA: 0x001B164C File Offset: 0x001AF84C
			internal string <SetupRecipeGroups>b__56_17()
			{
				if (!true)
				{
				}
				string textValue = Language.GetTextValue("Misc.Fruit");
				string text;
				return text;
			}

			// Token: 0x060029D5 RID: 10709 RVA: 0x001B1668 File Offset: 0x001AF868
			internal string <SetupRecipeGroups>b__56_18()
			{
				if (!true)
				{
				}
				string textValue = Language.GetTextValue("Misc.Balloon");
				string text;
				return text;
			}

			// Token: 0x060029D6 RID: 10710 RVA: 0x001B1684 File Offset: 0x001AF884
			internal string <SetupRecipeGroups>b__56_19()
			{
				return "replaceme wood";
			}

			// Token: 0x060029D7 RID: 10711 RVA: 0x001B1698 File Offset: 0x001AF898
			internal string <SetupRecipeGroups>b__56_20()
			{
				return "replaceme sand";
			}

			// Token: 0x060029D8 RID: 10712 RVA: 0x001B16AC File Offset: 0x001AF8AC
			internal string <SetupRecipeGroups>b__56_21()
			{
				return "replaceme ironbar";
			}

			// Token: 0x060029D9 RID: 10713 RVA: 0x001B16C0 File Offset: 0x001AF8C0
			internal string <SetupRecipeGroups>b__56_22()
			{
				return "replaceme fragment";
			}

			// Token: 0x060029DA RID: 10714 RVA: 0x001B16D4 File Offset: 0x001AF8D4
			internal string <SetupRecipeGroups>b__56_23()
			{
				return "replaceme pressureplate";
			}

			// Token: 0x040036D9 RID: 14041
			public static readonly Recipe.<>c <>9;

			// Token: 0x040036DA RID: 14042
			public static Func<string> <>9__56_0;

			// Token: 0x040036DB RID: 14043
			public static Func<string> <>9__56_1;

			// Token: 0x040036DC RID: 14044
			public static Func<string> <>9__56_2;

			// Token: 0x040036DD RID: 14045
			public static Func<string> <>9__56_3;

			// Token: 0x040036DE RID: 14046
			public static Func<string> <>9__56_4;

			// Token: 0x040036DF RID: 14047
			public static Func<string> <>9__56_5;

			// Token: 0x040036E0 RID: 14048
			public static Func<string> <>9__56_6;

			// Token: 0x040036E1 RID: 14049
			public static Func<string> <>9__56_7;

			// Token: 0x040036E2 RID: 14050
			public static Func<string> <>9__56_8;

			// Token: 0x040036E3 RID: 14051
			public static Func<string> <>9__56_9;

			// Token: 0x040036E4 RID: 14052
			public static Func<string> <>9__56_10;

			// Token: 0x040036E5 RID: 14053
			public static Func<string> <>9__56_11;

			// Token: 0x040036E6 RID: 14054
			public static Func<string> <>9__56_12;

			// Token: 0x040036E7 RID: 14055
			public static Func<string> <>9__56_13;

			// Token: 0x040036E8 RID: 14056
			public static Func<string> <>9__56_14;

			// Token: 0x040036E9 RID: 14057
			public static Func<string> <>9__56_15;

			// Token: 0x040036EA RID: 14058
			public static Func<string> <>9__56_16;

			// Token: 0x040036EB RID: 14059
			public static Func<string> <>9__56_17;

			// Token: 0x040036EC RID: 14060
			public static Func<string> <>9__56_18;

			// Token: 0x040036ED RID: 14061
			public static Func<string> <>9__56_19;

			// Token: 0x040036EE RID: 14062
			public static Func<string> <>9__56_20;

			// Token: 0x040036EF RID: 14063
			public static Func<string> <>9__56_21;

			// Token: 0x040036F0 RID: 14064
			public static Func<string> <>9__56_22;

			// Token: 0x040036F1 RID: 14065
			public static Func<string> <>9__56_23;
		}
	}
}
