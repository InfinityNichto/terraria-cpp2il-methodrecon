using System;
using System.Runtime.CompilerServices;
using Terraria.UI;

namespace Terraria.GameContent.Bestiary
{
	// Token: 0x02000968 RID: 2408
	public class NPCNetIdBestiaryInfoElement : IBestiaryInfoElement, IBestiaryEntryDisplayIndex
	{
		// Token: 0x1700082C RID: 2092
		// (get) Token: 0x0600481C RID: 18460 RVA: 0x0025FD68 File Offset: 0x0025DF68
		// (set) Token: 0x0600481D RID: 18461 RVA: 0x0025FD7C File Offset: 0x0025DF7C
		public int NetId
		{
			[CompilerGenerated]
			get
			{
				return this.<NetId>k__BackingField;
			}
			[CompilerGenerated]
			private set
			{
				this.<NetId>k__BackingField = value;
			}
		}

		// Token: 0x0600481E RID: 18462 RVA: 0x0025FD90 File Offset: 0x0025DF90
		public NPCNetIdBestiaryInfoElement(int npcNetId)
		{
			this.NetId = npcNetId;
		}

		// Token: 0x0600481F RID: 18463 RVA: 0x0025FDAC File Offset: 0x0025DFAC
		public UIElement ProvideUIElement(BestiaryUICollectionInfo info)
		{
		}

		// Token: 0x1700082D RID: 2093
		// (get) Token: 0x06004820 RID: 18464 RVA: 0x0025FDBC File Offset: 0x0025DFBC
		public int BestiaryDisplayIndex
		{
			get
			{
				/*
An exception occurred when decompiling this method (06004820)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Int32 Terraria.GameContent.Bestiary.NPCNetIdBestiaryInfoElement::get_BestiaryDisplayIndex()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0003:
	stloc:int32(var_0_09, ldfld:int32(NPCNetIdBestiaryInfoElement::<NetId>k__BackingField, ldloc:NPCNetIdBestiaryInfoElement(this)))
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

		// Token: 0x040083AC RID: 33708
		[CompilerGenerated]
		private int <NetId>k__BackingField;
	}
}
