using System;
using System.Runtime.InteropServices;
using Unity.Jobs;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine.Rendering
{
	// Token: 0x0200011D RID: 285
	[RequiredByNativeCode]
	[NativeHeader("Runtime/Math/Matrix4x4.h")]
	[NativeHeader("Runtime/Camera/BatchRendererGroup.h")]
	[StructLayout(0)]
	public class BatchRendererGroup
	{
		// Token: 0x060005CA RID: 1482 RVA: 0x0000A494 File Offset: 0x00008694
		[RequiredByNativeCode]
		private unsafe static void InvokeOnPerformCulling(BatchRendererGroup group, BatchRendererCullingOutput context, LODParameters lodParameters)
		{
			Plane* cullingPlanes = context.cullingPlanes;
			int cullingPlanesCount = context.cullingPlanesCount;
			int batchVisibilityCount = context.batchVisibilityCount;
			BatchVisibility* batchVisibility = context.batchVisibility;
			int visibleIndicesCount = context.visibleIndicesCount;
			int* visibleIndices = context.visibleIndices;
			int visibleIndicesCount2 = context.visibleIndicesCount;
			int* visibleIndicesY = context.visibleIndicesY;
			BatchRendererGroup.OnPerformCulling performCulling = group.m_PerformCulling;
			float m = context.cullingMatrix.m00;
			float m2 = context.cullingMatrix.m10;
			float m3 = context.cullingMatrix.m02;
			float m4 = context.cullingMatrix.m12;
			float nearPlane = context.nearPlane;
			IntPtr invoke_impl = performCulling.invoke_impl;
			IntPtr method_code = performCulling.method_code;
			IntPtr method = performCulling.method;
			context.cullingJobsFence = method_code;
			JobHandle.ScheduleBatchedJobs();
		}

		// Token: 0x040004CC RID: 1228
		private IntPtr m_GroupHandle;

		// Token: 0x040004CD RID: 1229
		private BatchRendererGroup.OnPerformCulling m_PerformCulling;

		// Token: 0x0200011E RID: 286
		public sealed class OnPerformCulling : MulticastDelegate
		{
			// Token: 0x060005CB RID: 1483 RVA: 0x0000A570 File Offset: 0x00008770
			public OnPerformCulling(object @object, IntPtr method)
			{
				this.method_ptr = method;
				this.m_target = @object;
				this.method = method;
				this.method_code = this;
			}

			// Token: 0x060005CC RID: 1484 RVA: 0x0000A5D0 File Offset: 0x000087D0
			public JobHandle Invoke(BatchRendererGroup rendererGroup, BatchCullingContext cullingContext)
			{
				/*
An exception occurred when decompiling this method (060005CC)

ICSharpCode.Decompiler.DecompilerException: Error decompiling Unity.Jobs.JobHandle UnityEngine.Rendering.BatchRendererGroup/OnPerformCulling::Invoke(UnityEngine.Rendering.BatchRendererGroup,UnityEngine.Rendering.BatchCullingContext)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:native int(var_0_06, ldfld:native int(Delegate::invoke_impl, ldloc:OnPerformCulling[exp:Delegate](this)))
	stloc:native int(var_1_0D, ldfld:native int(Delegate::method_code, ldloc:OnPerformCulling[exp:Delegate](this)))
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
	}
}
