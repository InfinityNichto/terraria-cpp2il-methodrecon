using System;
using UnityEngine.Scripting;

namespace UnityEngine.Experimental.GlobalIllumination
{
	// Token: 0x02000135 RID: 309
	[UsedByNativeCode]
	public struct LightDataGI
	{
		// Token: 0x060005EF RID: 1519 RVA: 0x0000A8EC File Offset: 0x00008AEC
		public void Init(DirectionalLight light, Cookie cookie)
		{
			Vector3 vector = light.position;
			float z = light.position.z;
			this.position.z = z;
			Vector2 sizes = cookie.sizes;
			float penumbraWidthRadian = light.penumbraWidthRadian;
			this.shape0 = penumbraWidthRadian;
			LightMode lightMode = light.mode;
			this.mode = lightMode;
			bool flag = light.shadow;
			this.falloff = FalloffType.Undefined;
			this.shadow = (flag ? 1 : 0);
		}

		// Token: 0x060005F0 RID: 1520 RVA: 0x0000A954 File Offset: 0x00008B54
		public void Init(PointLight light, Cookie cookie)
		{
			float z = light.position.z;
			Vector3 vector = light.position;
			this.position.z = z;
			float num = light.range;
			this.range = num;
			float sphereRadius = light.sphereRadius;
			this.type = LightType.Point;
			this.shape0 = sphereRadius;
			LightMode lightMode = light.mode;
			this.mode = lightMode;
			bool flag = light.shadow;
			this.shadow = (flag ? 1 : 0);
			FalloffType falloffType = light.falloff;
			this.falloff = falloffType;
		}

		// Token: 0x060005F1 RID: 1521 RVA: 0x0000A9D4 File Offset: 0x00008BD4
		public void Init(SpotLight light, Cookie cookie)
		{
			float z = light.position.z;
			Vector3 vector = light.position;
			this.position.z = z;
			byte value__ = light.angularFalloff.value__;
			this.type = LightType.Spot;
			LightMode lightMode = light.mode;
			this.mode = lightMode;
			bool flag = light.shadow;
			this.shadow = (flag ? 1 : 0);
			FalloffType falloffType = light.falloff;
			this.falloff = falloffType;
		}

		// Token: 0x060005F2 RID: 1522 RVA: 0x0000AA44 File Offset: 0x00008C44
		public void Init(RectangleLight light, Cookie cookie)
		{
			float z = light.position.z;
			Vector3 vector = light.position;
			this.position.z = z;
			float num = light.range;
			this.range = num;
			float width = light.width;
			this.type = LightType.Rectangle;
			LightMode lightMode = light.mode;
			this.mode = lightMode;
			bool flag = light.shadow;
			this.shadow = (flag ? 1 : 0);
			FalloffType falloffType = light.falloff;
			this.falloff = falloffType;
		}

		// Token: 0x060005F3 RID: 1523 RVA: 0x0000AABC File Offset: 0x00008CBC
		public void Init(DiscLight light, Cookie cookie)
		{
			float z = light.position.z;
			Vector3 vector = light.position;
			this.position.z = z;
			float num = light.range;
			this.range = num;
			float radius = light.radius;
			this.type = LightType.Disc;
			this.shape0 = radius;
			LightMode lightMode = light.mode;
			this.mode = lightMode;
			bool flag = light.shadow;
			this.shadow = (flag ? 1 : 0);
			FalloffType falloffType = light.falloff;
			this.falloff = falloffType;
		}

		// Token: 0x060005F4 RID: 1524 RVA: 0x0000AB3C File Offset: 0x00008D3C
		public void InitNoBake(int lightInstanceID)
		{
			this.instanceID = lightInstanceID;
			this.mode = LightMode.Unknown;
		}

		// Token: 0x0400054B RID: 1355
		public int instanceID;

		// Token: 0x0400054C RID: 1356
		public int cookieID;

		// Token: 0x0400054D RID: 1357
		public float cookieScale;

		// Token: 0x0400054E RID: 1358
		public LinearColor color;

		// Token: 0x0400054F RID: 1359
		public LinearColor indirectColor;

		// Token: 0x04000550 RID: 1360
		public Quaternion orientation;

		// Token: 0x04000551 RID: 1361
		public Vector3 position;

		// Token: 0x04000552 RID: 1362
		public float range;

		// Token: 0x04000553 RID: 1363
		public float coneAngle;

		// Token: 0x04000554 RID: 1364
		public float innerConeAngle;

		// Token: 0x04000555 RID: 1365
		public float shape0;

		// Token: 0x04000556 RID: 1366
		public float shape1;

		// Token: 0x04000557 RID: 1367
		public LightType type;

		// Token: 0x04000558 RID: 1368
		public LightMode mode;

		// Token: 0x04000559 RID: 1369
		public byte shadow;

		// Token: 0x0400055A RID: 1370
		public FalloffType falloff;
	}
}
