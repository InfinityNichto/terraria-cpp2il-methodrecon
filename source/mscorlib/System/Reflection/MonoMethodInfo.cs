using System;
using System.Runtime.InteropServices;
using Cpp2IlInjected;

namespace System.Reflection
{
	// Token: 0x0200050D RID: 1293
	internal struct MonoMethodInfo
	{
		// Token: 0x060025C2 RID: 9666 RVA: 0x000530E4 File Offset: 0x000512E4
		private static void get_method_info(IntPtr handle, [Out] MonoMethodInfo info)
		{
		}

		// Token: 0x060025C3 RID: 9667 RVA: 0x0000207A File Offset: 0x0000027A
		private static int get_method_attributes(IntPtr handle)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x060025C4 RID: 9668 RVA: 0x000530F4 File Offset: 0x000512F4
		internal static MonoMethodInfo GetMethodInfo(IntPtr handle)
		{
			MonoMethodInfo monoMethodInfo;
			return monoMethodInfo;
		}

		// Token: 0x060025C5 RID: 9669 RVA: 0x0000207A File Offset: 0x0000027A
		internal static Type GetDeclaringType(IntPtr handle)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x060025C6 RID: 9670 RVA: 0x0000207A File Offset: 0x0000027A
		internal static Type GetReturnType(IntPtr handle)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x060025C7 RID: 9671 RVA: 0x0000207A File Offset: 0x0000027A
		internal static MethodAttributes GetAttributes(IntPtr handle)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x060025C8 RID: 9672 RVA: 0x0000207A File Offset: 0x0000027A
		internal static CallingConventions GetCallingConvention(IntPtr handle)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x060025C9 RID: 9673 RVA: 0x0000207A File Offset: 0x0000027A
		internal static MethodImplAttributes GetMethodImplementationFlags(IntPtr handle)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x060025CA RID: 9674 RVA: 0x0000207A File Offset: 0x0000027A
		private static ParameterInfo[] get_parameter_info(IntPtr handle, MemberInfo member)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x060025CB RID: 9675 RVA: 0x0000207A File Offset: 0x0000027A
		internal static ParameterInfo[] GetParametersInfo(IntPtr handle, MemberInfo member)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x060025CC RID: 9676 RVA: 0x0000207A File Offset: 0x0000027A
		private static MarshalAsAttribute get_retval_marshal(IntPtr handle)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x060025CD RID: 9677 RVA: 0x00053104 File Offset: 0x00051304
		internal static ParameterInfo GetReturnParameterInfo(RuntimeMethodInfo method)
		{
			ParameterInfo parameterInfo;
			return parameterInfo;
		}

		// Token: 0x040014ED RID: 5357
		private Type parent;

		// Token: 0x040014EE RID: 5358
		private Type ret;

		// Token: 0x040014EF RID: 5359
		internal MethodAttributes attrs;

		// Token: 0x040014F0 RID: 5360
		internal MethodImplAttributes iattrs;

		// Token: 0x040014F1 RID: 5361
		private CallingConventions callconv;
	}
}
