using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass_Poly_Interface_DS_Day5_Demos
{
    class Student
    {
        // property
        // property is a wrapper around priv variables
        // are public
        // they are used so that we can access pri variables outside the class
        // also used for validation
        int rn;
        public int Rn
        {
            get
            {
                return rn;
            }
            set
            {
                rn = value;
            }
        }
        string name;
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
        string batch;
        public string Batch
        {
            get {  return batch; }
        set { batch = value; }
        }
         
        int marks;
        public int Marks
        {
             get
            {
                return marks;
            }
            set
            {
                marks = value;
            }
        }
        public void GetDetails()
        {

        }

        public void DisplayDetails()
        {

        }
    }
}
