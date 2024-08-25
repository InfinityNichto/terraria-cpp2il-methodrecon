using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000063 RID: 99
public abstract class Singleton<T> : ScriptableObject where T : Singleton<T>, new()
{
	// Token: 0x06000209 RID: 521 RVA: 0x00005FB0 File Offset: 0x000041B0
	public Singleton()
	{
	}

	// Token: 0x17000073 RID: 115
	// (get) Token: 0x0600020A RID: 522 RVA: 0x000021DB File Offset: 0x000003DB
	public static T Instance
	{
		get
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}
	}

	// Token: 0x0600020B RID: 523 RVA: 0x00005FC4 File Offset: 0x000041C4
	public static void Create()
	{
	}

	// Token: 0x0600020C RID: 524 RVA: 0x00005FD8 File Offset: 0x000041D8
	private static void CreateOnMainThread(object resourceId)
	{
		if (resourceId != null)
		{
		}
	}

	// Token: 0x0600020D RID: 525 RVA: 0x00005FF0 File Offset: 0x000041F0
	public static void Create(string resourceId)
	{
		bool isMainThread = DrPlatform.IsMainThread;
		bool isPlaying = Application.isPlaying;
	}

	// Token: 0x0600020E RID: 526 RVA: 0x00006060 File Offset: 0x00004260
	public static void Destroy()
	{
	}

	// Token: 0x0600020F RID: 527 RVA: 0x00006074 File Offset: 0x00004274
	private void OnEnable()
	{
		if (!true)
		{
			return;
		}
	}

	// Token: 0x06000210 RID: 528 RVA: 0x00006088 File Offset: 0x00004288
	private void OnDisable()
	{
		if (true)
		{
			return;
		}
	}

	// Token: 0x06000211 RID: 529 RVA: 0x0000609C File Offset: 0x0000429C
	private static void Cleanup()
	{
		string text;
		Debug.Log(text);
	}

	// Token: 0x06000212 RID: 530 RVA: 0x000060B0 File Offset: 0x000042B0
	public virtual void Init()
	{
	}

	// Token: 0x06000213 RID: 531 RVA: 0x000060C0 File Offset: 0x000042C0
	public virtual void Shutdown()
	{
	}

	// Token: 0x040001F7 RID: 503
	private static T _instance;

	// Token: 0x040001F8 RID: 504
	private static bool _initialised;
}
