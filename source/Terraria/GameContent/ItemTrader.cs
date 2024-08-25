using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Cpp2IlInjected;

namespace Terraria.GameContent
{
	// Token: 0x020007DF RID: 2015
	public class ItemTrader
	{
		// Token: 0x060040EA RID: 16618 RVA: 0x002441BC File Offset: 0x002423BC
		public void AddOption_Interchangable(int itemType1, int itemType2)
		{
			this.AddOption_OneWay(itemType1, 1, itemType2, 1);
			this.AddOption_OneWay(itemType2, 1, itemType1, 1);
		}

		// Token: 0x060040EB RID: 16619 RVA: 0x002441E0 File Offset: 0x002423E0
		public void AddOption_CyclicLoop(params int[] typesInOrder)
		{
		}

		// Token: 0x060040EC RID: 16620 RVA: 0x002441F0 File Offset: 0x002423F0
		public void AddOption_FromAny(int givingItemType, params int[] takingItemTypes)
		{
			int num = 1;
			int num2 = 1;
			this.AddOption_OneWay(givingItemType, num, givingItemType, num2);
		}

		// Token: 0x060040ED RID: 16621 RVA: 0x000021DB File Offset: 0x000003DB
		public void AddOption_OneWay(int takingItemType, int takingItemStack, int givingItemType, int givingItemStack)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x060040EE RID: 16622 RVA: 0x000021DB File Offset: 0x000003DB
		public bool TryGetTradeOption(Item item, [Out] ItemTrader.TradeOption option)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x060040EF RID: 16623 RVA: 0x000021DB File Offset: 0x000003DB
		public static ItemTrader CreateChlorophyteExtractinator()
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x060040F0 RID: 16624 RVA: 0x0024420C File Offset: 0x0024240C
		public ItemTrader()
		{
		}

		// Token: 0x060040F1 RID: 16625 RVA: 0x00244220 File Offset: 0x00242420
		// Note: this type is marked as 'beforefieldinit'.
		static ItemTrader()
		{
			ItemTrader itemTrader = ItemTrader.CreateChlorophyteExtractinator();
		}

		// Token: 0x04007EAA RID: 32426
		public static ItemTrader ChlorophyteExtractinator;

		// Token: 0x04007EAB RID: 32427
		private List<ItemTrader.TradeOption> _options;

		// Token: 0x020007E0 RID: 2016
		public class TradeOption
		{
			// Token: 0x060040F2 RID: 16626 RVA: 0x00244234 File Offset: 0x00242434
			public bool WillTradeFor(int offeredItemType, int offeredItemStack)
			{
				/*
An exception occurred when decompiling this method (060040F2)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean Terraria.GameContent.ItemTrader/TradeOption::WillTradeFor(System.Int32,System.Int32)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:int32(var_0_06, ldfld:int32(TradeOption::TakingItemType, ldloc:TradeOption(this)))
	stloc:int32(var_1_0D, ldfld:int32(TradeOption::TakingItemStack, ldloc:TradeOption(this)))
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

			// Token: 0x060040F3 RID: 16627 RVA: 0x00244250 File Offset: 0x00242450
			public TradeOption()
			{
			}

			// Token: 0x04007EAC RID: 32428
			public int TakingItemType;

			// Token: 0x04007EAD RID: 32429
			public int TakingItemStack;

			// Token: 0x04007EAE RID: 32430
			public int GivingITemType;

			// Token: 0x04007EAF RID: 32431
			public int GivingItemStack;
		}
	}
}
