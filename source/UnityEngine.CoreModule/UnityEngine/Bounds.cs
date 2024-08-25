using System;
using System.Globalization;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine
{
	// Token: 0x02000086 RID: 134
	[NativeHeader("Runtime/Geometry/AABB.h")]
	[NativeClass("AABB")]
	[NativeType(Header = "Runtime/Geometry/AABB.h")]
	[NativeHeader("Runtime/Geometry/Ray.h")]
	[NativeHeader("Runtime/Geometry/Intersection.h")]
	[RequiredByNativeCode(Optional = true, GenerateProxy = true)]
	[NativeHeader("Runtime/Math/MathScripting.h")]
	public struct Bounds : IEquatable<Bounds>, IFormattable
	{
		// Token: 0x06000240 RID: 576 RVA: 0x000053CC File Offset: 0x000035CC
		public Bounds(Vector3 center, Vector3 size)
		{
		}

		// Token: 0x06000241 RID: 577 RVA: 0x000053DC File Offset: 0x000035DC
		public override int GetHashCode()
		{
			float z = this.m_Extents.z;
			int num;
			return num;
		}

		// Token: 0x06000242 RID: 578 RVA: 0x000053F8 File Offset: 0x000035F8
		public override bool Equals(object other)
		{
			/*
An exception occurred when decompiling this method (06000242)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean UnityEngine.Bounds::Equals(System.Object)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0003:
	stloc:float32(var_2_12, ldfld:float32(Vector3::x, ldfld:Vector3[exp:valuetype UnityEngine.Vector3&](Bounds::m_Extents, ldloc:valuetype UnityEngine.Bounds&(this))))
	stloc:float32(var_3_1E, ldfld:float32(Vector3::y, ldfld:Vector3[exp:valuetype UnityEngine.Vector3&](Bounds::m_Extents, ldloc:valuetype UnityEngine.Bounds&(this))))
	stloc:float32(var_4_2A, ldfld:float32(Vector3::z, ldfld:Vector3[exp:valuetype UnityEngine.Vector3&](Bounds::m_Extents, ldloc:valuetype UnityEngine.Bounds&(this))))
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

		// Token: 0x06000243 RID: 579 RVA: 0x00005430 File Offset: 0x00003630
		public bool Equals(Bounds other)
		{
			/*
An exception occurred when decompiling this method (06000243)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean UnityEngine.Bounds::Equals(UnityEngine.Bounds)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:float32(var_0_0B, ldfld:float32(Vector3::x, ldfld:Vector3[exp:valuetype UnityEngine.Vector3&](Bounds::m_Extents, ldloc:valuetype UnityEngine.Bounds&(this))))
	stloc:float32(var_1_17, ldfld:float32(Vector3::y, ldfld:Vector3[exp:valuetype UnityEngine.Vector3&](Bounds::m_Extents, ldloc:valuetype UnityEngine.Bounds&(this))))
	stloc:float32(var_2_23, ldfld:float32(Vector3::x, ldfld:Vector3[exp:valuetype UnityEngine.Vector3&](Bounds::m_Extents, ldloc:Bounds[exp:valuetype UnityEngine.Bounds&](other))))
	stloc:float32(var_3_2F, ldfld:float32(Vector3::y, ldfld:Vector3[exp:valuetype UnityEngine.Vector3&](Bounds::m_Extents, ldloc:Bounds[exp:valuetype UnityEngine.Bounds&](other))))
	stloc:float32(var_4_3B, ldfld:float32(Vector3::z, ldfld:Vector3[exp:valuetype UnityEngine.Vector3&](Bounds::m_Extents, ldloc:valuetype UnityEngine.Bounds&(this))))
	stloc:float32(var_5_48, ldfld:float32(Vector3::z, ldfld:Vector3[exp:valuetype UnityEngine.Vector3&](Bounds::m_Extents, ldloc:Bounds[exp:valuetype UnityEngine.Bounds&](other))))
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

		// Token: 0x1700007B RID: 123
		// (get) Token: 0x06000244 RID: 580 RVA: 0x0000548C File Offset: 0x0000368C
		// (set) Token: 0x06000245 RID: 581 RVA: 0x000054A4 File Offset: 0x000036A4
		public Vector3 center
		{
			get
			{
				Vector3 center = this.m_Center;
				Vector3 vector;
				return vector;
			}
			set
			{
			}
		}

		// Token: 0x1700007C RID: 124
		// (get) Token: 0x06000246 RID: 582 RVA: 0x000054B4 File Offset: 0x000036B4
		// (set) Token: 0x06000247 RID: 583 RVA: 0x000054E8 File Offset: 0x000036E8
		public Vector3 size
		{
			get
			{
				float x = this.m_Extents.x;
				float y = this.m_Extents.y;
				float z = this.m_Extents.z;
				Vector3 vector;
				return vector;
			}
			set
			{
			}
		}

		// Token: 0x1700007D RID: 125
		// (get) Token: 0x06000248 RID: 584 RVA: 0x000054F8 File Offset: 0x000036F8
		// (set) Token: 0x06000249 RID: 585 RVA: 0x0000552C File Offset: 0x0000372C
		public Vector3 extents
		{
			get
			{
				float x = this.m_Extents.x;
				float y = this.m_Extents.y;
				float z = this.m_Extents.z;
				Vector3 vector;
				return vector;
			}
			set
			{
			}
		}

		// Token: 0x1700007E RID: 126
		// (get) Token: 0x0600024A RID: 586 RVA: 0x0000553C File Offset: 0x0000373C
		public Vector3 min
		{
			get
			{
				float z = this.m_Extents.z;
				Vector3 vector;
				return vector;
			}
		}

		// Token: 0x1700007F RID: 127
		// (get) Token: 0x0600024B RID: 587 RVA: 0x00005558 File Offset: 0x00003758
		public Vector3 max
		{
			get
			{
				float z = this.m_Extents.z;
				Vector3 vector;
				return vector;
			}
		}

		// Token: 0x0600024C RID: 588 RVA: 0x00005574 File Offset: 0x00003774
		public static bool operator ==(Bounds lhs, Bounds rhs)
		{
			/*
An exception occurred when decompiling this method (0600024C)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean UnityEngine.Bounds::op_Equality(UnityEngine.Bounds,UnityEngine.Bounds)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:float32(var_0_0B, ldfld:float32(Vector3::x, ldfld:Vector3[exp:valuetype UnityEngine.Vector3&](Bounds::m_Extents, ldloc:Bounds[exp:valuetype UnityEngine.Bounds&](lhs))))
	stloc:float32(var_1_17, ldfld:float32(Vector3::y, ldfld:Vector3[exp:valuetype UnityEngine.Vector3&](Bounds::m_Extents, ldloc:Bounds[exp:valuetype UnityEngine.Bounds&](lhs))))
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

		// Token: 0x0600024D RID: 589 RVA: 0x0000559C File Offset: 0x0000379C
		public static bool operator !=(Bounds lhs, Bounds rhs)
		{
			float y = lhs.m_Extents.y;
			bool flag;
			return flag;
		}

		// Token: 0x0600024E RID: 590 RVA: 0x000055B8 File Offset: 0x000037B8
		public void SetMinMax(Vector3 min, Vector3 max)
		{
		}

		// Token: 0x0600024F RID: 591 RVA: 0x000055C8 File Offset: 0x000037C8
		public void Encapsulate(Vector3 point)
		{
			float z = this.m_Extents.z;
		}

		// Token: 0x06000250 RID: 592 RVA: 0x000055E4 File Offset: 0x000037E4
		public override string ToString()
		{
			string text;
			return text;
		}

		// Token: 0x06000251 RID: 593 RVA: 0x000055F4 File Offset: 0x000037F4
		public string ToString(string format, IFormatProvider formatProvider)
		{
			bool flag = string.IsNullOrEmpty(format);
			if (formatProvider == null)
			{
				CultureInfo invariantCulture = CultureInfo.InvariantCulture;
			}
			string text;
			string text2;
			if ((text == null || text != null) && (text2 == null || text2 != null))
			{
				string text3;
				return text3;
			}
			throw new ArrayTypeMismatchException();
		}

		// Token: 0x04000319 RID: 793
		private Vector3 m_Center;

		// Token: 0x0400031A RID: 794
		[NativeName("m_Extent")]
		private Vector3 m_Extents;
	}
}
