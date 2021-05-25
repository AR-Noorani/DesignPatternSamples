using System;

namespace Observer
{
    class Program
    {
        static void Main()
        {
            var room = new ChatRoom();
            var user1 = new User("User-1");
            var user2 = new User("User-2");
            var user3 = new User("User-3");

            user1.EnterChatRoom(room);
            user2.EnterChatRoom(room);
            user3.EnterChatRoom(room);

            user1.SendMessage("Hi!");
            user2.SendMessage("Bye!");
            user2.ExitChatRoom();
            user3.SendMessage("Hello there!");

            Console.ReadKey();
        }
    }
}
