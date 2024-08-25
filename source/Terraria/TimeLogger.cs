using System;
using System.Diagnostics;
using System.IO;
using System.Text;
using Cpp2IlInjected;
using UnityEngine;

namespace Terraria
{
	// Token: 0x02000463 RID: 1123
	public static class TimeLogger
	{
		// Token: 0x06002B2A RID: 11050 RVA: 0x001B453C File Offset: 0x001B273C
		public static void Initialize()
		{
		}

		// Token: 0x06002B2B RID: 11051 RVA: 0x001B4560 File Offset: 0x001B2760
		public static void Start()
		{
		}

		// Token: 0x06002B2C RID: 11052 RVA: 0x001B4570 File Offset: 0x001B2770
		public static void NewDrawFrame()
		{
			while (!false)
			{
			}
			DateTime now = DateTime.Now;
			string text2;
			string text = Main.SavePath + text2 + "TerrariaDrawLog.7z";
			if (true)
			{
			}
			TimeSpan timeSpan;
			double totalMilliseconds = timeSpan.TotalMilliseconds;
		}

		// Token: 0x06002B2D RID: 11053 RVA: 0x001B45E0 File Offset: 0x001B27E0
		public static void EndDrawFrame()
		{
			StringBuilder stringBuilder;
			int length = stringBuilder.AppendLine().AppendLine("Logging ended early").Length;
			int num = 250;
			int num2 = 250;
			long num3 = 0L;
			Main.NewText("Detailed logging ended.", (byte)num, (byte)num2, (byte)num3);
		}

		// Token: 0x06002B2E RID: 11054 RVA: 0x001B4624 File Offset: 0x001B2824
		private static void UpdateTime(TimeLogger.TimeLogData[] times, int type, double time)
		{
		}

		// Token: 0x06002B2F RID: 11055 RVA: 0x001B4634 File Offset: 0x001B2834
		public static void RenderTime(int renderType, double timeElapsed)
		{
		}

		// Token: 0x06002B30 RID: 11056 RVA: 0x000021DB File Offset: 0x000003DB
		public static float GetRenderTime(int renderType)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06002B31 RID: 11057 RVA: 0x000021DB File Offset: 0x000003DB
		public static float GetRenderMax(int renderType)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06002B32 RID: 11058 RVA: 0x001B4644 File Offset: 0x001B2844
		public static void DrawTime(int drawType, double timeElapsed)
		{
		}

		// Token: 0x06002B33 RID: 11059 RVA: 0x000021DB File Offset: 0x000003DB
		public static float GetDrawTime(int drawType)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06002B34 RID: 11060 RVA: 0x001B4654 File Offset: 0x001B2854
		public static float GetDrawTotal()
		{
		}

		// Token: 0x06002B35 RID: 11061 RVA: 0x001B4664 File Offset: 0x001B2864
		public static void LightingTime(int lightingType, double timeElapsed)
		{
		}

		// Token: 0x06002B36 RID: 11062 RVA: 0x000021DB File Offset: 0x000003DB
		public static float GetLightingTime(int lightingType)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06002B37 RID: 11063 RVA: 0x001B4674 File Offset: 0x001B2874
		public static float GetLightingTotal()
		{
		}

		// Token: 0x06002B38 RID: 11064 RVA: 0x001B4684 File Offset: 0x001B2884
		public static void DetailedDrawReset()
		{
			TimeSpan timeSpan;
			double totalMilliseconds = timeSpan.TotalMilliseconds;
		}

		// Token: 0x06002B39 RID: 11065 RVA: 0x001B4698 File Offset: 0x001B2898
		public static void DetailedDrawTime(int detailedDrawType)
		{
			TimeSpan timeSpan;
			double totalMilliseconds = timeSpan.TotalMilliseconds;
		}

		// Token: 0x06002B3A RID: 11066 RVA: 0x000021DB File Offset: 0x000003DB
		public static float GetDetailedDrawTime(int detailedDrawType)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06002B3B RID: 11067 RVA: 0x001B46AC File Offset: 0x001B28AC
		public static float GetDetailedDrawTotal()
		{
		}

		// Token: 0x06002B3C RID: 11068 RVA: 0x001B46BC File Offset: 0x001B28BC
		public static void MenuDrawTime(double timeElapsed)
		{
		}

		// Token: 0x06002B3D RID: 11069 RVA: 0x001B46CC File Offset: 0x001B28CC
		public static void SplashDrawTime(double timeElapsed)
		{
		}

		// Token: 0x06002B3E RID: 11070 RVA: 0x001B46DC File Offset: 0x001B28DC
		public static void MapDrawTime(double timeElapsed)
		{
		}

		// Token: 0x06002B3F RID: 11071 RVA: 0x001B46EC File Offset: 0x001B28EC
		public static void DrawException(Exception e)
		{
			Debug.LogError(e);
		}

		// Token: 0x0400378C RID: 14220
		private static StreamWriter logWriter;

		// Token: 0x0400378D RID: 14221
		private static StringBuilder logBuilder;

		// Token: 0x0400378E RID: 14222
		private static int framesToLog;

		// Token: 0x0400378F RID: 14223
		private static int currentFrame;

		// Token: 0x04003790 RID: 14224
		private static bool startLoggingNextFrame;

		// Token: 0x04003791 RID: 14225
		private static bool endLoggingThisFrame;

		// Token: 0x04003792 RID: 14226
		private static bool currentlyLogging;

		// Token: 0x04003793 RID: 14227
		private static Stopwatch detailedDrawTimer;

		// Token: 0x04003794 RID: 14228
		private static double lastDetailedDrawTime;

		// Token: 0x04003795 RID: 14229
		private static TimeLogger.TimeLogData[] renderTimes;

		// Token: 0x04003796 RID: 14230
		private static TimeLogger.TimeLogData[] drawTimes;

		// Token: 0x04003797 RID: 14231
		private static TimeLogger.TimeLogData[] lightingTimes;

		// Token: 0x04003798 RID: 14232
		private static TimeLogger.TimeLogData[] detailedDrawTimes;

		// Token: 0x04003799 RID: 14233
		private const int maxTimeDelay = 100;

		// Token: 0x02000464 RID: 1124
		private struct TimeLogData
		{
			// Token: 0x0400379A RID: 14234
			public float time;

			// Token: 0x0400379B RID: 14235
			public float timeMax;

			// Token: 0x0400379C RID: 14236
			public int resetMaxTime;

			// Token: 0x0400379D RID: 14237
			public bool usedLastDraw;

			// Token: 0x0400379E RID: 14238
			public string logText;
		}
	}
}
