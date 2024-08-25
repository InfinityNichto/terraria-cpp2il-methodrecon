using System;
using System.Runtime.InteropServices;
using Cpp2IlInjected;

namespace Microsoft.Xna.Framework.Graphics
{
	// Token: 0x0200037C RID: 892
	internal static class GraphicsExtensions
	{
		// Token: 0x060017AD RID: 6061 RVA: 0x000021DB File Offset: 0x000003DB
		public static int GetSyncInterval(this PresentInterval interval)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x060017AE RID: 6062 RVA: 0x00065964 File Offset: 0x00063B64
		public static bool IsCompressedFormat(this SurfaceFormat format)
		{
		}

		// Token: 0x060017AF RID: 6063 RVA: 0x00065978 File Offset: 0x00063B78
		public static int GetSize(this SurfaceFormat surfaceFormat)
		{
			return 1;
		}

		// Token: 0x060017B0 RID: 6064 RVA: 0x00065990 File Offset: 0x00063B90
		public static void GetBlockSize(this SurfaceFormat surfaceFormat, [Out] int width, [Out] int height)
		{
		}
	}
}
