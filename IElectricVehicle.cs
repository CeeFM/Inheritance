            public interface IElectricVehicle
            {
                void ChargeBattery();
                void CurrentChargePercentage();
                double BatteryKWh { get; }
            }