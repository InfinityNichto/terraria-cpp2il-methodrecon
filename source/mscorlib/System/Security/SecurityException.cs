using System;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace System.Security
{
	// Token: 0x0200029C RID: 668
	[ComVisible(true)]
	[Serializable]
	public class SecurityException : SystemException
	{
		// Token: 0x0600171A RID: 5914 RVA: 0x00030C8C File Offset: 0x0002EE8C
		public SecurityException()
		{
			string text = Locale.GetText("A security error has been detected.");
			base..ctor(text);
			this._HResult = 5386;
		}

		// Token: 0x0600171B RID: 5915 RVA: 0x00030CB8 File Offset: 0x0002EEB8
		public SecurityException(string message)
			: base(message)
		{
			this._HResult = 5386;
		}

		// Token: 0x0600171C RID: 5916 RVA: 0x00030CD8 File Offset: 0x0002EED8
		protected SecurityException(SerializationInfo info, StreamingContext context)
			: base(info, context)
		{
			this._HResult = 5386;
			SerializationInfoEnumerator enumerator = info.GetEnumerator();
			bool flag = enumerator.MoveNext();
			bool flag2 = enumerator.Name == "PermissionState";
			object value = enumerator.Value;
			if (value != null)
			{
				this.permissionState = value;
				throw new InvalidCastException();
			}
		}

		// Token: 0x0600171D RID: 5917 RVA: 0x00030D30 File Offset: 0x0002EF30
		public SecurityException(string message, Exception inner)
			: base(message, inner)
		{
			this._HResult = 5386;
		}

		// Token: 0x0600171E RID: 5918 RVA: 0x00030D50 File Offset: 0x0002EF50
		public override void GetObjectData(SerializationInfo info, StreamingContext context)
		{
			base.GetObjectData(info, context);
			string text = this.permissionState;
			info.AddValue("PermissionState", text);
		}

		// Token: 0x0600171F RID: 5919 RVA: 0x00030D7C File Offset: 0x0002EF7C
		public override string ToString()
		{
			return base.ToString();
		}

		// Token: 0x04000BB1 RID: 2993
		private string permissionState;
	}
}
