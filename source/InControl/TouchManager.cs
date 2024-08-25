using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using UnityEngine;

namespace InControl
{
	// Token: 0x02000053 RID: 83
	[ExecuteInEditMode]
	public class TouchManager : SingletonMonoBehavior<TouchManager>
	{
		// Token: 0x1400000F RID: 15
		// (add) Token: 0x060003D2 RID: 978 RVA: 0x0000CBCC File Offset: 0x0000ADCC
		// (remove) Token: 0x060003D3 RID: 979 RVA: 0x0000CBE4 File Offset: 0x0000ADE4
		public static event Action OnSetup
		{
			[CompilerGenerated]
			add
			{
				Delegate @delegate;
				if (@delegate != null)
				{
				}
			}
			[CompilerGenerated]
			remove
			{
				Delegate @delegate;
				if (@delegate != null)
				{
				}
			}
		}

		// Token: 0x060003D4 RID: 980 RVA: 0x0000CBFC File Offset: 0x0000ADFC
		protected TouchManager()
		{
			if (3 == 0)
			{
			}
			base..ctor();
		}

		// Token: 0x060003D5 RID: 981 RVA: 0x0000CC28 File Offset: 0x0000AE28
		private void OnEnable()
		{
			InControlManager component = base.GetComponent<InControlManager>();
			Debug.LogError("Touch Manager component can only be added to the InControl Manager object.");
			global::UnityEngine.Object.DestroyImmediate(this);
		}

		// Token: 0x060003D6 RID: 982 RVA: 0x0000CC70 File Offset: 0x0000AE70
		private void OnDisable()
		{
			bool isPlaying = Application.isPlaying;
			this.Reset();
		}

		// Token: 0x060003D7 RID: 983 RVA: 0x0000CC8C File Offset: 0x0000AE8C
		private void Setup()
		{
			Vector2 currentScreenSize = this.GetCurrentScreenSize();
			this.CreateDevice();
			this.CreateTouches();
		}

		// Token: 0x060003D8 RID: 984 RVA: 0x0000CCAC File Offset: 0x0000AEAC
		private void Reset()
		{
			Touch[] array = this.mouseTouches;
		}

		// Token: 0x060003D9 RID: 985 RVA: 0x000025E1 File Offset: 0x000007E1
		private IEnumerator UpdateScreenSizeAtEndOfFrame()
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x060003DA RID: 986 RVA: 0x0000CCC4 File Offset: 0x0000AEC4
		private void Update()
		{
			Vector2 currentScreenSize = this.GetCurrentScreenSize();
			if (this.isReady)
			{
				float x = this.screenSize.x;
				float y = this.screenSize.y;
				return;
			}
			IEnumerator enumerator = this.UpdateScreenSizeAtEndOfFrame();
			Coroutine coroutine = base.StartCoroutine(enumerator);
			this.isReady = true;
		}

		// Token: 0x060003DB RID: 987 RVA: 0x0000CD10 File Offset: 0x0000AF10
		private void CreateDevice()
		{
			InputDevice inputDevice = this.device;
			InputDevice inputDevice2 = this.device;
			InputDevice inputDevice3 = this.device;
			InputDevice inputDevice4 = this.device;
			InputDevice inputDevice5 = this.device;
			InputDevice inputDevice6 = this.device;
			InputDevice inputDevice7 = this.device;
			InputDevice inputDevice8 = this.device;
			InputDevice inputDevice9 = this.device;
			InputDevice inputDevice10 = this.device;
			InputDevice inputDevice11 = this.device;
			InputDevice inputDevice12 = this.device;
			InputDevice inputDevice13 = this.device;
			InputDevice inputDevice14 = this.device;
			InputDevice inputDevice15 = this.device;
			InputDevice inputDevice16 = this.device;
			InputDevice inputDevice17 = this.device;
			InputDevice inputDevice18 = this.device;
			InputManager.AttachDevice(this.device);
		}

		// Token: 0x060003DC RID: 988 RVA: 0x0000CDC4 File Offset: 0x0000AFC4
		private void UpdateDevice(ulong updateTick, float deltaTime)
		{
			this.UpdateTouches(updateTick, deltaTime);
			this.SubmitControlStates(updateTick, deltaTime);
		}

		// Token: 0x060003DD RID: 989 RVA: 0x0000CDE4 File Offset: 0x0000AFE4
		private void CommitDevice(ulong updateTick, float deltaTime)
		{
			this.CommitControlStates(updateTick, deltaTime);
		}

