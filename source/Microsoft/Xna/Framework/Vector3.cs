using System;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using UnityEngine;

namespace Microsoft.Xna.Framework
{
	// Token: 0x02000331 RID: 817
	[Serializable]
	public struct Vector3 : IEquatable<Vector3>
	{
		// Token: 0x170001ED RID: 493
		// (get) Token: 0x060013CD RID: 5069 RVA: 0x0005D930 File Offset: 0x0005BB30
		public static Vector3 Zero
		{
			get
			{
				if (!true)
				{
				}
				return 1;
			}
		}

		// Token: 0x170001EE RID: 494
		// (get) Token: 0x060013CE RID: 5070 RVA: 0x0005D944 File Offset: 0x0005BB44
		public static Vector3 One
		{
			get
			{
				if (!true)
				{
				}
				return 1;
			}
		}

		// Token: 0x170001EF RID: 495
		// (get) Token: 0x060013CF RID: 5071 RVA: 0x0005D958 File Offset: 0x0005BB58
		public static Vector3 UnitX
		{
			get
			{
				if (!true)
				{
				}
				return 1;
			}
		}

		// Token: 0x170001F0 RID: 496
		// (get) Token: 0x060013D0 RID: 5072 RVA: 0x0005D96C File Offset: 0x0005BB6C
		public static Vector3 UnitY
		{
			get
			{
				if (!true)
				{
				}
				return 1;
			}
		}

		// Token: 0x170001F1 RID: 497
		// (get) Token: 0x060013D1 RID: 5073 RVA: 0x0005D980 File Offset: 0x0005BB80
		public static Vector3 UnitZ
		{
			get
			{
				if (!true)
				{
				}
				return 1;
			}
		}

		// Token: 0x170001F2 RID: 498
		// (get) Token: 0x060013D2 RID: 5074 RVA: 0x0005D994 File Offset: 0x0005BB94
		public static Vector3 Up
		{
			get
			{
				if (!true)
				{
				}
				return 1;
			}
		}

		// Token: 0x170001F3 RID: 499
		// (get) Token: 0x060013D3 RID: 5075 RVA: 0x0005D9A8 File Offset: 0x0005BBA8
		public static Vector3 Down
		{
			get
			{
				if (!true)
				{
				}
				return 1;
			}
		}

		// Token: 0x170001F4 RID: 500
		// (get) Token: 0x060013D4 RID: 5076 RVA: 0x0005D9BC File Offset: 0x0005BBBC
		public static Vector3 Right
		{
			get
			{
				if (!true)
				{
				}
				return 1;
			}
		}

		// Token: 0x170001F5 RID: 501
		// (get) Token: 0x060013D5 RID: 5077 RVA: 0x0005D9D0 File Offset: 0x0005BBD0
		public static Vector3 Left
		{
			get
			{
				if (!true)
				{
				}
				return 1;
			}
		}

		// Token: 0x170001F6 RID: 502
		// (get) Token: 0x060013D6 RID: 5078 RVA: 0x0005D9E4 File Offset: 0x0005BBE4
		public static Vector3 Forward
		{
			get
			{
				if (!true)
				{
				}
				return 1;
			}
		}

		// Token: 0x170001F7 RID: 503
		// (get) Token: 0x060013D7 RID: 5079 RVA: 0x0005D9F8 File Offset: 0x0005BBF8
		public static Vector3 Backward
		{
			get
			{
				if (!true)
				{
				}
				return 1;
			}
		}

		// Token: 0x060013D8 RID: 5080 RVA: 0x0005DA0C File Offset: 0x0005BC0C
		public Vector3(float x, float y, float z)
		{
		}

		// Token: 0x060013D9 RID: 5081 RVA: 0x0005DA1C File Offset: 0x0005BC1C
		public Vector3(float value)
		{
		}

		// Token: 0x060013DA RID: 5082 RVA: 0x0005DA2C File Offset: 0x0005BC2C
		public Vector3(Vector2 value, float z)
		{
		}

