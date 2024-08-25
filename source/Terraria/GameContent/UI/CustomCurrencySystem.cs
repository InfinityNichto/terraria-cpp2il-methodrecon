using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Terraria.GameContent.UI
{
	// Token: 0x02000A5A RID: 2650
	public class CustomCurrencySystem
	{
		// Token: 0x1700089F RID: 2207
		// (get) Token: 0x06004E56 RID: 20054 RVA: 0x00276768 File Offset: 0x00274968
		public long CurrencyCap
		{
			get
			{
				return this._currencyCap;
			}
		}

		// Token: 0x06004E57 RID: 20055 RVA: 0x0027677C File Offset: 0x0027497C
		public void Include(int coin, int howMuchIsItWorth)
		{
			Dictionary<int, int> valuePerUnit = this._valuePerUnit;
		}

		// Token: 0x06004E58 RID: 20056 RVA: 0x00276790 File Offset: 0x00274990
		public void SetCurrencyCap(long cap)
		{
			this._currencyCap = cap;
		}

		// Token: 0x06004E59 RID: 20057 RVA: 0x002767A4 File Offset: 0x002749A4
		public virtual long CountCurrency([Out] bool overFlowing, Item[] inv, params int[] ignoreSlots)
		{
			long entityId = inv.entityId;
			Dictionary<int, int> valuePerUnit = this._valuePerUnit;
			long currencyCap = this._currencyCap;
			int num = 1;
			overFlowing.m_value = num != 0;
			return this._currencyCap;
		}

		// Token: 0x06004E5A RID: 20058 RVA: 0x002767DC File Offset: 0x002749DC
		public virtual long CombineStacks([Out] bool overFlowing, params long[] coinCounts)
		{
			long currencyCap = this._currencyCap;
			return 0L;
		}

		// Token: 0x06004E5B RID: 20059 RVA: 0x000021DB File Offset: 0x000003DB
		public virtual bool TryPurchasing(long price, List<Item[]> inv, List<Point> slotCoins, List<Point> slotsEmpty, List<Point> slotEmptyBank, List<Point> slotEmptyBank2, List<Point> slotEmptyBank3, List<Point> slotEmptyBank4)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06004E5C RID: 20060 RVA: 0x00276808 File Offset: 0x00274A08
		public virtual bool Accepts(Item item)
		{
			/*
An exception occurred when decompiling this method (06004E5C)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean Terraria.GameContent.UI.CustomCurrencySystem::Accepts(Terraria.Item)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:class [mscorlib]System.Collections.Generic.Dictionary`2<int32, int32>(var_0_06, ldfld:class [mscorlib]System.Collections.Generic.Dictionary`2<int32, int32>(CustomCurrencySystem::_valuePerUnit, ldloc:CustomCurrencySystem(this)))
	stloc:int32(var_1_0D, ldfld:int32(Item::type, ldloc:Item(item)))
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

		// Token: 0x06004E5D RID: 20061 RVA: 0x00276824 File Offset: 0x00274A24
		public virtual void DrawSavingsMoney(SpriteBatch sb, string text, float shopx, float shopy, long totalCoins, bool horizontal = false)
		{
		}

		// Token: 0x06004E5E RID: 20062 RVA: 0x00276834 File Offset: 0x00274A34
		public virtual void GetPriceText(string[] lines, int currentLine, long price)
		{
		}

		// Token: 0x06004E5F RID: 20063 RVA: 0x000021DB File Offset: 0x000003DB
		protected int SortByHighest(Tuple<int, int> valueA, Tuple<int, int> valueB)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06004E60 RID: 20064 RVA: 0x00276844 File Offset: 0x00274A44
		protected List<Tuple<Point, Item>> ItemCacheCreate(List<Item[]> inventories)
		{
			/*
An exception occurred when decompiling this method (06004E60)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Collections.Generic.List`1<System.Tuple`2<Microsoft.Xna.Framework.Point,Terraria.Item>> Terraria.GameContent.UI.CustomCurrencySystem::ItemCacheCreate(System.Collections.Generic.List`1<Terraria.Item[]>)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:int32(var_0_06, ldfld:int32(List`1::_size, ldloc:class [mscorlib]System.Collections.Generic.List`1<class Terraria.Item[]>[exp:List`1](inventories)))
	stloc:int32(var_2_0F, ldfld:int32(List`1::_size, ldloc:class [mscorlib]System.Collections.Generic.List`1<class Terraria.Item[]>[exp:List`1](inventories)))
	stloc:int32(var_5_18, ldfld:int32(List`1::_size, ldloc:class [mscorlib]System.Collections.Generic.List`1<class Terraria.Item[]>[exp:List`1](inventories)))
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

		// Token: 0x06004E61 RID: 20065 RVA: 0x0027686C File Offset: 0x00274A6C
		protected void ItemCacheRestore(List<Tuple<Point, Item>> cache, List<Item[]> inventories)
		{
		}

		// Token: 0x06004E62 RID: 20066 RVA: 0x00276898 File Offset: 0x00274A98
		public virtual void GetItemExpectedPrice(Item item, [Out] long calcForSelling, [Out] long calcForBuying)
		{
			int storeValue = item.GetStoreValue();
		}

		// Token: 0x06004E63 RID: 20067 RVA: 0x002768AC File Offset: 0x00274AAC
		public CustomCurrencySystem()
		{
		}

		// Token: 0x040086F4 RID: 34548
		protected Dictionary<int, int> _valuePerUnit;

		// Token: 0x040086F5 RID: 34549
		private long _currencyCap = 51711L;
	}
}
