using System;
using System.Reflection;
using Cpp2IlInjected;

namespace ReLogic.Utilities
{
	// Token: 0x02000B00 RID: 2816
	public static class AttributeUtilities
	{
		// Token: 0x06005270 RID: 21104 RVA: 0x00282EE8 File Offset: 0x002810E8
		public static T GetAttribute<T>(this MethodBase method) where T : Attribute
		{
			object obj;
			while (obj != null)
			{
				if (obj == null)
				{
					throw new InvalidCastException();
				}
			}
		}

		// Token: 0x06005271 RID: 21105 RVA: 0x00282F04 File Offset: 0x00281104
		public static T GetAttribute<T>(this Enum value) where T : Attribute
		{
			/*
An exception occurred when decompiling this method (06005271)

ICSharpCode.Decompiler.DecompilerException: Error decompiling T ReLogic.Utilities.AttributeUtilities::GetAttribute<T>(System.Enum)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:int64(var_0_01, ldc.i4:int64(0))
	stloc:string(var_2_09, call:string(Enum::GetName, ldloc:Type(var_1), ldloc:int64[exp:object](var_0_01)))
	stloc:FieldInfo(var_3_11, call:FieldInfo(Type::GetField, ldloc:Type(var_1), ldloc:string(var_2_09)))
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

		// Token: 0x06005272 RID: 21106 RVA: 0x000021DB File Offset: 0x000003DB
		public static A GetCacheableAttribute<A, T>() where A : Attribute
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06005273 RID: 21107 RVA: 0x000021DB File Offset: 0x000003DB
		public static T GetAttribute<T>(this Type type) where T : Attribute
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x02000B01 RID: 2817
		private static class TypeAttributeCache<T, A> where A : Attribute
		{
			// Token: 0x06005274 RID: 21108 RVA: 0x00282F24 File Offset: 0x00281124
			// Note: this type is marked as 'beforefieldinit'.
			static TypeAttributeCache()
			{
			}

			// Token: 0x04008AC1 RID: 35521
			public static readonly A Value;
		}
	}
}
