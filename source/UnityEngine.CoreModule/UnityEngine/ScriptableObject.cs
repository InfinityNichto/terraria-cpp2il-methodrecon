using System;
using System.Runtime.InteropServices;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine
{
	// Token: 0x020000AB RID: 171
	[NativeClass(null)]
	[RequiredByNativeCode]
	[ExtensionOfNativeClass]
	[NativeHeader("Runtime/Mono/MonoBehaviour.h")]
	[StructLayout(0)]
	public class ScriptableObject : Object
	{
		// Token: 0x06000310 RID: 784 RVA: 0x000066DC File Offset: 0x000048DC
		public ScriptableObject()
		{
			if (!true)
			{
			}
			base..ctor();
			throw new MissingMethodException();
		}

		// Token: 0x06000311 RID: 785 RVA: 0x000066F8 File Offset: 0x000048F8
		public static ScriptableObject CreateInstance(Type type)
		{
			throw new MissingMethodException();
		}

		// Token: 0x06000312 RID: 786 RVA: 0x0000670C File Offset: 0x0000490C
		public static T CreateInstance<T>() where T : ScriptableObject
		{
			ScriptableObject scriptableObject;
			do
			{
				Type type;
				scriptableObject = ScriptableObject.CreateInstance(type);
				if (scriptableObject == null)
				{
					return;
				}
			}
			while (scriptableObject != null);
			throw new InvalidCastException();
		}

		// Token: 0x06000313 RID: 787 RVA: 0x00006730 File Offset: 0x00004930
		[NativeMethod(IsThreadSafe = true)]
		private static void CreateScriptableObject([Writable] ScriptableObject self)
		{
			throw new MissingMethodException();
		}

		// Token: 0x06000314 RID: 788 RVA: 0x00006744 File Offset: 0x00004944
		[FreeFunction("Scripting::CreateScriptableObjectWithType")]
		internal static ScriptableObject CreateScriptableObjectInstanceFromType(Type type, bool applyDefaultsAndReset)
		{
			throw new MissingMethodException();
		}
	}
}
