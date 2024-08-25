using System;
using System.Collections;
using System.Collections.Specialized;
using System.Diagnostics;
using System.Globalization;
using System.Reflection;
using Cpp2IlInjected;

namespace System.ComponentModel
{
	// Token: 0x020003E9 RID: 1001
	internal sealed class ReflectPropertyDescriptor : PropertyDescriptor
	{
		// Token: 0x06001A7A RID: 6778 RVA: 0x00049470 File Offset: 0x00047670
		public ReflectPropertyDescriptor(Type componentClass, string name, Type type, Attribute[] attributes)
		{
			int num = 1;
			base..ctor(name, attributes);
			if (num == 0)
			{
			}
			if (num == 0)
			{
			}
			this.componentClass = componentClass;
			this.type = type;
		}

		// Token: 0x06001A7B RID: 6779 RVA: 0x000494D0 File Offset: 0x000476D0
		public ReflectPropertyDescriptor(Type componentClass, string name, Type type, PropertyInfo propInfo, MethodInfo getMethod, MethodInfo setMethod, Attribute[] attrs)
		{
			int num = 1;
			this.propInfo = propInfo;
			this.getMethod = getMethod;
			this.setMethod = setMethod;
			if (num == 0)
			{
			}
		}

		// Token: 0x06001A7C RID: 6780 RVA: 0x00049504 File Offset: 0x00047704
		public ReflectPropertyDescriptor(Type componentClass, string name, Type type, Type receiverType, MethodInfo getMethod, MethodInfo setMethod, Attribute[] attrs)
		{
			int num = 1;
			this.receiverType = receiverType;
			this.getMethod = getMethod;
			this.setMethod = setMethod;
			if (num == 0)
			{
			}
		}

		// Token: 0x06001A7D RID: 6781 RVA: 0x00049530 File Offset: 0x00047730
		public ReflectPropertyDescriptor(Type componentClass, PropertyDescriptor oldReflectPropertyDescriptor, Attribute[] attributes)
			: base(oldReflectPropertyDescriptor, attributes)
		{
			this.componentClass = componentClass;
			this.type = oldReflectPropertyDescriptor;
		}

		// Token: 0x17000617 RID: 1559
		// (get) Token: 0x06001A7E RID: 6782 RVA: 0x00049584 File Offset: 0x00047784
		private object AmbientValue
		{
			get
			{
				if (!true)
				{
				}
				return this.ambientValue;
			}
		}

		// Token: 0x17000618 RID: 1560
		// (get) Token: 0x06001A7F RID: 6783 RVA: 0x000495B0 File Offset: 0x000477B0
		private EventDescriptor ChangedEventValue
		{
			get
			{
				if (!true)
				{
				}
				return this.realChangedEvent;
			}
		}

		// Token: 0x17000619 RID: 1561
		// (get) Token: 0x06001A80 RID: 6784 RVA: 0x000495E8 File Offset: 0x000477E8
		// (set) Token: 0x06001A81 RID: 6785 RVA: 0x00049618 File Offset: 0x00047818
		private EventDescriptor IPropChangedEventValue
		{
			get
			{
				int num = 1;
				if (num == 0)
				{
				}
				if (num == 0)
				{
				}
				if (num == 0)
				{
				}
				Type type;
				EventDescriptorCollection events = TypeDescriptor.GetEvents(type);
				this.realIPropChangedEvent = events;
				return this.realIPropChangedEvent;
			}
			set
			{
				int num = 1;
				this.realIPropChangedEvent = value;
				if (num == 0)
				{
				}
			}
		}

		// Token: 0x1700061A RID: 1562
		// (get) Token: 0x06001A82 RID: 6786 RVA: 0x00049634 File Offset: 0x00047834
		public override Type ComponentType
		{
			get
			{
				return this.componentClass;
			}
		}

		// Token: 0x1700061B RID: 1563
		// (get) Token: 0x06001A83 RID: 6787 RVA: 0x00049648 File Offset: 0x00047848
		private object DefaultValue
		{
			get
			{
				int num = 1;
				if (num == 0)
				{
				}
				if (num == 0)
				{
				}
				if (this != null)
				{
					this.defaultValue = this;
					if (this != null)
					{
						Type type = this.defaultValue.GetType();
						object obj = this.defaultValue;
						object obj2;
						this.defaultValue = obj2;
						return obj2;
					}
				}
				return this.defaultValue;
			}
		}

