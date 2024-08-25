using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;

// Token: 0x0200004C RID: 76
public static class XBOOnlinePresencePermissions
{
	// Token: 0x06000199 RID: 409 RVA: 0x00004B8C File Offset: 0x00002D8C
	public static void Reset()
	{
		if (!true)
		{
		}
	}

	// Token: 0x0600019A RID: 410 RVA: 0x00004BB8 File Offset: 0x00002DB8
	public static void CanSeeOnlinePresence(string xboPlayerId, XBOOnlinePresencePermissions.OnlinePresencePermissionsResult result)
	{
		bool flag = string.IsNullOrEmpty(xboPlayerId);
		IntPtr invoke_impl = result.invoke_impl;
		IntPtr method_code = result.method_code;
		IntPtr method = result.method;
	}

	// Token: 0x0600019B RID: 411 RVA: 0x00004C00 File Offset: 0x00002E00
	public static void SetPermissions(string xboPlayerId, bool canCommunicate)
	{
		if (!true)
		{
		}
	}

	// Token: 0x0600019C RID: 412 RVA: 0x00004C10 File Offset: 0x00002E10
	// Note: this type is marked as 'beforefieldinit'.
	static XBOOnlinePresencePermissions()
	{
	}

	// Token: 0x04000118 RID: 280
	private static Dictionary<string, XBOOnlinePresencePermissions.RequestResult> _inprogress;

	// Token: 0x04000119 RID: 281
	private static Dictionary<string, bool> _cachedOnlinePresencePermissions;

	// Token: 0x0200004D RID: 77
	public sealed class OnlinePresencePermissionsResult : MulticastDelegate
	{
		// Token: 0x0600019D RID: 413 RVA: 0x00004C20 File Offset: 0x00002E20
		public OnlinePresencePermissionsResult(object @object, IntPtr method)
		{
			this.method_ptr = method;
			this.m_target = @object;
			this.method = method;
			this.method_code = this;
		}

		// Token: 0x0600019E RID: 414 RVA: 0x00004C74 File Offset: 0x00002E74
		public void Invoke(string playerId, bool result)
		{
			IntPtr method_code = this.method_code;
			IntPtr invoke_impl = this.invoke_impl;
			IntPtr method = this.method;
		}

		// Token: 0x0600019F RID: 415 RVA: 0x000021DB File Offset: 0x000003DB
		public IAsyncResult BeginInvoke(string playerId, bool result, AsyncCallback callback, object @object)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x060001A0 RID: 416 RVA: 0x00004C98 File Offset: 0x00002E98
		public void EndInvoke(IAsyncResult result)
		{
		}
	}

	// Token: 0x0200004E RID: 78
	public class RequestResult
	{
		// Token: 0x060001A1 RID: 417 RVA: 0x00004CA8 File Offset: 0x00002EA8
		public void Clear()
		{
		}

		// Token: 0x14000004 RID: 4
		// (add) Token: 0x060001A2 RID: 418 RVA: 0x00004CB8 File Offset: 0x00002EB8
		// (remove) Token: 0x060001A3 RID: 419 RVA: 0x00004CDC File Offset: 0x00002EDC
		public event XBOOnlinePresencePermissions.OnlinePresencePermissionsResult ResultCallbacks
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

		// Token: 0x060001A4 RID: 420 RVA: 0x00004D00 File Offset: 0x00002F00
		public RequestResult()
		{
		}

		// Token: 0x0400011A RID: 282
		public string xboPlayerId;

		// Token: 0x0400011B RID: 283
		[CompilerGenerated]
		private XBOOnlinePresencePermissions.OnlinePresencePermissionsResult ResultCallbacks;
	}
}
