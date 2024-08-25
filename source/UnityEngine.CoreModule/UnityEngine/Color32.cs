using System;
using System.Globalization;
using System.Reflection;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine
{
	// Token: 0x020000CE RID: 206
	[DefaultMember("Item")]
	[UsedByNativeCode]
	[StructLayout(2)]
	public struct Color32 : IFormattable
	{
		// Token: 0x060003F2 RID: 1010 RVA: 0x00007B28 File Offset: 0x00005D28
		public Color32(byte r, byte g, byte b, byte a)
		{
			this.rgba = (int)r;
			this.g = g;
			this.b = b;
			this.a = a;
		}

		// Token: 0x060003F3 RID: 1011 RVA: 0x000021B3 File Offset: 0x000003B3
		public static implicit operator Color32(Color c)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x060003F4 RID: 1012 RVA: 0x000021B3 File Offset: 0x000003B3
		public static implicit operator Color(Color32 c)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x060003F5 RID: 1013 RVA: 0x000021B3 File Offset: 0x000003B3
		public static Color32 Lerp(Color32 a, Color32 b, float t)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x060003F6 RID: 1014 RVA: 0x00007B54 File Offset: 0x00005D54
		public override string ToString()
		{
			string text;
			return text;
		}

		// Token: 0x060003F7 RID: 1015 RVA: 0x00007B64 File Offset: 0x00005D64
		public string ToString(string format, IFormatProvider formatProvider)
		{
			if (formatProvider == null)
			{
				CultureInfo invariantCulture = CultureInfo.InvariantCulture;
			}
			string text;
			string text2;
			string text3;
			string text4;
			if ((text == null || text != null) && (text2 == null || text2 != null) && (text3 == null || text3 != null) && (text4 == null || text4 != null))
			{
				string text5;
				return text5;
			}
			throw new ArrayTypeMismatchException();
		}

		// Token: 0x040003BB RID: 955
		[Ignore(DoesNotContributeToSize = true)]
		private int rgba;

		// Token: 0x040003BC RID: 956
		public byte r;

		// Token: 0x040003BD RID: 957
		public byte g;

		// Token: 0x040003BE RID: 958
		public byte b;

		// Token: 0x040003BF RID: 959
		public byte a;
	}
}
