using System;
using System.Runtime.Serialization;

namespace System
{
	// Token: 0x02000085 RID: 133
	[Serializable]
	public class ArgumentOutOfRangeException : ArgumentException
	{
		// Token: 0x060003D2 RID: 978 RVA: 0x0000C00C File Offset: 0x0000A20C
		public ArgumentOutOfRangeException()
			: base("Specified argument was out of the range of valid values.")
		{
			this._HResult = 5378;
		}

		// Token: 0x060003D3 RID: 979 RVA: 0x0000C030 File Offset: 0x0000A230
		public ArgumentOutOfRangeException(string paramName)
			: base("Specified argument was out of the range of valid values.")
		{
			this._paramName = paramName;
			this._HResult = 5378;
		}

		// Token: 0x060003D4 RID: 980 RVA: 0x0000C05C File Offset: 0x0000A25C
		public ArgumentOutOfRangeException(string paramName, string message)
			: base(message)
		{
			this._paramName = paramName;
			this._HResult = 5378;
		}

		// Token: 0x060003D5 RID: 981 RVA: 0x0000C084 File Offset: 0x0000A284
		public ArgumentOutOfRangeException(string paramName, object actualValue, string message)
			: base(message)
		{
			this._paramName = paramName;
			this._actualValue = actualValue;
			this._HResult = 5378;
		}

		// Token: 0x060003D6 RID: 982 RVA: 0x0000C0B4 File Offset: 0x0000A2B4
		protected ArgumentOutOfRangeException(SerializationInfo info, StreamingContext context)
			: base(info, context)
		{
			if (!true)
			{
			}
			Type type;
			object value = info.GetValue("ActualValue", type);
			this._actualValue = value;
		}

		// Token: 0x060003D7 RID: 983 RVA: 0x0000C0E0 File Offset: 0x0000A2E0
		public override void GetObjectData(SerializationInfo info, StreamingContext context)
		{
			base.GetObjectData(info, context);
			object actualValue = this._actualValue;
			if (!true)
			{
			}
			Type type;
			info.AddValue("ActualValue", actualValue, type);
		}

		// Token: 0x17000059 RID: 89
		// (get) Token: 0x060003D8 RID: 984 RVA: 0x0000C10C File Offset: 0x0000A30C
		public override string Message
		{
			get
			{
				string message = base.Message;
				object actualValue = this._actualValue;
				string text;
				if (actualValue != null)
				{
					text = SR.Format("Actual value was {0}.", actualValue);
					if (message != null)
					{
						string newLine = Environment.NewLine;
						return message + newLine + text;
					}
				}
				return text;
			}
		}

		// Token: 0x040001DC RID: 476
		private object _actualValue;
	}
}
