using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleScapeAPIExample
{
	class GenerateParameters
	{
		public GenerateParameters(
			List<uint> messageHandles,
			List<uint> signalHandles,
			string name,
			int numberOfMessagesToCollect,
			double sleepMode,
			VehicleScapeAPI.WakeupModeType wakeMode,
			double busActivitySleepTimeout,
			bool enableRemoteWakeup,
			bool startNewFileOnWakeup,
			double neoVITimeout,
			double connectionTimeout,
			double voltageCutoff)
		{
			MessageHandles = messageHandles;
			SignalHandles = signalHandles;
			NumberOfMessagesToCollect = numberOfMessagesToCollect;
			BusActivitySleepTimeout = busActivitySleepTimeout;
			SleepMode = sleepMode;
			WakeMode = wakeMode;
			EnableRemoteWakeup = enableRemoteWakeup;
			StartNewFileOnWakeup = startNewFileOnWakeup;
			NeoVITimeout = neoVITimeout;
			ConnectionTimeout = connectionTimeout;
			VoltageCutoff = voltageCutoff;
		}

		public List<uint> MessageHandles { get; private set; } // list of VehicleScape handles
		public List<uint> SignalHandles { get; private set; }
		public string Name { get; private set; }
		public int NumberOfMessagesToCollect { get; private set; }
		public double SleepMode { get; private set; }
		public VehicleScapeAPI.WakeupModeType WakeMode { get; private set; }
		public double BusActivitySleepTimeout { get; private set; }
		public bool EnableRemoteWakeup { get; private set; }
		public bool StartNewFileOnWakeup { get; private set; }
		public double NeoVITimeout { get; private set; }
		public double ConnectionTimeout { get; private set; }
		public double VoltageCutoff { get; private set; }
	}
}
