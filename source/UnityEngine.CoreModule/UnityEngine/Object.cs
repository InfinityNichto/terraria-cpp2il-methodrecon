using System;
using System.Runtime.InteropServices;
using UnityEngine.Bindings;
using UnityEngine.Internal;
using UnityEngine.Scripting;
using UnityEngineInternal;

namespace UnityEngine
{
	// Token: 0x020000A3 RID: 163
	[RequiredByNativeCode(GenerateProxy = true)]
	[NativeHeader("Runtime/GameCode/CloneObject.h")]
	[NativeHeader("Runtime/SceneManager/SceneManager.h")]
	[NativeHeader("Runtime/Export/Scripting/UnityEngineObject.bindings.h")]
	[StructLayout(0)]
	public class Object
	{
		// Token: 0x060002DF RID: 735 RVA: 0x0000629C File Offset: 0x0000449C
		public int GetInstanceID()
		{
			IntPtr cachedPtr = this.m_CachedPtr;
			throw new MissingMethodException();
		}

		// Token: 0x060002E0 RID: 736 RVA: 0x000062BC File Offset: 0x000044BC
		public override int GetHashCode()
		{
			return base.GetHashCode();
		}

		// Token: 0x060002E1 RID: 737 RVA: 0x000062D0 File Offset: 0x000044D0
		public override bool Equals(object other)
		{
			if (other != null)
			{
			}
			if (other != null)
			{
			}
			bool flag;
			return flag;
		}

		// Token: 0x060002E2 RID: 738 RVA: 0x000062E8 File Offset: 0x000044E8
		public static implicit operator bool(Object exists)
		{
			if (!true)
			{
			}
			bool flag;
			return flag;
		}

		// Token: 0x060002E3 RID: 739 RVA: 0x000062FC File Offset: 0x000044FC
		private static bool CompareBaseObjects(Object lhs, Object rhs)
		{
			if (!true)
			{
			}
			if (lhs != null)
			{
			}
			return Object.IsNativeObjectAlive(lhs);
		}

		// Token: 0x060002E4 RID: 740 RVA: 0x00006318 File Offset: 0x00004518
		private static bool IsNativeObjectAlive(Object o)
		{
			bool flag;
			return flag;
		}

		// Token: 0x060002E5 RID: 741 RVA: 0x00006328 File Offset: 0x00004528
		private IntPtr GetCachedPtr()
		{
			return this.m_CachedPtr;
		}

		// Token: 0x170000AB RID: 171
		// (get) Token: 0x060002E6 RID: 742 RVA: 0x0000633C File Offset: 0x0000453C
		// (set) Token: 0x060002E7 RID: 743 RVA: 0x00006354 File Offset: 0x00004554
		public string name
		{
			get
			{
				if (!true)
				{
				}
				throw new MissingMethodException();
			}
			set
			{
				if (!true)
				{
				}
				throw new MissingMethodException();
			}
		}

		// Token: 0x060002E8 RID: 744 RVA: 0x0000636C File Offset: 0x0000456C
		[TypeInferenceRule(TypeInferenceRules.TypeOfFirstArgument)]
		public static Object Instantiate(Object original, Vector3 position, Quaternion rotation)
		{
			if (!true)
			{
			}
			Object @object;
			return @object;
		}

		// Token: 0x060002E9 RID: 745 RVA: 0x00006380 File Offset: 0x00004580
		[TypeInferenceRule(TypeInferenceRules.TypeOfFirstArgument)]
		public static Object Instantiate(Object original)
		{
			if (!true)
			{
			}
			throw new MissingMethodException();
		}

		// Token: 0x060002EA RID: 746 RVA: 0x00006398 File Offset: 0x00004598
		public static T Instantiate<T>(T original) where T : Object
		{
			Object @object;
			do
			{
				if (!true)
				{
				}
				if (@object == null)
				{
					return;
				}
			}
			while (@object != null);
			throw new InvalidCastException();
		}

