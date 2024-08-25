using System;
using System.Reflection;

namespace System.Runtime.Serialization
{
	// Token: 0x020003DD RID: 989
	internal sealed class ObjectHolder
	{
		// Token: 0x06001F3E RID: 7998 RVA: 0x00044A88 File Offset: 0x00042C88
		internal ObjectHolder(long objID)
		{
		}

		// Token: 0x06001F3F RID: 7999 RVA: 0x00044A98 File Offset: 0x00042C98
		internal ObjectHolder(object obj, long objID, SerializationInfo info, ISerializationSurrogate surrogate, long idOfContainingObj, FieldInfo field, int[] arrayIndex)
		{
			this.m_object = obj;
			this.m_id = objID;
			this.m_serInfo = info;
			this.m_surrogate = surrogate;
			if (obj != null)
			{
				this.m_typeLoad = obj;
			}
			if (idOfContainingObj != 0L && arrayIndex == null)
			{
				return;
			}
			this.SetFlags();
		}

		// Token: 0x06001F40 RID: 8000 RVA: 0x00044AF8 File Offset: 0x00042CF8
		internal ObjectHolder(string obj, long objID, SerializationInfo info, ISerializationSurrogate surrogate, long idOfContainingObj, FieldInfo field, int[] arrayIndex)
		{
			this.m_object = obj;
			this.m_id = objID;
			this.m_serInfo = info;
			this.m_surrogate = surrogate;
			if (idOfContainingObj != 0L && arrayIndex != null)
			{
				return;
			}
			if (this.m_valueFixup != null)
			{
				int flags = this.m_flags;
				this.m_flags = flags;
			}
		}

		// Token: 0x06001F41 RID: 8001 RVA: 0x00044B48 File Offset: 0x00042D48
		private void IncrementDescendentFixups(int amount)
		{
			int missingDecendents = this.m_missingDecendents;
			this.m_missingDecendents = missingDecendents;
		}

		// Token: 0x06001F42 RID: 8002 RVA: 0x00044B64 File Offset: 0x00042D64
		internal void DecrementFixupsRemaining(ObjectManager manager)
		{
			int missingElementsRemaining = this.m_missingElementsRemaining;
			int flags = this.m_flags;
			this.m_missingElementsRemaining = missingElementsRemaining;
		}

		// Token: 0x06001F43 RID: 8003 RVA: 0x00044B88 File Offset: 0x00042D88
		internal void RemoveDependency(long id)
		{
			LongList dependentObjects = this.m_dependentObjects;
			int totalItems = dependentObjects.m_totalItems;
			long[] values = dependentObjects.m_values;
		}

		// Token: 0x06001F44 RID: 8004 RVA: 0x00044BB8 File Offset: 0x00042DB8
		internal void AddFixup(FixupHolder fixup, ObjectManager manager)
		{
			FixupHolderList missingElements = this.m_missingElements;
			if (missingElements == null)
			{
				this.m_missingElements = missingElements;
			}
			int missingElementsRemaining = this.m_missingElementsRemaining;
			int flags = this.m_flags;
			this.m_missingElementsRemaining = missingElementsRemaining;
		}

		// Token: 0x06001F45 RID: 8005 RVA: 0x00044BFC File Offset: 0x00042DFC
		private void UpdateDescendentDependencyChain(int amount, ObjectManager manager)
		{
			ValueTypeFixupInfo valueFixup = this.m_valueFixup;
			if (valueFixup != null)
			{
				long containerID = valueFixup._containerID;
				return;
			}
			long num = 0L;
			ObjectHolder objectHolder = manager.FindOrCreateObjectHolder(num);
			int missingDecendents = objectHolder.m_missingDecendents;
			int flags = objectHolder.m_flags;
			objectHolder.m_missingDecendents = missingDecendents;
		}

		// Token: 0x06001F46 RID: 8006 RVA: 0x00044C40 File Offset: 0x00042E40
		internal void AddDependency(long dependentObject)
		{
			if (this.m_dependentObjects == null)
			{
			}
		}

