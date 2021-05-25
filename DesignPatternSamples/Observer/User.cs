using System;

namespace Observer
{
    public class User : IObserver<MessageInfo>
    {
        private readonly string name;
        private IDisposable cancellation;
        private ChatRoom currentChatRoom;

        public User(string name)
        {
            this.name = name;
        }

        public void EnterChatRoom(ChatRoom chatRoom)
        {
            currentChatRoom = chatRoom;
            cancellation = chatRoom.Subscribe(this);
        }

        public void SendMessage(string message)
        {
            var messageInfo = new MessageInfo { From = name, Message = message };
            currentChatRoom?.AddMessage(messageInfo);
        }

        public void ExitChatRoom()
        {
            cancellation.Dispose();
            currentChatRoom = null;
        }

        public void OnNext(MessageInfo messageInfo)
        {
            Console.WriteLine($"{name} ===> {messageInfo.From}: {messageInfo.Message}");
        }

        public void OnCompleted()
        {
            throw new NotImplementedException();
        }

        public void OnError(Exception error)
        {
            throw new NotImplementedException();
        }
    }
}
