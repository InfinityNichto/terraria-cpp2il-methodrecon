using System;
using System.Runtime.Serialization;

namespace System.Runtime.CompilerServices
{
	// Token: 0x0200047D RID: 1149
	[Serializable]
	public sealed class RuntimeWrappedException : Exception
	{
		// Token: 0x06002223 RID: 8739 RVA: 0x0004CF5C File Offset: 0x0004B15C
		public RuntimeWrappedException(object thrownObject)
		{
			if (!true)
			{
			}
			base..ctor("An object that does not derive from System.Exception has been wrapped in a RuntimeWrappedException.");
			this._HResult = 5438;
			this._wrappedException = thrownObject;
		}

		// Token: 0x06002224 RID: 8740 RVA: 0x0004CF8C File Offset: 0x0004B18C
		private RuntimeWrappedException(SerializationInfo info, StreamingContext context)
		{
			if (!true)
			{
			}
			base..ctor(info, context);
			if (!true)
			{
			}
			Type type;
			object value = info.GetValue("WrappedException", type);
			this._wrappedException = value;
		}

		// Token: 0x06002225 RID: 8741 RVA: 0x0004CFBC File Offset: 0x0004B1BC
		public override void GetObjectData(SerializationInfo info, StreamingContext context)
		{
			base.GetObjectData(info, context);
			object wrappedException = this._wrappedException;
			if (!true)
			{
			}
			Type type;
			info.AddValue("WrappedException", wrappedException, type);
		}

		// Token: 0x06002226 RID: 8742 RVA: 0x0004CFE8 File Offset: 0x0004B1E8
		internal RuntimeWrappedException()
		{
			throw new NotSupportedException();
		}

		// Token: 0x040012B5 RID: 4789
		private object _wrappedException;
	}
}
