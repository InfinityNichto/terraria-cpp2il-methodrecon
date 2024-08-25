using System;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using UnityEngine.Bindings;
using UnityEngine.Experimental.Rendering;
using UnityEngine.Scripting;

namespace UnityEngine
{
	// Token: 0x0200004A RID: 74
	[NativeHeader("Runtime/Streaming/TextureStreamingManager.h")]
	[UsedByNativeCode]
	[NativeHeader("Runtime/Graphics/Texture.h")]
	public class Texture : Object
	{
		// Token: 0x060000FD RID: 253 RVA: 0x0000352C File Offset: 0x0000172C
		protected Texture()
		{
			if (!true)
			{
			}
			base..ctor();
		}

		// Token: 0x060000FE RID: 254 RVA: 0x00003544 File Offset: 0x00001744
		private int GetDataWidth()
		{
			throw new MissingMethodException();
		}

		// Token: 0x060000FF RID: 255 RVA: 0x00003558 File Offset: 0x00001758
		private int GetDataHeight()
		{
			throw new MissingMethodException();
		}

		// Token: 0x1700002E RID: 46
		// (get) Token: 0x06000100 RID: 256 RVA: 0x0000356C File Offset: 0x0000176C
		// (set) Token: 0x06000101 RID: 257 RVA: 0x000021B3 File Offset: 0x000003B3
		public virtual int width
		{
			get
			{
				throw new MissingMethodException();
			}
			set
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		// Token: 0x1700002F RID: 47
		// (get) Token: 0x06000102 RID: 258 RVA: 0x00003580 File Offset: 0x00001780
		// (set) Token: 0x06000103 RID: 259 RVA: 0x000021B3 File Offset: 0x000003B3
		public virtual int height
		{
			get
			{
				throw new MissingMethodException();
			}
			set
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		// Token: 0x17000030 RID: 48
		// (get) Token: 0x06000104 RID: 260 RVA: 0x00003594 File Offset: 0x00001794
		public virtual bool isReadable
		{
			get
			{
				throw new MissingMethodException();
			}
		}

		// Token: 0x17000031 RID: 49
		// (get) Token: 0x06000105 RID: 261 RVA: 0x000035A8 File Offset: 0x000017A8
		// (set) Token: 0x06000106 RID: 262 RVA: 0x000035BC File Offset: 0x000017BC
		public TextureWrapMode wrapMode
		{
			[NativeName("GetWrapModeU")]
			get
			{
				throw new MissingMethodException();
			}
			set
			{
				throw new MissingMethodException();
			}
		}

		// Token: 0x17000032 RID: 50
		// (set) Token: 0x06000107 RID: 263 RVA: 0x000035D0 File Offset: 0x000017D0
		public FilterMode filterMode
		{
			set
			{
				throw new MissingMethodException();
			}
		}

		// Token: 0x17000033 RID: 51
		// (get) Token: 0x06000108 RID: 264 RVA: 0x000035E4 File Offset: 0x000017E4
		public Vector2 texelSize
		{
			[NativeName("GetTexelSize")]
			get
			{
				throw new MissingMethodException();
			}
		}

		// Token: 0x06000109 RID: 265 RVA: 0x000035F8 File Offset: 0x000017F8
		internal bool ValidateFormat(TextureFormat format)
		{
			bool flag = SystemInfo.SupportsTextureFormat(format);
			return true;
		}

		// Token: 0x0600010A RID: 266 RVA: 0x00003650 File Offset: 0x00001850
		internal bool ValidateFormat(GraphicsFormat format, FormatUsage usage)
		{
			string text;
			Debug.LogWarning(string.Format("'{0}' is not allowed because it is an auto format and not an exact format. Use GraphicsFormatUtility.GetDepthStencilFormat to get an exact depth/stencil format.", text), this);
			throw new MissingMethodException();
		}

		// Token: 0x0600010B RID: 267 RVA: 0x00003690 File Offset: 0x00001890
		internal UnityException CreateNonReadableException(Texture t)
		{
			/*
An exception occurred when decompiling this method (0600010B)

ICSharpCode.Decompiler.DecompilerException: Error decompiling UnityEngine.UnityException UnityEngine.Texture::CreateNonReadableException(UnityEngine.Texture)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:string(var_1_0B, call:string(string::Format, ldstr:string("Texture '{0}' is not readable, the texture memory can not be accessed from scripts. You can make the texture readable in the Texture Import Settings."), ldloc:string[exp:object](var_0)))
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

		// Token: 0x0600010C RID: 268 RVA: 0x000021B3 File Offset: 0x000003B3
		internal UnityException CreateNativeArrayLengthOverflowException()
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x0600010D RID: 269 RVA: 0x000036A8 File Offset: 0x000018A8
		// Note: this type is marked as 'beforefieldinit'.
		static Texture()
		{
		}

		// Token: 0x0600010E RID: 270 RVA: 0x000036B8 File Offset: 0x000018B8
		private void get_texelSize_Injected([Out] Vector2 ret)
		{
			throw new MissingMethodException();
		}

		// Token: 0x04000211 RID: 529
		public static readonly int GenerateAllMips;
	}
}
