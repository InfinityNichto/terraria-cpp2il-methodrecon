using System;
using Cpp2IlInjected;

namespace System.Xml.Linq
{
	// Token: 0x02000017 RID: 23
	public sealed class XNamespace
	{
		// Token: 0x0600009A RID: 154 RVA: 0x000037B0 File Offset: 0x000019B0
		internal XNamespace(string namespaceName)
		{
			this._namespaceName = namespaceName;
			this._hashCode = namespaceName;
		}

		// Token: 0x1700001F RID: 31
		// (get) Token: 0x0600009B RID: 155 RVA: 0x000037D4 File Offset: 0x000019D4
		public string NamespaceName
		{
			get
			{
				return this._namespaceName;
			}
		}

		// Token: 0x0600009C RID: 156 RVA: 0x000037E8 File Offset: 0x000019E8
		public XName GetName(string localName)
		{
			while (localName == null)
			{
			}
			int stringLength = localName._stringLength;
			long num = 0L;
			return this.GetName(localName, (int)num, stringLength);
		}

		// Token: 0x0600009D RID: 157 RVA: 0x0000380C File Offset: 0x00001A0C
		public override string ToString()
		{
			return this._namespaceName;
		}

		// Token: 0x17000020 RID: 32
		// (get) Token: 0x0600009E RID: 158 RVA: 0x00003820 File Offset: 0x00001A20
		public static XNamespace None
		{
			get
			{
				XNamespace xnamespace;
				return xnamespace;
			}
		}

		// Token: 0x17000021 RID: 33
		// (get) Token: 0x0600009F RID: 159 RVA: 0x00003830 File Offset: 0x00001A30
		public static XNamespace Xml
		{
			get
			{
				XNamespace xnamespace;
				return xnamespace;
			}
		}

		// Token: 0x17000022 RID: 34
		// (get) Token: 0x060000A0 RID: 160 RVA: 0x00003840 File Offset: 0x00001A40
		public static XNamespace Xmlns
		{
			get
			{
				XNamespace xnamespace;
				return xnamespace;
			}
		}

		// Token: 0x060000A1 RID: 161 RVA: 0x00003850 File Offset: 0x00001A50
		public static XNamespace Get(string namespaceName)
		{
			XNamespace xnamespace;
			return xnamespace;
		}

		// Token: 0x060000A2 RID: 162 RVA: 0x00003860 File Offset: 0x00001A60
		[CLSCompliant(false)]
		public static implicit operator XNamespace(string namespaceName)
		{
			XNamespace xnamespace;
			return xnamespace;
		}

		// Token: 0x060000A3 RID: 163 RVA: 0x00002367 File Offset: 0x00000567
		public override bool Equals(object obj)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x060000A4 RID: 164 RVA: 0x00003870 File Offset: 0x00001A70
		public override int GetHashCode()
		{
			return this._hashCode;
		}

		// Token: 0x060000A5 RID: 165 RVA: 0x00002367 File Offset: 0x00000567
		public static bool operator ==(XNamespace left, XNamespace right)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x060000A6 RID: 166 RVA: 0x00002367 File Offset: 0x00000567
		public static bool operator !=(XNamespace left, XNamespace right)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x060000A7 RID: 167 RVA: 0x00003884 File Offset: 0x00001A84
		internal XName GetName(string localName, int index, int count)
		{
			XHashtable<XName> names = this._names;
			XHashtable<XName> names2 = this._names;
			string text = localName.Substring(index, count);
			XName xname;
			return xname;
		}

		// Token: 0x060000A8 RID: 168 RVA: 0x000038AC File Offset: 0x00001AAC
		internal static XNamespace Get(string namespaceName, int index, int count)
		{
			if (index != 0)
			{
				bool flag;
				if (flag)
				{
					goto IL_0012;
				}
				int num;
				if (num == 0)
				{
					return XNamespace.Xml;
				}
				int num2;
				if (num2 == 0)
				{
					return XNamespace.Xmlns;
				}
				!0 !;
				if (! != null)
				{
					goto IL_0012;
				}
				IL_0016:
				while (! == null)
				{
				}
				goto IL_001A;
				IL_0012:
				if (! != null)
				{
					goto IL_0016;
				}
				goto IL_0016;
			}
			IL_001A:
			return XNamespace.None;
		}

		// Token: 0x060000A9 RID: 169 RVA: 0x00002367 File Offset: 0x00000567
		private static string ExtractLocalName(XName n)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x060000AA RID: 170 RVA: 0x000038EC File Offset: 0x00001AEC
		private static string ExtractNamespace(WeakReference r)
		{
			throw new InvalidCastException();
		}

		// Token: 0x060000AB RID: 171 RVA: 0x00003900 File Offset: 0x00001B00
		private static XNamespace EnsureNamespace(WeakReference refNmsp, string namespaceName)
		{
			throw new InvalidCastException();
		}

		// Token: 0x04000039 RID: 57
		private static XHashtable<WeakReference> s_namespaces;

		// Token: 0x0400003A RID: 58
		private static WeakReference s_refNone;

		// Token: 0x0400003B RID: 59
		private static WeakReference s_refXml;

		// Token: 0x0400003C RID: 60
		private static WeakReference s_refXmlns;

		// Token: 0x0400003D RID: 61
		private string _namespaceName;

		// Token: 0x0400003E RID: 62
		private int _hashCode;

		// Token: 0x0400003F RID: 63
		private XHashtable<XName> _names;
	}
}
