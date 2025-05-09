using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio_04
{
    internal class TemperatureSensor
    {
        public event EventHandler<string> temperatureExceeded;
        private double _temperature;

        public void SetTemperature(double temperature)
        {
            _temperature = temperature;
            if (_temperature > 100)
            {
                OnTemperatureExceeded($"ALERTA! Temperatura excedeu o limite: {_temperature}");
            }
        }

        public void OnTemperatureExceeded(string message)
        {
            temperatureExceeded?.Invoke(this, message);
        }
    }

}
