using System;
using Cpp2IlInjected;

namespace Microsoft.Xna.Framework.Graphics
{
	// Token: 0x020003A1 RID: 929
	public class RasterizerState : GraphicsResource
	{
		// Token: 0x17000333 RID: 819
		// (get) Token: 0x060018C8 RID: 6344 RVA: 0x00069CC0 File Offset: 0x00067EC0
		// (set) Token: 0x060018C9 RID: 6345 RVA: 0x00069CD4 File Offset: 0x00067ED4
		public CullMode CullMode
		{
			get
			{
				return this._cullMode;
			}
			set
			{
				this.ThrowIfBound();
				this._cullMode = value;
			}
		}

		// Token: 0x17000334 RID: 820
		// (get) Token: 0x060018CA RID: 6346 RVA: 0x00069CF0 File Offset: 0x00067EF0
		// (set) Token: 0x060018CB RID: 6347 RVA: 0x00069D04 File Offset: 0x00067F04
		public float DepthBias
		{
			get
			{
				/*
An exception occurred when decompiling this method (060018CA)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Single Microsoft.Xna.Framework.Graphics.RasterizerState::get_DepthBias()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:float32(var_0_06, ldfld:float32(RasterizerState::_depthBias, ldloc:RasterizerState(this)))
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
				this.ThrowIfBound();
			}
		}

		// Token: 0x17000335 RID: 821
		// (get) Token: 0x060018CC RID: 6348 RVA: 0x00069D18 File Offset: 0x00067F18
		// (set) Token: 0x060018CD RID: 6349 RVA: 0x00069D2C File Offset: 0x00067F2C
		public FillMode FillMode
		{
			get
			{
				return this._fillMode;
			}
			set
			{
				this.ThrowIfBound();
				this._fillMode = value;
			}
		}

		// Token: 0x17000336 RID: 822
		// (get) Token: 0x060018CE RID: 6350 RVA: 0x00069D48 File Offset: 0x00067F48
		// (set) Token: 0x060018CF RID: 6351 RVA: 0x00069D5C File Offset: 0x00067F5C
		public bool MultiSampleAntiAlias
		{
			get
			{
				return this._multiSampleAntiAlias;
			}
			set
			{
				this.ThrowIfBound();
			}
		}

		// Token: 0x17000337 RID: 823
		// (get) Token: 0x060018D0 RID: 6352 RVA: 0x00069D70 File Offset: 0x00067F70
		// (set) Token: 0x060018D1 RID: 6353 RVA: 0x00069D84 File Offset: 0x00067F84
		public bool ScissorTestEnable
		{
			get
			{
				return this._scissorTestEnable;
			}
			set
			{
				this.ThrowIfBound();
			}
		}

		// Token: 0x17000338 RID: 824
		// (get) Token: 0x060018D2 RID: 6354 RVA: 0x00069D98 File Offset: 0x00067F98
		// (set) Token: 0x060018D3 RID: 6355 RVA: 0x00069DAC File Offset: 0x00067FAC
		public float SlopeScaleDepthBias
		{
			get
			{
				/*
An exception occurred when decompiling this method (060018D2)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Single Microsoft.Xna.Framework.Graphics.RasterizerState::get_SlopeScaleDepthBias()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:float32(var_0_06, ldfld:float32(RasterizerState::_slopeScaleDepthBias, ldloc:RasterizerState(this)))
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
				this.ThrowIfBound();
			}
		}

		// Token: 0x17000339 RID: 825
		// (get) Token: 0x060018D4 RID: 6356 RVA: 0x00069DC0 File Offset: 0x00067FC0
		// (set) Token: 0x060018D5 RID: 6357 RVA: 0x00069DD4 File Offset: 0x00067FD4
		public bool DepthClipEnable
		{
			get
			{
				return this._depthClipEnable;
			}
			set
			{
				this.ThrowIfBound();
			}
		}

		// Token: 0x060018D6 RID: 6358 RVA: 0x00069DE8 File Offset: 0x00067FE8
		internal void BindToGraphicsDevice(GraphicsDevice device)
		{
			if (!this._defaultStateObject)
			{
				if (this.graphicsDevice != null)
				{
				}
				base.GraphicsDevice = device;
				return;
			}
		}

		// Token: 0x060018D7 RID: 6359 RVA: 0x00069E10 File Offset: 0x00068010
		internal void ThrowIfBound()
		{
			while (!this._defaultStateObject)
			{
				if (this.graphicsDevice == null)
				{
					return;
				}
			}
		}

		// Token: 0x060018D8 RID: 6360 RVA: 0x00069E30 File Offset: 0x00068030
		public RasterizerState()
		{
			this.ThrowIfBound();
			this._cullMode = CullMode.CullCounterClockwiseFace;
			this.ThrowIfBound();
			this.ThrowIfBound();
			this.ThrowIfBound();
			this._multiSampleAntiAlias = true;
			this.ThrowIfBound();
			this.ThrowIfBound();
			this.ThrowIfBound();
			this._depthClipEnable = true;
		}

		// Token: 0x060018D9 RID: 6361 RVA: 0x00069E84 File Offset: 0x00068084
		private RasterizerState(string name, CullMode cullMode)
		{
			this.<Name>k__BackingField = name;
			this._cullMode = cullMode;
			this._defaultStateObject = true;
		}

		// Token: 0x060018DA RID: 6362 RVA: 0x00069EA8 File Offset: 0x000680A8
		private RasterizerState(RasterizerState cloneSource)
		{
		}

		// Token: 0x060018DB RID: 6363 RVA: 0x00069EBC File Offset: 0x000680BC
		static RasterizerState()
		{
		}

		// Token: 0x060018DC RID: 6364 RVA: 0x000021DB File Offset: 0x000003DB
		internal RasterizerState Clone()
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x04002710 RID: 10000
		private readonly bool _defaultStateObject;

		// Token: 0x04002711 RID: 10001
		private CullMode _cullMode;

		// Token: 0x04002712 RID: 10002
		private float _depthBias;

		// Token: 0x04002713 RID: 10003
		private FillMode _fillMode;

		// Token: 0x04002714 RID: 10004
		private bool _multiSampleAntiAlias;

		// Token: 0x04002715 RID: 10005
		private bool _scissorTestEnable;

		// Token: 0x04002716 RID: 10006
		private float _slopeScaleDepthBias;

		// Token: 0x04002717 RID: 10007
		private bool _depthClipEnable;

		// Token: 0x04002718 RID: 10008
		public static readonly RasterizerState CullClockwise;

		// Token: 0x04002719 RID: 10009
		public static readonly RasterizerState CullCounterClockwise;

		// Token: 0x0400271A RID: 10010
		public static readonly RasterizerState CullNone;
	}
}
