using System;

namespace System.Xml
{
	// Token: 0x0200007A RID: 122
	public class XmlNodeChangedEventArgs : EventArgs
	{
		// Token: 0x060005F6 RID: 1526 RVA: 0x00014498 File Offset: 0x00012698
		public XmlNodeChangedEventArgs(XmlNode node, XmlNode oldParent, XmlNode newParent, string oldValue, string newValue, XmlNodeChangedAction action)
		{
			if (!true)
			{
			}
			base..ctor();
			this.node = node;
			this.oldParent = oldParent;
			this.action = action;
			this.newParent = newParent;
			this.oldValue = oldValue;
			this.newValue = newValue;
		}

		// Token: 0x1700018C RID: 396
		// (get) Token: 0x060005F7 RID: 1527 RVA: 0x000144DC File Offset: 0x000126DC
		public XmlNodeChangedAction Action
		{
			get
			{
				return this.action;
			}
		}

		// Token: 0x040002F3 RID: 755
		private XmlNodeChangedAction action;

		// Token: 0x040002F4 RID: 756
		private XmlNode node;

		// Token: 0x040002F5 RID: 757
		private XmlNode oldParent;

		// Token: 0x040002F6 RID: 758
		private XmlNode newParent;

		// Token: 0x040002F7 RID: 759
		private string oldValue;

		// Token: 0x040002F8 RID: 760
		private string newValue;
	}
}
