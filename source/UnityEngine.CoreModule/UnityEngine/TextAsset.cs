using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine.Bindings;

namespace UnityEngine
{
	// Token: 0x020000A8 RID: 168
	[NativeHeader("Runtime/Scripting/TextAsset.h")]
	public class TextAsset : Object
	{
		// Token: 0x170000AE RID: 174
		// (get) Token: 0x0600030B RID: 779 RVA: 0x0000666C File Offset: 0x0000486C
		public byte[] bytes
		{
			get
			{
				throw new MissingMethodException();
			}
		}

		// Token: 0x170000AF RID: 175
		// (get) Token: 0x0600030C RID: 780 RVA: 0x00006680 File Offset: 0x00004880
		public string text
		{
			get
			{
				throw new MissingMethodException();
			}
		}

		// Token: 0x0600030D RID: 781 RVA: 0x00006694 File Offset: 0x00004894
		public override string ToString()
		{
			return this.text;
		}

		// Token: 0x0600030E RID: 782 RVA: 0x000066A8 File Offset: 0x000048A8
		internal static string DecodeString(byte[] bytes)
		{
			if (!true)
			{
			}
			if (!false)
			{
				return;
			}
		}

		// Token: 0x020000A9 RID: 169
		private static class EncodingUtility
		{
			// Token: 0x0600030F RID: 783 RVA: 0x000066C0 File Offset: 0x000048C0
			static EncodingUtility()
			{
				Encoding utf = Encoding.UTF8;
			}

			// Token: 0x04000366 RID: 870
			internal static readonly KeyValuePair<byte[], Encoding>[] encodingLookup;

			// Token: 0x04000367 RID: 871
			internal static readonly Encoding targetEncoding;
		}
	}
}
