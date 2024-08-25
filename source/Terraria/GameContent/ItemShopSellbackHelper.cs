using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;

namespace Terraria.GameContent
{
	// Token: 0x020007DA RID: 2010
	public class ItemShopSellbackHelper
	{
		// Token: 0x060040DD RID: 16605 RVA: 0x000021DB File Offset: 0x000003DB
		public void Add(Item item)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x060040DE RID: 16606 RVA: 0x000021DB File Offset: 0x000003DB
		public void Clear()
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x060040DF RID: 16607 RVA: 0x00244014 File Offset: 0x00242214
		public int GetAmount(Item item)
		{
			List<ItemShopSellbackHelper.ItemMemo> memos;
			do
			{
				memos = this._memos;
			}
			while (memos == null);
			return memos._size;
		}

		// Token: 0x060040E0 RID: 16608 RVA: 0x00244034 File Offset: 0x00242234
		public int Remove(Item item)
		{
			int num = 1;
			List<ItemShopSellbackHelper.ItemMemo> memos = this._memos;
			int size;
			if (memos != null)
			{
				size = memos._size;
				memos._size = num;
				List<ItemShopSellbackHelper.ItemMemo> memos2 = this._memos;
			}
			return size;
		}

		// Token: 0x060040E1 RID: 16609 RVA: 0x00244064 File Offset: 0x00242264
		public ItemShopSellbackHelper()
		{
		}

		// Token: 0x04007EA3 RID: 32419
		private List<ItemShopSellbackHelper.ItemMemo> _memos;

		// Token: 0x020007DB RID: 2011
		private class ItemMemo
		{
			// Token: 0x060040E2 RID: 16610 RVA: 0x00244078 File Offset: 0x00242278
			public ItemMemo(Item item)
			{
				int netID = item.netID;
				this.itemNetID = netID;
				byte prefix = item.prefix;
				this.itemPrefix = (int)prefix;
				int num = item.stack;
				this.stack = num;
			}

			// Token: 0x060040E3 RID: 16611 RVA: 0x002440B8 File Offset: 0x002422B8
			public bool Matches(Item item)
			{
				/*
An exception occurred when decompiling this method (060040E3)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean Terraria.GameContent.ItemShopSellbackHelper/ItemMemo::Matches(Terraria.Item)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:int32(var_0_06, ldfld:int32(Item::netID, ldloc:Item(item)))
	stloc:int32(var_1_0D, ldfld:int32(ItemMemo::itemNetID, ldloc:ItemMemo(this)))
	stloc:uint8(var_2_14, ldfld:uint8(Item::prefix, ldloc:Item(item)))
	stloc:int32(var_3_1B, ldfld:int32(ItemMemo::itemPrefix, ldloc:ItemMemo(this)))
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

			// Token: 0x04007EA4 RID: 32420
			public readonly int itemNetID;

			// Token: 0x04007EA5 RID: 32421
			public readonly int itemPrefix;

			// Token: 0x04007EA6 RID: 32422
			public int stack;
		}

		// Token: 0x020007DC RID: 2012
		[CompilerGenerated]
		private sealed class <>c__DisplayClass2_0
		{
			// Token: 0x060040E4 RID: 16612 RVA: 0x002440E4 File Offset: 0x002422E4
			public <>c__DisplayClass2_0()
			{
			}

			// Token: 0x060040E5 RID: 16613 RVA: 0x002440F8 File Offset: 0x002422F8
			internal bool <Add>b__0(ItemShopSellbackHelper.ItemMemo x)
			{
				/*
An exception occurred when decompiling this method (060040E5)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean Terraria.GameContent.ItemShopSellbackHelper/<>c__DisplayClass2_0::<Add>b__0(Terraria.GameContent.ItemShopSellbackHelper/ItemMemo)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:Item(var_0_06, ldfld:Item('<>c__DisplayClass2_0'::item, ldloc:'<>c__DisplayClass2_0'(this)))
	stloc:int32(var_1_0D, ldfld:int32(ItemMemo::itemNetID, ldloc:ItemMemo(x)))
	stloc:int32(var_2_14, ldfld:int32(Item::netID, ldloc:Item(var_0_06)))
	stloc:uint8(var_3_1B, ldfld:uint8(Item::prefix, ldloc:Item(var_0_06)))
	stloc:int32(var_4_22, ldfld:int32(ItemMemo::itemPrefix, ldloc:ItemMemo(x)))
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

			// Token: 0x04007EA7 RID: 32423
			public Item item;
		}

		// Token: 0x020007DD RID: 2013
		[CompilerGenerated]
		private sealed class <>c__DisplayClass4_0
		{
			// Token: 0x060040E6 RID: 16614 RVA: 0x0024412C File Offset: 0x0024232C
			public <>c__DisplayClass4_0()
			{
			}

			// Token: 0x060040E7 RID: 16615 RVA: 0x00244140 File Offset: 0x00242340
			internal bool <GetAmount>b__0(ItemShopSellbackHelper.ItemMemo x)
			{
				/*
An exception occurred when decompiling this method (060040E7)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean Terraria.GameContent.ItemShopSellbackHelper/<>c__DisplayClass4_0::<GetAmount>b__0(Terraria.GameContent.ItemShopSellbackHelper/ItemMemo)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:Item(var_0_06, ldfld:Item('<>c__DisplayClass4_0'::item, ldloc:'<>c__DisplayClass4_0'(this)))
	stloc:int32(var_1_0D, ldfld:int32(ItemMemo::itemNetID, ldloc:ItemMemo(x)))
	stloc:int32(var_2_14, ldfld:int32(Item::netID, ldloc:Item(var_0_06)))
	stloc:uint8(var_3_1B, ldfld:uint8(Item::prefix, ldloc:Item(var_0_06)))
	stloc:int32(var_4_22, ldfld:int32(ItemMemo::itemPrefix, ldloc:ItemMemo(x)))
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

			// Token: 0x04007EA8 RID: 32424
			public Item item;
		}

		// Token: 0x020007DE RID: 2014
		[CompilerGenerated]
		private sealed class <>c__DisplayClass5_0
		{
			// Token: 0x060040E8 RID: 16616 RVA: 0x00244174 File Offset: 0x00242374
			public <>c__DisplayClass5_0()
			{
			}

			// Token: 0x060040E9 RID: 16617 RVA: 0x00244188 File Offset: 0x00242388
			internal bool <Remove>b__0(ItemShopSellbackHelper.ItemMemo x)
			{
				/*
An exception occurred when decompiling this method (060040E9)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean Terraria.GameContent.ItemShopSellbackHelper/<>c__DisplayClass5_0::<Remove>b__0(Terraria.GameContent.ItemShopSellbackHelper/ItemMemo)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:Item(var_0_06, ldfld:Item('<>c__DisplayClass5_0'::item, ldloc:'<>c__DisplayClass5_0'(this)))
	stloc:int32(var_1_0D, ldfld:int32(ItemMemo::itemNetID, ldloc:ItemMemo(x)))
	stloc:int32(var_2_14, ldfld:int32(Item::netID, ldloc:Item(var_0_06)))
	stloc:uint8(var_3_1B, ldfld:uint8(Item::prefix, ldloc:Item(var_0_06)))
	stloc:int32(var_4_22, ldfld:int32(ItemMemo::itemPrefix, ldloc:ItemMemo(x)))
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

			// Token: 0x04007EA9 RID: 32425
			public Item item;
		}
	}
}
