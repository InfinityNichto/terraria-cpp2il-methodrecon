using System;
using UnityEngine.Scripting;

namespace UnityEngine.Serialization
{
	// Token: 0x02000127 RID: 295
	[RequiredByNativeCode]
	[AttributeUsage(AttributeTargets.Field, AllowMultiple = true, Inherited = false)]
	public class FormerlySerializedAsAttribute : Attribute
	{
		// Token: 0x060005E6 RID: 1510 RVA: 0x0000A7E4 File Offset: 0x000089E4
		public FormerlySerializedAsAttribute(string oldName)
		{
			this.m_oldName = oldName;
		}

		// Token: 0x040004E9 RID: 1257
		private string m_oldName;
	}
}
