using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.InteropServices;

namespace System.Runtime.Serialization
{
	// Token: 0x020003DC RID: 988
	[ComVisible(true)]
	public class ObjectManager
	{
		// Token: 0x06001F21 RID: 7969 RVA: 0x000440B0 File Offset: 0x000422B0
		internal ObjectManager(ISurrogateSelector selector, StreamingContext context, bool checkSecurity, bool isCrossAppDomain)
		{
			this.m_selector = selector;
			this.m_context = context;
			this.m_context.m_state = (checkSecurity ? StreamingContextStates.CrossProcess : ((StreamingContextStates)0));
		}

		// Token: 0x06001F22 RID: 7970 RVA: 0x000440E0 File Offset: 0x000422E0
		private bool CanCallGetType(object obj)
		{
			return true;
		}

		// Token: 0x17000415 RID: 1045
		// (get) Token: 0x06001F24 RID: 7972 RVA: 0x00044104 File Offset: 0x00042304
		// (set) Token: 0x06001F23 RID: 7971 RVA: 0x000440F0 File Offset: 0x000422F0
		internal object TopObject
		{
			get
			{
				return this.m_topObject;
			}
			set
			{
				this.m_topObject = value;
			}
		}

		// Token: 0x17000416 RID: 1046
		// (get) Token: 0x06001F25 RID: 7973 RVA: 0x00044118 File Offset: 0x00042318
		internal ObjectHolderList SpecialFixupObjects
		{
			get
			{
				/*
An exception occurred when decompiling this method (06001F25)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Runtime.Serialization.ObjectHolderList System.Runtime.Serialization.ObjectManager::get_SpecialFixupObjects()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0000:
	brtrue(IL_0000, ldfld:ObjectHolderList[exp:bool](ObjectManager::m_specialFixupObjects, ldloc:ObjectManager(this)))
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
		}

		// Token: 0x06001F26 RID: 7974 RVA: 0x0004412C File Offset: 0x0004232C
		internal ObjectHolder FindObjectHolder(long objectID)
		{
			ObjectHolder[] objects = this.m_objects;
			long id = objects.m_id;
			int missingElementsRemaining = objects.m_missingElementsRemaining;
			if (missingElementsRemaining != 0)
			{
				while (missingElementsRemaining != 0)
				{
				}
				return;
			}
		}

		// Token: 0x06001F27 RID: 7975 RVA: 0x00044158 File Offset: 0x00042358
		internal ObjectHolder FindOrCreateObjectHolder(long objectID)
		{
			/*
An exception occurred when decompiling this method (06001F27)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Runtime.Serialization.ObjectHolder System.Runtime.Serialization.ObjectManager::FindOrCreateObjectHolder(System.Int64)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0018:
	brtrue(IL_0018, ldloc:int32[exp:bool](var_2_14))
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

		// Token: 0x06001F28 RID: 7976 RVA: 0x00044180 File Offset: 0x00042380
		private void AddObjectHolder(ObjectHolder holder)
		{
			ObjectHolder[] objects = this.m_objects;
			long id = holder.m_id;
			long id2 = objects.m_id;
		}

		// Token: 0x06001F29 RID: 7977 RVA: 0x000441D8 File Offset: 0x000423D8
		private bool GetCompletionInfo(FixupHolder fixup, [Out] ObjectHolder holder, [Out] object member, bool bThrowIfMissing)
		{
			ObjectHolder[] objects;
			int missingElementsRemaining;
			do
			{
				object fixupInfo = fixup.m_fixupInfo;
				objects = this.m_objects;
				long id = fixup.m_id;
				long id2 = objects.m_id;
				missingElementsRemaining = objects.m_missingElementsRemaining;
			}
			while (missingElementsRemaining == 0);
			while (missingElementsRemaining != 0)
			{
			}
			if (false || objects != null)
			{
			}
			bool flag;
			return flag;
		}

		// Token: 0x06001F2A RID: 7978 RVA: 0x00044250 File Offset: 0x00042450
		private void FixupSpecialObject(ObjectHolder holder)
		{
			int flags = holder.m_flags;
			object @object = holder.m_object;
			SerializationInfo serInfo = holder.m_serInfo;
			StreamingContext context = this.m_context;
			StreamingContextStates state = this.m_context.m_state;
		}

		// Token: 0x06001F2B RID: 7979 RVA: 0x00044320 File Offset: 0x00042520
		private bool ResolveObjectReference(ObjectHolder holder)
		{
			object @object = holder.m_object;
			return false;
		}

		// Token: 0x06001F2C RID: 7980 RVA: 0x000443C4 File Offset: 0x000425C4
		private bool DoValueTypeFixup(FieldInfo memberToFix, ObjectHolder holder, object value)
		{
			int flags = holder.m_flags;
			long num = 0L;
			object @object = holder.m_object;
			ValueTypeFixupInfo valueFixup = holder.m_valueFixup;
			object object2 = holder.m_object;
			FieldInfo parentField = valueFixup._parentField;
			long containerID = valueFixup._containerID;
			FieldInfo parentField2 = valueFixup._parentField;
			ObjectHolder[] objects = this.m_objects;
			if (containerID != 0L)
			{
				if (objects == null)
				{
				}
				if ((parentField2 != null && parentField2 == null) || parentField2 == null)
				{
					goto IL_009A;
				}
			}
			long num2 = 0L;
			long id = objects.m_id;
			int missingElementsRemaining = objects.m_missingElementsRemaining;
			if (missingElementsRemaining != 0)
			{
				while (missingElementsRemaining != 0)
				{
				}
			}
			if (num != 0L)
			{
				if (num != 0L)
				{
				}
				if (num != 0L && num == 0L)
				{
					goto IL_009A;
				}
				if (num == 0L)
				{
					goto IL_0090;
				}
			}
			if (num2 != 0L || num2 != 0L)
			{
				goto IL_0094;
			}
			IL_0090:
			if (num2 == 0L)
			{
				goto IL_0097;
			}
			IL_0094:
			if (num != 0L)
			{
			}
			IL_0097:
			IL_009A:
			throw new ArrayTypeMismatchException();
		}

		// Token: 0x06001F2D RID: 7981 RVA: 0x00044478 File Offset: 0x00042678
		internal void CompleteObject(ObjectHolder holder, bool bObjectFullyComplete)
		{
			/*
An exception occurred when decompiling this method (06001F2D)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Void System.Runtime.Serialization.ObjectManager::CompleteObject(System.Runtime.Serialization.ObjectHolder,System.Boolean)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0186:
	stloc:string(var_35_190, call:string(Environment::GetResourceString, ldstr:string("A fixup on an object implementing ISerializable or having a surrogate was discovered for an object which does not have a SerializationInfo available.")))
}

   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1852
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1878
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1878
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1846
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1878
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1878
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1846
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

		// Token: 0x06001F2E RID: 7982 RVA: 0x00044618 File Offset: 0x00042818
		private void DoNewlyRegisteredObjectFixups(ObjectHolder holder)
		{
			int flags = holder.m_flags;
			bool canSurrogatedObjectValueChange = holder.CanSurrogatedObjectValueChange;
			LongList dependentObjects = holder.m_dependentObjects;
			if (dependentObjects == null)
			{
				return;
			}
			dependentObjects.m_currentItem = flags;
			int totalItems = dependentObjects.m_totalItems;
			long[] values = dependentObjects.m_values;
			dependentObjects.m_currentItem = flags;
			long[] values2 = dependentObjects.m_values;
			ObjectHolder[] objects = this.m_objects;
			long id = objects.m_id;
			int missingElementsRemaining = objects.m_missingElementsRemaining;
			if (missingElementsRemaining != 0)
			{
				while (missingElementsRemaining != 0)
				{
				}
				return;
			}
			if (flags == 0 && flags != 0)
			{
				return;
			}
		}

		// Token: 0x06001F2F RID: 7983 RVA: 0x00044694 File Offset: 0x00042894
		public virtual object GetObject(long objectID)
		{
			/*
An exception occurred when decompiling this method (06001F2F)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Object System.Runtime.Serialization.ObjectManager::GetObject(System.Int64)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_001B:
	stloc:string(var_5_28, call:string(Environment::GetResourceString, ldstr:string("objectID cannot be less than or equal to zero.")))
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

		// Token: 0x06001F30 RID: 7984 RVA: 0x000446CC File Offset: 0x000428CC
		internal void RegisterString(string obj, long objectID, SerializationInfo info, long idOfContainingObj, MemberInfo member)
		{
			if (member != null)
			{
			}
		}

		// Token: 0x06001F31 RID: 7985 RVA: 0x000446E4 File Offset: 0x000428E4
		public void RegisterObject(object obj, long objectID, SerializationInfo info, long idOfContainingObj, MemberInfo member, int[] arrayIndex)
		{
			if (obj == null)
			{
				string resourceString = Environment.GetResourceString("objectID cannot be less than or equal to zero.");
				return;
			}
			if (this.m_selector != null)
			{
				Type type = obj.GetType();
				ISurrogateSelector selector = this.m_selector;
				StreamingContext context = this.m_context;
				StreamingContextStates state = this.m_context.m_state;
				return;
			}
		}

		// Token: 0x06001F32 RID: 7986 RVA: 0x00044794 File Offset: 0x00042994
		internal void CompleteISerializableObject(object obj, SerializationInfo info, StreamingContext context)
		{
			if (obj != null && obj != null)
			{
				if (obj.GetType() != null)
				{
				}
				RuntimeConstructorInfo runtimeConstructorInfo;
				runtimeConstructorInfo.SerializationInvoke(obj, info, context);
				return;
			}
			throw new ArrayTypeMismatchException();
		}

		// Token: 0x06001F33 RID: 7987 RVA: 0x000447CC File Offset: 0x000429CC
		internal static RuntimeConstructorInfo GetConstructor(RuntimeType t)
		{
			RuntimeConstructorInfo runtimeConstructorInfo;
			return runtimeConstructorInfo;
		}

		// Token: 0x06001F34 RID: 7988 RVA: 0x000447E0 File Offset: 0x000429E0
		public virtual void DoFixups()
		{
			ObjectHolderListEnumerator fixupEnumerator = this.SpecialFixupObjects.GetFixupEnumerator();
			bool flag = fixupEnumerator.MoveNext();
			ObjectHolder[] values = fixupEnumerator.m_list.m_values;
			int missingElementsRemaining = values.m_missingElementsRemaining;
			if (values != null)
			{
				return;
			}
			throw new ArrayTypeMismatchException();
		}

		// Token: 0x06001F35 RID: 7989 RVA: 0x0004488C File Offset: 0x00042A8C
		private void RegisterFixup(FixupHolder fixup, long objectToBeFixed, long objectRequired)
		{
			ObjectHolder objectHolder = this.FindOrCreateObjectHolder(objectToBeFixed);
			if (objectHolder.m_flags != 0)
			{
				int fixupType = fixup.m_fixupType;
			}
			objectHolder.AddFixup(fixup, this);
			this.FindOrCreateObjectHolder(objectRequired).AddDependency(objectToBeFixed);
			long fixupCount = this.m_fixupCount;
			this.m_fixupCount = fixupCount;
		}

		// Token: 0x06001F36 RID: 7990 RVA: 0x000448E0 File Offset: 0x00042AE0
		public virtual void RecordFixup(long objectToBeFixed, MemberInfo member, long objectRequired)
		{
			if (member != null)
			{
				return;
			}
			Type type = base.GetType();
			throw new ArrayTypeMismatchException();
		}

		// Token: 0x06001F37 RID: 7991 RVA: 0x0004490C File Offset: 0x00042B0C
		public virtual void RecordDelayedFixup(long objectToBeFixed, string memberName, long objectRequired)
		{
			while (memberName == null)
			{
			}
		}

		// Token: 0x06001F38 RID: 7992 RVA: 0x00044928 File Offset: 0x00042B28
		public virtual void RecordArrayElementFixup(long arrayToBeFixed, int[] indices, long objectRequired)
		{
			while (indices == null)
			{
			}
		}

		// Token: 0x06001F39 RID: 7993 RVA: 0x00044944 File Offset: 0x00042B44
		public virtual void RaiseDeserializationEvent()
		{
			SerializationEventHandler onDeserializedHandler = this.m_onDeserializedHandler;
			if (onDeserializedHandler != null)
			{
				StreamingContext context = this.m_context;
				StreamingContextStates state = this.m_context.m_state;
				IntPtr invoke_impl = onDeserializedHandler.invoke_impl;
				IntPtr method_code = onDeserializedHandler.method_code;
				IntPtr method = onDeserializedHandler.method;
			}
			DeserializationEventHandler onDeserializationHandler = this.m_onDeserializationHandler;
			if (onDeserializationHandler != null)
			{
				IntPtr invoke_impl2 = onDeserializationHandler.invoke_impl;
				IntPtr method_code2 = onDeserializationHandler.method_code;
				IntPtr method2 = onDeserializationHandler.method;
				return;
			}
		}

		// Token: 0x06001F3A RID: 7994 RVA: 0x000449B0 File Offset: 0x00042BB0
		internal virtual void AddOnDeserialization(DeserializationEventHandler handler)
		{
			Delegate @delegate = Delegate.Combine(this.m_onDeserializationHandler, handler);
			if (@delegate != null)
			{
				this.m_onDeserializationHandler = @delegate;
				throw new InvalidCastException();
			}
			this.m_onDeserializationHandler = @delegate;
		}

		// Token: 0x06001F3B RID: 7995 RVA: 0x000449E4 File Offset: 0x00042BE4
		internal virtual void AddOnDeserialized(object obj)
		{
			SerializationEvents serializationEventsForType = SerializationEventsCache.GetSerializationEventsForType(obj.GetType());
			SerializationEventHandler onDeserializedHandler = this.m_onDeserializedHandler;
			List<MethodInfo> onDeserializedMethods = serializationEventsForType._onDeserializedMethods;
			SerializationEventHandler serializationEventHandler = SerializationEvents.AddOnDelegate(obj, onDeserializedHandler, onDeserializedMethods);
			this.m_onDeserializedHandler = serializationEventHandler;
		}

		// Token: 0x06001F3C RID: 7996 RVA: 0x00044A1C File Offset: 0x00042C1C
		internal virtual void RaiseOnDeserializedEvent(object obj)
		{
			long num = 0L;
			SerializationEvents serializationEventsForType = SerializationEventsCache.GetSerializationEventsForType(obj.GetType());
			StreamingContext context = this.m_context;
			StreamingContextStates state = this.m_context.m_state;
			serializationEventsForType.InvokeOnDeserialized(num, context);
		}

		// Token: 0x06001F3D RID: 7997 RVA: 0x00044A54 File Offset: 0x00042C54
		public void RaiseOnDeserializingEvent(object obj)
		{
			SerializationEvents serializationEventsForType = SerializationEventsCache.GetSerializationEventsForType(obj.GetType());
			StreamingContext context = this.m_context;
			StreamingContextStates state = this.m_context.m_state;
			serializationEventsForType.InvokeOnDeserializing(obj, context);
		}

		// Token: 0x04000F9A RID: 3994
		private DeserializationEventHandler m_onDeserializationHandler;

		// Token: 0x04000F9B RID: 3995
		private SerializationEventHandler m_onDeserializedHandler;

		// Token: 0x04000F9C RID: 3996
		internal ObjectHolder[] m_objects;

		// Token: 0x04000F9D RID: 3997
		internal object m_topObject;

		// Token: 0x04000F9E RID: 3998
		internal ObjectHolderList m_specialFixupObjects;

		// Token: 0x04000F9F RID: 3999
		internal long m_fixupCount;

		// Token: 0x04000FA0 RID: 4000
		internal ISurrogateSelector m_selector;

		// Token: 0x04000FA1 RID: 4001
		internal StreamingContext m_context;
	}
}
