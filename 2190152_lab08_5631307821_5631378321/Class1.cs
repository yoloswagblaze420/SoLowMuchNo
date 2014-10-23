using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2190152_lab08_5631307821_5631378321
{
    class Class1
    {
        public string name { get; set; }
        public string gender { get; set; }
        public string height { get; set; }
        public string[] hobbies { get; set; }
        public Boolean[] hobbiesTruth { get; set; }
        public Class1(String name, String gender, String height,String[] hobbies,Boolean[] hobbiesTruth)
        {
            this.name = name;
            this.gender = gender;
            this.height = height;
            this.hobbies = hobbies;
            this.hobbiesTruth = hobbiesTruth;
        }
    }
}
