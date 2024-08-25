using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using Terraria.DataStructures;
using Terraria.Localization;

namespace Terraria.Social.Base
{
	// Token: 0x02000534 RID: 1332
	public class WorkshopIssueReporter : IProvideReports
	{
		// Token: 0x14000033 RID: 51
		// (add) Token: 0x0600320E RID: 12814 RVA: 0x001F91FC File Offset: 0x001F73FC
		// (remove) Token: 0x0600320F RID: 12815 RVA: 0x001F9220 File Offset: 0x001F7420
		public event Action OnNeedToOpenUI
		{
			[CompilerGenerated]
			add
			{
				if (Delegate.Combine(this.OnNeedToOpenUI, value) != null)
				{
				}
			}
			[CompilerGenerated]
			remove
			{
				if (Delegate.Remove(this.OnNeedToOpenUI, value) != null)
				{
				}
			}
		}

		// Token: 0x14000034 RID: 52
		// (add) Token: 0x06003210 RID: 12816 RVA: 0x001F9244 File Offset: 0x001F7444
		// (remove) Token: 0x06003211 RID: 12817 RVA: 0x001F9268 File Offset: 0x001F7468
		public event Action OnNeedToNotifyUI
		{
			[CompilerGenerated]
			add
			{
				if (Delegate.Combine(this.OnNeedToNotifyUI, value) != null)
				{
				}
			}
			[CompilerGenerated]
			remove
			{
				if (Delegate.Remove(this.OnNeedToNotifyUI, value) != null)
				{
				}
			}
		}

		// Token: 0x06003212 RID: 12818 RVA: 0x000021DB File Offset: 0x000003DB
		private void AddReport(string reportText)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06003213 RID: 12819 RVA: 0x001F928C File Offset: 0x001F748C
		public List<IssueReport> GetReports()
		{
			return this._reports;
		}

		// Token: 0x06003214 RID: 12820 RVA: 0x001F92A0 File Offset: 0x001F74A0
		private void OpenReportsScreen()
		{
			Action onNeedToOpenUI = this.OnNeedToOpenUI;
			if (onNeedToOpenUI != null)
			{
				IntPtr invoke_impl = onNeedToOpenUI.invoke_impl;
				IntPtr method_code = onNeedToOpenUI.method_code;
				IntPtr method = onNeedToOpenUI.method;
				return;
			}
		}

		// Token: 0x06003215 RID: 12821 RVA: 0x001F92D0 File Offset: 0x001F74D0
		private void NotifyReportsScreen()
		{
			Action onNeedToNotifyUI = this.OnNeedToNotifyUI;
			if (onNeedToNotifyUI != null)
			{
				IntPtr invoke_impl = onNeedToNotifyUI.invoke_impl;
				IntPtr method_code = onNeedToNotifyUI.method_code;
				IntPtr method = onNeedToNotifyUI.method;
				return;
			}
		}

		// Token: 0x06003216 RID: 12822 RVA: 0x001F9300 File Offset: 0x001F7500
		public void ReportInstantUploadProblem(string textKey)
		{
			string textValue = Language.GetTextValue(textKey);
			this.AddReport(textValue);
			Action onNeedToOpenUI = this.OnNeedToOpenUI;
			if (onNeedToOpenUI != null)
			{
				IntPtr invoke_impl = onNeedToOpenUI.invoke_impl;
				IntPtr method_code = onNeedToOpenUI.method_code;
				IntPtr method = onNeedToOpenUI.method;
				return;
			}
		}

		// Token: 0x06003217 RID: 12823 RVA: 0x001F933C File Offset: 0x001F753C
		public void ReportInstantUploadProblemFromValue(string text)
		{
			this.AddReport(text);
			Action onNeedToOpenUI = this.OnNeedToOpenUI;
			if (onNeedToOpenUI != null)
			{
				IntPtr invoke_impl = onNeedToOpenUI.invoke_impl;
				IntPtr method_code = onNeedToOpenUI.method_code;
				IntPtr method = onNeedToOpenUI.method;
				return;
			}
		}

		// Token: 0x06003218 RID: 12824 RVA: 0x001F9370 File Offset: 0x001F7570
		public void ReportDelayedUploadProblem(string textKey)
		{
			string textValue = Language.GetTextValue(textKey);
			this.AddReport(textValue);
			Action onNeedToNotifyUI = this.OnNeedToNotifyUI;
			if (onNeedToNotifyUI != null)
			{
				IntPtr invoke_impl = onNeedToNotifyUI.invoke_impl;
				IntPtr method_code = onNeedToNotifyUI.method_code;
				IntPtr method = onNeedToNotifyUI.method;
				return;
			}
		}

		// Token: 0x06003219 RID: 12825 RVA: 0x001F93AC File Offset: 0x001F75AC
		public void ReportDelayedUploadProblemWithoutKnownReason(string textKey, string reasonValue)
		{
			string text;
			this.AddReport(text);
			Action onNeedToNotifyUI = this.OnNeedToNotifyUI;
			if (onNeedToNotifyUI != null)
			{
				IntPtr invoke_impl = onNeedToNotifyUI.invoke_impl;
				IntPtr method_code = onNeedToNotifyUI.method_code;
				IntPtr method = onNeedToNotifyUI.method;
				return;
			}
		}

		// Token: 0x0600321A RID: 12826 RVA: 0x001F93E4 File Offset: 0x001F75E4
		public void ReportDownloadProblem(string textKey, string path, Exception exception)
		{
			string text;
			this.AddReport(text);
			Action onNeedToNotifyUI = this.OnNeedToNotifyUI;
			if (onNeedToNotifyUI != null)
			{
				IntPtr invoke_impl = onNeedToNotifyUI.invoke_impl;
				IntPtr method_code = onNeedToNotifyUI.method_code;
				IntPtr method = onNeedToNotifyUI.method;
				return;
			}
		}

		// Token: 0x0600321B RID: 12827 RVA: 0x001F941C File Offset: 0x001F761C
		public void ReportManifestCreationProblem(string textKey, Exception exception)
		{
			string text;
			this.AddReport(text);
			Action onNeedToNotifyUI = this.OnNeedToNotifyUI;
			if (onNeedToNotifyUI != null)
			{
				IntPtr invoke_impl = onNeedToNotifyUI.invoke_impl;
				IntPtr method_code = onNeedToNotifyUI.method_code;
				IntPtr method = onNeedToNotifyUI.method;
				return;
			}
		}

		// Token: 0x0600321C RID: 12828 RVA: 0x001F9454 File Offset: 0x001F7654
		public WorkshopIssueReporter()
		{
		}

		// Token: 0x04003B70 RID: 15216
		[CompilerGenerated]
		private Action OnNeedToOpenUI;

		// Token: 0x04003B71 RID: 15217
		[CompilerGenerated]
		private Action OnNeedToNotifyUI;

		// Token: 0x04003B72 RID: 15218
		private int _maxReports = 1000;

		// Token: 0x04003B73 RID: 15219
		private List<IssueReport> _reports;
	}
}
