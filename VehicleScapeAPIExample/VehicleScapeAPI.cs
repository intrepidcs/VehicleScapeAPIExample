using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;

namespace VehicleScapeAPIExample
{
	public class VehicleScapeAPI
	{
		const string DLLName = "VehicleScapeDLL.dll";

		// Note: C# does not provide a mechanism for C-style optional parameters, i.e. pointer parameters
		// for which null is an acceptable value. To represent optional values, an overload is provided
		// with the optional parameter's type replaced by IntPtr. To pass null, pass IntPtr.Zero.

		// Example function with optional parameters:
		/*
		 
		[DllImport(DLLName, CallingConvention = CallingConvention.Cdecl)]
		public static extern Result GetNetworks([In, Out] ref Network NetworkProperties, ref int NumberOfNetworks);
		[DllImport(DLLName, CallingConvention = CallingConvention.Cdecl)]
		public static extern Result GetNetworks(IntPtr NetworkProperties, ref int NumberOfNetworks);
		
		*/

		// Example usage:
		/*
		 
		int networkCount = 0;
		VehicleScapeAPI.Result result = VehicleScapeAPI.GetNetworks(IntPtr.Zero, ref networkCount);
		if(result == VehicleScapeAPI.Result.ResultOK) {
			// (networkCount now contains the number of networks
			...
		}

		*/

