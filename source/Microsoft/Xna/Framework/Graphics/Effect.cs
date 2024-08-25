using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace Microsoft.Xna.Framework.Graphics
{
	// Token: 0x02000362 RID: 866
	public class Effect : GraphicsResource
	{
		// Token: 0x17000298 RID: 664
		// (get) Token: 0x06001690 RID: 5776 RVA: 0x00063010 File Offset: 0x00061210
		// (set) Token: 0x06001691 RID: 5777 RVA: 0x00063024 File Offset: 0x00061224
		public EffectParameterCollection Parameters
		{
			[CompilerGenerated]
			get
			{
				return this.<Parameters>k__BackingField;
			}
			[CompilerGenerated]
			protected set
			{
				this.<Parameters>k__BackingField = value;
			}
		}

		// Token: 0x17000299 RID: 665
		// (get) Token: 0x06001692 RID: 5778 RVA: 0x00063038 File Offset: 0x00061238
		// (set) Token: 0x06001693 RID: 5779 RVA: 0x0006304C File Offset: 0x0006124C
		public EffectTechnique CurrentTechnique
		{
			[CompilerGenerated]
			get
			{
				return this.<CurrentTechnique>k__BackingField;
			}
			[CompilerGenerated]
			protected set
			{
				this.<CurrentTechnique>k__BackingField = value;
			}
		}

		// Token: 0x06001694 RID: 5780 RVA: 0x00063060 File Offset: 0x00061260
		internal Effect(GraphicsDevice graphicsDevice)
		{
			base.GraphicsDevice = graphicsDevice;
		}

		// Token: 0x06001695 RID: 5781 RVA: 0x0006307C File Offset: 0x0006127C
		protected Effect(Effect cloneSource)
		{
			GraphicsDevice graphicsDevice = cloneSource.graphicsDevice;
			base..ctor();
			base.GraphicsDevice = graphicsDevice;
			this._isClone = true;
		}

		// Token: 0x06001696 RID: 5782 RVA: 0x000630A4 File Offset: 0x000612A4
		public virtual void ApplyValuesToMaterial(EffectPass pass, Material material)
		{
		}

		// Token: 0x06001697 RID: 5783 RVA: 0x000630B4 File Offset: 0x000612B4
		private void Clone(Effect cloneSource)
		{
		}

		// Token: 0x06001698 RID: 5784 RVA: 0x000630C4 File Offset: 0x000612C4
		public virtual Effect Clone()
		{
			/*
An exception occurred when decompiling this method (06001698)

ICSharpCode.Decompiler.DecompilerException: Error decompiling Microsoft.Xna.Framework.Graphics.Effect Microsoft.Xna.Framework.Graphics.Effect::Clone()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:GraphicsDevice(var_0_06, ldfld:GraphicsDevice(GraphicsResource::graphicsDevice, ldloc:Effect[exp:GraphicsResource](this)))
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

		// Token: 0x06001699 RID: 5785 RVA: 0x000630D8 File Offset: 0x000612D8
		protected internal virtual void OnApply()
		{
		}

		// Token: 0x040024D5 RID: 9429
		[CompilerGenerated]
		private EffectParameterCollection <Parameters>k__BackingField;

		// Token: 0x040024D6 RID: 9430
		[CompilerGenerated]
		private EffectTechnique <CurrentTechnique>k__BackingField;

		// Token: 0x040024D7 RID: 9431
		private readonly bool _isClone;
	}
}
