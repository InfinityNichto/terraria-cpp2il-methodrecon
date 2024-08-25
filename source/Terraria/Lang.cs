using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Terraria.Localization;
using Terraria.Map;
using Terraria.UI;

namespace Terraria
{
	// Token: 0x02000436 RID: 1078
	public class Lang
	{
		// Token: 0x06002838 RID: 10296 RVA: 0x001917C8 File Offset: 0x0018F9C8
		public static string GetMapObjectName(int id)
		{
			/*
An exception occurred when decompiling this method (06002838)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.String Terraria.Lang::GetMapObjectName(System.Int32)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0005:
	brtrue(IL_0000, logicnot:bool(ldloc:int32[exp:bool](var_0_01)))
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

		// Token: 0x06002839 RID: 10297 RVA: 0x001917DC File Offset: 0x0018F9DC
		public static object CreateDialogSubstitutionObject([Optional] NPC npc)
		{
			/*
An exception occurred when decompiling this method (06002839)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Object Terraria.Lang::CreateDialogSubstitutionObject(Terraria.NPC)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0204:
	stloc:KeyCode(var_83_20E, ldfld:KeyCode(Entry::InputKey, ldloc:Entry(var_82)))
	stloc:string(var_85_217, call:string(Language::GetTextValue, ldloc:string(var_84)))
	brtrue(IL_0000, ldstr:string[exp:bool]("KeyboardBindings.{0}"))
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

		// Token: 0x0600283A RID: 10298 RVA: 0x00191A0C File Offset: 0x0018FC0C
		public static bool CanSubstituteBindings(string bindingKey)
		{
			if (!true)
			{
			}
			XNAUnityRunner.ForcedInputMode primaryInputMode = XNAUnityRunner.PrimaryInputMode;
			bool flag;
			return flag;
		}

		// Token: 0x0600283B RID: 10299 RVA: 0x00191A78 File Offset: 0x0018FC78
		[Obsolete("dialog is deprecated. Please use Language.GetText instead.")]
		public static string dialog(int l, bool english = false)
		{
			string text2;
			string text = "LegacyDialog." + text2;
			object obj;
			return Language.GetTextValueWith(text, obj);
		}

		// Token: 0x0600283C RID: 10300 RVA: 0x00191A9C File Offset: 0x0018FC9C
		public static string GetNPCNameValue(int netID)
		{
			if (!true)
			{
			}
			return Lang.GetNPCName(42178960).<Value>k__BackingField;
		}

		// Token: 0x0600283D RID: 10301 RVA: 0x00191ABC File Offset: 0x0018FCBC
		public static LocalizedText GetNPCName(int netID)
		{
			/*
An exception occurred when decompiling this method (0600283D)

ICSharpCode.Decompiler.DecompilerException: Error decompiling Terraria.Localization.LocalizedText Terraria.Lang::GetNPCName(System.Int32)

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

		// Token: 0x0600283E RID: 10302 RVA: 0x00191AD0 File Offset: 0x0018FCD0
		public static ItemTooltip GetTooltip(int itemId)
		{
			/*
An exception occurred when decompiling this method (0600283E)

ICSharpCode.Decompiler.DecompilerException: Error decompiling Terraria.UI.ItemTooltip Terraria.Lang::GetTooltip(System.Int32)

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

		// Token: 0x0600283F RID: 10303 RVA: 0x00191AE0 File Offset: 0x0018FCE0
		public static LocalizedText GetItemName(int id)
		{
			/*
An exception occurred when decompiling this method (0600283F)

ICSharpCode.Decompiler.DecompilerException: Error decompiling Terraria.Localization.LocalizedText Terraria.Lang::GetItemName(System.Int32)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	brtrue(IL_0000, ldloc:int32[exp:bool](var_2_0A))
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

		// Token: 0x06002840 RID: 10304 RVA: 0x00191B00 File Offset: 0x0018FD00
		public static LocalizedText GetEmojiName(int id)
		{
			/*
An exception occurred when decompiling this method (06002840)

ICSharpCode.Decompiler.DecompilerException: Error decompiling Terraria.Localization.LocalizedText Terraria.Lang::GetEmojiName(System.Int32)

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

		// Token: 0x06002841 RID: 10305 RVA: 0x00191B10 File Offset: 0x0018FD10
		public static string GetItemNameValue(int id)
		{
			if (!true)
			{
			}
			return Lang.GetItemName(42178960).<Value>k__BackingField;
		}

		// Token: 0x06002842 RID: 10306 RVA: 0x00191B30 File Offset: 0x0018FD30
		public static string GetBuffName(int id)
		{
			/*
An exception occurred when decompiling this method (06002842)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.String Terraria.Lang::GetBuffName(System.Int32)

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

		// Token: 0x06002843 RID: 10307 RVA: 0x00191B40 File Offset: 0x0018FD40
		public static string GetBuffDescription(int id)
		{
			/*
An exception occurred when decompiling this method (06002843)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.String Terraria.Lang::GetBuffDescription(System.Int32)

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

		// Token: 0x06002844 RID: 10308 RVA: 0x00191B50 File Offset: 0x0018FD50
		public static string GetDryadWorldStatusDialog([Out] bool worldIsEntirelyPure)
		{
			if (!true)
			{
			}
			string text;
			return text;
		}

		// Token: 0x06002845 RID: 10309 RVA: 0x00191BC0 File Offset: 0x0018FDC0
		public static string GetRandomGameTitle()
		{
			LocalizedText localizedText;
			return localizedText.<Value>k__BackingField;
		}

		// Token: 0x06002846 RID: 10310 RVA: 0x00191BD4 File Offset: 0x0018FDD4
		public static string DyeTraderQuestChat(bool gotDye = false)
		{
			if (!true)
			{
			}
			LanguageSearchFilter languageSearchFilter;
			string <Value>k__BackingField = Language.FindAll(languageSearchFilter).<Value>k__BackingField;
			string text;
			return text;
		}

		// Token: 0x06002847 RID: 10311 RVA: 0x00191BF4 File Offset: 0x0018FDF4
		public static string AnglerQuestCountChat(NPC npc)
		{
			if (!true)
			{
			}
			object obj;
			LanguageSearchFilter languageSearchFilter = Lang.CreateDialogFilter("AnglerQuestChatter.", obj);
			LocalizedText localizedText;
			return localizedText.FormatWith(obj);
		}

		// Token: 0x06002848 RID: 10312 RVA: 0x00191C18 File Offset: 0x0018FE18
		public static string BartenderHelpText(NPC npc)
		{
			if (!true)
			{
			}
			int myPlayer = Main.myPlayer;
			object obj;
			string <Value>k__BackingField = Language.FindAll(Lang.CreateDialogFilter("BartenderHelpText.", obj)).<Value>k__BackingField;
			string text;
			return text;
		}

		// Token: 0x06002849 RID: 10313 RVA: 0x00191C90 File Offset: 0x0018FE90
		public static string BartenderChat(NPC npc)
		{
			if (!true)
			{
			}
			int num;
			if (num != 0)
			{
				object obj;
				LanguageSearchFilter languageSearchFilter = Lang.CreateDialogFilter("BartenderChatter.", obj);
				LocalizedText localizedText;
				return localizedText.FormatWith(obj);
			}
			string text;
			return text;
		}

		// Token: 0x0600284A RID: 10314 RVA: 0x00191CBC File Offset: 0x0018FEBC
		public static string GolferChat(NPC npc)
		{
			if (!true)
			{
			}
			object obj;
			LanguageSearchFilter languageSearchFilter = Lang.CreateDialogFilter("GolferChatter.", obj);
			LocalizedText localizedText;
			return localizedText.FormatWith(obj);
		}

		// Token: 0x0600284B RID: 10315 RVA: 0x00191CE0 File Offset: 0x0018FEE0
		public static string BestiaryGirlChat(NPC npc)
		{
			if (!true)
			{
			}
			LocalizedText localizedText;
			object obj;
			return localizedText.FormatWith(obj);
		}

		// Token: 0x0600284C RID: 10316 RVA: 0x00191CF8 File Offset: 0x0018FEF8
		public static string PrincessChat(NPC npc)
		{
			if (!true)
			{
			}
			object obj;
			LanguageSearchFilter languageSearchFilter = Lang.CreateDialogFilter("PrincessChatter.", obj);
			LocalizedText localizedText;
			return localizedText.FormatWith(obj);
		}

		// Token: 0x0600284D RID: 10317 RVA: 0x00191D1C File Offset: 0x0018FF1C
		public static string CatChat(NPC npc)
		{
			if (!true)
			{
			}
			object obj;
			LanguageSearchFilter languageSearchFilter = Lang.CreateDialogFilter("CatChatter.", obj);
			LocalizedText localizedText;
			return localizedText.FormatWith(obj);
		}

		// Token: 0x0600284E RID: 10318 RVA: 0x00191D40 File Offset: 0x0018FF40
		public static string DogChat(NPC npc)
		{
			if (!true)
			{
			}
			object obj;
			LanguageSearchFilter languageSearchFilter = Lang.CreateDialogFilter("DogChatter.", obj);
			LocalizedText localizedText;
			return localizedText.FormatWith(obj);
		}

		// Token: 0x0600284F RID: 10319 RVA: 0x00191D64 File Offset: 0x0018FF64
		public static string BunnyChat(NPC npc)
		{
			if (!true)
			{
			}
			object obj;
			LanguageSearchFilter languageSearchFilter = Lang.CreateDialogFilter("BunnyChatter.", obj);
			LocalizedText localizedText;
			return localizedText.FormatWith(obj);
		}

		// Token: 0x06002850 RID: 10320 RVA: 0x00191D88 File Offset: 0x0018FF88
		public static string SlimeChat(NPC npc)
		{
			if (!true)
			{
			}
			string text = "Slime" + "Blue" + "Chatter.";
			if ("Green" == null)
			{
			}
			object obj;
			LanguageSearchFilter languageSearchFilter = Lang.CreateDialogFilter(text, obj);
			LocalizedText localizedText;
			return localizedText.FormatWith(obj);
		}

		// Token: 0x06002851 RID: 10321 RVA: 0x00191DC4 File Offset: 0x0018FFC4
		public static string GetNPCHouseBannerText(NPC npc, int bannerStyle)
		{
			string text;
			return Language.GetTextValue("Game.ReservedForNPC", text);
		}

		// Token: 0x06002852 RID: 10322 RVA: 0x000021DB File Offset: 0x000003DB
		public static LanguageSearchFilter CreateDialogFilter(string startsWith, object substitutions)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06002853 RID: 10323 RVA: 0x000021DB File Offset: 0x000003DB
		public static LanguageSearchFilter CreateDialogFilter(string startsWith)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06002854 RID: 10324 RVA: 0x00191DE0 File Offset: 0x0018FFE0
		public static string AnglerQuestChat(bool turnIn = false)
		{
			int num = 1;
			if (num == 0)
			{
			}
			if (num == 0)
			{
			}
			object obj;
			LanguageSearchFilter languageSearchFilter = Lang.CreateDialogFilter("AnglerQuestText.TurnIn_", obj);
			LocalizedText localizedText;
			return localizedText.FormatWith(obj);
		}

		// Token: 0x06002855 RID: 10325 RVA: 0x00191E34 File Offset: 0x00190034
		public static LocalizedText GetProjectileName(int type)
		{
			/*
An exception occurred when decompiling this method (06002855)

ICSharpCode.Decompiler.DecompilerException: Error decompiling Terraria.Localization.LocalizedText Terraria.Lang::GetProjectileName(System.Int32)

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

		// Token: 0x06002856 RID: 10326 RVA: 0x00191E44 File Offset: 0x00190044
		private static void FillNameCacheArray<IdClass, IdType>(string category, LocalizedText[] nameCache, bool leaveMissingEntriesBlank = false) where IdType : IConvertible
		{
			if (nameCache.<Value>k__BackingField == null)
			{
			}
		}

		// Token: 0x06002857 RID: 10327 RVA: 0x00191E64 File Offset: 0x00190064
		private static string ToopltipProcessor(short Id, string tooltip)
		{
			if (!true)
			{
			}
			XNAUnityRunner.ForcedInputMode primaryInputMode = XNAUnityRunner.PrimaryInputMode;
			return Language.GetTextValue("Mobile.TooltipInteractKM");
		}

		// Token: 0x06002858 RID: 10328 RVA: 0x001923A0 File Offset: 0x001905A0
		public static void InitializeLegacyLocalization()
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
			string text2;
			LocalizedText text = Language.GetText("LegacyWorldGen." + text2);
			if (text == null || text != null)
			{
				return;
			}
			throw new ArrayTypeMismatchException();
		}

		// Token: 0x06002859 RID: 10329 RVA: 0x00192680 File Offset: 0x00190880
		public static void BuildMapAtlas()
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
				int num2 = MapHelper.LookupCount();
				return;
			}
		}

		// Token: 0x0600285A RID: 10330 RVA: 0x00196464 File Offset: 0x00194664
		public static NetworkText CreateDeathMessage(string deadPlayerName, int plr = -1, int npc = -1, int proj = -1, int other = -1, int projType = 0, int plrItemType = 0)
		{
			int num = 1;
			if (num == 0)
			{
			}
			if (num == 0)
			{
			}
			LocalizedText projectileName = Lang.GetProjectileName(other);
			string key = projectileName.Key;
			if (projectileName == null)
			{
			}
			LocalizedText itemName = Lang.GetItemName(projType);
			string key2 = itemName.Key;
			if (itemName == null)
			{
			}
			LocalizedText localizedText;
			string key3 = localizedText.Key;
			NetworkText networkText;
			NetworkText networkText2;
			if ((proj == 0 || proj != 0) && (networkText == null || networkText != null) && (networkText2 == null || networkText2 != null))
			{
				return "DeathSource.NPC";
			}
			throw new ArrayTypeMismatchException();
		}

		// Token: 0x0600285B RID: 10331 RVA: 0x0019662C File Offset: 0x0019482C
		public static NetworkText GetInvasionWaveText(int wave, params short[] npcIds)
		{
			if (!true)
			{
			}
			LocalizedText npcname = Lang.GetNPCName(43143168);
			string key = npcname.Key;
			if (npcname == null)
			{
			}
			NetworkText networkText;
			if (networkText == null || networkText != null)
			{
				return "Game.FinalWave";
			}
			throw new ArrayTypeMismatchException();
		}

		// Token: 0x0600285C RID: 10332 RVA: 0x00196684 File Offset: 0x00194884
		public static string LocalizedDuration(TimeSpan time, bool abbreviated, bool showAllAvailableUnits)
		{
			int num = 1;
			if (num == 0)
			{
			}
			GameCulture gameCulture;
			bool isActive = gameCulture.IsActive;
			if (num == 0)
			{
			}
			TimeSpan timeSpan;
			bool flag = time > timeSpan;
			string textValue = Language.GetTextValue("Misc.ShortDays");
			return " " + textValue;
		}

		// Token: 0x0600285D RID: 10333 RVA: 0x001967A4 File Offset: 0x001949A4
		public Lang()
		{
		}

		// Token: 0x0600285E RID: 10334 RVA: 0x001967B8 File Offset: 0x001949B8
		// Note: this type is marked as 'beforefieldinit'.
		static Lang()
		{
		}

		// Token: 0x0400355F RID: 13663
		[Obsolete("Lang arrays have been replaced with the new Language.GetText system.")]
		public static LocalizedText[] menu;

		// Token: 0x04003560 RID: 13664
		[Obsolete("Lang arrays have been replaced with the new Language.GetText system.")]
		public static LocalizedText[] gen;

		// Token: 0x04003561 RID: 13665
		[Obsolete("Lang arrays have been replaced with the new Language.GetText system.")]
		public static LocalizedText[] misc;

		// Token: 0x04003562 RID: 13666
		[Obsolete("Lang arrays have been replaced with the new Language.GetText system.")]
		public static LocalizedText[] inter;

		// Token: 0x04003563 RID: 13667
		[Obsolete("Lang arrays have been replaced with the new Language.GetText system.")]
		public static LocalizedText[] tip;

		// Token: 0x04003564 RID: 13668
		[Obsolete("Lang arrays have been replaced with the new Language.GetText system.")]
		public static LocalizedText[] mp;

		// Token: 0x04003565 RID: 13669
		[Obsolete("Lang arrays have been replaced with the new Language.GetText system.")]
		public static LocalizedText[] chestType;

		// Token: 0x04003566 RID: 13670
		[Obsolete("Lang arrays have been replaced with the new Language.GetText system.")]
		public static LocalizedText[] dresserType;

		// Token: 0x04003567 RID: 13671
		[Obsolete("Lang arrays have been replaced with the new Language.GetText system.")]
		public static LocalizedText[] chestType2;

		// Token: 0x04003568 RID: 13672
		public static LocalizedText[] prefix;

		// Token: 0x04003569 RID: 13673
		public static LocalizedText[] _mapLegendCache;

		// Token: 0x0400356A RID: 13674
		public static LocalizedText[] mobile;

		// Token: 0x0400356B RID: 13675
		private static LocalizedText[] _itemNameCache;

		// Token: 0x0400356C RID: 13676
		private static LocalizedText[] _projectileNameCache;

		// Token: 0x0400356D RID: 13677
		private static LocalizedText[] _npcNameCache;

		// Token: 0x0400356E RID: 13678
		private static LocalizedText[] _negativeNpcNameCache;

		// Token: 0x0400356F RID: 13679
		private static LocalizedText[] _buffNameCache;

		// Token: 0x04003570 RID: 13680
		private static LocalizedText[] _buffDescriptionCache;

		// Token: 0x04003571 RID: 13681
		private static ItemTooltip[] _itemTooltipCache;

		// Token: 0x04003572 RID: 13682
		private static LocalizedText[] _emojiNameCache;

		// Token: 0x04003573 RID: 13683
		private static Lang.SubstitutionsObject SubstitutionsObjectValue;

		// Token: 0x02000437 RID: 1079
		public class SubstitutionsObject
		{
			// Token: 0x1700056E RID: 1390
			// (get) Token: 0x0600285F RID: 10335 RVA: 0x001967C8 File Offset: 0x001949C8
			// (set) Token: 0x06002860 RID: 10336 RVA: 0x001967DC File Offset: 0x001949DC
			public string Nurse
			{
				[CompilerGenerated]
				get
				{
					return this.<Nurse>k__BackingField;
				}
				[CompilerGenerated]
				set
				{
					this.<Nurse>k__BackingField = value;
				}
			}

			// Token: 0x1700056F RID: 1391
			// (get) Token: 0x06002861 RID: 10337 RVA: 0x001967F0 File Offset: 0x001949F0
			// (set) Token: 0x06002862 RID: 10338 RVA: 0x00196804 File Offset: 0x00194A04
			public string Merchant
			{
				[CompilerGenerated]
				get
				{
					return this.<Merchant>k__BackingField;
				}
				[CompilerGenerated]
				set
				{
					this.<Merchant>k__BackingField = value;
				}
			}

			// Token: 0x17000570 RID: 1392
			// (get) Token: 0x06002863 RID: 10339 RVA: 0x00196818 File Offset: 0x00194A18
			// (set) Token: 0x06002864 RID: 10340 RVA: 0x0019682C File Offset: 0x00194A2C
			public string ArmsDealer
			{
				[CompilerGenerated]
				get
				{
					return this.<ArmsDealer>k__BackingField;
				}
				[CompilerGenerated]
				set
				{
					this.<ArmsDealer>k__BackingField = value;
				}
			}

			// Token: 0x17000571 RID: 1393
			// (get) Token: 0x06002865 RID: 10341 RVA: 0x00196840 File Offset: 0x00194A40
			// (set) Token: 0x06002866 RID: 10342 RVA: 0x00196854 File Offset: 0x00194A54
			public string Dryad
			{
				[CompilerGenerated]
				get
				{
					return this.<Dryad>k__BackingField;
				}
				[CompilerGenerated]
				set
				{
					this.<Dryad>k__BackingField = value;
				}
			}

			// Token: 0x17000572 RID: 1394
			// (get) Token: 0x06002867 RID: 10343 RVA: 0x00196868 File Offset: 0x00194A68
			// (set) Token: 0x06002868 RID: 10344 RVA: 0x0019687C File Offset: 0x00194A7C
			public string Demolitionist
			{
				[CompilerGenerated]
				get
				{
					return this.<Demolitionist>k__BackingField;
				}
				[CompilerGenerated]
				set
				{
					this.<Demolitionist>k__BackingField = value;
				}
			}

			// Token: 0x17000573 RID: 1395
			// (get) Token: 0x06002869 RID: 10345 RVA: 0x00196890 File Offset: 0x00194A90
			// (set) Token: 0x0600286A RID: 10346 RVA: 0x001968A4 File Offset: 0x00194AA4
			public string Clothier
			{
				[CompilerGenerated]
				get
				{
					return this.<Clothier>k__BackingField;
				}
				[CompilerGenerated]
				set
				{
					this.<Clothier>k__BackingField = value;
				}
			}

			// Token: 0x17000574 RID: 1396
			// (get) Token: 0x0600286B RID: 10347 RVA: 0x001968B8 File Offset: 0x00194AB8
			// (set) Token: 0x0600286C RID: 10348 RVA: 0x001968CC File Offset: 0x00194ACC
			public string Guide
			{
				[CompilerGenerated]
				get
				{
					return this.<Guide>k__BackingField;
				}
				[CompilerGenerated]
				set
				{
					this.<Guide>k__BackingField = value;
				}
			}

			// Token: 0x17000575 RID: 1397
			// (get) Token: 0x0600286D RID: 10349 RVA: 0x001968E0 File Offset: 0x00194AE0
			// (set) Token: 0x0600286E RID: 10350 RVA: 0x001968F4 File Offset: 0x00194AF4
			public string Wizard
			{
				[CompilerGenerated]
				get
				{
					return this.<Wizard>k__BackingField;
				}
				[CompilerGenerated]
				set
				{
					this.<Wizard>k__BackingField = value;
				}
			}

			// Token: 0x17000576 RID: 1398
			// (get) Token: 0x0600286F RID: 10351 RVA: 0x00196908 File Offset: 0x00194B08
			// (set) Token: 0x06002870 RID: 10352 RVA: 0x0019691C File Offset: 0x00194B1C
			public string GoblinTinkerer
			{
				[CompilerGenerated]
				get
				{
					return this.<GoblinTinkerer>k__BackingField;
				}
				[CompilerGenerated]
				set
				{
					this.<GoblinTinkerer>k__BackingField = value;
				}
			}

			// Token: 0x17000577 RID: 1399
			// (get) Token: 0x06002871 RID: 10353 RVA: 0x00196930 File Offset: 0x00194B30
			// (set) Token: 0x06002872 RID: 10354 RVA: 0x00196944 File Offset: 0x00194B44
			public string Mechanic
			{
				[CompilerGenerated]
				get
				{
					return this.<Mechanic>k__BackingField;
				}
				[CompilerGenerated]
				set
				{
					this.<Mechanic>k__BackingField = value;
				}
			}

			// Token: 0x17000578 RID: 1400
			// (get) Token: 0x06002873 RID: 10355 RVA: 0x00196958 File Offset: 0x00194B58
			// (set) Token: 0x06002874 RID: 10356 RVA: 0x0019696C File Offset: 0x00194B6C
			public string Truffle
			{
				[CompilerGenerated]
				get
				{
					return this.<Truffle>k__BackingField;
				}
				[CompilerGenerated]
				set
				{
					this.<Truffle>k__BackingField = value;
				}
			}

			// Token: 0x17000579 RID: 1401
			// (get) Token: 0x06002875 RID: 10357 RVA: 0x00196980 File Offset: 0x00194B80
			// (set) Token: 0x06002876 RID: 10358 RVA: 0x00196994 File Offset: 0x00194B94
			public string Steampunker
			{
				[CompilerGenerated]
				get
				{
					return this.<Steampunker>k__BackingField;
				}
				[CompilerGenerated]
				set
				{
					this.<Steampunker>k__BackingField = value;
				}
			}

			// Token: 0x1700057A RID: 1402
			// (get) Token: 0x06002877 RID: 10359 RVA: 0x001969A8 File Offset: 0x00194BA8
			// (set) Token: 0x06002878 RID: 10360 RVA: 0x001969BC File Offset: 0x00194BBC
			public string DyeTrader
			{
				[CompilerGenerated]
				get
				{
					return this.<DyeTrader>k__BackingField;
				}
				[CompilerGenerated]
				set
				{
					this.<DyeTrader>k__BackingField = value;
				}
			}

			// Token: 0x1700057B RID: 1403
			// (get) Token: 0x06002879 RID: 10361 RVA: 0x001969D0 File Offset: 0x00194BD0
			// (set) Token: 0x0600287A RID: 10362 RVA: 0x001969E4 File Offset: 0x00194BE4
			public string PartyGirl
			{
				[CompilerGenerated]
				get
				{
					return this.<PartyGirl>k__BackingField;
				}
				[CompilerGenerated]
				set
				{
					this.<PartyGirl>k__BackingField = value;
				}
			}

			// Token: 0x1700057C RID: 1404
			// (get) Token: 0x0600287B RID: 10363 RVA: 0x001969F8 File Offset: 0x00194BF8
			// (set) Token: 0x0600287C RID: 10364 RVA: 0x00196A0C File Offset: 0x00194C0C
			public string Cyborg
			{
				[CompilerGenerated]
				get
				{
					return this.<Cyborg>k__BackingField;
				}
				[CompilerGenerated]
				set
				{
					this.<Cyborg>k__BackingField = value;
				}
			}

			// Token: 0x1700057D RID: 1405
			// (get) Token: 0x0600287D RID: 10365 RVA: 0x00196A20 File Offset: 0x00194C20
			// (set) Token: 0x0600287E RID: 10366 RVA: 0x00196A34 File Offset: 0x00194C34
			public string Painter
			{
				[CompilerGenerated]
				get
				{
					return this.<Painter>k__BackingField;
				}
				[CompilerGenerated]
				set
				{
					this.<Painter>k__BackingField = value;
				}
			}

			// Token: 0x1700057E RID: 1406
			// (get) Token: 0x0600287F RID: 10367 RVA: 0x00196A48 File Offset: 0x00194C48
			// (set) Token: 0x06002880 RID: 10368 RVA: 0x00196A5C File Offset: 0x00194C5C
			public string WitchDoctor
			{
				[CompilerGenerated]
				get
				{
					return this.<WitchDoctor>k__BackingField;
				}
				[CompilerGenerated]
				set
				{
					this.<WitchDoctor>k__BackingField = value;
				}
			}

			// Token: 0x1700057F RID: 1407
			// (get) Token: 0x06002881 RID: 10369 RVA: 0x00196A70 File Offset: 0x00194C70
			// (set) Token: 0x06002882 RID: 10370 RVA: 0x00196A84 File Offset: 0x00194C84
			public string Pirate
			{
				[CompilerGenerated]
				get
				{
					return this.<Pirate>k__BackingField;
				}
				[CompilerGenerated]
				set
				{
					this.<Pirate>k__BackingField = value;
				}
			}

			// Token: 0x17000580 RID: 1408
			// (get) Token: 0x06002883 RID: 10371 RVA: 0x00196A98 File Offset: 0x00194C98
			// (set) Token: 0x06002884 RID: 10372 RVA: 0x00196AAC File Offset: 0x00194CAC
			public string Stylist
			{
				[CompilerGenerated]
				get
				{
					return this.<Stylist>k__BackingField;
				}
				[CompilerGenerated]
				set
				{
					this.<Stylist>k__BackingField = value;
				}
			}

			// Token: 0x17000581 RID: 1409
			// (get) Token: 0x06002885 RID: 10373 RVA: 0x00196AC0 File Offset: 0x00194CC0
			// (set) Token: 0x06002886 RID: 10374 RVA: 0x00196AD4 File Offset: 0x00194CD4
			public string TravelingMerchant
			{
				[CompilerGenerated]
				get
				{
					return this.<TravelingMerchant>k__BackingField;
				}
				[CompilerGenerated]
				set
				{
					this.<TravelingMerchant>k__BackingField = value;
				}
			}

			// Token: 0x17000582 RID: 1410
			// (get) Token: 0x06002887 RID: 10375 RVA: 0x00196AE8 File Offset: 0x00194CE8
			// (set) Token: 0x06002888 RID: 10376 RVA: 0x00196AFC File Offset: 0x00194CFC
			public string Angler
			{
				[CompilerGenerated]
				get
				{
					return this.<Angler>k__BackingField;
				}
				[CompilerGenerated]
				set
				{
					this.<Angler>k__BackingField = value;
				}
			}

			// Token: 0x17000583 RID: 1411
			// (get) Token: 0x06002889 RID: 10377 RVA: 0x00196B10 File Offset: 0x00194D10
			// (set) Token: 0x0600288A RID: 10378 RVA: 0x00196B24 File Offset: 0x00194D24
			public string Bartender
			{
				[CompilerGenerated]
				get
				{
					return this.<Bartender>k__BackingField;
				}
				[CompilerGenerated]
				set
				{
					this.<Bartender>k__BackingField = value;
				}
			}

			// Token: 0x17000584 RID: 1412
			// (get) Token: 0x0600288B RID: 10379 RVA: 0x00196B38 File Offset: 0x00194D38
			// (set) Token: 0x0600288C RID: 10380 RVA: 0x00196B4C File Offset: 0x00194D4C
			public string WorldName
			{
				[CompilerGenerated]
				get
				{
					return this.<WorldName>k__BackingField;
				}
				[CompilerGenerated]
				set
				{
					this.<WorldName>k__BackingField = value;
				}
			}

			// Token: 0x17000585 RID: 1413
			// (get) Token: 0x0600288D RID: 10381 RVA: 0x00196B60 File Offset: 0x00194D60
			// (set) Token: 0x0600288E RID: 10382 RVA: 0x00196B74 File Offset: 0x00194D74
			public bool Day
			{
				[CompilerGenerated]
				get
				{
					return this.<Day>k__BackingField;
				}
				[CompilerGenerated]
				set
				{
				}
			}

			// Token: 0x17000586 RID: 1414
			// (get) Token: 0x0600288F RID: 10383 RVA: 0x00196B84 File Offset: 0x00194D84
			// (set) Token: 0x06002890 RID: 10384 RVA: 0x00196B98 File Offset: 0x00194D98
			public bool BloodMoon
			{
				[CompilerGenerated]
				get
				{
					return this.<BloodMoon>k__BackingField;
				}
				[CompilerGenerated]
				set
				{
				}
			}

			// Token: 0x17000587 RID: 1415
			// (get) Token: 0x06002891 RID: 10385 RVA: 0x00196BA8 File Offset: 0x00194DA8
			// (set) Token: 0x06002892 RID: 10386 RVA: 0x00196BBC File Offset: 0x00194DBC
			public bool Eclipse
			{
				[CompilerGenerated]
				get
				{
					return this.<Eclipse>k__BackingField;
				}
				[CompilerGenerated]
				set
				{
				}
			}

			// Token: 0x17000588 RID: 1416
			// (get) Token: 0x06002893 RID: 10387 RVA: 0x00196BCC File Offset: 0x00194DCC
			// (set) Token: 0x06002894 RID: 10388 RVA: 0x00196BE0 File Offset: 0x00194DE0
			public bool MoonLordDefeated
			{
				[CompilerGenerated]
				get
				{
					return this.<MoonLordDefeated>k__BackingField;
				}
				[CompilerGenerated]
				set
				{
				}
			}

			// Token: 0x17000589 RID: 1417
			// (get) Token: 0x06002895 RID: 10389 RVA: 0x00196BF0 File Offset: 0x00194DF0
			// (set) Token: 0x06002896 RID: 10390 RVA: 0x00196C04 File Offset: 0x00194E04
			public bool GolemDefeated
			{
				[CompilerGenerated]
				get
				{
					return this.<GolemDefeated>k__BackingField;
				}
				[CompilerGenerated]
				set
				{
				}
			}

			// Token: 0x1700058A RID: 1418
			// (get) Token: 0x06002897 RID: 10391 RVA: 0x00196C14 File Offset: 0x00194E14
			// (set) Token: 0x06002898 RID: 10392 RVA: 0x00196C28 File Offset: 0x00194E28
			public bool DukeFishronDefeated
			{
				[CompilerGenerated]
				get
				{
					return this.<DukeFishronDefeated>k__BackingField;
				}
				[CompilerGenerated]
				set
				{
				}
			}

			// Token: 0x1700058B RID: 1419
			// (get) Token: 0x06002899 RID: 10393 RVA: 0x00196C38 File Offset: 0x00194E38
			// (set) Token: 0x0600289A RID: 10394 RVA: 0x00196C4C File Offset: 0x00194E4C
			public bool FrostLegionDefeated
			{
				[CompilerGenerated]
				get
				{
					return this.<FrostLegionDefeated>k__BackingField;
				}
				[CompilerGenerated]
				set
				{
				}
			}

			// Token: 0x1700058C RID: 1420
			// (get) Token: 0x0600289B RID: 10395 RVA: 0x00196C5C File Offset: 0x00194E5C
			// (set) Token: 0x0600289C RID: 10396 RVA: 0x00196C70 File Offset: 0x00194E70
			public bool MartiansDefeated
			{
				[CompilerGenerated]
				get
				{
					return this.<MartiansDefeated>k__BackingField;
				}
				[CompilerGenerated]
				set
				{
				}
			}

			// Token: 0x1700058D RID: 1421
			// (get) Token: 0x0600289D RID: 10397 RVA: 0x00196C80 File Offset: 0x00194E80
			// (set) Token: 0x0600289E RID: 10398 RVA: 0x00196C94 File Offset: 0x00194E94
			public bool PumpkingDefeated
			{
				[CompilerGenerated]
				get
				{
					return this.<PumpkingDefeated>k__BackingField;
				}
				[CompilerGenerated]
				set
				{
				}
			}

			// Token: 0x1700058E RID: 1422
			// (get) Token: 0x0600289F RID: 10399 RVA: 0x00196CA4 File Offset: 0x00194EA4
			// (set) Token: 0x060028A0 RID: 10400 RVA: 0x00196CB8 File Offset: 0x00194EB8
			public bool IceQueenDefeated
			{
				[CompilerGenerated]
				get
				{
					return this.<IceQueenDefeated>k__BackingField;
				}
				[CompilerGenerated]
				set
				{
				}
			}

			// Token: 0x1700058F RID: 1423
			// (get) Token: 0x060028A1 RID: 10401 RVA: 0x00196CC8 File Offset: 0x00194EC8
			// (set) Token: 0x060028A2 RID: 10402 RVA: 0x00196CDC File Offset: 0x00194EDC
			public bool HardMode
			{
				[CompilerGenerated]
				get
				{
					return this.<HardMode>k__BackingField;
				}
				[CompilerGenerated]
				set
				{
				}
			}

			// Token: 0x17000590 RID: 1424
			// (get) Token: 0x060028A3 RID: 10403 RVA: 0x00196CEC File Offset: 0x00194EEC
			// (set) Token: 0x060028A4 RID: 10404 RVA: 0x00196D00 File Offset: 0x00194F00
			public bool Homeless
			{
				[CompilerGenerated]
				get
				{
					return this.<Homeless>k__BackingField;
				}
				[CompilerGenerated]
				set
				{
				}
			}

			// Token: 0x17000591 RID: 1425
			// (get) Token: 0x060028A5 RID: 10405 RVA: 0x00196D10 File Offset: 0x00194F10
			// (set) Token: 0x060028A6 RID: 10406 RVA: 0x00196D24 File Offset: 0x00194F24
			public string InventoryKey
			{
				[CompilerGenerated]
				get
				{
					return this.<InventoryKey>k__BackingField;
				}
				[CompilerGenerated]
				set
				{
					this.<InventoryKey>k__BackingField = value;
				}
			}

			// Token: 0x17000592 RID: 1426
			// (get) Token: 0x060028A7 RID: 10407 RVA: 0x00196D38 File Offset: 0x00194F38
			// (set) Token: 0x060028A8 RID: 10408 RVA: 0x00196D4C File Offset: 0x00194F4C
			public string PlayerName
			{
				[CompilerGenerated]
				get
				{
					return this.<PlayerName>k__BackingField;
				}
				[CompilerGenerated]
				set
				{
					this.<PlayerName>k__BackingField = value;
				}
			}

			// Token: 0x17000593 RID: 1427
			// (get) Token: 0x060028A9 RID: 10409 RVA: 0x00196D60 File Offset: 0x00194F60
			// (set) Token: 0x060028AA RID: 10410 RVA: 0x00196D74 File Offset: 0x00194F74
			public string GolfGuy
			{
				[CompilerGenerated]
				get
				{
					return this.<GolfGuy>k__BackingField;
				}
				[CompilerGenerated]
				set
				{
					this.<GolfGuy>k__BackingField = value;
				}
			}

			// Token: 0x17000594 RID: 1428
			// (get) Token: 0x060028AB RID: 10411 RVA: 0x00196D88 File Offset: 0x00194F88
			// (set) Token: 0x060028AC RID: 10412 RVA: 0x00196D9C File Offset: 0x00194F9C
			public string TaxCollector
			{
				[CompilerGenerated]
				get
				{
					return this.<TaxCollector>k__BackingField;
				}
				[CompilerGenerated]
				set
				{
					this.<TaxCollector>k__BackingField = value;
				}
			}

			// Token: 0x17000595 RID: 1429
			// (get) Token: 0x060028AD RID: 10413 RVA: 0x00196DB0 File Offset: 0x00194FB0
			// (set) Token: 0x060028AE RID: 10414 RVA: 0x00196DC4 File Offset: 0x00194FC4
			public bool Rain
			{
				[CompilerGenerated]
				get
				{
					return this.<Rain>k__BackingField;
				}
				[CompilerGenerated]
				set
				{
				}
			}

			// Token: 0x17000596 RID: 1430
			// (get) Token: 0x060028AF RID: 10415 RVA: 0x00196DD4 File Offset: 0x00194FD4
			// (set) Token: 0x060028B0 RID: 10416 RVA: 0x00196DE8 File Offset: 0x00194FE8
			public bool Graveyard
			{
				[CompilerGenerated]
				get
				{
					return this.<Graveyard>k__BackingField;
				}
				[CompilerGenerated]
				set
				{
				}
			}

			// Token: 0x17000597 RID: 1431
			// (get) Token: 0x060028B1 RID: 10417 RVA: 0x00196DF8 File Offset: 0x00194FF8
			// (set) Token: 0x060028B2 RID: 10418 RVA: 0x00196E0C File Offset: 0x0019500C
			public int AnglerCompletedQuestsCount
			{
				[CompilerGenerated]
				get
				{
					return this.<AnglerCompletedQuestsCount>k__BackingField;
				}
				[CompilerGenerated]
				set
				{
					this.<AnglerCompletedQuestsCount>k__BackingField = value;
				}
			}

			// Token: 0x17000598 RID: 1432
			// (get) Token: 0x060028B3 RID: 10419 RVA: 0x00196E20 File Offset: 0x00195020
			// (set) Token: 0x060028B4 RID: 10420 RVA: 0x00196E34 File Offset: 0x00195034
			public int TotalDeathsCount
			{
				[CompilerGenerated]
				get
				{
					return this.<TotalDeathsCount>k__BackingField;
				}
				[CompilerGenerated]
				set
				{
					this.<TotalDeathsCount>k__BackingField = value;
				}
			}

			// Token: 0x17000599 RID: 1433
			// (get) Token: 0x060028B5 RID: 10421 RVA: 0x00196E48 File Offset: 0x00195048
			// (set) Token: 0x060028B6 RID: 10422 RVA: 0x00196E5C File Offset: 0x0019505C
			public string WorldEvilStone
			{
				[CompilerGenerated]
				get
				{
					return this.<WorldEvilStone>k__BackingField;
				}
				[CompilerGenerated]
				set
				{
					this.<WorldEvilStone>k__BackingField = value;
				}
			}

			// Token: 0x1700059A RID: 1434
			// (get) Token: 0x060028B7 RID: 10423 RVA: 0x00196E70 File Offset: 0x00195070
			// (set) Token: 0x060028B8 RID: 10424 RVA: 0x00196E84 File Offset: 0x00195084
			public string InputTriggerUI_BuildFromInventory
			{
				[CompilerGenerated]
				get
				{
					return this.<InputTriggerUI_BuildFromInventory>k__BackingField;
				}
				[CompilerGenerated]
				set
				{
					this.<InputTriggerUI_BuildFromInventory>k__BackingField = value;
				}
			}

			// Token: 0x1700059B RID: 1435
			// (get) Token: 0x060028B9 RID: 10425 RVA: 0x00196E98 File Offset: 0x00195098
			// (set) Token: 0x060028BA RID: 10426 RVA: 0x00196EAC File Offset: 0x001950AC
			public string InputTriggerUI_SellItem
			{
				[CompilerGenerated]
				get
				{
					return this.<InputTriggerUI_SellItem>k__BackingField;
				}
				[CompilerGenerated]
				set
				{
					this.<InputTriggerUI_SellItem>k__BackingField = value;
				}
			}

			// Token: 0x1700059C RID: 1436
			// (get) Token: 0x060028BB RID: 10427 RVA: 0x00196EC0 File Offset: 0x001950C0
			// (set) Token: 0x060028BC RID: 10428 RVA: 0x00196ED4 File Offset: 0x001950D4
			public string InputTriggerUI_Trash
			{
				[CompilerGenerated]
				get
				{
					return this.<InputTriggerUI_Trash>k__BackingField;
				}
				[CompilerGenerated]
				set
				{
					this.<InputTriggerUI_Trash>k__BackingField = value;
				}
			}

			// Token: 0x1700059D RID: 1437
			// (get) Token: 0x060028BD RID: 10429 RVA: 0x00196EE8 File Offset: 0x001950E8
			// (set) Token: 0x060028BE RID: 10430 RVA: 0x00196EFC File Offset: 0x001950FC
			public string InputTriggerUI_FavoriteItem
			{
				[CompilerGenerated]
				get
				{
					return this.<InputTriggerUI_FavoriteItem>k__BackingField;
				}
				[CompilerGenerated]
				set
				{
					this.<InputTriggerUI_FavoriteItem>k__BackingField = value;
				}
			}

			// Token: 0x1700059E RID: 1438
			// (get) Token: 0x060028BF RID: 10431 RVA: 0x00196F10 File Offset: 0x00195110
			// (set) Token: 0x060028C0 RID: 10432 RVA: 0x00196F24 File Offset: 0x00195124
			public string InputTriggerUI_ZoomIn
			{
				[CompilerGenerated]
				get
				{
					return this.<InputTriggerUI_ZoomIn>k__BackingField;
				}
				[CompilerGenerated]
				set
				{
					this.<InputTriggerUI_ZoomIn>k__BackingField = value;
				}
			}

			// Token: 0x1700059F RID: 1439
			// (get) Token: 0x060028C1 RID: 10433 RVA: 0x00196F38 File Offset: 0x00195138
			// (set) Token: 0x060028C2 RID: 10434 RVA: 0x00196F4C File Offset: 0x0019514C
			public string InputTriggerUI_ZoomOut
			{
				[CompilerGenerated]
				get
				{
					return this.<InputTriggerUI_ZoomOut>k__BackingField;
				}
				[CompilerGenerated]
				set
				{
					this.<InputTriggerUI_ZoomOut>k__BackingField = value;
				}
			}

			// Token: 0x170005A0 RID: 1440
			// (get) Token: 0x060028C3 RID: 10435 RVA: 0x00196F60 File Offset: 0x00195160
			// (set) Token: 0x060028C4 RID: 10436 RVA: 0x00196F74 File Offset: 0x00195174
			public string InputTrigger_QuickEquip
			{
				[CompilerGenerated]
				get
				{
					return this.<InputTrigger_QuickEquip>k__BackingField;
				}
				[CompilerGenerated]
				set
				{
					this.<InputTrigger_QuickEquip>k__BackingField = value;
				}
			}

			// Token: 0x170005A1 RID: 1441
			// (get) Token: 0x060028C5 RID: 10437 RVA: 0x00196F88 File Offset: 0x00195188
			// (set) Token: 0x060028C6 RID: 10438 RVA: 0x00196F9C File Offset: 0x0019519C
			public string InputTrigger_LockOn
			{
				[CompilerGenerated]
				get
				{
					return this.<InputTrigger_LockOn>k__BackingField;
				}
				[CompilerGenerated]
				set
				{
					this.<InputTrigger_LockOn>k__BackingField = value;
				}
			}

			// Token: 0x170005A2 RID: 1442
			// (get) Token: 0x060028C7 RID: 10439 RVA: 0x00196FB0 File Offset: 0x001951B0
			// (set) Token: 0x060028C8 RID: 10440 RVA: 0x00196FC4 File Offset: 0x001951C4
			public string InputTrigger_SmartCursor
			{
				[CompilerGenerated]
				get
				{
					return this.<InputTrigger_SmartCursor>k__BackingField;
				}
				[CompilerGenerated]
				set
				{
					this.<InputTrigger_SmartCursor>k__BackingField = value;
				}
			}

			// Token: 0x170005A3 RID: 1443
			// (get) Token: 0x060028C9 RID: 10441 RVA: 0x00196FD8 File Offset: 0x001951D8
			// (set) Token: 0x060028CA RID: 10442 RVA: 0x00196FEC File Offset: 0x001951EC
			public string InputTrigger_UseOrAttack
			{
				[CompilerGenerated]
				get
				{
					return this.<InputTrigger_UseOrAttack>k__BackingField;
				}
				[CompilerGenerated]
				set
				{
					this.<InputTrigger_UseOrAttack>k__BackingField = value;
				}
			}

			// Token: 0x170005A4 RID: 1444
			// (get) Token: 0x060028CB RID: 10443 RVA: 0x00197000 File Offset: 0x00195200
			// (set) Token: 0x060028CC RID: 10444 RVA: 0x00197014 File Offset: 0x00195214
			public string InputTrigger_InteractWithTile
			{
				[CompilerGenerated]
				get
				{
					return this.<InputTrigger_InteractWithTile>k__BackingField;
				}
				[CompilerGenerated]
				set
				{
					this.<InputTrigger_InteractWithTile>k__BackingField = value;
				}
			}

			// Token: 0x170005A5 RID: 1445
			// (get) Token: 0x060028CD RID: 10445 RVA: 0x00197028 File Offset: 0x00195228
			// (set) Token: 0x060028CE RID: 10446 RVA: 0x0019703C File Offset: 0x0019523C
			public string InputTrigger_SmartSelect
			{
				[CompilerGenerated]
				get
				{
					return this.<InputTrigger_SmartSelect>k__BackingField;
				}
				[CompilerGenerated]
				set
				{
					this.<InputTrigger_SmartSelect>k__BackingField = value;
				}
			}

			// Token: 0x060028CF RID: 10447 RVA: 0x00197050 File Offset: 0x00195250
			public SubstitutionsObject()
			{
			}

			// Token: 0x04003574 RID: 13684
			[CompilerGenerated]
			private string <Nurse>k__BackingField;

			// Token: 0x04003575 RID: 13685
			[CompilerGenerated]
			private string <Merchant>k__BackingField;

			// Token: 0x04003576 RID: 13686
			[CompilerGenerated]
			private string <ArmsDealer>k__BackingField;

			// Token: 0x04003577 RID: 13687
			[CompilerGenerated]
			private string <Dryad>k__BackingField;

			// Token: 0x04003578 RID: 13688
			[CompilerGenerated]
			private string <Demolitionist>k__BackingField;

			// Token: 0x04003579 RID: 13689
			[CompilerGenerated]
			private string <Clothier>k__BackingField;

			// Token: 0x0400357A RID: 13690
			[CompilerGenerated]
			private string <Guide>k__BackingField;

			// Token: 0x0400357B RID: 13691
			[CompilerGenerated]
			private string <Wizard>k__BackingField;

			// Token: 0x0400357C RID: 13692
			[CompilerGenerated]
			private string <GoblinTinkerer>k__BackingField;

			// Token: 0x0400357D RID: 13693
			[CompilerGenerated]
			private string <Mechanic>k__BackingField;

			// Token: 0x0400357E RID: 13694
			[CompilerGenerated]
			private string <Truffle>k__BackingField;

			// Token: 0x0400357F RID: 13695
			[CompilerGenerated]
			private string <Steampunker>k__BackingField;

			// Token: 0x04003580 RID: 13696
			[CompilerGenerated]
			private string <DyeTrader>k__BackingField;

			// Token: 0x04003581 RID: 13697
			[CompilerGenerated]
			private string <PartyGirl>k__BackingField;

			// Token: 0x04003582 RID: 13698
			[CompilerGenerated]
			private string <Cyborg>k__BackingField;

			// Token: 0x04003583 RID: 13699
			[CompilerGenerated]
			private string <Painter>k__BackingField;

			// Token: 0x04003584 RID: 13700
			[CompilerGenerated]
			private string <WitchDoctor>k__BackingField;

			// Token: 0x04003585 RID: 13701
			[CompilerGenerated]
			private string <Pirate>k__BackingField;

			// Token: 0x04003586 RID: 13702
			[CompilerGenerated]
			private string <Stylist>k__BackingField;

			// Token: 0x04003587 RID: 13703
			[CompilerGenerated]
			private string <TravelingMerchant>k__BackingField;

			// Token: 0x04003588 RID: 13704
			[CompilerGenerated]
			private string <Angler>k__BackingField;

			// Token: 0x04003589 RID: 13705
			[CompilerGenerated]
			private string <Bartender>k__BackingField;

			// Token: 0x0400358A RID: 13706
			[CompilerGenerated]
			private string <WorldName>k__BackingField;

			// Token: 0x0400358B RID: 13707
			[CompilerGenerated]
			private bool <Day>k__BackingField;

			// Token: 0x0400358C RID: 13708
			[CompilerGenerated]
			private bool <BloodMoon>k__BackingField;

			// Token: 0x0400358D RID: 13709
			[CompilerGenerated]
			private bool <Eclipse>k__BackingField;

			// Token: 0x0400358E RID: 13710
			[CompilerGenerated]
			private bool <MoonLordDefeated>k__BackingField;

			// Token: 0x0400358F RID: 13711
			[CompilerGenerated]
			private bool <GolemDefeated>k__BackingField;

			// Token: 0x04003590 RID: 13712
			[CompilerGenerated]
			private bool <DukeFishronDefeated>k__BackingField;

			// Token: 0x04003591 RID: 13713
			[CompilerGenerated]
			private bool <FrostLegionDefeated>k__BackingField;

			// Token: 0x04003592 RID: 13714
			[CompilerGenerated]
			private bool <MartiansDefeated>k__BackingField;

			// Token: 0x04003593 RID: 13715
			[CompilerGenerated]
			private bool <PumpkingDefeated>k__BackingField;

			// Token: 0x04003594 RID: 13716
			[CompilerGenerated]
			private bool <IceQueenDefeated>k__BackingField;

			// Token: 0x04003595 RID: 13717
			[CompilerGenerated]
			private bool <HardMode>k__BackingField;

			// Token: 0x04003596 RID: 13718
			[CompilerGenerated]
			private bool <Homeless>k__BackingField;

			// Token: 0x04003597 RID: 13719
			[CompilerGenerated]
			private string <InventoryKey>k__BackingField;

			// Token: 0x04003598 RID: 13720
			[CompilerGenerated]
			private string <PlayerName>k__BackingField;

			// Token: 0x04003599 RID: 13721
			[CompilerGenerated]
			private string <GolfGuy>k__BackingField;

			// Token: 0x0400359A RID: 13722
			[CompilerGenerated]
			private string <TaxCollector>k__BackingField;

			// Token: 0x0400359B RID: 13723
			[CompilerGenerated]
			private bool <Rain>k__BackingField;

			// Token: 0x0400359C RID: 13724
			[CompilerGenerated]
			private bool <Graveyard>k__BackingField;

			// Token: 0x0400359D RID: 13725
			[CompilerGenerated]
			private int <AnglerCompletedQuestsCount>k__BackingField;

			// Token: 0x0400359E RID: 13726
			[CompilerGenerated]
			private int <TotalDeathsCount>k__BackingField;

			// Token: 0x0400359F RID: 13727
			[CompilerGenerated]
			private string <WorldEvilStone>k__BackingField;

			// Token: 0x040035A0 RID: 13728
			[CompilerGenerated]
			private string <InputTriggerUI_BuildFromInventory>k__BackingField;

			// Token: 0x040035A1 RID: 13729
			[CompilerGenerated]
			private string <InputTriggerUI_SellItem>k__BackingField;

			// Token: 0x040035A2 RID: 13730
			[CompilerGenerated]
			private string <InputTriggerUI_Trash>k__BackingField;

			// Token: 0x040035A3 RID: 13731
			[CompilerGenerated]
			private string <InputTriggerUI_FavoriteItem>k__BackingField;

			// Token: 0x040035A4 RID: 13732
			[CompilerGenerated]
			private string <InputTriggerUI_ZoomIn>k__BackingField;

			// Token: 0x040035A5 RID: 13733
			[CompilerGenerated]
			private string <InputTriggerUI_ZoomOut>k__BackingField;

			// Token: 0x040035A6 RID: 13734
			[CompilerGenerated]
			private string <InputTrigger_QuickEquip>k__BackingField;

			// Token: 0x040035A7 RID: 13735
			[CompilerGenerated]
			private string <InputTrigger_LockOn>k__BackingField;

			// Token: 0x040035A8 RID: 13736
			[CompilerGenerated]
			private string <InputTrigger_SmartCursor>k__BackingField;

			// Token: 0x040035A9 RID: 13737
			[CompilerGenerated]
			private string <InputTrigger_UseOrAttack>k__BackingField;

			// Token: 0x040035AA RID: 13738
			[CompilerGenerated]
			private string <InputTrigger_InteractWithTile>k__BackingField;

			// Token: 0x040035AB RID: 13739
			[CompilerGenerated]
			private string <InputTrigger_SmartSelect>k__BackingField;
		}

		// Token: 0x02000438 RID: 1080
		[CompilerGenerated]
		private sealed class <>c__DisplayClass48_0
		{
			// Token: 0x060028D0 RID: 10448 RVA: 0x00197064 File Offset: 0x00195264
			public <>c__DisplayClass48_0()
			{
			}

			// Token: 0x060028D1 RID: 10449 RVA: 0x00197078 File Offset: 0x00195278
			internal bool <CreateDialogFilter>b__0(string key, LocalizedText text)
			{
				string text2 = this.startsWith;
				bool flag = key.StartsWith(text2);
				object obj = this.substitutions;
				return text.CanFormatWith(obj);
			}

			// Token: 0x040035AC RID: 13740
			public string startsWith;

			// Token: 0x040035AD RID: 13741
			public object substitutions;
		}

		// Token: 0x02000439 RID: 1081
		[CompilerGenerated]
		private sealed class <>c__DisplayClass49_0
		{
			// Token: 0x060028D2 RID: 10450 RVA: 0x001970A4 File Offset: 0x001952A4
			public <>c__DisplayClass49_0()
			{
			}

			// Token: 0x060028D3 RID: 10451 RVA: 0x001970B8 File Offset: 0x001952B8
			internal bool <CreateDialogFilter>b__0(string key, LocalizedText text)
			{
				string text2 = this.startsWith;
				return key.StartsWith(text2);
			}

			// Token: 0x040035AE RID: 13742
			public string startsWith;
		}

		// Token: 0x0200043A RID: 1082
		[CompilerGenerated]
		private sealed class <>c__DisplayClass52_0<IdClass, IdType> where IdType : IConvertible
		{
			// Token: 0x060028D4 RID: 10452 RVA: 0x001970D4 File Offset: 0x001952D4
			public <>c__DisplayClass52_0()
			{
			}

			// Token: 0x060028D5 RID: 10453 RVA: 0x001970E8 File Offset: 0x001952E8
			internal void <FillNameCacheArray>b__1(FieldInfo field)
			{
				LocalizedText[] array = this.nameCache;
				if (this.leaveMissingEntriesBlank)
				{
					string text;
					bool flag = Language.Exists(text);
				}
				string text2;
				if (Language.GetText(text2) == null)
				{
					return;
				}
			}

			// Token: 0x040035AF RID: 13743
			public LocalizedText[] nameCache;

			// Token: 0x040035B0 RID: 13744
			public bool leaveMissingEntriesBlank;

			// Token: 0x040035B1 RID: 13745
			public string category;
		}

		// Token: 0x0200043B RID: 1083
		[CompilerGenerated]
		[Serializable]
		private sealed class <>c__52<IdClass, IdType> where IdType : IConvertible
		{
			// Token: 0x060028D6 RID: 10454 RVA: 0x00197130 File Offset: 0x00195330
			// Note: this type is marked as 'beforefieldinit'.
			static <>c__52()
			{
			}

			// Token: 0x060028D7 RID: 10455 RVA: 0x00197140 File Offset: 0x00195340
			public <>c__52()
			{
			}

			// Token: 0x060028D8 RID: 10456 RVA: 0x00197154 File Offset: 0x00195354
			internal bool <FillNameCacheArray>b__52_0(FieldInfo f)
			{
				bool flag;
				return flag;
			}

			// Token: 0x040035B2 RID: 13746
			public static readonly Lang.<>c__52<IdClass, IdType> <>9;

			// Token: 0x040035B3 RID: 13747
			public static Func<FieldInfo, bool> <>9__52_0;
		}

		// Token: 0x0200043C RID: 1084
		[CompilerGenerated]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x060028D9 RID: 10457 RVA: 0x00197164 File Offset: 0x00195364
			// Note: this type is marked as 'beforefieldinit'.
			static <>c()
			{
			}

			// Token: 0x060028DA RID: 10458 RVA: 0x00197174 File Offset: 0x00195374
			public <>c()
			{
			}

			// Token: 0x060028DB RID: 10459 RVA: 0x00197188 File Offset: 0x00195388
			internal bool <InitializeLegacyLocalization>b__54_0(FieldInfo f)
			{
				bool flag;
				return flag;
			}

			// Token: 0x060028DC RID: 10460 RVA: 0x00197198 File Offset: 0x00195398
			internal void <InitializeLegacyLocalization>b__54_1(FieldInfo field)
			{
				ItemTooltip itemTooltip;
				if (itemTooltip == null || itemTooltip != null)
				{
					return;
				}
				throw new ArrayTypeMismatchException();
			}

			// Token: 0x040035B4 RID: 13748
			public static readonly Lang.<>c <>9;

			// Token: 0x040035B5 RID: 13749
			public static Func<FieldInfo, bool> <>9__54_0;

			// Token: 0x040035B6 RID: 13750
			public static Action<FieldInfo> <>9__54_1;
		}
	}
}
