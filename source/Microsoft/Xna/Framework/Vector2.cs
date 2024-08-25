using System;
using System.Runtime.InteropServices;
using Cpp2IlInjected;

namespace Microsoft.Xna.Framework
{
	// Token: 0x02000330 RID: 816
	[Serializable]
	public struct Vector2 : IEquatable<Vector2>
	{
		// Token: 0x170001E9 RID: 489
		// (get) Token: 0x06001381 RID: 4993 RVA: 0x0005D378 File Offset: 0x0005B578
		public static Vector2 Zero
		{
			get
			{
				if (!true)
				{
				}
				return 1;
			}
		}

		// Token: 0x170001EA RID: 490
		// (get) Token: 0x06001382 RID: 4994 RVA: 0x0005D38C File Offset: 0x0005B58C
		public static Vector2 One
		{
			get
			{
				if (!true)
				{
				}
				return 1;
			}
		}

		// Token: 0x170001EB RID: 491
		// (get) Token: 0x06001383 RID: 4995 RVA: 0x0005D3A0 File Offset: 0x0005B5A0
		public static Vector2 UnitX
		{
			get
			{
				if (!true)
				{
				}
				return 1;
			}
		}

		// Token: 0x170001EC RID: 492
		// (get) Token: 0x06001384 RID: 4996 RVA: 0x0005D3B4 File Offset: 0x0005B5B4
		public static Vector2 UnitY
		{
			get
			{
				if (!true)
				{
				}
				return 1;
			}
		}

		// Token: 0x06001385 RID: 4997 RVA: 0x0005D3C8 File Offset: 0x0005B5C8
		public Vector2(float x, float y)
		{
		}

		// Token: 0x06001386 RID: 4998 RVA: 0x0005D3D8 File Offset: 0x0005B5D8
		public Vector2(float value)
		{
		}

		// Token: 0x06001387 RID: 4999 RVA: 0x0005D3E8 File Offset: 0x0005B5E8
		public static void Reflect(Vector2 vector, Vector2 normal, [Out] Vector2 result)
		{
			if (!true)
			{
			}
		}

		// Token: 0x06001388 RID: 5000 RVA: 0x0005D3F8 File Offset: 0x0005B5F8
		public static Vector2 Reflect(Vector2 vector, Vector2 normal)
		{
			if (!true)
			{
			}
			return 1;
		}

		// Token: 0x06001389 RID: 5001 RVA: 0x0005D40C File Offset: 0x0005B60C
		public static Vector2 Add(Vector2 value1, Vector2 value2)
		{
			Vector2 vector;
			return vector;
		}

		// Token: 0x0600138A RID: 5002 RVA: 0x0005D41C File Offset: 0x0005B61C
		public static void Add(Vector2 value1, Vector2 value2, [Out] Vector2 result)
		{
		}

		// Token: 0x0600138B RID: 5003 RVA: 0x0005D42C File Offset: 0x0005B62C
		public static Vector2 Barycentric(Vector2 value1, Vector2 value2, Vector2 value3, float amount1, float amount2)
		{
			Vector2 vector;
			return vector;
		}

		// Token: 0x0600138C RID: 5004 RVA: 0x0005D440 File Offset: 0x0005B640
		public static void Barycentric(Vector2 value1, Vector2 value2, Vector2 value3, float amount1, float amount2, [Out] Vector2 result)
		{
			float y = value1.Y;
			float y2 = value2.Y;
			float y3 = value3.Y;
		}

		// Token: 0x0600138D RID: 5005 RVA: 0x0005D468 File Offset: 0x0005B668
		public static Vector2 CatmullRom(Vector2 value1, Vector2 value2, Vector2 value3, Vector2 value4, float amount)
		{
			Vector2 vector;
			return vector;
		}

		// Token: 0x0600138E RID: 5006 RVA: 0x0005D47C File Offset: 0x0005B67C
		public static void CatmullRom(Vector2 value1, Vector2 value2, Vector2 value3, Vector2 value4, float amount, [Out] Vector2 result)
		{
			float y = value1.Y;
			float y2 = value2.Y;
			float y3 = value3.Y;
			float y4 = value4.Y;
		}

		// Token: 0x0600138F RID: 5007 RVA: 0x0005D4AC File Offset: 0x0005B6AC
		public static Vector2 Clamp(Vector2 value1, Vector2 min, Vector2 max)
		{
			Vector2 vector;
			return vector;
		}