		// Token: 0x060002EB RID: 747 RVA: 0x000063B8 File Offset: 0x000045B8
		public static T Instantiate<T>(T original, Vector3 position, Quaternion rotation) where T : Object
		{
			Object @object;
			do
			{
				if (!true)
				{
				}
				if (@object == null)
				{
					return;
				}
			}
			while (@object != null);
			throw new InvalidCastException();
		}

		// Token: 0x060002EC RID: 748 RVA: 0x000063D8 File Offset: 0x000045D8
		[NativeMethod(Name = "Scripting::DestroyObjectFromScripting", IsFreeFunction = true, ThrowsException = true)]
		public static void Destroy(Object obj, [DefaultValue("0.0F")] float t)
		{
			throw new MissingMethodException();
		}

		// Token: 0x060002ED RID: 749 RVA: 0x000063EC File Offset: 0x000045EC
		[ExcludeFromDocs]
		public static void Destroy(Object obj)
		{
			if (!true)
			{
			}
			throw new MissingMethodException();
		}

		// Token: 0x060002EE RID: 750 RVA: 0x00006404 File Offset: 0x00004604
		[NativeMethod(Name = "Scripting::DestroyObjectFromScriptingImmediate", IsFreeFunction = true, ThrowsException = true)]
		public static void DestroyImmediate(Object obj, [DefaultValue("false")] bool allowDestroyingAssets)
		{
			throw new MissingMethodException();
		}

		// Token: 0x060002EF RID: 751 RVA: 0x00006418 File Offset: 0x00004618
		[ExcludeFromDocs]
		public static void DestroyImmediate(Object obj)
		{
			if (!true)
			{
			}
			throw new MissingMethodException();
		}

		// Token: 0x060002F0 RID: 752 RVA: 0x00006430 File Offset: 0x00004630
		[FreeFunction("UnityEngineObjectBindings::FindObjectsOfType")]
		[TypeInferenceRule(TypeInferenceRules.ArrayOfTypeReferencedByFirstArgument)]
		public static Object[] FindObjectsOfType(Type type, bool includeInactive)
		{
			throw new MissingMethodException();
		}

		// Token: 0x060002F1 RID: 753 RVA: 0x00006444 File Offset: 0x00004644
		[FreeFunction("GetSceneManager().DontDestroyOnLoad", ThrowsException = true)]
		public static void DontDestroyOnLoad([NotNull("NullExceptionObject")] Object target)
		{
			throw new MissingMethodException();
		}

		// Token: 0x170000AC RID: 172
		// (set) Token: 0x060002F2 RID: 754 RVA: 0x00006458 File Offset: 0x00004658
		public HideFlags hideFlags
		{
			set
			{
				throw new MissingMethodException();
			}
		}

		// Token: 0x060002F3 RID: 755 RVA: 0x0000646C File Offset: 0x0000466C
		public static T[] FindObjectsOfType<T>() where T : Object
		{
			/*
An exception occurred when decompiling this method (060002F3)

ICSharpCode.Decompiler.DecompilerException: Error decompiling T[] UnityEngine.Object::FindObjectsOfType<T>()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:int64(var_1_01, ldc.i4:int64(0))
	stloc:class UnityEngine.Object[](var_2_09, call:class UnityEngine.Object[](Object::FindObjectsOfType, ldloc:Type(var_0), ldloc:int64[exp:bool](var_1_01)))
}

   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1852
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.Optimize(DecompilerContext context, ILBlock method, AutoPropertyProvider autoPropertyProvider, StateMachineKind& stateMachineKind, MethodDef& inlinedMethod, AsyncMethodDebugInfo& asyncInfo, ILAstOptimizationStep abortBeforeStep) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 355
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(IEnumerable`1 parameters, MethodDebugInfoBuilder& builder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 123
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 88
   --- End of inner exception stack trace ---
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 92
   at ICSharpCode.Decompiler.Ast.AstBuilder.AddMethodBody(EntityDeclaration methodNode, EntityDeclaration& updatedNode, MethodDef method, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, MethodKind methodKind) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 1683
*/;
		}

		// Token: 0x060002F4 RID: 756 RVA: 0x00006484 File Offset: 0x00004684
		private static void CheckNullArgument(object arg, string message)
		{
			while (arg == null)
			{
			}
		}

