using System;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace InControl
{
	// Token: 0x0200001A RID: 26
	public class InControlManager : SingletonMonoBehavior<InControlManager>
	{
		// Token: 0x0600011A RID: 282 RVA: 0x00004308 File Offset: 0x00002508
		private void OnEnable()
		{
			bool enforceSingleton = base.EnforceSingleton;
			bool flag = this.invertYAxis;
			if (!true)
			{
			}
			if (!true)
			{
			}
			bool flag2 = this.suspendInBackground;
			if (!true)
			{
			}
			bool flag3 = this.enableICade;
			if (!true)
			{
			}
			bool flag4 = this.enableXInput;
			if (!true)
			{
			}
			int num = this.xInputUpdateRate;
			if (!true)
			{
			}
			int num2 = this.xInputBufferSize;
			if (!true)
			{
			}
			bool flag5 = this.editorDisableAllProfiles;
			if (!true)
			{
			}
			bool flag6 = this.enableNativeInput;
			if (!true)
			{
			}
			bool flag7 = this.nativeInputEnableXInput;
			if (!true)
			{
			}
			bool flag8 = this.nativeInputEnableMFi;
			if (!true)
			{
			}
			int num3 = this.nativeInputUpdateRate;
			if (!true)
			{
			}
			bool flag9 = this.nativeInputPreventSleep;
			if (!true)
			{
			}
			bool flag10 = InputManager.SetupInternal();
			bool flag11 = this.logDebugInfo;
			if (flag11)
			{
				if (!flag11)
				{
				}
				string text;
				Debug.Log("InControl (version " + text + ")");
			}
			if (this.dontDestroyOnLoad)
			{
				global::UnityEngine.Object.DontDestroyOnLoad(this);
			}
		}

		// Token: 0x0600011B RID: 283 RVA: 0x000043E0 File Offset: 0x000025E0
		private void OnDisable()
		{
			bool isNotTheSingleton = base.IsNotTheSingleton;
		}

		// Token: 0x0600011C RID: 284 RVA: 0x000043FC File Offset: 0x000025FC
		private void Update()
		{
			bool isNotTheSingleton = base.IsNotTheSingleton;
			if (this.applicationHasQuit)
			{
				return;
			}
			InControlUpdateMode inControlUpdateMode = this.updateMode;
			if (inControlUpdateMode != InControlUpdateMode.Default)
			{
				float timeScale = Time.timeScale;
				if (inControlUpdateMode == InControlUpdateMode.Default)
				{
				}
				bool flag = Utility.IsZero(timeScale);
			}
			InputManager.UpdateInternal();
		}

		// Token: 0x0600011D RID: 285 RVA: 0x00004444 File Offset: 0x00002644
		private void FixedUpdate()
		{
			bool isNotTheSingleton = base.IsNotTheSingleton;
			if (!this.applicationHasQuit)
			{
				InControlUpdateMode inControlUpdateMode = this.updateMode;
				InputManager.UpdateInternal();
				return;
			}
		}

		// Token: 0x0600011E RID: 286 RVA: 0x00004470 File Offset: 0x00002670
		private void OnApplicationFocus(bool focusState)
		{
			bool isNotTheSingleton = base.IsNotTheSingleton;
		}

		// Token: 0x0600011F RID: 287 RVA: 0x0000448C File Offset: 0x0000268C
		private void OnApplicationPause(bool pauseState)
		{
			bool isNotTheSingleton = base.IsNotTheSingleton;
		}

		// Token: 0x06000120 RID: 288 RVA: 0x000044A8 File Offset: 0x000026A8
		private void OnApplicationQuit()
		{
			bool isNotTheSingleton = base.IsNotTheSingleton;
			InputManager.OnApplicationQuit();
			this.applicationHasQuit = true;
		}

		// Token: 0x06000121 RID: 289 RVA: 0x000044CC File Offset: 0x000026CC
		private void OnSceneWasLoaded(Scene scene, LoadSceneMode loadSceneMode)
		{
			bool isNotTheSingleton = base.IsNotTheSingleton;
			if (loadSceneMode == LoadSceneMode.Single)
			{
				InputManager.OnLevelWasLoaded();
				return;
			}
		}

		// Token: 0x06000122 RID: 290 RVA: 0x000044EC File Offset: 0x000026EC
		private static void LogMessage(LogMessage logMessage)
		{
			Debug.Log(logMessage);
		}

		// Token: 0x06000123 RID: 291 RVA: 0x00004510 File Offset: 0x00002710
		public InControlManager()
		{
			if (!true)
			{
			}
			base..ctor();
		}

		// Token: 0x04000113 RID: 275
		public bool logDebugInfo = true;

		// Token: 0x04000114 RID: 276
		public bool invertYAxis;

		// Token: 0x04000115 RID: 277
		[SerializeField]
		private bool useFixedUpdate;

		// Token: 0x04000116 RID: 278
		public bool dontDestroyOnLoad = true;

		// Token: 0x04000117 RID: 279
		public bool suspendInBackground;

		// Token: 0x04000118 RID: 280
		public InControlUpdateMode updateMode;

		// Token: 0x04000119 RID: 281
		public bool enableICade;

		// Token: 0x0400011A RID: 282
		public bool enableXInput;

		// Token: 0x0400011B RID: 283
		public bool xInputOverrideUpdateRate;

		// Token: 0x0400011C RID: 284
		public int xInputUpdateRate;

		// Token: 0x0400011D RID: 285
		public bool xInputOverrideBufferSize;

		// Token: 0x0400011E RID: 286
		public int xInputBufferSize;

		// Token: 0x0400011F RID: 287
		public bool editorDisableAllProfiles;

		// Token: 0x04000120 RID: 288
		public bool enableNativeInput;

		// Token: 0x04000121 RID: 289
		public bool nativeInputEnableXInput;

		// Token: 0x04000122 RID: 290
		public bool nativeInputEnableMFi;

		// Token: 0x04000123 RID: 291
		public bool nativeInputPreventSleep;

		// Token: 0x04000124 RID: 292
		public bool nativeInputOverrideUpdateRate;

		// Token: 0x04000125 RID: 293
		public int nativeInputUpdateRate;

		// Token: 0x04000126 RID: 294
		private bool applicationHasQuit;
	}
}
