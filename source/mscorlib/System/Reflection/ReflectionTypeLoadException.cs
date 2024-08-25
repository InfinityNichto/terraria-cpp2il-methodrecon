using System;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;

namespace System.Reflection
{
	// Token: 0x020004E9 RID: 1257
	[Serializable]
	public sealed class ReflectionTypeLoadException : SystemException, ISerializable
	{
		// Token: 0x0600242C RID: 9260 RVA: 0x00050E4C File Offset: 0x0004F04C
		public ReflectionTypeLoadException(Type[] classes, Exception[] exceptions)
		{
			this.<Types>k__BackingField = classes;
			this.LoaderExceptions = exceptions;
			this._HResult = 5634;
		}

		// Token: 0x0600242D RID: 9261 RVA: 0x00050E74 File Offset: 0x0004F074
		private ReflectionTypeLoadException(SerializationInfo info, StreamingContext context)
			: base(info, context)
		{
			if (!true)
			{
			}
			Type type;
			object value = info.GetValue("Exceptions", type);
			if (value != null)
			{
				if (value == null)
				{
					throw new InvalidCastException();
				}
				this.LoaderExceptions = value;
				if (value == null)
				{
					throw new InvalidCastException();
				}
			}
		}

		// Token: 0x0600242E RID: 9262 RVA: 0x00050EB8 File Offset: 0x0004F0B8
		public override void GetObjectData(SerializationInfo info, StreamingContext context)
		{
			base.GetObjectData(info, context);
			if (!true)
			{
			}
			long num = 0L;
			Type type;
			info.AddValue("Types", num, type);
			Exception[] array = this.<LoaderExceptions>k__BackingField;
			Type type2;
			info.AddValue("Exceptions", array, type2);
		}

		// Token: 0x170004D1 RID: 1233
		// (get) Token: 0x0600242F RID: 9263 RVA: 0x00050EF4 File Offset: 0x0004F0F4
		public Exception[] LoaderExceptions
		{
			[CompilerGenerated]
			get
			{
				return this.<LoaderExceptions>k__BackingField;
			}
		}

		// Token: 0x170004D2 RID: 1234
		// (get) Token: 0x06002430 RID: 9264 RVA: 0x00050F08 File Offset: 0x0004F108
		public override string Message
		{
			get
			{
				return this.CreateString(true);
			}
		}

		// Token: 0x06002431 RID: 9265 RVA: 0x00050F1C File Offset: 0x0004F11C
		public override string ToString()
		{
			long num = 0L;
			return this.CreateString(num != 0L);
		}

		// Token: 0x06002432 RID: 9266 RVA: 0x00050F34 File Offset: 0x0004F134
		private string CreateString(bool isMessage)
		{
			return base.Message;
		}

		// Token: 0x04001412 RID: 5138
		[CompilerGenerated]
		private readonly Type[] <Types>k__BackingField;

		// Token: 0x04001413 RID: 5139
		[CompilerGenerated]
		private readonly Exception[] <LoaderExceptions>k__BackingField;
	}
}
