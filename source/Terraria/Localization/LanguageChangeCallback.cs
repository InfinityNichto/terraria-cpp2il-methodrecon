using System;
using Cpp2IlInjected;

namespace Terraria.Localization
{
	// Token: 0x02000554 RID: 1364
	public sealed class LanguageChangeCallback : MulticastDelegate
	{
		// Token: 0x06003300 RID: 13056 RVA: 0x001FE414 File Offset: 0x001FC614
		public LanguageChangeCallback(object @object, IntPtr method)
		{
			this.method_ptr = method;
			this.m_target = @object;
			this.method = method;
			this.method_code = this;
		}

		// Token: 0x06003301 RID: 13057 RVA: 0x001FE474 File Offset: 0x001FC674
		public void Invoke(LanguageManager languageManager)
		{
			IntPtr method_code = this.method_code;
			IntPtr invoke_impl = this.invoke_impl;
			IntPtr method = this.method;
		}

		// Token: 0x06003302 RID: 13058 RVA: 0x000021DB File Offset: 0x000003DB
		public IAsyncResult BeginInvoke(LanguageManager languageManager, AsyncCallback callback, object @object)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06003303 RID: 13059 RVA: 0x001FE498 File Offset: 0x001FC698
		public void EndInvoke(IAsyncResult result)
		{
		}
	}
}
