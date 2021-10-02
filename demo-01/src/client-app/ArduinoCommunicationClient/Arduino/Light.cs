﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArduinoCommunicationClient
{
    public class Light
    {
        private readonly ArduinoController arduinoController;
        private readonly string name;

        private bool state = false;

        public Light(string name, ArduinoController arduinoController)
        {
            this.arduinoController = arduinoController;
            this.name = name;

            this.TurnOff();
        }

        public void TurnOn()
        {
            arduinoController.SendCommand($"{name}1");
            this.state = true;
        }

        public void TurnOff()
        {
            arduinoController.SendCommand($"{name}0");
            this.state = false;
        }

        public void Turn(bool state)
        {
            if(state)
            {
                this.TurnOn();
            }
            else
            {
                TurnOff();
            }
        }

        public void AlternateState()
        {
            if (this.state)
            {
                TurnOff();
            }
            else
            {
                TurnOn();
            }
        }

        public bool IsOn()
        {
            return this.state;
        }
    }
}
