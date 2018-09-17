/*
© Cutter Systems spol. s r.o., 2018
Author: Petr Kalandra (kalandra@cutter.cz)

Licensed under the Apache License, Version 2.0 (the "License");
you may not use this file except in compliance with the License.
You may obtain a copy of the License at
<http://www.apache.org/licenses/LICENSE-2.0>.
Unless required by applicable law or agreed to in writing, software
distributed under the License is distributed on an "AS IS" BASIS,
WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
See the License for the specific language governing permissions and
limitations under the License.
*/

using Newtonsoft.Json;
using System.Collections.Generic;
using RosSharp.RosBridgeClient.Messages.Standard;

namespace RosSharp.RosBridgeClient.Messages.Sensor
{
	public class BatteryState
	{
		[JsonIgnore]
		public const string RosMessageName = "sensor_msgs/BatteryState";

		// Constants are chosen to match the enums in the linux kernel
		// defined in include/linux/power_supply.h as of version 3.7
		// The one difference is for style reasons the constants are
		// all uppercase not mixed case.
		// Power supply status constants
		public byte POWER_SUPPLY_STATUS_UNKNOWN;

		public byte POWER_SUPPLY_STATUS_CHARGING;

		public byte POWER_SUPPLY_STATUS_DISCHARGING;

		public byte POWER_SUPPLY_STATUS_NOT_CHARGING;

		public byte POWER_SUPPLY_STATUS_FULL;

		// Power supply health constants
		public byte POWER_SUPPLY_HEALTH_UNKNOWN;

		public byte POWER_SUPPLY_HEALTH_GOOD;

		public byte POWER_SUPPLY_HEALTH_OVERHEAT;

		public byte POWER_SUPPLY_HEALTH_DEAD;

		public byte POWER_SUPPLY_HEALTH_OVERVOLTAGE;

		public byte POWER_SUPPLY_HEALTH_UNSPEC_FAILURE;

		public byte POWER_SUPPLY_HEALTH_COLD;

		public byte POWER_SUPPLY_HEALTH_WATCHDOG_TIMER_EXPIRE;

		public byte POWER_SUPPLY_HEALTH_SAFETY_TIMER_EXPIRE;

		// Power supply technology (chemistry) constants
		public byte POWER_SUPPLY_TECHNOLOGY_UNKNOWN;

		public byte POWER_SUPPLY_TECHNOLOGY_NIMH;

		public byte POWER_SUPPLY_TECHNOLOGY_LION;

		public byte POWER_SUPPLY_TECHNOLOGY_LIPO;

		public byte POWER_SUPPLY_TECHNOLOGY_LIFE;

		public byte POWER_SUPPLY_TECHNOLOGY_NICD;

		public byte POWER_SUPPLY_TECHNOLOGY_LIMN;

		public Header header;

		public float voltage;

		public float current;

		public float charge;

		public float capacity;

		public float design_capacity;

		public float percentage;

		public byte power_supply_status;

		public byte power_supply_health;

		public byte power_supply_technology;

		public bool present;

		public List<float> cell_voltage;

		// If individual voltages unknown but number of cells known set each to NaN
		public string location;

		public string serial_number;


		public BatteryState()
		{
			header = new Header();
			present = new bool();
			cell_voltage = new List<float>();
			location = string.Empty;
			serial_number = string.Empty;
		}
	}
}
