using System;

namespace System.Net
{
	// Token: 0x02000187 RID: 391
	public class Authorization
	{
		// Token: 0x06000A11 RID: 2577 RVA: 0x000222AC File Offset: 0x000204AC
		public Authorization(string token)
		{
			if (!true)
			{
			}
			string text = ValidationHelper.MakeStringNull(token);
			this.m_Message = text;
			this.m_Complete = true;
		}

		// Token: 0x06000A12 RID: 2578 RVA: 0x000222D8 File Offset: 0x000204D8
		public Authorization(string token, bool finished)
		{
			if (!true)
			{
			}
			string text = ValidationHelper.MakeStringNull(token);
			this.m_Message = text;
		}

		// Token: 0x06000A13 RID: 2579 RVA: 0x000222FC File Offset: 0x000204FC
		public Authorization(string token, bool finished, string connectionGroupId)
		{
		}

		// Token: 0x06000A14 RID: 2580 RVA: 0x0002230C File Offset: 0x0002050C
		internal Authorization(string token, bool finished, string connectionGroupId, bool mutualAuth)
		{
			if (!true)
			{
			}
			string text = ValidationHelper.MakeStringNull(token);
			this.m_Message = text;
			string text2 = ValidationHelper.MakeStringNull(connectionGroupId);
			this.m_ConnectionGroupId = text2;
		}

		// Token: 0x17000207 RID: 519
		// (get) Token: 0x06000A15 RID: 2581 RVA: 0x00022340 File Offset: 0x00020540
		public string Message
		{
			get
			{
				return this.m_Message;
			}
		}

		// Token: 0x17000208 RID: 520
		// (get) Token: 0x06000A16 RID: 2582 RVA: 0x00022354 File Offset: 0x00020554
		public string ConnectionGroupId
		{
			get
			{
				return this.m_ConnectionGroupId;
			}
		}

		// Token: 0x17000209 RID: 521
		// (get) Token: 0x06000A17 RID: 2583 RVA: 0x00022368 File Offset: 0x00020568
		public bool Complete
		{
			get
			{
				return this.m_Complete;
			}
		}

		// Token: 0x06000A18 RID: 2584 RVA: 0x0002237C File Offset: 0x0002057C
		internal void SetComplete(bool complete)
		{
		}

		// Token: 0x1700020A RID: 522
		// (get) Token: 0x06000A19 RID: 2585 RVA: 0x0002238C File Offset: 0x0002058C
		// (set) Token: 0x06000A1A RID: 2586 RVA: 0x000223A0 File Offset: 0x000205A0
		public string[] ProtectionRealm
		{
			get
			{
				return this.m_ProtectionRealm;
			}
			set
			{
				if (!true)
				{
				}
				string[] array = ValidationHelper.MakeEmptyArrayNull(value);
				this.m_ProtectionRealm = array;
			}
		}

		// Token: 0x1700020B RID: 523
		// (get) Token: 0x06000A1B RID: 2587 RVA: 0x000223C0 File Offset: 0x000205C0
		// (set) Token: 0x06000A1C RID: 2588 RVA: 0x000223E0 File Offset: 0x000205E0
		public bool MutuallyAuthenticated
		{
			get
			{
				if (this.m_Complete)
				{
					bool mutualAuth = this.m_MutualAuth;
					return;
				}
			}
			set
			{
			}
		}

		// Token: 0x040007B0 RID: 1968
		private string m_Message;

		// Token: 0x040007B1 RID: 1969
		private bool m_Complete;

		// Token: 0x040007B2 RID: 1970
		private string[] m_ProtectionRealm;

		// Token: 0x040007B3 RID: 1971
		private string m_ConnectionGroupId;

		// Token: 0x040007B4 RID: 1972
		private bool m_MutualAuth;

		// Token: 0x040007B5 RID: 1973
		internal string ModuleAuthenticationType;
	}
}
