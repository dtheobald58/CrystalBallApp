using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CrystalBallApp.Models
{
    public class CrystalBall
    {
        public string getResponse()
        {
            string[] responses = { "Response 1", "Response 2", "Response 3" };
            Random randomNum = new Random();
            var num = randomNum.Next(0, responses.Length);
            return responses[num];
        }

    }
}