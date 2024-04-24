namespace ChatOnline.Data
{
    public class Chat
    {
        public string Id { get; private set; }
        public List<Message> Messages { get; private set; }

        public void SendMessage(Message m)
        {
            Messages.Add(m);
        }
    }
}
