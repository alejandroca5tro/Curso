using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public enum Sexo : int
    {
        Masculino, Femenino
    }

    public class Alumno
    {
        private string name;
        private int semester;
        private int age;
        private Sexo gender;

        public Alumno(string n, int s, int a, Sexo g)
        {
            this.name = n;
            this.semester = s;
            this.age = a;
            this.gender = g;
        }

        public override string ToString()
        {
            return String.Format("{1} {2} {3} {4}", name, semester, age, gender);
        }
    }
}