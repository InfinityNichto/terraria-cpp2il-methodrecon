using System;

namespace System.Net
{
	// Token: 0x0200018F RID: 399
	public enum FtpStatusCode
	{
		// Token: 0x040007CD RID: 1997
		Undefined,
		// Token: 0x040007CE RID: 1998
		RestartMarker = 110,
		// Token: 0x040007CF RID: 1999
		ServiceTemporarilyNotAvailable = 120,
		// Token: 0x040007D0 RID: 2000
		DataAlreadyOpen = 125,
		// Token: 0x040007D1 RID: 2001
		OpeningData = 150,
		// Token: 0x040007D2 RID: 2002
		CommandOK = 200,
		// Token: 0x040007D3 RID: 2003
		CommandExtraneous = 202,
		// Token: 0x040007D4 RID: 2004
		DirectoryStatus = 212,
		// Token: 0x040007D5 RID: 2005
		FileStatus,
		// Token: 0x040007D6 RID: 2006
		SystemType = 215,
		// Token: 0x040007D7 RID: 2007
		SendUserCommand = 220,
		// Token: 0x040007D8 RID: 2008
		ClosingControl,
		// Token: 0x040007D9 RID: 2009
		ClosingData = 226,
		// Token: 0x040007DA RID: 2010
		EnteringPassive,
		// Token: 0x040007DB RID: 2011
		LoggedInProceed = 230,
		// Token: 0x040007DC RID: 2012
		ServerWantsSecureSession = 234,
		// Token: 0x040007DD RID: 2013
		FileActionOK = 250,
		// Token: 0x040007DE RID: 2014
		PathnameCreated = 257,
		// Token: 0x040007DF RID: 2015
		SendPasswordCommand = 331,
		// Token: 0x040007E0 RID: 2016
		NeedLoginAccount,
		// Token: 0x040007E1 RID: 2017
		FileCommandPending = 350,
		// Token: 0x040007E2 RID: 2018
		ServiceNotAvailable = 421,
		// Token: 0x040007E3 RID: 2019
		CantOpenData = 425,
		// Token: 0x040007E4 RID: 2020
		ConnectionClosed,
		// Token: 0x040007E5 RID: 2021
		ActionNotTakenFileUnavailableOrBusy = 450,
		// Token: 0x040007E6 RID: 2022
		ActionAbortedLocalProcessingError,
		// Token: 0x040007E7 RID: 2023
		ActionNotTakenInsufficientSpace,
		// Token: 0x040007E8 RID: 2024
		CommandSyntaxError = 500,
		// Token: 0x040007E9 RID: 2025
		ArgumentSyntaxError,
		// Token: 0x040007EA RID: 2026
		CommandNotImplemented,
		// Token: 0x040007EB RID: 2027
		BadCommandSequence,
		// Token: 0x040007EC RID: 2028
		NotLoggedIn = 530,
		// Token: 0x040007ED RID: 2029
		AccountNeeded = 532,
		// Token: 0x040007EE RID: 2030
		ActionNotTakenFileUnavailable = 550,
		// Token: 0x040007EF RID: 2031
		ActionAbortedUnknownPageType,
		// Token: 0x040007F0 RID: 2032
		FileActionAborted,
		// Token: 0x040007F1 RID: 2033
		ActionNotTakenFilenameNotAllowed
	}
}
