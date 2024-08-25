using System;
using System.Globalization;
using System.Runtime.InteropServices;
using UnityEngine.Scripting;

namespace UnityEngine
{
	// Token: 0x02000085 RID: 133
	[UsedByNativeCode]
	public struct Plane : IFormattable
	{
		// Token: 0x1700007A RID: 122
		// (get) Token: 0x0600023B RID: 571 RVA: 0x0000530C File Offset: 0x0000350C
		public Vector3 normal
		{
			get
			{
				Vector3 normal = this.m_Normal;
				Vector3 vector;
				return vector;
			}
		}

		// Token: 0x0600023C RID: 572 RVA: 0x00005324 File Offset: 0x00003524
		public Plane(Vector3 inNormal, Vector3 inPoint)
		{
		}

		// Token: 0x0600023D RID: 573 RVA: 0x00005334 File Offset: 0x00003534
		public bool Raycast(Ray ray, [Out] float enter)
		{
			/*
An exception occurred when decompiling this method (0600023D)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean UnityEngine.Plane::Raycast(UnityEngine.Ray,System.Single)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:float32(var_0_0B, ldfld:float32(Vector3::x, ldfld:Vector3[exp:valuetype UnityEngine.Vector3&](Ray::m_Direction, ldloc:Ray[exp:valuetype UnityEngine.Ray&](ray))))
	stloc:float32(var_1_17, ldfld:float32(Vector3::y, ldfld:Vector3[exp:valuetype UnityEngine.Vector3&](Ray::m_Direction, ldloc:Ray[exp:valuetype UnityEngine.Ray&](ray))))
	stloc:float32(var_2_23, ldfld:float32(Vector3::z, ldfld:Vector3[exp:valuetype UnityEngine.Vector3&](Ray::m_Direction, ldloc:Ray[exp:valuetype UnityEngine.Ray&](ray))))
	stloc:Vector3(var_3_2A, ldfld:Vector3(Plane::m_Normal, ldloc:valuetype UnityEngine.Plane&(this)))
	stloc:float32(var_4_31, ldfld:float32(Plane::m_Distance, ldloc:valuetype UnityEngine.Plane&(this)))
	stloc:Vector3(var_5_39, ldfld:Vector3(Ray::m_Origin, ldloc:Ray[exp:valuetype UnityEngine.Ray&](ray)))
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

		// Token: 0x0600023E RID: 574 RVA: 0x00005380 File Offset: 0x00003580
		public override string ToString()
		{
			string text;
			return text;
		}

		// Token: 0x0600023F RID: 575 RVA: 0x00005390 File Offset: 0x00003590
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

		// Token: 0x04000317 RID: 791
		private Vector3 m_Normal;

		// Token: 0x04000318 RID: 792
		private float m_Distance;
	}
}
