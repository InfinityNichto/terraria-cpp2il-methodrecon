using System;
using System.IO;
using Cpp2IlInjected;

// Token: 0x020002C9 RID: 713
public class SaveSynchronisationOperation
{
	// Token: 0x0600107E RID: 4222 RVA: 0x00050BF8 File Offset: 0x0004EDF8
	public SaveSynchronisationOperation(SaveSynchronisationOperation.SendDataFunction sendOperation)
	{
		this.SendData = sendOperation;
	}

	// Token: 0x0600107F RID: 4223 RVA: 0x00050C14 File Offset: 0x0004EE14
	public virtual void Begin()
	{
	}

	// Token: 0x06001080 RID: 4224 RVA: 0x00050C24 File Offset: 0x0004EE24
	public void SendEmptyMessage(SaveSynchronisationOperation.MessageId id)
	{
		if (!true)
		{
		}
		SaveSynchronisationOperation.SendDataFunction sendData = this.SendData;
		IntPtr invoke_impl = sendData.invoke_impl;
		IntPtr method_code = sendData.method_code;
		IntPtr method = sendData.method;
	}

	// Token: 0x06001081 RID: 4225 RVA: 0x00050C50 File Offset: 0x0004EE50
	public static void WriteMessageHeader(BinaryWriter packet, SaveSynchronisationOperation.MessageId id)
	{
	}

	// Token: 0x06001082 RID: 4226 RVA: 0x00050C60 File Offset: 0x0004EE60
	public static void WriteMessageLength(BinaryWriter packet)
	{
	}

	// Token: 0x06001083 RID: 4227 RVA: 0x00050C70 File Offset: 0x0004EE70
	public virtual void ProcessMessage(SaveSynchronisationOperation.MessageId messageId, byte[] data)
	{
	}

	// Token: 0x06001084 RID: 4228 RVA: 0x00050C80 File Offset: 0x0004EE80
	public virtual void Cancel()
	{
	}

	// Token: 0x06001085 RID: 4229 RVA: 0x000021DB File Offset: 0x000003DB
	public virtual string GetStatus()
	{
		throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
	}

	// Token: 0x06001086 RID: 4230 RVA: 0x00050C90 File Offset: 0x0004EE90
	// Note: this type is marked as 'beforefieldinit'.
	static SaveSynchronisationOperation()
	{
	}

	// Token: 0x04001F60 RID: 8032
	protected readonly SaveSynchronisationOperation.SendDataFunction SendData;

	// Token: 0x04001F61 RID: 8033
	private static byte[] emptyMessageData;

	// Token: 0x04001F62 RID: 8034
	public bool IsComplete;

	// Token: 0x020002CA RID: 714
	public enum MessageId
	{
		// Token: 0x04001F64 RID: 8036
		BeginFileList,
		// Token: 0x04001F65 RID: 8037
		PlayerFileEntry,
		// Token: 0x04001F66 RID: 8038
		WorldFileEntry,
		// Token: 0x04001F67 RID: 8039
		FileEntryReceived,
		// Token: 0x04001F68 RID: 8040
		EndFileList,
		// Token: 0x04001F69 RID: 8041
		RequestFileData,
		// Token: 0x04001F6A RID: 8042
		BeginFileData,
		// Token: 0x04001F6B RID: 8043
		FileData,
		// Token: 0x04001F6C RID: 8044
		FileDataRecieved
	}

	// Token: 0x020002CB RID: 715
	public sealed class SendDataFunction : MulticastDelegate
	{
		// Token: 0x06001087 RID: 4231 RVA: 0x00050CA0 File Offset: 0x0004EEA0
		public SendDataFunction(object @object, IntPtr method)
		{
			this.method_ptr = method;
			this.m_target = @object;
			this.method = method;
			this.method_code = this;
		}

		// Token: 0x06001088 RID: 4232 RVA: 0x00050CF4 File Offset: 0x0004EEF4
		public void Invoke(byte[] messageData, int length)
		{
			IntPtr method_code = this.method_code;
			IntPtr invoke_impl = this.invoke_impl;
			IntPtr method = this.method;
		}

		// Token: 0x06001089 RID: 4233 RVA: 0x000021DB File Offset: 0x000003DB
		public IAsyncResult BeginInvoke(byte[] messageData, int length, AsyncCallback callback, object @object)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x0600108A RID: 4234 RVA: 0x00050D18 File Offset: 0x0004EF18
		public void EndInvoke(IAsyncResult result)
		{
		}
	}
}
