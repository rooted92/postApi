using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace postApi.Models
{
    public class SayHelloModel
    {
        public string userName {get; set;}//this will ask user input in postman console

        public string lastName {get; set;}//will get last name from user

        public SayHelloModel(){}
    }
}