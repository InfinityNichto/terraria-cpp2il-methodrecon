using System;
using System.Globalization;
using System.Runtime.InteropServices;
using Cpp2IlInjected;

namespace System.Reflection.Emit
{
	// Token: 0x02000527 RID: 1319
	public sealed class TypeBuilder : TypeInfo
	{
		// Token: 0x17000597 RID: 1431
		// (get) Token: 0x060026E7 RID: 9959 RVA: 0x0000207A File Offset: 0x0000027A
		public override Assembly Assembly
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		// Token: 0x17000598 RID: 1432
		// (get) Token: 0x060026E8 RID: 9960 RVA: 0x0000207A File Offset: 0x0000027A
		public override string AssemblyQualifiedName
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		// Token: 0x17000599 RID: 1433
		// (get) Token: 0x060026E9 RID: 9961 RVA: 0x0000207A File Offset: 0x0000027A
		public override Type BaseType
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		// Token: 0x1700059A RID: 1434
		// (get) Token: 0x060026EA RID: 9962 RVA: 0x0000207A File Offset: 0x0000027A
		public override string FullName
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		// Token: 0x1700059B RID: 1435
		// (get) Token: 0x060026EB RID: 9963 RVA: 0x0000207A File Offset: 0x0000027A
		public override Module Module
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		// Token: 0x1700059C RID: 1436
		// (get) Token: 0x060026EC RID: 9964 RVA: 0x0000207A File Offset: 0x0000027A
		public override string Name
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		// Token: 0x1700059D RID: 1437
		// (get) Token: 0x060026ED RID: 9965 RVA: 0x0000207A File Offset: 0x0000027A
		public override string Namespace
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		// Token: 0x1700059E RID: 1438
		// (get) Token: 0x060026EE RID: 9966 RVA: 0x0000207A File Offset: 0x0000027A
		public override Type UnderlyingSystemType
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		// Token: 0x060026EF RID: 9967 RVA: 0x0000207A File Offset: 0x0000027A
		protected override TypeAttributes GetAttributeFlagsImpl()
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x060026F0 RID: 9968 RVA: 0x0000207A File Offset: 0x0000027A
		protected override ConstructorInfo GetConstructorImpl(BindingFlags bindingAttr, Binder binder, CallingConventions callConvention, Type[] types, ParameterModifier[] modifiers)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x060026F1 RID: 9969 RVA: 0x0000207A File Offset: 0x0000027A
		[ComVisible(true)]
		public override ConstructorInfo[] GetConstructors(BindingFlags bindingAttr)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x060026F2 RID: 9970 RVA: 0x0000207A File Offset: 0x0000027A
		public override object[] GetCustomAttributes(bool inherit)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x060026F3 RID: 9971 RVA: 0x0000207A File Offset: 0x0000027A
		public override object[] GetCustomAttributes(Type attributeType, bool inherit)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x060026F4 RID: 9972 RVA: 0x0000207A File Offset: 0x0000027A
		public override Type GetElementType()
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x060026F5 RID: 9973 RVA: 0x0000207A File Offset: 0x0000027A
		public override EventInfo GetEvent(string name, BindingFlags bindingAttr)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x060026F6 RID: 9974 RVA: 0x0000207A File Offset: 0x0000027A
		public override EventInfo[] GetEvents(BindingFlags bindingAttr)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x060026F7 RID: 9975 RVA: 0x0000207A File Offset: 0x0000027A
		public override FieldInfo GetField(string name, BindingFlags bindingAttr)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x060026F8 RID: 9976 RVA: 0x0000207A File Offset: 0x0000027A
		public override FieldInfo[] GetFields(BindingFlags bindingAttr)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x060026F9 RID: 9977 RVA: 0x0000207A File Offset: 0x0000027A
		public override Type[] GetInterfaces()
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x060026FA RID: 9978 RVA: 0x0000207A File Offset: 0x0000027A
		protected override MethodInfo GetMethodImpl(string name, BindingFlags bindingAttr, Binder binder, CallingConventions callConvention, Type[] types, ParameterModifier[] modifiers)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x060026FB RID: 9979 RVA: 0x0000207A File Offset: 0x0000027A
		public override MethodInfo[] GetMethods(BindingFlags bindingAttr)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x060026FC RID: 9980 RVA: 0x0000207A File Offset: 0x0000027A
		public override Type GetNestedType(string name, BindingFlags bindingAttr)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x060026FD RID: 9981 RVA: 0x0000207A File Offset: 0x0000027A
		public override PropertyInfo[] GetProperties(BindingFlags bindingAttr)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x060026FE RID: 9982 RVA: 0x0000207A File Offset: 0x0000027A
		protected override PropertyInfo GetPropertyImpl(string name, BindingFlags bindingAttr, Binder binder, Type returnType, Type[] types, ParameterModifier[] modifiers)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x060026FF RID: 9983 RVA: 0x0000207A File Offset: 0x0000027A
		protected override bool HasElementTypeImpl()
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06002700 RID: 9984 RVA: 0x0000207A File Offset: 0x0000027A
		public override object InvokeMember(string name, BindingFlags invokeAttr, Binder binder, object target, object[] args, ParameterModifier[] modifiers, CultureInfo culture, string[] namedParameters)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06002701 RID: 9985 RVA: 0x0000207A File Offset: 0x0000027A
		protected override bool IsArrayImpl()
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06002702 RID: 9986 RVA: 0x0000207A File Offset: 0x0000027A
		protected override bool IsByRefImpl()
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06002703 RID: 9987 RVA: 0x0000207A File Offset: 0x0000027A
		protected override bool IsCOMObjectImpl()
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06002704 RID: 9988 RVA: 0x0000207A File Offset: 0x0000027A
		public override bool IsDefined(Type attributeType, bool inherit)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06002705 RID: 9989 RVA: 0x0000207A File Offset: 0x0000027A
		protected override bool IsPointerImpl()
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06002706 RID: 9990 RVA: 0x0000207A File Offset: 0x0000027A
		protected override bool IsPrimitiveImpl()
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x0400151A RID: 5402
		public const int UnspecifiedTypeSize = 0;
	}
}
