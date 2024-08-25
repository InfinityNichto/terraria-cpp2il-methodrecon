using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using Microsoft.Xna.Framework;

namespace Terraria.Cinematics
{
	// Token: 0x0200078D RID: 1933
	public class CinematicManager
	{
		// Token: 0x06003F2A RID: 16170 RVA: 0x0023FD6C File Offset: 0x0023DF6C
		public void Update(GameTime gameTime)
		{
			List<Film> films = this._films;
			int size = films._size;
			if (films._version == 0)
			{
				List<Film> films2 = this._films;
			}
			List<Film> films3 = this._films;
		}

		// Token: 0x06003F2B RID: 16171 RVA: 0x000021DB File Offset: 0x000003DB
		public void PlayFilm(Film film)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06003F2C RID: 16172 RVA: 0x0023FDB0 File Offset: 0x0023DFB0
		public void StopAll()
		{
		}

		// Token: 0x06003F2D RID: 16173 RVA: 0x0023FDC0 File Offset: 0x0023DFC0
		public CinematicManager()
		{
		}

		// Token: 0x06003F2E RID: 16174 RVA: 0x0023FDD4 File Offset: 0x0023DFD4
		// Note: this type is marked as 'beforefieldinit'.
		static CinematicManager()
		{
		}

		// Token: 0x04007DA2 RID: 32162
		public static CinematicManager Instance;

		// Token: 0x04007DA3 RID: 32163
		private List<Film> _films;
	}
}
