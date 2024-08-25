using System;
using System.Runtime.CompilerServices;
using System.Security.Util;

namespace System
{
	// Token: 0x0200015C RID: 348
	internal sealed class SharedStatics
	{
		// Token: 0x06000E24 RID: 3620 RVA: 0x0001EB70 File Offset: 0x0001CD70
		private SharedStatics()
		{
		}

		// Token: 0x06000E25 RID: 3621 RVA: 0x0001EB80 File Offset: 0x0001CD80
		public static Tokenizer.StringMaker GetSharedStringMaker()
		{
			RuntimeHelpers.PrepareConstrainedRegions();
			if (!true)
			{
			}
			if (false || 3 == 0)
			{
			}
			throw new OutOfMemoryException();
		}

		// Token: 0x06000E26 RID: 3622 RVA: 0x0001EBB0 File Offset: 0x0001CDB0
		public static void ReleaseSharedStringMaker(Tokenizer.StringMaker maker)
		{
			RuntimeHelpers.PrepareConstrainedRegions();
			if (!true)
			{
			}
			if (!false)
			{
				return;
			}
			throw new OutOfMemoryException();
		}

		// Token: 0x06000E27 RID: 3623 RVA: 0x0001EBE4 File Offset: 0x0001CDE4
		// Note: this type is marked as 'beforefieldinit'.
		static SharedStatics()
		{
		}

		// Token: 0x04000568 RID: 1384
		private static readonly SharedStatics _sharedStatics;

		// Token: 0x04000569 RID: 1385
		private Tokenizer.StringMaker _maker;
	}
}
