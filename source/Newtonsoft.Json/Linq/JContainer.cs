using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Threading;
using Cpp2IlInjected;
using Newtonsoft.Json.Shims;
using Newtonsoft.Json.Utilities;

namespace Newtonsoft.Json.Linq
{
	// Token: 0x020000CC RID: 204
	[Preserve]
	public abstract class JContainer : JToken, IList<JToken>, ICollection<JToken>, IEnumerable<JToken>, IEnumerable, ITypedList, IBindingList, IList, ICollection
	{
		// Token: 0x14000005 RID: 5
		// (add) Token: 0x0600073F RID: 1855 RVA: 0x00012AE0 File Offset: 0x00010CE0
		// (remove) Token: 0x06000740 RID: 1856 RVA: 0x00012B14 File Offset: 0x00010D14
		public event ListChangedEventHandler ListChanged
		{
			add
			{
				Delegate @delegate = Delegate.Combine(this._listChanged, value);
				if (@delegate != null)
				{
					this._listChanged = @delegate;
					throw new InvalidCastException();
				}
				this._listChanged = @delegate;
			}
			remove
			{
				Delegate @delegate = Delegate.Remove(this._listChanged, value);
				if (@delegate != null)
				{
					this._listChanged = @delegate;
					throw new InvalidCastException();
				}
				this._listChanged = @delegate;
			}
		}

		// Token: 0x14000006 RID: 6
		// (add) Token: 0x06000741 RID: 1857 RVA: 0x00012B48 File Offset: 0x00010D48
		// (remove) Token: 0x06000742 RID: 1858 RVA: 0x00012B7C File Offset: 0x00010D7C
		public event global::System.ComponentModel.AddingNewEventHandler AddingNew
		{
			add
			{
				Delegate @delegate = Delegate.Combine(this._addingNew, value);
				if (@delegate != null)
				{
					this._addingNew = @delegate;
					throw new InvalidCastException();
				}
				this._addingNew = @delegate;
			}
			remove
			{
				Delegate @delegate = Delegate.Remove(this._addingNew, value);
				if (@delegate != null)
				{
					this._addingNew = @delegate;
					throw new InvalidCastException();
				}
				this._addingNew = @delegate;
			}
		}

		// Token: 0x1700015F RID: 351
		// (get) Token: 0x06000743 RID: 1859
		protected abstract IList<JToken> ChildrenTokens { get; }

		// Token: 0x06000744 RID: 1860 RVA: 0x00012BB0 File Offset: 0x00010DB0
		internal JContainer()
		{
			if (!true)
			{
			}
			base..ctor();
		}

		// Token: 0x06000745 RID: 1861 RVA: 0x00012BC8 File Offset: 0x00010DC8
		internal JContainer(JContainer other)
		{
			ValidationUtils.ArgumentNotNull(other, "other");
		}

