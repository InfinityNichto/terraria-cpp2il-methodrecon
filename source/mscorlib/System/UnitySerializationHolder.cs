using System;
using System.Reflection;
using System.Runtime.Serialization;
using Cpp2IlInjected;

namespace System
{
	// Token: 0x02000161 RID: 353
	[Serializable]
	internal class UnitySerializationHolder : ISerializable, IObjectReference
	{
		// Token: 0x06000E36 RID: 3638 RVA: 0x0001EE70 File Offset: 0x0001D070
		internal static RuntimeType AddElementTypes(SerializationInfo info, RuntimeType type)
		{
			if (info != null)
			{
			}
			throw new InvalidCastException();
		}

		// Token: 0x06000E37 RID: 3639 RVA: 0x0001EE88 File Offset: 0x0001D088
		internal Type MakeElementTypes(Type type)
		{
			int[] elementTypes = this.m_elementTypes;
			return type;
		}

		// Token: 0x06000E38 RID: 3640 RVA: 0x0001EEB0 File Offset: 0x0001D0B0
		internal static void GetUnitySerializationInfo(SerializationInfo info, int unityType)
		{
			if (!true)
			{
			}
			Type type;
			info.SetType(type);
			long num = 0L;
			Type type2;
			info.AddValue("Data", num, type2);
			info.AddValue("UnityType", unityType);
		}

		// Token: 0x06000E39 RID: 3641 RVA: 0x0001EEE4 File Offset: 0x0001D0E4
		internal static void GetUnitySerializationInfo(SerializationInfo info, RuntimeType type)
		{
			Type rootElementType = type.GetRootElementType();
			RuntimeType runtimeType = UnitySerializationHolder.AddElementTypes(info, type);
			Type type2;
			info.SetType(type2);
			int num = 7;
			info.AddValue("UnityType", num);
			Type type3;
			info.AddValue("DeclaringMethod", runtimeType, type3);
			Type type4;
			info.AddValue("DeclaringType", runtimeType, type4);
		}

		// Token: 0x06000E3A RID: 3642 RVA: 0x0001EF50 File Offset: 0x0001D150
		internal static void GetUnitySerializationInfo(SerializationInfo info, int unityType, string data, RuntimeAssembly assembly)
		{
			if (!true)
			{
			}
			Type type;
			info.SetType(type);
			Type type2;
			info.AddValue("Data", data, type2);
			info.AddValue("UnityType", unityType);
		}

		// Token: 0x06000E3B RID: 3643 RVA: 0x0001EF90 File Offset: 0x0001D190
		internal UnitySerializationHolder(SerializationInfo info, StreamingContext context)
		{
			while (info == null)
			{
			}
			int num;
			this.m_unityType = num;
			Type type;
			if (info.GetValue("DeclaringMethod", type) != null)
			{
			}
		}

		// Token: 0x06000E3C RID: 3644 RVA: 0x0001F060 File Offset: 0x0001D260
		private void ThrowInsufficientInformation(string field)
		{
			throw new ArrayTypeMismatchException();
		}

		// Token: 0x06000E3D RID: 3645 RVA: 0x0000207A File Offset: 0x0000027A
		public virtual void GetObjectData(SerializationInfo info, StreamingContext context)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06000E3E RID: 3646 RVA: 0x0001F074 File Offset: 0x0001D274
		public virtual object GetRealObject(StreamingContext context)
		{
			int unityType = this.m_unityType;
			return "Data";
		}

		// Token: 0x040005D9 RID: 1497
		private Type[] m_instantiation;

		// Token: 0x040005DA RID: 1498
		private int[] m_elementTypes;

		// Token: 0x040005DB RID: 1499
		private int m_genericParameterPosition;

		// Token: 0x040005DC RID: 1500
		private Type m_declaringType;

		// Token: 0x040005DD RID: 1501
		private MethodBase m_declaringMethod;

		// Token: 0x040005DE RID: 1502
		private string m_data;

		// Token: 0x040005DF RID: 1503
		private string m_assemblyName;

		// Token: 0x040005E0 RID: 1504
		private int m_unityType;
	}
}
