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
	// Token: 0x020000CB RID: 203
	[DefaultMember("Item")]
	[NativeClass("Matrix4x4f")]
	[NativeType(Header = "Runtime/Math/Matrix4x4.h")]
	[NativeHeader("Runtime/Math/MathScripting.h")]
	[RequiredByNativeCode(Optional = true, GenerateProxy = true)]
	[Il2CppEagerStaticClassConstruction]
	public struct Matrix4x4 : IEquatable<Matrix4x4>, IFormattable
	{
		// Token: 0x060003AE RID: 942 RVA: 0x000074A4 File Offset: 0x000056A4
		public Matrix4x4(Vector4 column0, Vector4 column1, Vector4 column2, Vector4 column3)
		{
		}

		// Token: 0x060003AF RID: 943 RVA: 0x000074B4 File Offset: 0x000056B4
		public override int GetHashCode()
		{
			float num = this.m01;
			float num2 = this.m02;
			float num3 = this.m03;
			int num4;
			return num4;
		}

		// Token: 0x060003B0 RID: 944 RVA: 0x000074DC File Offset: 0x000056DC
		public override bool Equals(object other)
		{
			if (other != null)
			{
				return;
			}
		}

		// Token: 0x060003B1 RID: 945 RVA: 0x000074F0 File Offset: 0x000056F0
		public bool Equals(Matrix4x4 other)
		{
			/*
An exception occurred when decompiling this method (060003B1)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean UnityEngine.Matrix4x4::Equals(UnityEngine.Matrix4x4)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:float32(var_0_06, ldfld:float32(Matrix4x4::m30, ldloc:valuetype UnityEngine.Matrix4x4&(this)))
	stloc:float32(var_1_0D, ldfld:float32(Matrix4x4::m30, ldloc:Matrix4x4[exp:valuetype UnityEngine.Matrix4x4&](other)))
	stloc:float32(var_2_14, ldfld:float32(Matrix4x4::m20, ldloc:valuetype UnityEngine.Matrix4x4&(this)))
	stloc:float32(var_3_1B, ldfld:float32(Matrix4x4::m20, ldloc:Matrix4x4[exp:valuetype UnityEngine.Matrix4x4&](other)))
	stloc:float32(var_4_22, ldfld:float32(Matrix4x4::m10, ldloc:valuetype UnityEngine.Matrix4x4&(this)))
	stloc:float32(var_5_2A, ldfld:float32(Matrix4x4::m10, ldloc:Matrix4x4[exp:valuetype UnityEngine.Matrix4x4&](other)))
	stloc:float32(var_6_32, ldfld:float32(Matrix4x4::m31, ldloc:valuetype UnityEngine.Matrix4x4&(this)))
	stloc:float32(var_7_3A, ldfld:float32(Matrix4x4::m31, ldloc:Matrix4x4[exp:valuetype UnityEngine.Matrix4x4&](other)))
	stloc:float32(var_8_42, ldfld:float32(Matrix4x4::m21, ldloc:valuetype UnityEngine.Matrix4x4&(this)))
	stloc:float32(var_9_4A, ldfld:float32(Matrix4x4::m21, ldloc:Matrix4x4[exp:valuetype UnityEngine.Matrix4x4&](other)))
	stloc:float32(var_10_52, ldfld:float32(Matrix4x4::m11, ldloc:valuetype UnityEngine.Matrix4x4&(this)))
	stloc:float32(var_11_5A, ldfld:float32(Matrix4x4::m11, ldloc:Matrix4x4[exp:valuetype UnityEngine.Matrix4x4&](other)))
	stloc:float32(var_12_62, ldfld:float32(Matrix4x4::m01, ldloc:valuetype UnityEngine.Matrix4x4&(this)))
	stloc:float32(var_13_6A, ldfld:float32(Matrix4x4::m01, ldloc:Matrix4x4[exp:valuetype UnityEngine.Matrix4x4&](other)))
	stloc:float32(var_14_72, ldfld:float32(Matrix4x4::m32, ldloc:valuetype UnityEngine.Matrix4x4&(this)))
	stloc:float32(var_15_7A, ldfld:float32(Matrix4x4::m32, ldloc:Matrix4x4[exp:valuetype UnityEngine.Matrix4x4&](other)))
	stloc:float32(var_16_82, ldfld:float32(Matrix4x4::m22, ldloc:valuetype UnityEngine.Matrix4x4&(this)))
	stloc:float32(var_17_8A, ldfld:float32(Matrix4x4::m22, ldloc:Matrix4x4[exp:valuetype UnityEngine.Matrix4x4&](other)))
	stloc:float32(var_18_92, ldfld:float32(Matrix4x4::m12, ldloc:valuetype UnityEngine.Matrix4x4&(this)))
	stloc:float32(var_19_9A, ldfld:float32(Matrix4x4::m12, ldloc:Matrix4x4[exp:valuetype UnityEngine.Matrix4x4&](other)))
	stloc:float32(var_20_A2, ldfld:float32(Matrix4x4::m02, ldloc:valuetype UnityEngine.Matrix4x4&(this)))
	stloc:float32(var_21_AA, ldfld:float32(Matrix4x4::m02, ldloc:Matrix4x4[exp:valuetype UnityEngine.Matrix4x4&](other)))
	stloc:float32(var_22_B2, ldfld:float32(Matrix4x4::m03, ldloc:valuetype UnityEngine.Matrix4x4&(this)))
	stloc:float32(var_23_BA, ldfld:float32(Matrix4x4::m13, ldloc:valuetype UnityEngine.Matrix4x4&(this)))
	stloc:float32(var_24_C2, ldfld:float32(Matrix4x4::m03, ldloc:Matrix4x4[exp:valuetype UnityEngine.Matrix4x4&](other)))
	stloc:float32(var_25_CA, ldfld:float32(Matrix4x4::m13, ldloc:Matrix4x4[exp:valuetype UnityEngine.Matrix4x4&](other)))
	stloc:float32(var_26_D2, ldfld:float32(Matrix4x4::m23, ldloc:valuetype UnityEngine.Matrix4x4&(this)))
	stloc:float32(var_27_DA, ldfld:float32(Matrix4x4::m33, ldloc:valuetype UnityEngine.Matrix4x4&(this)))
	stloc:float32(var_28_E2, ldfld:float32(Matrix4x4::m23, ldloc:Matrix4x4[exp:valuetype UnityEngine.Matrix4x4&](other)))
	stloc:float32(var_29_EA, ldfld:float32(Matrix4x4::m33, ldloc:Matrix4x4[exp:valuetype UnityEngine.Matrix4x4&](other)))
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

		// Token: 0x060003B2 RID: 946 RVA: 0x000021B3 File Offset: 0x000003B3
		public Vector4 GetColumn(int index)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x060003B3 RID: 947 RVA: 0x000075EC File Offset: 0x000057EC
		public Vector3 MultiplyPoint(Vector3 point)
		{
			float num = this.m20;
			float num2 = this.m30;
			float num3 = this.m01;
			float num4 = this.m21;
			float num5 = this.m31;
			float num6 = this.m02;
			float num7 = this.m22;
			float num8 = this.m32;
			float num9 = this.m23;
			float num10 = this.m33;
			float num11 = this.m03;
			Vector3 vector;
			return vector;
		}

		// Token: 0x060003B4 RID: 948 RVA: 0x00007650 File Offset: 0x00005850
		public Vector3 MultiplyPoint3x4(Vector3 point)
		{
			float num = this.m20;
			float num2 = this.m01;
			float num3 = this.m21;
			float num4 = this.m02;
			float num5 = this.m22;
			float num6 = this.m03;
			float num7 = this.m23;
			Vector3 vector;
			return vector;
		}

		// Token: 0x060003B5 RID: 949 RVA: 0x00007694 File Offset: 0x00005894
		public override string ToString()
		{
			string text;
			return text;
		}

		// Token: 0x060003B6 RID: 950 RVA: 0x000076A4 File Offset: 0x000058A4
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
			string text5;
			string text6;
			string text7;
			string text8;
			string text9;
			string text10;
			string text11;
			string text12;
			string text13;
			string text14;
			string text15;
			string text16;
			if ((text == null || text != null) && (text2 == null || text2 != null) && (text3 == null || text3 != null) && (text4 == null || text4 != null) && (text5 == null || text5 != null) && (text6 == null || text6 != null) && (text7 == null || text7 != null) && (text8 == null || text8 != null) && (text9 == null || text9 != null) && (text10 == null || text10 != null) && (text11 == null || text11 != null) && (text12 == null || text12 != null) && (text13 == null || text13 != null) && (text14 == null || text14 != null) && (text15 == null || text15 != null) && (text16 == null || text16 != null))
			{
				string text17;
				return text17;
			}
			throw new ArrayTypeMismatchException();
		}

		// Token: 0x060003B7 RID: 951 RVA: 0x00007764 File Offset: 0x00005964
		[FreeFunction("MatrixScripting::Ortho", IsThreadSafe = true)]
		public static Matrix4x4 Ortho(float left, float right, float bottom, float top, float zNear, float zFar)
		{
			throw new MissingMethodException();
		}

		// Token: 0x060003B8 RID: 952 RVA: 0x00007794 File Offset: 0x00005994
		// Note: this type is marked as 'beforefieldinit'.
		static Matrix4x4()
		{
		}

		// Token: 0x060003B9 RID: 953 RVA: 0x000077A4 File Offset: 0x000059A4
		private static void Ortho_Injected(float left, float right, float bottom, float top, float zNear, float zFar, [Out] Matrix4x4 ret)
		{
			throw new MissingMethodException();
		}

		// Token: 0x04000391 RID: 913
		[NativeName("m_Data[0]")]
		public float m00;

		// Token: 0x04000392 RID: 914
		[NativeName("m_Data[1]")]
		public float m10;

		// Token: 0x04000393 RID: 915
		[NativeName("m_Data[2]")]
		public float m20;

		// Token: 0x04000394 RID: 916
		[NativeName("m_Data[3]")]
		public float m30;

		// Token: 0x04000395 RID: 917
		[NativeName("m_Data[4]")]
		public float m01;

		// Token: 0x04000396 RID: 918
		[NativeName("m_Data[5]")]
		public float m11;

		// Token: 0x04000397 RID: 919
		[NativeName("m_Data[6]")]
		public float m21;

		// Token: 0x04000398 RID: 920
		[NativeName("m_Data[7]")]
		public float m31;

		// Token: 0x04000399 RID: 921
		[NativeName("m_Data[8]")]
		public float m02;

		// Token: 0x0400039A RID: 922
		[NativeName("m_Data[9]")]
		public float m12;

		// Token: 0x0400039B RID: 923
		[NativeName("m_Data[10]")]
		public float m22;

		// Token: 0x0400039C RID: 924
		[NativeName("m_Data[11]")]
		public float m32;

		// Token: 0x0400039D RID: 925
		[NativeName("m_Data[12]")]
		public float m03;

		// Token: 0x0400039E RID: 926
		[NativeName("m_Data[13]")]
		public float m13;

		// Token: 0x0400039F RID: 927
		[NativeName("m_Data[14]")]
		public float m23;

		// Token: 0x040003A0 RID: 928
		[NativeName("m_Data[15]")]
		public float m33;

		// Token: 0x040003A1 RID: 929
		private static readonly Matrix4x4 zeroMatrix;

		// Token: 0x040003A2 RID: 930
		private static readonly Matrix4x4 identityMatrix;
	}
}