		// Token: 0x1700061C RID: 1564
		// (get) Token: 0x06001A84 RID: 6788 RVA: 0x00049698 File Offset: 0x00047898
		private MethodInfo GetMethodValue
		{
			get
			{
				int num = 1;
				if (num == 0)
				{
				}
				if (num == 0)
				{
				}
				Type type = this.receiverType;
				if (num == 0)
				{
				}
				PropertyInfo propertyInfo = this.propInfo;
				Type type2 = this.componentClass;
				PropertyInfo propertyInfo2;
				this.propInfo = propertyInfo2;
				Type type3 = this.componentClass;
				Type type4 = this.receiverType;
				if (type4 == null || type4 != null)
				{
					Type type5 = this.type;
					MethodInfo methodInfo;
					this.getMethod = methodInfo;
					throw new ArrayTypeMismatchException();
				}
				throw new ArrayTypeMismatchException();
			}
		}

		// Token: 0x1700061D RID: 1565
		// (get) Token: 0x06001A85 RID: 6789 RVA: 0x00049718 File Offset: 0x00047918
		private bool IsExtender
		{
			get
			{
				Type type = this.receiverType;
				if (!true)
				{
				}
				bool flag;
				return flag;
			}
		}

		// Token: 0x1700061E RID: 1566
		// (get) Token: 0x06001A86 RID: 6790 RVA: 0x00049730 File Offset: 0x00047930
		public override bool IsReadOnly
		{
			get
			{
				MethodInfo setMethodValue = this.SetMethodValue;
				return true;
			}
		}

		// Token: 0x1700061F RID: 1567
		// (get) Token: 0x06001A87 RID: 6791 RVA: 0x00049758 File Offset: 0x00047958
		public override Type PropertyType
		{
			get
			{
				return this.type;
			}
		}

		// Token: 0x17000620 RID: 1568
		// (get) Token: 0x06001A88 RID: 6792 RVA: 0x0004976C File Offset: 0x0004796C
		private MethodInfo ResetMethodValue
		{
			get
			{
				if (!true)
				{
				}
				return this.resetMethod;
			}
		}

		// Token: 0x17000621 RID: 1569
		// (get) Token: 0x06001A89 RID: 6793 RVA: 0x000497C0 File Offset: 0x000479C0
		private MethodInfo SetMethodValue
		{
			get
			{
				int num = 1;
				if (num == 0)
				{
				}
				if (num == 0)
				{
				}
				if (num == 0)
				{
				}
				PropertyInfo propertyInfo = this.propInfo;
				MethodInfo methodInfo = this.setMethod;
				PropertyInfo propertyInfo2;
				MethodInfo methodInfo2 = propertyInfo2.GetSetMethod();
				this.setMethod = methodInfo2;
				Type type = this.receiverType;
				PropertyInfo propertyInfo3 = this.propInfo;
				Type type2 = this.componentClass;
				PropertyInfo propertyInfo4;
				this.propInfo = propertyInfo4;
				Type type3 = this.componentClass;
				Type type4 = this.receiverType;
				if (type4 == null || type4 != null)
				{
					Type type5 = this.type;
					if (type5 == null || type5 != null)
					{
						MethodInfo methodInfo3;
						return methodInfo3;
					}
				}
				throw new ArrayTypeMismatchException();
			}
		}

		// Token: 0x17000622 RID: 1570
		// (get) Token: 0x06001A8A RID: 6794 RVA: 0x0004987C File Offset: 0x00047A7C
		private MethodInfo ShouldSerializeMethodValue
		{
			get
			{
				if (!true)
				{
				}
				return this.shouldSerializeMethod;
			}
		}

		// Token: 0x06001A8B RID: 6795 RVA: 0x000498D0 File Offset: 0x00047AD0
		public override void AddValueChanged(object component, EventHandler handler)
		{
			while (component != null)
			{
				if (handler != null)
				{
					if (this.ChangedEventValue != null)
					{
						return;
					}
					if (base.GetValueChangedHandler(component) != null || this.IPropChangedEventValue != null)
					{
					}
					base.AddValueChanged(component, handler);
					return;
				}
			}
		}

		// Token: 0x06001A8C RID: 6796 RVA: 0x00049908 File Offset: 0x00047B08
		internal bool ExtenderCanResetValue(IExtenderProvider provider, object component)
		{
			object obj = this.DefaultValue;
			object obj2 = this.ExtenderGetValue(provider, component);
			object obj3 = this.defaultValue;
			return object.Equals(obj2, obj3);
		}

		// Token: 0x06001A8D RID: 6797 RVA: 0x0004996C File Offset: 0x00047B6C
		internal Type ExtenderGetReceiverType()
		{
			return this.receiverType;
		}

