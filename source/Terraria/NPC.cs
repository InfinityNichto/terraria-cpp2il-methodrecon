using System;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria.Audio;
using Terraria.DataStructures;
using Terraria.GameContent;
using Terraria.GameContent.Achievements;
using Terraria.GameContent.Creative;
using Terraria.GameContent.Events;
using Terraria.ID;
using Terraria.Localization;
using Terraria.Utilities;

namespace Terraria
{
	// Token: 0x02000403 RID: 1027
	public class NPC : Entity
	{
		// Token: 0x170004E0 RID: 1248
		// (get) Token: 0x06002112 RID: 8466 RVA: 0x000D29C8 File Offset: 0x000D0BC8
		public bool CanTalk
		{
			get
			{
				int num = this.type;
				if (!this.townNPC)
				{
					return;
				}
				int num2 = this.aiStyle;
				float y = this.velocity.Y;
				if (num2 == 0)
				{
					int num3 = this.type;
					return;
				}
			}
		}

		// Token: 0x170004E1 RID: 1249
		// (get) Token: 0x06002113 RID: 8467 RVA: 0x000D2A04 File Offset: 0x000D0C04
		public bool CanBeTalkedTo
		{
			get
			{
				int num = this.type;
				if (this.townNPC)
				{
					int num2 = this.aiStyle;
					float y = this.velocity.Y;
					return;
				}
			}
		}

		// Token: 0x170004E2 RID: 1250
		// (get) Token: 0x06002114 RID: 8468 RVA: 0x000D2A34 File Offset: 0x000D0C34
		public bool HasValidTarget
		{
			get
			{
				int num = this.target;
				if (!this.TargetPlayer.active || this.TargetPlayer.dead || this.TargetPlayer.ghost)
				{
					bool supportsNPCTargets = this.SupportsNPCTargets;
					int num2 = this.target;
					int num3 = this.target;
					return;
				}
			}
		}

