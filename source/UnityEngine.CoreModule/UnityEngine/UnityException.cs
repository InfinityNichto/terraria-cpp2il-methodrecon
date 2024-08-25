using System;
using System.Runtime.Serialization;
using UnityEngine.Scripting;

namespace UnityEngine
{
	// Token: 0x020000AD RID: 173
	[RequiredByNativeCode]
	[Serializable]
	public class UnityException : Exception
	{
		// Token: 0x0600031A RID: 794 RVA: 0x00006830 File Offset: 0x00004A30
		public UnityException()
		{
			if (!true)
			{
			}
			base..ctor("A Unity Runtime error occurred!");
			this._HResult = 16387;
		}

		// Token: 0x0600031B RID: 795 RVA: 0x00006858 File Offset: 0x00004A58
		public UnityException(string message)
		{
			if (!true)
			{
			}
			base..ctor(message);
			this._HResult = 16387;
		}

		// Token: 0x0600031C RID: 796 RVA: 0x0000687C File Offset: 0x00004A7C
		protected UnityException(SerializationInfo info, StreamingContext context)
		{
			if (!true)
			{
			}
			base..ctor(info, context);
		}
	}
}
