using System;

namespace Mini_jeuxTD
{
    
    class Program
    {
        static void Main(string[] args)
        {
            title();
            rules();


            Console.WriteLine("Vous êtes dans une forêt. Aller à l'est ou à l'ouest ?");
            string direction = Console.ReadLine();
            choice1(direction);
            direction = Console.ReadLine();
            choice2(direction);
            direction = Console.ReadLine();
            choice3(direction);



        }

        static void title()
        {
            Console.WriteLine("_________            .___           .__/\\               .__          ");
            Console.WriteLine("\\_   ___ \\  ____   __| _/____     __| _)/___ ___________| |    ____  ");
            Console.WriteLine("/    \\  \\/ /  _ \\/  __| / __ \\   / __ |/ _  \\\\____\\__ \\ | |  _/ __ \\");
            Console.WriteLine("\\     \\___(  <_> ) /_/ \\  ___/  / /_/ ( <_> )  |_> > __\\| |_ \\  ___/");
            Console.WriteLine(" \\______  /\\____/\\____ |\\___  > \\____| \\____/|  __(____ /____/\\___  >");
            Console.WriteLine("        \\/            \\/    \\/       \\/      |__|     \\/          \\/ ");
       
        }

        static void rules()

        {
            Console.WriteLine("La princesse à était enlevée à vous de suivre l'un des deux choix s'opposant a vous pour la retrouver");
        }

        static void choice1(string direction)
        {
            while (direction != "est" || direction != "ouest")
            {
                if (direction == "est")
                {
                    Console.WriteLine("Vous glissé soudainement de la falaise essayant de vous raccrocher en vaint.");
                    Environment.Exit(0);
                }
                else if (direction == "ouest")
                {
                    Console.WriteLine("Vous allez à l'ouest. Génial vous avez trouvée un chateau ! Entré par la porte ou par la fenêtre ?");
                    break;
                }
                else
                {
                    Console.WriteLine("Il vous faut choisir une des directions proposée");
                    direction = Console.ReadLine();
                }
            }
        }

        static void choice2(string direction)
        {
            while (direction != "porte" || direction != "fenêtre")
            {
                if (direction == "porte")
                {
                    Console.WriteLine("Un garde vous a reperez vous mourrez une fois la porte ouverte");
                    Environment.Exit(0);
                }
                else if (direction == "fenêtre")
                {
                    Console.WriteLine("Vous entrez dans le chateau ! Vous êtes dans un couloir. Passer par les escaliers ou la trappe ? ");
                    break;
                }
                else
                {
                    Console.WriteLine("Il vous faut choisir une des directions proposée");
                    direction = Console.ReadLine();
                }
            }
        }
        static void choice3(string direction)
        {
            while (direction != "trappe" || direction != "escalier")
            {
                if (direction == "escalier")
                {
                    Console.WriteLine("Vous descendez des escaliers vous rapprochant pas à pas de votre mort.");
                    Environment.Exit(0);
                }
                else if (direction == "trappe")
                {
                    Console.WriteLine("Vous entrez dans une pieces sombre, au loin une silhouette ce dessine peu à peu vous venez de retrouver la princesse !");
                    break;
                }
                else
                {
                    Console.WriteLine("Il vous faut choisir une des directions proposée");
                    direction = Console.ReadLine();
                }
            }
        }
    }
}
