using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine
{
	// Token: 0x02000036 RID: 54
	[DefaultMember("Item")]
	[NativeHeader("Runtime/Math/AnimationCurve.bindings.h")]
	[RequiredByNativeCode]
	[StructLayout(0)]
	public class AnimationCurve : IEquatable<AnimationCurve>
	{
		// Token: 0x0600004F RID: 79 RVA: 0x000025D8 File Offset: 0x000007D8
		[FreeFunction("AnimationCurveBindings::Internal_Destroy", IsThreadSafe = true)]
		private static void Internal_Destroy(IntPtr ptr)
		{
			throw new MissingMethodException();
		}

		// Token: 0x06000050 RID: 80 RVA: 0x000025EC File Offset: 0x000007EC
		[FreeFunction("AnimationCurveBindings::Internal_Create", IsThreadSafe = true)]
		private static IntPtr Internal_Create(Keyframe[] keys)
		{
			throw new MissingMethodException();
		}

		// Token: 0x06000051 RID: 81 RVA: 0x00002600 File Offset: 0x00000800
		[FreeFunction("AnimationCurveBindings::Internal_Equals", HasExplicitThis = true, IsThreadSafe = true)]
		private bool Internal_Equals(IntPtr other)
		{
			throw new MissingMethodException();
		}

		// Token: 0x06000052 RID: 82 RVA: 0x00002614 File Offset: 0x00000814
		protected override void Finalize()
		{
			IntPtr ptr = this.m_Ptr;
			throw new MissingMethodException();
		}

		// Token: 0x06000053 RID: 83 RVA: 0x00002658 File Offset: 0x00000858
		[ThreadSafe]
		public float Evaluate(float time)
		{
			throw new MissingMethodException();
		}

		// Token: 0x1700000B RID: 11
		// (get) Token: 0x06000054 RID: 84 RVA: 0x0000266C File Offset: 0x0000086C
		public Keyframe[] keys
		{
			get
			{
				throw new MissingMethodException();
			}
		}

		// Token: 0x1700000C RID: 12
		// (get) Token: 0x06000055 RID: 85 RVA: 0x00002680 File Offset: 0x00000880
		public int length
		{
			[NativeMethod("GetKeyCount", IsThreadSafe = true)]
			get
			{
				throw new MissingMethodException();
			}
		}

		// Token: 0x06000056 RID: 86 RVA: 0x00002694 File Offset: 0x00000894
		[FreeFunction("AnimationCurveBindings::GetKeys", HasExplicitThis = true, IsThreadSafe = true)]
		private Keyframe[] GetKeys()
		{
			throw new MissingMethodException();
		}

		// Token: 0x06000057 RID: 87 RVA: 0x000021B3 File Offset: 0x000003B3
		public static AnimationCurve Linear(float timeStart, float valueStart, float timeEnd, float valueEnd)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06000058 RID: 88 RVA: 0x000026A8 File Offset: 0x000008A8
		public AnimationCurve(params Keyframe[] keys)
		{
			throw new MissingMethodException();
		}

		// Token: 0x06000059 RID: 89 RVA: 0x000026C8 File Offset: 0x000008C8
		[RequiredByNativeCode]
		public AnimationCurve()
		{
			throw new MissingMethodException();
		}

		// Token: 0x0600005A RID: 90 RVA: 0x000026EC File Offset: 0x000008EC
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

		// Token: 0x0600005B RID: 91 RVA: 0x00002718 File Offset: 0x00000918
		public bool Equals(AnimationCurve other)
		{
			if (other != null)
			{
				IntPtr ptr = other.m_Ptr;
			}
			IntPtr ptr2 = other.m_Ptr;
			throw new MissingMethodException();
		}

		// Token: 0x0600005C RID: 92 RVA: 0x00002740 File Offset: 0x00000940
		public override int GetHashCode()
		{
			int num;
			return num;
		}

		// Token: 0x040000BC RID: 188
		internal IntPtr m_Ptr;
	}
}
