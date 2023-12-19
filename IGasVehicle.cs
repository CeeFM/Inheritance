            public interface IGasVehicle
            {
                void RefuelTank();
                void CurrentTankPercentage();
                double FuelCapacity { get; }
            }