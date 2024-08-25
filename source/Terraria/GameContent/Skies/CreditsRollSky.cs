using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria.GameContent.Animations;
using Terraria.GameContent.Skies.CreditsRoll;
using Terraria.Graphics.Effects;

namespace Terraria.GameContent.Skies
{
	// Token: 0x020009CD RID: 2509
	public class CreditsRollSky : CustomSky
	{
		// Token: 0x17000850 RID: 2128
		// (get) Token: 0x060049F8 RID: 18936 RVA: 0x002648E8 File Offset: 0x00262AE8
		public int AmountOfTimeNeededForFullPlay
		{
			get
			{
				return this._endTime;
			}
		}

		// Token: 0x060049F9 RID: 18937 RVA: 0x002648FC File Offset: 0x00262AFC
		public CreditsRollSky()
		{
			this.EnsureSegmentsAreMade();
		}

		// Token: 0x060049FA RID: 18938 RVA: 0x00264918 File Offset: 0x00262B18
		public override void Update(GameTime gameTime)
		{
			if (!true)
			{
			}
		}

		// Token: 0x060049FB RID: 18939 RVA: 0x00264988 File Offset: 0x00262B88
		public override void Draw(SpriteBatch spriteBatch, float minDepth, float maxDepth)
		{
			if (!true)
			{
			}
			Vector2 vector = Main.ScreenSize.ToVector2();
			bool gameMenu = Main.gameMenu;
			int currentTime = this._currentTime;
			float opacity = this._opacity;
			int num = 17302;
			List<IAnimationSegment> segmentsInGame = this._segmentsInGame;
			if (num == 0)
			{
			}
			bool gameMenu2 = Main.gameMenu;
			List<IAnimationSegment> segmentsInMainMenu = this._segmentsInMainMenu;
			int size = segmentsInMainMenu._size;
			if (currentTime != 0)
			{
			}
		}

		// Token: 0x060049FC RID: 18940 RVA: 0x00264A00 File Offset: 0x00262C00
		public override bool IsActive()
		{
			return this._isActive;
		}

		// Token: 0x060049FD RID: 18941 RVA: 0x00264A14 File Offset: 0x00262C14
		public override void Reset()
		{
			this.EnsureSegmentsAreMade();
		}

		// Token: 0x060049FE RID: 18942 RVA: 0x00264A28 File Offset: 0x00262C28
		public override void Activate(Vector2 position, params object[] args)
		{
			float opacity = this._opacity;
			this._isActive = 257 != 0;
			this.EnsureSegmentsAreMade();
		}

		// Token: 0x060049FF RID: 18943 RVA: 0x000021DB File Offset: 0x000003DB
		private void EnsureSegmentsAreMade()
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06004A00 RID: 18944 RVA: 0x00264A50 File Offset: 0x00262C50
		public override void Deactivate(params object[] args)
		{
		}

		// Token: 0x0400849B RID: 33947
		private int _endTime;

		// Token: 0x0400849C RID: 33948
		private int _currentTime;

		// Token: 0x0400849D RID: 33949
		private CreditsRollComposer _composer;

		// Token: 0x0400849E RID: 33950
		private List<IAnimationSegment> _segmentsInGame;

		// Token: 0x0400849F RID: 33951
		private List<IAnimationSegment> _segmentsInMainMenu;

		// Token: 0x040084A0 RID: 33952
		private bool _isActive;

		// Token: 0x040084A1 RID: 33953
		private bool _wantsToBeSeen;

		// Token: 0x040084A2 RID: 33954
		private float _opacity;
	}
}
