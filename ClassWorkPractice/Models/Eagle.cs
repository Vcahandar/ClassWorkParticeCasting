using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassWorkPractice.Models
{
    internal class Eagle:Bird
    {
        public string speed { get; set; }

        public override void Sound()
        {
            Console.WriteLine("Eagle Sound");
        }
    }
}
