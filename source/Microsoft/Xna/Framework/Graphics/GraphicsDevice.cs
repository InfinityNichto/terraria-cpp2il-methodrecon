using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using UnityEngine;
using UnityEngine.Rendering;

namespace Microsoft.Xna.Framework.Graphics
{
	// Token: 0x0200037A RID: 890
	public class GraphicsDevice
	{
		// Token: 0x170002E1 RID: 737
		// (get) Token: 0x0600176C RID: 5996 RVA: 0x0006508C File Offset: 0x0006328C
		// (set) Token: 0x0600176D RID: 5997 RVA: 0x000650A0 File Offset: 0x000632A0
		internal GraphicsCapabilities GraphicsCapabilities
		{
			[CompilerGenerated]
			get
			{
				return this.<GraphicsCapabilities>k__BackingField;
			}
			[CompilerGenerated]
			private set
			{
				this.<GraphicsCapabilities>k__BackingField = value;
			}
		}

		// Token: 0x14000012 RID: 18
		// (add) Token: 0x0600176E RID: 5998 RVA: 0x000650B4 File Offset: 0x000632B4
		// (remove) Token: 0x0600176F RID: 5999 RVA: 0x000650DC File Offset: 0x000632DC
		public event EventHandler<EventArgs> DeviceLost
		{
			[CompilerGenerated]
			add
			{
				Delegate @delegate = Delegate.Combine(this.DeviceLost, value);
				if (@delegate != null && @delegate == null)
				{
					return;
				}
			}
			[CompilerGenerated]
			remove
			{
				Delegate @delegate = Delegate.Remove(this.DeviceLost, value);
				if (@delegate != null && @delegate == null)
				{
					return;
				}
			}
		}

		// Token: 0x14000013 RID: 19
		// (add) Token: 0x06001770 RID: 6000 RVA: 0x00065104 File Offset: 0x00063304
		// (remove) Token: 0x06001771 RID: 6001 RVA: 0x0006512C File Offset: 0x0006332C
		public event EventHandler<EventArgs> DeviceReset
		{
			[CompilerGenerated]
			add
			{
				Delegate @delegate = Delegate.Combine(this.DeviceReset, value);
				if (@delegate != null && @delegate == null)
				{
					return;
				}
			}
			[CompilerGenerated]
			remove
			{
				Delegate @delegate = Delegate.Remove(this.DeviceReset, value);
				if (@delegate != null && @delegate == null)
				{
					return;
				}
			}
		}

		// Token: 0x14000014 RID: 20
		// (add) Token: 0x06001772 RID: 6002 RVA: 0x00065154 File Offset: 0x00063354
		// (remove) Token: 0x06001773 RID: 6003 RVA: 0x0006517C File Offset: 0x0006337C
		public event EventHandler<EventArgs> DeviceResetting
		{
			[CompilerGenerated]
			add
			{
				Delegate @delegate = Delegate.Combine(this.DeviceResetting, value);
				if (@delegate != null && @delegate == null)
				{
					return;
				}
			}
			[CompilerGenerated]
			remove
			{
				Delegate @delegate = Delegate.Remove(this.DeviceResetting, value);
				if (@delegate != null && @delegate == null)
				{
					return;
				}
			}
		}

		// Token: 0x14000015 RID: 21
		// (add) Token: 0x06001774 RID: 6004 RVA: 0x000651A4 File Offset: 0x000633A4
		// (remove) Token: 0x06001775 RID: 6005 RVA: 0x000651CC File Offset: 0x000633CC
		public event EventHandler<ResourceCreatedEventArgs> ResourceCreated
		{
			[CompilerGenerated]
			add
			{
				Delegate @delegate = Delegate.Combine(this.ResourceCreated, value);
				if (@delegate != null && @delegate == null)
				{
					return;
				}
			}
			[CompilerGenerated]
			remove
			{
				Delegate @delegate = Delegate.Remove(this.ResourceCreated, value);
				if (@delegate != null && @delegate == null)
				{
					return;
				}
			}
		}

