using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;

namespace Terraria.GameContent.Creative
{
	// Token: 0x02000A15 RID: 2581
	public class ItemsSacrificedUnlocksTracker : IPersistentPerWorldContent, IOnPlayerJoining
	{
		// Token: 0x17000876 RID: 2166
		// (get) Token: 0x06004C31 RID: 19505 RVA: 0x00271668 File Offset: 0x0026F868
		// (set) Token: 0x06004C32 RID: 19506 RVA: 0x0027167C File Offset: 0x0026F87C
		public int LastEditId
		{
			[CompilerGenerated]
			get
			{
				return this.<LastEditId>k__BackingField;
			}
			[CompilerGenerated]
			private set
			{
				this.<LastEditId>k__BackingField = value;
			}
		}

		// Token: 0x06004C33 RID: 19507 RVA: 0x00271690 File Offset: 0x0026F890
		public ItemsSacrificedUnlocksTracker()
		{
		}

		// Token: 0x06004C34 RID: 19508 RVA: 0x002716A4 File Offset: 0x0026F8A4
		public int GetSacrificeCount(int itemId)
		{
			/*
An exception occurred when decompiling this method (06004C34)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Int32 Terraria.GameContent.Creative.ItemsSacrificedUnlocksTracker::GetSacrificeCount(System.Int32)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0003:
	stloc:class [mscorlib]System.Collections.Generic.Dictionary`2<int32, int32>(var_0_09, ldfld:class [mscorlib]System.Collections.Generic.Dictionary`2<int32, int32>(ItemsSacrificedUnlocksTracker::SacrificesCountByItemIdCache, ldloc:ItemsSacrificedUnlocksTracker(this)))
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

		// Token: 0x06004C35 RID: 19509 RVA: 0x000021DB File Offset: 0x000003DB
		public void FillListOfItemsThatCanBeObtainedInfinitely(List<int> toObtainInfinitely)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06004C36 RID: 19510 RVA: 0x002716BC File Offset: 0x0026F8BC
		public bool TryGetSacrificeNumbers(int itemId, [Out] int amountWeHave, [Out] int amountNeededTotal)
		{
			if (!true)
			{
			}
			Dictionary<int, int> sacrificesCountByItemIdCache = this.SacrificesCountByItemIdCache;
			return true;
		}

		// Token: 0x06004C37 RID: 19511 RVA: 0x002716D8 File Offset: 0x0026F8D8
		public void RegisterItemSacrifice(int itemId, int amount)
		{
			if (!true)
			{
			}
			Dictionary<string, int> sacrificeCountByItemPersistentId = this._sacrificeCountByItemPersistentId;
			Dictionary<string, int> sacrificeCountByItemPersistentId2 = this._sacrificeCountByItemPersistentId;
			Dictionary<int, int> sacrificesCountByItemIdCache = this.SacrificesCountByItemIdCache;
			int num = this.<LastEditId>k__BackingField;
			this.<LastEditId>k__BackingField = num;
		}

		// Token: 0x06004C38 RID: 19512 RVA: 0x0027170C File Offset: 0x0026F90C
		public void SetSacrificeCountDirectly(string persistentId, int sacrificeCount)
		{
			if (!true)
			{
			}
			Dictionary<string, int> sacrificeCountByItemPersistentId = this._sacrificeCountByItemPersistentId;
			if (sacrificeCountByItemPersistentId == null)
			{
			}
			int[] buckets = sacrificeCountByItemPersistentId._buckets;
			Dictionary<int, int> sacrificesCountByItemIdCache = this.SacrificesCountByItemIdCache;
			int num = this.<LastEditId>k__BackingField;
			this.<LastEditId>k__BackingField = num;
		}

		// Token: 0x06004C39 RID: 19513 RVA: 0x00271744 File Offset: 0x0026F944
		public void Save(BinaryWriter writer)
		{
			Dictionary<string, int> sacrificeCountByItemPersistentId = this._sacrificeCountByItemPersistentId;
		}

		// Token: 0x06004C3A RID: 19514 RVA: 0x00271770 File Offset: 0x0026F970
		public void Load(BinaryReader reader, int gameVersionSaveWasMadeOn)
		{
		}

		// Token: 0x06004C3B RID: 19515 RVA: 0x0027178C File Offset: 0x0026F98C
		public void ValidateWorld(BinaryReader reader, int gameVersionSaveWasMadeOn)
		{
		}

		// Token: 0x06004C3C RID: 19516 RVA: 0x0027179C File Offset: 0x0026F99C
		public void Reset()
		{
			Dictionary<string, int> sacrificeCountByItemPersistentId = this._sacrificeCountByItemPersistentId;
			Dictionary<int, int> sacrificesCountByItemIdCache = this.SacrificesCountByItemIdCache;
			int num = this.<LastEditId>k__BackingField;
			this.<LastEditId>k__BackingField = num;
		}

		// Token: 0x06004C3D RID: 19517 RVA: 0x002717C8 File Offset: 0x0026F9C8
		public void OnPlayerJoining(int playerIndex)
		{
		}

		// Token: 0x06004C3E RID: 19518 RVA: 0x002717D8 File Offset: 0x0026F9D8
		public void MarkContentsDirty()
		{
			int num = this.<LastEditId>k__BackingField;
			this.<LastEditId>k__BackingField = num;
		}

		// Token: 0x0400864E RID: 34382
		public const int POSITIVE_SACRIFICE_COUNT_CAP = 9999;

		// Token: 0x0400864F RID: 34383
		private Dictionary<string, int> _sacrificeCountByItemPersistentId;

		// Token: 0x04008650 RID: 34384
		public Dictionary<int, int> SacrificesCountByItemIdCache;

		// Token: 0x04008651 RID: 34385
		[CompilerGenerated]
		private int <LastEditId>k__BackingField;
	}
}
