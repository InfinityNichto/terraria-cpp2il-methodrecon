using System;
using Cpp2IlInjected;
using Microsoft.Xna.Framework.Graphics;

namespace Terraria.Graphics.Capture
{
	// Token: 0x0200076D RID: 1901
	public class CaptureManager : IDisposable
	{
		// Token: 0x1700078F RID: 1935
		// (get) Token: 0x06003E58 RID: 15960 RVA: 0x0023D090 File Offset: 0x0023B290
		public bool IsCapturing
		{
			get
			{
			}
		}

		// Token: 0x06003E59 RID: 15961 RVA: 0x0023D0A0 File Offset: 0x0023B2A0
		public CaptureManager()
		{
		}

		// Token: 0x17000790 RID: 1936
		// (get) Token: 0x06003E5A RID: 15962 RVA: 0x0023D0B4 File Offset: 0x0023B2B4
		// (set) Token: 0x06003E5B RID: 15963 RVA: 0x0023D0CC File Offset: 0x0023B2CC
		public bool Active
		{
			get
			{
				return this._interface.Active;
			}
			set
			{
				if (!true)
				{
				}
				if (!true)
				{
					CaptureInterface @interface = this._interface;
					bool active = @interface.Active;
				}
			}
		}

		// Token: 0x17000791 RID: 1937
		// (get) Token: 0x06003E5C RID: 15964 RVA: 0x0023D0F8 File Offset: 0x0023B2F8
		public bool UsingMap
		{
			get
			{
				CaptureInterface @interface = this._interface;
				if (@interface.Active)
				{
					return @interface.UsingMap();
				}
			}
		}

		// Token: 0x06003E5D RID: 15965 RVA: 0x0023D11C File Offset: 0x0023B31C
		public void Scrolling()
		{
			this._interface.Scrolling();
		}

		// Token: 0x06003E5E RID: 15966 RVA: 0x0023D134 File Offset: 0x0023B334
		public void Update()
		{
			this._interface.Update();
		}

		// Token: 0x06003E5F RID: 15967 RVA: 0x0023D14C File Offset: 0x0023B34C
		public void Draw(SpriteBatch sb)
		{
			this._interface.Draw(sb);
		}

		// Token: 0x06003E60 RID: 15968 RVA: 0x000021DB File Offset: 0x000003DB
		public float GetProgress()
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06003E61 RID: 15969 RVA: 0x0023D168 File Offset: 0x0023B368
		public void Capture()
		{
		}

		// Token: 0x06003E62 RID: 15970 RVA: 0x0023D178 File Offset: 0x0023B378
		public void Capture(CaptureSettings settings)
		{
		}

		// Token: 0x06003E63 RID: 15971 RVA: 0x0023D188 File Offset: 0x0023B388
		public void DrawTick()
		{
		}

		// Token: 0x06003E64 RID: 15972 RVA: 0x0023D198 File Offset: 0x0023B398
		public void Dispose()
		{
		}

		// Token: 0x06003E65 RID: 15973 RVA: 0x0023D1A8 File Offset: 0x0023B3A8
		// Note: this type is marked as 'beforefieldinit'.
		static CaptureManager()
		{
		}

		// Token: 0x04007D17 RID: 32023
		public static CaptureManager Instance;

		// Token: 0x04007D18 RID: 32024
		private CaptureInterface _interface;
	}
}
