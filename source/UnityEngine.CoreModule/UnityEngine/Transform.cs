using System;
using System.Collections;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using UnityEngine.Bindings;
using UnityEngine.Internal;
using UnityEngine.Scripting;

namespace UnityEngine
{
	// Token: 0x020000E0 RID: 224
	[RequiredByNativeCode]
	[NativeHeader("Configuration/UnityConfigure.h")]
	[NativeHeader("Runtime/Transform/ScriptBindings/TransformScriptBindings.h")]
	[NativeHeader("Runtime/Transform/Transform.h")]
	public class Transform : Component, IEnumerable
	{
		// Token: 0x06000496 RID: 1174 RVA: 0x000086EC File Offset: 0x000068EC
		protected Transform()
		{
		}

		// Token: 0x170000EC RID: 236
		// (get) Token: 0x06000497 RID: 1175 RVA: 0x00008700 File Offset: 0x00006900
		// (set) Token: 0x06000498 RID: 1176 RVA: 0x00008714 File Offset: 0x00006914
		public Vector3 position
		{
			get
			{
				throw new MissingMethodException();
			}
			set
			{
				throw new MissingMethodException();
			}
		}

		// Token: 0x170000ED RID: 237
		// (get) Token: 0x06000499 RID: 1177 RVA: 0x00008728 File Offset: 0x00006928
		// (set) Token: 0x0600049A RID: 1178 RVA: 0x0000873C File Offset: 0x0000693C
		public Vector3 localPosition
		{
			get
			{
				throw new MissingMethodException();
			}
			set
			{
				throw new MissingMethodException();
			}
		}

