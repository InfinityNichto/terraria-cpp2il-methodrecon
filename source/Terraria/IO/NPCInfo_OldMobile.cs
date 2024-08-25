using System;
using System.Collections.Generic;
using System.IO;
using Cpp2IlInjected;
using Microsoft.Xna.Framework;

namespace Terraria.IO
{
	// Token: 0x0200056E RID: 1390
	public class NPCInfo_OldMobile
	{
		// Token: 0x060033CF RID: 13263 RVA: 0x000021DB File Offset: 0x000003DB
		public void LoadNPCEntries(BinaryReader reader, int release)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x060033D0 RID: 13264 RVA: 0x002007E8 File Offset: 0x001FE9E8
		public void ReadNPCNames(BinaryReader reader, int release)
		{
			NPC.setNPCName(reader.ReadNetString(), 17, true);
			NPC.setNPCName(reader.ReadNetString(), 18, true);
			NPC.setNPCName(reader.ReadNetString(), 19, true);
			NPC.setNPCName(reader.ReadNetString(), 20, true);
			NPC.setNPCName(reader.ReadNetString(), 22, true);
			NPC.setNPCName(reader.ReadNetString(), 54, true);
			NPC.setNPCName(reader.ReadNetString(), 38, true);
			NPC.setNPCName(reader.ReadNetString(), 107, true);
			NPC.setNPCName(reader.ReadNetString(), 108, true);
			NPC.setNPCName(reader.ReadNetString(), 124, true);
			NPC.setNPCName(reader.ReadNetString(), 160, true);
			NPC.setNPCName(reader.ReadNetString(), 178, true);
			NPC.setNPCName(reader.ReadNetString(), 207, true);
			NPC.setNPCName(reader.ReadNetString(), 209, true);
			NPC.setNPCName(reader.ReadNetString(), 208, true);
			NPC.setNPCName(reader.ReadNetString(), 227, true);
			NPC.setNPCName(reader.ReadNetString(), 228, true);
			NPC.setNPCName(reader.ReadNetString(), 229, true);
			NPC.setNPCName(reader.ReadNetString(), 369, true);
			NPC.setNPCName(NPC.getNewNPCName(353), 353, true);
		}

		// Token: 0x060033D1 RID: 13265 RVA: 0x00200930 File Offset: 0x001FEB30
		public bool Load(BinaryReader reader, int release)
		{
			/*
An exception occurred when decompiling this method (060033D1)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean Terraria.IO.NPCInfo_OldMobile::Load(System.IO.BinaryReader,System.Int32)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:int32(var_0_01, ldc.i4:int32(1))
	stfld:bool(NPCInfo_OldMobile::downedAnyBoss, ldloc:NPCInfo_OldMobile(this), ldloc:int32[exp:bool](var_0_01))
	stloc:int64(var_1_0A, ldc.i4:int64(0))
	stfld:int64(int64::m_value, ldloc:int64[exp:int64&](var_1_0A), ldloc:BinaryReader[exp:int64](reader))
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

		// Token: 0x060033D2 RID: 13266 RVA: 0x00200958 File Offset: 0x001FEB58
		public bool LoadMeta(WorldFileData data, BinaryReader reader, int release)
		{
			return true;
		}

		// Token: 0x060033D3 RID: 13267 RVA: 0x00200968 File Offset: 0x001FEB68
		public NPCInfo_OldMobile()
		{
		}

		// Token: 0x04003E11 RID: 15889
		private bool downedAnyBoss;

		// Token: 0x04003E12 RID: 15890
		private bool downedRabbit;

		// Token: 0x04003E13 RID: 15891
		private bool downedTurkor;

		// Token: 0x04003E14 RID: 15892
		private List<NPCInfo_OldMobile.NPCEntry> npcEntries;

		// Token: 0x0200056F RID: 1391
		public class NPCEntry
		{
			// Token: 0x060033D4 RID: 13268 RVA: 0x0020097C File Offset: 0x001FEB7C
			public NPCEntry()
			{
			}

			// Token: 0x04003E15 RID: 15893
			public int npcId;

			// Token: 0x04003E16 RID: 15894
			public int homeTileX;

			// Token: 0x04003E17 RID: 15895
			public int homeTileY;

			// Token: 0x04003E18 RID: 15896
			public bool homeless;

			// Token: 0x04003E19 RID: 15897
			public Vector2 position;
		}
	}
}
