using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using UnityEngine.Bindings;
using UnityEngine.Internal;
using UnityEngine.Scripting;
using UnityEngineInternal;

namespace UnityEngine
{
	// Token: 0x020000A0 RID: 160
	[ExcludeFromPreset]
	[NativeHeader("Runtime/Export/Scripting/GameObject.bindings.h")]
	[UsedByNativeCode]
	public sealed class GameObject : Object
	{
		// Token: 0x060002BA RID: 698 RVA: 0x000021B3 File Offset: 0x000003B3
		public T GetComponent<T>()
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x060002BB RID: 699 RVA: 0x00005FA4 File Offset: 0x000041A4
		[TypeInferenceRule(TypeInferenceRules.TypeReferencedByFirstArgument)]
		[FreeFunction(Name = "GameObjectBindings::GetComponentFromType", HasExplicitThis = true, ThrowsException = true)]
		public Component GetComponent(Type type)
		{
			throw new MissingMethodException();
		}

		// Token: 0x060002BC RID: 700 RVA: 0x00005FB8 File Offset: 0x000041B8
		[FreeFunction(Name = "GameObjectBindings::GetComponentFastPath", HasExplicitThis = true, ThrowsException = true)]
		[NativeWritableSelf]
		internal void GetComponentFastPath(Type type, IntPtr oneFurtherThanResultValue)
		{
			throw new MissingMethodException();
		}

		// Token: 0x060002BD RID: 701 RVA: 0x00005FCC File Offset: 0x000041CC
		[TypeInferenceRule(TypeInferenceRules.TypeReferencedByFirstArgument)]
		[FreeFunction(Name = "GameObjectBindings::GetComponentInChildren", HasExplicitThis = true, ThrowsException = true)]
		public Component GetComponentInChildren(Type type, bool includeInactive)
		{
			throw new MissingMethodException();
		}

		// Token: 0x060002BE RID: 702 RVA: 0x000021B3 File Offset: 0x000003B3
		[ExcludeFromDocs]
		public T GetComponentInChildren<T>()
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x060002BF RID: 703 RVA: 0x00005FE0 File Offset: 0x000041E0
		public T GetComponentInChildren<T>([DefaultValue("false")] bool includeInactive)
		{
			Component component;
			while (component != null)
			{
				if (component == null)
				{
					throw new InvalidCastException();
				}
			}
		}

		// Token: 0x060002C0 RID: 704 RVA: 0x00005FFC File Offset: 0x000041FC
		[TypeInferenceRule(TypeInferenceRules.TypeReferencedByFirstArgument)]
		[FreeFunction(Name = "GameObjectBindings::GetComponentInParent", HasExplicitThis = true, ThrowsException = true)]
		public Component GetComponentInParent(Type type, bool includeInactive)
		{
			throw new MissingMethodException();
		}

		// Token: 0x060002C1 RID: 705 RVA: 0x000021B3 File Offset: 0x000003B3
		[ExcludeFromDocs]
		public T GetComponentInParent<T>()
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x060002C2 RID: 706 RVA: 0x00006010 File Offset: 0x00004210
		public T GetComponentInParent<T>([DefaultValue("false")] bool includeInactive)
		{
			Component component;
			while (component != null)
			{
				if (component == null)
				{
					throw new InvalidCastException();
				}
			}
		}

		// Token: 0x060002C3 RID: 707 RVA: 0x0000602C File Offset: 0x0000422C
		[FreeFunction(Name = "GameObjectBindings::GetComponentsInternal", HasExplicitThis = true, ThrowsException = true)]
		private Array GetComponentsInternal(Type type, bool useSearchTypeAsArrayReturnType, bool recursive, bool includeInactive, bool reverse, object resultList)
		{
			throw new MissingMethodException();
		}

		// Token: 0x060002C4 RID: 708 RVA: 0x00006040 File Offset: 0x00004240
		public T[] GetComponents<T>()
		{
			Array componentsInternal;
			do
			{
				long num = 0L;
				long num2 = 0L;
				long num3 = 0L;
				Type type;
				componentsInternal = this.GetComponentsInternal(type, true, num != 0L, true, num2 != 0L, num3);
				if (componentsInternal == null)
				{
					return;
				}
			}
			while (componentsInternal != null);
			throw new InvalidCastException();
		}

		// Token: 0x060002C5 RID: 709 RVA: 0x00006074 File Offset: 0x00004274
		public void GetComponents<T>(List<T> results)
		{
			long num = 0L;
			long num2 = 0L;
			Type type;
			Array componentsInternal = this.GetComponentsInternal(type, true, num != 0L, true, num2 != 0L, results);
		}

		// Token: 0x060002C6 RID: 710 RVA: 0x00006094 File Offset: 0x00004294
		public T[] GetComponentsInChildren<T>(bool includeInactive)
		{
			Array array;
			while (array != null)
			{
				if (array == null)
				{
					throw new InvalidCastException();
				}
			}
		}

		// Token: 0x060002C7 RID: 711 RVA: 0x000060B0 File Offset: 0x000042B0
		public void GetComponentsInChildren<T>(bool includeInactive, List<T> results)
		{
		}

		// Token: 0x060002C8 RID: 712 RVA: 0x000021B3 File Offset: 0x000003B3
		public T[] GetComponentsInChildren<T>()
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x060002C9 RID: 713 RVA: 0x000060C0 File Offset: 0x000042C0
		public void GetComponentsInParent<T>(bool includeInactive, List<T> results)
		{
		}