		// Token: 0x170000EE RID: 238
		// (get) Token: 0x0600049B RID: 1179 RVA: 0x00008750 File Offset: 0x00006950
		public Vector3 forward
		{
			get
			{
				/*
An exception occurred when decompiling this method (0600049B)

ICSharpCode.Decompiler.DecompilerException: Error decompiling UnityEngine.Vector3 UnityEngine.Transform::get_forward()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:Quaternion(var_0_06, callgetter:Quaternion(Transform::get_rotation, ldloc:Transform(this)))
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

		// Token: 0x170000EF RID: 239
		// (get) Token: 0x0600049C RID: 1180 RVA: 0x00008764 File Offset: 0x00006964
		public Quaternion rotation
		{
			get
			{
				throw new MissingMethodException();
			}
		}

		// Token: 0x170000F0 RID: 240
		// (get) Token: 0x0600049D RID: 1181 RVA: 0x00008778 File Offset: 0x00006978
		// (set) Token: 0x0600049E RID: 1182 RVA: 0x0000878C File Offset: 0x0000698C
		public Quaternion localRotation
		{
			get
			{
				throw new MissingMethodException();
			}
			set
			{
				throw new MissingMethodException();
			}
		}

		// Token: 0x170000F1 RID: 241
		// (get) Token: 0x0600049F RID: 1183 RVA: 0x000087A0 File Offset: 0x000069A0
		// (set) Token: 0x060004A0 RID: 1184 RVA: 0x000087B4 File Offset: 0x000069B4
		public Vector3 localScale
		{
			get
			{
				throw new MissingMethodException();
			}
			set
			{
				throw new MissingMethodException();
			}
		}

		// Token: 0x170000F2 RID: 242
		// (get) Token: 0x060004A1 RID: 1185 RVA: 0x000087C8 File Offset: 0x000069C8
		// (set) Token: 0x060004A2 RID: 1186 RVA: 0x000087DC File Offset: 0x000069DC
		public Transform parent
		{
			get
			{
				throw new MissingMethodException();
			}
			set
			{
				if (this != null)
				{
					Debug.LogWarning("Parent of RectTransform is being set with parent property. Consider using the SetParent method instead, with the worldPositionStays argument set to false. This will retain local orientation and scale rather than world orientation and scale, which can prevent common UI scaling issues.", this);
				}
				throw new MissingMethodException();
			}
		}

		// Token: 0x170000F3 RID: 243
		// (get) Token: 0x060004A3 RID: 1187 RVA: 0x00008800 File Offset: 0x00006A00
		// (set) Token: 0x060004A4 RID: 1188 RVA: 0x00008814 File Offset: 0x00006A14
		internal Transform parentInternal
		{
			get
			{
				throw new MissingMethodException();
			}
			set
			{
				throw new MissingMethodException();
			}
		}

		// Token: 0x060004A5 RID: 1189 RVA: 0x00008828 File Offset: 0x00006A28
		private Transform GetParent()
		{
			throw new MissingMethodException();
		}

		// Token: 0x060004A6 RID: 1190 RVA: 0x0000883C File Offset: 0x00006A3C
		public void SetParent(Transform p)
		{
			throw new MissingMethodException();
		}

		// Token: 0x060004A7 RID: 1191 RVA: 0x00008850 File Offset: 0x00006A50
		[FreeFunction("SetParent", HasExplicitThis = true)]
		public void SetParent(Transform parent, bool worldPositionStays)
		{
			throw new MissingMethodException();
		}

		// Token: 0x170000F4 RID: 244
		// (get) Token: 0x060004A8 RID: 1192 RVA: 0x00008864 File Offset: 0x00006A64
		public Matrix4x4 worldToLocalMatrix
		{
			get
			{
				throw new MissingMethodException();
			}
		}

		// Token: 0x170000F5 RID: 245
		// (get) Token: 0x060004A9 RID: 1193 RVA: 0x00008878 File Offset: 0x00006A78
		public Matrix4x4 localToWorldMatrix
		{
			get
			{
				throw new MissingMethodException();
			}
		}

		// Token: 0x060004AA RID: 1194 RVA: 0x0000888C File Offset: 0x00006A8C
		[NativeMethod("RotateAround")]
		internal void RotateAroundInternal(Vector3 axis, float angle)
		{
			throw new MissingMethodException();
		}

		// Token: 0x060004AB RID: 1195 RVA: 0x000088A0 File Offset: 0x00006AA0
		public void Rotate(Vector3 axis, float angle, [DefaultValue("Space.Self")] Space relativeTo)
		{
			Transform transform = base.transform;
		}

		// Token: 0x060004AC RID: 1196 RVA: 0x000088B8 File Offset: 0x00006AB8
		public Vector3 TransformDirection(Vector3 direction)
		{
			throw new MissingMethodException();
		}

		// Token: 0x060004AD RID: 1197 RVA: 0x000088CC File Offset: 0x00006ACC
		public Vector3 TransformPoint(Vector3 position)
		{
			throw new MissingMethodException();
		}

		// Token: 0x060004AE RID: 1198 RVA: 0x000088E0 File Offset: 0x00006AE0
		public Vector3 InverseTransformPoint(Vector3 position)
		{
			throw new MissingMethodException();
		}

		// Token: 0x170000F6 RID: 246
		// (get) Token: 0x060004AF RID: 1199 RVA: 0x000088F4 File Offset: 0x00006AF4
		public int childCount
		{
			[NativeMethod("GetChildrenCount")]
			get
			{
				throw new MissingMethodException();
			}
		}

		// Token: 0x060004B0 RID: 1200 RVA: 0x00008908 File Offset: 0x00006B08
		public void SetAsFirstSibling()
		{
			throw new MissingMethodException();
		}

		// Token: 0x060004B1 RID: 1201 RVA: 0x0000891C File Offset: 0x00006B1C
		public int GetSiblingIndex()
		{
			throw new MissingMethodException();
		}

		// Token: 0x060004B2 RID: 1202 RVA: 0x00008930 File Offset: 0x00006B30
		[FreeFunction("Internal_IsChildOrSameTransform", HasExplicitThis = true)]
		public bool IsChildOf([NotNull("ArgumentNullException")] Transform parent)
		{
			throw new MissingMethodException();
		}

		// Token: 0x060004B3 RID: 1203 RVA: 0x000021B3 File Offset: 0x000003B3
		public IEnumerator GetEnumerator()
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x060004B4 RID: 1204 RVA: 0x00008944 File Offset: 0x00006B44
		[NativeThrows]
		[FreeFunction("GetChild", HasExplicitThis = true)]
		public Transform GetChild(int index)
		{
			throw new MissingMethodException();
		}

		// Token: 0x060004B5 RID: 1205 RVA: 0x00008958 File Offset: 0x00006B58
		private void get_position_Injected([Out] Vector3 ret)
		{
			throw new MissingMethodException();
		}

		// Token: 0x060004B6 RID: 1206 RVA: 0x0000896C File Offset: 0x00006B6C
		private void set_position_Injected(Vector3 value)
		{
			throw new MissingMethodException();
		}

		// Token: 0x060004B7 RID: 1207 RVA: 0x00008980 File Offset: 0x00006B80
		private void get_localPosition_Injected([Out] Vector3 ret)
		{
			throw new MissingMethodException();
		}

		// Token: 0x060004B8 RID: 1208 RVA: 0x00008994 File Offset: 0x00006B94
		private void set_localPosition_Injected(Vector3 value)
		{
			throw new MissingMethodException();
		}

		// Token: 0x060004B9 RID: 1209 RVA: 0x000089A8 File Offset: 0x00006BA8
		private void get_rotation_Injected([Out] Quaternion ret)
		{
			throw new MissingMethodException();
		}

		// Token: 0x060004BA RID: 1210 RVA: 0x000089BC File Offset: 0x00006BBC
		private void get_localRotation_Injected([Out] Quaternion ret)
		{
			throw new MissingMethodException();
		}

		// Token: 0x060004BB RID: 1211 RVA: 0x000089D0 File Offset: 0x00006BD0
		private void set_localRotation_Injected(Quaternion value)
		{
			throw new MissingMethodException();
		}

		// Token: 0x060004BC RID: 1212 RVA: 0x000089E4 File Offset: 0x00006BE4
		private void get_localScale_Injected([Out] Vector3 ret)
		{
			throw new MissingMethodException();
		}

		// Token: 0x060004BD RID: 1213 RVA: 0x000089F8 File Offset: 0x00006BF8
		private void set_localScale_Injected(Vector3 value)
		{
			throw new MissingMethodException();
		}

		// Token: 0x060004BE RID: 1214 RVA: 0x00008A0C File Offset: 0x00006C0C
		private void get_worldToLocalMatrix_Injected([Out] Matrix4x4 ret)
		{
			throw new MissingMethodException();
		}

		// Token: 0x060004BF RID: 1215 RVA: 0x00008A20 File Offset: 0x00006C20
		private void get_localToWorldMatrix_Injected([Out] Matrix4x4 ret)
		{
			throw new MissingMethodException();
		}

		// Token: 0x060004C0 RID: 1216 RVA: 0x00008A34 File Offset: 0x00006C34
		private void RotateAroundInternal_Injected(Vector3 axis, float angle)
		{
			throw new MissingMethodException();
		}

		// Token: 0x060004C1 RID: 1217 RVA: 0x00008A48 File Offset: 0x00006C48
		private void TransformDirection_Injected(Vector3 direction, [Out] Vector3 ret)
		{
			throw new MissingMethodException();
		}

		// Token: 0x060004C2 RID: 1218 RVA: 0x00008A5C File Offset: 0x00006C5C
		private void TransformPoint_Injected(Vector3 position, [Out] Vector3 ret)
		{
			throw new MissingMethodException();
		}

		// Token: 0x060004C3 RID: 1219 RVA: 0x00008A70 File Offset: 0x00006C70
		private void InverseTransformPoint_Injected(Vector3 position, [Out] Vector3 ret)
		{
			throw new MissingMethodException();
		}

		// Token: 0x020000E1 RID: 225
		private class Enumerator : IEnumerator
		{
			// Token: 0x060004C4 RID: 1220 RVA: 0x00008A84 File Offset: 0x00006C84
			internal Enumerator(Transform outer)
			{
				this.outer = outer;
			}

			// Token: 0x170000F7 RID: 247
			// (get) Token: 0x060004C5 RID: 1221 RVA: 0x00008AA0 File Offset: 0x00006CA0
			public object Current
			{
				get
				{
					Transform transform = this.outer;
					int num = this.currentIndex;
					throw new MissingMethodException();
				}
			}

			// Token: 0x060004C6 RID: 1222 RVA: 0x00008AC0 File Offset: 0x00006CC0
			public bool MoveNext()
			{
				Transform transform = this.outer;
				throw new MissingMethodException();
			}

			// Token: 0x060004C7 RID: 1223 RVA: 0x00008AE8 File Offset: 0x00006CE8
			public void Reset()
			{
			}

			// Token: 0x040003DC RID: 988
			private Transform outer;

			// Token: 0x040003DD RID: 989
			private int currentIndex;
		}
	}
}
