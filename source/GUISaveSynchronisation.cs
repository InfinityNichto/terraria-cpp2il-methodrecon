using System;

// Token: 0x02000298 RID: 664
public class GUISaveSynchronisation
{
	// Token: 0x06000F8D RID: 3981 RVA: 0x0004E134 File Offset: 0x0004C334
	public static void Open()
	{
	}

	// Token: 0x06000F8E RID: 3982 RVA: 0x0004E144 File Offset: 0x0004C344
	public static void Close()
	{
	}

	// Token: 0x06000F8F RID: 3983 RVA: 0x0004E154 File Offset: 0x0004C354
	public static void Draw()
	{
		GUISaveSynchronisation.DrawClientState();
	}

	// Token: 0x06000F90 RID: 3984 RVA: 0x0004E17C File Offset: 0x0004C37C
	private static void DrawConnectingState()
	{
		GUISaveSynchronisation_Status.DrawStatus("Connecting...");
	}

	// Token: 0x06000F91 RID: 3985 RVA: 0x0004E194 File Offset: 0x0004C394
	private static void DrawHostedState()
	{
		GUISaveSynchronisation_FileList.Draw();
	}

	// Token: 0x06000F92 RID: 3986 RVA: 0x0004E1A8 File Offset: 0x0004C3A8
	private static void DrawClientState()
	{
		GUISaveSynchronisation_FileList.Draw();
	}

	// Token: 0x06000F93 RID: 3987 RVA: 0x0004E1BC File Offset: 0x0004C3BC
	public GUISaveSynchronisation()
	{
	}

	// Token: 0x04001C30 RID: 7216
	public static bool Enabled;
}
