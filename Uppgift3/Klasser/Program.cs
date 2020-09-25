using System;
using System.Collections.Generic;
using System.Dynamic;

namespace Klasser
{
    class Program
    {
        /// <summary>
        /// Se instruktionenr i Uppgift.txt
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            List<Bil> bilar = new List<Bil>();

            Bil BMW = new Bil("BMW Z3");
            BMW.Registreringsnummer = "KRJ 137";
            BMW.Vikt = 100;
            BMW.Registreringstid = DateTime.Now;
            BMW.Elbil = true;
            bilar.Add(BMW);

            Bil Corvette = new Bil("Corvette Z06");
            Corvette.Registreringsnummer = "AVF 539";
            Corvette.Vikt = 200;
            Corvette.Registreringstid = DateTime.Now;
            Corvette.Elbil = false;
            bilar.Add(Corvette);

            Bil Ford = new Bil("Ford Mustang");
            Ford.Registreringsnummer = "NFS 201";
            Ford.Vikt = 250;
            Ford.Registreringstid = DateTime.Now;
            Ford.Elbil = false;
            bilar.Add(Ford);

            Bil Porsche = new Bil("Porsche Electric");
            Porsche.Registreringsnummer = "VPL 444";
            Porsche.Vikt = 95;
            Porsche.Registreringstid = DateTime.Now;
            Porsche.Elbil = true;
            bilar.Add(Porsche);

            foreach (Bil item in bilar)
            {
                Console.WriteLine("Model: " + item.Model);
                Console.WriteLine("Vikt: " + item.Vikt);
                if(item.Elbil)
                {
                    Console.WriteLine("Detta är en elbil!");
                }
                Console.WriteLine("Registreringsnummer: " + item.Registreringsnummer);
                Console.WriteLine("Registreringstid: " + item.Registreringstid + "\n");
            }
        }
    }

    public class Bil
    {
        public string Model { get; set; }

        public Bil(string model)
        {
            Model = model;
        }
        public string Registreringsnummer { get; set; }
        public int Vikt { get; set; }
        public bool Elbil { get; set; }
        public DateTime Registreringstid { get; set; }


    }
}