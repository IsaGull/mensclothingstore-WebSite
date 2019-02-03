using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Arbiter
{
    public class SingletonEsmoquin
    {

     List<Articulo> Elemento2 = new List<Articulo>(); //Variable unica singleton!

     private static SingletonEsmoquin instance = null;

     private SingletonEsmoquin()
     {

        // Constructor

     }

     public static SingletonEsmoquin Instance
   {
     get
     {
        if (instance == null)
           instance = new SingletonEsmoquin();
 
        return instance;
     }
   }

     public List<Articulo> GSquedan
     {
         get { return Elemento2; }
         set { Elemento2 = value; }
     }


        


    }
}