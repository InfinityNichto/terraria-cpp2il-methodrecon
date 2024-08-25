using System;
using System.Globalization;
using System.Runtime.Serialization;

namespace System.ComponentModel
{
	// Token: 0x02000341 RID: 833
	[Serializable]
	public class InvalidEnumArgumentException : ArgumentException
	{
		// Token: 0x060015AD RID: 5549 RVA: 0x00040684 File Offset: 0x0003E884
		public InvalidEnumArgumentException()
		{
		}

		// Token: 0x060015AE RID: 5550 RVA: 0x00040694 File Offset: 0x0003E894
		public InvalidEnumArgumentException(string message)
			: base(message)
		{
		}

		// Token: 0x060015AF RID: 5551 RVA: 0x000406A8 File Offset: 0x0003E8A8
		public InvalidEnumArgumentException(string message, Exception innerException)
			: base(message, innerException)
		{
		}

		// Token: 0x060015B0 RID: 5552 RVA: 0x000406C0 File Offset: 0x0003E8C0
		public InvalidEnumArgumentException(string argumentName, int invalidValue, Type enumClass)
		{
			if (!true)
			{
			}
			CultureInfo currentCulture = CultureInfo.CurrentCulture;
			string text2;
			string text = SR.Format("The value of argument '{0}' ({1}) is invalid for Enum type '{2}'.", argumentName, text2, enumClass);
			base..ctor(text, argumentName);
		}

		// Token: 0x060015B1 RID: 5553 RVA: 0x000406F0 File Offset: 0x0003E8F0
		protected InvalidEnumArgumentException(SerializationInfo info, StreamingContext context)
			: base(info, context)
		{
		}
	}
}
