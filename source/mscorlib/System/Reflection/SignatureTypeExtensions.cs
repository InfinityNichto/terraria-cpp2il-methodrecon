using System;

namespace System.Reflection
{
	// Token: 0x020004F1 RID: 1265
	internal static class SignatureTypeExtensions
	{
		// Token: 0x060024C5 RID: 9413 RVA: 0x0005144C File Offset: 0x0004F64C
		public static bool MatchesParameterTypeExactly(this Type pattern, ParameterInfo parameter)
		{
			bool flag;
			if (false)
			{
				return flag;
			}
			return flag;
		}

		// Token: 0x060024C6 RID: 9414 RVA: 0x00051460 File Offset: 0x0004F660
		internal static bool MatchesExactly(this SignatureType pattern, Type actual)
		{
			bool isByRef = pattern.IsByRef;
			return pattern.IsByRef;
		}

		// Token: 0x060024C7 RID: 9415 RVA: 0x00051490 File Offset: 0x0004F690
		internal static Type TryResolveAgainstGenericMethod(this SignatureType signatureType, MethodInfo genericMethod)
		{
			Type type;
			return type;
		}

		// Token: 0x060024C8 RID: 9416 RVA: 0x000514A0 File Offset: 0x0004F6A0
		private static Type TryResolve(this SignatureType signatureType, Type[] genericMethodParameters)
		{
			Type type;
			if (type != null)
			{
				return type.TryMakeArrayType();
			}
			throw new ArrayTypeMismatchException();
		}

		// Token: 0x060024C9 RID: 9417 RVA: 0x0005150C File Offset: 0x0004F70C
		private static Type TryMakeArrayType(this Type type)
		{
		}

		// Token: 0x060024CA RID: 9418 RVA: 0x0005151C File Offset: 0x0004F71C
		private static Type TryMakeArrayType(this Type type, int rank)
		{
		}

		// Token: 0x060024CB RID: 9419 RVA: 0x0005152C File Offset: 0x0004F72C
		private static Type TryMakeByRefType(this Type type)
		{
		}

		// Token: 0x060024CC RID: 9420 RVA: 0x0005153C File Offset: 0x0004F73C
		private static Type TryMakePointerType(this Type type)
		{
		}

		// Token: 0x060024CD RID: 9421 RVA: 0x0005154C File Offset: 0x0004F74C
		private static Type TryMakeGenericType(this Type type, Type[] instantiation)
		{
		}
	}
}
