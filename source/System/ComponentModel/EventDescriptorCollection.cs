using System;
using System.Collections;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;

namespace System.ComponentModel
{
	// Token: 0x02000374 RID: 884
	public class EventDescriptorCollection : ICollection, IEnumerable, IList
	{
		// Token: 0x06001710 RID: 5904 RVA: 0x00042C08 File Offset: 0x00040E08
		public EventDescriptorCollection(EventDescriptor[] events)
		{
			if (events != null)
			{
				this._events = events;
				string displayName = events.displayName;
				this.System.Collections.ICollection.Count = displayName;
				return;
			}
			this._eventsOwned = true;
		}

		// Token: 0x06001711 RID: 5905 RVA: 0x00042C3C File Offset: 0x00040E3C
		public EventDescriptorCollection(EventDescriptor[] events, bool readOnly)
		{
		}

		// Token: 0x06001712 RID: 5906 RVA: 0x00042C4C File Offset: 0x00040E4C
		private EventDescriptorCollection(EventDescriptor[] events, int eventCount, string[] namedSort, IComparer comparer)
		{
			object obj;
			if (namedSort != null && obj != null)
			{
				if (obj != null)
				{
					this._namedSort = obj;
					if (obj != null)
					{
						goto IL_001F;
					}
				}
				throw new InvalidCastException();
			}
			IL_001F:
			this._comparer = comparer;
			this._events = events;
			this.System.Collections.ICollection.Count = eventCount;
			this._needSort = true;
		}

		// Token: 0x1700053D RID: 1341
		// (get) Token: 0x06001713 RID: 5907 RVA: 0x00042C98 File Offset: 0x00040E98
		// (set) Token: 0x06001714 RID: 5908 RVA: 0x00042CAC File Offset: 0x00040EAC
		public int Count
		{
			[CompilerGenerated]
			get
			{
				return this.<Count>k__BackingField;
			}
			[CompilerGenerated]
			private set
			{
				this.<Count>k__BackingField = value;
			}
		}