		// Token: 0x06001F47 RID: 8007 RVA: 0x00044C58 File Offset: 0x00042E58
		internal void UpdateData(object obj, SerializationInfo info, ISerializationSurrogate surrogate, long idOfContainer, FieldInfo field, int[] arrayIndex, ObjectManager manager)
		{
			this.SetObjectValue(obj, manager);
			this.m_serInfo = info;
			this.m_surrogate = surrogate;
			if (idOfContainer != 0L)
			{
				if (arrayIndex == null)
				{
					return;
				}
				long id = this.m_id;
			}
			this.SetFlags();
			int flags = this.m_flags;
		}

		// Token: 0x06001F48 RID: 8008 RVA: 0x00044CBC File Offset: 0x00042EBC
		internal void MarkForCompletionWhenAvailable()
		{
			this.m_markForFixupWhenAvailable = true;
		}

		// Token: 0x06001F49 RID: 8009 RVA: 0x00044CD0 File Offset: 0x00042ED0
		internal void SetFlags()
		{
			object @object = this.m_object;
			int flags = this.m_flags;
			if (@object != null)
			{
				this.m_flags = flags;
			}
			ISerializationSurrogate surrogate = this.m_surrogate;
			this.m_flags = flags;
			if (surrogate != null)
			{
				return;
			}
			if (this.m_object != null)
			{
				int flags2 = this.m_flags;
				this.m_flags = flags2;
			}
			if (this.m_valueFixup != null)
			{
				int flags3 = this.m_flags;
				this.m_flags = flags3;
			}
		}

