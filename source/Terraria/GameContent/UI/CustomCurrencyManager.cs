using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Terraria.GameContent.UI
{
	// Token: 0x02000A5C RID: 2652
	public class CustomCurrencyManager
	{
		// Token: 0x06004E68 RID: 20072 RVA: 0x002769A0 File Offset: 0x00274BA0
		public static void Initialize()
		{
			if (!true)
			{
			}
		}

		// Token: 0x06004E69 RID: 20073 RVA: 0x002769B0 File Offset: 0x00274BB0
		public static int RegisterCurrency(CustomCurrencySystem collection)
		{
			/*
An exception occurred when decompiling this method (06004E69)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Int32 Terraria.GameContent.UI.CustomCurrencyManager::RegisterCurrency(Terraria.GameContent.UI.CustomCurrencySystem)

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

		// Token: 0x06004E6A RID: 20074 RVA: 0x002769C0 File Offset: 0x00274BC0
		public static long GetCurrencyCount(int currencyIndex)
		{
			/*
An exception occurred when decompiling this method (06004E6A)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Int64 Terraria.GameContent.UI.CustomCurrencyManager::GetCurrencyCount(System.Int32)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0003:
	stloc:int32(var_1_0A, callgetter:int32(Main::get_myPlayer))
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

		// Token: 0x06004E6B RID: 20075 RVA: 0x002769DC File Offset: 0x00274BDC
		public static void DrawSavings(SpriteBatch sb, int currencyIndex, float shopx, float shopy, bool horizontal = false)
		{
			if (!true)
			{
			}
			if ("Only TraceListeners can be added to a TraceListenerCollection." == null)
			{
			}
			int myPlayer = Main.myPlayer;
			if ("Only TraceListeners can be added to a TraceListenerCollection." == null)
			{
			}
			int num = 17036;
			if (num == 0)
			{
			}
			if (num == 0)
			{
			}
			int num2 = 1;
			if (num2 == 0)
			{
			}
			int value = num2.m_value;
		}

		// Token: 0x06004E6C RID: 20076 RVA: 0x00276A44 File Offset: 0x00274C44
		public static void GetPriceText(int currencyIndex, string[] lines, int currentLine, long price)
		{
			if (!true)
			{
			}
		}

		// Token: 0x06004E6D RID: 20077 RVA: 0x00276A54 File Offset: 0x00274C54
		public static bool CanAffordItem(Player player, long price, int currencyIndex)
		{
			if (!true)
			{
				return;
			}
		}

		// Token: 0x06004E6E RID: 20078 RVA: 0x00276A68 File Offset: 0x00274C68
		public static bool BuyItem(Player player, long price, int currencyIndex)
		{
			if (!true)
			{
				return;
			}
		}

		// Token: 0x06004E6F RID: 20079 RVA: 0x000021DB File Offset: 0x000003DB
		private static void FindEmptySlots(List<Item[]> inventories, Dictionary<int, List<int>> slotsToIgnore, List<Point> emptySlots, int currentInventoryIndex)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06004E70 RID: 20080 RVA: 0x00276A88 File Offset: 0x00274C88
		public static bool IsCustomCurrency(Item item)
		{
			if (!true)
			{
			}
			throw new OutOfMemoryException();
		}

		// Token: 0x06004E71 RID: 20081 RVA: 0x00276AA8 File Offset: 0x00274CA8
		public static void GetPrices(Item item, [Out] long calcForSelling, [Out] long calcForBuying)
		{
			if (!true)
			{
			}
			int shopSpecialCurrency = item.shopSpecialCurrency;
		}

		// Token: 0x06004E72 RID: 20082 RVA: 0x00276AC0 File Offset: 0x00274CC0
		public CustomCurrencyManager()
		{
		}

		// Token: 0x06004E73 RID: 20083 RVA: 0x00276AD4 File Offset: 0x00274CD4
		// Note: this type is marked as 'beforefieldinit'.
		static CustomCurrencyManager()
		{
		}

		// Token: 0x040086F9 RID: 34553
		private static int _nextCurrencyIndex;

		// Token: 0x040086FA RID: 34554
		private static Dictionary<int, CustomCurrencySystem> _currencies;
	}
}
