using System;
using Cpp2IlInjected;

namespace Microsoft.Xna.Framework.Graphics
{
	// Token: 0x02000387 RID: 903
	public struct RenderTargetBinding
	{
		// Token: 0x17000307 RID: 775
		// (get) Token: 0x060017F9 RID: 6137 RVA: 0x000021DB File Offset: 0x000003DB
		public Texture RenderTarget
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		// Token: 0x17000308 RID: 776
		// (get) Token: 0x060017FA RID: 6138 RVA: 0x00065F60 File Offset: 0x00064160
		public int ArraySlice
		{
			get
			{
				return this._arraySlice;
			}
		}

		// Token: 0x17000309 RID: 777
		// (get) Token: 0x060017FB RID: 6139 RVA: 0x00065F74 File Offset: 0x00064174
		internal DepthFormat DepthFormat
		{
			get
			{
				return this._depthFormat;
			}
		}

		// Token: 0x060017FC RID: 6140 RVA: 0x00065F88 File Offset: 0x00064188
		public RenderTargetBinding(RenderTarget2D renderTarget)
		{
			while (renderTarget == null)
			{
			}
			this._renderTarget = renderTarget;
			DepthFormat <DepthStencilFormat>k__BackingField = renderTarget.<DepthStencilFormat>k__BackingField;
			this._depthFormat = <DepthStencilFormat>k__BackingField;
		}

		// Token: 0x060017FD RID: 6141 RVA: 0x000021DB File Offset: 0x000003DB
		public static implicit operator RenderTargetBinding(RenderTarget2D renderTarget)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x04002639 RID: 9785
		private readonly Texture _renderTarget;

		// Token: 0x0400263A RID: 9786
		private readonly int _arraySlice;

		// Token: 0x0400263B RID: 9787
		private DepthFormat _depthFormat;
	}
}
