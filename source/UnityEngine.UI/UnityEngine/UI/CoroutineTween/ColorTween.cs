using System;
using Cpp2IlInjected;
using UnityEngine.Events;

namespace UnityEngine.UI.CoroutineTween
{
	// Token: 0x02000089 RID: 137
	internal struct ColorTween : ITweenValue
	{
		// Token: 0x1700015E RID: 350
		// (get) Token: 0x06000557 RID: 1367 RVA: 0x00010B88 File Offset: 0x0000ED88
		// (set) Token: 0x06000558 RID: 1368 RVA: 0x00010BC4 File Offset: 0x0000EDC4
		public Color startColor
		{
			get
			{
				/*
An exception occurred when decompiling this method (06000557)

ICSharpCode.Decompiler.DecompilerException: Error decompiling UnityEngine.Color UnityEngine.UI.CoroutineTween.ColorTween::get_startColor()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:float32(var_0_0B, ldfld:float32(Color::r, ldfld:Color[exp:valuetype [UnityEngine.CoreModule]UnityEngine.Color&](ColorTween::m_StartColor, ldloc:valuetype UnityEngine.UI.CoroutineTween.ColorTween&(this))))
	stloc:float32(var_1_17, ldfld:float32(Color::g, ldfld:Color[exp:valuetype [UnityEngine.CoreModule]UnityEngine.Color&](ColorTween::m_StartColor, ldloc:valuetype UnityEngine.UI.CoroutineTween.ColorTween&(this))))
	stloc:float32(var_2_23, ldfld:float32(Color::b, ldfld:Color[exp:valuetype [UnityEngine.CoreModule]UnityEngine.Color&](ColorTween::m_StartColor, ldloc:valuetype UnityEngine.UI.CoroutineTween.ColorTween&(this))))
	stloc:float32(var_3_2F, ldfld:float32(Color::a, ldfld:Color[exp:valuetype [UnityEngine.CoreModule]UnityEngine.Color&](ColorTween::m_StartColor, ldloc:valuetype UnityEngine.UI.CoroutineTween.ColorTween&(this))))
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
			set
			{
			}
		}

		// Token: 0x1700015F RID: 351
		// (get) Token: 0x06000559 RID: 1369 RVA: 0x00010BD4 File Offset: 0x0000EDD4
		// (set) Token: 0x0600055A RID: 1370 RVA: 0x00010C10 File Offset: 0x0000EE10
		public Color targetColor
		{
			get
			{
				/*
An exception occurred when decompiling this method (06000559)

ICSharpCode.Decompiler.DecompilerException: Error decompiling UnityEngine.Color UnityEngine.UI.CoroutineTween.ColorTween::get_targetColor()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:float32(var_0_0B, ldfld:float32(Color::r, ldfld:Color[exp:valuetype [UnityEngine.CoreModule]UnityEngine.Color&](ColorTween::m_TargetColor, ldloc:valuetype UnityEngine.UI.CoroutineTween.ColorTween&(this))))
	stloc:float32(var_1_17, ldfld:float32(Color::g, ldfld:Color[exp:valuetype [UnityEngine.CoreModule]UnityEngine.Color&](ColorTween::m_TargetColor, ldloc:valuetype UnityEngine.UI.CoroutineTween.ColorTween&(this))))
	stloc:float32(var_2_23, ldfld:float32(Color::b, ldfld:Color[exp:valuetype [UnityEngine.CoreModule]UnityEngine.Color&](ColorTween::m_TargetColor, ldloc:valuetype UnityEngine.UI.CoroutineTween.ColorTween&(this))))
	stloc:float32(var_3_2F, ldfld:float32(Color::a, ldfld:Color[exp:valuetype [UnityEngine.CoreModule]UnityEngine.Color&](ColorTween::m_TargetColor, ldloc:valuetype UnityEngine.UI.CoroutineTween.ColorTween&(this))))
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
			set
			{
			}
		}

		// Token: 0x17000160 RID: 352
		// (get) Token: 0x0600055B RID: 1371 RVA: 0x00010C20 File Offset: 0x0000EE20
		// (set) Token: 0x0600055C RID: 1372 RVA: 0x00010C34 File Offset: 0x0000EE34
		public ColorTween.ColorTweenMode tweenMode
		{
			get
			{
				return this.m_TweenMode;
			}
			set
			{
				this.m_TweenMode = value;
			}
		}

		// Token: 0x17000161 RID: 353
		// (get) Token: 0x0600055D RID: 1373 RVA: 0x00010C48 File Offset: 0x0000EE48
		// (set) Token: 0x0600055E RID: 1374 RVA: 0x00010C5C File Offset: 0x0000EE5C
		public float duration
		{
			get
			{
				/*
An exception occurred when decompiling this method (0600055D)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Single UnityEngine.UI.CoroutineTween.ColorTween::get_duration()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:float32(var_0_06, ldfld:float32(ColorTween::m_Duration, ldloc:valuetype UnityEngine.UI.CoroutineTween.ColorTween&(this)))
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
			set
			{
			}
		}

		// Token: 0x17000162 RID: 354
		// (get) Token: 0x0600055F RID: 1375 RVA: 0x00010C6C File Offset: 0x0000EE6C
		// (set) Token: 0x06000560 RID: 1376 RVA: 0x00010C80 File Offset: 0x0000EE80
		public bool ignoreTimeScale
		{
			get
			{
				return this.m_IgnoreTimeScale;
			}
			set
			{
			}
		}

		// Token: 0x06000561 RID: 1377 RVA: 0x00010C90 File Offset: 0x0000EE90
		public void TweenValue(float floatPercentage)
		{
			float a = this.m_StartColor.a;
			float a2 = this.m_TargetColor.a;
			ColorTween.ColorTweenMode tweenMode = this.m_TweenMode;
			float r = this.m_StartColor.r;
			float r2 = this.m_TargetColor.r;
		}

		// Token: 0x06000562 RID: 1378 RVA: 0x00010CD8 File Offset: 0x0000EED8
		public void AddOnChangedCallback(UnityAction<Color> callback)
		{
		}

		// Token: 0x06000563 RID: 1379 RVA: 0x00010CE8 File Offset: 0x0000EEE8
		public bool GetIgnoreTimescale()
		{
			return this.m_IgnoreTimeScale;
		}

		// Token: 0x06000564 RID: 1380 RVA: 0x00010CFC File Offset: 0x0000EEFC
		public float GetDuration()
		{
			/*
An exception occurred when decompiling this method (06000564)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Single UnityEngine.UI.CoroutineTween.ColorTween::GetDuration()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:float32(var_0_06, ldfld:float32(ColorTween::m_Duration, ldloc:valuetype UnityEngine.UI.CoroutineTween.ColorTween&(this)))
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

		// Token: 0x06000565 RID: 1381 RVA: 0x00002207 File Offset: 0x00000407
		public bool ValidTarget()
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x04000272 RID: 626
		private ColorTween.ColorTweenCallback m_Target;

		// Token: 0x04000273 RID: 627
		private Color m_StartColor;

		// Token: 0x04000274 RID: 628
		private Color m_TargetColor;

		// Token: 0x04000275 RID: 629
		private ColorTween.ColorTweenMode m_TweenMode;

		// Token: 0x04000276 RID: 630
		private float m_Duration;

		// Token: 0x04000277 RID: 631
		private bool m_IgnoreTimeScale;

		// Token: 0x0200008A RID: 138
		public enum ColorTweenMode
		{
			// Token: 0x04000279 RID: 633
			All,
			// Token: 0x0400027A RID: 634
			RGB,
			// Token: 0x0400027B RID: 635
			Alpha
		}

		// Token: 0x0200008B RID: 139
		public class ColorTweenCallback : UnityEvent<Color>
		{
			// Token: 0x06000566 RID: 1382 RVA: 0x00010D10 File Offset: 0x0000EF10
			public ColorTweenCallback()
			{
			}
		}
	}
}