		// Token: 0x060002CA RID: 714 RVA: 0x000060D0 File Offset: 0x000042D0
		public T[] GetComponentsInParent<T>(bool includeInactive)
		{
			Array array;
			while (array != null)
			{
				if (array == null)
				{
					throw new InvalidCastException();
				}
			}
		}

		// Token: 0x060002CB RID: 715 RVA: 0x000060EC File Offset: 0x000042EC
		public bool TryGetComponent<T>([Out] T component)
		{
		}

		// Token: 0x060002CC RID: 716 RVA: 0x000060FC File Offset: 0x000042FC
		[FreeFunction(Name = "GameObjectBindings::TryGetComponentFastPath", HasExplicitThis = true, ThrowsException = true)]
		[NativeWritableSelf]
		internal void TryGetComponentFastPath(Type type, IntPtr oneFurtherThanResultValue)
		{
			throw new MissingMethodException();
		}

		// Token: 0x060002CD RID: 717 RVA: 0x00006110 File Offset: 0x00004310
		[FreeFunction(Name = "MonoAddComponentWithType", HasExplicitThis = true)]
		private Component Internal_AddComponentWithType(Type componentType)
		{
			throw new MissingMethodException();
		}

		// Token: 0x060002CE RID: 718 RVA: 0x00006124 File Offset: 0x00004324
		[TypeInferenceRule(TypeInferenceRules.TypeReferencedByFirstArgument)]
		public Component AddComponent(Type componentType)
		{
			throw new MissingMethodException();
		}

		// Token: 0x060002CF RID: 719 RVA: 0x00006138 File Offset: 0x00004338
		public T AddComponent<T>() where T : Component
		{
			Component component;
			while (component != null)
			{
				if (component == null)
				{
					throw new InvalidCastException();
				}
			}
		}

		// Token: 0x170000A5 RID: 165
		// (get) Token: 0x060002D0 RID: 720 RVA: 0x00006154 File Offset: 0x00004354
		public Transform transform
		{
			[FreeFunction("GameObjectBindings::GetTransform", HasExplicitThis = true)]
			get
			{
				throw new MissingMethodException();
			}
		}

		// Token: 0x170000A6 RID: 166
		// (get) Token: 0x060002D1 RID: 721 RVA: 0x00006168 File Offset: 0x00004368
		// (set) Token: 0x060002D2 RID: 722 RVA: 0x0000617C File Offset: 0x0000437C
		public int layer
		{
			get
			{
				throw new MissingMethodException();
			}
			set
			{
				throw new MissingMethodException();
			}
		}

		// Token: 0x060002D3 RID: 723 RVA: 0x00006190 File Offset: 0x00004390
		[NativeMethod(Name = "SetSelfActive")]
		public void SetActive(bool value)
		{
			throw new MissingMethodException();
		}

		// Token: 0x170000A7 RID: 167
		// (get) Token: 0x060002D4 RID: 724 RVA: 0x000061A4 File Offset: 0x000043A4
		public bool activeSelf
		{
			[NativeMethod(Name = "IsSelfActive")]
			get
			{
				throw new MissingMethodException();
			}
		}

		// Token: 0x170000A8 RID: 168
		// (get) Token: 0x060002D5 RID: 725 RVA: 0x000061B8 File Offset: 0x000043B8
		public bool activeInHierarchy
		{
			[NativeMethod(Name = "IsActive")]
			get
			{
				throw new MissingMethodException();
			}
		}

		// Token: 0x060002D6 RID: 726 RVA: 0x000061CC File Offset: 0x000043CC
		[FreeFunction(Name = "Scripting::SendScriptingMessage", HasExplicitThis = true)]
		public void SendMessage(string methodName, [DefaultValue("null")] object value, [DefaultValue("SendMessageOptions.RequireReceiver")] SendMessageOptions options)
		{
			throw new MissingMethodException();
		}

		// Token: 0x060002D7 RID: 727 RVA: 0x000061E0 File Offset: 0x000043E0
		public GameObject(string name)
		{
			if (!true)
			{
			}
			base..ctor();
			throw new MissingMethodException();
		}

		// Token: 0x060002D8 RID: 728 RVA: 0x000061FC File Offset: 0x000043FC
		public GameObject()
		{
			if (!true)
			{
			}
			base..ctor();
			throw new MissingMethodException();
		}

		// Token: 0x060002D9 RID: 729 RVA: 0x00006218 File Offset: 0x00004418
		public GameObject(string name, params Type[] components)
		{
			if (!true)
			{
			}
			base..ctor();
			throw new MissingMethodException();
		}

		// Token: 0x060002DA RID: 730 RVA: 0x0000623C File Offset: 0x0000443C
		[FreeFunction(Name = "GameObjectBindings::Internal_CreateGameObject")]
		private static void Internal_CreateGameObject([Writable] GameObject self, string name)
		{
			throw new MissingMethodException();
		}

		// Token: 0x060002DB RID: 731 RVA: 0x00006250 File Offset: 0x00004450
		[FreeFunction(Name = "GameObjectBindings::Find")]
		public static GameObject Find(string name)
		{
			throw new MissingMethodException();
		}

		// Token: 0x170000A9 RID: 169
		// (get) Token: 0x060002DC RID: 732 RVA: 0x00006264 File Offset: 0x00004464
		public GameObject gameObject
		{
			get
			{
				return this;
			}
		}
	}
}
