using System;
using System.Runtime.CompilerServices;
using Newtonsoft.Json.Linq;
using UnityEngine;

namespace Newtonsoft.Json.Converters
{
	// Token: 0x020000FF RID: 255
	public class QuaternionConverter : JsonConverter
	{
		// Token: 0x06000A2C RID: 2604 RVA: 0x0001908C File Offset: 0x0001728C
		public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
		{
			Vector3 vector = Quaternion.Internal_ToEulerRad(0);
			Vector3 vector2 = Quaternion.Internal_ToEulerRad(0);
			Vector3 vector3 = Quaternion.Internal_ToEulerRad(0);
		}

		// Token: 0x06000A2D RID: 2605 RVA: 0x000190C0 File Offset: 0x000172C0
		public override bool CanConvert(Type objectType)
		{
			/*
An exception occurred when decompiling this method (06000A2D)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean Newtonsoft.Json.Converters.QuaternionConverter::CanConvert(System.Type)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0000:
	brtrue(IL_0000, ldtoken:RuntimeFieldHandle[exp:bool]('<PrivateImplementationDetails>'::A5BD4B1718E46B13C0771AD632FC5E42B140BD94B602D5F6D7F9304B41DF51F6))
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

		// Token: 0x06000A2E RID: 2606 RVA: 0x000190D4 File Offset: 0x000172D4
		public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
		{
			/*
An exception occurred when decompiling this method (06000A2E)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Object Newtonsoft.Json.Converters.QuaternionConverter::ReadJson(Newtonsoft.Json.JsonReader,System.Type,System.Object,Newtonsoft.Json.JsonSerializer)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0073:
	stloc:JToken(var_15_7E, callgetter:JToken(JObject::get_Item, ldloc:JObject(var_0_06), ldstr:string("eulerAngles")))
	stloc:float32(var_16_87, call:float32(JToken::op_Explicit, ldloc:JToken(var_15_7E)))
	stloc:float32(var_17_90, call:float32(JToken::op_Explicit, ldloc:JToken(var_15_7E)))
	stloc:float32(var_18_99, call:float32(JToken::op_Explicit, ldloc:JToken(var_15_7E)))
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

		// Token: 0x170001D0 RID: 464
		// (get) Token: 0x06000A2F RID: 2607 RVA: 0x00019180 File Offset: 0x00017380
		public override bool CanRead
		{
			get
			{
				return true;
			}
		}

		// Token: 0x06000A30 RID: 2608 RVA: 0x00019190 File Offset: 0x00017390
		public QuaternionConverter()
		{
		}

		// Token: 0x02000100 RID: 256
		[CompilerGenerated]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x06000A31 RID: 2609 RVA: 0x000191A4 File Offset: 0x000173A4
			// Note: this type is marked as 'beforefieldinit'.
			static <>c()
			{
			}

			// Token: 0x06000A32 RID: 2610 RVA: 0x000191B4 File Offset: 0x000173B4
			public <>c()
			{
			}

			// Token: 0x06000A33 RID: 2611 RVA: 0x000191C8 File Offset: 0x000173C8
			internal bool <ReadJson>b__2_0(JProperty p)
			{
				return p._name == "w";
			}

			// Token: 0x06000A34 RID: 2612 RVA: 0x000191E8 File Offset: 0x000173E8
			internal bool <ReadJson>b__2_1(JProperty p)
			{
				return p._name == "x";
			}

			// Token: 0x06000A35 RID: 2613 RVA: 0x00019208 File Offset: 0x00017408
			internal bool <ReadJson>b__2_2(JProperty p)
			{
				return p._name == "y";
			}

			// Token: 0x06000A36 RID: 2614 RVA: 0x00019228 File Offset: 0x00017428
			internal bool <ReadJson>b__2_3(JProperty p)
			{
				return p._name == "z";
			}

			// Token: 0x06000A37 RID: 2615 RVA: 0x00019248 File Offset: 0x00017448
			internal bool <ReadJson>b__2_4(JProperty p)
			{
				return p._name == "eulerAngles";
			}

			// Token: 0x040003F9 RID: 1017
			public static readonly QuaternionConverter.<>c <>9;

			// Token: 0x040003FA RID: 1018
			public static Func<JProperty, bool> <>9__2_0;

			// Token: 0x040003FB RID: 1019
			public static Func<JProperty, bool> <>9__2_1;

			// Token: 0x040003FC RID: 1020
			public static Func<JProperty, bool> <>9__2_2;

			// Token: 0x040003FD RID: 1021
			public static Func<JProperty, bool> <>9__2_3;

			// Token: 0x040003FE RID: 1022
			public static Func<JProperty, bool> <>9__2_4;
		}
	}
}
