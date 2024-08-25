using System;
using Terraria.Localization;
using Terraria.UI;

namespace Terraria.GameContent.Bestiary
{
	// Token: 0x0200096D RID: 2413
	public class NPCKillCounterInfoElement : IBestiaryInfoElement
	{
		// Token: 0x0600482D RID: 18477 RVA: 0x0025FF68 File Offset: 0x0025E168
		public NPCKillCounterInfoElement(int npcNetId)
		{
			if (!true)
			{
			}
		}

		// Token: 0x0600482E RID: 18478 RVA: 0x0025FF80 File Offset: 0x0025E180
		public UIElement ProvideUIElement(BestiaryUICollectionInfo info)
		{
			int? killCount = this.GetKillCount();
			int num = 17114;
			if (num != 0)
			{
			}
			long num2 = 0L;
			string text;
			int stringLength = text._stringLength;
			if (num == 0)
			{
			}
			int num3 = Math.Max(0, (int)num2);
			if (num == 0)
			{
				return;
			}
		}

		// Token: 0x0600482F RID: 18479 RVA: 0x0025FFD4 File Offset: 0x0025E1D4
		private void ShowDescription(UIElement element)
		{
			bool <IsMouseHovering>k__BackingField = element.<IsMouseHovering>k__BackingField;
			if (<IsMouseHovering>k__BackingField)
			{
				if (!<IsMouseHovering>k__BackingField)
				{
				}
				string textValue = Language.GetTextValue("BestiaryInfo.Slain");
			}
		}

		// Token: 0x06004830 RID: 18480 RVA: 0x0025FFFC File Offset: 0x0025E1FC
		private int? GetKillCount()
		{
			/*
An exception occurred when decompiling this method (06004830)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Nullable`1<System.Int32> Terraria.GameContent.Bestiary.NPCKillCounterInfoElement::GetKillCount()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0003:
	stloc:string(var_0_0E, call:string(NPC::GetBestiaryCreditId, ldfld:NPC(NPCKillCounterInfoElement::_instance, ldloc:NPCKillCounterInfoElement(this))))
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

		// Token: 0x040083B2 RID: 33714
		private NPC _instance;
	}
}
