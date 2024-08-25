using System;
using System.Collections.ObjectModel;
using InControl;
using UnityEngine;

namespace BindingsExample
{
	// Token: 0x0200000D RID: 13
	public class BindingsExample : MonoBehaviour
	{
		// Token: 0x06000042 RID: 66 RVA: 0x00002E9C File Offset: 0x0000109C
		private void OnEnable()
		{
			PlayerActions playerActions = PlayerActions.CreateWithDefaultBindings();
			this.playerActions = playerActions;
			this.LoadBindings();
		}

		// Token: 0x06000043 RID: 67 RVA: 0x00002EBC File Offset: 0x000010BC
		private void OnDisable()
		{
			this.playerActions.Destroy();
		}

		// Token: 0x06000044 RID: 68 RVA: 0x00002ED4 File Offset: 0x000010D4
		private void Start()
		{
			Renderer component = base.GetComponent<Renderer>();
			this.cachedRenderer = component;
		}

		// Token: 0x06000045 RID: 69 RVA: 0x00002EF0 File Offset: 0x000010F0
		private void Update()
		{
			Transform transform = base.transform;
			float deltaTime = Time.deltaTime;
			float <X>k__BackingField = this.playerActions.Move.<X>k__BackingField;
			Transform transform2 = base.transform;
			float deltaTime2 = Time.deltaTime;
			float <Y>k__BackingField = this.playerActions.Move.<Y>k__BackingField;
			bool isPressed = this.playerActions.Fire.IsPressed;
			bool isPressed2 = this.playerActions.Jump.IsPressed;
			Material material = this.cachedRenderer.material;
		}

		// Token: 0x06000046 RID: 70 RVA: 0x00002F74 File Offset: 0x00001174
		private void SaveBindings()
		{
			string text = this.playerActions.Save();
			this.saveData = text;
			PlayerPrefs.SetString("Bindings", text);
		}

		// Token: 0x06000047 RID: 71 RVA: 0x00002FA0 File Offset: 0x000011A0
		private void LoadBindings()
		{
			bool flag = PlayerPrefs.HasKey("Bindings");
			string @string = PlayerPrefs.GetString("Bindings");
			PlayerActions playerActions = this.playerActions;
			this.saveData = @string;
			playerActions.Load(@string);
		}

		// Token: 0x06000048 RID: 72 RVA: 0x00002FDC File Offset: 0x000011DC
		private void OnApplicationQuit()
		{
			PlayerPrefs.Save();
		}

		// Token: 0x06000049 RID: 73 RVA: 0x00002FF0 File Offset: 0x000011F0
		private void OnGUI()
		{
			PlayerActions playerActions = this.playerActions;
			BindingSourceType lastInputType = playerActions.LastInputType;
			string text2;
			string text = "Last Input Type: " + text2;
			if (playerActions == null)
			{
			}
			InputDeviceClass lastDeviceClass = this.playerActions.LastDeviceClass;
			string text4;
			string text3 = "Last Device Class: " + text4;
			PlayerActions playerActions2 = this.playerActions;
			InputDeviceStyle lastDeviceStyle = playerActions2.LastDeviceStyle;
			string text6;
			string text5 = "Last Device Style: " + text6;
			ReadOnlyCollection<PlayerAction> <Actions>k__BackingField = this.playerActions.<Actions>k__BackingField;
			string text8;
			string text9;
			string text7 = text8 + " = " + text9;
			if (17402 == 0)
			{
			}
			string text10 = text7 + ": " + text7;
			if (playerActions2 == null)
			{
			}
		}

		// Token: 0x0600004A RID: 74 RVA: 0x000030B0 File Offset: 0x000012B0
		public BindingsExample()
		{
		}

		// Token: 0x04000029 RID: 41
		private Renderer cachedRenderer;

		// Token: 0x0400002A RID: 42
		private PlayerActions playerActions;

		// Token: 0x0400002B RID: 43
		private string saveData;
	}
}