		[DllImport(DLLName, CallingConvention = CallingConvention.Cdecl)]
		public static extern Result Init();
		[DllImport(DLLName, CallingConvention = CallingConvention.Cdecl)]
		public static extern Result MakeNew();
		[DllImport(DLLName, CallingConvention = CallingConvention.Cdecl)]
		public static extern Result LoadFromFile([MarshalAs(UnmanagedType.LPWStr)] string sFile);
		[DllImport(DLLName, CallingConvention = CallingConvention.Cdecl)]
		public static extern Result LoadFromPackage([MarshalAs(UnmanagedType.LPWStr)] string sFile);
		[DllImport(DLLName, CallingConvention = CallingConvention.Cdecl)]
		public static extern Result SaveToFile([MarshalAs(UnmanagedType.LPWStr)] string sFile);
		[DllImport(DLLName, CallingConvention = CallingConvention.Cdecl)]
		public static extern Result SaveToPackage([MarshalAs(UnmanagedType.LPWStr)] string sFile);
		[DllImport(DLLName, CallingConvention = CallingConvention.Cdecl)]
		public static extern Result GetDevices([In, Out] Device[] DeviceProperties, ref int NumberOfDevices);
		[DllImport(DLLName, CallingConvention = CallingConvention.Cdecl)]
		public static extern Result GetDevices(IntPtr DeviceProperties, ref int NumberOfDevices);
		[DllImport(DLLName, CallingConvention = CallingConvention.Cdecl)]
		public static extern Result GetStorageMediumsForDevice(uint deviceHandle, [In, Out] MemoryType[] memoryTypes, ref int NumberOfTypes);
		[DllImport(DLLName, CallingConvention = CallingConvention.Cdecl)]
		public static extern Result GetStorageMediumsForDevice(uint deviceHandle, IntPtr memoryTypes, ref int NumberOfTypes);
		[DllImport(DLLName, CallingConvention = CallingConvention.Cdecl)]
		public static extern Result EraseCoreMini(uint deviceHandle, MemoryType location);
		[DllImport(DLLName, CallingConvention = CallingConvention.Cdecl)]
		public static extern Result SendCoreMini(uint deviceHandle, MemoryType location, uint options);
		[DllImport(DLLName, CallingConvention = CallingConvention.Cdecl)]
		public static extern Result SetCoreMiniGeneratorSettings([In] ref CoreMiniGeneratorSettings settings);
		[DllImport(DLLName, CallingConvention = CallingConvention.Cdecl)]
		public static extern Result GetCoreMiniGeneratorSettings([In, Out] ref CoreMiniGeneratorSettings settings);
		[DllImport(DLLName, CallingConvention = CallingConvention.Cdecl)]
		public static extern Result AddUserFilePath([MarshalAs(UnmanagedType.LPWStr)] string sFile);
		[DllImport(DLLName, CallingConvention = CallingConvention.Cdecl)]
		public static extern Result RemoveUserFilePath([MarshalAs(UnmanagedType.LPWStr)] string sFile);
		[DllImport(DLLName, CallingConvention = CallingConvention.Cdecl)]
		public static extern Result RemoveAllUserFilePaths();
		[DllImport(DLLName, CallingConvention = CallingConvention.Cdecl)]
		public static extern Result CompileCoreMini(uint deviceHandle);
		[DllImport(DLLName, CallingConvention = CallingConvention.Cdecl)]
		public static extern Result ReflashDevice(uint deviceHandle);
		[DllImport(DLLName, CallingConvention = CallingConvention.Cdecl)]
		public static extern Result SetDAQProperties([In] ref DAQ DAQProperties);
		[DllImport(DLLName, CallingConvention = CallingConvention.Cdecl)]
		public static extern Result GetDAQProperties([In, Out] ref DAQ DAQProperties);
		[DllImport(DLLName, CallingConvention = CallingConvention.Cdecl)]
		public static extern Result AddDAQ([In, Out] ref DAQ DAQProperties);
		[DllImport(DLLName, CallingConvention = CallingConvention.Cdecl)]
		public static extern Result RemoveDAQ(uint DAQHandle);
		[DllImport(DLLName, CallingConvention = CallingConvention.Cdecl)]
		public static extern Result GetDAQs([In, Out] DAQ[] DAQProperties, ref int NumberOfDAQs);
		[DllImport(DLLName, CallingConvention = CallingConvention.Cdecl)]
		public static extern Result GetDAQs(IntPtr DAQProperties, ref int NumberOfDAQs);
		[DllImport(DLLName, CallingConvention = CallingConvention.Cdecl)]
		public static extern Result SetDAQCollectionProperties([In] ref DAQCollection DAQCollectionProperties);
		[DllImport(DLLName, CallingConvention = CallingConvention.Cdecl)]
		public static extern Result GetDAQCollectionProperties([In, Out] ref DAQCollection DAQCollectionProperties);
		[DllImport(DLLName, CallingConvention = CallingConvention.Cdecl)]
		public static extern Result AddDAQCollection(uint DAQHandle, [In, Out] ref DAQCollection DAQCollectionProperties);
		[DllImport(DLLName, CallingConvention = CallingConvention.Cdecl)]
		public static extern Result RemoveDAQCollection(uint DAQCollectionHandle);
		[DllImport(DLLName, CallingConvention = CallingConvention.Cdecl)]
		public static extern Result GetDAQCollections(uint DAQHandle, [In, Out] DAQCollection[] DAQCollectionProperties, ref int NumberOfDAQCollections);
		[DllImport(DLLName, CallingConvention = CallingConvention.Cdecl)]
		public static extern Result GetDAQCollections(uint DAQHandle, IntPtr DAQCollectionProperties, ref int NumberOfDAQCollections);
		[DllImport(DLLName, CallingConvention = CallingConvention.Cdecl)]
		public static extern Result SetDAQChannelProperties([In] ref DAQChannel DAQChannelProperties);
		[DllImport(DLLName, CallingConvention = CallingConvention.Cdecl)]
		public static extern Result GetDAQChannelProperties([In, Out] ref DAQChannel DAQChannelProperties);
		[DllImport(DLLName, CallingConvention = CallingConvention.Cdecl)]
		public static extern Result AddDAQChannel(uint DAQHandle, uint signalHandle, [In, Out] ref DAQChannel DAQChannelProperties);
		[DllImport(DLLName, CallingConvention = CallingConvention.Cdecl)]
		public static extern Result RemoveDAQChannel(uint DAQChannelHandle);
		[DllImport(DLLName, CallingConvention = CallingConvention.Cdecl)]
		public static extern Result SetAlwaysCollectDAQChannel(uint DAQChannelHandle);
		[DllImport(DLLName, CallingConvention = CallingConvention.Cdecl)]
		public static extern Result AddCollectionToDAQChannel(uint DAQChannelHandle, uint DAQCollectionHandle);
		[DllImport(DLLName, CallingConvention = CallingConvention.Cdecl)]
		public static extern Result RemoveCollectionFromDAQChannel(uint DAQChannelHandle, uint DAQCollectionHandle);
		[DllImport(DLLName, CallingConvention = CallingConvention.Cdecl)]
		public static extern Result GetDAQChannels(uint DAQHandle, [In, Out] DAQChannel[] DAQChannelProperties, ref int NumberOfDAQChannels);
		[DllImport(DLLName, CallingConvention = CallingConvention.Cdecl)]
		public static extern Result GetDAQChannels(uint DAQHandle, IntPtr DAQChannelProperties, ref int NumberOfDAQChannels);
		[DllImport(DLLName, CallingConvention = CallingConvention.Cdecl)]
		public static extern Result GetNetworkProperties([In, Out] ref Network NetworkProperties);
		[DllImport(DLLName, CallingConvention = CallingConvention.Cdecl)]
		public static extern Result GetNetworks([In, Out] Network[] NetworkProperties, ref int NumberOfNetworks);
		[DllImport(DLLName, CallingConvention = CallingConvention.Cdecl)]
		public static extern Result GetNetworks(IntPtr NetworkProperties, ref int NumberOfNetworks);
		[DllImport(DLLName, CallingConvention = CallingConvention.Cdecl)]
		public static extern Result SetMessageProperties([In] ref Message MessageProperties);
		[DllImport(DLLName, CallingConvention = CallingConvention.Cdecl)]
		public static extern Result GetMessageProperties([In, Out] ref Message MessageProperties);
		[DllImport(DLLName, CallingConvention = CallingConvention.Cdecl)]
		public static extern Result AddRxMessage(uint networkHandle, [In, Out] ref Message MessageProperties);
		[DllImport(DLLName, CallingConvention = CallingConvention.Cdecl)]
		public static extern Result RemoveRxMessage(uint MessageHandle);
		[DllImport(DLLName, CallingConvention = CallingConvention.Cdecl)]
		public static extern Result GetRxMessages([In, Out] Message[] MessageProperties, ref int NumberOfMessages);
		[DllImport(DLLName, CallingConvention = CallingConvention.Cdecl)]
		public static extern Result GetRxMessages(IntPtr MessageProperties, ref int NumberOfMessages);
		[DllImport(DLLName, CallingConvention = CallingConvention.Cdecl)]
		public static extern Result GetDbMessages([In, Out] Message[] MessageProperties, ref int NumberOfMessages);
		[DllImport(DLLName, CallingConvention = CallingConvention.Cdecl)]
		public static extern Result GetDbMessages(IntPtr MessageProperties, ref int NumberOfMessages);
		[DllImport(DLLName, CallingConvention = CallingConvention.Cdecl)]
		public static extern Result SetMessageJ1939(uint MessageHandle, [In] ref MessageJ1939 J1939Properties);
		[DllImport(DLLName, CallingConvention = CallingConvention.Cdecl)]
		public static extern Result GetMessageJ1939(uint MessageHandle, [In, Out] ref MessageJ1939 J1939Properties);
		[DllImport(DLLName, CallingConvention = CallingConvention.Cdecl)]
		public static extern Result SetMessageArbId(uint MessageHandle, uint value, uint mask);
		[DllImport(DLLName, CallingConvention = CallingConvention.Cdecl)]
		public static extern Result GetMessageArbId(uint MessageHandle, ref uint value, ref uint mask);
		[DllImport(DLLName, CallingConvention = CallingConvention.Cdecl)]
		public static extern Result SetMessageByte(uint MessageHandle, int byteNumber, uint value, uint mask);
		[DllImport(DLLName, CallingConvention = CallingConvention.Cdecl)]
		public static extern Result GetMessageByte(uint MessageHandle, int byteNumber, ref uint value, ref uint mask);
		[DllImport(DLLName, CallingConvention = CallingConvention.Cdecl)]
		public static extern Result SetSignalProperties([In] ref Signal SignalProperties);
		[DllImport(DLLName, CallingConvention = CallingConvention.Cdecl)]
		public static extern Result GetSignalProperties([In, Out] ref Signal SignalProperties);
		[DllImport(DLLName, CallingConvention = CallingConvention.Cdecl)]
		public static extern Result AddSignal(uint MessageHandle, [In, Out] ref Signal SignalProperties);
		[DllImport(DLLName, CallingConvention = CallingConvention.Cdecl)]
		public static extern Result RemoveSignal(uint SignalHandle);
		[DllImport(DLLName, CallingConvention = CallingConvention.Cdecl)]
		public static extern Result GetSignals(uint MessageHandle, [In, Out] Signal[] SignalProperties, ref int NumberOfSignals);
		[DllImport(DLLName, CallingConvention = CallingConvention.Cdecl)]
		public static extern Result GetSignals(uint MessageHandle, IntPtr SignalProperties, ref int NumberOfSignals);
		[DllImport(DLLName, CallingConvention = CallingConvention.Cdecl)]
		public static extern Result SetSignalStates(uint SignalHandle, [In] SignalState[] SignalStateProperties, int NumberOfSignalStates);
		[DllImport(DLLName, CallingConvention = CallingConvention.Cdecl)]
		public static extern Result GetSignalStates(uint SignalHandle, [In, Out] SignalState[] SignalStateProperties, ref int NumberOfSignalStates);
		[DllImport(DLLName, CallingConvention = CallingConvention.Cdecl)]
		public static extern Result GetSignalStates(uint SignalHandle, IntPtr SignalStateProperties, ref int NumberOfSignalStates);
		[DllImport(DLLName, CallingConvention = CallingConvention.Cdecl)]
		public static extern Result SetDBCJ1939Settings([In] ref DBCJ1939Settings settings);
		[DllImport(DLLName, CallingConvention = CallingConvention.Cdecl)]
		public static extern Result GetDBCJ1939Settings([In, Out] ref DBCJ1939Settings settings);
		[DllImport(DLLName, CallingConvention = CallingConvention.Cdecl)]
		public static extern Result AddDatabase(uint NetworkHandle, [MarshalAs(UnmanagedType.LPWStr)] string fileName, DatabaseType type, [In, Out] ref Database DatabaseProperties);
		[DllImport(DLLName, CallingConvention = CallingConvention.Cdecl)]
		public static extern Result RemoveDatabase(uint DatabaseHandle);
		[DllImport(DLLName, CallingConvention = CallingConvention.Cdecl)]
		public static extern Result GetDatabases(uint NetworkHandle, [In, Out] Database[] DatabaseProperties, ref int NumberOfDatabases);
		[DllImport(DLLName, CallingConvention = CallingConvention.Cdecl)]
		public static extern Result GetDatabases(uint NetworkHandle, IntPtr DatabaseProperties, ref int NumberOfDatabases);
		[DllImport(DLLName, CallingConvention = CallingConvention.Cdecl)]
		public static extern Result GenerateCoreMini(uint DAQHandle, uint DeviceHandle);

