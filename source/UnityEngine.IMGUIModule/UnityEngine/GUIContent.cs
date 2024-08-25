using System;
using System.Runtime.InteropServices;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine
{
	// Token: 0x02000011 RID: 17
	[RequiredByNativeCode(Optional = true, GenerateProxy = true)]
	[NativeHeader("Modules/IMGUI/GUIContent.h")]
	[Serializable]
	[StructLayout(0)]
	public class GUIContent
	{
		// Token: 0x17000026 RID: 38
		// (get) Token: 0x06000089 RID: 137 RVA: 0x00003298 File Offset: 0x00001498
		// (set) Token: 0x0600008A RID: 138 RVA: 0x000032AC File Offset: 0x000014AC
		public string text
		{
			get
			{
				return this.m_Text;
			}
			set
			{
				this.m_Text = value;
			}
		}

		// Token: 0x17000027 RID: 39
		// (set) Token: 0x0600008B RID: 139 RVA: 0x000032C0 File Offset: 0x000014C0
		public Texture image
		{
			set
			{
				this.m_Image = value;
			}
		}

		// Token: 0x17000028 RID: 40
		// (get) Token: 0x0600008C RID: 140 RVA: 0x000032D4 File Offset: 0x000014D4
		// (set) Token: 0x0600008D RID: 141 RVA: 0x000032E8 File Offset: 0x000014E8
		public string tooltip
		{
			get
			{
				return this.m_Tooltip;
			}
			set
			{
				this.m_Tooltip = value;
			}
		}

		// Token: 0x0600008E RID: 142 RVA: 0x000032FC File Offset: 0x000014FC
		public GUIContent()
		{
		}

		// Token: 0x0600008F RID: 143 RVA: 0x00003310 File Offset: 0x00001510
		public GUIContent(string text)
		{
		}

		// Token: 0x06000090 RID: 144 RVA: 0x00003320 File Offset: 0x00001520
		public GUIContent(string text, Texture image, string tooltip)
		{
			this.m_Text = text;
			this.m_Image = image;
			this.m_Tooltip = tooltip;
		}

		// Token: 0x06000091 RID: 145 RVA: 0x00003348 File Offset: 0x00001548
		public GUIContent(GUIContent src)
		{
			string text = src.m_Text;
			this.m_Text = text;
			string tooltip = src.m_Tooltip;
			this.m_Tooltip = tooltip;
		}

		// Token: 0x06000092 RID: 146 RVA: 0x00003378 File Offset: 0x00001578
		internal static GUIContent Temp(string t)
		{
			if (!true)
			{
			}
			return 1;
		}

		// Token: 0x06000093 RID: 147 RVA: 0x0000338C File Offset: 0x0000158C
		internal static void ClearStaticCache()
		{
			if (!true)
			{
			}
		}

		// Token: 0x06000094 RID: 148 RVA: 0x0000339C File Offset: 0x0000159C
		public override string ToString()
		{
			string tooltip;
			if (this.m_Text == null)
			{
				tooltip = this.m_Tooltip;
				if (tooltip == null)
				{
					return tooltip.ToString();
				}
			}
			return tooltip;
		}

		// Token: 0x06000095 RID: 149 RVA: 0x000033C4 File Offset: 0x000015C4
		// Note: this type is marked as 'beforefieldinit'.
		static GUIContent()
		{
		}

		// Token: 0x04000069 RID: 105
		[SerializeField]
		private string m_Text;

		// Token: 0x0400006A RID: 106
		[SerializeField]
		private Texture m_Image;

		// Token: 0x0400006B RID: 107
		[SerializeField]
		private string m_Tooltip;

		// Token: 0x0400006C RID: 108
		private static readonly GUIContent s_Text;

		// Token: 0x0400006D RID: 109
		private static readonly GUIContent s_Image;

		// Token: 0x0400006E RID: 110
		private static readonly GUIContent s_TextImage;

		// Token: 0x0400006F RID: 111
		public static GUIContent none;
	}
}
