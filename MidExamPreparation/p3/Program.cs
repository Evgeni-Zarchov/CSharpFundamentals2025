namespace p3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> chat = new List<string>();

            string command;
            while ((command = Console.ReadLine()) != "end")
            {
                string[] action = command.Split(" ", StringSplitOptions.RemoveEmptyEntries);

                switch (action[0])
                {
                    case "Chat":
                        chat.Add(action[1]);
                        break;
                    case "Delete":
                        if (chat.Contains(action[1]))
                        {
                            chat.Remove(action[1]);
                        }
                        break;
                    case "Edit":
                        int index = chat.IndexOf(action[1]);
                        chat.Remove(action[1]);
                        chat.Insert(index, action[2]);
                        break;
                    case "Pin":

                        string searchedPin = action[1];
                        for (int i = 0; i < chat.Count; i++)
                        {
                            string current = chat[i];
                            if (current == searchedPin)
                            {
                                chat.RemoveAt(i);
                                chat.Add(searchedPin);
                            }
                        }

                        break;
                    case "Spam":
                        for (int i = 1; i < action.Length; i++)
                        {
                            chat.Add(action[i]);
                        }
                        break;

                }

            }

            foreach (string mess in chat)
            {
                Console.WriteLine(mess);
            }
        }
    }
}