		// Token: 0x06001A8E RID: 6798 RVA: 0x00002050 File Offset: 0x00000250
		internal Type ExtenderGetType(IExtenderProvider provider)
		{
			throw new global::Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06001A8F RID: 6799 RVA: 0x00049980 File Offset: 0x00047B80
		internal object ExtenderGetValue(IExtenderProvider provider, object component)
		{
			if (provider != null)
			{
				Type type = this.componentClass;
				if (this != null && this == null)
				{
					throw new InvalidCastException();
				}
			}
			MethodInfo getMethodValue = this.GetMethodValue;
			if (component == null || component != null)
			{
				object obj;
				return obj;
			}
			throw new ArrayTypeMismatchException();
		}

		// Token: 0x06001A90 RID: 6800 RVA: 0x000499BC File Offset: 0x00047BBC
		internal void ExtenderResetValue(IExtenderProvider provider, object component, PropertyDescriptor notifyDesc)
		{
			object obj = this.DefaultValue;
			object obj2 = this.DefaultValue;
		}

		// Token: 0x06001A91 RID: 6801 RVA: 0x00049A68 File Offset: 0x00047C68
		internal void ExtenderSetValue(IExtenderProvider provider, object component, object value, PropertyDescriptor notifyDesc)
		{
			if (provider == null)
			{
				return;
			}
			ISite site = MemberDescriptor.GetSite(component);
			if (site != null)
			{
				return;
			}
		}

		// Token: 0x06001A92 RID: 6802 RVA: 0x00049AF0 File Offset: 0x00047CF0
		internal bool ExtenderShouldSerializeValue(IExtenderProvider provider, object component)
		{
			Type type = this.componentClass;
			if (this != null && this == null)
			{
				throw new InvalidCastException();
			}
			MethodInfo shouldSerializeMethodValue = this.ShouldSerializeMethodValue;
			if (component == null || component != null)
			{
				object obj = this.DefaultValue;
				object obj2;
				return object.Equals(this.DefaultValue, obj2);
			}
			throw new ArrayTypeMismatchException();
		}

		// Token: 0x06001A93 RID: 6803 RVA: 0x00049B6C File Offset: 0x00047D6C
		public override bool CanResetValue(object component)
		{
			bool isExtender = this.IsExtender;
			object obj = this.DefaultValue;
			object obj2 = this.DefaultValue;
			return object.Equals(this, obj2);
		}

		// Token: 0x06001A94 RID: 6804 RVA: 0x00049BC8 File Offset: 0x00047DC8
		protected override void FillAttributes(IList attributes)
		{
			AttributeCollection attributeCollection;
			IEnumerator enumerator = attributeCollection.GetEnumerator();
		}

		// Token: 0x06001A95 RID: 6805 RVA: 0x00049C9C File Offset: 0x00047E9C
		public override object GetValue(object component)
		{
			bool isExtender = this.IsExtender;
			if (component != null)
			{
				Type type = this.componentClass;
				MethodInfo getMethodValue = this.GetMethodValue;
			}
			object obj;
			return obj;
		}

		// Token: 0x06001A96 RID: 6806 RVA: 0x00049CE4 File Offset: 0x00047EE4
		internal void OnINotifyPropertyChanged(object component, PropertyChangedEventArgs e)
		{
			CultureInfo invariantCulture = CultureInfo.InvariantCulture;
			int num;
			if (num != 0)
			{
				return;
			}
		}

		// Token: 0x06001A97 RID: 6807 RVA: 0x00049D00 File Offset: 0x00047F00
		protected override void OnValueChanged(object component, EventArgs e)
		{
			if (!true)
			{
			}
			if (this.realChangedEvent != null)
			{
				return;
			}
			base.OnValueChanged(component, e);
		}

		// Token: 0x06001A98 RID: 6808 RVA: 0x00049D24 File Offset: 0x00047F24
		public override void RemoveValueChanged(object component, EventHandler handler)
		{
			while (component != null)
			{
				if (handler != null)
				{
					if (this.ChangedEventValue != null)
					{
						return;
					}
					base.RemoveValueChanged(component, handler);
					if (base.GetValueChangedHandler(component) != null)
					{
						return;
					}
					if (this.IPropChangedEventValue != null)
					{
						return;
					}
				}
			}
		}

		// Token: 0x06001A99 RID: 6809 RVA: 0x00049D5C File Offset: 0x00047F5C
		public override void ResetValue(object component)
		{
			Type type = this.componentClass;
			object obj = this.DefaultValue;
			object obj2 = this.DefaultValue;
		}

		// Token: 0x06001A9A RID: 6810 RVA: 0x00049DE8 File Offset: 0x00047FE8
		public override void SetValue(object component, object value)
		{
			if (component == null)
			{
				return;
			}
			ISite site = MemberDescriptor.GetSite(component);
			Type type = this.componentClass;
			if (site != null)
			{
				return;
			}
		}

		// Token: 0x06001A9B RID: 6811 RVA: 0x00049E88 File Offset: 0x00048088
		public override bool ShouldSerializeValue(object component)
		{
			Type type = this.componentClass;
			MethodInfo shouldSerializeMethodValue = this.ShouldSerializeMethodValue;
			MethodInfo shouldSerializeMethodValue2 = this.ShouldSerializeMethodValue;
			object obj = this.DefaultValue;
			return object.Equals(this.DefaultValue, this);
		}

		// Token: 0x17000623 RID: 1571
		// (get) Token: 0x06001A9C RID: 6812 RVA: 0x00049EDC File Offset: 0x000480DC
		public override bool SupportsChangeEvents
		{
			get
			{
				/*
An exception occurred when decompiling this method (06001A9C)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean System.ComponentModel.ReflectPropertyDescriptor::get_SupportsChangeEvents()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_000A:
	stloc:EventDescriptor(var_0_10, callgetter:EventDescriptor(ReflectPropertyDescriptor::get_ChangedEventValue, ldloc:ReflectPropertyDescriptor(this)))
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

		// Token: 0x06001A9D RID: 6813 RVA: 0x00049EFC File Offset: 0x000480FC
		// Note: this type is marked as 'beforefieldinit'.
		static ReflectPropertyDescriptor()
		{
			int num = global::System.Collections.Specialized.BitVector32.CreateMask(global::System.Collections.Specialized.BitVector32.CreateMask(global::System.Collections.Specialized.BitVector32.CreateMask(global::System.Collections.Specialized.BitVector32.CreateMask(global::System.Collections.Specialized.BitVector32.CreateMask(global::System.Collections.Specialized.BitVector32.CreateMask(global::System.Collections.Specialized.BitVector32.CreateMask(global::System.Collections.Specialized.BitVector32.CreateMask(global::System.Collections.Specialized.BitVector32.CreateMask(global::System.Collections.Specialized.BitVector32.CreateMask())))))))));
		}

		// Token: 0x0400131B RID: 4891
		private static readonly Type[] argsNone;

		// Token: 0x0400131C RID: 4892
		private static readonly object noValue;

		// Token: 0x0400131D RID: 4893
		private static global::System.Diagnostics.TraceSwitch PropDescCreateSwitch;

		// Token: 0x0400131E RID: 4894
		private static global::System.Diagnostics.TraceSwitch PropDescUsageSwitch;

		// Token: 0x0400131F RID: 4895
		private static readonly int BitDefaultValueQueried;

		// Token: 0x04001320 RID: 4896
		private static readonly int BitGetQueried;

		// Token: 0x04001321 RID: 4897
		private static readonly int BitSetQueried;

		// Token: 0x04001322 RID: 4898
		private static readonly int BitShouldSerializeQueried;

		// Token: 0x04001323 RID: 4899
		private static readonly int BitResetQueried;

		// Token: 0x04001324 RID: 4900
		private static readonly int BitChangedQueried;

		// Token: 0x04001325 RID: 4901
		private static readonly int BitIPropChangedQueried;

		// Token: 0x04001326 RID: 4902
		private static readonly int BitReadOnlyChecked;

		// Token: 0x04001327 RID: 4903
		private static readonly int BitAmbientValueQueried;

		// Token: 0x04001328 RID: 4904
		private static readonly int BitSetOnDemand;

		// Token: 0x04001329 RID: 4905
		private global::System.Collections.Specialized.BitVector32 state;

		// Token: 0x0400132A RID: 4906
		private Type componentClass;

		// Token: 0x0400132B RID: 4907
		private Type type;

		// Token: 0x0400132C RID: 4908
		private object defaultValue;

		// Token: 0x0400132D RID: 4909
		private object ambientValue;

		// Token: 0x0400132E RID: 4910
		private PropertyInfo propInfo;

		// Token: 0x0400132F RID: 4911
		private MethodInfo getMethod;

		// Token: 0x04001330 RID: 4912
		private MethodInfo setMethod;

		// Token: 0x04001331 RID: 4913
		private MethodInfo shouldSerializeMethod;

		// Token: 0x04001332 RID: 4914
		private MethodInfo resetMethod;

		// Token: 0x04001333 RID: 4915
		private EventDescriptor realChangedEvent;

		// Token: 0x04001334 RID: 4916
		private EventDescriptor realIPropChangedEvent;

		// Token: 0x04001335 RID: 4917
		private Type receiverType;
	}
}
