using System;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;

namespace System.ComponentModel
{
	// Token: 0x020003C7 RID: 967
	[Serializable]
	public class WarningException : SystemException
	{
		// Token: 0x060019B1 RID: 6577 RVA: 0x00047848 File Offset: 0x00045A48
		public WarningException()
		{
		}

		// Token: 0x060019B2 RID: 6578 RVA: 0x00047858 File Offset: 0x00045A58
		public WarningException(string message)
			: base(message)
		{
		}

		// Token: 0x060019B3 RID: 6579 RVA: 0x0004786C File Offset: 0x00045A6C
		public WarningException(string message, string helpUrl)
			: base(message)
		{
			this.HelpUrl = helpUrl;
		}

		// Token: 0x060019B4 RID: 6580 RVA: 0x00047888 File Offset: 0x00045A88
		public WarningException(string message, Exception innerException)
			: base(message, innerException)
		{
		}

		// Token: 0x060019B5 RID: 6581 RVA: 0x000478A0 File Offset: 0x00045AA0
		public WarningException(string message, string helpUrl, string helpTopic)
			: base(message)
		{
			this.HelpUrl = helpUrl;
			this.HelpTopic = helpTopic;
		}

		// Token: 0x060019B6 RID: 6582 RVA: 0x000478C4 File Offset: 0x00045AC4
		protected WarningException(SerializationInfo info, StreamingContext context)
			: base(info, context)
		{
			if (!true)
			{
			}
			Type type;
			object value = info.GetValue("helpUrl", type);
			if (value != null)
			{
				this.HelpUrl = value;
				return;
			}
			Type type2;
			object value2 = info.GetValue("helpTopic", type2);
			if (value2 != null)
			{
				this.HelpTopic = value2;
				throw new InvalidCastException();
			}
		}

		// Token: 0x170005DA RID: 1498
		// (get) Token: 0x060019B7 RID: 6583 RVA: 0x00047914 File Offset: 0x00045B14
		public string HelpUrl
		{
			[CompilerGenerated]
			get
			{
				return this.<HelpUrl>k__BackingField;
			}
		}

		// Token: 0x170005DB RID: 1499
		// (get) Token: 0x060019B8 RID: 6584 RVA: 0x00047928 File Offset: 0x00045B28
		public string HelpTopic
		{
			[CompilerGenerated]
			get
			{
				return this.<HelpTopic>k__BackingField;
			}
		}

		// Token: 0x060019B9 RID: 6585 RVA: 0x0004793C File Offset: 0x00045B3C
		public override void GetObjectData(SerializationInfo info, StreamingContext context)
		{
			base.GetObjectData(info, context);
			string text = this.<HelpUrl>k__BackingField;
			info.AddValue("helpUrl", text);
			string text2 = this.<HelpTopic>k__BackingField;
			info.AddValue("helpTopic", text2);
		}

		// Token: 0x040012DA RID: 4826
		[CompilerGenerated]
		private readonly string <HelpUrl>k__BackingField;

		// Token: 0x040012DB RID: 4827
		[CompilerGenerated]
		private readonly string <HelpTopic>k__BackingField;
	}
}
