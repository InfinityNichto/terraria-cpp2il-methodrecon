using System;
using UnityEngine.Bindings;
using UnityEngine.Experimental.Rendering;

namespace UnityEngine
{
	// Token: 0x02000074 RID: 116
	[NativeHeader("Runtime/Misc/SystemInfo.h")]
	[NativeHeader("Runtime/Camera/RenderLoops/MotionVectorRenderLoop.h")]
	[NativeHeader("Runtime/Graphics/Mesh/MeshScriptBindings.h")]
	[NativeHeader("Runtime/Graphics/GraphicsFormatUtility.bindings.h")]
	[NativeHeader("Runtime/Input/GetInput.h")]
	[NativeHeader("Runtime/Shaders/GraphicsCapsScriptBindings.h")]
	public sealed class SystemInfo
	{
		// Token: 0x1700005C RID: 92
		// (get) Token: 0x060001C9 RID: 457 RVA: 0x00004978 File Offset: 0x00002B78
		public static string operatingSystem
		{
			get
			{
				throw new MissingMethodException();
			}
		}

		// Token: 0x1700005D RID: 93
		// (get) Token: 0x060001CA RID: 458 RVA: 0x0000498C File Offset: 0x00002B8C
		public static OperatingSystemFamily operatingSystemFamily
		{
			get
			{
				throw new MissingMethodException();
			}
		}

		// Token: 0x1700005E RID: 94
		// (get) Token: 0x060001CB RID: 459 RVA: 0x000049A0 File Offset: 0x00002BA0
		public static int systemMemorySize
		{
			get
			{
				throw new MissingMethodException();
			}
		}

		// Token: 0x1700005F RID: 95
		// (get) Token: 0x060001CC RID: 460 RVA: 0x000049B4 File Offset: 0x00002BB4
		public static string deviceModel
		{
			get
			{
				throw new MissingMethodException();
			}
		}

		// Token: 0x060001CD RID: 461 RVA: 0x000049C8 File Offset: 0x00002BC8
		private static bool IsValidEnumValue(Enum value)
		{
			long num = 0L;
			Type type;
			return Enum.IsDefined(type, num);
		}

		// Token: 0x060001CE RID: 462 RVA: 0x000049E0 File Offset: 0x00002BE0
		public static bool SupportsTextureFormat(TextureFormat format)
		{
			throw new MissingMethodException();
		}

		// Token: 0x060001CF RID: 463 RVA: 0x000049F4 File Offset: 0x00002BF4
		[FreeFunction("systeminfo::GetOperatingSystem")]
		private static string GetOperatingSystem()
		{
			throw new MissingMethodException();
		}

		// Token: 0x060001D0 RID: 464 RVA: 0x00004A08 File Offset: 0x00002C08
		[FreeFunction("systeminfo::GetOperatingSystemFamily")]
		private static OperatingSystemFamily GetOperatingSystemFamily()
		{
			throw new MissingMethodException();
		}

		// Token: 0x060001D1 RID: 465 RVA: 0x00004A1C File Offset: 0x00002C1C
		[FreeFunction("systeminfo::GetPhysicalMemoryMB")]
		private static int GetPhysicalMemoryMB()
		{
			throw new MissingMethodException();
		}

		// Token: 0x060001D2 RID: 466 RVA: 0x00004A30 File Offset: 0x00002C30
		[FreeFunction("systeminfo::GetDeviceModel")]
		private static string GetDeviceModel()
		{
			throw new MissingMethodException();
		}

		// Token: 0x060001D3 RID: 467 RVA: 0x00004A44 File Offset: 0x00002C44
		[FreeFunction("ScriptingGraphicsCaps::SupportsTextureFormat")]
		private static bool SupportsTextureFormatNative(TextureFormat format)
		{
			throw new MissingMethodException();
		}

		// Token: 0x060001D4 RID: 468 RVA: 0x00004A58 File Offset: 0x00002C58
		[FreeFunction("ScriptingGraphicsCaps::IsFormatSupported")]
		public static bool IsFormatSupported(GraphicsFormat format, FormatUsage usage)
		{
			throw new MissingMethodException();
		}

		// Token: 0x060001D5 RID: 469 RVA: 0x00004A6C File Offset: 0x00002C6C
		[FreeFunction("ScriptingGraphicsCaps::GetCompatibleFormat", ThrowsException = true)]
		public static GraphicsFormat GetCompatibleFormat(GraphicsFormat format, FormatUsage usage)
		{
			throw new MissingMethodException();
		}

		// Token: 0x060001D6 RID: 470 RVA: 0x00004A80 File Offset: 0x00002C80
		[FreeFunction("ScriptingGraphicsCaps::GetGraphicsFormat")]
		public static GraphicsFormat GetGraphicsFormat(DefaultFormat format)
		{
			throw new MissingMethodException();
		}
	}
}
