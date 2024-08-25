using System;
using System.Globalization;
using Cpp2IlInjected;

namespace System.Reflection.Emit
{
	// Token: 0x0200051B RID: 1307
	public sealed class DynamicMethod : MethodInfo
	{
		// Token: 0x17000571 RID: 1393
		// (get) Token: 0x06002676 RID: 9846 RVA: 0x0000207A File Offset: 0x0000027A
		public override MethodAttributes Attributes
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		// Token: 0x17000572 RID: 1394
		// (get) Token: 0x06002677 RID: 9847 RVA: 0x0000207A File Offset: 0x0000027A
		public override Type DeclaringType
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		// Token: 0x17000573 RID: 1395
		// (get) Token: 0x06002678 RID: 9848 RVA: 0x0000207A File Offset: 0x0000027A
		public override string Name
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		// Token: 0x06002679 RID: 9849 RVA: 0x0000207A File Offset: 0x0000027A
		public override ParameterInfo[] GetParameters()
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x17000574 RID: 1396
		// (get) Token: 0x0600267A RID: 9850 RVA: 0x0000207A File Offset: 0x0000027A
		public override RuntimeMethodHandle MethodHandle
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		// Token: 0x17000575 RID: 1397
		// (get) Token: 0x0600267B RID: 9851 RVA: 0x0000207A File Offset: 0x0000027A
		public override Type ReflectedType
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		// Token: 0x0600267C RID: 9852 RVA: 0x0000207A File Offset: 0x0000027A
		public override object[] GetCustomAttributes(bool inherit)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x0600267D RID: 9853 RVA: 0x0000207A File Offset: 0x0000027A
		public override object[] GetCustomAttributes(Type attributeType, bool inherit)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x0600267E RID: 9854 RVA: 0x0000207A File Offset: 0x0000027A
		public override MethodImplAttributes GetMethodImplementationFlags()
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x0600267F RID: 9855 RVA: 0x0000207A File Offset: 0x0000027A
		public override MethodInfo GetBaseDefinition()
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06002680 RID: 9856 RVA: 0x0000207A File Offset: 0x0000027A
		public override object Invoke(object obj, BindingFlags invokeAttr, Binder binder, object[] parameters, CultureInfo culture)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06002681 RID: 9857 RVA: 0x0000207A File Offset: 0x0000027A
		public override bool IsDefined(Type attributeType, bool inherit)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}
	}
}
