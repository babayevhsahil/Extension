using Core.Constans;
using Core.Etities;
using Core.Helpers;
using DataAcces.Implementations;

namespace CodeAccademy
{
    public class Program
    {
        static void Main()
        {
            GroupRepository _groupRepository = new GroupRepository();

            ConsoleHelper.WriteTextWithColor(ConsoleColor.Green, "Welcome");
            Console.WriteLine("---");

            while (true)
            {
                ConsoleHelper.WriteTextWithColor(ConsoleColor.Yellow, "1 - Create Group");
                ConsoleHelper.WriteTextWithColor(ConsoleColor.Yellow, "2 - Update Group");
                ConsoleHelper.WriteTextWithColor(ConsoleColor.Yellow, "3 - Delete Group");
                ConsoleHelper.WriteTextWithColor(ConsoleColor.Yellow, "4 - All Group");
                ConsoleHelper.WriteTextWithColor(ConsoleColor.Yellow, "5 - Get Group by name");
                ConsoleHelper.WriteTextWithColor(ConsoleColor.Yellow, "0 - Exit");
                Console.WriteLine("---");
                ConsoleHelper.WriteTextWithColor(ConsoleColor.Gray, "Select Option");
                string number = Console.ReadLine();

                int selectedNumber;
                bool result = int.TryParse(number, out selectedNumber);
                if (result)
                {
                    if (selectedNumber >= 0 && selectedNumber <= 5)
                    {
                        switch (selectedNumber)
                        {
                            #region CreateGroup
                            case (int)Options.CreateGroup:
                                ConsoleHelper.WriteTextWithColor(ConsoleColor.Magenta, "Enter Group Name:");
                                string name = Console.ReadLine();
                            maxSize: ConsoleHelper.WriteTextWithColor(ConsoleColor.Magenta, "Enter Group Max Size:");
                                string size = Console.ReadLine();
                                int maxSize;
                                result = int.TryParse(size, out maxSize);
                                if (result)
                                {
                                    Group group = new Group
                                    {
                                        Name = name,
                                        MaxSize = maxSize,
                                    };
                                    var createdGroup = _groupRepository.Create(group);
                                    ConsoleHelper.WriteTextWithColor(ConsoleColor.Green, $"{createdGroup.Name} is succcessfully created with max size - {createdGroup.MaxSize}");
                                    goto maxSize;
                                }
                                else
                                {
                                    ConsoleHelper.WriteTextWithColor(ConsoleColor.Red, "Please,Enter correct group max size:");
                                }
                                break;
                            #endregion
                            case (int)Options.UpdateGroup:
                                break;
                            case (int)Options.DeleteGroup:
                                break;
                            case (int)Options.AllGroup:
                                var groups = _groupRepository.GetAll();
                                ConsoleHelper.WriteTextWithColor(ConsoleColor.DarkBlue, "All Groups");
                                foreach (var group in groups)
                                {
                                    Console.WriteLine($"Name:{group.Name}, Max Size{group.MaxSize} ");
                                }
                                break;
                            case (int)Options.GetGroupByName:
                                break;
                            case (int)Options.Exit:
                                ConsoleHelper.WriteTextWithColor(ConsoleColor.Green, "Thank for using application");
                                break;
                        }
                    }
                    else
                    {
                        ConsoleHelper.WriteTextWithColor(ConsoleColor.Red, "Please Enter Correct Number");
                    }
                }

            }



        }
    }
}