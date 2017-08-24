using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Individual.Exercises.Classes
{
    public class Elevator
    {
        private int currentLevel = 1;
        private int numberOfLevels;
        private bool doorIsOpen;
        private int totalNumberOffloors;
        private int desiredFloor;
        
        public Elevator(int totalNumberOffloors)
        {
            currentLevel = CurrentLevel;
            numberOfLevels = totalNumberOffloors;
            doorIsOpen = DoorIsOpen;
            this.totalNumberOffloors = totalNumberOffloors;
        }
        public int CurrentLevel
        {
            get
            {
                return currentLevel;
            }
        }
        public int NumberOfLevels
        {
            get
            {
                return numberOfLevels;
            }
        }
        public bool DoorIsOpen
        {
            get
            {
                return doorIsOpen;
            }
        }

        public void OpenDoor()
        {
            doorIsOpen = true;       
        }

        public void CloseDoor()
        {
            doorIsOpen = false;
        }

        public void GoUp(int desiredFloor)
        {
            if(doorIsOpen == false && desiredFloor <= totalNumberOffloors && currentLevel < desiredFloor)
            {
                currentLevel = desiredFloor;
            }
        }

        public void GoDown(int desiredFloor)
        {
            if(doorIsOpen == false && desiredFloor >= 1 && currentLevel > desiredFloor)
            {
                currentLevel = desiredFloor;
            }
        }
    }
}

