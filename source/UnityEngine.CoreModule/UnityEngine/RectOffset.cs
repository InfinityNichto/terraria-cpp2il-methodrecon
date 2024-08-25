using System;
using System.Globalization;
using System.Runtime.InteropServices;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine
{
	// Token: 0x02000084 RID: 132
	[UsedByNativeCode]
	[NativeHeader("Modules/IMGUI/GUIStyle.h")]
	[Serializable]
	[StructLayout(0)]
	public class RectOffset : IFormattable
	{
		// Token: 0x0600022D RID: 557 RVA: 0x00005160 File Offset: 0x00003360
		public RectOffset()
		{
			throw new MissingMethodException();
		}

		// Token: 0x0600022E RID: 558 RVA: 0x0000517C File Offset: 0x0000337C
		[VisibleToOtherModules(new string[] { "UnityEngine.IMGUIModule" })]
		internal RectOffset(object sourceStyle, IntPtr source)
		{
			this.m_Ptr = source;
			this.m_SourceStyle = sourceStyle;
		}

		// Token: 0x0600022F RID: 559 RVA: 0x000051A0 File Offset: 0x000033A0
		protected override void Finalize()
		{
			if (this.m_SourceStyle == null)
			{
				this.Destroy();
			}
			base.Finalize();
		}

		// Token: 0x06000230 RID: 560 RVA: 0x000051E0 File Offset: 0x000033E0
		public override string ToString()
		{
			string text;
			return text;
		}

		// Token: 0x06000231 RID: 561 RVA: 0x000051F0 File Offset: 0x000033F0
		public string ToString(string format, IFormatProvider formatProvider)
		{
			if (formatProvider == null)
			{
				CultureInfo invariantCulture = CultureInfo.InvariantCulture;
			}
			throw new MissingMethodException();
		}

		// Token: 0x06000232 RID: 562 RVA: 0x00005248 File Offset: 0x00003448
		private void Destroy()
		{
			IntPtr ptr = this.m_Ptr;
			IntPtr ptr2 = this.m_Ptr;
			throw new MissingMethodException();
		}

		// Token: 0x06000233 RID: 563 RVA: 0x0000526C File Offset: 0x0000346C
		[ThreadAndSerializationSafe]
		private static IntPtr InternalCreate()
		{
			throw new MissingMethodException();
		}

		// Token: 0x06000234 RID: 564 RVA: 0x00005280 File Offset: 0x00003480
		[ThreadAndSerializationSafe]
		private static void InternalDestroy(IntPtr ptr)
		{
			throw new MissingMethodException();
		}

		// Token: 0x17000074 RID: 116
		// (get) Token: 0x06000235 RID: 565 RVA: 0x00005294 File Offset: 0x00003494
		[NativeProperty("left", false, TargetType.Field)]
		public int left
		{
			get
			{
				throw new MissingMethodException();
			}
		}

		// Token: 0x17000075 RID: 117
		// (get) Token: 0x06000236 RID: 566 RVA: 0x000052A8 File Offset: 0x000034A8
		[NativeProperty("right", false, TargetType.Field)]
		public int right
		{
			get
			{
				throw new MissingMethodException();
			}
		}

		// Token: 0x17000076 RID: 118
		// (get) Token: 0x06000237 RID: 567 RVA: 0x000052BC File Offset: 0x000034BC
		[NativeProperty("top", false, TargetType.Field)]
		public int top
		{
			get
			{
				throw new MissingMethodException();
			}
		}

		// Token: 0x17000077 RID: 119
		// (get) Token: 0x06000238 RID: 568 RVA: 0x000052D0 File Offset: 0x000034D0
		[NativeProperty("bottom", false, TargetType.Field)]
		public int bottom
		{
			get
			{
				throw new MissingMethodException();
			}
		}

		// Token: 0x17000078 RID: 120
		// (get) Token: 0x06000239 RID: 569 RVA: 0x000052E4 File Offset: 0x000034E4
		public int horizontal
		{
			get
			{
				throw new MissingMethodException();
			}
		}

		// Token: 0x17000079 RID: 121
		// (get) Token: 0x0600023A RID: 570 RVA: 0x000052F8 File Offset: 0x000034F8
		public int vertical
		{
			get
			{
				throw new MissingMethodException();
			}
		}

		// Token: 0x04000315 RID: 789
		[VisibleToOtherModules(new string[] { "UnityEngine.IMGUIModule" })]
		[NonSerialized]
		internal IntPtr m_Ptr;

		// Token: 0x04000316 RID: 790
		private readonly object m_SourceStyle;
	}
}
