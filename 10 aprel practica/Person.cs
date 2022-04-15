using System;
using System.Collections.Generic;
using System.Text;

namespace _10_aprel_practica
{
    class Person
    {
        public string Name { get; set; }
        public string SurName { get; set; }
        private int _age;
        public int Age
        {
            get
            {
                return _age;
            }
            set
            {
                if (value > 0 )
                {
                    _age = value;
                }

            }
        }
    }
}
