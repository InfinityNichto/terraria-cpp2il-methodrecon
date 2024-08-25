using System;
using System.Runtime.InteropServices;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using ReLogic.Content;

namespace Terraria.Graphics.Shaders
{
	// Token: 0x0200074B RID: 1867
	public class ScreenShaderData : ShaderData
	{
		// Token: 0x17000780 RID: 1920
		// (get) Token: 0x06003D8D RID: 15757 RVA: 0x002398C4 File Offset: 0x00237AC4
		public float Intensity
		{
			get
			{
				/*
An exception occurred when decompiling this method (06003D8D)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Single Terraria.Graphics.Shaders.ScreenShaderData::get_Intensity()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:float32(var_0_06, ldfld:float32(ScreenShaderData::_uIntensity, ldloc:ScreenShaderData(this)))
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
		}

		// Token: 0x17000781 RID: 1921
		// (get) Token: 0x06003D8E RID: 15758 RVA: 0x002398D8 File Offset: 0x00237AD8
		public float CombinedOpacity
		{
			get
			{
				/*
An exception occurred when decompiling this method (06003D8E)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Single Terraria.Graphics.Shaders.ScreenShaderData::get_CombinedOpacity()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:float32(var_0_06, ldfld:float32(ScreenShaderData::_uOpacity, ldloc:ScreenShaderData(this)))
	stloc:float32(var_1_0D, ldfld:float32(ScreenShaderData::_globalOpacity, ldloc:ScreenShaderData(this)))
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
		}

		// Token: 0x06003D8F RID: 15759 RVA: 0x002398F4 File Offset: 0x00237AF4
		public ScreenShaderData(string passName)
		{
			if (!true)
			{
			}
			if (true)
			{
				return;
			}
			if (!true)
			{
			}
			this._uIntensity = (float)16256;
			this._uSecondaryColor.Z = (float)1;
			if (!true)
			{
			}
			if (!true)
			{
			}
			if (!true)
			{
			}
			this._uImageOffset = 1;
			if (true)
			{
				return;
			}
			if (true)
			{
				return;
			}
			if (!true)
			{
			}
			if (!true)
			{
			}
			base..ctor();
			this._passName = passName;
		}

		// Token: 0x06003D90 RID: 15760 RVA: 0x00239950 File Offset: 0x00237B50
		public ScreenShaderData(Ref<Effect> shader, string passName)
		{
			if (!true)
			{
			}
			if (true)
			{
				return;
			}
			if (!true)
			{
			}
			this._uIntensity = (float)16256;
			this._uSecondaryColor.Z = (float)1;
			if (!true)
			{
			}
			if (!true)
			{
			}
			if (!true)
			{
			}
			this._uImageOffset = 1;
			if (true)
			{
				return;
			}
			if (true)
			{
				return;
			}
			if (!true)
			{
			}
			base..ctor();
			this._shader = shader;
		}

		// Token: 0x06003D91 RID: 15761 RVA: 0x002399A8 File Offset: 0x00237BA8
		public virtual void Update(GameTime gameTime)
		{
		}

		// Token: 0x06003D92 RID: 15762 RVA: 0x002399B8 File Offset: 0x00237BB8
		public override void Apply()
		{
			if (!true)
			{
			}
			if (!true)
			{
			}
			int screenWidth = Main.screenWidth;
			int screenHeight = Main.screenHeight;
			if (!true)
			{
			}
			Vector2 screenPosition = Main.screenPosition;
			!0 value = this._shader.Value;
			!0 value2 = this._shader.Value;
			float uOpacity = this._uOpacity;
			float globalOpacity = this._globalOpacity;
			!0 value3 = this._shader.Value;
			float x = this._uSecondaryColor.X;
			float y = this._uSecondaryColor.Y;
			float z = this._uSecondaryColor.Z;
			!0 value4 = this._shader.Value;
			!0 value5 = this._shader.Value;
			!0 value6 = this._shader.Value;
			!0 value7 = this._shader.Value;
			float x2 = this._uTargetPosition.X;
			float y2 = this._uTargetPosition.Y;
			!0 value8 = this._shader.Value;
			float x3 = this._uImageOffset.X;
			float y3 = this._uImageOffset.Y;
			!0 value9 = this._shader.Value;
			float uIntensity = this._uIntensity;
			!0 value10 = this._shader.Value;
			float uProgress = this._uProgress;
			!0 value11 = this._shader.Value;
			float x4 = this._uDirection.X;
			float y4 = this._uDirection.Y;
			!0 value12 = this._shader.Value;
			Asset<Texture2D>[] uAssetImages = this._uAssetImages;
			Texture2D[] uCustomImages = this._uCustomImages;
			string <Name>k__BackingField = uCustomImages.<Name>k__BackingField;
			EffectParameter effectParameter;
			Asset<Texture2D>[] uAssetImages2;
			if (effectParameter != null)
			{
				uAssetImages2 = this._uAssetImages;
			}
			if (<Name>k__BackingField == null)
			{
				Asset<Texture2D>[] uAssetImages3 = this._uAssetImages;
				base.Apply();
				return;
			}
			if (uAssetImages2 == null)
			{
			}
			GraphicsDevice graphicsDevice;
			Texture2D[] textures = graphicsDevice.Textures;
			if (<Name>k__BackingField != null)
			{
				!0 value13 = this._shader.Value;
				string text2;
				string text = "uImageSize" + text2;
				Vector2[] imageScales = this._imageScales;
				if (uCustomImages == null)
				{
				}
				return;
			}
			throw new ArrayTypeMismatchException();
		}

		// Token: 0x06003D93 RID: 15763 RVA: 0x00239B98 File Offset: 0x00237D98
		public ScreenShaderData UseImageOffset(Vector2 offset)
		{
			return this;
		}

		// Token: 0x06003D94 RID: 15764 RVA: 0x00239BA8 File Offset: 0x00237DA8
		public ScreenShaderData UseIntensity(float intensity)
		{
			return this;
		}

		// Token: 0x06003D95 RID: 15765 RVA: 0x00239BB8 File Offset: 0x00237DB8
		public ScreenShaderData UseColor(float r, float g, float b)
		{
			return this;
		}

		// Token: 0x06003D96 RID: 15766 RVA: 0x00239BC8 File Offset: 0x00237DC8
		public ScreenShaderData UseProgress(float progress)
		{
			return this;
		}

		// Token: 0x06003D97 RID: 15767 RVA: 0x00239BD8 File Offset: 0x00237DD8
		public ScreenShaderData UseImage(Texture2D image, int index = 0, [Optional] SamplerState samplerState)
		{
			SamplerState[] samplerStates = this._samplerStates;
			if (samplerState == null || samplerState != null)
			{
				Asset<Texture2D>[] uAssetImages = this._uAssetImages;
				Texture2D[] uCustomImages = this._uCustomImages;
				if (image == null || image != null)
				{
					return this;
				}
			}
			throw new ArrayTypeMismatchException();
		}

		// Token: 0x06003D98 RID: 15768 RVA: 0x00239C10 File Offset: 0x00237E10
		public ScreenShaderData UseImage(string path, int index = 0, [Optional] SamplerState samplerState)
		{
			int num = 1;
			Asset<Texture2D>[] uAssetImages = this._uAssetImages;
			if (num == 0)
			{
			}
			Texture2D[] uCustomImages = this._uCustomImages;
			SamplerState[] samplerStates = this._samplerStates;
			if (samplerState == null || samplerState != null)
			{
				return this;
			}
			throw new ArrayTypeMismatchException();
		}

		// Token: 0x06003D99 RID: 15769 RVA: 0x00239C44 File Offset: 0x00237E44
		public ScreenShaderData UseColor(Color color)
		{
			return this;
		}

		// Token: 0x06003D9A RID: 15770 RVA: 0x00239C54 File Offset: 0x00237E54
		public ScreenShaderData UseColor(Vector3 color)
		{
			return this;
		}

		// Token: 0x06003D9B RID: 15771 RVA: 0x00239C64 File Offset: 0x00237E64
		public ScreenShaderData UseDirection(Vector2 direction)
		{
			return this;
		}

		// Token: 0x06003D9C RID: 15772 RVA: 0x00239C74 File Offset: 0x00237E74
		public ScreenShaderData UseGlobalOpacity(float opacity)
		{
			return this;
		}

		// Token: 0x06003D9D RID: 15773 RVA: 0x00239C84 File Offset: 0x00237E84
		public ScreenShaderData UseTargetPosition(Vector2 position)
		{
			return this;
		}

		// Token: 0x06003D9E RID: 15774 RVA: 0x00239C94 File Offset: 0x00237E94
		public ScreenShaderData UseSecondaryColor(float r, float g, float b)
		{
			return this;
		}

		// Token: 0x06003D9F RID: 15775 RVA: 0x00239CA4 File Offset: 0x00237EA4
		public ScreenShaderData UseSecondaryColor(Color color)
		{
			return this;
		}

		// Token: 0x06003DA0 RID: 15776 RVA: 0x00239CB4 File Offset: 0x00237EB4
		public ScreenShaderData UseSecondaryColor(Vector3 color)
		{
			return this;
		}

		// Token: 0x06003DA1 RID: 15777 RVA: 0x00239CC4 File Offset: 0x00237EC4
		public ScreenShaderData UseOpacity(float opacity)
		{
			return this;
		}

		// Token: 0x06003DA2 RID: 15778 RVA: 0x00239CD4 File Offset: 0x00237ED4
		public ScreenShaderData UseImageScale(Vector2 scale, int index = 0)
		{
			Vector2[] imageScales = this._imageScales;
			return this;
		}

		// Token: 0x06003DA3 RID: 15779 RVA: 0x00239CEC File Offset: 0x00237EEC
		public virtual ScreenShaderData GetSecondaryShader(Player player)
		{
			return this;
		}

		// Token: 0x04007C5A RID: 31834
		private Vector3 _uColor;

		// Token: 0x04007C5B RID: 31835
		private Vector3 _uSecondaryColor;

		// Token: 0x04007C5C RID: 31836
		private float _uOpacity;

		// Token: 0x04007C5D RID: 31837
		private float _globalOpacity;

		// Token: 0x04007C5E RID: 31838
		private float _uIntensity;

		// Token: 0x04007C5F RID: 31839
		private Vector2 _uTargetPosition;

		// Token: 0x04007C60 RID: 31840
		private Vector2 _uDirection;

		// Token: 0x04007C61 RID: 31841
		private float _uProgress;

		// Token: 0x04007C62 RID: 31842
		private Vector2 _uImageOffset;

		// Token: 0x04007C63 RID: 31843
		private Asset<Texture2D>[] _uAssetImages;

		// Token: 0x04007C64 RID: 31844
		private Texture2D[] _uCustomImages;

		// Token: 0x04007C65 RID: 31845
		private SamplerState[] _samplerStates;

		// Token: 0x04007C66 RID: 31846
		private Vector2[] _imageScales;
	}
}
