using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Threading;
using Cpp2IlInjected;
using Terraria;
using UnityEngine;

// Token: 0x0200005B RID: 91
public class MainThreadExecution
{
	// Token: 0x060001E5 RID: 485 RVA: 0x00005A4C File Offset: 0x00003C4C
	public static void ExcludeThread(ManagedThread thread)
	{
		if (!true)
		{
		}
	}

	// Token: 0x060001E6 RID: 486 RVA: 0x00005A60 File Offset: 0x00003C60
	public static void ExecuteOnMainThread(MainThreadExecution.ExecutionSnippet snippet, object data)
	{
		if (!true)
		{
		}
		Thread currentThread = Thread.CurrentThread;
		Debug.LogError("Execute main on bad thread!");
	}

	// Token: 0x060001E7 RID: 487 RVA: 0x00005A88 File Offset: 0x00003C88
	public static void ExecuteSnippetsOnly()
	{
		if (!true)
		{
		}
	}

	// Token: 0x060001E8 RID: 488 RVA: 0x00005A9C File Offset: 0x00003C9C
	public static void ExecuteSnippets()
	{
		if (!true)
		{
		}
		MainThreadExecution.ExecuteSnippetsOnly();
		if (!true)
		{
		}
		WorldGen.ExecuteThreadTime();
	}

	// Token: 0x060001E9 RID: 489 RVA: 0x00005ABC File Offset: 0x00003CBC
	public MainThreadExecution(MainThreadExecution.ExecutionSnippet snippet, object data)
	{
		this._snippet = snippet;
		this._data = data;
	}

	// Token: 0x060001EA RID: 490 RVA: 0x00005AE0 File Offset: 0x00003CE0
	public void Execute()
	{
		MainThreadExecution.ExecutionSnippet snippet = this._snippet;
		object data = this._data;
		IntPtr invoke_impl = snippet.invoke_impl;
		IntPtr method_code = snippet.method_code;
		IntPtr method = snippet.method;
		object lockObject = this._lockObject;
		long num = 0L;
		this._completed = true;
		if (true)
		{
			Monitor.Exit(lockObject);
		}
		if (num == 0L)
		{
			return;
		}
		throw new OutOfMemoryException();
	}

	// Token: 0x060001EB RID: 491 RVA: 0x00005B58 File Offset: 0x00003D58
	public void WaitOnMainThreadComplete()
	{
		long num = 0L;
		long num2 = 0L;
		Thread.Sleep((int)num);
		object lockObject = this._lockObject;
		Monitor.Enter(lockObject, num2 != 0L);
		bool completed = this._completed;
		long num3 = 0L;
		if (completed)
		{
			Monitor.Exit(lockObject);
		}
		if (num3 == 0L)
		{
			return;
		}
		throw new OutOfMemoryException();
	}

	// Token: 0x060001EC RID: 492 RVA: 0x00005BBC File Offset: 0x00003DBC
	// Note: this type is marked as 'beforefieldinit'.
	static MainThreadExecution()
	{
	}

	// Token: 0x040001DE RID: 478
	private static List<ManagedThread> ExcludedThreads;

	// Token: 0x040001DF RID: 479
	private static ConcurrentQueue<MainThreadExecution> _pendingRequests;

	// Token: 0x040001E0 RID: 480
	private object _lockObject;

	// Token: 0x040001E1 RID: 481
	private MainThreadExecution.ExecutionSnippet _snippet;

	// Token: 0x040001E2 RID: 482
	private object _data;

	// Token: 0x040001E3 RID: 483
	private bool _completed;

	// Token: 0x0200005C RID: 92
	public sealed class ExecutionSnippet : MulticastDelegate
	{
		// Token: 0x060001ED RID: 493 RVA: 0x00005BCC File Offset: 0x00003DCC
		public ExecutionSnippet(object @object, IntPtr method)
		{
			this.method_ptr = method;
			this.m_target = @object;
			this.method = method;
			this.method_code = this;
		}

		// Token: 0x060001EE RID: 494 RVA: 0x00005C2C File Offset: 0x00003E2C
		public void Invoke(object data)
		{
			IntPtr method_code = this.method_code;
			IntPtr invoke_impl = this.invoke_impl;
			IntPtr method = this.method;
		}

		// Token: 0x060001EF RID: 495 RVA: 0x000021DB File Offset: 0x000003DB
		public IAsyncResult BeginInvoke(object data, AsyncCallback callback, object @object)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x060001F0 RID: 496 RVA: 0x00005C50 File Offset: 0x00003E50
		public void EndInvoke(IAsyncResult result)
		{
		}
	}
}
