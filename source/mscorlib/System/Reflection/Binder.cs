using System;
using System.Globalization;
using System.Runtime.InteropServices;

namespace System.Reflection
{
	// Token: 0x020004C9 RID: 1225
	public abstract class Binder
	{
		// Token: 0x0600236A RID: 9066 RVA: 0x000503C0 File Offset: 0x0004E5C0
		protected Binder()
		{
		}

		// Token: 0x0600236B RID: 9067
		public abstract FieldInfo BindToField(BindingFlags bindingAttr, FieldInfo[] match, object value, CultureInfo culture);

		// Token: 0x0600236C RID: 9068
		public abstract MethodBase BindToMethod(BindingFlags bindingAttr, MethodBase[] match, object[] args, ParameterModifier[] modifiers, CultureInfo culture, string[] names, [Out] object state);

		// Token: 0x0600236D RID: 9069
		public abstract object ChangeType(object value, Type type, CultureInfo culture);

		// Token: 0x0600236E RID: 9070
		public abstract void ReorderArgumentArray(object[] args, object state);

		// Token: 0x0600236F RID: 9071
		public abstract MethodBase SelectMethod(BindingFlags bindingAttr, MethodBase[] match, Type[] types, ParameterModifier[] modifiers);

		// Token: 0x06002370 RID: 9072
		public abstract PropertyInfo SelectProperty(BindingFlags bindingAttr, PropertyInfo[] match, Type returnType, Type[] indexes, ParameterModifier[] modifiers);
	}
}
