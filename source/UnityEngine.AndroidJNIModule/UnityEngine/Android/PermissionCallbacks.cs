using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine.Scripting;

namespace UnityEngine.Android
{
	// Token: 0x02000018 RID: 24
	public class PermissionCallbacks : AndroidJavaProxy
	{
		// Token: 0x14000001 RID: 1
		// (add) Token: 0x0600018A RID: 394 RVA: 0x00005638 File Offset: 0x00003838
		// (remove) Token: 0x0600018B RID: 395 RVA: 0x00005660 File Offset: 0x00003860
		public event Action<string> PermissionGranted
		{
			[CompilerGenerated]
			add
			{
				Delegate @delegate = Delegate.Combine(this.PermissionGranted, value);
				if (@delegate != null && @delegate == null)
				{
					return;
				}
			}
			[CompilerGenerated]
			remove
			{
				Delegate @delegate = Delegate.Remove(this.PermissionGranted, value);
				if (@delegate != null && @delegate == null)
				{
					return;
				}
			}
		}

		// Token: 0x14000002 RID: 2
		// (add) Token: 0x0600018C RID: 396 RVA: 0x00005688 File Offset: 0x00003888
		// (remove) Token: 0x0600018D RID: 397 RVA: 0x000056B0 File Offset: 0x000038B0
		public event Action<string> PermissionDenied
		{
			[CompilerGenerated]
			add
			{
				Delegate @delegate = Delegate.Combine(this.PermissionDenied, value);
				if (@delegate != null && @delegate == null)
				{
					return;
				}
			}
			[CompilerGenerated]
			remove
			{
				Delegate @delegate = Delegate.Remove(this.PermissionDenied, value);
				if (@delegate != null && @delegate == null)
				{
					return;
				}
			}
		}

		// Token: 0x14000003 RID: 3
		// (add) Token: 0x0600018E RID: 398 RVA: 0x000056D8 File Offset: 0x000038D8
		// (remove) Token: 0x0600018F RID: 399 RVA: 0x00005700 File Offset: 0x00003900
		public event Action<string> PermissionDeniedAndDontAskAgain
		{
			[CompilerGenerated]
			add
			{
				Delegate @delegate = Delegate.Combine(this.PermissionDeniedAndDontAskAgain, value);
				if (@delegate != null && @delegate == null)
				{
					return;
				}
			}
			[CompilerGenerated]
			remove
			{
				Delegate @delegate = Delegate.Remove(this.PermissionDeniedAndDontAskAgain, value);
				if (@delegate != null && @delegate == null)
				{
					return;
				}
			}
		}

		// Token: 0x06000190 RID: 400 RVA: 0x00005728 File Offset: 0x00003928
		public PermissionCallbacks()
		{
			if (!true)
			{
			}
			base..ctor("com.unity3d.player.IPermissionRequestCallbacks");
		}

		// Token: 0x06000191 RID: 401 RVA: 0x00005744 File Offset: 0x00003944
		[Preserve]
		private void onPermissionGranted(string permissionName)
		{
			if (this.PermissionGranted != null)
			{
				return;
			}
		}

		// Token: 0x06000192 RID: 402 RVA: 0x0000575C File Offset: 0x0000395C
		[Preserve]
		private void onPermissionDenied(string permissionName)
		{
			if (this.PermissionDenied != null)
			{
				return;
			}
		}

		// Token: 0x06000193 RID: 403 RVA: 0x00005774 File Offset: 0x00003974
		[Preserve]
		private void onPermissionDeniedAndDontAskAgain(string permissionName)
		{
			Action<string> permissionDeniedAndDontAskAgain = this.PermissionDeniedAndDontAskAgain;
			if (permissionDeniedAndDontAskAgain != null || permissionDeniedAndDontAskAgain != null)
			{
				return;
			}
		}

		// Token: 0x04000048 RID: 72
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		private Action<string> PermissionGranted;

		// Token: 0x04000049 RID: 73
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		private Action<string> PermissionDenied;

		// Token: 0x0400004A RID: 74
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private Action<string> PermissionDeniedAndDontAskAgain;
	}
}
