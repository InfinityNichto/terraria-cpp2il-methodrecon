using System;
using System.Collections;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Threading;
using Cpp2IlInjected;

namespace System.ComponentModel
{
	// Token: 0x020003E6 RID: 998
	[ComVisible(true)]
	public abstract class MemberDescriptor
	{
		// Token: 0x06001A5A RID: 6746 RVA: 0x00048EA8 File Offset: 0x000470A8
		protected MemberDescriptor(string name)
		{
		}

		// Token: 0x06001A5B RID: 6747 RVA: 0x00048EB8 File Offset: 0x000470B8
		protected MemberDescriptor(string name, Attribute[] attributes)
		{
			if (name == null || name._stringLength == 0)
			{
				string @string = SR.GetString("Invalid member name.");
				return;
			}
			this.name = name;
			this.displayName = name;
			this.nameHash = name;
			if (attributes != null)
			{
				this.attributes = attributes;
				return;
			}
			Attribute[] array = this.attributes;
			this.originalAttributes = array;
		}

		// Token: 0x06001A5C RID: 6748 RVA: 0x00048F14 File Offset: 0x00047114
		protected MemberDescriptor(MemberDescriptor descr)
		{
			this.name = descr;
			this.displayName = descr;
			this.nameHash = descr;
			Attribute[] array = this.attributes;
			Attribute[] array2 = this.attributes;
			this.attributesFiltered = true;
			this.originalAttributes = array2;
		}

		// Token: 0x06001A5D RID: 6749 RVA: 0x00048F5C File Offset: 0x0004715C
		protected MemberDescriptor(MemberDescriptor oldMemberDescriptor, Attribute[] newAttributes)
		{
			this.name = oldMemberDescriptor;
			string text = this.name;
			this.displayName = oldMemberDescriptor;
			this.nameHash = text;
			int num;
			if (num != 0)
			{
				return;
			}
			if (newAttributes != null)
			{
			}
			Attribute[] array = this.attributes;
			this.originalAttributes = array;
		}

		// Token: 0x1700060C RID: 1548
		// (get) Token: 0x06001A5E RID: 6750 RVA: 0x00048FC8 File Offset: 0x000471C8
		// (set) Token: 0x06001A5F RID: 6751 RVA: 0x00048FE8 File Offset: 0x000471E8
		protected virtual Attribute[] AttributeArray
		{
			get
			{
				this.CheckAttributesValid();
				this.FilterAttributesIfNeeded();
				return this.attributes;
			}
			set
			{
				object obj = this.lockCookie;
				long num = 0L;
				this.attributes = value;
				this.originalAttributes = value;
				Monitor.Exit(obj);
				if (num == 0L)
				{
					return;
				}
				throw new OutOfMemoryException();
			}
		}

		// Token: 0x1700060D RID: 1549
		// (get) Token: 0x06001A60 RID: 6752 RVA: 0x00049038 File Offset: 0x00047238
		public virtual AttributeCollection Attributes
		{
			get
			{
				this.CheckAttributesValid();
				if (this.attributeCollection == null)
				{
					object obj = this.lockCookie;
					long num = 0L;
					this.attributeCollection = this;
					Monitor.Exit(obj);
					if (num == 0L)
					{
					}
				}
				throw new OutOfMemoryException();
			}
		}

		// Token: 0x1700060E RID: 1550
		// (get) Token: 0x06001A61 RID: 6753 RVA: 0x0004908C File Offset: 0x0004728C
		public virtual string Category
		{
			get
			{
				string text;
				if (this.category == null)
				{
					if (this != null)
					{
					}
					this.category = text;
				}
				return text;
			}
		}

		// Token: 0x1700060F RID: 1551
		// (get) Token: 0x06001A62 RID: 6754 RVA: 0x000490B4 File Offset: 0x000472B4
		public virtual string Description
		{
			get
			{
				if (this.description == null)
				{
					this.description = this;
				}
				throw new InvalidCastException();
			}
		}

		// Token: 0x17000610 RID: 1552
		// (get) Token: 0x06001A63 RID: 6755 RVA: 0x000490D8 File Offset: 0x000472D8
		public virtual bool IsBrowsable
		{
			get
			{
				if (this != null)
				{
				}
				string text = this.name;
				throw new InvalidCastException();
			}
		}

		// Token: 0x17000611 RID: 1553
		// (get) Token: 0x06001A64 RID: 6756 RVA: 0x000490F4 File Offset: 0x000472F4
		public virtual string Name
		{
			get
			{
				string text = this.name;
				return "";
			}
		}

		// Token: 0x17000612 RID: 1554
		// (get) Token: 0x06001A65 RID: 6757 RVA: 0x00049110 File Offset: 0x00047310
		protected virtual int NameHashCode
		{
			get
			{
				return this.nameHash;
			}
		}

