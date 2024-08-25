using System;
using System.Runtime.InteropServices;
using Cpp2IlInjected;

namespace Microsoft.Xna.Framework
{
	// Token: 0x0200032D RID: 813
	[Serializable]
	public struct Quaternion : IEquatable<Quaternion>
	{
		// Token: 0x0600132C RID: 4908 RVA: 0x0005C924 File Offset: 0x0005AB24
		public Quaternion(float x, float y, float z, float w)
		{
		}

		// Token: 0x0600132D RID: 4909 RVA: 0x0005C934 File Offset: 0x0005AB34
		public Quaternion(Vector3 vectorPart, float scalarPart)
		{
		}

		// Token: 0x170001E0 RID: 480
		// (get) Token: 0x0600132E RID: 4910 RVA: 0x0005C944 File Offset: 0x0005AB44
		public static Quaternion Identity
		{
			get
			{
				/*
An exception occurred when decompiling this method (0600132E)

ICSharpCode.Decompiler.DecompilerException: Error decompiling Microsoft.Xna.Framework.Quaternion Microsoft.Xna.Framework.Quaternion::get_Identity()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0000:
	brtrue(IL_0000, ldc.i4:bool(1))
}

   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1852
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1878
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1878
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1846
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.Optimize(DecompilerContext context, ILBlock method, AutoPropertyProvider autoPropertyProvider, StateMachineKind& stateMachineKind, MethodDef& inlinedMethod, AsyncMethodDebugInfo& asyncInfo, ILAstOptimizationStep abortBeforeStep) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 355
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(IEnumerable`1 parameters, MethodDebugInfoBuilder& builder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 123
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 88
   --- End of inner exception stack trace ---
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 92
   at ICSharpCode.Decompiler.Ast.AstBuilder.AddMethodBody(EntityDeclaration methodNode, EntityDeclaration& updatedNode, MethodDef method, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, MethodKind methodKind) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 1683
*/;
			}
		}

		// Token: 0x0600132F RID: 4911 RVA: 0x000021DB File Offset: 0x000003DB
		public static Quaternion Add(Quaternion quaternion1, Quaternion quaternion2)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06001330 RID: 4912 RVA: 0x0005C954 File Offset: 0x0005AB54
		public static void Add(Quaternion quaternion1, Quaternion quaternion2, [Out] Quaternion result)
		{
		}

		// Token: 0x06001331 RID: 4913 RVA: 0x000021DB File Offset: 0x000003DB
		public static Quaternion Concatenate(Quaternion value1, Quaternion value2)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06001332 RID: 4914 RVA: 0x0005C964 File Offset: 0x0005AB64
		public void Conjugate()
		{
			float z = this.Z;
			this.Z = z;
		}

		// Token: 0x06001333 RID: 4915 RVA: 0x000021DB File Offset: 0x000003DB
		public static Quaternion Conjugate(Quaternion value)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06001334 RID: 4916 RVA: 0x0005C980 File Offset: 0x0005AB80
		public static void Conjugate(Quaternion value, [Out] Quaternion result)
		{
			float z = value.Z;
			result.Z = z;
			float w = value.W;
			result.W = w;
		}

		// Token: 0x06001335 RID: 4917 RVA: 0x0005C9AC File Offset: 0x0005ABAC
		public static void Concatenate(Quaternion value1, Quaternion value2, [Out] Quaternion result)
		{
			float x = value2.X;
			float y = value2.Y;
			float z = value1.Z;
			float w = value1.W;
			float x2 = value1.X;
			float y2 = value1.Y;
			float z2 = value2.Z;
			float w2 = value2.W;
			result.X = x;
			result.Y = z;
			float y3 = value1.Y;
			float y4 = value2.Y;
			result.Z = x2;
			float z3 = value2.Z;
			float z4 = value1.Z;
		}