		// Token: 0x060003DE RID: 990 RVA: 0x0000CDFC File Offset: 0x0000AFFC
		private void SubmitControlStates(ulong updateTick, float deltaTime)
		{
			TouchControl[] array = this.touchControls;
			bool enabled = base.enabled;
			GameObject gameObject;
			bool activeInHierarchy = gameObject.activeInHierarchy;
			TouchControl[] array2 = this.touchControls;
			throw new MissingMethodException();
		}

		// Token: 0x060003DF RID: 991 RVA: 0x0000CE30 File Offset: 0x0000B030
		private void CommitControlStates(ulong updateTick, float deltaTime)
		{
			TouchControl[] array = this.touchControls;
			bool enabled = base.enabled;
			GameObject gameObject;
			bool activeInHierarchy = gameObject.activeInHierarchy;
			TouchControl[] array2 = this.touchControls;
			throw new MissingMethodException();
		}

		// Token: 0x060003E0 RID: 992 RVA: 0x0000CE64 File Offset: 0x0000B064
		private void UpdateScreenSize(Vector2 currentScreenSize)
		{
			Camera camera = this.touchCamera;
			Camera camera2 = this.touchCamera;
			Camera camera3 = this.touchCamera;
			float orthographicSize = this.touchCamera.orthographicSize;
			float y = this.screenSize.y;
			this.pixelToWorld = y;
			if (this.touchControls != null)
			{
				TouchControl[] array = this.touchControls;
			}
		}

		// Token: 0x060003E1 RID: 993 RVA: 0x0000CEBC File Offset: 0x0000B0BC
		private void CreateTouches()
		{
			Touch[] array = this.mouseTouches;
			Touch[] array2 = this.mouseTouches;
		}

		// Token: 0x060003E2 RID: 994 RVA: 0x000025E1 File Offset: 0x000007E1
		private void UpdateTouches(ulong updateTick, float deltaTime)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x060003E3 RID: 995 RVA: 0x0000CEE4 File Offset: 0x0000B0E4
		private void SendTouchBegan(Touch touch)
		{
			TouchControl[] array = this.touchControls;
			bool enabled = base.enabled;
			GameObject gameObject;
			bool activeInHierarchy = gameObject.activeInHierarchy;
			throw new MissingMethodException();
		}

		// Token: 0x060003E4 RID: 996 RVA: 0x0000CF10 File Offset: 0x0000B110
		private void SendTouchMoved(Touch touch)
		{
			TouchControl[] array = this.touchControls;
			bool enabled = base.enabled;
			GameObject gameObject;
			bool activeInHierarchy = gameObject.activeInHierarchy;
			TouchControl[] array2 = this.touchControls;
			throw new MissingMethodException();
		}

		// Token: 0x060003E5 RID: 997 RVA: 0x0000CF44 File Offset: 0x0000B144
		private void SendTouchEnded(Touch touch)
		{
			TouchControl[] array = this.touchControls;
			bool enabled = base.enabled;
			GameObject gameObject;
			bool activeInHierarchy = gameObject.activeInHierarchy;
			TouchControl[] array2 = this.touchControls;
			throw new MissingMethodException();
		}

		// Token: 0x060003E6 RID: 998 RVA: 0x0000CF78 File Offset: 0x0000B178
		private void InvokeTouchEvents()
		{
			int size = this.activeTouches._size;
			if (this.enableControlsOnTouch && !this._controlsEnabled)
			{
				TouchManager.Device.RequestActivation();
				int num = 1;
				this.controlsEnabled = num != 0;
				return;
			}
			int size2 = this.activeTouches._size;
		}

		// Token: 0x060003E7 RID: 999 RVA: 0x0000CFC8 File Offset: 0x0000B1C8
		private bool TouchCameraIsValid()
		{
			Camera camera = this.touchCamera;
			if (!true)
			{
			}
			float orthographicSize = this.touchCamera.orthographicSize;
			if (!true)
			{
			}
			bool flag = Utility.IsZero(orthographicSize);
			float width = this.touchCamera.rect.width;
			if (!true)
			{
			}
			bool flag2 = Utility.IsZero(width);
			float height = this.touchCamera.rect.height;
			if (!true)
			{
			}
			bool flag3 = Utility.IsZero(height);
			float width2 = this.touchCamera.pixelRect.width;
			if (!true)
			{
			}
			bool flag4 = Utility.IsZero(width2);
			float height2 = this.touchCamera.pixelRect.height;
			if (!true)
			{
			}
			bool flag5 = Utility.IsZero(height2);
			return true;
		}

