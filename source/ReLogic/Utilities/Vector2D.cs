using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using Cpp2IlInjected;

namespace ReLogic.Utilities
{
	// Token: 0x02000B0D RID: 2829
	[DebuggerDisplay("{DebugDisplayString,nq}")]
	[Serializable]
	public struct Vector2D : IEquatable<Vector2D>
	{
		// Token: 0x170008EA RID: 2282
		// (get) Token: 0x060052BA RID: 21178 RVA: 0x00283668 File Offset: 0x00281868
		public static Vector2D Zero
		{
			get
			{
				if (!true)
				{
				}
				return 1;
			}
		}

		// Token: 0x170008EB RID: 2283
		// (get) Token: 0x060052BB RID: 21179 RVA: 0x0028367C File Offset: 0x0028187C
		public static Vector2D One
		{
			get
			{
				if (!true)
				{
				}
				return 1;
			}
		}

		// Token: 0x170008EC RID: 2284
		// (get) Token: 0x060052BC RID: 21180 RVA: 0x00283690 File Offset: 0x00281890
		public static Vector2D UnitX
		{
			get
			{
				if (!true)
				{
				}
				return 1;
			}
		}

		// Token: 0x170008ED RID: 2285
		// (get) Token: 0x060052BD RID: 21181 RVA: 0x002836A4 File Offset: 0x002818A4
		public static Vector2D UnitY
		{
			get
			{
				if (!true)
				{
				}
				return 1;
			}
		}

		// Token: 0x170008EE RID: 2286
		// (get) Token: 0x060052BE RID: 21182 RVA: 0x002836B8 File Offset: 0x002818B8
		internal string DebugDisplayString
		{
			get
			{
				string text;
				string text2;
				return text + " " + text2;
			}
		}

		// Token: 0x060052BF RID: 21183 RVA: 0x002836D4 File Offset: 0x002818D4
		public Vector2D(double x, double y)
		{
			this.X = x;
		}

		// Token: 0x060052C0 RID: 21184 RVA: 0x002836E8 File Offset: 0x002818E8
		public Vector2D(double value)
		{
			this.X = value;
		}

