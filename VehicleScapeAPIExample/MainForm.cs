using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace VehicleScapeAPIExample
{
	public partial class MainForm : Form
	{
		static MainForm instance = null;

		ListView dragSource = null;
		bool loading = false;

		struct TagMetadata
		{
			public TagMetadata(uint handle, MetadataType type)
			{
				Handle = handle;
				Type = type;
			}

			public enum MetadataType
			{
				DAQ,
				Device,
				Message,
				Signal
			}

			public uint Handle;
			public MetadataType Type;
		}

		public void Log(string str)
		{
			instance.LogTextbox.AppendText(str);
			instance.LogTextbox.AppendText(Environment.NewLine);
		}

		public MainForm()
		{
			InitializeComponent();
			instance = this;
		}

		private void exitToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private void ClearDAQs()
		{
			DAQListView.Items.Clear();
		}

		private void loadDBCToolStripMenuItem_Click(object sender, EventArgs e)
		{
			OpenFileDialog openFileDialog = new OpenFileDialog();

			openFileDialog.Filter = "DBC files (*.dbc)|*.dbc|All files (*.*)|*.*";
			openFileDialog.FilterIndex = 1;
			openFileDialog.RestoreDirectory = true;

			if (openFileDialog.ShowDialog() == DialogResult.OK)
			{
				VehicleScapeAPI.Result result = VehicleScapeInterface.LoadDatabase(openFileDialog.FileName);
				if (result == VehicleScapeAPI.Result.ResultOk)
				{
					Log(openFileDialog.FileName + " loaded successfully.");

					GetDAQs();
					LoadMessagesAndSignals();
					// Detect devices here for the user's convenience
					DetectDevices();
				}
				else
				{
					Log("Failed to load " + openFileDialog.FileName + ".");
					Log("Reason: " + VehicleScapeAPI.ResultToString(result) + ".");
				}
			}
		}

		private void DetectDevices()
		{
			DeviceListView.Items.Clear();
			List<VehicleScapeAPI.Device> devices = VehicleScapeInterface.GetDevices();
			foreach (VehicleScapeAPI.Device device in devices)
			{
				ListViewItem item = DeviceListView.Items.Add(VehicleScapeAPI.DeviceTypeToString(device.deviceType));
				item.Tag = new TagMetadata(device.handle, TagMetadata.MetadataType.Device);
				item.SubItems.Add(device.serialNumber.ToString());
				item.SubItems.Add(device.handle.ToString());
			}
		}

		private void StartDragDrop(ListView source)
		{
			dragSource = source;
			List<ListViewItem> selectedItems = new List<ListViewItem>();
			foreach (ListViewItem item in source.SelectedItems)
			{
				selectedItems.Add(item);
			}
			DoDragDrop(selectedItems, DragDropEffects.All);
		}

		private void AddDragDropItems(ListView receiver, DragEventArgs e)
		{
			if (dragSource == null)
			{
				// User is trying to drag something of the right type but from a different application.
				return;
			}
			if (e.Data.GetDataPresent(typeof(List<ListViewItem>)))
			{
				List<ListViewItem> items = (List<ListViewItem>)e.Data.GetData(typeof(List<ListViewItem>));
				// Get the location that the item(s) were dragged to relative to the receiving ListView's
				// top-left corner.
				Point localPoint = receiver.PointToClient(new Point(e.X, e.Y));
				// The item under the cursor when the mouse was released, if any.
				ListViewItem itemBeingDraggedOnto = receiver.GetItemAt(localPoint.X, localPoint.Y);
				int index = receiver.Items.IndexOf(itemBeingDraggedOnto);
				if (itemBeingDraggedOnto != null)
				{
					Rectangle bounds = itemBeingDraggedOnto.GetBounds(ItemBoundsPortion.Entire);
					// How far the cursor is from the top of the item being dragged onto.
					int relativeY = localPoint.Y - bounds.Y;
					// If the cursor is closer to the bottom of the item than the top...
					if (relativeY > (bounds.Height / 2))
					{
						// ...place the incoming item(s) below the item being dragged onto.
						index++;
						// (Otherwise place the incoming item(s) above).
					}
				}
				if (index < 0)
					index = receiver.Items.Count;
				foreach (ListViewItem item in items)
				{
					receiver.Items.Insert(index, (ListViewItem)item.Clone());
					dragSource.Items.Remove(item);
					// Increment the index so that the next item goes below the item we just placed rather
					// than above it, which would reverse the order of the items.
					index++;
				}
			}
		}

		private void AvailableSignalsListView_DragDrop(object sender, DragEventArgs e)
		{
			AddDragDropItems((ListView)sender, e);
		}

		private void AvailableSignalsListView_DragEnter(object sender, DragEventArgs e)
		{
			if (e.Data.GetDataPresent(typeof(List<ListViewItem>)))
			{
				e.Effect = DragDropEffects.All;
			}
			else
			{
				e.Effect = DragDropEffects.None;
			}
		}

		private void AvailableSignalsListView_ItemDrag(object sender, ItemDragEventArgs e)
		{
			StartDragDrop((ListView)sender);
		}

		private void SelectedSignalsListView_ItemDrag(object sender, ItemDragEventArgs e)
		{
			StartDragDrop((ListView)sender);
		}

		private void SelectedSignalsListView_DragEnter(object sender, DragEventArgs e)
		{
			if (e.Data.GetDataPresent(typeof(List<ListViewItem>)))
			{
				e.Effect = DragDropEffects.All;
			}
			else
			{
				e.Effect = DragDropEffects.None;
			}
		}

		private void SelectedSignalsListView_DragDrop(object sender, DragEventArgs e)
		{
			AddDragDropItems((ListView)sender, e);
		}

		private void MainForm_MouseLeave(object sender, EventArgs e)
		{
			dragSource = null;
		}

		private void MoveAllAvailableToSelected_Click(object sender, EventArgs e)
		{
			foreach (ListViewItem item in AvailableChannelsListView.Items)
			{
				SelectedChannelsListView.Items.Add((ListViewItem)item.Clone());
				AvailableChannelsListView.Items.Remove(item);
			}
		}

		private void MoveAvailableToSelected_Click(object sender, EventArgs e)
		{
			foreach (ListViewItem item in AvailableChannelsListView.SelectedItems)
			{
				SelectedChannelsListView.Items.Add((ListViewItem)item.Clone());
				AvailableChannelsListView.Items.Remove(item);
			}
		}

		private void MoveSelectedToAvailable_Click(object sender, EventArgs e)
		{
			foreach (ListViewItem item in SelectedChannelsListView.SelectedItems)
			{
				AvailableChannelsListView.Items.Add((ListViewItem)item.Clone());
				SelectedChannelsListView.Items.Remove(item);
			}
		}

		private void MoveAllSelectedToAvailable_Click(object sender, EventArgs e)
		{
			foreach (ListViewItem item in SelectedChannelsListView.Items)
			{
				AvailableChannelsListView.Items.Add((ListViewItem)item.Clone());
				SelectedChannelsListView.Items.Remove(item);
			}
		}

		// Call from a TextBox's Validating event. Prevents the user from deselecting
		// the textbox if the textbox contains any non-numeric characters.
		private void ValidateContainsDigitsOnly(object sender, CancelEventArgs e)
		{

			foreach (char c in ((TextBox)sender).Text)
			{
				if (!char.IsDigit(c))
				{
					e.Cancel = true;
					MessageBox.Show("This field must contain a valid whole number.");
					return;
				}
			}
		}

		// Prevent the user from deselecting the textbox if its contents can't be converted
		// to a double.
		private void ValidateContainsValidDouble(object sender, CancelEventArgs e)
		{
			double val;
			if (!double.TryParse(((TextBox)sender).Text, out val))
			{
				e.Cancel = true;
				MessageBox.Show("This field must contain a valid number.");
			}
		}

		private void SleepOnNoBusActivityRadioButton_CheckedChanged(object sender, EventArgs e)
		{
			BusActivityThresholdTextBox.Enabled = SleepOnNoBusActivityRadioButton.Checked;
			UpdateDAQEvent(sender, e);
		}

		private void CollectionNameTextBox_Validating(object sender, CancelEventArgs e)
		{
			if (string.IsNullOrEmpty(((TextBox)sender).Text))
			{
				e.Cancel = true;
				MessageBox.Show("This field must contain a name.");
			}
		}

		double SleepMode {
			get {
				if (NeverGoToSleepRadioButton.Checked)
					return VehicleScapeAPI.NeverGoToSleep;
				else
					return double.Parse(BusActivityThresholdTextBox.Text);
			}
			set {
				if (value < 0)
					NeverGoToSleepRadioButton.Checked = true;
				else
					SleepOnNoBusActivityRadioButton.Checked = true;
			}
		}

		VehicleScapeAPI.WakeupModeType WakeMode {
			get {
				if (WakeNormalRadioButton.Checked)
					return VehicleScapeAPI.WakeupModeType.WakeupModeTypeNormal;
				else
					return VehicleScapeAPI.WakeupModeType.WakeupModeTypeInstant;
			}
			set {
				if (value == VehicleScapeAPI.WakeupModeType.WakeupModeTypeNormal)
					WakeNormalRadioButton.Checked = true;
				else
					WakeInstantRadioButton.Checked = true;
			}
		}

		private void GenerateButton_Click(object sender, EventArgs e)
		{
			if (GetSelectedDAQHandle() == 0 || GetSelectedDeviceHandle() == 0)
			{
				MessageBox.Show("You must select a DAQ and a device to generate a CoreMini.");
				return;
			}
			UpdateDAQ();
			List<uint> messageHandles = new List<uint>();
			List<uint> signalHandles = new List<uint>();

			foreach (ListViewItem item in SelectedChannelsListView.Items)
			{
				TagMetadata metadata = (TagMetadata)item.Tag;
				if (metadata.Type == TagMetadata.MetadataType.Message)
					messageHandles.Add(metadata.Handle);
				else
					signalHandles.Add(metadata.Handle);
			}

			GenerateParameters parameters = new GenerateParameters(
				messageHandles,
				signalHandles,
				CollectionNameTextBox.Text,
				int.Parse(MessageCountTextBox.Text),
				SleepMode,
				WakeMode,
				double.Parse(BusActivityThresholdTextBox.Text),
				RemoteWakeupCheckBox.Checked,
				StartNewFileOnWakeupCheckBox.Checked,
				double.Parse(OverallTimeoutTextBox.Text),
				double.Parse(ConnectionTimeoutTextBox.Text),
				double.Parse(VoltageCutoffTextBox.Text));
			Log("Generating CoreMini.");
			VehicleScapeAPI.Result result = VehicleScapeInterface.Generate(parameters, GetSelectedDAQHandle(), GetSelectedDeviceHandle());
			Log("Result: " + VehicleScapeAPI.ResultToString(result));
		}

		private void UploadButton_Click(object sender, EventArgs e)
		{
			Log("Transferring to device.");
			VehicleScapeAPI.Result result = VehicleScapeInterface.Transfer(GetSelectedDeviceHandle(), ReflashFirmwareCheckbox.Checked);
			Log("Result: " + VehicleScapeAPI.ResultToString(result));
		}

		private void ClearMessagesAndSignals()
		{
			AvailableChannelsListView.Items.Clear();
			SelectedChannelsListView.Items.Clear();
		}

		private void LoadMessagesAndSignals()
		{
			ClearMessagesAndSignals();

			List<VehicleScapeAPI.Message> messages = VehicleScapeInterface.GetMessages();

			int signalCount = 0;
			foreach (VehicleScapeAPI.Message message in messages)
			{
				uint arbID = VehicleScapeInterface.GetMessageArbIDByHandle(message.handle);
				string networkDescription = VehicleScapeInterface.GetNetworkDescriptionByHandle(message.networkHandle);
				string source = networkDescription + " ($" + arbID + ")";

				ListViewItem newItem = AvailableChannelsListView.Items.Add(message.description);
				newItem.Tag = new TagMetadata(message.handle, TagMetadata.MetadataType.Message);
				newItem.SubItems.Add(source);
				newItem.SubItems.Add(networkDescription);
				newItem.SubItems.Add("Message");

				List<VehicleScapeAPI.Signal> signals = VehicleScapeInterface.GetSignals(message.handle);
				foreach (VehicleScapeAPI.Signal signal in signals)
				{
					signalCount++;
					source = networkDescription + " " + message.description + " ($" + arbID + ")";
					ListViewItem signalItem = AvailableChannelsListView.Items.Add(signal.description);
					signalItem.Tag = new TagMetadata(signal.handle, TagMetadata.MetadataType.Signal);
					signalItem.SubItems.Add(source);
					signalItem.SubItems.Add(networkDescription);
					signalItem.SubItems.Add(VehicleScapeAPI.SignalTypeToString(signal.type));
				}
			}
			Log("Retrieved " + signalCount + " signal" + (signalCount != 1 ? "s" : "") + ".");
			Log("Retrieved " + messages.Count + " message" + (messages.Count != 1 ? "s" : "") + ".");
		}

		private uint GetSelectedDAQHandle()
		{
			if (DAQListView.SelectedIndices.Count == 0)
				return 0;
			return ((TagMetadata)DAQListView.Items[DAQListView.SelectedIndices[0]].Tag).Handle;
		}

		private uint GetSelectedDeviceHandle()
		{
			if (DeviceListView.SelectedIndices.Count == 0)
				return 0;
			return ((TagMetadata)DeviceListView.Items[DeviceListView.SelectedIndices[0]].Tag).Handle;
		}

		private VehicleScapeAPI.DAQ GetSelectedDAQ()
		{
			return VehicleScapeInterface.GetDAQByHandle(GetSelectedDAQHandle());
		}

		private VehicleScapeAPI.Device GetSelectedDevice()
		{
			return VehicleScapeInterface.GetDeviceByHandle(GetSelectedDeviceHandle());
		}

		private void DAQListView_SelectedIndexChanged(object sender, EventArgs e)
		{
			LoadDAQ(GetSelectedDAQ());
		}

		private void RefreshButton_Click(object sender, EventArgs e)
		{
			DetectDevices();
			GetDAQs();
		}

		private void DAQListView_DoubleClick(object sender, EventArgs e)
		{
			// Strangely, the listview doesn't allow you to start editing by
			// double-clicking - you have to single-click and then wait.
			// Since that's unintuitive, we implement double-click-to-edit here.
			Point relativeCoordinates = DAQListView.PointToClient(new Point(MousePosition.X, MousePosition.Y));
			ListViewItem item = DAQListView.GetItemAt(relativeCoordinates.X, relativeCoordinates.Y);
			if (item != null)
			{
				item.BeginEdit();
			}
		}

		private void GetDAQs()
		{
			ClearDAQs();
			List<VehicleScapeAPI.DAQ> daqs = VehicleScapeInterface.GetDAQs();
			foreach (VehicleScapeAPI.DAQ daq in daqs)
			{
				ListViewItem item = DAQListView.Items.Add(daq.description);
				item.Tag = new TagMetadata(daq.handle, TagMetadata.MetadataType.DAQ);
			}
		}

		private void UpdateDAQ()
		{
			if (loading)
				return;
			VehicleScapeAPI.DAQ daq = GetSelectedDAQ();
			if (DAQListView.SelectedIndices.Count > 0)
				daq.description = DAQListView.Items[DAQListView.SelectedIndices[0]].Text;
			daq.newFileOnWakeup = Convert.ToInt32(StartNewFileOnWakeupCheckBox.Checked);
			daq.sleepPeriod = NeverGoToSleepRadioButton.Checked ?
				VehicleScapeAPI.NeverGoToSleep :
				double.Parse(BusActivityThresholdTextBox.Text);
			daq.wakeupMode = WakeNormalRadioButton.Checked ?
				VehicleScapeAPI.WakeupModeType.WakeupModeTypeNormal :
				VehicleScapeAPI.WakeupModeType.WakeupModeTypeInstant;
			daq.remoteWakeup = Convert.ToInt32(RemoteWakeupCheckBox.Checked);
			daq.neoVIOverallTimeout = double.Parse(OverallTimeoutTextBox.Text);
			daq.neoVIConnectionTimeout = double.Parse(ConnectionTimeoutTextBox.Text);
			daq.neoVIVoltageCutoff = double.Parse(VoltageCutoffTextBox.Text);
			VehicleScapeInterface.UpdateDAQ(daq);
		}

		private void LoadDAQ(VehicleScapeAPI.DAQ daq)
		{
			loading = true;

			if (DAQListView.SelectedIndices.Count > 0)
				DAQListView.Items[DAQListView.SelectedIndices[0]].Text = daq.description;

			StartNewFileOnWakeupCheckBox.Checked = Convert.ToBoolean(daq.newFileOnWakeup);

			if (daq.sleepPeriod == VehicleScapeAPI.NeverGoToSleep)
				NeverGoToSleepRadioButton.Checked = true;
			else
			{
				SleepOnNoBusActivityRadioButton.Checked = true;
				BusActivityThresholdTextBox.Text = daq.sleepPeriod.ToString();
			}

			if (daq.wakeupMode == VehicleScapeAPI.WakeupModeType.WakeupModeTypeNormal)
				WakeNormalRadioButton.Checked = true;
			else
				WakeInstantRadioButton.Checked = true;

			RemoteWakeupCheckBox.Checked = Convert.ToBoolean(daq.remoteWakeup);
			OverallTimeoutTextBox.Text = daq.neoVIOverallTimeout.ToString();
			ConnectionTimeoutTextBox.Text = daq.neoVIConnectionTimeout.ToString();
			VoltageCutoffTextBox.Text = daq.neoVIVoltageCutoff.ToString();

			loading = false;
		}

		private void UpdateDAQEvent(object sender, EventArgs e)
		{
			UpdateDAQ();
		}

		private void MainTabControl_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (GetSelectedDAQHandle() == 0)
			{
				// Temporarily disable the event so we don't instantly trigger it again,
				// which would generate two message boxes.
				MainTabControl.SelectedIndexChanged -= MainTabControl_SelectedIndexChanged;
				MainTabControl.SelectedIndex = 0;
				MainTabControl.SelectedIndexChanged += MainTabControl_SelectedIndexChanged;
				MessageBox.Show("You must select a DAQ before proceeding.");
			}
		}

		private void AddDAQButton_Click(object sender, EventArgs e)
		{
			VehicleScapeInterface.AddDAQ();
			GetDAQs();
		}
	}
}
