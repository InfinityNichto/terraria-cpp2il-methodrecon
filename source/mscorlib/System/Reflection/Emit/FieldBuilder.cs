using System;
using System.Globalization;
using Cpp2IlInjected;

namespace System.Reflection.Emit
{
	// Token: 0x0200051E RID: 1310
	public sealed class FieldBuilder : FieldInfo
	{
		// Token: 0x1700057E RID: 1406
		// (get) Token: 0x060026A2 RID: 9890 RVA: 0x00054168 File Offset: 0x00052368
		public override FieldAttributes Attributes
		{
			get
			{
				throw new NullReferenceException();
			}
		}

		// Token: 0x1700057F RID: 1407
		// (get) Token: 0x060026A3 RID: 9891 RVA: 0x0005417C File Offset: 0x0005237C
		public override Type DeclaringType
		{
			get
			{
				throw new NullReferenceException();
			}
		}

		// Token: 0x17000580 RID: 1408
		// (get) Token: 0x060026A4 RID: 9892 RVA: 0x00054190 File Offset: 0x00052390
		public override RuntimeFieldHandle FieldHandle
		{
			get
			{
				throw new NullReferenceException();
			}
		}

		// Token: 0x17000581 RID: 1409
		// (get) Token: 0x060026A5 RID: 9893 RVA: 0x000541A4 File Offset: 0x000523A4
		public override Type FieldType
		{
			get
			{
				throw new NullReferenceException();
			}
		}

		// Token: 0x17000582 RID: 1410
		// (get) Token: 0x060026A6 RID: 9894 RVA: 0x000541B8 File Offset: 0x000523B8
		public override string Name
		{
			get
			{
				throw new NullReferenceException();
			}
		}

		// Token: 0x17000583 RID: 1411
		// (get) Token: 0x060026A7 RID: 9895 RVA: 0x000541CC File Offset: 0x000523CC
		public override Type ReflectedType
		{
			get
			{
				throw new NullReferenceException();
			}
		}

		// Token: 0x060026A8 RID: 9896 RVA: 0x000541E0 File Offset: 0x000523E0
		public override object[] GetCustomAttributes(bool inherit)
		{
			throw new NullReferenceException();
		}

		// Token: 0x060026A9 RID: 9897 RVA: 0x000541F4 File Offset: 0x000523F4
		public override object[] GetCustomAttributes(Type attributeType, bool inherit)
		{
			throw new NullReferenceException();
		}

		// Token: 0x060026AA RID: 9898 RVA: 0x00054208 File Offset: 0x00052408
		public override object GetValue(object obj)
		{
			throw new NullReferenceException();
		}

		// Token: 0x060026AB RID: 9899 RVA: 0x0005421C File Offset: 0x0005241C
		public override bool IsDefined(Type attributeType, bool inherit)
		{
			throw new NullReferenceException();
		}

		// Token: 0x060026AC RID: 9900 RVA: 0x0000207A File Offset: 0x0000027A
		public override void SetValue(object obj, object val, BindingFlags invokeAttr, Binder binder, CultureInfo culture)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}
	}
}
