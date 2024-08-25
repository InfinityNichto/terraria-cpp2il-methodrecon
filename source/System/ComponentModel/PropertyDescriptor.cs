using System;
using System.Collections;
using Cpp2IlInjected;

namespace System.ComponentModel
{
	// Token: 0x020003AC RID: 940
	public abstract class PropertyDescriptor : MemberDescriptor
	{
		// Token: 0x060018D1 RID: 6353 RVA: 0x00045D34 File Offset: 0x00043F34
		protected PropertyDescriptor(string name, Attribute[] attrs)
			: base(name, attrs)
		{
		}

		// Token: 0x060018D2 RID: 6354 RVA: 0x00045D4C File Offset: 0x00043F4C
		protected PropertyDescriptor(MemberDescriptor descr)
			: base(descr)
		{
		}

		// Token: 0x060018D3 RID: 6355 RVA: 0x00045D60 File Offset: 0x00043F60
		protected PropertyDescriptor(MemberDescriptor descr, Attribute[] attrs)
			: base(descr, attrs)
		{
		}

		// Token: 0x170005AB RID: 1451
		// (get) Token: 0x060018D4 RID: 6356
		public abstract Type ComponentType { get; }

		// Token: 0x170005AC RID: 1452
		// (get) Token: 0x060018D5 RID: 6357 RVA: 0x00045D78 File Offset: 0x00043F78
		public virtual TypeConverter Converter
		{
			get
			{
				TypeConverter typeConverter;
				if (this._converter == null)
				{
					if (this != null)
					{
					}
					string name = this.name;
					if (name != null)
					{
						int stringLength = name._stringLength;
						Type typeFromName = this.GetTypeFromName(name);
						object obj = this.CreateInstance(typeFromName);
						if (obj == null)
						{
							return typeConverter;
						}
						this._converter = obj;
					}
					if (this._converter == null)
					{
						this._converter = typeConverter;
					}
				}
				return typeConverter;
			}
		}

		// Token: 0x170005AD RID: 1453
		// (get) Token: 0x060018D6 RID: 6358 RVA: 0x00045DDC File Offset: 0x00043FDC
		public virtual bool IsLocalizable
		{
			get
			{
				if (!true)
				{
				}
				return true;
			}
		}

		// Token: 0x170005AE RID: 1454
		// (get) Token: 0x060018D7 RID: 6359
		public abstract bool IsReadOnly { get; }

		// Token: 0x170005AF RID: 1455
		// (get) Token: 0x060018D8 RID: 6360 RVA: 0x00045DF0 File Offset: 0x00043FF0
		public DesignerSerializationVisibility SerializationVisibility
		{
			get
			{
				if (this != null)
				{
				}
				string name = this.name;
				throw new InvalidCastException();
			}
		}

		// Token: 0x170005B0 RID: 1456
		// (get) Token: 0x060018D9 RID: 6361
		public abstract Type PropertyType { get; }

		// Token: 0x060018DA RID: 6362 RVA: 0x00045E0C File Offset: 0x0004400C
		public virtual void AddValueChanged(object component, EventHandler handler)
		{
			if (component == null)
			{
				return;
			}
			if (handler != null)
			{
				if (this._valueChangedHandlers == null)
				{
				}
				Hashtable valueChangedHandlers = this._valueChangedHandlers;
				return;
			}
			throw new InvalidCastException();
		}

		// Token: 0x060018DB RID: 6363
		public abstract bool CanResetValue(object component);

		// Token: 0x060018DC RID: 6364 RVA: 0x00045E38 File Offset: 0x00044038
		public override bool Equals(object obj)
		{
			if (obj != null)
			{
				bool flag;
				return flag;
			}
		}

		// Token: 0x060018DD RID: 6365 RVA: 0x00045E5C File Offset: 0x0004405C
		protected object CreateInstance(Type type)
		{
			Type type2;
			if ((type2 == null || type2 != null) && (this == null || this != null))
			{
				object obj;
				return obj;
			}
			throw new ArrayTypeMismatchException();
		}

		// Token: 0x060018DE RID: 6366 RVA: 0x00045E84 File Offset: 0x00044084
		protected override void FillAttributes(IList attributeList)
		{
			base.FillAttributes(attributeList);
		}

