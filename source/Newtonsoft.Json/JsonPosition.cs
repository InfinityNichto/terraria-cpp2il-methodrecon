using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using Cpp2IlInjected;
using Newtonsoft.Json.Shims;
using Newtonsoft.Json.Utilities;

namespace Newtonsoft.Json
{
	// Token: 0x02000018 RID: 24
	[Preserve]
	internal struct JsonPosition
	{
		// Token: 0x0600003C RID: 60 RVA: 0x000025FC File Offset: 0x000007FC
		public JsonPosition(JsonContainerType type)
		{
			this.Type = type;
			if (!true)
			{
			}
			this.HasIndex = true;
		}

		// Token: 0x0600003D RID: 61 RVA: 0x0000261C File Offset: 0x0000081C
		internal int CalculateLength()
		{
			int num;
			return num;
		}

		// Token: 0x0600003E RID: 62 RVA: 0x0000262C File Offset: 0x0000082C
		internal void WriteTo(StringBuilder sb)
		{
			int num = 91;
			StringBuilder stringBuilder = sb.Append((char)num);
			int position = this.Position;
			StringBuilder stringBuilder2 = sb.Append(position);
			int num2 = 93;
			StringBuilder stringBuilder3 = sb.Append((char)num2);
		}

		// Token: 0x0600003F RID: 63 RVA: 0x0000212A File Offset: 0x0000032A
		internal static bool TypeHasIndex(JsonContainerType type)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06000040 RID: 64 RVA: 0x000026A4 File Offset: 0x000008A4
		internal static string BuildPath(List<JsonPosition> positions, JsonPosition? currentPosition)
		{
			int size = positions._size;
			int size2 = positions._size;
			throw new OutOfMemoryException();
		}

		// Token: 0x06000041 RID: 65 RVA: 0x000026D8 File Offset: 0x000008D8
		internal static string FormatMessage(IJsonLineInfo lineInfo, string path, string message)
		{
			int num = 1;
			string newLine = Environment.NewLine;
			string text = path.Trim();
			int num2 = 46;
			bool flag = text.EndsWith((char)num2);
			string text2 = text + "." + " ";
			if (num == 0)
			{
			}
			CultureInfo invariantCulture = CultureInfo.InvariantCulture;
			string text3;
			return text2 + text3;
		}

		// Token: 0x06000042 RID: 66 RVA: 0x00002760 File Offset: 0x00000960
		// Note: this type is marked as 'beforefieldinit'.
		static JsonPosition()
		{
		}

		// Token: 0x0400002E RID: 46
		private static readonly char[] SpecialCharacters;

		// Token: 0x0400002F RID: 47
		internal JsonContainerType Type;

		// Token: 0x04000030 RID: 48
		internal int Position;

		// Token: 0x04000031 RID: 49
		internal string PropertyName;

		// Token: 0x04000032 RID: 50
		internal bool HasIndex;
	}
}
