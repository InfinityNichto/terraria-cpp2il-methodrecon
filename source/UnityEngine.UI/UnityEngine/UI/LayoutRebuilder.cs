using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using UnityEngine.Events;
using UnityEngine.Pool;

namespace UnityEngine.UI
{
	// Token: 0x0200004E RID: 78
	public class LayoutRebuilder : ICanvasElement
	{
		// Token: 0x060002FA RID: 762 RVA: 0x0000A620 File Offset: 0x00008820
		private void Initialize(RectTransform controller)
		{
			this.m_ToRebuild = controller;
			this.m_CachedHashFromTransform = controller;
		}

		// Token: 0x060002FB RID: 763 RVA: 0x0000A63C File Offset: 0x0000883C
		private void Clear()
		{
		}

		// Token: 0x060002FC RID: 764 RVA: 0x0000A64C File Offset: 0x0000884C
		static LayoutRebuilder()
		{
			if (!true)
			{
			}
		}

		// Token: 0x060002FD RID: 765 RVA: 0x0000A660 File Offset: 0x00008860
		private static void ReapplyDrivenProperties(RectTransform driven)
		{
			if (!true)
			{
			}
			LayoutRebuilder.MarkLayoutForRebuild(driven);
		}

		// Token: 0x170000D4 RID: 212
		// (get) Token: 0x060002FE RID: 766 RVA: 0x0000A678 File Offset: 0x00008878
		public Transform transform
		{
			get
			{
				/*
An exception occurred when decompiling this method (060002FE)

ICSharpCode.Decompiler.DecompilerException: Error decompiling UnityEngine.Transform UnityEngine.UI.LayoutRebuilder::get_transform()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:RectTransform(var_0_06, ldfld:RectTransform(LayoutRebuilder::m_ToRebuild, ldloc:LayoutRebuilder(this)))
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

		// Token: 0x060002FF RID: 767 RVA: 0x0000A68C File Offset: 0x0000888C
		public bool IsDestroyed()
		{
			RectTransform toRebuild = this.m_ToRebuild;
			if (!true)
			{
			}
			bool flag;
			return flag;
		}

		// Token: 0x06000300 RID: 768 RVA: 0x0000A6A4 File Offset: 0x000088A4
		private static void StripDisabledBehavioursFromList(List<Component> components)
		{
			if (!true)
			{
			}
			if (!true)
			{
			}
		}

		// Token: 0x06000301 RID: 769 RVA: 0x00002207 File Offset: 0x00000407
		public static void ForceRebuildLayoutImmediate(RectTransform layoutRoot)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06000302 RID: 770 RVA: 0x0000A6B8 File Offset: 0x000088B8
		public void Rebuild(CanvasUpdate executing)
		{
			RectTransform toRebuild = this.m_ToRebuild;
			if (!true)
			{
			}
			if (!true)
			{
			}
			RectTransform toRebuild2 = this.m_ToRebuild;
			RectTransform toRebuild3 = this.m_ToRebuild;
			RectTransform toRebuild4 = this.m_ToRebuild;
		}

		// Token: 0x06000303 RID: 771 RVA: 0x0000A6E8 File Offset: 0x000088E8
		private void PerformLayoutControl(RectTransform rect, UnityAction<Component> action)
		{
			if (!true)
			{
			}
		}

		// Token: 0x06000304 RID: 772 RVA: 0x0000A724 File Offset: 0x00008924
		private void PerformLayoutCalculation(RectTransform rect, UnityAction<Component> action)
		{
			if (!true)
			{
			}
		}

		// Token: 0x06000305 RID: 773 RVA: 0x0000A764 File Offset: 0x00008964
		public static void MarkLayoutForRebuild(RectTransform rect)
		{
			if (!true)
			{
			}
			GameObject gameObject = rect.gameObject;
		}

		// Token: 0x06000306 RID: 774 RVA: 0x0000A7A4 File Offset: 0x000089A4
		private static bool ValidController(RectTransform layoutRoot, List<Component> comps)
		{
			if (!true)
			{
			}
			if (layoutRoot != null)
			{
				return;
			}
		}

		// Token: 0x06000307 RID: 775 RVA: 0x00002207 File Offset: 0x00000407
		private static void MarkLayoutRootForRebuild(RectTransform controller)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06000308 RID: 776 RVA: 0x0000A7C0 File Offset: 0x000089C0
		public void LayoutComplete()
		{
			if (!true)
			{
			}
		}

		// Token: 0x06000309 RID: 777 RVA: 0x0000A7D0 File Offset: 0x000089D0
		public void GraphicUpdateComplete()
		{
		}

		// Token: 0x0600030A RID: 778 RVA: 0x0000A7E0 File Offset: 0x000089E0
		public override int GetHashCode()
		{
			return this.m_CachedHashFromTransform;
		}

		// Token: 0x0600030B RID: 779 RVA: 0x00002207 File Offset: 0x00000407
		public override bool Equals(object obj)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x0600030C RID: 780 RVA: 0x0000A7F4 File Offset: 0x000089F4
		public override string ToString()
		{
			if (this.m_ToRebuild != null)
			{
			}
			string text;
			return text;
		}

		// Token: 0x0600030D RID: 781 RVA: 0x0000A80C File Offset: 0x00008A0C
		public LayoutRebuilder()
		{
		}

		// Token: 0x04000180 RID: 384
		private RectTransform m_ToRebuild;

		// Token: 0x04000181 RID: 385
		private int m_CachedHashFromTransform;

		// Token: 0x04000182 RID: 386
		private static ObjectPool<LayoutRebuilder> s_Rebuilders;

		// Token: 0x0200004F RID: 79
		[CompilerGenerated]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x0600030E RID: 782 RVA: 0x0000A820 File Offset: 0x00008A20
			// Note: this type is marked as 'beforefieldinit'.
			static <>c()
			{
			}

			// Token: 0x0600030F RID: 783 RVA: 0x0000A830 File Offset: 0x00008A30
			public <>c()
			{
			}

			// Token: 0x06000310 RID: 784 RVA: 0x00002207 File Offset: 0x00000407
			internal LayoutRebuilder <.cctor>b__5_0()
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}

			// Token: 0x06000311 RID: 785 RVA: 0x0000A844 File Offset: 0x00008A44
			internal void <.cctor>b__5_1(LayoutRebuilder x)
			{
			}

			// Token: 0x06000312 RID: 786 RVA: 0x0000A854 File Offset: 0x00008A54
			internal bool <StripDisabledBehavioursFromList>b__10_0(Component e)
			{
				if (e != null)
				{
				}
				throw new MissingMethodException();
			}

			// Token: 0x06000313 RID: 787 RVA: 0x0000A86C File Offset: 0x00008A6C
			internal void <Rebuild>b__12_0(Component e)
			{
			}

			// Token: 0x06000314 RID: 788 RVA: 0x0000A87C File Offset: 0x00008A7C
			internal void <Rebuild>b__12_1(Component e)
			{
			}

			// Token: 0x06000315 RID: 789 RVA: 0x0000A88C File Offset: 0x00008A8C
			internal void <Rebuild>b__12_2(Component e)
			{
			}

			// Token: 0x06000316 RID: 790 RVA: 0x0000A89C File Offset: 0x00008A9C
			internal void <Rebuild>b__12_3(Component e)
			{
			}

			// Token: 0x04000183 RID: 387
			public static readonly LayoutRebuilder.<>c <>9;

			// Token: 0x04000184 RID: 388
			public static Predicate<Component> <>9__10_0;

			// Token: 0x04000185 RID: 389
			public static UnityAction<Component> <>9__12_0;

			// Token: 0x04000186 RID: 390
			public static UnityAction<Component> <>9__12_1;

			// Token: 0x04000187 RID: 391
			public static UnityAction<Component> <>9__12_2;

			// Token: 0x04000188 RID: 392
			public static UnityAction<Component> <>9__12_3;
		}
	}
}
