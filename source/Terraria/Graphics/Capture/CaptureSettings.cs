using System;
using Microsoft.Xna.Framework;

namespace Terraria.Graphics.Capture
{
	// Token: 0x0200076E RID: 1902
	public class CaptureSettings
	{
		// Token: 0x06003E66 RID: 15974 RVA: 0x0023D1B8 File Offset: 0x0023B3B8
		public CaptureSettings()
		{
			if (!true)
			{
			}
			this.Biome = 1;
			base..ctor();
			if (!true)
			{
			}
			DateTime dateTime = DateTime.Now.ToLocalTime();
			if ("Capture " == null || "Capture " != null)
			{
				int num;
				string text = num.ToString("D4");
				if ((text == null || text != null) && ("-" == null || "-" != null))
				{
					int num2;
					string text2 = num2.ToString("D2");
					if ((text2 == null || text2 != null) && ("-" == null || "-" != null))
					{
						int num3;
						string text3 = num3.ToString("D2");
						if ((text3 == null || text3 != null) && (" " == null || " " != null))
						{
							int num4;
							string text4 = num4.ToString("D2");
							if ((text4 == null || text4 != null) && ("_" == null || "_" != null))
							{
								int num5;
								string text5 = num5.ToString("D2");
								if ((text5 == null || text5 != null) && ("_" == null || "_" != null))
								{
									int num6;
									string text6 = num6.ToString("D2");
									if (text6 == null || text6 != null)
									{
										string text7;
										this.OutputName = text7;
										return;
									}
								}
							}
						}
					}
				}
			}
			throw new ArrayTypeMismatchException();
		}

		// Token: 0x04007D19 RID: 32025
		public Rectangle Area;

		// Token: 0x04007D1A RID: 32026
		public bool UseScaling = true;

		// Token: 0x04007D1B RID: 32027
		public string OutputName;

		// Token: 0x04007D1C RID: 32028
		public bool CaptureEntities = true;

		// Token: 0x04007D1D RID: 32029
		public CaptureBiome Biome;

		// Token: 0x04007D1E RID: 32030
		public bool CaptureMech;

		// Token: 0x04007D1F RID: 32031
		public bool CaptureBackground;
	}
}