		public const int DoNotOverrideCardNumDivisions = 0;

		public const int DAQReportTypeNone = 0x00;
		public const int DAQReportTypeLEDs = 0x01;
		public const int DAQReportTypeNeoMOTE = 0x02;
		public const int DAQReportTypePushButtonPendant = 0x04;
		public const int DAQReportTypeBeepOnWakeup = 0x10;

		public const int UseDecimationFromChannels = -1;
		public const int NoDecimationRate = -2;

		public const int NoTriggerTrueTime = -1;

		public const int DoNotOverrideTriggerEvents = -1;
		public const int NeverGoToSleep = -1;

		public const uint NO_MULTIPLEXING = 0xffffffff;
		public const uint MULTIPLEXER_SWITCH = 0xfffffffe;

		public const int MAX_DESCRIPTION_SIZE = 224;
		public const int MAX_EXPRESSION_SIZE = 224;
		public const int MAX_FILENAME_SIZE = 224;
		public const int MAX_FORMAT_SIZE = 16;

		public const uint J1939IdWildCard = 0xFFFFFFFF;

		public const int RUNCOREMINI = 0x01;
		public const int SKIPREADBIN = 0x02;
		public const int SKIPFWCHECK = 0x04;
		public const int SYNCRTC = 0x08;

		public const int COREMINI_SECTOR_OFFSET = 256;