		// Token: 0x060013DB RID: 5083 RVA: 0x0005DA3C File Offset: 0x0005BC3C
		public static Vector3 Add(Vector3 value1, Vector3 value2)
		{
			Vector3 vector;
			return vector;
		}

		// Token: 0x060013DC RID: 5084 RVA: 0x0005DA4C File Offset: 0x0005BC4C
		public static void Add(Vector3 value1, Vector3 value2, [Out] Vector3 result)
		{
			float z = value1.Z;
			float z2 = value2.Z;
			result.Z = z;
		}

		// Token: 0x060013DD RID: 5085 RVA: 0x0005DA70 File Offset: 0x0005BC70
		public static Vector3 Barycentric(Vector3 value1, Vector3 value2, Vector3 value3, float amount1, float amount2)
		{
			Vector3 vector;
			return vector;
		}

		// Token: 0x060013DE RID: 5086 RVA: 0x0005DA88 File Offset: 0x0005BC88
		public static void Barycentric(Vector3 value1, Vector3 value2, Vector3 value3, float amount1, float amount2, [Out] Vector3 result)
		{
			float y = value1.Y;
			float y2 = value2.Y;
			float y3 = value3.Y;
			float z = value1.Z;
			float z2 = value2.Z;
			float z3 = value3.Z;
		}

		// Token: 0x060013DF RID: 5087 RVA: 0x0005DACC File Offset: 0x0005BCCC
		public static Vector3 CatmullRom(Vector3 value1, Vector3 value2, Vector3 value3, Vector3 value4, float amount)
		{
			Vector3 vector;
			return vector;
		}

		// Token: 0x060013E0 RID: 5088 RVA: 0x0005DAE4 File Offset: 0x0005BCE4
		public static void CatmullRom(Vector3 value1, Vector3 value2, Vector3 value3, Vector3 value4, float amount, [Out] Vector3 result)
		{
			float y = value1.Y;
			float y2 = value2.Y;
			float y3 = value3.Y;
			float y4 = value4.Y;
			float z = value1.Z;
			float z2 = value2.Z;
			float z3 = value3.Z;
			float z4 = value4.Z;
		}

		// Token: 0x060013E1 RID: 5089 RVA: 0x0005DB38 File Offset: 0x0005BD38
		public static Vector3 Clamp(Vector3 value1, Vector3 min, Vector3 max)
		{
			Vector3 vector;
			return vector;
		}

		// Token: 0x060013E2 RID: 5090 RVA: 0x0005DB50 File Offset: 0x0005BD50
		public static void Clamp(Vector3 value1, Vector3 min, Vector3 max, [Out] Vector3 result)
		{
			float y = value1.Y;
			float y2 = min.Y;
			float y3 = max.Y;
			float z = value1.Z;
			float z2 = min.Z;
			float z3 = max.Z;
		}

		// Token: 0x060013E3 RID: 5091 RVA: 0x0005DB94 File Offset: 0x0005BD94
		public static Vector3 Cross(Vector3 vector1, Vector3 vector2)
		{
			Vector3 vector3;
			return vector3;
		}

		// Token: 0x060013E4 RID: 5092 RVA: 0x0005DBA4 File Offset: 0x0005BDA4
		public static void Cross(Vector3 vector1, Vector3 vector2, [Out] Vector3 result)
		{
			float y = vector2.Y;
			float z = vector2.Z;
			float y2 = vector1.Y;
			float z2 = vector1.Z;
			result.X = y;
			result.Y = z;
			float y3 = vector2.Y;
			float y4 = vector1.Y;
		}

