using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace System.Runtime.Serialization
{
	// Token: 0x020003E6 RID: 998
	[Serializable]
	internal sealed class SafeSerializationManager : IObjectReference, ISerializable
	{
		// Token: 0x06001F84 RID: 8068 RVA: 0x00045390 File Offset: 0x00043590
		internal SafeSerializationManager()
		{
		}

		// Token: 0x06001F85 RID: 8069 RVA: 0x000453A4 File Offset: 0x000435A4
		private SafeSerializationManager(SerializationInfo info, StreamingContext context)
		{
			int num = 1;
			base..ctor();
			if (num == 0)
			{
			}
			Type type;
			if (info.GetValueNoThrow("CLR_SafeSerializationManager_RealType", type) != null)
			{
			}
		}

		// Token: 0x17000433 RID: 1075
		// (get) Token: 0x06001F86 RID: 8070 RVA: 0x000453F4 File Offset: 0x000435F4
		internal bool IsActive
		{
			get
			{
				/*
An exception occurred when decompiling this method (06001F86)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean System.Runtime.Serialization.SafeSerializationManager::get_IsActive()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:class System.EventHandler`1<class System.Runtime.Serialization.SafeSerializationEventArgs>(var_0_06, ldfld:class System.EventHandler`1<class System.Runtime.Serialization.SafeSerializationEventArgs>(SafeSerializationManager::SerializeObjectState, ldloc:SafeSerializationManager(this)))
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

		// Token: 0x06001F87 RID: 8071 RVA: 0x00045408 File Offset: 0x00043608
		internal void CompleteSerialization(object serializedObject, SerializationInfo info, StreamingContext context)
		{
			if (this.SerializeObjectState != null)
			{
				Type type = serializedObject.GetType();
				Type type2;
				info.AddValue("CLR_SafeSerializationManager_RealType", type, type2);
				Type type3;
				info.SetType(type3);
				return;
			}
		}

		// Token: 0x06001F88 RID: 8072 RVA: 0x0004543C File Offset: 0x0004363C
		internal void CompleteDeserialization(object deserializedObject)
		{
			IList<object> serializedStates = this.m_serializedStates;
			if (serializedStates != null)
			{
				return;
			}
		}

		// Token: 0x06001F89 RID: 8073 RVA: 0x000454A4 File Offset: 0x000436A4
		void ISerializable.GetObjectData(SerializationInfo info, StreamingContext context)
		{
			IList<object> serializedStates = this.m_serializedStates;
			if (!true)
			{
			}
		}

		// Token: 0x06001F8A RID: 8074 RVA: 0x000454BC File Offset: 0x000436BC
		object IObjectReference.GetRealObject(StreamingContext context)
		{
			/*
An exception occurred when decompiling this method (06001F8A)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Object System.Runtime.Serialization.SafeSerializationManager::System.Runtime.Serialization.IObjectReference.GetRealObject(System.Runtime.Serialization.StreamingContext)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_001C:
	stloc:object(var_10_2C, call:object(FormatterServices::GetUninitializedObject, ldfld:RuntimeType[exp:Type](SafeSerializationManager::m_realType, ldloc:SafeSerializationManager(this))))
	stloc:SerializationInfo(var_11_34, ldfld:SerializationInfo(SafeSerializationManager::m_savedSerializationInfo, ldloc:SafeSerializationManager(this)))
	stfld:object(SafeSerializationManager::m_realObject, ldloc:SafeSerializationManager(this), ldloc:object(var_10_2C))
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

		// Token: 0x06001F8B RID: 8075 RVA: 0x00045508 File Offset: 0x00043708
		[OnDeserialized]
		private void OnDeserialized(StreamingContext context)
		{
			object realObject = this.m_realObject;
			if (realObject != null)
			{
				SerializationEvents serializationEventsForType = SerializationEventsCache.GetSerializationEventsForType(realObject.GetType());
				object realObject2 = this.m_realObject;
				serializationEventsForType.InvokeOnDeserialized(realObject2, context);
			}
		}

		// Token: 0x04000FC2 RID: 4034
		private IList<object> m_serializedStates;

		// Token: 0x04000FC3 RID: 4035
		private SerializationInfo m_savedSerializationInfo;

		// Token: 0x04000FC4 RID: 4036
		private object m_realObject;

		// Token: 0x04000FC5 RID: 4037
		private RuntimeType m_realType;

		// Token: 0x04000FC6 RID: 4038
		[CompilerGenerated]
		private EventHandler<SafeSerializationEventArgs> SerializeObjectState;

		// Token: 0x04000FC7 RID: 4039
		private const string RealTypeSerializationName = "CLR_SafeSerializationManager_RealType";
	}
}
