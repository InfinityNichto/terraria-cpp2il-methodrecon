using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine.Bindings;
using UnityEngine.Internal;
using UnityEngine.Scripting;
using UnityEngineInternal;

namespace UnityEngine
{
	// Token: 0x020000C4 RID: 196
	[NativeHeader("Runtime/Export/Scripting/Component.bindings.h")]
	[RequiredByNativeCode]
	[NativeClass("Unity::Component")]
	public class Component : Object
	{
		// Token: 0x170000B4 RID: 180
		// (get) Token: 0x0600035B RID: 859 RVA: 0x00006E24 File Offset: 0x00005024
		public Transform transform
		{
			[FreeFunction("GetTransform", HasExplicitThis = true, ThrowsException = true)]
			get
			{
				throw new MissingMethodException();
			}
		}

		// Token: 0x170000B5 RID: 181
		// (get) Token: 0x0600035C RID: 860 RVA: 0x00006E38 File Offset: 0x00005038
		public GameObject gameObject
		{
			[FreeFunction("GetGameObject", HasExplicitThis = true)]
			get
			{
				throw new MissingMethodException();
			}
		}

		// Token: 0x0600035D RID: 861 RVA: 0x00006E4C File Offset: 0x0000504C
		[TypeInferenceRule(TypeInferenceRules.TypeReferencedByFirstArgument)]
		public Component GetComponent(Type type)
		{
			throw new MissingMethodException();
		}

		// Token: 0x0600035E RID: 862 RVA: 0x00006E68 File Offset: 0x00005068
		[FreeFunction(HasExplicitThis = true, ThrowsException = true)]
		internal void GetComponentFastPath(Type type, IntPtr oneFurtherThanResultValue)
		{
			throw new MissingMethodException();
		}

		// Token: 0x0600035F RID: 863 RVA: 0x000021B3 File Offset: 0x000003B3
		public T GetComponent<T>()
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06000360 RID: 864 RVA: 0x00006E7C File Offset: 0x0000507C
		[TypeInferenceRule(TypeInferenceRules.TypeReferencedByFirstArgument)]
		public Component GetComponentInChildren(Type t, bool includeInactive)
		{
			throw new MissingMethodException();
		}

		// Token: 0x06000361 RID: 865 RVA: 0x00006E98 File Offset: 0x00005098
		[ExcludeFromDocs]
		public T GetComponentInChildren<T>()
		{
			Component componentInChildren;
			do
			{
				long num = 0L;
				Type type;
				componentInChildren = this.GetComponentInChildren(type, num != 0L);
				if (componentInChildren == null)
				{
					return;
				}
			}
			while (componentInChildren != null);
			throw new InvalidCastException();
		}

		// Token: 0x06000362 RID: 866 RVA: 0x00006EC0 File Offset: 0x000050C0
		public T[] GetComponentsInChildren<T>(bool includeInactive)
		{
			/*
An exception occurred when decompiling this method (06000362)

ICSharpCode.Decompiler.DecompilerException: Error decompiling T[] UnityEngine.Component::GetComponentsInChildren<T>(System.Boolean)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:GameObject(var_0_06, callgetter:GameObject(Component::get_gameObject, ldloc:Component(this)))
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

		// Token: 0x06000363 RID: 867 RVA: 0x00006ED4 File Offset: 0x000050D4
		public void GetComponentsInChildren<T>(bool includeInactive, List<T> result)
		{
			GameObject gameObject = this.gameObject;
		}

		// Token: 0x06000364 RID: 868 RVA: 0x00006EE8 File Offset: 0x000050E8
		public void GetComponentsInChildren<T>(List<T> results)
		{
		}

		// Token: 0x06000365 RID: 869 RVA: 0x00006EF8 File Offset: 0x000050F8
		[TypeInferenceRule(TypeInferenceRules.TypeReferencedByFirstArgument)]
		public Component GetComponentInParent(Type t, bool includeInactive)
		{
			throw new MissingMethodException();
		}

		// Token: 0x06000366 RID: 870 RVA: 0x00006F14 File Offset: 0x00005114
		public T GetComponentInParent<T>()
		{
			Component componentInParent;
			do
			{
				long num = 0L;
				Type type;
				componentInParent = this.GetComponentInParent(type, num != 0L);
				if (componentInParent == null)
				{
					return;
				}
			}
			while (componentInParent != null);
			throw new InvalidCastException();
		}

		// Token: 0x06000367 RID: 871 RVA: 0x00006F3C File Offset: 0x0000513C
		public T[] GetComponentsInParent<T>(bool includeInactive)
		{
			/*
An exception occurred when decompiling this method (06000367)

ICSharpCode.Decompiler.DecompilerException: Error decompiling T[] UnityEngine.Component::GetComponentsInParent<T>(System.Boolean)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:GameObject(var_0_06, callgetter:GameObject(Component::get_gameObject, ldloc:Component(this)))
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

		// Token: 0x06000368 RID: 872 RVA: 0x00006F50 File Offset: 0x00005150
		public void GetComponentsInParent<T>(bool includeInactive, List<T> results)
		{
			GameObject gameObject = this.gameObject;
		}

		// Token: 0x06000369 RID: 873 RVA: 0x000021B3 File Offset: 0x000003B3
		public T[] GetComponentsInParent<T>()
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x0600036A RID: 874 RVA: 0x00006F64 File Offset: 0x00005164
		[FreeFunction(HasExplicitThis = true, ThrowsException = true)]
		private void GetComponentsForListInternal(Type searchType, object resultList)
		{
			throw new MissingMethodException();
		}

		// Token: 0x0600036B RID: 875 RVA: 0x00006F78 File Offset: 0x00005178
		public void GetComponents(Type type, List<Component> results)
		{
			throw new MissingMethodException();
		}

		// Token: 0x0600036C RID: 876 RVA: 0x00006F8C File Offset: 0x0000518C
		public void GetComponents<T>(List<T> results)
		{
			Type type;
			this.GetComponentsForListInternal(type, results);
		}

		// Token: 0x0600036D RID: 877 RVA: 0x00006FA4 File Offset: 0x000051A4
		public T[] GetComponents<T>()
		{
			/*
An exception occurred when decompiling this method (0600036D)

ICSharpCode.Decompiler.DecompilerException: Error decompiling T[] UnityEngine.Component::GetComponents<T>()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:GameObject(var_0_06, callgetter:GameObject(Component::get_gameObject, ldloc:Component(this)))
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

		// Token: 0x0600036E RID: 878 RVA: 0x00006FB8 File Offset: 0x000051B8
		public Component()
		{
			if (!true)
			{
			}
			base..ctor();
		}
	}
}
