using System;
using System.Collections.Generic;
using System.Reflection;
using UnityEngine.Scripting;
using UnityEngine.Serialization;

namespace UnityEngine.Events
{
	// Token: 0x02000167 RID: 359
	[UsedByNativeCode]
	[Serializable]
	public abstract class UnityEventBase : ISerializationCallbackReceiver
	{
		// Token: 0x060006B4 RID: 1716 RVA: 0x0000C048 File Offset: 0x0000A248
		protected UnityEventBase()
		{
		}

		// Token: 0x060006B5 RID: 1717 RVA: 0x0000C064 File Offset: 0x0000A264
		void ISerializationCallbackReceiver.OnBeforeSerialize()
		{
			this.m_Calls.ClearPersistent();
			this.m_CallsDirty = true;
		}

		// Token: 0x060006B6 RID: 1718 RVA: 0x0000C084 File Offset: 0x0000A284
		void ISerializationCallbackReceiver.OnAfterDeserialize()
		{
			this.m_Calls.ClearPersistent();
			this.m_CallsDirty = true;
		}

		// Token: 0x060006B7 RID: 1719
		protected abstract MethodInfo FindMethod_Impl(string name, Type targetObjType);

		// Token: 0x060006B8 RID: 1720
		internal abstract BaseInvokableCall GetDelegate(object target, MethodInfo theFunction);

		// Token: 0x060006B9 RID: 1721 RVA: 0x0000C0A4 File Offset: 0x0000A2A4
		internal MethodInfo FindMethod(PersistentCall call)
		{
			if (!true)
			{
			}
			bool flag = string.IsNullOrEmpty(call.m_Arguments.m_ObjectArgumentAssemblyTypeName);
			ArgumentCache arguments = call.m_Arguments;
			if (arguments.m_ObjectArgumentAssemblyTypeName != null || arguments == null)
			{
			}
			Object target = call.m_Target;
			if (arguments == null)
			{
			}
			Type type = call.m_Target.GetType();
			string targetAssemblyTypeName = call.targetAssemblyTypeName;
			string methodName = call.m_MethodName;
			PersistentListenerMode mode = call.m_Mode;
			MethodInfo methodInfo;
			return methodInfo;
		}

		// Token: 0x060006BA RID: 1722 RVA: 0x0000C10C File Offset: 0x0000A30C
		internal MethodInfo FindMethod(string name, Type listenerType, PersistentListenerMode mode, Type argumentType)
		{
			if (mode == PersistentListenerMode.EventDefined)
			{
			}
			Type type;
			if (type == null || type != null)
			{
				if (mode == PersistentListenerMode.EventDefined)
				{
				}
				Type type2;
				if (type2 == null || type2 != null)
				{
					MethodInfo methodInfo;
					return methodInfo;
				}
			}
			throw new ArrayTypeMismatchException();
		}

		// Token: 0x060006BB RID: 1723 RVA: 0x0000C140 File Offset: 0x0000A340
		private void DirtyPersistentCalls()
		{
			this.m_Calls.ClearPersistent();
			this.m_CallsDirty = true;
		}

		// Token: 0x060006BC RID: 1724 RVA: 0x0000C160 File Offset: 0x0000A360
		private void RebuildPersistentCallsIfNeeded()
		{
			if (this.m_CallsDirty)
			{
				InvokableCallList calls = this.m_Calls;
				this.m_PersistentCalls.Initialize(calls, this);
			}
		}

		// Token: 0x060006BD RID: 1725 RVA: 0x0000C18C File Offset: 0x0000A38C
		internal void AddCall(BaseInvokableCall call)
		{
			this.m_Calls.AddListener(call);
		}

		// Token: 0x060006BE RID: 1726 RVA: 0x0000C1A8 File Offset: 0x0000A3A8
		protected void RemoveListener(object targetObj, MethodInfo method)
		{
			this.m_Calls.RemoveListener(targetObj, method);
		}

		// Token: 0x060006BF RID: 1727 RVA: 0x0000C1C4 File Offset: 0x0000A3C4
		internal List<BaseInvokableCall> PrepareInvoke()
		{
			if (this.m_CallsDirty)
			{
				InvokableCallList calls = this.m_Calls;
				this.m_PersistentCalls.Initialize(calls, this);
			}
			return this.m_Calls.PrepareInvoke();
		}

		// Token: 0x060006C0 RID: 1728 RVA: 0x0000C1F8 File Offset: 0x0000A3F8
		public override string ToString()
		{
			string text = base.ToString();
			Type type = base.GetType();
			string text2;
			return text2;
		}

		// Token: 0x060006C1 RID: 1729 RVA: 0x0000C214 File Offset: 0x0000A414
		public static MethodInfo GetValidMethodInfo(object obj, string functionName, Type[] argumentTypes)
		{
			MethodInfo methodInfo;
			return methodInfo;
		}

		// Token: 0x060006C2 RID: 1730 RVA: 0x0000C224 File Offset: 0x0000A424
		public static MethodInfo GetValidMethodInfo(Type objectType, string functionName, Type[] argumentTypes)
		{
			if (!true)
			{
			}
			MethodInfo methodInfo;
			return methodInfo;
		}

		// Token: 0x04000663 RID: 1635
		private InvokableCallList m_Calls;

		// Token: 0x04000664 RID: 1636
		[FormerlySerializedAs("m_PersistentListeners")]
		[SerializeField]
		private PersistentCallGroup m_PersistentCalls;

		// Token: 0x04000665 RID: 1637
		private bool m_CallsDirty = true;
	}
}
