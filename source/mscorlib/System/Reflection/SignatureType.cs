using System;
using System.Globalization;
using Cpp2IlInjected;

namespace System.Reflection
{
	// Token: 0x020004F0 RID: 1264
	internal abstract class SignatureType : Type
	{
		// Token: 0x170004F5 RID: 1269
		// (get) Token: 0x06002476 RID: 9334 RVA: 0x000513E4 File Offset: 0x0004F5E4
		public sealed override bool IsSignatureType
		{
			get
			{
				return true;
			}
		}

		// Token: 0x06002477 RID: 9335
		protected abstract override bool HasElementTypeImpl();

		// Token: 0x06002478 RID: 9336
		protected abstract override bool IsArrayImpl();

		// Token: 0x170004F6 RID: 1270
		// (get) Token: 0x06002479 RID: 9337
		public abstract override bool IsSZArray { get; }

		// Token: 0x170004F7 RID: 1271
		// (get) Token: 0x0600247A RID: 9338
		public abstract override bool IsVariableBoundArray { get; }

		// Token: 0x0600247B RID: 9339
		protected abstract override bool IsByRefImpl();

		// Token: 0x0600247C RID: 9340
		protected abstract override bool IsPointerImpl();

		// Token: 0x170004F8 RID: 1272
		// (get) Token: 0x0600247D RID: 9341 RVA: 0x000513F4 File Offset: 0x0004F5F4
		public sealed override bool IsGenericType
		{
			get
			{
				return true;
			}
		}

		// Token: 0x170004F9 RID: 1273
		// (get) Token: 0x0600247E RID: 9342
		public abstract override bool IsGenericTypeDefinition { get; }

		// Token: 0x170004FA RID: 1274
		// (get) Token: 0x0600247F RID: 9343
		public abstract override bool IsConstructedGenericType { get; }

		// Token: 0x170004FB RID: 1275
		// (get) Token: 0x06002480 RID: 9344
		public abstract override bool IsGenericParameter { get; }

		// Token: 0x170004FC RID: 1276
		// (get) Token: 0x06002481 RID: 9345
		public abstract override bool IsGenericMethodParameter { get; }

		// Token: 0x170004FD RID: 1277
		// (get) Token: 0x06002482 RID: 9346
		public abstract override bool ContainsGenericParameters { get; }

		// Token: 0x170004FE RID: 1278
		// (get) Token: 0x06002483 RID: 9347 RVA: 0x00051404 File Offset: 0x0004F604
		public sealed override MemberTypes MemberType
		{
			get
			{
				return MemberTypes.TypeInfo;
			}
		}

		// Token: 0x06002484 RID: 9348 RVA: 0x0000207A File Offset: 0x0000027A
		public sealed override Type MakeArrayType()
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06002485 RID: 9349 RVA: 0x0000207A File Offset: 0x0000027A
		public sealed override Type MakeArrayType(int rank)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06002486 RID: 9350 RVA: 0x0000207A File Offset: 0x0000027A
		public sealed override Type MakeByRefType()
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06002487 RID: 9351 RVA: 0x0000207A File Offset: 0x0000027A
		public sealed override Type MakePointerType()
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06002488 RID: 9352 RVA: 0x0000207A File Offset: 0x0000027A
		public sealed override Type MakeGenericType(params Type[] typeArguments)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06002489 RID: 9353 RVA: 0x0000207A File Offset: 0x0000027A
		public sealed override Type GetElementType()
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x0600248A RID: 9354
		public abstract override int GetArrayRank();

		// Token: 0x0600248B RID: 9355
		public abstract override Type GetGenericTypeDefinition();

		// Token: 0x170004FF RID: 1279
		// (get) Token: 0x0600248C RID: 9356
		public abstract override Type[] GenericTypeArguments { get; }

		// Token: 0x0600248D RID: 9357
		public abstract override Type[] GetGenericArguments();

		// Token: 0x17000500 RID: 1280
		// (get) Token: 0x0600248E RID: 9358
		public abstract override int GenericParameterPosition { get; }

		// Token: 0x17000501 RID: 1281
		// (get) Token: 0x0600248F RID: 9359
		internal abstract SignatureType ElementType { get; }

		// Token: 0x17000502 RID: 1282
		// (get) Token: 0x06002490 RID: 9360 RVA: 0x0000207A File Offset: 0x0000027A
		public sealed override Type UnderlyingSystemType
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		// Token: 0x17000503 RID: 1283
		// (get) Token: 0x06002491 RID: 9361
		public abstract override string Name { get; }

		// Token: 0x17000504 RID: 1284
		// (get) Token: 0x06002492 RID: 9362
		public abstract override string Namespace { get; }