		// Token: 0x14000016 RID: 22
		// (add) Token: 0x06001776 RID: 6006 RVA: 0x000651F4 File Offset: 0x000633F4
		// (remove) Token: 0x06001777 RID: 6007 RVA: 0x0006521C File Offset: 0x0006341C
		public event EventHandler<ResourceDestroyedEventArgs> ResourceDestroyed
		{
			[CompilerGenerated]
			add
			{
				Delegate @delegate = Delegate.Combine(this.ResourceDestroyed, value);
				if (@delegate != null && @delegate == null)
				{
					return;
				}
			}
			[CompilerGenerated]
			remove
			{
				Delegate @delegate = Delegate.Remove(this.ResourceDestroyed, value);
				if (@delegate != null && @delegate == null)
				{
					return;
				}
			}
		}

		// Token: 0x14000017 RID: 23
		// (add) Token: 0x06001778 RID: 6008 RVA: 0x00065244 File Offset: 0x00063444
		// (remove) Token: 0x06001779 RID: 6009 RVA: 0x0006526C File Offset: 0x0006346C
		public event EventHandler<EventArgs> Disposing
		{
			[CompilerGenerated]
			add
			{
				Delegate @delegate = Delegate.Combine(this.Disposing, value);
				if (@delegate != null && @delegate == null)
				{
					return;
				}
			}
			[CompilerGenerated]
			remove
			{
				Delegate @delegate = Delegate.Remove(this.Disposing, value);
				if (@delegate != null && @delegate == null)
				{
					return;
				}
			}
		}

		// Token: 0x14000018 RID: 24
		// (add) Token: 0x0600177A RID: 6010 RVA: 0x00065294 File Offset: 0x00063494
		// (remove) Token: 0x0600177B RID: 6011 RVA: 0x000652BC File Offset: 0x000634BC
		internal event EventHandler<PresentationEventArgs> PresentationChanged
		{
			[CompilerGenerated]
			add
			{
				Delegate @delegate = Delegate.Combine(this.PresentationChanged, value);
				if (@delegate != null && @delegate == null)
				{
					return;
				}
			}
			[CompilerGenerated]
			remove
			{
				Delegate @delegate = Delegate.Remove(this.PresentationChanged, value);
				if (@delegate != null && @delegate == null)
				{
					return;
				}
			}
		}

