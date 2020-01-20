using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjectMars.Enums;

namespace ProjectMars
{
    public class MarsRover
    {
        public string RoverName = string.Empty;

        public MarsRover()
        {
        }

        public void GetInstruction(Instruction instruction)
        {
            if (instruction == Instruction.L)
            {
                if (CurrentDirection == Direction.North)
                {
                    CurrentDirection = Direction.West;
                    return;
                }
                if (CurrentDirection == Direction.South)
                {
                    CurrentDirection = Direction.East;
                    return;
                }
                if (CurrentDirection == Direction.West)
                {
                    CurrentDirection = Direction.South;
                    return;
                }
                if (CurrentDirection == Direction.East)
                {
                    CurrentDirection = Direction.North;
                    return;
                }
            }
            else if (instruction == Instruction.R)
            {
                if (CurrentDirection == Direction.North)
                {
                    CurrentDirection = Direction.East;
                    return;
                }
                if (CurrentDirection == Direction.South)
                {
                    CurrentDirection = Direction.West;
                    return;
                }
                if (CurrentDirection == Direction.West)
                {
                    CurrentDirection = Direction.North;
                    return;
                }
                if (CurrentDirection == Direction.East)
                {
                    CurrentDirection = Direction.South;
                    return;
                }
            }
            else if (instruction == Instruction.M)
            {
                if (CurrentDirection == Direction.North)
                {
                    CurrentPosition_CordinaateY++;
                    return;
                }
                if (CurrentDirection == Direction.South)
                {
                    CurrentPosition_CordinaateY--;
                    return;
                }
                if (CurrentDirection == Direction.West)
                {
                    CurrentPosition_CordinaateX--;
                    return;
                }
                if (CurrentDirection == Direction.East)
                {
                    CurrentPosition_CordinaateX++;
                    return;
                }
            }
            else
            {
                //do nothing
                return;
            }
        }

        private Direction direction;
        private int cordinaateX;
        private int cordinaateY;

        [System.ComponentModel.DefaultValue(0)]
        public int CurrentPosition_CordinaateX
        {
            get { return cordinaateX; }
            set { cordinaateX = value; }
        }
        [System.ComponentModel.DefaultValue(0)]
        public int CurrentPosition_CordinaateY
        {
            get { return cordinaateY; }
            set { cordinaateY = value; }
        }
        [System.ComponentModel.DefaultValue(Direction.North)]
        public Direction CurrentDirection
        {
            get { return direction; }
            set { direction = value; }
        }
    }
}