		// Token: 0x17000505 RID: 1285
		// (get) Token: 0x06002493 RID: 9363 RVA: 0x00051414 File Offset: 0x0004F614
		public sealed override string FullName
		{
			get
			{
			}
		}

		// Token: 0x17000506 RID: 1286
		// (get) Token: 0x06002494 RID: 9364 RVA: 0x00051424 File Offset: 0x0004F624
		public sealed override string AssemblyQualifiedName
		{
			get
			{
			}
		}

		// Token: 0x06002495 RID: 9365
		public abstract override string ToString();

		// Token: 0x17000507 RID: 1287
		// (get) Token: 0x06002496 RID: 9366 RVA: 0x0000207A File Offset: 0x0000027A
		public sealed override Assembly Assembly
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		// Token: 0x17000508 RID: 1288
		// (get) Token: 0x06002497 RID: 9367 RVA: 0x0000207A File Offset: 0x0000027A
		public sealed override Module Module
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		// Token: 0x17000509 RID: 1289
		// (get) Token: 0x06002498 RID: 9368 RVA: 0x0000207A File Offset: 0x0000027A
		public sealed override Type ReflectedType
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		// Token: 0x1700050A RID: 1290
		// (get) Token: 0x06002499 RID: 9369 RVA: 0x0000207A File Offset: 0x0000027A
		public sealed override Type BaseType
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		// Token: 0x0600249A RID: 9370 RVA: 0x0000207A File Offset: 0x0000027A
		public sealed override Type[] GetInterfaces()
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x0600249B RID: 9371 RVA: 0x0000207A File Offset: 0x0000027A
		public sealed override bool IsAssignableFrom(Type c)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x1700050B RID: 1291
		// (get) Token: 0x0600249C RID: 9372 RVA: 0x0000207A File Offset: 0x0000027A
		public sealed override int MetadataToken
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		// Token: 0x1700050C RID: 1292
		// (get) Token: 0x0600249D RID: 9373 RVA: 0x0000207A File Offset: 0x0000027A
		public sealed override Type DeclaringType
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		// Token: 0x1700050D RID: 1293
		// (get) Token: 0x0600249E RID: 9374 RVA: 0x0000207A File Offset: 0x0000027A
		public sealed override MethodBase DeclaringMethod
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		// Token: 0x0600249F RID: 9375 RVA: 0x0000207A File Offset: 0x0000027A
		public sealed override Type[] GetGenericParameterConstraints()
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x1700050E RID: 1294
		// (get) Token: 0x060024A0 RID: 9376 RVA: 0x0000207A File Offset: 0x0000027A
		public sealed override GenericParameterAttributes GenericParameterAttributes
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		// Token: 0x060024A1 RID: 9377 RVA: 0x0000207A File Offset: 0x0000027A
		public sealed override bool IsEnumDefined(object value)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x060024A2 RID: 9378 RVA: 0x0000207A File Offset: 0x0000027A
		public sealed override string GetEnumName(object value)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x060024A3 RID: 9379 RVA: 0x0000207A File Offset: 0x0000027A
		public sealed override string[] GetEnumNames()
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x060024A4 RID: 9380 RVA: 0x0000207A File Offset: 0x0000027A
		public sealed override Type GetEnumUnderlyingType()
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x060024A5 RID: 9381 RVA: 0x0000207A File Offset: 0x0000027A
		public sealed override Array GetEnumValues()
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x060024A6 RID: 9382 RVA: 0x0000207A File Offset: 0x0000027A
		protected sealed override TypeCode GetTypeCodeImpl()
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x060024A7 RID: 9383 RVA: 0x0000207A File Offset: 0x0000027A
		protected sealed override TypeAttributes GetAttributeFlagsImpl()
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x060024A8 RID: 9384 RVA: 0x0000207A File Offset: 0x0000027A
		public sealed override ConstructorInfo[] GetConstructors(BindingFlags bindingAttr)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x060024A9 RID: 9385 RVA: 0x0000207A File Offset: 0x0000027A
		public sealed override EventInfo GetEvent(string name, BindingFlags bindingAttr)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x060024AA RID: 9386 RVA: 0x0000207A File Offset: 0x0000027A
		public sealed override EventInfo[] GetEvents(BindingFlags bindingAttr)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x060024AB RID: 9387 RVA: 0x0000207A File Offset: 0x0000027A
		public sealed override FieldInfo GetField(string name, BindingFlags bindingAttr)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x060024AC RID: 9388 RVA: 0x0000207A File Offset: 0x0000027A
		public sealed override FieldInfo[] GetFields(BindingFlags bindingAttr)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x060024AD RID: 9389 RVA: 0x0000207A File Offset: 0x0000027A
		public sealed override MethodInfo[] GetMethods(BindingFlags bindingAttr)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x060024AE RID: 9390 RVA: 0x0000207A File Offset: 0x0000027A
		public sealed override Type GetNestedType(string name, BindingFlags bindingAttr)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x060024AF RID: 9391 RVA: 0x0000207A File Offset: 0x0000027A
		public sealed override PropertyInfo[] GetProperties(BindingFlags bindingAttr)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x060024B0 RID: 9392 RVA: 0x0000207A File Offset: 0x0000027A
		public sealed override object InvokeMember(string name, BindingFlags invokeAttr, Binder binder, object target, object[] args, ParameterModifier[] modifiers, CultureInfo culture, string[] namedParameters)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x060024B1 RID: 9393 RVA: 0x0000207A File Offset: 0x0000027A
		protected sealed override MethodInfo GetMethodImpl(string name, BindingFlags bindingAttr, Binder binder, CallingConventions callConvention, Type[] types, ParameterModifier[] modifiers)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x060024B2 RID: 9394 RVA: 0x0000207A File Offset: 0x0000027A
		protected sealed override PropertyInfo GetPropertyImpl(string name, BindingFlags bindingAttr, Binder binder, Type returnType, Type[] types, ParameterModifier[] modifiers)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x060024B3 RID: 9395 RVA: 0x0000207A File Offset: 0x0000027A
		public sealed override MemberInfo[] GetMember(string name, BindingFlags bindingAttr)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x060024B4 RID: 9396 RVA: 0x0000207A File Offset: 0x0000027A
		public sealed override MemberInfo[] GetMember(string name, MemberTypes type, BindingFlags bindingAttr)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x060024B5 RID: 9397 RVA: 0x0000207A File Offset: 0x0000027A
		public sealed override object[] GetCustomAttributes(bool inherit)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x060024B6 RID: 9398 RVA: 0x0000207A File Offset: 0x0000027A
		public sealed override object[] GetCustomAttributes(Type attributeType, bool inherit)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x060024B7 RID: 9399 RVA: 0x0000207A File Offset: 0x0000027A
		public sealed override bool IsDefined(Type attributeType, bool inherit)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x060024B8 RID: 9400 RVA: 0x0000207A File Offset: 0x0000027A
		protected sealed override ConstructorInfo GetConstructorImpl(BindingFlags bindingAttr, Binder binder, CallingConventions callConvention, Type[] types, ParameterModifier[] modifiers)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x060024B9 RID: 9401 RVA: 0x0000207A File Offset: 0x0000027A
		protected sealed override bool IsCOMObjectImpl()
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x060024BA RID: 9402 RVA: 0x0000207A File Offset: 0x0000027A
		protected sealed override bool IsPrimitiveImpl()
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x060024BB RID: 9403 RVA: 0x0000207A File Offset: 0x0000027A
		protected sealed override bool IsContextfulImpl()
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x1700050F RID: 1295
		// (get) Token: 0x060024BC RID: 9404 RVA: 0x0000207A File Offset: 0x0000027A
		public sealed override bool IsEnum
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		// Token: 0x060024BD RID: 9405 RVA: 0x0000207A File Offset: 0x0000027A
		public sealed override bool IsEquivalentTo(Type other)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x060024BE RID: 9406 RVA: 0x0000207A File Offset: 0x0000027A
		public sealed override bool IsInstanceOfType(object o)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x060024BF RID: 9407 RVA: 0x0000207A File Offset: 0x0000027A
		protected sealed override bool IsMarshalByRefImpl()
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x17000510 RID: 1296
		// (get) Token: 0x060024C0 RID: 9408 RVA: 0x0000207A File Offset: 0x0000027A
		public sealed override bool IsSerializable
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		// Token: 0x060024C1 RID: 9409 RVA: 0x0000207A File Offset: 0x0000027A
		public sealed override bool IsSubclassOf(Type c)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x060024C2 RID: 9410 RVA: 0x0000207A File Offset: 0x0000027A
		protected sealed override bool IsValueTypeImpl()
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x17000511 RID: 1297
		// (get) Token: 0x060024C3 RID: 9411 RVA: 0x0000207A File Offset: 0x0000027A
		public sealed override RuntimeTypeHandle TypeHandle
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		// Token: 0x060024C4 RID: 9412 RVA: 0x00051434 File Offset: 0x0004F634
		protected SignatureType()
		{
			if (!true)
			{
			}
			base..ctor();
		}
	}
}
