using System;
using Cpp2IlInjected;
using UnityEngine.Scripting;

namespace UnityEngine
{
	// Token: 0x02000055 RID: 85
	[RequiredByNativeCode]
	public struct Resolution
	{
		// Token: 0x17000041 RID: 65
		// (get) Token: 0x06000177 RID: 375 RVA: 0x000021B3 File Offset: 0x000003B3
		// (set) Token: 0x06000178 RID: 376 RVA: 0x00004244 File Offset: 0x00002444
		public int width
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
			set
			{
				this.m_Width = value;
			}
		}

		// Token: 0x17000042 RID: 66
		// (get) Token: 0x06000179 RID: 377 RVA: 0x00004258 File Offset: 0x00002458
		// (set) Token: 0x0600017A RID: 378 RVA: 0x0000426C File Offset: 0x0000246C
		public int height
		{
			get
			{
				return this.m_Height;
			}
			set
			{
				this.m_Height = value;
			}
		}

		// Token: 0x17000043 RID: 67
		// (get) Token: 0x0600017B RID: 379 RVA: 0x00004280 File Offset: 0x00002480
		// (set) Token: 0x0600017C RID: 380 RVA: 0x00004294 File Offset: 0x00002494
		public int refreshRate
		{
			get
			{
				return this.m_RefreshRate;
			}
			set
			{
				this.m_RefreshRate = value;
			}
		}

		// Token: 0x0600017D RID: 381 RVA: 0x000042A8 File Offset: 0x000024A8
		public override string ToString()
		{
			int height = this.m_Height;
			int refreshRate = this.m_RefreshRate;
			string text;
			return text;
		}

		// Token: 0x0400021A RID: 538
		private int m_Width;

		// Token: 0x0400021B RID: 539
		private int m_Height;

		// Token: 0x0400021C RID: 540
		private int m_RefreshRate;
	}
}
