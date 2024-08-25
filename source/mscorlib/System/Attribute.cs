using System;
using System.Reflection;
using Cpp2IlInjected;

namespace System
{
	// Token: 0x02000145 RID: 325
	[AttributeUsage(AttributeTargets.All, Inherited = true, AllowMultiple = false)]
	[Serializable]
	public abstract class Attribute
	{
		// Token: 0x06000CD1 RID: 3281 RVA: 0x0001BE8C File Offset: 0x0001A08C
		private static Attribute[] InternalGetCustomAttributes(PropertyInfo element, Type type, bool inherit)
		{
			if (!true)
			{
			}
			object[] array;
			if (array == null || array != null)
			{
			}
			throw new InvalidCastException();
		}

		// Token: 0x06000CD2 RID: 3282 RVA: 0x0001BEA8 File Offset: 0x0001A0A8
		private static Attribute[] InternalGetCustomAttributes(EventInfo element, Type type, bool inherit)
		{
			if (!true)
			{
			}
			object[] array;
			if (array == null || array != null)
			{
			}
			throw new InvalidCastException();
		}

		// Token: 0x06000CD3 RID: 3283 RVA: 0x0001BEC4 File Offset: 0x0001A0C4
		private static Attribute[] InternalParamGetCustomAttributes(ParameterInfo parameter, Type attributeType, bool inherit)
		{
			bool flag;
			if (!flag || !flag)
			{
				Array array;
				if (array != null)
				{
					if (array == null)
					{
						throw new InvalidCastException();
					}
				}
			}
			throw new InvalidCastException();
		}

		// Token: 0x06000CD4 RID: 3284 RVA: 0x0001BEF8 File Offset: 0x0001A0F8
		private static bool InternalIsDefined(PropertyInfo element, Type attributeType, bool inherit)
		{
			if (!true)
			{
			}
			bool flag;
			return flag;
		}

		// Token: 0x06000CD5 RID: 3285 RVA: 0x0001BF0C File Offset: 0x0001A10C
		private static bool InternalIsDefined(EventInfo element, Type attributeType, bool inherit)
		{
			if (!true)
			{
			}
			bool flag;
			return flag;
		}

		// Token: 0x06000CD6 RID: 3286 RVA: 0x0001BF20 File Offset: 0x0001A120
		public static Attribute[] GetCustomAttributes(MemberInfo element, Type type)
		{
			Attribute[] array;
			return array;
		}

		// Token: 0x06000CD7 RID: 3287 RVA: 0x0001BF30 File Offset: 0x0001A130
		public static Attribute[] GetCustomAttributes(MemberInfo element, Type type, bool inherit)
		{
			int num = 1;
			if (num == 0)
			{
			}
			if (num == 0)
			{
			}
			Attribute[] array;
			return array;
		}

		// Token: 0x06000CD8 RID: 3288 RVA: 0x0001BF68 File Offset: 0x0001A168
		public static Attribute[] GetCustomAttributes(MemberInfo element, bool inherit)
		{
			if (!true)
			{
			}
			Attribute[] array;
			return array;
		}

		// Token: 0x06000CD9 RID: 3289 RVA: 0x0001BF8C File Offset: 0x0001A18C
		public static bool IsDefined(MemberInfo element, Type attributeType)
		{
			bool flag;
			return flag;
		}

		// Token: 0x06000CDA RID: 3290 RVA: 0x0001BF9C File Offset: 0x0001A19C
		public static bool IsDefined(MemberInfo element, Type attributeType, bool inherit)
		{
			int num = 1;
			if (num == 0)
			{
			}
			if (num == 0)
			{
			}
			bool flag;
			return flag;
		}

