using System;
using System.Runtime.InteropServices;
using Cpp2IlInjected;

namespace Microsoft.Xna.Framework
{
	// Token: 0x02000332 RID: 818
	[Serializable]
	public struct Vector4 : IEquatable<Vector4>
	{
		// Token: 0x170001F8 RID: 504
		// (get) Token: 0x06001424 RID: 5156 RVA: 0x0005E2A4 File Offset: 0x0005C4A4
		public static Vector4 Zero
		{
			get
			{
				if (!true)
				{
				}
				return 1;
			}
		}

		// Token: 0x170001F9 RID: 505
		// (get) Token: 0x06001425 RID: 5157 RVA: 0x0005E2B8 File Offset: 0x0005C4B8
		public static Vector4 One
		{
			get
			{
				if (!true)
				{
				}
				return 1;
			}
		}

		// Token: 0x170001FA RID: 506
		// (get) Token: 0x06001426 RID: 5158 RVA: 0x0005E2CC File Offset: 0x0005C4CC
		public static Vector4 UnitX
		{
			get
			{
				if (!true)
				{
				}
				return 1;
			}
		}

		// Token: 0x170001FB RID: 507
		// (get) Token: 0x06001427 RID: 5159 RVA: 0x0005E2E0 File Offset: 0x0005C4E0
		public static Vector4 UnitY
		{
			get
			{
				if (!true)
				{
				}
				return 1;
			}
		}

		// Token: 0x170001FC RID: 508
		// (get) Token: 0x06001428 RID: 5160 RVA: 0x0005E2F4 File Offset: 0x0005C4F4
		public static Vector4 UnitZ
		{
			get
			{
				if (!true)
				{
				}
				return 1;
			}
		}

		// Token: 0x170001FD RID: 509
		// (get) Token: 0x06001429 RID: 5161 RVA: 0x0005E308 File Offset: 0x0005C508
		public static Vector4 UnitW
		{
			get
			{
				if (!true)
				{
				}
				return 1;
			}
		}

		// Token: 0x0600142A RID: 5162 RVA: 0x0005E31C File Offset: 0x0005C51C
		public Vector4(float x, float y, float z, float w)
		{
		}

		// Token: 0x0600142B RID: 5163 RVA: 0x0005E32C File Offset: 0x0005C52C
		public Vector4(Vector2 value, float z, float w)
		{
		}

		// Token: 0x0600142C RID: 5164 RVA: 0x0005E33C File Offset: 0x0005C53C
		public Vector4(Vector3 value, float w)
		{
		}

		// Token: 0x0600142D RID: 5165 RVA: 0x0005E34C File Offset: 0x0005C54C
		public Vector4(float value)
		{
			this.X = value;
		}

		// Token: 0x0600142E RID: 5166 RVA: 0x0005E360 File Offset: 0x0005C560
		public static Vector4 Add(Vector4 value1, Vector4 value2)
		{
			Vector4 vector;
			return vector;
		}

		// Token: 0x0600142F RID: 5167 RVA: 0x0005E370 File Offset: 0x0005C570
		public static void Add(Vector4 value1, Vector4 value2, [Out] Vector4 result)
		{
		}

		// Token: 0x06001430 RID: 5168 RVA: 0x0005E380 File Offset: 0x0005C580
		public static Vector4 Barycentric(Vector4 value1, Vector4 value2, Vector4 value3, float amount1, float amount2)
		{
			Vector4 vector;
			return vector;
		}

		// Token: 0x06001431 RID: 5169 RVA: 0x0005E398 File Offset: 0x0005C598
		public static void Barycentric(Vector4 value1, Vector4 value2, Vector4 value3, float amount1, float amount2, [Out] Vector4 result)
		{
			float y = value1.Y;
			float y2 = value2.Y;
			float y3 = value3.Y;
			float z = value1.Z;
			float z2 = value2.Z;
			float z3 = value3.Z;
			float w = value1.W;
			float w2 = value2.W;
			float w3 = value3.W;
		}

		// Token: 0x06001432 RID: 5170 RVA: 0x0005E3F8 File Offset: 0x0005C5F8
		public static Vector4 CatmullRom(Vector4 value1, Vector4 value2, Vector4 value3, Vector4 value4, float amount)
		{
			Vector4 vector;
			return vector;
		}

