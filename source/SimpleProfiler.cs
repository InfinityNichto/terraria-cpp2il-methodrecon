using System;
using System.Diagnostics;
using UnityEngine;

// Token: 0x0200005D RID: 93
public static class SimpleProfiler
{
	// Token: 0x060001F1 RID: 497 RVA: 0x00005C60 File Offset: 0x00003E60
	[Conditional("SIMPLEPROFILER")]
	public static void Initialise(Type enumType)
	{
		if (!true)
		{
		}
		string[] names = Enum.GetNames(enumType);
	}

	// Token: 0x060001F2 RID: 498 RVA: 0x00005C84 File Offset: 0x00003E84
	[Conditional("SIMPLEPROFILER")]
	private static void AllocateSampleFrames(int numberFrames)
	{
	}

	// Token: 0x060001F3 RID: 499 RVA: 0x00005C94 File Offset: 0x00003E94
	[Conditional("SIMPLEPROFILER")]
	public static void BeginFrame()
	{
		DateTime now = DateTime.Now;
		DateTime now2 = DateTime.Now;
		DateTime now3 = DateTime.Now;
	}

	// Token: 0x060001F4 RID: 500 RVA: 0x00005CBC File Offset: 0x00003EBC
	[Conditional("SIMPLEPROFILER")]
	public static void EndFrame()
	{
		if (!true)
		{
		}
		DateTime now = DateTime.Now;
	}

	// Token: 0x060001F5 RID: 501 RVA: 0x00005CD4 File Offset: 0x00003ED4
	[Conditional("SIMPLEPROFILER")]
	public static void Draw()
	{
	}

	// Token: 0x060001F6 RID: 502 RVA: 0x00005CE4 File Offset: 0x00003EE4
	[Conditional("SIMPLEPROFILER")]
	public static void BeginSample(int sampleId)
	{
		DateTime now = DateTime.Now;
	}

	// Token: 0x060001F7 RID: 503 RVA: 0x00005CFC File Offset: 0x00003EFC
	[Conditional("SIMPLEPROFILER")]
	public static void EndSample(int sampleId)
	{
		DateTime now = DateTime.Now;
	}

	// Token: 0x060001F8 RID: 504 RVA: 0x00005D14 File Offset: 0x00003F14
	[Conditional("SIMPLEPROFILER")]
	public static void Dump()
	{
	}

	// Token: 0x060001F9 RID: 505 RVA: 0x00005D24 File Offset: 0x00003F24
	[Conditional("SIMPLEPROFILER")]
	private static void DumpFrameData(int frame)
	{
		double totalMilliseconds = TimeSpan.FromTicks((long)frame).TotalMilliseconds;
		TimeSpan timeSpan;
		double totalMilliseconds2 = timeSpan.TotalMilliseconds;
		string text;
		string text2;
		Debug.Log(text + " " + text2);
		string text3;
		if ((" " == null || " " != null) && (text3 == null || text3 != null) && (" " == null || " " != null))
		{
			TimeSpan timeSpan2;
			double totalMilliseconds3 = timeSpan2.TotalMilliseconds;
			string text4;
			if (text4 == null || text4 != null)
			{
				string text5;
				Debug.Log(text5);
				return;
			}
		}
		throw new ArrayTypeMismatchException();
	}

	// Token: 0x060001FA RID: 506 RVA: 0x00005D9C File Offset: 0x00003F9C
	[Conditional("UNITYPROFILING")]
	public static void UnityProfileBegin(string begin)
	{
	}

	// Token: 0x060001FB RID: 507 RVA: 0x00005DAC File Offset: 0x00003FAC
	[Conditional("UNITYPROFILING")]
	public static void UnityProfileEnd(string end)
	{
	}

	// Token: 0x060001FC RID: 508 RVA: 0x00005DBC File Offset: 0x00003FBC
	[Conditional("SIMPLEPROFILER")]
	public static void OnGUI()
	{
		int height = Screen.height;
		int width = Screen.width;
		int height2 = Screen.height;
		if (16968 == 0)
		{
		}
		GUIStyle box = GUI.skin.box;
		double totalMilliseconds = TimeSpan.FromTicks((long)width).TotalMilliseconds;
		TimeSpan timeSpan;
		double totalMilliseconds2 = timeSpan.TotalMilliseconds;
		string text2;
		string text3;
		string text = text2 + " " + text3;
		string text4;
		if ((" " == null || " " != null) && (text4 == null || text4 != null) && (" " == null || " " != null))
		{
			TimeSpan timeSpan2;
			double totalMilliseconds3 = timeSpan2.TotalMilliseconds;
			string text5;
			if (text5 == null || text5 != null)
			{
				GUILayout.EndArea();
				return;
			}
		}
		throw new ArrayTypeMismatchException();
	}

	// Token: 0x040001E4 RID: 484
	public static bool DisplayStats;

	// Token: 0x040001E5 RID: 485
	private static int NextFrame;

	// Token: 0x040001E6 RID: 486
	private static string[] FrameSampleTypes;

	// Token: 0x040001E7 RID: 487
	private static SimpleProfilerFrameData[] FrameData;

	// Token: 0x040001E8 RID: 488
	private static SimpleProfilerFrameData CurrentFrameData;

	// Token: 0x040001E9 RID: 489
	private static SimpleProfilerFrameData LastFrameData;

	// Token: 0x040001EA RID: 490
	private static DateTime FrameTimeStart;

	// Token: 0x040001EB RID: 491
	private static DateTime FrameTimeEnd;

	// Token: 0x040001EC RID: 492
	private static SimpleProfilerSampleFrame AvailableFrames;

	// Token: 0x040001ED RID: 493
	private static SimpleProfilerSampleFrame CurrentFrames;
}
