using System;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Microsoft.Xna.Framework;

namespace Terraria.DataStructures
{
	// Token: 0x02000671 RID: 1649
	public class SettingsForCharacterPreview
	{
		// Token: 0x06003722 RID: 14114 RVA: 0x002211C4 File Offset: 0x0021F3C4
		public void ApplyTo(Projectile proj, bool walking)
		{
			int num = 1;
			float x = proj.position.X;
			float y = proj.position.Y;
			float x2 = this.Offset.X;
			float y2 = this.Offset.Y;
			if (num == 0)
			{
			}
			int spriteDirection = this.SpriteDirection;
			proj.spriteDirection = spriteDirection;
			proj.direction = spriteDirection;
			SettingsForCharacterPreview.CustomAnimationCode customAnimation = this.CustomAnimation;
			if (customAnimation != null)
			{
				IntPtr invoke_impl = customAnimation.invoke_impl;
				IntPtr method_code = customAnimation.method_code;
				IntPtr method = customAnimation.method;
				return;
			}
		}

		// Token: 0x06003723 RID: 14115 RVA: 0x0022124C File Offset: 0x0021F44C
		public SettingsForCharacterPreview WhenSelected([Optional] int? startFrame, [Optional] int? frameCount, [Optional] int? delayPerFrame, [Optional] bool? bounceLoop)
		{
			return this;
		}

		// Token: 0x06003724 RID: 14116 RVA: 0x0022125C File Offset: 0x0021F45C
		public SettingsForCharacterPreview WhenNotSelected([Optional] int? startFrame, [Optional] int? frameCount, [Optional] int? delayPerFrame, [Optional] bool? bounceLoop)
		{
			return this;
		}

		// Token: 0x06003725 RID: 14117 RVA: 0x000021DB File Offset: 0x000003DB
		private static void Modify(SettingsForCharacterPreview.SelectionBasedSettings target, int? startFrame, int? frameCount, int? delayPerFrame, bool? bounceLoop)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06003726 RID: 14118 RVA: 0x0022126C File Offset: 0x0021F46C
		public SettingsForCharacterPreview WithOffset(Vector2 offset)
		{
			return this;
		}

		// Token: 0x06003727 RID: 14119 RVA: 0x0022127C File Offset: 0x0021F47C
		public SettingsForCharacterPreview WithOffset(float x, float y)
		{
			return this;
		}

		// Token: 0x06003728 RID: 14120 RVA: 0x0022128C File Offset: 0x0021F48C
		public SettingsForCharacterPreview WithSpriteDirection(int spriteDirection)
		{
			this.SpriteDirection = spriteDirection;
			return this;
		}

		// Token: 0x06003729 RID: 14121 RVA: 0x002212A4 File Offset: 0x0021F4A4
		public SettingsForCharacterPreview WithCode(SettingsForCharacterPreview.CustomAnimationCode customAnimation)
		{
			this.CustomAnimation = customAnimation;
			return this;
		}

		// Token: 0x0600372A RID: 14122 RVA: 0x002212BC File Offset: 0x0021F4BC
		public SettingsForCharacterPreview()
		{
		}

		// Token: 0x0400781C RID: 30748
		public Vector2 Offset;

		// Token: 0x0400781D RID: 30749
		public SettingsForCharacterPreview.SelectionBasedSettings Selected;

		// Token: 0x0400781E RID: 30750
		public SettingsForCharacterPreview.SelectionBasedSettings NotSelected;

		// Token: 0x0400781F RID: 30751
		public int SpriteDirection = 1;

		// Token: 0x04007820 RID: 30752
		public SettingsForCharacterPreview.CustomAnimationCode CustomAnimation;

		// Token: 0x02000672 RID: 1650
		public sealed class CustomAnimationCode : MulticastDelegate
		{
			// Token: 0x0600372B RID: 14123 RVA: 0x002212D8 File Offset: 0x0021F4D8
			public CustomAnimationCode(object @object, IntPtr method)
			{
				this.method_ptr = method;
				this.m_target = @object;
				this.method = method;
				this.method_code = this;
			}

			// Token: 0x0600372C RID: 14124 RVA: 0x00221338 File Offset: 0x0021F538
			public void Invoke(Projectile proj, bool walking)
			{
				IntPtr method_code = this.method_code;
				IntPtr invoke_impl = this.invoke_impl;
				IntPtr method = this.method;
			}

			// Token: 0x0600372D RID: 14125 RVA: 0x000021DB File Offset: 0x000003DB
			public IAsyncResult BeginInvoke(Projectile proj, bool walking, AsyncCallback callback, object @object)
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}

			// Token: 0x0600372E RID: 14126 RVA: 0x0022135C File Offset: 0x0021F55C
			public void EndInvoke(IAsyncResult result)
			{
			}
		}

		// Token: 0x02000673 RID: 1651
		public struct SelectionBasedSettings
		{
			// Token: 0x0600372F RID: 14127 RVA: 0x0022136C File Offset: 0x0021F56C
			public void ApplyTo(Projectile proj)
			{
				if (this.FrameCount != 0)
				{
					int frame = proj.frame;
					int delayPerFrame = this.DelayPerFrame;
					bool bounceLoop = this.BounceLoop;
					int frameCounter = proj.frameCounter;
					proj.frameCounter = frameCounter;
					if (bounceLoop)
					{
					}
				}
			}

			// Token: 0x04007821 RID: 30753
			public int StartFrame;

			// Token: 0x04007822 RID: 30754
			public int FrameCount;

			// Token: 0x04007823 RID: 30755
			public int DelayPerFrame;

			// Token: 0x04007824 RID: 30756
			public bool BounceLoop;
		}
	}
}
