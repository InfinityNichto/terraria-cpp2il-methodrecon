using System;
using System.Globalization;
using System.Reflection;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Unity.IL2CPP.CompilerServices;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine
{
	// Token: 0x020000D0 RID: 208
	[NativeHeader("Runtime/Math/MathScripting.h")]
	[DefaultMember("Item")]
	[NativeType(Header = "Runtime/Math/Quaternion.h")]
	[Il2CppEagerStaticClassConstruction]
	[UsedByNativeCode]
	public struct Quaternion : IEquatable<Quaternion>, IFormattable
	{
		// Token: 0x06000411 RID: 1041 RVA: 0x00007CFC File Offset: 0x00005EFC
		[FreeFunction(IsThreadSafe = true)]
		public static Quaternion Inverse(Quaternion rotation)
		{
			throw new MissingMethodException();
		}

		// Token: 0x06000412 RID: 1042 RVA: 0x00007D10 File Offset: 0x00005F10
		[FreeFunction("EulerToQuaternion", IsThreadSafe = true)]
		private static Quaternion Internal_FromEulerRad(Vector3 euler)
		{
			throw new MissingMethodException();
		}

		// Token: 0x06000413 RID: 1043 RVA: 0x00007D24 File Offset: 0x00005F24
		[FreeFunction("QuaternionScripting::ToEuler", IsThreadSafe = true)]
		private static Vector3 Internal_ToEulerRad(Quaternion rotation)
		{
			throw new MissingMethodException();
		}

		// Token: 0x06000414 RID: 1044 RVA: 0x00007D38 File Offset: 0x00005F38
		[FreeFunction("QuaternionScripting::AngleAxis", IsThreadSafe = true)]
		public static Quaternion AngleAxis(float angle, Vector3 axis)
		{
			throw new MissingMethodException();
		}

		// Token: 0x06000415 RID: 1045 RVA: 0x00007D4C File Offset: 0x00005F4C
		public Quaternion(float x, float y, float z, float w)
		{
		}

		// Token: 0x170000DD RID: 221
		// (get) Token: 0x06000416 RID: 1046 RVA: 0x000021B3 File Offset: 0x000003B3
		public static Quaternion identity
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		// Token: 0x06000417 RID: 1047 RVA: 0x00007D5C File Offset: 0x00005F5C
		public static Vector3 operator *(Quaternion rotation, Vector3 point)
		{
			Vector3 vector;
			return vector;
		}

		// Token: 0x06000418 RID: 1048 RVA: 0x000021B3 File Offset: 0x000003B3
		private static bool IsEqualUsingDot(float dot)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06000419 RID: 1049 RVA: 0x000021B3 File Offset: 0x000003B3
		public static bool operator ==(Quaternion lhs, Quaternion rhs)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x0600041A RID: 1050 RVA: 0x000021B3 File Offset: 0x000003B3
		public static bool operator !=(Quaternion lhs, Quaternion rhs)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x0600041B RID: 1051 RVA: 0x000021B3 File Offset: 0x000003B3
		public static float Dot(Quaternion a, Quaternion b)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x0600041C RID: 1052 RVA: 0x00007D6C File Offset: 0x00005F6C
		private static Vector3 Internal_MakePositive(Vector3 euler)
		{
			return 17332;
		}

		// Token: 0x170000DE RID: 222
		// (get) Token: 0x0600041D RID: 1053 RVA: 0x00007D84 File Offset: 0x00005F84
		// (set) Token: 0x0600041E RID: 1054 RVA: 0x00007DBC File Offset: 0x00005FBC
		public Vector3 eulerAngles
		{
			get
			{
				/*
An exception occurred when decompiling this method (0600041D)

ICSharpCode.Decompiler.DecompilerException: Error decompiling UnityEngine.Vector3 UnityEngine.Quaternion::get_eulerAngles()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:float32(var_0_06, ldfld:float32(Quaternion::x, ldloc:valuetype UnityEngine.Quaternion&(this)))
	stloc:float32(var_1_0D, ldfld:float32(Quaternion::y, ldloc:valuetype UnityEngine.Quaternion&(this)))
	stloc:float32(var_2_14, ldfld:float32(Quaternion::z, ldloc:valuetype UnityEngine.Quaternion&(this)))
	stloc:float32(var_3_1B, ldfld:float32(Quaternion::w, ldloc:valuetype UnityEngine.Quaternion&(this)))
	stloc:Vector3(var_4_27, call:Vector3(Quaternion::Internal_MakePositive, call:Vector3(Quaternion::Internal_ToEulerRad, ldloc:valuetype UnityEngine.Quaternion&[exp:Quaternion](this))))
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
			set
			{
			}
		}

		// Token: 0x0600041F RID: 1055 RVA: 0x00007DCC File Offset: 0x00005FCC
		public override int GetHashCode()
		{
			int num;
			return num;
		}

		// Token: 0x06000420 RID: 1056 RVA: 0x00007DDC File Offset: 0x00005FDC
		public override bool Equals(object other)
		{
			if (other != null)
			{
				bool flag;
				return flag;
			}
		}

		// Token: 0x06000421 RID: 1057 RVA: 0x00007DF0 File Offset: 0x00005FF0
		public bool Equals(Quaternion other)
		{
			bool flag;
			return flag;
		}

		// Token: 0x06000422 RID: 1058 RVA: 0x00007E04 File Offset: 0x00006004
		public override string ToString()
		{
			string text;
			return text;
		}

		// Token: 0x06000423 RID: 1059 RVA: 0x00007E14 File Offset: 0x00006014
		public string ToString(string format, IFormatProvider formatProvider)
		{
			bool flag = string.IsNullOrEmpty(format);
			if (formatProvider == null)
			{
				CultureInfo invariantCulture = CultureInfo.InvariantCulture;
			}
			string text;
			string text2;
			string text3;
			string text4;
			if ((text == null || text != null) && (text2 == null || text2 != null) && (text3 == null || text3 != null) && (text4 == null || text4 != null))
			{
				string text5;
				return text5;
			}
			throw new ArrayTypeMismatchException();
		}

		// Token: 0x06000424 RID: 1060 RVA: 0x00007E60 File Offset: 0x00006060
		// Note: this type is marked as 'beforefieldinit'.
		static Quaternion()
		{
		}

		// Token: 0x06000425 RID: 1061 RVA: 0x00007E70 File Offset: 0x00006070
		private static void Inverse_Injected(Quaternion rotation, [Out] Quaternion ret)
		{
			throw new MissingMethodException();
		}

		// Token: 0x06000426 RID: 1062 RVA: 0x00007E84 File Offset: 0x00006084
		private static void Internal_FromEulerRad_Injected(Vector3 euler, [Out] Quaternion ret)
		{
			throw new MissingMethodException();
		}

		// Token: 0x06000427 RID: 1063 RVA: 0x00007E98 File Offset: 0x00006098
		private static void Internal_ToEulerRad_Injected(Quaternion rotation, [Out] Vector3 ret)
		{
			throw new MissingMethodException();
		}

		// Token: 0x06000428 RID: 1064 RVA: 0x00007EAC File Offset: 0x000060AC
		private static void AngleAxis_Injected(float angle, Vector3 axis, [Out] Quaternion ret)
		{
			throw new MissingMethodException();
		}

		// Token: 0x040003C4 RID: 964
		public float x;

		// Token: 0x040003C5 RID: 965
		public float y;

		// Token: 0x040003C6 RID: 966
		public float z;

		// Token: 0x040003C7 RID: 967
		public float w;

		// Token: 0x040003C8 RID: 968
		private static readonly Quaternion identityQuaternion;
	}
}
