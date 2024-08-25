using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Cpp2IlInjected;

namespace System.ComponentModel
{
	// Token: 0x02000352 RID: 850
	[Serializable]
	public class BindingList<T> : Collection<T>, IBindingList, IList, ICollection, IEnumerable, ICancelAddNew, IRaiseItemChangedEvents
	{
		// Token: 0x06001610 RID: 5648 RVA: 0x00041080 File Offset: 0x0003F280
		public BindingList()
		{
		}

		// Token: 0x06001611 RID: 5649 RVA: 0x00041090 File Offset: 0x0003F290
		public BindingList(IList<T> list)
		{
		}

		// Token: 0x06001612 RID: 5650 RVA: 0x000410A0 File Offset: 0x0003F2A0
		private void Initialize()
		{
			if (!true)
			{
			}
		}

		// Token: 0x17000504 RID: 1284
		// (get) Token: 0x06001613 RID: 5651 RVA: 0x000410E4 File Offset: 0x0003F2E4
		private bool ItemTypeHasDefaultConstructor
		{
			get
			{
				Type type;
				bool isPrimitive = type.IsPrimitive;
				return true;
			}
		}

		// Token: 0x14000011 RID: 17
		// (add) Token: 0x06001614 RID: 5652 RVA: 0x000410FC File Offset: 0x0003F2FC
		// (remove) Token: 0x06001615 RID: 5653 RVA: 0x00041114 File Offset: 0x0003F314
		public event AddingNewEventHandler AddingNew
		{
			add
			{
				Delegate @delegate;
				if (@delegate != null)
				{
					throw new InvalidCastException();
				}
			}
			remove
			{
				Delegate @delegate;
				if (@delegate != null)
				{
					throw new InvalidCastException();
				}
			}
		}

		// Token: 0x06001616 RID: 5654 RVA: 0x0004112C File Offset: 0x0003F32C
		protected virtual void OnAddingNew(AddingNewEventArgs e)
		{
		}

		// Token: 0x06001617 RID: 5655 RVA: 0x0004113C File Offset: 0x0003F33C
		private object FireAddingNew()
		{
		}

		// Token: 0x14000012 RID: 18
		// (add) Token: 0x06001618 RID: 5656 RVA: 0x0004114C File Offset: 0x0003F34C
		// (remove) Token: 0x06001619 RID: 5657 RVA: 0x00041164 File Offset: 0x0003F364
		public event ListChangedEventHandler ListChanged
		{
			add
			{
				Delegate @delegate;
				if (@delegate != null)
				{
					throw new InvalidCastException();
				}
			}
			remove
			{
				Delegate @delegate;
				if (@delegate != null)
				{
					throw new InvalidCastException();
				}
			}
		}

		// Token: 0x0600161A RID: 5658 RVA: 0x0004117C File Offset: 0x0003F37C
		protected virtual void OnListChanged(ListChangedEventArgs e)
		{
		}

