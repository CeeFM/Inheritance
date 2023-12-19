            public interface IScooter
            {
                void ChargeBattery();
                void CurrentChargePercentage();
                double BatteryKWh { get; }

            }