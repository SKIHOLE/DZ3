using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ3._2
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Pupil pupil1 = new ExelentPupil();
            Pupil pupil2 = new GoodPupil();
            Pupil pupil3 = new GoodPupil();
            Pupil pupil4 = new BadPupil();
            ClassRoom Clas = new ClassRoom(pupil1, pupil2, pupil3, pupil4);
            Clas.Study();
            Clas.Read();
            Clas.Write();
            Clas.Relax();
            Console.ReadKey();
        }
        
    }
    class ClassRoom
    {
         Pupil[] pupils;

        public ClassRoom(params Pupil[] pupils)
        {
            this.pupils = pupils;
        }

        public void Study()
        {
            foreach (Pupil pupil in pupils)
            {
                Console.Write("pupil is: ");
                pupil.Study();
            }
        }
        public void Read()
        {
            foreach (Pupil pupil in pupils)
            {
                Console.Write("pupil is: ");
                pupil.Read();
            }
        }
        public void Write()
        {
            foreach (Pupil pupil in pupils)
            {
                Console.Write("pupil is: ");
                pupil.Write();
            }
        }
        public void Relax()
        {
            foreach (Pupil pupil in pupils)
            {
                Console.Write("pupil is: ");
                pupil.Relax();
            }
        }
    }
    class Pupil
    {
        public virtual void Study()
        {
            Console.WriteLine("yes");
        }
        public virtual void Read()
        {
            Console.WriteLine("yes");
        }
        public virtual void Write()
        {
            Console.WriteLine("yes");
        }
        public virtual void Relax()
        {
            Console.WriteLine("yes");
        }
    }
    class ExelentPupil : Pupil
    {
        public override void Study()
        {
            Console.WriteLine("Study hard");
        }
        public override void Read()
        {
            Console.WriteLine("yes");
        }
        public override void Write()
        {
            Console.WriteLine("yes");
        }
        public override void Relax()
        {
            Console.WriteLine("yes");
        }
    }
    class GoodPupil : Pupil
    {
        public override void Study()
        {
            Console.WriteLine("yes");
        }
        public override void Read()
        {
            Console.WriteLine("yes");
        }
        public override void Write()
        {
            Console.WriteLine("yes");
        }
        public override void Relax()
        {
            Console.WriteLine("yes");
        }

    }
    class BadPupil : Pupil
    {
        public override void Study()
        {
            Console.WriteLine("yes");
        }
        public override void Read()
        {
            Console.WriteLine("yes");
        }
        public override void Write()
        {
            Console.WriteLine("yes");
        }
        public override void Relax()
        {
            Console.WriteLine("yes");
        }

    }
}
