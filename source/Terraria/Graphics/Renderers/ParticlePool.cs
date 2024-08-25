using System;
using System.Collections.Generic;
using Cpp2IlInjected;

namespace Terraria.Graphics.Renderers
{
	// Token: 0x02000750 RID: 1872
	public class ParticlePool<T> where T : IPooledParticle
	{
		// Token: 0x06003DB0 RID: 15792 RVA: 0x00239E04 File Offset: 0x00238004
		public int CountParticlesInUse()
		{
		}

		// Token: 0x06003DB1 RID: 15793 RVA: 0x00239E14 File Offset: 0x00238014
		public ParticlePool(int initialPoolSize, ParticlePool<T>.ParticleInstantiator instantiator)
		{
			this._instantiator = instantiator;
			this._particles = this;
		}

		// Token: 0x06003DB2 RID: 15794 RVA: 0x00239E38 File Offset: 0x00238038
		public T RequestParticle()
		{
			/*
An exception occurred when decompiling this method (06003DB2)

ICSharpCode.Decompiler.DecompilerException: Error decompiling T Terraria.Graphics.Renderers.ParticlePool`1::RequestParticle()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:List`1(var_0_06, ldfld:class [mscorlib]System.Collections.Generic.List`1<!T>[exp:List`1](ParticlePool`1::_particles, ldloc:ParticlePool`1(this)))
	stloc:List`1(var_2_0F, ldfld:class [mscorlib]System.Collections.Generic.List`1<!T>[exp:List`1](ParticlePool`1::_particles, ldloc:ParticlePool`1(this)))
	stloc:ParticleInstantiator(var_3_16, ldfld:class Terraria.Graphics.Renderers.ParticlePool`1/ParticleInstantiator<!T>[exp:ParticleInstantiator](ParticlePool`1::_instantiator, ldloc:ParticlePool`1(this)))
	stloc:List`1(var_4_1D, ldfld:class [mscorlib]System.Collections.Generic.List`1<!T>[exp:List`1](ParticlePool`1::_particles, ldloc:ParticlePool`1(this)))
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

		// Token: 0x04007C6D RID: 31853
		private ParticlePool<T>.ParticleInstantiator _instantiator;

		// Token: 0x04007C6E RID: 31854
		private List<T> _particles;

		// Token: 0x02000751 RID: 1873
		public sealed class ParticleInstantiator : MulticastDelegate
		{
			// Token: 0x06003DB3 RID: 15795 RVA: 0x00239E64 File Offset: 0x00238064
			public ParticleInstantiator(object @object, IntPtr method)
			{
			}

			// Token: 0x06003DB4 RID: 15796 RVA: 0x000021DB File Offset: 0x000003DB
			public T Invoke()
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}

			// Token: 0x06003DB5 RID: 15797 RVA: 0x000021DB File Offset: 0x000003DB
			public IAsyncResult BeginInvoke(AsyncCallback callback, object @object)
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}

			// Token: 0x06003DB6 RID: 15798 RVA: 0x000021DB File Offset: 0x000003DB
			public T EndInvoke(IAsyncResult result)
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}
	}
}
