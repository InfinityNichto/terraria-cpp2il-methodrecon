using System;
using System.Collections;
using System.Runtime.CompilerServices;
using System.Threading;
using Cpp2IlInjected;

namespace System.ComponentModel
{
	// Token: 0x020003AD RID: 941
	public class PropertyDescriptorCollection : ICollection, IEnumerable, IList, IDictionary
	{
		// Token: 0x060018EF RID: 6383 RVA: 0x0004607C File Offset: 0x0004427C
		public PropertyDescriptorCollection(PropertyDescriptor[] properties)
		{
			if (properties != null)
			{
				this._properties = properties;
				string displayName = properties.displayName;
				return;
			}
			long num = 0L;
			this.System.Collections.ICollection.Count = (int)num;
			this._propsOwned = true;
		}

		// Token: 0x060018F0 RID: 6384 RVA: 0x000460B4 File Offset: 0x000442B4
		public PropertyDescriptorCollection(PropertyDescriptor[] properties, bool readOnly)
		{
		}

		// Token: 0x060018F1 RID: 6385 RVA: 0x000460C4 File Offset: 0x000442C4
		private PropertyDescriptorCollection(PropertyDescriptor[] properties, int propCount, string[] namedSort, IComparer comparer)
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
			this._properties = properties;
			this.System.Collections.ICollection.Count = propCount;
			this._needSort = true;
		}

		// Token: 0x170005B2 RID: 1458
		// (get) Token: 0x060018F2 RID: 6386 RVA: 0x00046110 File Offset: 0x00044310
		// (set) Token: 0x060018F3 RID: 6387 RVA: 0x00046124 File Offset: 0x00044324
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

