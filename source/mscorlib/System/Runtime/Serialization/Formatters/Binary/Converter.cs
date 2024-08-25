using System;
using System.Globalization;
using System.Reflection;
using System.Runtime.InteropServices;

namespace System.Runtime.Serialization.Formatters.Binary
{
	// Token: 0x02000415 RID: 1045
	internal sealed class Converter
	{
		// Token: 0x06002030 RID: 8240 RVA: 0x00046ED0 File Offset: 0x000450D0
		internal static InternalPrimitiveTypeE ToCode(Type type)
		{
			TypeCode typeCode;
			return Converter.ToPrimitiveTypeEnum(typeCode);
		}

		// Token: 0x06002031 RID: 8241 RVA: 0x00046EEC File Offset: 0x000450EC
		internal static bool IsWriteAsByteArray(InternalPrimitiveTypeE code)
		{
		}

		// Token: 0x06002032 RID: 8242 RVA: 0x00046EFC File Offset: 0x000450FC
		internal static int TypeLength(InternalPrimitiveTypeE code)
		{
		}

		// Token: 0x06002033 RID: 8243 RVA: 0x00046F0C File Offset: 0x0004510C
		internal static Type ToArrayType(InternalPrimitiveTypeE code)
		{
			/*
An exception occurred when decompiling this method (06002033)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Type System.Runtime.Serialization.Formatters.Binary.Converter::ToArrayType(System.Runtime.Serialization.Formatters.Binary.InternalPrimitiveTypeE)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0008:
	call:void(Converter::InitArrayTypeA)
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

		// Token: 0x06002034 RID: 8244 RVA: 0x00046F28 File Offset: 0x00045128
		private static void InitTypeA()
		{
			if (!true)
			{
			}
		}

		// Token: 0x06002035 RID: 8245 RVA: 0x00046F40 File Offset: 0x00045140
		private static void InitArrayTypeA()
		{
			if (!true)
			{
			}
		}

		// Token: 0x06002036 RID: 8246 RVA: 0x00046F58 File Offset: 0x00045158
		internal static Type ToType(InternalPrimitiveTypeE code)
		{
			/*
An exception occurred when decompiling this method (06002036)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Type System.Runtime.Serialization.Formatters.Binary.Converter::ToType(System.Runtime.Serialization.Formatters.Binary.InternalPrimitiveTypeE)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0008:
	call:void(Converter::InitTypeA)
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

		// Token: 0x06002037 RID: 8247 RVA: 0x00046F74 File Offset: 0x00045174
		internal static Array CreatePrimitiveArray(InternalPrimitiveTypeE code, int length)
		{
		}

		// Token: 0x06002038 RID: 8248 RVA: 0x00046F84 File Offset: 0x00045184
		internal static bool IsPrimitiveArray(Type type, [Out] object typeInformation)
		{
			if (!true)
			{
			}
			return true;
		}

		// Token: 0x06002039 RID: 8249 RVA: 0x00046F98 File Offset: 0x00045198
		private static void InitValueA()
		{
			if (!true)
			{
			}
			if (("Boolean" == null || "Boolean" != null) && ("Byte" == null || "Byte" != null) && ("Char" == null || "Char" != null) && ("Decimal" == null || "Decimal" != null) && ("Double" == null || "Double" != null) && ("Int16" == null || "Int16" != null) && ("Int32" == null || "Int32" != null) && ("Int64" == null || "Int64" != null) && ("SByte" == null || "SByte" != null) && ("Single" == null || "Single" != null) && ("TimeSpan" == null || "TimeSpan" != null) && ("DateTime" == null || "DateTime" != null) && ("UInt16" == null || "UInt16" != null) && ("UInt32" == null || "UInt32" != null) && ("UInt64" == null || "UInt64" != null))
			{
				return;
			}
			throw new ArrayTypeMismatchException();
		}

		// Token: 0x0600203A RID: 8250 RVA: 0x00047098 File Offset: 0x00045298
		internal static string ToComType(InternalPrimitiveTypeE code)
		{
			/*
An exception occurred when decompiling this method (0600203A)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.String System.Runtime.Serialization.Formatters.Binary.Converter::ToComType(System.Runtime.Serialization.Formatters.Binary.InternalPrimitiveTypeE)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0008:
	call:void(Converter::InitValueA)
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

		// Token: 0x0600203B RID: 8251 RVA: 0x000470B4 File Offset: 0x000452B4
		private static void InitTypeCodeA()
		{
			if (!true)
			{
			}
		}

		// Token: 0x0600203C RID: 8252 RVA: 0x000470C4 File Offset: 0x000452C4
		internal static TypeCode ToTypeCode(InternalPrimitiveTypeE code)
		{
			/*
An exception occurred when decompiling this method (0600203C)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.TypeCode System.Runtime.Serialization.Formatters.Binary.Converter::ToTypeCode(System.Runtime.Serialization.Formatters.Binary.InternalPrimitiveTypeE)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0008:
	call:void(Converter::InitTypeCodeA)
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

		// Token: 0x0600203D RID: 8253 RVA: 0x000470E0 File Offset: 0x000452E0
		private static void InitCodeA()
		{
		}

		// Token: 0x0600203E RID: 8254 RVA: 0x000470F0 File Offset: 0x000452F0
		internal static InternalPrimitiveTypeE ToPrimitiveTypeEnum(TypeCode typeCode)
		{
			/*
An exception occurred when decompiling this method (0600203E)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Runtime.Serialization.Formatters.Binary.InternalPrimitiveTypeE System.Runtime.Serialization.Formatters.Binary.Converter::ToPrimitiveTypeEnum(System.TypeCode)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0008:
	call:void(Converter::InitCodeA)
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

		// Token: 0x0600203F RID: 8255 RVA: 0x0004710C File Offset: 0x0004530C
		internal static object FromString(string value, InternalPrimitiveTypeE code)
		{
			object obj;
			if (value != null)
			{
				CultureInfo invariantCulture = CultureInfo.InvariantCulture;
				return obj;
			}
			return obj;
		}

		// Token: 0x06002040 RID: 8256 RVA: 0x00047128 File Offset: 0x00045328
		// Note: this type is marked as 'beforefieldinit'.
		static Converter()
		{
		}

		// Token: 0x040010BC RID: 4284
		private static int primitiveTypeEnumLength;

		// Token: 0x040010BD RID: 4285
		private static Type[] typeA;

		// Token: 0x040010BE RID: 4286
		private static Type[] arrayTypeA;

		// Token: 0x040010BF RID: 4287
		private static string[] valueA;

		// Token: 0x040010C0 RID: 4288
		private static TypeCode[] typeCodeA;

		// Token: 0x040010C1 RID: 4289
		private static InternalPrimitiveTypeE[] codeA;

		// Token: 0x040010C2 RID: 4290
		internal static Type typeofISerializable;

		// Token: 0x040010C3 RID: 4291
		internal static Type typeofString;

		// Token: 0x040010C4 RID: 4292
		internal static Type typeofConverter;

		// Token: 0x040010C5 RID: 4293
		internal static Type typeofBoolean;

		// Token: 0x040010C6 RID: 4294
		internal static Type typeofByte;

		// Token: 0x040010C7 RID: 4295
		internal static Type typeofChar;

		// Token: 0x040010C8 RID: 4296
		internal static Type typeofDecimal;

		// Token: 0x040010C9 RID: 4297
		internal static Type typeofDouble;

		// Token: 0x040010CA RID: 4298
		internal static Type typeofInt16;

		// Token: 0x040010CB RID: 4299
		internal static Type typeofInt32;

		// Token: 0x040010CC RID: 4300
		internal static Type typeofInt64;

		// Token: 0x040010CD RID: 4301
		internal static Type typeofSByte;

		// Token: 0x040010CE RID: 4302
		internal static Type typeofSingle;

		// Token: 0x040010CF RID: 4303
		internal static Type typeofTimeSpan;

		// Token: 0x040010D0 RID: 4304
		internal static Type typeofDateTime;

		// Token: 0x040010D1 RID: 4305
		internal static Type typeofUInt16;

		// Token: 0x040010D2 RID: 4306
		internal static Type typeofUInt32;

		// Token: 0x040010D3 RID: 4307
		internal static Type typeofUInt64;

		// Token: 0x040010D4 RID: 4308
		internal static Type typeofObject;

		// Token: 0x040010D5 RID: 4309
		internal static Type typeofSystemVoid;

		// Token: 0x040010D6 RID: 4310
		internal static Assembly urtAssembly;

		// Token: 0x040010D7 RID: 4311
		internal static string urtAssemblyString;

		// Token: 0x040010D8 RID: 4312
		internal static Type typeofTypeArray;

		// Token: 0x040010D9 RID: 4313
		internal static Type typeofObjectArray;

		// Token: 0x040010DA RID: 4314
		internal static Type typeofStringArray;

		// Token: 0x040010DB RID: 4315
		internal static Type typeofBooleanArray;

		// Token: 0x040010DC RID: 4316
		internal static Type typeofByteArray;

		// Token: 0x040010DD RID: 4317
		internal static Type typeofCharArray;

		// Token: 0x040010DE RID: 4318
		internal static Type typeofDecimalArray;

		// Token: 0x040010DF RID: 4319
		internal static Type typeofDoubleArray;

		// Token: 0x040010E0 RID: 4320
		internal static Type typeofInt16Array;

		// Token: 0x040010E1 RID: 4321
		internal static Type typeofInt32Array;

		// Token: 0x040010E2 RID: 4322
		internal static Type typeofInt64Array;

		// Token: 0x040010E3 RID: 4323
		internal static Type typeofSByteArray;

		// Token: 0x040010E4 RID: 4324
		internal static Type typeofSingleArray;

		// Token: 0x040010E5 RID: 4325
		internal static Type typeofTimeSpanArray;

		// Token: 0x040010E6 RID: 4326
		internal static Type typeofDateTimeArray;

		// Token: 0x040010E7 RID: 4327
		internal static Type typeofUInt16Array;

		// Token: 0x040010E8 RID: 4328
		internal static Type typeofUInt32Array;

		// Token: 0x040010E9 RID: 4329
		internal static Type typeofUInt64Array;

		// Token: 0x040010EA RID: 4330
		internal static Type typeofMarshalByRefObject;
	}
}
