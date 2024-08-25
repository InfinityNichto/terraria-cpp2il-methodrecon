using System;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using Cpp2IlInjected;

namespace System.Reflection
{
	// Token: 0x02000510 RID: 1296
	[ClassInterface(ClassInterfaceType.None)]
	[ComVisible(true)]
	[ComDefaultInterface(typeof(_Module))]
	[Serializable]
	[StructLayout(0)]
	internal class RuntimeModule : Module
	{
		// Token: 0x1700055D RID: 1373
		// (get) Token: 0x06002626 RID: 9766 RVA: 0x000537B4 File Offset: 0x000519B4
		public override Assembly Assembly
		{
			get
			{
				return this.assembly;
			}
		}

		// Token: 0x1700055E RID: 1374
		// (get) Token: 0x06002627 RID: 9767 RVA: 0x000537C8 File Offset: 0x000519C8
		public override string ScopeName
		{
			get
			{
				return this.scopename;
			}
		}

		// Token: 0x1700055F RID: 1375
		// (get) Token: 0x06002628 RID: 9768 RVA: 0x0000207A File Offset: 0x0000027A
		public override Guid ModuleVersionId
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		// Token: 0x17000560 RID: 1376
		// (get) Token: 0x06002629 RID: 9769 RVA: 0x000537DC File Offset: 0x000519DC
		public override string FullyQualifiedName
		{
			get
			{
				return this.fqname;
			}
		}

		// Token: 0x0600262A RID: 9770 RVA: 0x000537F0 File Offset: 0x000519F0
		public override bool IsResource()
		{
			return this.is_resource;
		}

		// Token: 0x0600262B RID: 9771 RVA: 0x00053804 File Offset: 0x00051A04
		public override object[] GetCustomAttributes(bool inherit)
		{
			if (!true)
			{
			}
			return MonoCustomAttrs.GetCustomAttributes(this, inherit);
		}

		// Token: 0x0600262C RID: 9772 RVA: 0x0005381C File Offset: 0x00051A1C
		public override object[] GetCustomAttributes(Type attributeType, bool inherit)
		{
			if (!true)
			{
			}
			return MonoCustomAttrs.GetCustomAttributes(this, attributeType, inherit);
		}

		// Token: 0x0600262D RID: 9773 RVA: 0x00053834 File Offset: 0x00051A34
		public override bool IsDefined(Type attributeType, bool inherit)
		{
			if (!true)
			{
			}
			return MonoCustomAttrs.IsDefined(this, attributeType, inherit);
		}

		// Token: 0x0600262E RID: 9774 RVA: 0x0005384C File Offset: 0x00051A4C
		public override void GetObjectData(SerializationInfo info, StreamingContext context)
		{
			while (info == null)
			{
			}
			RuntimeAssembly runtimeAssembly = this.GetRuntimeAssembly();
		}

		// Token: 0x0600262F RID: 9775 RVA: 0x00053864 File Offset: 0x00051A64
		internal RuntimeAssembly GetRuntimeAssembly()
		{
			if (this.assembly != null)
			{
			}
			throw new InvalidCastException();
		}

		// Token: 0x06002630 RID: 9776 RVA: 0x00053880 File Offset: 0x00051A80
		internal override Guid GetModuleVersionId()
		{
			/*
An exception occurred when decompiling this method (06002630)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Guid System.Reflection.RuntimeModule::GetModuleVersionId()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:native int(var_0_06, ldfld:native int(RuntimeModule::_impl, ldloc:RuntimeModule(this)))
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

		// Token: 0x06002631 RID: 9777 RVA: 0x00053894 File Offset: 0x00051A94
		private static void GetGuidInternal(IntPtr module, byte[] guid)
		{
		}

		// Token: 0x06002632 RID: 9778 RVA: 0x000538A4 File Offset: 0x00051AA4
		public RuntimeModule()
		{
			if (!true)
			{
			}
			base..ctor();
		}

		// Token: 0x040014F8 RID: 5368
		internal IntPtr _impl;

		// Token: 0x040014F9 RID: 5369
		internal Assembly assembly;

		// Token: 0x040014FA RID: 5370
		internal string fqname;

		// Token: 0x040014FB RID: 5371
		internal string name;

		// Token: 0x040014FC RID: 5372
		internal string scopename;

		// Token: 0x040014FD RID: 5373
		internal bool is_resource;

		// Token: 0x040014FE RID: 5374
		internal int token;
	}
}
