using System;
using System.Collections.Generic;
using System.Linq;

namespace _05ParkingValidation
{
    class Program
    {
        static void Main(string[] args)
        {
            int numOfCommands = int.Parse(Console.ReadLine());
            var userInfo = new Dictionary<string, string>();
            string userName = "";
            string plate = "";
            for (int i = 0; i < numOfCommands; i++)
            {
                string[] commands = Console.ReadLine()
                                           .Split(' ')
                                           .ToArray();
                userName = commands[1];
                if (commands[0] == "register")
                {
                    plate = commands[2];
                    if (userInfo.ContainsKey(userName))
                    {
                        Console.WriteLine($"ERROR: already registered with plate number {userInfo[userName]}");
                    }
                    else if (!ValidPlate(commands[2]))
                    {
                        Console.WriteLine($"ERROR: invalid license plate {plate}");
                    }
                    else if (userInfo.ContainsValue(plate))
                    {
                        Console.WriteLine($"ERROR: license plate {plate} is busy");
                    }
                    else
                    {
                        Console.WriteLine($"{userName} registered {plate} successfully");
                        userInfo.Add(userName, plate);
                    }
                }
                else if (commands[0] == "unregister")
                {
                    if (!userInfo.ContainsKey(userName))
                    {
                        Console.WriteLine($"ERROR: user {userName} not found");
                    }
                    else
                    {
                        Console.WriteLine($"user {userName} unregistered successfully");
                        userInfo.Remove(userName);
                    }
                }
            }
            foreach (var user in userInfo)
            {
                Console.WriteLine($"{user.Key} => {user.Value}");
            }
        }

        static bool ValidPlate(string plate)
        {
            var checkPlate = plate.ToCharArray();
            if (checkPlate.Length == 8 &&
                checkPlate[0] >= 65 && checkPlate[0] <= 90 &&
                checkPlate[1] >= 65 && checkPlate[1] <= 90 &&
                checkPlate[6] >= 65 && checkPlate[6] <= 90 &&
                checkPlate[7] >= 65 && checkPlate[7] <= 90 &&
                checkPlate[2] >= 48 && checkPlate[2] <= 57 &&
                checkPlate[3] >= 48 && checkPlate[3] <= 57 &&
                checkPlate[4] >= 48 && checkPlate[4] <= 57 &&
                checkPlate[5] >= 48 && checkPlate[5] <= 57)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
