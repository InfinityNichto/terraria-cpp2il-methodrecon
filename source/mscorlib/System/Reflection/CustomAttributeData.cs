using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace System.Reflection
{
	// Token: 0x02000502 RID: 1282
	[ComVisible(true)]
	[Serializable]
	public class CustomAttributeData
	{
		// Token: 0x0600254C RID: 9548 RVA: 0x000526D0 File Offset: 0x000508D0
		protected CustomAttributeData()
		{
		}

		// Token: 0x0600254D RID: 9549 RVA: 0x000526E4 File Offset: 0x000508E4
		internal CustomAttributeData(ConstructorInfo ctorInfo, Assembly assembly, IntPtr data, uint data_length)
		{
			this.ctorInfo = ctorInfo;
		}

		// Token: 0x0600254E RID: 9550 RVA: 0x00052700 File Offset: 0x00050900
		internal CustomAttributeData(ConstructorInfo ctorInfo)
		{
			if (!true)
			{
			}
			if (!true)
			{
			}
			base..ctor();
			this.ctorInfo = ctorInfo;
			this.ctorArgs = 1;
			this.namedArgs = 1;
		}

		// Token: 0x0600254F RID: 9551 RVA: 0x00052730 File Offset: 0x00050930
		internal CustomAttributeData(ConstructorInfo ctorInfo, IList<CustomAttributeTypedArgument> ctorArgs, IList<CustomAttributeNamedArgument> namedArgs)
		{
			this.ctorInfo = ctorInfo;
			this.ctorArgs = ctorArgs;
			this.namedArgs = namedArgs;
		}

		// Token: 0x06002550 RID: 9552 RVA: 0x00052758 File Offset: 0x00050958
		private static void ResolveArgumentsInternal(ConstructorInfo ctor, Assembly assembly, IntPtr data, uint data_length, [Out] object[] ctorArgs, [Out] object[] namedArgs)
		{
		}

		// Token: 0x06002551 RID: 9553 RVA: 0x00052768 File Offset: 0x00050968
		private void ResolveArguments()
		{
			CustomAttributeData.LazyCAttrData lazyCAttrData = this.lazyData;
			if (lazyCAttrData == null)
			{
				return;
			}
			ConstructorInfo constructorInfo = this.ctorInfo;
			Assembly assembly = lazyCAttrData.assembly;
			IntPtr data = lazyCAttrData.data;
			uint data_length = lazyCAttrData.data_length;
			if (constructorInfo != null)
			{
				return;
			}
		}

		// Token: 0x17000526 RID: 1318
		// (get) Token: 0x06002552 RID: 9554 RVA: 0x000527AC File Offset: 0x000509AC
		[ComVisible(true)]
		public virtual ConstructorInfo Constructor
		{
			get
			{
				return this.ctorInfo;
			}
		}

		// Token: 0x17000527 RID: 1319
		// (get) Token: 0x06002553 RID: 9555 RVA: 0x000527C0 File Offset: 0x000509C0
		[ComVisible(true)]
		public virtual IList<CustomAttributeTypedArgument> ConstructorArguments
		{
			get
			{
				this.ResolveArguments();
				return this.ctorArgs;
			}
		}

		// Token: 0x17000528 RID: 1320
		// (get) Token: 0x06002554 RID: 9556 RVA: 0x000527DC File Offset: 0x000509DC
		public virtual IList<CustomAttributeNamedArgument> NamedArguments
		{
			get
			{
				this.ResolveArguments();
				return this.namedArgs;
			}
		}

		// Token: 0x06002555 RID: 9557 RVA: 0x000527F8 File Offset: 0x000509F8
		public static IList<CustomAttributeData> GetCustomAttributes(Assembly target)
		{
			IList<CustomAttributeData> list;
			return list;
		}

		// Token: 0x06002556 RID: 9558 RVA: 0x00052808 File Offset: 0x00050A08
		public static IList<CustomAttributeData> GetCustomAttributes(MemberInfo target)
		{
			if (!true)
			{
			}
			IList<CustomAttributeData> list;
			return list;
		}

		// Token: 0x06002557 RID: 9559 RVA: 0x0005281C File Offset: 0x00050A1C
		internal static IList<CustomAttributeData> GetCustomAttributesInternal(RuntimeType target)
		{
			if (!true)
			{
			}
			IList<CustomAttributeData> list;
			return list;
		}

		// Token: 0x06002558 RID: 9560 RVA: 0x00052830 File Offset: 0x00050A30
		public static IList<CustomAttributeData> GetCustomAttributes(Module target)
		{
			if (!true)
			{
			}
			IList<CustomAttributeData> list;
			return list;
		}

		// Token: 0x06002559 RID: 9561 RVA: 0x00052844 File Offset: 0x00050A44
		public static IList<CustomAttributeData> GetCustomAttributes(ParameterInfo target)
		{
			if (!true)
			{
			}
			IList<CustomAttributeData> list;
			return list;
		}

		// Token: 0x17000529 RID: 1321
		// (get) Token: 0x0600255A RID: 9562 RVA: 0x00052858 File Offset: 0x00050A58
		public Type AttributeType
		{
			get
			{
				/*
An exception occurred when decompiling this method (0600255A)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Type System.Reflection.CustomAttributeData::get_AttributeType()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:ConstructorInfo(var_0_06, ldfld:ConstructorInfo(CustomAttributeData::ctorInfo, ldloc:CustomAttributeData(this)))
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

		// Token: 0x0600255B RID: 9563 RVA: 0x0005286C File Offset: 0x00050A6C
		public override string ToString()
		{
			/*
An exception occurred when decompiling this method (0600255B)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.String System.Reflection.CustomAttributeData::ToString()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	call:void(CustomAttributeData::ResolveArguments, ldloc:CustomAttributeData(this))
	stloc:ConstructorInfo(var_0_0C, ldfld:ConstructorInfo(CustomAttributeData::ctorInfo, ldloc:CustomAttributeData(this)))
	stloc:class System.Collections.Generic.IList`1<valuetype System.Reflection.CustomAttributeTypedArgument>(var_4_15, ldfld:class System.Collections.Generic.IList`1<valuetype System.Reflection.CustomAttributeTypedArgument>(CustomAttributeData::ctorArgs, ldloc:CustomAttributeData(this)))
	stloc:class System.Collections.Generic.IList`1<valuetype System.Reflection.CustomAttributeTypedArgument>(var_5_1D, ldfld:class System.Collections.Generic.IList`1<valuetype System.Reflection.CustomAttributeTypedArgument>(CustomAttributeData::ctorArgs, ldloc:CustomAttributeData(this)))
	stloc:class System.Collections.Generic.IList`1<valuetype System.Reflection.CustomAttributeTypedArgument>(var_9_28, ldfld:class System.Collections.Generic.IList`1<valuetype System.Reflection.CustomAttributeTypedArgument>(CustomAttributeData::ctorArgs, ldloc:CustomAttributeData(this)))
	stloc:class System.Collections.Generic.IList`1<valuetype System.Reflection.CustomAttributeNamedArgument>(var_11_30, ldfld:class System.Collections.Generic.IList`1<valuetype System.Reflection.CustomAttributeNamedArgument>(CustomAttributeData::namedArgs, ldloc:CustomAttributeData(this)))
	stloc:class System.Collections.Generic.IList`1<valuetype System.Reflection.CustomAttributeNamedArgument>(var_14_3B, ldfld:class System.Collections.Generic.IList`1<valuetype System.Reflection.CustomAttributeNamedArgument>(CustomAttributeData::namedArgs, ldloc:CustomAttributeData(this)))
	stloc:class System.Collections.Generic.IList`1<valuetype System.Reflection.CustomAttributeNamedArgument>(var_15_43, ldfld:class System.Collections.Generic.IList`1<valuetype System.Reflection.CustomAttributeNamedArgument>(CustomAttributeData::namedArgs, ldloc:CustomAttributeData(this)))
	stloc:class System.Collections.Generic.IList`1<valuetype System.Reflection.CustomAttributeNamedArgument>(var_18_4B, ldfld:class System.Collections.Generic.IList`1<valuetype System.Reflection.CustomAttributeNamedArgument>(CustomAttributeData::namedArgs, ldloc:CustomAttributeData(this)))
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

		// Token: 0x0600255C RID: 9564 RVA: 0x000528C8 File Offset: 0x00050AC8
		private static T[] UnboxValues<T>(object[] values)
		{
			throw new InvalidCastException();
		}

		// Token: 0x0600255D RID: 9565 RVA: 0x000528DC File Offset: 0x00050ADC
		public override bool Equals(object obj)
		{
			if (obj != null)
			{
				ConstructorInfo constructorInfo = this.ctorInfo;
				IList<CustomAttributeTypedArgument> list = this.ctorArgs;
				IList<CustomAttributeNamedArgument> list2 = this.namedArgs;
				IList<CustomAttributeTypedArgument> list3 = this.ctorArgs;
				IList<CustomAttributeTypedArgument> list4 = this.ctorArgs;
				IList<CustomAttributeNamedArgument> list5 = this.namedArgs;
				IList<CustomAttributeNamedArgument> list6 = this.namedArgs;
				bool flag;
				return flag;
			}
		}

		// Token: 0x0600255E RID: 9566 RVA: 0x00052938 File Offset: 0x00050B38
		public override int GetHashCode()
		{
			int num = 1;
			ConstructorInfo constructorInfo = this.ctorInfo;
			if (num != 0)
			{
				if (constructorInfo == null)
				{
					goto IL_0019;
				}
				ConstructorInfo constructorInfo2 = this.ctorInfo;
			}
			while (constructorInfo != null)
			{
			}
			IL_0019:
			int num2 = 13;
			if (this.ctorArgs != null)
			{
				IList<CustomAttributeTypedArgument> list = this.ctorArgs;
				IList<CustomAttributeTypedArgument> list2 = this.ctorArgs;
				int num3;
				return num3;
			}
			if (this.namedArgs != null)
			{
				IList<CustomAttributeNamedArgument> list3 = this.namedArgs;
				IList<CustomAttributeNamedArgument> list4 = this.namedArgs;
				int num4;
				return num4;
			}
			return num2;
		}

		// Token: 0x040014BC RID: 5308
		private ConstructorInfo ctorInfo;

		// Token: 0x040014BD RID: 5309
		private IList<CustomAttributeTypedArgument> ctorArgs;

		// Token: 0x040014BE RID: 5310
		private IList<CustomAttributeNamedArgument> namedArgs;

		// Token: 0x040014BF RID: 5311
		private CustomAttributeData.LazyCAttrData lazyData;

		// Token: 0x02000503 RID: 1283
		private class LazyCAttrData
		{
			// Token: 0x0600255F RID: 9567 RVA: 0x000529A0 File Offset: 0x00050BA0
			public LazyCAttrData()
			{
			}

			// Token: 0x040014C0 RID: 5312
			internal Assembly assembly;

			// Token: 0x040014C1 RID: 5313
			internal IntPtr data;

			// Token: 0x040014C2 RID: 5314
			internal uint data_length;
		}
	}
}
