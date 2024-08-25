using System;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using UnityEngine.Bindings;

namespace UnityEngine
{
	// Token: 0x0200001B RID: 27
	[NativeHeader("Modules/IMGUI/GUIStyle.bindings.h")]
	[Serializable]
	[StructLayout(0)]
	public sealed class GUIStyleState
	{
		// Token: 0x17000048 RID: 72
		// (set) Token: 0x060000F4 RID: 244 RVA: 0x0000497C File Offset: 0x00002B7C
		[NativeProperty("textColor", false, TargetType.Field)]
		public Color textColor
		{
			set
			{
				throw new MissingMethodException();
			}
		}

		// Token: 0x060000F5 RID: 245 RVA: 0x00004990 File Offset: 0x00002B90
		[FreeFunction(Name = "GUIStyleState_Bindings::Init", IsThreadSafe = true)]
		private static IntPtr Init()
		{
			throw new MissingMethodException();
		}

		// Token: 0x060000F6 RID: 246 RVA: 0x000049A4 File Offset: 0x00002BA4
		[FreeFunction(Name = "GUIStyleState_Bindings::Cleanup", IsThreadSafe = true, HasExplicitThis = true)]
		private void Cleanup()
		{
			throw new MissingMethodException();
		}

		// Token: 0x060000F7 RID: 247 RVA: 0x000049B8 File Offset: 0x00002BB8
		public GUIStyleState()
		{
			throw new MissingMethodException();
		}

		// Token: 0x060000F8 RID: 248 RVA: 0x000049D4 File Offset: 0x00002BD4
		private GUIStyleState(GUIStyle sourceStyle, IntPtr source)
		{
			this.m_Ptr = source;
			this.m_SourceStyle = sourceStyle;
		}

		// Token: 0x060000F9 RID: 249 RVA: 0x000020F5 File Offset: 0x000002F5
		internal static GUIStyleState GetGUIStyleState(GUIStyle sourceStyle, IntPtr source)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x060000FA RID: 250 RVA: 0x000049F8 File Offset: 0x00002BF8
		protected override void Finalize()
		{
			if (this.m_SourceStyle == null)
			{
				throw new MissingMethodException();
			}
			base.Finalize();
		}

		// Token: 0x060000FB RID: 251 RVA: 0x00004A3C File Offset: 0x00002C3C
		private void set_textColor_Injected(Color value)
		{
			throw new MissingMethodException();
		}

		// Token: 0x040000C8 RID: 200
		[NonSerialized]
		internal IntPtr m_Ptr;

		// Token: 0x040000C9 RID: 201
		private readonly GUIStyle m_SourceStyle;
	}
}