		// Token: 0x06000746 RID: 1862 RVA: 0x00012C1C File Offset: 0x00010E1C
		internal void CheckReentrancy()
		{
			/*
An exception occurred when decompiling this method (06000746)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Void Newtonsoft.Json.Linq.JContainer::CheckReentrancy()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0009:
	stloc:CultureInfo(var_1_10, callgetter:CultureInfo(CultureInfo::get_InvariantCulture))
	stloc:Type(var_2_17, call:Type(object::GetType, ldloc:JContainer[exp:object](this)))
	stloc:string(var_3_24, call:string(StringUtils::FormatWith, ldstr:string("Cannot change {0} during a collection change event."), ldloc:CultureInfo[exp:IFormatProvider](var_1_10), ldloc:Type[exp:object](var_2_17)))
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

		// Token: 0x06000747 RID: 1863 RVA: 0x0000212A File Offset: 0x0000032A
		internal virtual IList<JToken> CreateChildrenCollection()
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06000748 RID: 1864 RVA: 0x00012C50 File Offset: 0x00010E50
		protected virtual void OnAddingNew(global::System.ComponentModel.AddingNewEventArgs e)
		{
			global::System.ComponentModel.AddingNewEventHandler addingNew = this._addingNew;
			if (addingNew != null)
			{
				IntPtr invoke_impl = addingNew.invoke_impl;
				IntPtr method_code = addingNew.method_code;
				IntPtr method = addingNew.method;
				return;
			}
		}

		// Token: 0x06000749 RID: 1865 RVA: 0x00012C80 File Offset: 0x00010E80
		protected virtual void OnListChanged(ListChangedEventArgs e)
		{
			ListChangedEventHandler listChanged = this._listChanged;
			if (listChanged != null)
			{
				this._busy = true;
				IntPtr method_code = listChanged.method_code;
				IntPtr invoke_impl = listChanged.invoke_impl;
				IntPtr method = listChanged.method;
			}
		}

		// Token: 0x17000160 RID: 352
		// (get) Token: 0x0600074A RID: 1866 RVA: 0x0000212A File Offset: 0x0000032A
		public override bool HasValues
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		// Token: 0x0600074B RID: 1867 RVA: 0x00012CC0 File Offset: 0x00010EC0
		internal bool ContentsEqual(JContainer container)
		{
		}

		// Token: 0x17000161 RID: 353
		// (get) Token: 0x0600074C RID: 1868 RVA: 0x00012CD0 File Offset: 0x00010ED0
		public override JToken First
		{
			get
			{
				/*
An exception occurred when decompiling this method (0600074C)

ICSharpCode.Decompiler.DecompilerException: Error decompiling Newtonsoft.Json.Linq.JToken Newtonsoft.Json.Linq.JContainer::get_First()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:int64(var_0_06, ldfld:int64(int64::m_value, ldc.i4:int32[exp:int64&](0)))
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

		// Token: 0x17000162 RID: 354
		// (get) Token: 0x0600074D RID: 1869 RVA: 0x00012CE4 File Offset: 0x00010EE4
		public override JToken Last
		{
			get
			{
				/*
An exception occurred when decompiling this method (0600074D)

ICSharpCode.Decompiler.DecompilerException: Error decompiling Newtonsoft.Json.Linq.JToken Newtonsoft.Json.Linq.JContainer::get_Last()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:int64(var_0_06, ldfld:int64(int64::m_value, ldc.i4:int32[exp:int64&](0)))
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

		// Token: 0x0600074E RID: 1870 RVA: 0x0000212A File Offset: 0x0000032A
		public override JEnumerable<JToken> Children()
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x0600074F RID: 1871 RVA: 0x0000212A File Offset: 0x0000032A
		public override IEnumerable<T> Values<T>()
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06000750 RID: 1872 RVA: 0x00012CF8 File Offset: 0x00010EF8
		public IEnumerable<JToken> Descendants()
		{
			long num = 0L;
			return this.GetDescendants(num != 0L);
		}

		// Token: 0x06000751 RID: 1873 RVA: 0x00012D10 File Offset: 0x00010F10
		public IEnumerable<JToken> DescendantsAndSelf()
		{
			return this.GetDescendants(true);
		}

		// Token: 0x06000752 RID: 1874 RVA: 0x0000212A File Offset: 0x0000032A
		internal IEnumerable<JToken> GetDescendants(bool self)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06000753 RID: 1875 RVA: 0x00012D24 File Offset: 0x00010F24
		internal bool IsMultiContent(object content)
		{
			while (content == null)
			{
			}
			if (content != null)
			{
				return;
			}
		}

		// Token: 0x06000754 RID: 1876 RVA: 0x00012D38 File Offset: 0x00010F38
		internal JToken EnsureParentToken(JToken item, bool skipParentCheck)
		{
			while (item == null)
			{
				JValue jvalue = JValue.CreateNull();
				if (item._parent != null)
				{
				}
				JContainer parent = jvalue._parent;
				if (parent == null || parent._parent == null)
				{
					return item;
				}
			}
			return item;
		}

		// Token: 0x06000755 RID: 1877
		internal abstract int IndexOfItem(JToken item);

		// Token: 0x06000756 RID: 1878 RVA: 0x00012D70 File Offset: 0x00010F70
		internal virtual void InsertItem(int index, JToken item, bool skipParentCheck)
		{
		}

		// Token: 0x06000757 RID: 1879 RVA: 0x00012DC8 File Offset: 0x00010FC8
		internal virtual void RemoveItemAt(int index)
		{
		}

		// Token: 0x06000758 RID: 1880 RVA: 0x00012E08 File Offset: 0x00011008
		internal virtual bool RemoveItem(JToken item)
		{
			return true;
		}

		// Token: 0x06000759 RID: 1881 RVA: 0x0000212A File Offset: 0x0000032A
		internal virtual JToken GetItem(int index)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x0600075A RID: 1882 RVA: 0x00012E18 File Offset: 0x00011018
		internal virtual void SetItem(int index, JToken item)
		{
		}

		// Token: 0x0600075B RID: 1883 RVA: 0x00012E34 File Offset: 0x00011034
		internal virtual void ClearItems()
		{
			this.CheckReentrancy();
		}

		// Token: 0x0600075C RID: 1884 RVA: 0x00012E74 File Offset: 0x00011074
		internal virtual void ReplaceItem(JToken existing, JToken replacement)
		{
			if (existing != null)
			{
				JContainer parent = existing._parent;
			}
		}

		// Token: 0x0600075D RID: 1885 RVA: 0x0000212A File Offset: 0x0000032A
		internal virtual bool ContainsItem(JToken item)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x0600075E RID: 1886 RVA: 0x00012E8C File Offset: 0x0001108C
		internal virtual void CopyItemsTo(Array array, int arrayIndex)
		{
			int count = this.Count;
		}

		// Token: 0x0600075F RID: 1887 RVA: 0x00012ED4 File Offset: 0x000110D4
		internal static bool IsTokenUnchanged(JToken currentValue, JToken newValue)
		{
			while (currentValue != null)
			{
			}
		}

		// Token: 0x06000760 RID: 1888 RVA: 0x00012EE8 File Offset: 0x000110E8
		internal virtual void ValidateToken(JToken o, JToken existing)
		{
			ValidationUtils.ArgumentNotNull(o, "o");
		}

		// Token: 0x06000761 RID: 1889 RVA: 0x00012F28 File Offset: 0x00011128
		public virtual void Add(object content)
		{
		}

		// Token: 0x06000762 RID: 1890 RVA: 0x00012F38 File Offset: 0x00011138
		internal void AddAndSkipParentCheck(JToken token)
		{
		}

		// Token: 0x06000763 RID: 1891 RVA: 0x00012F48 File Offset: 0x00011148
		public void AddFirst(object content)
		{
			long num = 0L;
			long num2 = 0L;
			this.AddInternal((int)num, content, num2 != 0L);
		}

		// Token: 0x06000764 RID: 1892 RVA: 0x00012F64 File Offset: 0x00011164
		internal void AddInternal(int index, object content, bool skipParentCheck)
		{
			if (content == null)
			{
				return;
			}
			if (content != null && content != null)
			{
				return;
			}
			throw new InvalidCastException();
		}

		// Token: 0x06000765 RID: 1893 RVA: 0x0000212A File Offset: 0x0000032A
		internal static JToken CreateFromContent(object content)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06000766 RID: 1894 RVA: 0x0000212A File Offset: 0x0000032A
		public JsonWriter CreateWriter()
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06000767 RID: 1895 RVA: 0x00012FEC File Offset: 0x000111EC
		public void ReplaceAll(object content)
		{
		}

		// Token: 0x06000768 RID: 1896 RVA: 0x00012FFC File Offset: 0x000111FC
		public void RemoveAll()
		{
		}

		// Token: 0x06000769 RID: 1897
		internal abstract void MergeItem(object content, JsonMergeSettings settings);

		// Token: 0x0600076A RID: 1898 RVA: 0x0001300C File Offset: 0x0001120C
		public void Merge(object content)
		{
		}

		// Token: 0x0600076B RID: 1899 RVA: 0x0001301C File Offset: 0x0001121C
		public void Merge(object content, JsonMergeSettings settings)
		{
		}

		// Token: 0x0600076C RID: 1900 RVA: 0x0001302C File Offset: 0x0001122C
		internal void ReadTokenFrom(JsonReader reader, JsonLoadSettings options)
		{
			this.ReadContentFrom(reader, options);
		}

		// Token: 0x0600076D RID: 1901 RVA: 0x0001307C File Offset: 0x0001127C
		internal void ReadContentFrom(JsonReader r, JsonLoadSettings settings)
		{
			ValidationUtils.ArgumentNotNull(r, "r");
			JToken jtoken;
			if (this != null && jtoken != null)
			{
				JContainer parent = this._parent;
			}
		}

		// Token: 0x0600076E RID: 1902 RVA: 0x000130E8 File Offset: 0x000112E8
		internal int ContentsHashCode()
		{
			long num = 0L;
			if (this != null)
			{
			}
			if (num == 0L)
			{
			}
			throw new OutOfMemoryException();
		}

		// Token: 0x0600076F RID: 1903 RVA: 0x0000212A File Offset: 0x0000032A
		string ITypedList.GetListName(PropertyDescriptor[] listAccessors)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06000770 RID: 1904 RVA: 0x0001311C File Offset: 0x0001131C
		PropertyDescriptorCollection ITypedList.GetItemProperties(PropertyDescriptor[] listAccessors)
		{
			/*
An exception occurred when decompiling this method (06000770)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.ComponentModel.PropertyDescriptorCollection Newtonsoft.Json.Linq.JContainer::System.ComponentModel.ITypedList.GetItemProperties(System.ComponentModel.PropertyDescriptor[])

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0000:
	brtrue(IL_0000, logicnot:bool(ldloc:JContainer[exp:bool](this)))
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

		// Token: 0x06000771 RID: 1905 RVA: 0x0000212A File Offset: 0x0000032A
		int IList<JToken>.IndexOf(JToken item)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06000772 RID: 1906 RVA: 0x0001312C File Offset: 0x0001132C
		void IList<JToken>.Insert(int index, JToken item)
		{
		}

		// Token: 0x06000773 RID: 1907 RVA: 0x0001313C File Offset: 0x0001133C
		void IList<JToken>.RemoveAt(int index)
		{
		}

		// Token: 0x17000163 RID: 355
		JToken IList<JToken>.this[int index]
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
			set
			{
			}
		}

		// Token: 0x06000776 RID: 1910 RVA: 0x0001315C File Offset: 0x0001135C
		void ICollection<JToken>.Add(JToken item)
		{
		}

		// Token: 0x06000777 RID: 1911 RVA: 0x0001316C File Offset: 0x0001136C
		void ICollection<JToken>.Clear()
		{
		}

		// Token: 0x06000778 RID: 1912 RVA: 0x0000212A File Offset: 0x0000032A
		bool ICollection<JToken>.Contains(JToken item)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06000779 RID: 1913 RVA: 0x0001317C File Offset: 0x0001137C
		void ICollection<JToken>.CopyTo(JToken[] array, int arrayIndex)
		{
		}

		// Token: 0x17000164 RID: 356
		// (get) Token: 0x0600077A RID: 1914 RVA: 0x0001318C File Offset: 0x0001138C
		bool ICollection<JToken>.IsReadOnly
		{
			get
			{
			}
		}

		// Token: 0x0600077B RID: 1915 RVA: 0x0000212A File Offset: 0x0000032A
		bool ICollection<JToken>.Remove(JToken item)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x0600077C RID: 1916 RVA: 0x0001319C File Offset: 0x0001139C
		private JToken EnsureValue(object value)
		{
			/*
An exception occurred when decompiling this method (0600077C)

ICSharpCode.Decompiler.DecompilerException: Error decompiling Newtonsoft.Json.Linq.JToken Newtonsoft.Json.Linq.JContainer::EnsureValue(System.Object)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0000:
	brtrue(IL_0000, logicnot:bool(ldloc:object[exp:bool](value)))
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

		// Token: 0x0600077D RID: 1917 RVA: 0x000131AC File Offset: 0x000113AC
		int IList.Add(object value)
		{
			JToken jtoken = this.EnsureValue(value);
			return this.Count;
		}

		// Token: 0x0600077E RID: 1918 RVA: 0x000131C8 File Offset: 0x000113C8
		void IList.Clear()
		{
		}

		// Token: 0x0600077F RID: 1919 RVA: 0x000131D8 File Offset: 0x000113D8
		bool IList.Contains(object value)
		{
			/*
An exception occurred when decompiling this method (0600077F)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean Newtonsoft.Json.Linq.JContainer::System.Collections.IList.Contains(System.Object)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:JToken(var_0_07, call:JToken(JContainer::EnsureValue, ldloc:JContainer(this), ldloc:object(value)))
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

		// Token: 0x06000780 RID: 1920 RVA: 0x000131EC File Offset: 0x000113EC
		int IList.IndexOf(object value)
		{
			/*
An exception occurred when decompiling this method (06000780)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Int32 Newtonsoft.Json.Linq.JContainer::System.Collections.IList.IndexOf(System.Object)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:JToken(var_0_07, call:JToken(JContainer::EnsureValue, ldloc:JContainer(this), ldloc:object(value)))
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

		// Token: 0x06000781 RID: 1921 RVA: 0x00013200 File Offset: 0x00011400
		void IList.Insert(int index, object value)
		{
			JToken jtoken = this.EnsureValue(value);
		}

		// Token: 0x17000165 RID: 357
		// (get) Token: 0x06000782 RID: 1922 RVA: 0x00013218 File Offset: 0x00011418
		bool IList.IsFixedSize
		{
			get
			{
			}
		}

		// Token: 0x17000166 RID: 358
		// (get) Token: 0x06000783 RID: 1923 RVA: 0x00013228 File Offset: 0x00011428
		bool IList.IsReadOnly
		{
			get
			{
			}
		}

		// Token: 0x06000784 RID: 1924 RVA: 0x00013238 File Offset: 0x00011438
		void IList.Remove(object value)
		{
			JToken jtoken = this.EnsureValue(value);
		}

		// Token: 0x06000785 RID: 1925 RVA: 0x00013250 File Offset: 0x00011450
		void IList.RemoveAt(int index)
		{
		}

		// Token: 0x17000167 RID: 359
		object IList.this[int index]
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
			set
			{
				JToken jtoken = this.EnsureValue(value);
			}
		}

		// Token: 0x06000788 RID: 1928 RVA: 0x00013278 File Offset: 0x00011478
		void ICollection.CopyTo(Array array, int index)
		{
		}

		// Token: 0x17000168 RID: 360
		// (get) Token: 0x06000789 RID: 1929 RVA: 0x0000212A File Offset: 0x0000032A
		public int Count
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		// Token: 0x17000169 RID: 361
		// (get) Token: 0x0600078A RID: 1930 RVA: 0x00013288 File Offset: 0x00011488
		bool ICollection.IsSynchronized
		{
			get
			{
			}
		}

		// Token: 0x1700016A RID: 362
		// (get) Token: 0x0600078B RID: 1931 RVA: 0x00013298 File Offset: 0x00011498
		object ICollection.SyncRoot
		{
			get
			{
				/*
An exception occurred when decompiling this method (0600078B)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Object Newtonsoft.Json.Linq.JContainer::System.Collections.ICollection.get_SyncRoot()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0000:
	brtrue(IL_0000, ldfld:object[exp:bool](JContainer::_syncRoot, ldloc:JContainer(this)))
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

		// Token: 0x0600078C RID: 1932 RVA: 0x000132AC File Offset: 0x000114AC
		void IBindingList.AddIndex(PropertyDescriptor property)
		{
		}

		// Token: 0x0600078D RID: 1933 RVA: 0x000132BC File Offset: 0x000114BC
		object IBindingList.AddNew()
		{
			CultureInfo invariantCulture = CultureInfo.InvariantCulture;
			return "New item to be added to collection must be compatible with {0}.";
		}

		// Token: 0x1700016B RID: 363
		// (get) Token: 0x0600078E RID: 1934 RVA: 0x000132F8 File Offset: 0x000114F8
		bool IBindingList.AllowEdit
		{
			get
			{
				return true;
			}
		}

		// Token: 0x1700016C RID: 364
		// (get) Token: 0x0600078F RID: 1935 RVA: 0x00013308 File Offset: 0x00011508
		bool IBindingList.AllowNew
		{
			get
			{
				return true;
			}
		}

		// Token: 0x1700016D RID: 365
		// (get) Token: 0x06000790 RID: 1936 RVA: 0x00013318 File Offset: 0x00011518
		bool IBindingList.AllowRemove
		{
			get
			{
				return true;
			}
		}

		// Token: 0x06000791 RID: 1937 RVA: 0x0000212A File Offset: 0x0000032A
		void IBindingList.ApplySort(PropertyDescriptor property, ListSortDirection direction)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06000792 RID: 1938 RVA: 0x0000212A File Offset: 0x0000032A
		int IBindingList.Find(PropertyDescriptor property, object key)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x1700016E RID: 366
		// (get) Token: 0x06000793 RID: 1939 RVA: 0x00013328 File Offset: 0x00011528
		bool IBindingList.IsSorted
		{
			get
			{
			}
		}

		// Token: 0x06000794 RID: 1940 RVA: 0x00013338 File Offset: 0x00011538
		void IBindingList.RemoveIndex(PropertyDescriptor property)
		{
		}

		// Token: 0x06000795 RID: 1941 RVA: 0x0000212A File Offset: 0x0000032A
		void IBindingList.RemoveSort()
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x1700016F RID: 367
		// (get) Token: 0x06000796 RID: 1942 RVA: 0x00013348 File Offset: 0x00011548
		ListSortDirection IBindingList.SortDirection
		{
			get
			{
			}
		}

		// Token: 0x17000170 RID: 368
		// (get) Token: 0x06000797 RID: 1943 RVA: 0x00013358 File Offset: 0x00011558
		PropertyDescriptor IBindingList.SortProperty
		{
			get
			{
			}
		}

		// Token: 0x17000171 RID: 369
		// (get) Token: 0x06000798 RID: 1944 RVA: 0x00013368 File Offset: 0x00011568
		bool IBindingList.SupportsChangeNotification
		{
			get
			{
				return true;
			}
		}

		// Token: 0x17000172 RID: 370
		// (get) Token: 0x06000799 RID: 1945 RVA: 0x00013378 File Offset: 0x00011578
		bool IBindingList.SupportsSearching
		{
			get
			{
			}
		}

		// Token: 0x17000173 RID: 371
		// (get) Token: 0x0600079A RID: 1946 RVA: 0x00013388 File Offset: 0x00011588
		bool IBindingList.SupportsSorting
		{
			get
			{
			}
		}

		// Token: 0x0600079B RID: 1947 RVA: 0x00013398 File Offset: 0x00011598
		internal static void MergeEnumerableContent(JContainer target, IEnumerable content, JsonMergeSettings settings)
		{
			MergeArrayHandling mergeArrayHandling = settings._mergeArrayHandling;
		}

		// Token: 0x0400031B RID: 795
		internal ListChangedEventHandler _listChanged;

		// Token: 0x0400031C RID: 796
		internal global::System.ComponentModel.AddingNewEventHandler _addingNew;

		// Token: 0x0400031D RID: 797
		private object _syncRoot;

		// Token: 0x0400031E RID: 798
		private bool _busy;

		// Token: 0x020000CD RID: 205
		[CompilerGenerated]
		private sealed class <GetDescendants>d__29 : IEnumerable<JToken>, IEnumerable, IEnumerator<JToken>, IDisposable, IEnumerator
		{
			// Token: 0x0600079C RID: 1948 RVA: 0x0001349C File Offset: 0x0001169C
			[DebuggerHidden]
			public <GetDescendants>d__29(int <>1__state)
			{
				this.<>1__state = <>1__state;
				int managedThreadId = Thread.CurrentThread.ManagedThreadId;
				this.<>l__initialThreadId = managedThreadId;
			}

			// Token: 0x0600079D RID: 1949 RVA: 0x000134CC File Offset: 0x000116CC
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
				int num = this.<>1__state;
			}

			// Token: 0x0600079E RID: 1950 RVA: 0x0001350C File Offset: 0x0001170C
			private bool MoveNext()
			{
				int num = this.<>1__state;
				if (this.self)
				{
					JContainer jcontainer = this.<>4__this;
					int num2 = 1;
					this.<>1__state = num2;
					this.<>2__current = jcontainer;
					JToken jtoken = this.<o>5__1;
					this.<>1__state = jcontainer;
					if (jtoken != null)
					{
					}
				}
				long value = 0.m_value;
				int value2 = 1.m_value;
				throw new OutOfMemoryException();
			}

			// Token: 0x0600079F RID: 1951 RVA: 0x00013574 File Offset: 0x00011774
			private void <>m__Finally1()
			{
				int num = 1;
				IEnumerator<JToken> enumerator = this.<>7__wrap1;
				this.<>1__state = num;
				if (enumerator != null)
				{
					return;
				}
			}

			// Token: 0x060007A0 RID: 1952 RVA: 0x00013598 File Offset: 0x00011798
			private void <>m__Finally2()
			{
				int num = 1;
				IEnumerator<JToken> enumerator = this.<>7__wrap2;
				this.<>1__state = num;
				if (enumerator != null)
				{
					return;
				}
			}

			// Token: 0x17000174 RID: 372
			// (get) Token: 0x060007A1 RID: 1953 RVA: 0x000135BC File Offset: 0x000117BC
			JToken IEnumerator<JToken>.Current
			{
				[DebuggerHidden]
				get
				{
					return this.<>2__current;
				}
			}

			// Token: 0x060007A2 RID: 1954 RVA: 0x0000212A File Offset: 0x0000032A
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}

			// Token: 0x17000175 RID: 373
			// (get) Token: 0x060007A3 RID: 1955 RVA: 0x000135D0 File Offset: 0x000117D0
			object IEnumerator.Current
			{
				[DebuggerHidden]
				get
				{
					/*
An exception occurred when decompiling this method (060007A3)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Object Newtonsoft.Json.Linq.JContainer/<GetDescendants>d__29::System.Collections.IEnumerator.get_Current()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:JToken(var_0_06, ldfld:JToken('<GetDescendants>d__29'::<>2__current, ldloc:'<GetDescendants>d__29'(this)))
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

			// Token: 0x060007A4 RID: 1956 RVA: 0x000135E4 File Offset: 0x000117E4
			[DebuggerHidden]
			IEnumerator<JToken> IEnumerable<JToken>.GetEnumerator()
			{
				/*
An exception occurred when decompiling this method (060007A4)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Collections.Generic.IEnumerator`1<Newtonsoft.Json.Linq.JToken> Newtonsoft.Json.Linq.JContainer/<GetDescendants>d__29::System.Collections.Generic.IEnumerable<Newtonsoft.Json.Linq.JToken>.GetEnumerator()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:int32(var_0_06, ldfld:int32('<GetDescendants>d__29'::<>1__state, ldloc:'<GetDescendants>d__29'(this)))
	stloc:int32(var_1_0D, ldfld:int32('<GetDescendants>d__29'::<>l__initialThreadId, ldloc:'<GetDescendants>d__29'(this)))
	stloc:int32(var_3_1A, callgetter:int32(Thread::get_ManagedThreadId, callgetter:Thread(Thread::get_CurrentThread)))
	stloc:JContainer(var_5_24, ldfld:JContainer('<GetDescendants>d__29'::<>4__this, ldloc:'<GetDescendants>d__29'(this)))
	stloc:bool(var_6_2C, ldfld:bool('<GetDescendants>d__29'::<>3__self, ldloc:'<GetDescendants>d__29'(this)))
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

			// Token: 0x060007A5 RID: 1957 RVA: 0x00013620 File Offset: 0x00011820
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				/*
An exception occurred when decompiling this method (060007A5)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Collections.IEnumerator Newtonsoft.Json.Linq.JContainer/<GetDescendants>d__29::System.Collections.IEnumerable.GetEnumerator()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:class [mscorlib]System.Collections.Generic.IEnumerator`1<class Newtonsoft.Json.Linq.JToken>(var_0_06, call:IEnumerator`1[exp:class [mscorlib]System.Collections.Generic.IEnumerator`1<class Newtonsoft.Json.Linq.JToken>]('<GetDescendants>d__29'::System.Collections.Generic.IEnumerable<Newtonsoft.Json.Linq.JToken>.GetEnumerator, ldloc:'<GetDescendants>d__29'(this)))
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

			// Token: 0x0400031F RID: 799
			private int <>1__state;

			// Token: 0x04000320 RID: 800
			private JToken <>2__current;

			// Token: 0x04000321 RID: 801
			private int <>l__initialThreadId;

			// Token: 0x04000322 RID: 802
			private bool self;

			// Token: 0x04000323 RID: 803
			public bool <>3__self;

			// Token: 0x04000324 RID: 804
			public JContainer <>4__this;

			// Token: 0x04000325 RID: 805
			private JToken <o>5__1;

			// Token: 0x04000326 RID: 806
			private IEnumerator<JToken> <>7__wrap1;

			// Token: 0x04000327 RID: 807
			private IEnumerator<JToken> <>7__wrap2;
		}
	}
}