		// Token: 0x06001336 RID: 4918 RVA: 0x0005CA2C File Offset: 0x0005AC2C
		public static Quaternion CreateFromYawPitchRoll(float yaw, float pitch, float roll)
		{
			/*
An exception occurred when decompiling this method (06001336)

ICSharpCode.Decompiler.DecompilerException: Error decompiling Microsoft.Xna.Framework.Quaternion Microsoft.Xna.Framework.Quaternion::CreateFromYawPitchRoll(System.Single,System.Single,System.Single)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0000:
	brtrue(IL_0000, ldc.i4:bool(1))
}

   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1852
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1878
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1878
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1846
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.Optimize(DecompilerContext context, ILBlock method, AutoPropertyProvider autoPropertyProvider, StateMachineKind& stateMachineKind, MethodDef& inlinedMethod, AsyncMethodDebugInfo& asyncInfo, ILAstOptimizationStep abortBeforeStep) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 355
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(IEnumerable`1 parameters, MethodDebugInfoBuilder& builder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 123
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 88
   --- End of inner exception stack trace ---
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 92
   at ICSharpCode.Decompiler.Ast.AstBuilder.AddMethodBody(EntityDeclaration methodNode, EntityDeclaration& updatedNode, MethodDef method, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, MethodKind methodKind) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 1683
*/;
		}

		// Token: 0x06001337 RID: 4919 RVA: 0x0005CA3C File Offset: 0x0005AC3C
		public static void CreateFromYawPitchRoll(float yaw, float pitch, float roll, [Out] Quaternion result)
		{
			if (!true)
			{
			}
		}

		// Token: 0x06001338 RID: 4920 RVA: 0x0005CA4C File Offset: 0x0005AC4C
		public static Quaternion CreateFromAxisAngle(Vector3 axis, float angle)
		{
			/*
An exception occurred when decompiling this method (06001338)

ICSharpCode.Decompiler.DecompilerException: Error decompiling Microsoft.Xna.Framework.Quaternion Microsoft.Xna.Framework.Quaternion::CreateFromAxisAngle(Microsoft.Xna.Framework.Vector3,System.Single)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0000:
	brtrue(IL_0000, ldc.i4:bool(1))
}

   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1852
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1878
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1878
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1846
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.Optimize(DecompilerContext context, ILBlock method, AutoPropertyProvider autoPropertyProvider, StateMachineKind& stateMachineKind, MethodDef& inlinedMethod, AsyncMethodDebugInfo& asyncInfo, ILAstOptimizationStep abortBeforeStep) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 355
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(IEnumerable`1 parameters, MethodDebugInfoBuilder& builder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 123
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 88
   --- End of inner exception stack trace ---
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 92
   at ICSharpCode.Decompiler.Ast.AstBuilder.AddMethodBody(EntityDeclaration methodNode, EntityDeclaration& updatedNode, MethodDef method, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, MethodKind methodKind) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 1683
*/;
		}

		// Token: 0x06001339 RID: 4921 RVA: 0x0005CA5C File Offset: 0x0005AC5C
		public static void CreateFromAxisAngle(Vector3 axis, float angle, [Out] Quaternion result)
		{
			if (!true)
			{
			}
			float z = axis.Z;
		}

		// Token: 0x0600133A RID: 4922 RVA: 0x000021DB File Offset: 0x000003DB
		public static Quaternion CreateFromRotationMatrix(Matrix matrix)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x0600133B RID: 4923 RVA: 0x0005CA74 File Offset: 0x0005AC74
		public static void CreateFromRotationMatrix(Matrix matrix, [Out] Quaternion result)
		{
			float m = matrix.M22;
			float m2 = matrix.M33;
			float m3 = matrix.M23;
			float m4 = matrix.M32;
			float m5 = matrix.M31;
			float m6 = matrix.M13;
			result.Y = m5;
			float m7 = matrix.M12;
			float m8 = matrix.M21;
		}

		// Token: 0x0600133C RID: 4924 RVA: 0x000021DB File Offset: 0x000003DB
		public static Quaternion Divide(Quaternion quaternion1, Quaternion quaternion2)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x0600133D RID: 4925 RVA: 0x0005CB58 File Offset: 0x0005AD58
		public static void Divide(Quaternion quaternion1, Quaternion quaternion2, [Out] Quaternion result)
		{
			float x = quaternion2.X;
			float y = quaternion2.Y;
			float z = quaternion2.Z;
			float w = quaternion2.W;
			float z2 = quaternion1.Z;
			float w2 = quaternion1.W;
			float x2 = quaternion1.X;
			float y2 = quaternion1.Y;
			result.X = x2;
			result.Y = z2;
			float y3 = quaternion1.Y;
			result.Z = w;
			float z3 = quaternion1.Z;
			result.W = x;
		}

