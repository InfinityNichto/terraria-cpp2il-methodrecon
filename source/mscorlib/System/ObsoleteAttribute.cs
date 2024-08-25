using System;

namespace System
{
	// Token: 0x020000E9 RID: 233
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Enum | AttributeTargets.Constructor | AttributeTargets.Method | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Interface | AttributeTargets.Delegate, Inherited = false)]
	[Serializable]
	public sealed class ObsoleteAttribute : Attribute
	{
		// Token: 0x060008BF RID: 2239 RVA: 0x00015680 File Offset: 0x00013880
		public ObsoleteAttribute()
		{
		}

		// Token: 0x060008C0 RID: 2240 RVA: 0x00015694 File Offset: 0x00013894
		public ObsoleteAttribute(string message)
		{
			this._message = message;
		}

		// Token: 0x060008C1 RID: 2241 RVA: 0x000156B0 File Offset: 0x000138B0
		public ObsoleteAttribute(string message, bool error)
		{
			this._message = message;
		}

		// Token: 0x17000099 RID: 153
		// (get) Token: 0x060008C2 RID: 2242 RVA: 0x000156CC File Offset: 0x000138CC
		public string Message
		{
			get
			{
				return this._message;
			}
		}

		// Token: 0x0400037F RID: 895
		private string _message;

		// Token: 0x04000380 RID: 896
		private bool _error;
	}
}
