using System;
using Terraria.GameInput;

namespace Terraria.UI
{
	// Token: 0x020006DF RID: 1759
	public class GameInterfaceLayer
	{
		// Token: 0x06003B11 RID: 15121 RVA: 0x00234174 File Offset: 0x00232374
		public GameInterfaceLayer(string name, InterfaceScaleType scaleType)
		{
			this.Name = name;
			this.ScaleType = scaleType;
		}

		// Token: 0x06003B12 RID: 15122 RVA: 0x00234198 File Offset: 0x00232398
		public bool Draw()
		{
			int num;
			if (this.ScaleType != InterfaceScaleType.Game)
			{
				PlayerInput.SetZoom_UI();
				num = 1;
				if (num == 0)
				{
				}
			}
			if (num == 0)
			{
			}
			PlayerInput.SetZoom_World();
			if (num == 0)
			{
			}
			PlayerInput.SetZoom_Unscaled();
			if (num == 0)
			{
			}
			int num2 = 1;
			if (num2 == 0)
			{
			}
			int value = num2.m_value;
			if (num2 == 0)
			{
				return;
			}
		}

		// Token: 0x06003B13 RID: 15123 RVA: 0x002341EC File Offset: 0x002323EC
		protected virtual bool DrawSelf()
		{
			return true;
		}

		// Token: 0x04007AF1 RID: 31473
		public readonly string Name;

		// Token: 0x04007AF2 RID: 31474
		public InterfaceScaleType ScaleType;
	}
}
