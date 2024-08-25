using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;

namespace UnityEngine.UI.CoroutineTween
{
	// Token: 0x0200008E RID: 142
	internal class TweenRunner<T> where T : struct, ITweenValue
	{
		// Token: 0x06000575 RID: 1397 RVA: 0x00002207 File Offset: 0x00000407
		private static IEnumerator Start(T tweenInfo)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06000576 RID: 1398 RVA: 0x00010E14 File Offset: 0x0000F014
		public void Init(MonoBehaviour coroutineContainer)
		{
			this.m_CoroutineContainer = coroutineContainer;
		}

		// Token: 0x06000577 RID: 1399 RVA: 0x00010E28 File Offset: 0x0000F028
		public void StartTween(T info)
		{
			MonoBehaviour coroutineContainer = this.m_CoroutineContainer;
			if (!true)
			{
			}
			Debug.LogWarning("Coroutine container not configured... did you forget to call Init?");
		}

		// Token: 0x06000578 RID: 1400 RVA: 0x00010E54 File Offset: 0x0000F054
		public void StopTween()
		{
			IEnumerator tween = this.m_Tween;
			if (tween != null)
			{
				this.m_CoroutineContainer.StopCoroutine(tween);
			}
		}

		// Token: 0x06000579 RID: 1401 RVA: 0x00010E78 File Offset: 0x0000F078
		public TweenRunner()
		{
		}

		// Token: 0x04000281 RID: 641
		protected MonoBehaviour m_CoroutineContainer;

		// Token: 0x04000282 RID: 642
		protected IEnumerator m_Tween;

		// Token: 0x0200008F RID: 143
		[CompilerGenerated]
		private sealed class <Start>d__2 : IEnumerator<object>, IEnumerator, IDisposable
		{
			// Token: 0x0600057A RID: 1402 RVA: 0x00010E8C File Offset: 0x0000F08C
			[DebuggerHidden]
			public <Start>d__2(int <>1__state)
			{
				this.<>1__state = <>1__state;
			}

			// Token: 0x0600057B RID: 1403 RVA: 0x00010EA8 File Offset: 0x0000F0A8
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			// Token: 0x0600057C RID: 1404 RVA: 0x00010EB8 File Offset: 0x0000F0B8
			private bool MoveNext()
			{
				/*
An exception occurred when decompiling this method (0600057C)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean UnityEngine.UI.CoroutineTween.TweenRunner`1/<Start>d__2::MoveNext()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0028:
	stloc:float32(var_6_30, callgetter:float32(Time::get_deltaTime))
	stloc:int32(var_7_33, ldc.i4:int32(1))
	stfld:int32('<Start>d__2'::<>1__state, ldloc:'<Start>d__2'(this), ldloc:int32(var_7_33))
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

			// Token: 0x17000167 RID: 359
			// (get) Token: 0x0600057D RID: 1405 RVA: 0x00002207 File Offset: 0x00000407
			object IEnumerator<object>.Current
			{
				[DebuggerHidden]
				get
				{
					throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
				}
			}

			// Token: 0x0600057E RID: 1406 RVA: 0x00002207 File Offset: 0x00000407
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}

			// Token: 0x17000168 RID: 360
			// (get) Token: 0x0600057F RID: 1407 RVA: 0x00002207 File Offset: 0x00000407
			object IEnumerator.Current
			{
				[DebuggerHidden]
				get
				{
					throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
				}
			}

			// Token: 0x04000283 RID: 643
			private int <>1__state;

			// Token: 0x04000284 RID: 644
			private object <>2__current;

			// Token: 0x04000285 RID: 645
			public T tweenInfo;

			// Token: 0x04000286 RID: 646
			private float <elapsedTime>5__2;
		}
	}
}
