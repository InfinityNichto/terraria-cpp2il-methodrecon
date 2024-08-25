using System;
using System.Collections;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;

namespace System.Net
{
	// Token: 0x02000209 RID: 521
	internal abstract class WebProxyDataBuilder
	{
		// Token: 0x06000CB1 RID: 3249 RVA: 0x000287DC File Offset: 0x000269DC
		public WebProxyData Build()
		{
			return this.m_Result;
		}

		// Token: 0x06000CB2 RID: 3250
		protected abstract void BuildInternal();

		// Token: 0x06000CB3 RID: 3251 RVA: 0x000287F0 File Offset: 0x000269F0
		protected void SetProxyAndBypassList(string addressString, string bypassListString)
		{
			if (addressString != null)
			{
				string text = addressString.Trim();
				WebProxyData result = this.m_Result;
				Hashtable hashtable = WebProxyDataBuilder.ParseProtocolProxies(text);
				result.proxyHostAddresses = hashtable;
				if (bypassListString == null)
				{
					return;
				}
				string text2 = bypassListString.Trim();
				WebProxyData result2 = this.m_Result;
				ArrayList arrayList = WebProxyDataBuilder.ParseBypassList(text2, true);
				result2.bypassList = arrayList;
				WebProxyData result3 = this.m_Result;
			}
		}

		// Token: 0x06000CB4 RID: 3252 RVA: 0x00028860 File Offset: 0x00026A60
		protected void SetAutoProxyUrl(string autoConfigUrl)
		{
			bool flag = string.IsNullOrEmpty(autoConfigUrl);
		}

		// Token: 0x06000CB5 RID: 3253 RVA: 0x00028874 File Offset: 0x00026A74
		protected void SetAutoDetectSettings(bool value)
		{
			WebProxyData result = this.m_Result;
		}

		// Token: 0x06000CB6 RID: 3254 RVA: 0x00028888 File Offset: 0x00026A88
		private static global::System.Uri ParseProxyUri(string proxyString)
		{
			/*
An exception occurred when decompiling this method (06000CB6)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Uri System.Net.WebProxyDataBuilder::ParseProxyUri(System.String)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:string(var_1_0F, call:string(string::Concat, ldstr:string("http://"), ldstr:string("://")))
	stloc:bool(var_3_17, callgetter:bool(Logging::get_On))
	stloc:FormatException(var_4_1E, call:FormatException(WebProxyDataBuilder::CreateInvalidProxyStringException, ldloc:string(var_1_0F)))
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

		// Token: 0x06000CB7 RID: 3255 RVA: 0x000288B8 File Offset: 0x00026AB8
		private static Hashtable ParseProtocolProxies(string proxyListString)
		{
			string[] array;
			string text = array.Trim();
			if (text == null || text != null)
			{
				string text2 = text.Trim();
				if (text2 == null || text2 != null)
				{
				}
			}
			throw new ArrayTypeMismatchException();
		}

		// Token: 0x06000CB8 RID: 3256 RVA: 0x000288F0 File Offset: 0x00026AF0
		private static FormatException CreateInvalidProxyStringException(string originalProxyString)
		{
			bool on = Logging.On;
			throw new ArrayTypeMismatchException();
		}

		// Token: 0x06000CB9 RID: 3257 RVA: 0x0002890C File Offset: 0x00026B0C
		private static string BypassStringEscape(string rawString)
		{
			global::System.Text.RegularExpressions.Match match;
			bool success = match.Success;
			global::System.Text.RegularExpressions.Group group;
			string value = group.Value;
			global::System.Text.RegularExpressions.Group group2;
			string value2 = group2.Value;
			global::System.Text.RegularExpressions.Group group3;
			return group3.Value;
		}

		// Token: 0x06000CBA RID: 3258 RVA: 0x00028968 File Offset: 0x00026B68
		private static string ConvertRegexReservedChars(string rawString)
		{
			while (!true)
			{
			}
		}

		// Token: 0x06000CBB RID: 3259 RVA: 0x0002897C File Offset: 0x00026B7C
		private static ArrayList ParseBypassList(string bypassListString, [Out] bool bypassOnLocal)
		{
			/*
An exception occurred when decompiling this method (06000CBB)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Collections.ArrayList System.Net.WebProxyDataBuilder::ParseBypassList(System.String,System.Boolean)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_2:
	stloc:string(var_7_28, call:string(WebProxyDataBuilder::BypassStringEscape, ldloc:string(var_4_12)))
	brtrue(IL_0000, ldloc:int64[exp:bool](var_2_06))
}

   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1852
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1878
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1878
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1846
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1878
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1878
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1846
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

		// Token: 0x06000CBC RID: 3260 RVA: 0x000289B8 File Offset: 0x00026BB8
		protected WebProxyDataBuilder()
		{
		}

		// Token: 0x04000ADA RID: 2778
		private const char addressListDelimiter = ';';

		// Token: 0x04000ADB RID: 2779
		private const char addressListSchemeValueDelimiter = '=';

		// Token: 0x04000ADC RID: 2780
		private const char bypassListDelimiter = ';';

		// Token: 0x04000ADD RID: 2781
		private WebProxyData m_Result;

		// Token: 0x04000ADE RID: 2782
		private const string regexReserved = "#$()+.?[\\^{|";
	}
}
