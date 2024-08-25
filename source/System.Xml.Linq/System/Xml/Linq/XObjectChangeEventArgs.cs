using System;

namespace System.Xml.Linq
{
	// Token: 0x0200001B RID: 27
	public class XObjectChangeEventArgs : EventArgs
	{
		// Token: 0x060000BC RID: 188 RVA: 0x00003B58 File Offset: 0x00001D58
		public XObjectChangeEventArgs(XObjectChange objectChange)
		{
			if (!true)
			{
			}
			base..ctor();
		}

		// Token: 0x060000BD RID: 189 RVA: 0x00003B70 File Offset: 0x00001D70
		// Note: this type is marked as 'beforefieldinit'.
		static XObjectChangeEventArgs()
		{
		}

		// Token: 0x04000045 RID: 69
		private XObjectChange _objectChange;

		// Token: 0x04000046 RID: 70
		public static readonly XObjectChangeEventArgs Add;

		// Token: 0x04000047 RID: 71
		public static readonly XObjectChangeEventArgs Remove;

		// Token: 0x04000048 RID: 72
		public static readonly XObjectChangeEventArgs Name;

		// Token: 0x04000049 RID: 73
		public static readonly XObjectChangeEventArgs Value;
	}
}
