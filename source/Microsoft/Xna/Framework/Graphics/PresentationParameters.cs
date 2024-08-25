using System;
using System.Runtime.CompilerServices;

namespace Microsoft.Xna.Framework.Graphics
{
	// Token: 0x02000384 RID: 900
	public class PresentationParameters
	{
		// Token: 0x060017CE RID: 6094 RVA: 0x00065B88 File Offset: 0x00063D88
		public PresentationParameters()
		{
			this.Clear();
		}

		// Token: 0x170002F7 RID: 759
		// (get) Token: 0x060017CF RID: 6095 RVA: 0x00065BA8 File Offset: 0x00063DA8
		// (set) Token: 0x060017D0 RID: 6096 RVA: 0x00065BBC File Offset: 0x00063DBC
		public SurfaceFormat BackBufferFormat
		{
			get
			{
				return this.backBufferFormat;
			}
			set
			{
				this.backBufferFormat = value;
			}
		}

		// Token: 0x170002F8 RID: 760
		// (get) Token: 0x060017D1 RID: 6097 RVA: 0x00065BD0 File Offset: 0x00063DD0
		// (set) Token: 0x060017D2 RID: 6098 RVA: 0x00065BE4 File Offset: 0x00063DE4
		public int BackBufferHeight
		{
			get
			{
				return this.backBufferHeight;
			}
			set
			{
				this.backBufferHeight = value;
			}
		}

		// Token: 0x170002F9 RID: 761
		// (get) Token: 0x060017D3 RID: 6099 RVA: 0x00065BF8 File Offset: 0x00063DF8
		// (set) Token: 0x060017D4 RID: 6100 RVA: 0x00065C0C File Offset: 0x00063E0C
		public int BackBufferWidth
		{
			get
			{
				return this.backBufferWidth;
			}
			set
			{
				this.backBufferWidth = value;
			}
		}

