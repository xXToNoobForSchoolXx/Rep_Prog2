///<summary>
/// Namn: Simon Gottfridsson
/// Klass: SY21
/// Info:
/// Sparar värden för de olika anställda.
/// </summary>
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School
{
    /// <summary>
    /// Employee är en superklass med två variabler liksom två subklasser.
    /// </summary>
    abstract class Employee
    {
        /// <value>
        /// Variabeln Name sparar den anställdes namn.
        /// </value>
        protected string Name { get; set; }
        /// <value>
        /// Variabeln SSN sparar den anställdes personnummer.
        /// </value>
        protected string SSN { get; set; }
        /// <summary>
        /// Konstruktorn för Employee.
        /// </summary>
        /// <param name="name"> Innehåller namn. </param>
        /// <param name="sSN"> Innehåller personnummer. </param>
        public Employee(string name, string sSN)
        {
            Name = name;
            SSN = sSN;
        }

        public abstract string getInfo();
    }
    /// <summary>
    /// Subklassen "Teacher" sparar data för anstälda lära.
    /// Klassen har en extra variabel.
    /// </summary>
    class Teacher : Employee
    {
        /// <value>
        /// Variabeln Subjects sparar lärarens ämnen.
        /// </value>
        private string Subjects { get; set; }
        /// <summary>
        /// Konstruktorn för Teacher.
        /// </summary>
        /// <param name="name"> Innehåller namn. </param>
        /// <param name="sSN"> Innehåller personnummer. </param>
        /// <param name="subjects"> Innehåkker lärarens "lärande" ämnen. </param>
        public Teacher(string name, string sSN, string subjects) : base(name, sSN)
        {
            Subjects = subjects;
        }

        /// <summary>
        /// Metoden ger ut data i consollen.
        /// </summary>
        /// <returns> Alla variabler i subklassen. </returns>
        public override string getInfo()
        {
            return "Namn:" + Name + " Personnummer: " + SSN + " Subjects: " + Subjects;
        }
    }

    /// <summary>
    /// Subklassen "Principal" sparar data för anställda rektorer.
    /// </summary>
    class Principal : Employee
    {
        /// <summary>
        /// Konstruktorn för Principal.
        /// </summary>
        /// <param name="name"> Innehåller namn. </param>
        /// <param name="sSN"> Innehåller personnummer. </param>
        public Principal(string name, string sSN) : base(name, sSN)
        {

        }

        /// <summary>
        /// Metoden ger ut data i consollen.
        /// </summary>
        /// <returns> Alla variabler i subklassen. </returns>
        public override string getInfo()
        {
            return "Namn: " + Name + " Personnummer: " + SSN;
        }
    }
}
