using System;
using System.Collections.Generic;
using UnityEngine.Bindings;

namespace UnityEngine.Rendering
{
	// Token: 0x02000116 RID: 278
	[NativeHeader("Runtime/Export/RenderPipeline/ScriptableRenderContext.bindings.h")]
	[NativeType("Runtime/Graphics/ScriptableRenderLoop/ScriptableRenderContext.h")]
	[NativeHeader("Runtime/Graphics/ScriptableRenderLoop/ScriptableDrawRenderersUtility.h")]
	[NativeHeader("Modules/UI/Canvas.h")]
	[NativeHeader("Runtime/Export/RenderPipeline/ScriptableRenderPipeline.bindings.h")]
	[NativeHeader("Modules/UI/CanvasManager.h")]
	public struct ScriptableRenderContext : IEquatable<ScriptableRenderContext>
	{
		// Token: 0x060005A9 RID: 1449 RVA: 0x0000A0B8 File Offset: 0x000082B8
		internal ScriptableRenderContext(IntPtr ptr)
		{
			this.m_Ptr = ptr;
		}

		// Token: 0x060005AA RID: 1450 RVA: 0x0000A0CC File Offset: 0x000082CC
		internal void GetCameras(List<Camera> results)
		{
			if (!true)
			{
			}
			Type type;
			this.GetCameras_Internal(type, results);
		}

		// Token: 0x060005AB RID: 1451 RVA: 0x0000A0E4 File Offset: 0x000082E4
		public bool Equals(ScriptableRenderContext other)
		{
			bool flag;
			return flag;
		}

		// Token: 0x060005AC RID: 1452 RVA: 0x0000A0F4 File Offset: 0x000082F4
		public override bool Equals(object obj)
		{
			if (obj != null)
			{
			}
			bool flag;
			return flag;
		}

		// Token: 0x060005AD RID: 1453 RVA: 0x0000A108 File Offset: 0x00008308
		public override int GetHashCode()
		{
			int num;
			return num;
		}

		// Token: 0x060005AE RID: 1454 RVA: 0x0000A118 File Offset: 0x00008318
		private void GetCameras_Internal(Type listType, object resultList)
		{
			if (!true)
			{
			}
			throw new MissingMethodException();
		}

		// Token: 0x060005AF RID: 1455 RVA: 0x0000A130 File Offset: 0x00008330
		// Note: this type is marked as 'beforefieldinit'.
		static ScriptableRenderContext()
		{
			int num = Shader.TagToID("RenderType");
		}

		// Token: 0x060005B0 RID: 1456 RVA: 0x0000A148 File Offset: 0x00008348
		private static void GetCameras_Internal_Injected(ScriptableRenderContext _unity_self, Type listType, object resultList)
		{
			throw new MissingMethodException();
		}

		// Token: 0x04000492 RID: 1170
		private static readonly ShaderTagId kRenderTypeTag;

		// Token: 0x04000493 RID: 1171
		private IntPtr m_Ptr;
	}
}