		// Token: 0x170005B3 RID: 1459
		public virtual PropertyDescriptor this[int index]
		{
			get
			{
				/*
An exception occurred when decompiling this method (060018F4)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.ComponentModel.PropertyDescriptor System.ComponentModel.PropertyDescriptorCollection::get_Item(System.Int32)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:int32(var_0_06, ldfld:int32(PropertyDescriptorCollection::<Count>k__BackingField, ldloc:PropertyDescriptorCollection(this)))
	call:void(PropertyDescriptorCollection::EnsurePropsOwned, ldloc:PropertyDescriptorCollection(this))
	stloc:int32(var_1_18, ldfld:int32(MemberDescriptor::nameHash, ldfld:class System.ComponentModel.PropertyDescriptor[][exp:MemberDescriptor](PropertyDescriptorCollection::_properties, ldloc:PropertyDescriptorCollection(this))))
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

		// Token: 0x170005B4 RID: 1460
		public virtual PropertyDescriptor this[string name]
		{
			get
			{
				throw new global::Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		// Token: 0x060018F6 RID: 6390 RVA: 0x00046160 File Offset: 0x00044360
		public int Add(PropertyDescriptor value)
		{
			if (!this._readOnly)
			{
				int num = this.<Count>k__BackingField;
				PropertyDescriptor[] properties = this._properties;
				this.<Count>k__BackingField = num;
				if (value != null && value != null)
				{
					int num2 = this.<Count>k__BackingField;
				}
			}
			throw new ArrayTypeMismatchException();
		}

		// Token: 0x060018F7 RID: 6391 RVA: 0x0004619C File Offset: 0x0004439C
		public void Clear()
		{
			while (this._readOnly)
			{
			}
		}

		// Token: 0x060018F8 RID: 6392 RVA: 0x000461B4 File Offset: 0x000443B4
		public bool Contains(PropertyDescriptor value)
		{
			/*
An exception occurred when decompiling this method (060018F8)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean System.ComponentModel.PropertyDescriptorCollection::Contains(System.ComponentModel.PropertyDescriptor)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:int32(var_0_07, call:int32(PropertyDescriptorCollection::IndexOf, ldloc:PropertyDescriptorCollection(this), ldloc:PropertyDescriptor(value)))
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

		// Token: 0x060018F9 RID: 6393 RVA: 0x000461C8 File Offset: 0x000443C8
		public void CopyTo(Array array, int index)
		{
			this.EnsurePropsOwned();
			PropertyDescriptor[] properties = this._properties;
			int num = this.<Count>k__BackingField;
			long num2 = 0L;
			Array.Copy(properties, (int)num2, array, index, num);
		}

		// Token: 0x060018FA RID: 6394 RVA: 0x000461F8 File Offset: 0x000443F8
		private void EnsurePropsOwned()
		{
			if (!this._propsOwned)
			{
				PropertyDescriptor[] properties = this._properties;
				this._propsOwned = true;
				if (properties != null)
				{
					int num = this.<Count>k__BackingField;
					PropertyDescriptor[] properties2 = this._properties;
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

		// Token: 0x060018FB RID: 6395 RVA: 0x0004624C File Offset: 0x0004444C
		private void EnsureSize(int sizeNeeded)
		{
			string displayName = this._properties.displayName;
			if (displayName != null)
			{
				this.EnsurePropsOwned();
				PropertyDescriptor[] properties = this._properties;
				if (displayName == null)
				{
				}
				string displayName2 = properties.displayName;
				int num = Math.Max(sizeNeeded, sizeNeeded);
				PropertyDescriptor[] properties2 = this._properties;
				int num2 = this.<Count>k__BackingField;
				return;
			}
		}

		// Token: 0x060018FC RID: 6396 RVA: 0x00046298 File Offset: 0x00044498
		public virtual PropertyDescriptor Find(string name, bool ignoreCase)
		{
			object internalSyncObject = this._internalSyncObject;
			bool cachedIgnoreCase;
			if (this._cachedFoundProperties != null)
			{
				cachedIgnoreCase = this._cachedIgnoreCase;
			}
			this._cachedIgnoreCase = cachedIgnoreCase;
			if (!cachedIgnoreCase)
			{
			}
			if (!true)
			{
			}
			int num = this.<Count>k__BackingField;
			PropertyDescriptor[] properties = this._properties;
			long num2 = 0L;
			if (properties != null)
			{
				Monitor.Exit(internalSyncObject);
			}
			if (num2 == 0L)
			{
				IDictionary cachedFoundProperties = this._cachedFoundProperties;
				if (this._properties != null)
				{
				}
				IDictionary cachedFoundProperties2 = this._cachedFoundProperties;
				if (this._properties != null)
				{
				}
				PropertyDescriptor[] properties2 = this._properties;
				throw new InvalidCastException();
			}
			throw new OutOfMemoryException();
		}

		// Token: 0x060018FD RID: 6397 RVA: 0x00046334 File Offset: 0x00044534
		public int IndexOf(PropertyDescriptor value)
		{
			/*
An exception occurred when decompiling this method (060018FD)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Int32 System.ComponentModel.PropertyDescriptorCollection::IndexOf(System.ComponentModel.PropertyDescriptor)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:class System.ComponentModel.PropertyDescriptor[](var_0_06, ldfld:class System.ComponentModel.PropertyDescriptor[](PropertyDescriptorCollection::_properties, ldloc:PropertyDescriptorCollection(this)))
	stloc:int32(var_1_0D, ldfld:int32(PropertyDescriptorCollection::<Count>k__BackingField, ldloc:PropertyDescriptorCollection(this)))
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

		// Token: 0x060018FE RID: 6398 RVA: 0x00046350 File Offset: 0x00044550
		public void Insert(int index, PropertyDescriptor value)
		{
			if (!this._readOnly)
			{
				int num = this.<Count>k__BackingField;
				this.EnsureSize(index);
				int num2 = this.<Count>k__BackingField;
				PropertyDescriptor[] properties = this._properties;
				PropertyDescriptor[] properties2 = this._properties;
				if (value == null || value != null)
				{
					int num3 = this.<Count>k__BackingField;
					this.<Count>k__BackingField = num3;
					return;
				}
			}
			throw new ArrayTypeMismatchException();
		}

		// Token: 0x060018FF RID: 6399 RVA: 0x000463A4 File Offset: 0x000445A4
		public void Remove(PropertyDescriptor value)
		{
			while (this._readOnly)
			{
			}
			int num = this.IndexOf(value);
			this.RemoveAt(num);
		}

		// Token: 0x06001900 RID: 6400 RVA: 0x000463CC File Offset: 0x000445CC
		public void RemoveAt(int index)
		{
			while (this._readOnly)
			{
			}
			int num = this.<Count>k__BackingField;
			PropertyDescriptor[] properties = this._properties;
			int num2 = this.<Count>k__BackingField;
			PropertyDescriptor[] properties2 = this._properties;
			this.<Count>k__BackingField = num2;
		}

		// Token: 0x06001901 RID: 6401 RVA: 0x00046404 File Offset: 0x00044604
		public virtual PropertyDescriptorCollection Sort()
		{
			/*
An exception occurred when decompiling this method (06001901)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.ComponentModel.PropertyDescriptorCollection System.ComponentModel.PropertyDescriptorCollection::Sort()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:int32(var_0_06, ldfld:int32(PropertyDescriptorCollection::<Count>k__BackingField, ldloc:PropertyDescriptorCollection(this)))
	stloc:class System.ComponentModel.PropertyDescriptor[](var_1_0D, ldfld:class System.ComponentModel.PropertyDescriptor[](PropertyDescriptorCollection::_properties, ldloc:PropertyDescriptorCollection(this)))
	stloc:string[](var_2_14, ldfld:string[](PropertyDescriptorCollection::_namedSort, ldloc:PropertyDescriptorCollection(this)))
	stloc:IComparer(var_3_1B, ldfld:IComparer(PropertyDescriptorCollection::_comparer, ldloc:PropertyDescriptorCollection(this)))
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

		// Token: 0x06001902 RID: 6402 RVA: 0x0004642C File Offset: 0x0004462C
		public virtual PropertyDescriptorCollection Sort(string[] names)
		{
			/*
An exception occurred when decompiling this method (06001902)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.ComponentModel.PropertyDescriptorCollection System.ComponentModel.PropertyDescriptorCollection::Sort(System.String[])

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:class System.ComponentModel.PropertyDescriptor[](var_0_06, ldfld:class System.ComponentModel.PropertyDescriptor[](PropertyDescriptorCollection::_properties, ldloc:PropertyDescriptorCollection(this)))
	stloc:int32(var_1_0D, ldfld:int32(PropertyDescriptorCollection::<Count>k__BackingField, ldloc:PropertyDescriptorCollection(this)))
	stloc:IComparer(var_2_14, ldfld:IComparer(PropertyDescriptorCollection::_comparer, ldloc:PropertyDescriptorCollection(this)))
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

		// Token: 0x06001903 RID: 6403 RVA: 0x00046450 File Offset: 0x00044650
		public virtual PropertyDescriptorCollection Sort(string[] names, IComparer comparer)
		{
			/*
An exception occurred when decompiling this method (06001903)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.ComponentModel.PropertyDescriptorCollection System.ComponentModel.PropertyDescriptorCollection::Sort(System.String[],System.Collections.IComparer)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:class System.ComponentModel.PropertyDescriptor[](var_0_06, ldfld:class System.ComponentModel.PropertyDescriptor[](PropertyDescriptorCollection::_properties, ldloc:PropertyDescriptorCollection(this)))
	stloc:int32(var_1_0D, ldfld:int32(PropertyDescriptorCollection::<Count>k__BackingField, ldloc:PropertyDescriptorCollection(this)))
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

		// Token: 0x06001904 RID: 6404 RVA: 0x0004646C File Offset: 0x0004466C
		public virtual PropertyDescriptorCollection Sort(IComparer comparer)
		{
			/*
An exception occurred when decompiling this method (06001904)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.ComponentModel.PropertyDescriptorCollection System.ComponentModel.PropertyDescriptorCollection::Sort(System.Collections.IComparer)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:int32(var_0_06, ldfld:int32(PropertyDescriptorCollection::<Count>k__BackingField, ldloc:PropertyDescriptorCollection(this)))
	stloc:class System.ComponentModel.PropertyDescriptor[](var_1_0D, ldfld:class System.ComponentModel.PropertyDescriptor[](PropertyDescriptorCollection::_properties, ldloc:PropertyDescriptorCollection(this)))
	stloc:string[](var_2_14, ldfld:string[](PropertyDescriptorCollection::_namedSort, ldloc:PropertyDescriptorCollection(this)))
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

		// Token: 0x06001905 RID: 6405 RVA: 0x00046490 File Offset: 0x00044690
		protected void InternalSort(string[] names)
		{
			string displayName = this._properties.displayName;
			if (displayName != null)
			{
				IComparer comparer = this._comparer;
				this.InternalSort(comparer);
				if (names != null && displayName != null)
				{
					PropertyDescriptor[] properties = this._properties;
					string displayName2 = this._properties.displayName;
					return;
				}
			}
		}

		// Token: 0x06001906 RID: 6406 RVA: 0x000464F4 File Offset: 0x000446F4
		protected void InternalSort(IComparer sorter)
		{
			if (sorter != null)
			{
				Array.Sort(this._properties, sorter);
				return;
			}
			TypeDescriptor.SortDescriptorArray(this);
		}

		// Token: 0x06001907 RID: 6407 RVA: 0x00046518 File Offset: 0x00044718
		public virtual IEnumerator GetEnumerator()
		{
			this.EnsurePropsOwned();
			PropertyDescriptor[] properties = this._properties;
			int num = this.<Count>k__BackingField;
			string displayName = properties.displayName;
			PropertyDescriptor[] properties2 = this._properties;
			int num2 = this.<Count>k__BackingField;
			IEnumerator enumerator;
			return enumerator;
		}

		// Token: 0x170005B5 RID: 1461
		// (get) Token: 0x06001908 RID: 6408 RVA: 0x00046554 File Offset: 0x00044754
		bool ICollection.IsSynchronized
		{
			get
			{
			}
		}

		// Token: 0x170005B6 RID: 1462
		// (get) Token: 0x06001909 RID: 6409 RVA: 0x00046564 File Offset: 0x00044764
		object ICollection.SyncRoot
		{
			get
			{
			}
		}

		// Token: 0x170005B7 RID: 1463
		// (get) Token: 0x0600190A RID: 6410 RVA: 0x00046574 File Offset: 0x00044774
		int ICollection.Count
		{
			get
			{
				return this.<Count>k__BackingField;
			}
		}

		// Token: 0x0600190B RID: 6411 RVA: 0x00046588 File Offset: 0x00044788
		void IList.Clear()
		{
			this.Clear();
		}

		// Token: 0x0600190C RID: 6412 RVA: 0x0004659C File Offset: 0x0004479C
		void IDictionary.Clear()
		{
			this.Clear();
		}

		// Token: 0x0600190D RID: 6413 RVA: 0x00002050 File Offset: 0x00000250
		IEnumerator IEnumerable.GetEnumerator()
		{
			throw new global::Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x0600190E RID: 6414 RVA: 0x000465B0 File Offset: 0x000447B0
		void IList.RemoveAt(int index)
		{
			this.RemoveAt(index);
		}

		// Token: 0x0600190F RID: 6415 RVA: 0x000465C4 File Offset: 0x000447C4
		void IDictionary.Add(object key, object value)
		{
			while (value == null)
			{
			}
		}

		// Token: 0x06001910 RID: 6416 RVA: 0x000465D4 File Offset: 0x000447D4
		bool IDictionary.Contains(object key)
		{
			if (key != null)
			{
				return;
			}
		}

		// Token: 0x06001911 RID: 6417 RVA: 0x00002050 File Offset: 0x00000250
		IDictionaryEnumerator IDictionary.GetEnumerator()
		{
			throw new global::Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x170005B8 RID: 1464
		// (get) Token: 0x06001912 RID: 6418 RVA: 0x000465E8 File Offset: 0x000447E8
		bool IDictionary.IsFixedSize
		{
			get
			{
				return this._readOnly;
			}
		}

		// Token: 0x170005B9 RID: 1465
		// (get) Token: 0x06001913 RID: 6419 RVA: 0x000465FC File Offset: 0x000447FC
		bool IDictionary.IsReadOnly
		{
			get
			{
				return this._readOnly;
			}
		}

		// Token: 0x170005BA RID: 1466
		object IDictionary.this[object key]
		{
			get
			{
				if (key != null)
				{
					return;
				}
			}
			set
			{
				if (this._readOnly)
				{
					throw new ArrayTypeMismatchException();
				}
				if (value != null)
				{
				}
				if (key != null)
				{
					int num = this.<Count>k__BackingField;
					int nameHash = this._properties.nameHash;
					return;
				}
			}
		}

		// Token: 0x170005BB RID: 1467
		// (get) Token: 0x06001916 RID: 6422 RVA: 0x0004668C File Offset: 0x0004488C
		ICollection IDictionary.Keys
		{
			get
			{
				int num = this.<Count>k__BackingField;
				int num2 = this.<Count>k__BackingField;
				PropertyDescriptor[] properties = this._properties;
				throw new ArrayTypeMismatchException();
			}
		}

		// Token: 0x170005BC RID: 1468
		// (get) Token: 0x06001917 RID: 6423 RVA: 0x000466B4 File Offset: 0x000448B4
		ICollection IDictionary.Values
		{
			get
			{
				object obj;
				do
				{
					PropertyDescriptor[] properties = this._properties;
					int num = this.<Count>k__BackingField;
					string displayName = properties.displayName;
					if (obj == null)
					{
						return;
					}
				}
				while (obj != null);
				throw new InvalidCastException();
			}
		}

		// Token: 0x06001918 RID: 6424 RVA: 0x000466E4 File Offset: 0x000448E4
		void IDictionary.Remove(object key)
		{
			if (key != null)
			{
			}
		}

		// Token: 0x06001919 RID: 6425 RVA: 0x000466FC File Offset: 0x000448FC
		int IList.Add(object value)
		{
			if (value != null)
			{
			}
			int num;
			return num;
		}

		// Token: 0x0600191A RID: 6426 RVA: 0x00046714 File Offset: 0x00044914
		bool IList.Contains(object value)
		{
			if (value != null)
			{
			}
			throw new InvalidCastException();
		}

		// Token: 0x0600191B RID: 6427 RVA: 0x0004672C File Offset: 0x0004492C
		int IList.IndexOf(object value)
		{
			if (value != null)
			{
			}
			int num;
			return num;
		}

		// Token: 0x0600191C RID: 6428 RVA: 0x00046744 File Offset: 0x00044944
		void IList.Insert(int index, object value)
		{
			if (value != null)
			{
			}
		}

		// Token: 0x170005BD RID: 1469
		// (get) Token: 0x0600191D RID: 6429 RVA: 0x0004675C File Offset: 0x0004495C
		bool IList.IsReadOnly
		{
			get
			{
				return this._readOnly;
			}
		}

		// Token: 0x170005BE RID: 1470
		// (get) Token: 0x0600191E RID: 6430 RVA: 0x00046770 File Offset: 0x00044970
		bool IList.IsFixedSize
		{
			get
			{
				return this._readOnly;
			}
		}

		// Token: 0x0600191F RID: 6431 RVA: 0x00046784 File Offset: 0x00044984
		void IList.Remove(object value)
		{
			if (value != null)
			{
			}
		}

		// Token: 0x170005BF RID: 1471
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
				if (value != null)
				{
				}
				this.EnsurePropsOwned();
				PropertyDescriptor[] properties = this._properties;
				if (value == null || value != null)
				{
					return;
				}
				throw new ArrayTypeMismatchException();
			}
		}

		// Token: 0x06001922 RID: 6434 RVA: 0x000467DC File Offset: 0x000449DC
		// Note: this type is marked as 'beforefieldinit'.
		static PropertyDescriptorCollection()
		{
		}

		// Token: 0x040012A6 RID: 4774
		public static readonly PropertyDescriptorCollection Empty;

		// Token: 0x040012A7 RID: 4775
		private IDictionary _cachedFoundProperties;

		// Token: 0x040012A8 RID: 4776
		private bool _cachedIgnoreCase;

		// Token: 0x040012A9 RID: 4777
		private PropertyDescriptor[] _properties;

		// Token: 0x040012AA RID: 4778
		private readonly string[] _namedSort;

		// Token: 0x040012AB RID: 4779
		private readonly IComparer _comparer;

		// Token: 0x040012AC RID: 4780
		private bool _propsOwned;

		// Token: 0x040012AD RID: 4781
		private bool _needSort;

		// Token: 0x040012AE RID: 4782
		private bool _readOnly;

		// Token: 0x040012AF RID: 4783
		private readonly object _internalSyncObject;

		// Token: 0x040012B0 RID: 4784
		[CompilerGenerated]
		private int <Count>k__BackingField;

		// Token: 0x020003AE RID: 942
		private class PropertyDescriptorEnumerator : IDictionaryEnumerator, IEnumerator
		{
			// Token: 0x06001923 RID: 6435 RVA: 0x000467EC File Offset: 0x000449EC
			public PropertyDescriptorEnumerator(PropertyDescriptorCollection owner)
			{
				this._owner = owner;
			}

			// Token: 0x170005C0 RID: 1472
			// (get) Token: 0x06001924 RID: 6436 RVA: 0x00046808 File Offset: 0x00044A08
			public object Current
			{
				get
				{
					/*
An exception occurred when decompiling this method (06001924)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Object System.ComponentModel.PropertyDescriptorCollection/PropertyDescriptorEnumerator::get_Current()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:DictionaryEntry(var_0_06, callgetter:DictionaryEntry(PropertyDescriptorEnumerator::get_Entry, ldloc:PropertyDescriptorEnumerator(this)))
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

			// Token: 0x170005C1 RID: 1473
			// (get) Token: 0x06001925 RID: 6437 RVA: 0x0004681C File Offset: 0x00044A1C
			public DictionaryEntry Entry
			{
				get
				{
					/*
An exception occurred when decompiling this method (06001925)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Collections.DictionaryEntry System.ComponentModel.PropertyDescriptorCollection/PropertyDescriptorEnumerator::get_Entry()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:PropertyDescriptorCollection(var_0_06, ldfld:PropertyDescriptorCollection(PropertyDescriptorEnumerator::_owner, ldloc:PropertyDescriptorEnumerator(this)))
	stloc:int32(var_1_0D, ldfld:int32(PropertyDescriptorEnumerator::_index, ldloc:PropertyDescriptorEnumerator(this)))
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

			// Token: 0x170005C2 RID: 1474
			// (get) Token: 0x06001926 RID: 6438 RVA: 0x00046838 File Offset: 0x00044A38
			public object Key
			{
				get
				{
					/*
An exception occurred when decompiling this method (06001926)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Object System.ComponentModel.PropertyDescriptorCollection/PropertyDescriptorEnumerator::get_Key()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:PropertyDescriptorCollection(var_0_06, ldfld:PropertyDescriptorCollection(PropertyDescriptorEnumerator::_owner, ldloc:PropertyDescriptorEnumerator(this)))
	stloc:int32(var_1_0D, ldfld:int32(PropertyDescriptorEnumerator::_index, ldloc:PropertyDescriptorEnumerator(this)))
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

			// Token: 0x170005C3 RID: 1475
			// (get) Token: 0x06001927 RID: 6439 RVA: 0x00046854 File Offset: 0x00044A54
			public object Value
			{
				get
				{
					/*
An exception occurred when decompiling this method (06001927)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Object System.ComponentModel.PropertyDescriptorCollection/PropertyDescriptorEnumerator::get_Value()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:PropertyDescriptorCollection(var_0_06, ldfld:PropertyDescriptorCollection(PropertyDescriptorEnumerator::_owner, ldloc:PropertyDescriptorEnumerator(this)))
	stloc:int32(var_1_0D, ldfld:int32(PropertyDescriptorEnumerator::_index, ldloc:PropertyDescriptorEnumerator(this)))
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

			// Token: 0x06001928 RID: 6440 RVA: 0x00046870 File Offset: 0x00044A70
			public bool MoveNext()
			{
				/*
An exception occurred when decompiling this method (06001928)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean System.ComponentModel.PropertyDescriptorCollection/PropertyDescriptorEnumerator::MoveNext()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:int32(var_0_0B, ldfld:int32(PropertyDescriptorCollection::<Count>k__BackingField, ldfld:PropertyDescriptorCollection(PropertyDescriptorEnumerator::_owner, ldloc:PropertyDescriptorEnumerator(this))))
	stloc:int32(var_1_12, ldfld:int32(PropertyDescriptorEnumerator::_index, ldloc:PropertyDescriptorEnumerator(this)))
	stfld:int32(PropertyDescriptorEnumerator::_index, ldloc:PropertyDescriptorEnumerator(this), ldloc:int32(var_1_12))
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

			// Token: 0x06001929 RID: 6441 RVA: 0x0004689C File Offset: 0x00044A9C
			public void Reset()
			{
			}

			// Token: 0x040012B1 RID: 4785
			private PropertyDescriptorCollection _owner;

			// Token: 0x040012B2 RID: 4786
			private int _index;
		}
	}
}
