using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Microsoft.Xna.Framework;

namespace Terraria.DataStructures
{
	// Token: 0x02000674 RID: 1652
	public class AnchoredEntitiesCollection
	{
		// Token: 0x170006A9 RID: 1705
		// (get) Token: 0x06003730 RID: 14128 RVA: 0x002213A8 File Offset: 0x0021F5A8
		public int AnchoredPlayersAmount
		{
			get
			{
				return this._anchoredPlayers._size;
			}
		}

		// Token: 0x06003731 RID: 14129 RVA: 0x002213C0 File Offset: 0x0021F5C0
		public AnchoredEntitiesCollection()
		{
		}

		// Token: 0x06003732 RID: 14130 RVA: 0x002213D4 File Offset: 0x0021F5D4
		public void ClearNPCAnchors()
		{
			List<AnchoredEntitiesCollection.IndexPointPair> anchoredNPCs = this._anchoredNPCs;
			int version = anchoredNPCs._version;
			anchoredNPCs._syncRoot = version;
		}

		// Token: 0x06003733 RID: 14131 RVA: 0x002213F8 File Offset: 0x0021F5F8
		public void ClearPlayerAnchors()
		{
			List<AnchoredEntitiesCollection.IndexPointPair> anchoredPlayers = this._anchoredPlayers;
			int version = anchoredPlayers._version;
			anchoredPlayers._syncRoot = version;
		}

		// Token: 0x06003734 RID: 14132 RVA: 0x000021DB File Offset: 0x000003DB
		public void AddNPC(int npcIndex, Point coords)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06003735 RID: 14133 RVA: 0x0022141C File Offset: 0x0021F61C
		public int GetNextPlayerStackIndexInCoords(Point coords)
		{
			return this.GetEntitiesInCoords(coords);
		}

		// Token: 0x06003736 RID: 14134 RVA: 0x000021DB File Offset: 0x000003DB
		public void AddPlayerAndGetItsStackedIndexInCoords(int playerIndex, Point coords, [Out] int stackedIndexInCoords)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06003737 RID: 14135 RVA: 0x00221430 File Offset: 0x0021F630
		private int GetEntitiesInCoords(Point coords)
		{
			/*
An exception occurred when decompiling this method (06003737)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Int32 Terraria.DataStructures.AnchoredEntitiesCollection::GetEntitiesInCoords(Microsoft.Xna.Framework.Point)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_003A:
	stloc:int32(var_10_45, ldfld:int32(List`1::_size, ldfld:class [mscorlib]System.Collections.Generic.List`1<valuetype Terraria.DataStructures.AnchoredEntitiesCollection/IndexPointPair>[exp:List`1](AnchoredEntitiesCollection::_anchoredPlayers, ldloc:AnchoredEntitiesCollection(this))))
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

		// Token: 0x04007825 RID: 30757
		private List<AnchoredEntitiesCollection.IndexPointPair> _anchoredNPCs;

		// Token: 0x04007826 RID: 30758
		private List<AnchoredEntitiesCollection.IndexPointPair> _anchoredPlayers;

		// Token: 0x02000675 RID: 1653
		private struct IndexPointPair
		{
			// Token: 0x04007827 RID: 30759
			public int index;

			// Token: 0x04007828 RID: 30760
			public Point coords;
		}
	}
}
