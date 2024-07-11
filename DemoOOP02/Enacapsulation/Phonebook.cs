using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoOOP02.Enacapsulation
{
    internal struct Phonebook
    {
        //Attributes
        private string[] Names;
        private int[] Numbers;
        private int size;

        public int _size
        { get { return size; } }

        //constructor
        public Phonebook(int _size)
        {
            Names = new string[size];
            Numbers = new int[size];
            size = _size;
        }

        //Method to add new person into note
        public void Addperson(int position, int Number, string name)

        {
            if (Names is not null && Numbers is not null)
            {
                if (position < size)
                {
                    Names[position] = name;
                    Numbers[position] = Number;
                }
            }

        }
        public int Getpersonnumber(string name)
        {
            if (Names is not null && Numbers is not null)
            {
                for (int i = 0; i < Names.Length; i++)
                {
                    if (Names[i] == name)
                    {
                        return Numbers[i];
                        ;
                    }

                }

            }
            return -1;
        }

        public void setPersonName(string name, int newnumber)
        {
            if (Names is not null && Numbers is not null)
            {
                for (int i = 0; i < Names.Length; i++)
                {
                    if (Names[i] == name)
                    {
                        //setnumber
                        Numbers[i] = newnumber;
                        break;
                    }

                }
            }
        }
        public int this[string name]
        {
            get
            {
                if (Names is not null && Numbers is not null)
                {
                    for (int i = 0; i < Names.Length; i++)


                    {
                        if (Names[i] == name)
                            return Numbers[i];
                    }
                }
                return -1;
            }
            set
            {
                for (int i = 0; i < Names.Length; i++)
                {
                    if (Names[i] == name)

                    {
                        Numbers[i] = value;

                        break;
                    }

                }
            }
        }
    }
}
