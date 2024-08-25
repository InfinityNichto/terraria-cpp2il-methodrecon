using System;
using System.Globalization;
using System.Reflection;
using Cpp2IlInjected;
using Unity.IL2CPP.CompilerServices;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine
{
	// Token: 0x020000CA RID: 202
	[Il2CppEagerStaticClassConstruction]
	[UsedByNativeCode]
	[DefaultMember("Item")]
	[NativeType("Runtime/Math/Vector2Int.h")]
	public struct Vector2Int : IEquatable<Vector2Int>, IFormattable
	{
		// Token: 0x170000C0 RID: 192
		// (get) Token: 0x060003A2 RID: 930 RVA: 0x000021B3 File Offset: 0x000003B3
		// (set) Token: 0x060003A3 RID: 931 RVA: 0x000073A0 File Offset: 0x000055A0
		public int x
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
			set
			{
				this.m_X = value;
			}
		}

		// Token: 0x170000C1 RID: 193
		// (get) Token: 0x060003A4 RID: 932 RVA: 0x000073B4 File Offset: 0x000055B4
		// (set) Token: 0x060003A5 RID: 933 RVA: 0x000073C8 File Offset: 0x000055C8
		public int y
		{
			get
			{
				return this.m_Y;
			}
			set
			{
				this.m_Y = value;
			}
		}

		// Token: 0x060003A6 RID: 934 RVA: 0x000073DC File Offset: 0x000055DC
		public Vector2Int(int x, int y)
		{
			this.m_X = x;
		}

		// Token: 0x060003A7 RID: 935 RVA: 0x000073F0 File Offset: 0x000055F0
		public static implicit operator Vector2(Vector2Int v)
		{
			Vector2 vector;
			return vector;
		}

		// Token: 0x060003A8 RID: 936 RVA: 0x00007400 File Offset: 0x00005600
		public override bool Equals(object other)
		{
			if (other != null)
			{
				int y = this.m_Y;
				return;
			}
		}

		// Token: 0x060003A9 RID: 937 RVA: 0x00007418 File Offset: 0x00005618
		public bool Equals(Vector2Int other)
		{
			/*
An exception occurred when decompiling this method (060003A9)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean UnityEngine.Vector2Int::Equals(UnityEngine.Vector2Int)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:int32(var_0_06, ldfld:int32(Vector2Int::m_Y, ldloc:valuetype UnityEngine.Vector2Int&(this)))
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

		// Token: 0x060003AA RID: 938 RVA: 0x00007430 File Offset: 0x00005630
		public override int GetHashCode()
		{
			int y = this.m_Y;
			int num;
			return num.GetHashCode();
		}

		// Token: 0x060003AB RID: 939 RVA: 0x0000744C File Offset: 0x0000564C
		public override string ToString()
		{
			string text;
			return text;
		}

		// Token: 0x060003AC RID: 940 RVA: 0x0000745C File Offset: 0x0000565C
		public string ToString(string format, IFormatProvider formatProvider)
		{
			if (formatProvider == null)
			{
				CultureInfo invariantCulture = CultureInfo.InvariantCulture;
			}
			string text;
			if (text == null || text != null)
			{
				int y = this.m_Y;
				string text2;
				if (text2 == null || text2 != null)
				{
					string text3;
					return text3;
				}
			}
			throw new ArrayTypeMismatchException();
		}

		// Token: 0x060003AD RID: 941 RVA: 0x00007494 File Offset: 0x00005694
		// Note: this type is marked as 'beforefieldinit'.
		static Vector2Int()
		{
		}

		// Token: 0x04000389 RID: 905
		private int m_X;

		// Token: 0x0400038A RID: 906
		private int m_Y;

		// Token: 0x0400038B RID: 907
		private static readonly Vector2Int s_Zero;

		// Token: 0x0400038C RID: 908
		private static readonly Vector2Int s_One;

		// Token: 0x0400038D RID: 909
		private static readonly Vector2Int s_Up;

		// Token: 0x0400038E RID: 910
		private static readonly Vector2Int s_Down;

		// Token: 0x0400038F RID: 911
		private static readonly Vector2Int s_Left;

		// Token: 0x04000390 RID: 912
		private static readonly Vector2Int s_Right;
	}
}
