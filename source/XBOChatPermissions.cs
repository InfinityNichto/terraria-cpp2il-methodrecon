using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;

// Token: 0x02000046 RID: 70
public static class XBOChatPermissions
{
	// Token: 0x0600017E RID: 382 RVA: 0x0000491C File Offset: 0x00002B1C
	public static void Reset()
	{
		if (!true)
		{
		}
	}

	// Token: 0x0600017F RID: 383 RVA: 0x00004948 File Offset: 0x00002B48
	public static void CanChatWith(string xboPlayerId, XBOChatPermissions.ChatPermissionsResult result)
	{
		bool flag = string.IsNullOrEmpty(xboPlayerId);
		IntPtr invoke_impl = result.invoke_impl;
		IntPtr method_code = result.method_code;
		IntPtr method = result.method;
	}

	// Token: 0x06000180 RID: 384 RVA: 0x00004990 File Offset: 0x00002B90
	public static void SetPermissions(string xboPlayerId, bool canCommunicate)
	{
		if (!true)
		{
		}
	}

	// Token: 0x06000181 RID: 385 RVA: 0x000049A0 File Offset: 0x00002BA0
	// Note: this type is marked as 'beforefieldinit'.
	static XBOChatPermissions()
	{
	}

	// Token: 0x04000113 RID: 275
	private static Dictionary<string, XBOChatPermissions.RequestResult> _inprogress;

	// Token: 0x04000114 RID: 276
	private static Dictionary<string, bool> _cachedChatPermissions;

	// Token: 0x02000047 RID: 71
	public sealed class ChatPermissionsResult : MulticastDelegate
	{
		// Token: 0x06000182 RID: 386 RVA: 0x000049B0 File Offset: 0x00002BB0
		public ChatPermissionsResult(object @object, IntPtr method)
		{
			this.method_ptr = method;
			this.m_target = @object;
			this.method = method;
			this.method_code = this;
		}

		// Token: 0x06000183 RID: 387 RVA: 0x00004A04 File Offset: 0x00002C04
		public void Invoke(string playerId, bool result)
		{
			IntPtr method_code = this.method_code;
			IntPtr invoke_impl = this.invoke_impl;
			IntPtr method = this.method;
		}

		// Token: 0x06000184 RID: 388 RVA: 0x000021DB File Offset: 0x000003DB
		public IAsyncResult BeginInvoke(string playerId, bool result, AsyncCallback callback, object @object)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06000185 RID: 389 RVA: 0x00004A28 File Offset: 0x00002C28
		public void EndInvoke(IAsyncResult result)
		{
		}
	}

	// Token: 0x02000048 RID: 72
	public class RequestResult
	{
		// Token: 0x06000186 RID: 390 RVA: 0x00004A38 File Offset: 0x00002C38
		public void Clear()
		{
		}

		// Token: 0x14000003 RID: 3
		// (add) Token: 0x06000187 RID: 391 RVA: 0x00004A48 File Offset: 0x00002C48
		// (remove) Token: 0x06000188 RID: 392 RVA: 0x00004A6C File Offset: 0x00002C6C
		public event XBOChatPermissions.ChatPermissionsResult ResultCallbacks
		{
			[CompilerGenerated]
			add
			{
				if (Delegate.Combine(this.ResultCallbacks, value) != null)
				{
				}
			}
			[CompilerGenerated]
			remove
			{
				if (Delegate.Remove(this.ResultCallbacks, value) != null)
				{
				}
			}
		}

		// Token: 0x06000189 RID: 393 RVA: 0x00004A90 File Offset: 0x00002C90
		public RequestResult()
		{
		}

		// Token: 0x04000115 RID: 277
		public string xboPlayerId;

		// Token: 0x04000116 RID: 278
		[CompilerGenerated]
		private XBOChatPermissions.ChatPermissionsResult ResultCallbacks;
	}
}
