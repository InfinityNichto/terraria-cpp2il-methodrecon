using System;
using System.Globalization;
using Cpp2IlInjected;
using Unity.IL2CPP.CompilerServices;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine
{
	// Token: 0x020000CC RID: 204
	[NativeClass("Vector4f")]
	[NativeHeader("Runtime/Math/Vector4.h")]
	[Il2CppEagerStaticClassConstruction]
	[RequiredByNativeCode(Optional = true, GenerateProxy = true)]
	public struct Vector4 : IEquatable<Vector4>, IFormattable
	{
		// Token: 0x170000C2 RID: 194
		public float this[int index]
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
			set
			{
			}
		}

		// Token: 0x060003BC RID: 956 RVA: 0x000077C8 File Offset: 0x000059C8
		public Vector4(float x, float y, float z, float w)
		{
		}

		// Token: 0x060003BD RID: 957 RVA: 0x000077D8 File Offset: 0x000059D8
		public override int GetHashCode()
		{
			int num;
			return num;
		}

		// Token: 0x060003BE RID: 958 RVA: 0x000077E8 File Offset: 0x000059E8
		public override bool Equals(object other)
		{
			/*
An exception occurred when decompiling this method (060003BE)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean UnityEngine.Vector4::Equals(System.Object)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0003:
	stloc:float32(var_1_0B, ldfld:float32(Vector4::y, ldloc:valuetype UnityEngine.Vector4&(this)))
	stloc:float32(var_2_12, ldfld:float32(Vector4::z, ldloc:valuetype UnityEngine.Vector4&(this)))
	stloc:float32(var_3_19, ldfld:float32(Vector4::w, ldloc:valuetype UnityEngine.Vector4&(this)))
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

		// Token: 0x060003BF RID: 959 RVA: 0x00007810 File Offset: 0x00005A10
		public bool Equals(Vector4 other)
		{
			/*
An exception occurred when decompiling this method (060003BF)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean UnityEngine.Vector4::Equals(UnityEngine.Vector4)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:float32(var_0_06, ldfld:float32(Vector4::y, ldloc:valuetype UnityEngine.Vector4&(this)))
	stloc:float32(var_1_0D, ldfld:float32(Vector4::z, ldloc:valuetype UnityEngine.Vector4&(this)))
	stloc:float32(var_2_14, ldfld:float32(Vector4::w, ldloc:valuetype UnityEngine.Vector4&(this)))
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

		// Token: 0x060003C0 RID: 960 RVA: 0x000021B3 File Offset: 0x000003B3
		public static float Dot(Vector4 a, Vector4 b)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x170000C3 RID: 195
		// (get) Token: 0x060003C1 RID: 961 RVA: 0x00007834 File Offset: 0x00005A34
		public float sqrMagnitude
		{
			get
			{
				/*
An exception occurred when decompiling this method (060003C1)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Single UnityEngine.Vector4::get_sqrMagnitude()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:float32(var_0_06, ldfld:float32(Vector4::x, ldloc:valuetype UnityEngine.Vector4&(this)))
	stloc:float32(var_1_0D, ldfld:float32(Vector4::y, ldloc:valuetype UnityEngine.Vector4&(this)))
	stloc:float32(var_2_14, ldfld:float32(Vector4::z, ldloc:valuetype UnityEngine.Vector4&(this)))
	stloc:float32(var_3_1B, ldfld:float32(Vector4::w, ldloc:valuetype UnityEngine.Vector4&(this)))
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
		}

		// Token: 0x170000C4 RID: 196
		// (get) Token: 0x060003C2 RID: 962 RVA: 0x000021B3 File Offset: 0x000003B3
		public static Vector4 zero
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		// Token: 0x170000C5 RID: 197
		// (get) Token: 0x060003C3 RID: 963 RVA: 0x000021B3 File Offset: 0x000003B3
		public static Vector4 one
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		// Token: 0x060003C4 RID: 964 RVA: 0x0000785C File Offset: 0x00005A5C
		public static Vector4 operator /(Vector4 a, float d)
		{
			Vector4 vector;
			return vector;
		}

		// Token: 0x060003C5 RID: 965 RVA: 0x000021B3 File Offset: 0x000003B3
		public static bool operator ==(Vector4 lhs, Vector4 rhs)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x060003C6 RID: 966 RVA: 0x0000786C File Offset: 0x00005A6C
		public static implicit operator Vector4(Vector3 v)
		{
			Vector4 vector;
			return vector;
		}

		// Token: 0x060003C7 RID: 967 RVA: 0x0000787C File Offset: 0x00005A7C
		public static implicit operator Vector4(Vector2 v)
		{
			Vector4 vector;
			return vector;
		}

		// Token: 0x060003C8 RID: 968 RVA: 0x0000788C File Offset: 0x00005A8C
		public override string ToString()
		{
			string text;
			return text;
		}

		// Token: 0x060003C9 RID: 969 RVA: 0x0000789C File Offset: 0x00005A9C
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

		// Token: 0x060003CA RID: 970 RVA: 0x000078E8 File Offset: 0x00005AE8
		// Note: this type is marked as 'beforefieldinit'.
		static Vector4()
		{
		}

		// Token: 0x040003A3 RID: 931
		public const float kEpsilon = 1E-05f;

		// Token: 0x040003A4 RID: 932
		public float x;

		// Token: 0x040003A5 RID: 933
		public float y;

		// Token: 0x040003A6 RID: 934
		public float z;

		// Token: 0x040003A7 RID: 935
		public float w;

		// Token: 0x040003A8 RID: 936
		private static readonly Vector4 zeroVector;

		// Token: 0x040003A9 RID: 937
		private static readonly Vector4 oneVector;

		// Token: 0x040003AA RID: 938
		private static readonly Vector4 positiveInfinityVector;

		// Token: 0x040003AB RID: 939
		private static readonly Vector4 negativeInfinityVector;
	}
}
