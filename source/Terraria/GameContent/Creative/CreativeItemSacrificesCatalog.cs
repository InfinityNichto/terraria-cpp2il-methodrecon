using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;
using UnityEngine;

namespace Terraria.GameContent.Creative
{
	// Token: 0x02000A0D RID: 2573
	public class CreativeItemSacrificesCatalog
	{
		// Token: 0x17000873 RID: 2163
		// (get) Token: 0x06004BFC RID: 19452 RVA: 0x00270BB4 File Offset: 0x0026EDB4
		public Dictionary<int, int> SacrificeCountNeededByItemId
		{
			get
			{
				return this._sacrificeCountNeededByItemId;
			}
		}

		// Token: 0x06004BFD RID: 19453 RVA: 0x00270BC8 File Offset: 0x0026EDC8
		public void Initialize()
		{
			Dictionary<int, int> sacrificeCountNeededByItemId = this._sacrificeCountNeededByItemId;
			string[] array = Regex.Split(Resources.Load<TextAsset>("Content/Sacrifices").text, "\r\n|\r|\n");
			string text;
			uint num = <PrivateImplementationDetails>.ComputeStringHash(text);
			bool flag = text == "e";
		}

		// Token: 0x06004BFE RID: 19454 RVA: 0x00270D90 File Offset: 0x0026EF90
		public bool TryGetSacrificeCountCapToUnlockInfiniteItems(int itemId, [Out] int amountNeeded)
		{
			/*
An exception occurred when decompiling this method (06004BFE)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean Terraria.GameContent.Creative.CreativeItemSacrificesCatalog::TryGetSacrificeCountCapToUnlockInfiniteItems(System.Int32,System.Int32)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0003:
	stloc:class [mscorlib]System.Collections.Generic.Dictionary`2<int32, int32>(var_0_09, ldfld:class [mscorlib]System.Collections.Generic.Dictionary`2<int32, int32>(CreativeItemSacrificesCatalog::_sacrificeCountNeededByItemId, ldloc:CreativeItemSacrificesCatalog(this)))
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

		// Token: 0x06004BFF RID: 19455 RVA: 0x00270DA8 File Offset: 0x0026EFA8
		public CreativeItemSacrificesCatalog()
		{
		}

		// Token: 0x06004C00 RID: 19456 RVA: 0x00270DBC File Offset: 0x0026EFBC
		// Note: this type is marked as 'beforefieldinit'.
		static CreativeItemSacrificesCatalog()
		{
		}

		// Token: 0x0400861D RID: 34333
		public static CreativeItemSacrificesCatalog Instance;

		// Token: 0x0400861E RID: 34334
		private Dictionary<int, int> _sacrificeCountNeededByItemId;
	}
}
