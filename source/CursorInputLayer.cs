using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;

// Token: 0x02000014 RID: 20
public class CursorInputLayer
{
	// Token: 0x06000056 RID: 86 RVA: 0x000028E0 File Offset: 0x00000AE0
	public CursorInputLayer()
	{
		int num = 1;
		base..ctor();
		if (num == 0)
		{
		}
	}

	// Token: 0x06000057 RID: 87 RVA: 0x000028FC File Offset: 0x00000AFC
	protected override void Finalize()
	{
		if (!true)
		{
		}
		base.Finalize();
	}

	// Token: 0x06000058 RID: 88 RVA: 0x00002938 File Offset: 0x00000B38
	public void UpdateCursor(Cursor cursor)
	{
		CursorInputLayer.CursorUpdater updateCallback = this.UpdateCallback;
		if (updateCallback != null)
		{
			IntPtr invoke_impl = updateCallback.invoke_impl;
			IntPtr method_code = updateCallback.method_code;
			IntPtr method = updateCallback.method;
			return;
		}
	}

	// Token: 0x06000059 RID: 89 RVA: 0x00002968 File Offset: 0x00000B68
	public void Postupdate(List<Cursor> cursors)
	{
		CursorInputLayer.CursorPostUpdate postUpdateCallback = this.PostUpdateCallback;
		if (postUpdateCallback != null)
		{
			IntPtr invoke_impl = postUpdateCallback.invoke_impl;
			IntPtr method_code = postUpdateCallback.method_code;
			IntPtr method = postUpdateCallback.method;
			return;
		}
	}

	// Token: 0x1700001F RID: 31
	// (get) Token: 0x0600005A RID: 90 RVA: 0x00002998 File Offset: 0x00000B98
	// (set) Token: 0x0600005B RID: 91 RVA: 0x000029AC File Offset: 0x00000BAC
	public int Priority
	{
		get
		{
			return this._priority;
		}
		set
		{
			this._priority = value;
			if (!true)
			{
			}
		}
	}

	// Token: 0x0600005C RID: 92 RVA: 0x000029C4 File Offset: 0x00000BC4
	public static void Resort()
	{
		if (!true)
		{
		}
	}

	// Token: 0x17000020 RID: 32
	// (get) Token: 0x0600005D RID: 93 RVA: 0x000021DB File Offset: 0x000003DB
	public static List<CursorInputLayer> Layers
	{
		get
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}
	}

	// Token: 0x0600005E RID: 94 RVA: 0x000029D4 File Offset: 0x00000BD4
	// Note: this type is marked as 'beforefieldinit'.
	static CursorInputLayer()
	{
	}

	// Token: 0x04000046 RID: 70
	public CursorInputLayer.CursorUpdater UpdateCallback;

	// Token: 0x04000047 RID: 71
	public CursorInputLayer.CursorPostUpdate PostUpdateCallback;

	// Token: 0x04000048 RID: 72
	private int _priority;

	// Token: 0x04000049 RID: 73
	public static bool Dirty;

	// Token: 0x02000015 RID: 21
	public sealed class CursorUpdater : MulticastDelegate
	{
		// Token: 0x0600005F RID: 95 RVA: 0x000029E4 File Offset: 0x00000BE4
		public CursorUpdater(object @object, IntPtr method)
		{
			this.method_ptr = method;
			this.m_target = @object;
			this.method = method;
			this.method_code = this;
		}

		// Token: 0x06000060 RID: 96 RVA: 0x00002A44 File Offset: 0x00000C44
		public void Invoke(Cursor cursor)
		{
			IntPtr method_code = this.method_code;
			IntPtr invoke_impl = this.invoke_impl;
			IntPtr method = this.method;
		}

		// Token: 0x06000061 RID: 97 RVA: 0x000021DB File Offset: 0x000003DB
		public IAsyncResult BeginInvoke(Cursor cursor, AsyncCallback callback, object @object)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06000062 RID: 98 RVA: 0x00002A68 File Offset: 0x00000C68
		public void EndInvoke(IAsyncResult result)
		{
		}
	}

	// Token: 0x02000016 RID: 22
	public sealed class CursorPostUpdate : MulticastDelegate
	{
		// Token: 0x06000063 RID: 99 RVA: 0x00002A78 File Offset: 0x00000C78
		public CursorPostUpdate(object @object, IntPtr method)
		{
			this.method_ptr = method;
			this.m_target = @object;
			this.method = method;
			this.method_code = this;
		}

		// Token: 0x06000064 RID: 100 RVA: 0x00002AD8 File Offset: 0x00000CD8
		public void Invoke(List<Cursor> cursors)
		{
			IntPtr method_code = this.method_code;
			IntPtr invoke_impl = this.invoke_impl;
			IntPtr method = this.method;
		}

		// Token: 0x06000065 RID: 101 RVA: 0x000021DB File Offset: 0x000003DB
		public IAsyncResult BeginInvoke(List<Cursor> cursors, AsyncCallback callback, object @object)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06000066 RID: 102 RVA: 0x00002AFC File Offset: 0x00000CFC
		public void EndInvoke(IAsyncResult result)
		{
		}
	}

	// Token: 0x02000017 RID: 23
	[CompilerGenerated]
	[Serializable]
	private sealed class <>c
	{
		// Token: 0x06000067 RID: 103 RVA: 0x00002B0C File Offset: 0x00000D0C
		// Note: this type is marked as 'beforefieldinit'.
		static <>c()
		{
		}

		// Token: 0x06000068 RID: 104 RVA: 0x00002B1C File Offset: 0x00000D1C
		public <>c()
		{
		}

		// Token: 0x06000069 RID: 105 RVA: 0x00002B30 File Offset: 0x00000D30
		internal int <Resort>b__9_0(CursorInputLayer layer1, CursorInputLayer layer2)
		{
			int priority = layer1._priority;
			int num;
			return num;
		}

		// Token: 0x0400004A RID: 74
		public static readonly CursorInputLayer.<>c <>9;

		// Token: 0x0400004B RID: 75
		public static Comparison<CursorInputLayer> <>9__9_0;
	}
}
