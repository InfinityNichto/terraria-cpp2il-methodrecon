using System;
using System.Diagnostics;
using Cpp2IlInjected;

// Token: 0x0200004A RID: 74
public class XBOPlatformEvent
{
	// Token: 0x1700006C RID: 108
	// (get) Token: 0x0600018C RID: 396 RVA: 0x000021DB File Offset: 0x000003DB
	public static string UserId
	{
		get
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}
	}

	// Token: 0x0600018D RID: 397 RVA: 0x00004AC8 File Offset: 0x00002CC8
	[Conditional("UNITY_XBOXONE")]
	public static void SendAchievementProgress(string identifier, float progress)
	{
	}

	// Token: 0x0600018E RID: 398 RVA: 0x00004AD8 File Offset: 0x00002CD8
	[Conditional("UNITY_XBOXONE")]
	public static void SendGameProgress(float progress)
	{
	}

	// Token: 0x0600018F RID: 399 RVA: 0x00004AE8 File Offset: 0x00002CE8
	[Conditional("UNITY_XBOXONE")]
	public static void SendMedalsUpdated(int Medals)
	{
	}

	// Token: 0x06000190 RID: 400 RVA: 0x00004AF8 File Offset: 0x00002CF8
	[Conditional("UNITY_XBOXONE")]
	public static void SendRankedMatchesUpdated(int RankedMatches)
	{
	}

	// Token: 0x06000191 RID: 401 RVA: 0x00004B08 File Offset: 0x00002D08
	[Conditional("UNITY_XBOXONE")]
	public static void SendRankedVicotriesUpdated(int RankedVictories)
	{
	}

	// Token: 0x06000192 RID: 402 RVA: 0x00004B18 File Offset: 0x00002D18
	[Conditional("UNITY_XBOXONE")]
	public static void SendThreeStarVictoriesUpdated(int ThreeStarVictories)
	{
	}

	// Token: 0x06000193 RID: 403 RVA: 0x00004B28 File Offset: 0x00002D28
	[Conditional("UNITY_XBOXONE")]
	public static void SendUnitsDonatedUpdated(int UnitsDonated)
	{
	}

	// Token: 0x06000194 RID: 404 RVA: 0x00004B38 File Offset: 0x00002D38
	[Conditional("UNITY_XBOXONE")]
	public static void SendUnitsUnlockedUpdated(int UnitsUnlocked)
	{
	}

	// Token: 0x06000195 RID: 405 RVA: 0x00004B48 File Offset: 0x00002D48
	[Conditional("UNITY_XBOXONE")]
	public static void SendMultiplayerRoundStart(Guid sessionGUID, string correlationId)
	{
	}

	// Token: 0x06000196 RID: 406 RVA: 0x00004B58 File Offset: 0x00002D58
	[Conditional("UNITY_XBOXONE")]
	public static void SendMultiplayerRoundEnd(Guid sessionGUID, string correlationId, float gameTime)
	{
	}

	// Token: 0x06000197 RID: 407 RVA: 0x00004B68 File Offset: 0x00002D68
	public XBOPlatformEvent()
	{
	}
}