		// Token: 0x0600133E RID: 4926 RVA: 0x000021DB File Offset: 0x000003DB
		public static float Dot(Quaternion quaternion1, Quaternion quaternion2)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x0600133F RID: 4927 RVA: 0x0005CBD0 File Offset: 0x0005ADD0
		public static void Dot(Quaternion quaternion1, Quaternion quaternion2, [Out] float result)
		{
			float x = quaternion1.X;
			float y = quaternion1.Y;
			float x2 = quaternion2.X;
			float y2 = quaternion2.Y;
			float z = quaternion1.Z;
			float w = quaternion1.W;
			float z2 = quaternion2.Z;
			float w2 = quaternion2.W;
		}

		// Token: 0x06001340 RID: 4928 RVA: 0x0005CC1C File Offset: 0x0005AE1C
		public override bool Equals(object obj)
		{
			if (obj != null)
			{
			}
			float x = this.X;
			float y = this.Y;
			float z = this.Z;
			float w = this.W;
			throw new InvalidCastException();
		}

		// Token: 0x06001341 RID: 4929 RVA: 0x0005CC54 File Offset: 0x0005AE54
		public bool Equals(Quaternion other)
		{
			/*
An exception occurred when decompiling this method (06001341)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean Microsoft.Xna.Framework.Quaternion::Equals(Microsoft.Xna.Framework.Quaternion)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:float32(var_0_06, ldfld:float32(Quaternion::Y, ldloc:valuetype Microsoft.Xna.Framework.Quaternion&(this)))
	stloc:float32(var_1_0D, ldfld:float32(Quaternion::Z, ldloc:valuetype Microsoft.Xna.Framework.Quaternion&(this)))
	stloc:float32(var_2_14, ldfld:float32(Quaternion::W, ldloc:valuetype Microsoft.Xna.Framework.Quaternion&(this)))
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

		// Token: 0x06001342 RID: 4930 RVA: 0x0005CC78 File Offset: 0x0005AE78
		public override int GetHashCode()
		{
			int num;
			return num;
		}

		// Token: 0x06001343 RID: 4931 RVA: 0x000021DB File Offset: 0x000003DB
		public static Quaternion Inverse(Quaternion quaternion)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06001344 RID: 4932 RVA: 0x0005CC88 File Offset: 0x0005AE88
		public static void Inverse(Quaternion quaternion, [Out] Quaternion result)
		{
			float z = quaternion.Z;
			float w = quaternion.W;
			result.Z = z;
			result.W = w;
		}

		// Token: 0x06001345 RID: 4933 RVA: 0x0005CCB4 File Offset: 0x0005AEB4
		public float Length()
		{
			/*
An exception occurred when decompiling this method (06001345)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Single Microsoft.Xna.Framework.Quaternion::Length()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0000:
	stloc:float32(var_0_06, ldfld:float32(Quaternion::X, ldloc:valuetype Microsoft.Xna.Framework.Quaternion&(this)))
	stloc:float32(var_1_0D, ldfld:float32(Quaternion::Y, ldloc:valuetype Microsoft.Xna.Framework.Quaternion&(this)))
	stloc:float32(var_2_14, ldfld:float32(Quaternion::Z, ldloc:valuetype Microsoft.Xna.Framework.Quaternion&(this)))
	stloc:float32(var_3_1B, ldfld:float32(Quaternion::W, ldloc:valuetype Microsoft.Xna.Framework.Quaternion&(this)))
	brtrue(IL_0000, ldc.i4:bool(1))
}

   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1852
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1878
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1878
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1846
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.Optimize(DecompilerContext context, ILBlock method, AutoPropertyProvider autoPropertyProvider, StateMachineKind& stateMachineKind, MethodDef& inlinedMethod, AsyncMethodDebugInfo& asyncInfo, ILAstOptimizationStep abortBeforeStep) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 355
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(IEnumerable`1 parameters, MethodDebugInfoBuilder& builder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 123
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 88
   --- End of inner exception stack trace ---
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 92
   at ICSharpCode.Decompiler.Ast.AstBuilder.AddMethodBody(EntityDeclaration methodNode, EntityDeclaration& updatedNode, MethodDef method, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, MethodKind methodKind) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 1683
*/;
		}

