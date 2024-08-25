using System;
using System.Runtime.CompilerServices;
using Unity.Collections;
using UnityEngine.Scripting;

namespace UnityEngine.Experimental.GlobalIllumination
{
	// Token: 0x02000137 RID: 311
	public static class Lightmapping
	{
		// Token: 0x06000600 RID: 1536 RVA: 0x0000AE5C File Offset: 0x0000905C
		[RequiredByNativeCode]
		public static void SetDelegate(Lightmapping.RequestLightsDelegate del)
		{
			if (del != null || !true)
			{
			}
			if (!true)
			{
			}
		}

		// Token: 0x06000601 RID: 1537 RVA: 0x0000AE74 File Offset: 0x00009074
		[RequiredByNativeCode]
		public static Lightmapping.RequestLightsDelegate GetDelegate()
		{
			/*
An exception occurred when decompiling this method (06000601)

ICSharpCode.Decompiler.DecompilerException: Error decompiling UnityEngine.Experimental.GlobalIllumination.Lightmapping/RequestLightsDelegate UnityEngine.Experimental.GlobalIllumination.Lightmapping::GetDelegate()

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

		// Token: 0x06000602 RID: 1538 RVA: 0x0000AE84 File Offset: 0x00009084
		[RequiredByNativeCode]
		public static void ResetDelegate()
		{
			if (!true)
			{
			}
		}

		// Token: 0x06000603 RID: 1539 RVA: 0x0000AE94 File Offset: 0x00009094
		[RequiredByNativeCode]
		internal unsafe static void RequestLights(Light[] lights, IntPtr outLightsPtr, int outLightsCount)
		{
			void* ptr = (void*)outLightsPtr;
			if (!true)
			{
			}
		}

		// Token: 0x06000604 RID: 1540 RVA: 0x0000AEAC File Offset: 0x000090AC
		// Note: this type is marked as 'beforefieldinit'.
		static Lightmapping()
		{
			if (!true)
			{
			}
		}

		// Token: 0x0400055B RID: 1371
		[RequiredByNativeCode]
		private static readonly Lightmapping.RequestLightsDelegate s_DefaultDelegate;

		// Token: 0x0400055C RID: 1372
		[RequiredByNativeCode]
		private static Lightmapping.RequestLightsDelegate s_RequestLightsDelegate;

		// Token: 0x02000138 RID: 312
		public sealed class RequestLightsDelegate : MulticastDelegate
		{
			// Token: 0x06000605 RID: 1541 RVA: 0x0000AEBC File Offset: 0x000090BC
			public RequestLightsDelegate(object @object, IntPtr method)
			{
				this.method_ptr = method;
				this.m_target = @object;
				this.method = method;
				this.method_code = this;
			}

			// Token: 0x06000606 RID: 1542 RVA: 0x0000AF10 File Offset: 0x00009110
			public void Invoke(Light[] requests, NativeArray<LightDataGI> lightsOutput)
			{
				IntPtr method_code = this.method_code;
				IntPtr invoke_impl = this.invoke_impl;
				IntPtr method = this.method;
			}
		}

		// Token: 0x02000139 RID: 313
		[CompilerGenerated]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x06000607 RID: 1543 RVA: 0x0000AF34 File Offset: 0x00009134
			// Note: this type is marked as 'beforefieldinit'.
			static <>c()
			{
			}

			// Token: 0x06000608 RID: 1544 RVA: 0x0000AF44 File Offset: 0x00009144
			public <>c()
			{
			}

			// Token: 0x06000609 RID: 1545 RVA: 0x0000AF58 File Offset: 0x00009158
			internal void <.cctor>b__7_0(Light[] requests, NativeArray<LightDataGI> lightsOutput)
			{
				int bakedIndex = requests.m_BakedIndex;
			}

			// Token: 0x0400055D RID: 1373
			public static readonly Lightmapping.<>c <>9;
		}
	}
}
