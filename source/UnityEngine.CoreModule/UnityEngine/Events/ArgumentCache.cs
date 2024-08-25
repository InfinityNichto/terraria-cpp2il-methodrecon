using System;
using Cpp2IlInjected;
using UnityEngine.Serialization;

namespace UnityEngine.Events
{
	// Token: 0x0200015B RID: 347
	[Serializable]
	internal class ArgumentCache : ISerializationCallbackReceiver
	{
		// Token: 0x17000155 RID: 341
		// (get) Token: 0x06000678 RID: 1656 RVA: 0x0000B858 File Offset: 0x00009A58
		public Object unityObjectArgument
		{
			get
			{
				return this.m_ObjectArgument;
			}
		}

		// Token: 0x17000156 RID: 342
		// (get) Token: 0x06000679 RID: 1657 RVA: 0x000021B3 File Offset: 0x000003B3
		public string unityObjectArgumentAssemblyTypeName
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		// Token: 0x17000157 RID: 343
		// (get) Token: 0x0600067A RID: 1658 RVA: 0x0000B86C File Offset: 0x00009A6C
		public int intArgument
		{
			get
			{
				return this.m_IntArgument;
			}
		}

		// Token: 0x17000158 RID: 344
		// (get) Token: 0x0600067B RID: 1659 RVA: 0x0000B880 File Offset: 0x00009A80
		public float floatArgument
		{
			get
			{
				/*
An exception occurred when decompiling this method (0600067B)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Single UnityEngine.Events.ArgumentCache::get_floatArgument()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:float32(var_0_06, ldfld:float32(ArgumentCache::m_FloatArgument, ldloc:ArgumentCache(this)))
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

		// Token: 0x17000159 RID: 345
		// (get) Token: 0x0600067C RID: 1660 RVA: 0x0000B894 File Offset: 0x00009A94
		public string stringArgument
		{
			get
			{
				return this.m_StringArgument;
			}
		}

		// Token: 0x1700015A RID: 346
		// (get) Token: 0x0600067D RID: 1661 RVA: 0x0000B8A8 File Offset: 0x00009AA8
		public bool boolArgument
		{
			get
			{
				return this.m_BoolArgument;
			}
		}

		// Token: 0x0600067E RID: 1662 RVA: 0x0000B8BC File Offset: 0x00009ABC
		public void OnBeforeSerialize()
		{
			string text = UnityEventTools.TidyAssemblyTypeName(this.m_ObjectArgumentAssemblyTypeName);
		}

		// Token: 0x0600067F RID: 1663 RVA: 0x0000B8D8 File Offset: 0x00009AD8
		public void OnAfterDeserialize()
		{
			string text = UnityEventTools.TidyAssemblyTypeName(this.m_ObjectArgumentAssemblyTypeName);
			this.m_ObjectArgumentAssemblyTypeName = text;
		}

		// Token: 0x06000680 RID: 1664 RVA: 0x0000B8F8 File Offset: 0x00009AF8
		public ArgumentCache()
		{
		}

		// Token: 0x04000648 RID: 1608
		[FormerlySerializedAs("objectArgument")]
		[SerializeField]
		private Object m_ObjectArgument;

		// Token: 0x04000649 RID: 1609
		[SerializeField]
		[FormerlySerializedAs("objectArgumentAssemblyTypeName")]
		private string m_ObjectArgumentAssemblyTypeName;

		// Token: 0x0400064A RID: 1610
		[FormerlySerializedAs("intArgument")]
		[SerializeField]
		private int m_IntArgument;

		// Token: 0x0400064B RID: 1611
		[SerializeField]
		[FormerlySerializedAs("floatArgument")]
		private float m_FloatArgument;

		// Token: 0x0400064C RID: 1612
		[SerializeField]
		[FormerlySerializedAs("stringArgument")]
		private string m_StringArgument;

		// Token: 0x0400064D RID: 1613
		[SerializeField]
		private bool m_BoolArgument;
	}
}