		public const int Version = 0x03080201;

		public static string ResultToString(Result result)
		{
			switch (result) {
				case Result.ResultOk:
					return "OK";
				case Result.ResultAlreadyInitialized:
					return "Already initialized";
				case Result.ResultInvalidHandle:
					return "Invalid handle";
				case Result.ResultByteNotFound:
					return "Byte not found";
				case Result.ResultAlreadyAdded:
					return "Already added";
				case Result.ResultUnableToLoadFile:
					return "Unable to load file";
				case Result.ResultCouldNotConnectToTarget:
					return "Could not connect to target";
				case Result.ResultInvalidMedium:
					return "Invalid medium";
				case Result.ResultSDCardNotAvailable:
					return "SD Card not available";
				case Result.ResultCoreMiniCompilerProblem:
					return "CoreMini compiler problem";
				case Result.ResultFirmwareNotCorrect:
					return "Firmware not correct";
				case Result.ResultCouldNotSetRTC:
					return "Could not set RTC";
				case Result.ResultBadRTC:
					return "Bad RTC";
				case Result.ResultBadRTCButUpdate:
					return "Bad RTC but update";
				case Result.ResultUnableToSaveFile:
					return "Unable to save file";
				case Result.ResultAlreadyExists:
					return "Already exists";
				case Result.ResultUnableToSetupForCompile:
					return "Unable to setup for compile";
				case Result.ResultUnableToReflash:
					return "Unable to reflash";
				case Result.ResultLicenseInsufficient:
					return "License insufficient";
				default:
					return "Unknown";
			}
		}

