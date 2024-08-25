using System;

namespace Microsoft.Xna.Framework.Graphics
{
	// Token: 0x020003A4 RID: 932
	public class TargetBlendState
	{
		// Token: 0x060018F8 RID: 6392 RVA: 0x0006A214 File Offset: 0x00068414
		internal TargetBlendState(BlendState parent)
		{
			this._parent = parent;
			parent.ThrowIfBound();
			this._parent.ThrowIfBound();
			BlendState parent2 = this._parent;
			this._alphaDestinationBlend = Blend.Zero;
			parent2.ThrowIfBound();
			this._parent.ThrowIfBound();
			this._parent.ThrowIfBound();
			BlendState parent3 = this._parent;
			this._colorDestinationBlend = Blend.Zero;
			parent3.ThrowIfBound();
			this._parent.ThrowIfBound();
			this._colorWriteChannels = ColorWriteChannels.All;
		}

		// Token: 0x060018F9 RID: 6393 RVA: 0x0006A290 File Offset: 0x00068490
		internal TargetBlendState Clone(BlendState parent)
		{
			/*
An exception occurred when decompiling this method (060018F9)

ICSharpCode.Decompiler.DecompilerException: Error decompiling Microsoft.Xna.Framework.Graphics.TargetBlendState Microsoft.Xna.Framework.Graphics.TargetBlendState::Clone(Microsoft.Xna.Framework.Graphics.BlendState)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:BlendFunction(var_0_06, ldfld:BlendFunction(TargetBlendState::_alphaBlendFunction, ldloc:TargetBlendState(this)))
	stloc:Blend(var_1_0D, ldfld:Blend(TargetBlendState::_alphaDestinationBlend, ldloc:TargetBlendState(this)))
	stloc:Blend(var_2_14, ldfld:Blend(TargetBlendState::_alphaSourceBlend, ldloc:TargetBlendState(this)))
	stloc:BlendFunction(var_3_1B, ldfld:BlendFunction(TargetBlendState::_colorBlendFunction, ldloc:TargetBlendState(this)))
	stloc:Blend(var_4_22, ldfld:Blend(TargetBlendState::_colorDestinationBlend, ldloc:TargetBlendState(this)))
	stloc:Blend(var_5_2A, ldfld:Blend(TargetBlendState::_colorSourceBlend, ldloc:TargetBlendState(this)))
	stloc:ColorWriteChannels(var_6_32, ldfld:ColorWriteChannels(TargetBlendState::_colorWriteChannels, ldloc:TargetBlendState(this)))
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

		// Token: 0x17000344 RID: 836
		// (get) Token: 0x060018FA RID: 6394 RVA: 0x0006A2D0 File Offset: 0x000684D0
		// (set) Token: 0x060018FB RID: 6395 RVA: 0x0006A2E4 File Offset: 0x000684E4
		public BlendFunction AlphaBlendFunction
		{
			get
			{
				return this._alphaBlendFunction;
			}
			set
			{
				this._parent.ThrowIfBound();
				this._alphaBlendFunction = value;
			}
		}

		// Token: 0x17000345 RID: 837
		// (get) Token: 0x060018FC RID: 6396 RVA: 0x0006A304 File Offset: 0x00068504
		// (set) Token: 0x060018FD RID: 6397 RVA: 0x0006A318 File Offset: 0x00068518
		public Blend AlphaDestinationBlend
		{
			get
			{
				return this._alphaDestinationBlend;
			}
			set
			{
				this._parent.ThrowIfBound();
				this._alphaDestinationBlend = value;
			}
		}

		// Token: 0x17000346 RID: 838
		// (get) Token: 0x060018FE RID: 6398 RVA: 0x0006A338 File Offset: 0x00068538
		// (set) Token: 0x060018FF RID: 6399 RVA: 0x0006A34C File Offset: 0x0006854C
		public Blend AlphaSourceBlend
		{
			get
			{
				return this._alphaSourceBlend;
			}
			set
			{
				this._parent.ThrowIfBound();
				this._alphaSourceBlend = value;
			}
		}

		// Token: 0x17000347 RID: 839
		// (get) Token: 0x06001900 RID: 6400 RVA: 0x0006A36C File Offset: 0x0006856C
		// (set) Token: 0x06001901 RID: 6401 RVA: 0x0006A380 File Offset: 0x00068580
		public BlendFunction ColorBlendFunction
		{
			get
			{
				return this._colorBlendFunction;
			}
			set
			{
				this._parent.ThrowIfBound();
				this._colorBlendFunction = value;
			}
		}

		// Token: 0x17000348 RID: 840
		// (get) Token: 0x06001902 RID: 6402 RVA: 0x0006A3A0 File Offset: 0x000685A0
		// (set) Token: 0x06001903 RID: 6403 RVA: 0x0006A3B4 File Offset: 0x000685B4
		public Blend ColorDestinationBlend
		{
			get
			{
				return this._colorDestinationBlend;
			}
			set
			{
				this._parent.ThrowIfBound();
				this._colorDestinationBlend = value;
			}
		}

		// Token: 0x17000349 RID: 841
		// (get) Token: 0x06001904 RID: 6404 RVA: 0x0006A3D4 File Offset: 0x000685D4
		// (set) Token: 0x06001905 RID: 6405 RVA: 0x0006A3E8 File Offset: 0x000685E8
		public Blend ColorSourceBlend
		{
			get
			{
				return this._colorSourceBlend;
			}
			set
			{
				this._parent.ThrowIfBound();
				this._colorSourceBlend = value;
			}
		}

		// Token: 0x1700034A RID: 842
		// (get) Token: 0x06001906 RID: 6406 RVA: 0x0006A408 File Offset: 0x00068608
		// (set) Token: 0x06001907 RID: 6407 RVA: 0x0006A41C File Offset: 0x0006861C
		public ColorWriteChannels ColorWriteChannels
		{
			get
			{
				return this._colorWriteChannels;
			}
			set
			{
				this._parent.ThrowIfBound();
				this._colorWriteChannels = value;
			}
		}

		// Token: 0x04002735 RID: 10037
		private readonly BlendState _parent;

		// Token: 0x04002736 RID: 10038
		private BlendFunction _alphaBlendFunction;

		// Token: 0x04002737 RID: 10039
		private Blend _alphaDestinationBlend;

		// Token: 0x04002738 RID: 10040
		private Blend _alphaSourceBlend;

		// Token: 0x04002739 RID: 10041
		private BlendFunction _colorBlendFunction;

		// Token: 0x0400273A RID: 10042
		private Blend _colorDestinationBlend;

		// Token: 0x0400273B RID: 10043
		private Blend _colorSourceBlend;

		// Token: 0x0400273C RID: 10044
		private ColorWriteChannels _colorWriteChannels;
	}
}
