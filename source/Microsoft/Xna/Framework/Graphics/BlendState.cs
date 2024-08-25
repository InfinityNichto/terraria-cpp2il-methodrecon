using System;
using Cpp2IlInjected;

namespace Microsoft.Xna.Framework.Graphics
{
	// Token: 0x0200039B RID: 923
	public class BlendState : GraphicsResource
	{
		// Token: 0x0600187F RID: 6271 RVA: 0x00069368 File Offset: 0x00067568
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

		// Token: 0x06001880 RID: 6272 RVA: 0x00069390 File Offset: 0x00067590
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

		// Token: 0x17000315 RID: 789
		public TargetBlendState this[int index]
		{
			get
			{
				/*
An exception occurred when decompiling this method (06001881)

ICSharpCode.Decompiler.DecompilerException: Error decompiling Microsoft.Xna.Framework.Graphics.TargetBlendState Microsoft.Xna.Framework.Graphics.BlendState::get_Item(System.Int32)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:Blend(var_0_0B, ldfld:Blend(TargetBlendState::_alphaSourceBlend, ldfld:class Microsoft.Xna.Framework.Graphics.TargetBlendState[][exp:TargetBlendState](BlendState::_targetBlendState, ldloc:BlendState(this))))
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

		// Token: 0x17000316 RID: 790
		// (get) Token: 0x06001882 RID: 6274 RVA: 0x000693C8 File Offset: 0x000675C8
		// (set) Token: 0x06001883 RID: 6275 RVA: 0x000693E0 File Offset: 0x000675E0
		public BlendFunction AlphaBlendFunction
		{
			get
			{
				/*
An exception occurred when decompiling this method (06001882)

ICSharpCode.Decompiler.DecompilerException: Error decompiling Microsoft.Xna.Framework.Graphics.BlendFunction Microsoft.Xna.Framework.Graphics.BlendState::get_AlphaBlendFunction()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:Blend(var_0_0B, ldfld:Blend(TargetBlendState::_alphaSourceBlend, ldfld:class Microsoft.Xna.Framework.Graphics.TargetBlendState[][exp:TargetBlendState](BlendState::_targetBlendState, ldloc:BlendState(this))))
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
				Blend alphaSourceBlend = this._targetBlendState._alphaSourceBlend;
				this.ThrowIfBound();
			}
		}

		// Token: 0x17000317 RID: 791
		// (get) Token: 0x06001884 RID: 6276 RVA: 0x00069408 File Offset: 0x00067608
		// (set) Token: 0x06001885 RID: 6277 RVA: 0x00069420 File Offset: 0x00067620
		public Blend AlphaDestinationBlend
		{
			get
			{
				/*
An exception occurred when decompiling this method (06001884)

ICSharpCode.Decompiler.DecompilerException: Error decompiling Microsoft.Xna.Framework.Graphics.Blend Microsoft.Xna.Framework.Graphics.BlendState::get_AlphaDestinationBlend()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:Blend(var_0_0B, ldfld:Blend(TargetBlendState::_alphaSourceBlend, ldfld:class Microsoft.Xna.Framework.Graphics.TargetBlendState[][exp:TargetBlendState](BlendState::_targetBlendState, ldloc:BlendState(this))))
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
				Blend alphaSourceBlend = this._targetBlendState._alphaSourceBlend;
				this.ThrowIfBound();
			}
		}

		// Token: 0x17000318 RID: 792
		// (get) Token: 0x06001886 RID: 6278 RVA: 0x00069448 File Offset: 0x00067648
		// (set) Token: 0x06001887 RID: 6279 RVA: 0x00069460 File Offset: 0x00067660
		public Blend AlphaSourceBlend
		{
			get
			{
				/*
An exception occurred when decompiling this method (06001886)

ICSharpCode.Decompiler.DecompilerException: Error decompiling Microsoft.Xna.Framework.Graphics.Blend Microsoft.Xna.Framework.Graphics.BlendState::get_AlphaSourceBlend()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:Blend(var_0_0B, ldfld:Blend(TargetBlendState::_alphaSourceBlend, ldfld:class Microsoft.Xna.Framework.Graphics.TargetBlendState[][exp:TargetBlendState](BlendState::_targetBlendState, ldloc:BlendState(this))))
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
				Blend alphaSourceBlend = this._targetBlendState._alphaSourceBlend;
				this.ThrowIfBound();
			}
		}

		// Token: 0x17000319 RID: 793
		// (get) Token: 0x06001888 RID: 6280 RVA: 0x00069488 File Offset: 0x00067688
		// (set) Token: 0x06001889 RID: 6281 RVA: 0x000694A0 File Offset: 0x000676A0
		public BlendFunction ColorBlendFunction
		{
			get
			{
				/*
An exception occurred when decompiling this method (06001888)

ICSharpCode.Decompiler.DecompilerException: Error decompiling Microsoft.Xna.Framework.Graphics.BlendFunction Microsoft.Xna.Framework.Graphics.BlendState::get_ColorBlendFunction()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:Blend(var_0_0B, ldfld:Blend(TargetBlendState::_alphaSourceBlend, ldfld:class Microsoft.Xna.Framework.Graphics.TargetBlendState[][exp:TargetBlendState](BlendState::_targetBlendState, ldloc:BlendState(this))))
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
				Blend alphaSourceBlend = this._targetBlendState._alphaSourceBlend;
				this.ThrowIfBound();
			}
		}

		// Token: 0x1700031A RID: 794
		// (get) Token: 0x0600188A RID: 6282 RVA: 0x000694C8 File Offset: 0x000676C8
		// (set) Token: 0x0600188B RID: 6283 RVA: 0x000694E0 File Offset: 0x000676E0
		public Blend ColorDestinationBlend
		{
			get
			{
				/*
An exception occurred when decompiling this method (0600188A)

ICSharpCode.Decompiler.DecompilerException: Error decompiling Microsoft.Xna.Framework.Graphics.Blend Microsoft.Xna.Framework.Graphics.BlendState::get_ColorDestinationBlend()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:Blend(var_0_0B, ldfld:Blend(TargetBlendState::_alphaSourceBlend, ldfld:class Microsoft.Xna.Framework.Graphics.TargetBlendState[][exp:TargetBlendState](BlendState::_targetBlendState, ldloc:BlendState(this))))
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
				Blend alphaSourceBlend = this._targetBlendState._alphaSourceBlend;
				this.ThrowIfBound();
			}
		}

		// Token: 0x1700031B RID: 795
		// (get) Token: 0x0600188C RID: 6284 RVA: 0x00069508 File Offset: 0x00067708
		// (set) Token: 0x0600188D RID: 6285 RVA: 0x00069520 File Offset: 0x00067720
		public Blend ColorSourceBlend
		{
			get
			{
				/*
An exception occurred when decompiling this method (0600188C)

ICSharpCode.Decompiler.DecompilerException: Error decompiling Microsoft.Xna.Framework.Graphics.Blend Microsoft.Xna.Framework.Graphics.BlendState::get_ColorSourceBlend()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:Blend(var_0_0B, ldfld:Blend(TargetBlendState::_alphaSourceBlend, ldfld:class Microsoft.Xna.Framework.Graphics.TargetBlendState[][exp:TargetBlendState](BlendState::_targetBlendState, ldloc:BlendState(this))))
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
				Blend alphaSourceBlend = this._targetBlendState._alphaSourceBlend;
				this.ThrowIfBound();
			}
		}

		// Token: 0x1700031C RID: 796
		// (get) Token: 0x0600188E RID: 6286 RVA: 0x00069548 File Offset: 0x00067748
		// (set) Token: 0x0600188F RID: 6287 RVA: 0x00069560 File Offset: 0x00067760
		public ColorWriteChannels ColorWriteChannels
		{
			get
			{
				/*
An exception occurred when decompiling this method (0600188E)

ICSharpCode.Decompiler.DecompilerException: Error decompiling Microsoft.Xna.Framework.Graphics.ColorWriteChannels Microsoft.Xna.Framework.Graphics.BlendState::get_ColorWriteChannels()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:Blend(var_0_0B, ldfld:Blend(TargetBlendState::_alphaSourceBlend, ldfld:class Microsoft.Xna.Framework.Graphics.TargetBlendState[][exp:TargetBlendState](BlendState::_targetBlendState, ldloc:BlendState(this))))
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
				Blend alphaSourceBlend = this._targetBlendState._alphaSourceBlend;
				this.ThrowIfBound();
			}
		}

		// Token: 0x1700031D RID: 797
		// (get) Token: 0x06001890 RID: 6288 RVA: 0x00069588 File Offset: 0x00067788
		// (set) Token: 0x06001891 RID: 6289 RVA: 0x000695A0 File Offset: 0x000677A0
		public ColorWriteChannels ColorWriteChannels1
		{
			get
			{
				/*
An exception occurred when decompiling this method (06001890)

ICSharpCode.Decompiler.DecompilerException: Error decompiling Microsoft.Xna.Framework.Graphics.ColorWriteChannels Microsoft.Xna.Framework.Graphics.BlendState::get_ColorWriteChannels1()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:Blend(var_0_0B, ldfld:Blend(TargetBlendState::_colorDestinationBlend, ldfld:class Microsoft.Xna.Framework.Graphics.TargetBlendState[][exp:TargetBlendState](BlendState::_targetBlendState, ldloc:BlendState(this))))
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
				Blend colorDestinationBlend = this._targetBlendState._colorDestinationBlend;
				this.ThrowIfBound();
			}
		}

		// Token: 0x1700031E RID: 798
		// (get) Token: 0x06001892 RID: 6290 RVA: 0x000695C8 File Offset: 0x000677C8
		// (set) Token: 0x06001893 RID: 6291 RVA: 0x000695E0 File Offset: 0x000677E0
		public ColorWriteChannels ColorWriteChannels2
		{
			get
			{
				/*
An exception occurred when decompiling this method (06001892)

ICSharpCode.Decompiler.DecompilerException: Error decompiling Microsoft.Xna.Framework.Graphics.ColorWriteChannels Microsoft.Xna.Framework.Graphics.BlendState::get_ColorWriteChannels2()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:ColorWriteChannels(var_0_0B, ldfld:ColorWriteChannels(TargetBlendState::_colorWriteChannels, ldfld:class Microsoft.Xna.Framework.Graphics.TargetBlendState[][exp:TargetBlendState](BlendState::_targetBlendState, ldloc:BlendState(this))))
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
				ColorWriteChannels colorWriteChannels = this._targetBlendState._colorWriteChannels;
				this.ThrowIfBound();
			}
		}

		// Token: 0x1700031F RID: 799
		// (get) Token: 0x06001894 RID: 6292 RVA: 0x00069608 File Offset: 0x00067808
		// (set) Token: 0x06001895 RID: 6293 RVA: 0x00069620 File Offset: 0x00067820
		public ColorWriteChannels ColorWriteChannels3
		{
			get
			{
				return this._targetBlendState._colorWriteChannels;
			}
			set
			{
				this.ThrowIfBound();
				TargetBlendState[] targetBlendState = this._targetBlendState;
				GraphicsDevice graphicsDevice = this.graphicsDevice;
				this._targetBlendState = value;
			}
		}

		// Token: 0x17000320 RID: 800
		// (get) Token: 0x06001896 RID: 6294 RVA: 0x00069648 File Offset: 0x00067848
		// (set) Token: 0x06001897 RID: 6295 RVA: 0x00069658 File Offset: 0x00067858
		public Color BlendFactor
		{
			get
			{
				Color color;
				return color;
			}
			set
			{
				this.ThrowIfBound();
			}
		}

		// Token: 0x17000321 RID: 801
		// (get) Token: 0x06001898 RID: 6296 RVA: 0x0006966C File Offset: 0x0006786C
		// (set) Token: 0x06001899 RID: 6297 RVA: 0x00069680 File Offset: 0x00067880
		public int MultiSampleMask
		{
			get
			{
				return this._multiSampleMask;
			}
			set
			{
				this.ThrowIfBound();
				this._multiSampleMask = value;
			}
		}

		// Token: 0x17000322 RID: 802
		// (get) Token: 0x0600189A RID: 6298 RVA: 0x0006969C File Offset: 0x0006789C
		// (set) Token: 0x0600189B RID: 6299 RVA: 0x000696B0 File Offset: 0x000678B0
		public bool IndependentBlendEnable
		{
			get
			{
				return this._independentBlendEnable;
			}
			set
			{
				this.ThrowIfBound();
			}
		}

		// Token: 0x0600189C RID: 6300 RVA: 0x000696C4 File Offset: 0x000678C4
		public BlendState()
		{
			TargetBlendState[] targetBlendState = this._targetBlendState;
			TargetBlendState[] targetBlendState2 = this._targetBlendState;
			TargetBlendState[] targetBlendState3 = this._targetBlendState;
		}

		// Token: 0x0600189D RID: 6301 RVA: 0x000696F4 File Offset: 0x000678F4
		private BlendState(string name, Blend sourceBlend, Blend destinationBlend)
		{
			this.<Name>k__BackingField = name;
			this.ThrowIfBound();
			Blend alphaSourceBlend = this._targetBlendState._alphaSourceBlend;
			this.ThrowIfBound();
			this.ThrowIfBound();
			Blend alphaSourceBlend2 = this._targetBlendState._alphaSourceBlend;
			this.ThrowIfBound();
			this.ThrowIfBound();
			Blend alphaSourceBlend3 = this._targetBlendState._alphaSourceBlend;
			this.ThrowIfBound();
			this.ThrowIfBound();
			Blend alphaSourceBlend4 = this._targetBlendState._alphaSourceBlend;
			this.ThrowIfBound();
			this._defaultStateObject = true;
		}

		// Token: 0x0600189E RID: 6302 RVA: 0x00069770 File Offset: 0x00067970
		private BlendState(BlendState cloneSource)
		{
			string <Name>k__BackingField = cloneSource.<Name>k__BackingField;
			this.<Name>k__BackingField = <Name>k__BackingField;
			Blend alphaSourceBlend = cloneSource._targetBlendState._alphaSourceBlend;
			TargetBlendState targetBlendState;
			if (targetBlendState == null || targetBlendState != null)
			{
				TargetBlendState[] targetBlendState2 = cloneSource._targetBlendState;
				TargetBlendState[] targetBlendState3 = this._targetBlendState;
				TargetBlendState targetBlendState4 = targetBlendState.Clone(this);
				if (targetBlendState4 == null || targetBlendState4 != null)
				{
					targetBlendState3._colorDestinationBlend = targetBlendState4;
					TargetBlendState[] targetBlendState5 = cloneSource._targetBlendState;
					TargetBlendState[] targetBlendState6 = this._targetBlendState;
					ColorWriteChannels colorWriteChannels = targetBlendState5._colorWriteChannels;
					TargetBlendState targetBlendState7;
					if (targetBlendState7 == null || targetBlendState7 != null)
					{
						targetBlendState6._colorWriteChannels = targetBlendState7;
						TargetBlendState[] targetBlendState8 = cloneSource._targetBlendState;
						TargetBlendState[] targetBlendState9 = this._targetBlendState;
						TargetBlendState targetBlendState10 = targetBlendState7.Clone(this);
						if (targetBlendState10 == null || targetBlendState10 != null)
						{
							int multiSampleMask = cloneSource._multiSampleMask;
							this._multiSampleMask = multiSampleMask;
							bool independentBlendEnable = cloneSource._independentBlendEnable;
							this._independentBlendEnable = independentBlendEnable;
							return;
						}
					}
				}
			}
			throw new ArrayTypeMismatchException();
		}

		// Token: 0x0600189F RID: 6303 RVA: 0x00069844 File Offset: 0x00067A44
		static BlendState()
		{
		}

		// Token: 0x060018A0 RID: 6304 RVA: 0x000021DB File Offset: 0x000003DB
		internal BlendState Clone()
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x040026DE RID: 9950
		private readonly TargetBlendState[] _targetBlendState;

		// Token: 0x040026DF RID: 9951
		private readonly bool _defaultStateObject;

		// Token: 0x040026E0 RID: 9952
		private Color _blendFactor;

		// Token: 0x040026E1 RID: 9953
		private int _multiSampleMask;

		// Token: 0x040026E2 RID: 9954
		private bool _independentBlendEnable;

		// Token: 0x040026E3 RID: 9955
		public static readonly BlendState Additive;

		// Token: 0x040026E4 RID: 9956
		public static readonly BlendState AlphaBlend;

		// Token: 0x040026E5 RID: 9957
		public static readonly BlendState NonPremultiplied;

		// Token: 0x040026E6 RID: 9958
		public static readonly BlendState Opaque;
	}
}
