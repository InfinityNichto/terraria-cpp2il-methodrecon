using System;
using System.Runtime.InteropServices;

namespace System.Security.Permissions
{
	// Token: 0x020002AF RID: 687
	[ComVisible(true)]
	[AttributeUsage(AttributeTargets.Assembly | AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Constructor | AttributeTargets.Method, AllowMultiple = true, Inherited = false)]
	[Obsolete("CAS support is not available with Silverlight applications.")]
	[Serializable]
	public abstract class SecurityAttribute : Attribute
	{
		// Token: 0x0600175B RID: 5979 RVA: 0x000320C8 File Offset: 0x000302C8
		protected SecurityAttribute(SecurityAction action)
		{
			this.m_Action = action;
		}

		// Token: 0x0600175C RID: 5980
		public abstract IPermission CreatePermission();

		// Token: 0x1700025F RID: 607
		// (get) Token: 0x0600175D RID: 5981 RVA: 0x000320E4 File Offset: 0x000302E4
		public bool Unrestricted
		{
			get
			{
				return this.m_Unrestricted;
			}
		}

		// Token: 0x17000260 RID: 608
		// (set) Token: 0x0600175E RID: 5982 RVA: 0x000320F8 File Offset: 0x000302F8
		public SecurityAction Action
		{
			set
			{
				this.m_Action = value;
			}
		}

		// Token: 0x04000BFB RID: 3067
		private SecurityAction m_Action;

		// Token: 0x04000BFC RID: 3068
		private bool m_Unrestricted;
	}
}
