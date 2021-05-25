using System;
using System.Collections.Generic;

namespace Observer
{
    public class ChatRoom : IObservable<MessageInfo>
    {
        private readonly List<IObserver<MessageInfo>> observers = new();

        public IDisposable Subscribe(IObserver<MessageInfo> observer)
        {
            if (!observers.Contains(observer))
                observers.Add(observer);

            return new Unsubscriber<MessageInfo>(observers, observer);
        }

        public void AddMessage(MessageInfo messageInfo)
        {
            foreach (var observer in observers)
                observer.OnNext(messageInfo);
        }
    }
}
