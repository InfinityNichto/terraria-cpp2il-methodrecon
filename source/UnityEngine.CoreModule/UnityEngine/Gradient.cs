using System;
using System.Runtime.InteropServices;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine
{
	// Token: 0x020000D2 RID: 210
	[NativeHeader("Runtime/Export/Math/Gradient.bindings.h")]
	[RequiredByNativeCode]
	[StructLayout(0)]
	public class Gradient : IEquatable<Gradient>
	{
		// Token: 0x0600044D RID: 1101 RVA: 0x00008048 File Offset: 0x00006248
		[FreeFunction(Name = "Gradient_Bindings::Init", IsThreadSafe = true)]
		private static IntPtr Init()
		{
			throw new MissingMethodException();
		}

		// Token: 0x0600044E RID: 1102 RVA: 0x0000805C File Offset: 0x0000625C
		[FreeFunction(Name = "Gradient_Bindings::Cleanup", IsThreadSafe = true, HasExplicitThis = true)]
		private void Cleanup()
		{
			throw new MissingMethodException();
		}

		// Token: 0x0600044F RID: 1103 RVA: 0x00008070 File Offset: 0x00006270
		[FreeFunction("Gradient_Bindings::Internal_Equals", IsThreadSafe = true, HasExplicitThis = true)]
		private bool Internal_Equals(IntPtr other)
		{
			throw new MissingMethodException();
		}

		// Token: 0x06000450 RID: 1104 RVA: 0x00008084 File Offset: 0x00006284
		[RequiredByNativeCode]
		public Gradient()
		{
			throw new MissingMethodException();
		}

		// Token: 0x06000451 RID: 1105 RVA: 0x000080A0 File Offset: 0x000062A0
		protected override void Finalize()
		{
			throw new MissingMethodException();
		}

		// Token: 0x06000452 RID: 1106 RVA: 0x000080DC File Offset: 0x000062DC
		public override bool Equals(object o)
		{
			if (o != null)
			{
				Type type = o.GetType();
				Type type2 = base.GetType();
			}
			bool flag;
			return flag;
		}

		// Token: 0x06000453 RID: 1107 RVA: 0x00008108 File Offset: 0x00006308
		public bool Equals(Gradient other)
		{
			if (other != null)
			{
				IntPtr ptr = other.m_Ptr;
			}
			IntPtr ptr2 = other.m_Ptr;
			throw new MissingMethodException();
		}

		// Token: 0x06000454 RID: 1108 RVA: 0x00008130 File Offset: 0x00006330
		public override int GetHashCode()
		{
			int num;
			return num;
		}

		// Token: 0x040003CA RID: 970
		internal IntPtr m_Ptr;
	}
}
