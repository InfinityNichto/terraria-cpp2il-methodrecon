using System;
using System.Runtime.Serialization;
using Cpp2IlInjected;

namespace System.Xml.Linq
{
	// Token: 0x02000016 RID: 22
	[Serializable]
	public sealed class XName : IEquatable<XName>, ISerializable
	{
		// Token: 0x0600008C RID: 140 RVA: 0x00003680 File Offset: 0x00001880
		internal XName(XNamespace ns, string localName)
		{
			this._ns = ns;
			if (!true)
			{
			}
			string text = XmlConvert.VerifyNCName(localName);
			this._localName = text;
		}

		// Token: 0x1700001C RID: 28
		// (get) Token: 0x0600008D RID: 141 RVA: 0x000036AC File Offset: 0x000018AC
		public string LocalName
		{
			get
			{
				return this._localName;
			}
		}

		// Token: 0x1700001D RID: 29
		// (get) Token: 0x0600008E RID: 142 RVA: 0x000036C0 File Offset: 0x000018C0
		public XNamespace Namespace
		{
			get
			{
				return this._ns;
			}
		}

		// Token: 0x1700001E RID: 30
		// (get) Token: 0x0600008F RID: 143 RVA: 0x000036D4 File Offset: 0x000018D4
		public string NamespaceName
		{
			get
			{
				return this._ns._namespaceName;
			}
		}

		// Token: 0x06000090 RID: 144 RVA: 0x000036EC File Offset: 0x000018EC
		public override string ToString()
		{
			XNamespace ns = this._ns;
			string localName = this._localName;
			string namespaceName = ns._namespaceName;
			if (namespaceName._stringLength != 0)
			{
				return "{" + namespaceName + "}" + localName;
			}
			return localName;
		}

		// Token: 0x06000091 RID: 145 RVA: 0x0000372C File Offset: 0x0000192C
		public static XName Get(string expandedName)
		{
			XName xname;
			return xname;
		}

		// Token: 0x06000092 RID: 146 RVA: 0x0000375C File Offset: 0x0000195C
		public static XName Get(string localName, string namespaceName)
		{
			return XNamespace.Get(localName).GetName(localName);
		}

		// Token: 0x06000093 RID: 147 RVA: 0x00003778 File Offset: 0x00001978
		[CLSCompliant(false)]
		public static implicit operator XName(string expandedName)
		{
			XName xname;
			return xname;
		}

		// Token: 0x06000094 RID: 148 RVA: 0x00002367 File Offset: 0x00000567
		public override bool Equals(object obj)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06000095 RID: 149 RVA: 0x00003788 File Offset: 0x00001988
		public override int GetHashCode()
		{
			return this._hashCode;
		}

		// Token: 0x06000096 RID: 150 RVA: 0x00002367 File Offset: 0x00000567
		public static bool operator ==(XName left, XName right)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06000097 RID: 151 RVA: 0x00002367 File Offset: 0x00000567
		bool IEquatable<XName>.Equals(XName other)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06000098 RID: 152 RVA: 0x00002367 File Offset: 0x00000567
		void ISerializable.GetObjectData(SerializationInfo info, StreamingContext context)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06000099 RID: 153 RVA: 0x0000379C File Offset: 0x0000199C
		internal XName()
		{
			throw new NotSupportedException();
		}

		// Token: 0x04000036 RID: 54
		private XNamespace _ns;

		// Token: 0x04000037 RID: 55
		private string _localName;

		// Token: 0x04000038 RID: 56
		private int _hashCode;
	}
}
