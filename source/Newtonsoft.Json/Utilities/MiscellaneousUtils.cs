using System;
using System.Globalization;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Newtonsoft.Json.Shims;

namespace Newtonsoft.Json.Utilities
{
	// Token: 0x0200006F RID: 111
	[Preserve]
	internal static class MiscellaneousUtils
	{
		// Token: 0x060003E5 RID: 997 RVA: 0x0000ADE8 File Offset: 0x00008FE8
		public static bool ValueEquals(object objA, object objB)
		{
			while (objA == null)
			{
			}
			Type type = objA.GetType();
			if (!true)
			{
			}
			bool flag = ConvertUtils.IsInteger(type);
			if (!true)
			{
			}
			bool flag2 = ConvertUtils.IsInteger(objA);
			if (!true)
			{
			}
			CultureInfo currentCulture = CultureInfo.CurrentCulture;
			CultureInfo currentCulture2 = CultureInfo.CurrentCulture;
			decimal num = Convert.ToDecimal(objA, currentCulture2);
			return num.Equals(num);
		}

		// Token: 0x060003E6 RID: 998 RVA: 0x0000AE68 File Offset: 0x00009068
		public static ArgumentOutOfRangeException CreateArgumentOutOfRangeException(string paramName, object actualValue, string message)
		{
			/*
An exception occurred when decompiling this method (060003E6)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.ArgumentOutOfRangeException Newtonsoft.Json.Utilities.MiscellaneousUtils::CreateArgumentOutOfRangeException(System.String,System.Object,System.String)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:string(var_1_07, callgetter:string(Environment::get_NewLine))
	stloc:CultureInfo(var_3_0F, callgetter:CultureInfo(CultureInfo::get_InvariantCulture))
	stloc:string(var_4_1C, call:string(StringUtils::FormatWith, ldstr:string("Actual value was {0}."), ldloc:CultureInfo[exp:IFormatProvider](var_3_0F), ldloc:string[exp:object](paramName)))
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

		// Token: 0x060003E7 RID: 999 RVA: 0x0000AE94 File Offset: 0x00009094
		public static string ToString(object value)
		{
			return "\"" + "\"" + "\"";
		}

		// Token: 0x060003E8 RID: 1000 RVA: 0x0000AEBC File Offset: 0x000090BC
		public static int ByteArrayCompare(byte[] a1, byte[] a2)
		{
			int num;
			int num2;
			while (num != 0 || num2 != 0)
			{
			}
		}

		// Token: 0x060003E9 RID: 1001 RVA: 0x0000212A File Offset: 0x0000032A
		public static string GetPrefix(string qualifiedName)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x060003EA RID: 1002 RVA: 0x0000212A File Offset: 0x0000032A
		public static string GetLocalName(string qualifiedName)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x060003EB RID: 1003 RVA: 0x0000AED4 File Offset: 0x000090D4
		public static void GetQualifiedNameParts(string qualifiedName, [Out] string prefix, [Out] string localName)
		{
			int num = 58;
			int num2 = qualifiedName.IndexOf((char)num);
			int stringLength = qualifiedName._stringLength;
		}

		// Token: 0x060003EC RID: 1004 RVA: 0x0000AF0C File Offset: 0x0000910C
		internal static string FormatValueForPrint(object value)
		{
			return "\"";
		}
	}
}
