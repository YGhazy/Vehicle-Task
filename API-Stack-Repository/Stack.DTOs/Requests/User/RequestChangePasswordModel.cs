using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Stack.DTOs.Requests
{
    //Basic Registration Model . 
    public class RequestChangePasswordModel
    {

        public string AccountID { get; set; }

        public DateTime Date { get; set; }


    }
}
