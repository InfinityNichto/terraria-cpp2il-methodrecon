using System;
using System.Runtime.Serialization;

namespace System.Globalization
{
	// Token: 0x02000584 RID: 1412
	[Serializable]
	public class CultureNotFoundException : ArgumentException
	{
		// Token: 0x06002A9F RID: 10911 RVA: 0x0005C904 File Offset: 0x0005AB04
		public CultureNotFoundException()
			: base("Culture is not supported.")
		{
		}

		// Token: 0x06002AA0 RID: 10912 RVA: 0x0005C91C File Offset: 0x0005AB1C
		public CultureNotFoundException(string paramName, string message)
			: base(message, paramName)
		{
		}

		// Token: 0x06002AA1 RID: 10913 RVA: 0x0005C934 File Offset: 0x0005AB34
		protected CultureNotFoundException(SerializationInfo info, StreamingContext context)
			: base(info, context)
		{
			if (!true)
			{
			}
			Type type;
			if (info.GetValue("InvalidCultureId", type) != null)
			{
			}
			Type type2;
			object value = info.GetValue("InvalidCultureName", type2);
			if (value != null)
			{
				this._invalidCultureName = value;
				return;
			}
		}

		// Token: 0x06002AA2 RID: 10914 RVA: 0x0005C978 File Offset: 0x0005AB78
		public override void GetObjectData(SerializationInfo info, StreamingContext context)
		{
			base.GetObjectData(info, context);
			int? invalidCultureId = this._invalidCultureId;
			string invalidCultureName = this._invalidCultureName;
			Type type;
			info.AddValue("InvalidCultureName", invalidCultureName, type);
		}

		// Token: 0x1700061B RID: 1563
		// (get) Token: 0x06002AA3 RID: 10915 RVA: 0x0005C9A8 File Offset: 0x0005ABA8
		public virtual int? InvalidCultureId
		{
			get
			{
				return this._invalidCultureId;
			}
		}

		// Token: 0x1700061C RID: 1564
		// (get) Token: 0x06002AA4 RID: 10916 RVA: 0x0005C9BC File Offset: 0x0005ABBC
		public virtual string InvalidCultureName
		{
			get
			{
				return this._invalidCultureName;
			}
		}

		// Token: 0x1700061D RID: 1565
		// (get) Token: 0x06002AA5 RID: 10917 RVA: 0x0005C9D0 File Offset: 0x0005ABD0
		private static string DefaultMessage
		{
			get
			{
				return "Culture is not supported.";
			}
		}

		// Token: 0x1700061E RID: 1566
		// (get) Token: 0x06002AA6 RID: 10918 RVA: 0x0005C9E4 File Offset: 0x0005ABE4
		private string FormatedInvalidCultureId
		{
			get
			{
				CultureInfo invariantCulture = CultureInfo.InvariantCulture;
				string text;
				return text;
			}
		}

		// Token: 0x1700061F RID: 1567
		// (get) Token: 0x06002AA7 RID: 10919 RVA: 0x0005C9FC File Offset: 0x0005ABFC
		public override string Message
		{
			get
			{
				string message = base.Message;
				string text;
				if (this._invalidCultureId != null || this._invalidCultureName != null)
				{
					string formatedInvalidCultureId = this.FormatedInvalidCultureId;
					text = SR.Format("{0} is an invalid culture identifier.", formatedInvalidCultureId);
					if (message != null)
					{
						string newLine = Environment.NewLine;
						return message + newLine + text;
					}
				}
				return text;
			}
		}

		// Token: 0x040016CD RID: 5837
		private string _invalidCultureName;

		// Token: 0x040016CE RID: 5838
		private int? _invalidCultureId;
	}
}
