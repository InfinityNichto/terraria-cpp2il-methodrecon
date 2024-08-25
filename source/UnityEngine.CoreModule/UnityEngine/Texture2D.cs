using System;
using System.Runtime.InteropServices;
using Unity.Collections;
using UnityEngine.Bindings;
using UnityEngine.Experimental.Rendering;
using UnityEngine.Internal;
using UnityEngine.Scripting;

namespace UnityEngine
{
	// Token: 0x0200004B RID: 75
	[NativeHeader("Runtime/Graphics/GeneratedTextures.h")]
	[NativeHeader("Runtime/Graphics/Texture2D.h")]
	[UsedByNativeCode]
	public sealed class Texture2D : Texture
	{
		// Token: 0x17000034 RID: 52
		// (get) Token: 0x0600010F RID: 271 RVA: 0x000036CC File Offset: 0x000018CC
		public TextureFormat format
		{
			[NativeName("GetTextureFormat")]
			get
			{
				throw new MissingMethodException();
			}
		}

		// Token: 0x17000035 RID: 53
		// (get) Token: 0x06000110 RID: 272 RVA: 0x000036E0 File Offset: 0x000018E0
		[StaticAccessor("builtintex", StaticAccessorType.DoubleColon)]
		public static Texture2D whiteTexture
		{
			get
			{
				throw new MissingMethodException();
			}
		}

		// Token: 0x06000111 RID: 273 RVA: 0x000036F4 File Offset: 0x000018F4
		[FreeFunction("Texture2DScripting::Create")]
		private static bool Internal_CreateImpl([Writable] Texture2D mono, int w, int h, int mipCount, GraphicsFormat format, TextureCreationFlags flags, IntPtr nativeTex)
		{
			throw new MissingMethodException();
		}

		// Token: 0x06000112 RID: 274 RVA: 0x00003708 File Offset: 0x00001908
		private static void Internal_Create([Writable] Texture2D mono, int w, int h, int mipCount, GraphicsFormat format, TextureCreationFlags flags, IntPtr nativeTex)
		{
			throw new MissingMethodException();
		}

		// Token: 0x17000036 RID: 54
		// (get) Token: 0x06000113 RID: 275 RVA: 0x0000371C File Offset: 0x0000191C
		public override bool isReadable
		{
			get
			{
				throw new MissingMethodException();
			}
		}

		// Token: 0x06000114 RID: 276 RVA: 0x00003730 File Offset: 0x00001930
		[NativeName("Apply")]
		private void ApplyImpl(bool updateMipmaps, bool makeNoLongerReadable)
		{
			throw new MissingMethodException();
		}

		// Token: 0x06000115 RID: 277 RVA: 0x00003744 File Offset: 0x00001944
		[NativeName("SetPixel")]
		private void SetPixelImpl(int image, int mip, int x, int y, Color color)
		{
			throw new MissingMethodException();
		}

		// Token: 0x06000116 RID: 278 RVA: 0x00003758 File Offset: 0x00001958
		[NativeName("GetPixelBilinear")]
		private Color GetPixelBilinearImpl(int image, int mip, float u, float v)
		{
			throw new MissingMethodException();
		}

		// Token: 0x06000117 RID: 279 RVA: 0x0000376C File Offset: 0x0000196C
		private IntPtr GetWritableImageData(int frame)
		{
			throw new MissingMethodException();
		}

		// Token: 0x06000118 RID: 280 RVA: 0x00003780 File Offset: 0x00001980
		private ulong GetRawImageDataSize()
		{
			throw new MissingMethodException();
		}

		// Token: 0x06000119 RID: 281 RVA: 0x00003794 File Offset: 0x00001994
		internal bool ValidateFormat(TextureFormat format, int width, int height)
		{
			bool flag = base.ValidateFormat(format);
			return Mathf.IsPowerOfTwo(width);
		}

		// Token: 0x0600011A RID: 282 RVA: 0x000037BC File Offset: 0x000019BC
		internal Texture2D(int width, int height, TextureFormat textureFormat, int mipCount, bool linear, IntPtr nativeTex)
		{
			if (!true)
			{
			}
			base..ctor();
			bool flag = this.ValidateFormat(textureFormat, width, height);
			if (!true)
			{
			}
			if (!true)
			{
			}
			bool flag2 = GraphicsFormatUtility.IsCrunchFormat(textureFormat);
		}

