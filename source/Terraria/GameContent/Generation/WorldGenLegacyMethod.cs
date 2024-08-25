using System;
using Cpp2IlInjected;
using Terraria.IO;
using Terraria.WorldBuilding;

namespace Terraria.GameContent.Generation
{
	// Token: 0x020008D5 RID: 2261
	public sealed class WorldGenLegacyMethod : MulticastDelegate
	{
		// Token: 0x0600459B RID: 17819 RVA: 0x002550D4 File Offset: 0x002532D4
		public WorldGenLegacyMethod(object @object, IntPtr method)
		{
			this.method_ptr = method;
			this.m_target = @object;
			this.method = method;
			this.method_code = this;
		}

		// Token: 0x0600459C RID: 17820 RVA: 0x00255134 File Offset: 0x00253334
		public void Invoke(GenerationProgress progress, GameConfiguration configuration)
		{
			IntPtr method_code = this.method_code;
			IntPtr invoke_impl = this.invoke_impl;
			IntPtr method = this.method;
		}

		// Token: 0x0600459D RID: 17821 RVA: 0x000021DB File Offset: 0x000003DB
		public IAsyncResult BeginInvoke(GenerationProgress progress, GameConfiguration configuration, AsyncCallback callback, object @object)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x0600459E RID: 17822 RVA: 0x00255158 File Offset: 0x00253358
		public void EndInvoke(IAsyncResult result)
		{
		}
	}
}
