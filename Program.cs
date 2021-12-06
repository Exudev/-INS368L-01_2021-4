using System;

namespace Door
{
   public class Program
    {
        static void Main(string[] args)
        {
            
        }
        public class Door
        {
            public bool IsOpen;
            public bool Islocked;
            public string key;
          public bool Close(Door door)
            {
                return door.IsOpen = false;
            }
            
           public  bool Open(Door door)
            {
                return door.IsOpen = true;
            }
          public   bool CheckStatus(Door door)
            {
                return door.IsOpen;
            }
           public bool Checklocked(Door door)
            {
                return door.Islocked;
            }
        }
    }
}
