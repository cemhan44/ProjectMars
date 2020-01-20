using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjectMars.Enums;

namespace ProjectMars
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please Enter The Upper-Right Coordinates of The Plateau as Two Positive Integer (Ex: 5 5): ");
            string urCoordinates = Console.ReadLine();

            Console.WriteLine("Please Enter First Rover's Initial Coordinate as Two Positive Integer and Direction as First Capital Letter (N-orth, S-outh, E-ast, W-est) (Ex: 5 5 N): ");
            string rover1Info = Console.ReadLine();
            Console.WriteLine("Please Enter First Rover's Command as First Capital Letter (L-eft, R-ight, M-ove) (Ex: LRMMMLR:) ");
            string rover1Instructions = Console.ReadLine();

            Console.WriteLine("Please Enter Second Rover's Initial Coordinate as Two Positive Integer and Direction as First Capital Letter (N-orth, S-outh, E-ast, W-est) (Ex: 42 31 N): ");
            string rover2Info = Console.ReadLine();
            Console.WriteLine("Please Enter Second Rover's Command as First Capital Letter (L-eft, R-ight, M-ove) (Ex: LRMMMLR): ");
            string rover2Instructions = Console.ReadLine();

            string[] plateauCoordinates = urCoordinates.Split(' ');
            int plateauCoordinateX = Convert.ToInt32(plateauCoordinates[0]);
            int plateauCoordinateY = Convert.ToInt32(plateauCoordinates[1]);

            string[] rover1InfoStringList = rover1Info.Split(' ');
            MarsRover firstRover = new MarsRover();
            firstRover.RoverName = "Cemhan";
            firstRover.CurrentPosition_CordinaateX = Convert.ToInt32(rover1InfoStringList[0]);
            firstRover.CurrentPosition_CordinaateY = Convert.ToInt32(rover1InfoStringList[1]);
            firstRover.CurrentDirection = CommandToDirection(rover1InfoStringList[2]);

            foreach (var command in rover1Instructions.ToCharArray())
            {
                firstRover.GetInstruction(CommandToInstruction(command.ToString()));
            }
            if (firstRover.CurrentPosition_CordinaateX > plateauCoordinateX)
                firstRover.CurrentPosition_CordinaateX = plateauCoordinateX;

            if (firstRover.CurrentPosition_CordinaateY > plateauCoordinateY)
                firstRover.CurrentPosition_CordinaateY = plateauCoordinateY;

            string[] rover2InfoStringList = rover2Info.Split(' ');
            MarsRover secondRover = new MarsRover();
            secondRover.RoverName = "Eren";
            secondRover.CurrentPosition_CordinaateX = Convert.ToInt32(rover2InfoStringList[0]);
            secondRover.CurrentPosition_CordinaateY = Convert.ToInt32(rover2InfoStringList[1]);
            secondRover.CurrentDirection = CommandToDirection(rover2InfoStringList[2]);

            foreach (var command in rover2Instructions.ToCharArray())
            {
                secondRover.GetInstruction(CommandToInstruction(command.ToString()));
            }
            if (secondRover.CurrentPosition_CordinaateX > plateauCoordinateX)
                secondRover.CurrentPosition_CordinaateX = plateauCoordinateX;

            if (secondRover.CurrentPosition_CordinaateY > plateauCoordinateY)
                secondRover.CurrentPosition_CordinaateY = plateauCoordinateY;

            Console.WriteLine(firstRover.CurrentPosition_CordinaateX + " " + firstRover.CurrentPosition_CordinaateY + " " + firstRover.CurrentDirection.ToString().ToCharArray()[0]);
            Console.WriteLine(secondRover.CurrentPosition_CordinaateX + " " + secondRover.CurrentPosition_CordinaateY + " " + secondRover.CurrentDirection.ToString().ToCharArray()[0]);
            Console.WriteLine("Press ENTER to close Project Mars......");
            String line = Console.ReadLine();

            if (line == "enter")
            {
                System.Environment.Exit(0);
            }


            Direction CommandToDirection(string command)
            {
                if (command == "N")
                    return Direction.North;
                else if (command == "S")
                    return Direction.South;
                else if (command == "W")
                    return Direction.West;
                else if (command == "E")
                    return Direction.East;
                else
                    return Direction.Unknown;
            }
            Instruction CommandToInstruction(string command)
            {
                if (command == "L")
                    return Instruction.L;
                else if (command == "R")
                    return Instruction.R;
                else if (command == "M")
                    return Instruction.M;
                else
                    return Instruction.Unknown;
            }
        }
        
    }

}
