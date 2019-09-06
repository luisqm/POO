using System;
using System.Collections.Generic;

// los metodos deben estar dentro de las clases

namespace bici
{
     class Auto
     {
         private string marca;
        
         private int año;
         private string modelo;

         public void setMarca(string m)
         {
             marca=m;

         }
         public String getMarca()
             {
                return marca;
             }

             public void setModelo(string m)
         {
             modelo=m;

         }
         public String getModelo()
             {
                return modelo;
             }

              public void setAño(int a)
         {
             año=a;

         }
         public int getAño()
             {
                return año;
             }

             //Constructor
             public Auto (string m, int a, string mod ) //No tienen que estar en orden a fuerzas
             {
                 this.marca=m;
                 this.año=a;
                 this.modelo=mod;
             }

            public Auto () 
             {
                 año=2020; //por default
             }
             //dos metodos que se llaman igual=sobrecarga de metodos

             public void imprime ()
             {
                 
                 Console.WriteLine(marca+" " + año+" "+ modelo+".");
             }

         
     }
    class Program
    {
        static void Main(string[] args)
        {
            Auto auto = new Auto();
            Auto auto1 = new Auto("Toyota", 2019, "B200");
            
            auto.setMarca("Ford");
            auto.setAño(2019);
             auto.setModelo("B100");
            auto1.setMarca("Toyota");
            auto1.setAño(2019);
             auto1.setModelo("B200");
             auto.imprime();
             auto1.imprime(); 
           
           // Console.WriteLine(auto.getMarca());
            //Console.WriteLine(auto.getModelo());
            //Console.WriteLine(auto1.getMarca()+ auto1.getModelo()+ auto1.getAño()+".");

        }
    }
}