		// Token: 0x170002E2 RID: 738
		// (get) Token: 0x0600177C RID: 6012 RVA: 0x000652E4 File Offset: 0x000634E4
		internal bool IsRenderTargetBound
		{
			get
			{
				/*
An exception occurred when decompiling this method (0600177C)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean Microsoft.Xna.Framework.Graphics.GraphicsDevice::get_IsRenderTargetBound()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:int32(var_0_06, ldfld:int32(GraphicsDevice::_currentRenderTargetCount, ldloc:GraphicsDevice(this)))
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

		// Token: 0x170002E3 RID: 739
		// (get) Token: 0x0600177D RID: 6013 RVA: 0x000652F8 File Offset: 0x000634F8
		internal DepthFormat ActiveDepthFormat
		{
			get
			{
				/*
An exception occurred when decompiling this method (0600177D)

ICSharpCode.Decompiler.DecompilerException: Error decompiling Microsoft.Xna.Framework.Graphics.DepthFormat Microsoft.Xna.Framework.Graphics.GraphicsDevice::get_ActiveDepthFormat()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:int32(var_0_06, ldfld:int32(GraphicsDevice::_currentRenderTargetCount, ldloc:GraphicsDevice(this)))
	stloc:valuetype Microsoft.Xna.Framework.Graphics.RenderTargetBinding[](var_1_0D, ldfld:valuetype Microsoft.Xna.Framework.Graphics.RenderTargetBinding[](GraphicsDevice::_currentRenderTargetBindings, ldloc:GraphicsDevice(this)))
	stloc:PresentationParameters(var_2_14, ldfld:PresentationParameters(GraphicsDevice::<PresentationParameters>k__BackingField, ldloc:GraphicsDevice(this)))
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

		// Token: 0x170002E4 RID: 740
		// (get) Token: 0x0600177E RID: 6014 RVA: 0x0006531C File Offset: 0x0006351C
		// (set) Token: 0x0600177F RID: 6015 RVA: 0x00065330 File Offset: 0x00063530
		public GraphicsAdapter Adapter
		{
			[CompilerGenerated]
			get
			{
				return this.<Adapter>k__BackingField;
			}
			[CompilerGenerated]
			private set
			{
				this.<Adapter>k__BackingField = value;
			}
		}

		// Token: 0x06001780 RID: 6016 RVA: 0x00065344 File Offset: 0x00063544
		internal GraphicsDevice()
		{
			if (!true)
			{
			}
			this._blendFactor = 1;
			base..ctor();
			if (!true)
			{
			}
			if (!true)
			{
			}
			GraphicsAdapter defaultAdapter = GraphicsAdapter.DefaultAdapter;
			this.Adapter = defaultAdapter;
			this.Setup();
			this.Initialize();
		}

		// Token: 0x06001781 RID: 6017 RVA: 0x00065380 File Offset: 0x00063580
		public GraphicsDevice(GraphicsAdapter adapter, GraphicsProfile graphicsProfile, PresentationParameters presentationParameters)
		{
			/*
An exception occurred when decompiling this method (06001781)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Void Microsoft.Xna.Framework.Graphics.GraphicsDevice::.ctor(Microsoft.Xna.Framework.Graphics.GraphicsAdapter,Microsoft.Xna.Framework.Graphics.GraphicsProfile,Microsoft.Xna.Framework.Graphics.PresentationParameters)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0013:
	stloc:string(var_0_19, ldfld:string(GraphicsAdapter::<Description>k__BackingField, ldloc:GraphicsAdapter(adapter)))
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

		// Token: 0x06001782 RID: 6018 RVA: 0x000021DB File Offset: 0x000003DB
		private void Setup()
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06001783 RID: 6019 RVA: 0x000653A8 File Offset: 0x000635A8
		protected override void Finalize()
		{
			base.Finalize();
		}

		// Token: 0x06001784 RID: 6020 RVA: 0x000653BC File Offset: 0x000635BC
		internal int GetClampedMultisampleCount(int multiSampleCount)
		{
			/*
An exception occurred when decompiling this method (06001784)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Int32 Microsoft.Xna.Framework.Graphics.GraphicsDevice::GetClampedMultisampleCount(System.Int32)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:int32(var_0_0B, ldfld:int32(GraphicsCapabilities::_maxMultiSampleCount, ldfld:GraphicsCapabilities(GraphicsDevice::<GraphicsCapabilities>k__BackingField, ldloc:GraphicsDevice(this))))
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

		// Token: 0x06001785 RID: 6021 RVA: 0x000653D8 File Offset: 0x000635D8
		internal void Initialize()
		{
			int num = 1;
			this._rasterizerStateDirty = num != 0;
			this._depthStencilStateDirty = num != 0;
			this._blendStateDirty = num != 0;
			if (num == 0)
			{
			}
			if (num == 0)
			{
			}
			if (num == 0)
			{
			}
			Texture2D[] textures = this.Textures;
			int num2 = 1;
			Texture2D[] textures2 = this.Textures;
			this._scissorRectangleDirty = num2 != 0;
			Rectangle rectangle;
			this.ScissorRectangle = rectangle;
		}

		// Token: 0x170002E5 RID: 741
		// (get) Token: 0x06001786 RID: 6022 RVA: 0x00065424 File Offset: 0x00063624
		// (set) Token: 0x06001787 RID: 6023 RVA: 0x00065438 File Offset: 0x00063638
		public RasterizerState RasterizerState
		{
			get
			{
				return this._rasterizerState;
			}
			set
			{
				if (value != null)
				{
					RasterizerState rasterizerState = this._rasterizerState;
					bool <SupportsDepthClamp>k__BackingField;
					if (!value._depthClipEnable)
					{
						<SupportsDepthClamp>k__BackingField = this.<GraphicsCapabilities>k__BackingField.<SupportsDepthClamp>k__BackingField;
						if (!<SupportsDepthClamp>k__BackingField)
						{
							return;
						}
					}
					this._rasterizerState = value;
					if (!<SupportsDepthClamp>k__BackingField)
					{
					}
					RasterizerState rasterizerState2 = this._rasterizerState;
					RasterizerState rasterizerState3 = this._rasterizerState;
					return;
				}
			}
		}

		// Token: 0x170002E6 RID: 742
		// (get) Token: 0x06001788 RID: 6024 RVA: 0x0006548C File Offset: 0x0006368C
		// (set) Token: 0x06001789 RID: 6025 RVA: 0x000654A4 File Offset: 0x000636A4
		public Color BlendFactor
		{
			get
			{
				Color blendFactor = this._blendFactor;
				Color color;
				return color;
			}
			set
			{
				Color blendFactor = this._blendFactor;
				if (!true)
				{
				}
				bool flag = blendFactor == value;
				this._blendFactor = value;
				this._blendFactorDirty = true;
			}
		}

		// Token: 0x170002E7 RID: 743
		// (get) Token: 0x0600178A RID: 6026 RVA: 0x000654D4 File Offset: 0x000636D4
		// (set) Token: 0x0600178B RID: 6027 RVA: 0x000654E8 File Offset: 0x000636E8
		public BlendState BlendState
		{
			get
			{
				return this._blendState;
			}
			set
			{
				while (value == null)
				{
				}
				BlendState blendState = this._blendState;
				this._blendState = value;
				if (blendState == null)
				{
				}
				BlendState blendState2 = this._blendState;
				BlendState blendState3 = this._blendState;
				GraphicsDevice graphicsDevice = blendState.graphicsDevice;
				BlendState blendState4 = this._blendState;
				if (graphicsDevice == null)
				{
				}
			}
		}

		// Token: 0x170002E8 RID: 744
		// (get) Token: 0x0600178C RID: 6028 RVA: 0x00065538 File Offset: 0x00063738
		// (set) Token: 0x0600178D RID: 6029 RVA: 0x0006554C File Offset: 0x0006374C
		public DepthStencilState DepthStencilState
		{
			get
			{
				return this._depthStencilState;
			}
			set
			{
				while (value == null)
				{
				}
				DepthStencilState depthStencilState = this._depthStencilState;
				this._depthStencilState = value;
				if (depthStencilState == null)
				{
				}
				DepthStencilState depthStencilState2 = this._depthStencilState;
				DepthStencilState depthStencilState3 = this._depthStencilState;
			}
		}

		// Token: 0x0600178E RID: 6030 RVA: 0x00065588 File Offset: 0x00063788
		internal void ApplyState(bool applyShaders)
		{
		}

		// Token: 0x0600178F RID: 6031 RVA: 0x00065598 File Offset: 0x00063798
		public void Clear(Color color)
		{
		}

		// Token: 0x06001790 RID: 6032 RVA: 0x000655A8 File Offset: 0x000637A8
		public void Clear(ClearOptions options, Color color, float depth, int stencil)
		{
		}

		// Token: 0x06001791 RID: 6033 RVA: 0x000655B8 File Offset: 0x000637B8
		public void Clear(ClearOptions options, Vector4 color, float depth, int stencil)
		{
		}

		// Token: 0x06001792 RID: 6034 RVA: 0x000655C8 File Offset: 0x000637C8
		public void Present()
		{
			while (this._currentRenderTargetCount != 0)
			{
			}
		}

		// Token: 0x06001793 RID: 6035 RVA: 0x000655E0 File Offset: 0x000637E0
		public void Reset()
		{
		}

		// Token: 0x06001794 RID: 6036 RVA: 0x000655F0 File Offset: 0x000637F0
		public void Reset(PresentationParameters presentationParameters)
		{
			while (presentationParameters == null)
			{
			}
			this.<PresentationParameters>k__BackingField = presentationParameters;
		}

		// Token: 0x170002E9 RID: 745
		// (get) Token: 0x06001795 RID: 6037 RVA: 0x00065608 File Offset: 0x00063808
		public DisplayMode DisplayMode
		{
			get
			{
				return this.<Adapter>k__BackingField._currentDisplayMode;
			}
		}

		// Token: 0x170002EA RID: 746
		// (get) Token: 0x06001796 RID: 6038 RVA: 0x00065620 File Offset: 0x00063820
		public GraphicsDeviceStatus GraphicsDeviceStatus
		{
			get
			{
			}
		}

		// Token: 0x170002EB RID: 747
		// (get) Token: 0x06001797 RID: 6039 RVA: 0x00065630 File Offset: 0x00063830
		// (set) Token: 0x06001798 RID: 6040 RVA: 0x00065644 File Offset: 0x00063844
		public PresentationParameters PresentationParameters
		{
			[CompilerGenerated]
			get
			{
				return this.<PresentationParameters>k__BackingField;
			}
			[CompilerGenerated]
			private set
			{
				this.<PresentationParameters>k__BackingField = value;
			}
		}

		// Token: 0x170002EC RID: 748
		// (get) Token: 0x06001799 RID: 6041 RVA: 0x00065658 File Offset: 0x00063858
		// (set) Token: 0x0600179A RID: 6042 RVA: 0x00065698 File Offset: 0x00063898
		public Viewport Viewport
		{
			get
			{
				DisplayMode currentDisplayMode = this.<Adapter>k__BackingField._currentDisplayMode;
				float minDepth = this._viewport.minDepth;
				int x = this._viewport.x;
				Viewport viewport;
				viewport.minDepth = minDepth;
				viewport.x = x;
				return viewport;
			}
			set
			{
				float minDepth = value.minDepth;
				this._viewport.minDepth = minDepth;
			}
		}

		// Token: 0x170002ED RID: 749
		// (get) Token: 0x0600179B RID: 6043 RVA: 0x000656B8 File Offset: 0x000638B8
		public GraphicsProfile GraphicsProfile
		{
			get
			{
				return this._graphicsProfile;
			}
		}

		// Token: 0x170002EE RID: 750
		// (get) Token: 0x0600179C RID: 6044 RVA: 0x000656CC File Offset: 0x000638CC
		// (set) Token: 0x0600179D RID: 6045 RVA: 0x000656F0 File Offset: 0x000638F0
		public Rectangle ScissorRectangle
		{
			get
			{
				Rectangle scissorRectangle = this._scissorRectangle;
				int width = this._scissorRectangle.Width;
				return scissorRectangle;
			}
			set
			{
				Rectangle scissorRectangle = this._scissorRectangle;
				int width = this._scissorRectangle.Width;
				if (!true)
				{
				}
				this._scissorRectangle = value;
				this._scissorRectangleDirty = true;
			}
		}

		// Token: 0x170002EF RID: 751
		// (get) Token: 0x0600179E RID: 6046 RVA: 0x00065724 File Offset: 0x00063924
		public int RenderTargetCount
		{
			get
			{
				return this._currentRenderTargetCount;
			}
		}

		// Token: 0x0600179F RID: 6047 RVA: 0x00065738 File Offset: 0x00063938
		public void SetRenderTarget(RenderTarget2D renderTarget)
		{
		}

		// Token: 0x060017A0 RID: 6048 RVA: 0x00065748 File Offset: 0x00063948
		public RenderTargetBinding[] GetRenderTargets()
		{
			/*
An exception occurred when decompiling this method (060017A0)

ICSharpCode.Decompiler.DecompilerException: Error decompiling Microsoft.Xna.Framework.Graphics.RenderTargetBinding[] Microsoft.Xna.Framework.Graphics.GraphicsDevice::GetRenderTargets()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:int32(var_0_06, ldfld:int32(GraphicsDevice::_currentRenderTargetCount, ldloc:GraphicsDevice(this)))
	stloc:valuetype Microsoft.Xna.Framework.Graphics.RenderTargetBinding[](var_1_0D, ldfld:valuetype Microsoft.Xna.Framework.Graphics.RenderTargetBinding[](GraphicsDevice::_currentRenderTargetBindings, ldloc:GraphicsDevice(this)))
	stloc:int32(var_2_14, ldfld:int32(GraphicsDevice::_currentRenderTargetCount, ldloc:GraphicsDevice(this)))
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

		// Token: 0x060017A1 RID: 6049 RVA: 0x0006576C File Offset: 0x0006396C
		public void GetRenderTargets(RenderTargetBinding[] outTargets)
		{
			RenderTargetBinding[] currentRenderTargetBindings = this._currentRenderTargetBindings;
			int currentRenderTargetCount = this._currentRenderTargetCount;
			Array.Copy(currentRenderTargetBindings, outTargets, currentRenderTargetCount);
		}

		// Token: 0x170002F0 RID: 752
		// (get) Token: 0x060017A2 RID: 6050 RVA: 0x00065790 File Offset: 0x00063990
		// (set) Token: 0x060017A3 RID: 6051 RVA: 0x000657A4 File Offset: 0x000639A4
		public bool ResourcesLost
		{
			[CompilerGenerated]
			get
			{
				return this.<ResourcesLost>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x060017A4 RID: 6052 RVA: 0x000021DB File Offset: 0x000003DB
		private T[] Clone<T>(T[] srcArray, int Count)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x060017A5 RID: 6053 RVA: 0x000657B4 File Offset: 0x000639B4
		public Material GetMaterial(int offset)
		{
			Texture2D[] textures = this.Textures;
			string <Name>k__BackingField = textures.<Name>k__BackingField;
			object <Tag>k__BackingField = textures.<Tag>k__BackingField;
			SurfaceFormat format = textures._format;
			int sortingKey = textures._sortingKey;
			if (textures == null)
			{
			}
			if (textures != null)
			{
				Texture2D[] textures2 = this.Textures;
				object <Tag>k__BackingField2 = textures2.<Tag>k__BackingField;
				if (textures2 == null)
				{
				}
				GraphicsDevice graphicsDevice = textures2.graphicsDevice;
				if (<Tag>k__BackingField2 != null)
				{
				}
			}
			Material material;
			return material;
		}

		// Token: 0x060017A6 RID: 6054 RVA: 0x00065810 File Offset: 0x00063A10
		public void DrawGeometry(SpriteBatcher.VertexData[] vertices, short[] indices, int vertexCount, int indexCount, Vector3 position, Vector3 scale)
		{
			if (!true)
			{
			}
			GeometryBufferInstance instance = GeometryBufferInstance.GetInstance(vertices, indices, vertexCount, indexCount);
			int offset = instance._offset;
			MeshRenderer meshRenderer = instance._meshRenderer;
			Material material = this.GetMaterial(offset);
			meshRenderer.material = material;
		}

		// Token: 0x060017A7 RID: 6055 RVA: 0x00065848 File Offset: 0x00063A48
		private Material[] GetMaterialArray(List<Material> subMeshMaterials)
		{
			int size = subMeshMaterials._size;
			List<Material[]> materialArrays = this.MaterialArrays;
			int size2 = subMeshMaterials._size;
			if (subMeshMaterials == null || subMeshMaterials != null)
			{
			}
			throw new ArrayTypeMismatchException();
		}

		// Token: 0x060017A8 RID: 6056 RVA: 0x00065878 File Offset: 0x00063A78
		public void DrawGeometryWithSubMeshes(SpriteBatcher.VertexData[] vertices, short[] indices, int vertexCount, int indexCount, Vector3 position, Vector3 scale, List<Material> subMeshMaterials, List<SubMeshDescriptor> subMeshPartitions)
		{
			int num = 1;
			if (num == 0)
			{
			}
			GeometryBufferInstance batchInstance = GeometryBufferInstance.GetBatchInstance();
			int offset = batchInstance._offset;
			if (false)
			{
				if (num == 0)
				{
				}
				GeometryBufferInstance.IncrementBufferOffset();
			}
			Material[] array;
			batchInstance._meshRenderer.materials = array;
			Mesh mesh = batchInstance.Mesh;
			int num2 = 1;
			mesh.Clear(num2 != 0);
			mesh.subMeshCount = num2;
			if (num == 0)
			{
			}
			long num3 = 0L;
			mesh.UploadMeshData(num3 != 0L);
		}

		// Token: 0x060017A9 RID: 6057 RVA: 0x000658E0 File Offset: 0x00063AE0
		public void DrawGeometry(List<Vector3> positions, List<Vector2> uvs, List<Vector4> uv2s, List<Color32> colours, List<int> indices, Vector3 position, Vector3 scale)
		{
			if (!true)
			{
			}
			GeometryBufferInstance instance = GeometryBufferInstance.GetInstance(positions, uvs, uv2s, colours, indices);
			int offset = instance._offset;
			MeshRenderer meshRenderer = instance._meshRenderer;
			Material material = this.GetMaterial(offset);
			meshRenderer.material = material;
		}

		// Token: 0x060017AA RID: 6058 RVA: 0x0006591C File Offset: 0x00063B1C
		internal static Rectangle GetDefaultTitleSafeArea(int x, int y, int width, int height)
		{
		}

		// Token: 0x060017AB RID: 6059 RVA: 0x00065930 File Offset: 0x00063B30
		internal static Rectangle GetTitleSafeArea(int x, int y, int width, int height)
		{
			if (!true)
			{
			}
			return GraphicsDevice.GetDefaultTitleSafeArea(42175128, x, y, width);
		}

		// Token: 0x060017AC RID: 6060 RVA: 0x00065950 File Offset: 0x00063B50
		// Note: this type is marked as 'beforefieldinit'.
		static GraphicsDevice()
		{
		}

		// Token: 0x040025E3 RID: 9699
		public static GraphicsDevice Instance;

		// Token: 0x040025E4 RID: 9700
		private Viewport _viewport;

		// Token: 0x040025E5 RID: 9701
		private Color _blendFactor;

		// Token: 0x040025E6 RID: 9702
		private bool _blendFactorDirty;

		// Token: 0x040025E7 RID: 9703
		private BlendState _blendState;

		// Token: 0x040025E8 RID: 9704
		private BlendState _actualBlendState;

		// Token: 0x040025E9 RID: 9705
		private bool _blendStateDirty;

		// Token: 0x040025EA RID: 9706
		private BlendState _blendStateAdditive;

		// Token: 0x040025EB RID: 9707
		private BlendState _blendStateAlphaBlend;

		// Token: 0x040025EC RID: 9708
		private BlendState _blendStateNonPremultiplied;

		// Token: 0x040025ED RID: 9709
		private BlendState _blendStateOpaque;

		// Token: 0x040025EE RID: 9710
		private DepthStencilState _depthStencilState;

		// Token: 0x040025EF RID: 9711
		private DepthStencilState _actualDepthStencilState;

		// Token: 0x040025F0 RID: 9712
		private bool _depthStencilStateDirty;

		// Token: 0x040025F1 RID: 9713
		private DepthStencilState _depthStencilStateDefault;

		// Token: 0x040025F2 RID: 9714
		private DepthStencilState _depthStencilStateDepthRead;

		// Token: 0x040025F3 RID: 9715
		private DepthStencilState _depthStencilStateNone;

		// Token: 0x040025F4 RID: 9716
		private RasterizerState _rasterizerState;

		// Token: 0x040025F5 RID: 9717
		private RasterizerState _actualRasterizerState;

		// Token: 0x040025F6 RID: 9718
		private bool _rasterizerStateDirty;

		// Token: 0x040025F7 RID: 9719
		private RasterizerState _rasterizerStateCullClockwise;

		// Token: 0x040025F8 RID: 9720
		private RasterizerState _rasterizerStateCullCounterClockwise;

		// Token: 0x040025F9 RID: 9721
		private RasterizerState _rasterizerStateCullNone;

		// Token: 0x040025FA RID: 9722
		private Rectangle _scissorRectangle;

		// Token: 0x040025FB RID: 9723
		private bool _scissorRectangleDirty;

		// Token: 0x040025FC RID: 9724
		private readonly RenderTargetBinding[] _currentRenderTargetBindings;

		// Token: 0x040025FD RID: 9725
		private int _currentRenderTargetCount;

		// Token: 0x040025FE RID: 9726
		private readonly RenderTargetBinding[] _tempRenderTargetBinding;

		// Token: 0x040025FF RID: 9727
		[CompilerGenerated]
		private GraphicsCapabilities <GraphicsCapabilities>k__BackingField;

		// Token: 0x04002600 RID: 9728
		private static readonly Color DiscardColor;

		// Token: 0x04002601 RID: 9729
		internal Dictionary<int, Effect> EffectCache;

		// Token: 0x04002602 RID: 9730
		[CompilerGenerated]
		private EventHandler<EventArgs> DeviceLost;

		// Token: 0x04002603 RID: 9731
		[CompilerGenerated]
		private EventHandler<EventArgs> DeviceReset;

		// Token: 0x04002604 RID: 9732
		[CompilerGenerated]
		private EventHandler<EventArgs> DeviceResetting;

		// Token: 0x04002605 RID: 9733
		[CompilerGenerated]
		private EventHandler<ResourceCreatedEventArgs> ResourceCreated;

		// Token: 0x04002606 RID: 9734
		[CompilerGenerated]
		private EventHandler<ResourceDestroyedEventArgs> ResourceDestroyed;

		// Token: 0x04002607 RID: 9735
		[CompilerGenerated]
		private EventHandler<EventArgs> Disposing;

		// Token: 0x04002608 RID: 9736
		[CompilerGenerated]
		private EventHandler<PresentationEventArgs> PresentationChanged;

		// Token: 0x04002609 RID: 9737
		private int _maxVertexBufferSlots;

		// Token: 0x0400260A RID: 9738
		internal int MaxTextureSlots;

		// Token: 0x0400260B RID: 9739
		internal int MaxVertexTextureSlots;

		// Token: 0x0400260C RID: 9740
		public Texture2D[] Textures;

		// Token: 0x0400260D RID: 9741
		[CompilerGenerated]
		private GraphicsAdapter <Adapter>k__BackingField;

		// Token: 0x0400260E RID: 9742
		[CompilerGenerated]
		private PresentationParameters <PresentationParameters>k__BackingField;

		// Token: 0x0400260F RID: 9743
		private readonly GraphicsProfile _graphicsProfile;

		// Token: 0x04002610 RID: 9744
		[CompilerGenerated]
		private bool <ResourcesLost>k__BackingField;

		// Token: 0x04002611 RID: 9745
		public bool CachedImmediateDrawMaterialActive;

		// Token: 0x04002612 RID: 9746
		private EffectPass _cachedImmediateDrawEffect;

		// Token: 0x04002613 RID: 9747
		private int _cachedImmediateDrawEffectState;

		// Token: 0x04002614 RID: 9748
		private Material _cachedImmediateDrawMaterial;

		// Token: 0x04002615 RID: 9749
		private Texture2D _cachedImmediateTexture0;

		// Token: 0x04002616 RID: 9750
		private Texture2D _cachedImmediateTexture1;

		// Token: 0x04002617 RID: 9751
		private List<Material[]> MaterialArrays;
	}
}
