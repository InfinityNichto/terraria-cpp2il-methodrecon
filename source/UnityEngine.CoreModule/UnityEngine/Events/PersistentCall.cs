using System;
using System.Reflection;
using UnityEngine.Serialization;

namespace UnityEngine.Events
{
	// Token: 0x02000164 RID: 356
	[Serializable]
	internal class PersistentCall : ISerializationCallbackReceiver
	{
		// Token: 0x1700015B RID: 347
		// (get) Token: 0x060006A1 RID: 1697 RVA: 0x0000BD80 File Offset: 0x00009F80
		public Object target
		{
			get
			{
				return this.m_Target;
			}
		}

		// Token: 0x1700015C RID: 348
		// (get) Token: 0x060006A2 RID: 1698 RVA: 0x0000BD94 File Offset: 0x00009F94
		public string targetAssemblyTypeName
		{
			get
			{
				bool flag = string.IsNullOrEmpty(this.m_TargetAssemblyTypeName);
				Object target = this.m_Target;
				Type type = this.m_Target.GetType();
				string text;
				this.m_TargetAssemblyTypeName = text;
				return this.m_TargetAssemblyTypeName;
			}
		}

		// Token: 0x1700015D RID: 349
		// (get) Token: 0x060006A3 RID: 1699 RVA: 0x0000BDD0 File Offset: 0x00009FD0
		public string methodName
		{
			get
			{
				return this.m_MethodName;
			}
		}

		// Token: 0x1700015E RID: 350
		// (get) Token: 0x060006A4 RID: 1700 RVA: 0x0000BDE4 File Offset: 0x00009FE4
		public PersistentListenerMode mode
		{
			get
			{
				return this.m_Mode;
			}
		}

		// Token: 0x1700015F RID: 351
		// (get) Token: 0x060006A5 RID: 1701 RVA: 0x0000BDF8 File Offset: 0x00009FF8
		public ArgumentCache arguments
		{
			get
			{
				return this.m_Arguments;
			}
		}

		// Token: 0x060006A6 RID: 1702 RVA: 0x0000BE0C File Offset: 0x0000A00C
		public bool IsValid()
		{
			return string.IsNullOrEmpty(this.targetAssemblyTypeName);
		}

		// Token: 0x060006A7 RID: 1703 RVA: 0x0000BE30 File Offset: 0x0000A030
		public BaseInvokableCall GetRuntimeCall(UnityEventBase theEvent)
		{
			MethodInfo methodInfo;
			Object target2;
			if (theEvent != null && this.m_CallState != UnityEventCallState.Off)
			{
				methodInfo = theEvent.FindMethod(this);
				if (methodInfo != null)
				{
					bool isStatic = methodInfo.IsStatic;
					Object target = this.m_Target;
					bool isStatic2 = methodInfo.IsStatic;
					target2 = this.m_Target;
					PersistentListenerMode mode = this.m_Mode;
				}
			}
			ArgumentCache arguments = this.m_Arguments;
			return PersistentCall.GetObjectCall(target2, methodInfo, arguments);
		}

		// Token: 0x060006A8 RID: 1704 RVA: 0x0000BEBC File Offset: 0x0000A0BC
		private static BaseInvokableCall GetObjectCall(Object target, MethodInfo method, ArgumentCache arguments)
		{
			int num = 1;
			if (num == 0)
			{
			}
			if (num == 0)
			{
			}
			Type type;
			if (type != null || num == 0)
			{
			}
			if (num == 0)
			{
			}
			Type type2;
			Type type3;
			Type type4;
			if ((type2 == null || type2 != null) && (type3 == null || type3 != null) && (type4 == null || type4 != null) && (type2 == null || type2 != null))
			{
				Type type6;
				Type type5 = type6.GetType();
				object obj;
				if ((target != null && target == null) || (type6 != null && type6 == null) || obj != null)
				{
				}
			}
			throw new ArrayTypeMismatchException();
		}

		// Token: 0x060006A9 RID: 1705 RVA: 0x0000BF24 File Offset: 0x0000A124
		public void OnBeforeSerialize()
		{
			string text = UnityEventTools.TidyAssemblyTypeName(this.m_TargetAssemblyTypeName);
			this.m_TargetAssemblyTypeName = text;
		}

		// Token: 0x060006AA RID: 1706 RVA: 0x0000BF44 File Offset: 0x0000A144
		public void OnAfterDeserialize()
		{
			string text = UnityEventTools.TidyAssemblyTypeName(this.m_TargetAssemblyTypeName);
			this.m_TargetAssemblyTypeName = text;
		}

		// Token: 0x060006AB RID: 1707 RVA: 0x0000BF64 File Offset: 0x0000A164
		public PersistentCall()
		{
		}

		// Token: 0x04000658 RID: 1624
		[SerializeField]
		[FormerlySerializedAs("instance")]
		private Object m_Target;

		// Token: 0x04000659 RID: 1625
		[SerializeField]
		private string m_TargetAssemblyTypeName;

		// Token: 0x0400065A RID: 1626
		[FormerlySerializedAs("methodName")]
		[SerializeField]
		private string m_MethodName;

		// Token: 0x0400065B RID: 1627
		[FormerlySerializedAs("mode")]
		[SerializeField]
		private PersistentListenerMode m_Mode;

		// Token: 0x0400065C RID: 1628
		[FormerlySerializedAs("arguments")]
		[SerializeField]
		private ArgumentCache m_Arguments;

		// Token: 0x0400065D RID: 1629
		[FormerlySerializedAs("m_Enabled")]
		[FormerlySerializedAs("enabled")]
		[SerializeField]
		private UnityEventCallState m_CallState = UnityEventCallState.RuntimeOnly;
	}
}
