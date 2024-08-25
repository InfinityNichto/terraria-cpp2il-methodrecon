using System;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using Terraria.Utilities;

namespace Terraria.Localization
{
	// Token: 0x02000556 RID: 1366
	public static class Language
	{
		// Token: 0x17000669 RID: 1641
		// (get) Token: 0x06003308 RID: 13064 RVA: 0x001FE520 File Offset: 0x001FC720
		public static GameCulture ActiveCulture
		{
			get
			{
				/*
An exception occurred when decompiling this method (06003308)

ICSharpCode.Decompiler.DecompilerException: Error decompiling Terraria.Localization.GameCulture Terraria.Localization.Language::get_ActiveCulture()

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

		// Token: 0x06003309 RID: 13065 RVA: 0x001FE530 File Offset: 0x001FC730
		public static LocalizedText GetText(string key)
		{
			if (!true)
			{
			}
			LocalizedText localizedText;
			return localizedText;
		}

		// Token: 0x0600330A RID: 13066 RVA: 0x001FE544 File Offset: 0x001FC744
		public static string GetTextValue(string key)
		{
			if (!true)
			{
			}
			string text;
			return text;
		}

		// Token: 0x0600330B RID: 13067 RVA: 0x001FE558 File Offset: 0x001FC758
		public static string GetTextValue(string key, object arg0)
		{
			if (!true)
			{
			}
			string text;
			return text;
		}

		// Token: 0x0600330C RID: 13068 RVA: 0x001FE56C File Offset: 0x001FC76C
		public static string GetTextValue(string key, object arg0, object arg1)
		{
			if (!true)
			{
			}
			string text;
			return text;
		}

		// Token: 0x0600330D RID: 13069 RVA: 0x001FE580 File Offset: 0x001FC780
		public static string GetTextValue(string key, object arg0, object arg1, object arg2)
		{
			if (!true)
			{
			}
			string text;
			return text;
		}

		// Token: 0x0600330E RID: 13070 RVA: 0x001FE594 File Offset: 0x001FC794
		public static string GetTextValue(string key, params object[] args)
		{
			if (!true)
			{
			}
			string text;
			return text;
		}

		// Token: 0x0600330F RID: 13071 RVA: 0x001FE5A8 File Offset: 0x001FC7A8
		public static string GetTextValueWith(string key, object obj)
		{
			if (!true)
			{
			}
			LocalizedText localizedText;
			return localizedText.FormatWith(key);
		}

		// Token: 0x06003310 RID: 13072 RVA: 0x001FE5C0 File Offset: 0x001FC7C0
		public static StringBuilder GetTextValueWith(string key, object obj, StringBuilder sb)
		{
			if (!true)
			{
			}
			StringBuilder stringBuilder;
			return stringBuilder;
		}

		// Token: 0x06003311 RID: 13073 RVA: 0x001FE5D4 File Offset: 0x001FC7D4
		public static bool Exists(string key)
		{
			if (!true)
			{
			}
			bool flag;
			return flag;
		}

		// Token: 0x06003312 RID: 13074 RVA: 0x001FE5E8 File Offset: 0x001FC7E8
		public static int GetCategorySize(string key)
		{
			if (!true)
			{
			}
			int num;
			return num;
		}

		// Token: 0x06003313 RID: 13075 RVA: 0x001FE5FC File Offset: 0x001FC7FC
		public static LocalizedText[] FindAll(Regex regex)
		{
			if (!true)
			{
			}
			LocalizedText[] array;
			return array;
		}

		// Token: 0x06003314 RID: 13076 RVA: 0x001FE610 File Offset: 0x001FC810
		public static LocalizedText[] FindAll(LanguageSearchFilter filter)
		{
			if (!true)
			{
			}
			LocalizedText[] array;
			return array;
		}

		// Token: 0x06003315 RID: 13077 RVA: 0x001FE624 File Offset: 0x001FC824
		public static LocalizedText[] FindAll(string categoryName)
		{
			if (!true)
			{
			}
			LocalizedText[] array;
			return array;
		}

		// Token: 0x06003316 RID: 13078 RVA: 0x001FE638 File Offset: 0x001FC838
		public static LocalizedText SelectRandom(LanguageSearchFilter filter, [Optional] UnifiedRandom random)
		{
			if (!true)
			{
			}
			LocalizedText localizedText;
			return localizedText;
		}

		// Token: 0x06003317 RID: 13079 RVA: 0x001FE64C File Offset: 0x001FC84C
		public static LocalizedText RandomFromCategory(string categoryName, [Optional] UnifiedRandom random)
		{
			if (!true)
			{
			}
			LocalizedText localizedText;
			return localizedText;
		}

		// Token: 0x04003C19 RID: 15385
		public const char NodeKeySeperator = '*';
	}
}
