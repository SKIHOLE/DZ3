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
            Pupil pup = new Pupil();
           
        }
        
    }
    class ClassRoom
    {
        Pupil[] pupils;
        public ClassRoom(Pupil[] pupils)
        {
            this.pupils = pupils;
        }
    }
    class Pupil
    {
        public virtual void Study()
        {

        }
        public virtual void Read()
        {


        }
        public virtual void Write()
        {

        }
        public virtual void Relax()
        {

        }
    }
    class ExelentPupil:Pupil
    {
        public override void Study()
        {

        }
        public override void Read()
        {

        }
        public override void Write()
        {

        }
        public override void Relax()
        {

        }
    }
    class GoodPupil : Pupil
    {
        public override void Study()
        {

        }
        public override void Read()
        {

        }
        public override void Write()
        {

        }
        public override void Relax()
        {

        }

    }
    class BadPupil : Pupil
    {
        public override void Study()
        {

        }
        public override void Read()
        {

        }
        public override void Write()
        {

        }
        public override void Relax()
        {

        }

    }
}
