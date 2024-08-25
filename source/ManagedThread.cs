using System;
using System.Threading;

// Token: 0x02000065 RID: 101
public class ManagedThread
{
	// Token: 0x06000216 RID: 534 RVA: 0x00006104 File Offset: 0x00004304
	public ManagedThread(ParameterizedThreadStart callBack, object state)
	{
		this.ParameterizedThreadStartCallBack = callBack;
		this.ParameterizedThreadStartCallbackState = state;
	}

	// Token: 0x06000217 RID: 535 RVA: 0x00006128 File Offset: 0x00004328
	public ManagedThread(ThreadStart callBack)
	{
		this.ThreadStartCallBack = callBack;
	}

	// Token: 0x06000218 RID: 536 RVA: 0x00006144 File Offset: 0x00004344
	public void Run()
	{
		Thread activeThread = this.ActiveThread;
		this.IsAlive = true;
		activeThread.IsBackground = true;
		this.ActiveThread.Start();
	}

	// Token: 0x06000219 RID: 537 RVA: 0x00006174 File Offset: 0x00004374
	public void RunCritical()
	{
		Thread activeThread = this.ActiveThread;
		this.IsAlive = true;
		activeThread.Priority = ThreadPriority.Highest;
		this.ActiveThread.Start();
	}

	// Token: 0x0600021A RID: 538 RVA: 0x000061A4 File Offset: 0x000043A4
	private void ThreadExecute()
	{
		ParameterizedThreadStart parameterizedThreadStartCallBack = this.ParameterizedThreadStartCallBack;
		if (parameterizedThreadStartCallBack != null)
		{
			object parameterizedThreadStartCallbackState = this.ParameterizedThreadStartCallbackState;
			IntPtr method_code = parameterizedThreadStartCallBack.method_code;
			IntPtr invoke_impl = parameterizedThreadStartCallBack.invoke_impl;
			IntPtr method = parameterizedThreadStartCallBack.method;
			return;
		}
		ThreadStart threadStartCallBack = this.ThreadStartCallBack;
		if (threadStartCallBack != null)
		{
			IntPtr method_code2 = threadStartCallBack.method_code;
			IntPtr method2 = threadStartCallBack.method;
			IntPtr invoke_impl2 = threadStartCallBack.invoke_impl;
		}
	}

	// Token: 0x040001FA RID: 506
	private ParameterizedThreadStart ParameterizedThreadStartCallBack;

	// Token: 0x040001FB RID: 507
	private object ParameterizedThreadStartCallbackState;

	// Token: 0x040001FC RID: 508
	private ThreadStart ThreadStartCallBack;

	// Token: 0x040001FD RID: 509
	public LocalUser User;

	// Token: 0x040001FE RID: 510
	public Thread ActiveThread;

	// Token: 0x040001FF RID: 511
	public bool IsAlive;
}