		// Token: 0x17000613 RID: 1555
		// (get) Token: 0x06001A66 RID: 6758 RVA: 0x00049124 File Offset: 0x00047324
		public virtual bool DesignTimeOnly
		{
			get
			{
				if (!true)
				{
				}
				return true;
			}
		}

		// Token: 0x17000614 RID: 1556
		// (get) Token: 0x06001A67 RID: 6759 RVA: 0x00049138 File Offset: 0x00047338
		public virtual string DisplayName
		{
			get
			{
				if (this != null)
				{
				}
				return this.displayName;
			}
		}

		// Token: 0x06001A68 RID: 6760 RVA: 0x00049150 File Offset: 0x00047350
		private void CheckAttributesValid()
		{
			bool flag = this.attributesFiltered;
			if (flag)
			{
				int num = this.metadataVersion;
				if (!flag)
				{
				}
				if (!true)
				{
				}
			}
		}

		// Token: 0x06001A69 RID: 6761 RVA: 0x00002050 File Offset: 0x00000250
		protected virtual AttributeCollection CreateAttributeCollection()
		{
			throw new global::Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06001A6A RID: 6762 RVA: 0x00049174 File Offset: 0x00047374
		public override bool Equals(object obj)
		{
			if (obj != null)
			{
				Type type = obj.GetType();
				Type type2 = base.GetType();
				bool flag = type != type2;
				this.FilterAttributesIfNeeded();
				int num = this.nameHash;
				if (this.category != null)
				{
				}
				string text = this.description;
				if (text != null)
				{
					bool flag2;
					return flag2;
				}
				if (this.attributes != null)
				{
					Attribute[] array = this.attributes;
				}
			}
			throw new InvalidCastException();
		}

		// Token: 0x06001A6B RID: 6763 RVA: 0x000491E0 File Offset: 0x000473E0
		protected virtual void FillAttributes(IList attributeList)
		{
			if (this.originalAttributes != null)
			{
				return;
			}
		}

		// Token: 0x06001A6C RID: 6764 RVA: 0x000491FC File Offset: 0x000473FC
		private void FilterAttributesIfNeeded()
		{
			if (this.attributesFiltered)
			{
				return;
			}
			bool flag = this.attributesFilled;
			if (flag)
			{
				Attribute[] array = this.attributes;
				return;
			}
			if (flag)
			{
			}
		}

		// Token: 0x06001A6D RID: 6765 RVA: 0x00049300 File Offset: 0x00047500
		protected static MethodInfo FindMethod(Type componentClass, string name, Type[] args, Type returnType)
		{
			MethodInfo methodInfo;
			return methodInfo;
		}

		// Token: 0x06001A6E RID: 6766 RVA: 0x00049310 File Offset: 0x00047510
		protected static MethodInfo FindMethod(Type componentClass, string name, Type[] args, Type returnType, bool publicOnly)
		{
			MethodInfo methodInfo;
			return methodInfo;
		}

		// Token: 0x06001A6F RID: 6767 RVA: 0x00049324 File Offset: 0x00047524
		public override int GetHashCode()
		{
			return this.nameHash;
		}

		// Token: 0x06001A70 RID: 6768 RVA: 0x00049338 File Offset: 0x00047538
		protected virtual object GetInvocationTarget(Type type, object instance)
		{
			do
			{
				if (!true)
				{
				}
			}
			while (instance == null);
			return TypeDescriptor.GetAssociation(type, instance);
		}

		// Token: 0x06001A71 RID: 6769 RVA: 0x00049358 File Offset: 0x00047558
		protected static ISite GetSite(object component)
		{
			long value = 0.m_value;
			throw new InvalidCastException();
		}

		// Token: 0x06001A72 RID: 6770 RVA: 0x00049374 File Offset: 0x00047574
		[Obsolete("This method has been deprecated. Use GetInvocationTarget instead.  http://go.microsoft.com/fwlink/?linkid=14202")]
		protected static object GetInvokee(Type componentClass, object component)
		{
			do
			{
				if (!true)
				{
				}
			}
			while (componentClass == null);
			object obj;
			return obj;
		}

		// Token: 0x0400130D RID: 4877
		private string name;

		// Token: 0x0400130E RID: 4878
		private string displayName;

		// Token: 0x0400130F RID: 4879
		private int nameHash;

		// Token: 0x04001310 RID: 4880
		private AttributeCollection attributeCollection;

		// Token: 0x04001311 RID: 4881
		private Attribute[] attributes;

		// Token: 0x04001312 RID: 4882
		private Attribute[] originalAttributes;

		// Token: 0x04001313 RID: 4883
		private bool attributesFiltered;

		// Token: 0x04001314 RID: 4884
		private bool attributesFilled;

		// Token: 0x04001315 RID: 4885
		private int metadataVersion;

		// Token: 0x04001316 RID: 4886
		private string category;

		// Token: 0x04001317 RID: 4887
		private string description;

		// Token: 0x04001318 RID: 4888
		private object lockCookie;
	}
}
