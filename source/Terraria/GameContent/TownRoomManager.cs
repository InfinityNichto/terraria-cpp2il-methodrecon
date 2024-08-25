using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Microsoft.Xna.Framework;

namespace Terraria.GameContent
{
	// Token: 0x02000801 RID: 2049
	public class TownRoomManager
	{
		// Token: 0x060041AA RID: 16810 RVA: 0x00248648 File Offset: 0x00246848
		public void AddOccupantsToList(int x, int y, List<int> occupantsList)
		{
		}

		// Token: 0x060041AB RID: 16811 RVA: 0x000021DB File Offset: 0x000003DB
		public void AddOccupantsToList(Point tilePosition, List<int> occupants)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x060041AC RID: 16812 RVA: 0x00248658 File Offset: 0x00246858
		public bool HasRoomQuick(int npcID)
		{
			/*
An exception occurred when decompiling this method (060041AC)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean Terraria.GameContent.TownRoomManager::HasRoomQuick(System.Int32)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:bool[](var_0_06, ldfld:bool[](TownRoomManager::_hasRoom, ldloc:TownRoomManager(this)))
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

		// Token: 0x060041AD RID: 16813 RVA: 0x0024866C File Offset: 0x0024686C
		public bool HasRoom(int npcID, [Out] Point roomPosition)
		{
			if (this._hasRoom != null)
			{
				List<Tuple<int, Point>> roomLocationPairs = this._roomLocationPairs;
			}
			throw new OutOfMemoryException();
		}

		// Token: 0x060041AE RID: 16814 RVA: 0x002486A0 File Offset: 0x002468A0
		public void SetRoom(int npcID, int x, int y)
		{
			bool[] hasRoom = this._hasRoom;
		}

		// Token: 0x060041AF RID: 16815 RVA: 0x000021DB File Offset: 0x000003DB
		public void SetRoom(int npcID, Point pt)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x060041B0 RID: 16816 RVA: 0x002486B8 File Offset: 0x002468B8
		public void KickOut(NPC n)
		{
			int type = n.type;
			this.KickOut(type);
			bool[] hasRoom = this._hasRoom;
		}

		// Token: 0x060041B1 RID: 16817 RVA: 0x002486DC File Offset: 0x002468DC
		public void KickOut(int npcType)
		{
			if (!true)
			{
			}
			List<Tuple<int, Point>> roomLocationPairs = this._roomLocationPairs;
			if (!false)
			{
				return;
			}
			throw new OutOfMemoryException();
		}

		// Token: 0x060041B2 RID: 16818 RVA: 0x00248714 File Offset: 0x00246914
		public void DisplayRooms()
		{
			List<Tuple<int, Point>> roomLocationPairs = this._roomLocationPairs;
		}

		// Token: 0x060041B3 RID: 16819 RVA: 0x00248740 File Offset: 0x00246940
		public void Save(BinaryWriter writer)
		{
			if (!true)
			{
			}
			int size = this._roomLocationPairs._size;
			List<Tuple<int, Point>> roomLocationPairs = this._roomLocationPairs;
		}

		// Token: 0x060041B4 RID: 16820 RVA: 0x000021DB File Offset: 0x000003DB
		public void Load(BinaryReader reader)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x060041B5 RID: 16821 RVA: 0x000021DB File Offset: 0x000003DB
		public void Clear()
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x060041B6 RID: 16822 RVA: 0x002487A0 File Offset: 0x002469A0
		public byte GetHouseholdStatus(NPC n)
		{
			while (!n.homeless)
			{
			}
		}

		// Token: 0x060041B7 RID: 16823 RVA: 0x002487B8 File Offset: 0x002469B8
		public bool CanNPCsLiveWithEachOther(int npc1ByType, NPC npc2)
		{
			if (!true)
			{
			}
			int housingCategory = npc2.housingCategory;
			return true;
		}

		// Token: 0x060041B8 RID: 16824 RVA: 0x002487D4 File Offset: 0x002469D4
		public bool CanNPCsLiveWithEachOther(NPC npc1, NPC npc2)
		{
			/*
An exception occurred when decompiling this method (060041B8)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean Terraria.GameContent.TownRoomManager::CanNPCsLiveWithEachOther(Terraria.NPC,Terraria.NPC)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:int32(var_0_06, ldfld:int32(NPC::housingCategory, ldloc:NPC(npc1)))
	stloc:int32(var_1_0D, ldfld:int32(NPC::housingCategory, ldloc:NPC(npc2)))
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

		// Token: 0x060041B9 RID: 16825 RVA: 0x002487F0 File Offset: 0x002469F0
		public bool CanNPCsLiveWithEachOther_ShopHelper(NPC npc1, NPC npc2)
		{
			/*
An exception occurred when decompiling this method (060041B9)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean Terraria.GameContent.TownRoomManager::CanNPCsLiveWithEachOther_ShopHelper(Terraria.NPC,Terraria.NPC)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:int32(var_0_06, ldfld:int32(NPC::housingCategory, ldloc:NPC(npc1)))
	stloc:int32(var_1_0D, ldfld:int32(NPC::housingCategory, ldloc:NPC(npc2)))
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

		// Token: 0x060041BA RID: 16826 RVA: 0x0024880C File Offset: 0x00246A0C
		public TownRoomManager()
		{
		}

		// Token: 0x060041BB RID: 16827 RVA: 0x00248820 File Offset: 0x00246A20
		// Note: this type is marked as 'beforefieldinit'.
		static TownRoomManager()
		{
		}

		// Token: 0x04008084 RID: 32900
		public static object EntityCreationLock;

		// Token: 0x04008085 RID: 32901
		private List<Tuple<int, Point>> _roomLocationPairs;

		// Token: 0x04008086 RID: 32902
		private bool[] _hasRoom;

		// Token: 0x02000802 RID: 2050
		[CompilerGenerated]
		private sealed class <>c__DisplayClass8_0
		{
			// Token: 0x060041BC RID: 16828 RVA: 0x00248830 File Offset: 0x00246A30
			public <>c__DisplayClass8_0()
			{
			}

			// Token: 0x060041BD RID: 16829 RVA: 0x000021DB File Offset: 0x000003DB
			internal bool <SetRoom>b__0(Tuple<int, Point> x)
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}

			// Token: 0x04008087 RID: 32903
			public int npcID;
		}

		// Token: 0x02000803 RID: 2051
		[CompilerGenerated]
		private sealed class <>c__DisplayClass10_0
		{
			// Token: 0x060041BE RID: 16830 RVA: 0x00248844 File Offset: 0x00246A44
			public <>c__DisplayClass10_0()
			{
			}

			// Token: 0x060041BF RID: 16831 RVA: 0x000021DB File Offset: 0x000003DB
			internal bool <KickOut>b__0(Tuple<int, Point> x)
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}

			// Token: 0x04008088 RID: 32904
			public int npcType;
		}
	}
}
