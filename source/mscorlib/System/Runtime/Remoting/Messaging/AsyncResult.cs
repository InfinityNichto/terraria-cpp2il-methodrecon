using System;
using System.Runtime.InteropServices;
using System.Threading;
using Cpp2IlInjected;

namespace System.Runtime.Remoting.Messaging
{
	// Token: 0x0200039A RID: 922
	[ComVisible(true)]
	[StructLayout(0)]
	public class AsyncResult : IAsyncResult, IMessageSink, IThreadPoolWorkItem
	{
		// Token: 0x06001DA9 RID: 7593 RVA: 0x00040BC4 File Offset: 0x0003EDC4
		internal AsyncResult()
		{
		}

		// Token: 0x17000399 RID: 921
		// (get) Token: 0x06001DAA RID: 7594 RVA: 0x00040BD8 File Offset: 0x0003EDD8
		public virtual object AsyncState
		{
			get
			{
				return this.async_state;
			}
		}

		// Token: 0x1700039A RID: 922
		// (get) Token: 0x06001DAB RID: 7595 RVA: 0x00040BEC File Offset: 0x0003EDEC
		public virtual WaitHandle AsyncWaitHandle
		{
			get
			{
				if (this.handle != null)
				{
				}
				bool flag = this.completed;
				long num = 0L;
				Monitor.Exit(this);
				if (num == 0L)
				{
				}
				throw new OutOfMemoryException();
			}
		}

		// Token: 0x1700039B RID: 923
		// (get) Token: 0x06001DAC RID: 7596 RVA: 0x00040C34 File Offset: 0x0003EE34
		public virtual bool CompletedSynchronously
		{
			get
			{
				return this.sync_completed;
			}
		}

		// Token: 0x1700039C RID: 924
		// (get) Token: 0x06001DAD RID: 7597 RVA: 0x00040C48 File Offset: 0x0003EE48
		public virtual bool IsCompleted
		{
			get
			{
				return this.completed;
			}
		}

		// Token: 0x1700039D RID: 925
		// (get) Token: 0x06001DAE RID: 7598 RVA: 0x00040C5C File Offset: 0x0003EE5C
		// (set) Token: 0x06001DAF RID: 7599 RVA: 0x00040C70 File Offset: 0x0003EE70
		public bool EndInvokeCalled
		{
			get
			{
				return this.endinvoke_called;
			}
			set
			{
			}
		}

		// Token: 0x1700039E RID: 926
		// (get) Token: 0x06001DB0 RID: 7600 RVA: 0x00040C80 File Offset: 0x0003EE80
		public virtual object AsyncDelegate
		{
			get
			{
				return this.async_delegate;
			}
		}

		// Token: 0x1700039F RID: 927
		// (get) Token: 0x06001DB1 RID: 7601 RVA: 0x00040C94 File Offset: 0x0003EE94
		public IMessageSink NextSink
		{
			get
			{
			}
		}

		// Token: 0x06001DB2 RID: 7602 RVA: 0x0000207A File Offset: 0x0000027A
		public virtual IMessageCtrl AsyncProcessMessage(IMessage msg, IMessageSink replySink)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06001DB3 RID: 7603 RVA: 0x00040CA4 File Offset: 0x0003EEA4
		public virtual IMessage GetReplyMessage()
		{
			return this.reply_message;
		}

		// Token: 0x06001DB4 RID: 7604 RVA: 0x00040CB8 File Offset: 0x0003EEB8
		public virtual void SetMessageCtrl(IMessageCtrl mc)
		{
			this.message_ctrl = mc;
		}

		// Token: 0x06001DB5 RID: 7605 RVA: 0x00040CCC File Offset: 0x0003EECC
		internal void SetCompletedSynchronously(bool completed)
		{
		}

		// Token: 0x06001DB6 RID: 7606 RVA: 0x00040CDC File Offset: 0x0003EEDC
		internal IMessage EndInvoke()
		{
			bool flag = this.completed;
			if (flag)
			{
				IMessage message = this.reply_message;
			}
			long num = 0L;
			if (flag)
			{
				Monitor.Exit(this);
			}
			if (num == 0L)
			{
				return this.reply_message;
			}
			throw new OutOfMemoryException();
		}

		// Token: 0x06001DB7 RID: 7607 RVA: 0x00040D2C File Offset: 0x0003EF2C
		public virtual IMessage SyncProcessMessage(IMessage msg)
		{
			this.reply_message = msg;
			WaitHandle waitHandle = this.handle;
			this.completed = true;
			if (waitHandle == null || this != null)
			{
			}
			long num = 0L;
			Monitor.Exit(this);
			if (num == 0L)
			{
				if (3 != 0 || this.async_callback != null)
				{
				}
			}
			throw new OutOfMemoryException();
		}

		// Token: 0x170003A0 RID: 928
		// (get) Token: 0x06001DB8 RID: 7608 RVA: 0x00040D90 File Offset: 0x0003EF90
		// (set) Token: 0x06001DB9 RID: 7609 RVA: 0x00040DA4 File Offset: 0x0003EFA4
		internal MonoMethodMessage CallMessage
		{
			get
			{
				return this.call_message;
			}
			set
			{
				this.call_message = value;
			}
		}

		// Token: 0x06001DBA RID: 7610 RVA: 0x00040DB8 File Offset: 0x0003EFB8
		void IThreadPoolWorkItem.ExecuteWorkItem()
		{
		}

		// Token: 0x06001DBB RID: 7611 RVA: 0x00040DC8 File Offset: 0x0003EFC8
		void IThreadPoolWorkItem.MarkAborted(ThreadAbortException tae)
		{
		}

		// Token: 0x06001DBC RID: 7612 RVA: 0x0000207A File Offset: 0x0000027A
		internal object Invoke()
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x04000EF4 RID: 3828
		private object async_state;

		// Token: 0x04000EF5 RID: 3829
		private WaitHandle handle;

		// Token: 0x04000EF6 RID: 3830
		private object async_delegate;

		// Token: 0x04000EF7 RID: 3831
		private IntPtr data;

		// Token: 0x04000EF8 RID: 3832
		private object object_data;

		// Token: 0x04000EF9 RID: 3833
		private bool sync_completed;

		// Token: 0x04000EFA RID: 3834
		private bool completed;

		// Token: 0x04000EFB RID: 3835
		private bool endinvoke_called;

		// Token: 0x04000EFC RID: 3836
		private object async_callback;

		// Token: 0x04000EFD RID: 3837
		private ExecutionContext current;

		// Token: 0x04000EFE RID: 3838
		private ExecutionContext original;

		// Token: 0x04000EFF RID: 3839
		private long add_time;

		// Token: 0x04000F00 RID: 3840
		private MonoMethodMessage call_message;

		// Token: 0x04000F01 RID: 3841
		private IMessageCtrl message_ctrl;

		// Token: 0x04000F02 RID: 3842
		private IMessage reply_message;

		// Token: 0x04000F03 RID: 3843
		private WaitCallback orig_cb;
	}
}