		// Token: 0x06001390 RID: 5008 RVA: 0x0005D4C0 File Offset: 0x0005B6C0
		public static void Clamp(Vector2 value1, Vector2 min, Vector2 max, [Out] Vector2 result)
		{
			float y = value1.Y;
			float y2 = min.Y;
			float y3 = max.Y;
		}

		// Token: 0x06001391 RID: 5009 RVA: 0x0005D4E8 File Offset: 0x0005B6E8
		public static float Distance(Vector2 value1, Vector2 value2)
		{
			/*
An exception occurred when decompiling this method (06001391)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Single Microsoft.Xna.Framework.Vector2::Distance(Microsoft.Xna.Framework.Vector2,Microsoft.Xna.Framework.Vector2)

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

		// Token: 0x06001392 RID: 5010 RVA: 0x0005D4F8 File Offset: 0x0005B6F8
		public static void Distance(Vector2 value1, Vector2 value2, [Out] float result)
		{
			float x = value1.X;
			float y = value1.Y;
			float x2 = value2.X;
			float y2 = value2.Y;
			if (!true)
			{
			}
		}

		// Token: 0x06001393 RID: 5011 RVA: 0x000021DB File Offset: 0x000003DB
		public static float DistanceSquared(Vector2 value1, Vector2 value2)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06001394 RID: 5012 RVA: 0x0005D524 File Offset: 0x0005B724
		public static void DistanceSquared(Vector2 value1, Vector2 value2, [Out] float result)
		{
			float x = value1.X;
			float y = value1.Y;
			float x2 = value2.X;
			float y2 = value2.Y;
		}

		// Token: 0x06001395 RID: 5013 RVA: 0x0005D550 File Offset: 0x0005B750
		public static Vector2 Divide(Vector2 value1, Vector2 value2)
		{
			Vector2 vector;
			return vector;
		}

		// Token: 0x06001396 RID: 5014 RVA: 0x0005D560 File Offset: 0x0005B760
		public static void Divide(Vector2 value1, Vector2 value2, [Out] Vector2 result)
		{
		}

		// Token: 0x06001397 RID: 5015 RVA: 0x0005D570 File Offset: 0x0005B770
		public static Vector2 Divide(Vector2 value1, float divider)
		{
			Vector2 vector;
			return vector;
		}

		// Token: 0x06001398 RID: 5016 RVA: 0x0005D580 File Offset: 0x0005B780
		public static void Divide(Vector2 value1, float divider, [Out] Vector2 result)
		{
			result.X = divider;
		}

		// Token: 0x06001399 RID: 5017 RVA: 0x000021DB File Offset: 0x000003DB
		public static float Dot(Vector2 value1, Vector2 value2)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x0600139A RID: 5018 RVA: 0x0005D594 File Offset: 0x0005B794
		public static void Dot(Vector2 value1, Vector2 value2, [Out] float result)
		{
			float x = value1.X;
			float y = value1.Y;
			float x2 = value2.X;
			float y2 = value2.Y;
		}

		// Token: 0x0600139B RID: 5019 RVA: 0x0005D5C0 File Offset: 0x0005B7C0
		public override bool Equals(object obj)
		{
			if (obj != null)
			{
			}
			float x = this.X;
			float y = this.Y;
			throw new InvalidCastException();
		}

		// Token: 0x0600139C RID: 5020 RVA: 0x0005D5E8 File Offset: 0x0005B7E8
		public bool Equals(Vector2 other)
		{
			/*
An exception occurred when decompiling this method (0600139C)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean Microsoft.Xna.Framework.Vector2::Equals(Microsoft.Xna.Framework.Vector2)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0000:
	stloc:float32(var_0_06, ldfld:float32(Vector2::X, ldloc:valuetype Microsoft.Xna.Framework.Vector2&(this)))
	stloc:float32(var_1_0D, ldfld:float32(Vector2::Y, ldloc:valuetype Microsoft.Xna.Framework.Vector2&(this)))
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

		// Token: 0x0600139D RID: 5021 RVA: 0x0005D608 File Offset: 0x0005B808
		public override int GetHashCode()
		{
			/*
An exception occurred when decompiling this method (0600139D)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Int32 Microsoft.Xna.Framework.Vector2::GetHashCode()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:float32(var_0_06, ldfld:float32(Vector2::X, ldloc:valuetype Microsoft.Xna.Framework.Vector2&(this)))
	stloc:float32(var_1_0D, ldfld:float32(Vector2::Y, ldloc:valuetype Microsoft.Xna.Framework.Vector2&(this)))
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

		// Token: 0x0600139E RID: 5022 RVA: 0x0005D624 File Offset: 0x0005B824
		public static Vector2 Hermite(Vector2 value1, Vector2 tangent1, Vector2 value2, Vector2 tangent2, float amount)
		{
			Vector2 vector;
			return vector;
		}

		// Token: 0x0600139F RID: 5023 RVA: 0x0005D638 File Offset: 0x0005B838
		public static void Hermite(Vector2 value1, Vector2 tangent1, Vector2 value2, Vector2 tangent2, float amount, [Out] Vector2 result)
		{
			float y = value1.Y;
			float y2 = tangent1.Y;
			float y3 = value2.Y;
			float y4 = tangent2.Y;
			result.Y = y;
		}

		// Token: 0x060013A0 RID: 5024 RVA: 0x0005D670 File Offset: 0x0005B870
		public float Length()
		{
			/*
An exception occurred when decompiling this method (060013A0)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Single Microsoft.Xna.Framework.Vector2::Length()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0000:
	stloc:float32(var_0_06, ldfld:float32(Vector2::X, ldloc:valuetype Microsoft.Xna.Framework.Vector2&(this)))
	stloc:float32(var_1_0D, ldfld:float32(Vector2::Y, ldloc:valuetype Microsoft.Xna.Framework.Vector2&(this)))
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

		// Token: 0x060013A1 RID: 5025 RVA: 0x0005D690 File Offset: 0x0005B890
		public float LengthSquared()
		{
			/*
An exception occurred when decompiling this method (060013A1)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Single Microsoft.Xna.Framework.Vector2::LengthSquared()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:float32(var_0_06, ldfld:float32(Vector2::X, ldloc:valuetype Microsoft.Xna.Framework.Vector2&(this)))
	stloc:float32(var_1_0D, ldfld:float32(Vector2::Y, ldloc:valuetype Microsoft.Xna.Framework.Vector2&(this)))
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

		// Token: 0x060013A2 RID: 5026 RVA: 0x0005D6AC File Offset: 0x0005B8AC
		public static Vector2 Lerp(Vector2 value1, Vector2 value2, float amount)
		{
			Vector2 vector;
			return vector;
		}

		// Token: 0x060013A3 RID: 5027 RVA: 0x0005D6C0 File Offset: 0x0005B8C0
		public static void Lerp(Vector2 value1, Vector2 value2, float amount, [Out] Vector2 result)
		{
			float y = value1.Y;
			float y2 = value2.Y;
		}

		// Token: 0x060013A4 RID: 5028 RVA: 0x0005D6E0 File Offset: 0x0005B8E0
		public static Vector2 Max(Vector2 value1, Vector2 value2)
		{
			Vector2 vector;
			return vector;
		}

		// Token: 0x060013A5 RID: 5029 RVA: 0x0005D6F4 File Offset: 0x0005B8F4
		public static void Max(Vector2 value1, Vector2 value2, [Out] Vector2 result)
		{
			float y = value1.Y;
			float y2 = value2.Y;
		}

		// Token: 0x060013A6 RID: 5030 RVA: 0x0005D714 File Offset: 0x0005B914
		public static Vector2 Min(Vector2 value1, Vector2 value2)
		{
			Vector2 vector;
			return vector;
		}

		// Token: 0x060013A7 RID: 5031 RVA: 0x0005D728 File Offset: 0x0005B928
		public static void Min(Vector2 value1, Vector2 value2, [Out] Vector2 result)
		{
			float y = value1.Y;
			float y2 = value2.Y;
		}

		// Token: 0x060013A8 RID: 5032 RVA: 0x0005D748 File Offset: 0x0005B948
		public static Vector2 Multiply(Vector2 value1, Vector2 value2)
		{
			Vector2 vector;
			return vector;
		}

		// Token: 0x060013A9 RID: 5033 RVA: 0x0005D758 File Offset: 0x0005B958
		public static Vector2 Multiply(Vector2 value1, float scaleFactor)
		{
			Vector2 vector;
			return vector;
		}

		// Token: 0x060013AA RID: 5034 RVA: 0x0005D768 File Offset: 0x0005B968
		public static void Multiply(Vector2 value1, float scaleFactor, [Out] Vector2 result)
		{
			result.X = scaleFactor;
		}

		// Token: 0x060013AB RID: 5035 RVA: 0x0005D77C File Offset: 0x0005B97C
		public static void Multiply(Vector2 value1, Vector2 value2, [Out] Vector2 result)
		{
		}

		// Token: 0x060013AC RID: 5036 RVA: 0x0005D78C File Offset: 0x0005B98C
		public static Vector2 Negate(Vector2 value)
		{
			Vector2 vector;
			return vector;
		}

		// Token: 0x060013AD RID: 5037 RVA: 0x0005D79C File Offset: 0x0005B99C
		public static void Negate(Vector2 value, [Out] Vector2 result)
		{
		}

		// Token: 0x060013AE RID: 5038 RVA: 0x0005D7AC File Offset: 0x0005B9AC
		public void Normalize()
		{
			if (!true)
			{
			}
		}

		// Token: 0x060013AF RID: 5039 RVA: 0x0005D7BC File Offset: 0x0005B9BC
		public static Vector2 Normalize(Vector2 value)
		{
			if (!true)
			{
			}
			return 1;
		}

		// Token: 0x060013B0 RID: 5040 RVA: 0x0005D7D0 File Offset: 0x0005B9D0
		public static void Normalize(Vector2 value, [Out] Vector2 result)
		{
			if (!true)
			{
			}
		}

		// Token: 0x060013B1 RID: 5041 RVA: 0x0005D7E0 File Offset: 0x0005B9E0
		public static Vector2 SmoothStep(Vector2 value1, Vector2 value2, float amount)
		{
			Vector2 vector;
			return vector;
		}

		// Token: 0x060013B2 RID: 5042 RVA: 0x0005D7F4 File Offset: 0x0005B9F4
		public static void SmoothStep(Vector2 value1, Vector2 value2, float amount, [Out] Vector2 result)
		{
			float y = value1.Y;
			float y2 = value2.Y;
		}

		// Token: 0x060013B3 RID: 5043 RVA: 0x0005D814 File Offset: 0x0005BA14
		public static Vector2 Subtract(Vector2 value1, Vector2 value2)
		{
			Vector2 vector;
			return vector;
		}

		// Token: 0x060013B4 RID: 5044 RVA: 0x0005D824 File Offset: 0x0005BA24
		public static void Subtract(Vector2 value1, Vector2 value2, [Out] Vector2 result)
		{
		}

		// Token: 0x060013B5 RID: 5045 RVA: 0x0005D834 File Offset: 0x0005BA34
		public static Vector2 Transform(Vector2 position, Matrix matrix)
		{
			if (!true)
			{
			}
			return 1;
		}

		// Token: 0x060013B6 RID: 5046 RVA: 0x0005D848 File Offset: 0x0005BA48
		public static void Transform(Vector2 position, Matrix matrix, [Out] Vector2 result)
		{
			float m = matrix.M21;
			float m2 = matrix.M41;
		}

		// Token: 0x060013B7 RID: 5047 RVA: 0x000021DB File Offset: 0x000003DB
		public static Vector2 Transform(Vector2 value, Quaternion rotation)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x060013B8 RID: 5048 RVA: 0x000021DB File Offset: 0x000003DB
		public static void Transform(Vector2 value, Quaternion rotation, [Out] Vector2 result)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x060013B9 RID: 5049 RVA: 0x000021DB File Offset: 0x000003DB
		public static void Transform(Vector2[] sourceArray, Matrix matrix, Vector2[] destinationArray)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x060013BA RID: 5050 RVA: 0x000021DB File Offset: 0x000003DB
		public static void Transform(Vector2[] sourceArray, Quaternion rotation, Vector2[] destinationArray)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x060013BB RID: 5051 RVA: 0x000021DB File Offset: 0x000003DB
		public static void Transform(Vector2[] sourceArray, int sourceIndex, Matrix matrix, Vector2[] destinationArray, int destinationIndex, int length)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x060013BC RID: 5052 RVA: 0x000021DB File Offset: 0x000003DB
		public static void Transform(Vector2[] sourceArray, int sourceIndex, Quaternion rotation, Vector2[] destinationArray, int destinationIndex, int length)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x060013BD RID: 5053 RVA: 0x0005D864 File Offset: 0x0005BA64
		public static Vector2 TransformNormal(Vector2 normal, Matrix matrix)
		{
			if (!true)
			{
			}
			return 1;
		}

		// Token: 0x060013BE RID: 5054 RVA: 0x0005D878 File Offset: 0x0005BA78
		public static void TransformNormal(Vector2 normal, Matrix matrix, [Out] Vector2 result)
		{
			float m = matrix.M21;
		}

		// Token: 0x060013BF RID: 5055 RVA: 0x000021DB File Offset: 0x000003DB
		public static void TransformNormal(Vector2[] sourceArray, Matrix matrix, Vector2[] destinationArray)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x060013C0 RID: 5056 RVA: 0x000021DB File Offset: 0x000003DB
		public static void TransformNormal(Vector2[] sourceArray, int sourceIndex, Matrix matrix, Vector2[] destinationArray, int destinationIndex, int length)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x060013C1 RID: 5057 RVA: 0x0005D88C File Offset: 0x0005BA8C
		public override string ToString()
		{
			/*
An exception occurred when decompiling this method (060013C1)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.String Microsoft.Xna.Framework.Vector2::ToString()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:float32(var_3_06, ldfld:float32(Vector2::Y, ldloc:valuetype Microsoft.Xna.Framework.Vector2&(this)))
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

		// Token: 0x060013C2 RID: 5058 RVA: 0x0005D8A0 File Offset: 0x0005BAA0
		public static Vector2 operator -(Vector2 value)
		{
			Vector2 vector;
			return vector;
		}

		// Token: 0x060013C3 RID: 5059 RVA: 0x000021DB File Offset: 0x000003DB
		public static bool operator ==(Vector2 value1, Vector2 value2)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x060013C4 RID: 5060 RVA: 0x000021DB File Offset: 0x000003DB
		public static bool operator !=(Vector2 value1, Vector2 value2)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x060013C5 RID: 5061 RVA: 0x0005D8B0 File Offset: 0x0005BAB0
		public static Vector2 operator +(Vector2 value1, Vector2 value2)
		{
			Vector2 vector;
			return vector;
		}

		// Token: 0x060013C6 RID: 5062 RVA: 0x0005D8C0 File Offset: 0x0005BAC0
		public static Vector2 operator -(Vector2 value1, Vector2 value2)
		{
			Vector2 vector;
			return vector;
		}

		// Token: 0x060013C7 RID: 5063 RVA: 0x0005D8D0 File Offset: 0x0005BAD0
		public static Vector2 operator *(Vector2 value1, Vector2 value2)
		{
			Vector2 vector;
			return vector;
		}

		// Token: 0x060013C8 RID: 5064 RVA: 0x0005D8E0 File Offset: 0x0005BAE0
		public static Vector2 operator *(Vector2 value, float scaleFactor)
		{
			Vector2 vector;
			return vector;
		}

		// Token: 0x060013C9 RID: 5065 RVA: 0x0005D8F0 File Offset: 0x0005BAF0
		public static Vector2 operator *(float scaleFactor, Vector2 value)
		{
			Vector2 vector;
			return vector;
		}

		// Token: 0x060013CA RID: 5066 RVA: 0x0005D900 File Offset: 0x0005BB00
		public static Vector2 operator /(Vector2 value1, Vector2 value2)
		{
			Vector2 vector;
			return vector;
		}

		// Token: 0x060013CB RID: 5067 RVA: 0x0005D910 File Offset: 0x0005BB10
		public static Vector2 operator /(Vector2 value1, float divider)
		{
			Vector2 vector;
			return vector;
		}

		// Token: 0x060013CC RID: 5068 RVA: 0x0005D920 File Offset: 0x0005BB20
		// Note: this type is marked as 'beforefieldinit'.
		static Vector2()
		{
		}

		// Token: 0x04002272 RID: 8818
		private static Vector2 zeroVector;

		// Token: 0x04002273 RID: 8819
		private static Vector2 unitVector;

		// Token: 0x04002274 RID: 8820
		private static Vector2 unitXVector;

		// Token: 0x04002275 RID: 8821
		private static Vector2 unitYVector;

		// Token: 0x04002276 RID: 8822
		public float X;

		// Token: 0x04002277 RID: 8823
		public float Y;
	}
}