		// Token: 0x06001433 RID: 5171 RVA: 0x0005E410 File Offset: 0x0005C610
		public static void CatmullRom(Vector4 value1, Vector4 value2, Vector4 value3, Vector4 value4, float amount, [Out] Vector4 result)
		{
			float y = value1.Y;
			float y2 = value2.Y;
			float y3 = value3.Y;
			float y4 = value4.Y;
			float z = value1.Z;
			float z2 = value2.Z;
			float z3 = value3.Z;
			float z4 = value4.Z;
			float w = value1.W;
			float w2 = value2.W;
			float w3 = value3.W;
			float w4 = value4.W;
		}

		// Token: 0x06001434 RID: 5172 RVA: 0x0005E488 File Offset: 0x0005C688
		public static Vector4 Clamp(Vector4 value1, Vector4 min, Vector4 max)
		{
			Vector4 vector;
			return vector;
		}

		// Token: 0x06001435 RID: 5173 RVA: 0x0005E4A0 File Offset: 0x0005C6A0
		public static void Clamp(Vector4 value1, Vector4 min, Vector4 max, [Out] Vector4 result)
		{
			float y = value1.Y;
			float y2 = min.Y;
			float y3 = max.Y;
			float z = value1.Z;
			float z2 = min.Z;
			float z3 = max.Z;
			float w = value1.W;
			float w2 = min.W;
			float w3 = max.W;
		}

