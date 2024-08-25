using System;
using System.Collections;
using System.Reflection;
using System.Threading;

namespace System.ComponentModel
{
	// Token: 0x020003EA RID: 1002
	internal sealed class ReflectTypeDescriptionProvider : TypeDescriptionProvider
	{
		// Token: 0x17000624 RID: 1572
		// (get) Token: 0x06001A9E RID: 6814 RVA: 0x00049F40 File Offset: 0x00048140
		internal static Guid ExtenderProviderKey
		{
			get
			{
				/*
An exception occurred when decompiling this method (06001A9E)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Guid System.ComponentModel.ReflectTypeDescriptionProvider::get_ExtenderProviderKey()

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

		// Token: 0x06001A9F RID: 6815 RVA: 0x00049F50 File Offset: 0x00048150
		internal ReflectTypeDescriptionProvider()
		{
		}

		// Token: 0x17000625 RID: 1573
		// (get) Token: 0x06001AA0 RID: 6816 RVA: 0x00049F64 File Offset: 0x00048164
		private static Hashtable IntrinsicTypeConverters
		{
			get
			{
				/*
An exception occurred when decompiling this method (06001AA0)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Collections.Hashtable System.ComponentModel.ReflectTypeDescriptionProvider::get_IntrinsicTypeConverters()

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

		// Token: 0x06001AA1 RID: 6817 RVA: 0x00049F74 File Offset: 0x00048174
		internal static void AddEditorTable(Type editorBaseType, Hashtable table)
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
		}

		// Token: 0x06001AA2 RID: 6818 RVA: 0x00049FA8 File Offset: 0x000481A8
		public override object CreateInstance(IServiceProvider provider, Type objectType, Type[] argTypes, object[] args)
		{
			if (argTypes != null)
			{
				object obj;
				if (obj != null)
				{
					return obj;
				}
			}
			else
			{
				Type type;
				if (args != null && type != null && type == null)
				{
					throw new ArrayTypeMismatchException();
				}
				object obj2;
				while (obj2 != null)
				{
				}
			}
			return global::System.SecurityUtils.SecureCreateInstance(objectType, args);
		}

		// Token: 0x06001AA3 RID: 6819 RVA: 0x00049FDC File Offset: 0x000481DC
		private static object CreateInstance(Type objectType, Type callingType)
		{
			if (!true)
			{
			}
			if (objectType != null && objectType == null)
			{
				throw new ArrayTypeMismatchException();
			}
			object obj;
			if (obj != null)
			{
				return obj;
			}
			object obj2;
			return obj2;
		}

		// Token: 0x06001AA4 RID: 6820 RVA: 0x0004A000 File Offset: 0x00048200
		internal AttributeCollection GetAttributes(Type type)
		{
			return this.GetTypeData(type, true).GetAttributes();
		}

		// Token: 0x06001AA5 RID: 6821 RVA: 0x0004A01C File Offset: 0x0004821C
		public override IDictionary GetCache(object instance)
		{
			/*
An exception occurred when decompiling this method (06001AA5)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Collections.IDictionary System.ComponentModel.ReflectTypeDescriptionProvider::GetCache(System.Object)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0010:
	brtrue(IL_0010, ldloc:object[exp:bool](instance))
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

		// Token: 0x06001AA6 RID: 6822 RVA: 0x0004A03C File Offset: 0x0004823C
		internal string GetClassName(Type type)
		{
			/*
An exception occurred when decompiling this method (06001AA6)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.String System.ComponentModel.ReflectTypeDescriptionProvider::GetClassName(System.Type)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:Type(var_0_0D, ldfld:Type(ReflectedTypeData::_type, call:ReflectedTypeData(ReflectTypeDescriptionProvider::GetTypeData, ldloc:ReflectTypeDescriptionProvider(this), ldloc:Type(type), ldc.i4:bool(1))))
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

		// Token: 0x06001AA7 RID: 6823 RVA: 0x0004A058 File Offset: 0x00048258
		internal string GetComponentName(Type type, object instance)
		{
			return this.GetTypeData(type, true).GetComponentName(instance);
		}

		// Token: 0x06001AA8 RID: 6824 RVA: 0x0004A074 File Offset: 0x00048274
		internal TypeConverter GetConverter(Type type, object instance)
		{
			return this.GetTypeData(type, true).GetConverter(instance);
		}

		// Token: 0x06001AA9 RID: 6825 RVA: 0x0004A090 File Offset: 0x00048290
		internal EventDescriptor GetDefaultEvent(Type type, object instance)
		{
			return this.GetTypeData(type, true).GetDefaultEvent(instance);
		}

		// Token: 0x06001AAA RID: 6826 RVA: 0x0004A0AC File Offset: 0x000482AC
		internal PropertyDescriptor GetDefaultProperty(Type type, object instance)
		{
			return this.GetTypeData(type, true).GetDefaultProperty(instance);
		}

		// Token: 0x06001AAB RID: 6827 RVA: 0x0004A0C8 File Offset: 0x000482C8
		internal object GetEditor(Type type, object instance, Type editorBaseType)
		{
			return this.GetTypeData(type, true).GetEditor(instance, editorBaseType);
		}

		// Token: 0x06001AAC RID: 6828 RVA: 0x0004A0E4 File Offset: 0x000482E4
		private static Hashtable GetEditorTable(Type editorBaseType)
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
			if (num == 0)
			{
			}
			if (false)
			{
				throw new OutOfMemoryException();
			}
			if (!false)
			{
				throw new InvalidCastException();
			}
			throw new OutOfMemoryException();
		}

		// Token: 0x06001AAD RID: 6829 RVA: 0x0004A138 File Offset: 0x00048338
		internal EventDescriptorCollection GetEvents(Type type)
		{
			return this.GetTypeData(type, true).GetEvents();
		}

		// Token: 0x06001AAE RID: 6830 RVA: 0x0004A154 File Offset: 0x00048354
		internal AttributeCollection GetExtendedAttributes(object instance)
		{
			/*
An exception occurred when decompiling this method (06001AAE)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.ComponentModel.AttributeCollection System.ComponentModel.ReflectTypeDescriptionProvider::GetExtendedAttributes(System.Object)

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

		// Token: 0x06001AAF RID: 6831 RVA: 0x0004A164 File Offset: 0x00048364
		internal string GetExtendedClassName(object instance)
		{
			/*
An exception occurred when decompiling this method (06001AAF)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.String System.ComponentModel.ReflectTypeDescriptionProvider::GetExtendedClassName(System.Object)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:Type(var_0_06, call:Type(object::GetType, ldloc:object(instance)))
	stloc:Type(var_1_14, ldfld:Type(ReflectedTypeData::_type, call:ReflectedTypeData(ReflectTypeDescriptionProvider::GetTypeData, ldloc:ReflectTypeDescriptionProvider(this), ldloc:Type(var_0_06), ldc.i4:bool(1))))
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

		// Token: 0x06001AB0 RID: 6832 RVA: 0x0004A188 File Offset: 0x00048388
		internal string GetExtendedComponentName(object instance)
		{
			Type type = instance.GetType();
			return this.GetTypeData(type, true).GetComponentName(instance);
		}

		// Token: 0x06001AB1 RID: 6833 RVA: 0x0004A1AC File Offset: 0x000483AC
		internal TypeConverter GetExtendedConverter(object instance)
		{
			Type type = instance.GetType();
			return this.GetTypeData(type, true).GetConverter(instance);
		}

		// Token: 0x06001AB2 RID: 6834 RVA: 0x0004A1D0 File Offset: 0x000483D0
		internal EventDescriptor GetExtendedDefaultEvent(object instance)
		{
		}

		// Token: 0x06001AB3 RID: 6835 RVA: 0x0004A1E0 File Offset: 0x000483E0
		internal PropertyDescriptor GetExtendedDefaultProperty(object instance)
		{
		}

		// Token: 0x06001AB4 RID: 6836 RVA: 0x0004A1F0 File Offset: 0x000483F0
		internal object GetExtendedEditor(object instance, Type editorBaseType)
		{
			Type type = instance.GetType();
			return this.GetTypeData(type, true).GetEditor(instance, editorBaseType);
		}

		// Token: 0x06001AB5 RID: 6837 RVA: 0x0004A214 File Offset: 0x00048414
		internal EventDescriptorCollection GetExtendedEvents(object instance)
		{
			if (!true)
			{
			}
			return 1;
		}

		// Token: 0x06001AB6 RID: 6838 RVA: 0x0004A228 File Offset: 0x00048428
		internal PropertyDescriptorCollection GetExtendedProperties(object instance)
		{
			/*
An exception occurred when decompiling this method (06001AB6)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.ComponentModel.PropertyDescriptorCollection System.ComponentModel.ReflectTypeDescriptionProvider::GetExtendedProperties(System.Object)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_003F:
	stloc:string(var_8_46, ldfld:string(MemberDescriptor::displayName, ldloc:class System.ComponentModel.PropertyDescriptor[][exp:MemberDescriptor](var_5)))
	brtrue(IL_0000, ldloc:EmptyCustomTypeDescriptor[exp:bool](var_7))
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

		// Token: 0x06001AB7 RID: 6839 RVA: 0x0004A284 File Offset: 0x00048484
		protected internal override IExtenderProvider[] GetExtenderProviders(object instance)
		{
			while (instance == null)
			{
			}
			if (instance != null && instance != null)
			{
				IDictionary cache = TypeDescriptor.GetCache(instance);
				if (instance != null)
				{
				}
				if (instance != null)
				{
				}
			}
			IExtenderProvider[] array;
			return array;
		}

		// Token: 0x06001AB8 RID: 6840 RVA: 0x0004A2AC File Offset: 0x000484AC
		private static IExtenderProvider[] GetExtenders(ICollection components, object instance, IDictionary cache)
		{
			int num = 1;
			if (instance == null || num == 0)
			{
			}
			throw new ArrayTypeMismatchException();
		}

		// Token: 0x06001AB9 RID: 6841 RVA: 0x0004A3B0 File Offset: 0x000485B0
		internal object GetExtendedPropertyOwner(object instance, PropertyDescriptor pd)
		{
			Type type = instance.GetType();
			object obj;
			return obj;
		}

		// Token: 0x06001ABA RID: 6842 RVA: 0x0004A3C8 File Offset: 0x000485C8
		public override ICustomTypeDescriptor GetExtendedTypeDescriptor(object instance)
		{
		}

		// Token: 0x06001ABB RID: 6843 RVA: 0x0004A3D8 File Offset: 0x000485D8
		public override string GetFullComponentName(object component)
		{
			if (component == null || component != null)
			{
			}
			return TypeDescriptor.GetComponentName(component);
		}

		// Token: 0x06001ABC RID: 6844 RVA: 0x0004A3F4 File Offset: 0x000485F4
		internal Type[] GetPopulatedTypes(Module module)
		{
			Hashtable typeData = this._typeData;
			long num = 0L;
			if (typeData != null)
			{
			}
			if (num == 0L)
			{
				throw new InvalidCastException();
			}
			throw new OutOfMemoryException();
		}

		// Token: 0x06001ABD RID: 6845 RVA: 0x0004A438 File Offset: 0x00048638
		internal PropertyDescriptorCollection GetProperties(Type type)
		{
			return this.GetTypeData(type, true).GetProperties();
		}

		// Token: 0x06001ABE RID: 6846 RVA: 0x0004A454 File Offset: 0x00048654
		internal object GetPropertyOwner(Type type, object instance, PropertyDescriptor pd)
		{
			if (!true)
			{
			}
			return TypeDescriptor.GetAssociation(type, instance);
		}

		// Token: 0x06001ABF RID: 6847 RVA: 0x0004A46C File Offset: 0x0004866C
		public override Type GetReflectionType(Type objectType, object instance)
		{
			return objectType;
		}

		// Token: 0x06001AC0 RID: 6848 RVA: 0x0004A47C File Offset: 0x0004867C
		private ReflectTypeDescriptionProvider.ReflectedTypeData GetTypeData(Type type, bool createIfNeeded)
		{
			for (;;)
			{
				Hashtable typeData = this._typeData;
				if (typeData != null && typeData != null)
				{
					break;
				}
				Hashtable typeData2 = this._typeData;
				if (typeData2 == null)
				{
					goto IL_0026;
				}
				if (typeData2 != null)
				{
					goto Block_3;
				}
			}
			throw new InvalidCastException();
			Block_3:
			throw new InvalidCastException();
			IL_0026:
			long num;
			if (!false)
			{
				if (this._typeData == null)
				{
				}
				num = 0L;
			}
			if (num == 0L)
			{
			}
			throw new OutOfMemoryException();
		}

		// Token: 0x06001AC1 RID: 6849 RVA: 0x0004A4D0 File Offset: 0x000486D0
		public override ICustomTypeDescriptor GetTypeDescriptor(Type objectType, object instance)
		{
		}

		// Token: 0x06001AC2 RID: 6850 RVA: 0x0004A4E0 File Offset: 0x000486E0
		private static Type GetTypeFromName(string typeName)
		{
			if (!true)
			{
				return;
			}
		}

		// Token: 0x06001AC3 RID: 6851 RVA: 0x0004A4F4 File Offset: 0x000486F4
		internal bool IsPopulated(Type type)
		{
			/*
An exception occurred when decompiling this method (06001AC3)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean System.ComponentModel.ReflectTypeDescriptionProvider::IsPopulated(System.Type)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:AttributeCollection(var_2_14, ldfld:AttributeCollection(ReflectedTypeData::_attributes, ldloc:ReflectedTypeData(var_1_0A)))
	stloc:EventDescriptorCollection(var_3_1B, ldfld:EventDescriptorCollection(ReflectedTypeData::_events, ldloc:ReflectedTypeData(var_1_0A)))
	stloc:PropertyDescriptorCollection(var_4_22, ldfld:PropertyDescriptorCollection(ReflectedTypeData::_properties, ldloc:ReflectedTypeData(var_1_0A)))
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

		// Token: 0x06001AC4 RID: 6852 RVA: 0x0004A524 File Offset: 0x00048724
		private static Attribute[] ReflectGetAttributes(Type type)
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
			if (!false)
			{
				throw new InvalidCastException();
			}
			throw new OutOfMemoryException();
		}

		// Token: 0x06001AC5 RID: 6853 RVA: 0x0004A570 File Offset: 0x00048770
		internal static Attribute[] ReflectGetAttributes(MemberInfo member)
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
			if (!false)
			{
				throw new InvalidCastException();
			}
			throw new OutOfMemoryException();
		}

		// Token: 0x06001AC6 RID: 6854 RVA: 0x0004A5B8 File Offset: 0x000487B8
		private static EventDescriptor[] ReflectGetEvents(Type type)
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
			if (!false)
			{
				throw new InvalidCastException();
			}
			throw new OutOfMemoryException();
		}

		// Token: 0x06001AC7 RID: 6855 RVA: 0x0004A624 File Offset: 0x00048824
		private static PropertyDescriptor[] ReflectGetExtendedProperties(IExtenderProvider provider)
		{
			int num = 1;
			if (num == 0)
			{
			}
			IDictionary dictionary;
			if (dictionary != null)
			{
				if (num == 0)
				{
				}
				if (dictionary != null)
				{
					throw new ArrayTypeMismatchException();
				}
			}
			if (dictionary == null || dictionary != null)
			{
				throw new InvalidCastException();
			}
			throw new InvalidCastException();
		}

		// Token: 0x06001AC8 RID: 6856 RVA: 0x0004A768 File Offset: 0x00048968
		private static PropertyDescriptor[] ReflectGetProperties(Type type)
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
			if (!false)
			{
				throw new InvalidCastException();
			}
			throw new OutOfMemoryException();
		}

		// Token: 0x06001AC9 RID: 6857 RVA: 0x0004A7E4 File Offset: 0x000489E4
		internal void Refresh(Type type)
		{
			long num = 0L;
			if (this.GetTypeData(type, num != 0L) != null)
			{
			}
		}

		// Token: 0x06001ACA RID: 6858 RVA: 0x0004A800 File Offset: 0x00048A00
		private static object SearchIntrinsicTable(Hashtable table, Type callingType)
		{
			int num = 1;
			if (num == 0)
			{
			}
			if (num == 0)
			{
			}
			Type type;
			bool flag = type != type;
			long num2;
			if (!flag || !flag)
			{
				bool value = flag.m_value;
				bool value2 = flag.m_value;
				bool value3 = flag.m_value;
				if (value3)
				{
				}
				if (!value3)
				{
				}
				while (!flag)
				{
				}
				while (!flag)
				{
				}
				num2 = 0L;
				if (!flag)
				{
					goto IL_004D;
				}
			}
			bool value4 = flag.m_value;
			IL_004D:
			if (num2 == 0L)
			{
				if (num2 != 0L)
				{
					long num3 = 0L;
					bool flag2;
					Monitor.Exit(flag2);
					if (num3 != 0L)
					{
						throw new OutOfMemoryException();
					}
				}
				Type type2;
				while (type2 != null)
				{
				}
				throw new InvalidCastException();
			}
			throw new OutOfMemoryException();
		}

		// Token: 0x06001ACB RID: 6859 RVA: 0x0004A8B0 File Offset: 0x00048AB0
		// Note: this type is marked as 'beforefieldinit'.
		static ReflectTypeDescriptionProvider()
		{
			Type type;
			if (type == null || type != null)
			{
				Guid guid = Guid.NewGuid();
				Guid guid2 = Guid.NewGuid();
				Guid guid3 = Guid.NewGuid();
				Type type2;
				Type type3;
				Type type4;
				if ((type2 == null || type2 != null) && (type3 == null || type3 != null) && (type4 == null || type4 != null))
				{
					return;
				}
			}
			throw new ArrayTypeMismatchException();
		}

		// Token: 0x04001336 RID: 4918
		private Hashtable _typeData;

		// Token: 0x04001337 RID: 4919
		private static Type[] _typeConstructor;

		// Token: 0x04001338 RID: 4920
		private static Hashtable _editorTables;

		// Token: 0x04001339 RID: 4921
		private static Hashtable _intrinsicTypeConverters;

		// Token: 0x0400133A RID: 4922
		private static object _intrinsicReferenceKey;

		// Token: 0x0400133B RID: 4923
		private static object _intrinsicNullableKey;

		// Token: 0x0400133C RID: 4924
		private static object _dictionaryKey;

		// Token: 0x0400133D RID: 4925
		private static Hashtable _propertyCache;

		// Token: 0x0400133E RID: 4926
		private static Hashtable _eventCache;

		// Token: 0x0400133F RID: 4927
		private static Hashtable _attributeCache;

		// Token: 0x04001340 RID: 4928
		private static Hashtable _extendedPropertyCache;

		// Token: 0x04001341 RID: 4929
		private static readonly Guid _extenderProviderKey;

		// Token: 0x04001342 RID: 4930
		private static readonly Guid _extenderPropertiesKey;

		// Token: 0x04001343 RID: 4931
		private static readonly Guid _extenderProviderPropertiesKey;

		// Token: 0x04001344 RID: 4932
		private static readonly Type[] _skipInterfaceAttributeList;

		// Token: 0x04001345 RID: 4933
		private static object _internalSyncObject;

		// Token: 0x020003EB RID: 1003
		private class ReflectedTypeData
		{
			// Token: 0x06001ACC RID: 6860 RVA: 0x0004A8FC File Offset: 0x00048AFC
			internal ReflectedTypeData(Type type)
			{
				this._type = type;
			}

			// Token: 0x17000626 RID: 1574
			// (get) Token: 0x06001ACD RID: 6861 RVA: 0x0004A918 File Offset: 0x00048B18
			internal bool IsPopulated
			{
				get
				{
					/*
An exception occurred when decompiling this method (06001ACD)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean System.ComponentModel.ReflectTypeDescriptionProvider/ReflectedTypeData::get_IsPopulated()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:AttributeCollection(var_0_06, ldfld:AttributeCollection(ReflectedTypeData::_attributes, ldloc:ReflectedTypeData(this)))
	stloc:EventDescriptorCollection(var_1_0D, ldfld:EventDescriptorCollection(ReflectedTypeData::_events, ldloc:ReflectedTypeData(this)))
	stloc:PropertyDescriptorCollection(var_2_14, ldfld:PropertyDescriptorCollection(ReflectedTypeData::_properties, ldloc:ReflectedTypeData(this)))
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

			// Token: 0x06001ACE RID: 6862 RVA: 0x0004A93C File Offset: 0x00048B3C
			internal AttributeCollection GetAttributes()
			{
				int num;
				do
				{
					num = 1;
				}
				while (this._attributes != null);
				Type type = this._type;
				if (num == 0)
				{
				}
				Attribute[] array = ReflectTypeDescriptionProvider.ReflectGetAttributes(type);
				Type type2 = this._type;
				if (type2 == null)
				{
				}
				if (type2 == null)
				{
				}
				if (type2 == null)
				{
				}
				Type type3 = this._type;
				AttributeCollection attributeCollection;
				int count = attributeCollection.Count;
				int count2 = attributeCollection.Count;
				return attributeCollection;
			}

			// Token: 0x06001ACF RID: 6863 RVA: 0x0004A99C File Offset: 0x00048B9C
			internal string GetClassName(object instance)
			{
				/*
An exception occurred when decompiling this method (06001ACF)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.String System.ComponentModel.ReflectTypeDescriptionProvider/ReflectedTypeData::GetClassName(System.Object)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:Type(var_0_06, ldfld:Type(ReflectedTypeData::_type, ldloc:ReflectedTypeData(this)))
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

			// Token: 0x06001AD0 RID: 6864 RVA: 0x0004A9B0 File Offset: 0x00048BB0
			internal string GetComponentName(object instance)
			{
				while (instance != null && instance != null && instance == null)
				{
				}
			}

			// Token: 0x06001AD1 RID: 6865 RVA: 0x0004A9C8 File Offset: 0x00048BC8
			internal TypeConverter GetConverter(object instance)
			{
				int num = 1;
				Type type2;
				object obj;
				if (instance != null)
				{
					Type type = this._type;
					if (num == 0)
					{
					}
					if (TypeDescriptor.GetAttributes(type) != null)
					{
					}
					AttributeCollection attributes = TypeDescriptor.GetAttributes(instance);
					if (attributes != null)
					{
					}
					Attribute[] attributes2 = attributes._attributes;
					type2 = this._type;
					Type type3;
					obj = ReflectTypeDescriptionProvider.CreateInstance(type3, type2);
					if (obj == null)
					{
						goto IL_008C;
					}
				}
				long num2 = 0L;
				if (obj == null)
				{
					AttributeCollection attributeCollection;
					if (num2 == 0L)
					{
						RuntimeTypeHandle impl = type2._impl;
						if (attributeCollection == null)
						{
							goto IL_006E;
						}
					}
					Attribute[] attributes3 = attributeCollection._attributes;
					RuntimeTypeHandle impl2 = type2._impl;
					object obj2;
					if (obj2 == null)
					{
						goto IL_008C;
					}
					IL_006E:
					if (obj2 == null)
					{
						Hashtable intrinsicTypeConverters = ReflectTypeDescriptionProvider.IntrinsicTypeConverters;
						RuntimeTypeHandle impl3 = type2._impl;
						object obj3;
						if (obj3 != null)
						{
							throw new InvalidCastException();
						}
					}
				}
				IL_008C:
				throw new InvalidCastException();
			}

			// Token: 0x06001AD2 RID: 6866 RVA: 0x0004AA68 File Offset: 0x00048C68
			internal EventDescriptor GetDefaultEvent(object instance)
			{
				if (instance != null)
				{
					if (!true)
					{
					}
					AttributeCollection attributes = TypeDescriptor.GetAttributes(instance);
				}
				Type type = this._type;
				if (!true)
				{
				}
				AttributeCollection attributes2 = TypeDescriptor.GetAttributes(type);
				if (!true)
				{
				}
				Attribute[] attributes3;
				if (attributes2 != null)
				{
					attributes3 = attributes2._attributes;
					if (attributes3 != null)
					{
						if (instance != null)
						{
							if (attributes3 == null)
							{
							}
							EventDescriptorCollection events = TypeDescriptor.GetEvents(instance);
						}
					}
				}
				Type type2 = this._type;
				if (attributes3 == null)
				{
				}
				EventDescriptorCollection events2 = TypeDescriptor.GetEvents(type2);
				Attribute[] attributes4 = attributes2._attributes;
				throw new InvalidCastException();
			}

			// Token: 0x06001AD3 RID: 6867 RVA: 0x0004AADC File Offset: 0x00048CDC
			internal PropertyDescriptor GetDefaultProperty(object instance)
			{
				if (instance != null)
				{
					if (!true)
					{
					}
					AttributeCollection attributes = TypeDescriptor.GetAttributes(instance);
				}
				Type type = this._type;
				if (!true)
				{
				}
				AttributeCollection attributes2 = TypeDescriptor.GetAttributes(type);
				if (!true)
				{
				}
				Attribute[] attributes3;
				if (attributes2 != null)
				{
					attributes3 = attributes2._attributes;
					if (attributes3 != null)
					{
						if (instance != null)
						{
							if (attributes3 == null)
							{
							}
							PropertyDescriptorCollection properties = TypeDescriptor.GetProperties(instance);
						}
					}
				}
				Type type2 = this._type;
				if (attributes3 == null)
				{
				}
				PropertyDescriptorCollection properties2 = TypeDescriptor.GetProperties(type2);
				Attribute[] attributes4 = attributes2._attributes;
				throw new InvalidCastException();
			}

			// Token: 0x06001AD4 RID: 6868 RVA: 0x0004AB50 File Offset: 0x00048D50
			internal object GetEditor(object instance, Type editorBaseType)
			{
				int num = 1;
				Type type2;
				if (instance != null)
				{
					Type type = this._type;
					if (num == 0)
					{
					}
					EditorAttribute editorAttribute = ReflectTypeDescriptionProvider.ReflectedTypeData.GetEditorAttribute(TypeDescriptor.GetAttributes(type), editorBaseType);
					string <EditorTypeName>k__BackingField = ReflectTypeDescriptionProvider.ReflectedTypeData.GetEditorAttribute(TypeDescriptor.GetAttributes(instance), editorBaseType).<EditorTypeName>k__BackingField;
					Type typeFromName = this.GetTypeFromName(<EditorTypeName>k__BackingField);
					type2 = this._type;
					return ReflectTypeDescriptionProvider.CreateInstance(typeFromName, type2);
				}
				long num2 = 0L;
				int num3 = 6;
				Monitor.Exit(type2);
				if (num2 == 0L && num3 == 0)
				{
					RuntimeTypeHandle impl = type2._impl;
					AttributeCollection attributeCollection;
					EditorAttribute editorAttribute2 = ReflectTypeDescriptionProvider.ReflectedTypeData.GetEditorAttribute(attributeCollection, editorBaseType);
					if (editorAttribute2 != null)
					{
						string <EditorTypeName>k__BackingField2 = editorAttribute2.<EditorTypeName>k__BackingField;
						RuntimeTypeHandle impl2 = type2._impl;
						object obj;
						if (obj != null)
						{
							goto IL_00A3;
						}
					}
					if (ReflectTypeDescriptionProvider.GetEditorTable(editorBaseType) == null)
					{
						goto IL_00C2;
					}
					RuntimeTypeHandle impl3 = type2._impl;
					object obj2;
					if (obj2 == null)
					{
						goto IL_00C2;
					}
					IL_00A3:
					long num4 = 0L;
					if (editorBaseType == null)
					{
						throw new ArrayTypeMismatchException();
					}
					if (num4 != 0L && num4 == 0L)
					{
						throw new ArrayTypeMismatchException();
					}
					long num5 = 0L;
					Monitor.Exit(type2);
					if (num5 != 0L)
					{
						throw new OutOfMemoryException();
					}
				}
				IL_00C2:
				throw new OutOfMemoryException();
			}

			// Token: 0x06001AD5 RID: 6869 RVA: 0x0004AC64 File Offset: 0x00048E64
			private static EditorAttribute GetEditorAttribute(AttributeCollection attributes, Type editorBaseType)
			{
				IEnumerator enumerator;
				while (enumerator == null)
				{
				}
				long num = 0L;
				if (enumerator != null)
				{
				}
				if (num == 0L)
				{
					throw new InvalidCastException();
				}
				throw new OutOfMemoryException();
			}

			// Token: 0x06001AD6 RID: 6870 RVA: 0x0004AC9C File Offset: 0x00048E9C
			internal EventDescriptorCollection GetEvents()
			{
				/*
An exception occurred when decompiling this method (06001AD6)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.ComponentModel.EventDescriptorCollection System.ComponentModel.ReflectTypeDescriptionProvider/ReflectedTypeData::GetEvents()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:Type(var_0_0E, ldfld:Type(ReflectedTypeData::_type, ldloc:ReflectedTypeData(this)))
	stloc:string(var_2_1A, ldfld:string(MemberDescriptor::displayName, call:class System.ComponentModel.EventDescriptor[][exp:MemberDescriptor](ReflectTypeDescriptionProvider::ReflectGetEvents, ldloc:Type(var_0_0E))))
	stloc:bool(var_5_24, call:bool(Type::op_Inequality, ldloc:Type(var_0_0E), ldloc:Type(var_1)))
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

			// Token: 0x06001AD7 RID: 6871 RVA: 0x0004ACD0 File Offset: 0x00048ED0
			internal PropertyDescriptorCollection GetProperties()
			{
				/*
An exception occurred when decompiling this method (06001AD7)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.ComponentModel.PropertyDescriptorCollection System.ComponentModel.ReflectTypeDescriptionProvider/ReflectedTypeData::GetProperties()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:Type(var_0_0E, ldfld:Type(ReflectedTypeData::_type, ldloc:ReflectedTypeData(this)))
	stloc:string(var_2_1A, ldfld:string(MemberDescriptor::displayName, call:class System.ComponentModel.PropertyDescriptor[][exp:MemberDescriptor](ReflectTypeDescriptionProvider::ReflectGetProperties, ldloc:Type(var_0_0E))))
	stloc:bool(var_5_24, call:bool(Type::op_Inequality, ldloc:Type(var_0_0E), ldloc:Type(var_1)))
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

			// Token: 0x06001AD8 RID: 6872 RVA: 0x0004AD04 File Offset: 0x00048F04
			private Type GetTypeFromName(string typeName)
			{
				if (typeName != null && typeName._stringLength != 0)
				{
					Type type = this._type;
					long num = 0L;
					int num2;
					string text = typeName.Substring((int)num, num2);
					return;
				}
			}

			// Token: 0x06001AD9 RID: 6873 RVA: 0x0004AD34 File Offset: 0x00048F34
			internal void Refresh()
			{
			}

			// Token: 0x04001346 RID: 4934
			private Type _type;

			// Token: 0x04001347 RID: 4935
			private AttributeCollection _attributes;

			// Token: 0x04001348 RID: 4936
			private EventDescriptorCollection _events;

			// Token: 0x04001349 RID: 4937
			private PropertyDescriptorCollection _properties;

			// Token: 0x0400134A RID: 4938
			private TypeConverter _converter;

			// Token: 0x0400134B RID: 4939
			private object[] _editors;

			// Token: 0x0400134C RID: 4940
			private Type[] _editorTypes;

			// Token: 0x0400134D RID: 4941
			private int _editorCount;
		}
	}
}
