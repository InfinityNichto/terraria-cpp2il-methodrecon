using System;
using System.Collections.Generic;
using System.Reflection;

namespace System.Runtime.Serialization
{
	// Token: 0x020003D5 RID: 981
	public sealed class SerializationObjectManager
	{
		// Token: 0x06001EFA RID: 7930 RVA: 0x00043A74 File Offset: 0x00041C74
		public SerializationObjectManager(StreamingContext context)
		{
			this._context = context;
		}

		// Token: 0x06001EFB RID: 7931 RVA: 0x00043A90 File Offset: 0x00041C90
		public void RegisterObject(object obj)
		{
			SerializationEvents serializationEventsForType = SerializationEventsCache.GetSerializationEventsForType(obj.GetType());
			if (serializationEventsForType._onSerializingMethods != null || serializationEventsForType._onSerializedMethods != null)
			{
				Dictionary<object, object> objectSeenTable = this._objectSeenTable;
				StreamingContext context = this._context;
				StreamingContextStates state = this._context.m_state;
				serializationEventsForType.InvokeOnSerializing(obj, context);
				this.AddOnSerialized(obj);
			}
		}

		// Token: 0x06001EFC RID: 7932 RVA: 0x00043AE4 File Offset: 0x00041CE4
		public void RaiseOnSerializedEvent()
		{
			SerializationEventHandler onSerializedHandler = this._onSerializedHandler;
			if (onSerializedHandler != null)
			{
				StreamingContext context = this._context;
				StreamingContextStates state = this._context.m_state;
				IntPtr invoke_impl = onSerializedHandler.invoke_impl;
				IntPtr method_code = onSerializedHandler.method_code;
				IntPtr method = onSerializedHandler.method;
				return;
			}
		}

		// Token: 0x06001EFD RID: 7933 RVA: 0x00043B28 File Offset: 0x00041D28
		private void AddOnSerialized(object obj)
		{
			SerializationEvents serializationEventsForType = SerializationEventsCache.GetSerializationEventsForType(obj.GetType());
			SerializationEventHandler onSerializedHandler = this._onSerializedHandler;
			List<MethodInfo> onSerializedMethods = serializationEventsForType._onSerializedMethods;
			SerializationEventHandler serializationEventHandler = SerializationEvents.AddOnDelegate(obj, onSerializedHandler, onSerializedMethods);
			this._onSerializedHandler = serializationEventHandler;
		}

		// Token: 0x04000F88 RID: 3976
		private readonly Dictionary<object, object> _objectSeenTable;

		// Token: 0x04000F89 RID: 3977
		private readonly StreamingContext _context;

		// Token: 0x04000F8A RID: 3978
		private SerializationEventHandler _onSerializedHandler;
	}
}
