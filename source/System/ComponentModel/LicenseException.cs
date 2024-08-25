using System;
using System.Runtime.Serialization;

namespace System.ComponentModel
{
	// Token: 0x020003E5 RID: 997
	[Serializable]
	public class LicenseException : SystemException
	{
		// Token: 0x06001A53 RID: 6739 RVA: 0x00048D30 File Offset: 0x00046F30
		public LicenseException(Type type)
		{
			if (type == null || type != null)
			{
				string text;
				base..ctor(text);
				this.type = type;
				this._HResult = 6401;
				return;
			}
			throw new ArrayTypeMismatchException();
		}

		// Token: 0x06001A54 RID: 6740 RVA: 0x00048D64 File Offset: 0x00046F64
		public LicenseException(Type type, object instance)
		{
			if (type == null || type != null)
			{
				Type type2 = instance.GetType();
				if (type2 == null || type2 != null)
				{
					string text;
					base..ctor(text);
					this.type = type;
					this._HResult = 6401;
					return;
				}
			}
			throw new ArrayTypeMismatchException();
		}

		// Token: 0x06001A55 RID: 6741 RVA: 0x00048DA4 File Offset: 0x00046FA4
		public LicenseException(Type type, object instance, string message)
			: base(message)
		{
			this.type = type;
			this.instance = instance;
			this._HResult = 6401;
		}

		// Token: 0x06001A56 RID: 6742 RVA: 0x00048DD4 File Offset: 0x00046FD4
		public LicenseException(Type type, object instance, string message, Exception innerException)
			: base(message, innerException)
		{
			this.type = type;
			this.instance = instance;
			this._HResult = 6401;
		}

		// Token: 0x06001A57 RID: 6743 RVA: 0x00048E04 File Offset: 0x00047004
		protected LicenseException(SerializationInfo info, StreamingContext context)
		{
			int num = 1;
			base..ctor(info, context);
			if (num == 0)
			{
			}
			Type type;
			object value = info.GetValue("type", type);
			if (value != null)
			{
				this.type = value;
				throw new InvalidCastException();
			}
			Type type2;
			object value2 = info.GetValue("instance", type2);
			this.instance = value2;
		}

		// Token: 0x1700060B RID: 1547
		// (get) Token: 0x06001A58 RID: 6744 RVA: 0x00048E54 File Offset: 0x00047054
		public Type LicensedType
		{
			get
			{
				return this.type;
			}
		}

		// Token: 0x06001A59 RID: 6745 RVA: 0x00048E68 File Offset: 0x00047068
		public override void GetObjectData(SerializationInfo info, StreamingContext context)
		{
			while (info == null)
			{
			}
			Type type = this.type;
			info.AddValue("type", type);
			object obj = this.instance;
			info.AddValue("instance", obj);
			base.GetObjectData(info, context);
		}

		// Token: 0x0400130B RID: 4875
		private Type type;

		// Token: 0x0400130C RID: 4876
		private object instance;
	}
}
