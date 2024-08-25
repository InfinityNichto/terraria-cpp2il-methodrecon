using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using Cpp2IlInjected;
using Newtonsoft.Json.Shims;
using Newtonsoft.Json.Utilities;

namespace Newtonsoft.Json.Serialization
{
	// Token: 0x0200009E RID: 158
	[Preserve]
	public abstract class JsonContract
	{
		// Token: 0x170000E5 RID: 229
		// (get) Token: 0x0600055F RID: 1375 RVA: 0x0000DF3C File Offset: 0x0000C13C
		// (set) Token: 0x06000560 RID: 1376 RVA: 0x0000DF50 File Offset: 0x0000C150
		public Type UnderlyingType
		{
			[CompilerGenerated]
			get
			{
				return this.<UnderlyingType>k__BackingField;
			}
			[CompilerGenerated]
			private set
			{
				this.<UnderlyingType>k__BackingField = value;
			}
		}

		// Token: 0x170000E6 RID: 230
		// (get) Token: 0x06000561 RID: 1377 RVA: 0x0000DF64 File Offset: 0x0000C164
		// (set) Token: 0x06000562 RID: 1378 RVA: 0x0000DF78 File Offset: 0x0000C178
		public Type CreatedType
		{
			get
			{
				return this._createdType;
			}
			set
			{
				this._createdType = value;
				bool flag = value.IsSealed();
				bool flag2 = this._createdType.IsInterface();
			}
		}

		// Token: 0x170000E7 RID: 231
		// (get) Token: 0x06000563 RID: 1379 RVA: 0x0000DFB8 File Offset: 0x0000C1B8
		// (set) Token: 0x06000564 RID: 1380 RVA: 0x0000DFCC File Offset: 0x0000C1CC
		public bool? IsReference
		{
			[CompilerGenerated]
			get
			{
				return this.<IsReference>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<IsReference>k__BackingField = value;
			}
		}

		// Token: 0x170000E8 RID: 232
		// (get) Token: 0x06000565 RID: 1381 RVA: 0x0000DFE0 File Offset: 0x0000C1E0
		// (set) Token: 0x06000566 RID: 1382 RVA: 0x0000DFF4 File Offset: 0x0000C1F4
		public JsonConverter Converter
		{
			[CompilerGenerated]
			get
			{
				return this.<Converter>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<Converter>k__BackingField = value;
			}
		}

		// Token: 0x170000E9 RID: 233
		// (get) Token: 0x06000567 RID: 1383 RVA: 0x0000E008 File Offset: 0x0000C208
		// (set) Token: 0x06000568 RID: 1384 RVA: 0x0000E01C File Offset: 0x0000C21C
		internal JsonConverter InternalConverter
		{
			[CompilerGenerated]
			get
			{
				return this.<InternalConverter>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<InternalConverter>k__BackingField = value;
			}
		}

