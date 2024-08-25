using System;
using System.Runtime.CompilerServices;

namespace Microsoft.Xna.Framework.Graphics
{
	// Token: 0x02000386 RID: 902
	public class RenderTarget2D : Texture2D, IRenderTarget
	{
		// Token: 0x17000303 RID: 771
		// (get) Token: 0x060017E8 RID: 6120 RVA: 0x00065DD0 File Offset: 0x00063FD0
		// (set) Token: 0x060017E9 RID: 6121 RVA: 0x00065DE4 File Offset: 0x00063FE4
		public DepthFormat DepthStencilFormat
		{
			[CompilerGenerated]
			get
			{
				return this.<DepthStencilFormat>k__BackingField;
			}
			[CompilerGenerated]
			private set
			{
				this.<DepthStencilFormat>k__BackingField = value;
			}
		}

		// Token: 0x17000304 RID: 772
		// (get) Token: 0x060017EA RID: 6122 RVA: 0x00065DF8 File Offset: 0x00063FF8
		// (set) Token: 0x060017EB RID: 6123 RVA: 0x00065E0C File Offset: 0x0006400C
		public int MultiSampleCount
		{
			[CompilerGenerated]
			get
			{
				return this.<MultiSampleCount>k__BackingField;
			}
			[CompilerGenerated]
			private set
			{
				this.<MultiSampleCount>k__BackingField = value;
			}
		}

		// Token: 0x17000305 RID: 773
		// (get) Token: 0x060017EC RID: 6124 RVA: 0x00065E20 File Offset: 0x00064020
		// (set) Token: 0x060017ED RID: 6125 RVA: 0x00065E34 File Offset: 0x00064034
		public RenderTargetUsage RenderTargetUsage
		{
			[CompilerGenerated]
			get
			{
				return this.<RenderTargetUsage>k__BackingField;
			}
			[CompilerGenerated]
			private set
			{
				this.<RenderTargetUsage>k__BackingField = value;
			}
		}

		// Token: 0x17000306 RID: 774
		// (get) Token: 0x060017EE RID: 6126 RVA: 0x00065E48 File Offset: 0x00064048
		public bool IsContentLost
		{
			get
			{
			}
		}

		// Token: 0x1400001E RID: 30
		// (add) Token: 0x060017EF RID: 6127 RVA: 0x00065E58 File Offset: 0x00064058
		// (remove) Token: 0x060017F0 RID: 6128 RVA: 0x00065E80 File Offset: 0x00064080
		public event EventHandler<EventArgs> ContentLost
		{
			[CompilerGenerated]
			add
			{
				Delegate @delegate = Delegate.Combine(this.ContentLost, value);
				if (@delegate != null && @delegate == null)
				{
					return;
				}
			}
			[CompilerGenerated]
			remove
			{
				Delegate @delegate = Delegate.Remove(this.ContentLost, value);
				if (@delegate != null && @delegate == null)
				{
					return;
				}
			}
		}

		// Token: 0x060017F1 RID: 6129 RVA: 0x00065EA8 File Offset: 0x000640A8
		private bool SuppressEventHandlerWarningsUntilEventsAreProperlyImplemented()
		{
			/*
An exception occurred when decompiling this method (060017F1)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean Microsoft.Xna.Framework.Graphics.RenderTarget2D::SuppressEventHandlerWarningsUntilEventsAreProperlyImplemented()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:class [mscorlib]System.EventHandler`1<class [mscorlib]System.EventArgs>(var_0_06, ldfld:class [mscorlib]System.EventHandler`1<class [mscorlib]System.EventArgs>(RenderTarget2D::ContentLost, ldloc:RenderTarget2D(this)))
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

		// Token: 0x060017F2 RID: 6130 RVA: 0x00065EBC File Offset: 0x000640BC
		public RenderTarget2D(GraphicsDevice device, int width, int height, bool mipMap, SurfaceFormat preferredFormat, DepthFormat preferredDepthFormat, int preferredMultiSampleCount, RenderTargetUsage usage, bool shared, int arraySize)
		{
			this.DepthStencilFormat = preferredDepthFormat;
		}

		// Token: 0x060017F3 RID: 6131 RVA: 0x00065ED4 File Offset: 0x000640D4
		public RenderTarget2D(GraphicsDevice device, int width, int height, bool mipMap, SurfaceFormat preferredFormat, DepthFormat preferredDepthFormat, int preferredMultiSampleCount, RenderTargetUsage usage, bool shared)
		{
			this.DepthStencilFormat = preferredDepthFormat;
		}

		// Token: 0x060017F4 RID: 6132 RVA: 0x00065EEC File Offset: 0x000640EC
		public RenderTarget2D(GraphicsDevice device, int width, int height, bool mipMap, SurfaceFormat preferredFormat, DepthFormat preferredDepthFormat, int preferredMultiSampleCount, RenderTargetUsage usage)
		{
			this.DepthStencilFormat = preferredDepthFormat;
		}

		// Token: 0x060017F5 RID: 6133 RVA: 0x00065F04 File Offset: 0x00064104
		public RenderTarget2D(GraphicsDevice device, int width, int height, bool mipMap, SurfaceFormat preferredFormat, DepthFormat preferredDepthFormat)
		{
			this.DepthStencilFormat = preferredDepthFormat;
		}

		// Token: 0x060017F6 RID: 6134 RVA: 0x00065F1C File Offset: 0x0006411C
		public RenderTarget2D(GraphicsDevice device, int width, int height)
		{
		}

		// Token: 0x060017F7 RID: 6135 RVA: 0x00065F2C File Offset: 0x0006412C
		protected RenderTarget2D(GraphicsDevice device, int width, int height, bool mipMap, SurfaceFormat format, DepthFormat depthFormat, int preferredMultiSampleCount, RenderTargetUsage usage, Texture2D.SurfaceType surfaceType)
		{
			this.DepthStencilFormat = depthFormat;
			this.RenderTargetUsage = (RenderTargetUsage)preferredMultiSampleCount;
		}

		// Token: 0x060017F8 RID: 6136 RVA: 0x00065F4C File Offset: 0x0006414C
		protected internal override void GraphicsDeviceResetting()
		{
			base.GraphicsDeviceResetting();
		}

		// Token: 0x04002635 RID: 9781
		[CompilerGenerated]
		private DepthFormat <DepthStencilFormat>k__BackingField;

		// Token: 0x04002636 RID: 9782
		[CompilerGenerated]
		private int <MultiSampleCount>k__BackingField;

		// Token: 0x04002637 RID: 9783
		[CompilerGenerated]
		private RenderTargetUsage <RenderTargetUsage>k__BackingField;

		// Token: 0x04002638 RID: 9784
		[CompilerGenerated]
		private EventHandler<EventArgs> ContentLost;
	}
}