		// Token: 0x17000417 RID: 1047
		// (get) Token: 0x06001F4A RID: 8010 RVA: 0x00044D38 File Offset: 0x00042F38
		// (set) Token: 0x06001F4B RID: 8011 RVA: 0x00044D4C File Offset: 0x00042F4C
		internal bool IsIncompleteObjectReference
		{
			get
			{
				/*
An exception occurred when decompiling this method (06001F4A)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean System.Runtime.Serialization.ObjectHolder::get_IsIncompleteObjectReference()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:int32(var_0_06, ldfld:int32(ObjectHolder::m_flags, ldloc:ObjectHolder(this)))
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
			set
			{
				int flags = this.m_flags;
				this.m_flags = flags;
			}
		}

		// Token: 0x17000418 RID: 1048
		// (get) Token: 0x06001F4C RID: 8012 RVA: 0x00044D68 File Offset: 0x00042F68
		internal bool RequiresDelayedFixup
		{
			get
			{
				/*
An exception occurred when decompiling this method (06001F4C)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean System.Runtime.Serialization.ObjectHolder::get_RequiresDelayedFixup()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:int32(var_0_06, ldfld:int32(ObjectHolder::m_flags, ldloc:ObjectHolder(this)))
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

		// Token: 0x17000419 RID: 1049
		// (get) Token: 0x06001F4D RID: 8013 RVA: 0x00044D7C File Offset: 0x00042F7C
		internal bool RequiresValueTypeFixup
		{
			get
			{
				/*
An exception occurred when decompiling this method (06001F4D)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean System.Runtime.Serialization.ObjectHolder::get_RequiresValueTypeFixup()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:int32(var_0_06, ldfld:int32(ObjectHolder::m_flags, ldloc:ObjectHolder(this)))
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

		// Token: 0x1700041A RID: 1050
		// (get) Token: 0x06001F4E RID: 8014 RVA: 0x00044D90 File Offset: 0x00042F90
		// (set) Token: 0x06001F4F RID: 8015 RVA: 0x00044DBC File Offset: 0x00042FBC
		internal bool ValueTypeFixupPerformed
		{
			get
			{
				if (this.m_object != null)
				{
					LongList dependentObjects = this.m_dependentObjects;
					if (dependentObjects != null)
					{
						int count = dependentObjects.m_count;
					}
					return true;
				}
			}
			set
			{
				int flags = this.m_flags;
				this.m_flags = flags;
			}
		}

		// Token: 0x1700041B RID: 1051
		// (get) Token: 0x06001F50 RID: 8016 RVA: 0x00044DD8 File Offset: 0x00042FD8
		internal bool HasISerializable
		{
			get
			{
				/*
An exception occurred when decompiling this method (06001F50)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean System.Runtime.Serialization.ObjectHolder::get_HasISerializable()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:int32(var_0_06, ldfld:int32(ObjectHolder::m_flags, ldloc:ObjectHolder(this)))
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

		// Token: 0x1700041C RID: 1052
		// (get) Token: 0x06001F51 RID: 8017 RVA: 0x00044DEC File Offset: 0x00042FEC
		internal bool HasSurrogate
		{
			get
			{
				/*
An exception occurred when decompiling this method (06001F51)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean System.Runtime.Serialization.ObjectHolder::get_HasSurrogate()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:int32(var_0_06, ldfld:int32(ObjectHolder::m_flags, ldloc:ObjectHolder(this)))
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

		// Token: 0x1700041D RID: 1053
		// (get) Token: 0x06001F52 RID: 8018 RVA: 0x00044E00 File Offset: 0x00043000
		internal bool CanSurrogatedObjectValueChange
		{
			get
			{
				Type type;
				Type type2;
				return this.m_surrogate == null || type != type2;
			}
		}

		// Token: 0x1700041E RID: 1054
		// (get) Token: 0x06001F53 RID: 8019 RVA: 0x00044E20 File Offset: 0x00043020
		internal bool CanObjectValueChange
		{
			get
			{
				int flags = this.m_flags;
				return true;
			}
		}

		// Token: 0x1700041F RID: 1055
		// (get) Token: 0x06001F54 RID: 8020 RVA: 0x00044E3C File Offset: 0x0004303C
		internal int DirectlyDependentObjects
		{
			get
			{
				return this.m_missingElementsRemaining;
			}
		}

		// Token: 0x17000420 RID: 1056
		// (get) Token: 0x06001F55 RID: 8021 RVA: 0x00044E50 File Offset: 0x00043050
		internal int TotalDependentObjects
		{
			get
			{
				/*
An exception occurred when decompiling this method (06001F55)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Int32 System.Runtime.Serialization.ObjectHolder::get_TotalDependentObjects()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:int32(var_0_06, ldfld:int32(ObjectHolder::m_missingElementsRemaining, ldloc:ObjectHolder(this)))
	stloc:SerializationInfo(var_1_0D, ldfld:SerializationInfo(ObjectHolder::m_serInfo, ldloc:ObjectHolder(this)))
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

		// Token: 0x17000421 RID: 1057
		// (get) Token: 0x06001F56 RID: 8022 RVA: 0x00044E6C File Offset: 0x0004306C
		// (set) Token: 0x06001F57 RID: 8023 RVA: 0x00044E80 File Offset: 0x00043080
		internal bool Reachable
		{
			get
			{
				return this.m_reachable;
			}
			set
			{
			}
		}

		// Token: 0x17000422 RID: 1058
		// (get) Token: 0x06001F58 RID: 8024 RVA: 0x00044E90 File Offset: 0x00043090
		internal bool TypeLoadExceptionReachable
		{
			get
			{
				/*
An exception occurred when decompiling this method (06001F58)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean System.Runtime.Serialization.ObjectHolder::get_TypeLoadExceptionReachable()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:TypeLoadExceptionHolder(var_0_06, ldfld:TypeLoadExceptionHolder(ObjectHolder::m_typeLoad, ldloc:ObjectHolder(this)))
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

		// Token: 0x17000423 RID: 1059
		// (get) Token: 0x06001F59 RID: 8025 RVA: 0x00044EA4 File Offset: 0x000430A4
		// (set) Token: 0x06001F5A RID: 8026 RVA: 0x00044EB8 File Offset: 0x000430B8
		internal TypeLoadExceptionHolder TypeLoadException
		{
			get
			{
				return this.m_typeLoad;
			}
			set
			{
				this.m_typeLoad = value;
			}
		}

		// Token: 0x17000424 RID: 1060
		// (get) Token: 0x06001F5B RID: 8027 RVA: 0x00044ECC File Offset: 0x000430CC
		internal object ObjectValue
		{
			get
			{
				return this.m_object;
			}
		}

		// Token: 0x06001F5C RID: 8028 RVA: 0x00044EE0 File Offset: 0x000430E0
		internal void SetObjectValue(object obj, ObjectManager manager)
		{
			this.m_object = obj;
			object topObject = manager.m_topObject;
			if (obj == null)
			{
				return;
			}
			this.m_typeLoad = obj;
			if (this.m_markForFixupWhenAvailable)
			{
				int num = 1;
				manager.CompleteObject(this, num != 0);
				return;
			}
		}

		// Token: 0x17000425 RID: 1061
		// (get) Token: 0x06001F5D RID: 8029 RVA: 0x00044F2C File Offset: 0x0004312C
		// (set) Token: 0x06001F5E RID: 8030 RVA: 0x00044F40 File Offset: 0x00043140
		internal SerializationInfo SerializationInfo
		{
			get
			{
				return this.m_serInfo;
			}
			set
			{
				this.m_serInfo = value;
			}
		}

		// Token: 0x17000426 RID: 1062
		// (get) Token: 0x06001F5F RID: 8031 RVA: 0x00044F54 File Offset: 0x00043154
		internal ISerializationSurrogate Surrogate
		{
			get
			{
				return this.m_surrogate;
			}
		}

		// Token: 0x17000427 RID: 1063
		// (get) Token: 0x06001F60 RID: 8032 RVA: 0x00044F68 File Offset: 0x00043168
		// (set) Token: 0x06001F61 RID: 8033 RVA: 0x00044F7C File Offset: 0x0004317C
		internal LongList DependentObjects
		{
			get
			{
				return this.m_dependentObjects;
			}
			set
			{
				this.m_dependentObjects = value;
			}
		}

		// Token: 0x17000428 RID: 1064
		// (get) Token: 0x06001F62 RID: 8034 RVA: 0x00044F90 File Offset: 0x00043190
		// (set) Token: 0x06001F63 RID: 8035 RVA: 0x00044FA4 File Offset: 0x000431A4
		internal bool RequiresSerInfoFixup
		{
			get
			{
				/*
An exception occurred when decompiling this method (06001F62)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean System.Runtime.Serialization.ObjectHolder::get_RequiresSerInfoFixup()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:int32(var_0_06, ldfld:int32(ObjectHolder::m_flags, ldloc:ObjectHolder(this)))
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
			set
			{
				int flags = this.m_flags;
				this.m_flags = flags;
			}
		}

		// Token: 0x17000429 RID: 1065
		// (get) Token: 0x06001F64 RID: 8036 RVA: 0x00044FC0 File Offset: 0x000431C0
		internal ValueTypeFixupInfo ValueFixup
		{
			get
			{
				return this.m_valueFixup;
			}
		}

		// Token: 0x1700042A RID: 1066
		// (get) Token: 0x06001F65 RID: 8037 RVA: 0x00044FD4 File Offset: 0x000431D4
		internal bool CompletelyFixed
		{
			get
			{
				/*
An exception occurred when decompiling this method (06001F65)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean System.Runtime.Serialization.ObjectHolder::get_CompletelyFixed()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:int32(var_0_06, ldfld:int32(ObjectHolder::m_flags, ldloc:ObjectHolder(this)))
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

		// Token: 0x1700042B RID: 1067
		// (get) Token: 0x06001F66 RID: 8038 RVA: 0x00044FEC File Offset: 0x000431EC
		internal long ContainerID
		{
			get
			{
				ValueTypeFixupInfo valueFixup = this.m_valueFixup;
				if (valueFixup != null)
				{
					return valueFixup._containerID;
				}
				return 0L;
			}
		}

		// Token: 0x04000FA2 RID: 4002
		private object m_object;

		// Token: 0x04000FA3 RID: 4003
		internal long m_id;

		// Token: 0x04000FA4 RID: 4004
		private int m_missingElementsRemaining;

		// Token: 0x04000FA5 RID: 4005
		private int m_missingDecendents;

		// Token: 0x04000FA6 RID: 4006
		internal SerializationInfo m_serInfo;

		// Token: 0x04000FA7 RID: 4007
		internal ISerializationSurrogate m_surrogate;

		// Token: 0x04000FA8 RID: 4008
		internal FixupHolderList m_missingElements;

		// Token: 0x04000FA9 RID: 4009
		internal LongList m_dependentObjects;

		// Token: 0x04000FAA RID: 4010
		internal ObjectHolder m_next;

		// Token: 0x04000FAB RID: 4011
		internal int m_flags;

		// Token: 0x04000FAC RID: 4012
		private bool m_markForFixupWhenAvailable;

		// Token: 0x04000FAD RID: 4013
		private ValueTypeFixupInfo m_valueFixup;

		// Token: 0x04000FAE RID: 4014
		private TypeLoadExceptionHolder m_typeLoad;

		// Token: 0x04000FAF RID: 4015
		private bool m_reachable;
	}
}
