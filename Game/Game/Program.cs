using System;

namespace Game
{
    class Program
    {
        static Game_Progress game = Game_Progress.GetInstance();
        static void Main(string[] args)
        {
            Console.WriteLine(


"MMMMMMMM               MMMMMMMM                                                                                                         \n" +
"M:::::::M             M:::::::M                                                                                                    \n" +
"M::::::::M           M::::::::M                                                                                                    \n" +
"M:::::::::M         M:::::::::M                                                                                                    \n" +
"M::::::::::M       M::::::::::M    eeeeeeeeeeee    rrrrr   rrrrrrrrr       cccccccccccccccc    eeeeeeeeeeee    rrrrr   rrrrrrrrr   \n" +
"M:::::::::::M     M:::::::::::M  ee::::::::::::ee  r::::rrr:::::::::r    cc:::::::::::::::c  ee::::::::::::ee  r::::rrr:::::::::r  \n" +
"M:::::::M::::M   M::::M:::::::M e::::::eeeee:::::eer:::::::::::::::::r  c:::::::::::::::::c e::::::eeeee:::::eer:::::::::::::::::r \n" +
"M::::::M M::::M M::::M M::::::Me::::::e     e:::::err::::::rrrrr::::::rc:::::::cccccc:::::ce::::::e     e:::::err::::::rrrrr::::::r\n" +
"M::::::M  M::::M::::M  M::::::Me:::::::eeeee::::::e r:::::r     r:::::rc::::::c     ccccccce:::::::eeeee::::::e r:::::r     r:::::r\n" +
"M::::::M   M:::::::M   M::::::Me:::::::::::::::::e  r:::::r     rrrrrrrc:::::c             e:::::::::::::::::e  r:::::r     rrrrrrr\n" +
"M::::::M   M:::::::M   M::::::Me:::::::::::::::::e  r:::::r     rrrrrrrc:::::c             e:::::::::::::::::e  r:::::r     rrrrrrr\n" +
"M::::::M     MMMMM     M::::::Me:::::::e            r:::::r            c::::::c     ccccccce:::::::e            r:::::r            \n" +
"M::::::M               M::::::Me::::::::e           r:::::r            c:::::::cccccc:::::ce::::::::e           r:::::r            \n" +
"M::::::M               M::::::M e::::::::eeeeeeee   r:::::r             c:::::::::::::::::c e::::::::eeeeeeee   r:::::r            \n" +
"M::::::M               M::::::M  ee:::::::::::::e   r:::::r              cc:::::::::::::::c  ee:::::::::::::e   r:::::r            \n" +
"MMMMMMMM               MMMMMMMM    eeeeeeeeeeeeee   rrrrrrr                cccccccccccccccc    eeeeeeeeeeeeee   rrrrrrr            \n\n");


            wait();

            game.startGame();
            
        }

        public static void wait()
        {
            Console.WriteLine("Press key to start...");
            Console.ReadKey();
            Console.Clear();
        }
    }
}
