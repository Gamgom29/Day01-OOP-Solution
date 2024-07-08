using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    internal struct Employee
    {
        #region Attributes
        private int id;
        private string? Name;
        private decimal salary;
        private decimal deduction; // [Drived Attribute]
        #endregion

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        // Encapsulation : Separates Data Definiton [Attribute] From its use [Getter,Setter Method , Property]

        #region Appling Encapsulation :Using old Approach [Getter , Setter Method]
        //Getter
        public string GetName()
        {
            return Name;
        }
        //Setter
        public void SetName(string? value) //Private
        {
            Name = value?.Length > 10 ? value.Substring(0, 10) : value; // Control value [Data Validation]
        }
        #endregion

        //Full Property

        #region Appling Encapsulation :Using New Approach [Property]
        public decimal Salary
        {
            get { return salary; }
            set { salary = value; }
        }
        public decimal Deduction
        {
            get { return salary * .2m; }
        }
        #endregion

        // Recommended (Property): Easy To Use Like As Dealing With The Attribute It Self

        #region Automatic Property 
        //  public int Age { get; set; }
        /// Compiler Will Generate Backing Field " Hidden Private Attribute "
        //  private int age;


        //public int Age
        //{
        //    get { return age; }
        //    set { age = value; }
        //} 
        #endregion

        #region Propfull is a Snaippet For The Full Property
        /*private string address;
        public string MyProperty
        {
            get { return address; }
            set { address = value; }
        }*/


        #endregion

        #region prop is a Snaippet For The Automatic Property
        //public string address { get; set; }
        #endregion

        #region Constructor
        public Employee(int _id, string _Name, decimal _salary)
        {
            id = _id;
            Name = _Name;
            salary = _salary;
        }
        #endregion

        #region Methods
        public override string ToString()
        {
            return $" Id: {Id} \n Name: {Name} \n Salary: {salary}";
        }
        #endregion
    }
}