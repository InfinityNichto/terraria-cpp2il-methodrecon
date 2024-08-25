using System;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;

// Token: 0x02000060 RID: 96
internal class SingletonCleanup
{
	// Token: 0x14000005 RID: 5
	// (add) Token: 0x06000200 RID: 512 RVA: 0x00005EAC File Offset: 0x000040AC
	// (remove) Token: 0x06000201 RID: 513 RVA: 0x00005EC4 File Offset: 0x000040C4
	public static event SingletonCleanup.CleanupSingletonCallback CleanUpEvent
	{
		[CompilerGenerated]
		add
		{
			Delegate @delegate;
			if (@delegate != null)
			{
			}
		}
		[CompilerGenerated]
		remove
		{
			Delegate @delegate;
			if (@delegate != null)
			{
			}
		}
	}

	// Token: 0x06000202 RID: 514 RVA: 0x00005EDC File Offset: 0x000040DC
	public static void Cleanup()
	{
	}

	// Token: 0x06000203 RID: 515 RVA: 0x00005EEC File Offset: 0x000040EC
	public SingletonCleanup()
	{
	}

	// Token: 0x040001F5 RID: 501
	[CompilerGenerated]
	private static SingletonCleanup.CleanupSingletonCallback CleanUpEvent;

	// Token: 0x02000061 RID: 97
	public sealed class CleanupSingletonCallback : MulticastDelegate
	{
		// Token: 0x06000204 RID: 516 RVA: 0x00005F00 File Offset: 0x00004100
		public CleanupSingletonCallback(object @object, IntPtr method)
		{
			this.method_ptr = method;
			this.m_target = @object;
			this.method = method;
			this.method_code = this;
		}

		// Token: 0x06000205 RID: 517 RVA: 0x00005F54 File Offset: 0x00004154
		public void Invoke()
		{
			IntPtr method_code = this.method_code;
			IntPtr invoke_impl = this.invoke_impl;
			IntPtr method = this.method;
		}

		// Token: 0x06000206 RID: 518 RVA: 0x000021DB File Offset: 0x000003DB
		public IAsyncResult BeginInvoke(AsyncCallback callback, object @object)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06000207 RID: 519 RVA: 0x00005F78 File Offset: 0x00004178
		public void EndInvoke(IAsyncResult result)
		{
		}
	}
}