		// Token: 0x06001436 RID: 5174 RVA: 0x0005E500 File Offset: 0x0005C700
		public static float Distance(Vector4 value1, Vector4 value2)
		{
			/*
An exception occurred when decompiling this method (06001436)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Single Microsoft.Xna.Framework.Vector4::Distance(Microsoft.Xna.Framework.Vector4,Microsoft.Xna.Framework.Vector4)

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

		// Token: 0x06001437 RID: 5175 RVA: 0x0005E510 File Offset: 0x0005C710
		public static void Distance(Vector4 value1, Vector4 value2, [Out] float result)
		{
			float z = value1.Z;
			float w = value1.W;
			float z2 = value2.Z;
			float w2 = value2.W;
			float x = value1.X;
			float y = value1.Y;
			float x2 = value2.X;
			float y2 = value2.Y;
			if (!true)
			{
			}
		}

		// Token: 0x06001438 RID: 5176 RVA: 0x000021DB File Offset: 0x000003DB
		public static float DistanceSquared(Vector4 value1, Vector4 value2)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06001439 RID: 5177 RVA: 0x0005E55C File Offset: 0x0005C75C
		public static void DistanceSquared(Vector4 value1, Vector4 value2, [Out] float result)
		{
			float z = value1.Z;
			float w = value1.W;
			float z2 = value2.Z;
			float w2 = value2.W;
			float x = value1.X;
			float y = value1.Y;
			float x2 = value2.X;
			float y2 = value2.Y;
		}

		// Token: 0x0600143A RID: 5178 RVA: 0x0005E5A8 File Offset: 0x0005C7A8
		public static Vector4 Divide(Vector4 value1, Vector4 value2)
		{
			Vector4 vector;
			return vector;
		}

		// Token: 0x0600143B RID: 5179 RVA: 0x0005E5B8 File Offset: 0x0005C7B8
		public static Vector4 Divide(Vector4 value1, float divider)
		{
			Vector4 vector;
			return vector;
		}

		// Token: 0x0600143C RID: 5180 RVA: 0x0005E5C8 File Offset: 0x0005C7C8
		public static void Divide(Vector4 value1, float divider, [Out] Vector4 result)
		{
			result.X = divider;
		}

		// Token: 0x0600143D RID: 5181 RVA: 0x0005E5DC File Offset: 0x0005C7DC
		public static void Divide(Vector4 value1, Vector4 value2, [Out] Vector4 result)
		{
		}

		// Token: 0x0600143E RID: 5182 RVA: 0x000021DB File Offset: 0x000003DB
		public static float Dot(Vector4 vector1, Vector4 vector2)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x0600143F RID: 5183 RVA: 0x0005E5EC File Offset: 0x0005C7EC
		public static void Dot(Vector4 vector1, Vector4 vector2, [Out] float result)
		{
			float x = vector1.X;
			float y = vector1.Y;
			float x2 = vector2.X;
			float y2 = vector2.Y;
			float z = vector1.Z;
			float w = vector1.W;
			float z2 = vector2.Z;
			float w2 = vector2.W;
		}

		// Token: 0x06001440 RID: 5184 RVA: 0x0005E638 File Offset: 0x0005C838
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

		// Token: 0x06001441 RID: 5185 RVA: 0x0005E670 File Offset: 0x0005C870
		public bool Equals(Vector4 other)
		{
			/*
An exception occurred when decompiling this method (06001441)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean Microsoft.Xna.Framework.Vector4::Equals(Microsoft.Xna.Framework.Vector4)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:float32(var_0_06, ldfld:float32(Vector4::W, ldloc:valuetype Microsoft.Xna.Framework.Vector4&(this)))
	stloc:float32(var_1_0D, ldfld:float32(Vector4::Y, ldloc:valuetype Microsoft.Xna.Framework.Vector4&(this)))
	stloc:float32(var_2_14, ldfld:float32(Vector4::Z, ldloc:valuetype Microsoft.Xna.Framework.Vector4&(this)))
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

		// Token: 0x06001442 RID: 5186 RVA: 0x0005E694 File Offset: 0x0005C894
		public override int GetHashCode()
		{
			/*
An exception occurred when decompiling this method (06001442)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Int32 Microsoft.Xna.Framework.Vector4::GetHashCode()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:float32(var_0_06, ldfld:float32(Vector4::W, ldloc:valuetype Microsoft.Xna.Framework.Vector4&(this)))
	stloc:float32(var_1_0D, ldfld:float32(Vector4::X, ldloc:valuetype Microsoft.Xna.Framework.Vector4&(this)))
	stloc:float32(var_2_14, ldfld:float32(Vector4::Y, ldloc:valuetype Microsoft.Xna.Framework.Vector4&(this)))
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

		// Token: 0x06001443 RID: 5187 RVA: 0x0005E6B8 File Offset: 0x0005C8B8
		public static Vector4 Hermite(Vector4 value1, Vector4 tangent1, Vector4 value2, Vector4 tangent2, float amount)
		{
			Vector4 vector;
			return vector;
		}

		// Token: 0x06001444 RID: 5188 RVA: 0x0005E6D0 File Offset: 0x0005C8D0
		public static void Hermite(Vector4 value1, Vector4 tangent1, Vector4 value2, Vector4 tangent2, float amount, [Out] Vector4 result)
		{
			float w = value1.W;
			float w2 = tangent1.W;
			float w3 = value2.W;
			float w4 = tangent2.W;
			float y = value1.Y;
			float y2 = tangent1.Y;
			float y3 = value2.Y;
			float y4 = tangent2.Y;
			result.Y = y;
			float z = value1.Z;
			float z2 = tangent1.Z;
			float z3 = value2.Z;
			float z4 = tangent2.Z;
			result.Z = z;
		}

		// Token: 0x06001445 RID: 5189 RVA: 0x0005E758 File Offset: 0x0005C958
		public float Length()
		{
			/*
An exception occurred when decompiling this method (06001445)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Single Microsoft.Xna.Framework.Vector4::Length()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0000:
	stloc:float32(var_0_06, ldfld:float32(Vector4::X, ldloc:valuetype Microsoft.Xna.Framework.Vector4&(this)))
	stloc:float32(var_1_0D, ldfld:float32(Vector4::Y, ldloc:valuetype Microsoft.Xna.Framework.Vector4&(this)))
	stloc:float32(var_2_14, ldfld:float32(Vector4::Z, ldloc:valuetype Microsoft.Xna.Framework.Vector4&(this)))
	stloc:float32(var_3_1B, ldfld:float32(Vector4::W, ldloc:valuetype Microsoft.Xna.Framework.Vector4&(this)))
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

		// Token: 0x06001446 RID: 5190 RVA: 0x0005E784 File Offset: 0x0005C984
		public float LengthSquared()
		{
			/*
An exception occurred when decompiling this method (06001446)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Single Microsoft.Xna.Framework.Vector4::LengthSquared()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:float32(var_0_06, ldfld:float32(Vector4::X, ldloc:valuetype Microsoft.Xna.Framework.Vector4&(this)))
	stloc:float32(var_1_0D, ldfld:float32(Vector4::Y, ldloc:valuetype Microsoft.Xna.Framework.Vector4&(this)))
	stloc:float32(var_2_14, ldfld:float32(Vector4::Z, ldloc:valuetype Microsoft.Xna.Framework.Vector4&(this)))
	stloc:float32(var_3_1B, ldfld:float32(Vector4::W, ldloc:valuetype Microsoft.Xna.Framework.Vector4&(this)))
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

		// Token: 0x06001447 RID: 5191 RVA: 0x0005E7AC File Offset: 0x0005C9AC
		public static Vector4 Lerp(Vector4 value1, Vector4 value2, float amount)
		{
			Vector4 vector;
			return vector;
		}

		// Token: 0x06001448 RID: 5192 RVA: 0x0005E7C4 File Offset: 0x0005C9C4
		public static void Lerp(Vector4 value1, Vector4 value2, float amount, [Out] Vector4 result)
		{
			float y = value1.Y;
			float y2 = value2.Y;
			float z = value1.Z;
			float z2 = value2.Z;
			float w = value1.W;
			float w2 = value2.W;
		}

		// Token: 0x06001449 RID: 5193 RVA: 0x0005E80C File Offset: 0x0005CA0C
		public static Vector4 Max(Vector4 value1, Vector4 value2)
		{
			Vector4 vector;
			return vector;
		}

		// Token: 0x0600144A RID: 5194 RVA: 0x0005E824 File Offset: 0x0005CA24
		public static void Max(Vector4 value1, Vector4 value2, [Out] Vector4 result)
		{
			float y = value1.Y;
			float y2 = value2.Y;
			float z = value1.Z;
			float z2 = value2.Z;
			float w = value1.W;
			float w2 = value2.W;
		}

		// Token: 0x0600144B RID: 5195 RVA: 0x0005E86C File Offset: 0x0005CA6C
		public static Vector4 Min(Vector4 value1, Vector4 value2)
		{
			Vector4 vector;
			return vector;
		}

		// Token: 0x0600144C RID: 5196 RVA: 0x0005E884 File Offset: 0x0005CA84
		public static void Min(Vector4 value1, Vector4 value2, [Out] Vector4 result)
		{
			float y = value1.Y;
			float y2 = value2.Y;
			float z = value1.Z;
			float z2 = value2.Z;
			float w = value1.W;
			float w2 = value2.W;
		}

		// Token: 0x0600144D RID: 5197 RVA: 0x0005E8CC File Offset: 0x0005CACC
		public static Vector4 Multiply(Vector4 value1, Vector4 value2)
		{
			Vector4 vector;
			return vector;
		}

		// Token: 0x0600144E RID: 5198 RVA: 0x0005E8DC File Offset: 0x0005CADC
		public static Vector4 Multiply(Vector4 value1, float scaleFactor)
		{
			Vector4 vector;
			return vector;
		}

		// Token: 0x0600144F RID: 5199 RVA: 0x0005E8EC File Offset: 0x0005CAEC
		public static void Multiply(Vector4 value1, float scaleFactor, [Out] Vector4 result)
		{
			result.X = scaleFactor;
		}

		// Token: 0x06001450 RID: 5200 RVA: 0x0005E900 File Offset: 0x0005CB00
		public static void Multiply(Vector4 value1, Vector4 value2, [Out] Vector4 result)
		{
		}

		// Token: 0x06001451 RID: 5201 RVA: 0x0005E910 File Offset: 0x0005CB10
		public static Vector4 Negate(Vector4 value)
		{
			Vector4 vector;
			return vector;
		}

		// Token: 0x06001452 RID: 5202 RVA: 0x0005E920 File Offset: 0x0005CB20
		public static void Negate(Vector4 value, [Out] Vector4 result)
		{
		}

		// Token: 0x06001453 RID: 5203 RVA: 0x0005E930 File Offset: 0x0005CB30
		public void Normalize()
		{
			if (!true)
			{
			}
		}

		// Token: 0x06001454 RID: 5204 RVA: 0x0005E940 File Offset: 0x0005CB40
		public static Vector4 Normalize(Vector4 vector)
		{
			if (!true)
			{
			}
			return 1;
		}

		// Token: 0x06001455 RID: 5205 RVA: 0x0005E954 File Offset: 0x0005CB54
		public static void Normalize(Vector4 vector, [Out] Vector4 result)
		{
			if (!true)
			{
			}
		}

		// Token: 0x06001456 RID: 5206 RVA: 0x0005E964 File Offset: 0x0005CB64
		public static Vector4 SmoothStep(Vector4 value1, Vector4 value2, float amount)
		{
			Vector4 vector;
			return vector;
		}

		// Token: 0x06001457 RID: 5207 RVA: 0x0005E97C File Offset: 0x0005CB7C
		public static void SmoothStep(Vector4 value1, Vector4 value2, float amount, [Out] Vector4 result)
		{
			float y = value1.Y;
			float y2 = value2.Y;
			float z = value1.Z;
			float z2 = value2.Z;
			float w = value1.W;
			float w2 = value2.W;
		}

		// Token: 0x06001458 RID: 5208 RVA: 0x0005E9C4 File Offset: 0x0005CBC4
		public static Vector4 Subtract(Vector4 value1, Vector4 value2)
		{
			Vector4 vector;
			return vector;
		}

		// Token: 0x06001459 RID: 5209 RVA: 0x0005E9D4 File Offset: 0x0005CBD4
		public static void Subtract(Vector4 value1, Vector4 value2, [Out] Vector4 result)
		{
		}

		// Token: 0x0600145A RID: 5210 RVA: 0x0005E9E4 File Offset: 0x0005CBE4
		public static Vector4 Transform(Vector2 position, Matrix matrix)
		{
			if (!true)
			{
			}
			return 1;
		}

		// Token: 0x0600145B RID: 5211 RVA: 0x000021DB File Offset: 0x000003DB
		public static Vector4 Transform(Vector2 value, Quaternion rotation)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x0600145C RID: 5212 RVA: 0x000021DB File Offset: 0x000003DB
		public static Vector4 Transform(Vector3 value, Quaternion rotation)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x0600145D RID: 5213 RVA: 0x000021DB File Offset: 0x000003DB
		public static Vector4 Transform(Vector4 value, Quaternion rotation)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x0600145E RID: 5214 RVA: 0x000021DB File Offset: 0x000003DB
		public static void Transform(Vector2 value, Quaternion rotation, [Out] Vector4 result)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x0600145F RID: 5215 RVA: 0x000021DB File Offset: 0x000003DB
		public static void Transform(Vector3 value, Quaternion rotation, [Out] Vector4 result)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06001460 RID: 5216 RVA: 0x000021DB File Offset: 0x000003DB
		public static void Transform(Vector4 value, Quaternion rotation, [Out] Vector4 result)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06001461 RID: 5217 RVA: 0x000021DB File Offset: 0x000003DB
		public static void Transform(Vector4[] sourceArray, Quaternion rotation, Vector4[] destinationArray)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06001462 RID: 5218 RVA: 0x000021DB File Offset: 0x000003DB
		public static void Transform(Vector4[] sourceArray, Matrix matrix, Vector4[] destinationArray)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06001463 RID: 5219 RVA: 0x000021DB File Offset: 0x000003DB
		public static void Transform(Vector4[] sourceArray, int sourceIndex, Matrix matrix, Vector4[] destinationArray, int destinationIndex, int length)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06001464 RID: 5220 RVA: 0x000021DB File Offset: 0x000003DB
		public static void Transform(Vector4[] sourceArray, int sourceIndex, Quaternion rotation, Vector4[] destinationArray, int destinationIndex, int length)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06001465 RID: 5221 RVA: 0x0005E9F8 File Offset: 0x0005CBF8
		public static Vector4 Transform(Vector3 position, Matrix matrix)
		{
			if (!true)
			{
			}
			return 1;
		}

		// Token: 0x06001466 RID: 5222 RVA: 0x0005EA0C File Offset: 0x0005CC0C
		public static Vector4 Transform(Vector4 vector, Matrix matrix)
		{
			if (!true)
			{
			}
			return 1;
		}

		// Token: 0x06001467 RID: 5223 RVA: 0x0005EA20 File Offset: 0x0005CC20
		public static void Transform(Vector2 position, Matrix matrix, [Out] Vector4 result)
		{
			float m = matrix.M11;
			float m2 = matrix.M12;
			float m3 = matrix.M41;
		}

		// Token: 0x06001468 RID: 5224 RVA: 0x0005EA44 File Offset: 0x0005CC44
		public static void Transform(Vector3 position, Matrix matrix, [Out] Vector4 result)
		{
			float m = matrix.M11;
			float m2 = matrix.M12;
			float z = position.Z;
			float m3 = matrix.M31;
			float m4 = matrix.M32;
		}

		// Token: 0x06001469 RID: 5225 RVA: 0x0005EA78 File Offset: 0x0005CC78
		public static void Transform(Vector4 vector, Matrix matrix, [Out] Vector4 result)
		{
			float m = matrix.M11;
			float m2 = matrix.M12;
			float z = vector.Z;
			float w = vector.W;
			float m3 = matrix.M31;
			float m4 = matrix.M32;
		}

		// Token: 0x0600146A RID: 5226 RVA: 0x0005EAB4 File Offset: 0x0005CCB4
		public override string ToString()
		{
			/*
An exception occurred when decompiling this method (0600146A)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.String Microsoft.Xna.Framework.Vector4::ToString()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:float32(var_3_06, ldfld:float32(Vector4::Y, ldloc:valuetype Microsoft.Xna.Framework.Vector4&(this)))
	stloc:float32(var_6_0D, ldfld:float32(Vector4::Z, ldloc:valuetype Microsoft.Xna.Framework.Vector4&(this)))
	stloc:float32(var_9_15, ldfld:float32(Vector4::W, ldloc:valuetype Microsoft.Xna.Framework.Vector4&(this)))
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

		// Token: 0x0600146B RID: 5227 RVA: 0x0005EAD8 File Offset: 0x0005CCD8
		public static Vector4 operator -(Vector4 value)
		{
			Vector4 vector;
			return vector;
		}

		// Token: 0x0600146C RID: 5228 RVA: 0x0005EAE8 File Offset: 0x0005CCE8
		public static bool operator ==(Vector4 value1, Vector4 value2)
		{
		}

		// Token: 0x0600146D RID: 5229 RVA: 0x0005EAF8 File Offset: 0x0005CCF8
		public static bool operator !=(Vector4 value1, Vector4 value2)
		{
			return true;
		}

		// Token: 0x0600146E RID: 5230 RVA: 0x0005EB08 File Offset: 0x0005CD08
		public static Vector4 operator +(Vector4 value1, Vector4 value2)
		{
			Vector4 vector;
			return vector;
		}

		// Token: 0x0600146F RID: 5231 RVA: 0x0005EB18 File Offset: 0x0005CD18
		public static Vector4 operator -(Vector4 value1, Vector4 value2)
		{
			Vector4 vector;
			return vector;
		}

		// Token: 0x06001470 RID: 5232 RVA: 0x0005EB28 File Offset: 0x0005CD28
		public static Vector4 operator *(Vector4 value1, Vector4 value2)
		{
			Vector4 vector;
			return vector;
		}

		// Token: 0x06001471 RID: 5233 RVA: 0x0005EB38 File Offset: 0x0005CD38
		public static Vector4 operator *(Vector4 value1, float scaleFactor)
		{
			Vector4 vector;
			return vector;
		}

		// Token: 0x06001472 RID: 5234 RVA: 0x0005EB48 File Offset: 0x0005CD48
		public static Vector4 operator *(float scaleFactor, Vector4 value1)
		{
			Vector4 vector;
			return vector;
		}

		// Token: 0x06001473 RID: 5235 RVA: 0x0005EB58 File Offset: 0x0005CD58
		public static Vector4 operator /(Vector4 value1, Vector4 value2)
		{
			Vector4 vector;
			return vector;
		}

		// Token: 0x06001474 RID: 5236 RVA: 0x0005EB68 File Offset: 0x0005CD68
		public static Vector4 operator /(Vector4 value1, float divider)
		{
			Vector4 vector;
			return vector;
		}

		// Token: 0x06001475 RID: 5237 RVA: 0x0005EB78 File Offset: 0x0005CD78
		// Note: this type is marked as 'beforefieldinit'.
		static Vector4()
		{
		}

		// Token: 0x04002286 RID: 8838
		private static Vector4 zeroVector;

		// Token: 0x04002287 RID: 8839
		private static Vector4 unitVector;

		// Token: 0x04002288 RID: 8840
		private static Vector4 unitXVector;

		// Token: 0x04002289 RID: 8841
		private static Vector4 unitYVector;

		// Token: 0x0400228A RID: 8842
		private static Vector4 unitZVector;

		// Token: 0x0400228B RID: 8843
		private static Vector4 unitWVector;

		// Token: 0x0400228C RID: 8844
		public float X;

		// Token: 0x0400228D RID: 8845
		public float Y;

		// Token: 0x0400228E RID: 8846
		public float Z;

		// Token: 0x0400228F RID: 8847
		public float W;
	}
}
