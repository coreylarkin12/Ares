using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Individual.Exercises.Classes
{
    public class Television
    {
//TurnOff() turns off the tv
//TurnOn() besides turning the tv on, also resets the channel to 3 and the volume level to 2
//ChangeChannel(int newChannel) changes the current channel(only if it is on) to the value of newChannel as long as it is between 3 and 18
//ChannelUp() increases the current channel by 1 (only if it is on). If the value goes past 18, then the current channel should be set to 3.
//ChannelDown() decreases the current channel by 1 (only if it is on). If the value goes below 3, then the current channel should be set to 18.
//RaiseVolume() inceases the volume by 1 (only if it is on). The limit is 10
//LowerVolume() decreases the volume by 1 (only if it is on). The limit is 0

        private bool isOn = false;
        private int currentVolume = 2;
        private int currentChannel = 3;

        public void TurnOff()
        {
            isOn = false;
        }

        public void TurnOn()
        {
            isOn = true;
            currentVolume = 2;
            currentChannel = 3;
        }

        public void ChangeChannel(int newChannel)
        {
            if(isOn)
            {
            currentChannel = newChannel;
            }

        }

        public void ChannelUp()
        {
            if (isOn)
            {
                currentChannel += 1;
                if(currentChannel > 18)
                {
                    currentChannel = 3;
                }
            }
        }

        public void ChannelDown()
        {
            if (isOn && currentChannel >= 0)
            {
                currentChannel -= 1;
                if (currentChannel < 3)
                {
                    currentChannel = 18;
                }
            }
        }

        public void RaiseVolume()
        {
            if(isOn && currentVolume < 11)
            {
                    currentVolume += 1;
            }
            
        }

        public void LowerVolume()
        {
            if(isOn && currentVolume > 0)
            {
                currentVolume -= 1;
            }
        }
        public bool IsOn
        {
            get
            {
                return isOn;
            }
        }
        public int CurrentVolume
        {
            get
            {
                return currentVolume;
            }
        }
        public int CurrentChannel
        {
            get
            {
                return currentChannel;
            }
        }
    }
}
        
        


