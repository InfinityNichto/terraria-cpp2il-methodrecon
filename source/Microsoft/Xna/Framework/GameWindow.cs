using System;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;

namespace Microsoft.Xna.Framework
{
	// Token: 0x02000336 RID: 822
	public abstract class GameWindow
	{
		// Token: 0x17000209 RID: 521
		// (get) Token: 0x060014A3 RID: 5283 RVA: 0x0005F270 File Offset: 0x0005D470
		// (set) Token: 0x060014A4 RID: 5284 RVA: 0x0005F284 File Offset: 0x0005D484
		public string Title
		{
			get
			{
				return this.title;
			}
			set
			{
				bool flag = this.title != value;
				this.title = value;
			}
		}

		// Token: 0x1700020A RID: 522
		// (get) Token: 0x060014A5 RID: 5285
		// (set) Token: 0x060014A6 RID: 5286
		public abstract bool AllowUserResizing { get; set; }

		// Token: 0x1700020B RID: 523
		// (get) Token: 0x060014A7 RID: 5287
		public abstract Rectangle ClientBounds { get; }

		// Token: 0x1700020C RID: 524
		// (get) Token: 0x060014A8 RID: 5288
		public abstract IntPtr Handle { get; }

		// Token: 0x1700020D RID: 525
		// (get) Token: 0x060014A9 RID: 5289
		public abstract string ScreenDeviceName { get; }

		// Token: 0x14000008 RID: 8
		// (add) Token: 0x060014AA RID: 5290 RVA: 0x0005F2A8 File Offset: 0x0005D4A8
		// (remove) Token: 0x060014AB RID: 5291 RVA: 0x0005F2CC File Offset: 0x0005D4CC
		public event EventHandler ClientSizeChanged
		{
			[CompilerGenerated]
			add
			{
				if (Delegate.Combine(this.ClientSizeChanged, value) != null)
				{
				}
			}
			[CompilerGenerated]
			remove
			{
				if (Delegate.Remove(this.ClientSizeChanged, value) != null)
				{
				}
			}
		}

		// Token: 0x14000009 RID: 9
		// (add) Token: 0x060014AC RID: 5292 RVA: 0x0005F2F0 File Offset: 0x0005D4F0
		// (remove) Token: 0x060014AD RID: 5293 RVA: 0x0005F314 File Offset: 0x0005D514
		public event EventHandler ScreenDeviceNameChanged
		{
			[CompilerGenerated]
			add
			{
				if (Delegate.Combine(this.ScreenDeviceNameChanged, value) != null)
				{
				}
			}
			[CompilerGenerated]
			remove
			{
				if (Delegate.Remove(this.ScreenDeviceNameChanged, value) != null)
				{
				}
			}
		}

		// Token: 0x060014AE RID: 5294
		public abstract void BeginScreenDeviceChange(bool willBeFullScreen);

		// Token: 0x060014AF RID: 5295 RVA: 0x000021DB File Offset: 0x000003DB
		public void EndScreenDeviceChange(string screenDeviceName)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x060014B0 RID: 5296
		public abstract void EndScreenDeviceChange(string screenDeviceName, int clientWidth, int clientHeight);

		// Token: 0x060014B1 RID: 5297 RVA: 0x0005F338 File Offset: 0x0005D538
		protected void OnActivated()
		{
		}

		// Token: 0x060014B2 RID: 5298 RVA: 0x0005F348 File Offset: 0x0005D548
		protected void OnClientSizeChanged()
		{
			EventHandler clientSizeChanged = this.ClientSizeChanged;
			if (clientSizeChanged != null)
			{
				if (!true)
				{
				}
				IntPtr invoke_impl = clientSizeChanged.invoke_impl;
				IntPtr method_code = clientSizeChanged.method_code;
				IntPtr method = clientSizeChanged.method;
				return;
			}
		}

		// Token: 0x060014B3 RID: 5299 RVA: 0x0005F378 File Offset: 0x0005D578
		protected void OnDeactivated()
		{
		}

		// Token: 0x060014B4 RID: 5300 RVA: 0x000021DB File Offset: 0x000003DB
		protected void OnPaint()
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x060014B5 RID: 5301 RVA: 0x0005F388 File Offset: 0x0005D588
		protected void OnScreenDeviceNameChanged()
		{
			EventHandler screenDeviceNameChanged = this.ScreenDeviceNameChanged;
			if (screenDeviceNameChanged != null)
			{
				if (!true)
				{
				}
				IntPtr invoke_impl = screenDeviceNameChanged.invoke_impl;
				IntPtr method_code = screenDeviceNameChanged.method_code;
				IntPtr method = screenDeviceNameChanged.method;
				return;
			}
		}

		// Token: 0x060014B6 RID: 5302
		protected abstract void SetTitle(string title);

		// Token: 0x1700020E RID: 526
		// (get) Token: 0x060014B7 RID: 5303 RVA: 0x0005F3B8 File Offset: 0x0005D5B8
		// (set) Token: 0x060014B8 RID: 5304 RVA: 0x0005F3CC File Offset: 0x0005D5CC
		public DisplayOrientation CurrentOrientation
		{
			[CompilerGenerated]
			get
			{
				return this.<CurrentOrientation>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<CurrentOrientation>k__BackingField = value;
			}
		}

		// Token: 0x060014B9 RID: 5305 RVA: 0x0005F3E0 File Offset: 0x0005D5E0
		protected GameWindow()
		{
		}

		// Token: 0x040022B3 RID: 8883
		private string title;

		// Token: 0x040022B4 RID: 8884
		[CompilerGenerated]
		private EventHandler ClientSizeChanged;

		// Token: 0x040022B5 RID: 8885
		[CompilerGenerated]
		private EventHandler ScreenDeviceNameChanged;

		// Token: 0x040022B6 RID: 8886
		[CompilerGenerated]
		private DisplayOrientation <CurrentOrientation>k__BackingField;
	}
}
