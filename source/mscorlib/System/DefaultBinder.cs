using System;
using System.Globalization;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace System
{
	// Token: 0x02000149 RID: 329
	[Serializable]
	internal class DefaultBinder : Binder
	{
		// Token: 0x06000CFE RID: 3326 RVA: 0x0001C358 File Offset: 0x0001A558
		public override MethodBase BindToMethod(BindingFlags bindingAttr, MethodBase[] match, object[] args, ParameterModifier[] modifiers, CultureInfo cultureInfo, string[] names, [Out] object state)
		{
			int num = 1;
			if (match == null || num == 0)
			{
				string resourceString = Environment.GetResourceString("Array may not be empty.");
				string resourceString2 = Environment.GetResourceString("Member not found.");
				throw new InvalidCastException();
			}
			object obj;
			if (obj != null && obj == null)
			{
				throw new InvalidCastException();
			}
			if (names != null)
			{
			}
			Type type;
			if (type == null || type != null)
			{
				if (type != null)
				{
				}
				int num2;
				if (num2 != 0)
				{
				}
				int num3 = 1;
				string resourceString3 = Environment.GetResourceString("Ambiguous match found.");
				if (num3 != 0)
				{
					object obj2;
					if (obj2 != null)
					{
						if (obj2 == null)
						{
							throw new InvalidCastException();
						}
					}
				}
				Array array;
				if (array == null || array != null)
				{
					if (array != null)
					{
					}
					Array array2;
					Array array3;
					if (array2 != null)
					{
						if (array2 != null)
						{
							throw new InvalidCastException();
						}
					}
					else if ((array3 != null && array3 == null) || array3 == null || array3 != null)
					{
					}
				}
			}
			throw new ArrayTypeMismatchException();
		}

		// Token: 0x06000CFF RID: 3327 RVA: 0x0001C484 File Offset: 0x0001A684
		public override FieldInfo BindToField(BindingFlags bindingAttr, FieldInfo[] match, object value, CultureInfo cultureInfo)
		{
			if (match != null)
			{
				object obj;
				if (obj == null || obj != null)
				{
					Type type = value.GetType();
					long num = 0L;
					bool flag = type == type;
					bool isClass = type.IsClass;
					Type type2;
					bool flag2 = type == type2;
					if (type == null || type != null)
					{
						bool isPrimitive = type.IsPrimitive;
						if (type != null || type != null)
						{
						}
						if (num == 0L)
						{
							goto IL_006E;
						}
						if (num == 0L)
						{
						}
						int num2;
						if (num2 != 0)
						{
						}
						string resourceString = Environment.GetResourceString("Ambiguous match found.");
					}
					throw new ArrayTypeMismatchException();
				}
				goto IL_007A;
			}
			IL_006E:
			string resourceString2 = Environment.GetResourceString("Field not found.");
			IL_007A:
			throw new InvalidCastException();
		}

		// Token: 0x06000D00 RID: 3328 RVA: 0x0001C510 File Offset: 0x0001A710
		public override PropertyInfo SelectProperty(BindingFlags bindingAttr, PropertyInfo[] match, Type returnType, Type[] indexes, ParameterModifier[] modifiers)
		{
			int num = 1;
			if (num == 0)
			{
			}
			if (num == 0)
			{
			}
			if (match != null)
			{
				object obj;
				if (obj == null || obj != null)
				{
					bool flag;
					if (flag)
					{
					}
					throw new InvalidCastException();
				}
			}
			else
			{
				string resourceString = Environment.GetResourceString("Array may not be empty.");
			}
			throw new InvalidCastException();
		}

		// Token: 0x06000D01 RID: 3329 RVA: 0x0001C588 File Offset: 0x0001A788
		public override object ChangeType(object value, Type type, CultureInfo cultureInfo)
		{
			/*
An exception occurred when decompiling this method (06000D01)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Object System.DefaultBinder::ChangeType(System.Object,System.Type,System.Globalization.CultureInfo)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:string(var_0_0A, call:string(Environment::GetResourceString, ldstr:string("ChangeType operation is not supported.")))
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

		// Token: 0x06000D02 RID: 3330 RVA: 0x0001C5A0 File Offset: 0x0001A7A0
		public override void ReorderArgumentArray(object[] args, object state)
		{
			if (state != null)
			{
			}
			if (args == null || args == null)
			{
				throw new InvalidCastException();
			}
			if (args == null || args != null)
			{
				return;
			}
			throw new ArrayTypeMismatchException();
		}

		// Token: 0x06000D03 RID: 3331 RVA: 0x0001C5D8 File Offset: 0x0001A7D8
		public static MethodBase ExactBinding(MethodBase[] match, Type[] types, ParameterModifier[] modifiers)
		{
			long num = 0L;
			if (num != 0L)
			{
			}
			MethodBase methodBase;
			return methodBase;
		}

		// Token: 0x06000D04 RID: 3332 RVA: 0x0001C5FC File Offset: 0x0001A7FC
		public static PropertyInfo ExactPropertyBinding(PropertyInfo[] match, Type returnType, Type[] types, ParameterModifier[] modifiers)
		{
			/*
An exception occurred when decompiling this method (06000D04)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Reflection.PropertyInfo System.DefaultBinder::ExactPropertyBinding(System.Reflection.PropertyInfo[],System.Type,System.Type[],System.Reflection.ParameterModifier[])

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0005:
	stloc:string(var_7_13, call:string(Environment::GetResourceString, ldstr:string("Ambiguous match found.")))
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

		// Token: 0x06000D05 RID: 3333 RVA: 0x0001C620 File Offset: 0x0001A820
		private static int FindMostSpecific(ParameterInfo[] p1, int[] paramOrder1, Type paramArrayType1, ParameterInfo[] p2, int[] paramOrder2, Type paramArrayType2, Type[] types, object[] args)
		{
			int num = 1;
			if (num == 0)
			{
			}
			if (num == 0)
			{
			}
			return 2;
		}

		// Token: 0x06000D06 RID: 3334 RVA: 0x0001C668 File Offset: 0x0001A868
		private static int FindMostSpecificType(Type c1, Type c2, Type t)
		{
			int num = 1;
			if (num == 0)
			{
			}
			if (num == 0)
			{
			}
			return 1;
		}

		// Token: 0x06000D07 RID: 3335 RVA: 0x0001C6A0 File Offset: 0x0001A8A0
		private static int FindMostSpecificMethod(MethodBase m1, int[] paramOrder1, Type paramArrayType1, MethodBase m2, int[] paramOrder2, Type paramArrayType2, Type[] types, object[] args)
		{
			int num;
			if (num == 0)
			{
				int hierarchyDepth = DefaultBinder.GetHierarchyDepth(paramArrayType1);
			}
			return num;
		}

		// Token: 0x06000D08 RID: 3336 RVA: 0x0001C6BC File Offset: 0x0001A8BC
		private static int FindMostSpecificField(FieldInfo cur1, FieldInfo cur2)
		{
		}

		// Token: 0x06000D09 RID: 3337 RVA: 0x0001C6CC File Offset: 0x0001A8CC
		private static int FindMostSpecificProperty(PropertyInfo cur1, PropertyInfo cur2)
		{
		}

		// Token: 0x06000D0A RID: 3338 RVA: 0x0001C6DC File Offset: 0x0001A8DC
		internal static bool CompareMethodSigAndName(MethodBase m1, MethodBase m2)
		{
		}

		// Token: 0x06000D0B RID: 3339 RVA: 0x0001C6EC File Offset: 0x0001A8EC
		internal static int GetHierarchyDepth(Type t)
		{
		}

		// Token: 0x06000D0C RID: 3340 RVA: 0x0001C6FC File Offset: 0x0001A8FC
		internal static MethodBase FindMostDerivedNewSlotMeth(MethodBase[] match, int cMatches)
		{
			/*
An exception occurred when decompiling this method (06000D0C)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Reflection.MethodBase System.DefaultBinder::FindMostDerivedNewSlotMeth(System.Reflection.MethodBase[],System.Int32)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:string(var_3_0E, call:string(Environment::GetResourceString, ldstr:string("Ambiguous match found.")))
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

		// Token: 0x06000D0D RID: 3341 RVA: 0x0001C718 File Offset: 0x0001A918
		private static void ReorderParams(int[] paramOrder, object[] vars)
		{
			long num = 0L;
			if (paramOrder == null || paramOrder != null)
			{
				num.m_value = paramOrder;
				return;
			}
			throw new ArrayTypeMismatchException();
		}

		// Token: 0x06000D0E RID: 3342 RVA: 0x0001C740 File Offset: 0x0001A940
		private static bool CreateParamOrder(int[] paramOrder, ParameterInfo[] pars, string[] names)
		{
			bool flag;
			return flag;
		}

		// Token: 0x06000D0F RID: 3343 RVA: 0x0001C768 File Offset: 0x0001A968
		private static bool CanConvertPrimitive(RuntimeType source, RuntimeType target)
		{
			/*
An exception occurred when decompiling this method (06000D0F)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean System.DefaultBinder::CanConvertPrimitive(System.RuntimeType,System.RuntimeType)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0003:
	stloc:TypeCode(var_1_09, call:TypeCode(Type::GetTypeCode, ldloc:RuntimeType[exp:Type](source)))
	stloc:bool(var_5_14, call:bool(Type::op_Equality, ldloc:RuntimeType[exp:Type](source), ldloc:Type(var_4)))
	stloc:bool(var_7_1E, call:bool(Type::op_Equality, ldloc:RuntimeType[exp:Type](source), ldloc:Type(var_6)))
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

		// Token: 0x06000D10 RID: 3344 RVA: 0x0001C794 File Offset: 0x0001A994
		private static bool CanConvertPrimitiveObjectToType(object source, RuntimeType type)
		{
			Type type2;
			if (type2 != null || type2 != null)
			{
			}
			bool flag;
			return flag;
		}

		// Token: 0x06000D11 RID: 3345 RVA: 0x0001C7B0 File Offset: 0x0001A9B0
		internal static bool CompareMethodSig(MethodBase m1, MethodBase m2)
		{
		}

		// Token: 0x06000D12 RID: 3346 RVA: 0x0001C7C0 File Offset: 0x0001A9C0
		public sealed override MethodBase SelectMethod(BindingFlags bindingAttr, MethodBase[] match, Type[] types, ParameterModifier[] modifiers)
		{
			if (match == null)
			{
				throw new ArrayTypeMismatchException();
			}
			object obj;
			if (obj != null && obj == null)
			{
				throw new InvalidCastException();
			}
			Type type;
			Type type2;
			if (type != null)
			{
				bool flag = type2.IsRuntimeImplemented();
			}
			if (obj == null || obj != null)
			{
				if (type2 != null)
				{
				}
				int num;
				if (num != 0)
				{
				}
			}
			throw new ArrayTypeMismatchException();
		}

		// Token: 0x06000D13 RID: 3347 RVA: 0x0001C818 File Offset: 0x0001AA18
		private static bool CanChangePrimitive(Type source, Type target)
		{
			if (!true)
			{
			}
			bool flag;
			return flag;
		}

		// Token: 0x06000D14 RID: 3348 RVA: 0x0001C82C File Offset: 0x0001AA2C
		private static bool CanPrimitiveWiden(Type source, Type target)
		{
			/*
An exception occurred when decompiling this method (06000D14)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean System.DefaultBinder::CanPrimitiveWiden(System.Type,System.Type)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0003:
	stloc:TypeCode(var_1_09, call:TypeCode(Type::GetTypeCode, ldloc:Type(source)))
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

		// Token: 0x06000D15 RID: 3349 RVA: 0x0001C844 File Offset: 0x0001AA44
		public DefaultBinder()
		{
		}

		// Token: 0x06000D16 RID: 3350 RVA: 0x0001C858 File Offset: 0x0001AA58
		// Note: this type is marked as 'beforefieldinit'.
		static DefaultBinder()
		{
		}

		// Token: 0x040004F7 RID: 1271
		private static DefaultBinder.Primitives[] _primitiveConversions;

		// Token: 0x0200014A RID: 330
		internal class BinderState
		{
			// Token: 0x06000D17 RID: 3351 RVA: 0x0001C868 File Offset: 0x0001AA68
			internal BinderState(int[] argsMap, int originalSize, bool isParamArray)
			{
				this.m_argsMap = argsMap;
				this.m_originalSize = originalSize;
			}

			// Token: 0x040004F8 RID: 1272
			internal int[] m_argsMap;

			// Token: 0x040004F9 RID: 1273
			internal int m_originalSize;

			// Token: 0x040004FA RID: 1274
			internal bool m_isParamArray;
		}

		// Token: 0x0200014B RID: 331
		[Flags]
		private enum Primitives
		{
			// Token: 0x040004FC RID: 1276
			Boolean = 8,
			// Token: 0x040004FD RID: 1277
			Char = 16,
			// Token: 0x040004FE RID: 1278
			SByte = 32,
			// Token: 0x040004FF RID: 1279
			Byte = 64,
			// Token: 0x04000500 RID: 1280
			Int16 = 128,
			// Token: 0x04000501 RID: 1281
			UInt16 = 256,
			// Token: 0x04000502 RID: 1282
			Int32 = 512,
			// Token: 0x04000503 RID: 1283
			UInt32 = 1024,
			// Token: 0x04000504 RID: 1284
			Int64 = 2048,
			// Token: 0x04000505 RID: 1285
			UInt64 = 4096,
			// Token: 0x04000506 RID: 1286
			Single = 8192,
			// Token: 0x04000507 RID: 1287
			Double = 16384,
			// Token: 0x04000508 RID: 1288
			Decimal = 32768,
			// Token: 0x04000509 RID: 1289
			DateTime = 65536,
			// Token: 0x0400050A RID: 1290
			String = 262144
		}

		// Token: 0x0200014C RID: 332
		[CompilerGenerated]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x06000D18 RID: 3352 RVA: 0x0001C88C File Offset: 0x0001AA8C
			// Note: this type is marked as 'beforefieldinit'.
			static <>c()
			{
			}

			// Token: 0x06000D19 RID: 3353 RVA: 0x0001C89C File Offset: 0x0001AA9C
			public <>c()
			{
			}

			// Token: 0x06000D1A RID: 3354 RVA: 0x0001C8B0 File Offset: 0x0001AAB0
			internal bool <SelectProperty>b__2_0(Type t)
			{
				if (!true)
				{
				}
				bool flag;
				return flag;
			}

			// Token: 0x0400050B RID: 1291
			public static readonly DefaultBinder.<>c <>9;

			// Token: 0x0400050C RID: 1292
			public static Predicate<Type> <>9__2_0;
		}
	}
}
