using System;
using System.IO;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;

namespace Terraria.DataStructures
{
	// Token: 0x02000681 RID: 1665
	public struct TrackedProjectileReference
	{
		// Token: 0x170006B9 RID: 1721
		// (get) Token: 0x06003791 RID: 14225 RVA: 0x000021DB File Offset: 0x000003DB
		// (set) Token: 0x06003792 RID: 14226 RVA: 0x00221DD8 File Offset: 0x0021FFD8
		public int ProjectileLocalIndex
		{
			[CompilerGenerated]
			readonly get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
			[CompilerGenerated]
			private set
			{
				this.<ProjectileLocalIndex>k__BackingField = value;
			}
		}

		// Token: 0x170006BA RID: 1722
		// (get) Token: 0x06003793 RID: 14227 RVA: 0x00221DEC File Offset: 0x0021FFEC
		// (set) Token: 0x06003794 RID: 14228 RVA: 0x00221E00 File Offset: 0x00220000
		public int ProjectileOwnerIndex
		{
			[CompilerGenerated]
			readonly get
			{
				return this.<ProjectileOwnerIndex>k__BackingField;
			}
			[CompilerGenerated]
			private set
			{
				this.<ProjectileOwnerIndex>k__BackingField = value;
			}
		}

		// Token: 0x170006BB RID: 1723
		// (get) Token: 0x06003795 RID: 14229 RVA: 0x00221E14 File Offset: 0x00220014
		// (set) Token: 0x06003796 RID: 14230 RVA: 0x00221E28 File Offset: 0x00220028
		public int ProjectileIdentity
		{
			[CompilerGenerated]
			readonly get
			{
				return this.<ProjectileIdentity>k__BackingField;
			}
			[CompilerGenerated]
			private set
			{
				this.<ProjectileIdentity>k__BackingField = value;
			}
		}

		// Token: 0x170006BC RID: 1724
		// (get) Token: 0x06003797 RID: 14231 RVA: 0x00221E3C File Offset: 0x0022003C
		// (set) Token: 0x06003798 RID: 14232 RVA: 0x00221E50 File Offset: 0x00220050
		public int ProjectileType
		{
			[CompilerGenerated]
			readonly get
			{
				return this.<ProjectileType>k__BackingField;
			}
			[CompilerGenerated]
			private set
			{
				this.<ProjectileType>k__BackingField = value;
			}
		}

