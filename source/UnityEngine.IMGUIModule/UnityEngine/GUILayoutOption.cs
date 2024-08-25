using System;

namespace UnityEngine
{
	// Token: 0x0200001F RID: 31
	public sealed class GUILayoutOption
	{
		// Token: 0x06000129 RID: 297 RVA: 0x00004EA8 File Offset: 0x000030A8
		internal GUILayoutOption(GUILayoutOption.Type type, object value)
		{
			this.type = type;
			this.value = value;
		}

		// Token: 0x040000DF RID: 223
		internal GUILayoutOption.Type type;

		// Token: 0x040000E0 RID: 224
		internal object value;

		// Token: 0x02000020 RID: 32
		internal enum Type
		{
			// Token: 0x040000E2 RID: 226
			fixedWidth,
			// Token: 0x040000E3 RID: 227
			fixedHeight,
			// Token: 0x040000E4 RID: 228
			minWidth,
			// Token: 0x040000E5 RID: 229
			maxWidth,
			// Token: 0x040000E6 RID: 230
			minHeight,
			// Token: 0x040000E7 RID: 231
			maxHeight,
			// Token: 0x040000E8 RID: 232
			stretchWidth,
			// Token: 0x040000E9 RID: 233
			stretchHeight,
			// Token: 0x040000EA RID: 234
			alignStart,
			// Token: 0x040000EB RID: 235
			alignMiddle,
			// Token: 0x040000EC RID: 236
			alignEnd,
			// Token: 0x040000ED RID: 237
			alignJustify,
			// Token: 0x040000EE RID: 238
			equalSize,
			// Token: 0x040000EF RID: 239
			spacing
		}
	}
}
