using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventureStory
{
    class Program
    {
        static void Main(string[] args)
        {
            Program Start = new Program();
            Start.StartAdventure(); 
            }
        public void StartAdventure()
        {
            Program Start = new Program();
            Console.Write("Welcome to the choose your own adventure game where everything is made up and the points don't matter. \n You have landed on an island with nothing but the clothes on your back and 99 others. \n There can only be one survivor. Find what you can use to survive by any means neccessary. \n You have landed somewhere in the center of the island, fighting has broke out to the East and West. \n Do you want to go 'North' to Roz or 'South' to Pochinki?");
            string firstchoice = Console.ReadLine();

            switch (firstchoice)
            {

                case "North":
                    Console.WriteLine("Good choice, great loot and not too much competition to fight off right away.");
                    Start.NorthPath();
                    break;
                case "South":
                    Console.WriteLine("Get ready to fight with the first things you find!");
                    Start.SouthPath();                   
                    break;
            }
        }
        public void NorthPath()
        {
            Program Start = new Program();
            Console.Write("You've made it to Rozhok and have armed yourself with a 1911. You found a scar on the second story of the first building you went into as well. \n Do you want to keep looting, 'Yes' or 'No'?");
            string NorthPath = Console.ReadLine();

            switch (NorthPath)
            {

                case "Yes":
                    Console.WriteLine("Smart choice, you need to be armed better than that to survive!");
                    Start.NorthPath2();
                    break;
                case "No":
                    Console.WriteLine("Camping is lame, you will be out-gunned. You are spotted leaving the building and shot. Restart the game.");
                    break;
            }
        }
        public void NorthPath2()
        {
            Program Start = new Program();
            Console.Write("You continue to loot and lucky you, have found a 4x scope for your scar and a suppressor. \n Do you want to look for a 'fight' or continue to 'loot' for medkits?");
            string NorthPath3 = Console.ReadLine();

            switch (NorthPath3)
            {

                case "fight":
                    Console.WriteLine("You spot someone trying to leave Roz on thier way to a vehicle, with your 4x scope and silenced shots, they are no match for you.");
                    Start.NorthPath4();
                    break;
                case "loot":
                    Console.WriteLine("You've spent too much time minding your own business and have been killed running to a new building to loot. Restart the game.");
                    break;
            }
        }
        public void NorthPath4()
        {
            Program Start = new Program();
            Console.Write("Looting thier body you found medkits and boosts. You are well equiped to fight for the win. \n There is a storm and the water levels rise to make the island much smaller. \n Do you want to 'run' to the middle or 'camp' the outter rim to kill anyone on thier way?");
            string NorthPath4 = Console.ReadLine();

            switch (NorthPath4)
            {

                case "run":
                    Console.WriteLine("As the island gets smaller there isn't many people that are still alive. \n The water level continues to rise and you have eyes on the few people that are left");
                    Start.NorthPath5();
                    break;
                case "camp":
                    Console.WriteLine("On the outter edge of the island you are trapped between survivors spotting you and everyone else trying to stay on land. /n You can't fight both fronts and are picked off. Restart the game.");
                    break;
            }
        }
        public void NorthPath5()
        {
            Program Start = new Program();
            Console.Write("Looting thier body you found medkits and boosts. You are well equiped to fight for the win. \n There is a storm and the water levels rise to make the island much smaller. \n Do you want to 'run' to the middle or 'camp' the outter rim to kill anyone on thier way?");
            string NorthPath5 = Console.ReadLine();

            switch (NorthPath5)
            {

                case "run":
                    Console.WriteLine("As the island gets smaller there isn't many people that are still alive. \n The water level continues to rise and you have eyes on the few people that are left");
                    Start.NorthPath6();
                    break;
                case "camp":
                    Console.WriteLine("On the outter edge of the island you are trapped between survivors spotting you and everyone else trying to stay on land. /n You can't fight both fronts and are picked off. Restart the game.");
                    break;
            }
        }
        public void NorthPath6()
        {
            Program Start = new Program();
            Console.Write("Watching the fighting unfold in front of you there are only 2 other people left. Do you want to 'fight', or 'wait' it out?");
            string NorthPath6 = Console.ReadLine();

            switch (NorthPath6)
            {

                case "fight":
                    Console.WriteLine("Taking on two people at once in close quarters isn't smart, you throw smoke near one as you shoot the other. \n Your plan worked, the smoke clears and you already knew where the last person was. \n Taking him out was easy, YOU WIN!");
                    Start.NorthPath4();
                    break;
                case "wait":
                    Console.WriteLine("You had the drop on both of the last remaining people and you chose to wait? They spot you once settled in and you spend eternity regretting your decision. Don't restart the game.");
                    break;
            }
        }
        public void SouthPath()
        {
            Program Start = new Program();
            Console.Write("Welcome to Pochinki, almost as bloody as the prison. \n You are lucky enough to find a P92 with 15 rounds of ammo. You hear people all around the city. \n Do you try to 'kill' the first person you can hear, or 'loot' the next building?");
            string SouthPath = Console.ReadLine();

            switch (SouthPath)
            {

                case "kill":
                    Console.WriteLine("You rush the person in the next building and take them by surprise killing them by unloading your entire clip into them. \n You loot thier body and find a med kit, UMP, and more ammo. Well worth it.");
                    Start.NorthPath4();
                    break;
                case "loot":
                    Console.WriteLine("Probably the right decision to better equip yourself, but there is just too many people in Pochinki. \n Two people both fire at you on the way to the next building. Better restart the game.");
                    break;
            }
        }


















    }
}
