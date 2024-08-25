﻿using System;
using UnityEngine;

namespace InControl
{
	// Token: 0x02000041 RID: 65
	public class NativeInputDeviceProfileList : ScriptableObject
	{
		// Token: 0x06000357 RID: 855 RVA: 0x00009EF0 File Offset: 0x000080F0
		public NativeInputDeviceProfileList()
		{
		}

		// Token: 0x06000358 RID: 856 RVA: 0x00009F04 File Offset: 0x00008104
		// Note: this type is marked as 'beforefieldinit'.
		static NativeInputDeviceProfileList()
		{
			if (("InControl.NativeDeviceProfiles.AfterglowXbox360WindowsNativeProfile" == null || "InControl.NativeDeviceProfiles.AfterglowXbox360WindowsNativeProfile" != null) && ("InControl.NativeDeviceProfiles.AirFloControllerMacNativeProfile" == null || "InControl.NativeDeviceProfiles.AirFloControllerMacNativeProfile" != null) && ("InControl.NativeDeviceProfiles.AirFloPS3WindowsNativeProfile" == null || "InControl.NativeDeviceProfiles.AirFloPS3WindowsNativeProfile" != null) && ("InControl.NativeDeviceProfiles.AppleMFiExtendedGamepadNativeProfile" == null || "InControl.NativeDeviceProfiles.AppleMFiExtendedGamepadNativeProfile" != null) && ("InControl.NativeDeviceProfiles.AppleMFiMicroGamepadNativeProfile" == null || "InControl.NativeDeviceProfiles.AppleMFiMicroGamepadNativeProfile" != null) && ("InControl.NativeDeviceProfiles.ArdwiinoControllerMacNativeProfile" == null || "InControl.NativeDeviceProfiles.ArdwiinoControllerMacNativeProfile" != null) && ("InControl.NativeDeviceProfiles.AtPlayControllerMacNativeProfile" == null || "InControl.NativeDeviceProfiles.AtPlayControllerMacNativeProfile" != null) && ("InControl.NativeDeviceProfiles.BatarangControllerMacNativeProfile" == null || "InControl.NativeDeviceProfiles.BatarangControllerMacNativeProfile" != null) && ("InControl.NativeDeviceProfiles.BETAOPControllerMacNativeProfile" == null || "InControl.NativeDeviceProfiles.BETAOPControllerMacNativeProfile" != null) && ("InControl.NativeDeviceProfiles.BigBenControllerMacNativeProfile" == null || "InControl.NativeDeviceProfiles.BigBenControllerMacNativeProfile" != null) && ("InControl.NativeDeviceProfiles.BrookNeoGeoConverterMacNativeProfile" == null || "InControl.NativeDeviceProfiles.BrookNeoGeoConverterMacNativeProfile" != null) && ("InControl.NativeDeviceProfiles.BuffaloClassicMacNativeProfile" == null || "InControl.NativeDeviceProfiles.BuffaloClassicMacNativeProfile" != null) && ("InControl.NativeDeviceProfiles.BuffaloClassicWindowsNativeProfile" == null || "InControl.NativeDeviceProfiles.BuffaloClassicWindowsNativeProfile" != null) && ("InControl.NativeDeviceProfiles.DragonRiseArcadeStickMacNativeProfile" == null || "InControl.NativeDeviceProfiles.DragonRiseArcadeStickMacNativeProfile" != null) && ("InControl.NativeDeviceProfiles.DualShock4MFiNativeProfile" == null || "InControl.NativeDeviceProfiles.DualShock4MFiNativeProfile" != null) && ("InControl.NativeDeviceProfiles.EASportsControllerMacNativeProfile" == null || "InControl.NativeDeviceProfiles.EASportsControllerMacNativeProfile" != null) && ("InControl.NativeDeviceProfiles.EightBitdoNES30ProBTMacNativeProfile" == null || "InControl.NativeDeviceProfiles.EightBitdoNES30ProBTMacNativeProfile" != null) && ("InControl.NativeDeviceProfiles.EightBitdoNES30ProUSBMacNativeProfile" == null || "InControl.NativeDeviceProfiles.EightBitdoNES30ProUSBMacNativeProfile" != null) && ("InControl.NativeDeviceProfiles.EightBitdoNES30ProWindowsNativeProfile" == null || "InControl.NativeDeviceProfiles.EightBitdoNES30ProWindowsNativeProfile" != null) && ("InControl.NativeDeviceProfiles.EightBitdoSF30ProWindowsNativeProfile" == null || "InControl.NativeDeviceProfiles.EightBitdoSF30ProWindowsNativeProfile" != null) && ("InControl.NativeDeviceProfiles.EightBitdoSFC30MacNativeProfile" == null || "InControl.NativeDeviceProfiles.EightBitdoSFC30MacNativeProfile" != null) && ("InControl.NativeDeviceProfiles.EightBitdoSFC30WindowsNativeProfile" == null || "InControl.NativeDeviceProfiles.EightBitdoSFC30WindowsNativeProfile" != null) && ("InControl.NativeDeviceProfiles.EightBitdoSNES30MacNativeProfile" == null || "InControl.NativeDeviceProfiles.EightBitdoSNES30MacNativeProfile" != null) && ("InControl.NativeDeviceProfiles.EightBitdoSNES30WindowsNativeProfile" == null || "InControl.NativeDeviceProfiles.EightBitdoSNES30WindowsNativeProfile" != null) && ("InControl.NativeDeviceProfiles.ElecomControllerMacNativeProfile" == null || "InControl.NativeDeviceProfiles.ElecomControllerMacNativeProfile" != null) && ("InControl.NativeDeviceProfiles.FusionXboxOneControllerMacNativeProfile" == null || "InControl.NativeDeviceProfiles.FusionXboxOneControllerMacNativeProfile" != null) && ("InControl.NativeDeviceProfiles.GameCubeMayflashWindowsNativeProfile" == null || "InControl.NativeDeviceProfiles.GameCubeMayflashWindowsNativeProfile" != null) && ("InControl.NativeDeviceProfiles.GameCubeWindowsNativeProfile" == null || "InControl.NativeDeviceProfiles.GameCubeWindowsNativeProfile" != null) && ("InControl.NativeDeviceProfiles.GameStopControllerMacNativeProfile" == null || "InControl.NativeDeviceProfiles.GameStopControllerMacNativeProfile" != null) && ("InControl.NativeDeviceProfiles.GoogleStadiaMacNativeProfile" == null || "InControl.NativeDeviceProfiles.GoogleStadiaMacNativeProfile" != null) && ("InControl.NativeDeviceProfiles.GoogleStadiaWindowsNativeProfile" == null || "InControl.NativeDeviceProfiles.GoogleStadiaWindowsNativeProfile" != null) && ("InControl.NativeDeviceProfiles.GuitarHeroControllerMacNativeProfile" == null || "InControl.NativeDeviceProfiles.GuitarHeroControllerMacNativeProfile" != null) && ("InControl.NativeDeviceProfiles.HarmonixDrumKitMacNativeProfile" == null || "InControl.NativeDeviceProfiles.HarmonixDrumKitMacNativeProfile" != null) && ("InControl.NativeDeviceProfiles.HarmonixGuitarMacNativeProfile" == null || "InControl.NativeDeviceProfiles.HarmonixGuitarMacNativeProfile" != null) && ("InControl.NativeDeviceProfiles.HarmonixKeyboardMacNativeProfile" == null || "InControl.NativeDeviceProfiles.HarmonixKeyboardMacNativeProfile" != null) && ("InControl.NativeDeviceProfiles.HoneyBeeControllerMacNativeProfile" == null || "InControl.NativeDeviceProfiles.HoneyBeeControllerMacNativeProfile" != null) && ("InControl.NativeDeviceProfiles.HoriBlueSoloControllerMacNativeProfile" == null || "InControl.NativeDeviceProfiles.HoriBlueSoloControllerMacNativeProfile" != null) && ("InControl.NativeDeviceProfiles.HoriControllerMacNativeProfile" == null || "InControl.NativeDeviceProfiles.HoriControllerMacNativeProfile" != null) && ("InControl.NativeDeviceProfiles.HoriDOA4ArcadeStickMacNativeProfile" == null || "InControl.NativeDeviceProfiles.HoriDOA4ArcadeStickMacNativeProfile" != null) && ("InControl.NativeDeviceProfiles.HoriEdgeFightingStickMacNativeProfile" == null || "InControl.NativeDeviceProfiles.HoriEdgeFightingStickMacNativeProfile" != null) && ("InControl.NativeDeviceProfiles.HoriEX2ControllerMacNativeProfile" == null || "InControl.NativeDeviceProfiles.HoriEX2ControllerMacNativeProfile" != null) && ("InControl.NativeDeviceProfiles.HORIFightingCommanderControllerMacNativeProfile" == null || "InControl.NativeDeviceProfiles.HORIFightingCommanderControllerMacNativeProfile" != null) && ("InControl.NativeDeviceProfiles.HoriFightingCommanderMacNativeProfile" == null || "InControl.NativeDeviceProfiles.HoriFightingCommanderMacNativeProfile" != null) && ("InControl.NativeDeviceProfiles.HoriFightingEdgeArcadeStickMacNativeProfile" == null || "InControl.NativeDeviceProfiles.HoriFightingEdgeArcadeStickMacNativeProfile" != null) && ("InControl.NativeDeviceProfiles.HoriFightingStickEX2MacNativeProfile" == null || "InControl.NativeDeviceProfiles.HoriFightingStickEX2MacNativeProfile" != null) && ("InControl.NativeDeviceProfiles.HoriFightingStickMiniMacNativeProfile" == null || "InControl.NativeDeviceProfiles.HoriFightingStickMiniMacNativeProfile" != null) && ("InControl.NativeDeviceProfiles.HoriFightingStickVXMacNativeProfile" == null || "InControl.NativeDeviceProfiles.HoriFightingStickVXMacNativeProfile" != null) && ("InControl.NativeDeviceProfiles.HoriFightStickMacNativeProfile" == null || "InControl.NativeDeviceProfiles.HoriFightStickMacNativeProfile" != null) && ("InControl.NativeDeviceProfiles.HoriPadEXTurboControllerMacNativeProfile" == null || "InControl.NativeDeviceProfiles.HoriPadEXTurboControllerMacNativeProfile" != null) && ("InControl.NativeDeviceProfiles.HoriPadUltimateMacNativeProfile" == null || "InControl.NativeDeviceProfiles.HoriPadUltimateMacNativeProfile" != null) && ("InControl.NativeDeviceProfiles.HoriRAPNFightingStickMacNativeProfile" == null || "InControl.NativeDeviceProfiles.HoriRAPNFightingStickMacNativeProfile" != null) && ("InControl.NativeDeviceProfiles.HoriRealArcadeProEXMacNativeProfile" == null || "InControl.NativeDeviceProfiles.HoriRealArcadeProEXMacNativeProfile" != null) && ("InControl.NativeDeviceProfiles.HoriRealArcadeProEXPremiumVLXMacNativeProfile" == null || "InControl.NativeDeviceProfiles.HoriRealArcadeProEXPremiumVLXMacNativeProfile" != null) && ("InControl.NativeDeviceProfiles.HoriRealArcadeProEXSEMacNativeProfile" == null || "InControl.NativeDeviceProfiles.HoriRealArcadeProEXSEMacNativeProfile" != null) && ("InControl.NativeDeviceProfiles.HoriRealArcadeProHayabusaMacNativeProfile" == null || "InControl.NativeDeviceProfiles.HoriRealArcadeProHayabusaMacNativeProfile" != null) && ("InControl.NativeDeviceProfiles.HoriRealArcadeProIVMacNativeProfile" == null || "InControl.NativeDeviceProfiles.HoriRealArcadeProIVMacNativeProfile" != null) && ("InControl.NativeDeviceProfiles.HoriRealArcadeProVHayabusaMacNativeProfile" == null || "InControl.NativeDeviceProfiles.HoriRealArcadeProVHayabusaMacNativeProfile" != null) && ("InControl.NativeDeviceProfiles.HoriRealArcadeProVKaiFightingStickMacNativeProfile" == null || "InControl.NativeDeviceProfiles.HoriRealArcadeProVKaiFightingStickMacNativeProfile" != null) && ("InControl.NativeDeviceProfiles.HoriRealArcadeProVXMacNativeProfile" == null || "InControl.NativeDeviceProfiles.HoriRealArcadeProVXMacNativeProfile" != null) && ("InControl.NativeDeviceProfiles.HoriRealArcadeProVXSAMacNativeProfile" == null || "InControl.NativeDeviceProfiles.HoriRealArcadeProVXSAMacNativeProfile" != null) && ("InControl.NativeDeviceProfiles.HoriXbox360GemPadExMacNativeProfile" == null || "InControl.NativeDeviceProfiles.HoriXbox360GemPadExMacNativeProfile" != null) && ("InControl.NativeDeviceProfiles.HyperkinX91MacNativeProfile" == null || "InControl.NativeDeviceProfiles.HyperkinX91MacNativeProfile" != null) && ("InControl.NativeDeviceProfiles.InjusticeFightStickMacNativeProfile" == null || "InControl.NativeDeviceProfiles.InjusticeFightStickMacNativeProfile" != null) && ("InControl.NativeDeviceProfiles.IonDrumRockerMacNativeProfile" == null || "InControl.NativeDeviceProfiles.IonDrumRockerMacNativeProfile" != null) && ("InControl.NativeDeviceProfiles.JoytekXbox360ControllerMacNativeProfile" == null || "InControl.NativeDeviceProfiles.JoytekXbox360ControllerMacNativeProfile" != null) && ("InControl.NativeDeviceProfiles.KiwitataNESWindowsNativeProfile" == null || "InControl.NativeDeviceProfiles.KiwitataNESWindowsNativeProfile" != null) && ("InControl.NativeDeviceProfiles.KonamiDancePadMacNativeProfile" == null || "InControl.NativeDeviceProfiles.KonamiDancePadMacNativeProfile" != null) && ("InControl.NativeDeviceProfiles.LogitechChillStreamControllerMacNativeProfile" == null || "InControl.NativeDeviceProfiles.LogitechChillStreamControllerMacNativeProfile" != null) && ("InControl.NativeDeviceProfiles.LogitechControllerMacNativeProfile" == null || "InControl.NativeDeviceProfiles.LogitechControllerMacNativeProfile" != null) && ("InControl.NativeDeviceProfiles.LogitechDriveFXRacingWheelMacNativeProfile" == null || "InControl.NativeDeviceProfiles.LogitechDriveFXRacingWheelMacNativeProfile" != null) && ("InControl.NativeDeviceProfiles.LogitechF310ControllerMacNativeProfile" == null || "InControl.NativeDeviceProfiles.LogitechF310ControllerMacNativeProfile" != null) && ("InControl.NativeDeviceProfiles.LogitechF310ModeDMacNativeProfile" == null || "InControl.NativeDeviceProfiles.LogitechF310ModeDMacNativeProfile" != null) && ("InControl.NativeDeviceProfiles.LogitechF310ModeDWindowsNativeProfile" == null || "InControl.NativeDeviceProfiles.LogitechF310ModeDWindowsNativeProfile" != null) && ("InControl.NativeDeviceProfiles.LogitechF310ModeXWindowsNativeProfile" == null || "InControl.NativeDeviceProfiles.LogitechF310ModeXWindowsNativeProfile" != null) && ("InControl.NativeDeviceProfiles.LogitechF510ControllerMacNativeProfile" == null || "InControl.NativeDeviceProfiles.LogitechF510ControllerMacNativeProfile" != null) && ("InControl.NativeDeviceProfiles.LogitechF510ModeDMacNativeProfile" == null || "InControl.NativeDeviceProfiles.LogitechF510ModeDMacNativeProfile" != null) && ("InControl.NativeDeviceProfiles.LogitechF510ModeDWindowsNativeProfile" == null || "InControl.NativeDeviceProfiles.LogitechF510ModeDWindowsNativeProfile" != null) && ("InControl.NativeDeviceProfiles.LogitechF510ModeXWindowsNativeProfile" == null || "InControl.NativeDeviceProfiles.LogitechF510ModeXWindowsNativeProfile" != null) && ("InControl.NativeDeviceProfiles.LogitechF710ControllerMacNativeProfile" == null || "InControl.NativeDeviceProfiles.LogitechF710ControllerMacNativeProfile" != null) && ("InControl.NativeDeviceProfiles.LogitechF710ModeDMacNativeProfile" == null || "InControl.NativeDeviceProfiles.LogitechF710ModeDMacNativeProfile" != null) && ("InControl.NativeDeviceProfiles.LogitechF710ModeDWindowsNativeProfile" == null || "InControl.NativeDeviceProfiles.LogitechF710ModeDWindowsNativeProfile" != null) && ("InControl.NativeDeviceProfiles.LogitechF710ModeXWindowsNativeProfile" == null || "InControl.NativeDeviceProfiles.LogitechF710ModeXWindowsNativeProfile" != null) && ("InControl.NativeDeviceProfiles.LogitechG920RacingWheelMacNativeProfile" == null || "InControl.NativeDeviceProfiles.LogitechG920RacingWheelMacNativeProfile" != null) && ("InControl.NativeDeviceProfiles.LogitechThunderpadMacNativeProfile" == null || "InControl.NativeDeviceProfiles.LogitechThunderpadMacNativeProfile" != null) && ("InControl.NativeDeviceProfiles.MadCatzArcadeStickMacNativeProfile" == null || "InControl.NativeDeviceProfiles.MadCatzArcadeStickMacNativeProfile" != null) && ("InControl.NativeDeviceProfiles.MadCatzBeatPadMacNativeProfile" == null || "InControl.NativeDeviceProfiles.MadCatzBeatPadMacNativeProfile" != null) && ("InControl.NativeDeviceProfiles.MadCatzBrawlStickMacNativeProfile" == null || "InControl.NativeDeviceProfiles.MadCatzBrawlStickMacNativeProfile" != null) && ("InControl.NativeDeviceProfiles.MadCatzCODControllerMacNativeProfile" == null || "InControl.NativeDeviceProfiles.MadCatzCODControllerMacNativeProfile" != null) && ("InControl.NativeDeviceProfiles.MadCatzControllerMacNativeProfile" == null || "InControl.NativeDeviceProfiles.MadCatzControllerMacNativeProfile" != null) && ("InControl.NativeDeviceProfiles.MadCatzFightPadControllerMacNativeProfile" == null || "InControl.NativeDeviceProfiles.MadCatzFightPadControllerMacNativeProfile" != null) && ("InControl.NativeDeviceProfiles.MadCatzFightPadMacNativeProfile" == null || "InControl.NativeDeviceProfiles.MadCatzFightPadMacNativeProfile" != null) && ("InControl.NativeDeviceProfiles.MadCatzFightStickTE2MacNativeProfile" == null || "InControl.NativeDeviceProfiles.MadCatzFightStickTE2MacNativeProfile" != null) && ("InControl.NativeDeviceProfiles.MadCatzFightStickTESPlusMacNativeProfile" == null || "InControl.NativeDeviceProfiles.MadCatzFightStickTESPlusMacNativeProfile" != null) && ("InControl.NativeDeviceProfiles.MadCatzFPSProMacNativeProfile" == null || "InControl.NativeDeviceProfiles.MadCatzFPSProMacNativeProfile" != null) && ("InControl.NativeDeviceProfiles.MadCatzGhostReconFightingStickMacNativeProfile" == null || "InControl.NativeDeviceProfiles.MadCatzGhostReconFightingStickMacNativeProfile" != null) && ("InControl.NativeDeviceProfiles.MadCatzInnoControllerMacNativeProfile" == null || "InControl.NativeDeviceProfiles.MadCatzInnoControllerMacNativeProfile" != null) && ("InControl.NativeDeviceProfiles.MadCatzMC2ControllerMacNativeProfile" == null || "InControl.NativeDeviceProfiles.MadCatzMC2ControllerMacNativeProfile" != null) && ("InControl.NativeDeviceProfiles.MadCatzMC2RacingWheelMacNativeProfile" == null || "InControl.NativeDeviceProfiles.MadCatzMC2RacingWheelMacNativeProfile" != null) && ("InControl.NativeDeviceProfiles.MadCatzMicroConControllerMacNativeProfile" == null || "InControl.NativeDeviceProfiles.MadCatzMicroConControllerMacNativeProfile" != null) && ("InControl.NativeDeviceProfiles.MadCatzMicroControllerMacNativeProfile" == null || "InControl.NativeDeviceProfiles.MadCatzMicroControllerMacNativeProfile" != null) && ("InControl.NativeDeviceProfiles.MadCatzMLGFightStickTEMacNativeProfile" == null || "InControl.NativeDeviceProfiles.MadCatzMLGFightStickTEMacNativeProfile" != null) && ("InControl.NativeDeviceProfiles.MadCatzNeoFightStickMacNativeProfile" == null || "InControl.NativeDeviceProfiles.MadCatzNeoFightStickMacNativeProfile" != null) && ("InControl.NativeDeviceProfiles.MadCatzPortableDrumMacNativeProfile" == null || "InControl.NativeDeviceProfiles.MadCatzPortableDrumMacNativeProfile" != null) && ("InControl.NativeDeviceProfiles.MadCatzProControllerMacNativeProfile" == null || "InControl.NativeDeviceProfiles.MadCatzProControllerMacNativeProfile" != null) && ("InControl.NativeDeviceProfiles.MadCatzProControllerMacNativeProfile" == null || "InControl.NativeDeviceProfiles.MadCatzProControllerMacNativeProfile" != null) && ("InControl.NativeDeviceProfiles.MadCatzSF4FightStickRound2TEMacNativeProfile" == null || "InControl.NativeDeviceProfiles.MadCatzSF4FightStickRound2TEMacNativeProfile" != null) && ("InControl.NativeDeviceProfiles.MadCatzSF4FightStickRound2TEMacNativeProfile" == null || "InControl.NativeDeviceProfiles.MadCatzSF4FightStickRound2TEMacNativeProfile" != null) && ("InControl.NativeDeviceProfiles.MadCatzSF4FightStickTEMacNativeProfile" == null || "InControl.NativeDeviceProfiles.MadCatzSF4FightStickTEMacNativeProfile" != null) && ("InControl.NativeDeviceProfiles.MadCatzSoulCaliberFightStickMacNativeProfile" == null || "InControl.NativeDeviceProfiles.MadCatzSoulCaliberFightStickMacNativeProfile" != null) && ("InControl.NativeDeviceProfiles.MadCatzSSF4ChunLiFightStickTEMacNativeProfile" == null || "InControl.NativeDeviceProfiles.MadCatzSSF4ChunLiFightStickTEMacNativeProfile" != null) && ("InControl.NativeDeviceProfiles.MadCatzSSF4FightStickTEMacNativeProfile" == null || "InControl.NativeDeviceProfiles.MadCatzSSF4FightStickTEMacNativeProfile" != null) && ("InControl.NativeDeviceProfiles.MatCatzControllerMacNativeProfile" == null || "InControl.NativeDeviceProfiles.MatCatzControllerMacNativeProfile" != null) && ("InControl.NativeDeviceProfiles.MayflashMagicNSMacNativeProfile" == null || "InControl.NativeDeviceProfiles.MayflashMagicNSMacNativeProfile" != null) && ("InControl.NativeDeviceProfiles.McbazelAdapterMacNativeProfile" == null || "InControl.NativeDeviceProfiles.McbazelAdapterMacNativeProfile" != null) && ("InControl.NativeDeviceProfiles.MicrosoftAdaptiveControllerMacNativeProfile" == null || "InControl.NativeDeviceProfiles.MicrosoftAdaptiveControllerMacNativeProfile" != null) && ("InControl.NativeDeviceProfiles.MicrosoftXbox360ControllerMacNativeProfile" == null || "InControl.NativeDeviceProfiles.MicrosoftXbox360ControllerMacNativeProfile" != null) && ("InControl.NativeDeviceProfiles.MicrosoftXboxControllerMacNativeProfile" == null || "InControl.NativeDeviceProfiles.MicrosoftXboxControllerMacNativeProfile" != null) && ("InControl.NativeDeviceProfiles.MicrosoftXboxOneControllerMacNativeProfile" == null || "InControl.NativeDeviceProfiles.MicrosoftXboxOneControllerMacNativeProfile" != null) && ("InControl.NativeDeviceProfiles.MicrosoftXboxOneEliteControllerMacNativeProfile" == null || "InControl.NativeDeviceProfiles.MicrosoftXboxOneEliteControllerMacNativeProfile" != null) && ("InControl.NativeDeviceProfiles.MKKlassikFightStickMacNativeProfile" == null || "InControl.NativeDeviceProfiles.MKKlassikFightStickMacNativeProfile" != null) && ("InControl.NativeDeviceProfiles.MLGControllerMacNativeProfile" == null || "InControl.NativeDeviceProfiles.MLGControllerMacNativeProfile" != null) && ("InControl.NativeDeviceProfiles.MVCTEStickMacNativeProfile" == null || "InControl.NativeDeviceProfiles.MVCTEStickMacNativeProfile" != null) && ("InControl.NativeDeviceProfiles.NaconGC100XFControllerMacNativeProfile" == null || "InControl.NativeDeviceProfiles.NaconGC100XFControllerMacNativeProfile" != null) && ("InControl.NativeDeviceProfiles.NintendoSwitchProMacNativeProfile" == null || "InControl.NativeDeviceProfiles.NintendoSwitchProMacNativeProfile" != null) && ("InControl.NativeDeviceProfiles.NintendoSwitchProWindowsNativeProfile" == null || "InControl.NativeDeviceProfiles.NintendoSwitchProWindowsNativeProfile" != null) && ("InControl.NativeDeviceProfiles.NVidiaShieldWindowsNativeProfile" == null || "InControl.NativeDeviceProfiles.NVidiaShieldWindowsNativeProfile" != null) && ("InControl.NativeDeviceProfiles.OUYAWindowsNativeProfile" == null || "InControl.NativeDeviceProfiles.OUYAWindowsNativeProfile" != null) && ("InControl.NativeDeviceProfiles.PCTWINSHOCKWindowsNativeProfile" == null || "InControl.NativeDeviceProfiles.PCTWINSHOCKWindowsNativeProfile" != null) && ("InControl.NativeDeviceProfiles.PDPAfterglowControllerMacNativeProfile" == null || "InControl.NativeDeviceProfiles.PDPAfterglowControllerMacNativeProfile" != null) && ("InControl.NativeDeviceProfiles.PDPAfterglowPrismaticControllerMacNativeProfile" == null || "InControl.NativeDeviceProfiles.PDPAfterglowPrismaticControllerMacNativeProfile" != null) && ("InControl.NativeDeviceProfiles.PDPBattlefieldXBoxOneControllerMacNativeProfile" == null || "InControl.NativeDeviceProfiles.PDPBattlefieldXBoxOneControllerMacNativeProfile" != null) && ("InControl.NativeDeviceProfiles.PDPMarvelControllerMacNativeProfile" == null || "InControl.NativeDeviceProfiles.PDPMarvelControllerMacNativeProfile" != null) && ("InControl.NativeDeviceProfiles.PDPMetallicsLEControllerMacNativeProfile" == null || "InControl.NativeDeviceProfiles.PDPMetallicsLEControllerMacNativeProfile" != null) && ("InControl.NativeDeviceProfiles.PDPTitanfall2XboxOneControllerMacNativeProfile" == null || "InControl.NativeDeviceProfiles.PDPTitanfall2XboxOneControllerMacNativeProfile" != null) && ("InControl.NativeDeviceProfiles.PDPTronControllerMacNativeProfile" == null || "InControl.NativeDeviceProfiles.PDPTronControllerMacNativeProfile" != null) && ("InControl.NativeDeviceProfiles.PDPVersusControllerMacNativeProfile" == null || "InControl.NativeDeviceProfiles.PDPVersusControllerMacNativeProfile" != null) && "InControl.NativeDeviceProfiles.PDPXbox360ControllerMacNativeProfile" != null && ("InControl.NativeDeviceProfiles.PDPXboxOneArcadeStickMacNativeProfile" == null || "InControl.NativeDeviceProfiles.PDPXboxOneArcadeStickMacNativeProfile" != null) && ("InControl.NativeDeviceProfiles.PDPXboxOneControllerMacNativeProfile" == null || "InControl.NativeDeviceProfiles.PDPXboxOneControllerMacNativeProfile" != null) && ("InControl.NativeDeviceProfiles.PlayStation3MacNativeProfile" == null || "InControl.NativeDeviceProfiles.PlayStation3MacNativeProfile" != null) && ("InControl.NativeDeviceProfiles.PlayStation4MacNativeProfile" == null || "InControl.NativeDeviceProfiles.PlayStation4MacNativeProfile" != null) && ("InControl.NativeDeviceProfiles.PlayStation4WindowsNativeProfile" == null || "InControl.NativeDeviceProfiles.PlayStation4WindowsNativeProfile" != null) && ("InControl.NativeDeviceProfiles.PowerAAirflowControllerMacNativeProfile" == null || "InControl.NativeDeviceProfiles.PowerAAirflowControllerMacNativeProfile" != null) && ("InControl.NativeDeviceProfiles.POWERAFUS1ONTournamentControllerMacNativeProfile" == null || "InControl.NativeDeviceProfiles.POWERAFUS1ONTournamentControllerMacNativeProfile" != null) && ("InControl.NativeDeviceProfiles.PowerAMiniControllerMacNativeProfile" == null || "InControl.NativeDeviceProfiles.PowerAMiniControllerMacNativeProfile" != null) && ("InControl.NativeDeviceProfiles.PowerAMiniProExControllerMacNativeProfile" == null || "InControl.NativeDeviceProfiles.PowerAMiniProExControllerMacNativeProfile" != null) && ("InControl.NativeDeviceProfiles.PowerAMiniXboxOneControllerMacNativeProfile" == null || "InControl.NativeDeviceProfiles.PowerAMiniXboxOneControllerMacNativeProfile" != null) && ("InControl.NativeDeviceProfiles.PowerANintendoSwitchMacNativeProfile" == null || "InControl.NativeDeviceProfiles.PowerANintendoSwitchMacNativeProfile" != null) && ("InControl.NativeDeviceProfiles.PowerASpectraIlluminatedControllerMacNativeProfile" == null || "InControl.NativeDeviceProfiles.PowerASpectraIlluminatedControllerMacNativeProfile" != null) && ("InControl.NativeDeviceProfiles.ProEXXbox360ControllerMacNativeProfile" == null || "InControl.NativeDeviceProfiles.ProEXXbox360ControllerMacNativeProfile" != null) && ("InControl.NativeDeviceProfiles.ProEXXboxOneControllerMacNativeProfile" == null || "InControl.NativeDeviceProfiles.ProEXXboxOneControllerMacNativeProfile" != null) && ("InControl.NativeDeviceProfiles.QanbaFightStickPlusMacNativeProfile" == null || "InControl.NativeDeviceProfiles.QanbaFightStickPlusMacNativeProfile" != null) && ("InControl.NativeDeviceProfiles.RazerAtroxArcadeStickMacNativeProfile" == null || "InControl.NativeDeviceProfiles.RazerAtroxArcadeStickMacNativeProfile" != null) && ("InControl.NativeDeviceProfiles.RazerOnzaControllerMacNativeProfile" == null || "InControl.NativeDeviceProfiles.RazerOnzaControllerMacNativeProfile" != null) && ("InControl.NativeDeviceProfiles.RazerOnzaTEControllerMacNativeProfile" == null || "InControl.NativeDeviceProfiles.RazerOnzaTEControllerMacNativeProfile" != null) && ("InControl.NativeDeviceProfiles.RazerSabertoothEliteControllerMacNativeProfile" == null || "InControl.NativeDeviceProfiles.RazerSabertoothEliteControllerMacNativeProfile" != null) && ("InControl.NativeDeviceProfiles.RazerServalWindowsNativeProfile" == null || "InControl.NativeDeviceProfiles.RazerServalWindowsNativeProfile" != null) && ("InControl.NativeDeviceProfiles.RazerStrikeControllerMacNativeProfile" == null || "InControl.NativeDeviceProfiles.RazerStrikeControllerMacNativeProfile" != null) && ("InControl.NativeDeviceProfiles.RazerWildcatControllerMacNativeProfile" == null || "InControl.NativeDeviceProfiles.RazerWildcatControllerMacNativeProfile" != null) && ("InControl.NativeDeviceProfiles.RazerWolverineUltimateControllerMacNativeProfile" == null || "InControl.NativeDeviceProfiles.RazerWolverineUltimateControllerMacNativeProfile" != null) && ("InControl.NativeDeviceProfiles.RedOctaneControllerMacNativeProfile" == null || "InControl.NativeDeviceProfiles.RedOctaneControllerMacNativeProfile" != null) && ("InControl.NativeDeviceProfiles.RedOctaneGuitarMacNativeProfile" == null || "InControl.NativeDeviceProfiles.RedOctaneGuitarMacNativeProfile" != null) && ("InControl.NativeDeviceProfiles.RockBandDrumsMacNativeProfile" == null || "InControl.NativeDeviceProfiles.RockBandDrumsMacNativeProfile" != null) && ("InControl.NativeDeviceProfiles.RockBandGuitarMacNativeProfile" == null || "InControl.NativeDeviceProfiles.RockBandGuitarMacNativeProfile" != null) && ("InControl.NativeDeviceProfiles.RockCandyControllerMacNativeProfile" == null || "InControl.NativeDeviceProfiles.RockCandyControllerMacNativeProfile" != null) && ("InControl.NativeDeviceProfiles.RockCandyPS3ControllerMacNativeProfile" == null || "InControl.NativeDeviceProfiles.RockCandyPS3ControllerMacNativeProfile" != null) && ("InControl.NativeDeviceProfiles.RockCandyXbox360ControllerMacNativeProfile" == null || "InControl.NativeDeviceProfiles.RockCandyXbox360ControllerMacNativeProfile" != null) && ("InControl.NativeDeviceProfiles.RockCandyXboxOneControllerMacNativeProfile" == null || "InControl.NativeDeviceProfiles.RockCandyXboxOneControllerMacNativeProfile" != null) && ("InControl.NativeDeviceProfiles.SaitekXbox360ControllerMacNativeProfile" == null || "InControl.NativeDeviceProfiles.SaitekXbox360ControllerMacNativeProfile" != null) && ("InControl.NativeDeviceProfiles.SteamWindowsNativeProfile" == null || "InControl.NativeDeviceProfiles.SteamWindowsNativeProfile" != null) && ("InControl.NativeDeviceProfiles.SteelseriesNimbusMacNativeProfile" == null || "InControl.NativeDeviceProfiles.SteelseriesNimbusMacNativeProfile" != null) && ("InControl.NativeDeviceProfiles.ThrustMasterFerrari430RacingWheelMacNativeProfile" == null || "InControl.NativeDeviceProfiles.ThrustMasterFerrari430RacingWheelMacNativeProfile" != null) && ("InControl.NativeDeviceProfiles.ThrustmasterFerrari458RacingWheelMacNativeProfile" == null || "InControl.NativeDeviceProfiles.ThrustmasterFerrari458RacingWheelMacNativeProfile" != null) && ("InControl.NativeDeviceProfiles.ThrustMasterFerrari458SpiderRacingWheelMacNativeProfile" == null || "InControl.NativeDeviceProfiles.ThrustMasterFerrari458SpiderRacingWheelMacNativeProfile" != null) && ("InControl.NativeDeviceProfiles.ThrustmasterGPXControllerMacNativeProfile" == null || "InControl.NativeDeviceProfiles.ThrustmasterGPXControllerMacNativeProfile" != null) && ("InControl.NativeDeviceProfiles.ThrustmasterTMXMacNativeProfile" == null || "InControl.NativeDeviceProfiles.ThrustmasterTMXMacNativeProfile" != null) && ("InControl.NativeDeviceProfiles.ThrustmasterTMXMacNativeProfile" == null || "InControl.NativeDeviceProfiles.ThrustmasterTMXMacNativeProfile" != null) && ("InControl.NativeDeviceProfiles.TrustPredatorJoystickMacNativeProfile" == null || "InControl.NativeDeviceProfiles.TrustPredatorJoystickMacNativeProfile" != null) && ("InControl.NativeDeviceProfiles.TSZPelicanControllerMacNativeProfile" == null || "InControl.NativeDeviceProfiles.TSZPelicanControllerMacNativeProfile" != null) && ("InControl.NativeDeviceProfiles.Xbox360MortalKombatFightStickMacNativeProfile" == null || "InControl.NativeDeviceProfiles.Xbox360MortalKombatFightStickMacNativeProfile" != null) && ("InControl.NativeDeviceProfiles.Xbox360ProEXControllerMacNativeProfile" == null || "InControl.NativeDeviceProfiles.Xbox360ProEXControllerMacNativeProfile" != null) && ("InControl.NativeDeviceProfiles.Xbox360WiredWindowsNativeProfile" == null || "InControl.NativeDeviceProfiles.Xbox360WiredWindowsNativeProfile" != null) && ("InControl.NativeDeviceProfiles.Xbox360WirelessWindowsNativeProfile" == null || "InControl.NativeDeviceProfiles.Xbox360WirelessWindowsNativeProfile" != null) && ("InControl.NativeDeviceProfiles.XboxOneEliteWindows10AENativeProfile" == null || "InControl.NativeDeviceProfiles.XboxOneEliteWindows10AENativeProfile" != null) && ("InControl.NativeDeviceProfiles.XboxOneEliteWindowsNativeProfile" == null || "InControl.NativeDeviceProfiles.XboxOneEliteWindowsNativeProfile" != null) && ("InControl.NativeDeviceProfiles.XboxOneMFiNativeProfile" == null || "InControl.NativeDeviceProfiles.XboxOneMFiNativeProfile" != null) && ("InControl.NativeDeviceProfiles.XboxOneSMacNativeProfile" == null || "InControl.NativeDeviceProfiles.XboxOneSMacNativeProfile" != null) && ("InControl.NativeDeviceProfiles.XboxOneWindows10AENativeProfile" == null || "InControl.NativeDeviceProfiles.XboxOneWindows10AENativeProfile" != null) && ("InControl.NativeDeviceProfiles.XboxOneWindows10NativeProfile" == null || "InControl.NativeDeviceProfiles.XboxOneWindows10NativeProfile" != null) && ("InControl.NativeDeviceProfiles.XboxOneWindowsNativeProfile" == null || "InControl.NativeDeviceProfiles.XboxOneWindowsNativeProfile" != null) && ("InControl.NativeDeviceProfiles.XboxOneWirelessAdapterWindowsNativeProfile" == null || "InControl.NativeDeviceProfiles.XboxOneWirelessAdapterWindowsNativeProfile" != null) && ("InControl.NativeDeviceProfiles.XInputWindowsNativeProfile" == null || "InControl.NativeDeviceProfiles.XInputWindowsNativeProfile" != null) && ("InControl.NativeDeviceProfiles.XTR_G2_MacNativeProfile" == null || "InControl.NativeDeviceProfiles.XTR_G2_MacNativeProfile" != null) && ("InControl.NativeDeviceProfiles.XTR_G2_WindowsNativeProfile" == null || "InControl.NativeDeviceProfiles.XTR_G2_WindowsNativeProfile" != null) && ("InControl.NativeDeviceProfiles.XTR55_G2_MacNativeProfile" == null || "InControl.NativeDeviceProfiles.XTR55_G2_MacNativeProfile" != null) && ("InControl.NativeDeviceProfiles.XTR55_G2_WindowsNativeProfile" == null || "InControl.NativeDeviceProfiles.XTR55_G2_WindowsNativeProfile" != null))
			{
				return;
			}
			throw new ArrayTypeMismatchException();
		}

		// Token: 0x040002E1 RID: 737
		public static readonly string[] Profiles;
	}
}