using System;
using System.Globalization;

namespace UnityEngine
{
	// Token: 0x02000088 RID: 136
	public struct Ray : IFormattable
	{
		// Token: 0x06000277 RID: 631 RVA: 0x0000596C File Offset: 0x00003B6C
		public Ray(Vector3 origin, Vector3 direction)
		{
		}

		// Token: 0x1700008E RID: 142
		// (get) Token: 0x06000278 RID: 632 RVA: 0x0000597C File Offset: 0x00003B7C
		public Vector3 origin
		{
			get
			{
				Vector3 origin = this.m_Origin;
				Vector3 vector;
				return vector;
			}
		}

		// Token: 0x1700008F RID: 143
		// (get) Token: 0x06000279 RID: 633 RVA: 0x00005994 File Offset: 0x00003B94
		public Vector3 direction
		{
			get
			{
				float x = this.m_Direction.x;
				float y = this.m_Direction.y;
				float z = this.m_Direction.z;
				Vector3 vector;
				return vector;
			}
		}

		// Token: 0x0600027A RID: 634 RVA: 0x000059C8 File Offset: 0x00003BC8
		public Vector3 GetPoint(float distance)
		{
			float z = this.m_Direction.z;
			Vector3 vector;
			return vector;
		}

		// Token: 0x0600027B RID: 635 RVA: 0x000059E4 File Offset: 0x00003BE4
		public override string ToString()
		{
			string text;
			return text;
		}

		// Token: 0x0600027C RID: 636 RVA: 0x000059F4 File Offset: 0x00003BF4
		public string ToString(string format, IFormatProvider formatProvider)
		{
			bool flag = string.IsNullOrEmpty(format);
			if (formatProvider == null)
			{
				CultureInfo invariantCulture = CultureInfo.InvariantCulture;
			}
			string text;
			string text2;
			if ((text == null || text != null) && (text2 == null || text2 != null))
			{
				string text3;
				return text3;
			}
			throw new ArrayTypeMismatchException();
		}

		// Token: 0x0400031F RID: 799
		private Vector3 m_Origin;

		// Token: 0x04000320 RID: 800
		private Vector3 m_Direction;
	}
}
