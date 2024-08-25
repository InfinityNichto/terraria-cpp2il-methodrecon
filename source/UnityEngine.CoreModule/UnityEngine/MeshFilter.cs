using System;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine
{
	// Token: 0x02000053 RID: 83
	[RequireComponent(typeof(Transform))]
	[NativeHeader("Runtime/Graphics/Mesh/MeshFilter.h")]
	public sealed class MeshFilter : Component
	{
		// Token: 0x06000170 RID: 368 RVA: 0x000041BC File Offset: 0x000023BC
		[RequiredByNativeCode]
		private void DontStripMeshFilter()
		{
		}

		// Token: 0x17000040 RID: 64
		// (set) Token: 0x06000171 RID: 369 RVA: 0x000041CC File Offset: 0x000023CC
		public Mesh mesh
		{
			[NativeName("SetInstantiatedMesh")]
			set
			{
				throw new MissingMethodException();
			}
		}
	}
}