		public static string SignalTypeToString(SignalType type)
		{
			switch (type) {
				case SignalType.SignalTypeAnalog:
					return "Analog";
				case SignalType.SignalTypeDigital:
					return "Digital";
				case SignalType.SignalTypeStateEncoded:
					return "State Encoded";
				case SignalType.SignalTypeStateEncodedPlusAnalog:
					return "State Encoded plus Analog";
				case SignalType.SignalTypeText:
					return "Text";
				default:
					return "Unknown";
			}
		}

		public static string DeviceTypeToString(DeviceType type)
		{
			switch (type) {
				case DeviceType.DeviceTypeNeoVIFire:
					return "NeoVI Fire";
				case DeviceType.DeviceTypeNeoVIFire2:
					return "NeoVI Fire2";
				case DeviceType.DeviceTypeNeoVIIon:
					return "NeoVI Ion";
				case DeviceType.DeviceTypeNeoVIPlasma:
					return "NeoVI Plasma";
				case DeviceType.DeviceTypeNeoVIRed:
					return "NeoVI Red";
				case DeviceType.DeviceTypeRadGalaxy:
					return "RAD Galaxy";
				case DeviceType.DeviceTypeValueCANRf:
					return "ValueCAN RF";
				default:
					return "Unknown";
			}
		}

		public enum Result
		{
			ResultOk = 0,
			ResultAlreadyInitialized = 1,
			ResultInvalidHandle = 2,
			ResultByteNotFound = 3,
			ResultAlreadyAdded = 4,
			ResultUnableToLoadFile = 5,
			ResultCouldNotConnectToTarget = 6,
			ResultInvalidMedium = 7,
			ResultSDCardNotAvailable = 8,
			ResultCoreMiniCompilerProblem = 9,
			ResultFirmwareNotCorrect = 10,
			ResultCouldNotSetRTC = 11,
			ResultBadRTC = 12,
			ResultBadRTCButUpdate = 13,
			ResultUnableToSaveFile = 14,
			ResultAlreadyExists = 15,
			ResultUnableToSetupForCompile = 16,
			ResultUnableToReflash = 17,
			ResultLicenseInsufficient = 18
		}


