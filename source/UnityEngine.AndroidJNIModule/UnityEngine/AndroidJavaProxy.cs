using System;
using System.Reflection;

namespace UnityEngine
{
	// Token: 0x02000007 RID: 7
	public class AndroidJavaProxy
	{
		// Token: 0x0600006C RID: 108 RVA: 0x000035C8 File Offset: 0x000017C8
		public AndroidJavaProxy(string javaInterface)
		{
		}

		// Token: 0x0600006D RID: 109 RVA: 0x000035D8 File Offset: 0x000017D8
		public AndroidJavaProxy(AndroidJavaClass javaInterface)
		{
			this.javaInterface = javaInterface;
		}

		// Token: 0x0600006E RID: 110 RVA: 0x000035F4 File Offset: 0x000017F4
		protected override void Finalize()
		{
			AndroidJNISafe.DeleteWeakGlobalRef(this.proxyObject);
			base.Finalize();
		}

		// Token: 0x0600006F RID: 111 RVA: 0x00003634 File Offset: 0x00001834
		public virtual AndroidJavaObject Invoke(string methodName, object[] args)
		{
			if (!true)
			{
			}
			Type type;
			if (type == null || type != null)
			{
				Type type2 = base.GetType();
				MethodInfo methodInfo;
				if (methodInfo != null)
				{
					return _AndroidJNIHelper.Box(methodInfo.Invoke(this, args));
				}
				if (false)
				{
					string text;
					if (text.GetType() != null)
					{
					}
					throw new ArrayTypeMismatchException();
				}
				IntPtr rawProxy = this.GetRawProxy();
				if ("No such proxy method: " == null || "No such proxy method: " != null)
				{
					Type type3 = base.GetType();
					if (type3 == null || type3 == null || type3 == null)
					{
					}
					string text2;
					if (("." == null || "." != null) && (methodName == null || methodName != null) && ("(" == null || "(" != null) && (text2 == null || text2 != null) && (")" == null || ")" != null))
					{
					}
				}
			}
			throw new ArrayTypeMismatchException();
		}

		// Token: 0x06000070 RID: 112 RVA: 0x0000371C File Offset: 0x0000191C
		public virtual AndroidJavaObject Invoke(string methodName, AndroidJavaObject[] javaArgs)
		{
			GlobalJavaObjectRef jclass = javaArgs.m_jclass;
			GlobalJavaObjectRef jclass2 = javaArgs.m_jclass;
			object obj;
			if ((obj != null && obj == null) || obj != null)
			{
			}
			throw new ArrayTypeMismatchException();
		}

		// Token: 0x06000071 RID: 113 RVA: 0x00003748 File Offset: 0x00001948
		public virtual bool equals(AndroidJavaObject obj)
		{
			if (obj == null || obj.m_jobject != null)
			{
			}
			IntPtr intPtr = this.proxyObject;
			throw new MissingMethodException();
		}

		// Token: 0x06000072 RID: 114 RVA: 0x0000376C File Offset: 0x0000196C
		public virtual int hashCode()
		{
			IntPtr rawProxy = this.GetRawProxy();
			if (!true)
			{
			}
			int num;
			return num;
		}

		// Token: 0x06000073 RID: 115 RVA: 0x00003784 File Offset: 0x00001984
		public virtual string toString()
		{
			if (this != null)
			{
			}
			string text;
			return text;
		}

		// Token: 0x06000074 RID: 116 RVA: 0x00003798 File Offset: 0x00001998
		internal AndroidJavaObject GetProxyObject()
		{
			return AndroidJavaObject.AndroidJavaObjectDeleteLocalRef(this.GetRawProxy());
		}

		// Token: 0x06000075 RID: 117 RVA: 0x000037B0 File Offset: 0x000019B0
		internal IntPtr GetRawProxy()
		{
			IntPtr intPtr = this.proxyObject;
			IntPtr intPtr2 = this.proxyObject;
			throw new MissingMethodException();
		}

		// Token: 0x06000076 RID: 118 RVA: 0x000037F8 File Offset: 0x000019F8
		// Note: this type is marked as 'beforefieldinit'.
		static AndroidJavaProxy()
		{
			IntPtr intPtr = AndroidJNISafe.FindClass("java/lang/System");
		}

		// Token: 0x04000005 RID: 5
		public readonly AndroidJavaClass javaInterface;

		// Token: 0x04000006 RID: 6
		internal IntPtr proxyObject;

		// Token: 0x04000007 RID: 7
		private static readonly GlobalJavaObjectRef s_JavaLangSystemClass;

		// Token: 0x04000008 RID: 8
		private static readonly IntPtr s_HashCodeMethodID;
	}
}
