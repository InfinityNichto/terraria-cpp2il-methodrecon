using System;
using System.Collections.Generic;
using UnityEngine.UI.Collections;

namespace UnityEngine.UI
{
	// Token: 0x02000020 RID: 32
	public class GraphicRegistry
	{
		// Token: 0x0600012F RID: 303 RVA: 0x00004A14 File Offset: 0x00002C14
		protected GraphicRegistry()
		{
			if (!true)
			{
			}
		}

		// Token: 0x1700004A RID: 74
		// (get) Token: 0x06000130 RID: 304 RVA: 0x00004A2C File Offset: 0x00002C2C
		public static GraphicRegistry instance
		{
			get
			{
				if (!true)
				{
				}
				if (true || !true)
				{
				}
				if (!true)
				{
				}
				return 1;
			}
		}

		// Token: 0x06000131 RID: 305 RVA: 0x00004A48 File Offset: 0x00002C48
		public static void RegisterGraphicForCanvas(Canvas c, Graphic graphic)
		{
			if (!true)
			{
			}
			if (!true)
			{
			}
			if (!true)
			{
			}
			if (GraphicRegistry.instance.m_Graphics != null)
			{
				return;
			}
			Dictionary<Canvas, IndexedSet<Graphic>> graphics = GraphicRegistry.instance.m_Graphics;
			GraphicRegistry.RegisterRaycastGraphicForCanvas(c, graphic);
		}

		// Token: 0x06000132 RID: 306 RVA: 0x00004A80 File Offset: 0x00002C80
		public static void RegisterRaycastGraphicForCanvas(Canvas c, Graphic graphic)
		{
			if (!true)
			{
			}
			if (!true)
			{
			}
			if (GraphicRegistry.instance.m_RaycastableGraphics != null)
			{
				return;
			}
			Dictionary<Canvas, IndexedSet<Graphic>> raycastableGraphics = GraphicRegistry.instance.m_RaycastableGraphics;
		}

		// Token: 0x06000133 RID: 307 RVA: 0x00004AAC File Offset: 0x00002CAC
		public static void UnregisterGraphicForCanvas(Canvas c, Graphic graphic)
		{
			if (!true)
			{
			}
			if (!true)
			{
			}
			if (!true)
			{
			}
			Dictionary<Canvas, IndexedSet<Graphic>> graphics = GraphicRegistry.instance.m_Graphics;
			int num;
			if (num == 0)
			{
				Dictionary<Canvas, IndexedSet<Graphic>> graphics2 = GraphicRegistry.instance.m_Graphics;
			}
			GraphicRegistry.UnregisterRaycastGraphicForCanvas(c, graphic);
		}

		// Token: 0x06000134 RID: 308 RVA: 0x00004AE4 File Offset: 0x00002CE4
		public static void UnregisterRaycastGraphicForCanvas(Canvas c, Graphic graphic)
		{
			if (!true)
			{
			}
			if (!true)
			{
			}
			if (!true)
			{
			}
			Dictionary<Canvas, IndexedSet<Graphic>> raycastableGraphics = GraphicRegistry.instance.m_RaycastableGraphics;
			Dictionary<Canvas, IndexedSet<Graphic>> raycastableGraphics2 = GraphicRegistry.instance.m_RaycastableGraphics;
		}

		// Token: 0x06000135 RID: 309 RVA: 0x00004B14 File Offset: 0x00002D14
		public static void DisableGraphicForCanvas(Canvas c, Graphic graphic)
		{
			if (!true)
			{
			}
			if (!true)
			{
			}
			Dictionary<Canvas, IndexedSet<Graphic>> graphics = GraphicRegistry.instance.m_Graphics;
			int num;
			if (num == 0)
			{
				Dictionary<Canvas, IndexedSet<Graphic>> graphics2 = GraphicRegistry.instance.m_Graphics;
			}
			GraphicRegistry.DisableRaycastGraphicForCanvas(c, graphic);
		}

		// Token: 0x06000136 RID: 310 RVA: 0x00004B48 File Offset: 0x00002D48
		public static void DisableRaycastGraphicForCanvas(Canvas c, Graphic graphic)
		{
			if (!true)
			{
			}
			Dictionary<Canvas, IndexedSet<Graphic>> raycastableGraphics = GraphicRegistry.instance.m_RaycastableGraphics;
			int num;
			if (num == 0)
			{
				Dictionary<Canvas, IndexedSet<Graphic>> raycastableGraphics2 = GraphicRegistry.instance.m_RaycastableGraphics;
			}
		}

		// Token: 0x06000137 RID: 311 RVA: 0x00004B74 File Offset: 0x00002D74
		public static IList<Graphic> GetGraphicsForCanvas(Canvas canvas)
		{
			/*
An exception occurred when decompiling this method (06000137)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Collections.Generic.IList`1<UnityEngine.UI.Graphic> UnityEngine.UI.GraphicRegistry::GetGraphicsForCanvas(UnityEngine.Canvas)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0005:
	stloc:class [mscorlib]System.Collections.Generic.Dictionary`2<class [UnityEngine.UIModule]UnityEngine.Canvas, class UnityEngine.UI.Collections.IndexedSet`1<class UnityEngine.UI.Graphic>>(var_1_0F, ldfld:class [mscorlib]System.Collections.Generic.Dictionary`2<class [UnityEngine.UIModule]UnityEngine.Canvas, class UnityEngine.UI.Collections.IndexedSet`1<class UnityEngine.UI.Graphic>>(GraphicRegistry::m_Graphics, callgetter:GraphicRegistry(GraphicRegistry::get_instance)))
	brtrue(IL_0000, ldloc:int32[exp:bool](var_0_01))
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

		// Token: 0x06000138 RID: 312 RVA: 0x00004B94 File Offset: 0x00002D94
		public static IList<Graphic> GetRaycastableGraphicsForCanvas(Canvas canvas)
		{
			/*
An exception occurred when decompiling this method (06000138)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Collections.Generic.IList`1<UnityEngine.UI.Graphic> UnityEngine.UI.GraphicRegistry::GetRaycastableGraphicsForCanvas(UnityEngine.Canvas)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0005:
	stloc:class [mscorlib]System.Collections.Generic.Dictionary`2<class [UnityEngine.UIModule]UnityEngine.Canvas, class UnityEngine.UI.Collections.IndexedSet`1<class UnityEngine.UI.Graphic>>(var_1_0F, ldfld:class [mscorlib]System.Collections.Generic.Dictionary`2<class [UnityEngine.UIModule]UnityEngine.Canvas, class UnityEngine.UI.Collections.IndexedSet`1<class UnityEngine.UI.Graphic>>(GraphicRegistry::m_RaycastableGraphics, callgetter:GraphicRegistry(GraphicRegistry::get_instance)))
	brtrue(IL_0000, ldloc:int32[exp:bool](var_0_01))
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

		// Token: 0x06000139 RID: 313 RVA: 0x00004BB4 File Offset: 0x00002DB4
		// Note: this type is marked as 'beforefieldinit'.
		static GraphicRegistry()
		{
		}

		// Token: 0x0400008D RID: 141
		private static GraphicRegistry s_Instance;

		// Token: 0x0400008E RID: 142
		private readonly Dictionary<Canvas, IndexedSet<Graphic>> m_Graphics;

		// Token: 0x0400008F RID: 143
		private readonly Dictionary<Canvas, IndexedSet<Graphic>> m_RaycastableGraphics;

		// Token: 0x04000090 RID: 144
		private static readonly List<Graphic> s_EmptyList;
	}
}
