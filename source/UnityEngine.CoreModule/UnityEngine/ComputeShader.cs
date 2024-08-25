using System;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine
{
	// Token: 0x020000D3 RID: 211
	[NativeHeader("Runtime/Graphics/ShaderScriptBindings.h")]
	[NativeHeader("Runtime/Shaders/ComputeShader.h")]
	[UsedByNativeCode]
	public sealed class ComputeShader : Object
	{
		// Token: 0x06000455 RID: 1109 RVA: 0x00008140 File Offset: 0x00006340
		[RequiredByNativeCode]
		[NativeMethod(Name = "ComputeShaderScripting::FindKernel", HasExplicitThis = true, IsFreeFunction = true, ThrowsException = true)]
		public int FindKernel(string name)
		{
			throw new MissingMethodException();
		}
	}
}
