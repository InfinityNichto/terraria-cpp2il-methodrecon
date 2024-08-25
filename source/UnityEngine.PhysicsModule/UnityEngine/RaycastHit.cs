using System;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine
{
	// Token: 0x02000003 RID: 3
	[NativeHeader("PhysicsScriptingClasses.h")]
	[UsedByNativeCode]
	[NativeHeader("Modules/Physics/RaycastHit.h")]
	[NativeHeader("Runtime/Interfaces/IRaycast.h")]
	public struct RaycastHit
	{
		// Token: 0x17000001 RID: 1
		// (get) Token: 0x06000001 RID: 1 RVA: 0x00002050 File Offset: 0x00000250
		public Collider collider
		{
			get
			{
				for (;;)
				{
					int num = 1;
					int collider = this.m_Collider;
					if (num == 0)
					{
					}
					if (Object.FindObjectFromInstanceID(collider) != null)
					{
						return;
					}
				}
			}
		}

		// Token: 0x17000002 RID: 2
		// (get) Token: 0x06000002 RID: 2 RVA: 0x00002074 File Offset: 0x00000274
		public Vector3 point
		{
			get
			{
				Vector3 point = this.m_Point;
				Vector3 vector;
				return vector;
			}
		}

		// Token: 0x17000003 RID: 3
		// (get) Token: 0x06000003 RID: 3 RVA: 0x0000208C File Offset: 0x0000028C
		public Vector3 normal
		{
			get
			{
				float x = this.m_Normal.x;
				float y = this.m_Normal.y;
				float z = this.m_Normal.z;
				Vector3 vector;
				return vector;
			}
		}

		// Token: 0x17000004 RID: 4
		// (get) Token: 0x06000004 RID: 4 RVA: 0x000020C0 File Offset: 0x000002C0
		public float distance
		{
			get
			{
				/*
An exception occurred when decompiling this method (06000004)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Single UnityEngine.RaycastHit::get_distance()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:float32(var_0_06, ldfld:float32(RaycastHit::m_Distance, ldloc:valuetype UnityEngine.RaycastHit&(this)))
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

		// Token: 0x04000001 RID: 1
		[NativeName("point")]
		internal Vector3 m_Point;

		// Token: 0x04000002 RID: 2
		[NativeName("normal")]
		internal Vector3 m_Normal;

		// Token: 0x04000003 RID: 3
		[NativeName("faceID")]
		internal uint m_FaceID;

		// Token: 0x04000004 RID: 4
		[NativeName("distance")]
		internal float m_Distance;

		// Token: 0x04000005 RID: 5
		[NativeName("uv")]
		internal Vector2 m_UV;

		// Token: 0x04000006 RID: 6
		[NativeName("collider")]
		internal int m_Collider;
	}
}
