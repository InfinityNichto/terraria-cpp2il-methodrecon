using System;
using System.Runtime.InteropServices;
using UnityEngine.Bindings;

namespace UnityEngine
{
	// Token: 0x0200000C RID: 12
	[NativeType(CodegenOptions.Custom, "ScriptingJvalue")]
	[StructLayout(2)]
	public struct jvalue
	{
		// Token: 0x04000014 RID: 20
		public bool z;

		// Token: 0x04000015 RID: 21
		public sbyte b;

		// Token: 0x04000016 RID: 22
		public char c;

		// Token: 0x04000017 RID: 23
		public short s;

		// Token: 0x04000018 RID: 24
		public int i;

		// Token: 0x04000019 RID: 25
		public long j;

		// Token: 0x0400001A RID: 26
		public float f;

		// Token: 0x0400001B RID: 27
		public double d;

		// Token: 0x0400001C RID: 28
		public IntPtr l;
	}
}
