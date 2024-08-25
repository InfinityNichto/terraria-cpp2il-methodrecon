using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using UnityEngine.Experimental.Rendering;
using UnityEngine.Rendering;

namespace UnityEngine
{
	// Token: 0x02000059 RID: 89
	public struct RenderTextureDescriptor
	{
		// Token: 0x17000046 RID: 70
		// (get) Token: 0x06000182 RID: 386 RVA: 0x000021B3 File Offset: 0x000003B3
		public readonly int width
		{
			[CompilerGenerated]
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		// Token: 0x17000047 RID: 71
		// (get) Token: 0x06000183 RID: 387 RVA: 0x00004314 File Offset: 0x00002514
		public readonly int height
		{
			[CompilerGenerated]
			get
			{
				return this.<height>k__BackingField;
			}
		}

		// Token: 0x17000048 RID: 72
		// (get) Token: 0x06000184 RID: 388 RVA: 0x00004328 File Offset: 0x00002528
		public readonly int msaaSamples
		{
			[CompilerGenerated]
			get
			{
				return this.<msaaSamples>k__BackingField;
			}
		}

		// Token: 0x17000049 RID: 73
		// (get) Token: 0x06000185 RID: 389 RVA: 0x0000433C File Offset: 0x0000253C
		public readonly int volumeDepth
		{
			[CompilerGenerated]
			get
			{
				return this.<volumeDepth>k__BackingField;
			}
		}

		// Token: 0x1700004A RID: 74
		// (get) Token: 0x06000186 RID: 390 RVA: 0x00004350 File Offset: 0x00002550
		public GraphicsFormat graphicsFormat
		{
			get
			{
				return this._graphicsFormat;
			}
		}

		// Token: 0x1700004B RID: 75
		// (get) Token: 0x06000187 RID: 391 RVA: 0x00004364 File Offset: 0x00002564
		public readonly GraphicsFormat depthStencilFormat
		{
			[CompilerGenerated]
			get
			{
				return this.<depthStencilFormat>k__BackingField;
			}
		}

		// Token: 0x1700004C RID: 76
		// (get) Token: 0x06000188 RID: 392 RVA: 0x00004378 File Offset: 0x00002578
		public readonly TextureDimension dimension
		{
			[CompilerGenerated]
			get
			{
				return this.<dimension>k__BackingField;
			}
		}

		// Token: 0x0400021F RID: 543
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private int <width>k__BackingField;

		// Token: 0x04000220 RID: 544
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		private int <height>k__BackingField;

		// Token: 0x04000221 RID: 545
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		private int <msaaSamples>k__BackingField;

		// Token: 0x04000222 RID: 546
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private int <volumeDepth>k__BackingField;

		// Token: 0x04000223 RID: 547
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		private int <mipCount>k__BackingField;

		// Token: 0x04000224 RID: 548
		private GraphicsFormat _graphicsFormat;

		// Token: 0x04000225 RID: 549
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private GraphicsFormat <stencilFormat>k__BackingField;

		// Token: 0x04000226 RID: 550
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		private GraphicsFormat <depthStencilFormat>k__BackingField;

		// Token: 0x04000227 RID: 551
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		private TextureDimension <dimension>k__BackingField;

		// Token: 0x04000228 RID: 552
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		private ShadowSamplingMode <shadowSamplingMode>k__BackingField;

		// Token: 0x04000229 RID: 553
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		private VRTextureUsage <vrUsage>k__BackingField;

		// Token: 0x0400022A RID: 554
		private RenderTextureCreationFlags _flags;

		// Token: 0x0400022B RID: 555
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private RenderTextureMemoryless <memoryless>k__BackingField;
	}
}
