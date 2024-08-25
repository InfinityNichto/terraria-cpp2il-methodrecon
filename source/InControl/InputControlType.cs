using System;

namespace InControl
{
	// Token: 0x02000023 RID: 35
	public enum InputControlType
	{
		// Token: 0x04000145 RID: 325
		None,
		// Token: 0x04000146 RID: 326
		LeftStickUp,
		// Token: 0x04000147 RID: 327
		LeftStickDown,
		// Token: 0x04000148 RID: 328
		LeftStickLeft,
		// Token: 0x04000149 RID: 329
		LeftStickRight,
		// Token: 0x0400014A RID: 330
		LeftStickButton,
		// Token: 0x0400014B RID: 331
		RightStickUp,
		// Token: 0x0400014C RID: 332
		RightStickDown,
		// Token: 0x0400014D RID: 333
		RightStickLeft,
		// Token: 0x0400014E RID: 334
		RightStickRight,
		// Token: 0x0400014F RID: 335
		RightStickButton,
		// Token: 0x04000150 RID: 336
		DPadUp,
		// Token: 0x04000151 RID: 337
		DPadDown,
		// Token: 0x04000152 RID: 338
		DPadLeft,
		// Token: 0x04000153 RID: 339
		DPadRight,
		// Token: 0x04000154 RID: 340
		LeftTrigger,
		// Token: 0x04000155 RID: 341
		RightTrigger,
		// Token: 0x04000156 RID: 342
		LeftBumper,
		// Token: 0x04000157 RID: 343
		RightBumper,
		// Token: 0x04000158 RID: 344
		Action1,
		// Token: 0x04000159 RID: 345
		Action2,
		// Token: 0x0400015A RID: 346
		Action3,
		// Token: 0x0400015B RID: 347
		Action4,
		// Token: 0x0400015C RID: 348
		Action5,
		// Token: 0x0400015D RID: 349
		Action6,
		// Token: 0x0400015E RID: 350
		Action7,
		// Token: 0x0400015F RID: 351
		Action8,
		// Token: 0x04000160 RID: 352
		Action9,
		// Token: 0x04000161 RID: 353
		Action10,
		// Token: 0x04000162 RID: 354
		Action11,
		// Token: 0x04000163 RID: 355
		Action12,
		// Token: 0x04000164 RID: 356
		Back = 100,
		// Token: 0x04000165 RID: 357
		Start,
		// Token: 0x04000166 RID: 358
		Select,
		// Token: 0x04000167 RID: 359
		System,
		// Token: 0x04000168 RID: 360
		Options,
		// Token: 0x04000169 RID: 361
		Pause,
		// Token: 0x0400016A RID: 362
		Menu,
		// Token: 0x0400016B RID: 363
		Share,
		// Token: 0x0400016C RID: 364
		Home,
		// Token: 0x0400016D RID: 365
		View,
		// Token: 0x0400016E RID: 366
		Power,
		// Token: 0x0400016F RID: 367
		Capture,
		// Token: 0x04000170 RID: 368
		Assistant,
		// Token: 0x04000171 RID: 369
		Plus,
		// Token: 0x04000172 RID: 370
		Minus,
		// Token: 0x04000173 RID: 371
		PedalLeft = 150,
		// Token: 0x04000174 RID: 372
		PedalRight,
		// Token: 0x04000175 RID: 373
		PedalMiddle,
		// Token: 0x04000176 RID: 374
		GearUp,
		// Token: 0x04000177 RID: 375
		GearDown,
		// Token: 0x04000178 RID: 376
		Pitch = 200,
		// Token: 0x04000179 RID: 377
		Roll,
		// Token: 0x0400017A RID: 378
		Yaw,
		// Token: 0x0400017B RID: 379
		ThrottleUp,
		// Token: 0x0400017C RID: 380
		ThrottleDown,
		// Token: 0x0400017D RID: 381
		ThrottleLeft,
		// Token: 0x0400017E RID: 382
		ThrottleRight,
		// Token: 0x0400017F RID: 383
		POVUp,
		// Token: 0x04000180 RID: 384
		POVDown,
		// Token: 0x04000181 RID: 385
		POVLeft,
		// Token: 0x04000182 RID: 386
		POVRight,
		// Token: 0x04000183 RID: 387
		TiltX = 250,
		// Token: 0x04000184 RID: 388
		TiltY,
		// Token: 0x04000185 RID: 389
		TiltZ,
		// Token: 0x04000186 RID: 390
		ScrollWheel,
		// Token: 0x04000187 RID: 391
		[Obsolete("Use InputControlType.TouchPadButton instead.", true)]
		TouchPadTap,
		// Token: 0x04000188 RID: 392
		TouchPadButton,
		// Token: 0x04000189 RID: 393
		TouchPadXAxis,
		// Token: 0x0400018A RID: 394
		TouchPadYAxis,
		// Token: 0x0400018B RID: 395
		LeftSL,
		// Token: 0x0400018C RID: 396
		LeftSR,
		// Token: 0x0400018D RID: 397
		RightSL,
		// Token: 0x0400018E RID: 398
		RightSR,
		// Token: 0x0400018F RID: 399
		Command = 300,
		// Token: 0x04000190 RID: 400
		LeftStickX,
		// Token: 0x04000191 RID: 401
		LeftStickY,
		// Token: 0x04000192 RID: 402
		RightStickX,
		// Token: 0x04000193 RID: 403
		RightStickY,
		// Token: 0x04000194 RID: 404
		DPadX,
		// Token: 0x04000195 RID: 405
		DPadY,
		// Token: 0x04000196 RID: 406
		Analog0 = 400,
		// Token: 0x04000197 RID: 407
		Analog1,
		// Token: 0x04000198 RID: 408
		Analog2,
		// Token: 0x04000199 RID: 409
		Analog3,
		// Token: 0x0400019A RID: 410
		Analog4,
		// Token: 0x0400019B RID: 411
		Analog5,
		// Token: 0x0400019C RID: 412
		Analog6,
		// Token: 0x0400019D RID: 413
		Analog7,
		// Token: 0x0400019E RID: 414
		Analog8,
		// Token: 0x0400019F RID: 415
		Analog9,
		// Token: 0x040001A0 RID: 416
		Analog10,
		// Token: 0x040001A1 RID: 417
		Analog11,
		// Token: 0x040001A2 RID: 418
		Analog12,
		// Token: 0x040001A3 RID: 419
		Analog13,
		// Token: 0x040001A4 RID: 420
		Analog14,
		// Token: 0x040001A5 RID: 421
		Analog15,
		// Token: 0x040001A6 RID: 422
		Analog16,
		// Token: 0x040001A7 RID: 423
		Analog17,
		// Token: 0x040001A8 RID: 424
		Analog18,
		// Token: 0x040001A9 RID: 425
		Analog19,
		// Token: 0x040001AA RID: 426
		Button0 = 500,
		// Token: 0x040001AB RID: 427
		Button1,
		// Token: 0x040001AC RID: 428
		Button2,
		// Token: 0x040001AD RID: 429
		Button3,
		// Token: 0x040001AE RID: 430
		Button4,
		// Token: 0x040001AF RID: 431
		Button5,
		// Token: 0x040001B0 RID: 432
		Button6,
		// Token: 0x040001B1 RID: 433
		Button7,
		// Token: 0x040001B2 RID: 434
		Button8,
		// Token: 0x040001B3 RID: 435
		Button9,
		// Token: 0x040001B4 RID: 436
		Button10,
		// Token: 0x040001B5 RID: 437
		Button11,
		// Token: 0x040001B6 RID: 438
		Button12,
		// Token: 0x040001B7 RID: 439
		Button13,
		// Token: 0x040001B8 RID: 440
		Button14,
		// Token: 0x040001B9 RID: 441
		Button15,
		// Token: 0x040001BA RID: 442
		Button16,
		// Token: 0x040001BB RID: 443
		Button17,
		// Token: 0x040001BC RID: 444
		Button18,
		// Token: 0x040001BD RID: 445
		Button19,
		// Token: 0x040001BE RID: 446
		Count
	}
}