		// Token: 0x0600011B RID: 283 RVA: 0x000037EC File Offset: 0x000019EC
		[ExcludeFromDocs]
		public Texture2D(int width, int height, TextureFormat textureFormat, bool mipChain)
		{
		}

		// Token: 0x0600011C RID: 284 RVA: 0x000037FC File Offset: 0x000019FC
		[ExcludeFromDocs]
		public Texture2D(int width, int height)
		{
			if (!true)
			{
			}
		}

		// Token: 0x0600011D RID: 285 RVA: 0x0000380C File Offset: 0x00001A0C
		[ExcludeFromDocs]
		public void SetPixel(int x, int y, Color color)
		{
		}

		// Token: 0x0600011E RID: 286 RVA: 0x00003824 File Offset: 0x00001A24
		[ExcludeFromDocs]
		public Color GetPixelBilinear(float u, float v)
		{
			long num = 0L;
			long num2 = 0L;
			return this.GetPixelBilinearImpl((int)num, (int)num2, u, v);
		}

		// Token: 0x0600011F RID: 287 RVA: 0x00003840 File Offset: 0x00001A40
		public NativeArray<T> GetRawTextureData<T>() where T : struct
		{
			/*
An exception occurred when decompiling this method (0600011F)

ICSharpCode.Decompiler.DecompilerException: Error decompiling Unity.Collections.NativeArray`1<T> UnityEngine.Texture2D::GetRawTextureData<T>()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:uint64(var_0_06, call:uint64(Texture2D::GetRawImageDataSize, ldloc:Texture2D(this)))
	stloc:int64(var_1_08, ldc.i4:int64(0))
	stloc:void*(var_2_15, call:void*(native int::op_Explicit, call:native int(Texture2D::GetWritableImageData, ldloc:Texture2D(this), ldloc:int64[exp:int32](var_1_08))))
	stloc:UnityException(var_3_1D, call:UnityException(Texture::CreateNonReadableException, ldloc:Texture2D[exp:Texture](this), ldloc:Texture2D[exp:Texture](this)))
}

   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1852
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.Optimize(DecompilerContext context, ILBlock method, AutoPropertyProvider autoPropertyProvider, StateMachineKind& stateMachineKind, MethodDef& inlinedMethod, AsyncMethodDebugInfo& asyncInfo, ILAstOptimizationStep abortBeforeStep) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 355
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(IEnumerable`1 parameters, MethodDebugInfoBuilder& builder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 123
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 88
   --- End of inner exception stack trace ---
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 92
   at ICSharpCode.Decompiler.Ast.AstBuilder.AddMethodBody(EntityDeclaration methodNode, EntityDeclaration& updatedNode, MethodDef method, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, MethodKind methodKind) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 1683
*/;
		}

		// Token: 0x06000120 RID: 288 RVA: 0x0000386C File Offset: 0x00001A6C
		public void Apply([DefaultValue("true")] bool updateMipmaps, [DefaultValue("false")] bool makeNoLongerReadable)
		{
			throw new MissingMethodException();
		}

		// Token: 0x06000121 RID: 289 RVA: 0x00003888 File Offset: 0x00001A88
		[ExcludeFromDocs]
		public void Apply()
		{
			long num = 0L;
			this.Apply(true, num != 0L);
		}

		// Token: 0x06000122 RID: 290 RVA: 0x000038A0 File Offset: 0x00001AA0
		private void SetPixelImpl_Injected(int image, int mip, int x, int y, Color color)
		{
			throw new MissingMethodException();
		}

		// Token: 0x06000123 RID: 291 RVA: 0x000038B4 File Offset: 0x00001AB4
		private void GetPixelBilinearImpl_Injected(int image, int mip, float u, float v, [Out] Color ret)
		{
			throw new MissingMethodException();
		}

		// Token: 0x04000212 RID: 530
		internal const int streamingMipmapsPriorityMin = -128;

		// Token: 0x04000213 RID: 531
		internal const int streamingMipmapsPriorityMax = 127;
	}
}
