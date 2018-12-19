using System;
using System.Collections.Generic;
using System.Text;

//project name
namespace AppDevProject2018.Model
{
    //page name
   public class Token
    {
        //get & set Id
        public int Id { get; set; }
        //get & set Id access_token
        public string access_token { get; set; }
        //get & set Id error_description
        public string error_description{ get; set; }
        //get & set Id expire_date
        public DateTime expire_date { get; set; }
        //get & set username
        public string username { get; set; }

        public Token() { }
        

    }
    
}
