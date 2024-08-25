using System;

namespace UnityEngine
{
	// Token: 0x02000009 RID: 9
	public class AndroidJavaClass : AndroidJavaObject
	{
		// Token: 0x060000A1 RID: 161 RVA: 0x00003F3C File Offset: 0x0000213C
		public AndroidJavaClass(string className)
		{
			this._AndroidJavaClass(className);
		}

		// Token: 0x060000A2 RID: 162 RVA: 0x00003F58 File Offset: 0x00002158
		private void _AndroidJavaClass(string className)
		{
			string text = "Creating AndroidJavaClass from " + className;
			string text2;
			AndroidJNISafe.DeleteLocalRef(AndroidJNISafe.FindClass(text2));
		}

		// Token: 0x060000A3 RID: 163 RVA: 0x00003F7C File Offset: 0x0000217C
		internal AndroidJavaClass(IntPtr jclass)
		{
		}
	}
}
