using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Stack.DTOs.Requests
{
    //Basic Registration Model . 
    public class UpdateEmailModel
    {

        public string AccountID { get; set; }
        public string Email { get; set; }
        public string User_Token { get; set; }
        public DateTime Date { get; set; }


    }
}
