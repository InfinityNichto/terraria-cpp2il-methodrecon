using System;
using System.Runtime.Serialization;

namespace System.Net
{
	// Token: 0x020001C8 RID: 456
	[Serializable]
	public class WebException : InvalidOperationException, ISerializable
	{
		// Token: 0x06000AE7 RID: 2791 RVA: 0x00023FF0 File Offset: 0x000221F0
		public WebException()
		{
			this.m_Status = WebExceptionStatus.UnknownError;
			base..ctor();
		}

		// Token: 0x06000AE8 RID: 2792 RVA: 0x0002400C File Offset: 0x0002220C
		public WebException(string message)
		{
			this.m_Status = WebExceptionStatus.UnknownError;
		}

		// Token: 0x06000AE9 RID: 2793 RVA: 0x00024024 File Offset: 0x00022224
		public WebException(string message, Exception innerException)
		{
			this.m_Status = WebExceptionStatus.UnknownError;
			base..ctor(message, innerException);
		}

		// Token: 0x06000AEA RID: 2794 RVA: 0x00024044 File Offset: 0x00022244
		public WebException(string message, WebExceptionStatus status)
		{
		}

		// Token: 0x06000AEB RID: 2795 RVA: 0x00024054 File Offset: 0x00022254
		internal WebException(string message, WebExceptionStatus status, WebExceptionInternalStatus internalStatus, Exception innerException)
		{
		}

		// Token: 0x06000AEC RID: 2796 RVA: 0x00024064 File Offset: 0x00022264
		public WebException(string message, Exception innerException, WebExceptionStatus status, WebResponse response)
		{
		}

		// Token: 0x06000AED RID: 2797 RVA: 0x00024074 File Offset: 0x00022274
		internal WebException(string message, string data, Exception innerException, WebExceptionStatus status, WebResponse response)
		{
			this.m_Status = WebExceptionStatus.UnknownError;
			if (data != null)
			{
				string text = ": '" + data + "'";
				return;
			}
			string text2 = message + "";
			base..ctor(text2, innerException);
			this.m_Status = status;
			this.m_Response = response;
		}

		// Token: 0x06000AEE RID: 2798 RVA: 0x000240C4 File Offset: 0x000222C4
		internal WebException(string message, Exception innerException, WebExceptionStatus status, WebResponse response, WebExceptionInternalStatus internalStatus)
		{
		}

		// Token: 0x06000AEF RID: 2799 RVA: 0x000240D4 File Offset: 0x000222D4
		internal WebException(string message, string data, Exception innerException, WebExceptionStatus status, WebResponse response, WebExceptionInternalStatus internalStatus)
		{
			this.m_Status = WebExceptionStatus.UnknownError;
			if (data != null)
			{
				string text = ": '" + data + "'";
				return;
			}
			string text2 = message + "";
			base..ctor(text2, innerException);
			this.m_Status = status;
			this.m_Response = response;
			this.m_InternalStatus = internalStatus;
		}

		// Token: 0x06000AF0 RID: 2800 RVA: 0x0002412C File Offset: 0x0002232C
		protected WebException(SerializationInfo serializationInfo, StreamingContext streamingContext)
		{
			this.m_Status = WebExceptionStatus.UnknownError;
			base..ctor(serializationInfo, streamingContext);
		}

		// Token: 0x06000AF1 RID: 2801 RVA: 0x0002414C File Offset: 0x0002234C
		void ISerializable.GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext)
		{
		}

		// Token: 0x06000AF2 RID: 2802 RVA: 0x0002415C File Offset: 0x0002235C
		public override void GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext)
		{
			base.GetObjectData(serializationInfo, streamingContext);
		}

		// Token: 0x17000232 RID: 562
		// (get) Token: 0x06000AF3 RID: 2803 RVA: 0x00024174 File Offset: 0x00022374
		public WebExceptionStatus Status
		{
			get
			{
				return this.m_Status;
			}
		}

		// Token: 0x17000233 RID: 563
		// (get) Token: 0x06000AF4 RID: 2804 RVA: 0x00024188 File Offset: 0x00022388
		public WebResponse Response
		{
			get
			{
				return this.m_Response;
			}
		}

		// Token: 0x17000234 RID: 564
		// (get) Token: 0x06000AF5 RID: 2805 RVA: 0x0002419C File Offset: 0x0002239C
		internal WebExceptionInternalStatus InternalStatus
		{
			get
			{
				return this.m_InternalStatus;
			}
		}

		// Token: 0x04000995 RID: 2453
		private WebExceptionStatus m_Status;

		// Token: 0x04000996 RID: 2454
		private WebResponse m_Response;

		// Token: 0x04000997 RID: 2455
		[NonSerialized]
		private WebExceptionInternalStatus m_InternalStatus;
	}
}