		public enum Protocol
		{
			ProtocolCustom = 0,
			ProtocolCan = 1,
			ProtocolGmlan = 2,
			ProtocolJ1850vpw = 3,
			ProtocolJ1850pwm = 4,
			ProtocolIso9141 = 5,
			ProtocolKeyword2000 = 6,
			ProtocolGmAldlUart = 7,
			ProtocolChryslerCcd = 8,
			ProtocolChryslerSci = 9,
			ProtocolFordUbp = 10,
			ProtocolBean = 11,
			ProtocolLin = 12,
			ProtocolJ1708 = 13,
			ProtocolChryslerJvpw = 14,
			ProtocolJ1939 = 15,
			ProtocolFlexRay = 16,
			ProtocolMost = 17,
			ProtocolCgi = 18,
			ProtocolGmeCimSclKline = 19,
			ProtocolSpi = 20,
			ProtocolI2c = 21,
			ProtocolGenericUart = 22,
			ProtocolJtag = 23,
			ProtocolUnio = 24,
			ProtocolDallas1Wire = 25,
			ProtocolGenericManchester = 26,
			ProtocolSent = 27,
			ProtocolUart = 28,
			ProtocolEthernet = 29,
			ProtocolCanFd = 30,
			ProtocolGmfsa = 31,
			ProtocolTcp = 32,
		}

		public enum MessageType
		{
			MessageTypeCanStd = 0,
			MessageTypeCanXtd = 1,
			MessageTypeCanAny = 2,
		}

		public enum SignalType
		{
			SignalTypeStateEncodedPlusAnalog = 0,
			SignalTypeAnalog = 1,
			SignalTypeDigital = 2,
			SignalTypeStateEncoded = 3,
			SignalTypeText = 4,
		}

		public enum SignalRawValueType
		{
			SignalRawValueTypeUnsignedInt = 0,
			SignalRawValueTypeTwosComplimentInt = 1,
			SignalRawValueTypeSignMagnitudeInt = 2,
			SignalRawValueTypeIeeeFloat32Bit = 3,
			SignalRawValueTypeIeeeFloat64Bit = 4,
			SignalRawValueTypePackedBCD = 5,
			SignalRawValueTypeTaskingFloat = 6,
		}

		public enum CollectionType
		{
			StartImmediatelyStopNumMessage = 0,
			StartImmediatelyStopExpressionTrue = 1,
			StartExpressionTrueStopNumMessage = 2,
			StartExpressionTrueStopExpressionTrue = 3,
			StartTriggerTrueStopPrePostByTime = 4,
			StartTriggerTrueStopPrePostByMessage = 5,
			StartTriggerTrueStopPrePostExpressionByTime = 6,
			StartTriggerTrueStopPrePostExpressionByMessage = 7,
			StartTriggerTrueStopOneShot = 8,
			StartTriggerChangesStopPrePostByTime = 9,
			StartTriggerChangesStopPrePostByMessage = 10,
			StartTriggerChangesStopPrePostExpressionByTime = 11,
			StartTriggerChangesStopPrePostExpressionByMessage = 12,
			StartTriggerChangesStopOneShot = 13,
			StartTriggerChangesRangeStopPrePostByTime = 14,
			StartTriggerChangesRangeStopPrePostByMessage = 15,
			StartTriggerChangesRangeStopPrePostExpressionByTime = 16,
			StartTriggerChangesRangeStopPrePostExpressionByMessage = 17,
			StartTriggerChangesRangeStopOneShot = 18,
		}

		public enum OptimizationLevel
		{
			OptimizationLevelOff = 0,
			OptimizationLevelOn = 5,
			OptimizationLevelOnUseFlash = 10,
		}

		public enum MaxValuesPerFileLine
		{
			MaxValuesPerFileLine3 = 3,
			MaxValuesPerFileLine6 = 6,
		}

		public enum SDCardSize
		{
			SDCardSize512M = 0,
			SDCardSize2GB = 2,
			SDCardSize4GB = 3,
			SDCardSize8GB = 4,
			SDCardSize16GB = 5,
			SDCardSize32GB = 6,
			SDCardSize64GB = 7,
		}

