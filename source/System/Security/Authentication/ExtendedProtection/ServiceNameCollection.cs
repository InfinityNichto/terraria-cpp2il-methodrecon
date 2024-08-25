using System;
using System.Collections;
using Cpp2IlInjected;

namespace System.Security.Authentication.ExtendedProtection
{
	// Token: 0x020000E6 RID: 230
	[Serializable]
	public class ServiceNameCollection : ReadOnlyCollectionBase
	{
		// Token: 0x0600053E RID: 1342 RVA: 0x00014F74 File Offset: 0x00013174
		public ServiceNameCollection(ICollection items)
		{
			if (items != null)
			{
				return;
			}
			throw new OutOfMemoryException();
		}

		// Token: 0x0600053F RID: 1343 RVA: 0x00014FC0 File Offset: 0x000131C0
		private static void AddIfNew(ArrayList newServiceNames, string serviceName)
		{
			bool flag = string.IsNullOrEmpty(serviceName);
			bool flag2 = ServiceNameCollection.Contains(ServiceNameCollection.NormalizeServiceName(serviceName), newServiceNames);
		}

		// Token: 0x06000540 RID: 1344 RVA: 0x00014FF0 File Offset: 0x000131F0
		internal static bool Contains(string searchServiceName, ICollection serviceNames)
		{
			if (searchServiceName != null)
			{
			}
			int num;
			while (num != 0)
			{
			}
			long num2 = 0L;
			if (searchServiceName != null)
			{
			}
			if (num2 == 0L)
			{
				throw new InvalidCastException();
			}
			throw new OutOfMemoryException();
		}

		// Token: 0x06000541 RID: 1345 RVA: 0x00015028 File Offset: 0x00013228
		internal static string NormalizeServiceName(string inputServiceName)
		{
			bool flag = string.IsNullOrWhiteSpace("{0}{1}{2}{3}");
			long num = 0L;
			string text2;
			string text = text2.Substring((int)num);
			bool flag2 = string.IsNullOrWhiteSpace(text);
			if (global::System.Uri.CheckHostName(text) != global::System.UriHostNameType.Unknown)
			{
			}
			int num2 = 47;
			int num3 = text.IndexOf((char)num2);
			long num4 = 0L;
			string text3 = text.Substring((int)num4, num3);
			return text.Substring(num3);
		}

		// Token: 0x06000542 RID: 1346 RVA: 0x00002050 File Offset: 0x00000250
		internal static bool Match(string serviceName1, string serviceName2)
		{
			throw new global::Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}
	}
}