		// Token: 0x060002F5 RID: 757 RVA: 0x00006494 File Offset: 0x00004694
		public override string ToString()
		{
			if (!true)
			{
			}
			throw new MissingMethodException();
		}

		// Token: 0x060002F6 RID: 758 RVA: 0x000064AC File Offset: 0x000046AC
		public static bool operator ==(Object x, Object y)
		{
			if (!true)
			{
			}
			bool flag;
			return flag;
		}

		// Token: 0x060002F7 RID: 759 RVA: 0x000064C0 File Offset: 0x000046C0
		public static bool operator !=(Object x, Object y)
		{
			if (!true)
			{
			}
			bool flag;
			return flag;
		}

		// Token: 0x060002F8 RID: 760 RVA: 0x000064D4 File Offset: 0x000046D4
		[NativeMethod(Name = "Object::GetOffsetOfInstanceIdMember", IsFreeFunction = true, IsThreadSafe = true)]
		private static int GetOffsetOfInstanceIDInCPlusPlusObject()
		{
			throw new MissingMethodException();
		}

		// Token: 0x060002F9 RID: 761 RVA: 0x000064E8 File Offset: 0x000046E8
		[NativeMethod(Name = "CloneObject", IsFreeFunction = true, ThrowsException = true)]
		private static Object Internal_CloneSingle([NotNull("NullExceptionObject")] Object data)
		{
			throw new MissingMethodException();
		}

		// Token: 0x060002FA RID: 762 RVA: 0x000064FC File Offset: 0x000046FC
		[FreeFunction("InstantiateObject")]
		private static Object Internal_InstantiateSingle([NotNull("NullExceptionObject")] Object data, Vector3 pos, Quaternion rot)
		{
			if (!true)
			{
			}
			throw new MissingMethodException();
		}

		// Token: 0x060002FB RID: 763 RVA: 0x00006514 File Offset: 0x00004714
		[FreeFunction("UnityEngineObjectBindings::ToString")]
		private static string ToString(Object obj)
		{
			throw new MissingMethodException();
		}

		// Token: 0x060002FC RID: 764 RVA: 0x00006528 File Offset: 0x00004728
		[FreeFunction("UnityEngineObjectBindings::GetName")]
		private static string GetName([NotNull("NullExceptionObject")] Object obj)
		{
			throw new MissingMethodException();
		}

		// Token: 0x060002FD RID: 765 RVA: 0x0000653C File Offset: 0x0000473C
		[FreeFunction("UnityEngineObjectBindings::SetName")]
		private static void SetName([NotNull("NullExceptionObject")] Object obj, string name)
		{
			throw new MissingMethodException();
		}

		// Token: 0x060002FE RID: 766 RVA: 0x00006550 File Offset: 0x00004750
		[VisibleToOtherModules]
		[FreeFunction("UnityEngineObjectBindings::FindObjectFromInstanceID")]
		internal static Object FindObjectFromInstanceID(int instanceID)
		{
			throw new MissingMethodException();
		}

		// Token: 0x060002FF RID: 767 RVA: 0x00006564 File Offset: 0x00004764
		public Object()
		{
		}

		// Token: 0x06000300 RID: 768 RVA: 0x00006578 File Offset: 0x00004778
		// Note: this type is marked as 'beforefieldinit'.
		static Object()
		{
		}

		// Token: 0x06000301 RID: 769 RVA: 0x00006588 File Offset: 0x00004788
		private static Object Internal_InstantiateSingle_Injected(Object data, Vector3 pos, Quaternion rot)
		{
			throw new MissingMethodException();
		}

		// Token: 0x0400035D RID: 861
		private IntPtr m_CachedPtr;

		// Token: 0x0400035E RID: 862
		internal static int OffsetOfInstanceIDInCPlusPlusObject;

		// Token: 0x0400035F RID: 863
		private const string objectIsNullMessage = "The Object you want to instantiate is null.";

		// Token: 0x04000360 RID: 864
		private const string cloneDestroyedMessage = "Instantiate failed because the clone was destroyed during creation. This can happen if DestroyImmediate is called in MonoBehaviour.Awake.";
	}
}
