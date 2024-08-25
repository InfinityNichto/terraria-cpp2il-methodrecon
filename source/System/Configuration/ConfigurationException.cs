using System;
using System.Runtime.Serialization;
using System.Xml;

namespace System.Configuration
{
	// Token: 0x02000451 RID: 1105
	[Serializable]
	public class ConfigurationException : SystemException
	{
		// Token: 0x06001DF5 RID: 7669 RVA: 0x00050204 File Offset: 0x0004E404
		[Obsolete("This class is obsolete, to create a new exception create a System.Configuration!System.Configuration.ConfigurationErrorsException")]
		public ConfigurationException()
		{
			throw new NotSupportedException();
		}

		// Token: 0x06001DF6 RID: 7670 RVA: 0x00050218 File Offset: 0x0004E418
		protected ConfigurationException(SerializationInfo info, StreamingContext context)
		{
			throw new NotSupportedException();
		}

		// Token: 0x06001DF7 RID: 7671 RVA: 0x0005022C File Offset: 0x0004E42C
		[Obsolete("This class is obsolete, to create a new exception create a System.Configuration!System.Configuration.ConfigurationErrorsException")]
		public ConfigurationException(string message)
		{
			throw new NotSupportedException();
		}

		// Token: 0x06001DF8 RID: 7672 RVA: 0x00050240 File Offset: 0x0004E440
		[Obsolete("This class is obsolete, to create a new exception create a System.Configuration!System.Configuration.ConfigurationErrorsException")]
		public ConfigurationException(string message, Exception inner)
		{
			throw new NotSupportedException();
		}

		// Token: 0x06001DF9 RID: 7673 RVA: 0x00050254 File Offset: 0x0004E454
		[Obsolete("This class is obsolete, to create a new exception create a System.Configuration!System.Configuration.ConfigurationErrorsException")]
		public ConfigurationException(string message, Exception inner, string filename, int line)
		{
			throw new NotSupportedException();
		}

		// Token: 0x06001DFA RID: 7674 RVA: 0x00050268 File Offset: 0x0004E468
		[Obsolete("This class is obsolete, to create a new exception create a System.Configuration!System.Configuration.ConfigurationErrorsException")]
		public ConfigurationException(string message, Exception inner, XmlNode node)
		{
			throw new NotSupportedException();
		}

		// Token: 0x06001DFB RID: 7675 RVA: 0x0005027C File Offset: 0x0004E47C
		[Obsolete("This class is obsolete, to create a new exception create a System.Configuration!System.Configuration.ConfigurationErrorsException")]
		public ConfigurationException(string message, string filename, int line)
		{
			throw new NotSupportedException();
		}

		// Token: 0x06001DFC RID: 7676 RVA: 0x00050290 File Offset: 0x0004E490
		[Obsolete("This class is obsolete, to create a new exception create a System.Configuration!System.Configuration.ConfigurationErrorsException")]
		public ConfigurationException(string message, XmlNode node)
		{
			throw new NotSupportedException();
		}

		// Token: 0x170006BC RID: 1724
		// (get) Token: 0x06001DFD RID: 7677 RVA: 0x000502A4 File Offset: 0x0004E4A4
		public virtual string BareMessage
		{
			get
			{
				throw new NotSupportedException();
			}
		}

		// Token: 0x170006BD RID: 1725
		// (get) Token: 0x06001DFE RID: 7678 RVA: 0x000502B8 File Offset: 0x0004E4B8
		public virtual string Filename
		{
			get
			{
				throw new NotSupportedException();
			}
		}

		// Token: 0x170006BE RID: 1726
		// (get) Token: 0x06001DFF RID: 7679 RVA: 0x000502CC File Offset: 0x0004E4CC
		public virtual int Line
		{
			get
			{
				throw new NotSupportedException();
			}
		}

		// Token: 0x06001E00 RID: 7680 RVA: 0x000502E0 File Offset: 0x0004E4E0
		[Obsolete("This class is obsolete, use System.Configuration!System.Configuration.ConfigurationErrorsException.GetFilename instead")]
		public static string GetXmlNodeFilename(XmlNode node)
		{
			throw new NotSupportedException();
		}

		// Token: 0x06001E01 RID: 7681 RVA: 0x000502F4 File Offset: 0x0004E4F4
		[Obsolete("This class is obsolete, use System.Configuration!System.Configuration.ConfigurationErrorsException.GetLinenumber instead")]
		public static int GetXmlNodeLineNumber(XmlNode node)
		{
			throw new NotSupportedException();
		}
	}
}
