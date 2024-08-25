using System;

namespace System.Runtime.Remoting
{
	// Token: 0x02000353 RID: 851
	[Serializable]
	internal class TypeInfo : IRemotingTypeInfo
	{
		// Token: 0x06001C7B RID: 7291 RVA: 0x0003DEEC File Offset: 0x0003C0EC
		public TypeInfo(Type type)
		{
			int num = 1;
			base..ctor();
			bool isInterface = type.IsInterface;
			if (num == 0)
			{
			}
			Type type2;
			this.serverType = type2;
			string[] array = this.interfacesImplemented;
			if (type == null || type != null)
			{
				return;
			}
			throw new ArrayTypeMismatchException();
		}

		// Token: 0x17000347 RID: 839
		// (get) Token: 0x06001C7C RID: 7292 RVA: 0x0003DF48 File Offset: 0x0003C148
		public string TypeName
		{
			get
			{
				return this.serverType;
			}
		}

		// Token: 0x06001C7D RID: 7293 RVA: 0x0003DF5C File Offset: 0x0003C15C
		public bool CanCastTo(Type fromType, object o)
		{
			if (!true)
			{
			}
			Type type;
			bool flag = fromType == type;
			Type type2;
			bool flag2 = fromType == type2;
			string text;
			bool flag3 = (this.serverType + ",").StartsWith(text);
			if (this.serverHierarchy != null)
			{
				string text2;
				bool flag4 = text2.StartsWith(text);
			}
			if (this.interfacesImplemented != null)
			{
				string text3;
				bool flag5 = text3.StartsWith(text);
				return;
			}
		}

		// Token: 0x04000E6E RID: 3694
		private string serverType;

		// Token: 0x04000E6F RID: 3695
		private string[] serverHierarchy;

		// Token: 0x04000E70 RID: 3696
		private string[] interfacesImplemented;
	}
}