		// Token: 0x170004E3 RID: 1251
		// (get) Token: 0x06002115 RID: 8469 RVA: 0x000D2A8C File Offset: 0x000D0C8C
		private Player TargetPlayer
		{
			get
			{
				/*
An exception occurred when decompiling this method (06002115)

ICSharpCode.Decompiler.DecompilerException: Error decompiling Terraria.Player Terraria.NPC::get_TargetPlayer()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0005:
	brtrue(IL_0000, ldloc:int32[exp:bool](var_0_01))
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
		}

		// Token: 0x170004E4 RID: 1252
		// (get) Token: 0x06002116 RID: 8470 RVA: 0x000D2AA0 File Offset: 0x000D0CA0
		public bool HasPlayerTarget
		{
			get
			{
				/*
An exception occurred when decompiling this method (06002116)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean Terraria.NPC::get_HasPlayerTarget()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:int32(var_0_06, ldfld:int32(NPC::target, ldloc:NPC(this)))
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
		}

		// Token: 0x170004E5 RID: 1253
		// (get) Token: 0x06002117 RID: 8471 RVA: 0x000D2AB4 File Offset: 0x000D0CB4
		public bool HasNPCTarget
		{
			get
			{
				/*
An exception occurred when decompiling this method (06002117)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean Terraria.NPC::get_HasNPCTarget()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:int32(var_0_06, ldfld:int32(NPC::target, ldloc:NPC(this)))
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
		}

		// Token: 0x170004E6 RID: 1254
		// (get) Token: 0x06002118 RID: 8472 RVA: 0x000D2AC8 File Offset: 0x000D0CC8
		public bool SupportsNPCTargets
		{
			get
			{
				/*
An exception occurred when decompiling this method (06002118)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean Terraria.NPC::get_SupportsNPCTargets()

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
		}

		// Token: 0x170004E7 RID: 1255
		// (get) Token: 0x06002119 RID: 8473 RVA: 0x000D2AD8 File Offset: 0x000D0CD8
		public int TranslatedTargetIndex
		{
			get
			{
				/*
An exception occurred when decompiling this method (06002119)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Int32 Terraria.NPC::get_TranslatedTargetIndex()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:int32(var_0_06, ldfld:int32(NPC::target, ldloc:NPC(this)))
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
		}

		// Token: 0x170004E8 RID: 1256
		// (get) Token: 0x0600211A RID: 8474 RVA: 0x000D2AEC File Offset: 0x000D0CEC
		public int WhoAmIToTargettingIndex
		{
			get
			{
				/*
An exception occurred when decompiling this method (0600211A)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Int32 Terraria.NPC::get_WhoAmIToTargettingIndex()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:int32(var_0_06, ldfld:int32(Entity::whoAmI, ldloc:NPC[exp:Entity](this)))
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
		}

		// Token: 0x0600211B RID: 8475 RVA: 0x000D2B00 File Offset: 0x000D0D00
		public NPCAimedTarget GetTargetData(bool ignorePlayerTankPets = true)
		{
			/*
An exception occurred when decompiling this method (0600211B)

ICSharpCode.Decompiler.DecompilerException: Error decompiling Terraria.DataStructures.NPCAimedTarget Terraria.NPC::GetTargetData(System.Boolean)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:bool(var_1_06, callgetter:bool(NPC::get_HasValidTarget, ldloc:NPC(this)))
	stloc:bool(var_2_0D, callgetter:bool(NPC::get_SupportsNPCTargets, ldloc:NPC(this)))
	stloc:int32(var_3_14, ldfld:int32(NPC::target, ldloc:NPC(this)))
	stloc:int32(var_4_1B, ldfld:int32(NPC::target, ldloc:NPC(this)))
	stloc:Player(var_6_26, callgetter:Player(NPC::get_TargetPlayer, ldloc:NPC(this)))
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

		// Token: 0x170004E9 RID: 1257
		// (get) Token: 0x0600211C RID: 8476 RVA: 0x000D2B34 File Offset: 0x000D0D34
		public bool IsShimmerVariant
		{
			get
			{
				if (this.townNpcVariationIndex == 0)
				{
					return;
				}
			}
		}

		// Token: 0x0600211D RID: 8477 RVA: 0x000D2B4C File Offset: 0x000D0D4C
		public static int[,,,] InitializeMoonLordAttacks()
		{
			int num = 1;
			if (num == 0)
			{
			}
			if (num == 0)
			{
			}
			int num2;
			return num2;
		}

		// Token: 0x0600211E RID: 8478 RVA: 0x000D2BD8 File Offset: 0x000D0DD8
		public static int[,] InitializeMoonLordAttacks2()
		{
			int num = 1;
			if (num == 0)
			{
			}
			if (num == 0)
			{
			}
			int num2;
			return num2;
		}

		// Token: 0x170004EA RID: 1258
		// (get) Token: 0x0600211F RID: 8479 RVA: 0x000D2C00 File Offset: 0x000D0E00
		public string TypeName
		{
			get
			{
				int num = this.netID;
				if (!true)
				{
				}
				return Lang.GetNPCNameValue(num);
			}
		}

		// Token: 0x170004EB RID: 1259
		// (get) Token: 0x06002120 RID: 8480 RVA: 0x000D2C20 File Offset: 0x000D0E20
		public string FullName
		{
			get
			{
				string givenName = this._givenName;
				if (givenName._stringLength != 0)
				{
					string typeName = this.TypeName;
					return Language.GetTextValue("Game.NPCTitle", givenName, typeName);
				}
				return this.TypeName;
			}
		}

		// Token: 0x170004EC RID: 1260
		// (get) Token: 0x06002121 RID: 8481 RVA: 0x000D2C58 File Offset: 0x000D0E58
		public bool HasGivenName
		{
			get
			{
				/*
An exception occurred when decompiling this method (06002121)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean Terraria.NPC::get_HasGivenName()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:int32(var_0_0B, ldfld:int32(string::_stringLength, ldfld:string(NPC::_givenName, ldloc:NPC(this))))
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
		}

		// Token: 0x170004ED RID: 1261
		// (get) Token: 0x06002122 RID: 8482 RVA: 0x000D2C70 File Offset: 0x000D0E70
		public string GivenOrTypeName
		{
			get
			{
				string givenName = this._givenName;
				if (givenName._stringLength != 0)
				{
					return givenName;
				}
				string text;
				return text;
			}
		}

		// Token: 0x170004EE RID: 1262
		// (get) Token: 0x06002123 RID: 8483 RVA: 0x000D2C90 File Offset: 0x000D0E90
		// (set) Token: 0x06002124 RID: 8484 RVA: 0x000D2CA4 File Offset: 0x000D0EA4
		public string GivenName
		{
			get
			{
				return this._givenName;
			}
			set
			{
				this._givenName = "";
			}
		}

		// Token: 0x06002125 RID: 8485 RVA: 0x000D2CBC File Offset: 0x000D0EBC
		public static string GetFullnameByID(int npcID)
		{
			int num = 1;
			if (num == 0)
			{
			}
			if (num == 0 || num == 0)
			{
			}
			if (num == 0)
			{
			}
			return Lang.GetNPCNameValue(42178960);
		}

		// Token: 0x170004EF RID: 1263
		// (get) Token: 0x06002126 RID: 8486 RVA: 0x000D2CE8 File Offset: 0x000D0EE8
		public static bool downedTowers
		{
			get
			{
				if (!true)
				{
					return;
				}
			}
		}

		// Token: 0x170004F0 RID: 1264
		// (get) Token: 0x06002127 RID: 8487 RVA: 0x000D2CFC File Offset: 0x000D0EFC
		public static int ShieldStrengthTowerMax
		{
			get
			{
				/*
An exception occurred when decompiling this method (06002127)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Int32 Terraria.NPC::get_ShieldStrengthTowerMax()

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
		}

		// Token: 0x170004F1 RID: 1265
		// (get) Token: 0x06002128 RID: 8488 RVA: 0x000D2D0C File Offset: 0x000D0F0C
		public static bool TowersDefeated
		{
			get
			{
				if (!true)
				{
					return;
				}
			}
		}

		// Token: 0x06002129 RID: 8489 RVA: 0x000D2D20 File Offset: 0x000D0F20
		public static bool BusyWithAnyInvasionOfSorts()
		{
			if (!true)
			{
			}
			return true;
		}

		// Token: 0x170004F2 RID: 1266
		// (get) Token: 0x0600212A RID: 8490 RVA: 0x000D2D34 File Offset: 0x000D0F34
		// (set) Token: 0x0600212B RID: 8491 RVA: 0x000D2D48 File Offset: 0x000D0F48
		public float Opacity
		{
			get
			{
				/*
An exception occurred when decompiling this method (0600212A)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Single Terraria.NPC::get_Opacity()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:int32(var_0_06, ldfld:int32(NPC::alpha, ldloc:NPC(this)))
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
			set
			{
				this.alpha = 32768;
			}
		}

		// Token: 0x0600212C RID: 8492 RVA: 0x000D2D64 File Offset: 0x000D0F64
		public int GetAttackDamage_ScaledByStrength(float normalDamage)
		{
			/*
An exception occurred when decompiling this method (0600212C)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Int32 Terraria.NPC::GetAttackDamage_ScaledByStrength(System.Single)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0006:
	stloc:float32(var_0_0C, ldfld:float32(NPC::strengthMultiplier, ldloc:NPC(this)))
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

		// Token: 0x0600212D RID: 8493 RVA: 0x000D2D80 File Offset: 0x000D0F80
		public float GetAttackDamage_LerpBetweenFinalValuesFloat(float normalDamage, float expertDamage)
		{
			/*
An exception occurred when decompiling this method (0600212D)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Single Terraria.NPC::GetAttackDamage_LerpBetweenFinalValuesFloat(System.Single,System.Single)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_001A:
	stloc:float32(var_6_27, call:float32(MathHelper::Lerp, ldloc:float32(var_4), ldloc:float32(normalDamage), ldloc:float32(var_4)))
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

		// Token: 0x0600212E RID: 8494 RVA: 0x000D2DB8 File Offset: 0x000D0FB8
		public int GetAttackDamage_LerpBetweenFinalValues(float normalDamage, float expertDamage)
		{
			/*
An exception occurred when decompiling this method (0600212E)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Int32 Terraria.NPC::GetAttackDamage_LerpBetweenFinalValues(System.Single,System.Single)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_001A:
	stloc:float32(var_6_26, call:float32(MathHelper::Lerp, ldloc:float32(normalDamage), ldloc:float32(expertDamage), ldloc:float32(var_4)))
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

		// Token: 0x0600212F RID: 8495 RVA: 0x000D2DEC File Offset: 0x000D0FEC
		public int GetAttackDamage_ForProjectiles(float normalDamage, float expertDamage)
		{
			/*
An exception occurred when decompiling this method (0600212F)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Int32 Terraria.NPC::GetAttackDamage_ForProjectiles(System.Single,System.Single)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_001A:
	stloc:float32(var_6_26, call:float32(MathHelper::Lerp, ldloc:float32(normalDamage), ldloc:float32(expertDamage), ldloc:float32(var_4)))
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

		// Token: 0x06002130 RID: 8496 RVA: 0x000D2E20 File Offset: 0x000D1020
		public int GetAttackDamage_ForProjectiles_MultiLerp(float normalDamage, float expertDamage, float masterDamage)
		{
			/*
An exception occurred when decompiling this method (06002130)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Int32 Terraria.NPC::GetAttackDamage_ForProjectiles_MultiLerp(System.Single,System.Single,System.Single)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0034:
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

		// Token: 0x170004F3 RID: 1267
		// (get) Token: 0x06002131 RID: 8497 RVA: 0x000D2E64 File Offset: 0x000D1064
		public bool isLikeATownNPC
		{
			get
			{
				int num = this.type;
				return true;
			}
		}

		// Token: 0x06002132 RID: 8498 RVA: 0x000D2E7C File Offset: 0x000D107C
		public static bool SpawnAllowed_Demolitionist()
		{
			int num = 1;
			if (num == 0)
			{
			}
			if (num == 0)
			{
				if (num == 0)
				{
				}
				if (num != 0)
				{
					if (num == 0)
					{
					}
					if (num != 0)
					{
						return;
					}
				}
				return;
			}
		}

		// Token: 0x06002133 RID: 8499 RVA: 0x000D2EA8 File Offset: 0x000D10A8
		public static bool SpawnAllowed_ArmsDealer()
		{
			int num = 1;
			if (num == 0)
			{
			}
			if (num == 0)
			{
				if (num == 0)
				{
				}
				if (num == 0 || num == 0)
				{
				}
				return;
			}
		}

		// Token: 0x06002134 RID: 8500 RVA: 0x000D2ED0 File Offset: 0x000D10D0
		public static bool SpawnAllowed_DyeTrader()
		{
			/*
An exception occurred when decompiling this method (06002134)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean Terraria.NPC::SpawnAllowed_DyeTrader()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0029:
	brtrue(IL_0029, ldloc:int32[exp:bool](var_4_1A))
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

		// Token: 0x06002135 RID: 8501 RVA: 0x000D2F0C File Offset: 0x000D110C
		public static bool SpawnAllowed_Nurse()
		{
			int num = 1;
			if (num == 0)
			{
			}
			if (num != 0)
			{
			}
			if (num == 0)
			{
				return;
			}
		}

		// Token: 0x06002136 RID: 8502 RVA: 0x000D2F2C File Offset: 0x000D112C
		public static bool SpawnAllowed_Merchant()
		{
			int num = 1;
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

		// Token: 0x06002137 RID: 8503 RVA: 0x000D2F58 File Offset: 0x000D1158
		public static void ClearFoundActiveNPCs()
		{
			int num = 1;
			if (num == 0)
			{
			}
			if (num == 0)
			{
			}
		}

		// Token: 0x06002138 RID: 8504 RVA: 0x000D2F70 File Offset: 0x000D1170
		public static void UpdateFoundActiveNPCs()
		{
			int num = 1;
			if (num == 0)
			{
			}
			if (num != 0)
			{
			}
		}

		// Token: 0x06002139 RID: 8505 RVA: 0x000D2F8C File Offset: 0x000D118C
		public static void ClearFoundNPCTypesForBestiary()
		{
			int num = 1;
			if (num == 0)
			{
			}
			if (num == 0)
			{
			}
		}

		// Token: 0x0600213A RID: 8506 RVA: 0x000D2FA4 File Offset: 0x000D11A4
		public void SpawnWithHigherTime(int timeMult)
		{
			if (!true)
			{
			}
			this.timeLeft = 1;
		}

		// Token: 0x0600213B RID: 8507 RVA: 0x000D2FBC File Offset: 0x000D11BC
		public void EncourageDespawn(int despawnTime)
		{
			int num = this.timeLeft;
			this.timeLeft = despawnTime;
			this.despawnEncouraged = true;
		}

		// Token: 0x0600213C RID: 8508 RVA: 0x000D2FE0 File Offset: 0x000D11E0
		public void DiscourageDespawn(int despawnTime)
		{
			int num = this.timeLeft;
			this.timeLeft = despawnTime;
		}

		// Token: 0x0600213D RID: 8509 RVA: 0x000D2FFC File Offset: 0x000D11FC
		public static bool WouldBeEncouragedToDespawn(int aistyle, int type)
		{
			if (!true)
			{
				return;
			}
		}

		// Token: 0x0600213E RID: 8510 RVA: 0x000D3010 File Offset: 0x000D1210
		public static string getNewNPCName(int npcType)
		{
			if (!true)
			{
			}
			return NPC.getNewNPCNameInner(int.MinValue);
		}

		// Token: 0x0600213F RID: 8511 RVA: 0x000D302C File Offset: 0x000D122C
		private static string getNewNPCNameInner(int npcType)
		{
			return "DryadNames";
		}

		// Token: 0x06002140 RID: 8512 RVA: 0x000D322C File Offset: 0x000D142C
		public NetworkText GetTypeNetName()
		{
			int num = this.netID;
			if (!true)
			{
			}
			LocalizedText npcname = Lang.GetNPCName(num);
			string key = npcname.Key;
			if (npcname == null)
			{
			}
			NetworkText networkText;
			return networkText;
		}

		// Token: 0x06002141 RID: 8513 RVA: 0x000D3258 File Offset: 0x000D1458
		public void GetLifeStats([Out] int statLife, [Out] int statLifeMax)
		{
			int num = this.life;
			statLife.m_value = num;
			int num2 = this.lifeMax;
			statLifeMax.m_value = num2;
			int num3 = this.realLife;
			int num4 = this.realLife;
			statLife.m_value = num4;
			statLifeMax.m_value = num4;
		}

		// Token: 0x06002142 RID: 8514 RVA: 0x000021DB File Offset: 0x000003DB
		public float GetLifePercent()
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06002143 RID: 8515 RVA: 0x000D32A0 File Offset: 0x000D14A0
		public NetworkText GetFullNetName()
		{
			if (this._givenName._stringLength != 0)
			{
				NetworkText givenNetName = this.GetGivenNetName();
				if (givenNetName == null || givenNetName != null)
				{
					NetworkText typeNetName = this.GetTypeNetName();
					if (typeNetName == null || typeNetName != null)
					{
						NetworkText networkText;
						return networkText;
					}
				}
				throw new ArrayTypeMismatchException();
			}
			NetworkText networkText2;
			return networkText2;
		}

		// Token: 0x06002144 RID: 8516 RVA: 0x000D32E0 File Offset: 0x000D14E0
		public NetworkText GetGivenOrTypeNetName()
		{
			if (this._givenName._stringLength != 0)
			{
				return this.GetGivenNetName();
			}
			NetworkText networkText;
			return networkText;
		}

		// Token: 0x06002145 RID: 8517 RVA: 0x000D3304 File Offset: 0x000D1504
		public NetworkText GetGivenNetName()
		{
			string givenName = this._givenName;
			if (!true)
			{
			}
			return NetworkText.FromLiteral(givenName);
		}

		// Token: 0x06002146 RID: 8518 RVA: 0x000D3324 File Offset: 0x000D1524
		public static void setNPCName(string newName, int npcType, bool resetExtras = false)
		{
			int num = 1;
			if (num == 0)
			{
			}
			if (num != 0)
			{
				if (num == 0)
				{
				}
				if (num != 0)
				{
					if (num == 0)
					{
					}
					string newNPCName = NPC.getNewNPCName(npcType);
					return;
				}
			}
		}

		// Token: 0x06002147 RID: 8519 RVA: 0x000D3350 File Offset: 0x000D1550
		public static string firstNPCName(int npcType)
		{
			int num = 1;
			if (num == 0)
			{
			}
			if (num == 0 || num == 0)
			{
			}
			if (num == 0)
			{
			}
			return NPC.getNewNPCName(int.MinValue);
		}

		// Token: 0x06002148 RID: 8520 RVA: 0x000D3388 File Offset: 0x000D1588
		public static string GetFirstNPCNameOrNull(int npcType)
		{
			int num = 1;
			if (num == 0)
			{
			}
			if (num == 0 || num == 0)
			{
			}
			string text;
			return text;
		}

		// Token: 0x06002149 RID: 8521 RVA: 0x000D33A8 File Offset: 0x000D15A8
		public static bool MechSpawn(float x, float y, int type)
		{
			/*
An exception occurred when decompiling this method (06002149)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean Terraria.NPC::MechSpawn(System.Single,System.Single,System.Int32)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0012:
	brtrue(IL_0000, ldloc:int32[exp:bool](var_0_01))
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

		// Token: 0x0600214A RID: 8522 RVA: 0x000D33CC File Offset: 0x000D15CC
		public static int TypeToDefaultHeadIndex(int type)
		{
			return 13;
		}

		// Token: 0x0600214B RID: 8523 RVA: 0x000D3454 File Offset: 0x000D1654
		public int GetBossHeadTextureIndex()
		{
			/*
An exception occurred when decompiling this method (0600214B)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Int32 Terraria.NPC::GetBossHeadTextureIndex()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0003:
	stloc:float32[](var_0_09, ldfld:float32[](NPC::ai, ldloc:NPC(this)))
	stloc:int32(var_1_10, ldfld:int32(NPC::alpha, ldloc:NPC(this)))
	stloc:float32[](var_2_17, ldfld:float32[](NPC::ai, ldloc:NPC(this)))
	stloc:float32[](var_4_21, ldfld:float32[](NPC::ai, ldloc:NPC(this)))
	stloc:float32[](var_5_29, ldfld:float32[](NPC::ai, ldloc:NPC(this)))
	stloc:float32[](var_6_31, ldfld:float32[](NPC::ai, ldloc:NPC(this)))
	stloc:float32[](var_7_39, ldfld:float32[](NPC::ai, ldloc:NPC(this)))
	stloc:int32(var_8_41, ldfld:int32(NPC::alpha, ldloc:NPC(this)))
	stloc:int32(var_9_49, ldfld:int32(NPC::lifeMax, ldloc:NPC(this)))
	stloc:int32(var_10_51, ldfld:int32(NPC::life, ldloc:NPC(this)))
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

		// Token: 0x0600214C RID: 8524 RVA: 0x000D34B4 File Offset: 0x000D16B4
		public float GetBossHeadRotation()
		{
			/*
An exception occurred when decompiling this method (0600214C)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Single Terraria.NPC::GetBossHeadRotation()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:int32(var_0_06, ldfld:int32(NPC::type, ldloc:NPC(this)))
	stloc:float32[](var_1_0D, ldfld:float32[](NPC::ai, ldloc:NPC(this)))
	stloc:float32[](var_2_14, ldfld:float32[](NPC::ai, ldloc:NPC(this)))
	stloc:float32(var_3_1B, ldfld:float32(NPC::rotation, ldloc:NPC(this)))
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

		// Token: 0x0600214D RID: 8525 RVA: 0x000D34DC File Offset: 0x000D16DC
		public SpriteEffects GetBossHeadSpriteEffects()
		{
			/*
An exception occurred when decompiling this method (0600214D)

ICSharpCode.Decompiler.DecompilerException: Error decompiling Microsoft.Xna.Framework.Graphics.SpriteEffects Terraria.NPC::GetBossHeadSpriteEffects()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:int32(var_0_06, ldfld:int32(NPC::type, ldloc:NPC(this)))
	stloc:int32(var_1_0D, ldfld:int32(NPC::spriteDirection, ldloc:NPC(this)))
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

		// Token: 0x0600214E RID: 8526 RVA: 0x000D34F8 File Offset: 0x000D16F8
		public int BannerID()
		{
			/*
An exception occurred when decompiling this method (0600214E)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Int32 Terraria.NPC::BannerID()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:int32(var_0_06, ldfld:int32(NPC::netID, ldloc:NPC(this)))
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

		// Token: 0x0600214F RID: 8527 RVA: 0x000D350C File Offset: 0x000D170C
		private void SetDefaultsFromNetId(int id, [Optional] NPCSpawnParams spawnparams)
		{
			if (!true)
			{
			}
			int num = NPCID.FromNetId(id);
			long num2 = 0L;
			this.SetDefaults((int)num2, spawnparams);
		}

		// Token: 0x06002150 RID: 8528 RVA: 0x000D3AE4 File Offset: 0x000D1CE4
		public void SetDefaultsKeepPlayerInteraction(int Type)
		{
			bool[] array = this.playerInteraction;
			bool[] array2 = this.playerInteraction;
			bool[] array3 = this.playerInteraction;
		}

		// Token: 0x06002151 RID: 8529 RVA: 0x000D3B0C File Offset: 0x000D1D0C
		public void SetDefaults_ForNetId(int Type, float scaleOverride)
		{
		}

		// Token: 0x06002152 RID: 8530 RVA: 0x000D3B1C File Offset: 0x000D1D1C
		public void SetDefaults_ForNetId(int Type, NPCSpawnParams spawnparams, float scaleOverride)
		{
			NPCSpawnParams npcspawnParams = spawnparams.WithScale(scaleOverride);
			this.SetDefaults(Type, spawnparams);
		}

		// Token: 0x06002153 RID: 8531 RVA: 0x000D3B3C File Offset: 0x000D1D3C
		public void SetNetShimmerEffect()
		{
			this.netShimmer = true;
			this.shimmerTransparency = (float)16256;
		}

		// Token: 0x06002154 RID: 8532 RVA: 0x000D3B5C File Offset: 0x000D1D5C
		public void SetDefaults(int Type, [Optional] NPCSpawnParams spawnparams)
		{
			GameModeData gameModeData = spawnparams.gameModeData;
			int num;
			if (gameModeData == null)
			{
				if (gameModeData == null)
				{
				}
				num = 1;
				if (num == 0)
				{
				}
				spawnparams.gameModeData = num;
			}
			if (num == 0)
			{
			}
			if (num != 0)
			{
				return;
			}
			int num2 = 16000;
			this.honeyMovementSpeed = (float)num2;
			float x = this.netOffset.X;
			float y = this.netOffset.Y;
			bool[] array = this.playerInteraction;
			int num3 = 16256;
			this.takenDamageMultiplier = (float)num3;
			int num4;
			if (this.defDamage != 0)
			{
				num4 = 16256;
				this.shimmerTransparency = (float)num4;
			}
			long num5 = 16256L;
			num4.m_value = (int)num5;
			if (num4 == 0)
			{
			}
		}

		// Token: 0x06002155 RID: 8533 RVA: 0x000DD27C File Offset: 0x000DB47C
		private void getTenthAnniversaryAdjustments()
		{
			int num = this.type;
			float num2 = this.scale;
		}

		// Token: 0x06002156 RID: 8534 RVA: 0x000DD2BC File Offset: 0x000DB4BC
		private void getZenithSeedAdjustmentsBeforeEverything()
		{
			int num = this.type;
			int num2 = this.lifeMax;
			int num3 = 32640;
			this.lifeMax = num3;
		}

		// Token: 0x06002157 RID: 8535 RVA: 0x000DD2E8 File Offset: 0x000DB4E8
		private void getGoodAdjustments()
		{
			int num = this.type;
			float num2 = this.scale;
		}

		// Token: 0x06002158 RID: 8536 RVA: 0x000DD360 File Offset: 0x000DB560
		private void LazySetLiquidMovementDD2()
		{
			this.honeyMovementSpeed = (float)16256;
		}

		// Token: 0x06002159 RID: 8537 RVA: 0x000DD378 File Offset: 0x000DB578
		public static void SetWorldSpecificMonstersByWorldID()
		{
			int num = 1;
			if (num == 0)
			{
			}
			if (num == 0)
			{
			}
		}

		// Token: 0x0600215A RID: 8538 RVA: 0x000DD3B0 File Offset: 0x000DB5B0
		public NPCSpawnParams GetMatchingSpawnParams()
		{
			int num = this.statsAreScaledForThisManyPlayers;
			float num2 = this.strengthMultiplier;
			NPCSpawnParams npcspawnParams;
			npcspawnParams.strengthMultiplierOverride = 1;
			return 1;
		}

		// Token: 0x0600215B RID: 8539 RVA: 0x000DD3D4 File Offset: 0x000DB5D4
		public void ScaleStats(int? activePlayersCount, GameModeData gameModeData, float? strengthOverride)
		{
			int num = 1;
			if (num == 0)
			{
			}
			int num2 = this.type;
			if (num == 0)
			{
			}
			if (num == 0)
			{
			}
			if (num != 0)
			{
				bool <IsJourneyMode>k__BackingField = gameModeData.<IsJourneyMode>k__BackingField;
				if (<IsJourneyMode>k__BackingField)
				{
					if (!<IsJourneyMode>k__BackingField)
					{
					}
					return;
				}
				this.ScaleStats_ApplyExpertTweaks();
				this.ScaleStats_ApplyGameMode(gameModeData);
				return;
			}
			else
			{
				int num3 = this.lifeMax;
				if (this.damage != 0 && !this.friendly && !this.townNPC)
				{
					return;
				}
				return;
			}
		}

		// Token: 0x0600215C RID: 8540 RVA: 0x000DD4BC File Offset: 0x000DB6BC
		public void ScaleStats_UseStrengthMultiplier(float strength)
		{
			int num = this.type;
			if (this.type != 0)
			{
				return;
			}
			int num2 = this.lifeMax;
			int num3 = 32640;
			long num4 = 0L;
			this.lifeMax = num3;
			int num5 = this.damage;
			int num6 = 32640;
			int num7 = 32768;
			this.damage = num6;
			if (num6 == 0)
			{
			}
			int num9;
			if (num4 == 0L)
			{
				if (num7 == 0)
				{
				}
				if (num7 == 0)
				{
				}
				float num8 = this.value;
				num9 = 32640;
				this.value = (float)num5;
			}
			if (num9 == 0)
			{
			}
			float num10 = this.knockBackResist;
			this.knockBackResist = (float)num5;
		}

		// Token: 0x0600215D RID: 8541 RVA: 0x000DD550 File Offset: 0x000DB750
		public static float GetBalance()
		{
			/*
An exception occurred when decompiling this method (0600215D)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Single Terraria.NPC::GetBalance()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0003:
	stloc:int32(var_0_08, call:int32(NPC::GetActivePlayerCount))
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

		// Token: 0x0600215E RID: 8542 RVA: 0x000DD568 File Offset: 0x000DB768
		public float GetMyBalance()
		{
			/*
An exception occurred when decompiling this method (0600215E)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Single Terraria.NPC::GetMyBalance()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:int32(var_0_06, ldfld:int32(NPC::statsAreScaledForThisManyPlayers, ldloc:NPC(this)))
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

		// Token: 0x0600215F RID: 8543 RVA: 0x000DD57C File Offset: 0x000DB77C
		private static int GetActivePlayerCount()
		{
			if (!true)
			{
			}
			return 1;
		}

		// Token: 0x06002160 RID: 8544 RVA: 0x000DD590 File Offset: 0x000DB790
		private void ScaleStats_ApplyExpertTweaks()
		{
			int num = this.type;
			int num2 = this.type;
		}

		// Token: 0x06002161 RID: 8545 RVA: 0x000DD680 File Offset: 0x000DB880
		private void ScaleStats_ApplyGameMode(GameModeData gameModeData)
		{
			int num = this.type;
			int num2 = this.type;
		}

		// Token: 0x06002162 RID: 8546 RVA: 0x000DD720 File Offset: 0x000DB920
		private void ScaleStats_ApplyMultiplayerStats(int numPlayers, float balance, float boost, float bossAdjustment)
		{
			int num = this.type;
			int num2 = this.lifeMax;
		}

		// Token: 0x06002163 RID: 8547 RVA: 0x000DDB40 File Offset: 0x000DBD40
		public static void GetStatScalingFactors(int numPlayers, [Out] float balance, [Out] float boost)
		{
		}

		// Token: 0x06002164 RID: 8548 RVA: 0x000DDB50 File Offset: 0x000DBD50
		public static bool GetNPCLocation(int i, bool seekHead, bool averageDirection, [Out] int index, [Out] Vector2 pos)
		{
			/*
An exception occurred when decompiling this method (06002164)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean Terraria.NPC::GetNPCLocation(System.Int32,System.Boolean,System.Boolean,System.Int32,Microsoft.Xna.Framework.Vector2)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0082:
	stfld:int32(int32::m_value, ldloc:int32[exp:int32&](var_12_4C), ldloc:int32(var_10_3E))
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

		// Token: 0x06002165 RID: 8549 RVA: 0x000DDBEC File Offset: 0x000DBDEC
		public void PopAllAttachedProjectilesAndTakeDamageForThem()
		{
			int num = 1;
			if (num == 0)
			{
			}
			if (num == 0)
			{
			}
			if (num != 0)
			{
				if (num == 0)
				{
				}
				int myPlayer = Main.myPlayer;
				if (num != 0)
				{
				}
			}
		}

		// Token: 0x06002166 RID: 8550 RVA: 0x000DDC14 File Offset: 0x000DBE14
		public bool AI_AttemptToFindTeleportSpot(Vector2 chosenTile, int targetTileX, int targetTileY, int rangeFromTargetTile = 20, int telefragPreventionDistanceInTiles = 5, int solidTileCheckFluff = 1, bool solidTileCheckCentered = false, bool teleportInAir = false)
		{
			if (!true)
			{
			}
			Tile tile;
			bool flag = tile.nactive();
			Tile tile2;
			ushort wall = tile2.wall;
			Tile tile3;
			bool flag2 = tile3.lava();
			Tile tile4;
			ushort num = tile4.type;
			return NPC.AnyNPCs(35);
		}

		// Token: 0x06002167 RID: 8551 RVA: 0x000DDCAC File Offset: 0x000DBEAC
		public static void TransformElderSlime(int npcIndex)
		{
			int num = 1;
			if (num == 0)
			{
			}
			if (num == 0)
			{
			}
		}

		// Token: 0x06002168 RID: 8552 RVA: 0x000DDCE4 File Offset: 0x000DBEE4
		public static void TransformCopperSlime(int npcIndex)
		{
			int num = 1;
			if (num == 0)
			{
			}
			if (num == 0)
			{
			}
		}

		// Token: 0x06002169 RID: 8553 RVA: 0x000DDD1C File Offset: 0x000DBF1C
		public static void HaveDryadDoStardewAnimation()
		{
			if (!true)
			{
			}
		}

		// Token: 0x0600216A RID: 8554 RVA: 0x000021DB File Offset: 0x000003DB
		private void AI_047_GolemFist()
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x0600216B RID: 8555 RVA: 0x000DDD94 File Offset: 0x000DBF94
		private void AI_045_Golem()
		{
			int num = 1;
			int whoAmI = this.whoAmI;
			if (num == 0)
			{
			}
			float myBalance = this.GetMyBalance();
			if (num == 0)
			{
			}
			bool zoneLihzhardTemple = this.TargetPlayer.ZoneLihzhardTemple;
			bool zoneJungle = this.TargetPlayer.ZoneJungle;
			Vector2 center = this.TargetPlayer.Center;
			if (num == 0)
			{
			}
			float[] array = this.localAI;
			IEntitySource spawnSourceForNPCFromNPCAI = this.GetSpawnSourceForNPCFromNPCAI();
			Vector2 center2 = base.Center;
			Vector2 center3 = base.Center;
			if (array == null)
			{
			}
			IEntitySource spawnSourceForNPCFromNPCAI2 = this.GetSpawnSourceForNPCFromNPCAI();
			Vector2 center4 = base.Center;
			Vector2 center5 = base.Center;
			IEntitySource spawnSourceForNPCFromNPCAI3 = this.GetSpawnSourceForNPCFromNPCAI();
			Vector2 center6 = base.Center;
			Vector2 center7 = base.Center;
			int num2 = this.target;
			if (this.TargetPlayer.dead)
			{
				int num3 = 1;
				int num4 = 1;
				this.TargetClosest(num3 != 0);
				if (this.TargetPlayer.dead)
				{
					this.noTileCollide = num4 != 0;
				}
			}
			int num5 = this.alpha;
			float[] array2 = this.ai;
			int num6 = 10;
			this.alpha = num5;
			if (num5 == 0)
			{
			}
			if (num6 == 0 || num6 == 0)
			{
			}
			if (num5 == 0)
			{
			}
			if (num6 == 0 || num6 == 0)
			{
			}
			if (num5 == 0)
			{
			}
			if (num5 == 0 || num5 == 0)
			{
			}
			this.dontTakeDamage = num5 != 0;
			if (num5 == 0)
			{
			}
			if (num6 == 0)
			{
			}
			float y = this.velocity.Y;
			float x = this.position.X;
			int width = this.width;
			float y2 = this.position.Y;
			int num7 = 32640;
			if (width == 0)
			{
			}
			Tile tile;
			ushort num8 = tile.type;
			if (width == 0)
			{
			}
			long num9 = 0L;
			Tile tile2;
			tile2.active(num9 != 0L);
			bool netHost = Main.NetHost;
			if (width == 0)
			{
			}
			int width2 = this.width;
			float y3 = this.position.Y;
			float x2 = this.position.X;
			float x3 = this.position.X;
			float y4 = this.position.Y;
			float x4 = this.netOffset.X;
			float y5 = this.netOffset.Y;
			if (width2 == 0)
			{
			}
			this.position.X = x2;
			this.position.Y = y3;
			if (width2 == 0)
			{
			}
			if (width2 == 0)
			{
				Vector2 center8 = base.Center;
				float num10 = this.scale;
				Vector2 center9 = base.Center;
				if (49824 == 0)
				{
				}
				if (num7 == 0)
				{
				}
				int num11;
				if (num11 == 0)
				{
					Vector2 center10 = base.Center;
					float num12 = this.scale;
					Vector2 center11 = base.Center;
					if (49824 == 0)
					{
					}
					if (num7 == 0)
					{
					}
					int num13;
					if (num13 != 0)
					{
					}
				}
				Vector2 center12 = base.Center;
				float num14 = this.scale;
				Vector2 center13 = base.Center;
				if (17016 == 0)
				{
				}
				if (num7 == 0)
				{
				}
				int num15;
				if (num15 == 0)
				{
					Vector2 center14 = base.Center;
					float num16 = this.scale;
					Vector2 center15 = base.Center;
					if (17016 == 0)
					{
					}
					if (num7 == 0)
					{
					}
					int num17;
					if (num17 != 0)
					{
					}
				}
			}
			float x5 = this.position.X;
			float y6 = this.position.Y;
			float x6 = this.netOffset.X;
			float y7 = this.netOffset.Y;
			bool flag = this.noTileCollide;
			this.position.X = x2;
			this.position.Y = y3;
			if (flag && !this.TargetPlayer.dead)
			{
				float y8 = this.velocity.Y;
				Vector2 bottom = base.Bottom;
				Vector2 top = this.TargetPlayer.Top;
				float x7 = this.position.X;
				float y9 = this.position.Y;
				int width3 = this.width;
				bool wet = this.wet;
				Vector2 center16 = this.TargetPlayer.Center;
				float x8 = this.position.X;
				float y10 = this.position.Y;
				int width4 = this.width;
				bool wet2 = this.wet;
			}
			float[] array3 = this.ai;
			float y11 = this.velocity.Y;
			float x9 = this.velocity.X;
			this.velocity.X = x9;
			int num18 = this.life;
			if (33497088 == 0)
			{
				float[] array4 = this.ai;
			}
			int num19 = 1;
			int num20 = 1;
			this.noTileCollide = num19 != 0;
			this.TargetClosest(num20 != 0);
			int direction = this.direction;
			int num21 = this.life;
			int num22 = this.lifeMax;
			this.velocity.X = x9;
		}

		// Token: 0x170004F4 RID: 1268
		// (get) Token: 0x0600216C RID: 8556 RVA: 0x000DE478 File Offset: 0x000DC678
		public static bool IsMechQueenUp
		{
			get
			{
				if (!true)
				{
				}
				if (!false)
				{
					return;
				}
			}
		}

		// Token: 0x0600216D RID: 8557 RVA: 0x000DE48C File Offset: 0x000DC68C
		public static bool SpawnMechQueen(int onWhichPlayer)
		{
			/*
An exception occurred when decompiling this method (0600216D)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean Terraria.NPC::SpawnMechQueen(System.Int32)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0067:
	stloc:IEntitySource(var_12_6E, call:IEntitySource(NPC::GetBossSpawnSource, ldloc:int32(var_11)))
	stloc:IEntitySource(var_16_77, call:IEntitySource(NPC::GetBossSpawnSource, ldloc:int32(var_15)))
	stloc:IEntitySource(var_20_80, call:IEntitySource(NPC::GetBossSpawnSource, ldloc:int32(var_19)))
	stloc:IEntitySource(var_24_89, call:IEntitySource(NPC::GetBossSpawnSource, ldloc:int32(var_23)))
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

		// Token: 0x0600216E RID: 8558 RVA: 0x000021DB File Offset: 0x000003DB
		public void AI()
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x0600216F RID: 8559 RVA: 0x000DE524 File Offset: 0x000DC724
		private void AI_124_ElderSlimeChest()
		{
			float y = this.velocity.Y;
			this.velocity.Y = y;
		}

		// Token: 0x06002170 RID: 8560 RVA: 0x000DE54C File Offset: 0x000DC74C
		private void AI_125_ClumsySlimeBalloon()
		{
			if (this.localAI == null)
			{
			}
			int num = 1;
			int num2 = 1;
			this.TargetClosest(num != 0);
			float[] array = this.localAI;
			this.netUpdate = num2 != 0;
			int direction = this.direction;
			float x = this.velocity.X;
			int num3 = 1;
			this.spriteDirection = direction;
			this.rotation = x;
			NPCAimedTarget targetData = this.GetTargetData(num3 != 0);
			if (direction == 0)
			{
			}
			if (!true)
			{
			}
		}

		// Token: 0x06002171 RID: 8561 RVA: 0x000DE8A4 File Offset: 0x000DCAA4
		private void SpawnStardustMark_StardustTower()
		{
			if (!true)
			{
			}
			int num = NPC.CountNPCS(405);
			int num2 = NPC.CountNPCS(406);
		}

		// Token: 0x06002172 RID: 8562 RVA: 0x000DE9A4 File Offset: 0x000DCBA4
		private void SpawnStardustMark_StardustWorm()
		{
			if (!true)
			{
			}
			int num = NPC.CountNPCS(405);
			int num2 = NPC.CountNPCS(406);
		}

		// Token: 0x06002173 RID: 8563 RVA: 0x000DEA94 File Offset: 0x000DCC94
		public static bool IsDeerclopsHostile()
		{
			/*
An exception occurred when decompiling this method (06002173)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean Terraria.NPC::IsDeerclopsHostile()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_000A:
	stloc:Vector2(var_1_11, callgetter:Vector2(Main::get_screenPosition))
	stloc:Vector2(var_3_19, callgetter:Vector2(Main::get_screenPosition))
	stloc:int32(var_5_22, callgetter:int32(Main::get_screenWidth))
	stloc:int32(var_7_2C, callgetter:int32(Main::get_screenHeight))
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

		// Token: 0x06002174 RID: 8564 RVA: 0x000021DB File Offset: 0x000003DB
		private void AI_123_Deerclops()
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06002175 RID: 8565 RVA: 0x000DEAE4 File Offset: 0x000DCCE4
		private bool ShouldRunAway(NPCAimedTarget targetData, bool isChasing)
		{
			/*
An exception occurred when decompiling this method (06002175)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean Terraria.NPC::ShouldRunAway(Terraria.DataStructures.NPCAimedTarget,System.Boolean)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:Player(var_0_06, callgetter:Player(NPC::get_TargetPlayer, ldloc:NPC(this)))
	stloc:bool(var_1_0D, callgetter:bool(Player::get_ZoneSnow, ldloc:Player(var_0_06)))
	stloc:int32(var_2_14, ldfld:int32(NPC::homeTileX, ldloc:NPC(this)))
	stloc:int32(var_3_1B, ldfld:int32(NPC::homeTileY, ldloc:NPC(this)))
	stloc:bool(var_5_22, ldfld:bool(Player::dead, ldloc:Player(var_0_06)))
	stloc:Vector2(var_6_2A, callgetter:Vector2(Entity::get_Center, ldloc:Player[exp:Entity](var_0_06)))
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

		// Token: 0x06002176 RID: 8566 RVA: 0x000DEB1C File Offset: 0x000DCD1C
		private void SpawnPassiveShadowHands(float lifePercent, int shadowHandDamage)
		{
			if (!true)
			{
			}
			float[] array = this.localAI;
			int num = 32768;
			int num2 = 21846;
			long num3 = 0L;
			int num4 = 3;
			long num5 = 0L;
			float num6;
			bool flag = this.Boss_CanShootExtraAt((int)num3, 43143168, num4, num6, num5 != 0L);
			if (num == 0)
			{
			}
			if (num2 == 0)
			{
			}
			IEntitySource spawnSource_ForProjectile = this.GetSpawnSource_ForProjectile();
			int myPlayer = Main.myPlayer;
		}

		// Token: 0x06002177 RID: 8567 RVA: 0x000DEB78 File Offset: 0x000DCD78
		private void AI_123_Deerclops_ShootRubbleUp(NPCAimedTarget targetData, Point sourceTileCoords, int howMany, int distancedByThisManyTiles, float upBiasPerSpike, int whichOne)
		{
			int direction = this.direction;
			int x = sourceTileCoords.X;
		}

		// Token: 0x06002178 RID: 8568 RVA: 0x000DEBE0 File Offset: 0x000DCDE0
		private void AI_123_Deerclops_MakeSpikesForward(int AISLOT_PhaseCounter, NPCAimedTarget targetData)
		{
			if (!true)
			{
			}
			float[] array = this.ai;
			int num = 16912;
			Vector2 bottom = base.Bottom;
			if (num == 0)
			{
			}
			int direction = this.direction;
			float[] array2 = this.ai;
			Vector2 center = base.Center;
			if (17530 == 0)
			{
			}
			int direction2 = this.direction;
		}

		// Token: 0x06002179 RID: 8569 RVA: 0x000DEC30 File Offset: 0x000DCE30
		private void AI_123_Deerclops_MakeSpikesBothSides(int AISLOT_PhaseCounter, NPCAimedTarget targetData)
		{
			if (!true)
			{
			}
			float[] array = this.ai;
			int num = 16992;
			Vector2 bottom = base.Bottom;
			if (num == 0)
			{
			}
			float[] array2 = this.ai;
			Vector2 center = base.Center;
			if (17530 == 0)
			{
			}
			int direction = this.direction;
			int direction2 = this.direction;
		}

		// Token: 0x0600217A RID: 8570 RVA: 0x000DEC88 File Offset: 0x000DCE88
		public static bool IsADeerclopsNearScreen()
		{
			/*
An exception occurred when decompiling this method (0600217A)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean Terraria.NPC::IsADeerclopsNearScreen()

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

		// Token: 0x0600217B RID: 8571 RVA: 0x000DEC98 File Offset: 0x000DCE98
		private void AI_123_Deerclops_FindSpotToSpawnSpike(int howMany, int whichOne, int x, int y)
		{
			if (!true)
			{
			}
			int num = 10;
			int num2 = 32768;
			y.m_value = num;
			if (num2 == 0)
			{
			}
			if (num2 == 0)
			{
			}
		}

		// Token: 0x0600217C RID: 8572 RVA: 0x000DECD4 File Offset: 0x000DCED4
		private void AI_123_Deerclops_TryMakingSpike(Point sourceTileCoords, int dir, int howMany, int whichOne, int xOffset)
		{
			int num = this.AI_123_Deerclops_TryMakingSpike_FindBestY(sourceTileCoords, 43143168);
			bool flag = WorldGen.ActiveAndWalkableTile(43143168, num);
			if (8 == 0)
			{
			}
			IEntitySource spawnSource_ForProjectile = this.GetSpawnSource_ForProjectile();
			int myPlayer = Main.myPlayer;
		}

		// Token: 0x0600217D RID: 8573 RVA: 0x000DED14 File Offset: 0x000DCF14
		private int AI_123_Deerclops_TryMakingSpike_FindBestY(Point sourceTileCoords, int x)
		{
			/*
An exception occurred when decompiling this method (0600217D)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Int32 Terraria.NPC::AI_123_Deerclops_TryMakingSpike_FindBestY(Microsoft.Xna.Framework.Point,System.Int32)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0069:
	stloc:bool(var_15_71, call:bool(WorldGen::ActiveAndWalkableTile, ldloc:int32(x), ldloc:int32(var_5_23)))
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

		// Token: 0x0600217E RID: 8574 RVA: 0x000DED94 File Offset: 0x000DCF94
		private void AI_123_Deerclops_Movement(bool haltMovement, bool goHome)
		{
			int num = this.life;
			int num2 = this.lifeMax;
			int num3 = 1;
			NPCAimedTarget targetData = this.GetTargetData(num3 != 0);
			int num4 = this.homeTileX;
			if (this.homeTileY == 0)
			{
			}
			Point point;
			Vector2 vector = point.ToVector2();
			Vector2 center = base.Center;
			int direction = this.direction;
			Vector2 center2 = base.Center;
			if (direction == 0)
			{
			}
			if (direction == 0)
			{
			}
			float num6;
			int num5 = Math.Sign(num6);
			this.spriteDirection = num5;
			this.direction = num5;
			float[] array = this.ai;
			float x = this.velocity.X;
		}

		// Token: 0x0600217F RID: 8575 RVA: 0x000DEEF8 File Offset: 0x000DD0F8
		private void AI_124_DeerclopsLeg()
		{
			float[] array = this.ai;
			int num = 32768;
			int num2 = 32640;
			if (num2 == 0)
			{
			}
			int num3;
			if (num != 0)
			{
				NPCAimedTarget npcaimedTarget;
				Vector2 center = npcaimedTarget.Center;
				Vector2 center2 = base.Center;
				if (num2 == 0)
				{
				}
				int width = this.width;
				float x = this.position.X;
				if (num == 0)
				{
				}
				float x2 = this.position.X;
				Vector2 center3 = base.Center;
				float[] array2 = this.localAI;
				num3 = 16256;
				return;
			}
			if (num3 == 0)
			{
			}
			int whoAmI = this.whoAmI;
		}

		// Token: 0x06002180 RID: 8576 RVA: 0x000DEFB8 File Offset: 0x000DD1B8
		private static float? TryFindingFloor(Vector2 searchStartPositionInWorld, int searchRange, [Out] int tilesTraveled)
		{
			/*
An exception occurred when decompiling this method (06002180)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Nullable`1<System.Single> Terraria.NPC::TryFindingFloor(Microsoft.Xna.Framework.Vector2,System.Int32,System.Int32)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0027:
	stfld:float32(Vector2::X, ldloc:Vector2[exp:valuetype Microsoft.Xna.Framework.Vector2&](searchStartPositionInWorld), ldloc:int64[exp:float32](var_3_08))
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

		// Token: 0x06002181 RID: 8577 RVA: 0x000DEFF4 File Offset: 0x000DD1F4
		private void AI_87_BigMimic_FireStuffCannonBurst()
		{
			if (!true)
			{
			}
		}

		// Token: 0x06002182 RID: 8578 RVA: 0x000DF004 File Offset: 0x000DD204
		private void AI_87_BigMimic_ShootItem(int itemID)
		{
			IEntitySource itemSource_Loot = this.GetItemSource_Loot();
			float x = this.position.X;
			float y = this.position.Y;
			int width = this.width;
			bool wet = this.wet;
			if (32640 == 0)
			{
			}
			int width2 = this.width;
			int height = this.height;
			float x2 = this.position.X;
			float y2 = this.position.Y;
			Vector2 center = this.TargetPlayer.Center;
			if (17136 == 0)
			{
			}
			int num;
			if (num == 0)
			{
			}
		}

		// Token: 0x06002183 RID: 8579 RVA: 0x000DF0BC File Offset: 0x000DD2BC
		public void AI_122_PirateGhost()
		{
			float[] array = this.localAI;
			if (array == null)
			{
			}
			float x = this.position.X;
			float y = this.position.Y;
			int num = 1;
			bool invalid = this.GetTargetData(num != 0).Invalid;
			int num2 = 1;
			this.TargetClosest(num2 != 0);
			int num3 = 1;
			bool invalid2 = this.GetTargetData(num3 != 0).Invalid;
			float x2 = this.velocity.X;
			float y2 = this.velocity.Y;
			if (array == null)
			{
			}
			this.velocity.X = x;
			this.velocity.Y = y;
			int num4 = this.alpha;
		}

		// Token: 0x06002184 RID: 8580 RVA: 0x000DF228 File Offset: 0x000DD428
		public void AI_000_TransformBoundNPC(int playerID, int npcType)
		{
			int num = 1;
			this.Transform(npcType);
			if (num == 0)
			{
			}
			int whoAmI = this.whoAmI;
			bool netHost = Main.NetHost;
		}

		// Token: 0x06002185 RID: 8581 RVA: 0x000DF258 File Offset: 0x000DD458
		private void AI_065_Butterflies()
		{
			float[] array = this.ai;
			int num = this.type;
			if (array == null)
			{
			}
			Color color;
			Vector3 vector = color.ToVector3();
			if (array == null)
			{
			}
			int num2 = 1;
			if (num2 != 0)
			{
				return;
			}
			Vector2 center = base.Center;
			if (num2 == 0)
			{
			}
			int num3 = 1;
			bool invalid = this.GetTargetData(num3 != 0).Invalid;
			Vector2 center2 = base.Center;
		}

		// Token: 0x06002186 RID: 8582 RVA: 0x000DF5F8 File Offset: 0x000DD7F8
		public static Color AI_121_QueenSlime_GetDustColor()
		{
			/*
An exception occurred when decompiling this method (06002186)

ICSharpCode.Decompiler.DecompilerException: Error decompiling Microsoft.Xna.Framework.Graphics.Color Terraria.NPC::AI_121_QueenSlime_GetDustColor()

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

		// Token: 0x06002187 RID: 8583 RVA: 0x000DF60C File Offset: 0x000DD80C
		private void AI_121_QueenSlime_FlyMovement()
		{
			int num = 257;
			int num2 = 1;
			this.noGravity = num != 0;
			this.TargetClosest(num2 != 0);
			Vector2 center = base.Center;
			int num3 = this.timeLeft;
			Vector2 center2 = base.Center;
			int direction = this.direction;
			if (50042 == 0)
			{
			}
		}

		// Token: 0x06002188 RID: 8584 RVA: 0x000021DB File Offset: 0x000003DB
		private void AI_121_QueenSlime()
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06002189 RID: 8585 RVA: 0x000DF6E8 File Offset: 0x000DD8E8
		public bool AI_120_HallowBoss_IsInPhase2()
		{
			/*
An exception occurred when decompiling this method (06002189)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean Terraria.NPC::AI_120_HallowBoss_IsInPhase2()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:float32[](var_0_06, ldfld:float32[](NPC::ai, ldloc:NPC(this)))
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

		// Token: 0x0600218A RID: 8586 RVA: 0x000DF6FC File Offset: 0x000DD8FC
		public bool AI_120_HallowBoss_IsGenuinelyEnraged()
		{
			/*
An exception occurred when decompiling this method (0600218A)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean Terraria.NPC::AI_120_HallowBoss_IsGenuinelyEnraged()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:float32[](var_0_06, ldfld:float32[](NPC::ai, ldloc:NPC(this)))
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

		// Token: 0x0600218B RID: 8587 RVA: 0x000DF710 File Offset: 0x000DD910
		private void AI_120_HallowBoss_DoMagicEffect(Vector2 spot, int effectType, float progress)
		{
		}

		// Token: 0x0600218C RID: 8588 RVA: 0x000DF910 File Offset: 0x000DDB10
		public static bool ShouldEmpressBeEnraged()
		{
			int num = 1;
			if (num == 0)
			{
			}
			if (num == 0)
			{
			}
			if (num != 0)
			{
				return;
			}
		}

		// Token: 0x0600218D RID: 8589 RVA: 0x000DF934 File Offset: 0x000DDB34
		private void AI_120_HallowBoss()
		{
			int num = 50170;
			if (this.ai == null)
			{
			}
			bool expertMode = Main.expertMode;
			if (num == 0)
			{
			}
			bool flag = NPC.ShouldEmpressBeEnraged();
			int num2 = this.life;
			int num3 = this.lifeMax;
			float[] array = this.ai;
		}

		// Token: 0x0600218E RID: 8590 RVA: 0x000E0D78 File Offset: 0x000DEF78
		private void AI_120_HallowBoss_DashTo(Vector2 targetPosition)
		{
			if (50070 == 0)
			{
			}
			if (17224 == 0)
			{
			}
			Vector2 center = base.Center;
			if (17096 == 0)
			{
			}
			Vector2 vector;
			float num = vector.Length();
			if (17096 == 0)
			{
			}
			if (17096 == 0)
			{
			}
			if (!true)
			{
			}
		}

		// Token: 0x0600218F RID: 8591 RVA: 0x000E0DD4 File Offset: 0x000DEFD4
		public bool Boss_CanShootExtraAt(int playerIndex, int rotationIndexToAttack, int rotationSize, float attackScanDistance, bool alwaysSkipMainTarget = true)
		{
			/*
An exception occurred when decompiling this method (0600218F)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean Terraria.NPC::Boss_CanShootExtraAt(System.Int32,System.Int32,System.Int32,System.Single,System.Boolean)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0012:
	brtrue(IL_0000, logicnot:bool(ldfld:bool[][exp:bool](NPC::playerInteraction, ldloc:NPC(this))))
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

		// Token: 0x06002190 RID: 8592 RVA: 0x000E0DFC File Offset: 0x000DEFFC
		private void AI_119_Dandelion()
		{
			if (!true)
			{
			}
			int num = 1;
			if (num == 0)
			{
			}
			if (num == 0)
			{
				int num2 = this.timeLeft;
				int num3 = 10;
				this.timeLeft = num3;
			}
			int num4 = 17430;
			int num5 = 1;
			NPCAimedTarget targetData = this.GetTargetData(num5 != 0);
			if (num4 == 0)
			{
			}
			Vector2 center = base.Center;
			if (num4 == 0)
			{
			}
			Vector2 center2 = base.Center;
		}

		// Token: 0x06002191 RID: 8593 RVA: 0x000E0F1C File Offset: 0x000DF11C
		private void AI_118_Seahorses()
		{
			bool wet = this.wet;
			this.noGravity = wet;
			Vector2 center = base.Center;
			if (!wet)
			{
			}
			Vector2 top = base.Top;
		}

		// Token: 0x06002192 RID: 8594 RVA: 0x000E10C4 File Offset: 0x000DF2C4
		private void AI_117_BloodNautilus()
		{
			float[] array = this.localAI;
			int num = 255;
			this.alpha = num;
			if (array == null)
			{
			}
			bool logicHost = Main.LogicHost;
			float[] array2 = this.ai;
			int num2 = 49024;
			int num3 = 1;
			this.netUpdate = num3 != 0;
			float[] array3 = this.ai;
			if (array3 == null)
			{
			}
			int num4;
			if (num4 == 0)
			{
				float x = this.position.X;
				float y = this.position.Y;
				float x2 = this.netOffset.X;
				float y2 = this.netOffset.Y;
				if (array3 == null)
				{
				}
				int width = this.width;
				bool wet = this.wet;
				if (array3 == null)
				{
				}
				Dust dust;
				float x3 = dust.velocity.X;
				float y3 = dust.velocity.Y;
				dust.velocity.X = x3;
				dust.velocity.Y = y3;
				dust.velocity.Y = x3;
				int num5 = 120;
				dust.alpha = num5;
				if (num5 == 0)
				{
				}
				if (num2 == 0)
				{
				}
				dust.scale = x3;
				float x4 = dust.velocity.X;
				float y4 = dust.velocity.Y;
				float x5 = this.velocity.X;
				float y5 = this.velocity.Y;
				dust.velocity.X = x3;
				float x6 = this.position.X;
				float y6 = this.position.Y;
				float x7 = this.netOffset.X;
				float y7 = this.netOffset.Y;
				this.position.X = x6;
				this.position.Y = y6;
			}
			int num6 = this.target;
			int num7 = 1;
			this.TargetClosest(num7 != 0);
			int direction = this.direction;
			float[] array4 = this.ai;
			bool dead = this.TargetPlayer.dead;
			int num8;
			if (!dead)
			{
				Vector2 center = this.TargetPlayer.Center;
				Vector2 center2 = base.Center;
				if (!dead)
				{
				}
				num8 = 17658;
			}
			int num9 = 1;
			this.TargetClosest(num9 != 0);
			int num10 = 1;
			NPCAimedTarget targetData = this.GetTargetData(num10 != 0);
			if (num8 == 0)
			{
			}
			if (num2 != 0)
			{
				return;
			}
			if (num2 == 0)
			{
			}
			float[] array5 = this.ai;
		}

		// Token: 0x06002193 RID: 8595 RVA: 0x000E2564 File Offset: 0x000E0764
		private void BloodNautilus_CallForHelp()
		{
			if (!true)
			{
			}
			bool netClientOnly = Main.NetClientOnly;
			if (this.TargetPlayer.active && !this.TargetPlayer.dead)
			{
				Vector2 center = this.TargetPlayer.Center;
				int num = NPC.CountNPCS(619);
				Vector2 center2 = base.Center;
				Tile tile;
				bool flag = tile.nactive();
				long num2 = 0L;
				long num3 = 0L;
				Tile tile2;
				bool flag2 = tile2.lava();
				int num4;
				bool flag3 = Collision.SolidTiles(42168472, (int)num3, num4, (int)num2);
				Vector2 center3 = base.Center;
				Vector2 center4 = this.TargetPlayer.Center;
			}
		}

		// Token: 0x170004F5 RID: 1269
		// (get) Token: 0x06002194 RID: 8596 RVA: 0x000E2610 File Offset: 0x000E0810
		public static bool TooWindyForButterflies
		{
			get
			{
				/*
An exception occurred when decompiling this method (06002194)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean Terraria.NPC::get_TooWindyForButterflies()

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
		}

		// Token: 0x06002195 RID: 8597 RVA: 0x000E2620 File Offset: 0x000E0820
		private void AI_116_WaterStriders()
		{
			Vector2 center = base.Center;
			if (!true)
			{
			}
			Vector2 bottom = base.Bottom;
			Vector2 center2 = base.Center;
			float y = this.velocity.Y;
			this.velocity.Y = y;
		}

		// Token: 0x06002196 RID: 8598 RVA: 0x000E2730 File Offset: 0x000E0930
		private void AI_115_LadyBugs()
		{
			int num = 1;
			if (num == 0)
			{
			}
			bool logicHost = Main.LogicHost;
			float[] array = this.ai;
			if (num == 0)
			{
			}
			int num2 = 1;
			this.netUpdate = num2 != 0;
			float[] array2 = this.localAI;
			if (num2 == 0)
			{
			}
			int num3;
			int num4;
			if (num3 == 0)
			{
				float[] array3 = this.ai;
				num4 = 16256;
				int num5 = 1;
				this.netUpdate = num5 != 0;
				return;
			}
			int num6 = 1;
			this.TargetClosest(num6 != 0);
			float[] array4 = this.ai;
			int num7;
			if (num7 == 0)
			{
			}
			if (num4 == 0)
			{
			}
			Vector2 center = this.TargetPlayer.Center;
			int num8 = 17455;
			float[] array5 = this.ai;
			Vector2 center2 = this.TargetPlayer.Center;
			if (num8 == 0)
			{
			}
			if (num4 == 0)
			{
			}
			int num9 = 1;
			this.netUpdate = num9 != 0;
			float[] array6 = this.ai;
			this.scale = (float)num4;
			if (num4 == 0)
			{
			}
			float num10;
			Vector2 vector = num10.ToRotationVector2();
			if (array6 == null)
			{
			}
			if (array6 == null)
			{
			}
			float x = this.velocity.X;
			float y = this.velocity.Y;
			this.velocity.X = x;
			this.velocity.Y = y;
			Vector2 center3 = base.Center;
			Vector2 center4 = base.Center;
			Tile tile;
			bool flag = tile.nactive();
			if (-2147483648 == 0)
			{
			}
			Tile tile2;
			ushort num11 = tile2.type;
			if (-2147483648 == 0)
			{
				if (-2147483648 == 0)
				{
				}
				Tile tile3;
				byte liquid = tile3.liquid;
			}
			float[] array7 = this.ai;
			float y2 = this.velocity.Y;
			this.velocity.Y = y2;
			float y3 = this.velocity.Y;
			Vector2 center5 = base.Center;
			Vector2 center6 = base.Center;
			if (array7 == null)
			{
			}
			Tile tile4;
			bool flag2 = tile4.nactive();
			if (-2147483648 == 0)
			{
			}
			Tile tile5;
			ushort num12 = tile5.type;
			if (-2147483648 == 0)
			{
				if (-2147483648 == 0)
				{
				}
				Tile tile6;
				byte liquid2 = tile6.liquid;
			}
			float[] array8 = this.ai;
			float y4 = this.velocity.Y;
			this.velocity.Y = y4;
			if (this.collideX)
			{
				float[] array9 = this.ai;
				float x2 = this.velocity.X;
				return;
			}
			float x3 = this.velocity.X;
			int num13;
			this.direction = num13;
		}

		// Token: 0x06002197 RID: 8599 RVA: 0x000E2B1C File Offset: 0x000E0D1C
		private void AI_114_Dragonflies()
		{
			if (this.localAI == null)
			{
			}
			bool logicHost = Main.LogicHost;
			float[] array = this.localAI;
			int num = 16256;
			Vector2 center = base.Center;
			if (this.ai == null)
			{
			}
			if (num == 0)
			{
			}
			float[] array2 = this.ai;
			int num2 = 1;
			this.netUpdate = num2 != 0;
			float[] array3 = this.ai;
			if (32640 == 0)
			{
				float x = this.velocity.X;
				float y = this.velocity.Y;
				if (-2147483648 == 0)
				{
				}
				float y2;
				this.velocity.X = y2;
				bool logicHost2 = Main.LogicHost;
				if (this.ai == null)
				{
				}
				float[] array4 = this.ai;
				if (17088 == 0)
				{
				}
				return;
			}
			float[] array5 = this.ai;
			int num3 = 1;
			this.netUpdate = num3 != 0;
			Vector2 center2 = base.Center;
			Vector2 center3 = base.Center;
			if (num3 == 0)
			{
			}
			Tile tile;
			bool flag = tile.nactive();
			if (-2147483648 == 0)
			{
			}
			Tile tile2;
			ushort num4 = tile2.type;
			if (-2147483648 == 0)
			{
				if (-2147483648 == 0)
				{
				}
				Tile tile3;
				byte liquid = tile3.liquid;
			}
			float y3 = this.velocity.Y;
			this.velocity.Y = y3;
			this.velocity.Y = y3;
			float y4 = this.velocity.Y;
			if (-2147483648 == 0)
			{
			}
			Tile tile4;
			bool flag2 = tile4.nactive();
			if (-2147483648 == 0)
			{
			}
			Tile tile5;
			ushort num5 = tile5.type;
			if (-2147483648 == 0)
			{
				float y2 = this.velocity.Y;
				this.velocity.Y = y2;
				return;
			}
			float x2 = this.velocity.X;
			float[] array6;
			this.direction = array6;
			if (this.wet)
			{
				int num6 = 49216;
				this.velocity.Y = (float)num6;
			}
			float[] array7 = this.localAI;
		}

		// Token: 0x06002198 RID: 8600 RVA: 0x000E2F00 File Offset: 0x000E1100
		private void AI_113_WindyBalloon()
		{
			if (this.localAI == null)
			{
			}
			bool logicHost = Main.LogicHost;
			int num = 1;
			this.TargetClosest(num != 0);
			float[] array = this.localAI;
			float[] array2 = this.ai;
			if (array == null)
			{
			}
			IEntitySource spawnSourceForNPCFromNPCAI = this.GetSpawnSourceForNPCFromNPCAI();
			float x = this.position.X;
			float y = this.position.Y;
			if (array == null)
			{
			}
			int num2 = 32640;
			if (num2 != 0)
			{
				int num3;
				if (num3 != 0)
				{
					if (num2 != 0)
					{
						int num4;
						int num5;
						if (num4 != 0 && num5 == 0)
						{
							return;
						}
					}
					else
					{
						int num4;
						while (num4 != 0)
						{
						}
					}
					int num6 = 1;
					float[] array3 = this.ai;
					this.netUpdate = num6 != 0;
					Vector2 center = base.Center;
					float[] array4 = this.ai;
					if (array3 == null)
					{
					}
					float[] array5 = this.ai;
					float x2 = this.position.X;
					float y2 = this.position.Y;
					this.scale = array5;
					NPC npc = this.AI_113_WindyBalloon_GetSlaveNPC();
					float x3 = this.velocity.X;
					this.rotation = x3;
					if (npc != null)
					{
						int num7 = 1;
						NPCAimedTarget targetData = this.GetTargetData(num7 != 0);
						if (array5 == null)
						{
						}
						if (!true)
						{
						}
						return;
					}
					float y3 = this.velocity.Y;
					this.velocity.Y = y3;
					float x4 = this.velocity.X;
					if (this.collideX || this.collideY)
					{
						int direction = this.direction;
						float x5 = this.oldVelocity.X;
						float x6 = this.position.X;
						this.position.X = x5;
						return;
					}
					return;
				}
			}
			else
			{
				int num4;
				while (num4 != 0)
				{
				}
			}
		}

		// Token: 0x06002199 RID: 8601 RVA: 0x000E3430 File Offset: 0x000E1630
		public NPC AI_113_WindyBalloon_GetSlaveNPC()
		{
			/*
An exception occurred when decompiling this method (06002199)

ICSharpCode.Decompiler.DecompilerException: Error decompiling Terraria.NPC Terraria.NPC::AI_113_WindyBalloon_GetSlaveNPC()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0013:
	stloc:float32[](var_2_19, ldfld:float32[](NPC::ai, ldloc:NPC(this)))
	stloc:int32(var_5_24, ldc.i4:int32(1))
	stfld:bool(NPC::netUpdate, ldloc:NPC(this), ldloc:int32[exp:bool](var_5_24))
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

		// Token: 0x0600219A RID: 8602 RVA: 0x000E3470 File Offset: 0x000E1670
		private void AI_112_FairyCritter()
		{
			int num = 1;
			this.lavaImmune = num != 0;
			if (num == 0)
			{
			}
			bool logicHost = Main.LogicHost;
			float[] array = this.ai;
			float[] array2 = this.localAI;
			Vector2 center = this.TargetPlayer.Center;
			Vector2 center2 = base.Center;
			int num2 = 1;
			this.direction = array;
			this.netUpdate = num2 != 0;
			float[] array3 = this.ai;
		}

		// Token: 0x0600219B RID: 8603 RVA: 0x000E4388 File Offset: 0x000E2588
		public static void FairyEffects(Vector2 Position, int type)
		{
			if (!true)
			{
			}
		}

		// Token: 0x0600219C RID: 8604 RVA: 0x000E441C File Offset: 0x000E261C
		private void GetBirdFlightRecommendation(int downScanRange, int upRange, Point tCoords, [Out] bool goDownwards, [Out] bool goUpwards)
		{
			int direction = this.direction;
			int num = 1;
			goDownwards.m_value = num != 0;
			if (direction == 0)
			{
			}
			if (direction == 0)
			{
			}
			Tile tile;
			bool isLoaded = tile.IsLoaded;
			if (direction == 0)
			{
			}
			if (direction == 0)
			{
				return;
			}
			int num2 = 1;
			goUpwards.m_value = num2 != 0;
		}

		// Token: 0x0600219D RID: 8605 RVA: 0x000E445C File Offset: 0x000E265C
		private Vector2 GetFairyCircleOffset(float elapsedTime, float circleRotation, float circleHeight)
		{
			/*
An exception occurred when decompiling this method (0600219D)

ICSharpCode.Decompiler.DecompilerException: Error decompiling Microsoft.Xna.Framework.Vector2 Terraria.NPC::GetFairyCircleOffset(System.Single,System.Single,System.Single)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0003:
	stloc:Vector2(var_1_0B, call:Vector2(Utils::ToRotationVector2, ldloc:float32(elapsedTime)))
	stloc:int32(var_4_14, ldfld:int32(Entity::direction, ldloc:NPC[exp:Entity](this)))
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

		// Token: 0x0600219E RID: 8606 RVA: 0x000E4484 File Offset: 0x000E2684
		private bool GetFairyTreasureCoords([Out] Point treasureCoords)
		{
			/*
An exception occurred when decompiling this method (0600219E)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean Terraria.NPC::GetFairyTreasureCoords(Microsoft.Xna.Framework.Point)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_006B:
	stloc:uint16(var_27_72, callgetter:uint16(Tile::get_type, ldloc:Tile[exp:valuetype Terraria.Tile&](var_26)))
	stfld:int32(int32::m_value, ldc.i4:int32[exp:int32&](8), ldloc:Rectangle[exp:int32](var_10))
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

		// Token: 0x0600219F RID: 8607 RVA: 0x000021DB File Offset: 0x000003DB
		private void AI_069_DukeFishron()
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x060021A0 RID: 8608 RVA: 0x000E450C File Offset: 0x000E270C
		private void AI_037_Destroyer()
		{
			if (!true)
			{
			}
			bool isMechQueenUp = NPC.IsMechQueenUp;
			int num = this.type;
			float[] array = this.ai;
			float[] array2 = this.ai;
			int num2 = 32768;
			this.realLife = num2;
			int num3 = this.target;
			if (this.TargetPlayer.dead)
			{
				int num4 = 1;
				this.TargetClosest(num4 != 0);
			}
			int num5 = this.type;
			if (this.type == 0)
			{
			}
			float[] array3 = this.ai;
			int num6 = this.alpha;
			int num7;
			if (num6 != 0)
			{
				float x = this.position.X;
				float y = this.position.Y;
				int width = this.width;
				bool wet = this.wet;
				if (num6 == 0)
				{
				}
				num7 = this.alpha;
			}
			this.alpha = num7;
			int num8 = this.type;
			float[] array4;
			if (this.ai == null)
			{
				array4 = this.ai;
			}
			long num9 = 0L;
			float num10;
			this.HitEffect((int)num9, (double)num10);
			this.checkDead();
			if (array4 == null)
			{
			}
			bool logicHost = Main.LogicHost;
			float[] array5 = this.ai;
			int num11 = this.type;
			int whoAmI = this.whoAmI;
			this.realLife = whoAmI;
			if (array5 == null)
			{
			}
			int destroyerSegmentsCount = NPC.GetDestroyerSegmentsCount();
			int num12 = 135;
			IEntitySource spawnSourceForNPCFromNPCAI = this.GetSpawnSourceForNPCFromNPCAI();
			float x2 = this.position.X;
			float y2 = this.position.Y;
			int width2 = this.width;
			bool wet2 = this.wet;
			int whoAmI2 = this.whoAmI;
			if (num12 == 0)
			{
			}
			if (num11 == 0)
			{
			}
			int whoAmI3 = this.whoAmI;
			int num13 = this.type;
			float[] array6 = this.localAI;
			float[] array7 = this.localAI;
			float[] array8 = this.localAI;
			int num14 = 1;
			this.TargetClosest(num14 != 0);
			float x3 = this.position.X;
			float y3 = this.position.Y;
			int width3 = this.width;
			bool wet3 = this.wet;
			Player targetPlayer = this.TargetPlayer;
			float x4 = targetPlayer.position.X;
			float y4 = targetPlayer.position.Y;
			int width4 = this.TargetPlayer.width;
			int height = this.TargetPlayer.height;
			if (num13 == 0)
			{
			}
			int height2 = this.height;
			int width5 = this.width;
			float x5 = this.position.X;
			float y5 = this.position.Y;
			float x6 = this.TargetPlayer.position.X;
			Player targetPlayer2 = this.TargetPlayer;
			int width6 = targetPlayer2.width;
			if (targetPlayer2 == null)
			{
			}
			Player targetPlayer3 = this.TargetPlayer;
			Player targetPlayer4 = this.TargetPlayer;
			if (num13 == 0)
			{
			}
			IEntitySource spawnSource_ForProjectile = this.GetSpawnSource_ForProjectile();
			int myPlayer = Main.myPlayer;
			if (num13 == 0)
			{
			}
			long num15 = 0L;
			int num16 = 1;
			this.netUpdate = num16 != 0;
			float x7 = this.position.X;
			float y6 = this.position.Y;
			int width7 = this.width;
			int height3 = this.height;
			int num17 = 15744;
			int num18 = 32640;
			if (num18 != 0)
			{
				return;
			}
			if (num17 == 0)
			{
			}
			if (num18 != 0)
			{
				return;
			}
			if (num18 == 0)
			{
			}
			if (num18 == 0)
			{
			}
			if (num15 == 0L)
			{
			}
			float x8 = this.position.X;
			int width8 = this.width;
			float y7 = this.position.Y;
			int height4 = this.height;
		}

		// Token: 0x060021A1 RID: 8609 RVA: 0x000E4DA4 File Offset: 0x000E2FA4
		private void AI_005_EaterOfSouls()
		{
			int num = this.type;
		}

		// Token: 0x060021A2 RID: 8610 RVA: 0x000E5DB0 File Offset: 0x000E3FB0
		public void CopyInteractions(NPC npc)
		{
			bool[] array = this.playerInteraction;
			bool[] array2 = npc.playerInteraction;
			int num = npc.lastInteraction;
			this.lastInteraction = num;
		}

		// Token: 0x060021A3 RID: 8611 RVA: 0x000E5DDC File Offset: 0x000E3FDC
		public static int GetEaterOfWorldsSegmentsCount()
		{
			/*
An exception occurred when decompiling this method (060021A3)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Int32 Terraria.NPC::GetEaterOfWorldsSegmentsCount()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0003:
	stloc:bool(var_1_0A, callgetter:bool(Main::get_expertMode))
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

		// Token: 0x060021A4 RID: 8612 RVA: 0x000E5DF4 File Offset: 0x000E3FF4
		public static int GetEaterOfWorldsSegmentsCountByGamemode(int gamemode)
		{
			if (!true)
			{
			}
			return 65;
		}

		// Token: 0x060021A5 RID: 8613 RVA: 0x000E5E08 File Offset: 0x000E4008
		public static int GetBrainOfCthuluCreepersCount()
		{
			/*
An exception occurred when decompiling this method (060021A5)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Int32 Terraria.NPC::GetBrainOfCthuluCreepersCount()

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

		// Token: 0x060021A6 RID: 8614 RVA: 0x000E5E18 File Offset: 0x000E4018
		public static int GetDestroyerSegmentsCount()
		{
			/*
An exception occurred when decompiling this method (060021A6)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Int32 Terraria.NPC::GetDestroyerSegmentsCount()

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

		// Token: 0x060021A7 RID: 8615 RVA: 0x000E5E28 File Offset: 0x000E4028
		public Vector2 GetMechQueenCenter()
		{
			/*
An exception occurred when decompiling this method (060021A7)

ICSharpCode.Decompiler.DecompilerException: Error decompiling Microsoft.Xna.Framework.Vector2 Terraria.NPC::GetMechQueenCenter()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_001A:
	stloc:Vector2(var_5_22, callgetter:Vector2(Entity::get_Center, ldloc:NPC[exp:Entity](this)))
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

		// Token: 0x060021A8 RID: 8616 RVA: 0x000E5E58 File Offset: 0x000E4058
		private void AI_006_Worms()
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

		// Token: 0x060021A9 RID: 8617 RVA: 0x000E677C File Offset: 0x000E497C
		private void AI_002_FloatingEye()
		{
			if (this.type == 0)
			{
			}
			int num;
			if (num == 0)
			{
				float x = this.position.X;
				float y = this.position.Y;
			}
			bool flag = this.noTileCollide;
			int num2 = 1;
			this.noGravity = num2 != 0;
			if (!flag)
			{
				if (this.collideX)
				{
					float x2 = this.oldVelocity.X;
					int direction = this.direction;
					this.velocity.X = x2;
					return;
				}
				if (this.collideY)
				{
					float y2 = this.oldVelocity.Y;
					this.velocity.Y = y2;
					return;
				}
			}
			int num3 = this.type;
			float x3 = this.position.X;
			float y3 = this.position.Y;
			int num4 = this.target;
			int num5 = this.timeLeft;
			int num6 = 10;
			this.timeLeft = num6;
			float y4 = this.velocity.Y;
			int num7 = 1;
			this.despawnEncouraged = num7 != 0;
			this.directionY = num6;
			this.direction = num7;
			float x4 = this.velocity.X;
			this.direction = num6;
			int num8 = 1;
			this.direction = num8;
		}

		// Token: 0x060021AA RID: 8618 RVA: 0x000E70C4 File Offset: 0x000E52C4
		private void StingerExplosion()
		{
			if (!true)
			{
			}
			float num = this.scale;
			int num2 = this.type;
			IEntitySource spawnSource_ForProjectile = this.GetSpawnSource_ForProjectile();
			Vector2 center = base.Center;
			Vector2 center2 = base.Center;
			if (num2 == 0)
			{
			}
			int myPlayer = Main.myPlayer;
		}

		// Token: 0x060021AB RID: 8619 RVA: 0x000E7114 File Offset: 0x000E5314
		public static bool DespawnEncouragement_AIStyle2_FloatingEye_IsDiscouraged(int npcID, Vector2 npcPosition, int target = 255)
		{
			/*
An exception occurred when decompiling this method (060021AB)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean Terraria.NPC::DespawnEncouragement_AIStyle2_FloatingEye_IsDiscouraged(System.Int32,Microsoft.Xna.Framework.Vector2,System.Int32)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0003:
	stloc:bool(var_2_0A, call:bool(Main::IsItDay))
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

		// Token: 0x060021AC RID: 8620 RVA: 0x000E7130 File Offset: 0x000E5330
		private bool AI_007_TownEntities_IsInAGoodRestingSpot(int tileX, int tileY, int idealRestX, int idealRestY)
		{
			if (!true)
			{
			}
			if (true)
			{
				int num = this.type;
				if (this.wet)
				{
					return;
				}
			}
			float[] array = this.ai;
			if (array == null)
			{
			}
			if (array == null)
			{
				return;
			}
		}

		// Token: 0x060021AD RID: 8621 RVA: 0x000E7160 File Offset: 0x000E5360
		private void AI_007_FindGoodRestingSpot(int myTileX, int myTileY, [Out] int floorX, [Out] int floorY)
		{
			int num = this.homeTileX;
			floorX.m_value = num;
			int num2 = this.homeTileY;
			floorY.m_value = num2;
			if (num == 0)
			{
			}
			if (num == 0)
			{
			}
		}

		// Token: 0x060021AE RID: 8622 RVA: 0x000E7254 File Offset: 0x000E5454
		private void AI_007_TryForcingSitting(int homeFloorX, int homeFloorY)
		{
			if (!true)
			{
			}
			int num = this.type;
			if (this.type == 0)
			{
				float[] array = this.ai;
				Vector2 bottom = base.Bottom;
				if (array == null)
				{
				}
				int num2 = 1;
				if (num2 == 0)
				{
				}
				if (num2 == 0)
				{
				}
				if (num2 == 0)
				{
				}
				int num3 = 1;
				if (num3 == 0)
				{
				}
				if (num3 == 0)
				{
				}
				Point point;
				Point point2;
				bool flag = point == point2;
				float[] array2 = this.ai;
				int num4 = 16544;
				if (num4 == 0)
				{
				}
				this.direction = num4;
				if (num4 == 0)
				{
				}
				if (!true)
				{
				}
				float[] array3 = this.localAI;
				int num5 = 1;
				this.netUpdate = num5 != 0;
			}
		}

		// Token: 0x060021AF RID: 8623 RVA: 0x000E72FC File Offset: 0x000E54FC
		public void UpdateHomeTileState(bool homeless, int x, int y)
		{
			int num = this.homeTileX;
			int num2 = this.homeTileY;
			bool flag = this.homeless;
			this.homeTileX = x;
			this.homeTileY = y;
		}

		// Token: 0x060021B0 RID: 8624 RVA: 0x000E735C File Offset: 0x000E555C
		public Color GetMagicAuraColor()
		{
			/*
An exception occurred when decompiling this method (060021B0)

ICSharpCode.Decompiler.DecompilerException: Error decompiling Microsoft.Xna.Framework.Graphics.Color Terraria.NPC::GetMagicAuraColor()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0003:
	stloc:int32(var_0_09, ldfld:int32(NPC::townNpcVariationIndex, ldloc:NPC(this)))
	stloc:int32(var_1_10, ldfld:int32(NPC::type, ldloc:NPC(this)))
	stloc:int32(var_2_17, ldfld:int32(NPC::townNpcVariationIndex, ldloc:NPC(this)))
	stloc:int32(var_3_1E, ldfld:int32(NPC::type, ldloc:NPC(this)))
	stloc:int32(var_4_25, ldfld:int32(NPC::townNpcVariationIndex, ldloc:NPC(this)))
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

		// Token: 0x060021B1 RID: 8625 RVA: 0x000021DB File Offset: 0x000003DB
		private void AI_007_TownEntities()
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x060021B2 RID: 8626 RVA: 0x000E7390 File Offset: 0x000E5590
		private void AI_007_TownEntities_Shimmer_TeleportToLandingSpot()
		{
			Vector2? vector = this.AI_007_TownEntities_Shimmer_ScanForBestSpotToLandOn();
			float x = this.position.X;
			float y = this.position.Y;
			Vector2 vector2;
			float num = vector2.Length();
			float[] array = this.ai;
			Vector2 size = base.Size;
			if (array == null)
			{
			}
			if (array == null)
			{
			}
			this.netUpdate = true;
		}

		// Token: 0x060021B3 RID: 8627 RVA: 0x000E73EC File Offset: 0x000E55EC
		private Vector2? AI_007_TownEntities_Shimmer_ScanForBestSpotToLandOn()
		{
			int num = 1;
			Vector2 top = base.Top;
			if (num == 0)
			{
			}
			if (this.homeless)
			{
				int num2 = this.homeTileX;
				int num3 = this.homeTileY;
			}
			Vector2? vector;
			return vector;
		}

		// Token: 0x060021B4 RID: 8628 RVA: 0x000E74C8 File Offset: 0x000E56C8
		private void AI_007_TownEntities_TeleportToHome(int homeFloorX, int homeFloorY)
		{
			if (this.type == 0)
			{
			}
			int num = 1;
			this.homeless = num != 0;
			int whoAmI = this.whoAmI;
			if (num == 0)
			{
			}
			WorldGen.QuickFindHome(whoAmI);
		}

		// Token: 0x060021B5 RID: 8629 RVA: 0x000E751C File Offset: 0x000E571C
		private void AI_007_TownEntities_GetWalkPrediction(int myTileX, int homeFloorX, bool canBreathUnderWater, bool currentlyDrowning, int tileX, int tileY, [Out] bool keepwalking, [Out] bool avoidFalling)
		{
			if (this.townNPC)
			{
				float[] array = this.ai;
				Vector2 top = base.Top;
				Vector2 bottom = base.Bottom;
				int width = this.width;
				if (array == null)
				{
				}
				Rectangle hitbox = base.Hitbox;
				if (this.whoAmI == 0)
				{
				}
				Rectangle rectangle;
				bool flag = rectangle.Intersects(rectangle);
			}
			int num = 1;
			keepwalking.m_value = num != 0;
		}

		// Token: 0x060021B6 RID: 8630 RVA: 0x000021DB File Offset: 0x000003DB
		private bool AI_007_TownEntities_CheckIfWillDrown(bool currentlyDrowning)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x060021B7 RID: 8631 RVA: 0x000E7618 File Offset: 0x000E5818
		private void AI_007_AttemptToPlayIdleAnimationsForPets(int petIdleChance)
		{
			int num = 1;
			float x = this.velocity.X;
			if (num == 0)
			{
			}
			bool logicHost = Main.LogicHost;
			if (num == 0)
			{
			}
			int num2;
			if (num2 == 0)
			{
				int num3 = this.type;
				if (num != 0)
				{
					return;
				}
				int num4 = this.type;
				float[] array = this.ai;
				if (num4 != 0)
				{
					return;
				}
				if (num4 == 0)
				{
				}
				int num5 = 22;
				float[] array2 = this.ai;
				if (num5 == 0)
				{
				}
				float[] array3 = this.ai;
				if (this.type == 0)
				{
				}
				float[] array4 = this.ai;
				if (this.type == 0)
				{
				}
				float[] array5 = this.ai;
				if (this.type == 0)
				{
				}
				float[] array6 = this.ai;
				if (array6 == null)
				{
				}
				if (array6 != null)
				{
					float[] array7 = this.ai;
					if (array6 == null)
					{
					}
				}
				float[] array8 = this.ai;
				int num6 = 1;
				float[] array9 = this.localAI;
				this.netUpdate = num6 != 0;
			}
		}

		// Token: 0x060021B8 RID: 8632 RVA: 0x000E770C File Offset: 0x000E590C
		public bool NPCCanStickToWalls()
		{
			int num = 1;
			Vector2 center = base.Center;
			Vector2 center2 = base.Center;
			Tile tile;
			bool flag = tile.active();
			if (num == 0)
			{
			}
			if (num == 0)
			{
				return;
			}
			if (num == 0)
			{
			}
			if (num != 0)
			{
				return;
			}
		}

		// Token: 0x060021B9 RID: 8633 RVA: 0x000E774C File Offset: 0x000E594C
		private bool AI_003_Gnomes_ShouldTurnToStone()
		{
			if (!true)
			{
			}
			float y = this.position.Y;
			if (15744 == 0)
			{
			}
			float x = this.position.X;
			float y2 = this.position.Y;
			int width = this.width;
			bool wet = this.wet;
			bool flag;
			return flag;
		}

		// Token: 0x060021BA RID: 8634 RVA: 0x000E779C File Offset: 0x000E599C
		private void AI_003_Fighters()
		{
			int num = 1;
			float y = this.TargetPlayer.position.Y;
			int height = this.TargetPlayer.height;
			int height2 = this.height;
			float y2 = this.position.Y;
			this.directionY = num;
			int num2 = this.type;
			bool flag = this.AI_003_Gnomes_ShouldTurnToStone();
			Vector2 center = base.Center;
			int num3 = 15744;
			int num4 = 32640;
			Vector2 bottom = base.Bottom;
			float x = this.position.X;
			float y3 = this.position.Y;
			float x2 = this.netOffset.X;
			float y4 = this.netOffset.Y;
			if (num3 == 0)
			{
			}
			this.position.X = (float)height;
			this.position.Y = (float)height2;
			int width = this.width;
			bool wet = this.wet;
			if (num3 == 0)
			{
			}
			if (num4 == 0)
			{
			}
			float x3 = this.position.X;
			float y5 = this.position.Y;
			float x4 = this.netOffset.X;
			float y6 = this.netOffset.Y;
			this.position.X = x3;
			this.position.Y = y5;
			bool flag2 = WorldGen.SolidTileAllowBottomSlope(0, wet ? 1 : 0);
			float x5 = this.position.X;
			float y7 = this.position.Y;
			float x6 = this.netOffset.X;
			float y8 = this.netOffset.Y;
			if (!false)
			{
			}
			this.position.X = x3;
			this.position.Y = y5;
			int width2 = this.width;
			bool wet2 = this.wet;
			if (!false)
			{
			}
			long num5 = 0L;
			if (num4 == 0)
			{
			}
			float x7 = this.position.X;
			float y9 = this.position.Y;
			float x8 = this.netOffset.X;
			float y10 = this.netOffset.Y;
			this.position.X = x7;
			this.position.Y = y9;
			bool logicHost = Main.LogicHost;
			int direction = this.direction;
			int num6 = 5;
			if (num4 == 0)
			{
			}
			int num7 = 567;
			long num8 = 0L;
			long num9 = 0L;
			int num10;
			bool flag3 = WorldGen.PlaceTile(0, num6, num7, num8 != 0L, num9 != 0L, (int)num5, num10);
			if (!false)
			{
			}
			bool netHost = Main.NetHost;
			if (!false)
			{
			}
			bool logicHost2 = Main.LogicHost;
			bool flag4 = this.IsNPCValidForBestiaryKillCredit();
			if (!false)
			{
			}
			this.CountKillForBannersAndDropThem();
			AchievementsHelper.NotifyProgressionEvent(24);
		}

		// Token: 0x060021BB RID: 8635 RVA: 0x000EB3A8 File Offset: 0x000E95A8
		public static bool DespawnEncouragement_AIStyle3_Fighters_NotDiscouraged(int npcID, Vector2 position, NPC npcInstance)
		{
			int num = 1;
			if (num == 0)
			{
			}
			if (num != 0)
			{
				return;
			}
			if (num == 0)
			{
			}
			bool flag = Main.IsItDay();
			if (npcID != 0 && num != 0)
			{
				return;
			}
			if (num == 0)
			{
			}
			if (npcID != 0)
			{
				Player player;
				bool zoneGraveyard = player.ZoneGraveyard;
			}
			if (num == 0)
			{
			}
			if (npcID != 0)
			{
				return;
			}
		}

		// Token: 0x060021BC RID: 8636 RVA: 0x000EB3EC File Offset: 0x000E95EC
		public static bool DespawnEncouragement_AIStyle3_Fighters_CanBeBusyWithAction(int npcID)
		{
		}

		// Token: 0x060021BD RID: 8637 RVA: 0x000EB3FC File Offset: 0x000E95FC
		private void AI_001_Slimes()
		{
			int num = this.type;
			float[] array = this.ai;
			int num2 = 17046;
			Vector2 center = base.Center;
			Vector2 center2 = base.Center;
			if (num2 == 0)
			{
			}
			int num3;
			if (num3 == 0)
			{
				Vector2 center3 = base.Center;
				int height = this.height;
				int width = this.width;
				bool wet = this.wet;
				int num4 = 52429;
				int num5 = 16128;
				int num6 = 1;
				Dust dust;
				dust.scale = (float)num5;
				dust.fadeIn = (float)num4;
				dust.noGravity = num6 != 0;
				dust.noLight = num6 != 0;
				return;
			}
			int num7 = this.type;
			if (this.ai == null)
			{
			}
			bool logicHost = Main.LogicHost;
			float num8 = this.value;
			float[] array2 = this.ai;
			int num9 = 49024;
			if (array2 == null)
			{
			}
			float[] array3;
			if (array2 != null)
			{
				array3 = this.ai;
				if (array3 == null)
				{
				}
				int num10;
				if (num10 == 0)
				{
					float[] array4 = this.ai;
					int num11 = 1;
					this.netUpdate = num11 != 0;
					goto IL_0135;
				}
			}
			if (array3 == null)
			{
			}
			int num12;
			if (num12 == 0)
			{
				float[] array5 = this.ai;
				if (num9 == 0)
				{
				}
				int num13 = NPC.AI_001_Slimes_GenerateItemInsideBody(true);
				float[] array6 = this.ai;
				int num14 = 1;
				this.netUpdate = num14 != 0;
				return;
			}
			IL_0135:
			int num15 = this.type;
			float[] array7 = this.ai;
		}

		// Token: 0x060021BE RID: 8638 RVA: 0x000ED284 File Offset: 0x000EB484
		public void AI_001_SetRainbowSlimeColor()
		{
			if (!true)
			{
			}
			this.color = 100;
			this.alpha = 175;
			this.color.B = 1;
		}

		// Token: 0x060021BF RID: 8639 RVA: 0x000ED2B4 File Offset: 0x000EB4B4
		private static int AI_001_Slimes_GenerateItemInsideBody(bool isBallooned)
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
			return 4367;
		}

		// Token: 0x060021C0 RID: 8640 RVA: 0x000ED334 File Offset: 0x000EB534
		private void AI_110_Betsy()
		{
			int num = 1;
			NPCAimedTarget targetData = this.GetTargetData(num != 0);
			float[] array = this.ai;
			int num2 = 1;
			this.netUpdate = num2 != 0;
		}

		// Token: 0x060021C1 RID: 8641 RVA: 0x000ED968 File Offset: 0x000EBB68
		private void AI_026_Unicorns()
		{
			float y = this.velocity.Y;
			int direction = this.direction;
			int direction2 = this.direction;
			float[] array = this.ai;
		}

		// Token: 0x060021C2 RID: 8642 RVA: 0x000EE698 File Offset: 0x000EC898
		private void AI_107_ImprovedWalkers()
		{
			float x = this.velocity.X;
			float y = this.velocity.Y;
			bool flag = this.justHit;
		}

		// Token: 0x060021C3 RID: 8643 RVA: 0x000021DB File Offset: 0x000003DB
		private void AI_084_LunaticCultist()
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x060021C4 RID: 8644 RVA: 0x000021DB File Offset: 0x000003DB
		private void AI_108_DivingFlyer()
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x060021C5 RID: 8645 RVA: 0x000F09E8 File Offset: 0x000EEBE8
		private void AI_109_DarkMage()
		{
			int num = 1;
			NPCAimedTarget targetData = this.GetTargetData(num != 0);
			int num2 = this.type;
			int direction = this.direction;
			float x = this.velocity.X;
			float[] array = this.localAI;
			this.rotation = x;
			this.spriteDirection = direction;
			Vector2 top = base.Top;
			Vector2 bottom = base.Bottom;
			int width = this.width;
			float[] array2 = this.ai;
			float[] array3 = this.ai;
			if (17056 == 0)
			{
			}
			Vector2 center = base.Center;
			float[] array4 = this.ai;
			if (17024 == 0)
			{
			}
			bool logicHost = Main.LogicHost;
			IEntitySource spawnSource_ForProjectile = this.GetSpawnSource_ForProjectile();
			Vector2 center2 = base.Center;
			int direction2 = this.direction;
			if (49696 == 0)
			{
			}
			if (!true)
			{
			}
			int myPlayer = Main.myPlayer;
			Vector2 center3 = base.Center;
			float[] array5 = this.ai;
			Vector2 center4 = base.Center;
			if (this.direction == 0)
			{
			}
			if (!true)
			{
			}
			bool logicHost2 = Main.LogicHost;
			IEntitySource spawnSource_ForProjectile2 = this.GetSpawnSource_ForProjectile();
			Vector2 center5 = base.Center;
			int direction3 = this.direction;
			if (direction3 == 0)
			{
			}
			if (direction3 == 0)
			{
			}
			int myPlayer2 = Main.myPlayer;
			float[] array6 = this.ai;
			int num3 = 17148;
			if (array6 == null)
			{
			}
			Vector2 center6 = base.Center;
			if (this.ai == null)
			{
			}
			bool logicHost3 = Main.LogicHost;
			float[] array7 = this.ai;
			Vector2 center7 = base.Center;
			int direction4 = this.direction;
			Vector2 center8 = base.Center;
			IEntitySource spawnSource_ForProjectile3 = this.GetSpawnSource_ForProjectile();
			if (num3 == 0)
			{
			}
			if (!true)
			{
			}
			int num4 = num3.m_value;
			int myPlayer3 = Main.myPlayer;
			if (num3 == 0)
			{
			}
			float[] array8 = this.ai;
		}

		// Token: 0x060021C6 RID: 8646 RVA: 0x000F10A0 File Offset: 0x000EF2A0
		private void AI_111_DD2LightningBug()
		{
			Vector2 center = base.Center;
			int num = 1;
			NPCAimedTarget targetData = this.GetTargetData(num != 0);
			int num2 = this.type;
			int num3 = this.spriteDirection;
			if (num3 == 0)
			{
			}
			float x = this.position.X;
			float y = this.position.Y;
			float x2 = this.netOffset.X;
			float y2 = this.netOffset.Y;
			this.position.X = x;
			if (num3 == 0)
			{
			}
			int num4;
			int num5;
			int direction2;
			if (num4 == 0)
			{
				int direction = this.direction;
				int height = this.height;
				float x3 = this.position.X;
				float y3 = this.position.Y;
				int height2 = this.height;
				Dust dust;
				float x4 = dust.velocity.X;
				float y4 = dust.velocity.Y;
				num5 = 26214;
				dust.scale = (float)num5;
				dust.velocity.Y = y3;
				direction2 = this.direction;
				dust.velocity.X = x4;
				if (num5 == 0)
				{
				}
				dust.velocity.X = (float)direction2;
			}
			if (num5 == 0)
			{
			}
			int num6;
			float x6;
			float y6;
			if (num6 == 0)
			{
				if (num5 == 0)
				{
				}
				float num7;
				Vector2 vector = num7.ToRotationVector2();
				Vector2 center2 = base.Center;
				Dust dust2;
				float x5 = dust2.velocity.X;
				float y5 = dust2.velocity.Y;
				int num8 = 1;
				dust2.velocity.X = (float)direction2;
				dust2.noGravity = num8 != 0;
				dust2.customData = this;
				Vector2 center3 = base.Center;
				Dust dust3;
				x6 = dust3.velocity.X;
				y6 = dust3.velocity.Y;
				dust3.velocity.X = x6;
				dust3.velocity.Y = y6;
				dust3.noGravity = num8 != 0;
				dust3.customData = this;
			}
			float x7 = this.position.X;
			float y7 = this.position.Y;
			float x8 = this.netOffset.X;
			float y8 = this.netOffset.Y;
			float[] array = this.localAI;
			this.position.X = x6;
			this.position.Y = y6;
			int num9 = 255;
			this.alpha = num9;
			if (array == null)
			{
			}
			Vector2 center4 = base.Center;
			float[] array2 = this.localAI;
			int num10 = this.alpha;
			this.alpha = num10;
			float num11 = base.Size.Length();
			int num12 = this.type;
			int num13 = 52429;
			int num14 = 13107;
			if (num12 == 0)
			{
			}
			int num15;
			if (num15 == 0)
			{
				float x9 = this.position.X;
				float y9 = this.position.Y;
				int width = this.width;
				bool wet = this.wet;
				float x10 = this.velocity.X;
				Dust dust4;
				dust4.scale = (float)num13;
				dust4.fadeIn = (float)num14;
				float x11 = dust4.velocity.X;
				float y10 = dust4.velocity.Y;
				dust4.velocity.X = x6;
				dust4.velocity.Y = y6;
				float x12 = this.velocity.X;
				float y11 = this.velocity.Y;
				dust4.velocity.X = x6;
				dust4.velocity.Y = y6;
			}
			int whoAmI = this.whoAmI;
			if (whoAmI == 0)
			{
			}
			if (whoAmI != 0)
			{
				if (whoAmI == 0)
				{
				}
				int num16 = this.type;
				float x13 = this.position.X;
				if (whoAmI == 0)
				{
				}
				if (num16 == 0)
				{
				}
				float y12 = this.position.Y;
				int width2 = this.width;
				float x14 = this.position.X;
				float y13 = this.position.Y;
				float x15 = this.velocity.X;
				this.velocity.X = x15;
				float y14 = this.velocity.Y;
				return;
			}
		}

		// Token: 0x060021C7 RID: 8647 RVA: 0x000F1614 File Offset: 0x000EF814
		public void ReflectProjectiles(Rectangle myRect)
		{
			if (!true)
			{
			}
		}

		// Token: 0x060021C8 RID: 8648 RVA: 0x000F1628 File Offset: 0x000EF828
		public bool CanReflectProjectile(Projectile proj)
		{
			/*
An exception occurred when decompiling this method (060021C8)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean Terraria.NPC::CanReflectProjectile(Terraria.Projectile)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:Rectangle(var_0_06, callgetter:Rectangle(Entity::get_Hitbox, ldloc:Projectile[exp:Entity](proj)))
	stloc:Rectangle(var_1_0D, callgetter:Rectangle(Entity::get_Hitbox, ldloc:NPC[exp:Entity](this)))
	stloc:bool(var_2_15, call:bool(Rectangle::Intersects, ldloc:Rectangle[exp:valuetype Microsoft.Xna.Framework.Rectangle&](var_1_0D), ldloc:Rectangle(var_1_0D)))
	stloc:int32(var_3_1C, ldfld:int32(NPC::type, ldloc:NPC(this)))
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

		// Token: 0x060021C9 RID: 8649 RVA: 0x000F1654 File Offset: 0x000EF854
		public void BloodNautilus_GetMouthPositionAndRotation([Out] Vector2 mouthPosition, [Out] Vector2 mouthDirection)
		{
			int num = this.spriteDirection;
			float num2 = this.rotation;
			mouthDirection.X = num2;
			Vector2 center = base.Center;
			float x = mouthDirection.X;
			float y = mouthDirection.Y;
			if (num == 0)
			{
			}
			mouthPosition.X = num2;
		}

		// Token: 0x060021CA RID: 8650 RVA: 0x000F16A0 File Offset: 0x000EF8A0
		public void ReflectProjectile(Projectile proj)
		{
			if (!true)
			{
			}
			float x = proj.position.X;
			float y = proj.position.Y;
			float x2 = proj.position.X;
			float y2 = proj.position.Y;
			int width = proj.width;
			bool wet = proj.wet;
			int num = 257;
			proj.hostile = num != 0;
			if (num == 0)
			{
			}
			Vector2 center = proj.Center;
			if (num == 0)
			{
			}
			Vector2 vector;
			vector.Normalize();
			float num2 = vector.Length();
			float val = proj.ai.val1;
			int num3 = 1;
			proj.stepSpeed = (float)num3;
			proj.ai.val1 = val;
		}

		// Token: 0x060021CB RID: 8651 RVA: 0x000F1768 File Offset: 0x000EF968
		public int GetShootingFrame(float circleY)
		{
			/*
An exception occurred when decompiling this method (060021CB)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Int32 Terraria.NPC::GetShootingFrame(System.Single)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:int32(var_0_06, ldfld:int32(NPC::type, ldloc:NPC(this)))
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

		// Token: 0x060021CC RID: 8652 RVA: 0x000F177C File Offset: 0x000EF97C
		public Tuple<Vector2, float> GetSwingStats(int swingMax, int swingCurrent, int aimDir, int itemWidth, int itemHeight)
		{
			/*
An exception occurred when decompiling this method (060021CC)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Tuple`2<Microsoft.Xna.Framework.Vector2,System.Single> Terraria.NPC::GetSwingStats(System.Int32,System.Int32,System.Int32,System.Int32,System.Int32)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0006:
	stloc:Vector2(var_0_0C, callgetter:Vector2(Entity::get_Center, ldloc:NPC[exp:Entity](this)))
	stloc:float32(var_1_18, ldfld:float32(Vector2::Y, ldfld:Vector2[exp:valuetype Microsoft.Xna.Framework.Vector2&](Entity::position, ldloc:NPC[exp:Entity](this))))
	stloc:Vector2(var_2_1F, callgetter:Vector2(Entity::get_Center, ldloc:NPC[exp:Entity](this)))
	stloc:float32(var_3_2B, ldfld:float32(Vector2::Y, ldfld:Vector2[exp:valuetype Microsoft.Xna.Framework.Vector2&](Entity::position, ldloc:NPC[exp:Entity](this))))
	stloc:Vector2(var_4_32, callgetter:Vector2(Entity::get_Center, ldloc:NPC[exp:Entity](this)))
	stloc:float32(var_5_3F, ldfld:float32(Vector2::Y, ldfld:Vector2[exp:valuetype Microsoft.Xna.Framework.Vector2&](Entity::position, ldloc:NPC[exp:Entity](this))))
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

		// Token: 0x060021CD RID: 8653 RVA: 0x000F17CC File Offset: 0x000EF9CC
		public void TweakSwingStats(int swingMax, int swingCurrent, int aimDir, Rectangle itemRectangle)
		{
			int width = itemRectangle.Width;
		}

		// Token: 0x060021CE RID: 8654 RVA: 0x000F1838 File Offset: 0x000EFA38
		public bool UsesPartyHat()
		{
			for (;;)
			{
				int num = this.type;
				int num2 = this.townNpcVariationIndex;
				if (this.ForcePartyHatOn)
				{
					break;
				}
				if (this.IsABestiaryIconDummy)
				{
				}
				int height = this.frame.Height;
				if (this.townNPC)
				{
					goto Block_1;
				}
			}
			return true;
			Block_1:
			return BirthdayParty.PartyIsUp;
		}

		// Token: 0x060021CF RID: 8655 RVA: 0x000F1888 File Offset: 0x000EFA88
		public PartyHatColor GetPartyHatColor()
		{
			/*
An exception occurred when decompiling this method (060021CF)

ICSharpCode.Decompiler.DecompilerException: Error decompiling Terraria.PartyHatColor Terraria.NPC::GetPartyHatColor()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_006D:
	stloc:int32(var_10_73, ldfld:int32(Entity::whoAmI, ldloc:NPC[exp:Entity](this)))
	stloc:int32(var_11_7B, call:int32(Utils::ToDirectionInt, ldc.i4:bool(1)))
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

		// Token: 0x060021D0 RID: 8656 RVA: 0x000F1914 File Offset: 0x000EFB14
		public void SetFrameSize()
		{
			if (!true)
			{
			}
			int num = this.type;
			bool flag = this.setFrameSize;
			if (!flag || !flag)
			{
			}
		}

		// Token: 0x060021D1 RID: 8657 RVA: 0x000F1938 File Offset: 0x000EFB38
		public void FindFrame()
		{
			int num = 1;
			float x = this.position.X;
			float y = this.position.Y;
			float x2 = this.netOffset.X;
			float y2 = this.netOffset.Y;
			if (num == 0)
			{
			}
		}

		// Token: 0x060021D2 RID: 8658 RVA: 0x000021DB File Offset: 0x000003DB
		private static int FindFrame_FromSequence(int sequenceFrame, int[] frames)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x060021D3 RID: 8659 RVA: 0x000F2BE4 File Offset: 0x000F0DE4
		private static int FindFrame_Deerclops_GetAttack1Frame(int sequenceFrame)
		{
			/*
An exception occurred when decompiling this method (060021D3)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Int32 Terraria.NPC::FindFrame_Deerclops_GetAttack1Frame(System.Int32)

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

		// Token: 0x060021D4 RID: 8660 RVA: 0x000F2BF4 File Offset: 0x000F0DF4
		private static int FindFrame_Deerclops_GetAttack2Frame(int sequenceFrame)
		{
			/*
An exception occurred when decompiling this method (060021D4)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Int32 Terraria.NPC::FindFrame_Deerclops_GetAttack2Frame(System.Int32)

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

		// Token: 0x060021D5 RID: 8661 RVA: 0x000F2C04 File Offset: 0x000F0E04
		private static int FindFrame_Deerclops_GetAttack3Frame(int sequenceFrame)
		{
			/*
An exception occurred when decompiling this method (060021D5)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Int32 Terraria.NPC::FindFrame_Deerclops_GetAttack3Frame(System.Int32)

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

		// Token: 0x060021D6 RID: 8662 RVA: 0x000F2C14 File Offset: 0x000F0E14
		public void SimpleFlyMovement(Vector2 desiredVelocity, float moveSpeed)
		{
			float x = this.velocity.X;
			this.velocity.X = x;
		}

		// Token: 0x060021D7 RID: 8663 RVA: 0x000F2C78 File Offset: 0x000F0E78
		public void HealEffect(int healAmount, bool broadcast = true)
		{
			float x = this.position.X;
			float y = this.position.Y;
			int width = this.width;
			bool wet = this.wet;
			if (32640 == 0)
			{
			}
		}

		// Token: 0x060021D8 RID: 8664 RVA: 0x000F2CB4 File Offset: 0x000F0EB4
		public static void HealEffect(Rectangle r, int healAmount, bool broadcast = true)
		{
			bool netHost = Main.NetHost;
		}

		// Token: 0x060021D9 RID: 8665 RVA: 0x000F2CCC File Offset: 0x000F0ECC
		public int FindClosestPlayer()
		{
			int num;
			return num;
		}

		// Token: 0x060021DA RID: 8666 RVA: 0x000F2CDC File Offset: 0x000F0EDC
		public int FindClosestPlayer([Out] float distanceToPlayer)
		{
			int num = 1;
			Vector2 center = base.Center;
			if (num == 0)
			{
				return;
			}
		}

		// Token: 0x060021DB RID: 8667 RVA: 0x000F2D00 File Offset: 0x000F0F00
		public void BigMimicSpawnSmoke()
		{
			if (!true)
			{
			}
			bool netHost = Main.NetHost;
			int whoAmI = this.whoAmI;
		}

		// Token: 0x060021DC RID: 8668 RVA: 0x000F2D34 File Offset: 0x000F0F34
		public static bool BigMimicSummonCheck(int x, int y, Player user)
		{
			int num = 1;
			if (num == 0)
			{
			}
			bool netClientOnly = Main.NetClientOnly;
			if (num == 0)
			{
			}
			if (num != 0)
			{
				int num2 = Chest.FindChest(42168200, x);
				long num3 = 0L;
				long num4 = 0L;
				if (42168200 == 0)
				{
				}
				Tile tile;
				ushort num5 = tile.type;
				Tile tile2;
				short frameX = tile2.frameX;
				if (num4 == 0L)
				{
					Tile tile3;
					ushort num6 = tile3.type;
					Tile tile4;
					short frameX2 = tile4.frameX;
					if (36409 == 0)
					{
					}
					Tile tile5;
					short frameY = tile5.frameY;
					int num7 = 36409;
					if (num7 == 0)
					{
					}
					int num8 = Chest.FindChest(42168200, x);
					num3.m_value = -1073741824L;
					bool flag = Chest.DestroyChest(42168200, x);
					if (num7 == 0)
					{
					}
					Tile tile6;
					ushort num9 = tile6.type;
					Tile tile7;
					tile7.ClearTile();
					Tile tile8;
					ushort num10 = tile8.type;
					if (5 == 0)
					{
					}
					if (473 == 0)
					{
					}
				}
			}
			throw new ArrayTypeMismatchException();
		}

		// Token: 0x060021DD RID: 8669 RVA: 0x000F2E34 File Offset: 0x000F1034
		public bool ShouldFaceTarget(NPCUtils.TargetSearchResults searchResults, [Optional] NPCUtils.TargetType? overrideTargetType)
		{
			/*
An exception occurred when decompiling this method (060021DD)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean Terraria.NPC::ShouldFaceTarget(Terraria.Utilities.NPCUtils/TargetSearchResults,System.Nullable`1<Terraria.Utilities.NPCUtils/TargetType>)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_2:
	stloc:int32(var_4_29, ldfld:int32(Entity::width, ldloc:NPC[exp:Entity](this)))
	stloc:bool(var_5_31, ldfld:bool(Entity::wet, ldloc:NPC[exp:Entity](this)))
	stloc:float32(var_6_39, ldfld:float32(TargetSearchResults::_nearestTankDistance, ldloc:TargetSearchResults[exp:valuetype Terraria.Utilities.NPCUtils/TargetSearchResults&](searchResults)))
	stloc:int32(var_7_41, ldfld:int32(NPC::oldTarget, ldloc:NPC(this)))
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

		// Token: 0x060021DE RID: 8670 RVA: 0x000F2E84 File Offset: 0x000F1084
		public void FaceTarget()
		{
			Vector2 center = base.Center;
			Vector2 center2 = base.Center;
		}

		// Token: 0x060021DF RID: 8671 RVA: 0x000021DB File Offset: 0x000003DB
		public void TargetClosestUpgraded(bool faceTarget = true, [Optional] Vector2? checkPosition)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x060021E0 RID: 8672 RVA: 0x000F2EA0 File Offset: 0x000F10A0
		public void TargetClosest(bool faceTarget = true)
		{
			int num = 1;
			if (num == 0)
			{
			}
			if (num != 0)
			{
			}
		}

		// Token: 0x060021E1 RID: 8673 RVA: 0x000F2EB8 File Offset: 0x000F10B8
		public void TargetClosest_WOF(bool faceTarget = true)
		{
			if (!true)
			{
			}
		}

		// Token: 0x060021E2 RID: 8674 RVA: 0x000F2ECC File Offset: 0x000F10CC
		private void TryTrackingTarget(float distance, float realDist, bool t, int tankTarget, int j)
		{
			if (!true)
			{
			}
			float x = this.position.X;
			int width = this.width;
			int height = this.height;
			float y = this.position.Y;
			int direction = this.direction;
			int num = 1;
			j.m_value = num;
			if (num == 0)
			{
			}
			float x2 = this.position.X;
			int width2 = this.width;
			int height2 = this.height;
			float y2 = this.position.Y;
			t.m_value = x != null;
		}

		// Token: 0x060021E3 RID: 8675 RVA: 0x000F2F94 File Offset: 0x000F1194
		private void SetTargetTrackingValues(bool faceTarget, float realDist, int tankTarget)
		{
			if (!true)
			{
			}
			int num = 32640;
			int num2 = 1;
			num.m_value = (int)realDist;
			int width = this.targetRect.Width;
			int width2 = this.width;
			Rectangle rectangle = this.targetRect;
			float x = this.position.X;
			this.direction = num2;
			this.direction = width;
			int height = this.targetRect.Height;
			int height2 = this.height;
			int y = this.targetRect.Y;
			float y2 = this.position.Y;
			this.directionY = num2;
			this.directionY = num2;
		}

		// Token: 0x060021E4 RID: 8676 RVA: 0x000F313C File Offset: 0x000F133C
		public bool DoesntDespawnToInactivityAndCountsNPCSlots()
		{
			/*
An exception occurred when decompiling this method (060021E4)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean Terraria.NPC::DoesntDespawnToInactivityAndCountsNPCSlots()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:int32(var_0_06, ldfld:int32(NPC::type, ldloc:NPC(this)))
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

		// Token: 0x060021E5 RID: 8677 RVA: 0x000F3150 File Offset: 0x000F1350
		public bool DoesntDespawnToInactivity()
		{
			int num = this.type;
			if (num == 0)
			{
			}
			int num2;
			if (num == 0)
			{
				num2 = 6943;
			}
			if (num2 == 0)
			{
			}
			while (num2 != 0)
			{
			}
		}

		// Token: 0x060021E6 RID: 8678 RVA: 0x000F318C File Offset: 0x000F138C
		public void CheckActive()
		{
			if (!this.active)
			{
				return;
			}
			bool flag = this.DoesntDespawnToInactivity();
			bool flag2 = this.townNPC;
			if (flag2)
			{
				this.AddIntoPlayersTownNPCSlots();
				return;
			}
			int num = this.type;
			float x = this.position.X;
			int width = this.width;
			if (!flag2)
			{
			}
			int height = this.height;
			float y = this.position.Y;
			int width2 = this.width;
			bool wet = this.wet;
			float x2 = this.position.X;
			float y2 = this.position.Y;
			if (width2 == 0)
			{
			}
			if (!wet)
			{
			}
			Rectangle rectangle;
			bool flag3 = rectangle.Intersects(rectangle);
			int num2 = this.type;
			if (num2 == 0)
			{
			}
			this.timeLeft = num2;
			if (num2 == 0)
			{
			}
			if (num2 != 0)
			{
				int num3 = this.type;
			}
			int num4 = this.type;
			bool flag4 = this.boss;
			float[] array = this.ai;
			if (array == null)
			{
			}
			this.timeLeft = array;
		}

		// Token: 0x060021E7 RID: 8679 RVA: 0x000F3318 File Offset: 0x000F1518
		private void CheckActive_WormSegments()
		{
			int num = this.aiStyle;
			float[] array = this.ai;
			int whoAmI = this.whoAmI;
			if (whoAmI == 0)
			{
			}
			if (whoAmI != 0)
			{
				if (whoAmI == 0)
				{
				}
				bool netHost = Main.NetHost;
				if (whoAmI == 0)
				{
				}
				int whoAmI2 = this.whoAmI;
			}
		}

		// Token: 0x060021E8 RID: 8680 RVA: 0x000F3364 File Offset: 0x000F1564
		private void AddIntoPlayersTownNPCSlots()
		{
			int num = 1;
			float x = this.position.X;
			int width = this.width;
			if (num == 0)
			{
			}
			int height = this.height;
			int num2 = 32640;
			float y = this.position.Y;
			if (num == 0)
			{
			}
			if (height == 0)
			{
			}
			if (height != 0)
			{
				if (num2 == 0)
				{
				}
				if (height != 0)
				{
					if (height == 0)
					{
					}
					Rectangle rectangle;
					bool flag = rectangle.Intersects(rectangle);
					float num3 = this.npcSlots;
				}
			}
		}

		// Token: 0x060021E9 RID: 8681 RVA: 0x000F33CC File Offset: 0x000F15CC
		public void checkDead()
		{
			if (this.active)
			{
				int num = this.realLife;
				int whoAmI = this.whoAmI;
				int num2 = this.life;
			}
		}

		// Token: 0x060021EA RID: 8682 RVA: 0x000F385C File Offset: 0x000F1A5C
		public void DropTombstoneTownNPC(NetworkText deathText)
		{
			int num = 1;
			if (num == 0)
			{
			}
			bool logicHost = Main.LogicHost;
			if (num == 0)
			{
			}
			int num2;
			if (num2 != 0)
			{
			}
			if (this.type == 0)
			{
			}
		}

		// Token: 0x060021EB RID: 8683 RVA: 0x000F38E8 File Offset: 0x000F1AE8
		public static int GetNPCInvasionGroup(int npcID)
		{
			return 3;
		}

		// Token: 0x060021EC RID: 8684 RVA: 0x000F38FC File Offset: 0x000F1AFC
		private void DropEoWLoot(bool fromCheckDead = true)
		{
			if (this.whoAmI == 0)
			{
			}
			int num = 1;
			this.boss = num != 0;
			this.NPCLoot();
		}

		// Token: 0x060021ED RID: 8685 RVA: 0x000F3924 File Offset: 0x000F1B24
		private float GetMoonEventPointScalar()
		{
			/*
An exception occurred when decompiling this method (060021ED)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Single Terraria.NPC::GetMoonEventPointScalar()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_000E:
	stloc:bool(var_3_15, callgetter:bool(Main::get_expertMode))
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

		// Token: 0x060021EE RID: 8686 RVA: 0x000F3948 File Offset: 0x000F1B48
		private void CheckProgressFrostMoon()
		{
			int num = 1;
			if (num == 0)
			{
			}
			if (num != 0)
			{
				if (num == 0)
				{
				}
				return;
			}
		}

		// Token: 0x060021EF RID: 8687 RVA: 0x000F3A48 File Offset: 0x000F1C48
		private void CheckProgressPumpkinMoon()
		{
			int num = 1;
			if (num == 0)
			{
			}
			if (num != 0)
			{
				if (num == 0)
				{
				}
				return;
			}
		}

		// Token: 0x060021F0 RID: 8688 RVA: 0x000F3B68 File Offset: 0x000F1D68
		public static void ResetKillCount()
		{
			if (!true)
			{
			}
		}

		// Token: 0x060021F1 RID: 8689 RVA: 0x000F3B80 File Offset: 0x000F1D80
		public bool AnyInteractions()
		{
			int num = 1;
			if (num == 0)
			{
			}
			bool[] array;
			if (num != 0)
			{
				if (num == 0)
				{
				}
				array = this.playerInteraction;
				while (array == null)
				{
				}
			}
			bool[] array2 = this.playerInteraction;
			if (array == null)
			{
			}
			int myPlayer = Main.myPlayer;
			if (array != null)
			{
				return;
			}
		}

		// Token: 0x060021F2 RID: 8690 RVA: 0x000F3BC0 File Offset: 0x000F1DC0
		public bool IsDamageDodgeable()
		{
			int num = this.type;
			if (this.ai == null)
			{
			}
			return true;
		}

		// Token: 0x060021F3 RID: 8691 RVA: 0x000F3BE0 File Offset: 0x000F1DE0
		public static void SetEventFlagCleared(bool eventFlag, int gameEventId)
		{
			eventFlag.m_value = true;
		}

		// Token: 0x060021F4 RID: 8692 RVA: 0x000F3BFC File Offset: 0x000F1DFC
		public static void OnGameEventClearedForTheFirstTime(int gameEventId)
		{
			CreditsRollEvent.TryStartingCreditsRoll();
		}

		// Token: 0x060021F5 RID: 8693 RVA: 0x000F3C30 File Offset: 0x000F1E30
		public void NPCLoot()
		{
			if (!true)
			{
			}
			bool netClientOnly = Main.NetClientOnly;
			int num = this.type;
			if (num == 0)
			{
			}
			if (num != 0)
			{
				if (num == 0)
				{
				}
				if (num == 0)
				{
					int num2 = this.type;
					return;
				}
			}
			if (num == 0)
			{
			}
			float x = this.position.X;
			float y = this.position.Y;
			int width = this.width;
			bool wet = this.wet;
			if (num == 0)
			{
			}
			this.CountKillForAchievements();
			bool wereThereAnyInteractions = this.GetWereThereAnyInteractions();
			int num3 = this.type;
			bool flag = this.boss;
			if (!flag || !flag)
			{
			}
			this.CountKillForBannersAndDropThem();
			int num4 = this.type;
			if (num4 == 0)
			{
			}
			if (num4 == 0)
			{
				bool spawnedFromStatue = this.SpawnedFromStatue;
				bool spawnedFromStatue2;
				if (spawnedFromStatue)
				{
					if (!spawnedFromStatue)
					{
					}
					if (spawnedFromStatue)
					{
						if (!spawnedFromStatue)
						{
						}
						if (!spawnedFromStatue)
						{
							return;
						}
					}
					spawnedFromStatue2 = this.SpawnedFromStatue;
					if (!spawnedFromStatue2 || !spawnedFromStatue2)
					{
					}
				}
				if (!spawnedFromStatue2)
				{
				}
				return;
			}
		}

		// Token: 0x060021F6 RID: 8694 RVA: 0x000F3D3C File Offset: 0x000F1F3C
		public bool IsNPCValidForBestiaryKillCredit()
		{
			/*
An exception occurred when decompiling this method (060021F6)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean Terraria.NPC::IsNPCValidForBestiaryKillCredit()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:int32(var_0_06, ldfld:int32(NPC::type, ldloc:NPC(this)))
	stloc:bool(var_1_0D, ldfld:bool(NPC::boss, ldloc:NPC(this)))
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

		// Token: 0x060021F7 RID: 8695 RVA: 0x000F3D58 File Offset: 0x000F1F58
		private void DoDeathEvents_BeforeLoot(Player closestPlayer)
		{
			int num = this.type;
			bool flag = NPC.AnyNPCs(43143168);
		}

		// Token: 0x060021F8 RID: 8696 RVA: 0x000F3D78 File Offset: 0x000F1F78
		private void NPCLoot_DropItems(Player closestPlayer)
		{
			if (!true)
			{
			}
			bool expertMode = Main.expertMode;
			bool masterMode = Main.masterMode;
		}

		// Token: 0x060021F9 RID: 8697 RVA: 0x000F3D98 File Offset: 0x000F1F98
		public static void ResetBadgerHatTime()
		{
			if (!true)
			{
			}
		}

		// Token: 0x060021FA RID: 8698 RVA: 0x000F3DA8 File Offset: 0x000F1FA8
		private void DoDeathEvents_DropBossPotionsAndHearts()
		{
			if (!true)
			{
			}
			int num = this.type;
		}

		// Token: 0x060021FB RID: 8699 RVA: 0x000F3EB4 File Offset: 0x000F20B4
		private void DoDeathEvents_CelebrateBossDeath()
		{
			int num = 1;
			int num2 = this.type;
			if (num == 0)
			{
			}
			if (num == 0)
			{
				string textValue = Language.GetTextValue("Enemies.MoonLord");
				return;
			}
			if (num == 0)
			{
			}
			bool netHost = Main.NetHost;
			NetworkText networkText;
			if (networkText == null || networkText != null)
			{
				return;
			}
			throw new ArrayTypeMismatchException();
		}

		// Token: 0x060021FC RID: 8700 RVA: 0x000F3F8C File Offset: 0x000F218C
		private void CreateBrickBoxForWallOfFlesh()
		{
			int width = this.width;
			bool wet = this.wet;
			float x = this.position.X;
			float y = this.position.Y;
			int num = 32640;
			if (num == 0)
			{
			}
			int num2;
			if (num != 0)
			{
				Tile tile;
				bool flag = tile.active();
				if (num == 0)
				{
				}
				num2 = 347;
			}
			if (num2 == 0)
			{
			}
			bool netHost = Main.NetHost;
			if (num2 == 0)
			{
			}
			if (num2 == 0)
			{
			}
			bool logicClient = Main.LogicClient;
			if (num2 == 0)
			{
			}
		}

		// Token: 0x060021FD RID: 8701 RVA: 0x000F4018 File Offset: 0x000F2218
		private void DoDeathEvents_SummonDungeonSpirit(Player closestPlayer)
		{
			int num = this.lifeMax;
			int num2 = this.type;
			float num3 = this.value;
			int num4 = this.target;
			if (num4 == 0)
			{
			}
			if (num4 != 0)
			{
				if (num4 == 0)
				{
				}
				if (num4 != 0)
				{
					Player targetPlayer = this.TargetPlayer;
					long num5 = 0L;
					bool zoneDungeon = targetPlayer.ZoneDungeon;
					if (num4 == 0)
					{
					}
					bool expertMode = Main.expertMode;
					int num6 = 13;
					if (closestPlayer.RollLuck((int)num5) == 0)
					{
						if (num6 == 0)
						{
						}
						Vector2 center = base.Center;
						Vector2 center2 = base.Center;
						Tile tile;
						ushort wall = tile.wall;
						if (num6 != 0)
						{
							IEntitySource spawnSource_NPCHurt = this.GetSpawnSource_NPCHurt();
							Vector2 center3 = base.Center;
							Vector2 center4 = base.Center;
							if (num6 == 0)
							{
							}
						}
					}
				}
			}
		}

		// Token: 0x060021FE RID: 8702 RVA: 0x000F40C8 File Offset: 0x000F22C8
		private void DoDeathEvents_AdvanceSlimeRain(Player closestPlayer)
		{
			if (!true)
			{
			}
			bool flag = NPC.AnyNPCs(50);
			int num = 150;
			int whoAmI = closestPlayer.whoAmI;
			if (num == 0)
			{
			}
			int num2 = 50;
			NPC.SpawnOnPlayer(whoAmI, num2);
			if (num == 0)
			{
			}
		}

		// Token: 0x060021FF RID: 8703 RVA: 0x000F4100 File Offset: 0x000F2300
		private void NPCLoot_DropHeals(Player closestPlayer)
		{
			this.NPCLoot_DropCommonLifeAndMana(closestPlayer);
			int num = this.type;
		}

		// Token: 0x06002200 RID: 8704 RVA: 0x000F41AC File Offset: 0x000F23AC
		private void DoDeathEvents(Player closestPlayer)
		{
			int num = 1;
			this.DoDeathEvents_AdvanceSlimeRain(closestPlayer);
			this.DoDeathEvents_SummonDungeonSpirit(closestPlayer);
			if (num == 0)
			{
			}
			if (num != 0)
			{
				if (num == 0)
				{
				}
				if (num == 0)
				{
					bool flag = this.AnyInteractions();
					if (num == 0)
					{
					}
					bool flag2 = Main.AnyPlayerReadyToFightKingSlime();
					int num2 = this.type;
					if (num2 == 0)
					{
					}
					bool flag3 = NPC.AnyNPCs(50);
					if (num2 == 0)
					{
					}
					int num3;
					if (num3 == 0)
					{
						int whoAmI = closestPlayer.whoAmI;
						if (num2 == 0)
						{
						}
						int num4 = 50;
						NPC.SpawnOnPlayer(whoAmI, num4);
					}
				}
			}
			if (this.type == 0)
			{
			}
		}

		// Token: 0x06002201 RID: 8705 RVA: 0x000F4670 File Offset: 0x000F2870
		private void ViolentlySpawnNerdySlime()
		{
			int num = 1;
			IEntitySource spawnSourceForNPCFromNPCAI = this.GetSpawnSourceForNPCFromNPCAI();
			Vector2 center = base.Center;
			Vector2 center2 = base.Center;
			if (num == 0)
			{
			}
			int num2 = 32640;
			if (num2 == 0)
			{
			}
			if (num2 == 0)
			{
			}
			WorldGen.CheckAchievement_RealEstateAndTownSlimes();
			Vector2 center3 = base.Center;
		}

		// Token: 0x06002202 RID: 8706 RVA: 0x000F46BC File Offset: 0x000F28BC
		private void NPCLoot_DropCommonLifeAndMana(Player closestPlayer)
		{
			int num = this.type;
			if (closestPlayer.RollLuck(6) == 0)
			{
				int num2 = this.lifeMax;
				if (this.damage == 0)
				{
				}
				int num3;
				if (num3 == 0)
				{
					int statMana = closestPlayer.statMana;
					int statManaMax = closestPlayer.statManaMax2;
					IEntitySource itemSource_Loot = this.GetItemSource_Loot();
					float x = this.position.X;
					float y = this.position.Y;
					int width = this.width;
					bool wet = this.wet;
					if (statManaMax == 0)
					{
					}
					return;
				}
				int num4;
				if (num4 == 0)
				{
					int statLife = closestPlayer.statLife;
					int statLifeMax = closestPlayer.statLifeMax2;
					IEntitySource itemSource_Loot2 = this.GetItemSource_Loot();
					float x2 = this.position.X;
					float y2 = this.position.Y;
					int width2 = this.width;
					bool wet2 = this.wet;
					if (statLifeMax == 0)
					{
					}
				}
			}
			int num5 = this.type;
			if (closestPlayer.RollLuck(2) == 0)
			{
				int num6 = this.lifeMax;
				int num7 = this.damage;
				int statMana2 = closestPlayer.statMana;
				int statManaMax2 = closestPlayer.statManaMax2;
				IEntitySource itemSource_Loot3 = this.GetItemSource_Loot();
				float x3 = this.position.X;
				float y3 = this.position.Y;
				int width3 = this.width;
				bool wet3 = this.wet;
				if (statManaMax2 == 0)
				{
				}
			}
		}

		// Token: 0x06002203 RID: 8707 RVA: 0x000F47E8 File Offset: 0x000F29E8
		private void NPCLoot_DropMoney(Player closestPlayer)
		{
			int num = 1;
			float luck = closestPlayer.luck;
			if (num == 0)
			{
			}
			long num2 = 0L;
			bool flag = this.midas;
			float num3 = this.value;
			if (flag)
			{
				if (!flag)
				{
				}
			}
			if (!flag)
			{
			}
			int num4;
			if (num4 == 0)
			{
				if (!flag)
				{
				}
			}
			if (!flag)
			{
			}
			int num5;
			if (num5 == 0)
			{
				if (!flag)
				{
				}
			}
			if (!flag)
			{
			}
			int num6;
			if (num6 == 0)
			{
				if (!flag)
				{
				}
			}
			if (!flag)
			{
			}
			int num7;
			if (num7 == 0)
			{
				if (!flag)
				{
				}
			}
			if (!flag)
			{
			}
			int num8;
			if (num8 == 0)
			{
				if (!flag)
				{
				}
			}
			if (!flag)
			{
			}
			int num9;
			if (num9 == 0)
			{
				if (!flag)
				{
				}
			}
			if (!flag)
			{
			}
			if (flag)
			{
				if (!flag)
				{
				}
			}
			if (num2 != 0L)
			{
				return;
			}
			int num10 = this.extraValue;
			int num11;
			if (num11 == 0)
			{
			}
			int num12;
			if (num12 == 0)
			{
			}
			IEntitySource itemSource_Loot = this.GetItemSource_Loot();
			float x = this.position.X;
			float y = this.position.Y;
			int width = this.width;
			bool wet = this.wet;
			IEntitySource itemSource_Loot2 = this.GetItemSource_Loot();
			float x2 = this.position.X;
			float y2 = this.position.Y;
			int width2 = this.width;
			bool wet2 = this.wet;
		}

		// Token: 0x06002204 RID: 8708 RVA: 0x000F4A34 File Offset: 0x000F2C34
		public static int GetStackForSlimeItemDrop(int item)
		{
			int num = 1;
			if (num == 0)
			{
			}
			if (num == 0)
			{
			}
			int num2;
			return num2;
		}

		// Token: 0x06002205 RID: 8709 RVA: 0x000F4A60 File Offset: 0x000F2C60
		public bool ExcludedFromDeathTally()
		{
			/*
An exception occurred when decompiling this method (06002205)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean Terraria.NPC::ExcludedFromDeathTally()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:int32(var_0_06, ldfld:int32(NPC::netID, ldloc:NPC(this)))
	stloc:int32(var_1_0D, ldfld:int32(NPC::netID, ldloc:NPC(this)))
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

		// Token: 0x06002206 RID: 8710 RVA: 0x000F4A7C File Offset: 0x000F2C7C
		private void CountKillForBannersAndDropThem()
		{
			int num = this.netID;
			int num2 = 340;
			int num3 = 528;
			if (num2 == 0)
			{
			}
			int num4 = Item.NPCtoBanner(43143168);
			bool flag = this.ExcludedFromDeathTally();
			if (num == 0)
			{
			}
			if (num == 0)
			{
			}
			bool netHost = Main.NetHost;
			if (num3 == 0)
			{
			}
			int num5 = Item.BannerToItem(num4);
			if (num2 == 0)
			{
			}
			if (num5 == 0)
			{
				if (num5 == 0)
				{
				}
				int num6 = Item.BannerToNPC(num4);
				int num7 = this.lastInteraction;
				if (num5 == 0)
				{
				}
				if (num2 == 0 || num2 == 0)
				{
				}
				if (num2 == 0)
				{
				}
				LocalizedText npcname = Lang.GetNPCName(num6);
				string key = npcname.Key;
				if (npcname == null)
				{
				}
				if (num3 == 0)
				{
				}
				NetworkText networkText;
				if (networkText == null || networkText != null)
				{
					if (num2 == 0)
					{
					}
					if (networkText == null || networkText != null)
					{
						LocalizedText npcname2 = Lang.GetNPCName(42178960);
						string key2 = npcname2.Key;
						if (npcname2 == null)
						{
						}
						if (num3 == 0)
						{
						}
						NetworkText networkText2;
						if (networkText2 == null || networkText2 != null)
						{
							if ("Game.EnemiesDefeatedByAnnouncement" == null)
							{
							}
							if ("Game.EnemiesDefeatedByAnnouncement" != null)
							{
								if ("Game.EnemiesDefeatedByAnnouncement" == null)
								{
								}
								bool netHost2 = Main.NetHost;
								if ("Game.EnemiesDefeatedByAnnouncement" == null)
								{
								}
								return;
							}
							int num8 = Item.BannerToItem(num4);
							return;
						}
					}
				}
				throw new ArrayTypeMismatchException();
			}
		}

		// Token: 0x06002207 RID: 8711 RVA: 0x000F4BB8 File Offset: 0x000F2DB8
		public bool GetWereThereAnyInteractions()
		{
			int num = this.realLife;
			int num2 = this.realLife;
			return this.AnyInteractions();
		}

		// Token: 0x06002208 RID: 8712 RVA: 0x000F4BDC File Offset: 0x000F2DDC
		private void CountKillForAchievements()
		{
			AchievementsHelper.CheckMechaMayhem(this.type);
			AchievementsHelper.NotifyNPCKilled(this);
			if (!this.boss)
			{
				return;
			}
			int num = this.netID;
			bool flag;
			if (!flag)
			{
			}
			PlatformAwardNotifierUtility.NoteBossKillForAllLocalUsers(PlatformAwardNotifierUtility.GetBossStatIDFromNetID(num));
		}

		// Token: 0x06002209 RID: 8713 RVA: 0x000F4C60 File Offset: 0x000F2E60
		private bool TryTeleportingCaughtMysticFrog()
		{
			if (!true)
			{
			}
			if (this.type == 0)
			{
			}
			if (!true)
			{
			}
			Vector2 center = base.Center;
			if (!true)
			{
			}
			int width = this.width;
			int height = this.height;
			int whoAmI = this.whoAmI;
			if (width == 0)
			{
			}
			return true;
		}

		// Token: 0x0600220A RID: 8714 RVA: 0x000F4CCC File Offset: 0x000F2ECC
		public static void CatchNPC(int i, int who = -1)
		{
			int myPlayer = Main.myPlayer;
			bool netClientOnly = Main.NetClientOnly;
		}

		// Token: 0x0600220B RID: 8715 RVA: 0x000F4D1C File Offset: 0x000F2F1C
		public void DropItemInstanced(Vector2 Position, Vector2 HitboxSize, int itemType, int itemStack = 1, bool interactionRequired = true)
		{
			if (!true)
			{
			}
			bool netHost = Main.NetHost;
			IEntitySource itemSource_Loot = this.GetItemSource_Loot();
			int num = 32640;
			if (num == 0)
			{
			}
			int num2 = 54000;
			if (num2 == 0)
			{
			}
			if (num2 == 0)
			{
			}
			if (num != 0)
			{
				if (num2 == 0)
				{
				}
				if (num != 0)
				{
					if (this.playerInteraction == null)
					{
					}
					int myPlayer = Main.myPlayer;
					return;
				}
			}
		}

		// Token: 0x0600220C RID: 8716 RVA: 0x000F4DE0 File Offset: 0x000F2FE0
		public void PlayerInteraction(int player)
		{
			int num = this.realLife;
			if (this == null)
			{
				int num2 = this.realLife;
			}
			int num3 = this.lastInteraction;
		}

		// Token: 0x0600220D RID: 8717 RVA: 0x000F4FA4 File Offset: 0x000F31A4
		public void ApplyInteraction(int player)
		{
			int num = this.realLife;
			int num2 = this.realLife;
		}

		// Token: 0x0600220E RID: 8718 RVA: 0x000F4FDC File Offset: 0x000F31DC
		public static bool CanReleaseNPCs(int who)
		{
			int num = 1;
			if (num == 0)
			{
			}
			bool logicHost = Main.LogicHost;
			if (num == 0)
			{
			}
			if (num == 0 || num == 0)
			{
			}
			if (num == 0)
			{
			}
			if (num == 0)
			{
			}
			if (num == 0 || num == 0)
			{
				return;
			}
		}

		// Token: 0x0600220F RID: 8719 RVA: 0x000F5020 File Offset: 0x000F3220
		public static int ReleaseNPC(int x, int y, int Type, int Style, int who)
		{
			if (!true)
			{
			}
			bool netClientOnly = Main.NetClientOnly;
			return 71;
		}

		// Token: 0x06002210 RID: 8720 RVA: 0x000F509C File Offset: 0x000F329C
		public static void SlimeRainSpawns(int plr)
		{
			if (!true)
			{
			}
			bool expertMode = Main.expertMode;
			if (32752 == 0)
			{
			}
			int num = 1;
			if (num == 0)
			{
			}
			int num2;
			int num3;
			if (num != 0)
			{
				CreativePowers.SpawnRateSliderPerPlayerPower power = CreativePowerManager.Instance.GetPower<CreativePowers.SpawnRateSliderPerPlayerPower>();
				if (power != null)
				{
					bool shouldDisableSpawnsFor = power.GetShouldDisableSpawnsFor(plr);
					bool remappedSliderValueFor = power.GetRemappedSliderValueFor(plr, 3.689349E+19f);
					num2 = 32640;
					num3 = 32768;
				}
			}
			if (num2 == 0)
			{
			}
			int num4;
			if (num4 == 0)
			{
				if (32752 == 0)
				{
				}
				if (num3 == 0)
				{
				}
				if (num3 == 0)
				{
				}
				if (42168472 == 0)
				{
				}
				Tile tile;
				ushort wall = tile.wall;
				if (42168472 == 0)
				{
					IEntitySource spawnSourceForNaturalSpawn = NPC.GetSpawnSourceForNaturalSpawn();
					if (num3 == 0)
					{
					}
					if (num3 == 0)
					{
					}
					int num5;
					if (num5 == 0)
					{
						return;
					}
					bool expertMode2 = Main.expertMode;
					if (num3 == 0)
					{
					}
					if (num3 == 0)
					{
					}
					int num6;
					if (num6 == 0)
					{
						return;
					}
					int num7;
					if (num7 == 0)
					{
						return;
					}
				}
			}
		}

		// Token: 0x06002211 RID: 8721 RVA: 0x000F5180 File Offset: 0x000F3380
		public static bool Spawning_SandstoneCheck(int x, int y)
		{
			for (;;)
			{
				int num = 1;
				if (num == 0)
				{
				}
				int num2 = 10;
				bool flag = WorldGen.InWorld(0, x, num2);
				if (num == 0)
				{
				}
				Tile tile;
				bool flag2 = tile.active();
				if (num == 0)
				{
				}
				if (num != 0)
				{
					if (num == 0)
					{
					}
					Tile tile2;
					bool flag3 = tile2.active();
					if (num == 0)
					{
					}
					if (num != 0)
					{
					}
					if (num == 0)
					{
					}
					Tile tile3;
					bool flag4 = tile3.active();
					if (num == 0)
					{
					}
					if (num != 0)
					{
					}
				}
				if (num == 0)
				{
				}
				if (num != 0)
				{
					return;
				}
			}
		}

		// Token: 0x06002212 RID: 8722 RVA: 0x000F51EC File Offset: 0x000F33EC
		public static bool Spawning_FlyingAntlionCheck(int x, int y)
		{
			int num = 1;
			if (num == 0)
			{
			}
			int num2 = 10;
			bool flag = WorldGen.InWorld(0, x, num2);
			if (num == 0)
			{
				return;
			}
		}

		// Token: 0x06002213 RID: 8723 RVA: 0x000F5214 File Offset: 0x000F3414
		private static int RollDragonflyType(int tileType = 2)
		{
			/*
An exception occurred when decompiling this method (06002213)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Int32 Terraria.NPC::RollDragonflyType(System.Int32)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0003:
	brtrue(IL_0000, ldtoken:RuntimeFieldHandle[exp:bool]('<PrivateImplementationDetails>'::746773A11884D65BB97254A4C2A5FE86D1884505C46A053504CFD06D5DBCC7C9))
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

		// Token: 0x06002214 RID: 8724 RVA: 0x000F522C File Offset: 0x000F342C
		public static void ResetRemixHax()
		{
			if (!true)
			{
			}
		}

		// Token: 0x06002215 RID: 8725 RVA: 0x000F523C File Offset: 0x000F343C
		public static void SetRemixHax()
		{
			if (!true)
			{
			}
		}

		// Token: 0x06002216 RID: 8726 RVA: 0x000F524C File Offset: 0x000F344C
		public static bool SpawnTileOrAboveHasAnyWallInSet(int x, int y, bool[] wallTypes)
		{
			/*
An exception occurred when decompiling this method (06002216)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean Terraria.NPC::SpawnTileOrAboveHasAnyWallInSet(System.Int32,System.Int32,System.Boolean[])

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0013:
	stloc:uint16(var_5_1A, callgetter:uint16(Tile::get_wall, ldloc:Tile[exp:valuetype Terraria.Tile&](var_4)))
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

		// Token: 0x06002217 RID: 8727 RVA: 0x000F527C File Offset: 0x000F347C
		public static void SpawnNPC()
		{
			int num = 1;
			if (num != 0 && num != 0)
			{
				return;
			}
			bool tooWindyForButterflies = NPC.TooWindyForButterflies;
		}

		// Token: 0x06002218 RID: 8728 RVA: 0x000FBA68 File Offset: 0x000F9C68
		public static void SpawnNPC_SpawnFrog(int spawnTileX, int spawnTileY, int plr)
		{
			int num = 1;
			if (num == 0)
			{
			}
			if (num == 0)
			{
				if (num == 0)
				{
				}
				int num2;
				if (num2 == 0)
				{
					if (num == 0)
					{
					}
					bool flag = NPC.AnyNPCs(687);
				}
			}
			if (num == 0)
			{
			}
			IEntitySource spawnSourceForNaturalSpawn = NPC.GetSpawnSourceForNaturalSpawn();
			int num3;
			if (num3 != 0)
			{
				return;
			}
		}

		// Token: 0x06002219 RID: 8729 RVA: 0x000FBAB4 File Offset: 0x000F9CB4
		public static int SpawnNPC_GetGemBunnyToSpawn()
		{
			if (!true)
			{
			}
			int num;
			return num;
		}

		// Token: 0x0600221A RID: 8730 RVA: 0x000FBAE4 File Offset: 0x000F9CE4
		public static int SpawnNPC_GetGemSquirrelToSpawn()
		{
			if (!true)
			{
			}
			int num;
			return num;
		}

		// Token: 0x0600221B RID: 8731 RVA: 0x000FBB14 File Offset: 0x000F9D14
		private static bool SpawnNPC_CheckToSpawnRockGolem(int spawnTileX, int spawnTileY, int plr, int tileType)
		{
			int num = 1;
			if (num == 0)
			{
			}
			if (num != 0)
			{
				if (num == 0)
				{
				}
				if (num != 0)
				{
					if (num == 0)
					{
					}
					if (num == 0)
					{
					}
					int num2;
					if (num2 == 0)
					{
						if (num == 0)
						{
						}
						long num3 = 0L;
						bool flag = WorldGen.SolidTile(0, spawnTileX, num3 != 0L);
						if (num == 0)
						{
						}
						long num4 = 0L;
						bool flag2 = WorldGen.SolidTile(0, spawnTileX, num4 != 0L);
					}
				}
			}
			if (num == 0)
			{
			}
			long num5 = 0L;
			return WorldGen.SolidTile(0, spawnTileX, num5 != 0L);
		}

		// Token: 0x0600221C RID: 8732 RVA: 0x000FBB70 File Offset: 0x000F9D70
		private static bool SpawnNPC_CheckToSpawnUndergroundFairy(int spawnTileX, int spawnTileY, int plr)
		{
			int num = 1;
			if (num == 0)
			{
			}
			if (num == 0)
			{
				return;
			}
			if (num == 0)
			{
			}
			int num2 = 500;
			if (250 == 0)
			{
			}
			int num3;
			if (num2 != 0)
			{
				num3 = 32640;
			}
			if (num3 == 0)
			{
			}
			int num4;
			if (num4 == 0)
			{
				if (num3 == 0)
				{
				}
				return NPC.AnyHelpfulFairies();
			}
		}

		// Token: 0x0600221D RID: 8733 RVA: 0x000FBBBC File Offset: 0x000F9DBC
		private static int SpawnNPC_SpawnLavaBaitCritters(int spawnTileX, int spawnTileY)
		{
			for (;;)
			{
				int num = 1;
				if (num == 0)
				{
				}
				int num2;
				if (num2 == 0)
				{
					goto IL_0013;
				}
				if (num == 0)
				{
				}
				if (num != 0)
				{
					if (num == 0)
					{
						goto IL_0013;
					}
					goto IL_0013;
				}
				IL_0016:
				if (num == 0)
				{
				}
				int num3;
				if (num3 != 0)
				{
					continue;
				}
				IEntitySource spawnSourceForNaturalSpawn = NPC.GetSpawnSourceForNaturalSpawn();
				if (8 == 0)
				{
				}
				int num4;
				if (num4 == 0)
				{
					break;
				}
				continue;
				IL_0013:
				if (num == 0)
				{
					goto IL_0016;
				}
				goto IL_0016;
			}
			IEntitySource spawnSourceForNaturalSpawn2 = NPC.GetSpawnSourceForNaturalSpawn();
			if (8 == 0)
			{
			}
			int num5;
			if (num5 == 0)
			{
				IEntitySource spawnSourceForNaturalSpawn3 = NPC.GetSpawnSourceForNaturalSpawn();
			}
			int num6;
			if (num6 == 0)
			{
				IEntitySource spawnSourceForNaturalSpawn4 = NPC.GetSpawnSourceForNaturalSpawn();
			}
			IEntitySource spawnSourceForNaturalSpawn5 = NPC.GetSpawnSourceForNaturalSpawn();
			int num7;
			return num7;
		}

		// Token: 0x0600221E RID: 8734 RVA: 0x000FBC20 File Offset: 0x000F9E20
		private static int SpawnNPC_TryFindingProperGroundTileType(int spawnTileType, int x, int y)
		{
			/*
An exception occurred when decompiling this method (0600221E)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Int32 Terraria.NPC::SpawnNPC_TryFindingProperGroundTileType(System.Int32,System.Int32,System.Int32)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_001B:
	stloc:uint16(var_4_21, callgetter:uint16(Tile::get_type, ldloc:Tile[exp:valuetype Terraria.Tile&](var_3)))
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

		// Token: 0x0600221F RID: 8735 RVA: 0x000FBC50 File Offset: 0x000F9E50
		public static bool IsValidSpawningGroundTile(int x, int y)
		{
			/*
An exception occurred when decompiling this method (0600221F)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean Terraria.NPC::IsValidSpawningGroundTile(System.Int32,System.Int32)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_001B:
	brtrue(IL_0000, ldloc:int32[exp:bool](var_0_01))
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

		// Token: 0x06002220 RID: 8736 RVA: 0x000FBC7C File Offset: 0x000F9E7C
		public static bool FindCattailTop(int landX, int landY, [Out] int cattailX, [Out] int cattailY)
		{
			int num = 1;
			cattailX.m_value = landX;
			if (num == 0)
			{
			}
			int num2 = 31;
			bool flag = WorldGen.InWorld(0, landX, num2);
			if (num == 0)
			{
			}
			Tile tile;
			bool isLoaded = tile.IsLoaded;
			if (num == 0)
			{
			}
			int num3;
			if (num3 == 0)
			{
				landY.m_value = 0;
				return;
			}
		}

		// Token: 0x06002221 RID: 8737 RVA: 0x000FBCC4 File Offset: 0x000F9EC4
		public static bool FindTreeBranch(int landX, int landY, [Out] int treeBranchX, [Out] int treeBranchY)
		{
			int num = 1;
			treeBranchX.m_value = landX;
			if (num == 0)
			{
			}
			int num2 = 11;
			bool flag = WorldGen.InWorld(0, landX, num2);
			if (num == 0)
			{
			}
			Tile tile;
			bool isLoaded = tile.IsLoaded;
			if (num == 0)
			{
			}
			if (num == 0)
			{
				return;
			}
			if (num == 0)
			{
			}
			int num3;
			if (num3 == 0)
			{
				landY.m_value = landX;
				treeBranchX.m_value = 0;
				return;
			}
		}

		// Token: 0x06002222 RID: 8738 RVA: 0x000FBD18 File Offset: 0x000F9F18
		public static bool AnyDanger(bool quickBossNPCCheck = false, bool ignorePillarsAndMoonlordCountdown = false)
		{
			if (!true)
			{
				return;
			}
		}

		// Token: 0x06002223 RID: 8739 RVA: 0x000FBD2C File Offset: 0x000F9F2C
		public static bool AnyoneNearCultists()
		{
			int num = 1;
			if (num == 0)
			{
			}
			int num2 = NPC.FindFirstNPC(437);
			if (num == 0)
			{
			}
			Rectangle rectangle;
			Vector2 vector = rectangle.Size();
			bool flag;
			return flag;
		}

		// Token: 0x06002224 RID: 8740 RVA: 0x000FBD78 File Offset: 0x000F9F78
		public static void SpawnWOF(Vector2 pos)
		{
			int num = 1;
			if (num == 0)
			{
			}
			if (num == 0)
			{
			}
			bool netClientOnly = Main.NetClientOnly;
			if (num == 0)
			{
			}
			bool flag = NPC.AnyNPCs(113);
			int num2 = 32768;
			int num3 = 1;
			if (num2 == 0)
			{
			}
			if (num3 == 0)
			{
			}
		}

		// Token: 0x06002225 RID: 8741 RVA: 0x000FBF24 File Offset: 0x000FA124
		public static void SpawnSkeletron(int onWho)
		{
			if (!true)
			{
			}
			int num = 1;
			if (num == 0)
			{
			}
			int num2 = num.m_value;
			if (num == 0)
			{
			}
			if (num == 0 || num == 0)
			{
			}
		}

		// Token: 0x06002226 RID: 8742 RVA: 0x000FC004 File Offset: 0x000FA204
		public static void SpawnFaelings(int plr)
		{
			int num = 1;
			if (num == 0)
			{
			}
			bool flag = NPC.AnyNPCs(677);
			if (num == 0)
			{
			}
		}

		// Token: 0x06002227 RID: 8743 RVA: 0x000FC08C File Offset: 0x000FA28C
		public static void SpawnOnPlayer(int plr, int Type)
		{
			if (!true)
			{
			}
			bool netClientOnly = Main.NetClientOnly;
		}

		// Token: 0x06002228 RID: 8744 RVA: 0x000FC354 File Offset: 0x000FA554
		public static int GetAvailableAmountOfNPCsToSpawnUpToSlot(int amountWeWant, int highestNPCSlotIndexWeWillPick = 100)
		{
			/*
An exception occurred when decompiling this method (06002228)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Int32 Terraria.NPC::GetAvailableAmountOfNPCsToSpawnUpToSlot(System.Int32,System.Int32)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0009:
	brtrue(IL_0000, ldloc:int32[exp:bool](var_0_01))
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

		// Token: 0x06002229 RID: 8745 RVA: 0x000FC36C File Offset: 0x000FA56C
		public static IEntitySource GetBossSpawnSource(int targetPlayerIndex)
		{
			/*
An exception occurred when decompiling this method (06002229)

ICSharpCode.Decompiler.DecompilerException: Error decompiling Terraria.DataStructures.IEntitySource Terraria.NPC::GetBossSpawnSource(System.Int32)

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

		// Token: 0x0600222A RID: 8746 RVA: 0x000FC37C File Offset: 0x000FA57C
		public static void SpawnBoss(int spawnPositionX, int spawnPositionY, int Type, int targetPlayerIndex)
		{
			int num = 1;
			if (num == 0)
			{
			}
			if (num == 0)
			{
			}
			IEntitySource bossSpawnSource = NPC.GetBossSpawnSource(targetPlayerIndex);
		}

		// Token: 0x0600222B RID: 8747 RVA: 0x000FC470 File Offset: 0x000FA670
		public static int NewNPC(IEntitySource source, int X, int Y, int Type, int Start = 0, float ai0 = 0f, float ai1 = 0f, float ai2 = 0f, float ai3 = 0f, int Target = 255)
		{
			int num = 1;
			if (num == 0)
			{
			}
			int num3;
			if (num != 0)
			{
				if (num == 0)
				{
				}
				int num2;
				if (num2 != 0)
				{
					num3 = 614;
				}
			}
			if (num3 == 0)
			{
			}
			int availableNPCSlot = NPC.GetAvailableNPCSlot(Y, Type);
			if (num3 == 0)
			{
			}
			NPC.GiveTownUniqueDataToNPCsThatNeedIt(Y, availableNPCSlot);
			int num4 = 32768;
			int num5;
			if (num4 != 0)
			{
				bool netHost = Main.NetHost;
				if (num4 == 0)
				{
				}
				NetworkText networkText;
				if (networkText != null && networkText == null)
				{
					throw new ArrayTypeMismatchException();
				}
				num5 = 200;
			}
			if (num4 == 0)
			{
			}
			NetworkText networkText2;
			while (networkText2 != null)
			{
			}
			string text;
			string textValue = Language.GetTextValue("Announcement.HasAwoken", text);
			int num6 = 175;
			int num7 = 75;
			int num8 = 255;
			Main.NewText(textValue, (byte)num6, (byte)num7, (byte)num8);
			return num5;
		}

		// Token: 0x0600222C RID: 8748 RVA: 0x000FC524 File Offset: 0x000FA724
		private static int GetAvailableNPCSlot(int Type, int startIndex)
		{
			int num = 199;
			if (num == 0)
			{
			}
			if (num == 0)
			{
			}
			if (num != 0)
			{
				if (num == 0)
				{
				}
				if (num == 0)
				{
				}
			}
			return num;
		}

		// Token: 0x0600222D RID: 8749 RVA: 0x000FC548 File Offset: 0x000FA748
		private static void GiveTownUniqueDataToNPCsThatNeedIt(int Type, int nextNPC)
		{
			int num = 1;
			if (num == 0)
			{
			}
			if (num != 0)
			{
				if (num == 0)
				{
				}
				string newNPCName = NPC.getNewNPCName(Type);
				if ("" == null)
				{
				}
				return;
			}
		}

		// Token: 0x0600222E RID: 8750 RVA: 0x000FC584 File Offset: 0x000FA784
		public static void UnlockOrExchangePet(bool petBoughtFlag, int npcType, string textKeyForLicense, int netMessageData)
		{
			if (!true)
			{
			}
			bool flag = NPC.AnyNPCs(npcType);
			int myPlayer = Main.myPlayer;
		}

		// Token: 0x0600222F RID: 8751 RVA: 0x000FC5B8 File Offset: 0x000FA7B8
		public static bool RerollVariationForNPCType(int npcType)
		{
			if (!true)
			{
			}
			bool flag;
			return flag;
		}

		// Token: 0x06002230 RID: 8752 RVA: 0x000FC5D0 File Offset: 0x000FA7D0
		public bool RerollVariation()
		{
			if (!true)
			{
			}
			int num = this.type;
			int num2 = this.townNpcVariationIndex;
			int num3 = this.lifeMax;
			this._givenName = "";
			this.life = num3;
			if ("" == null)
			{
			}
			Vector2 center = base.Center;
			Vector2 velocity = this.velocity;
			if ("" == null)
			{
			}
			int whoAmI = this.whoAmI;
			if ("" == null)
			{
				return;
			}
		}

		// Token: 0x06002231 RID: 8753 RVA: 0x000FC648 File Offset: 0x000FA848
		public void TransformVisuals(int oldType, int newType)
		{
			int num = 1;
			float x = this.position.X;
			float y = this.position.Y;
			float x2 = this.netOffset.X;
			float y2 = this.netOffset.Y;
			if (num == 0)
			{
			}
			if (num == 0)
			{
				float x3 = this.position.X;
				float y3 = this.position.Y;
			}
			float x4 = this.position.X;
			float y4 = this.position.Y;
			float x5 = this.velocity.X;
			float y5 = this.velocity.Y;
			float num2 = this.scale;
			if (num == 0)
			{
			}
			int height = this.height;
			float x6 = this.position.X;
			float y6 = this.position.Y;
			float x7 = this.velocity.X;
			float y7 = this.velocity.Y;
			float num3 = this.scale;
			int height2 = this.height;
			float x8 = this.position.X;
			float y8 = this.position.Y;
			float x9 = this.velocity.X;
			float y9 = this.velocity.Y;
			float num4 = this.scale;
			float x10 = this.position.X;
			float y10 = this.position.Y;
			float x11 = this.netOffset.X;
			float y11 = this.netOffset.Y;
			this.position.X = x8;
			this.position.Y = (float)height2;
		}

		// Token: 0x06002232 RID: 8754 RVA: 0x000FC984 File Offset: 0x000FAB84
		public void Teleport(Vector2 newPos, int Style = 0, int extraInfo = 0)
		{
			int num = this.lastPortalColorIndex;
		}

		// Token: 0x06002233 RID: 8755 RVA: 0x000FC9F4 File Offset: 0x000FABF4
		public void Transform(int newType)
		{
			if (!true)
			{
			}
			bool netClientOnly = Main.NetClientOnly;
			int num = this.extraValue;
			float num2 = this.value;
			if (num == 0)
			{
			}
			int[] array = this.buffType;
			int[] array2 = this.buffTime;
		}

		// Token: 0x06002234 RID: 8756 RVA: 0x000FCBB0 File Offset: 0x000FADB0
		public int checkArmorPenetration(int armorPenetration, float armorPenetrationPercent)
		{
			/*
An exception occurred when decompiling this method (06002234)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Int32 Terraria.NPC::checkArmorPenetration(System.Int32,System.Single)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:int32(var_0_06, ldfld:int32(NPC::defense, ldloc:NPC(this)))
	stloc:bool(var_1_0D, ldfld:bool(NPC::ichor, ldloc:NPC(this)))
	stloc:bool(var_2_14, ldfld:bool(NPC::betsysCurse, ldloc:NPC(this)))
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

		// Token: 0x06002235 RID: 8757 RVA: 0x000FCBD4 File Offset: 0x000FADD4
		public double StrikeNPCNoInteraction(int Damage, float knockBack, int hitDirection, bool crit = false, bool noEffect = false, bool fromNet = false)
		{
			/*
An exception occurred when decompiling this method (06002235)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Double Terraria.NPC::StrikeNPCNoInteraction(System.Int32,System.Single,System.Int32,System.Boolean,System.Boolean,System.Boolean)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0005:
	stloc:bool(var_2_0C, callgetter:bool(Main::get_LogicClient))
	brtrue(IL_0000, ldloc:int32[exp:bool](var_0_01))
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

		// Token: 0x06002236 RID: 8758 RVA: 0x000FCBF0 File Offset: 0x000FADF0
		public double StrikeNPC(int Damage, float knockBack, int hitDirection, bool crit = false, bool noEffect = false, bool fromNet = false)
		{
			/*
An exception occurred when decompiling this method (06002236)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Double Terraria.NPC::StrikeNPC(System.Int32,System.Single,System.Int32,System.Boolean,System.Boolean,System.Boolean)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0442:
	brtrue(IL_0000, ldloc:int32[exp:bool](var_99))
}

   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1852
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

		// Token: 0x06002237 RID: 8759 RVA: 0x000FD048 File Offset: 0x000FB248
		public static void LadyBugKilled(Vector2 Position, bool GoldLadyBug = false)
		{
			if (!true)
			{
			}
			int myPlayer = Main.myPlayer;
			Vector2 vector;
			float num = vector.Length();
			float num2 = vector.Length();
			float num3 = vector.Length();
			long num4 = 32752L;
			if (num4 == 0L)
			{
			}
			if (num4 == 0L)
			{
			}
		}

		// Token: 0x06002238 RID: 8760 RVA: 0x000FD08C File Offset: 0x000FB28C
		private void LadyBugLuck(int plr, bool GoldLadyBug = false)
		{
			short num = this.releaseOwner;
			if (num == 0)
			{
			}
			Vector2 center = base.Center;
			if (num == 0)
			{
			}
			if (num == 0)
			{
			}
			Vector2 vector;
			float num2 = vector.Length();
			float num3 = vector.Length();
			float num4 = vector.Length();
			if (49289 == 0)
			{
			}
			long num5 = 32752L;
			if (num5 == 0L)
			{
			}
			if (num5 == 0L)
			{
			}
		}

		// Token: 0x06002239 RID: 8761 RVA: 0x000FD0EC File Offset: 0x000FB2EC
		private void NPCLuck()
		{
			if (!true)
			{
			}
			int myPlayer = Main.myPlayer;
			int num = this.type;
			if (num == 0)
			{
			}
			if (num == 0)
			{
				return;
			}
		}

		// Token: 0x0600223A RID: 8762 RVA: 0x000FD128 File Offset: 0x000FB328
		public void HitEffect(int hitDirection = 0, double dmg = 10.0)
		{
			if (!this.active)
			{
				return;
			}
			if (this.townNPC)
			{
				int num = this.life;
				bool flag = this.UsesPartyHat();
				bool isShimmerVariant = this.IsShimmerVariant;
				int num2 = this.type;
				float x = this.position.X;
				float x2 = this.velocity.X;
				bool isShimmerVariant2 = this.IsShimmerVariant;
				return;
			}
			if (this.daybreak)
			{
				int num3 = this.life;
				Rectangle hitbox = base.Hitbox;
				if (20 != 0)
				{
					Vector2 vector = hitbox.TopLeft();
					int width = this.width;
					bool wet = this.wet;
					return;
				}
				bool logicHost = Main.LogicHost;
				int num4;
				if (num4 == 0)
				{
				}
				if (num4 == 0 || num4 != 0 || num4 != 0 || num4 != 0 || num4 == 0)
				{
				}
			}
			int num5 = this.type;
			int num6 = this.life;
			Vector2 bottom = base.Bottom;
			if (!true)
			{
			}
			float num7 = this.rotation;
			Gore gore;
			float y = gore.velocity.Y;
			float x3 = gore.velocity.X;
			float num8;
			gore.velocity.Y = num8;
			gore.velocity.Y = num8;
			Vector2 bottom2 = base.Bottom;
			if (!true)
			{
			}
			float num9 = this.rotation;
			Gore gore2;
			float y2 = gore2.velocity.Y;
			float x4 = gore2.velocity.X;
			gore2.velocity.Y = num8;
			gore2.velocity.Y = num8;
			Vector2 bottom3 = base.Bottom;
			Vector2 velocity = this.velocity;
			int num10 = 680;
			this.Transform(num10);
			int num11 = 1;
			this.position.X = y2;
			this.velocity = velocity;
			this.netUpdate = num11 != 0;
			if (num11 == 0)
			{
			}
			bool netHost = Main.NetHost;
			int num12 = this.life;
			float[] array = this.ai;
			Vector2 bottom4 = base.Bottom;
			if (!true)
			{
			}
			float num13 = this.rotation;
			Gore gore3;
			float y3 = gore3.velocity.Y;
			float x5 = gore3.velocity.X;
			gore3.velocity.Y = num8;
			gore3.velocity.Y = num8;
			Vector2 bottom5 = base.Bottom;
			if (!true)
			{
			}
			float num14 = this.rotation;
			Gore gore4;
			float y4 = gore4.velocity.Y;
			float x6 = gore4.velocity.X;
			gore4.velocity.Y = num8;
			gore4.velocity.Y = num8;
			NPC npc = this.AI_113_WindyBalloon_GetSlaveNPC();
			if (npc != null)
			{
				float[] array2 = npc.ai;
				float y5 = npc.position.Y;
				int num15 = 1;
				npc.netUpdate = num15 != 0;
				npc.position.Y = y5;
			}
			int num16 = this.life;
			int num17 = this.lifeMax;
			int num18;
			if (num18 == 0)
			{
				int num19 = 255;
				float num20;
				Color color = Main.hslToRgb(num20, num8, num20, (byte)num19);
				float x7 = this.position.X;
				float y6 = this.position.Y;
				int width2 = this.width;
				bool wet2 = this.wet;
				Vector2 center = base.Center;
				int width3 = this.width;
				bool wet3 = this.wet;
				Vector2 center2 = base.Center;
				return;
			}
			int num21 = this.lifeMax;
		}

		// Token: 0x0600223B RID: 8763 RVA: 0x0010F8F4 File Offset: 0x0010DAF4
		public static int CountNPCS(int Type)
		{
			/*
An exception occurred when decompiling this method (0600223B)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Int32 Terraria.NPC::CountNPCS(System.Int32)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	brtrue(IL_0000, ldloc:int32[exp:bool](var_0_01))
}

   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1852
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

		// Token: 0x0600223C RID: 8764 RVA: 0x0010F910 File Offset: 0x0010DB10
		public static bool AnyHelpfulFairies()
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
				return;
			}
		}

		// Token: 0x0600223D RID: 8765 RVA: 0x0010F930 File Offset: 0x0010DB30
		public static bool AnyNPCs(int Type)
		{
			int num = 1;
			if (num == 0)
			{
			}
			if (num == 0 || num == 0)
			{
				return;
			}
		}

		// Token: 0x0600223E RID: 8766 RVA: 0x0010F950 File Offset: 0x0010DB50
		public static int FindFirstNPC(int Type)
		{
			/*
An exception occurred when decompiling this method (0600223E)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Int32 Terraria.NPC::FindFirstNPC(System.Int32)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	brtrue(IL_0000, ldloc:int32[exp:bool](var_0_01))
}

   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1852
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

		// Token: 0x0600223F RID: 8767 RVA: 0x0010F96C File Offset: 0x0010DB6C
		public static bool NearSpikeBall(int x, int y)
		{
			if (!true)
			{
				return;
			}
		}

		// Token: 0x06002240 RID: 8768 RVA: 0x0010F99C File Offset: 0x0010DB9C
		public int FindBuffIndex(int type)
		{
			/*
An exception occurred when decompiling this method (06002240)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Int32 Terraria.NPC::FindBuffIndex(System.Int32)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_000F:
	stloc:int32[](var_2_15, ldfld:int32[](NPC::buffTime, ldloc:NPC(this)))
	stloc:int32[](var_3_1C, ldfld:int32[](NPC::buffType, ldloc:NPC(this)))
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

		// Token: 0x06002241 RID: 8769 RVA: 0x0010F9C8 File Offset: 0x0010DBC8
		public void AddBuff(int type, int time, bool quiet = false)
		{
			bool[] array = this.buffImmune;
			if (array != null)
			{
				return;
			}
			if (array == null)
			{
			}
			bool netClientOnly = Main.NetClientOnly;
			int whoAmI = this.whoAmI;
			if (array == null)
			{
			}
		}

		// Token: 0x06002242 RID: 8770 RVA: 0x0010FA6C File Offset: 0x0010DC6C
		public void RequestBuffRemoval(int buffTypeToRemove)
		{
			int num = 1;
			if (num == 0)
			{
			}
			if (num != 0)
			{
				int num2 = this.FindBuffIndex(buffTypeToRemove);
				this.DelBuff(num2);
				if (num == 0)
				{
				}
				bool netClientOnly = Main.NetClientOnly;
				int whoAmI = this.whoAmI;
			}
		}

		// Token: 0x06002243 RID: 8771 RVA: 0x0010FAAC File Offset: 0x0010DCAC
		public void DelBuff(int buffIndex)
		{
			int[] array = this.buffTime;
			if (this.buffType == null)
			{
			}
			int[] array2;
			if (this.buffTime != null)
			{
				array2 = this.buffType;
				if (array2 != null)
				{
					return;
				}
			}
			if (array2 == null)
			{
			}
			int[] array3 = this.buffTime;
			int[] array4 = this.buffType;
		}

		// Token: 0x06002244 RID: 8772 RVA: 0x0010FB10 File Offset: 0x0010DD10
		public Rectangle getRect()
		{
			/*
An exception occurred when decompiling this method (06002244)

ICSharpCode.Decompiler.DecompilerException: Error decompiling Microsoft.Xna.Framework.Rectangle Terraria.NPC::getRect()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:float32(var_0_0B, ldfld:float32(Vector2::X, ldfld:Vector2[exp:valuetype Microsoft.Xna.Framework.Vector2&](Entity::position, ldloc:NPC[exp:Entity](this))))
	stloc:float32(var_1_17, ldfld:float32(Vector2::Y, ldfld:Vector2[exp:valuetype Microsoft.Xna.Framework.Vector2&](Entity::position, ldloc:NPC[exp:Entity](this))))
	stloc:int32(var_2_1E, ldfld:int32(Entity::width, ldloc:NPC[exp:Entity](this)))
	stloc:bool(var_3_25, ldfld:bool(Entity::wet, ldloc:NPC[exp:Entity](this)))
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

		// Token: 0x06002245 RID: 8773 RVA: 0x0010FB44 File Offset: 0x0010DD44
		public bool CanBeChasedBy([Optional] object attacker, bool ignoreDontTakeDamage = false)
		{
			while (this.active && this.chaseable)
			{
				int num = this.lifeMax;
				if (!this.dontTakeDamage || this.friendly)
				{
					return;
				}
			}
		}

		// Token: 0x06002246 RID: 8774 RVA: 0x0010FB7C File Offset: 0x0010DD7C
		public bool HittableForOnHitRewards()
		{
			/*
An exception occurred when decompiling this method (06002246)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean Terraria.NPC::HittableForOnHitRewards()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0016:
	stloc:int32(var_2_1C, ldfld:int32(NPC::type, ldloc:NPC(this)))
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

		// Token: 0x170004F6 RID: 1270
		// (get) Token: 0x06002247 RID: 8775 RVA: 0x0010FBA8 File Offset: 0x0010DDA8
		public bool CountsAsACritter
		{
			get
			{
				for (;;)
				{
					int num = this.lifeMax;
					if (this.damage != 0)
					{
						return;
					}
				}
			}
		}

		// Token: 0x06002248 RID: 8776 RVA: 0x0010FBC8 File Offset: 0x0010DDC8
		public void moneyPing(Vector2 pos)
		{
			int num = this.extraValue;
		}

		// Token: 0x06002249 RID: 8777 RVA: 0x0010FBFC File Offset: 0x0010DDFC
		public void IdleSounds()
		{
			float num = this.shimmerTransparency;
		}

		// Token: 0x0600224A RID: 8778 RVA: 0x001101F8 File Offset: 0x0010E3F8
		public void UpdateAltTexture()
		{
			if (this.townNPC)
			{
				int num = this.altTexture;
				bool partyIsUp = BirthdayParty.PartyIsUp;
				return;
			}
		}

		// Token: 0x0600224B RID: 8779 RVA: 0x00110254 File Offset: 0x0010E454
		private void MakeTransitionEffectsForTextureChanges(int oldAltTexture, int currentAltTexture)
		{
			int num = 1;
			if (oldAltTexture == 0)
			{
				float x = this.position.X;
				float y = this.position.Y;
				int width = this.width;
				bool wet = this.wet;
				if (num == 0)
				{
				}
			}
			if (currentAltTexture == 0)
			{
				float x2 = this.position.X;
				float y2 = this.position.Y;
			}
			int num2 = this.type;
			if (num2 != 0)
			{
				int num3 = 1;
				int num4 = 16384;
				float x3 = this.position.X;
				float y3 = this.position.Y;
				int width2 = this.width;
				bool wet2 = this.wet;
				if (num2 == 0)
				{
				}
				Dust dust;
				dust.noGravity = num3 != 0;
				dust.scale = (float)num4;
			}
		}

		// Token: 0x0600224C RID: 8780 RVA: 0x0011030C File Offset: 0x0010E50C
		public static void ResetNetOffsets()
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

		// Token: 0x0600224D RID: 8781 RVA: 0x00110330 File Offset: 0x0010E530
		public void UpdateNPC(int i)
		{
			bool active = this.active;
			this.whoAmI = i;
			if (active)
			{
				if (!active)
				{
				}
				if (!active)
				{
				}
				bool netHost = Main.NetHost;
				float x = this.netOffset.X;
				float y = this.netOffset.Y;
				if (!active)
				{
				}
				this.UpdateAltTexture();
				int num = this.type;
				if (num == 0)
				{
				}
				if (num == 0)
				{
				}
				bool logicClient = Main.LogicClient;
				this.UpdateNPC_CastLights();
				this.UpdateNPC_TeleportVisuals();
				this.UpdateNPC_CritterSounds();
				this.TrySyncingUniqueTownNPCData(i);
				int num2 = this.aiStyle;
				float y2 = this.position.Y;
				if (num2 == 0)
				{
				}
				int height = this.height;
				int num3 = 50208;
				if (num3 == 0)
				{
				}
				bool logicHost = Main.LogicHost;
				if (num3 == 0)
				{
				}
				if (num3 == 0)
				{
					if (num3 == 0)
					{
					}
					bool netHost2 = Main.NetHost;
					int whoAmI = this.whoAmI;
				}
				bool netClientOnly = Main.NetClientOnly;
				int width = this.width;
				bool wet = this.wet;
				float x2 = this.position.X;
				float y3 = this.position.Y;
				int num4 = 32768;
				int num5 = 1;
				this.lifeRegenExpectedLossPerSecond = num4;
				this.UpdateNPC_BuffSetFlags(num5 != 0);
				this.UpdateNPC_SoulDrainDebuff();
				this.UpdateNPC_BuffClearExpiredBuffs();
				this.UpdateNPC_BuffApplyDOTs();
				this.UpdateNPC_BuffApplyVFX();
				this.UpdateNPC_BloodMoonTransformations();
				double num6;
				this.UpdateNPC_UpdateGravity((float)num6);
				int num7 = this.soundDelay;
				this.soundDelay = num7;
				int num8 = this.life;
				int num9 = this.target;
				int direction = this.direction;
				int num10 = this.directionY;
				this.oldTarget = num9;
				this.oldDirection = direction;
				this.oldDirectionY = num10;
				float x3 = this.velocity.X;
				if (num9 == 0)
				{
				}
				float num11 = this.gfxOffY;
				float num12 = this.stepSpeed;
				this.gfxOffY = num11;
				return;
			}
		}

		// Token: 0x0600224E RID: 8782 RVA: 0x00110A64 File Offset: 0x0010EC64
		private void SubAI_HandleTemporaryCatchableNPCPlayerInvulnerability()
		{
			int num = this.type;
			if (this.type != 0)
			{
				short num2 = this.releaseOwner;
				long num4;
				if (!this.SpawnedFromStatue)
				{
					int num3 = this.catchableNPCTempImmunityCounter;
					bool flag = this.friendly;
					this.catchableNPCTempImmunityCounter = (int)num4;
					return;
				}
				bool flag2 = this.friendly;
				num4 = 0L;
				int num5 = 1;
				this.netUpdate = num5 != 0;
			}
		}

		// Token: 0x0600224F RID: 8783 RVA: 0x00110ABC File Offset: 0x0010ECBC
		private void TrySyncingUniqueTownNPCData(int npcIndex)
		{
			if (!true)
			{
			}
			bool netClientOnly = Main.NetClientOnly;
			if (this.needsUniqueInfoUpdate)
			{
				int num = this.type;
				if (this.townNPC)
				{
				}
			}
		}

		// Token: 0x06002250 RID: 8784 RVA: 0x00110AEC File Offset: 0x0010ECEC
		private void UpdateNetworkCode(int i)
		{
			int num;
			if (!this.active)
			{
				num = 1;
				this.netUpdate = num != 0;
			}
			if (num == 0)
			{
			}
			bool netHost = Main.NetHost;
			if (num == 0)
			{
			}
			if (!this.townNPC)
			{
				int num2;
				if (num2 == 0)
				{
				}
				while (num2 == 0)
				{
				}
				float x = this.velocity.X;
				if (num2 == 0)
				{
				}
				float y = this.velocity.Y;
				if (this.netStream == 0)
				{
				}
				Vector2 center = base.Center;
				Vector2 center2 = base.Center;
				int[] array = this.streamPlayer;
				return;
			}
			if (!this.townNPC)
			{
				int num3 = this.aiStyle;
			}
			if (this.netUpdate2)
			{
				int num4 = 1;
				this.netUpdate = num4 != 0;
			}
			if (!this.active)
			{
			}
			if (!this.netUpdate)
			{
				int num5 = this.netSpam;
				this.netSpam = num5;
				if (this.active && this.townNPC)
				{
					int num6 = NPC.TypeToDefaultHeadIndex(this.type);
					bool flag = this.homeless;
					bool flag2 = this.oldHomeless;
					int num7 = this.homeTileX;
					int num8 = this.oldHomeTileX;
					int num9 = this.homeTileY;
					int num10 = this.oldHomeTileY;
					if (!flag)
					{
					}
					if (num7 == 0)
					{
					}
					if (num7 == 0)
					{
					}
					bool flag3 = this.homeless;
					int num11 = this.homeTileX;
					int num12 = this.homeTileY;
					this.oldHomeless = flag3;
					this.oldHomeTileX = num11;
					this.oldHomeTileY = num12;
				}
				return;
			}
			if (this.boss)
			{
				float x2 = this.oldPosition.X;
				float y2 = this.oldPosition.Y;
				float x3 = this.position.X;
				float y3 = this.position.Y;
				int num2 = this.netSpam;
				return;
			}
			int num13 = this.netSpam;
		}

		// Token: 0x06002251 RID: 8785 RVA: 0x000021DB File Offset: 0x000003DB
		public IEntitySource GetItemSource_Misc(int itemSourceId)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06002252 RID: 8786 RVA: 0x00110CDC File Offset: 0x0010EEDC
		public static IEntitySource GetSpawnSource_NPCRelease(int whoReleasedIt)
		{
			/*
An exception occurred when decompiling this method (06002252)

ICSharpCode.Decompiler.DecompilerException: Error decompiling Terraria.DataStructures.IEntitySource Terraria.NPC::GetSpawnSource_NPCRelease(System.Int32)

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

		// Token: 0x06002253 RID: 8787 RVA: 0x00110CEC File Offset: 0x0010EEEC
		public static IEntitySource GetSpawnSource_NPCCatch(int whoCatchedIt)
		{
			/*
An exception occurred when decompiling this method (06002253)

ICSharpCode.Decompiler.DecompilerException: Error decompiling Terraria.DataStructures.IEntitySource Terraria.NPC::GetSpawnSource_NPCCatch(System.Int32)

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

		// Token: 0x06002254 RID: 8788 RVA: 0x000021DB File Offset: 0x000003DB
		public IEntitySource GetSpawnSource_NPCHurt()
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06002255 RID: 8789 RVA: 0x000021DB File Offset: 0x000003DB
		public IEntitySource GetSpawnSource_ForProjectile()
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06002256 RID: 8790 RVA: 0x000021DB File Offset: 0x000003DB
		public IEntitySource GetSpawnSourceForProjectileNPC()
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06002257 RID: 8791 RVA: 0x000021DB File Offset: 0x000003DB
		public static IEntitySource GetSpawnSourceForNaturalSpawn()
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06002258 RID: 8792 RVA: 0x000021DB File Offset: 0x000003DB
		public static IEntitySource GetSpawnSourceForTownSpawn()
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06002259 RID: 8793 RVA: 0x000021DB File Offset: 0x000003DB
		public IEntitySource GetSpawnSourceForNPCFromNPCAI()
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x0600225A RID: 8794 RVA: 0x000021DB File Offset: 0x000003DB
		public IEntitySource GetItemSource_Loot()
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x0600225B RID: 8795 RVA: 0x00110CFC File Offset: 0x0010EEFC
		private void UpdateNPC_UpdateTrails()
		{
			if (!true)
			{
			}
		}

		// Token: 0x0600225C RID: 8796 RVA: 0x0011101C File Offset: 0x0010F21C
		private void UpdateNPC_UpdateGravity([Out] float maxFallSpeed)
		{
			if (16672 == 0)
			{
			}
			if (this.type == 0)
			{
			}
			float y = this.velocity.Y;
			int num = 16448;
			this.velocity.Y = (float)num;
		}

		// Token: 0x0600225D RID: 8797 RVA: 0x000021DB File Offset: 0x000003DB
		private void UpdateNPC_SoulDrainDebuff()
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x0600225E RID: 8798 RVA: 0x001110F8 File Offset: 0x0010F2F8
		public static Color buffColor(Color newColor, float R, float G, float B, float A)
		{
			Color color;
			return color;
		}

		// Token: 0x0600225F RID: 8799 RVA: 0x00111108 File Offset: 0x0010F308
		public bool CanApplyHunterPotionEffects()
		{
			/*
An exception occurred when decompiling this method (0600225F)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean Terraria.NPC::CanApplyHunterPotionEffects()

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

		// Token: 0x06002260 RID: 8800 RVA: 0x00111120 File Offset: 0x0010F320
		public Color GetNPCColorTintedByBuffs(Color npcColor)
		{
			if (this.canDisplayBuffs)
			{
				bool flag = this.poisoned;
				if (!flag || !flag)
				{
				}
				bool flag2 = this.venom;
				if (!flag2 || !flag2)
				{
				}
				if (this.midas)
				{
				}
				if (this.betsysCurse)
				{
				}
				if (this.oiled)
				{
				}
				if (this.stinky)
				{
				}
				bool flag3 = this.drippingSlime;
				if (!flag3 || !flag3)
				{
				}
				bool flag4 = this.drippingSparkleSlime;
				if (!flag4 || !flag4)
				{
				}
				if (this.ichor)
				{
				}
				int num = this.lifeMax;
				if (this.friendly)
				{
					return 50;
				}
			}
			return 50;
		}

		// Token: 0x06002261 RID: 8801 RVA: 0x001111C0 File Offset: 0x0010F3C0
		private void UpdateNPC_BuffApplyVFX()
		{
			bool flag = this.canDisplayBuffs;
			if (flag)
			{
				float x = this.position.X;
				float y = this.position.Y;
				float x2 = this.netOffset.X;
				float y2 = this.netOffset.Y;
				if (!flag)
				{
				}
				bool flag2 = this.markedByScytheWhip;
				if (flag2)
				{
					if (!flag2)
					{
					}
					int num;
					if (num == 0)
					{
						if (!flag2)
						{
						}
						Rectangle hitbox = base.Hitbox;
					}
				}
				bool flag3 = this.poisoned;
				if (flag3)
				{
					if (!flag3)
					{
					}
					int num2;
					if (num2 == 0)
					{
						float x3 = this.position.X;
						float y3 = this.position.Y;
						int width = this.width;
						bool wet = this.wet;
						if (!flag3)
						{
						}
						int num3 = 13107;
						int num4 = 1;
						Dust dust;
						dust.noGravity = num4 != 0;
						dust.fadeIn = (float)num3;
					}
				}
				bool flag4 = this.venom;
				if (flag4)
				{
					if (!flag4)
					{
					}
					int num5;
					if (num5 == 0)
					{
						float x4 = this.position.X;
						float y4 = this.position.Y;
						int width2 = this.width;
						bool wet2 = this.wet;
						if (!flag4)
						{
						}
						int num6 = 1;
						int num7 = 16320;
						Dust dust2;
						dust2.noGravity = num6 != 0;
						dust2.fadeIn = (float)num7;
					}
				}
				bool flag5 = this.shadowFlame;
				if (flag5)
				{
					if (!flag5)
					{
					}
					float x5 = this.position.X;
					float y5 = this.position.Y;
					int width3 = this.width;
					bool wet3 = this.wet;
					float x6 = this.velocity.X;
					float y6 = this.velocity.Y;
					if (!flag5)
					{
					}
					int num8 = 1;
					Dust dust3;
					dust3.noGravity = num8 != 0;
					float x7 = dust3.velocity.X;
					float y7 = dust3.velocity.Y;
					if (num8 == 0)
					{
					}
					dust3.velocity.X = x5;
					dust3.velocity.Y = y5;
					if (num8 == 0)
					{
					}
					int num9;
					if (num9 == 0)
					{
						float num10 = dust3.scale;
						dust3.scale = num10;
					}
				}
				bool flag6 = this.onFire;
				if (flag6)
				{
					if (!flag6)
					{
					}
					float x8 = this.position.X;
					float y8 = this.position.Y;
					int width4 = this.width;
					bool wet4 = this.wet;
					float x9 = this.velocity.X;
					float y9 = this.velocity.Y;
					if (!flag6)
					{
					}
					int num11 = 1;
					Dust dust4;
					dust4.noGravity = num11 != 0;
					float x10 = dust4.velocity.X;
					float y10 = dust4.velocity.Y;
					if (num11 == 0)
					{
					}
					dust4.velocity.X = x8;
					dust4.velocity.Y = y8;
					int num12;
					if (num12 == 0)
					{
						float num13 = dust4.scale;
						dust4.scale = num13;
					}
					float x11 = this.position.X;
					float y11 = this.position.Y;
				}
				bool flag7 = this.onFire3;
				if (flag7)
				{
					if (!flag7)
					{
					}
					float x12 = this.position.X;
					float y12 = this.position.Y;
					int width5 = this.width;
					bool wet5 = this.wet;
					float x13 = this.velocity.X;
					float y13 = this.velocity.Y;
					if (!flag7)
					{
					}
					int num14 = 1;
					Dust dust5;
					dust5.noGravity = num14 != 0;
					float x14 = dust5.velocity.X;
					float y14 = dust5.velocity.Y;
					if (num14 == 0)
					{
					}
					dust5.velocity.X = x12;
					dust5.velocity.Y = y12;
					int num15;
					if (num15 == 0)
					{
						float num16 = dust5.scale;
						dust5.scale = num16;
					}
					float x15 = this.position.X;
					float y15 = this.position.Y;
				}
				bool flag8 = this.daybreak;
				if (flag8)
				{
					if (!flag8)
					{
					}
					float x16 = this.position.X;
					float y16 = this.position.Y;
					int width6 = this.width;
					bool wet6 = this.wet;
					float x17 = this.velocity.X;
					float y17 = this.velocity.Y;
					if (!flag8)
					{
					}
					int num17 = 1;
					Dust dust6;
					dust6.noGravity = num17 != 0;
					float x18 = dust6.velocity.X;
					float y18 = dust6.velocity.Y;
					if (num17 == 0)
					{
					}
					dust6.velocity.X = x16;
					dust6.velocity.Y = y16;
					if (num17 == 0)
					{
					}
					int num18;
					if (num18 == 0)
					{
						float num19 = dust6.scale;
						dust6.scale = num19;
					}
					float x19 = this.position.X;
					float y19 = this.position.Y;
					if (num17 == 0)
					{
					}
				}
				bool flag9 = this.betsysCurse;
				int num22;
				if (flag9)
				{
					if (!flag9)
					{
					}
					float x20 = this.position.X;
					float y20 = this.position.Y;
					int width7 = this.width;
					bool wet7 = this.wet;
					float x21 = this.velocity.X;
					float y21 = this.velocity.Y;
					if (!flag9)
					{
					}
					int num20 = 1;
					Dust dust7;
					dust7.noGravity = num20 != 0;
					float x22 = dust7.velocity.X;
					float y22 = dust7.velocity.Y;
					if (num20 == 0)
					{
					}
					int num21 = 26214;
					dust7.scale = (float)num21;
					dust7.velocity.X = x20;
					dust7.velocity.Y = y20;
					float x23 = dust7.velocity.X;
					float y23 = dust7.velocity.Y;
					dust7.color = num21;
					dust7.velocity.X = x23;
					dust7.velocity.Y = y23;
					float x24 = this.position.X;
					float y24 = this.position.Y;
					num22 = 32640;
				}
				bool flag10 = this.oiled;
				if (flag10)
				{
					if (!flag10)
					{
					}
					int num23;
					if (num23 != 0)
					{
						float x25 = this.position.X;
						float y25 = this.position.Y;
						if (!flag10)
						{
						}
						int num24;
						if (num24 == 0)
						{
							int width8 = this.width;
							bool wet8 = this.wet;
							if (!flag10)
							{
							}
							if (num22 == 0)
							{
							}
							int num25;
							Dust dust8;
							int num26;
							if (num25 == 0)
							{
								num26 = dust8.alpha;
								dust8.alpha = num26;
							}
							if (num26 == 0)
							{
							}
							int num27;
							if (num27 == 0)
							{
								int num28 = dust8.alpha;
								dust8.alpha = num28;
							}
							int num29 = 1;
							dust8.noLight = num29 != 0;
							float x26 = dust8.velocity.X;
							float y26 = dust8.velocity.Y;
							if (num29 == 0)
							{
							}
							float x27 = this.velocity.X;
							float y27 = this.velocity.Y;
						}
					}
				}
				bool flag11 = this.dryadWard;
				if (flag11)
				{
					float x28 = this.velocity.X;
					if (!flag11)
					{
					}
					int num30;
					if (num30 == 0)
					{
						int height = this.height;
						float x29 = this.position.X;
						float y28 = this.position.Y;
						int width9 = this.width;
						float x30 = this.velocity.X;
						float y29 = this.velocity.Y;
						if (!flag11)
						{
						}
						int num31 = 1;
						Dust dust9;
						dust9.noGravity = num31 != 0;
						dust9.noLight = num31 != 0;
						float x31 = dust9.velocity.X;
						float y30 = dust9.velocity.Y;
						if (num31 == 0)
						{
						}
						dust9.velocity.X = x29;
						dust9.velocity.Y = (float)height;
					}
				}
				bool flag12 = this.dryadBane;
				if (flag12)
				{
					if (!flag12)
					{
					}
					int num32;
					if (num32 == 0)
					{
						float x32 = this.position.X;
						float y31 = this.position.Y;
						int width10 = this.width;
						bool wet9 = this.wet;
						float x33 = this.velocity.X;
						float y32 = this.velocity.Y;
						if (!flag12)
						{
						}
						int num33 = 1;
						Dust dust10;
						dust10.noGravity = num33 != 0;
						float x34 = dust10.velocity.X;
						float y33 = dust10.velocity.Y;
						if (num33 == 0)
						{
						}
						int num34 = 1;
						dust10.velocity.X = x32;
						dust10.velocity.Y = y31;
						dust10.noLight = num34 != 0;
					}
				}
				bool flag13 = this.loveStruck;
				if (flag13)
				{
					if (!flag13)
					{
					}
					int num35;
					if (num35 == 0)
					{
						if (!flag13)
						{
						}
						float x35 = this.position.X;
						float y34 = this.position.Y;
						int width11 = this.width;
						if (this.height == 0)
						{
						}
					}
				}
				bool flag14 = this.stinky;
				float x37;
				float y36;
				if (flag14)
				{
					if (!flag14)
					{
					}
					int num36;
					if (num36 == 0)
					{
						if (!flag14)
						{
						}
						float x36 = this.position.X;
						float y35 = this.position.Y;
						int width12 = this.width;
						bool wet10 = this.wet;
						Dust dust11;
						x37 = dust11.velocity.X;
						y36 = dust11.velocity.Y;
						dust11.velocity.X = x37;
						dust11.velocity.Y = y36;
					}
				}
				bool flag15 = this.dripping;
				if (flag15)
				{
					if (!flag15)
					{
					}
					int num37;
					if (num37 != 0)
					{
						float x38 = this.position.X;
						float y37 = this.position.Y;
						if (!flag15)
						{
						}
						int width13 = this.width;
						bool wet11 = this.wet;
						int num38;
						if (num38 != 0)
						{
							int num39;
							Dust dust12;
							int num40;
							if (num39 == 0)
							{
								num40 = dust12.alpha;
								dust12.alpha = num40;
							}
							if (num40 == 0)
							{
							}
							int num41;
							if (num41 == 0)
							{
								int num42 = dust12.alpha;
								dust12.alpha = num42;
							}
							int num43 = 1;
							dust12.noLight = num43 != 0;
							dust12.noGravity = num43 != 0;
							float x39 = dust12.velocity.X;
							float y38 = dust12.velocity.Y;
							if (num43 == 0)
							{
							}
							return;
						}
						int num44;
						Dust dust13;
						int num45;
						if (num44 == 0)
						{
							num45 = dust13.alpha;
							dust13.alpha = num45;
						}
						if (num45 == 0)
						{
						}
						int num46;
						if (num46 == 0)
						{
							int num47 = dust13.alpha;
							dust13.alpha = num47;
						}
						int num48 = 1;
						dust13.noLight = num48 != 0;
						float x40 = dust13.velocity.X;
						float y39 = dust13.velocity.Y;
						if (num48 == 0)
						{
						}
						dust13.velocity.X = x37;
						dust13.velocity.Y = y36;
						float x41 = this.velocity.X;
						float y40 = this.velocity.Y;
						dust13.velocity.X = x37;
						dust13.velocity.Y = y36;
					}
				}
				bool flag16 = this.drippingSlime;
				if (flag16)
				{
					if (!flag16)
					{
					}
					int num49;
					if (num49 != 0)
					{
						float x42 = this.position.X;
						float y41 = this.position.Y;
						if (!flag16)
						{
						}
						int num50;
						if (num50 == 0)
						{
							int width14 = this.width;
							bool wet12 = this.wet;
							if (!flag16)
							{
							}
							int num51;
							Dust dust14;
							int num52;
							if (num51 == 0)
							{
								num52 = dust14.alpha;
								dust14.alpha = num52;
							}
							if (num52 == 0)
							{
							}
							int num53;
							if (num53 == 0)
							{
								int num54 = dust14.alpha;
								dust14.alpha = num54;
							}
							int num55 = 1;
							dust14.noLight = num55 != 0;
							float x43 = dust14.velocity.X;
							float y42 = dust14.velocity.Y;
							if (num55 == 0)
							{
							}
							dust14.velocity.X = x37;
							dust14.velocity.Y = y36;
							float x44 = this.velocity.X;
							float y43 = this.velocity.Y;
							dust14.velocity.X = x37;
							dust14.velocity.Y = y36;
						}
					}
				}
				bool flag17 = this.drippingSparkleSlime;
				if (flag17)
				{
					if (!flag17)
					{
					}
					int num56;
					if (num56 != 0)
					{
						float x45 = this.position.X;
						float y44 = this.position.Y;
						if (!flag17)
						{
						}
						int num57;
						if (num57 == 0)
						{
							int width15 = this.width;
							bool wet13 = this.wet;
							if (!flag17)
							{
							}
							int num58;
							Dust dust15;
							int num59;
							if (num58 == 0)
							{
								num59 = dust15.alpha;
								dust15.alpha = num59;
							}
							if (num59 == 0)
							{
							}
							int num60;
							if (num60 == 0)
							{
								int num61 = dust15.alpha;
								dust15.alpha = num61;
							}
							int num62 = 1;
							dust15.noLight = num62 != 0;
							float x46 = dust15.velocity.X;
							float y45 = dust15.velocity.Y;
							if (num62 == 0)
							{
							}
							dust15.velocity.X = x37;
							dust15.velocity.Y = y36;
							float x47 = this.velocity.X;
							float y46 = this.velocity.Y;
							dust15.velocity.X = x37;
							dust15.velocity.Y = y36;
						}
					}
				}
				bool flag18 = this.onFrostBurn;
				float num67;
				if (flag18)
				{
					if (!flag18)
					{
					}
					float x48 = this.position.X;
					float y47 = this.position.Y;
					int width16 = this.width;
					bool wet14 = this.wet;
					float x49 = this.velocity.X;
					float y48 = this.velocity.Y;
					if (!flag18)
					{
					}
					int num63 = 1;
					Dust dust16;
					dust16.noGravity = num63 != 0;
					float x50 = dust16.velocity.X;
					float y49 = dust16.velocity.Y;
					if (num63 == 0)
					{
					}
					dust16.velocity.X = x48;
					dust16.velocity.Y = y47;
					int num64 = 4;
					int num65;
					if (num65 == 0)
					{
						float num66 = dust16.scale;
						dust16.scale = num66;
					}
					float x51 = this.position.X;
					float y50 = this.position.Y;
					Lighting.AddLight(1073741824, num64, num67, num67, num67);
				}
				bool flag19 = this.onFrostBurn2;
				if (flag19)
				{
					if (!flag19)
					{
					}
					float x52 = this.position.X;
					float y51 = this.position.Y;
					int width17 = this.width;
					bool wet15 = this.wet;
					float x53 = this.velocity.X;
					float y52 = this.velocity.Y;
					if (!flag19)
					{
					}
					int num68 = 1;
					Dust dust17;
					dust17.noGravity = num68 != 0;
					float x54 = dust17.velocity.X;
					float y53 = dust17.velocity.Y;
					if (num68 == 0)
					{
					}
					dust17.velocity.X = x52;
					dust17.velocity.Y = y51;
					int num69 = 4;
					int num70;
					if (num70 == 0)
					{
						float num71 = dust17.scale;
						dust17.scale = num71;
					}
					float x55 = this.position.X;
					float y54 = this.position.Y;
					Lighting.AddLight(1073741824, num69, num67, num67, num67);
				}
				bool flag20 = this.onFire2;
				if (flag20)
				{
					if (!flag20)
					{
					}
					float x56 = this.position.X;
					float y55 = this.position.Y;
					int width18 = this.width;
					bool wet16 = this.wet;
					float x57 = this.velocity.X;
					float y56 = this.velocity.Y;
					if (!flag20)
					{
					}
					int num72 = 1;
					Dust dust18;
					dust18.noGravity = num72 != 0;
					float x58 = dust18.velocity.X;
					float y57 = dust18.velocity.Y;
					if (num72 == 0)
					{
					}
					dust18.velocity.X = x56;
					dust18.velocity.Y = y55;
					int num73 = 4;
					int num74;
					if (num74 == 0)
					{
						float num75 = dust18.scale;
						dust18.scale = num75;
					}
					float x59 = this.position.X;
					float y58 = this.position.Y;
					Lighting.AddLight(1073741824, num73, num67, num67, num67);
				}
				bool flag21 = this.shimmering;
				float num76 = this.shimmerTransparency;
				float num78;
				if (flag21)
				{
					this.shimmerTransparency = num76;
					float num77 = this.shimmerTransparency;
					this.GetShimmered();
					num78 = this.shimmerTransparency;
					int num79 = 16256;
					this.shimmerTransparency = (float)num79;
					return;
				}
				if (this.justHit)
				{
					this.shimmerTransparency = num78;
				}
				bool[] array = this.buffImmune;
				this.shimmerTransparency = num78;
				float x60 = this.position.X;
				float y59 = this.position.Y;
				float x61 = this.netOffset.X;
				float y60 = this.netOffset.Y;
				if (array == null)
				{
				}
				this.position.X = num78;
			}
		}

		// Token: 0x06002262 RID: 8802 RVA: 0x00112448 File Offset: 0x00110648
		private void GetShimmered()
		{
			bool spawnedFromStatue = this.SpawnedFromStatue;
			long num;
			int num2;
			if (spawnedFromStatue)
			{
				if (!spawnedFromStatue)
				{
				}
				Vector2 center = base.Center;
				num = 0L;
				Vector2 center2 = base.Center;
				if (!spawnedFromStatue)
				{
				}
				num2 = 32640;
				return;
			}
			if (num2 == 0)
			{
			}
			if (num2 != 0)
			{
				this.Transform((int)num);
				if (!spawnedFromStatue)
				{
				}
				Vector2 center3 = base.Center;
				Vector2 center4 = base.Center;
				if (!spawnedFromStatue)
				{
				}
				return;
			}
			int num3;
			if (num3 == 0)
			{
			}
			if (num3 == 0)
			{
			}
			if (32640 == 0)
			{
			}
			if (16256 == 0)
			{
			}
			int myPlayer = Main.myPlayer;
		}

		// Token: 0x06002263 RID: 8803 RVA: 0x0011252C File Offset: 0x0011072C
		private void UpdateNPC_BuffApplyDOTs()
		{
			if (this.dontTakeDamage)
			{
				return;
			}
			bool flag = this.poisoned;
			int num = this.lifeRegenExpectedLossPerSecond;
			if (flag)
			{
				int num2 = this.lifeRegen;
				long num3 = 0L;
				this.lifeRegen = (int)num3;
			}
			bool flag2 = this.onFire;
			if (flag2)
			{
				int num4 = this.lifeRegen;
				long num5 = 0L;
				this.lifeRegen = (int)num5;
			}
			bool flag3 = this.onFire3;
			if (flag3)
			{
				int num6 = this.lifeRegen;
				long num7 = 0L;
				this.lifeRegen = (int)num7;
			}
			bool flag4 = this.onFrostBurn;
			if (flag4)
			{
				int num8 = this.lifeRegen;
				long num9 = 0L;
				this.lifeRegen = (int)num9;
			}
			bool flag5 = this.onFrostBurn2;
			if (flag5)
			{
				int num10 = this.lifeRegen;
				long num11 = 0L;
				this.lifeRegen = (int)num11;
			}
			if (this.onFire2)
			{
				int num12 = this.lifeRegen;
				long num13 = 0L;
				this.lifeRegen = (int)num13;
			}
			if (this.venom)
			{
				int num14 = this.lifeRegen;
				long num15 = 0L;
				this.lifeRegen = (int)num15;
			}
			bool flag6 = this.shadowFlame;
			if (flag6)
			{
				int num16 = this.lifeRegen;
				long num17 = 0L;
				this.lifeRegen = (int)num17;
			}
			int num20;
			if (this.oiled && (flag2 || flag3 || flag4 || flag5 || flag6))
			{
				int num18 = this.lifeRegen;
				long num19 = 0L;
				num20 = 10;
				this.lifeRegen = (int)num19;
			}
			if (this.javelined)
			{
				int num21 = this.lifeRegen;
				if (num21 == 0)
				{
				}
				if (num21 == 0)
				{
				}
				while (num20 == 0)
				{
				}
				int whoAmI = this.whoAmI;
				return;
			}
			if (this.tentacleSpiked)
			{
				int num22 = this.lifeRegen;
				if (num22 == 0)
				{
				}
				if (num22 == 0)
				{
				}
				while (num20 == 0)
				{
				}
				int whoAmI2 = this.whoAmI;
				return;
			}
			if (this.bloodButchered)
			{
				if (this.lifeRegen == 0)
				{
				}
				if (num20 != 0)
				{
					if (num20 == 0)
					{
					}
					if (num20 == 0)
					{
					}
					int whoAmI3 = this.whoAmI;
				}
				int num23 = this.lifeRegen;
				this.lifeRegen = num23;
			}
			if (this.daybreak)
			{
				if (this.lifeRegen == 0)
				{
				}
				if (num20 == 0)
				{
				}
				while (!flag4)
				{
				}
				if (!flag4)
				{
				}
				int whoAmI4 = this.whoAmI;
				return;
			}
			if (this.celled)
			{
				int num24 = this.lifeRegen;
				if (num24 == 0)
				{
				}
				if (num24 == 0)
				{
				}
				while (num20 == 0)
				{
				}
				int whoAmI5 = this.whoAmI;
				return;
			}
			if (!this.dryadBane)
			{
				if (this.soulDrain)
				{
					int num25 = this.realLife;
					int num26 = this.lifeRegen;
					long num27 = 0L;
					this.lifeRegen = (int)num27;
				}
				int num28 = this.lifeRegen;
				int num29 = this.lifeRegenCount;
				this.lifeRegenCount = num28;
				if (!this.immortal)
				{
					int num30 = this.life;
					int num31 = this.lifeMax;
					this.life = num31;
				}
				this.lifeRegenCount = num28;
				this.lifeRegenCount = num28;
				int num32 = this.realLife;
				int whoAmI6 = this.whoAmI;
				if (num32 != 0 || num32 == 0)
				{
				}
				float x = this.position.X;
				float y = this.position.Y;
				int width = this.width;
				bool wet = this.wet;
				if (num32 == 0)
				{
				}
				if (num32 == 0)
				{
					if (num32 == 0)
					{
					}
					bool logicHost = Main.LogicHost;
					bool netHost = Main.NetHost;
				}
				int num33 = this.lifeRegenCount;
				return;
			}
			int num34 = this.lifeRegen;
			if (num34 == 0)
			{
			}
			if (num34 != 0)
			{
				return;
			}
		}

		// Token: 0x06002264 RID: 8804 RVA: 0x001129B0 File Offset: 0x00110BB0
		private void UpdateNPC_BuffClearExpiredBuffs()
		{
			int num = 1;
			if (num == 0)
			{
			}
			bool logicHost = Main.LogicHost;
			long num2 = 0L;
			if (num == 0)
			{
			}
			int[] array = this.buffType;
			int[] array2 = this.buffTime;
			this.DelBuff((int)num2);
			if (array2 == null)
			{
			}
			bool netHost = Main.NetHost;
			int whoAmI = this.whoAmI;
			if (array2 == null)
			{
			}
		}

		// Token: 0x06002265 RID: 8805 RVA: 0x00112A08 File Offset: 0x00110C08
		private void UpdateNPC_BloodMoonTransformations()
		{
			if (!true)
			{
			}
			bool logicHost = Main.LogicHost;
			if (!true)
			{
			}
			if (true)
			{
				float num = this.value;
				if (!true)
				{
				}
			}
		}

		// Token: 0x06002266 RID: 8806 RVA: 0x00112A30 File Offset: 0x00110C30
		public void AttemptToConvertNPCToEvil(bool crimson)
		{
			int num = this.type;
		}

		// Token: 0x06002267 RID: 8807 RVA: 0x00112A60 File Offset: 0x00110C60
		public void UpdateNPC_BuffSetFlags(bool lowerBuffTime = true)
		{
			int num = 1;
			int num2 = 1;
			if (num == 0)
			{
			}
			int[] array = this.buffType;
			int[] array2 = this.buffTime;
			this.onFrostBurn = num2 != 0;
		}

		// Token: 0x06002268 RID: 8808 RVA: 0x00112B78 File Offset: 0x00110D78
		private void UpdateNPC_BuffFlagsReset()
		{
		}

		// Token: 0x06002269 RID: 8809 RVA: 0x00112B88 File Offset: 0x00110D88
		private void UpdateNPC_TeleportVisuals()
		{
			float num = this.teleportTime;
			int num6;
			int num7;
			if (this.teleportStyle != 0)
			{
				this.teleportTime = num;
				float num2 = this.teleportTime;
				int num3 = 17096;
				if (num3 == 0)
				{
				}
				float x = this.position.X;
				float y = this.position.Y;
				int width = this.width;
				bool wet = this.wet;
				if (num3 == 0)
				{
				}
				int num4 = this.lastPortalColorIndex;
				int num5;
				if (num5 == 0)
				{
				}
				Color portalColor = PortalHelper.GetPortalColor(num4);
				num6 = 39322;
				num7 = 1;
				return;
			}
			if (num7 == 0)
			{
			}
			float num8 = this.teleportTime;
			int num9 = 17096;
			Rectangle rect = this.getRect();
			Rectangle rect2 = this.getRect();
			Rectangle rect3 = this.getRect();
			Rectangle rect4 = this.getRect();
			if (num9 == 0)
			{
			}
			if (num6 == 0)
			{
			}
			float num10 = this.teleportTime;
			if (!true)
			{
			}
		}

		// Token: 0x0600226A RID: 8810 RVA: 0x00112CD8 File Offset: 0x00110ED8
		private void UpdateNPC_CritterSounds()
		{
			if (!true)
			{
			}
			bool logicClient = Main.LogicClient;
			int num = this.type;
			if (num == 0)
			{
			}
			if (num == 0)
			{
				if (num == 0)
				{
				}
				int num2;
				if (num2 == 0)
				{
					float x = this.position.X;
					float y = this.position.Y;
				}
			}
			int num3 = this.type;
			if (num3 == 0)
			{
			}
			if (num3 != 0)
			{
				if (num3 == 0)
				{
				}
				int num4;
				if (num4 == 0)
				{
					float x2 = this.position.X;
					float y2 = this.position.Y;
				}
			}
			int num5 = this.type;
		}

		// Token: 0x0600226B RID: 8811 RVA: 0x00112FEC File Offset: 0x001111EC
		private void UpdateNPC_CastLights()
		{
			int num = this.type;
			float x = this.position.X;
			float y = this.position.Y;
			float x2 = this.netOffset.X;
			float y2 = this.netOffset.Y;
			if (num == 0)
			{
			}
			Vector2 center = base.Center;
			long num2 = 0L;
			Vector2 center2 = base.Center;
			if (num == 0)
			{
			}
			int num3 = 32640;
			Color color = Lighting.GetColor(1073741824, (int)num2);
			if (num3 == 0)
			{
			}
			float x3 = this.position.X;
			float y3 = this.position.Y;
			int width = this.width;
			bool wet = this.wet;
			if (num == 0)
			{
			}
			if (num3 == 0)
			{
			}
			float x4 = this.position.X;
			float y4 = this.position.Y;
			float x5 = this.netOffset.X;
			float y5 = this.netOffset.Y;
			if (this.type == 0)
			{
			}
			int num4 = this.townNpcVariationIndex;
			Vector2 center3 = base.Center;
			Vector2 center4 = base.Center;
			if (this.type == 0)
			{
			}
			int num5 = this.type;
			Vector2 center5 = base.Center;
			Vector2 center6 = base.Center;
			if (this.type == 0)
			{
			}
			Vector2 center7 = base.Center;
			Vector2 center8 = base.Center;
			float[] array = this.ai;
			Vector2 top = base.Top;
			if (array == null)
			{
			}
			int num6 = this.type;
			int width2 = this.width;
			float x6 = this.position.X;
			float y6 = this.position.Y;
			if (num6 == 0)
			{
			}
		}

		// Token: 0x0600226C RID: 8812 RVA: 0x001131B4 File Offset: 0x001113B4
		private void GetHurtByOtherNPCs(bool[] acceptableNPCIDs)
		{
			if (!this.dontTakeDamage && !this.dontTakeDamageFromHostiles && !this.immortal)
			{
				int[] array = this.immune;
				if (array == null)
				{
					Rectangle hitbox = base.Hitbox;
					if (array == null)
					{
					}
					if (array == null || array == null || array != null)
					{
						return;
					}
					if (array == null)
					{
					}
					return;
				}
			}
		}

		// Token: 0x0600226D RID: 8813 RVA: 0x00113208 File Offset: 0x00111408
		private void BeHurtByOtherNPC(int npcIndex, NPC thatNPC)
		{
			int num = this.type;
			int num2 = thatNPC.damage;
			if (num == 0)
			{
			}
			Vector2 center = thatNPC.Center;
			Vector2 center2 = base.Center;
			if (num == 0)
			{
			}
			if (num != 0)
			{
				int whoAmI = this.whoAmI;
				if (num == 0)
				{
				}
			}
			int[] array = this.immune;
			int num3 = 1;
			this.netUpdate = num3 != 0;
			bool flag = this.dryadWard;
			double num7;
			int[] array2;
			if (flag)
			{
				long num4 = 0L;
				long num5 = 0L;
				long num6 = 0L;
				int num8;
				double num9;
				num7 = thatNPC.StrikeNPCNoInteraction(num8, (float)num9, num2, num4 != 0L, num5 != 0L, num6 != 0L);
				if (!flag)
				{
				}
				if (flag)
				{
					if (!flag)
					{
					}
				}
				array2 = thatNPC.immune;
				int num10 = 1;
				thatNPC.netUpdate = num10 != 0;
			}
			if (array2 == null)
			{
			}
			if (array2 != null)
			{
				int num11 = this.damage;
				long num12 = 0L;
				long num13 = 0L;
				long num14 = 0L;
				double num15 = thatNPC.StrikeNPCNoInteraction(num11, (float)num7, num2, num12 != 0L, num13 != 0L, num14 != 0L);
				if (array2 == null)
				{
				}
				if (array2 != null)
				{
					if (array2 == null)
					{
					}
				}
				int[] array3 = thatNPC.immune;
				int num16 = 1;
				thatNPC.netUpdate = num16 != 0;
			}
		}

		// Token: 0x0600226E RID: 8814 RVA: 0x001132FC File Offset: 0x001114FC
		private void CheckLifeRegen()
		{
			int num = this.life;
			int num2 = this.lifeMax;
			int num3 = this.friendlyRegen;
			bool flag = this.dryadWard;
			this.friendlyRegen = num2;
			if (flag)
			{
				this.friendlyRegen = num2;
			}
			int num4 = 1;
			this.life = num;
			this.netUpdate = num4 != 0;
		}

		// Token: 0x0600226F RID: 8815 RVA: 0x00113348 File Offset: 0x00111548
		public void GetImmuneTime(int fromWho, int time)
		{
			int[] array = this.immune;
		}

		// Token: 0x06002270 RID: 8816 RVA: 0x00113370 File Offset: 0x00111570
		private void UpdateCollision()
		{
			this.Collision_WalkDownSlopes();
			bool flag = this.Collision_LavaCollision();
			if (!this.wet)
			{
			}
			byte wetCount = this.wetCount;
			if (wetCount != 0)
			{
				this.wetCount = wetCount;
			}
			bool flag2 = this.Collision_DecideFallThroughPlatforms();
			Vector2 velocity = this.velocity;
			this.oldVelocity = velocity;
			this.FishTransformationDuringRain();
			float x = this.velocity.X;
			float y = this.velocity.Y;
			if (!this.wet)
			{
				this.Collision_MoveWhileDry();
				return;
			}
			if (this.shimmerWet)
			{
				float num = this.shimmerMovementSpeed;
				return;
			}
			if (this.honeyWet)
			{
				float num2 = this.honeyMovementSpeed;
				return;
			}
			if (this.lavaWet)
			{
				float num3 = this.lavaMovementSpeed;
				return;
			}
			float num4 = this.waterMovementSpeed;
			int num5 = this.aiStyle;
			this.Collision_MoveSnailOnSlopes();
		}

		// Token: 0x06002271 RID: 8817 RVA: 0x00113454 File Offset: 0x00111654
		private void Collision_MoveWhileDry()
		{
			if (!true)
			{
			}
			if (true)
			{
				this.velocity.Y = (float)55050;
			}
			float x = this.oldVelocity.X;
			float x2 = this.velocity.X;
			this.collideX = true;
			float y = this.oldVelocity.Y;
			float y2 = this.velocity.Y;
			this.collideY = true;
			Vector2 position = this.position;
			int direction = this.direction;
			float y3 = this.position.Y;
			this.oldPosition = position;
			this.oldDirection = direction;
			this.position.X = y;
		}

		// Token: 0x06002272 RID: 8818 RVA: 0x001134F4 File Offset: 0x001116F4
		private void ApplyTileCollision(bool fall, Vector2 cPosition, int cWidth, int cHeight)
		{
			int num = this.type;
			this.Collision_MoveBlazingWheel();
		}

		// Token: 0x06002273 RID: 8819 RVA: 0x00113540 File Offset: 0x00111740
		private void Collision_MoveSlopesAndStairFall(bool fall)
		{
			int num = 1;
			this.stairFall = num != 0;
			int num2 = this.aiStyle;
			Vector2 center = base.Center;
			int num3 = 32640;
			float y = this.position.Y;
			if (num3 == 0)
			{
			}
			if (num3 == 0)
			{
			}
			bool flag = this.townNPC;
			if (flag)
			{
				if (!flag)
				{
				}
				return;
			}
			if (!flag)
			{
			}
			if (num3 != 0)
			{
				if (num3 == 0)
				{
				}
				int height = this.height;
				float y2 = this.position.Y;
				int num4 = this.homeTileY;
			}
			int height2 = this.height;
			float y3 = this.position.Y;
			int num5 = this.homeTileY;
			int num6 = 1;
			this.stairFall = num6 != 0;
		}

		// Token: 0x06002274 RID: 8820 RVA: 0x001136B8 File Offset: 0x001118B8
		private void Collision_MoveSnailOnSlopes()
		{
			float x = this.position.X;
			float y = this.position.Y;
			float x2 = this.velocity.X;
			float y2 = this.velocity.Y;
			int width = this.width;
			bool wet = this.wet;
			if (!true)
			{
			}
			float x3 = this.position.X;
			float y3 = this.position.Y;
			float[] array = this.ai;
			float y4 = this.velocity.Y;
			int direction = this.direction;
			if (direction != 0)
			{
				float num = this.rotation;
				int num2 = this.spriteDirection;
				return;
			}
			this.directionY = 1;
		}

		// Token: 0x06002275 RID: 8821 RVA: 0x00113774 File Offset: 0x00111974
		private void Collision_MoveNormal(bool fall, Vector2 cPosition, int cWidth, int cHeight)
		{
			float x = this.velocity.X;
			float y = this.velocity.Y;
			if (!true)
			{
			}
		}

		// Token: 0x06002276 RID: 8822 RVA: 0x0011379C File Offset: 0x0011199C
		private void Collision_MoveSandshark(bool fall, Vector2 cPosition, int cWidth, int cHeight)
		{
			if (!true)
			{
			}
			if (!true)
			{
				if (!true)
				{
				}
				float x = this.velocity.X;
				float y = this.velocity.Y;
				if (!true)
				{
				}
			}
		}

		// Token: 0x06002277 RID: 8823 RVA: 0x001137D0 File Offset: 0x001119D0
		private void Collision_MoveSolarSroller(bool fall, Vector2 cPosition, int cWidth, int cHeight)
		{
			float x = this.velocity.X;
			float y = this.velocity.Y;
			if (!true)
			{
			}
			float[] array = this.ai;
			float x2 = this.oldVelocity.X;
			float y2 = this.oldVelocity.Y;
			float[] array2 = this.ai;
			float x3 = this.velocity.X;
			float x4 = this.oldVelocity.X;
			int direction = this.direction;
			this.velocity.X = x4;
			this.direction = direction;
			float y3 = this.velocity.Y;
			float y4 = this.oldVelocity.Y;
		}

		// Token: 0x06002278 RID: 8824 RVA: 0x00113878 File Offset: 0x00111A78
		private void Collision_MoveStardustCell(bool fall, Vector2 cPosition, int cWidth, int cHeight)
		{
			float x = this.velocity.X;
			float y = this.velocity.Y;
			if (!true)
			{
			}
			float x2 = this.oldVelocity.X;
			float y2 = this.oldVelocity.Y;
			if (!true)
			{
			}
			float x3 = this.velocity.X;
			float x4 = this.oldVelocity.X;
			float y3 = this.velocity.Y;
			float y4 = this.oldVelocity.Y;
		}

		// Token: 0x06002279 RID: 8825 RVA: 0x001138F4 File Offset: 0x00111AF4
		private void Collision_MoveBlazingWheel()
		{
			int width = this.width;
			bool wet = this.wet;
			float x = this.position.X;
			float y = this.position.Y;
			float x2 = this.velocity.X;
			float y2 = this.velocity.Y;
			if (width == 0)
			{
			}
			this.velocity.X = x;
			this.velocity.Y = y;
		}

		// Token: 0x0600227A RID: 8826 RVA: 0x0011395C File Offset: 0x00111B5C
		private void Collision_MoveWhileWet(Vector2 oldDryVelocity, float Slowdown = 0.5f)
		{
			if (!true)
			{
			}
			if (true)
			{
				this.velocity.Y = (float)55050;
				return;
			}
			float y = this.velocity.Y;
			float x = this.velocity.X;
			if (55050 == 0)
			{
			}
			float x2 = this.velocity.X;
		}

		// Token: 0x0600227B RID: 8827 RVA: 0x00113A0C File Offset: 0x00111C0C
		public void GetTileCollisionParameters([Out] Vector2 cPosition, [Out] int cWidth, [Out] int cHeight)
		{
			Vector2 position = this.position;
			cPosition.X = position;
			int width = this.width;
			cWidth.m_value = width;
			int height = this.height;
			cHeight.m_value = height;
			int num = this.type;
			float[] array = this.ai;
			cHeight.m_value = height;
			cWidth.m_value = array;
			int num2 = this.type;
			int num3 = 32;
			cWidth.m_value = num3;
			int num4 = this.type;
			int num5 = 90;
			cHeight.m_value = num5;
			int num6 = this.type;
			int num7 = 40;
			cHeight.m_value = num7;
			int num8 = this.type;
			int num9 = 40;
			cHeight.m_value = num9;
			int num10 = this.type;
			int num11 = 40;
			cHeight.m_value = num11;
			int num12 = this.type;
			int num13 = 40;
			cHeight.m_value = num13;
			int num14 = this.type;
			if (num14 == 0)
			{
			}
			if (num14 != 0)
			{
				if (num14 == 0)
				{
				}
				if (num14 == 0)
				{
				}
				int whoAmI = this.whoAmI;
			}
		}

		// Token: 0x0600227C RID: 8828 RVA: 0x00113B5C File Offset: 0x00111D5C
		private void FishTransformationDuringRain()
		{
			if (!true)
			{
			}
			bool logicHost = Main.LogicHost;
			int num = this.type;
			if (this.wet)
			{
				int direction = this.direction;
				Vector2 velocity = this.velocity;
				return;
			}
		}

		// Token: 0x0600227D RID: 8829 RVA: 0x00113C5C File Offset: 0x00111E5C
		private bool Collision_DecideFallThroughPlatforms()
		{
			/*
An exception occurred when decompiling this method (0600227D)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean Terraria.NPC::Collision_DecideFallThroughPlatforms()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0175:
	stloc:int32(var_38_17B, ldfld:int32(Entity::height, ldloc:NPC[exp:Entity](this)))
	stloc:float32(var_39_188, ldfld:float32(Vector2::Y, ldfld:Vector2[exp:valuetype Microsoft.Xna.Framework.Vector2&](Entity::position, ldloc:NPC[exp:Entity](this))))
	stloc:int32(var_41_197, ldfld:int32(NPC::homeTileY, ldloc:NPC(this)))
	stloc:int32(var_42_19F, ldfld:int32(NPC::type, ldloc:NPC(this)))
	stloc:int32(var_43_1A7, ldfld:int32(NPC::target, ldloc:NPC(this)))
	stloc:float32(var_44_1B9, ldfld:float32(Vector2::Y, ldfld:Vector2[exp:valuetype Microsoft.Xna.Framework.Vector2&](Entity::position, callgetter:Player[exp:Entity](NPC::get_TargetPlayer, ldloc:NPC(this)))))
	stloc:Vector2(var_45_1C1, callgetter:Vector2(Entity::get_Bottom, ldloc:NPC[exp:Entity](this)))
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

		// Token: 0x0600227E RID: 8830 RVA: 0x00113E2C File Offset: 0x0011202C
		private bool Collision_WaterCollision(bool lava)
		{
			/*
An exception occurred when decompiling this method (0600227E)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean Terraria.NPC::Collision_WaterCollision(System.Boolean)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_15:
	brtrue(IL_0000, ldfld:bool(NPC::noGravity, ldloc:NPC(this)))
}

   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1852
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

		// Token: 0x0600227F RID: 8831 RVA: 0x00114394 File Offset: 0x00112594
		private bool Collision_LavaCollision()
		{
			/*
An exception occurred when decompiling this method (0600227F)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean Terraria.NPC::Collision_LavaCollision()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_00F4:
	stloc:int32(var_25_F6, ldc.i4:int32(24))
	stloc:int32(var_26_FD, ldc.i4:int32(180))
	stloc:int64(var_27_100, ldc.i4:int64(0))
	call:void(NPC::AddBuff, ldloc:NPC(this), ldloc:int32(var_25_F6), ldloc:int32(var_26_FD), ldloc:int64[exp:bool](var_27_100))
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

		// Token: 0x06002280 RID: 8832 RVA: 0x001144B0 File Offset: 0x001126B0
		private void Collision_WalkDownSlopes()
		{
			float x = this.position.X;
			float y = this.position.Y;
			float x2 = this.velocity.X;
			float y2 = this.velocity.Y;
			int width = this.width;
			bool wet = this.wet;
			if (!true)
			{
			}
		}

		// Token: 0x06002281 RID: 8833 RVA: 0x00114500 File Offset: 0x00112700
		public static void setFireFlyChance()
		{
			if (!true)
			{
			}
			long ticks = DateTime.Now.Ticks;
			if (WorldGen.genRand.Next(9) == 0)
			{
				return;
			}
			if (WorldGen.genRand.Next(3) != 0)
			{
				return;
			}
			if (16959 == 0)
			{
			}
			int num;
			if (num != 0)
			{
				if (WorldGen.genRand.Next(5) == 0)
				{
					return;
				}
			}
			else if (WorldGen.genRand.Next(5) == 0)
			{
			}
			int num2 = Math.Max(1, 5);
			int num3 = Math.Max(1, 5);
		}

		// Token: 0x06002282 RID: 8834 RVA: 0x0011457C File Offset: 0x0011277C
		public Color GetBestiaryEntryColor()
		{
			if (!true)
			{
			}
			return 1;
		}

		// Token: 0x06002283 RID: 8835 RVA: 0x00114590 File Offset: 0x00112790
		public Color GetAlpha(Color newColor)
		{
			/*
An exception occurred when decompiling this method (06002283)

ICSharpCode.Decompiler.DecompilerException: Error decompiling Microsoft.Xna.Framework.Graphics.Color Terraria.NPC::GetAlpha(Microsoft.Xna.Framework.Graphics.Color)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_011D:
	stloc:float32(var_47_12E, ldfld:float32(NPC::shimmerTransparency, ldloc:NPC(this)))
	stloc:float32(var_49_136, ldfld:float32(NPC::shimmerTransparency, ldloc:NPC(this)))
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

		// Token: 0x06002284 RID: 8836 RVA: 0x001146D4 File Offset: 0x001128D4
		public Color GetShimmerColor(Color newColor)
		{
			float num = this.shimmerTransparency;
			bool flag = this.CanApplyHunterPotionEffects();
			float num2 = this.shimmerTransparency;
			Color color;
			return color;
		}

		// Token: 0x06002285 RID: 8837 RVA: 0x001146F8 File Offset: 0x001128F8
		public Color GetColor(Color newColor)
		{
			/*
An exception occurred when decompiling this method (06002285)

ICSharpCode.Decompiler.DecompilerException: Error decompiling Microsoft.Xna.Framework.Graphics.Color Terraria.NPC::GetColor(Microsoft.Xna.Framework.Graphics.Color)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_000B:
	stloc:uint8(var_0_16, ldfld:uint8(Color::G, ldfld:Color[exp:valuetype Microsoft.Xna.Framework.Graphics.Color&](NPC::color, ldloc:NPC(this))))
	stloc:uint8(var_1_22, ldfld:uint8(Color::B, ldfld:Color[exp:valuetype Microsoft.Xna.Framework.Graphics.Color&](NPC::color, ldloc:NPC(this))))
	stloc:uint8(var_2_2E, ldfld:uint8(Color::R, ldfld:Color[exp:valuetype Microsoft.Xna.Framework.Graphics.Color&](NPC::color, ldloc:NPC(this))))
	stloc:Color(var_3_35, ldfld:Color(NPC::color, ldloc:NPC(this)))
	stloc:float32(var_4_3C, ldfld:float32(NPC::shimmerTransparency, ldloc:NPC(this)))
	stloc:float32(var_6_44, ldfld:float32(NPC::shimmerTransparency, ldloc:NPC(this)))
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

		// Token: 0x06002286 RID: 8838 RVA: 0x0011474C File Offset: 0x0011294C
		public bool ShouldBestiaryGirlBeLycantrope()
		{
			if (!true)
			{
			}
			if (true)
			{
				if (!true)
				{
				}
			}
			return true;
		}

		// Token: 0x06002287 RID: 8839 RVA: 0x00114768 File Offset: 0x00112968
		public string GetChat()
		{
			int num = 1;
			if (num == 0)
			{
			}
			if (num == 0)
			{
			}
			Recipe.FindRecipes(false);
			if (num == 0)
			{
			}
			object obj = Lang.CreateDialogSubstitutionObject(this);
			if (num == 0)
			{
			}
			if (num != 0)
			{
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
				}
				if (num == 0)
				{
				}
				if (num == 0)
				{
				}
				if (!true)
				{
				}
				if (!true)
				{
				}
				int num2 = 1;
				if (num2 == 0)
				{
				}
				if (num2 == 0)
				{
				}
				int num3 = 1;
				if (num3 == 0)
				{
				}
				if (num3 == 0)
				{
				}
				if (!true)
				{
				}
				if (!true)
				{
				}
				if (!true)
				{
				}
				if (!true)
				{
				}
				if (!true)
				{
				}
			}
			int num4 = this.type;
			int num5;
			int num23;
			if (num5 != 0)
			{
				if ("TaxCollector" == null)
				{
				}
				if ("TaxCollector" == null)
				{
				}
				if ("Merchant" == null)
				{
				}
				if ("Merchant" == null)
				{
					if ("Merchant" == null)
					{
					}
					int num6;
					if (num6 == 0)
					{
						goto IL_0CA9;
					}
				}
				if ("Merchant" != null)
				{
					int num7;
					if (num7 != 0)
					{
						goto IL_0EF5;
					}
					if ("Merchant" == null)
					{
					}
					if ("Merchant" == null)
					{
					}
					if ("Steampunker" == null)
					{
					}
					if ("Steampunker" != null)
					{
						if ("Steampunker" == null)
						{
						}
						int num8;
						if (num8 == 0)
						{
							goto IL_0BAF;
						}
					}
					if ("Steampunker" == null)
					{
					}
					int num9;
					if (num9 == 0)
					{
						goto IL_0C97;
					}
					if ("Steampunker" == null)
					{
					}
					int num10;
					if (num10 != 0)
					{
						return Lang.PrincessChat(this);
					}
					int num11;
					if (num11 == 0)
					{
					}
					if ("." == null)
					{
					}
					int num12;
					if (num12 == 0)
					{
						int num13;
						if (num13 == 0)
						{
						}
						if (num11 == 0)
						{
						}
						goto IL_0E4F;
					}
					goto IL_10B8;
				}
				else
				{
					int num14;
					if (num14 == 0)
					{
						goto IL_113F;
					}
					int num15;
					if (num15 != 0)
					{
						goto IL_1117;
					}
					int num16;
					if (num16 == 0)
					{
						goto IL_0E4F;
					}
					int num17;
					if (num17 == 0)
					{
						goto IL_112D;
					}
					int num18;
					if (num18 == 0)
					{
						goto IL_11F6;
					}
					int num19;
					if (num19 == 0)
					{
						goto IL_11D5;
					}
					int num20;
					if (num20 == 0)
					{
						goto IL_123B;
					}
					int num21;
					if (num21 != 0)
					{
						goto IL_0F52;
					}
					int myPlayer = Main.myPlayer;
					bool anglerQuestFinished = Main.anglerQuestFinished;
					int num22;
					if (num22 == 0)
					{
						goto IL_11CC;
					}
					if ("AnglerChatter." == null)
					{
					}
					if ("AnglerChatter." == null)
					{
					}
					if ("AnglerChatter." == null)
					{
					}
					if (num23 == 0)
					{
						goto IL_106F;
					}
					if ("GolferQuestsChatterMaster" == null)
					{
					}
					if ("GolferQuestsChatterMaster" == null)
					{
					}
					if ("GolferQuestsChatterMaster" == null)
					{
					}
					if ("GolferQuestsChatterMaster" == null)
					{
					}
					int num24;
					if (num24 == 0)
					{
						goto IL_10A6;
					}
					int myPlayer2 = Main.myPlayer;
				}
				IL_0BAF:
				bool lanternsUp = LanternNight.LanternsUp;
				bool lanternsUp2 = LanternNight.LanternsUp;
				return "AnglerSpecialText.BloodMoonFishing";
				IL_0E4F:
				int num25 = 6;
				int num26;
				if (num26 == 0)
				{
				}
				if (num26 == 0)
				{
				}
				if (num26 == 0)
				{
				}
				if (num26 == 0)
				{
				}
				if (num26 == 0)
				{
				}
				IL_0EF5:
				return Language.GetTextValueWith("DryadSpecialText.AfterDD2Tier1", num25);
			}
			if ("Mechanic" == null)
			{
			}
			if ("Mechanic" == null)
			{
				goto IL_0CD0;
			}
			if ("Mechanic" == null)
			{
			}
			int num27;
			if (num27 != 0)
			{
				goto IL_1003;
			}
			if ("Mechanic" == null)
			{
			}
			if ("GoblinTinkerer" == null)
			{
			}
			int num28;
			if (num28 == 0)
			{
				goto IL_0FA4;
			}
			if ("GoblinTinkerer" == null)
			{
			}
			int num29 = 5;
			int num30;
			if (num30 == 0)
			{
				goto IL_1039;
			}
			if ("GoblinTinkerer" == null)
			{
			}
			LanguageSearchFilter languageSearchFilter = Lang.CreateDialogFilter("GoblinTinkererChatter.", num29);
			string <Value>k__BackingField = Language.FindAll(languageSearchFilter).<Value>k__BackingField;
			if (<Value>k__BackingField == null)
			{
			}
			int num54;
			if (<Value>k__BackingField != null)
			{
				int num31;
				if (num31 != 0)
				{
					if ("Wizard" == null)
					{
					}
					if ("Wizard" != null)
					{
						if ("Wizard" == null)
						{
						}
						int num32;
						if (num32 == 0)
						{
							goto IL_10BE;
						}
					}
					if ("Wizard" == null)
					{
					}
					int myPlayer3 = Main.myPlayer;
					if ("Wizard" == null)
					{
					}
					int num33;
					if (num33 != 0)
					{
						if ("Wizard" == null)
						{
						}
						int myPlayer4 = Main.myPlayer;
						if ("Wizard" == null)
						{
						}
						int num34;
						if (num34 != 0)
						{
							if ("Wizard" == null)
							{
							}
							int myPlayer5 = Main.myPlayer;
							if ("Wizard" == null)
							{
							}
							int num35;
							if (num35 == 0)
							{
								goto IL_12B6;
							}
							if ("Wizard" == null)
							{
							}
							int myPlayer6 = Main.myPlayer;
							if ("Wizard" == null)
							{
							}
							int num36;
							if (num36 == 0)
							{
								goto IL_1345;
							}
							if ("Wizard" == null)
							{
							}
							int myPlayer7 = Main.myPlayer;
							if ("Wizard" == null)
							{
							}
							int num37;
							if (num37 == 0)
							{
								goto IL_13BD;
							}
							if ("Wizard" == null)
							{
							}
							int myPlayer8 = Main.myPlayer;
							if ("Wizard" == null)
							{
							}
							int num38;
							if (num38 == 0)
							{
								goto IL_13D8;
							}
							if ("Wizard" == null)
							{
								goto IL_130B;
							}
							if ("PartyGirl" == null)
							{
							}
							if (Main.LocalPlayer.golferScoreAccumulated == 0)
							{
							}
							if (Main.LocalPlayer.golferScoreAccumulated == 0)
							{
							}
							int golferScoreAccumulated = Main.LocalPlayer.golferScoreAccumulated;
							if ("GolferQuestsChatterApprentice" == null)
							{
							}
							if ("GolferQuestsChatterApprentice" == null)
							{
							}
							if ("GolferQuestsChatterApprentice" == null)
							{
							}
							int num39;
							if (num39 != 0)
							{
								goto IL_0C97;
							}
							if ("GolferQuestsChatterApprentice" == null)
							{
							}
							if ("GolferQuestsChatterBeginner" == null)
							{
							}
							while (num31 != 0)
							{
							}
							int num40;
							int numberOfDeathsPVE;
							if (num40 == 0)
							{
								if ("GolferQuestsChatterApprentice" == null)
								{
								}
								numberOfDeathsPVE = Main.LocalPlayer.numberOfDeathsPVE;
							}
							if (numberOfDeathsPVE == 0)
							{
							}
							int num41;
							if (num41 == 0)
							{
								if (numberOfDeathsPVE == 0)
								{
								}
								if (numberOfDeathsPVE == 0)
								{
									goto IL_10EB;
								}
							}
							if (numberOfDeathsPVE == 0)
							{
							}
							int num42;
							if (num42 == 0)
							{
								goto IL_108E;
							}
							if (numberOfDeathsPVE == 0)
							{
							}
							int num43;
							if (num43 == 0)
							{
								goto IL_1139;
							}
							if (numberOfDeathsPVE == 0)
							{
							}
							int num44;
							if (num44 != 0)
							{
								if (numberOfDeathsPVE == 0)
								{
								}
								int myPlayer9 = Main.myPlayer;
								int myPlayer10 = Main.myPlayer;
								int num45;
								if (num45 == 0)
								{
								}
								if (num45 == 0)
								{
								}
								int num46;
								if (num46 == 0)
								{
									goto IL_10DC;
								}
								if (num45 == 0)
								{
								}
								int myPlayer11 = Main.myPlayer;
								if (num45 == 0)
								{
								}
								int num47;
								if (num47 == 0)
								{
									goto IL_0FD7;
								}
								if (num45 == 0)
								{
								}
								int myPlayer12 = Main.myPlayer;
								if (num45 == 0)
								{
								}
								int num48;
								if (num48 == 0)
								{
									goto IL_107A;
								}
								if (num45 == 0)
								{
								}
								int num49;
								if (num49 == 0)
								{
									goto IL_1124;
								}
								if (num45 == 0)
								{
								}
								int num50;
								if (num50 != 0)
								{
									if (num45 == 0)
									{
									}
									int num51;
									if (num51 != 0)
									{
										if (num45 == 0)
										{
										}
										int num52 = 5;
										int num53;
										if (num53 != 0)
										{
											LanguageSearchFilter languageSearchFilter2 = Lang.CreateDialogFilter("StylistChatter.", num52);
											LocalizedText[] array = Language.FindAll(languageSearchFilter2);
											int num11 = 4;
											if (array.<Value>k__BackingField == null)
											{
											}
											if (num54 != 0)
											{
												string text;
												return text;
											}
											goto IL_14D3;
										}
									}
								}
							}
						}
					}
				}
				goto IL_11CC;
			}
			goto IL_1094;
			IL_0C97:
			IL_0CA9:
			int myPlayer13 = Main.myPlayer;
			int myPlayer14 = Main.myPlayer;
			IL_0CD0:
			int num55;
			if (num55 == 0)
			{
				goto IL_11ED;
			}
			int num56 = 6;
			int num57;
			if (num57 == 0)
			{
				goto IL_1271;
			}
			LanguageSearchFilter languageSearchFilter3 = Lang.CreateDialogFilter("MechanicChatter.", num56);
			string <Value>k__BackingField2 = Language.FindAll(languageSearchFilter3).<Value>k__BackingField;
			int num58;
			if (num58 != 0)
			{
				goto IL_1328;
			}
			if (num23 == 0)
			{
				goto IL_1074;
			}
			int num59;
			string text2;
			if (num23 == 0 || num59 != 0)
			{
				int num60;
				if (num60 == 0)
				{
					text2 = "GolferQuestsChatterJourneyman" + ".";
					if ("." == null)
					{
					}
					LanguageSearchFilter languageSearchFilter4 = Lang.CreateDialogFilter(text2);
					string text3;
					return text3;
				}
				goto IL_10DC;
			}
			IL_0F52:
			int numberOfDeathsPVE2 = Main.LocalPlayer.numberOfDeathsPVE;
			if ("Low" == null)
			{
			}
			int myPlayer15 = Main.myPlayer;
			int myPlayer16 = Main.myPlayer;
			int num61;
			if (num61 == 0)
			{
			}
			IL_0FA4:
			if (num61 == 0)
			{
			}
			if (num61 == 0)
			{
			}
			if (num61 == 0)
			{
			}
			IL_0FD7:
			int num62;
			while (num62 != 0)
			{
			}
			IL_1003:
			IL_1039:
			IL_106F:
			IL_1074:
			IL_107A:
			int num63 = 3;
			int num64;
			while (num64 != 0)
			{
			}
			IL_108E:
			IL_1094:
			if (text2 == null)
			{
				goto IL_12BF;
			}
			IL_10A6:
			IL_10B8:
			IL_10BE:
			return Language.GetTextValueWith("WizardSpecialText.AfterDD2Tier1", num63);
			IL_10DC:
			IL_10EB:
			if ("GuideSpecialText.Lantern1" == null)
			{
			}
			if ("GuideSpecialText.Lantern1" == null)
			{
			}
			IL_1117:
			if ("GuideSpecialText.Lantern1" == null)
			{
			}
			IL_1124:
			IL_112D:
			IL_1139:
			IL_113F:
			int num65;
			if (num65 == 0)
			{
			}
			int num66;
			if (num66 == 0)
			{
				if (num65 == 0)
				{
				}
				return "NurseSpecialText.DeathCount";
			}
			goto IL_13ED;
			IL_11CC:
			IL_11D5:
			IL_11ED:
			IL_11F6:
			IL_123B:
			IL_1271:
			int num67;
			if (num67 == 0)
			{
				goto IL_1524;
			}
			int num68;
			if (num68 == 0)
			{
				return;
			}
			int num69;
			if (num69 != 0)
			{
				goto IL_1534;
			}
			IL_12B6:
			IL_12BF:
			int num70;
			if (num70 == 0)
			{
				goto IL_13C6;
			}
			int num71;
			if (num71 != 0)
			{
				goto IL_13D2;
			}
			IL_130B:
			if (num70 != 0)
			{
			}
			IL_1328:
			int num72;
			while (num72 != 0)
			{
			}
			IL_1345:
			if (num54 == 0)
			{
				goto IL_14D3;
			}
			IL_13BD:
			IL_13C6:
			IL_13D2:
			IL_13D8:
			IL_13ED:
			int num73 = 77;
			long num74 = 0L;
			string text4 = Lang.dialog(num73, num74 != 0L);
			Player localPlayer = Main.LocalPlayer;
			int num75 = 5275;
			bool flag = localPlayer.HasItem(num75);
			return Language.GetTextValue("StardewTalk.PlayerHasColaButIsNotHoldingIt");
			IL_14D3:
			IL_1524:
			if ("GuideChatter.Chatter_1" == null)
			{
			}
			IL_1534:
			if ("GuideChatter.Chatter_1" == null)
			{
				return;
			}
		}

		// Token: 0x06002288 RID: 8840 RVA: 0x00115CDC File Offset: 0x00113EDC
		public object Clone()
		{
			return base.MemberwiseClone();
		}

		// Token: 0x06002289 RID: 8841 RVA: 0x00115CF0 File Offset: 0x00113EF0
		public bool HasLuckTextForWizard([Out] string specialEventText)
		{
			/*
An exception occurred when decompiling this method (06002289)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean Terraria.NPC::HasLuckTextForWizard(System.String)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0011:
	stloc:int32(var_5_19, callgetter:int32(Main::get_myPlayer))
	stloc:LanguageSearchFilter(var_7_25, call:LanguageSearchFilter(Lang::CreateDialogFilter, ldstr:string("WizardSpecialText.LuckIsGodly")))
	stloc:string(var_9_2F, call:string(LocalizedText::FormatWith, ldloc:LocalizedText(var_8), ldloc:object(var_0_09)))
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

		// Token: 0x0600228A RID: 8842 RVA: 0x00115D30 File Offset: 0x00113F30
		public bool HasSpecialEventText(string specialTextCategoryKey, [Out] string specialEventText)
		{
			if (!true)
			{
			}
			object obj = Lang.CreateDialogSubstitutionObject(this);
			bool zoneGraveyard = Main.LocalPlayer.ZoneGraveyard;
			int num;
			if (num == 0)
			{
				string text = specialTextCategoryKey + "SpecialText.Graveyard";
			}
			bool partyIsUp = BirthdayParty.PartyIsUp;
			int num2;
			if (num2 == 0)
			{
				string text2 = specialTextCategoryKey + "SpecialText.Party";
			}
			if ("SpecialText.Party" == null)
			{
			}
			if ("SpecialText.Party" != null)
			{
				if ("SpecialText.Party" == null)
				{
				}
				int num3 = 1;
				if (num3 == 0)
				{
				}
				if (num3 == 0)
				{
					if (num3 == 0)
					{
					}
					int num4;
					if (num4 == 0)
					{
						string text3 = specialTextCategoryKey + "SpecialText.Rain";
					}
				}
			}
			if ("SpecialText.Rain" == null)
			{
			}
			int num5 = 1;
			if (num5 == 0)
			{
			}
			if (num5 != 0)
			{
				if (num5 == 0)
				{
				}
				int num6;
				if (num6 == 0)
				{
					string text4 = specialTextCategoryKey + "SpecialText.Windy";
				}
			}
			if ("SpecialText.Windy" == null)
			{
			}
			int num7 = 1;
			if (num7 == 0)
			{
			}
			if (num7 == 0)
			{
				return;
			}
			if (num7 == 0)
			{
			}
			int num8;
			if (num8 == 0)
			{
				string text5 = specialTextCategoryKey + "SpecialText.Storm";
				return;
			}
		}

		// Token: 0x0600228B RID: 8843 RVA: 0x00115E18 File Offset: 0x00114018
		public bool GetSpecialEventTextIfNotEmpty(string specialTextKey, object substitutes, string specialEventText)
		{
			if (!true)
			{
			}
			LanguageSearchFilter languageSearchFilter = Lang.CreateDialogFilter(specialTextKey);
			LocalizedText localizedText;
			string text = localizedText.FormatWith(substitutes);
			return true;
		}

		// Token: 0x0600228C RID: 8844 RVA: 0x00115E3C File Offset: 0x0011403C
		public void CheckDrowning()
		{
			int num = 1;
			float x = this.position.X;
			float y = this.position.Y;
			int width = this.width;
			bool wet = this.wet;
			if (num == 0)
			{
			}
			bool logicHost = Main.LogicHost;
			int num2 = this.breathCounter;
			this.breathCounter = num2;
			int num3 = this.breath;
			this.breath = num3;
			int num4 = this.life;
			this.life = num4;
			int num5 = 1;
			this.netUpdate = num5 != 0;
			int num6 = 1;
			this.life = num6;
			if (num6 == 0)
			{
			}
			if (num6 != 0)
			{
				int whoAmI = this.whoAmI;
				return;
			}
			int num7;
			if (num7 == 0 && !this.lavaWet && !this.honeyWet && !this.shimmerWet)
			{
				int num8 = this.type;
				float x2 = this.position.X;
				float y2 = this.position.Y;
				int direction = this.direction;
				int width2 = this.width;
				if (direction == 0)
				{
				}
				return;
			}
		}

		// Token: 0x0600228D RID: 8845 RVA: 0x00115F38 File Offset: 0x00114138
		public void TryPortalJumping()
		{
			if (this.townNPC)
			{
				bool netClientOnly = Main.NetClientOnly;
			}
		}

		// Token: 0x0600228E RID: 8846 RVA: 0x00115F5C File Offset: 0x0011415C
		public static void GetMeleeCollisionData(Rectangle victimHitbox, int enemyIndex, int specialHitSetter, float damageMultiplier, Rectangle npcRect)
		{
			if (!true)
			{
			}
			if (17096 == 0)
			{
			}
			Rectangle rectangle;
			bool flag = rectangle.Intersects(rectangle);
		}

		// Token: 0x0600228F RID: 8847 RVA: 0x00115FE8 File Offset: 0x001141E8
		public string GetBestiaryCreditId()
		{
			/*
An exception occurred when decompiling this method (0600228F)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.String Terraria.NPC::GetBestiaryCreditId()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0003:
	stloc:int32(var_0_09, ldfld:int32(NPC::netID, ldloc:NPC(this)))
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

		// Token: 0x06002290 RID: 8848 RVA: 0x00116000 File Offset: 0x00114200
		public override string ToString()
		{
			if ("name:" == null || "name:" != null)
			{
				string typeName = this.TypeName;
				string text;
				string text2;
				if ((typeName == null || typeName != null) && (", active:" == null || ", active:" != null) && (text == null || text != null) && (", whoAmI:" == null || ", whoAmI:" != null) && (text2 == null || text2 != null))
				{
					string text3;
					return text3;
				}
			}
			throw new ArrayTypeMismatchException();
		}

		// Token: 0x06002291 RID: 8849 RVA: 0x0011605C File Offset: 0x0011425C
		public NPC()
		{
			if (!true)
			{
			}
			int num = 255;
			this.releaseOwner = (short)num;
			long num2 = 255L;
			this.lastInteraction = (int)num2;
			int num3 = 1;
			this.needsUniqueInfoUpdate = num3 != 0;
			int num4 = 16256;
			this.npcSlots = (float)num4;
			this._givenName = "";
			if ("" == null)
			{
			}
			this.canDisplayBuffs = num3 != 0;
			this.directionY = num3;
			this.strengthMultiplier = (float)num4;
			base..ctor();
		}

		// Token: 0x06002292 RID: 8850 RVA: 0x001160F4 File Offset: 0x001142F4
		// Note: this type is marked as 'beforefieldinit'.
		static NPC()
		{
			int[,,,] array = NPC.InitializeMoonLordAttacks();
			int[,] array2 = NPC.InitializeMoonLordAttacks2();
		}

		// Token: 0x04002D1B RID: 11547
		public static int MoonLordCountdown;

		// Token: 0x04002D1C RID: 11548
		public static int immuneTime;

		// Token: 0x04002D1D RID: 11549
		public static int maxAI;

		// Token: 0x04002D1E RID: 11550
		public static int[] killCount;

		// Token: 0x04002D1F RID: 11551
		public static float waveKills;

		// Token: 0x04002D20 RID: 11552
		public static int waveNumber;

		// Token: 0x04002D21 RID: 11553
		public static bool taxCollector;

		// Token: 0x04002D22 RID: 11554
		public static bool freeCake;

		// Token: 0x04002D23 RID: 11555
		private static float gravity;

		// Token: 0x04002D24 RID: 11556
		public static int fireFlyFriendly;

		// Token: 0x04002D25 RID: 11557
		public static int fireFlyChance;

		// Token: 0x04002D26 RID: 11558
		public static int fireFlyMultiple;

		// Token: 0x04002D27 RID: 11559
		public static int butterflyChance;

		// Token: 0x04002D28 RID: 11560
		public static int golemBoss;

		// Token: 0x04002D29 RID: 11561
		public static int plantBoss;

		// Token: 0x04002D2A RID: 11562
		public static int crimsonBoss;

		// Token: 0x04002D2B RID: 11563
		public static int deerclopsBoss;

		// Token: 0x04002D2C RID: 11564
		public static int sWidth;

		// Token: 0x04002D2D RID: 11565
		public static int sHeight;

		// Token: 0x04002D2E RID: 11566
		private static int spawnRangeX;

		// Token: 0x04002D2F RID: 11567
		private static int spawnRangeY;

		// Token: 0x04002D30 RID: 11568
		public static int safeRangeX;

		// Token: 0x04002D31 RID: 11569
		public static int safeRangeY;

		// Token: 0x04002D32 RID: 11570
		private static int activeRangeX;

		// Token: 0x04002D33 RID: 11571
		private static int activeRangeY;

		// Token: 0x04002D34 RID: 11572
		private static int townRangeX;

		// Token: 0x04002D35 RID: 11573
		private static int townRangeY;

		// Token: 0x04002D36 RID: 11574
		private static bool noSpawnCycle;

		// Token: 0x04002D37 RID: 11575
		private static int activeTime;

		// Token: 0x04002D38 RID: 11576
		private static int defaultSpawnRate;

		// Token: 0x04002D39 RID: 11577
		private static int defaultMaxSpawns;

		// Token: 0x04002D3A RID: 11578
		public static bool savedTaxCollector;

		// Token: 0x04002D3B RID: 11579
		public static bool savedGoblin;

		// Token: 0x04002D3C RID: 11580
		public static bool savedWizard;

		// Token: 0x04002D3D RID: 11581
		public static bool savedMech;

		// Token: 0x04002D3E RID: 11582
		public static bool savedAngler;

		// Token: 0x04002D3F RID: 11583
		public static bool savedStylist;

		// Token: 0x04002D40 RID: 11584
		public static bool savedBartender;

		// Token: 0x04002D41 RID: 11585
		public static bool savedGolfer;

		// Token: 0x04002D42 RID: 11586
		public static bool boughtCat;

		// Token: 0x04002D43 RID: 11587
		public static bool boughtDog;

		// Token: 0x04002D44 RID: 11588
		public static bool boughtBunny;

		// Token: 0x04002D45 RID: 11589
		public static bool combatBookWasUsed;

		// Token: 0x04002D46 RID: 11590
		public static bool combatBookVolumeTwoWasUsed;

		// Token: 0x04002D47 RID: 11591
		public static bool peddlersSatchelWasUsed;

		// Token: 0x04002D48 RID: 11592
		public static bool downedBoss1;

		// Token: 0x04002D49 RID: 11593
		public static bool downedBoss2;

		// Token: 0x04002D4A RID: 11594
		public static bool downedBoss3;

		// Token: 0x04002D4B RID: 11595
		public static bool downedQueenBee;

		// Token: 0x04002D4C RID: 11596
		public static bool downedSlimeKing;

		// Token: 0x04002D4D RID: 11597
		public static bool downedGoblins;

		// Token: 0x04002D4E RID: 11598
		public static bool downedFrost;

		// Token: 0x04002D4F RID: 11599
		public static bool downedPirates;

		// Token: 0x04002D50 RID: 11600
		public static bool downedClown;

		// Token: 0x04002D51 RID: 11601
		public static bool downedPlantBoss;

		// Token: 0x04002D52 RID: 11602
		public static bool downedGolemBoss;

		// Token: 0x04002D53 RID: 11603
		public static bool downedMartians;

		// Token: 0x04002D54 RID: 11604
		public static bool downedFishron;

		// Token: 0x04002D55 RID: 11605
		public static bool downedHalloweenTree;

		// Token: 0x04002D56 RID: 11606
		public static bool downedHalloweenKing;

		// Token: 0x04002D57 RID: 11607
		public static bool downedChristmasIceQueen;

		// Token: 0x04002D58 RID: 11608
		public static bool downedChristmasTree;

		// Token: 0x04002D59 RID: 11609
		public static bool downedChristmasSantank;

		// Token: 0x04002D5A RID: 11610
		public static bool downedAncientCultist;

		// Token: 0x04002D5B RID: 11611
		public static bool downedMoonlord;

		// Token: 0x04002D5C RID: 11612
		public static bool downedTowerSolar;

		// Token: 0x04002D5D RID: 11613
		public static bool downedTowerVortex;

		// Token: 0x04002D5E RID: 11614
		public static bool downedTowerNebula;

		// Token: 0x04002D5F RID: 11615
		public static bool downedTowerStardust;

		// Token: 0x04002D60 RID: 11616
		public static bool downedEmpressOfLight;

		// Token: 0x04002D61 RID: 11617
		public static bool downedQueenSlime;

		// Token: 0x04002D62 RID: 11618
		public static bool downedDeerclops;

		// Token: 0x04002D63 RID: 11619
		public static int ShieldStrengthTowerSolar;

		// Token: 0x04002D64 RID: 11620
		public static int ShieldStrengthTowerVortex;

		// Token: 0x04002D65 RID: 11621
		public static int ShieldStrengthTowerNebula;

		// Token: 0x04002D66 RID: 11622
		public static int ShieldStrengthTowerStardust;

		// Token: 0x04002D67 RID: 11623
		public static int LunarShieldPowerNormal;

		// Token: 0x04002D68 RID: 11624
		public static int LunarShieldPowerExpert;

		// Token: 0x04002D69 RID: 11625
		public static bool TowerActiveSolar;

		// Token: 0x04002D6A RID: 11626
		public static bool TowerActiveVortex;

		// Token: 0x04002D6B RID: 11627
		public static bool TowerActiveNebula;

		// Token: 0x04002D6C RID: 11628
		public static bool TowerActiveStardust;

		// Token: 0x04002D6D RID: 11629
		public static bool LunarApocalypseIsUp;

		// Token: 0x04002D6E RID: 11630
		public static bool downedMechBossAny;

		// Token: 0x04002D6F RID: 11631
		public static bool downedMechBoss1;

		// Token: 0x04002D70 RID: 11632
		public static bool downedMechBoss2;

		// Token: 0x04002D71 RID: 11633
		public static bool downedMechBoss3;

		// Token: 0x04002D72 RID: 11634
		public static bool[] npcsFoundForCheckActive;

		// Token: 0x04002D73 RID: 11635
		public static int[] lazyNPCOwnedProjectileSearchArray;

		// Token: 0x04002D74 RID: 11636
		private static int spawnRate;

		// Token: 0x04002D75 RID: 11637
		private static int maxSpawns;

		// Token: 0x04002D76 RID: 11638
		public static CoinLossRevengeSystem RevengeManager;

		// Token: 0x04002D77 RID: 11639
		public static bool travelNPC;

		// Token: 0x04002D78 RID: 11640
		public static int[,] cavernMonsterType;

		// Token: 0x04002D79 RID: 11641
		private static bool EoCKilledToday;

		// Token: 0x04002D7A RID: 11642
		private static bool WoFKilledToday;

		// Token: 0x04002D7B RID: 11643
		public static bool fairyLog;

		// Token: 0x04002D7C RID: 11644
		private static int ignorePlayerInteractions;

		// Token: 0x04002D7D RID: 11645
		public static int ladyBugGoodLuckTime;

		// Token: 0x04002D7E RID: 11646
		public static int ladyBugBadLuckTime;

		// Token: 0x04002D7F RID: 11647
		private static int ladyBugRainTime;

		// Token: 0x04002D80 RID: 11648
		private static int maximumAmountOfTimesLadyBugRainCanStack;

		// Token: 0x04002D81 RID: 11649
		public static int offSetDelayTime;

		// Token: 0x04002D82 RID: 11650
		private const int NPC_TARGETS_START = 300;

		// Token: 0x04002D83 RID: 11651
		public bool IsABestiaryIconDummy;

		// Token: 0x04002D84 RID: 11652
		public bool ForcePartyHatOn;

		// Token: 0x04002D85 RID: 11653
		public float waterMovementSpeed;

		// Token: 0x04002D86 RID: 11654
		public float lavaMovementSpeed;

		// Token: 0x04002D87 RID: 11655
		public float honeyMovementSpeed;

		// Token: 0x04002D88 RID: 11656
		public float shimmerMovementSpeed;

		// Token: 0x04002D89 RID: 11657
		public static readonly int[,,,] MoonLordAttacksArray;

		// Token: 0x04002D8A RID: 11658
		public static readonly int[,] MoonLordAttacksArray2;

		// Token: 0x04002D8B RID: 11659
		public static int MoonLordFightingDistance;

		// Token: 0x04002D8C RID: 11660
		public static int MaxMoonLordCountdown;

		// Token: 0x04002D8D RID: 11661
		public const int NaturalMoonlordCountdownTime = 3600;

		// Token: 0x04002D8E RID: 11662
		public const int ItemMoonlordCountdownTime = 720;

		// Token: 0x04002D8F RID: 11663
		public int teleportStyle;

		// Token: 0x04002D90 RID: 11664
		public float teleportTime;

		// Token: 0x04002D91 RID: 11665
		public int netSpam;

		// Token: 0x04002D92 RID: 11666
		public const int goldCritterChance = 400;

		// Token: 0x04002D93 RID: 11667
		public static float totalInvasionPoints;

		// Token: 0x04002D94 RID: 11668
		public const float nameOverIncrement = 0.025f;

		// Token: 0x04002D95 RID: 11669
		public const float nameOverDistance = 350f;

		// Token: 0x04002D96 RID: 11670
		public float nameOver;

		// Token: 0x04002D97 RID: 11671
		public bool SpawnedFromStatue;

		// Token: 0x04002D98 RID: 11672
		public bool CanBeReplacedByOtherNPCs;

		// Token: 0x04002D99 RID: 11673
		public bool dripping;

		// Token: 0x04002D9A RID: 11674
		public bool drippingSlime;

		// Token: 0x04002D9B RID: 11675
		public bool drippingSparkleSlime;

		// Token: 0x04002D9C RID: 11676
		public static readonly int AFKTimeNeededForNoWorms;

		// Token: 0x04002D9D RID: 11677
		public static bool[] ShimmeredTownNPCs;

		// Token: 0x04002D9E RID: 11678
		public int altTexture;

		// Token: 0x04002D9F RID: 11679
		public int townNpcVariationIndex;

		// Token: 0x04002DA0 RID: 11680
		public Vector2 netOffset;

		// Token: 0x04002DA1 RID: 11681
		public short catchItem;

		// Token: 0x04002DA2 RID: 11682
		public short releaseOwner;

		// Token: 0x04002DA3 RID: 11683
		public int rarity;

		// Token: 0x04002DA4 RID: 11684
		public bool[] playerInteraction;

		// Token: 0x04002DA5 RID: 11685
		public int lastInteraction;

		// Token: 0x04002DA6 RID: 11686
		public float takenDamageMultiplier;

		// Token: 0x04002DA7 RID: 11687
		private static int spawnSpaceX;

		// Token: 0x04002DA8 RID: 11688
		private static int spawnSpaceY;

		// Token: 0x04002DA9 RID: 11689
		public float gfxOffY;

		// Token: 0x04002DAA RID: 11690
		public float stepSpeed;

		// Token: 0x04002DAB RID: 11691
		public bool teleporting;

		// Token: 0x04002DAC RID: 11692
		public bool stairFall;

		// Token: 0x04002DAD RID: 11693
		public static int stinkBugChance;

		// Token: 0x04002DAE RID: 11694
		private int netStream;

		// Token: 0x04002DAF RID: 11695
		private int[] streamPlayer;

		// Token: 0x04002DB0 RID: 11696
		private bool needsUniqueInfoUpdate;

		// Token: 0x04002DB1 RID: 11697
		public Vector2[] oldPos;

		// Token: 0x04002DB2 RID: 11698
		public float[] oldRot;

		// Token: 0x04002DB3 RID: 11699
		public bool setFrameSize;

		// Token: 0x04002DB4 RID: 11700
		public int netSkip;

		// Token: 0x04002DB5 RID: 11701
		public bool netAlways;

		// Token: 0x04002DB6 RID: 11702
		public int realLife;

		// Token: 0x04002DB7 RID: 11703
		private string _givenName;

		// Token: 0x04002DB8 RID: 11704
		public float npcSlots;

		// Token: 0x04002DB9 RID: 11705
		public float shimmerTransparency;

		// Token: 0x04002DBA RID: 11706
		public bool dontCountMe;

		// Token: 0x04002DBB RID: 11707
		public static readonly int maxBuffs;

		// Token: 0x04002DBC RID: 11708
		public int[] buffType;

		// Token: 0x04002DBD RID: 11709
		public int[] buffTime;

		// Token: 0x04002DBE RID: 11710
		public bool[] buffImmune;

		// Token: 0x04002DBF RID: 11711
		public bool canDisplayBuffs;

		// Token: 0x04002DC0 RID: 11712
		public bool midas;

		// Token: 0x04002DC1 RID: 11713
		public bool ichor;

		// Token: 0x04002DC2 RID: 11714
		public bool onFire;

		// Token: 0x04002DC3 RID: 11715
		public bool onFire2;

		// Token: 0x04002DC4 RID: 11716
		public bool onFire3;

		// Token: 0x04002DC5 RID: 11717
		public bool onFrostBurn;

		// Token: 0x04002DC6 RID: 11718
		public bool onFrostBurn2;

		// Token: 0x04002DC7 RID: 11719
		public bool poisoned;

		// Token: 0x04002DC8 RID: 11720
		public bool markedByScytheWhip;

		// Token: 0x04002DC9 RID: 11721
		public bool venom;

		// Token: 0x04002DCA RID: 11722
		public bool shadowFlame;

		// Token: 0x04002DCB RID: 11723
		public bool soulDrain;

		// Token: 0x04002DCC RID: 11724
		public bool shimmering;

		// Token: 0x04002DCD RID: 11725
		public int lifeRegen;

		// Token: 0x04002DCE RID: 11726
		public int lifeRegenCount;

		// Token: 0x04002DCF RID: 11727
		public int lifeRegenExpectedLossPerSecond;

		// Token: 0x04002DD0 RID: 11728
		public bool confused;

		// Token: 0x04002DD1 RID: 11729
		public bool loveStruck;

		// Token: 0x04002DD2 RID: 11730
		public bool stinky;

		// Token: 0x04002DD3 RID: 11731
		public bool dryadWard;

		// Token: 0x04002DD4 RID: 11732
		public bool immortal;

		// Token: 0x04002DD5 RID: 11733
		public bool chaseable;

		// Token: 0x04002DD6 RID: 11734
		public bool canGhostHeal;

		// Token: 0x04002DD7 RID: 11735
		public bool javelined;

		// Token: 0x04002DD8 RID: 11736
		public bool tentacleSpiked;

		// Token: 0x04002DD9 RID: 11737
		public bool bloodButchered;

		// Token: 0x04002DDA RID: 11738
		public bool celled;

		// Token: 0x04002DDB RID: 11739
		public bool dryadBane;

		// Token: 0x04002DDC RID: 11740
		public bool daybreak;

		// Token: 0x04002DDD RID: 11741
		public bool dontTakeDamageFromHostiles;

		// Token: 0x04002DDE RID: 11742
		public bool betsysCurse;

		// Token: 0x04002DDF RID: 11743
		public bool oiled;

		// Token: 0x04002DE0 RID: 11744
		public static bool unlockedSlimeBlueSpawn;

		// Token: 0x04002DE1 RID: 11745
		public static bool unlockedSlimeGreenSpawn;

		// Token: 0x04002DE2 RID: 11746
		public static bool unlockedSlimeOldSpawn;

		// Token: 0x04002DE3 RID: 11747
		public static bool unlockedSlimePurpleSpawn;

		// Token: 0x04002DE4 RID: 11748
		public static bool unlockedSlimeRainbowSpawn;

		// Token: 0x04002DE5 RID: 11749
		public static bool unlockedSlimeRedSpawn;

		// Token: 0x04002DE6 RID: 11750
		public static bool unlockedSlimeYellowSpawn;

		// Token: 0x04002DE7 RID: 11751
		public static bool unlockedSlimeCopperSpawn;

		// Token: 0x04002DE8 RID: 11752
		public static bool unlockedMerchantSpawn;

		// Token: 0x04002DE9 RID: 11753
		public static bool unlockedDemolitionistSpawn;

		// Token: 0x04002DEA RID: 11754
		public static bool unlockedPartyGirlSpawn;

		// Token: 0x04002DEB RID: 11755
		public static bool unlockedDyeTraderSpawn;

		// Token: 0x04002DEC RID: 11756
		public static bool unlockedTruffleSpawn;

		// Token: 0x04002DED RID: 11757
		public static bool unlockedArmsDealerSpawn;

		// Token: 0x04002DEE RID: 11758
		public static bool unlockedNurseSpawn;

		// Token: 0x04002DEF RID: 11759
		public static bool unlockedPrincessSpawn;

		// Token: 0x04002DF0 RID: 11760
		public static int LunarShieldPowerMax;

		// Token: 0x04002DF1 RID: 11761
		public int soundDelay;

		// Token: 0x04002DF2 RID: 11762
		public int[] immune;

		// Token: 0x04002DF3 RID: 11763
		public int directionY;

		// Token: 0x04002DF4 RID: 11764
		public int type;

		// Token: 0x04002DF5 RID: 11765
		public float[] ai;

		// Token: 0x04002DF6 RID: 11766
		public float[] localAI;

		// Token: 0x04002DF7 RID: 11767
		public int aiAction;

		// Token: 0x04002DF8 RID: 11768
		public int aiStyle;

		// Token: 0x04002DF9 RID: 11769
		public bool justHit;

		// Token: 0x04002DFA RID: 11770
		public int timeLeft;

		// Token: 0x04002DFB RID: 11771
		public int target;

		// Token: 0x04002DFC RID: 11772
		public int damage;

		// Token: 0x04002DFD RID: 11773
		public int defense;

		// Token: 0x04002DFE RID: 11774
		public int defDamage;

		// Token: 0x04002DFF RID: 11775
		public int defDefense;

		// Token: 0x04002E00 RID: 11776
		public bool coldDamage;

		// Token: 0x04002E01 RID: 11777
		public bool trapImmune;

		// Token: 0x04002E02 RID: 11778
		public LegacySoundStyle HitSound;

		// Token: 0x04002E03 RID: 11779
		public LegacySoundStyle DeathSound;

		// Token: 0x04002E04 RID: 11780
		public int life;

		// Token: 0x04002E05 RID: 11781
		public int lifeMax;

		// Token: 0x04002E06 RID: 11782
		public Rectangle targetRect;

		// Token: 0x04002E07 RID: 11783
		public double frameCounter;

		// Token: 0x04002E08 RID: 11784
		public Rectangle frame;

		// Token: 0x04002E09 RID: 11785
		public Color color;

		// Token: 0x04002E0A RID: 11786
		public int alpha;

		// Token: 0x04002E0B RID: 11787
		public bool hide;

		// Token: 0x04002E0C RID: 11788
		public float scale;

		// Token: 0x04002E0D RID: 11789
		public float knockBackResist;

		// Token: 0x04002E0E RID: 11790
		public int oldDirectionY;

		// Token: 0x04002E0F RID: 11791
		public int oldTarget;

		// Token: 0x04002E10 RID: 11792
		public float rotation;

		// Token: 0x04002E11 RID: 11793
		public bool noGravity;

		// Token: 0x04002E12 RID: 11794
		public bool noTileCollide;

		// Token: 0x04002E13 RID: 11795
		public bool netUpdate;

		// Token: 0x04002E14 RID: 11796
		public bool netUpdate2;

		// Token: 0x04002E15 RID: 11797
		public bool collideX;

		// Token: 0x04002E16 RID: 11798
		public bool collideY;

		// Token: 0x04002E17 RID: 11799
		public bool boss;

		// Token: 0x04002E18 RID: 11800
		public int spriteDirection;

		// Token: 0x04002E19 RID: 11801
		public bool behindTiles;

		// Token: 0x04002E1A RID: 11802
		public bool lavaImmune;

		// Token: 0x04002E1B RID: 11803
		public float value;

		// Token: 0x04002E1C RID: 11804
		public int extraValue;

		// Token: 0x04002E1D RID: 11805
		public bool dontTakeDamage;

		// Token: 0x04002E1E RID: 11806
		private int catchableNPCTempImmunityCounter;

		// Token: 0x04002E1F RID: 11807
		public int netID;

		// Token: 0x04002E20 RID: 11808
		public int statsAreScaledForThisManyPlayers;

		// Token: 0x04002E21 RID: 11809
		public float strengthMultiplier;

		// Token: 0x04002E22 RID: 11810
		public bool townNPC;

		// Token: 0x04002E23 RID: 11811
		public bool homeless;

		// Token: 0x04002E24 RID: 11812
		public int homeTileX;

		// Token: 0x04002E25 RID: 11813
		public int homeTileY;

		// Token: 0x04002E26 RID: 11814
		public int housingCategory;

		// Token: 0x04002E27 RID: 11815
		public bool oldHomeless;

		// Token: 0x04002E28 RID: 11816
		public int oldHomeTileX;

		// Token: 0x04002E29 RID: 11817
		public int oldHomeTileY;

		// Token: 0x04002E2A RID: 11818
		public bool friendly;

		// Token: 0x04002E2B RID: 11819
		public bool closeDoor;

		// Token: 0x04002E2C RID: 11820
		public int doorX;

		// Token: 0x04002E2D RID: 11821
		public int doorY;

		// Token: 0x04002E2E RID: 11822
		public int friendlyRegen;

		// Token: 0x04002E2F RID: 11823
		public int breath;

		// Token: 0x04002E30 RID: 11824
		public const int breathMax = 200;

		// Token: 0x04002E31 RID: 11825
		public int breathCounter;

		// Token: 0x04002E32 RID: 11826
		public bool reflectsProjectiles;

		// Token: 0x04002E33 RID: 11827
		public int lastPortalColorIndex;

		// Token: 0x04002E34 RID: 11828
		public bool despawnEncouraged;

		// Token: 0x04002E35 RID: 11829
		private long GoodRestingTileCacheTileState;

		// Token: 0x04002E36 RID: 11830
		private bool GoodRestingTileCacheFound;

		// Token: 0x04002E37 RID: 11831
		private Point GoodRestingTileCacheOrigin;

		// Token: 0x04002E38 RID: 11832
		private Point GoodRestingTileCacheResult;

		// Token: 0x04002E39 RID: 11833
		private bool netShimmer;

		// Token: 0x04002E3A RID: 11834
		public static int mechQueen;

		// Token: 0x04002E3B RID: 11835
		public static int brainOfGravity;

		// Token: 0x04002E3C RID: 11836
		public static bool empressRageMode;

		// Token: 0x04002E3D RID: 11837
		private static readonly int[] _deerclopsAttack1Frames;

		// Token: 0x04002E3E RID: 11838
		private static readonly int[] _deerclopsAttack2Frames;

		// Token: 0x04002E3F RID: 11839
		private static readonly int[] _deerclopsAttack3Frames;

		// Token: 0x04002E40 RID: 11840
		public static int[] MoonEventRequiredPointsPerWaveLookup;

		// Token: 0x04002E41 RID: 11841
		private static bool dayTimeHax;

		// Token: 0x04002E42 RID: 11842
		private static bool rainingHax;

		// Token: 0x04002E43 RID: 11843
		private static float cloudAlphaHax;

		// Token: 0x04002E44 RID: 11844
		public static bool PreventJojaColaDialog;

		// Token: 0x04002E45 RID: 11845
		public static int RerollDryadText;
	}
}
