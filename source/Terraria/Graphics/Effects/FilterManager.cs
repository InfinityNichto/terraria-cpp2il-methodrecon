using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Terraria.Graphics.Effects
{
	// Token: 0x02000784 RID: 1924
	public class FilterManager : EffectManager<Filter>
	{
		// Token: 0x14000053 RID: 83
		// (add) Token: 0x06003EFA RID: 16122 RVA: 0x0023F85C File Offset: 0x0023DA5C
		// (remove) Token: 0x06003EFB RID: 16123 RVA: 0x0023F880 File Offset: 0x0023DA80
		public event Action OnPostDraw
		{
			[CompilerGenerated]
			add
			{
				if (Delegate.Combine(this.OnPostDraw, value) != null)
				{
				}
			}
			[CompilerGenerated]
			remove
			{
				if (Delegate.Remove(this.OnPostDraw, value) != null)
				{
				}
			}
		}

		// Token: 0x06003EFC RID: 16124 RVA: 0x0023F8A4 File Offset: 0x0023DAA4
		public FilterManager()
		{
		}

		// Token: 0x06003EFD RID: 16125 RVA: 0x000021DB File Offset: 0x000003DB
		public override void OnActivate(Filter effect, Vector2 position)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06003EFE RID: 16126 RVA: 0x0023F8C0 File Offset: 0x0023DAC0
		public void BeginCapture(RenderTarget2D screenTarget1, Color clearColor)
		{
			if (this._activeFilterCount != 0 || this.OnPostDraw != null)
			{
				this._captureThisFrame = true;
				if (!true)
				{
				}
				GraphicsDevice graphicsDevice;
				graphicsDevice.SetRenderTarget(screenTarget1);
				return;
			}
		}

		// Token: 0x06003EFF RID: 16127 RVA: 0x000021DB File Offset: 0x000003DB
		public void Update(GameTime gameTime)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06003F00 RID: 16128 RVA: 0x000021DB File Offset: 0x000003DB
		public void UpdateFilters()
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06003F01 RID: 16129 RVA: 0x000021DB File Offset: 0x000003DB
		public void EndCapture(RenderTarget2D finalTexture, RenderTarget2D screenTarget1, RenderTarget2D screenTarget2, Color clearColor)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06003F02 RID: 16130 RVA: 0x0023F8F0 File Offset: 0x0023DAF0
		public bool HasActiveFilter()
		{
			/*
An exception occurred when decompiling this method (06003F02)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean Terraria.Graphics.Effects.FilterManager::HasActiveFilter()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:int32(var_0_0B, ldfld:int32(LinkedList`1::count, ldfld:class [System]System.Collections.Generic.LinkedList`1<class Terraria.Graphics.Effects.Filter>[exp:LinkedList`1](FilterManager::_activeFilters, ldloc:FilterManager(this))))
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

		// Token: 0x06003F03 RID: 16131 RVA: 0x0023F908 File Offset: 0x0023DB08
		public bool CanCapture()
		{
			return this._activeFilters == null || true;
		}

		// Token: 0x04007D7D RID: 32125
		private const float OPACITY_RATE = 1f;

		// Token: 0x04007D7E RID: 32126
		[CompilerGenerated]
		private Action OnPostDraw;

		// Token: 0x04007D7F RID: 32127
		private LinkedList<Filter> _activeFilters;

		// Token: 0x04007D80 RID: 32128
		private int _filterLimit = 16;

		// Token: 0x04007D81 RID: 32129
		private EffectPriority _priorityThreshold;

		// Token: 0x04007D82 RID: 32130
		private int _activeFilterCount;

		// Token: 0x04007D83 RID: 32131
		private bool _captureThisFrame;
	}
}
