using System;
using System.Collections;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Metadata;
using Cpp2IlInjected;

namespace System.Runtime.Remoting
{
	// Token: 0x02000350 RID: 848
	[ComVisible(true)]
	public class SoapServices
	{
		// Token: 0x17000342 RID: 834
		// (get) Token: 0x06001C65 RID: 7269 RVA: 0x0003DC6C File Offset: 0x0003BE6C
		public static string XmlNsForClrTypeWithAssembly
		{
			get
			{
				return "http://schemas.microsoft.com/clr/assem/";
			}
		}

		// Token: 0x17000343 RID: 835
		// (get) Token: 0x06001C66 RID: 7270 RVA: 0x0003DC80 File Offset: 0x0003BE80
		public static string XmlNsForClrTypeWithNs
		{
			get
			{
				return "http://schemas.microsoft.com/clr/ns/";
			}
		}

		// Token: 0x17000344 RID: 836
		// (get) Token: 0x06001C67 RID: 7271 RVA: 0x0003DC94 File Offset: 0x0003BE94
		public static string XmlNsForClrTypeWithNsAndAssembly
		{
			get
			{
				return "http://schemas.microsoft.com/clr/nsassem/";
			}
		}

		// Token: 0x06001C68 RID: 7272 RVA: 0x0003DCA8 File Offset: 0x0003BEA8
		public static string CodeXmlNamespaceForClrTypeNamespace(string typeNamespace, string assemblyName)
		{
			string text;
			return text;
		}

		// Token: 0x06001C69 RID: 7273 RVA: 0x0003DCCC File Offset: 0x0003BECC
		private static string GetNameKey(string name, string namspace)
		{
			string text;
			if (name != null)
			{
				text = " " + " " + name;
				return text;
			}
			return text;
		}

		// Token: 0x06001C6A RID: 7274 RVA: 0x0000207A File Offset: 0x0000027A
		private static string GetAssemblyName(MethodBase mb)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06001C6B RID: 7275 RVA: 0x0003DCF0 File Offset: 0x0003BEF0
		public static bool GetXmlElementForInteropType(Type type, [Out] string xmlElement, [Out] string xmlNamespace)
		{
			if (!true)
			{
			}
			SoapAttribute soapAttribute;
			if (soapAttribute != null)
			{
			}
			return true;
		}

		// Token: 0x06001C6C RID: 7276 RVA: 0x0003DD0C File Offset: 0x0003BF0C
		public static string GetXmlNamespaceForMethodCall(MethodBase mb)
		{
			string text;
			return text;
		}

		// Token: 0x06001C6D RID: 7277 RVA: 0x0003DD1C File Offset: 0x0003BF1C
		public static string GetXmlNamespaceForMethodResponse(MethodBase mb)
		{
			string text;
			return text;
		}

		// Token: 0x06001C6E RID: 7278 RVA: 0x0003DD2C File Offset: 0x0003BF2C
		public static bool GetXmlTypeForInteropType(Type type, [Out] string xmlType, [Out] string xmlTypeNamespace)
		{
			if (!true)
			{
			}
			SoapAttribute soapAttribute;
			if (soapAttribute != null)
			{
			}
			return true;
		}

		// Token: 0x06001C6F RID: 7279 RVA: 0x0003DD4C File Offset: 0x0003BF4C
		public static void PreLoad(Assembly assembly)
		{
		}

		// Token: 0x06001C70 RID: 7280 RVA: 0x0003DD5C File Offset: 0x0003BF5C
		public static void PreLoad(Type type)
		{
			if (!true)
			{
			}
			SoapAttribute soapAttribute;
			if (soapAttribute != null)
			{
			}
			if (soapAttribute == null)
			{
			}
		}

		// Token: 0x06001C71 RID: 7281 RVA: 0x0003DDB0 File Offset: 0x0003BFB0
		public static void RegisterInteropXmlElement(string xmlElement, string xmlNamespace, Type type)
		{
			if (!true)
			{
			}
			string text = xmlElement + " " + xmlNamespace;
			if (!false)
			{
				return;
			}
			throw new OutOfMemoryException();
		}

		// Token: 0x06001C72 RID: 7282 RVA: 0x0003DDF0 File Offset: 0x0003BFF0
		public static void RegisterInteropXmlType(string xmlType, string xmlTypeNamespace, Type type)
		{
			if (!true)
			{
			}
			if (!true)
			{
			}
			string text = xmlType + " " + xmlTypeNamespace;
			long num = 0L;
			if (true)
			{
			}
			if (num == 0L)
			{
				return;
			}
			throw new OutOfMemoryException();
		}

		// Token: 0x06001C73 RID: 7283 RVA: 0x0003DE38 File Offset: 0x0003C038
		private static string EncodeNs(string ns)
		{
			string text;
			return text.Replace(" ", "%20").Replace("=", "%3D");
		}

		// Token: 0x06001C74 RID: 7284 RVA: 0x0003DE64 File Offset: 0x0003C064
		// Note: this type is marked as 'beforefieldinit'.
		static SoapServices()
		{
		}

		// Token: 0x04000E65 RID: 3685
		private static Hashtable _xmlTypes;

		// Token: 0x04000E66 RID: 3686
		private static Hashtable _xmlElements;

		// Token: 0x04000E67 RID: 3687
		private static Hashtable _soapActions;

		// Token: 0x04000E68 RID: 3688
		private static Hashtable _soapActionsMethods;

		// Token: 0x04000E69 RID: 3689
		private static Hashtable _typeInfos;

		// Token: 0x02000351 RID: 849
		private class TypeInfo
		{
			// Token: 0x06001C75 RID: 7285 RVA: 0x0003DE74 File Offset: 0x0003C074
			public TypeInfo()
			{
			}

			// Token: 0x04000E6A RID: 3690
			public Hashtable Attributes;

			// Token: 0x04000E6B RID: 3691
			public Hashtable Elements;
		}
	}
}
