using System;

namespace ZurroService.Models
{
    public class ZUser
    {
        public int Id 
        { 
            get;
            set;
        }

        public string Name 
        { 
            get; 
            set;
        }

        public DateTime Birthdate 
        { 
            get; 
            set;
        }

        public bool Active 
        { 
            get; 
            set;
        }
    }
}
