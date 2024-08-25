using System;
using System.Runtime.InteropServices;
using Cpp2IlInjected;

namespace UnityEngine.Experimental.GlobalIllumination
{
	// Token: 0x02000136 RID: 310
	public static class LightmapperUtils
	{
		// Token: 0x060005F5 RID: 1525 RVA: 0x0000AB58 File Offset: 0x00008D58
		public static LightMode Extract(LightmapBakeType baketype)
		{
		}

		// Token: 0x060005F6 RID: 1526 RVA: 0x0000AB68 File Offset: 0x00008D68
		public static LinearColor ExtractIndirect(Light l)
		{
			Color color;
			float num;
			return LinearColor.Convert(color, num);
		}

		// Token: 0x060005F7 RID: 1527 RVA: 0x000021B3 File Offset: 0x000003B3
		public static float ExtractInnerCone(Light l)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x060005F8 RID: 1528 RVA: 0x0000AB7C File Offset: 0x00008D7C
		private static Color ExtractColorTemperature(Light l)
		{
			throw new MissingMethodException();
		}

		// Token: 0x060005F9 RID: 1529 RVA: 0x0000AB9C File Offset: 0x00008D9C
		private static void ApplyColorTemperature(Color cct, LinearColor lightColor)
		{
			float g = cct.g;
			float b = cct.b;
		}

		// Token: 0x060005FA RID: 1530 RVA: 0x0000ABB8 File Offset: 0x00008DB8
		public static void Extract(Light l, DirectionalLight dir)
		{
			int instanceID = l.GetInstanceID();
			dir.instanceID = instanceID;
			LightBakingOutput bakingOutput = l.bakingOutput;
			LightShadows shadows = l.shadows;
			Vector3 position = l.transform.position;
			Quaternion rotation = l.transform.rotation;
			Color color = LightmapperUtils.ExtractColorTemperature(l);
			Color color2 = l.color;
			float intensity = l.intensity;
			LinearColor linearColor = LightmapperUtils.ExtractIndirect(l);
		}

		// Token: 0x060005FB RID: 1531 RVA: 0x0000AC1C File Offset: 0x00008E1C
		public static void Extract(Light l, PointLight point)
		{
			int instanceID = l.GetInstanceID();
			point.instanceID = instanceID;
			LightBakingOutput bakingOutput = l.bakingOutput;
			LightShadows shadows = l.shadows;
			Vector3 position = l.transform.position;
			Quaternion rotation = l.transform.rotation;
			Color color = LightmapperUtils.ExtractColorTemperature(l);
			Color color2 = l.color;
			float intensity = l.intensity;
			LinearColor linearColor = LightmapperUtils.ExtractIndirect(l);
			float range = l.range;
			point.falloff = FalloffType.Legacy;
		}

		// Token: 0x060005FC RID: 1532 RVA: 0x0000AC90 File Offset: 0x00008E90
		public static void Extract(Light l, SpotLight spot)
		{
			int instanceID = l.GetInstanceID();
			spot.instanceID = instanceID;
			LightBakingOutput bakingOutput = l.bakingOutput;
			LightShadows shadows = l.shadows;
			Vector3 position = l.transform.position;
			Quaternion rotation = l.transform.rotation;
			Color color = LightmapperUtils.ExtractColorTemperature(l);
			Color color2 = l.color;
			float intensity = l.intensity;
			LinearColor linearColor = LightmapperUtils.ExtractIndirect(l);
			float range = l.range;
			float spotAngle = l.spotAngle;
			float num = LightmapperUtils.ExtractInnerCone(l);
			spot.falloff = FalloffType.Legacy;
		}

		// Token: 0x060005FD RID: 1533 RVA: 0x0000AD14 File Offset: 0x00008F14
		public static void Extract(Light l, RectangleLight rect)
		{
			int instanceID = l.GetInstanceID();
			rect.instanceID = instanceID;
			LightBakingOutput bakingOutput = l.bakingOutput;
			LightShadows shadows = l.shadows;
			Vector3 position = l.transform.position;
			Quaternion rotation = l.transform.rotation;
			Color color = LightmapperUtils.ExtractColorTemperature(l);
			Color color2 = l.color;
			float intensity = l.intensity;
			LinearColor linearColor = LightmapperUtils.ExtractIndirect(l);
			float range = l.range;
			rect.falloff = FalloffType.Legacy;
		}

		// Token: 0x060005FE RID: 1534 RVA: 0x0000AD88 File Offset: 0x00008F88
		public static void Extract(Light l, DiscLight disc)
		{
			int instanceID = l.GetInstanceID();
			disc.instanceID = instanceID;
			LightBakingOutput bakingOutput = l.bakingOutput;
			LightShadows shadows = l.shadows;
			Vector3 position = l.transform.position;
			Quaternion rotation = l.transform.rotation;
			Color color = LightmapperUtils.ExtractColorTemperature(l);
			Color color2 = l.color;
			float intensity = l.intensity;
			LinearColor linearColor = LightmapperUtils.ExtractIndirect(l);
			float range = l.range;
			disc.falloff = FalloffType.Legacy;
		}

		// Token: 0x060005FF RID: 1535 RVA: 0x0000ADFC File Offset: 0x00008FFC
		public static void Extract(Light l, [Out] Cookie cookie)
		{
			bool flag = l.cookie;
			int instanceID = l.cookie.GetInstanceID();
		}
	}
}