		// Token: 0x17000505 RID: 1285
		// (get) Token: 0x0600161B RID: 5659 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600161C RID: 5660 RVA: 0x0004118C File Offset: 0x0003F38C
		public bool RaiseListChangedEvents
		{
			get
			{
				throw new global::Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
			set
			{
			}
		}

		// Token: 0x0600161D RID: 5661 RVA: 0x0004119C File Offset: 0x0003F39C
		public void ResetBindings()
		{
		}

		// Token: 0x0600161E RID: 5662 RVA: 0x000411AC File Offset: 0x0003F3AC
		public void ResetItem(int position)
		{
		}

		// Token: 0x0600161F RID: 5663 RVA: 0x000411BC File Offset: 0x0003F3BC
		private void FireListChanged(ListChangedType type, int index)
		{
			if (true)
			{
				return;
			}
		}

		// Token: 0x06001620 RID: 5664 RVA: 0x000411D0 File Offset: 0x0003F3D0
		protected override void ClearItems()
		{
		}

		// Token: 0x06001621 RID: 5665 RVA: 0x00041210 File Offset: 0x0003F410
		protected override void InsertItem(int index, T item)
		{
		}

		// Token: 0x06001622 RID: 5666 RVA: 0x00041220 File Offset: 0x0003F420
		protected override void RemoveItem(int index)
		{
			if (index != 0)
			{
			}
		}

		// Token: 0x06001623 RID: 5667 RVA: 0x00041230 File Offset: 0x0003F430
		protected override void SetItem(int index, T item)
		{
		}

		// Token: 0x06001624 RID: 5668 RVA: 0x00041240 File Offset: 0x0003F440
		public virtual void CancelNew(int itemIndex)
		{
		}

		// Token: 0x06001625 RID: 5669 RVA: 0x00041250 File Offset: 0x0003F450
		public virtual void EndNew(int itemIndex)
		{
		}

		// Token: 0x06001626 RID: 5670 RVA: 0x00041260 File Offset: 0x0003F460
		public T AddNew()
		{
			while (this != null)
			{
				if (this == null)
				{
					throw new InvalidCastException();
				}
			}
		}

		// Token: 0x06001627 RID: 5671 RVA: 0x0004127C File Offset: 0x0003F47C
		object IBindingList.AddNew()
		{
			if (this == null || this != null)
			{
			}
			throw new InvalidCastException();
		}

		// Token: 0x17000506 RID: 1286
		// (get) Token: 0x06001628 RID: 5672 RVA: 0x00041294 File Offset: 0x0003F494
		private bool AddingNewHandled
		{
			get
			{
				/*
An exception occurred when decompiling this method (06001628)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean System.ComponentModel.BindingList`1::get_AddingNewHandled()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0000:
	brtrue(IL_0000, logicnot:bool(ldloc:BindingList`1[exp:bool](this)))
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

		// Token: 0x06001629 RID: 5673 RVA: 0x000412A4 File Offset: 0x0003F4A4
		protected virtual object AddNewCore()
		{
			object obj;
			if (this == null)
			{
				Type type;
				obj = global::System.SecurityUtils.SecureCreateInstance(type);
			}
			if (obj != null && obj == null)
			{
				throw new InvalidCastException();
			}
			return obj;
		}

		// Token: 0x17000507 RID: 1287
		// (get) Token: 0x0600162A RID: 5674 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600162B RID: 5675 RVA: 0x000412C8 File Offset: 0x0003F4C8
		public bool AllowNew
		{
			get
			{
				throw new global::Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
			set
			{
			}
		}

		// Token: 0x17000508 RID: 1288
		// (get) Token: 0x0600162C RID: 5676 RVA: 0x00002050 File Offset: 0x00000250
		bool IBindingList.AllowNew
		{
			get
			{
				throw new global::Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		// Token: 0x17000509 RID: 1289
		// (get) Token: 0x0600162D RID: 5677 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600162E RID: 5678 RVA: 0x000412D8 File Offset: 0x0003F4D8
		public bool AllowEdit
		{
			get
			{
				throw new global::Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
			set
			{
			}
		}

		// Token: 0x1700050A RID: 1290
		// (get) Token: 0x0600162F RID: 5679 RVA: 0x00002050 File Offset: 0x00000250
		bool IBindingList.AllowEdit
		{
			get
			{
				throw new global::Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		// Token: 0x1700050B RID: 1291
		// (get) Token: 0x06001630 RID: 5680 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06001631 RID: 5681 RVA: 0x000412E8 File Offset: 0x0003F4E8
		public bool AllowRemove
		{
			get
			{
				throw new global::Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
			set
			{
			}
		}

		// Token: 0x1700050C RID: 1292
		// (get) Token: 0x06001632 RID: 5682 RVA: 0x00002050 File Offset: 0x00000250
		bool IBindingList.AllowRemove
		{
			get
			{
				throw new global::Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		// Token: 0x1700050D RID: 1293
		// (get) Token: 0x06001633 RID: 5683 RVA: 0x00002050 File Offset: 0x00000250
		bool IBindingList.SupportsChangeNotification
		{
			get
			{
				throw new global::Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		// Token: 0x1700050E RID: 1294
		// (get) Token: 0x06001634 RID: 5684 RVA: 0x000412F8 File Offset: 0x0003F4F8
		protected virtual bool SupportsChangeNotificationCore
		{
			get
			{
				return true;
			}
		}

		// Token: 0x1700050F RID: 1295
		// (get) Token: 0x06001635 RID: 5685 RVA: 0x00002050 File Offset: 0x00000250
		bool IBindingList.SupportsSearching
		{
			get
			{
				throw new global::Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		// Token: 0x17000510 RID: 1296
		// (get) Token: 0x06001636 RID: 5686 RVA: 0x00041308 File Offset: 0x0003F508
		protected virtual bool SupportsSearchingCore
		{
			get
			{
			}
		}

		// Token: 0x17000511 RID: 1297
		// (get) Token: 0x06001637 RID: 5687 RVA: 0x00002050 File Offset: 0x00000250
		bool IBindingList.SupportsSorting
		{
			get
			{
				throw new global::Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		// Token: 0x17000512 RID: 1298
		// (get) Token: 0x06001638 RID: 5688 RVA: 0x00041318 File Offset: 0x0003F518
		protected virtual bool SupportsSortingCore
		{
			get
			{
			}
		}

		// Token: 0x17000513 RID: 1299
		// (get) Token: 0x06001639 RID: 5689 RVA: 0x00002050 File Offset: 0x00000250
		bool IBindingList.IsSorted
		{
			get
			{
				throw new global::Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		// Token: 0x17000514 RID: 1300
		// (get) Token: 0x0600163A RID: 5690 RVA: 0x00041328 File Offset: 0x0003F528
		protected virtual bool IsSortedCore
		{
			get
			{
			}
		}

		// Token: 0x17000515 RID: 1301
		// (get) Token: 0x0600163B RID: 5691 RVA: 0x00002050 File Offset: 0x00000250
		PropertyDescriptor IBindingList.SortProperty
		{
			get
			{
				throw new global::Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		// Token: 0x17000516 RID: 1302
		// (get) Token: 0x0600163C RID: 5692 RVA: 0x00041338 File Offset: 0x0003F538
		protected virtual PropertyDescriptor SortPropertyCore
		{
			get
			{
			}
		}

		// Token: 0x17000517 RID: 1303
		// (get) Token: 0x0600163D RID: 5693 RVA: 0x00002050 File Offset: 0x00000250
		ListSortDirection IBindingList.SortDirection
		{
			get
			{
				throw new global::Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		// Token: 0x17000518 RID: 1304
		// (get) Token: 0x0600163E RID: 5694 RVA: 0x00041348 File Offset: 0x0003F548
		protected virtual ListSortDirection SortDirectionCore
		{
			get
			{
			}
		}

		// Token: 0x0600163F RID: 5695 RVA: 0x00041358 File Offset: 0x0003F558
		void IBindingList.ApplySort(PropertyDescriptor prop, ListSortDirection direction)
		{
		}

		// Token: 0x06001640 RID: 5696 RVA: 0x00002050 File Offset: 0x00000250
		protected virtual void ApplySortCore(PropertyDescriptor prop, ListSortDirection direction)
		{
			throw new global::Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06001641 RID: 5697 RVA: 0x00041368 File Offset: 0x0003F568
		void IBindingList.RemoveSort()
		{
		}

		// Token: 0x06001642 RID: 5698 RVA: 0x00002050 File Offset: 0x00000250
		protected virtual void RemoveSortCore()
		{
			throw new global::Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06001643 RID: 5699 RVA: 0x00002050 File Offset: 0x00000250
		int IBindingList.Find(PropertyDescriptor prop, object key)
		{
			throw new global::Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06001644 RID: 5700 RVA: 0x00002050 File Offset: 0x00000250
		protected virtual int FindCore(PropertyDescriptor prop, object key)
		{
			throw new global::Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06001645 RID: 5701 RVA: 0x00041378 File Offset: 0x0003F578
		void IBindingList.AddIndex(PropertyDescriptor prop)
		{
		}

		// Token: 0x06001646 RID: 5702 RVA: 0x00041388 File Offset: 0x0003F588
		void IBindingList.RemoveIndex(PropertyDescriptor prop)
		{
		}

		// Token: 0x06001647 RID: 5703 RVA: 0x00041398 File Offset: 0x0003F598
		private void HookPropertyChanged(T item)
		{
			if (item != null)
			{
				return;
			}
		}

		// Token: 0x06001648 RID: 5704 RVA: 0x000413AC File Offset: 0x0003F5AC
		private void UnhookPropertyChanged(T item)
		{
			if (item != null && this != null)
			{
				return;
			}
		}

		// Token: 0x06001649 RID: 5705 RVA: 0x000413C4 File Offset: 0x0003F5C4
		private void Child_PropertyChanged(object sender, PropertyChangedEventArgs e)
		{
			if (sender == null || e == null)
			{
				PropertyDescriptorCollection properties2;
				PropertyDescriptor[] properties = properties2._properties;
				return;
			}
			if (sender != null)
			{
				if (sender == null)
				{
					Type type;
					PropertyDescriptorCollection properties2 = TypeDescriptor.GetProperties(type);
				}
				return;
			}
			throw new InvalidCastException();
		}

		// Token: 0x17000519 RID: 1305
		// (get) Token: 0x0600164A RID: 5706 RVA: 0x00002050 File Offset: 0x00000250
		bool IRaiseItemChangedEvents.RaisesItemChangedEvents
		{
			get
			{
				throw new global::Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		// Token: 0x040011CB RID: 4555
		private int addNewPos;

		// Token: 0x040011CC RID: 4556
		private bool raiseListChangedEvents;

		// Token: 0x040011CD RID: 4557
		private bool raiseItemChangedEvents;

		// Token: 0x040011CE RID: 4558
		[NonSerialized]
		private PropertyDescriptorCollection _itemTypeProperties;

		// Token: 0x040011CF RID: 4559
		[NonSerialized]
		private PropertyChangedEventHandler _propertyChangedEventHandler;

		// Token: 0x040011D0 RID: 4560
		[NonSerialized]
		private AddingNewEventHandler _onAddingNew;

		// Token: 0x040011D1 RID: 4561
		[NonSerialized]
		private ListChangedEventHandler _onListChanged;

		// Token: 0x040011D2 RID: 4562
		[NonSerialized]
		private int _lastChangeIndex;

		// Token: 0x040011D3 RID: 4563
		private bool allowNew;

		// Token: 0x040011D4 RID: 4564
		private bool allowEdit;

		// Token: 0x040011D5 RID: 4565
		private bool allowRemove;

		// Token: 0x040011D6 RID: 4566
		private bool userSetAllowNew;
	}
}
