using System;
using System.Runtime.CompilerServices;
using Newtonsoft.Json.Shims;
using UnityEngine;

namespace Newtonsoft.Json.Converters
{
	// Token: 0x02000105 RID: 261
	[Preserve]
	public class VectorConverter : JsonConverter
	{
		// Token: 0x170001D4 RID: 468
		// (get) Token: 0x06000A53 RID: 2643 RVA: 0x00019630 File Offset: 0x00017830
		// (set) Token: 0x06000A54 RID: 2644 RVA: 0x00019644 File Offset: 0x00017844
		public bool EnableVector2
		{
			[CompilerGenerated]
			get
			{
				return this.<EnableVector2>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170001D5 RID: 469
		// (get) Token: 0x06000A55 RID: 2645 RVA: 0x00019654 File Offset: 0x00017854
		// (set) Token: 0x06000A56 RID: 2646 RVA: 0x00019668 File Offset: 0x00017868
		public bool EnableVector3
		{
			[CompilerGenerated]
			get
			{
				return this.<EnableVector3>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170001D6 RID: 470
		// (get) Token: 0x06000A57 RID: 2647 RVA: 0x00019678 File Offset: 0x00017878
		// (set) Token: 0x06000A58 RID: 2648 RVA: 0x0001968C File Offset: 0x0001788C
		public bool EnableVector4
		{
			[CompilerGenerated]
			get
			{
				return this.<EnableVector4>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06000A59 RID: 2649 RVA: 0x0001969C File Offset: 0x0001789C
		public VectorConverter()
		{
			this.<EnableVector2>k__BackingField = 257 != 0;
			this.<EnableVector4>k__BackingField = true;
		}

		// Token: 0x06000A5A RID: 2650 RVA: 0x000196C4 File Offset: 0x000178C4
		public VectorConverter(bool enableVector2, bool enableVector3, bool enableVector4)
		{
		}

		// Token: 0x06000A5B RID: 2651 RVA: 0x000196D8 File Offset: 0x000178D8
		public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
		{
			if (value != null)
			{
				Type type = value.GetType();
			}
		}

		// Token: 0x06000A5C RID: 2652 RVA: 0x000196F8 File Offset: 0x000178F8
		private static void WriteVector(JsonWriter writer, float x, float y, float? z, float? w)
		{
		}

		// Token: 0x06000A5D RID: 2653 RVA: 0x00019708 File Offset: 0x00017908
		public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
		{
			/*
An exception occurred when decompiling this method (06000A5D)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Object Newtonsoft.Json.Converters.VectorConverter::ReadJson(Newtonsoft.Json.JsonReader,System.Type,System.Object,Newtonsoft.Json.JsonSerializer)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_000A:
	stloc:Vector2(var_1_10, call:Vector2(VectorConverter::PopulateVector2, ldloc:JsonReader(reader)))
	stloc:Vector3(var_2_17, call:Vector3(VectorConverter::PopulateVector3, ldloc:JsonReader(reader)))
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

		// Token: 0x06000A5E RID: 2654 RVA: 0x0001972C File Offset: 0x0001792C
		public override bool CanConvert(Type objectType)
		{
			bool flag = this.<EnableVector2>k__BackingField;
			if (!flag || !flag)
			{
			}
			bool flag2 = this.<EnableVector3>k__BackingField;
			if (!flag2 || !flag2)
			{
			}
			bool flag3 = this.<EnableVector4>k__BackingField;
			if (flag3)
			{
				if (!flag3)
				{
				}
				return true;
			}
		}

		// Token: 0x06000A5F RID: 2655 RVA: 0x00019764 File Offset: 0x00017964
		private static Vector2 PopulateVector2(JsonReader reader)
		{
			/*
An exception occurred when decompiling this method (06000A5F)

ICSharpCode.Decompiler.DecompilerException: Error decompiling UnityEngine.Vector2 Newtonsoft.Json.Converters.VectorConverter::PopulateVector2(Newtonsoft.Json.JsonReader)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:JObject(var_0_06, call:JObject(JObject::Load, ldloc:JsonReader(reader)))
	stloc:JToken(var_1_12, callgetter:JToken(JObject::get_Item, ldloc:JObject(var_0_06), ldstr:string("x")))
	stloc:JToken(var_2_1E, callgetter:JToken(JObject::get_Item, ldloc:JObject(var_0_06), ldstr:string("y")))
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

		// Token: 0x06000A60 RID: 2656 RVA: 0x00019790 File Offset: 0x00017990
		private static Vector3 PopulateVector3(JsonReader reader)
		{
			/*
An exception occurred when decompiling this method (06000A60)

ICSharpCode.Decompiler.DecompilerException: Error decompiling UnityEngine.Vector3 Newtonsoft.Json.Converters.VectorConverter::PopulateVector3(Newtonsoft.Json.JsonReader)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:JObject(var_0_06, call:JObject(JObject::Load, ldloc:JsonReader(reader)))
	stloc:JToken(var_1_12, callgetter:JToken(JObject::get_Item, ldloc:JObject(var_0_06), ldstr:string("x")))
	stloc:JToken(var_2_1E, callgetter:JToken(JObject::get_Item, ldloc:JObject(var_0_06), ldstr:string("y")))
	stloc:JToken(var_3_2A, callgetter:JToken(JObject::get_Item, ldloc:JObject(var_0_06), ldstr:string("z")))
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

		// Token: 0x06000A61 RID: 2657 RVA: 0x000197C8 File Offset: 0x000179C8
		private static Vector4 PopulateVector4(JsonReader reader)
		{
			/*
An exception occurred when decompiling this method (06000A61)

ICSharpCode.Decompiler.DecompilerException: Error decompiling UnityEngine.Vector4 Newtonsoft.Json.Converters.VectorConverter::PopulateVector4(Newtonsoft.Json.JsonReader)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:JObject(var_0_06, call:JObject(JObject::Load, ldloc:JsonReader(reader)))
	stloc:JToken(var_1_12, callgetter:JToken(JObject::get_Item, ldloc:JObject(var_0_06), ldstr:string("x")))
	stloc:JToken(var_2_1E, callgetter:JToken(JObject::get_Item, ldloc:JObject(var_0_06), ldstr:string("y")))
	stloc:JToken(var_3_2A, callgetter:JToken(JObject::get_Item, ldloc:JObject(var_0_06), ldstr:string("z")))
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

		// Token: 0x06000A62 RID: 2658 RVA: 0x00019800 File Offset: 0x00017A00
		// Note: this type is marked as 'beforefieldinit'.
		static VectorConverter()
		{
			if (!true)
			{
			}
		}

		// Token: 0x04000403 RID: 1027
		private static readonly Type V2;

		// Token: 0x04000404 RID: 1028
		private static readonly Type V3;

		// Token: 0x04000405 RID: 1029
		private static readonly Type V4;

		// Token: 0x04000406 RID: 1030
		[CompilerGenerated]
		private bool <EnableVector2>k__BackingField;

		// Token: 0x04000407 RID: 1031
		[CompilerGenerated]
		private bool <EnableVector3>k__BackingField;

		// Token: 0x04000408 RID: 1032
		[CompilerGenerated]
		private bool <EnableVector4>k__BackingField;
	}
}
