using System;
using System.Reflection;
using System.Runtime.ConstrainedExecution;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Threading;
using Cpp2IlInjected;

namespace System
{
	// Token: 0x0200018C RID: 396
	[ComVisible(true)]
	[Serializable]
	public struct RuntimeTypeHandle : ISerializable
	{
		// Token: 0x06000F51 RID: 3921 RVA: 0x00020964 File Offset: 0x0001EB64
		internal RuntimeTypeHandle(IntPtr val)
		{
			this.value = val;
		}

		// Token: 0x06000F52 RID: 3922 RVA: 0x00020978 File Offset: 0x0001EB78
		internal RuntimeTypeHandle(RuntimeType type)
		{
			RuntimeTypeHandle impl = type._impl;
			this.value = impl;
		}

		// Token: 0x06000F53 RID: 3923 RVA: 0x00020994 File Offset: 0x0001EB94
		private RuntimeTypeHandle(SerializationInfo info, StreamingContext context)
		{
			if (info != null)
			{
				Type type;
				object obj = info.GetValue("TypeObj", type);
				this.value = obj;
				return;
			}
		}

		// Token: 0x17000161 RID: 353
		// (get) Token: 0x06000F54 RID: 3924 RVA: 0x0000207A File Offset: 0x0000027A
		public IntPtr Value
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		// Token: 0x06000F55 RID: 3925 RVA: 0x000209C0 File Offset: 0x0001EBC0
		public void GetObjectData(SerializationInfo info, StreamingContext context)
		{
			if (info != null)
			{
				Type type;
				info.AddValue("TypeObj", context, type);
				return;
			}
		}