		// Token: 0x170002FA RID: 762
		// (get) Token: 0x060017D5 RID: 6101 RVA: 0x00065C20 File Offset: 0x00063E20
		public Rectangle Bounds
		{
			get
			{
				/*
An exception occurred when decompiling this method (060017D5)

ICSharpCode.Decompiler.DecompilerException: Error decompiling Microsoft.Xna.Framework.Rectangle Microsoft.Xna.Framework.Graphics.PresentationParameters::get_Bounds()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:int32(var_0_06, ldfld:int32(PresentationParameters::backBufferHeight, ldloc:PresentationParameters(this)))
	stloc:native int(var_1_0D, ldfld:native int(PresentationParameters::deviceWindowHandle, ldloc:PresentationParameters(this)))
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

		// Token: 0x170002FB RID: 763
		// (get) Token: 0x060017D6 RID: 6102 RVA: 0x00065C40 File Offset: 0x00063E40
		// (set) Token: 0x060017D7 RID: 6103 RVA: 0x00065C54 File Offset: 0x00063E54
		public IntPtr DeviceWindowHandle
		{
			get
			{
				return this.deviceWindowHandle;
			}
			set
			{
				this.deviceWindowHandle = value;
			}
		}

		// Token: 0x170002FC RID: 764
		// (get) Token: 0x060017D8 RID: 6104 RVA: 0x00065C68 File Offset: 0x00063E68
		// (set) Token: 0x060017D9 RID: 6105 RVA: 0x00065C7C File Offset: 0x00063E7C
		public DepthFormat DepthStencilFormat
		{
			get
			{
				return this.depthStencilFormat;
			}
			set
			{
				this.depthStencilFormat = value;
			}
		}

		// Token: 0x170002FD RID: 765
		// (get) Token: 0x060017DA RID: 6106 RVA: 0x00065C90 File Offset: 0x00063E90
		// (set) Token: 0x060017DB RID: 6107 RVA: 0x00065CA4 File Offset: 0x00063EA4
		public bool IsFullScreen
		{
			get
			{
				return this.isFullScreen;
			}
			set
			{
			}
		}

		// Token: 0x170002FE RID: 766
		// (get) Token: 0x060017DC RID: 6108 RVA: 0x00065CB4 File Offset: 0x00063EB4
		// (set) Token: 0x060017DD RID: 6109 RVA: 0x00065CC8 File Offset: 0x00063EC8
		public bool HardwareModeSwitch
		{
			get
			{
				return this.hardwareModeSwitch;
			}
			set
			{
			}
		}

		// Token: 0x170002FF RID: 767
		// (get) Token: 0x060017DE RID: 6110 RVA: 0x00065CD8 File Offset: 0x00063ED8
		// (set) Token: 0x060017DF RID: 6111 RVA: 0x00065CEC File Offset: 0x00063EEC
		public int MultiSampleCount
		{
			get
			{
				return this.multiSampleCount;
			}
			set
			{
				this.multiSampleCount = value;
			}
		}

		// Token: 0x17000300 RID: 768
		// (get) Token: 0x060017E0 RID: 6112 RVA: 0x00065D00 File Offset: 0x00063F00
		// (set) Token: 0x060017E1 RID: 6113 RVA: 0x00065D14 File Offset: 0x00063F14
		public PresentInterval PresentationInterval
		{
			[CompilerGenerated]
			get
			{
				return this.<PresentationInterval>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<PresentationInterval>k__BackingField = value;
			}
		}

		// Token: 0x17000301 RID: 769
		// (get) Token: 0x060017E2 RID: 6114 RVA: 0x00065D28 File Offset: 0x00063F28
		// (set) Token: 0x060017E3 RID: 6115 RVA: 0x00065D3C File Offset: 0x00063F3C
		public DisplayOrientation DisplayOrientation
		{
			[CompilerGenerated]
			get
			{
				return this.<DisplayOrientation>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<DisplayOrientation>k__BackingField = value;
			}
		}

		// Token: 0x17000302 RID: 770
		// (get) Token: 0x060017E4 RID: 6116 RVA: 0x00065D50 File Offset: 0x00063F50
		// (set) Token: 0x060017E5 RID: 6117 RVA: 0x00065D64 File Offset: 0x00063F64
		public RenderTargetUsage RenderTargetUsage
		{
			[CompilerGenerated]
			get
			{
				return this.<RenderTargetUsage>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<RenderTargetUsage>k__BackingField = value;
			}
		}

		// Token: 0x060017E6 RID: 6118 RVA: 0x00065D78 File Offset: 0x00063F78
		public void Clear()
		{
		}

		// Token: 0x060017E7 RID: 6119 RVA: 0x00065D88 File Offset: 0x00063F88
		public PresentationParameters Clone()
		{
			/*
An exception occurred when decompiling this method (060017E7)

ICSharpCode.Decompiler.DecompilerException: Error decompiling Microsoft.Xna.Framework.Graphics.PresentationParameters Microsoft.Xna.Framework.Graphics.PresentationParameters::Clone()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:native int(var_0_06, ldfld:native int(PresentationParameters::deviceWindowHandle, ldloc:PresentationParameters(this)))
	stloc:int32(var_1_12, ldfld:int32(DepthFormat::value__, ldfld:DepthFormat[exp:valuetype Microsoft.Xna.Framework.Graphics.DepthFormat&](PresentationParameters::depthStencilFormat, ldloc:PresentationParameters(this))))
	stloc:bool(var_2_19, ldfld:bool(PresentationParameters::isFullScreen, ldloc:PresentationParameters(this)))
	stloc:bool(var_3_20, ldfld:bool(PresentationParameters::hardwareModeSwitch, ldloc:PresentationParameters(this)))
	stloc:int32(var_4_27, ldfld:int32(PresentationParameters::multiSampleCount, ldloc:PresentationParameters(this)))
	stloc:PresentInterval(var_5_2F, ldfld:PresentInterval(PresentationParameters::<PresentationInterval>k__BackingField, ldloc:PresentationParameters(this)))
	stloc:RenderTargetUsage(var_6_37, ldfld:RenderTargetUsage(PresentationParameters::<RenderTargetUsage>k__BackingField, ldloc:PresentationParameters(this)))
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

		// Token: 0x04002624 RID: 9764
		public const int DefaultPresentRate = 60;

		// Token: 0x04002625 RID: 9765
		private DepthFormat depthStencilFormat;

		// Token: 0x04002626 RID: 9766
		private SurfaceFormat backBufferFormat;

		// Token: 0x04002627 RID: 9767
		private int backBufferHeight;

		// Token: 0x04002628 RID: 9768
		private int backBufferWidth;

		// Token: 0x04002629 RID: 9769
		private IntPtr deviceWindowHandle;

		// Token: 0x0400262A RID: 9770
		private int multiSampleCount;

		// Token: 0x0400262B RID: 9771
		private bool isFullScreen;

		// Token: 0x0400262C RID: 9772
		private bool hardwareModeSwitch = true;

		// Token: 0x0400262D RID: 9773
		[CompilerGenerated]
		private PresentInterval <PresentationInterval>k__BackingField;

		// Token: 0x0400262E RID: 9774
		[CompilerGenerated]
		private DisplayOrientation <DisplayOrientation>k__BackingField;

		// Token: 0x0400262F RID: 9775
		[CompilerGenerated]
		private RenderTargetUsage <RenderTargetUsage>k__BackingField;
	}
}