		public enum WakeupModeType
		{
			WakeupModeTypeNormal = 0,
			WakeupModeTypeInstant = 1,
		}

		public enum FileSaveAction
		{
			FileSaveActionDoNotGenerate = -1,
			FileSaveActionDefault = 0,
			FileSaveActionSave = 1,
		}

		public enum CompareValueWith
		{
			CompareValueWithStart = 0,
			CompareValueWithPrevious = 1,
		}

		public enum TriggerChange
		{
			TriggerChangeMoreThan = 0,
			TriggerChangeLessThan = 1,
			TriggerChangeExactly = 2,
		}

		public enum TriggerChangeDirection
		{
			TriggerChangeDirectionIncrease = 0,
			TriggerChangeDirectionDecrease = 1,
			TriggerChangeDirectionEither = 2,
			TriggerChangeDirectionDecreaseAfterExceed = 3,
		}

		public enum RestartType
		{
			RestartTypeStop = 0,
			RestartTypeRestart = 1,
			RestartTypeForceRestart = 2,
		}

		public enum Priority
		{
			PriorityLow = 0,
			PriorityNormal = 1,
			PriorityHigh = 2,
		}

		public enum DeviceType
		{
			DeviceTypeNeoVIFire = 0,
			DeviceTypeNeoVIRed = 1,
			DeviceTypeNeoVIPlasma = 2,
			DeviceTypeNeoVIIon = 3,
			DeviceTypeNeoVIFire2 = 4,
			DeviceTypeRadGalaxy = 5,
			DeviceTypeValueCANRf = 6,
		}

		public enum MemoryType
		{
			MemoryTypeDataFlash = 0,//EEPROM
			MemoryTypeRemoveableStorage = 1,//SD
			MemoryTypeInternalFlash = 2,
			MemoryTypeExternalSRAM = 4,//VCAN 3 has this
		}

		public enum DatabaseType
		{
			DatabaseTypeCan = 0,
			DatabaseTypeJ1939PgnOffset = 1,
			DatabaseTypeJ1939NoPgnOffset = 2,
		}

