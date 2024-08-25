using System;
using Cpp2IlInjected;

namespace UnityEngine.Rendering
{
	// Token: 0x02000113 RID: 275
	public struct ShaderTagId : IEquatable<ShaderTagId>
	{
		// Token: 0x06000583 RID: 1411 RVA: 0x00009E14 File Offset: 0x00008014
		public ShaderTagId(string name)
		{
			int num = Shader.TagToID(name);
			this.m_Id = num;
		}

		// Token: 0x06000584 RID: 1412 RVA: 0x00009E30 File Offset: 0x00008030
		public override bool Equals(object obj)
		{
			if (obj != null)
			{
				return;
			}
		}

		// Token: 0x06000585 RID: 1413 RVA: 0x000021B3 File Offset: 0x000003B3
		public bool Equals(ShaderTagId other)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06000586 RID: 1414 RVA: 0x00009E44 File Offset: 0x00008044
		public override int GetHashCode()
		{
			int num;
			return num;
		}

		// Token: 0x04000490 RID: 1168
		private int m_Id;
	}
}