		// Token: 0x060003E8 RID: 1000 RVA: 0x0000D080 File Offset: 0x0000B280
		private Vector3 ConvertScreenToWorldPoint(Vector2 point)
		{
			bool flag = this.TouchCameraIsValid();
			Vector3 position = this.touchCamera.transform.position;
			Vector3 vector;
			return vector;
		}

		// Token: 0x060003E9 RID: 1001 RVA: 0x0000D0A8 File Offset: 0x0000B2A8
		private Vector3 ConvertViewToWorldPoint(Vector2 point)
		{
			bool flag = this.TouchCameraIsValid();
			Vector3 position = this.touchCamera.transform.position;
			Vector3 vector;
			return vector;
		}

		// Token: 0x060003EA RID: 1002 RVA: 0x0000D0D0 File Offset: 0x0000B2D0
		private Vector3 ConvertScreenToViewPoint(Vector2 point)
		{
			bool flag = this.TouchCameraIsValid();
			Vector3 position = this.touchCamera.transform.position;
			Vector3 vector;
			return vector;
		}

		// Token: 0x060003EB RID: 1003 RVA: 0x0000D0F8 File Offset: 0x0000B2F8
		private Vector2 GetCurrentScreenSize()
		{
			/*
An exception occurred when decompiling this method (060003EB)

ICSharpCode.Decompiler.DecompilerException: Error decompiling UnityEngine.Vector2 InControl.TouchManager::GetCurrentScreenSize()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:bool(var_0_06, call:bool(TouchManager::TouchCameraIsValid, ldloc:TouchManager(this)))
	stloc:int32(var_1_12, callgetter:int32(Camera::get_pixelWidth, ldfld:Camera(TouchManager::touchCamera, ldloc:TouchManager(this))))
	stloc:int32(var_2_1E, callgetter:int32(Camera::get_pixelHeight, ldfld:Camera(TouchManager::touchCamera, ldloc:TouchManager(this))))
	stloc:int32(var_4_26, callgetter:int32(Screen::get_width))
	stloc:int32(var_6_30, callgetter:int32(Screen::get_height))
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

		// Token: 0x17000127 RID: 295
		// (get) Token: 0x060003EC RID: 1004 RVA: 0x0000D138 File Offset: 0x0000B338
		// (set) Token: 0x060003ED RID: 1005 RVA: 0x0000D14C File Offset: 0x0000B34C
		public bool controlsEnabled
		{
			get
			{
				return this._controlsEnabled;
			}
			set
			{
				bool controlsEnabled = this._controlsEnabled;
				TouchControl[] array = this.touchControls;
				base.enabled = value;
				TouchControl[] array2 = this.touchControls;
				base.enabled = value;
			}
		}

		// Token: 0x17000128 RID: 296
		// (get) Token: 0x060003EE RID: 1006 RVA: 0x0000D180 File Offset: 0x0000B380
		public static ReadOnlyCollection<Touch> Touches
		{
			get
			{
				/*
An exception occurred when decompiling this method (060003EE)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Collections.ObjectModel.ReadOnlyCollection`1<InControl.Touch> InControl.TouchManager::get_Touches()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0003:
	stloc:!0(var_0_08, callgetter:!0(SingletonMonoBehavior`1::get_Instance))
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

		// Token: 0x17000129 RID: 297
		// (get) Token: 0x060003EF RID: 1007 RVA: 0x0000D198 File Offset: 0x0000B398
		public static int TouchCount
		{
			get
			{
				/*
An exception occurred when decompiling this method (060003EF)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Int32 InControl.TouchManager::get_TouchCount()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0003:
	stloc:!0(var_0_08, callgetter:!0(SingletonMonoBehavior`1::get_Instance))
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

		// Token: 0x060003F0 RID: 1008 RVA: 0x0000D1B0 File Offset: 0x0000B3B0
		public static Touch GetTouch(int touchIndex)
		{
			/*
An exception occurred when decompiling this method (060003F0)

ICSharpCode.Decompiler.DecompilerException: Error decompiling InControl.Touch InControl.TouchManager::GetTouch(System.Int32)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0003:
	stloc:!0(var_0_08, callgetter:!0(SingletonMonoBehavior`1::get_Instance))
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

		// Token: 0x060003F1 RID: 1009 RVA: 0x0000D1C8 File Offset: 0x0000B3C8
		public static Touch GetTouchByFingerId(int fingerId)
		{
			if (!true)
			{
			}
			!0 instance = SingletonMonoBehavior.Instance;
			Touch touch;
			return touch;
		}

		// Token: 0x060003F2 RID: 1010 RVA: 0x0000D1E0 File Offset: 0x0000B3E0
		public static Vector3 ScreenToWorldPoint(Vector2 point)
		{
			if (!true)
			{
			}
			!0 instance = SingletonMonoBehavior.Instance;
			return 1;
		}

		// Token: 0x060003F3 RID: 1011 RVA: 0x0000D1F8 File Offset: 0x0000B3F8
		public static Vector3 ViewToWorldPoint(Vector2 point)
		{
			if (!true)
			{
			}
			!0 instance = SingletonMonoBehavior.Instance;
			return 1;
		}

		// Token: 0x060003F4 RID: 1012 RVA: 0x0000D210 File Offset: 0x0000B410
		public static Vector3 ScreenToViewPoint(Vector2 point)
		{
			if (!true)
			{
			}
			!0 instance = SingletonMonoBehavior.Instance;
			return 1;
		}

		// Token: 0x060003F5 RID: 1013 RVA: 0x0000D228 File Offset: 0x0000B428
		public static float ConvertToWorld(float value, TouchUnitType unitType)
		{
			/*
An exception occurred when decompiling this method (060003F5)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Single InControl.TouchManager::ConvertToWorld(System.Single,InControl.TouchUnitType)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:float32(var_0_05, callgetter:float32(TouchManager::get_PixelToWorld))
	stloc:float32(var_1_0B, callgetter:float32(TouchManager::get_PercentToWorld))
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

		// Token: 0x060003F6 RID: 1014 RVA: 0x0000D240 File Offset: 0x0000B440
		public static Rect PercentToWorldRect(Rect rect)
		{
			/*
An exception occurred when decompiling this method (060003F6)

ICSharpCode.Decompiler.DecompilerException: Error decompiling UnityEngine.Rect InControl.TouchManager::PercentToWorldRect(UnityEngine.Rect)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:Vector3(var_1_05, callgetter:Vector3(TouchManager::get_ViewSize))
	stloc:Vector3(var_3_0B, callgetter:Vector3(TouchManager::get_ViewSize))
	stloc:Vector3(var_5_11, callgetter:Vector3(TouchManager::get_ViewSize))
	stloc:Vector3(var_7_18, callgetter:Vector3(TouchManager::get_ViewSize))
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

		// Token: 0x060003F7 RID: 1015 RVA: 0x0000D268 File Offset: 0x0000B468
		public static Rect PixelToWorldRect(Rect rect)
		{
			/*
An exception occurred when decompiling this method (060003F7)

ICSharpCode.Decompiler.DecompilerException: Error decompiling UnityEngine.Rect InControl.TouchManager::PixelToWorldRect(UnityEngine.Rect)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:Vector2(var_1_05, callgetter:Vector2(TouchManager::get_HalfScreenSize))
	stloc:float32(var_2_0B, callgetter:float32(TouchManager::get_PixelToWorld))
	stloc:Vector2(var_4_11, callgetter:Vector2(TouchManager::get_HalfScreenSize))
	stloc:float32(var_5_18, callgetter:float32(TouchManager::get_PixelToWorld))
	stloc:float32(var_7_1F, callgetter:float32(TouchManager::get_PixelToWorld))
	stloc:float32(var_9_26, callgetter:float32(TouchManager::get_PixelToWorld))
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

		// Token: 0x060003F8 RID: 1016 RVA: 0x0000D29C File Offset: 0x0000B49C
		public static Rect ConvertToWorld(Rect rect, TouchUnitType unitType)
		{
			Rect rect2;
			return rect2;
		}

		// Token: 0x1700012A RID: 298
		// (get) Token: 0x060003F9 RID: 1017 RVA: 0x0000D2B4 File Offset: 0x0000B4B4
		public static Camera Camera
		{
			get
			{
				/*
An exception occurred when decompiling this method (060003F9)

ICSharpCode.Decompiler.DecompilerException: Error decompiling UnityEngine.Camera InControl.TouchManager::get_Camera()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0003:
	stloc:!0(var_0_08, callgetter:!0(SingletonMonoBehavior`1::get_Instance))
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

		// Token: 0x1700012B RID: 299
		// (get) Token: 0x060003FA RID: 1018 RVA: 0x0000D2CC File Offset: 0x0000B4CC
		public static InputDevice Device
		{
			get
			{
				/*
An exception occurred when decompiling this method (060003FA)

ICSharpCode.Decompiler.DecompilerException: Error decompiling InControl.InputDevice InControl.TouchManager::get_Device()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0003:
	stloc:!0(var_0_08, callgetter:!0(SingletonMonoBehavior`1::get_Instance))
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

		// Token: 0x1700012C RID: 300
		// (get) Token: 0x060003FB RID: 1019 RVA: 0x0000D2E4 File Offset: 0x0000B4E4
		public static Vector3 ViewSize
		{
			get
			{
				if (!true)
				{
				}
				!0 instance = SingletonMonoBehavior.Instance;
				return 1;
			}
		}

		// Token: 0x1700012D RID: 301
		// (get) Token: 0x060003FC RID: 1020 RVA: 0x0000D2FC File Offset: 0x0000B4FC
		public static float PercentToWorld
		{
			get
			{
				/*
An exception occurred when decompiling this method (060003FC)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Single InControl.TouchManager::get_PercentToWorld()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0003:
	stloc:!0(var_0_08, callgetter:!0(SingletonMonoBehavior`1::get_Instance))
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

		// Token: 0x1700012E RID: 302
		// (get) Token: 0x060003FD RID: 1021 RVA: 0x0000D314 File Offset: 0x0000B514
		public static float HalfPercentToWorld
		{
			get
			{
				/*
An exception occurred when decompiling this method (060003FD)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Single InControl.TouchManager::get_HalfPercentToWorld()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0003:
	stloc:!0(var_0_08, callgetter:!0(SingletonMonoBehavior`1::get_Instance))
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

		// Token: 0x1700012F RID: 303
		// (get) Token: 0x060003FE RID: 1022 RVA: 0x0000D32C File Offset: 0x0000B52C
		public static float PixelToWorld
		{
			get
			{
				/*
An exception occurred when decompiling this method (060003FE)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Single InControl.TouchManager::get_PixelToWorld()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0003:
	stloc:!0(var_0_08, callgetter:!0(SingletonMonoBehavior`1::get_Instance))
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

		// Token: 0x17000130 RID: 304
		// (get) Token: 0x060003FF RID: 1023 RVA: 0x0000D344 File Offset: 0x0000B544
		public static float HalfPixelToWorld
		{
			get
			{
				/*
An exception occurred when decompiling this method (060003FF)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Single InControl.TouchManager::get_HalfPixelToWorld()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0003:
	stloc:!0(var_0_08, callgetter:!0(SingletonMonoBehavior`1::get_Instance))
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

		// Token: 0x17000131 RID: 305
		// (get) Token: 0x06000400 RID: 1024 RVA: 0x0000D35C File Offset: 0x0000B55C
		public static Vector2 ScreenSize
		{
			get
			{
				if (!true)
				{
				}
				!0 instance = SingletonMonoBehavior.Instance;
				return 1;
			}
		}

		// Token: 0x17000132 RID: 306
		// (get) Token: 0x06000401 RID: 1025 RVA: 0x0000D374 File Offset: 0x0000B574
		public static Vector2 HalfScreenSize
		{
			get
			{
				if (!true)
				{
				}
				!0 instance = SingletonMonoBehavior.Instance;
				return 1;
			}
		}

		// Token: 0x17000133 RID: 307
		// (get) Token: 0x06000402 RID: 1026 RVA: 0x0000D38C File Offset: 0x0000B58C
		public static TouchManager.GizmoShowOption ControlsShowGizmos
		{
			get
			{
				/*
An exception occurred when decompiling this method (06000402)

ICSharpCode.Decompiler.DecompilerException: Error decompiling InControl.TouchManager/GizmoShowOption InControl.TouchManager::get_ControlsShowGizmos()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0003:
	stloc:!0(var_0_08, callgetter:!0(SingletonMonoBehavior`1::get_Instance))
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

		// Token: 0x17000134 RID: 308
		// (get) Token: 0x06000403 RID: 1027 RVA: 0x0000D3A4 File Offset: 0x0000B5A4
		// (set) Token: 0x06000404 RID: 1028 RVA: 0x0000D3BC File Offset: 0x0000B5BC
		public static bool ControlsEnabled
		{
			get
			{
				/*
An exception occurred when decompiling this method (06000403)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean InControl.TouchManager::get_ControlsEnabled()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0003:
	stloc:!0(var_0_08, callgetter:!0(SingletonMonoBehavior`1::get_Instance))
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
			set
			{
				if (!true)
				{
				}
				!0 instance = SingletonMonoBehavior.Instance;
			}
		}

		// Token: 0x06000405 RID: 1029 RVA: 0x0000D3D4 File Offset: 0x0000B5D4
		public static implicit operator bool(TouchManager instance)
		{
			if (!true)
			{
			}
			bool flag;
			return flag;
		}

		// Token: 0x04000395 RID: 917
		[Space(10f)]
		public Camera touchCamera;

		// Token: 0x04000396 RID: 918
		public TouchManager.GizmoShowOption controlsShowGizmos = TouchManager.GizmoShowOption.Always;

		// Token: 0x04000397 RID: 919
		[HideInInspector]
		public bool enableControlsOnTouch;

		// Token: 0x04000398 RID: 920
		[SerializeField]
		[HideInInspector]
		private bool _controlsEnabled = true;

		// Token: 0x04000399 RID: 921
		[HideInInspector]
		public int controlsLayer = 5;

		// Token: 0x0400039A RID: 922
		[CompilerGenerated]
		private static Action OnSetup;

		// Token: 0x0400039B RID: 923
		private InputDevice device;

		// Token: 0x0400039C RID: 924
		private Vector3 viewSize;

		// Token: 0x0400039D RID: 925
		private Vector2 screenSize;

		// Token: 0x0400039E RID: 926
		private Vector2 halfScreenSize;

		// Token: 0x0400039F RID: 927
		private float percentToWorld;

		// Token: 0x040003A0 RID: 928
		private float halfPercentToWorld;

		// Token: 0x040003A1 RID: 929
		private float pixelToWorld;

		// Token: 0x040003A2 RID: 930
		private float halfPixelToWorld;

		// Token: 0x040003A3 RID: 931
		private TouchControl[] touchControls;

		// Token: 0x040003A4 RID: 932
		private TouchPool cachedTouches;

		// Token: 0x040003A5 RID: 933
		private List<Touch> activeTouches;

		// Token: 0x040003A6 RID: 934
		private ReadOnlyCollection<Touch> readOnlyActiveTouches;

		// Token: 0x040003A7 RID: 935
		private bool isReady;

		// Token: 0x040003A8 RID: 936
		private readonly Touch[] mouseTouches;

		// Token: 0x02000054 RID: 84
		public enum GizmoShowOption
		{
			// Token: 0x040003AA RID: 938
			Never,
			// Token: 0x040003AB RID: 939
			WhenSelected,
			// Token: 0x040003AC RID: 940
			UnlessPlaying,
			// Token: 0x040003AD RID: 941
			Always
		}

		// Token: 0x02000055 RID: 85
		[CompilerGenerated]
		private sealed class <UpdateScreenSizeAtEndOfFrame>d__28 : IEnumerator<object>, IEnumerator, IDisposable
		{
			// Token: 0x06000406 RID: 1030 RVA: 0x0000D3E8 File Offset: 0x0000B5E8
			[DebuggerHidden]
			public <UpdateScreenSizeAtEndOfFrame>d__28(int <>1__state)
			{
				this.<>1__state = <>1__state;
			}

			// Token: 0x06000407 RID: 1031 RVA: 0x0000D404 File Offset: 0x0000B604
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			// Token: 0x06000408 RID: 1032 RVA: 0x0000D414 File Offset: 0x0000B614
			private bool MoveNext()
			{
				if (this.<>1__state == 0)
				{
					TouchManager touchManager = this.<>4__this;
					this.<>1__state = 1;
					Vector2 currentScreenSize = touchManager.GetCurrentScreenSize();
					long num = 0L;
					this.<>2__current = num;
					this.<>1__state = 2;
				}
				return true;
			}

			// Token: 0x17000135 RID: 309
			// (get) Token: 0x06000409 RID: 1033 RVA: 0x0000D450 File Offset: 0x0000B650
			object IEnumerator<object>.Current
			{
				[DebuggerHidden]
				get
				{
					return this.<>2__current;
				}
			}

			// Token: 0x0600040A RID: 1034 RVA: 0x000025E1 File Offset: 0x000007E1
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}

			// Token: 0x17000136 RID: 310
			// (get) Token: 0x0600040B RID: 1035 RVA: 0x0000D464 File Offset: 0x0000B664
			object IEnumerator.Current
			{
				[DebuggerHidden]
				get
				{
					return this.<>2__current;
				}
			}

			// Token: 0x040003AE RID: 942
			private int <>1__state;

			// Token: 0x040003AF RID: 943
			private object <>2__current;

			// Token: 0x040003B0 RID: 944
			public TouchManager <>4__this;
		}
	}
}
