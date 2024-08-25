using System;
using Terraria.Graphics.Shaders;

namespace Terraria.GameContent.Shaders
{
	// Token: 0x02000822 RID: 2082
	public class MoonLordScreenShaderData : ScreenShaderData
	{
		// Token: 0x060042B7 RID: 17079 RVA: 0x0024C1AC File Offset: 0x0024A3AC
		public MoonLordScreenShaderData(string passName, bool aimAtPlayer)
			: base(passName)
		{
		}

		// Token: 0x060042B8 RID: 17080 RVA: 0x0024C1C0 File Offset: 0x0024A3C0
		private void UpdateMoonLordIndex()
		{
			if (!this._aimAtPlayer)
			{
				int moonLordIndex = this._moonLordIndex;
				int moonLordIndex2 = this._moonLordIndex;
				if (moonLordIndex2 == 0)
				{
				}
				if (moonLordIndex2 == 0)
				{
				}
				if (moonLordIndex2 == 0 || moonLordIndex2 == 0)
				{
				}
				return;
			}
		}

		// Token: 0x060042B9 RID: 17081 RVA: 0x0024C1F4 File Offset: 0x0024A3F4
		public override void Apply()
		{
			this.UpdateMoonLordIndex();
			bool aimAtPlayer = this._aimAtPlayer;
			if (aimAtPlayer)
			{
				if (!aimAtPlayer)
				{
				}
				Player localPlayer = Main.LocalPlayer;
				return;
			}
			int moonLordIndex = this._moonLordIndex;
			int moonLordIndex2 = this._moonLordIndex;
			base.Apply();
		}

		// Token: 0x040080F4 RID: 33012
		private int _moonLordIndex;

		// Token: 0x040080F5 RID: 33013
		private bool _aimAtPlayer;
	}
}
