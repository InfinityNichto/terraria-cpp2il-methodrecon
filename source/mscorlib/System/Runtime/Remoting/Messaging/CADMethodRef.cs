using System;
using System.Reflection;

namespace System.Runtime.Remoting.Messaging
{
	// Token: 0x0200039D RID: 925
	[Serializable]
	internal class CADMethodRef
	{
		// Token: 0x06001DBF RID: 7615 RVA: 0x00040E24 File Offset: 0x0003F024
		private Type[] GetTypes(string[] typeArray)
		{
			if (!true)
			{
			}
			throw new ArrayTypeMismatchException();
		}

		// Token: 0x06001DC0 RID: 7616 RVA: 0x00040E40 File Offset: 0x0003F040
		public MethodBase Resolve()
		{
			int num = 1;
			string text = this.typeName;
			if (num == 0)
			{
			}
			string[] array = this.param_names;
			if (this.ctor)
			{
			}
			string text2 = this.methodName;
			if (this.generic_arg_names != null)
			{
			}
			if (this.generic_arg_names != null)
			{
			}
			if (this.generic_arg_names != null)
			{
				string text3 = this.methodName;
				string[] array2 = this.generic_arg_names;
				string[] array3 = this.param_names;
				string[] array4 = this.param_names;
			}
			throw new ArrayTypeMismatchException();
		}

		// Token: 0x06001DC1 RID: 7617 RVA: 0x00040EE4 File Offset: 0x0003F0E4
		public CADMethodRef(IMethodMessage msg)
		{
		}

		// Token: 0x04000F08 RID: 3848
		private bool ctor;

		// Token: 0x04000F09 RID: 3849
		private string typeName;

		// Token: 0x04000F0A RID: 3850
		private string methodName;

		// Token: 0x04000F0B RID: 3851
		private string[] param_names;

		// Token: 0x04000F0C RID: 3852
		private string[] generic_arg_names;
	}
}
