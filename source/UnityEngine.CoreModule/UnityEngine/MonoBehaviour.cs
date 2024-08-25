using System;
using System.Collections;
using UnityEngine.Bindings;
using UnityEngine.Internal;
using UnityEngine.Scripting;

namespace UnityEngine
{
	// Token: 0x020000B8 RID: 184
	[ExtensionOfNativeClass]
	[RequiredByNativeCode]
	[NativeHeader("Runtime/Scripting/DelayedCallUtility.h")]
	[NativeHeader("Runtime/Mono/MonoBehaviour.h")]
	public class MonoBehaviour : Behaviour
	{
		// Token: 0x06000326 RID: 806 RVA: 0x00006960 File Offset: 0x00004B60
		public bool IsInvoking()
		{
			throw new MissingMethodException();
		}

		// Token: 0x06000327 RID: 807 RVA: 0x00006974 File Offset: 0x00004B74
		public void CancelInvoke()
		{
			throw new MissingMethodException();
		}

		// Token: 0x06000328 RID: 808 RVA: 0x00006988 File Offset: 0x00004B88
		public void Invoke(string methodName, float time)
		{
			throw new MissingMethodException();
		}

		// Token: 0x06000329 RID: 809 RVA: 0x0000699C File Offset: 0x00004B9C
		public void InvokeRepeating(string methodName, float time, float repeatRate)
		{
			throw new MissingMethodException();
		}

		// Token: 0x0600032A RID: 810 RVA: 0x000069B0 File Offset: 0x00004BB0
		public void CancelInvoke(string methodName)
		{
			throw new MissingMethodException();
		}

		// Token: 0x0600032B RID: 811 RVA: 0x000069C4 File Offset: 0x00004BC4
		public bool IsInvoking(string methodName)
		{
			throw new MissingMethodException();
		}

		// Token: 0x0600032C RID: 812 RVA: 0x000069D8 File Offset: 0x00004BD8
		[ExcludeFromDocs]
		public Coroutine StartCoroutine(string methodName)
		{
			long num = 0L;
			return this.StartCoroutine(methodName, num);
		}

		// Token: 0x0600032D RID: 813 RVA: 0x000069F0 File Offset: 0x00004BF0
		public Coroutine StartCoroutine(string methodName, [DefaultValue("null")] object value)
		{
			bool flag = string.IsNullOrEmpty(methodName);
			throw new MissingMethodException();
		}

		// Token: 0x0600032E RID: 814 RVA: 0x00006A10 File Offset: 0x00004C10
		public Coroutine StartCoroutine(IEnumerator routine)
		{
			while (routine == null)
			{
			}
			throw new MissingMethodException();
		}

		// Token: 0x0600032F RID: 815 RVA: 0x00006A2C File Offset: 0x00004C2C
		[Obsolete("StartCoroutine_Auto has been deprecated. Use StartCoroutine instead (UnityUpgradable) -> StartCoroutine([mscorlib] System.Collections.IEnumerator)", false)]
		public Coroutine StartCoroutine_Auto(IEnumerator routine)
		{
			return this.StartCoroutine(routine);
		}

		// Token: 0x06000330 RID: 816 RVA: 0x00006A40 File Offset: 0x00004C40
		public void StopCoroutine(IEnumerator routine)
		{
			if (routine != null)
			{
				throw new MissingMethodException();
			}
		}

		// Token: 0x06000331 RID: 817 RVA: 0x00006A60 File Offset: 0x00004C60
		public void StopCoroutine(Coroutine routine)
		{
			if (routine != null)
			{
				throw new MissingMethodException();
			}
		}

		// Token: 0x06000332 RID: 818 RVA: 0x00006A80 File Offset: 0x00004C80
		public void StopCoroutine(string methodName)
		{
			throw new MissingMethodException();
		}

		// Token: 0x06000333 RID: 819 RVA: 0x00006A94 File Offset: 0x00004C94
		public void StopAllCoroutines()
		{
			throw new MissingMethodException();
		}

		// Token: 0x170000B1 RID: 177
		// (get) Token: 0x06000334 RID: 820 RVA: 0x00006AA8 File Offset: 0x00004CA8
		// (set) Token: 0x06000335 RID: 821 RVA: 0x00006ABC File Offset: 0x00004CBC
		public bool useGUILayout
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

		// Token: 0x06000336 RID: 822 RVA: 0x00006AD0 File Offset: 0x00004CD0
		public static void print(object message)
		{
			if (!true)
			{
			}
			Debug.Log(message);
		}

		// Token: 0x06000337 RID: 823 RVA: 0x00006AE8 File Offset: 0x00004CE8
		[FreeFunction("CancelInvoke")]
		private static void Internal_CancelInvokeAll([NotNull("NullExceptionObject")] MonoBehaviour self)
		{
			throw new MissingMethodException();
		}

		// Token: 0x06000338 RID: 824 RVA: 0x00006AFC File Offset: 0x00004CFC
		[FreeFunction("IsInvoking")]
		private static bool Internal_IsInvokingAll([NotNull("NullExceptionObject")] MonoBehaviour self)
		{
			throw new MissingMethodException();
		}

		// Token: 0x06000339 RID: 825 RVA: 0x00006B10 File Offset: 0x00004D10
		[FreeFunction]
		private static void InvokeDelayed([NotNull("NullExceptionObject")] MonoBehaviour self, string methodName, float time, float repeatRate)
		{
			throw new MissingMethodException();
		}

		// Token: 0x0600033A RID: 826 RVA: 0x00006B24 File Offset: 0x00004D24
		[FreeFunction]
		private static void CancelInvoke([NotNull("NullExceptionObject")] MonoBehaviour self, string methodName)
		{
			throw new MissingMethodException();
		}

		// Token: 0x0600033B RID: 827 RVA: 0x00006B38 File Offset: 0x00004D38
		[FreeFunction]
		private static bool IsInvoking([NotNull("NullExceptionObject")] MonoBehaviour self, string methodName)
		{
			throw new MissingMethodException();
		}

		// Token: 0x0600033C RID: 828 RVA: 0x00006B4C File Offset: 0x00004D4C
		[FreeFunction]
		private static bool IsObjectMonoBehaviour([NotNull("NullExceptionObject")] Object obj)
		{
			throw new MissingMethodException();
		}

		// Token: 0x0600033D RID: 829 RVA: 0x00006B60 File Offset: 0x00004D60
		private Coroutine StartCoroutineManaged(string methodName, object value)
		{
			throw new MissingMethodException();
		}

		// Token: 0x0600033E RID: 830 RVA: 0x00006B74 File Offset: 0x00004D74
		private Coroutine StartCoroutineManaged2(IEnumerator enumerator)
		{
			throw new MissingMethodException();
		}

		// Token: 0x0600033F RID: 831 RVA: 0x00006B88 File Offset: 0x00004D88
		private void StopCoroutineManaged(Coroutine routine)
		{
			throw new MissingMethodException();
		}

		// Token: 0x06000340 RID: 832 RVA: 0x00006B9C File Offset: 0x00004D9C
		private void StopCoroutineFromEnumeratorManaged(IEnumerator routine)
		{
			throw new MissingMethodException();
		}

		// Token: 0x06000341 RID: 833 RVA: 0x00006BB0 File Offset: 0x00004DB0
		internal string GetScriptClassName()
		{
			throw new MissingMethodException();
		}

		// Token: 0x06000342 RID: 834 RVA: 0x00006BC4 File Offset: 0x00004DC4
		public MonoBehaviour()
		{
		}
	}
}
