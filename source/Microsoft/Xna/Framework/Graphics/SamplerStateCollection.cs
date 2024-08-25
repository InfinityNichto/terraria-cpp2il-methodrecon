using System;

namespace Microsoft.Xna.Framework.Graphics
{
	// Token: 0x0200038B RID: 907
	public sealed class SamplerStateCollection
	{
		// Token: 0x06001806 RID: 6150 RVA: 0x00066058 File Offset: 0x00064258
		internal SamplerStateCollection(GraphicsDevice device, int maxSamplers, bool applyToVertexStage)
		{
			this._graphicsDevice = device;
			if (!true)
			{
			}
			SamplerState samplerState;
			this._samplerStateAnisotropicClamp = samplerState;
			SamplerState samplerState2 = samplerState.Clone();
			this._samplerStateAnisotropicWrap = samplerState2;
			SamplerState samplerState3 = samplerState2.Clone();
			this._samplerStateLinearClamp = samplerState3;
			SamplerState samplerState4 = samplerState3.Clone();
			this._samplerStateLinearWrap = samplerState4;
			SamplerState samplerState5 = samplerState4.Clone();
			this._samplerStatePointClamp = samplerState5;
			SamplerState samplerState6 = samplerState5.Clone();
			this._samplerStatePointWrap = samplerState6;
			this.Clear();
		}

		// Token: 0x1700030D RID: 781
		public SamplerState this[int index]
		{
			get
			{
				/*
An exception occurred when decompiling this method (06001807)

ICSharpCode.Decompiler.DecompilerException: Error decompiling Microsoft.Xna.Framework.Graphics.SamplerState Microsoft.Xna.Framework.Graphics.SamplerStateCollection::get_Item(System.Int32)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:string(var_0_0B, ldfld:string(GraphicsResource::<Name>k__BackingField, ldfld:class Microsoft.Xna.Framework.Graphics.SamplerState[][exp:GraphicsResource](SamplerStateCollection::_samplers, ldloc:SamplerStateCollection(this))))
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
				if (value != null)
				{
					SamplerState[] samplers = this._samplers;
					if (value != null)
					{
						return;
					}
				}
				throw new ArrayTypeMismatchException();
			}
		}

		// Token: 0x06001809 RID: 6153 RVA: 0x0006611C File Offset: 0x0006431C
		internal void Clear()
		{
			if (!true)
			{
			}
			SamplerState samplerStateLinearWrap = this._samplerStateLinearWrap;
			GraphicsDevice graphicsDevice = this._graphicsDevice;
			samplerStateLinearWrap.BindToGraphicsDevice(graphicsDevice);
			SamplerState samplerStateLinearWrap2 = this._samplerStateLinearWrap;
			SamplerState[] actualSamplers = this._actualSamplers;
			if (samplerStateLinearWrap2 == null || samplerStateLinearWrap2 != null)
			{
				SamplerState[] samplers = this._samplers;
				return;
			}
			throw new ArrayTypeMismatchException();
		}

		// Token: 0x0600180A RID: 6154 RVA: 0x00066164 File Offset: 0x00064364
		internal void Dirty()
		{
		}

		// Token: 0x04002643 RID: 9795
		private readonly GraphicsDevice _graphicsDevice;

		// Token: 0x04002644 RID: 9796
		private readonly SamplerState _samplerStateAnisotropicClamp;

		// Token: 0x04002645 RID: 9797
		private readonly SamplerState _samplerStateAnisotropicWrap;

		// Token: 0x04002646 RID: 9798
		private readonly SamplerState _samplerStateLinearClamp;

		// Token: 0x04002647 RID: 9799
		private readonly SamplerState _samplerStateLinearWrap;

		// Token: 0x04002648 RID: 9800
		private readonly SamplerState _samplerStatePointClamp;

		// Token: 0x04002649 RID: 9801
		private readonly SamplerState _samplerStatePointWrap;

		// Token: 0x0400264A RID: 9802
		private readonly SamplerState[] _samplers;

		// Token: 0x0400264B RID: 9803
		private readonly SamplerState[] _actualSamplers;

		// Token: 0x0400264C RID: 9804
		private readonly bool _applyToVertexStage;
	}
}
