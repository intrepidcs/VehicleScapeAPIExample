using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace VehicleScapeAPIExample
{
	class VehicleScapeInterface
	{
		static bool Initialized = false;
		private static VehicleScapeAPI.Result Initialize()
		{
			VehicleScapeAPI.Result result = VehicleScapeAPI.Init();
			if (result == VehicleScapeAPI.Result.ResultOk)
			{
				Initialized = true;
				// VehicleScape automatically creates a DAQ for us and names it "DAQ 1."
				// We want it named "New DAQ" like any DAQ we create, so we'll change it here.
				VehicleScapeAPI.DAQ initialDAQ = GetDAQs()[0];
				initialDAQ.description = "New DAQ";
				VehicleScapeAPI.SetDAQProperties(ref initialDAQ);
			}
			return result;
		}

		public static VehicleScapeAPI.Result LoadDatabase(string filename)
		{
			VehicleScapeAPI.Result result = Initialize();
			if (result != VehicleScapeAPI.Result.ResultOk && result != VehicleScapeAPI.Result.ResultAlreadyInitialized)
				return result;

			if (result == VehicleScapeAPI.Result.ResultAlreadyInitialized)
				result = VehicleScapeAPI.Result.ResultOk;

			int networkCount = 0;
			result = VehicleScapeAPI.GetNetworks(IntPtr.Zero, ref networkCount);
			if (networkCount <= 0)
				return result;
			VehicleScapeAPI.Network[] networks = new VehicleScapeAPI.Network[networkCount];
			VehicleScapeAPI.GetNetworks(networks, ref networkCount);
			uint networkHandle = networks[0].handle;
			VehicleScapeAPI.Database database = new VehicleScapeAPI.Database();
			result = VehicleScapeAPI.AddDatabase(networkHandle, filename, VehicleScapeAPI.DatabaseType.DatabaseTypeJ1939NoPgnOffset, ref database);
			return result;
		}

		public static List<VehicleScapeAPI.DAQ> GetDAQs()
		{
			List<VehicleScapeAPI.DAQ> daqList = new List<VehicleScapeAPI.DAQ>();
			if (!Initialized)
				return daqList;

			int daqCount = 0;
			VehicleScapeAPI.GetDAQs(IntPtr.Zero, ref daqCount);
			if (daqCount == 0)
				return daqList;
			VehicleScapeAPI.DAQ[] daqs = new VehicleScapeAPI.DAQ[daqCount];
			VehicleScapeAPI.GetDAQs(daqs, ref daqCount);
			daqList.AddRange(daqs);
			return daqList;
		}

		public static List<VehicleScapeAPI.Message> GetMessages()
		{
			List<VehicleScapeAPI.Message> messages = new List<VehicleScapeAPI.Message>();
			if (!Initialized)
				return messages;

			int messageCount = 0;
			VehicleScapeAPI.GetRxMessages(IntPtr.Zero, ref messageCount);
			if (messageCount > 0)
			{
				VehicleScapeAPI.Message[] rxMessages = new VehicleScapeAPI.Message[messageCount];
				VehicleScapeAPI.GetRxMessages(rxMessages, ref messageCount);
				messages.AddRange(rxMessages);
			}

			VehicleScapeAPI.GetDbMessages(IntPtr.Zero, ref messageCount);
			if (messageCount > 0)
			{
				VehicleScapeAPI.Message[] dbMessages = new VehicleScapeAPI.Message[messageCount];
				VehicleScapeAPI.GetDbMessages(dbMessages, ref messageCount);
				messages.AddRange(dbMessages);
			}

			return messages;
		}

		public static List<VehicleScapeAPI.Signal> GetSignals(uint messageHandle)
		{
			List<VehicleScapeAPI.Signal> signals = new List<VehicleScapeAPI.Signal>();

			int signalCount = 0;
			VehicleScapeAPI.GetSignals(messageHandle, IntPtr.Zero, ref signalCount);
			if (signalCount > 0)
			{
				VehicleScapeAPI.Signal[] sigs = new VehicleScapeAPI.Signal[signalCount];
				VehicleScapeAPI.GetSignals(messageHandle, sigs, ref signalCount);
				signals.AddRange(sigs);
			}
			return signals;
		}

		public static string GetNetworkDescriptionByHandle(uint networkHandle)
		{
			VehicleScapeAPI.Network network = new VehicleScapeAPI.Network();
			network.handle = networkHandle;
			VehicleScapeAPI.GetNetworkProperties(ref network);
			return network.description;
		}

		public static uint GetMessageArbIDByHandle(uint arbIDHandle)
		{
			uint arb = 0;
			uint mask = 0;
			VehicleScapeAPI.GetMessageArbId(arbIDHandle, ref arb, ref mask);
			return arb;
		}

		public static List<VehicleScapeAPI.Device> GetDevices()
		{
			List<VehicleScapeAPI.Device> devices = new List<VehicleScapeAPI.Device>();
			VehicleScapeAPI.Result result = Initialize();
			if (result != VehicleScapeAPI.Result.ResultOk && result != VehicleScapeAPI.Result.ResultAlreadyInitialized)
				return devices;

			int deviceCount = 0;
			VehicleScapeAPI.GetDevices(IntPtr.Zero, ref deviceCount);
			if (deviceCount > 0)
			{
				VehicleScapeAPI.Device[] devs = new VehicleScapeAPI.Device[deviceCount];
				VehicleScapeAPI.GetDevices(devs, ref deviceCount);
				devices.AddRange(devs);
			}
			return devices;
		}

		public static VehicleScapeAPI.DAQ GetDAQByHandle(uint handle)
		{
			VehicleScapeAPI.DAQ daq = new VehicleScapeAPI.DAQ();
			if (handle == 0)
				return daq;
			daq.handle = handle;
			VehicleScapeAPI.GetDAQProperties(ref daq);
			return daq;
		}

		public static VehicleScapeAPI.DAQ AddDAQ()
		{
			if (!Initialized)
			{
				if (Initialize() == VehicleScapeAPI.Result.ResultOk)
				{
					VehicleScapeAPI.DAQ initialDAQ = GetDAQs()[0];
					return initialDAQ;
				}
				else
					return new VehicleScapeAPI.DAQ();
			}

			VehicleScapeAPI.DAQ daq = new VehicleScapeAPI.DAQ();
			VehicleScapeAPI.AddDAQ(ref daq);
			daq.description = "New DAQ";
			VehicleScapeAPI.SetDAQProperties(ref daq);
			return daq;
		}

		public static VehicleScapeAPI.Device GetDeviceByHandle(uint handle)
		{
			List<VehicleScapeAPI.Device> devices = GetDevices();
			foreach (VehicleScapeAPI.Device device in devices)
			{
				if (device.handle == handle)
					return device;
			}
			return new VehicleScapeAPI.Device();
		}

		public static void UpdateDAQ(VehicleScapeAPI.DAQ daq)
		{
			if (daq.handle == 0)
				return;
			VehicleScapeAPI.SetDAQProperties(ref daq);
		}

		public static VehicleScapeAPI.Result WriteDAQ(VehicleScapeAPI.DAQ daq)
		{
			return VehicleScapeAPI.SetDAQProperties(ref daq);
		}

		public static List<VehicleScapeAPI.DAQCollection> GetDAQCollections(uint daqHandle)
		{
			List<VehicleScapeAPI.DAQCollection> collections = new List<VehicleScapeAPI.DAQCollection>();
			int colCount = 0;
			VehicleScapeAPI.GetDAQCollections(daqHandle, IntPtr.Zero, ref colCount);
			if (colCount > 0)
			{
				VehicleScapeAPI.DAQCollection[] cols = new VehicleScapeAPI.DAQCollection[colCount];
				VehicleScapeAPI.GetDAQCollections(daqHandle, cols, ref colCount);
				collections.AddRange(cols);
			}
			return collections;
		}

		public static VehicleScapeAPI.Result Generate(GenerateParameters parameters, uint daqHandle, uint deviceHandle)
		{
			if (daqHandle == 0 || deviceHandle == 0)
				return VehicleScapeAPI.Result.ResultInvalidHandle;
			// Set up our DAQ
			VehicleScapeAPI.DAQ daq = GetDAQByHandle(daqHandle);
			VehicleScapeAPI.SetDAQProperties(ref daq);

			// Set up our collection
			List<VehicleScapeAPI.DAQCollection> cols = GetDAQCollections(daqHandle);
			if (cols.Count == 0)
				return VehicleScapeAPI.Result.ResultUnableToSetupForCompile;
			VehicleScapeAPI.DAQCollection col = cols[0];
			col.fileName = parameters.Name;
			col.stopNumMessages.numMessages = parameters.NumberOfMessagesToCollect;
			col.collectionType = VehicleScapeAPI.CollectionType.StartImmediatelyStopNumMessage;
			VehicleScapeAPI.SetDAQCollectionProperties(ref col);

			List<uint> channelHandles = new List<uint>();
			channelHandles.AddRange(parameters.MessageHandles);
			channelHandles.AddRange(parameters.SignalHandles);
			List<VehicleScapeAPI.DAQChannel> channels = new List<VehicleScapeAPI.DAQChannel>();

			// Set up our channels
			foreach (uint handle in channelHandles)
			{
				VehicleScapeAPI.DAQChannel channel = new VehicleScapeAPI.DAQChannel();
				channel.signalHandle = handle;
				VehicleScapeAPI.AddDAQChannel(daqHandle, handle, ref channel);
				VehicleScapeAPI.SetAlwaysCollectDAQChannel(handle);
				channels.Add(channel);
			}

			VehicleScapeAPI.Result retv = VehicleScapeAPI.GenerateCoreMini(daqHandle, deviceHandle);

			// Clear out the channels
			foreach (VehicleScapeAPI.DAQChannel channel in channels)
			{
				VehicleScapeAPI.RemoveDAQChannel(channel.signalHandle);
			}

			return retv;
		}

		public static VehicleScapeAPI.Result Transfer(uint deviceHandle, bool reflash)
		{
			if (deviceHandle == 0)
				return VehicleScapeAPI.Result.ResultInvalidHandle;

			int storageMediaCount = 0;
			VehicleScapeAPI.GetStorageMediumsForDevice(deviceHandle, IntPtr.Zero, ref storageMediaCount);
			if (storageMediaCount < 0)
			{
				return VehicleScapeAPI.Result.ResultInvalidMedium;
			}
			VehicleScapeAPI.MemoryType[] types = new VehicleScapeAPI.MemoryType[storageMediaCount];
			VehicleScapeAPI.GetStorageMediumsForDevice(deviceHandle, types, ref storageMediaCount);
			VehicleScapeAPI.Result result = VehicleScapeAPI.Result.ResultOk;
			if (reflash)
			{
				VehicleScapeAPI.ReflashDevice(deviceHandle);
			}
			if (result != VehicleScapeAPI.Result.ResultOk)
				return result;
			return VehicleScapeAPI.SendCoreMini(deviceHandle, types[0], VehicleScapeAPI.RUNCOREMINI | VehicleScapeAPI.SYNCRTC);
		}
	}
}
