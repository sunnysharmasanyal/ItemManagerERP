using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ItemManager.DTO
{
   public  class empObjects
    {
        public string ID { get; set; }
        public string name { get; set; }
       
        public string Address { get; set; }
        public string state { get; set; }
      
        public string Desigination { get; set; }
        
        public string email{ get; set;}
        public string mobilenumber { get; set; }
        public string qualification { get; set; }
                                
        public string password { get; set; } 
        public string username { get; set; }
        public string Admin { get;  set;}
        public string AdminPass { get;  set;}
        public byte[] photo { get; set; }

    }
}
