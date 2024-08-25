using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000039 RID: 57
public static class AndroidImmersive
{
	// Token: 0x06000141 RID: 321 RVA: 0x00004150 File Offset: 0x00002350
	public static void Activate()
	{
		RuntimePlatform platform = Application.platform;
		int sdklevel = AndroidImmersive.GetSDKLevel();
		Debug.Log("AndroidImmersive: SDK level < 19 so skipping immersive mode");
	}

	// Token: 0x06000142 RID: 322 RVA: 0x000041A8 File Offset: 0x000023A8
	public static void Deactivate(bool blockReactivation)
	{
	}

	// Token: 0x06000143 RID: 323 RVA: 0x000041D4 File Offset: 0x000023D4
	private static void RunActivate()
	{
	}

	// Token: 0x06000144 RID: 324 RVA: 0x00004208 File Offset: 0x00002408
	private static void RunDeactivate()
	{
		if ("setOnSystemUiVisibilityChangeListener" != null)
		{
			Debug.Log("AndroidImmersive: Listener cleared.");
		}
	}

	// Token: 0x06000145 RID: 325 RVA: 0x00004248 File Offset: 0x00002448
	private static int GetSDKLevel()
	{
		IntPtr intPtr = AndroidJNI.FindClass("android/os/Build$VERSION");
		IntPtr staticFieldID = AndroidJNI.GetStaticFieldID(intPtr, "SDK_INT", "I");
		string text = AndroidJNI.GetStaticIntField(intPtr, staticFieldID).ToString();
		string text2 = "AndroidImmersive: SDK level = " + text;
		Debug.Log(text2);
		Debug.Log("AndroidImmersive: Can't retrieve SDK level");
		return "AndroidImmersive: Can't retrieve SDK level";
	}

	// Token: 0x040000D0 RID: 208
	private static AndroidJavaObject _viewInstance;

	// Token: 0x040000D1 RID: 209
	private static AndroidJavaObject _viewInstanceBackup;

	// Token: 0x040000D2 RID: 210
	private static bool _blockReactivation;

	// Token: 0x040000D3 RID: 211
	private const int SYSTEM_UI_FLAG_HIDE_NAVIGATION = 2;

	// Token: 0x040000D4 RID: 212
	private const int SYSTEM_UI_FLAG_FULLSCREEN = 4;

	// Token: 0x040000D5 RID: 213
	private const int SYSTEM_UI_FLAG_LAYOUT_STABLE = 256;

	// Token: 0x040000D6 RID: 214
	private const int SYSTEM_UI_FLAG_LAYOUT_HIDE_NAVIGATION = 512;

	// Token: 0x040000D7 RID: 215
	private const int SYSTEM_UI_FLAG_LAYOUT_FULLSCREEN = 1024;

	// Token: 0x040000D8 RID: 216
	private const int SYSTEM_UI_FLAG_IMMERSIVE = 2048;

	// Token: 0x040000D9 RID: 217
	private const int SYSTEM_UI_FLAG_IMMERSIVE_STICKY = 4096;

	// Token: 0x0200003A RID: 58
	private sealed class RunPtr : MulticastDelegate
	{
		// Token: 0x06000146 RID: 326 RVA: 0x000042A8 File Offset: 0x000024A8
		public RunPtr(object @object, IntPtr method)
		{
			this.method_ptr = method;
			this.m_target = @object;
			this.method = method;
			this.method_code = this;
		}

		// Token: 0x06000147 RID: 327 RVA: 0x000042FC File Offset: 0x000024FC
		public void Invoke()
		{
			IntPtr method_code = this.method_code;
			IntPtr invoke_impl = this.invoke_impl;
			IntPtr method = this.method;
		}

		// Token: 0x06000148 RID: 328 RVA: 0x000021DB File Offset: 0x000003DB
		public IAsyncResult BeginInvoke(AsyncCallback callback, object @object)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06000149 RID: 329 RVA: 0x00004320 File Offset: 0x00002520
		public void EndInvoke(IAsyncResult result)
		{
		}
	}

	// Token: 0x0200003B RID: 59
	private class Listener : AndroidJavaProxy
	{
		// Token: 0x0600014A RID: 330 RVA: 0x00004330 File Offset: 0x00002530
		public Listener()
		{
			if (!true)
			{
			}
			base..ctor("android.view.View$OnSystemUiVisibilityChangeListener");
		}

		// Token: 0x0600014B RID: 331 RVA: 0x0000434C File Offset: 0x0000254C
		private void onSystemUiVisibilityChange(int visibility)
		{
			string text;
			Debug.Log("AndroidImmersive: SystemUiVisibilityChange = " + text);
			AndroidImmersive.RunActivate();
		}
	}
}
