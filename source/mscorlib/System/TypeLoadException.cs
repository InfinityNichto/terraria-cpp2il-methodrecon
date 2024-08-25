using System;
using System.Globalization;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace System
{
	// Token: 0x02000160 RID: 352
	[ComVisible(true)]
	[Serializable]
	public class TypeLoadException : SystemException, ISerializable
	{
		// Token: 0x06000E2E RID: 3630 RVA: 0x0001EC58 File Offset: 0x0001CE58
		public TypeLoadException()
			: base("Failure has occurred while loading a type.")
		{
			base.SetErrorCode(5410);
		}

		// Token: 0x06000E2F RID: 3631 RVA: 0x0001EC7C File Offset: 0x0001CE7C
		public TypeLoadException(string message)
			: base(message)
		{
			base.SetErrorCode(5410);
		}

		// Token: 0x17000141 RID: 321
		// (get) Token: 0x06000E30 RID: 3632 RVA: 0x0001EC9C File Offset: 0x0001CE9C
		public override string Message
		{
			get
			{
				this.SetMessageField();
				return this._message;
			}
		}

		// Token: 0x06000E31 RID: 3633 RVA: 0x0001ECB8 File Offset: 0x0001CEB8
		private void SetMessageField()
		{
			if (this._message == null)
			{
				string className = this.ClassName;
				if (className == null && this.ResourceId == 0)
				{
					this._message = "Failure has occurred while loading a type.";
					return;
				}
				if (this.AssemblyName == null)
				{
					this.AssemblyName = "[Unknown]";
				}
				if (className == null)
				{
					this.ClassName = "[Unknown]";
				}
				if ("[Unknown]" == null)
				{
				}
				CultureInfo currentCulture = CultureInfo.CurrentCulture;
				string className2 = this.ClassName;
				string assemblyName = this.AssemblyName;
				string messageArg = this.MessageArg;
				string text = string.Format(currentCulture, "Could not load type '{0}' from assembly '{1}'.", className2, assemblyName, messageArg);
				this._message = text;
			}
		}

		// Token: 0x06000E32 RID: 3634 RVA: 0x0001ED50 File Offset: 0x0001CF50
		private TypeLoadException(string className, string assemblyName)
		{
		}

		// Token: 0x06000E33 RID: 3635 RVA: 0x0001ED60 File Offset: 0x0001CF60
		private TypeLoadException(string className, string assemblyName, string messageArg, int resourceId)
		{
			base.SetErrorCode(5410);
			this.ClassName = className;
			this.AssemblyName = assemblyName;
			this.MessageArg = messageArg;
			this.ResourceId = resourceId;
			this.SetMessageField();
		}

		// Token: 0x06000E34 RID: 3636 RVA: 0x0001ED9C File Offset: 0x0001CF9C
		protected TypeLoadException(SerializationInfo info, StreamingContext context)
		{
			do
			{
				base..ctor(info, context);
			}
			while (info == null);
			string @string = info.GetString("TypeLoadClassName");
			this.ClassName = @string;
			string string2 = info.GetString("TypeLoadAssemblyName");
			this.AssemblyName = string2;
			string string3 = info.GetString("TypeLoadMessageArg");
			this.MessageArg = string3;
			int @int = info.GetInt32("TypeLoadResourceID");
			this.ResourceId = @int;
		}

		// Token: 0x06000E35 RID: 3637 RVA: 0x0001EE00 File Offset: 0x0001D000
		public override void GetObjectData(SerializationInfo info, StreamingContext context)
		{
			while (info == null)
			{
			}
			base.GetObjectData(info, context);
			string className = this.ClassName;
			if (!true)
			{
			}
			Type type;
			info.AddValue("TypeLoadClassName", className, type);
			string assemblyName = this.AssemblyName;
			Type type2;
			info.AddValue("TypeLoadAssemblyName", assemblyName, type2);
			string messageArg = this.MessageArg;
			Type type3;
			info.AddValue("TypeLoadMessageArg", messageArg, type3);
			int resourceId = this.ResourceId;
			info.AddValue("TypeLoadResourceID", resourceId);
		}

		// Token: 0x040005D5 RID: 1493
		private string ClassName;

		// Token: 0x040005D6 RID: 1494
		private string AssemblyName;

		// Token: 0x040005D7 RID: 1495
		private string MessageArg;

		// Token: 0x040005D8 RID: 1496
		internal int ResourceId;
	}
}
