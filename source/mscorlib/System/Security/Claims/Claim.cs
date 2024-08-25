using System;
using System.Collections.Generic;
using System.Globalization;
using System.Runtime.Serialization;
using System.Threading;
using Cpp2IlInjected;

namespace System.Security.Claims
{
	// Token: 0x0200032D RID: 813
	[Serializable]
	public class Claim
	{
		// Token: 0x06001B70 RID: 7024 RVA: 0x0003ADF8 File Offset: 0x00038FF8
		public Claim(string type, string value, string valueType, string issuer, string originalIssuer, ClaimsIdentity subject)
		{
		}

		// Token: 0x06001B71 RID: 7025 RVA: 0x0003AE08 File Offset: 0x00039008
		internal Claim(string type, string value, string valueType, string issuer, string originalIssuer, ClaimsIdentity subject, string propertyKey, string propertyValue)
		{
			do
			{
				base..ctor();
				if (type == null)
				{
					return;
				}
			}
			while (value == null);
			this.m_type = type;
			this.m_value = value;
			bool flag = string.IsNullOrEmpty(valueType);
			this.m_valueType = "http://www.w3.org/2001/XMLSchema#string";
		}

		// Token: 0x06001B72 RID: 7026 RVA: 0x0003AEA0 File Offset: 0x000390A0
		protected Claim(Claim other, ClaimsIdentity subject)
		{
			if (other == null)
			{
				return;
			}
			string issuer = other.m_issuer;
			this.m_subject = subject;
			this.m_issuer = issuer;
			string type = other.m_type;
			this.m_type = type;
			string valueType = other.m_valueType;
			this.m_valueType = valueType;
			if (other.m_properties != null)
			{
				Dictionary<string, string> properties = other.m_properties;
				Dictionary<string, string> properties2 = this.m_properties;
				Dictionary<string, string> properties3 = other.m_properties;
				return;
			}
			if (other.m_userSerializationData != null)
			{
				object obj;
				this.m_userSerializationData = obj;
			}
		}

		// Token: 0x06001B73 RID: 7027 RVA: 0x0003AF2C File Offset: 0x0003912C
		[OnDeserialized]
		private void OnDeserializedMethod(StreamingContext context)
		{
		}

		// Token: 0x17000316 RID: 790
		// (get) Token: 0x06001B74 RID: 7028 RVA: 0x0003AF3C File Offset: 0x0003913C
		public IDictionary<string, string> Properties
		{
			get
			{
				if (this.m_properties == null)
				{
					object propertyLock = this.m_propertyLock;
					if (this.m_properties != null)
					{
					}
					long num = 0L;
					Monitor.Exit(propertyLock);
					if (num == 0L)
					{
						Dictionary<string, string> properties = this.m_properties;
					}
				}
				throw new OutOfMemoryException();
			}
		}

		// Token: 0x17000317 RID: 791
		// (get) Token: 0x06001B75 RID: 7029 RVA: 0x0003AF94 File Offset: 0x00039194
		// (set) Token: 0x06001B76 RID: 7030 RVA: 0x0003AFA8 File Offset: 0x000391A8
		public ClaimsIdentity Subject
		{
			get
			{
				return this.m_subject;
			}
			internal set
			{
				this.m_subject = value;
			}
		}

		// Token: 0x17000318 RID: 792
		// (get) Token: 0x06001B77 RID: 7031 RVA: 0x0003AFBC File Offset: 0x000391BC
		public string Type
		{
			get
			{
				return this.m_type;
			}
		}

		// Token: 0x17000319 RID: 793
		// (get) Token: 0x06001B78 RID: 7032 RVA: 0x0003AFD0 File Offset: 0x000391D0
		public string Value
		{
			get
			{
				return this.m_value;
			}
		}

		// Token: 0x06001B79 RID: 7033 RVA: 0x0000207A File Offset: 0x0000027A
		public virtual Claim Clone(ClaimsIdentity identity)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06001B7A RID: 7034 RVA: 0x0003AFE4 File Offset: 0x000391E4
		public override string ToString()
		{
			if (!true)
			{
			}
			CultureInfo invariantCulture = CultureInfo.InvariantCulture;
			string type = this.m_type;
			string value = this.m_value;
			return string.Format(invariantCulture, "{0}: {1}", type, value);
		}

		// Token: 0x04000DF7 RID: 3575
		private string m_issuer;

		// Token: 0x04000DF8 RID: 3576
		private string m_originalIssuer;

		// Token: 0x04000DF9 RID: 3577
		private string m_type;

		// Token: 0x04000DFA RID: 3578
		private string m_value;

		// Token: 0x04000DFB RID: 3579
		private string m_valueType;

		// Token: 0x04000DFC RID: 3580
		[NonSerialized]
		private byte[] m_userSerializationData;

		// Token: 0x04000DFD RID: 3581
		private Dictionary<string, string> m_properties;

		// Token: 0x04000DFE RID: 3582
		[NonSerialized]
		private object m_propertyLock;

		// Token: 0x04000DFF RID: 3583
		[NonSerialized]
		private ClaimsIdentity m_subject;
	}
}
