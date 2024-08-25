using System;
using System.Collections.Generic;
using Cpp2IlInjected;

namespace UnityEngine.UI
{
	// Token: 0x02000086 RID: 134
	[AddComponentMenu("UI/Effects/Shadow", 80)]
	public class Shadow : BaseMeshEffect
	{
		// Token: 0x06000532 RID: 1330 RVA: 0x00010728 File Offset: 0x0000E928
		protected Shadow()
		{
		}

		// Token: 0x17000155 RID: 341
		// (get) Token: 0x06000533 RID: 1331 RVA: 0x00010744 File Offset: 0x0000E944
		// (set) Token: 0x06000534 RID: 1332 RVA: 0x00010780 File Offset: 0x0000E980
		public Color effectColor
		{
			get
			{
				/*
An exception occurred when decompiling this method (06000533)

ICSharpCode.Decompiler.DecompilerException: Error decompiling UnityEngine.Color UnityEngine.UI.Shadow::get_effectColor()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:float32(var_0_0B, ldfld:float32(Color::r, ldfld:Color[exp:valuetype [UnityEngine.CoreModule]UnityEngine.Color&](Shadow::m_EffectColor, ldloc:Shadow(this))))
	stloc:float32(var_1_17, ldfld:float32(Color::g, ldfld:Color[exp:valuetype [UnityEngine.CoreModule]UnityEngine.Color&](Shadow::m_EffectColor, ldloc:Shadow(this))))
	stloc:float32(var_2_23, ldfld:float32(Color::b, ldfld:Color[exp:valuetype [UnityEngine.CoreModule]UnityEngine.Color&](Shadow::m_EffectColor, ldloc:Shadow(this))))
	stloc:float32(var_3_2F, ldfld:float32(Color::a, ldfld:Color[exp:valuetype [UnityEngine.CoreModule]UnityEngine.Color&](Shadow::m_EffectColor, ldloc:Shadow(this))))
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
				Graphic graphic = base.graphic;
				Graphic graphic2 = base.graphic;
			}
		}

		// Token: 0x17000156 RID: 342
		// (get) Token: 0x06000535 RID: 1333 RVA: 0x0001079C File Offset: 0x0000E99C
		// (set) Token: 0x06000536 RID: 1334 RVA: 0x000107C4 File Offset: 0x0000E9C4
		public Vector2 effectDistance
		{
			get
			{
				float x = this.m_EffectDistance.x;
				float y = this.m_EffectDistance.y;
				Vector2 vector;
				return vector;
			}
			set
			{
				float x = this.m_EffectDistance.x;
				float y = this.m_EffectDistance.y;
				Graphic graphic = base.graphic;
				Graphic graphic2 = base.graphic;
			}
		}

		// Token: 0x17000157 RID: 343
		// (get) Token: 0x06000537 RID: 1335 RVA: 0x000107FC File Offset: 0x0000E9FC
		// (set) Token: 0x06000538 RID: 1336 RVA: 0x00010810 File Offset: 0x0000EA10
		public bool useGraphicAlpha
		{
			get
			{
				return this.m_UseGraphicAlpha;
			}
			set
			{
				Graphic graphic = base.graphic;
				Graphic graphic2 = base.graphic;
			}
		}

		// Token: 0x06000539 RID: 1337 RVA: 0x00002207 File Offset: 0x00000407
		protected void ApplyShadowZeroAlloc(List<UIVertex> verts, Color32 color, int start, int end, float x, float y)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x0600053A RID: 1338 RVA: 0x0001082C File Offset: 0x0000EA2C
		protected void ApplyShadow(List<UIVertex> verts, Color32 color, int start, int end, float x, float y)
		{
			this.ApplyShadowZeroAlloc(verts, color, start, end, x, y);
		}

		// Token: 0x0600053B RID: 1339 RVA: 0x00010848 File Offset: 0x0000EA48
		public override void ModifyMesh(VertexHelper vh)
		{
			float r = this.m_EffectColor.r;
			float g = this.m_EffectColor.g;
			float b = this.m_EffectColor.b;
			float a = this.m_EffectColor.a;
		}

		// Token: 0x0400026B RID: 619
		[SerializeField]
		private Color m_EffectColor;

		// Token: 0x0400026C RID: 620
		[SerializeField]
		private Vector2 m_EffectDistance;

		// Token: 0x0400026D RID: 621
		[SerializeField]
		private bool m_UseGraphicAlpha = true;

		// Token: 0x0400026E RID: 622
		private const float kMaxEffectDistance = 600f;
	}
}