		// Token: 0x06001346 RID: 4934 RVA: 0x0005CCE0 File Offset: 0x0005AEE0
		public float LengthSquared()
		{
			/*
An exception occurred when decompiling this method (06001346)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Single Microsoft.Xna.Framework.Quaternion::LengthSquared()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:float32(var_0_06, ldfld:float32(Quaternion::X, ldloc:valuetype Microsoft.Xna.Framework.Quaternion&(this)))
	stloc:float32(var_1_0D, ldfld:float32(Quaternion::Y, ldloc:valuetype Microsoft.Xna.Framework.Quaternion&(this)))
	stloc:float32(var_2_14, ldfld:float32(Quaternion::Z, ldloc:valuetype Microsoft.Xna.Framework.Quaternion&(this)))
	stloc:float32(var_3_1B, ldfld:float32(Quaternion::W, ldloc:valuetype Microsoft.Xna.Framework.Quaternion&(this)))
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

		// Token: 0x06001347 RID: 4935 RVA: 0x000021DB File Offset: 0x000003DB
		public static Quaternion Lerp(Quaternion quaternion1, Quaternion quaternion2, float amount)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06001348 RID: 4936 RVA: 0x0005CD08 File Offset: 0x0005AF08
		public static void Lerp(Quaternion quaternion1, Quaternion quaternion2, float amount, [Out] Quaternion result)
		{
			float w = quaternion1.W;
			float w2 = quaternion2.W;
		}

		// Token: 0x06001349 RID: 4937 RVA: 0x000021DB File Offset: 0x000003DB
		public static Quaternion Slerp(Quaternion quaternion1, Quaternion quaternion2, float amount)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x0600134A RID: 4938 RVA: 0x0005CD3C File Offset: 0x0005AF3C
		public static void Slerp(Quaternion quaternion1, Quaternion quaternion2, float amount, [Out] Quaternion result)
		{
			float x = quaternion2.X;
			float y = quaternion2.Y;
			float x2 = quaternion1.X;
			float y2 = quaternion1.Y;
		}

		// Token: 0x0600134B RID: 4939 RVA: 0x000021DB File Offset: 0x000003DB
		public static Quaternion Subtract(Quaternion quaternion1, Quaternion quaternion2)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x0600134C RID: 4940 RVA: 0x0005CD70 File Offset: 0x0005AF70
		public static void Subtract(Quaternion quaternion1, Quaternion quaternion2, [Out] Quaternion result)
		{
		}

		// Token: 0x0600134D RID: 4941 RVA: 0x000021DB File Offset: 0x000003DB
		public static Quaternion Multiply(Quaternion quaternion1, Quaternion quaternion2)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x0600134E RID: 4942 RVA: 0x000021DB File Offset: 0x000003DB
		public static Quaternion Multiply(Quaternion quaternion1, float scaleFactor)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x0600134F RID: 4943 RVA: 0x0005CD80 File Offset: 0x0005AF80
		public static void Multiply(Quaternion quaternion1, float scaleFactor, [Out] Quaternion result)
		{
			result.X = scaleFactor;
		}

		// Token: 0x06001350 RID: 4944 RVA: 0x0005CD94 File Offset: 0x0005AF94
		public static void Multiply(Quaternion quaternion1, Quaternion quaternion2, [Out] Quaternion result)
		{
			float x = quaternion1.X;
			float y = quaternion1.Y;
			float y2 = quaternion2.Y;
			float z = quaternion2.Z;
			float z2 = quaternion1.Z;
			float w = quaternion1.W;
			float w2 = quaternion2.W;
			result.X = x;
			result.Y = y;
			result.Z = z;
			result.W = x;
		}

		// Token: 0x06001351 RID: 4945 RVA: 0x000021DB File Offset: 0x000003DB
		public static Quaternion Negate(Quaternion quaternion)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06001352 RID: 4946 RVA: 0x0005CDF4 File Offset: 0x0005AFF4
		public static void Negate(Quaternion quaternion, [Out] Quaternion result)
		{
		}

		// Token: 0x06001353 RID: 4947 RVA: 0x0005CE04 File Offset: 0x0005B004
		public void Normalize()
		{
			if (!true)
			{
			}
		}

		// Token: 0x06001354 RID: 4948 RVA: 0x0005CE14 File Offset: 0x0005B014
		public static Quaternion Normalize(Quaternion quaternion)
		{
			/*
An exception occurred when decompiling this method (06001354)

ICSharpCode.Decompiler.DecompilerException: Error decompiling Microsoft.Xna.Framework.Quaternion Microsoft.Xna.Framework.Quaternion::Normalize(Microsoft.Xna.Framework.Quaternion)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0000:
	brtrue(IL_0000, ldc.i4:bool(1))
}

   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1852
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1878
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1878
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1846
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.Optimize(DecompilerContext context, ILBlock method, AutoPropertyProvider autoPropertyProvider, StateMachineKind& stateMachineKind, MethodDef& inlinedMethod, AsyncMethodDebugInfo& asyncInfo, ILAstOptimizationStep abortBeforeStep) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 355
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(IEnumerable`1 parameters, MethodDebugInfoBuilder& builder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 123
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 88
   --- End of inner exception stack trace ---
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 92
   at ICSharpCode.Decompiler.Ast.AstBuilder.AddMethodBody(EntityDeclaration methodNode, EntityDeclaration& updatedNode, MethodDef method, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, MethodKind methodKind) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 1683
*/;
		}

