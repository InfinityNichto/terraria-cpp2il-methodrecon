using System;
using System.Runtime.InteropServices;
using Cpp2IlInjected;

namespace Microsoft.Xna.Framework
{
	// Token: 0x0200032B RID: 811
	[Serializable]
	public struct Plane : IEquatable<Plane>
	{
		// Token: 0x0600130C RID: 4876 RVA: 0x0005C574 File Offset: 0x0005A774
		public Plane(Vector4 value)
		{
		}

		// Token: 0x0600130D RID: 4877 RVA: 0x0005C584 File Offset: 0x0005A784
		public Plane(Vector3 normal, float d)
		{
		}

		// Token: 0x0600130E RID: 4878 RVA: 0x0005C594 File Offset: 0x0005A794
		public Plane(Vector3 a, Vector3 b, Vector3 c)
		{
			if (!true)
			{
			}
		}

		// Token: 0x0600130F RID: 4879 RVA: 0x0005C5A4 File Offset: 0x0005A7A4
		public Plane(float a, float b, float c, float d)
		{
		}

		// Token: 0x06001310 RID: 4880 RVA: 0x0005C5B4 File Offset: 0x0005A7B4
		public float Dot(Vector4 value)
		{
			/*
An exception occurred when decompiling this method (06001310)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Single Microsoft.Xna.Framework.Plane::Dot(Microsoft.Xna.Framework.Vector4)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:float32(var_0_0B, ldfld:float32(Vector3::X, ldfld:Vector3[exp:valuetype Microsoft.Xna.Framework.Vector3&](Plane::Normal, ldloc:valuetype Microsoft.Xna.Framework.Plane&(this))))
	stloc:float32(var_1_17, ldfld:float32(Vector3::Y, ldfld:Vector3[exp:valuetype Microsoft.Xna.Framework.Vector3&](Plane::Normal, ldloc:valuetype Microsoft.Xna.Framework.Plane&(this))))
	stloc:float32(var_2_23, ldfld:float32(Vector3::Z, ldfld:Vector3[exp:valuetype Microsoft.Xna.Framework.Vector3&](Plane::Normal, ldloc:valuetype Microsoft.Xna.Framework.Plane&(this))))
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

		// Token: 0x06001311 RID: 4881 RVA: 0x0005C5E4 File Offset: 0x0005A7E4
		public void Dot(Vector4 value, [Out] float result)
		{
			float d = this.D;
			float x = this.Normal.X;
			float x2 = value.X;
			float y = value.Y;
			float y2 = this.Normal.Y;
			float z = this.Normal.Z;
			float z2 = value.Z;
			float w = value.W;
		}

		// Token: 0x06001312 RID: 4882 RVA: 0x0005C63C File Offset: 0x0005A83C
		public float DotCoordinate(Vector3 value)
		{
			/*
An exception occurred when decompiling this method (06001312)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Single Microsoft.Xna.Framework.Plane::DotCoordinate(Microsoft.Xna.Framework.Vector3)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:float32(var_0_0B, ldfld:float32(Vector3::X, ldfld:Vector3[exp:valuetype Microsoft.Xna.Framework.Vector3&](Plane::Normal, ldloc:valuetype Microsoft.Xna.Framework.Plane&(this))))
	stloc:float32(var_1_17, ldfld:float32(Vector3::Y, ldfld:Vector3[exp:valuetype Microsoft.Xna.Framework.Vector3&](Plane::Normal, ldloc:valuetype Microsoft.Xna.Framework.Plane&(this))))
	stloc:float32(var_2_23, ldfld:float32(Vector3::Z, ldfld:Vector3[exp:valuetype Microsoft.Xna.Framework.Vector3&](Plane::Normal, ldloc:valuetype Microsoft.Xna.Framework.Plane&(this))))
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

		// Token: 0x06001313 RID: 4883 RVA: 0x0005C66C File Offset: 0x0005A86C
		public void DotCoordinate(Vector3 value, [Out] float result)
		{
			float d = this.D;
			float x = this.Normal.X;
			float x2 = value.X;
			float y = value.Y;
			float y2 = this.Normal.Y;
			float z = this.Normal.Z;
			float z2 = value.Z;
		}

		// Token: 0x06001314 RID: 4884 RVA: 0x0005C6BC File Offset: 0x0005A8BC
		public float DotNormal(Vector3 value)
		{
			/*
An exception occurred when decompiling this method (06001314)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Single Microsoft.Xna.Framework.Plane::DotNormal(Microsoft.Xna.Framework.Vector3)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:float32(var_0_0B, ldfld:float32(Vector3::X, ldfld:Vector3[exp:valuetype Microsoft.Xna.Framework.Vector3&](Plane::Normal, ldloc:valuetype Microsoft.Xna.Framework.Plane&(this))))
	stloc:float32(var_1_17, ldfld:float32(Vector3::Y, ldfld:Vector3[exp:valuetype Microsoft.Xna.Framework.Vector3&](Plane::Normal, ldloc:valuetype Microsoft.Xna.Framework.Plane&(this))))
	stloc:float32(var_2_23, ldfld:float32(Vector3::Z, ldfld:Vector3[exp:valuetype Microsoft.Xna.Framework.Vector3&](Plane::Normal, ldloc:valuetype Microsoft.Xna.Framework.Plane&(this))))
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

		// Token: 0x06001315 RID: 4885 RVA: 0x0005C6EC File Offset: 0x0005A8EC
		public void DotNormal(Vector3 value, [Out] float result)
		{
			float x = this.Normal.X;
			float y = this.Normal.Y;
			float x2 = value.X;
			float y2 = value.Y;
			float z = this.Normal.Z;
			float z2 = value.Z;
		}

		// Token: 0x06001316 RID: 4886 RVA: 0x000021DB File Offset: 0x000003DB
		public static void Transform(Plane plane, Quaternion rotation, [Out] Plane result)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06001317 RID: 4887 RVA: 0x000021DB File Offset: 0x000003DB
		public static void Transform(Plane plane, Matrix matrix, [Out] Plane result)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06001318 RID: 4888 RVA: 0x000021DB File Offset: 0x000003DB
		public static Plane Transform(Plane plane, Quaternion rotation)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06001319 RID: 4889 RVA: 0x000021DB File Offset: 0x000003DB
		public static Plane Transform(Plane plane, Matrix matrix)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x0600131A RID: 4890 RVA: 0x0005C734 File Offset: 0x0005A934
		public void Normalize()
		{
			float x = this.Normal.X;
			float y = this.Normal.Y;
			float z = this.Normal.Z;
			if (!true)
			{
			}
			if (!true)
			{
			}
		}

		// Token: 0x0600131B RID: 4891 RVA: 0x000021DB File Offset: 0x000003DB
		public static Plane Normalize(Plane value)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x0600131C RID: 4892 RVA: 0x0005C76C File Offset: 0x0005A96C
		public static void Normalize(Plane value, [Out] Plane result)
		{
			float x = value.Normal.X;
			float y = value.Normal.Y;
			float z = value.Normal.Z;
			if (!true)
			{
			}
			if (!true)
			{
			}
			float d = value.D;
			float x2 = value.Normal.X;
			float y2 = value.Normal.Y;
			float z2 = value.Normal.Z;
		}

		// Token: 0x0600131D RID: 4893 RVA: 0x0005C7D4 File Offset: 0x0005A9D4
		public static bool operator !=(Plane plane1, Plane plane2)
		{
			bool flag;
			return flag;
		}

		// Token: 0x0600131E RID: 4894 RVA: 0x0005C7E4 File Offset: 0x0005A9E4
		public static bool operator ==(Plane plane1, Plane plane2)
		{
			bool flag;
			return flag;
		}

		// Token: 0x0600131F RID: 4895 RVA: 0x0005C7F4 File Offset: 0x0005A9F4
		public override bool Equals(object other)
		{
			if (other != null)
			{
			}
			bool flag;
			return flag;
		}

		// Token: 0x06001320 RID: 4896 RVA: 0x0005C808 File Offset: 0x0005AA08
		public bool Equals(Plane other)
		{
			float x = this.Normal.X;
			float y = this.Normal.Y;
			float z = this.Normal.Z;
			if (!true)
			{
				return;
			}
		}

		// Token: 0x06001321 RID: 4897 RVA: 0x0005C840 File Offset: 0x0005AA40
		public override int GetHashCode()
		{
			float x = this.Normal.X;
			float y = this.Normal.Y;
			float z = this.Normal.Z;
			int num;
			return num;
		}

		// Token: 0x06001322 RID: 4898 RVA: 0x0005C874 File Offset: 0x0005AA74
		public override string ToString()
		{
			float z = this.Normal.Z;
			string text;
			return text;
		}

		// Token: 0x04002263 RID: 8803
		public float D;

		// Token: 0x04002264 RID: 8804
		public Vector3 Normal;
	}
}
