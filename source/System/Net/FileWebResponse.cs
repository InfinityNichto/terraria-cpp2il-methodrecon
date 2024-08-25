using System;
using System.IO;
using System.Runtime.Serialization;

namespace System.Net
{
	// Token: 0x0200021D RID: 541
	[Serializable]
	public class FileWebResponse : WebResponse, ISerializable, ICloseEx
	{
		// Token: 0x06000D8B RID: 3467 RVA: 0x0002B994 File Offset: 0x00029B94
		internal FileWebResponse(FileWebRequest request, global::System.Uri uri, FileAccess access, bool asyncHint)
		{
			int num = 1;
			base..ctor();
			this.m_fileAccess = access;
			if (num == 0)
			{
			}
		}

		// Token: 0x06000D8C RID: 3468 RVA: 0x0002B9EC File Offset: 0x00029BEC
		[Obsolete("Serialization is obsoleted for this type. http://go.microsoft.com/fwlink/?linkid=14202")]
		protected FileWebResponse(SerializationInfo serializationInfo, StreamingContext streamingContext)
		{
			int num = 1;
			base..ctor(serializationInfo, streamingContext);
			if (num == 0)
			{
			}
			object obj;
			if (obj != null)
			{
				this.m_headers = obj;
				return;
			}
			Type type;
			object value = serializationInfo.GetValue("uri", type);
			if (value != null)
			{
				this.m_uri = value;
				throw new InvalidCastException();
			}
			long @int = serializationInfo.GetInt64("contentLength");
			this.m_contentLength = @int;
			int int2 = serializationInfo.GetInt32("fileAccess");
			this.m_fileAccess = (FileAccess)int2;
		}

		// Token: 0x06000D8D RID: 3469 RVA: 0x0002BA5C File Offset: 0x00029C5C
		void ISerializable.GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext)
		{
		}

		// Token: 0x06000D8E RID: 3470 RVA: 0x0002BA6C File Offset: 0x00029C6C
		protected override void GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext)
		{
			WebHeaderCollection headers = this.m_headers;
			if (!true)
			{
			}
			Type type;
			serializationInfo.AddValue("headers", headers, type);
			global::System.Uri uri = this.m_uri;
			Type type2;
			serializationInfo.AddValue("uri", uri, type2);
			long contentLength = this.m_contentLength;
			serializationInfo.AddValue("contentLength", contentLength);
			FileAccess fileAccess = this.m_fileAccess;
			base.GetObjectData(serializationInfo, streamingContext);
		}

		// Token: 0x170002D5 RID: 725
		// (get) Token: 0x06000D8F RID: 3471 RVA: 0x0002BACC File Offset: 0x00029CCC
		public override long ContentLength
		{
			get
			{
				this.CheckDisposed();
				return this.m_contentLength;
			}
		}

		// Token: 0x170002D6 RID: 726
		// (get) Token: 0x06000D90 RID: 3472 RVA: 0x0002BAE8 File Offset: 0x00029CE8
		public override string ContentType
		{
			get
			{
				this.CheckDisposed();
				return "application/octet-stream";
			}
		}

		// Token: 0x170002D7 RID: 727
		// (get) Token: 0x06000D91 RID: 3473 RVA: 0x0002BB00 File Offset: 0x00029D00
		public override WebHeaderCollection Headers
		{
			get
			{
				this.CheckDisposed();
				return this.m_headers;
			}
		}

		// Token: 0x170002D8 RID: 728
		// (get) Token: 0x06000D92 RID: 3474 RVA: 0x0002BB1C File Offset: 0x00029D1C
		public override bool SupportsHeaders
		{
			get
			{
				return true;
			}
		}

		// Token: 0x170002D9 RID: 729
		// (get) Token: 0x06000D93 RID: 3475 RVA: 0x0002BB2C File Offset: 0x00029D2C
		public override global::System.Uri ResponseUri
		{
			get
			{
				this.CheckDisposed();
				return this.m_uri;
			}
		}

		// Token: 0x06000D94 RID: 3476 RVA: 0x0002BB48 File Offset: 0x00029D48
		private void CheckDisposed()
		{
			/*
An exception occurred when decompiling this method (06000D94)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Void System.Net.FileWebResponse::CheckDisposed()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0009:
	stloc:Type(var_0_0F, call:Type(object::GetType, ldloc:FileWebResponse[exp:object](this)))
}

   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1852
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1878
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1878
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1846
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.Optimize(DecompilerContext context, ILBlock method, AutoPropertyProvider autoPropertyProvider, StateMachineKind& stateMachineKind, MethodDef& inlinedMethod, AsyncMethodDebugInfo& asyncInfo, ILAstOptimizationStep abortBeforeStep) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 355
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(IEnumerable`1 parameters, MethodDebugInfoBuilder& builder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 123
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 88
   --- End of inner exception stack trace ---
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 92
   at ICSharpCode.Decompiler.Ast.AstBuilder.AddMethodBody(EntityDeclaration methodNode, EntityDeclaration& updatedNode, MethodDef method, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, MethodKind methodKind) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 1683
*/;
		}

		// Token: 0x06000D95 RID: 3477 RVA: 0x0002BB64 File Offset: 0x00029D64
		public override void Close()
		{
		}

		// Token: 0x06000D96 RID: 3478 RVA: 0x0002BB74 File Offset: 0x00029D74
		void ICloseEx.CloseEx(CloseExState closeState)
		{
			if (!this.m_closed)
			{
				Stream stream = this.m_stream;
				int num = 1;
				this.m_closed = num != 0;
				if (stream != null)
				{
					if (stream == null)
					{
						return;
					}
					if (stream == null)
					{
						throw new InvalidCastException();
					}
					if (stream != null)
					{
						return;
					}
					throw new InvalidCastException();
				}
			}
		}

		// Token: 0x06000D97 RID: 3479 RVA: 0x0002BBC4 File Offset: 0x00029DC4
		public override Stream GetResponseStream()
		{
			this.CheckDisposed();
			return this.m_stream;
		}

		// Token: 0x04000B67 RID: 2919
		private const int DefaultFileStreamBufferSize = 8192;

		// Token: 0x04000B68 RID: 2920
		private const string DefaultFileContentType = "application/octet-stream";

		// Token: 0x04000B69 RID: 2921
		private bool m_closed;

		// Token: 0x04000B6A RID: 2922
		private long m_contentLength;

		// Token: 0x04000B6B RID: 2923
		private FileAccess m_fileAccess;

		// Token: 0x04000B6C RID: 2924
		private WebHeaderCollection m_headers;

		// Token: 0x04000B6D RID: 2925
		private Stream m_stream;

		// Token: 0x04000B6E RID: 2926
		private global::System.Uri m_uri;
	}
}