		// Token: 0x060018DF RID: 6367 RVA: 0x00002050 File Offset: 0x00000250
		public PropertyDescriptorCollection GetChildProperties()
		{
			throw new global::Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x060018E0 RID: 6368 RVA: 0x00002050 File Offset: 0x00000250
		public PropertyDescriptorCollection GetChildProperties(Attribute[] filter)
		{
			throw new global::Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x060018E1 RID: 6369 RVA: 0x00002050 File Offset: 0x00000250
		public PropertyDescriptorCollection GetChildProperties(object instance)
		{
			throw new global::Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x060018E2 RID: 6370 RVA: 0x00045E98 File Offset: 0x00044098
		public virtual PropertyDescriptorCollection GetChildProperties(object instance, Attribute[] filter)
		{
			if (instance != null)
			{
				if (!true)
				{
				}
				return TypeDescriptor.GetProperties(instance, filter);
			}
			PropertyDescriptorCollection propertyDescriptorCollection;
			return propertyDescriptorCollection;
		}

		// Token: 0x060018E3 RID: 6371 RVA: 0x00045EB4 File Offset: 0x000440B4
		public virtual object GetEditor(Type editorBaseType)
		{
			if (this._editorTypes != null)
			{
				if (this._editorCount == 0)
				{
				}
				Type[] editorTypes = this._editorTypes;
			}
			if (this != null)
			{
				string displayName = this.displayName;
				Type typeFromName = this.GetTypeFromName(displayName);
				bool flag = editorBaseType == typeFromName;
				int nameHash = this.nameHash;
			}
			if (this._editorTypes == null)
			{
				Type[] editorTypes2 = this._editorTypes;
			}
			int editorCount = this._editorCount;
			object[] editors = this._editors;
			Type[] editorTypes3 = this._editorTypes;
			object[] editors2 = this._editors;
			int editorCount2 = this._editorCount;
			if (editorBaseType != null)
			{
				if (editorBaseType == null)
				{
					goto IL_00B1;
				}
				int editorCount3 = this._editorCount;
			}
			object[] editors3 = this._editors;
			object obj;
			if (obj == null || obj != null)
			{
				return obj;
			}
			IL_00B1:
			throw new ArrayTypeMismatchException();
		}

		// Token: 0x060018E4 RID: 6372 RVA: 0x00002050 File Offset: 0x00000250
		public override int GetHashCode()
		{
			throw new global::Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x060018E5 RID: 6373 RVA: 0x00045F78 File Offset: 0x00044178
		protected override object GetInvocationTarget(Type type, object instance)
		{
			object invocationTarget = base.GetInvocationTarget(type, instance);
			if (invocationTarget != null)
			{
				return invocationTarget;
			}
			return invocationTarget;
		}

		// Token: 0x060018E6 RID: 6374 RVA: 0x00045F98 File Offset: 0x00044198
		protected Type GetTypeFromName(string typeName)
		{
			if (typeName == null)
			{
				return;
			}
			int stringLength = typeName._stringLength;
			if (stringLength != 0)
			{
				if (stringLength == 0)
				{
				}
				bool flag;
				if (!flag)
				{
				}
				long num = 0L;
				int num2;
				string text = typeName.Substring((int)num, num2);
				return;
			}
		}

		// Token: 0x060018E7 RID: 6375
		public abstract object GetValue(object component);

		// Token: 0x060018E8 RID: 6376 RVA: 0x00045FCC File Offset: 0x000441CC
		protected virtual void OnValueChanged(object component, EventArgs e)
		{
			if (component != null)
			{
				Hashtable valueChangedHandlers = this._valueChangedHandlers;
				if (valueChangedHandlers != null && valueChangedHandlers != null)
				{
					IEqualityComparer keycomparer = valueChangedHandlers._keycomparer;
					int count = valueChangedHandlers._count;
					int version = valueChangedHandlers._version;
					return;
				}
			}
		}

		// Token: 0x060018E9 RID: 6377 RVA: 0x00046008 File Offset: 0x00044208
		public virtual void RemoveValueChanged(object component, EventHandler handler)
		{
			if (component == null)
			{
				return;
			}
			if (handler == null)
			{
				throw new InvalidCastException();
			}
			Hashtable valueChangedHandlers = this._valueChangedHandlers;
			if (valueChangedHandlers == null)
			{
				return;
			}
			if (valueChangedHandlers != null)
			{
			}
			Delegate @delegate;
			if (@delegate != null)
			{
				Hashtable valueChangedHandlers2 = this._valueChangedHandlers;
				return;
			}
			Hashtable valueChangedHandlers3 = this._valueChangedHandlers;
		}

		// Token: 0x060018EA RID: 6378 RVA: 0x00046048 File Offset: 0x00044248
		protected internal EventHandler GetValueChangedHandler(object component)
		{
			while (component != null)
			{
				Hashtable valueChangedHandlers = this._valueChangedHandlers;
				if (valueChangedHandlers != null && valueChangedHandlers != null)
				{
					throw new InvalidCastException();
				}
			}
		}

		// Token: 0x060018EB RID: 6379
		public abstract void ResetValue(object component);

		// Token: 0x060018EC RID: 6380
		public abstract void SetValue(object component, object value);

		// Token: 0x060018ED RID: 6381
		public abstract bool ShouldSerializeValue(object component);

		// Token: 0x170005B1 RID: 1457
		// (get) Token: 0x060018EE RID: 6382 RVA: 0x0004606C File Offset: 0x0004426C
		public virtual bool SupportsChangeEvents
		{
			get
			{
			}
		}

		// Token: 0x040012A1 RID: 4769
		private TypeConverter _converter;

		// Token: 0x040012A2 RID: 4770
		private Hashtable _valueChangedHandlers;

		// Token: 0x040012A3 RID: 4771
		private object[] _editors;

		// Token: 0x040012A4 RID: 4772
		private Type[] _editorTypes;

		// Token: 0x040012A5 RID: 4773
		private int _editorCount;
	}
}
