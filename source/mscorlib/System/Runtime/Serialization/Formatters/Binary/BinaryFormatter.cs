using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Messaging;

namespace System.Runtime.Serialization.Formatters.Binary
{
	// Token: 0x02000416 RID: 1046
	[ComVisible(true)]
	public sealed class BinaryFormatter : IFormatter
	{
		// Token: 0x17000445 RID: 1093
		// (set) Token: 0x06002041 RID: 8257 RVA: 0x00047138 File Offset: 0x00045338
		public FormatterAssemblyStyle AssemblyFormat
		{
			set
			{
				this.m_assemblyFormat = value;
			}
		}

		// Token: 0x17000446 RID: 1094
		// (set) Token: 0x06002042 RID: 8258 RVA: 0x0004714C File Offset: 0x0004534C
		public ISurrogateSelector SurrogateSelector
		{
			set
			{
				this.m_surrogates = value;
			}
		}

		// Token: 0x06002043 RID: 8259 RVA: 0x00047160 File Offset: 0x00045360
		public BinaryFormatter()
		{
		}

		// Token: 0x06002044 RID: 8260 RVA: 0x00047184 File Offset: 0x00045384
		public BinaryFormatter(ISurrogateSelector selector, StreamingContext context)
		{
			this.m_surrogates = selector;
			this.m_context = context;
		}

		// Token: 0x06002045 RID: 8261 RVA: 0x000471B4 File Offset: 0x000453B4
		public object Deserialize(Stream serializationStream)
		{
			object obj;
			return obj;
		}

		// Token: 0x06002046 RID: 8262 RVA: 0x000471C4 File Offset: 0x000453C4
		internal object Deserialize(Stream serializationStream, HeaderHandler handler, bool fCheck)
		{
			/*
An exception occurred when decompiling this method (06002046)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Object System.Runtime.Serialization.Formatters.Binary.BinaryFormatter::Deserialize(System.IO.Stream,System.Runtime.Remoting.Messaging.HeaderHandler,System.Boolean)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0048:
	stloc:string(var_9_52, call:string(Environment::GetResourceString, ldstr:string("Attempting to deserialize an empty stream.")))
}

   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1852
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1878
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1878
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1846
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

		// Token: 0x06002047 RID: 8263 RVA: 0x00047224 File Offset: 0x00045424
		public object Deserialize(Stream serializationStream, HeaderHandler handler)
		{
			return this.Deserialize(serializationStream, handler, true);
		}

		// Token: 0x06002048 RID: 8264 RVA: 0x0004723C File Offset: 0x0004543C
		public void Serialize(Stream serializationStream, object graph)
		{
		}

		// Token: 0x06002049 RID: 8265 RVA: 0x0004724C File Offset: 0x0004544C
		public void Serialize(Stream serializationStream, object graph, Header[] headers)
		{
			this.Serialize(serializationStream, graph, headers, true);
		}

		// Token: 0x0600204A RID: 8266 RVA: 0x00047264 File Offset: 0x00045464
		internal void Serialize(Stream serializationStream, object graph, Header[] headers, bool fCheck)
		{
			if (serializationStream != null)
			{
				FormatterTypeStyle typeFormat = this.m_typeFormat;
				ISurrogateSelector surrogates = this.m_surrogates;
				StreamingContext context = this.m_context;
				StreamingContextStates state = this.m_context.m_state;
				SerializationBinder binder = this.m_binder;
				FormatterTypeStyle typeFormat2 = this.m_typeFormat;
				return;
			}
			throw new ArrayTypeMismatchException();
		}

		// Token: 0x0600204B RID: 8267 RVA: 0x000472AC File Offset: 0x000454AC
		internal static TypeInformation GetTypeInformation(Type type)
		{
			if (!true)
			{
			}
			if (!true)
			{
			}
			if (!false)
			{
				return 1;
			}
			throw new OutOfMemoryException();
		}

		// Token: 0x0600204C RID: 8268 RVA: 0x000472D8 File Offset: 0x000454D8
		// Note: this type is marked as 'beforefieldinit'.
		static BinaryFormatter()
		{
		}

		// Token: 0x040010EB RID: 4331
		internal ISurrogateSelector m_surrogates;

		// Token: 0x040010EC RID: 4332
		internal StreamingContext m_context;

		// Token: 0x040010ED RID: 4333
		internal SerializationBinder m_binder;

		// Token: 0x040010EE RID: 4334
		internal FormatterTypeStyle m_typeFormat = FormatterTypeStyle.TypesAlways;

		// Token: 0x040010EF RID: 4335
		internal FormatterAssemblyStyle m_assemblyFormat;

		// Token: 0x040010F0 RID: 4336
		internal TypeFilterLevel m_securityLevel = TypeFilterLevel.Full;

		// Token: 0x040010F1 RID: 4337
		internal object[] m_crossAppDomainArray;

		// Token: 0x040010F2 RID: 4338
		private static Dictionary<Type, TypeInformation> typeNameCache;
	}
}
