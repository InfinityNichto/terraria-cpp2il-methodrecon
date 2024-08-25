using System;
using Cpp2IlInjected;
using UnityEngine.Scripting;

namespace UnityEngine
{
	// Token: 0x0200000B RID: 11
	[UsedByNativeCode]
	internal sealed class _AndroidJNIHelper
	{
		// Token: 0x060000B0 RID: 176 RVA: 0x00004204 File Offset: 0x00002404
		public static IntPtr CreateJavaProxy(IntPtr delegateHandle, AndroidJavaProxy proxy)
		{
			IntPtr intPtr;
			return intPtr;
		}

		// Token: 0x060000B1 RID: 177 RVA: 0x00004214 File Offset: 0x00002414
		public static IntPtr CreateJavaRunnable(AndroidJavaRunnable jrunnable)
		{
			IntPtr intPtr;
			return intPtr;
		}

		// Token: 0x060000B2 RID: 178 RVA: 0x00004224 File Offset: 0x00002424
		[RequiredByNativeCode]
		public static IntPtr InvokeJavaProxyMethod(AndroidJavaProxy proxy, IntPtr jmethodName, IntPtr jargs)
		{
			int arrayLength = AndroidJNISafe.GetArrayLength(jmethodName);
			long num = 0L;
			IntPtr objectArrayElement = AndroidJNISafe.GetObjectArrayElement(jmethodName, (int)num);
			throw new MissingMethodException();
		}

		// Token: 0x060000B3 RID: 179 RVA: 0x0000428C File Offset: 0x0000248C
		public static jvalue[] CreateJNIArgArray(object[] args)
		{
			Type type;
			bool isPrimitive = type.IsPrimitive;
			Debug.LogWarning("Passing Byte arguments to Java methods is obsolete, pass SByte parameters instead");
			return "Passing Byte arguments to Java methods is obsolete, pass SByte parameters instead";
		}

		// Token: 0x060000B4 RID: 180 RVA: 0x000042CC File Offset: 0x000024CC
		public static object UnboxArray(AndroidJavaObject obj)
		{
			return "java.lang.Class";
		}

		// Token: 0x060000B5 RID: 181 RVA: 0x00004374 File Offset: 0x00002574
		public static object Unbox(AndroidJavaObject obj)
		{
			if (!false)
			{
				object obj2;
				return obj2;
			}
			throw new OutOfMemoryException();
		}

		// Token: 0x060000B6 RID: 182 RVA: 0x000043C4 File Offset: 0x000025C4
		public static AndroidJavaObject Box(object obj)
		{
			Type type;
			bool isPrimitive = type.IsPrimitive;
			if ("java.lang.Integer" != null)
			{
				return "java.lang.Boolean";
			}
			throw new ArrayTypeMismatchException();
		}

		// Token: 0x060000B7 RID: 183 RVA: 0x00004434 File Offset: 0x00002634
		public static void DeleteJNIArgArray(object[] args, jvalue[] jniArgs)
		{
		}

		// Token: 0x060000B8 RID: 184 RVA: 0x00004448 File Offset: 0x00002648
		public static IntPtr ConvertToJNIArray(Array array)
		{
			Type type;
			bool isPrimitive = type.IsPrimitive;
			Type type2;
			if (type2 == null)
			{
				throw new InvalidCastException();
			}
			IntPtr intPtr = AndroidJNISafe.FindClass("java/lang/Object");
			long num;
			if (num != 0L)
			{
			}
			AndroidJNISafe.DeleteLocalRef(intPtr);
			IntPtr intPtr2;
			return intPtr2;
		}

		// Token: 0x060000B9 RID: 185 RVA: 0x0000353A File Offset: 0x0000173A
		public static ArrayType ConvertFromJNIArray<ArrayType>(IntPtr array)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x060000BA RID: 186 RVA: 0x0000455C File Offset: 0x0000275C
		public static IntPtr GetConstructorID(IntPtr jclass, object[] args)
		{
			IntPtr intPtr;
			return intPtr;
		}

		// Token: 0x060000BB RID: 187 RVA: 0x0000456C File Offset: 0x0000276C
		public static IntPtr GetMethodID(IntPtr jclass, string methodName, object[] args, bool isStatic)
		{
			IntPtr intPtr;
			return intPtr;
		}

		// Token: 0x060000BC RID: 188 RVA: 0x0000457C File Offset: 0x0000277C
		public static IntPtr GetMethodID<ReturnType>(IntPtr jclass, string methodName, object[] args, bool isStatic)
		{
			IntPtr intPtr;
			return intPtr;
		}

		// Token: 0x060000BD RID: 189 RVA: 0x0000458C File Offset: 0x0000278C
		public static IntPtr GetFieldID<ReturnType>(IntPtr jclass, string fieldName, bool isStatic)
		{
			Type type;
			string signature = _AndroidJNIHelper.GetSignature(type);
			IntPtr intPtr;
			return intPtr;
		}

		// Token: 0x060000BE RID: 190 RVA: 0x000045A4 File Offset: 0x000027A4
		public static IntPtr GetConstructorID(IntPtr jclass, string signature)
		{
			IntPtr intPtr2;
			IntPtr intPtr = AndroidJNISafe.FromReflectedMethod(intPtr2);
			AndroidJNISafe.DeleteLocalRef(intPtr2);
			return intPtr;
		}

		// Token: 0x060000BF RID: 191 RVA: 0x0000353A File Offset: 0x0000173A
		public static IntPtr GetMethodID(IntPtr jclass, string methodName, string signature, bool isStatic)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x060000C0 RID: 192 RVA: 0x000045F8 File Offset: 0x000027F8
		private static IntPtr GetMethodIDFallback(IntPtr jclass, string methodName, string signature, bool isStatic)
		{
			IntPtr intPtr;
			return intPtr;
		}

		// Token: 0x060000C1 RID: 193 RVA: 0x0000460C File Offset: 0x0000280C
		public static IntPtr GetFieldID(IntPtr jclass, string fieldName, string signature, bool isStatic)
		{
			throw new MissingMethodException();
		}

		// Token: 0x060000C2 RID: 194 RVA: 0x0000353A File Offset: 0x0000173A
		public static string GetSignature(object obj)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x060000C3 RID: 195 RVA: 0x0000467C File Offset: 0x0000287C
		public static string GetSignature(object[] args)
		{
			/*
An exception occurred when decompiling this method (060000C3)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.String UnityEngine._AndroidJNIHelper::GetSignature(System.Object[])

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:string(var_4_0D, call:string(_AndroidJNIHelper::GetSignature, ldloc:StringBuilder[exp:object](var_2)))
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

		// Token: 0x060000C4 RID: 196 RVA: 0x00004698 File Offset: 0x00002898
		public static string GetSignature<ReturnType>(object[] args)
		{
			/*
An exception occurred when decompiling this method (060000C4)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.String UnityEngine._AndroidJNIHelper::GetSignature<ReturnType>(System.Object[])

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:string(var_4_0D, call:string(_AndroidJNIHelper::GetSignature, ldloc:StringBuilder[exp:object](var_2)))
	stloc:string(var_9_1A, call:string(_AndroidJNIHelper::GetSignature, ldloc:Type[exp:object](var_8)))
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

		// Token: 0x060000C5 RID: 197 RVA: 0x000046C0 File Offset: 0x000028C0
		public _AndroidJNIHelper()
		{
		}
	}
}
