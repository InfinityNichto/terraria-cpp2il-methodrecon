using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace UnityEngine
{
	// Token: 0x020000C1 RID: 193
	public class WaitForSecondsRealtime : CustomYieldInstruction
	{
		// Token: 0x170000B2 RID: 178
		// (get) Token: 0x0600034D RID: 845 RVA: 0x00006CD8 File Offset: 0x00004ED8
		// (set) Token: 0x0600034E RID: 846 RVA: 0x00006CEC File Offset: 0x00004EEC
		public float waitTime
		{
			[CompilerGenerated]
			get
			{
				/*
An exception occurred when decompiling this method (0600034D)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Single UnityEngine.WaitForSecondsRealtime::get_waitTime()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:float32(var_0_06, ldfld:float32(WaitForSecondsRealtime::<waitTime>k__BackingField, ldloc:WaitForSecondsRealtime(this)))
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
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170000B3 RID: 179
		// (get) Token: 0x0600034F RID: 847 RVA: 0x00006CFC File Offset: 0x00004EFC
		public override bool keepWaiting
		{
			get
			{
				float waitUntilTime = this.m_WaitUntilTime;
				throw new MissingMethodException();
			}
		}

		// Token: 0x06000350 RID: 848 RVA: 0x00006D30 File Offset: 0x00004F30
		public WaitForSecondsRealtime(float time)
		{
		}

		// Token: 0x06000351 RID: 849 RVA: 0x00006D50 File Offset: 0x00004F50
		public override void Reset()
		{
			this.m_WaitUntilTime = (float)49024;
		}

		// Token: 0x04000374 RID: 884
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		private float <waitTime>k__BackingField;

		// Token: 0x04000375 RID: 885
		private float m_WaitUntilTime = (float)49024;
	}
}
