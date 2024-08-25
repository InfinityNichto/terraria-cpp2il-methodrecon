using System;
using Cpp2IlInjected;

namespace Microsoft.Xna.Framework
{
	// Token: 0x02000338 RID: 824
	internal class UnityGameWindow : GameWindow
	{
		// Token: 0x17000211 RID: 529
		// (get) Token: 0x060014BF RID: 5311 RVA: 0x0005F458 File Offset: 0x0005D658
		// (set) Token: 0x060014C0 RID: 5312 RVA: 0x0005F468 File Offset: 0x0005D668
		public override bool AllowUserResizing
		{
			get
			{
			}
			set
			{
			}
		}

		// Token: 0x060014C1 RID: 5313 RVA: 0x0005F478 File Offset: 0x0005D678
		public override void BeginScreenDeviceChange(bool willBeFullScreen)
		{
		}

		// Token: 0x17000212 RID: 530
		// (get) Token: 0x060014C2 RID: 5314 RVA: 0x000021DB File Offset: 0x000003DB
		public override Rectangle ClientBounds
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		// Token: 0x060014C3 RID: 5315 RVA: 0x000021DB File Offset: 0x000003DB
		public override void EndScreenDeviceChange(string screenDeviceName, int clientWidth, int clientHeight)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x17000213 RID: 531
		// (get) Token: 0x060014C4 RID: 5316 RVA: 0x000021DB File Offset: 0x000003DB
		public override IntPtr Handle
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		// Token: 0x17000214 RID: 532
		// (get) Token: 0x060014C5 RID: 5317 RVA: 0x000021DB File Offset: 0x000003DB
		public override string ScreenDeviceName
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		// Token: 0x060014C6 RID: 5318 RVA: 0x0005F488 File Offset: 0x0005D688
		protected override void SetTitle(string title)
		{
		}

		// Token: 0x060014C7 RID: 5319 RVA: 0x0005F498 File Offset: 0x0005D698
		public UnityGameWindow()
		{
		}
	}
}
