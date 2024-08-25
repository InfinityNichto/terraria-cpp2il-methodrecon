using System;
using Cpp2IlInjected;

namespace Extensions
{
	// Token: 0x020003D3 RID: 979
	public static class EnumerationExtensions
	{
		// Token: 0x06001A8F RID: 6799 RVA: 0x0006CE58 File Offset: 0x0006B058
		public static T Include<T>(this Enum value, T append)
		{
			object obj;
			do
			{
				ulong num2;
				long num = Convert.ToInt64(num2);
				if (obj == null)
				{
					return;
				}
			}
			while (obj != null);
			throw new InvalidCastException();
		}

		// Token: 0x06001A90 RID: 6800 RVA: 0x0006CE7C File Offset: 0x0006B07C
		public static T Remove<T>(this Enum value, T remove)
		{
			object obj;
			do
			{
				ulong num2;
				long num = Convert.ToInt64(num2);
				if (obj == null)
				{
					return;
				}
			}
			while (obj != null);
			throw new InvalidCastException();
		}

		// Token: 0x06001A91 RID: 6801 RVA: 0x0006CEA0 File Offset: 0x0006B0A0
		public static bool Has<T>(this Enum value, T check)
		{
			/*
An exception occurred when decompiling this method (06001A91)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean Extensions.EnumerationExtensions::Has<T>(System.Enum,T)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:uint64(var_3_08, call:uint64(Convert::ToUInt64, ldloc:int64[exp:object](var_2)))
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

		// Token: 0x06001A92 RID: 6802 RVA: 0x000021DB File Offset: 0x000003DB
		public static bool Missing<T>(this Enum obj, T value)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x020003D4 RID: 980
		private class _Value
		{
			// Token: 0x06001A93 RID: 6803 RVA: 0x0006CEB8 File Offset: 0x0006B0B8
			public _Value(object value, Type type)
			{
				Type underlyingType = Enum.GetUnderlyingType(type);
				ulong num = Convert.ToUInt64(value);
			}

			// Token: 0x06001A94 RID: 6804 RVA: 0x0006CEE4 File Offset: 0x0006B0E4
			// Note: this type is marked as 'beforefieldinit'.
			static _Value()
			{
				if (!true)
				{
				}
			}

			// Token: 0x040027EB RID: 10219
			private static Type _UInt64;

			// Token: 0x040027EC RID: 10220
			private static Type _UInt32;

			// Token: 0x040027ED RID: 10221
			public long? Signed;

			// Token: 0x040027EE RID: 10222
			public ulong? Unsigned;
		}
	}
}
