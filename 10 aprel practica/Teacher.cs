using System;
using System.Collections.Generic;
using System.Text;

namespace _10_aprel_practica
{
    class Teacher : Person
    {
        private static int _id;
        private  int _experience;
        public int Experience
        {
            get
            {
                return _experience;
            }
            set
            {
                if (value >= 1 && value <= 80)
                {
                    _experience = value;
                }

            }

        }
        public int Id { get; }
        public Teacher()
        {
            _id++;
            Id = _id;
        }

    }
}
