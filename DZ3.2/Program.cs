﻿using System;

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
            Pupil pupil5 = new BadPupil();
            ClassRoom Clas = new ClassRoom(pupil1, pupil2, pupil3,pupil4);
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
        

        public ClassRoom(Pupil pupil1, Pupil pupil2, Pupil pupil3)
        {
            pupils = new Pupil[3];
            pupils[0] = pupil1;
            pupils[1] = pupil2;
            pupils[2] = pupil3;
        }
        public ClassRoom(Pupil pupil1, Pupil pupil2, Pupil pupil3, Pupil pupil4)
        {
            pupils = new Pupil[4];
            pupils[0] = pupil1;
            pupils[1] = pupil2;
            pupils[2] = pupil3;
            pupils[3] = pupil4;
        }
        public ClassRoom(Pupil pupil1, Pupil pupil2, Pupil pupil3, Pupil pupil4, Pupil pupil5)
        {
            pupils = new Pupil[5];
            pupils[0] = pupil1;
            pupils[1] = pupil2;
            pupils[2] = pupil3;
            pupils[3] = pupil4;
            pupils[4] = pupil5;
        }

        public void Study()
        {
            int i = 1;
            foreach (Pupil pupil in pupils)
            { 
                Console.Write($"pupil number {i} : ");
                pupil.Study();
                i++;
            }
        }
        public void Read()
        {
            int i = 1;
            foreach (Pupil pupil in pupils)
            {
                Console.Write($"pupil number {i} : ");
                pupil.Read();
                i++;
            }
        }
        public void Write()
        {
            int i = 1;
            foreach (Pupil pupil in pupils)
            {
                Console.Write($"pupil number {i} : ");
                pupil.Write();
                i++;
            }
        }
        public void Relax()
        {
            int i = 1;
            foreach (Pupil pupil in pupils)
            {
                Console.Write($"pupil number {i} : ");
                pupil.Relax();
                i++;
            }
        }
    }
    class Pupil
    {
        public virtual void Study()
        {
            Console.WriteLine("Studies diligently and thoroughly");
        }
        public virtual void Read()
        {
            Console.WriteLine("Reads a variety of materials and demonstrates excellent comprehension");
        }
        public virtual void Write()
        {
            Console.WriteLine("Writes well-structured, clear, and compelling pieces");
        }
        public virtual void Relax()
        {
            Console.WriteLine("Relaxes in moderation, balancing leisure with academic responsibilities");
        }
    }
    class ExelentPupil : Pupil
    {
        public override void Study()
        {
            Console.WriteLine("Studies diligently and thoroughly");
        }
        public override void Read()
        {
            Console.WriteLine("Reads a variety of materials and demonstrates excellent comprehension");
        }
        public override void Write()
        {
            Console.WriteLine("Writes well-structured, clear, and compelling pieces");
        }
        public override void Relax()
        {
            Console.WriteLine("Relaxes in moderation, balancing leisure with academic responsibilities");
        }
    }
    class GoodPupil : Pupil
    {
        public override void Study()
        {
            Console.WriteLine("Studies consistently and effectively");
        }
        public override void Read()
        {
            Console.WriteLine("Reads regularly and has a good understanding of the material");
        }
        public override void Write()
        {
            Console.WriteLine("Writes competently and clearly");
        }
        public override void Relax()
        {
            Console.WriteLine("Relaxes enough to recharge, but does not let leisure time interfere with studies");
        }
    }
    class BadPupil : Pupil
    {
        public override void Study()
        {
            Console.WriteLine("Has difficulty concentrating and does not study effectively");
        }
        public override void Read()
        {
            Console.WriteLine("Reads little and struggles to understand the material");
        }
        public override void Write()
        {
            Console.WriteLine("Struggles to articulate thoughts and ideas clearly in writing");
        }
        public override void Relax()
        {
            Console.WriteLine("Spends too much time relaxing and neglects academic responsibilities");
        }
    }
}