		// Token: 0x06000F56 RID: 3926 RVA: 0x000209E0 File Offset: 0x0001EBE0
		[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
		public override bool Equals(object obj)
		{
			if (obj != null)
			{
			}
			throw new InvalidCastException();
		}

		// Token: 0x06000F57 RID: 3927 RVA: 0x0000207A File Offset: 0x0000027A
		public override int GetHashCode()
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06000F58 RID: 3928 RVA: 0x0000207A File Offset: 0x0000027A
		internal static TypeAttributes GetAttributes(RuntimeType type)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06000F59 RID: 3929 RVA: 0x0000207A File Offset: 0x0000027A
		private static int GetMetadataToken(RuntimeType type)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06000F5A RID: 3930 RVA: 0x0000207A File Offset: 0x0000027A
		internal static int GetToken(RuntimeType type)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06000F5B RID: 3931 RVA: 0x0000207A File Offset: 0x0000027A
		private static Type GetGenericTypeDefinition_impl(RuntimeType type)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06000F5C RID: 3932 RVA: 0x0000207A File Offset: 0x0000027A
		internal static Type GetGenericTypeDefinition(RuntimeType type)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06000F5D RID: 3933 RVA: 0x000209F8 File Offset: 0x0001EBF8
		internal static bool IsPrimitive(RuntimeType type)
		{
		}

		// Token: 0x06000F5E RID: 3934 RVA: 0x0000207A File Offset: 0x0000027A
		internal static bool IsByRef(RuntimeType type)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06000F5F RID: 3935 RVA: 0x0000207A File Offset: 0x0000027A
		internal static bool IsPointer(RuntimeType type)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06000F60 RID: 3936 RVA: 0x0000207A File Offset: 0x0000027A
		internal static bool IsArray(RuntimeType type)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06000F61 RID: 3937 RVA: 0x0000207A File Offset: 0x0000027A
		internal static bool IsSzArray(RuntimeType type)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06000F62 RID: 3938 RVA: 0x00020A08 File Offset: 0x0001EC08
		internal static bool HasElementType(RuntimeType type)
		{
		}

		// Token: 0x06000F63 RID: 3939 RVA: 0x0000207A File Offset: 0x0000027A
		internal static CorElementType GetCorElementType(RuntimeType type)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06000F64 RID: 3940 RVA: 0x0000207A File Offset: 0x0000027A
		internal static bool HasInstantiation(RuntimeType type)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06000F65 RID: 3941 RVA: 0x0000207A File Offset: 0x0000027A
		internal static bool IsComObject(RuntimeType type)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06000F66 RID: 3942 RVA: 0x0000207A File Offset: 0x0000027A
		internal static bool IsInstanceOfType(RuntimeType type, object o)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06000F67 RID: 3943 RVA: 0x0000207A File Offset: 0x0000027A
		internal static bool HasReferences(RuntimeType type)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06000F68 RID: 3944 RVA: 0x00020A18 File Offset: 0x0001EC18
		internal static bool IsComObject(RuntimeType type, bool isGenericCOM)
		{
		}

		// Token: 0x06000F69 RID: 3945 RVA: 0x00020A28 File Offset: 0x0001EC28
		internal static bool IsContextful(RuntimeType type)
		{
			/*
An exception occurred when decompiling this method (06000F69)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean System.RuntimeTypeHandle::IsContextful(System.RuntimeType)

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

		// Token: 0x06000F6A RID: 3946 RVA: 0x00020A38 File Offset: 0x0001EC38
		internal static bool IsEquivalentTo(RuntimeType rtType1, RuntimeType rtType2)
		{
		}

		// Token: 0x06000F6B RID: 3947 RVA: 0x0000207A File Offset: 0x0000027A
		internal static bool IsInterface(RuntimeType type)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06000F6C RID: 3948 RVA: 0x0000207A File Offset: 0x0000027A
		internal static int GetArrayRank(RuntimeType type)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06000F6D RID: 3949 RVA: 0x0000207A File Offset: 0x0000027A
		internal static RuntimeAssembly GetAssembly(RuntimeType type)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06000F6E RID: 3950 RVA: 0x0000207A File Offset: 0x0000027A
		internal static RuntimeType GetElementType(RuntimeType type)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06000F6F RID: 3951 RVA: 0x0000207A File Offset: 0x0000027A
		internal static RuntimeModule GetModule(RuntimeType type)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06000F70 RID: 3952 RVA: 0x0000207A File Offset: 0x0000027A
		internal static bool IsGenericVariable(RuntimeType type)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06000F71 RID: 3953 RVA: 0x0000207A File Offset: 0x0000027A
		internal static RuntimeType GetBaseType(RuntimeType type)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06000F72 RID: 3954 RVA: 0x0000207A File Offset: 0x0000027A
		internal static bool CanCastTo(RuntimeType type, RuntimeType target)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06000F73 RID: 3955 RVA: 0x0000207A File Offset: 0x0000027A
		private static bool type_is_assignable_from(Type a, Type b)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06000F74 RID: 3956 RVA: 0x0000207A File Offset: 0x0000027A
		internal static bool IsGenericTypeDefinition(RuntimeType type)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06000F75 RID: 3957 RVA: 0x0000207A File Offset: 0x0000027A
		internal static IntPtr GetGenericParameterInfo(RuntimeType type)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06000F76 RID: 3958 RVA: 0x00020A48 File Offset: 0x0001EC48
		internal static bool IsSubclassOf(RuntimeType childType, RuntimeType baseType)
		{
			/*
An exception occurred when decompiling this method (06000F76)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean System.RuntimeTypeHandle::IsSubclassOf(System.RuntimeType,System.RuntimeType)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:RuntimeTypeHandle(var_0_06, ldfld:RuntimeTypeHandle(Type::_impl, ldloc:RuntimeType[exp:Type](childType)))
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

		// Token: 0x06000F77 RID: 3959 RVA: 0x0000207A File Offset: 0x0000027A
		internal static bool is_subclass_of(IntPtr childType, IntPtr baseType)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06000F78 RID: 3960 RVA: 0x0000207A File Offset: 0x0000027A
		private static RuntimeType internal_from_name(string name, StackCrawlMark stackMark, Assembly callerAssembly, bool throwOnError, bool ignoreCase, bool reflectionOnly)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06000F79 RID: 3961 RVA: 0x00020A5C File Offset: 0x0001EC5C
		internal static RuntimeType GetTypeByName(string typeName, bool throwOnError, bool ignoreCase, bool reflectionOnly, StackCrawlMark stackMark, bool loadTypeFromPartialName)
		{
			string text;
			Assembly assembly = Assembly.ReflectionOnlyLoad(text);
			if (assembly != null)
			{
				throw new InvalidCastException();
			}
			string text2 = "Error loading '" + "Assembly qualifed type name is required" + "'";
			throw new OutOfMemoryException();
		}

		// Token: 0x04000697 RID: 1687
		private IntPtr value;
	}
}