		// Token: 0x06000CDB RID: 3291 RVA: 0x0001BFD4 File Offset: 0x0001A1D4
		public static Attribute GetCustomAttribute(MemberInfo element, Type attributeType, bool inherit)
		{
			/*
An exception occurred when decompiling this method (06000CDB)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Attribute System.Attribute::GetCustomAttribute(System.Reflection.MemberInfo,System.Type,System.Boolean)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0007:
	stloc:string(var_2_11, call:string(Environment::GetResourceString, ldstr:string("Multiple custom attributes of the same type found.")))
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

		// Token: 0x06000CDC RID: 3292 RVA: 0x0001BFF4 File Offset: 0x0001A1F4
		public static Attribute[] GetCustomAttributes(ParameterInfo element, Type attributeType, bool inherit)
		{
			if (!true)
			{
			}
			if (!true)
			{
			}
			Attribute[] array;
			return array;
		}

		// Token: 0x06000CDD RID: 3293 RVA: 0x0001C02C File Offset: 0x0001A22C
		public static Attribute[] GetCustomAttributes(ParameterInfo element, bool inherit)
		{
			Attribute[] array;
			return array;
		}

		// Token: 0x06000CDE RID: 3294 RVA: 0x0001C048 File Offset: 0x0001A248
		public static Attribute[] GetCustomAttributes(Module element, bool inherit)
		{
			if (!true)
			{
			}
			Type type;
			if (type == null || type != null)
			{
			}
			throw new InvalidCastException();
		}

		// Token: 0x06000CDF RID: 3295 RVA: 0x0001C064 File Offset: 0x0001A264
		public static Attribute[] GetCustomAttributes(Module element, Type attributeType, bool inherit)
		{
			if (!true)
			{
			}
			if (!true)
			{
			}
			if (!true)
			{
			}
			bool flag;
			if (!flag || flag)
			{
				return "element";
			}
			throw new InvalidCastException();
		}

		// Token: 0x06000CE0 RID: 3296 RVA: 0x0001C09C File Offset: 0x0001A29C
		public static Attribute[] GetCustomAttributes(Assembly element, Type attributeType)
		{
			Attribute[] array;
			return array;
		}

		// Token: 0x06000CE1 RID: 3297 RVA: 0x0001C0AC File Offset: 0x0001A2AC
		public static Attribute[] GetCustomAttributes(Assembly element, Type attributeType, bool inherit)
		{
			if (!true)
			{
			}
			if (!true)
			{
			}
			bool flag;
			if (!flag || flag)
			{
				return "element";
			}
			throw new InvalidCastException();
		}

		// Token: 0x06000CE2 RID: 3298 RVA: 0x0001C0E0 File Offset: 0x0001A2E0
		public static Attribute[] GetCustomAttributes(Assembly element)
		{
			Attribute[] array;
			return array;
		}

		// Token: 0x06000CE3 RID: 3299 RVA: 0x0001C0F0 File Offset: 0x0001A2F0
		public static Attribute[] GetCustomAttributes(Assembly element, bool inherit)
		{
			Type type;
			if (type == null || type != null)
			{
			}
			throw new InvalidCastException();
		}

		// Token: 0x06000CE4 RID: 3300 RVA: 0x0001C108 File Offset: 0x0001A308
		public static Attribute GetCustomAttribute(Assembly element, Type attributeType)
		{
			Attribute attribute;
			return attribute;
		}

		// Token: 0x06000CE5 RID: 3301 RVA: 0x0001C118 File Offset: 0x0001A318
		public static Attribute GetCustomAttribute(Assembly element, Type attributeType, bool inherit)
		{
			/*
An exception occurred when decompiling this method (06000CE5)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Attribute System.Attribute::GetCustomAttribute(System.Reflection.Assembly,System.Type,System.Boolean)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0007:
	stloc:string(var_2_11, call:string(Environment::GetResourceString, ldstr:string("Multiple custom attributes of the same type found.")))
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

		// Token: 0x06000CE6 RID: 3302 RVA: 0x0001C138 File Offset: 0x0001A338
		protected Attribute()
		{
		}

		// Token: 0x06000CE7 RID: 3303 RVA: 0x0001C14C File Offset: 0x0001A34C
		public override bool Equals(object obj)
		{
			if (obj != null)
			{
				if (base.GetType() != null)
				{
				}
				Type type = obj.GetType();
				if (type != null || type != null)
				{
				}
			}
			throw new InvalidCastException();
		}

		// Token: 0x06000CE8 RID: 3304 RVA: 0x0001C18C File Offset: 0x0001A38C
		private static bool AreFieldValuesEqual(object thisValue, object thatValue)
		{
			/*
An exception occurred when decompiling this method (06000CE8)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean System.Attribute::AreFieldValuesEqual(System.Object,System.Object)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:Type(var_2_10, call:Type(object::GetType, callgetter:bool[exp:object](Type::get_IsArray, ldloc:Type(var_1))))
	stloc:Type(var_3_17, call:Type(object::GetType, ldloc:object(thisValue)))
	stloc:bool(var_13_2D, call:bool(Attribute::AreFieldValuesEqual, ldloc:object(var_11), ldloc:object(var_12)))
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

		// Token: 0x06000CE9 RID: 3305 RVA: 0x0001C1CC File Offset: 0x0001A3CC
		public override int GetHashCode()
		{
			Type type = base.GetType();
			if (type != null)
			{
				bool isArray = type.GetType().IsArray;
			}
			throw new InvalidCastException();
		}

		// Token: 0x1700011E RID: 286
		// (get) Token: 0x06000CEA RID: 3306 RVA: 0x0001C1F8 File Offset: 0x0001A3F8
		public virtual object TypeId
		{
			get
			{
				/*
An exception occurred when decompiling this method (06000CEA)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Object System.Attribute::get_TypeId()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:Type(var_0_06, call:Type(object::GetType, ldloc:Attribute[exp:object](this)))
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
		}

		// Token: 0x06000CEB RID: 3307 RVA: 0x0000207A File Offset: 0x0000027A
		public virtual bool Match(object obj)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06000CEC RID: 3308 RVA: 0x0001C20C File Offset: 0x0001A40C
		public virtual bool IsDefaultAttribute()
		{
		}
	}
}