		[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
		public struct Database
		{
			public int version;
			public uint handle;
			[MarshalAs(UnmanagedType.ByValTStr, SizeConst = MAX_FILENAME_SIZE)]
			public string fileName;
			public DatabaseType type;
		}

		[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
		public struct DBCJ1939Settings
		{
			public int version;
			public int priorityBitsToDontCare;
			public int sourceBitsToDontCare;
			public int destinationBitsToDontCare;
			public int nullAddressToDontCare;
			public int globalAddressBitsToDontCare;
		}

		[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
		public struct Device
		{
			public int version;
			public uint handle;
			public DeviceType deviceType;
			public uint serialNumber;
		}

		[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
		public struct CoreMiniGeneratorSettings
		{
			public int version;
			public SDCardSize cardSize;
			public int sleepWithUsb;
			public OptimizationLevel optimization;
			public MaxValuesPerFileLine maxValuesPerFileLine;
			public uint numRecordsPersistentLogdata;
			public uint cardNumDivsions;
		}

		[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
		public struct DAQ
		{
			public int version;
			public uint handle;
			[MarshalAs(UnmanagedType.ByValTStr, SizeConst = MAX_DESCRIPTION_SIZE)]
			public string description;
			public SDCardSize cardSize;
			public int triggerEventsOverride;
			public uint reportTypes;
			public WakeupModeType wakeupMode;
			public double sleepPeriod;
			public int newFileOnWakeup;
			public FileSaveAction vsdbAction;
			public int remoteWakeup;
			public double neoVIOverallTimeout;
			public double neoVIConnectionTimeout;
			public double neoVIVoltageCutoff;
		}

		[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
		public struct AdvancedCollectionOptions
		{
			public int storeOnChange;
			public double decimationRate;
		}

		[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
		public struct StartTriggerTrue
		{
			public double triggerTrueTime;
		}

		[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
		public struct StartTriggerChangesRange
		{
			public TriggerChangeDirection triggerChangeDirection;
			public TriggerChange triggerChange;
			public double triggerThreshold;
			public CompareValueWith compareValueWith;
		}

		[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
		public struct StopNumMessages
		{
			public int numMessages;
		}

		[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
		public struct StopPrePostByMessage
		{
			public int numMsgsPreTrigger;
			public int numMsgsPostTrigger;
		}

		[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
		public struct StopPrePostByTime
		{
			public double timePreTrigger;
			public double timePostTrigger;
			public int messagesPerSecond;
		}

		[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
		public struct StopPrePostOnExpression
		{
			public double expressionTimeout;
			public int triggerExpressionOnChange;
			[MarshalAs(UnmanagedType.ByValTStr, SizeConst = MAX_EXPRESSION_SIZE)]
			public string expression;
		}

		[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
		public struct StopOneShot
		{
			public double delay;
			public double recordTime;
		}

		[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
		public struct StopExpressionTrue
		{
			[MarshalAs(UnmanagedType.ByValTStr, SizeConst = MAX_EXPRESSION_SIZE)]
			public string expression;
		}

		[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
		public struct DAQCollection
		{
			public int version;
			public uint handle;
			public int appendDateTime;
			[MarshalAs(UnmanagedType.ByValTStr, SizeConst = MAX_FILENAME_SIZE)]
			public string fileName;
			public int logEntireBus;
			public AdvancedCollectionOptions advancedCollectionOptions;
			public CollectionType collectionType;
			[MarshalAs(UnmanagedType.ByValTStr, SizeConst = MAX_EXPRESSION_SIZE)]
			public string startExpression;
			public StartTriggerTrue startTriggerTrue;
			public StartTriggerChangesRange startTriggerChangesRange;
			public StopNumMessages stopNumMessages;
			public StopExpressionTrue stopExpressionTrue;
			public StopPrePostByMessage stopPrePostByMessage;
			public StopPrePostByTime stopPrePostByTime;
			public StopPrePostOnExpression stopPrePostOnExpression;
			public StopOneShot stopOneShot;
			public RestartType restartType;
		}

		[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
		public struct DAQChannel
		{
			public int version;
			public uint handle;
			public uint signalHandle;
			public Priority priority;
			public int storeOnChange;
		}

		[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
		public struct Network
		{
			public int version;
			public uint handle;
			[MarshalAs(UnmanagedType.ByValTStr, SizeConst = MAX_DESCRIPTION_SIZE)]
			public string description;
			public Protocol protocol;
		}

		[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
		public struct Message
		{
			public int version;
			public uint handle;
			[MarshalAs(UnmanagedType.ByValTStr, SizeConst = MAX_DESCRIPTION_SIZE)]
			public string description;
			public MessageType type;
			public uint networkHandle;
			public uint length;
		}

		[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
		public struct MessageJ1939
		{
			public int version;
			public int priority;
			public int pgn;
			public int destination;
			public int source;
			public int j1939TP;
			public uint j1939TPTimeIntervalMs;
		}

		[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
		public struct Signal
		{
			public int version;
			public uint handle;
			[MarshalAs(UnmanagedType.ByValTStr, SizeConst = MAX_DESCRIPTION_SIZE)]
			public string description;
			public SignalType type;
			public SignalRawValueType rawValueType;
			[MarshalAs(UnmanagedType.ByValTStr, SizeConst = MAX_FORMAT_SIZE)]
			public string format;
			public double min;
			public double max;
			[MarshalAs(UnmanagedType.ByValTStr, SizeConst = MAX_DESCRIPTION_SIZE)]
			public string units;
			public int J1939SequentialIntelDecoding;
			public int startBit;
			public int lengthInBits;
			public int bigEndian;
			public int multiplex;
			public double scalingFactor;
			public double scalingOffset;
		}

		[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
		public struct SignalState
		{
			public int version;
			[MarshalAs(UnmanagedType.ByValTStr, SizeConst = MAX_DESCRIPTION_SIZE)]
			public string state;
			public int value;
		}
	}
}