		// Token: 0x060013E5 RID: 5093 RVA: 0x0005DBEC File Offset: 0x0005BDEC
		public static float Distance(Vector3 value1, Vector3 value2)
		{
			/*
An exception occurred when decompiling this method (060013E5)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Single Microsoft.Xna.Framework.Vector3::Distance(Microsoft.Xna.Framework.Vector3,Microsoft.Xna.Framework.Vector3)

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

		// Token: 0x060013E6 RID: 5094 RVA: 0x0005DBFC File Offset: 0x0005BDFC
		public static void Distance(Vector3 value1, Vector3 value2, [Out] float result)
		{
			float x = value1.X;
			float y = value1.Y;
			float x2 = value2.X;
			float y2 = value2.Y;
			float z = value1.Z;
			float z2 = value2.Z;
			if (!true)
			{
			}
		}

		// Token: 0x060013E7 RID: 5095 RVA: 0x000021DB File Offset: 0x000003DB
		public static float DistanceSquared(Vector3 value1, Vector3 value2)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x060013E8 RID: 5096 RVA: 0x0005DC38 File Offset: 0x0005BE38
		public static void DistanceSquared(Vector3 value1, Vector3 value2, [Out] float result)
		{
			float x = value1.X;
			float y = value1.Y;
			float x2 = value2.X;
			float y2 = value2.Y;
			float z = value1.Z;
			float z2 = value2.Z;
		}

		// Token: 0x060013E9 RID: 5097 RVA: 0x0005DC74 File Offset: 0x0005BE74
		public static Vector3 Divide(Vector3 value1, Vector3 value2)
		{
			Vector3 vector;
			return vector;
		}

		// Token: 0x060013EA RID: 5098 RVA: 0x0005DC84 File Offset: 0x0005BE84
		public static Vector3 Divide(Vector3 value1, float value2)
		{
			Vector3 vector;
			return vector;
		}

		// Token: 0x060013EB RID: 5099 RVA: 0x0005DC94 File Offset: 0x0005BE94
		public static void Divide(Vector3 value1, float divisor, [Out] Vector3 result)
		{
			float z = value1.Z;
		}

		// Token: 0x060013EC RID: 5100 RVA: 0x0005DCA8 File Offset: 0x0005BEA8
		public static void Divide(Vector3 value1, Vector3 value2, [Out] Vector3 result)
		{
			float z = value1.Z;
			float z2 = value2.Z;
			result.Z = z;
		}

		// Token: 0x060013ED RID: 5101 RVA: 0x000021DB File Offset: 0x000003DB
		public static float Dot(Vector3 vector1, Vector3 vector2)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x060013EE RID: 5102 RVA: 0x0005DCCC File Offset: 0x0005BECC
		public static void Dot(Vector3 vector1, Vector3 vector2, [Out] float result)
		{
			float x = vector1.X;
			float y = vector1.Y;
			float x2 = vector2.X;
			float y2 = vector2.Y;
			float z = vector1.Z;
			float z2 = vector2.Z;
		}

		// Token: 0x060013EF RID: 5103 RVA: 0x0005DD08 File Offset: 0x0005BF08
		public override bool Equals(object obj)
		{
			if (obj != null)
			{
			}
			float x = this.X;
			float y = this.Y;
			float z = this.Z;
			throw new InvalidCastException();
		}

		// Token: 0x060013F0 RID: 5104 RVA: 0x0005DD34 File Offset: 0x0005BF34
		public bool Equals(Vector3 other)
		{
			float x = this.X;
			float y = this.Y;
			float z = this.Z;
			if (!true)
			{
				return;
			}
		}

		// Token: 0x060013F1 RID: 5105 RVA: 0x0005DD5C File Offset: 0x0005BF5C
		public override int GetHashCode()
		{
			/*
An exception occurred when decompiling this method (060013F1)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Int32 Microsoft.Xna.Framework.Vector3::GetHashCode()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:float32(var_0_06, ldfld:float32(Vector3::X, ldloc:valuetype Microsoft.Xna.Framework.Vector3&(this)))
	stloc:float32(var_1_0D, ldfld:float32(Vector3::Y, ldloc:valuetype Microsoft.Xna.Framework.Vector3&(this)))
	stloc:float32(var_2_14, ldfld:float32(Vector3::Z, ldloc:valuetype Microsoft.Xna.Framework.Vector3&(this)))
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

		// Token: 0x060013F2 RID: 5106 RVA: 0x0005DD80 File Offset: 0x0005BF80
		public static Vector3 Hermite(Vector3 value1, Vector3 tangent1, Vector3 value2, Vector3 tangent2, float amount)
		{
			Vector3 vector;
			return vector;
		}

		// Token: 0x060013F3 RID: 5107 RVA: 0x0005DD98 File Offset: 0x0005BF98
		public static void Hermite(Vector3 value1, Vector3 tangent1, Vector3 value2, Vector3 tangent2, float amount, [Out] Vector3 result)
		{
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

		// Token: 0x060013F4 RID: 5108 RVA: 0x0005DDFC File Offset: 0x0005BFFC
		public float Length()
		{
			/*
An exception occurred when decompiling this method (060013F4)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Single Microsoft.Xna.Framework.Vector3::Length()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0000:
	stloc:float32(var_0_06, ldfld:float32(Vector3::X, ldloc:valuetype Microsoft.Xna.Framework.Vector3&(this)))
	stloc:float32(var_1_0D, ldfld:float32(Vector3::Y, ldloc:valuetype Microsoft.Xna.Framework.Vector3&(this)))
	stloc:float32(var_2_14, ldfld:float32(Vector3::Z, ldloc:valuetype Microsoft.Xna.Framework.Vector3&(this)))
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

		// Token: 0x060013F5 RID: 5109 RVA: 0x0005DE20 File Offset: 0x0005C020
		public float LengthSquared()
		{
			/*
An exception occurred when decompiling this method (060013F5)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Single Microsoft.Xna.Framework.Vector3::LengthSquared()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:float32(var_0_06, ldfld:float32(Vector3::X, ldloc:valuetype Microsoft.Xna.Framework.Vector3&(this)))
	stloc:float32(var_1_0D, ldfld:float32(Vector3::Y, ldloc:valuetype Microsoft.Xna.Framework.Vector3&(this)))
	stloc:float32(var_2_14, ldfld:float32(Vector3::Z, ldloc:valuetype Microsoft.Xna.Framework.Vector3&(this)))
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

		// Token: 0x060013F6 RID: 5110 RVA: 0x0005DE44 File Offset: 0x0005C044
		public static Vector3 Lerp(Vector3 value1, Vector3 value2, float amount)
		{
			Vector3 vector;
			return vector;
		}

		// Token: 0x060013F7 RID: 5111 RVA: 0x0005DE5C File Offset: 0x0005C05C
		public static void Lerp(Vector3 value1, Vector3 value2, float amount, [Out] Vector3 result)
		{
			float y = value1.Y;
			float y2 = value2.Y;
			float z = value1.Z;
			float z2 = value2.Z;
		}

		// Token: 0x060013F8 RID: 5112 RVA: 0x0005DE90 File Offset: 0x0005C090
		public static Vector3 Max(Vector3 value1, Vector3 value2)
		{
			Vector3 vector;
			return vector;
		}

		// Token: 0x060013F9 RID: 5113 RVA: 0x0005DEA8 File Offset: 0x0005C0A8
		public static void Max(Vector3 value1, Vector3 value2, [Out] Vector3 result)
		{
			float y = value1.Y;
			float y2 = value2.Y;
			float z = value1.Z;
			float z2 = value2.Z;
		}

		// Token: 0x060013FA RID: 5114 RVA: 0x0005DEDC File Offset: 0x0005C0DC
		public static Vector3 Min(Vector3 value1, Vector3 value2)
		{
			Vector3 vector;
			return vector;
		}

		// Token: 0x060013FB RID: 5115 RVA: 0x0005DEF4 File Offset: 0x0005C0F4
		public static void Min(Vector3 value1, Vector3 value2, [Out] Vector3 result)
		{
			float y = value1.Y;
			float y2 = value2.Y;
			float z = value1.Z;
			float z2 = value2.Z;
		}

		// Token: 0x060013FC RID: 5116 RVA: 0x0005DF28 File Offset: 0x0005C128
		public static Vector3 Multiply(Vector3 value1, Vector3 value2)
		{
			Vector3 vector;
			return vector;
		}

		// Token: 0x060013FD RID: 5117 RVA: 0x0005DF38 File Offset: 0x0005C138
		public static Vector3 Multiply(Vector3 value1, float scaleFactor)
		{
			Vector3 vector;
			return vector;
		}

		// Token: 0x060013FE RID: 5118 RVA: 0x0005DF48 File Offset: 0x0005C148
		public static void Multiply(Vector3 value1, float scaleFactor, [Out] Vector3 result)
		{
			float z = value1.Z;
		}

		// Token: 0x060013FF RID: 5119 RVA: 0x0005DF5C File Offset: 0x0005C15C
		public static void Multiply(Vector3 value1, Vector3 value2, [Out] Vector3 result)
		{
			float z = value1.Z;
			float z2 = value2.Z;
			result.Z = z;
		}

		// Token: 0x06001400 RID: 5120 RVA: 0x0005DF80 File Offset: 0x0005C180
		public static Vector3 Negate(Vector3 value)
		{
			Vector3 vector;
			return vector;
		}

		// Token: 0x06001401 RID: 5121 RVA: 0x0005DF90 File Offset: 0x0005C190
		public static void Negate(Vector3 value, [Out] Vector3 result)
		{
			float z = value.Z;
			result.Z = z;
		}

		// Token: 0x06001402 RID: 5122 RVA: 0x0005DFAC File Offset: 0x0005C1AC
		public void Normalize()
		{
			float z = this.Z;
			float z2;
			if (!true)
			{
				z2 = this.Z;
			}
			this.Z = z2;
		}

		// Token: 0x06001403 RID: 5123 RVA: 0x0005DFD4 File Offset: 0x0005C1D4
		public static Vector3 Normalize(Vector3 value)
		{
			if (!true)
			{
			}
			return 1;
		}

		// Token: 0x06001404 RID: 5124 RVA: 0x0005DFE8 File Offset: 0x0005C1E8
		public static void Normalize(Vector3 value, [Out] Vector3 result)
		{
			float z = value.Z;
			float z2;
			if (!true)
			{
				z2 = value.Z;
			}
			result.Z = z2;
		}

		// Token: 0x06001405 RID: 5125 RVA: 0x0005E010 File Offset: 0x0005C210
		public static Vector3 Reflect(Vector3 vector, Vector3 normal)
		{
			if (!true)
			{
			}
			return 1;
		}

		// Token: 0x06001406 RID: 5126 RVA: 0x0005E024 File Offset: 0x0005C224
		public static void Reflect(Vector3 vector, Vector3 normal, [Out] Vector3 result)
		{
			float z = vector.Z;
			float z2 = normal.Z;
			float z3;
			if (!true)
			{
				z3 = vector.Z;
				float z4 = normal.Z;
			}
			result.Z = z3;
		}

		// Token: 0x06001407 RID: 5127 RVA: 0x0005E058 File Offset: 0x0005C258
		public static Vector3 SmoothStep(Vector3 value1, Vector3 value2, float amount)
		{
			Vector3 vector;
			return vector;
		}

		// Token: 0x06001408 RID: 5128 RVA: 0x0005E070 File Offset: 0x0005C270
		public static void SmoothStep(Vector3 value1, Vector3 value2, float amount, [Out] Vector3 result)
		{
			float y = value1.Y;
			float y2 = value2.Y;
			float z = value1.Z;
			float z2 = value2.Z;
		}

		// Token: 0x06001409 RID: 5129 RVA: 0x0005E0A4 File Offset: 0x0005C2A4
		public static Vector3 Subtract(Vector3 value1, Vector3 value2)
		{
			Vector3 vector;
			return vector;
		}

		// Token: 0x0600140A RID: 5130 RVA: 0x0005E0B4 File Offset: 0x0005C2B4
		public static void Subtract(Vector3 value1, Vector3 value2, [Out] Vector3 result)
		{
			float z = value1.Z;
			float z2 = value2.Z;
			result.Z = z;
		}

		// Token: 0x0600140B RID: 5131 RVA: 0x0005E0D8 File Offset: 0x0005C2D8
		public override string ToString()
		{
			/*
An exception occurred when decompiling this method (0600140B)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.String Microsoft.Xna.Framework.Vector3::ToString()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:float32(var_3_06, ldfld:float32(Vector3::Y, ldloc:valuetype Microsoft.Xna.Framework.Vector3&(this)))
	stloc:float32(var_6_0D, ldfld:float32(Vector3::Z, ldloc:valuetype Microsoft.Xna.Framework.Vector3&(this)))
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

		// Token: 0x0600140C RID: 5132 RVA: 0x0005E0F4 File Offset: 0x0005C2F4
		public static Vector3 Transform(Vector3 position, Matrix matrix)
		{
			if (!true)
			{
			}
			return 1;
		}

		// Token: 0x0600140D RID: 5133 RVA: 0x0005E108 File Offset: 0x0005C308
		public static void Transform(Vector3 position, Matrix matrix, [Out] Vector3 result)
		{
			float x = position.X;
			float y = position.Y;
			float m = matrix.M21;
			float m2 = matrix.M13;
			float m3 = matrix.M23;
			float z = position.Z;
			float m4 = matrix.M31;
			float m5 = matrix.M33;
			float m6 = matrix.M41;
			float m7 = matrix.M43;
			result.Z = x;
		}

		// Token: 0x0600140E RID: 5134 RVA: 0x0005E168 File Offset: 0x0005C368
		public Vector3 UnityVec3()
		{
			float x = this.X;
			float y = this.Y;
			float z = this.Z;
			Vector3 vector;
			return vector;
		}

		// Token: 0x0600140F RID: 5135 RVA: 0x000021DB File Offset: 0x000003DB
		public static Vector3 Transform(Vector3 value, Quaternion rotation)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06001410 RID: 5136 RVA: 0x000021DB File Offset: 0x000003DB
		public static void Transform(Vector3[] sourceArray, Matrix matrix, Vector3[] destinationArray)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06001411 RID: 5137 RVA: 0x000021DB File Offset: 0x000003DB
		public static void Transform(Vector3[] sourceArray, Quaternion rotation, Vector3[] destinationArray)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06001412 RID: 5138 RVA: 0x000021DB File Offset: 0x000003DB
		public static void Transform(Vector3[] sourceArray, int sourceIndex, Matrix matrix, Vector3[] destinationArray, int destinationIndex, int length)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06001413 RID: 5139 RVA: 0x000021DB File Offset: 0x000003DB
		public static void Transform(Vector3[] sourceArray, int sourceIndex, Quaternion rotation, Vector3[] destinationArray, int destinationIndex, int length)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06001414 RID: 5140 RVA: 0x000021DB File Offset: 0x000003DB
		public static void Transform(Vector3 value, Quaternion rotation, [Out] Vector3 result)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06001415 RID: 5141 RVA: 0x000021DB File Offset: 0x000003DB
		public static void TransformNormal(Vector3[] sourceArray, Matrix matrix, Vector3[] destinationArray)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06001416 RID: 5142 RVA: 0x000021DB File Offset: 0x000003DB
		public static void TransformNormal(Vector3[] sourceArray, int sourceIndex, Matrix matrix, Vector3[] destinationArray, int destinationIndex, int length)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06001417 RID: 5143 RVA: 0x0005E18C File Offset: 0x0005C38C
		public static Vector3 TransformNormal(Vector3 normal, Matrix matrix)
		{
			if (!true)
			{
			}
			float z = normal.Z;
			return 1;
		}

		// Token: 0x06001418 RID: 5144 RVA: 0x0005E1A4 File Offset: 0x0005C3A4
		public static void TransformNormal(Vector3 normal, Matrix matrix, [Out] Vector3 result)
		{
			float x = normal.X;
			float y = normal.Y;
			float m = matrix.M21;
			float m2 = matrix.M13;
			float m3 = matrix.M23;
			float z = normal.Z;
			float m4 = matrix.M31;
			float m5 = matrix.M33;
			result.Z = x;
		}

		// Token: 0x06001419 RID: 5145 RVA: 0x0005E1F4 File Offset: 0x0005C3F4
		public static bool operator ==(Vector3 value1, Vector3 value2)
		{
		}

		// Token: 0x0600141A RID: 5146 RVA: 0x0005E204 File Offset: 0x0005C404
		public static bool operator !=(Vector3 value1, Vector3 value2)
		{
			return true;
		}

		// Token: 0x0600141B RID: 5147 RVA: 0x0005E214 File Offset: 0x0005C414
		public static Vector3 operator +(Vector3 value1, Vector3 value2)
		{
			Vector3 vector;
			return vector;
		}

		// Token: 0x0600141C RID: 5148 RVA: 0x0005E224 File Offset: 0x0005C424
		public static Vector3 operator -(Vector3 value)
		{
			Vector3 vector;
			return vector;
		}

		// Token: 0x0600141D RID: 5149 RVA: 0x0005E234 File Offset: 0x0005C434
		public static Vector3 operator -(Vector3 value1, Vector3 value2)
		{
			Vector3 vector;
			return vector;
		}

		// Token: 0x0600141E RID: 5150 RVA: 0x0005E244 File Offset: 0x0005C444
		public static Vector3 operator *(Vector3 value1, Vector3 value2)
		{
			Vector3 vector;
			return vector;
		}

		// Token: 0x0600141F RID: 5151 RVA: 0x0005E254 File Offset: 0x0005C454
		public static Vector3 operator *(Vector3 value, float scaleFactor)
		{
			Vector3 vector;
			return vector;
		}

		// Token: 0x06001420 RID: 5152 RVA: 0x0005E264 File Offset: 0x0005C464
		public static Vector3 operator *(float scaleFactor, Vector3 value)
		{
			Vector3 vector;
			return vector;
		}

		// Token: 0x06001421 RID: 5153 RVA: 0x0005E274 File Offset: 0x0005C474
		public static Vector3 operator /(Vector3 value1, Vector3 value2)
		{
			Vector3 vector;
			return vector;
		}

		// Token: 0x06001422 RID: 5154 RVA: 0x0005E284 File Offset: 0x0005C484
		public static Vector3 operator /(Vector3 value, float divider)
		{
			Vector3 vector;
			return vector;
		}

		// Token: 0x06001423 RID: 5155 RVA: 0x0005E294 File Offset: 0x0005C494
		// Note: this type is marked as 'beforefieldinit'.
		static Vector3()
		{
		}

		// Token: 0x04002278 RID: 8824
		private static Vector3 zero;

		// Token: 0x04002279 RID: 8825
		private static Vector3 one;

		// Token: 0x0400227A RID: 8826
		private static Vector3 unitX;

		// Token: 0x0400227B RID: 8827
		private static Vector3 unitY;

		// Token: 0x0400227C RID: 8828
		private static Vector3 unitZ;

		// Token: 0x0400227D RID: 8829
		private static Vector3 up;

		// Token: 0x0400227E RID: 8830
		private static Vector3 down;

		// Token: 0x0400227F RID: 8831
		private static Vector3 right;

		// Token: 0x04002280 RID: 8832
		private static Vector3 left;

		// Token: 0x04002281 RID: 8833
		private static Vector3 forward;

		// Token: 0x04002282 RID: 8834
		private static Vector3 backward;

		// Token: 0x04002283 RID: 8835
		public float X;

		// Token: 0x04002284 RID: 8836
		public float Y;

		// Token: 0x04002285 RID: 8837
		public float Z;
	}
}
