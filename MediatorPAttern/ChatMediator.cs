using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorPAttern
{
    public class ChatMediator : IChatMediator
    {
        List<IUser> _users;


        public ChatMediator()
        {
            _users= new List<IUser>();
        }

        public void AddUser(IUser user)
        {
            _users.Add(user);
        }

        public void SendMessage(string message,IUser sender)
        {

            foreach (var user in _users)
            {
                //gonderici kendi mesajını almasin
                if (user != sender)
                {
                    user.ReceiveMessage(message);
                }
            }

        }
    }
}