		// Token: 0x170000EA RID: 234
		// (get) Token: 0x06000569 RID: 1385 RVA: 0x0000E030 File Offset: 0x0000C230
		public IList<SerializationCallback> OnDeserializedCallbacks
		{
			get
			{
				/*
An exception occurred when decompiling this method (06000569)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Collections.Generic.IList`1<Newtonsoft.Json.Serialization.SerializationCallback> Newtonsoft.Json.Serialization.JsonContract::get_OnDeserializedCallbacks()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0000:
	brtrue(IL_0000, ldfld:class [mscorlib]System.Collections.Generic.List`1<class Newtonsoft.Json.Serialization.SerializationCallback>[exp:bool](JsonContract::_onDeserializedCallbacks, ldloc:JsonContract(this)))
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
		}

		// Token: 0x170000EB RID: 235
		// (get) Token: 0x0600056A RID: 1386 RVA: 0x0000E044 File Offset: 0x0000C244
		public IList<SerializationCallback> OnDeserializingCallbacks
		{
			get
			{
				/*
An exception occurred when decompiling this method (0600056A)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Collections.Generic.IList`1<Newtonsoft.Json.Serialization.SerializationCallback> Newtonsoft.Json.Serialization.JsonContract::get_OnDeserializingCallbacks()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0000:
	brtrue(IL_0000, ldfld:class [mscorlib]System.Collections.Generic.IList`1<class Newtonsoft.Json.Serialization.SerializationCallback>[exp:bool](JsonContract::_onDeserializingCallbacks, ldloc:JsonContract(this)))
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
		}

		// Token: 0x170000EC RID: 236
		// (get) Token: 0x0600056B RID: 1387 RVA: 0x0000E058 File Offset: 0x0000C258
		public IList<SerializationCallback> OnSerializedCallbacks
		{
			get
			{
				/*
An exception occurred when decompiling this method (0600056B)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Collections.Generic.IList`1<Newtonsoft.Json.Serialization.SerializationCallback> Newtonsoft.Json.Serialization.JsonContract::get_OnSerializedCallbacks()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0000:
	brtrue(IL_0000, ldfld:class [mscorlib]System.Collections.Generic.IList`1<class Newtonsoft.Json.Serialization.SerializationCallback>[exp:bool](JsonContract::_onSerializedCallbacks, ldloc:JsonContract(this)))
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
		}

		// Token: 0x170000ED RID: 237
		// (get) Token: 0x0600056C RID: 1388 RVA: 0x0000E06C File Offset: 0x0000C26C
		public IList<SerializationCallback> OnSerializingCallbacks
		{
			get
			{
				/*
An exception occurred when decompiling this method (0600056C)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Collections.Generic.IList`1<Newtonsoft.Json.Serialization.SerializationCallback> Newtonsoft.Json.Serialization.JsonContract::get_OnSerializingCallbacks()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0000:
	brtrue(IL_0000, ldfld:class [mscorlib]System.Collections.Generic.IList`1<class Newtonsoft.Json.Serialization.SerializationCallback>[exp:bool](JsonContract::_onSerializingCallbacks, ldloc:JsonContract(this)))
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
		}

		// Token: 0x170000EE RID: 238
		// (get) Token: 0x0600056D RID: 1389 RVA: 0x0000E080 File Offset: 0x0000C280
		public IList<SerializationErrorCallback> OnErrorCallbacks
		{
			get
			{
				/*
An exception occurred when decompiling this method (0600056D)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Collections.Generic.IList`1<Newtonsoft.Json.Serialization.SerializationErrorCallback> Newtonsoft.Json.Serialization.JsonContract::get_OnErrorCallbacks()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0000:
	brtrue(IL_0000, ldfld:class [mscorlib]System.Collections.Generic.IList`1<class Newtonsoft.Json.Serialization.SerializationErrorCallback>[exp:bool](JsonContract::_onErrorCallbacks, ldloc:JsonContract(this)))
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
		}

		// Token: 0x170000EF RID: 239
		// (get) Token: 0x0600056E RID: 1390 RVA: 0x0000E094 File Offset: 0x0000C294
		// (set) Token: 0x0600056F RID: 1391 RVA: 0x0000E0B8 File Offset: 0x0000C2B8
		[Obsolete("This property is obsolete and has been replaced by the OnDeserializedCallbacks collection.")]
		public MethodInfo OnDeserialized
		{
			get
			{
				IList<SerializationCallback> onDeserializedCallbacks = this.OnDeserializedCallbacks;
				IList<SerializationCallback> onDeserializedCallbacks2 = this.OnDeserializedCallbacks;
				long value = 0.m_value;
				MethodInfo methodInfo;
				return methodInfo;
			}
			set
			{
				IList<SerializationCallback> onDeserializedCallbacks = this.OnDeserializedCallbacks;
			}
		}

		// Token: 0x170000F0 RID: 240
		// (get) Token: 0x06000570 RID: 1392 RVA: 0x0000E0DC File Offset: 0x0000C2DC
		// (set) Token: 0x06000571 RID: 1393 RVA: 0x0000E100 File Offset: 0x0000C300
		[Obsolete("This property is obsolete and has been replaced by the OnDeserializingCallbacks collection.")]
		public MethodInfo OnDeserializing
		{
			get
			{
				IList<SerializationCallback> onDeserializingCallbacks = this.OnDeserializingCallbacks;
				IList<SerializationCallback> onDeserializingCallbacks2 = this.OnDeserializingCallbacks;
				long value = 0.m_value;
				MethodInfo methodInfo;
				return methodInfo;
			}
			set
			{
				IList<SerializationCallback> onDeserializingCallbacks = this.OnDeserializingCallbacks;
			}
		}

		// Token: 0x170000F1 RID: 241
		// (get) Token: 0x06000572 RID: 1394 RVA: 0x0000E124 File Offset: 0x0000C324
		// (set) Token: 0x06000573 RID: 1395 RVA: 0x0000E148 File Offset: 0x0000C348
		[Obsolete("This property is obsolete and has been replaced by the OnSerializedCallbacks collection.")]
		public MethodInfo OnSerialized
		{
			get
			{
				IList<SerializationCallback> onSerializedCallbacks = this.OnSerializedCallbacks;
				IList<SerializationCallback> onSerializedCallbacks2 = this.OnSerializedCallbacks;
				long value = 0.m_value;
				MethodInfo methodInfo;
				return methodInfo;
			}
			set
			{
				IList<SerializationCallback> onSerializedCallbacks = this.OnSerializedCallbacks;
			}
		}

		// Token: 0x170000F2 RID: 242
		// (get) Token: 0x06000574 RID: 1396 RVA: 0x0000E16C File Offset: 0x0000C36C
		// (set) Token: 0x06000575 RID: 1397 RVA: 0x0000E190 File Offset: 0x0000C390
		[Obsolete("This property is obsolete and has been replaced by the OnSerializingCallbacks collection.")]
		public MethodInfo OnSerializing
		{
			get
			{
				IList<SerializationCallback> onSerializingCallbacks = this.OnSerializingCallbacks;
				IList<SerializationCallback> onSerializingCallbacks2 = this.OnSerializingCallbacks;
				long value = 0.m_value;
				MethodInfo methodInfo;
				return methodInfo;
			}
			set
			{
				IList<SerializationCallback> onSerializingCallbacks = this.OnSerializingCallbacks;
			}
		}

		// Token: 0x170000F3 RID: 243
		// (get) Token: 0x06000576 RID: 1398 RVA: 0x0000E1B4 File Offset: 0x0000C3B4
		// (set) Token: 0x06000577 RID: 1399 RVA: 0x0000E1D8 File Offset: 0x0000C3D8
		[Obsolete("This property is obsolete and has been replaced by the OnErrorCallbacks collection.")]
		public MethodInfo OnError
		{
			get
			{
				IList<SerializationErrorCallback> onErrorCallbacks = this.OnErrorCallbacks;
				IList<SerializationErrorCallback> onErrorCallbacks2 = this.OnErrorCallbacks;
				long value = 0.m_value;
				MethodInfo methodInfo;
				return methodInfo;
			}
			set
			{
				IList<SerializationErrorCallback> onErrorCallbacks = this.OnErrorCallbacks;
			}
		}

		// Token: 0x170000F4 RID: 244
		// (get) Token: 0x06000578 RID: 1400 RVA: 0x0000E1FC File Offset: 0x0000C3FC
		// (set) Token: 0x06000579 RID: 1401 RVA: 0x0000E210 File Offset: 0x0000C410
		public Func<object> DefaultCreator
		{
			[CompilerGenerated]
			get
			{
				return this.<DefaultCreator>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<DefaultCreator>k__BackingField = value;
			}
		}

		// Token: 0x170000F5 RID: 245
		// (get) Token: 0x0600057A RID: 1402 RVA: 0x0000E224 File Offset: 0x0000C424
		// (set) Token: 0x0600057B RID: 1403 RVA: 0x0000E238 File Offset: 0x0000C438
		public bool DefaultCreatorNonPublic
		{
			[CompilerGenerated]
			get
			{
				return this.<DefaultCreatorNonPublic>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x0600057C RID: 1404 RVA: 0x0000E248 File Offset: 0x0000C448
		internal JsonContract(Type underlyingType)
		{
			ValidationUtils.ArgumentNotNull(underlyingType, "underlyingType");
			this.UnderlyingType = underlyingType;
			if (!true)
			{
			}
			bool flag = ReflectionUtils.IsNullable(underlyingType);
			this.IsNullable = true;
			if (!true)
			{
			}
			bool flag2 = ReflectionUtils.IsNullableType(underlyingType);
			Type underlyingType2 = Nullable.GetUnderlyingType(underlyingType);
			this.NonNullableUnderlyingType = underlyingType2;
			this.CreatedType = underlyingType2;
			Type nonNullableUnderlyingType = this.NonNullableUnderlyingType;
			if (!true)
			{
			}
			bool flag3 = ConvertUtils.IsConvertible(nonNullableUnderlyingType);
			Type nonNullableUnderlyingType2 = this.NonNullableUnderlyingType;
			bool flag4 = nonNullableUnderlyingType2.IsEnum();
			this.IsEnum = nonNullableUnderlyingType2 != null;
		}

		// Token: 0x0600057D RID: 1405 RVA: 0x0000E2C8 File Offset: 0x0000C4C8
		internal void InvokeOnSerializing(object o, StreamingContext context)
		{
			IList<SerializationCallback> onSerializingCallbacks = this._onSerializingCallbacks;
			if (onSerializingCallbacks != null)
			{
				return;
			}
		}

		// Token: 0x0600057E RID: 1406 RVA: 0x0000E310 File Offset: 0x0000C510
		internal void InvokeOnSerialized(object o, StreamingContext context)
		{
			IList<SerializationCallback> onSerializedCallbacks = this._onSerializedCallbacks;
			if (onSerializedCallbacks != null)
			{
				return;
			}
		}

		// Token: 0x0600057F RID: 1407 RVA: 0x0000E358 File Offset: 0x0000C558
		internal void InvokeOnDeserializing(object o, StreamingContext context)
		{
			IList<SerializationCallback> onDeserializingCallbacks = this._onDeserializingCallbacks;
			if (onDeserializingCallbacks != null)
			{
				return;
			}
		}

		// Token: 0x06000580 RID: 1408 RVA: 0x0000E3A0 File Offset: 0x0000C5A0
		internal void InvokeOnDeserialized(object o, StreamingContext context)
		{
			if (this._onDeserializedCallbacks != null)
			{
				return;
			}
		}

		// Token: 0x06000581 RID: 1409 RVA: 0x0000E3CC File Offset: 0x0000C5CC
		internal void InvokeOnError(object o, StreamingContext context, ErrorContext errorContext)
		{
			IList<SerializationErrorCallback> onErrorCallbacks = this._onErrorCallbacks;
			if (onErrorCallbacks != null)
			{
				return;
			}
		}

		// Token: 0x06000582 RID: 1410 RVA: 0x0000212A File Offset: 0x0000032A
		internal static SerializationCallback CreateSerializationCallback(MethodInfo callbackMethodInfo)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06000583 RID: 1411 RVA: 0x0000212A File Offset: 0x0000032A
		internal static SerializationErrorCallback CreateSerializationErrorCallback(MethodInfo callbackMethodInfo)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x04000268 RID: 616
		internal bool IsNullable;

		// Token: 0x04000269 RID: 617
		internal bool IsConvertable;

		// Token: 0x0400026A RID: 618
		internal bool IsEnum;

		// Token: 0x0400026B RID: 619
		internal Type NonNullableUnderlyingType;

		// Token: 0x0400026C RID: 620
		internal ReadType InternalReadType;

		// Token: 0x0400026D RID: 621
		internal JsonContractType ContractType;

		// Token: 0x0400026E RID: 622
		internal bool IsReadOnlyOrFixedSize;

		// Token: 0x0400026F RID: 623
		internal bool IsSealed;

		// Token: 0x04000270 RID: 624
		internal bool IsInstantiable;

		// Token: 0x04000271 RID: 625
		private List<SerializationCallback> _onDeserializedCallbacks;

		// Token: 0x04000272 RID: 626
		private IList<SerializationCallback> _onDeserializingCallbacks;

		// Token: 0x04000273 RID: 627
		private IList<SerializationCallback> _onSerializedCallbacks;

		// Token: 0x04000274 RID: 628
		private IList<SerializationCallback> _onSerializingCallbacks;

		// Token: 0x04000275 RID: 629
		private IList<SerializationErrorCallback> _onErrorCallbacks;

		// Token: 0x04000276 RID: 630
		private Type _createdType;

		// Token: 0x04000277 RID: 631
		[CompilerGenerated]
		private Type <UnderlyingType>k__BackingField;

		// Token: 0x04000278 RID: 632
		[CompilerGenerated]
		private bool? <IsReference>k__BackingField;

		// Token: 0x04000279 RID: 633
		[CompilerGenerated]
		private JsonConverter <Converter>k__BackingField;

		// Token: 0x0400027A RID: 634
		[CompilerGenerated]
		private JsonConverter <InternalConverter>k__BackingField;

		// Token: 0x0400027B RID: 635
		[CompilerGenerated]
		private Func<object> <DefaultCreator>k__BackingField;

		// Token: 0x0400027C RID: 636
		[CompilerGenerated]
		private bool <DefaultCreatorNonPublic>k__BackingField;

		// Token: 0x0200009F RID: 159
		[CompilerGenerated]
		private sealed class <>c__DisplayClass73_0
		{
			// Token: 0x06000584 RID: 1412 RVA: 0x0000E414 File Offset: 0x0000C614
			public <>c__DisplayClass73_0()
			{
			}

			// Token: 0x06000585 RID: 1413 RVA: 0x0000E428 File Offset: 0x0000C628
			internal void <CreateSerializationCallback>b__0(object o, StreamingContext context)
			{
				MethodInfo methodInfo = this.callbackMethodInfo;
			}

			// Token: 0x0400027D RID: 637
			public MethodInfo callbackMethodInfo;
		}

		// Token: 0x020000A0 RID: 160
		[CompilerGenerated]
		private sealed class <>c__DisplayClass74_0
		{
			// Token: 0x06000586 RID: 1414 RVA: 0x0000E444 File Offset: 0x0000C644
			public <>c__DisplayClass74_0()
			{
			}

			// Token: 0x06000587 RID: 1415 RVA: 0x0000E458 File Offset: 0x0000C658
			internal void <CreateSerializationErrorCallback>b__0(object o, StreamingContext context, ErrorContext econtext)
			{
				MethodInfo methodInfo = this.callbackMethodInfo;
			}

			// Token: 0x0400027E RID: 638
			public MethodInfo callbackMethodInfo;
		}
	}
}
