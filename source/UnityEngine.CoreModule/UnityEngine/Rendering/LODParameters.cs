using System;

namespace UnityEngine.Rendering
{
	// Token: 0x02000112 RID: 274
	public struct LODParameters : IEquatable<LODParameters>
	{
		// Token: 0x06000580 RID: 1408 RVA: 0x00009D6C File Offset: 0x00007F6C
		public bool Equals(LODParameters other)
		{
			float x = other.m_CameraPosition.x;
			float x2 = this.m_CameraPosition.x;
			float y = other.m_CameraPosition.y;
			float y2 = this.m_CameraPosition.y;
			float z = other.m_CameraPosition.z;
			float z2 = this.m_CameraPosition.z;
			float fieldOfView = other.m_FieldOfView;
			float orthoSize = other.m_OrthoSize;
			int cameraPixelHeight = this.m_CameraPixelHeight;
			int cameraPixelHeight2 = other.m_CameraPixelHeight;
			bool flag;
			return flag;
		}

		// Token: 0x06000581 RID: 1409 RVA: 0x00009DE8 File Offset: 0x00007FE8
		public override bool Equals(object obj)
		{
			if (obj != null)
			{
			}
			bool flag;
			return flag;
		}

		// Token: 0x06000582 RID: 1410 RVA: 0x00009DFC File Offset: 0x00007FFC
		public override int GetHashCode()
		{
			int cameraPixelHeight = this.m_CameraPixelHeight;
			int num;
			return num;
		}

		// Token: 0x0400048B RID: 1163
		private int m_IsOrthographic;

		// Token: 0x0400048C RID: 1164
		private Vector3 m_CameraPosition;

		// Token: 0x0400048D RID: 1165
		private float m_FieldOfView;

		// Token: 0x0400048E RID: 1166
		private float m_OrthoSize;

		// Token: 0x0400048F RID: 1167
		private int m_CameraPixelHeight;
	}
}
