using System;

namespace Microsoft.Xna.Framework
{
	// Token: 0x02000335 RID: 821
	public class GameTime
	{
		// Token: 0x06001496 RID: 5270 RVA: 0x0005F128 File Offset: 0x0005D328
		public GameTime()
		{
		}

		// Token: 0x06001497 RID: 5271 RVA: 0x0005F13C File Offset: 0x0005D33C
		public GameTime(TimeSpan totalRealTime, TimeSpan elapsedRealTime, TimeSpan totalGameTime, TimeSpan elapsedGameTime)
		{
			this.totalGameTime = totalGameTime;
			this.totalRealTime = totalRealTime;
			this.elapsedGameTime = elapsedGameTime;
			this.elapsedRealTime = elapsedRealTime;
		}

		// Token: 0x06001498 RID: 5272 RVA: 0x0005F16C File Offset: 0x0005D36C
		public GameTime(TimeSpan totalRealTime, TimeSpan elapsedRealTime, TimeSpan totalGameTime, TimeSpan elapsedGameTime, bool isRunningSlowly)
		{
			this.totalGameTime = totalGameTime;
			this.totalRealTime = totalRealTime;
			this.elapsedGameTime = elapsedGameTime;
			this.elapsedRealTime = elapsedRealTime;
		}

		// Token: 0x17000204 RID: 516
		// (get) Token: 0x06001499 RID: 5273 RVA: 0x0005F19C File Offset: 0x0005D39C
		// (set) Token: 0x0600149A RID: 5274 RVA: 0x0005F1B4 File Offset: 0x0005D3B4
		public TimeSpan ElapsedGameTime
		{
			get
			{
				TimeSpan timeSpan = this.elapsedGameTime;
				TimeSpan timeSpan2;
				return timeSpan2;
			}
			internal set
			{
				this.elapsedGameTime = value;
			}
		}

		// Token: 0x17000205 RID: 517
		// (get) Token: 0x0600149B RID: 5275 RVA: 0x0005F1C8 File Offset: 0x0005D3C8
		// (set) Token: 0x0600149C RID: 5276 RVA: 0x0005F1E0 File Offset: 0x0005D3E0
		public TimeSpan ElapsedRealTime
		{
			get
			{
				TimeSpan timeSpan = this.elapsedRealTime;
				TimeSpan timeSpan2;
				return timeSpan2;
			}
			internal set
			{
				this.elapsedRealTime = value;
			}
		}

		// Token: 0x17000206 RID: 518
		// (get) Token: 0x0600149D RID: 5277 RVA: 0x0005F1F4 File Offset: 0x0005D3F4
		// (set) Token: 0x0600149E RID: 5278 RVA: 0x0005F208 File Offset: 0x0005D408
		public bool IsRunningSlowly
		{
			get
			{
				return this.isRunningSlowly;
			}
			internal set
			{
			}
		}

		// Token: 0x17000207 RID: 519
		// (get) Token: 0x0600149F RID: 5279 RVA: 0x0005F218 File Offset: 0x0005D418
		// (set) Token: 0x060014A0 RID: 5280 RVA: 0x0005F230 File Offset: 0x0005D430
		public TimeSpan TotalGameTime
		{
			get
			{
				TimeSpan timeSpan = this.totalGameTime;
				TimeSpan timeSpan2;
				return timeSpan2;
			}
			internal set
			{
				this.totalGameTime = value;
			}
		}

		// Token: 0x17000208 RID: 520
		// (get) Token: 0x060014A1 RID: 5281 RVA: 0x0005F244 File Offset: 0x0005D444
		// (set) Token: 0x060014A2 RID: 5282 RVA: 0x0005F25C File Offset: 0x0005D45C
		public TimeSpan TotalRealTime
		{
			get
			{
				TimeSpan timeSpan = this.totalRealTime;
				TimeSpan timeSpan2;
				return timeSpan2;
			}
			internal set
			{
				this.totalRealTime = value;
			}
		}

		// Token: 0x040022AE RID: 8878
		private TimeSpan elapsedGameTime;

		// Token: 0x040022AF RID: 8879
		private TimeSpan elapsedRealTime;

		// Token: 0x040022B0 RID: 8880
		private bool isRunningSlowly;

		// Token: 0x040022B1 RID: 8881
		private TimeSpan totalGameTime;

		// Token: 0x040022B2 RID: 8882
		private TimeSpan totalRealTime;
	}
}