		// Token: 0x060052C1 RID: 21185 RVA: 0x002836FC File Offset: 0x002818FC
		public override bool Equals(object obj)
		{
			/*
An exception occurred when decompiling this method (060052C1)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean ReLogic.Utilities.Vector2D::Equals(System.Object)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0003:
	stloc:float64(var_1_0B, ldfld:float64(Vector2D::Y, ldloc:valuetype ReLogic.Utilities.Vector2D&(this)))
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

		// Token: 0x060052C2 RID: 21186 RVA: 0x00283714 File Offset: 0x00281914
		public bool Equals(Vector2D other)
		{
			/*
An exception occurred when decompiling this method (060052C2)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean ReLogic.Utilities.Vector2D::Equals(ReLogic.Utilities.Vector2D)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:float64(var_0_06, ldfld:float64(Vector2D::Y, ldloc:valuetype ReLogic.Utilities.Vector2D&(this)))
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

		// Token: 0x060052C3 RID: 21187 RVA: 0x0028372C File Offset: 0x0028192C
		public override int GetHashCode()
		{
			/*
An exception occurred when decompiling this method (060052C3)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Int32 ReLogic.Utilities.Vector2D::GetHashCode()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0003:
	stloc:int32(var_0_04, ldc.i4:int32(1))
	stloc:float64(var_1_0B, ldfld:float64(Vector2D::Y, ldloc:valuetype ReLogic.Utilities.Vector2D&(this)))
	brtrue(IL_0000, ldloc:int32[exp:bool](var_0_04))
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

		// Token: 0x060052C4 RID: 21188 RVA: 0x00283748 File Offset: 0x00281948
		public double Length()
		{
			/*
An exception occurred when decompiling this method (060052C4)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Double ReLogic.Utilities.Vector2D::Length()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0000:
	stloc:float64(var_0_06, ldfld:float64(Vector2D::X, ldloc:valuetype ReLogic.Utilities.Vector2D&(this)))
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

		// Token: 0x060052C5 RID: 21189 RVA: 0x00283760 File Offset: 0x00281960
		public double LengthSquared()
		{
			/*
An exception occurred when decompiling this method (060052C5)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Double ReLogic.Utilities.Vector2D::LengthSquared()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:float64(var_0_06, ldfld:float64(Vector2D::X, ldloc:valuetype ReLogic.Utilities.Vector2D&(this)))
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

		// Token: 0x060052C6 RID: 21190 RVA: 0x00283774 File Offset: 0x00281974
		public void Normalize()
		{
			double x = this.X;
			double x2;
			if (!true)
			{
				x2 = this.X;
			}
			this.X = x2;
		}

		// Token: 0x060052C7 RID: 21191 RVA: 0x0028379C File Offset: 0x0028199C
		public override string ToString()
		{
			string text;
			string text2;
			if (("{X:" == null || "{X:" != null) && (text == null || text != null) && (" Y:" == null || " Y:" != null) && (text2 == null || text2 != null) && ("}" == null || "}" != null))
			{
				string text3;
				return text3;
			}
			throw new ArrayTypeMismatchException();
		}

		// Token: 0x060052C8 RID: 21192 RVA: 0x002837E8 File Offset: 0x002819E8
		public static Vector2D Add(Vector2D value1, Vector2D value2)
		{
			Vector2D vector2D;
			return vector2D;
		}

		// Token: 0x060052C9 RID: 21193 RVA: 0x002837F8 File Offset: 0x002819F8
		public static void Add(Vector2D value1, Vector2D value2, [Out] Vector2D result)
		{
		}

		// Token: 0x060052CA RID: 21194 RVA: 0x00283808 File Offset: 0x00281A08
		public static Vector2D Barycentric(Vector2D value1, Vector2D value2, Vector2D value3, double amount1, double amount2)
		{
			if (!true)
			{
			}
			return 1;
		}

		// Token: 0x060052CB RID: 21195 RVA: 0x0028381C File Offset: 0x00281A1C
		public static void Barycentric(Vector2D value1, Vector2D value2, Vector2D value3, double amount1, double amount2, [Out] Vector2D result)
		{
			if (!true)
			{
			}
			result.X = amount1;
		}

		// Token: 0x060052CC RID: 21196 RVA: 0x00283834 File Offset: 0x00281A34
		public static Vector2D CatmullRom(Vector2D value1, Vector2D value2, Vector2D value3, Vector2D value4, double amount)
		{
			if (!true)
			{
			}
			return 1;
		}

		// Token: 0x060052CD RID: 21197 RVA: 0x00283848 File Offset: 0x00281A48
		public static void CatmullRom(Vector2D value1, Vector2D value2, Vector2D value3, Vector2D value4, double amount, [Out] Vector2D result)
		{
			if (!true)
			{
			}
			result.X = amount;
		}

		// Token: 0x060052CE RID: 21198 RVA: 0x00283864 File Offset: 0x00281A64
		public static Vector2D Clamp(Vector2D value1, Vector2D min, Vector2D max)
		{
			if (!true)
			{
			}
			return 1;
		}

		// Token: 0x060052CF RID: 21199 RVA: 0x00283878 File Offset: 0x00281A78
		public static void Clamp(Vector2D value1, Vector2D min, Vector2D max, [Out] Vector2D result)
		{
			if (!true)
			{
			}
			double y = value1.Y;
			double y2 = max.Y;
			double y3 = min.Y;
			result.Y = y;
		}

		// Token: 0x060052D0 RID: 21200 RVA: 0x002838A4 File Offset: 0x00281AA4
		public static double Distance(Vector2D value1, Vector2D value2)
		{
			/*
An exception occurred when decompiling this method (060052D0)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Double ReLogic.Utilities.Vector2D::Distance(ReLogic.Utilities.Vector2D,ReLogic.Utilities.Vector2D)

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

		// Token: 0x060052D1 RID: 21201 RVA: 0x002838B4 File Offset: 0x00281AB4
		public static void Distance(Vector2D value1, Vector2D value2, [Out] double result)
		{
			double x = value1.X;
			double x2 = value2.X;
			if (!true)
			{
			}
		}

		// Token: 0x060052D2 RID: 21202 RVA: 0x000021DB File Offset: 0x000003DB
		public static double DistanceSquared(Vector2D value1, Vector2D value2)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x060052D3 RID: 21203 RVA: 0x002838D4 File Offset: 0x00281AD4
		public static void DistanceSquared(Vector2D value1, Vector2D value2, [Out] double result)
		{
			double x = value1.X;
			double x2 = value2.X;
		}

		// Token: 0x060052D4 RID: 21204 RVA: 0x002838F0 File Offset: 0x00281AF0
		public static Vector2D Divide(Vector2D value1, Vector2D value2)
		{
			Vector2D vector2D;
			return vector2D;
		}

		// Token: 0x060052D5 RID: 21205 RVA: 0x00283900 File Offset: 0x00281B00
		public static void Divide(Vector2D value1, Vector2D value2, [Out] Vector2D result)
		{
		}

		// Token: 0x060052D6 RID: 21206 RVA: 0x00283910 File Offset: 0x00281B10
		public static Vector2D Divide(Vector2D value1, double divider)
		{
			Vector2D vector2D;
			return vector2D;
		}

		// Token: 0x060052D7 RID: 21207 RVA: 0x00283920 File Offset: 0x00281B20
		public static void Divide(Vector2D value1, double divider, [Out] Vector2D result)
		{
			result.X = divider;
		}

		// Token: 0x060052D8 RID: 21208 RVA: 0x000021DB File Offset: 0x000003DB
		public static double Dot(Vector2D value1, Vector2D value2)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x060052D9 RID: 21209 RVA: 0x00283934 File Offset: 0x00281B34
		public static void Dot(Vector2D value1, Vector2D value2, [Out] double result)
		{
			double x = value1.X;
			double x2 = value2.X;
		}

		// Token: 0x060052DA RID: 21210 RVA: 0x00283950 File Offset: 0x00281B50
		public static Vector2D Hermite(Vector2D value1, Vector2D tangent1, Vector2D value2, Vector2D tangent2, double amount)
		{
			if (!true)
			{
			}
			return 1;
		}

		// Token: 0x060052DB RID: 21211 RVA: 0x00283964 File Offset: 0x00281B64
		public static void Hermite(Vector2D value1, Vector2D tangent1, Vector2D value2, Vector2D tangent2, double amount, [Out] Vector2D result)
		{
			if (!true)
			{
			}
			double num;
			result.X = num;
			double y = value1.Y;
			double y2 = tangent1.Y;
			double y3 = value2.Y;
			double y4 = tangent2.Y;
			double num2 = Vector2D.Hermite(y, y2, y3, y4, amount);
			result.Y = num2;
		}

		// Token: 0x060052DC RID: 21212 RVA: 0x002839B0 File Offset: 0x00281BB0
		public static Vector2D Lerp(Vector2D value1, Vector2D value2, double amount)
		{
			if (!true)
			{
			}
			return 1;
		}

		// Token: 0x060052DD RID: 21213 RVA: 0x002839C4 File Offset: 0x00281BC4
		public static void Lerp(Vector2D value1, Vector2D value2, double amount, [Out] Vector2D result)
		{
			if (!true)
			{
			}
			result.X = amount;
			double y = value1.Y;
			double y2 = value2.Y;
			result.Y = y;
		}

		// Token: 0x060052DE RID: 21214 RVA: 0x002839F0 File Offset: 0x00281BF0
		public static Vector2D Max(Vector2D value1, Vector2D value2)
		{
			Vector2D vector2D;
			return vector2D;
		}

		// Token: 0x060052DF RID: 21215 RVA: 0x00283A00 File Offset: 0x00281C00
		public static void Max(Vector2D value1, Vector2D value2, [Out] Vector2D result)
		{
			double y = value1.Y;
			double y2 = value2.Y;
			result.Y = y;
		}

		// Token: 0x060052E0 RID: 21216 RVA: 0x00283A24 File Offset: 0x00281C24
		public static Vector2D Min(Vector2D value1, Vector2D value2)
		{
			Vector2D vector2D;
			return vector2D;
		}

		// Token: 0x060052E1 RID: 21217 RVA: 0x00283A34 File Offset: 0x00281C34
		public static void Min(Vector2D value1, Vector2D value2, [Out] Vector2D result)
		{
			double y = value1.Y;
			double y2 = value2.Y;
			result.Y = y;
		}

		// Token: 0x060052E2 RID: 21218 RVA: 0x00283A58 File Offset: 0x00281C58
		public static Vector2D Multiply(Vector2D value1, Vector2D value2)
		{
			Vector2D vector2D;
			return vector2D;
		}

		// Token: 0x060052E3 RID: 21219 RVA: 0x00283A68 File Offset: 0x00281C68
		public static Vector2D Multiply(Vector2D value1, double scaleFactor)
		{
			Vector2D vector2D;
			return vector2D;
		}

		// Token: 0x060052E4 RID: 21220 RVA: 0x00283A78 File Offset: 0x00281C78
		public static void Multiply(Vector2D value1, double scaleFactor, [Out] Vector2D result)
		{
			result.X = scaleFactor;
		}

		// Token: 0x060052E5 RID: 21221 RVA: 0x00283A8C File Offset: 0x00281C8C
		public static void Multiply(Vector2D value1, Vector2D value2, [Out] Vector2D result)
		{
		}

		// Token: 0x060052E6 RID: 21222 RVA: 0x00283A9C File Offset: 0x00281C9C
		public static Vector2D Negate(Vector2D value)
		{
			Vector2D vector2D;
			return vector2D;
		}

		// Token: 0x060052E7 RID: 21223 RVA: 0x00283AAC File Offset: 0x00281CAC
		public static void Negate(Vector2D value, [Out] Vector2D result)
		{
		}

		// Token: 0x060052E8 RID: 21224 RVA: 0x00283ABC File Offset: 0x00281CBC
		public static Vector2D Normalize(Vector2D value)
		{
			if (!true)
			{
			}
			return 1;
		}

		// Token: 0x060052E9 RID: 21225 RVA: 0x00283AD0 File Offset: 0x00281CD0
		public static void Normalize(Vector2D value, [Out] Vector2D result)
		{
			double x = value.X;
			double x2;
			if (!true)
			{
				x2 = value.X;
			}
			result.X = x2;
		}

		// Token: 0x060052EA RID: 21226 RVA: 0x00283AF8 File Offset: 0x00281CF8
		public static Vector2D Reflect(Vector2D vector, Vector2D normal)
		{
			Vector2D vector2D;
			return vector2D;
		}

		// Token: 0x060052EB RID: 21227 RVA: 0x00283B08 File Offset: 0x00281D08
		public static void Reflect(Vector2D vector, Vector2D normal, [Out] Vector2D result)
		{
			double x = vector.X;
			double x2 = normal.X;
			result.X = x;
		}

		// Token: 0x060052EC RID: 21228 RVA: 0x00283B2C File Offset: 0x00281D2C
		public static Vector2D SmoothStep(Vector2D value1, Vector2D value2, double amount)
		{
			if (!true)
			{
			}
			return 1;
		}

		// Token: 0x060052ED RID: 21229 RVA: 0x00283B40 File Offset: 0x00281D40
		public static void SmoothStep(Vector2D value1, Vector2D value2, double amount, [Out] Vector2D result)
		{
			if (!true)
			{
			}
			double num;
			result.X = num;
			double y = value1.Y;
			double y2 = value2.Y;
			double num2 = Vector2D.SmoothStep(y, y2, amount);
			result.Y = num2;
		}

		// Token: 0x060052EE RID: 21230 RVA: 0x00283B78 File Offset: 0x00281D78
		public static Vector2D Subtract(Vector2D value1, Vector2D value2)
		{
			Vector2D vector2D;
			return vector2D;
		}

		// Token: 0x060052EF RID: 21231 RVA: 0x00283B88 File Offset: 0x00281D88
		public static void Subtract(Vector2D value1, Vector2D value2, [Out] Vector2D result)
		{
		}

		// Token: 0x060052F0 RID: 21232 RVA: 0x00283B98 File Offset: 0x00281D98
		public static Vector2D operator -(Vector2D value)
		{
			Vector2D vector2D;
			return vector2D;
		}

		// Token: 0x060052F1 RID: 21233 RVA: 0x000021DB File Offset: 0x000003DB
		public static bool operator ==(Vector2D value1, Vector2D value2)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x060052F2 RID: 21234 RVA: 0x00283BA8 File Offset: 0x00281DA8
		public static bool operator !=(Vector2D value1, Vector2D value2)
		{
			/*
An exception occurred when decompiling this method (060052F2)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean ReLogic.Utilities.Vector2D::op_Inequality(ReLogic.Utilities.Vector2D,ReLogic.Utilities.Vector2D)

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

		// Token: 0x060052F3 RID: 21235 RVA: 0x00283BB8 File Offset: 0x00281DB8
		public static Vector2D operator +(Vector2D value1, Vector2D value2)
		{
			Vector2D vector2D;
			return vector2D;
		}

		// Token: 0x060052F4 RID: 21236 RVA: 0x00283BC8 File Offset: 0x00281DC8
		public static Vector2D operator -(Vector2D value1, Vector2D value2)
		{
			Vector2D vector2D;
			return vector2D;
		}

		// Token: 0x060052F5 RID: 21237 RVA: 0x00283BD8 File Offset: 0x00281DD8
		public static Vector2D operator *(Vector2D value1, Vector2D value2)
		{
			Vector2D vector2D;
			return vector2D;
		}

		// Token: 0x060052F6 RID: 21238 RVA: 0x00283BE8 File Offset: 0x00281DE8
		public static Vector2D operator *(Vector2D value, double scaleFactor)
		{
			Vector2D vector2D;
			return vector2D;
		}

		// Token: 0x060052F7 RID: 21239 RVA: 0x00283BF8 File Offset: 0x00281DF8
		public static Vector2D operator *(double scaleFactor, Vector2D value)
		{
			Vector2D vector2D;
			return vector2D;
		}

		// Token: 0x060052F8 RID: 21240 RVA: 0x00283C08 File Offset: 0x00281E08
		public static Vector2D operator /(Vector2D value1, Vector2D value2)
		{
			Vector2D vector2D;
			return vector2D;
		}

		// Token: 0x060052F9 RID: 21241 RVA: 0x00283C18 File Offset: 0x00281E18
		public static Vector2D operator /(Vector2D value1, double divider)
		{
			Vector2D vector2D;
			return vector2D;
		}

		// Token: 0x060052FA RID: 21242 RVA: 0x000021DB File Offset: 0x000003DB
		public static double Clamp(double value, double min, double max)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x060052FB RID: 21243 RVA: 0x000021DB File Offset: 0x000003DB
		public static double Lerp(double value1, double value2, double amount)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x060052FC RID: 21244 RVA: 0x00283C28 File Offset: 0x00281E28
		public static double SmoothStep(double value1, double value2, double amount)
		{
			/*
An exception occurred when decompiling this method (060052FC)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Double ReLogic.Utilities.Vector2D::SmoothStep(System.Double,System.Double,System.Double)

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

		// Token: 0x060052FD RID: 21245 RVA: 0x00283C38 File Offset: 0x00281E38
		public static double Hermite(double value1, double tangent1, double value2, double tangent2, double amount)
		{
			/*
An exception occurred when decompiling this method (060052FD)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Double ReLogic.Utilities.Vector2D::Hermite(System.Double,System.Double,System.Double,System.Double,System.Double)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0003:
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

		// Token: 0x060052FE RID: 21246 RVA: 0x000021DB File Offset: 0x000003DB
		public static double Barycentric(double value1, double value2, double value3, double amount1, double amount2)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x060052FF RID: 21247 RVA: 0x000021DB File Offset: 0x000003DB
		public static double CatmullRom(double value1, double value2, double value3, double value4, double amount)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06005300 RID: 21248 RVA: 0x00283C4C File Offset: 0x00281E4C
		// Note: this type is marked as 'beforefieldinit'.
		static Vector2D()
		{
			double num = Math.Pow(0.0, 53.0);
		}

		// Token: 0x04008AE0 RID: 35552
		public double X;

		// Token: 0x04008AE1 RID: 35553
		public double Y;

		// Token: 0x04008AE2 RID: 35554
		private static Vector2D zeroVector;

		// Token: 0x04008AE3 RID: 35555
		private static Vector2D unitVector;

		// Token: 0x04008AE4 RID: 35556
		private static Vector2D unitXVector;

		// Token: 0x04008AE5 RID: 35557
		private static Vector2D unitYVector;

		// Token: 0x04008AE6 RID: 35558
		public static readonly double DoubleEpsilon;
	}
}