		// Token: 0x1700053E RID: 1342
		public virtual EventDescriptor this[int index]
		{
			get
			{
				/*
An exception occurred when decompiling this method (06001715)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.ComponentModel.EventDescriptor System.ComponentModel.EventDescriptorCollection::get_Item(System.Int32)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:int32(var_0_06, ldfld:int32(EventDescriptorCollection::<Count>k__BackingField, ldloc:EventDescriptorCollection(this)))
	call:void(EventDescriptorCollection::EnsureEventsOwned, ldloc:EventDescriptorCollection(this))
	stloc:int32(var_1_18, ldfld:int32(MemberDescriptor::nameHash, ldfld:class System.ComponentModel.EventDescriptor[][exp:MemberDescriptor](EventDescriptorCollection::_events, ldloc:EventDescriptorCollection(this))))
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

		// Token: 0x1700053F RID: 1343
		public virtual EventDescriptor this[string name]
		{
			get
			{
				throw new global::Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		// Token: 0x06001717 RID: 5911 RVA: 0x00042CE8 File Offset: 0x00040EE8
		public int Add(EventDescriptor value)
		{
			if (!this._readOnly)
			{
				int num = this.<Count>k__BackingField;
				EventDescriptor[] events = this._events;
				this.<Count>k__BackingField = num;
				if (value != null && value != null)
				{
					int num2 = this.<Count>k__BackingField;
				}
			}
			throw new ArrayTypeMismatchException();
		}

		// Token: 0x06001718 RID: 5912 RVA: 0x00042D24 File Offset: 0x00040F24
		public void Clear()
		{
		}

		// Token: 0x06001719 RID: 5913 RVA: 0x00042D34 File Offset: 0x00040F34
		public bool Contains(EventDescriptor value)
		{
			/*
An exception occurred when decompiling this method (06001719)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean System.ComponentModel.EventDescriptorCollection::Contains(System.ComponentModel.EventDescriptor)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:int32(var_0_07, call:int32(EventDescriptorCollection::IndexOf, ldloc:EventDescriptorCollection(this), ldloc:EventDescriptor(value)))
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

		// Token: 0x0600171A RID: 5914 RVA: 0x00042D48 File Offset: 0x00040F48
		void ICollection.CopyTo(Array array, int index)
		{
			this.EnsureEventsOwned();
			EventDescriptor[] events = this._events;
			int num = this.<Count>k__BackingField;
			long num2 = 0L;
			Array.Copy(events, (int)num2, array, index, num);
		}

		// Token: 0x0600171B RID: 5915 RVA: 0x00042D78 File Offset: 0x00040F78
		private void EnsureEventsOwned()
		{
			if (!this._eventsOwned)
			{
				EventDescriptor[] events = this._events;
				this._eventsOwned = true;
				if (events != null)
				{
					int num = this.<Count>k__BackingField;
					EventDescriptor[] events2 = this._events;
					int num2 = this.<Count>k__BackingField;
				}
			}
			if (this._needSort)
			{
				string[] namedSort = this._namedSort;
				this.InternalSort(namedSort);
				return;
			}
		}

		// Token: 0x0600171C RID: 5916 RVA: 0x00042DCC File Offset: 0x00040FCC
		private void EnsureSize(int sizeNeeded)
		{
			string displayName = this._events.displayName;
			if (displayName != null)
			{
				this.EnsureEventsOwned();
				EventDescriptor[] events = this._events;
				if (displayName == null)
				{
				}
				string displayName2 = events.displayName;
				int num = Math.Max(sizeNeeded, sizeNeeded);
				EventDescriptor[] events2 = this._events;
				int num2 = this.<Count>k__BackingField;
				return;
			}
		}

		// Token: 0x0600171D RID: 5917 RVA: 0x00042E18 File Offset: 0x00041018
		public virtual EventDescriptor Find(string name, bool ignoreCase)
		{
			/*
An exception occurred when decompiling this method (0600171D)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.ComponentModel.EventDescriptor System.ComponentModel.EventDescriptorCollection::Find(System.String,System.Boolean)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:int32(var_0_06, ldfld:int32(EventDescriptorCollection::<Count>k__BackingField, ldloc:EventDescriptorCollection(this)))
	stloc:class System.ComponentModel.EventDescriptor[](var_1_0D, ldfld:class System.ComponentModel.EventDescriptor[](EventDescriptorCollection::_events, ldloc:EventDescriptorCollection(this)))
	stloc:class System.ComponentModel.EventDescriptor[](var_3_14, ldfld:class System.ComponentModel.EventDescriptor[](EventDescriptorCollection::_events, ldloc:EventDescriptorCollection(this)))
	stloc:class System.ComponentModel.EventDescriptor[](var_6_1E, ldfld:class System.ComponentModel.EventDescriptor[](EventDescriptorCollection::_events, ldloc:EventDescriptorCollection(this)))
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

		// Token: 0x0600171E RID: 5918 RVA: 0x00042E44 File Offset: 0x00041044
		public int IndexOf(EventDescriptor value)
		{
			/*
An exception occurred when decompiling this method (0600171E)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Int32 System.ComponentModel.EventDescriptorCollection::IndexOf(System.ComponentModel.EventDescriptor)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:class System.ComponentModel.EventDescriptor[](var_0_06, ldfld:class System.ComponentModel.EventDescriptor[](EventDescriptorCollection::_events, ldloc:EventDescriptorCollection(this)))
	stloc:int32(var_1_0D, ldfld:int32(EventDescriptorCollection::<Count>k__BackingField, ldloc:EventDescriptorCollection(this)))
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

		// Token: 0x0600171F RID: 5919 RVA: 0x00042E60 File Offset: 0x00041060
		public void Insert(int index, EventDescriptor value)
		{
			if (!this._readOnly)
			{
				int num = this.<Count>k__BackingField;
				this.EnsureSize(index);
				int num2 = this.<Count>k__BackingField;
				EventDescriptor[] events = this._events;
				EventDescriptor[] events2 = this._events;
				if (value == null || value != null)
				{
					int num3 = this.<Count>k__BackingField;
					this.<Count>k__BackingField = num3;
					return;
				}
			}
			throw new ArrayTypeMismatchException();
		}

		// Token: 0x06001720 RID: 5920 RVA: 0x00042EB4 File Offset: 0x000410B4
		public void Remove(EventDescriptor value)
		{
			while (this._readOnly)
			{
			}
			int num = this.IndexOf(value);
			this.RemoveAt(num);
		}

		// Token: 0x06001721 RID: 5921 RVA: 0x00042EDC File Offset: 0x000410DC
		public void RemoveAt(int index)
		{
			while (this._readOnly)
			{
			}
			int num = this.<Count>k__BackingField;
			EventDescriptor[] events = this._events;
			int num2 = this.<Count>k__BackingField;
			EventDescriptor[] events2 = this._events;
			this.<Count>k__BackingField = num2;
		}

		// Token: 0x06001722 RID: 5922 RVA: 0x00042F14 File Offset: 0x00041114
		public IEnumerator GetEnumerator()
		{
			EventDescriptor[] events = this._events;
			int num = this.<Count>k__BackingField;
			string displayName = events.displayName;
			IEnumerator enumerator;
			return enumerator;
		}

		// Token: 0x06001723 RID: 5923 RVA: 0x00042F38 File Offset: 0x00041138
		public virtual EventDescriptorCollection Sort()
		{
			/*
An exception occurred when decompiling this method (06001723)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.ComponentModel.EventDescriptorCollection System.ComponentModel.EventDescriptorCollection::Sort()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:int32(var_0_06, ldfld:int32(EventDescriptorCollection::<Count>k__BackingField, ldloc:EventDescriptorCollection(this)))
	stloc:class System.ComponentModel.EventDescriptor[](var_1_0D, ldfld:class System.ComponentModel.EventDescriptor[](EventDescriptorCollection::_events, ldloc:EventDescriptorCollection(this)))
	stloc:string[](var_2_14, ldfld:string[](EventDescriptorCollection::_namedSort, ldloc:EventDescriptorCollection(this)))
	stloc:IComparer(var_3_1B, ldfld:IComparer(EventDescriptorCollection::_comparer, ldloc:EventDescriptorCollection(this)))
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

		// Token: 0x06001724 RID: 5924 RVA: 0x00042F60 File Offset: 0x00041160
		public virtual EventDescriptorCollection Sort(string[] names)
		{
			/*
An exception occurred when decompiling this method (06001724)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.ComponentModel.EventDescriptorCollection System.ComponentModel.EventDescriptorCollection::Sort(System.String[])

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:class System.ComponentModel.EventDescriptor[](var_0_06, ldfld:class System.ComponentModel.EventDescriptor[](EventDescriptorCollection::_events, ldloc:EventDescriptorCollection(this)))
	stloc:int32(var_1_0D, ldfld:int32(EventDescriptorCollection::<Count>k__BackingField, ldloc:EventDescriptorCollection(this)))
	stloc:IComparer(var_2_14, ldfld:IComparer(EventDescriptorCollection::_comparer, ldloc:EventDescriptorCollection(this)))
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

		// Token: 0x06001725 RID: 5925 RVA: 0x00042F84 File Offset: 0x00041184
		public virtual EventDescriptorCollection Sort(string[] names, IComparer comparer)
		{
			/*
An exception occurred when decompiling this method (06001725)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.ComponentModel.EventDescriptorCollection System.ComponentModel.EventDescriptorCollection::Sort(System.String[],System.Collections.IComparer)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:class System.ComponentModel.EventDescriptor[](var_0_06, ldfld:class System.ComponentModel.EventDescriptor[](EventDescriptorCollection::_events, ldloc:EventDescriptorCollection(this)))
	stloc:int32(var_1_0D, ldfld:int32(EventDescriptorCollection::<Count>k__BackingField, ldloc:EventDescriptorCollection(this)))
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

		// Token: 0x06001726 RID: 5926 RVA: 0x00042FA0 File Offset: 0x000411A0
		public virtual EventDescriptorCollection Sort(IComparer comparer)
		{
			/*
An exception occurred when decompiling this method (06001726)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.ComponentModel.EventDescriptorCollection System.ComponentModel.EventDescriptorCollection::Sort(System.Collections.IComparer)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:int32(var_0_06, ldfld:int32(EventDescriptorCollection::<Count>k__BackingField, ldloc:EventDescriptorCollection(this)))
	stloc:class System.ComponentModel.EventDescriptor[](var_1_0D, ldfld:class System.ComponentModel.EventDescriptor[](EventDescriptorCollection::_events, ldloc:EventDescriptorCollection(this)))
	stloc:string[](var_2_14, ldfld:string[](EventDescriptorCollection::_namedSort, ldloc:EventDescriptorCollection(this)))
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

		// Token: 0x06001727 RID: 5927 RVA: 0x00042FC4 File Offset: 0x000411C4
		protected void InternalSort(string[] names)
		{
			string displayName = this._events.displayName;
			if (displayName != null)
			{
				IComparer comparer = this._comparer;
				this.InternalSort(comparer);
				if (names != null && displayName != null)
				{
					EventDescriptor[] events = this._events;
					string displayName2 = this._events.displayName;
					return;
				}
			}
		}

		// Token: 0x06001728 RID: 5928 RVA: 0x00043028 File Offset: 0x00041228
		protected void InternalSort(IComparer sorter)
		{
			if (sorter != null)
			{
				Array.Sort(this._events, sorter);
				return;
			}
			TypeDescriptor.SortDescriptorArray(this);
		}

		// Token: 0x17000540 RID: 1344
		// (get) Token: 0x06001729 RID: 5929 RVA: 0x0004304C File Offset: 0x0004124C
		bool ICollection.IsSynchronized
		{
			get
			{
			}
		}

		// Token: 0x17000541 RID: 1345
		// (get) Token: 0x0600172A RID: 5930 RVA: 0x0004305C File Offset: 0x0004125C
		object ICollection.SyncRoot
		{
			get
			{
			}
		}

		// Token: 0x17000542 RID: 1346
		// (get) Token: 0x0600172B RID: 5931 RVA: 0x0004306C File Offset: 0x0004126C
		int ICollection.Count
		{
			get
			{
				return this.<Count>k__BackingField;
			}
		}

		// Token: 0x0600172C RID: 5932 RVA: 0x00043080 File Offset: 0x00041280
		IEnumerator IEnumerable.GetEnumerator()
		{
			return this.GetEnumerator();
		}

		// Token: 0x17000543 RID: 1347
		object IList.this[int index]
		{
			get
			{
				throw new global::Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
			set
			{
				if (this._readOnly)
				{
					return;
				}
				int num = this.<Count>k__BackingField;
				this.EnsureEventsOwned();
				EventDescriptor[] events = this._events;
				if (value == null || value != null)
				{
					return;
				}
				throw new ArrayTypeMismatchException();
			}
		}

		// Token: 0x0600172F RID: 5935 RVA: 0x000430D0 File Offset: 0x000412D0
		int IList.Add(object value)
		{
			if (value != null)
			{
			}
			int num;
			return num;
		}

		// Token: 0x06001730 RID: 5936 RVA: 0x000430E8 File Offset: 0x000412E8
		bool IList.Contains(object value)
		{
			if (value != null)
			{
			}
			throw new InvalidCastException();
		}

		// Token: 0x06001731 RID: 5937 RVA: 0x00043100 File Offset: 0x00041300
		void IList.Clear()
		{
			this.Clear();
		}

		// Token: 0x06001732 RID: 5938 RVA: 0x00043114 File Offset: 0x00041314
		int IList.IndexOf(object value)
		{
			if (value != null)
			{
			}
			int num;
			return num;
		}

		// Token: 0x06001733 RID: 5939 RVA: 0x0004312C File Offset: 0x0004132C
		void IList.Insert(int index, object value)
		{
			if (value != null)
			{
			}
		}

		// Token: 0x06001734 RID: 5940 RVA: 0x00043144 File Offset: 0x00041344
		void IList.Remove(object value)
		{
			if (value != null)
			{
			}
		}

		// Token: 0x06001735 RID: 5941 RVA: 0x0004315C File Offset: 0x0004135C
		void IList.RemoveAt(int index)
		{
			this.RemoveAt(index);
		}

		// Token: 0x17000544 RID: 1348
		// (get) Token: 0x06001736 RID: 5942 RVA: 0x00043170 File Offset: 0x00041370
		bool IList.IsReadOnly
		{
			get
			{
				return this._readOnly;
			}
		}

		// Token: 0x17000545 RID: 1349
		// (get) Token: 0x06001737 RID: 5943 RVA: 0x00043184 File Offset: 0x00041384
		bool IList.IsFixedSize
		{
			get
			{
				return this._readOnly;
			}
		}

		// Token: 0x06001738 RID: 5944 RVA: 0x00043198 File Offset: 0x00041398
		// Note: this type is marked as 'beforefieldinit'.
		static EventDescriptorCollection()
		{
		}

		// Token: 0x0400121B RID: 4635
		private EventDescriptor[] _events;

		// Token: 0x0400121C RID: 4636
		private string[] _namedSort;

		// Token: 0x0400121D RID: 4637
		private readonly IComparer _comparer;

		// Token: 0x0400121E RID: 4638
		private bool _eventsOwned;

		// Token: 0x0400121F RID: 4639
		private bool _needSort;

		// Token: 0x04001220 RID: 4640
		private readonly bool _readOnly;

		// Token: 0x04001221 RID: 4641
		public static readonly EventDescriptorCollection Empty;

		// Token: 0x04001222 RID: 4642
		[CompilerGenerated]
		private int <Count>k__BackingField;

		// Token: 0x02000375 RID: 885
		private class ArraySubsetEnumerator : IEnumerator
		{
			// Token: 0x06001739 RID: 5945 RVA: 0x000431A8 File Offset: 0x000413A8
			public ArraySubsetEnumerator(Array array, int count)
			{
				this._array = array;
				this._total = count;
			}

			// Token: 0x0600173A RID: 5946 RVA: 0x000431CC File Offset: 0x000413CC
			public bool MoveNext()
			{
				/*
An exception occurred when decompiling this method (0600173A)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean System.ComponentModel.EventDescriptorCollection/ArraySubsetEnumerator::MoveNext()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:int32(var_0_06, ldfld:int32(ArraySubsetEnumerator::_total, ldloc:ArraySubsetEnumerator(this)))
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

			// Token: 0x0600173B RID: 5947 RVA: 0x000431E4 File Offset: 0x000413E4
			public void Reset()
			{
			}

			// Token: 0x17000546 RID: 1350
			// (get) Token: 0x0600173C RID: 5948 RVA: 0x000431F4 File Offset: 0x000413F4
			public object Current
			{
				get
				{
					int current = this._current;
					return this._array.GetValue(current);
				}
			}

			// Token: 0x04001223 RID: 4643
			private readonly Array _array;

			// Token: 0x04001224 RID: 4644
			private readonly int _total;

			// Token: 0x04001225 RID: 4645
			private int _current;
		}
	}
}