		// Token: 0x170006BD RID: 1725
		// (get) Token: 0x06003799 RID: 14233 RVA: 0x00221E64 File Offset: 0x00220064
		// (set) Token: 0x0600379A RID: 14234 RVA: 0x00221E78 File Offset: 0x00220078
		public bool IsTrackingSomething
		{
			[CompilerGenerated]
			readonly get
			{
				return this.<IsTrackingSomething>k__BackingField;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x0600379B RID: 14235 RVA: 0x00221E88 File Offset: 0x00220088
		public void Set(Projectile proj)
		{
			int whoAmI = proj.whoAmI;
			this.<ProjectileLocalIndex>k__BackingField = whoAmI;
			int owner = proj.owner;
			this.<ProjectileOwnerIndex>k__BackingField = owner;
			int identity = proj.identity;
			this.<ProjectileIdentity>k__BackingField = identity;
			int type = proj.type;
			this.<IsTrackingSomething>k__BackingField = true;
			this.<ProjectileType>k__BackingField = type;
		}

		// Token: 0x0600379C RID: 14236 RVA: 0x00221ED4 File Offset: 0x002200D4
		public void Clear()
		{
		}

		// Token: 0x0600379D RID: 14237 RVA: 0x00221EE4 File Offset: 0x002200E4
		public void Write(BinaryWriter writer)
		{
			int num = this.<ProjectileOwnerIndex>k__BackingField;
			int num2 = this.<ProjectileOwnerIndex>k__BackingField;
			int num3 = this.<ProjectileIdentity>k__BackingField;
			int num4 = this.<ProjectileType>k__BackingField;
		}

		// Token: 0x0600379E RID: 14238 RVA: 0x00221F10 File Offset: 0x00220110
		public bool IsTracking(Projectile proj)
		{
			/*
An exception occurred when decompiling this method (0600379E)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean Terraria.DataStructures.TrackedProjectileReference::IsTracking(Terraria.Projectile)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:int32(var_0_06, ldfld:int32(Entity::whoAmI, ldloc:Projectile[exp:Entity](proj)))
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

		// Token: 0x0600379F RID: 14239 RVA: 0x00221F24 File Offset: 0x00220124
		public void TryReading(BinaryReader reader)
		{
			Projectile projectile;
			int type;
			if (projectile != null)
			{
				int whoAmI = projectile.whoAmI;
				this.<ProjectileLocalIndex>k__BackingField = whoAmI;
				int owner = projectile.owner;
				this.<ProjectileOwnerIndex>k__BackingField = owner;
				int identity = projectile.identity;
				this.<ProjectileIdentity>k__BackingField = identity;
				type = projectile.type;
				this.<IsTrackingSomething>k__BackingField = true;
				this.<ProjectileType>k__BackingField = type;
				return;
			}
			this.<ProjectileLocalIndex>k__BackingField = type;
			this.<ProjectileIdentity>k__BackingField = type;
		}

		// Token: 0x060037A0 RID: 14240 RVA: 0x00221F88 File Offset: 0x00220188
		private Projectile FindMatchingProjectile(int expectedOwner, int expectedIdentity, int expectedType)
		{
			if (!true)
			{
				return;
			}
		}

		// Token: 0x060037A1 RID: 14241 RVA: 0x00221FA0 File Offset: 0x002201A0
		public override bool Equals(object obj)
		{
			if (obj != null)
			{
				int num = this.<ProjectileOwnerIndex>k__BackingField;
				int num2 = this.<ProjectileIdentity>k__BackingField;
				int num3 = this.<ProjectileType>k__BackingField;
				return;
			}
		}

		// Token: 0x060037A2 RID: 14242 RVA: 0x00221FC8 File Offset: 0x002201C8
		public bool Equals(TrackedProjectileReference other)
		{
			/*
An exception occurred when decompiling this method (060037A2)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean Terraria.DataStructures.TrackedProjectileReference::Equals(Terraria.DataStructures.TrackedProjectileReference)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:int32(var_0_06, ldfld:int32(TrackedProjectileReference::<ProjectileOwnerIndex>k__BackingField, ldloc:valuetype Terraria.DataStructures.TrackedProjectileReference&(this)))
	stloc:int32(var_1_0D, ldfld:int32(TrackedProjectileReference::<ProjectileOwnerIndex>k__BackingField, ldloc:TrackedProjectileReference[exp:valuetype Terraria.DataStructures.TrackedProjectileReference&](other)))
	stloc:int32(var_2_14, ldfld:int32(TrackedProjectileReference::<ProjectileIdentity>k__BackingField, ldloc:valuetype Terraria.DataStructures.TrackedProjectileReference&(this)))
	stloc:int32(var_3_1B, ldfld:int32(TrackedProjectileReference::<ProjectileIdentity>k__BackingField, ldloc:TrackedProjectileReference[exp:valuetype Terraria.DataStructures.TrackedProjectileReference&](other)))
	stloc:int32(var_4_22, ldfld:int32(TrackedProjectileReference::<ProjectileType>k__BackingField, ldloc:valuetype Terraria.DataStructures.TrackedProjectileReference&(this)))
	stloc:int32(var_5_2A, ldfld:int32(TrackedProjectileReference::<ProjectileType>k__BackingField, ldloc:TrackedProjectileReference[exp:valuetype Terraria.DataStructures.TrackedProjectileReference&](other)))
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

		// Token: 0x060037A3 RID: 14243 RVA: 0x00222004 File Offset: 0x00220204
		public override int GetHashCode()
		{
			/*
An exception occurred when decompiling this method (060037A3)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Int32 Terraria.DataStructures.TrackedProjectileReference::GetHashCode()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:int32(var_0_06, ldfld:int32(TrackedProjectileReference::<ProjectileLocalIndex>k__BackingField, ldloc:valuetype Terraria.DataStructures.TrackedProjectileReference&(this)))
	stloc:int32(var_1_0D, ldfld:int32(TrackedProjectileReference::<ProjectileIdentity>k__BackingField, ldloc:valuetype Terraria.DataStructures.TrackedProjectileReference&(this)))
	stloc:int32(var_2_14, ldfld:int32(TrackedProjectileReference::<ProjectileIdentity>k__BackingField, ldloc:valuetype Terraria.DataStructures.TrackedProjectileReference&(this)))
	stloc:bool(var_3_1B, ldfld:bool(TrackedProjectileReference::<IsTrackingSomething>k__BackingField, ldloc:valuetype Terraria.DataStructures.TrackedProjectileReference&(this)))
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

		// Token: 0x060037A4 RID: 14244 RVA: 0x0022202C File Offset: 0x0022022C
		public static bool operator ==(TrackedProjectileReference c1, TrackedProjectileReference c2)
		{
			/*
An exception occurred when decompiling this method (060037A4)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean Terraria.DataStructures.TrackedProjectileReference::op_Equality(Terraria.DataStructures.TrackedProjectileReference,Terraria.DataStructures.TrackedProjectileReference)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:int32(var_0_06, ldfld:int32(TrackedProjectileReference::<ProjectileOwnerIndex>k__BackingField, ldloc:TrackedProjectileReference[exp:valuetype Terraria.DataStructures.TrackedProjectileReference&](c1)))
	stloc:int32(var_1_0D, ldfld:int32(TrackedProjectileReference::<ProjectileIdentity>k__BackingField, ldloc:TrackedProjectileReference[exp:valuetype Terraria.DataStructures.TrackedProjectileReference&](c1)))
	stloc:int32(var_2_14, ldfld:int32(TrackedProjectileReference::<ProjectileType>k__BackingField, ldloc:TrackedProjectileReference[exp:valuetype Terraria.DataStructures.TrackedProjectileReference&](c1)))
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

		// Token: 0x060037A5 RID: 14245 RVA: 0x00222050 File Offset: 0x00220250
		public static bool operator !=(TrackedProjectileReference c1, TrackedProjectileReference c2)
		{
			int num = c1.<ProjectileOwnerIndex>k__BackingField;
			int num2 = c1.<ProjectileIdentity>k__BackingField;
			int num3 = c1.<ProjectileType>k__BackingField;
			return true;
		}

		// Token: 0x04007895 RID: 30869
		[CompilerGenerated]
		private int <ProjectileLocalIndex>k__BackingField;

		// Token: 0x04007896 RID: 30870
		[CompilerGenerated]
		private int <ProjectileOwnerIndex>k__BackingField;

		// Token: 0x04007897 RID: 30871
		[CompilerGenerated]
		private int <ProjectileIdentity>k__BackingField;

		// Token: 0x04007898 RID: 30872
		[CompilerGenerated]
		private int <ProjectileType>k__BackingField;

		// Token: 0x04007899 RID: 30873
		[CompilerGenerated]
		private bool <IsTrackingSomething>k__BackingField;
	}
}