		// Token: 0x06001355 RID: 4949 RVA: 0x0005CE24 File Offset: 0x0005B024
		public static void Normalize(Quaternion quaternion, [Out] Quaternion result)
		{
			if (!true)
			{
			}
		}

		// Token: 0x06001356 RID: 4950 RVA: 0x000021DB File Offset: 0x000003DB
		public static Quaternion operator +(Quaternion quaternion1, Quaternion quaternion2)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06001357 RID: 4951 RVA: 0x000021DB File Offset: 0x000003DB
		public static Quaternion operator /(Quaternion quaternion1, Quaternion quaternion2)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06001358 RID: 4952 RVA: 0x0005CE34 File Offset: 0x0005B034
		public static bool operator ==(Quaternion quaternion1, Quaternion quaternion2)
		{
		}

		// Token: 0x06001359 RID: 4953 RVA: 0x0005CE44 File Offset: 0x0005B044
		public static bool operator !=(Quaternion quaternion1, Quaternion quaternion2)
		{
			return true;
		}

		// Token: 0x0600135A RID: 4954 RVA: 0x000021DB File Offset: 0x000003DB
		public static Quaternion operator *(Quaternion quaternion1, Quaternion quaternion2)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x0600135B RID: 4955 RVA: 0x000021DB File Offset: 0x000003DB
		public static Quaternion operator *(Quaternion quaternion1, float scaleFactor)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x0600135C RID: 4956 RVA: 0x000021DB File Offset: 0x000003DB
		public static Quaternion operator -(Quaternion quaternion1, Quaternion quaternion2)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x0600135D RID: 4957 RVA: 0x000021DB File Offset: 0x000003DB
		public static Quaternion operator -(Quaternion quaternion)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x0600135E RID: 4958 RVA: 0x0005CE54 File Offset: 0x0005B054
		public override string ToString()
		{
			/*
An exception occurred when decompiling this method (0600135E)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.String Microsoft.Xna.Framework.Quaternion::ToString()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:float32(var_3_06, ldfld:float32(Quaternion::Y, ldloc:valuetype Microsoft.Xna.Framework.Quaternion&(this)))
	stloc:float32(var_6_0D, ldfld:float32(Quaternion::Z, ldloc:valuetype Microsoft.Xna.Framework.Quaternion&(this)))
	stloc:float32(var_9_15, ldfld:float32(Quaternion::W, ldloc:valuetype Microsoft.Xna.Framework.Quaternion&(this)))
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

		// Token: 0x0600135F RID: 4959 RVA: 0x0005CE78 File Offset: 0x0005B078
		// Note: this type is marked as 'beforefieldinit'.
		static Quaternion()
		{
		}

		// Token: 0x04002268 RID: 8808
		public float X;

		// Token: 0x04002269 RID: 8809
		public float Y;

		// Token: 0x0400226A RID: 8810
		public float Z;

		// Token: 0x0400226B RID: 8811
		public float W;

		// Token: 0x0400226C RID: 8812
		private static Quaternion identity;
	}
}
