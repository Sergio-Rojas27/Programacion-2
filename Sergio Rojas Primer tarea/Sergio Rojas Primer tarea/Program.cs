using System;

     public class Plataforma
{ //Propiedades de la clase
        public string nombre { get; set; } 
        public string tipo { get; set; }
        public Boolean encendido { get; set; }

  // Constructor
        public Plataforma(string nombre, string tipo, Boolean estado)
        {
            this.nombre = nombre;
            this.tipo = tipo;
            this.encendido = estado;
        }

   //metodos
        public void Encender()
        {
            Console.WriteLine("Encendiendo la " + nombre);
            Console.WriteLine("La " + nombre + " esta encendida");
            encendido = true;
            Console.WriteLine("Encendido es: " + this.encendido);
            Console.WriteLine("");

        }
        public virtual void Detalles()
        {
            Console.WriteLine("Detalles de la plataforma:");
            Console.WriteLine("Nombre: " + this.nombre);
            Console.WriteLine("Tipo: " + this.tipo);
            if (encendido == true)
            Console.WriteLine("La " + this.nombre + " esta encendida");
            else
                Console.WriteLine("La " + this.nombre + " esta apagada");
            Console.WriteLine("");
        }
        
 }
    //Clase hija
    public class ComputadoraPortatil : Plataforma
    {
        public int bateria { get; set; }
        private Boolean pila { get; set; }
    public ComputadoraPortatil(string nombre, string tipo, Boolean estado, int bateria) : base(nombre, tipo, estado)
        {
            this.nombre = nombre;
            this.tipo = tipo;
            this.encendido = estado;
            this.bateria = bateria;
            this.pila = true;
    }
    //Metodo con Polimorfismo
        public override void Detalles()
        {
            Console.WriteLine("Detalles de la plataforma:");
            Console.WriteLine("Nombre: " + this.nombre);
            Console.WriteLine("Tipo: " + this.tipo);
            if (encendido == true)
                Console.WriteLine("La " + this.nombre + " esta encendida");
            else
                Console.WriteLine("La " + this.nombre + " esta apagada");
            Console.WriteLine("Bateria: " + this.bateria + "%");
            Console.WriteLine("");
        }
    //Metodo propio
        public void setpilaremove(Boolean pila)
    {
        this.pila = false;
            Console.WriteLine("La computadora portatil ya no posee una bateria");
            Console.WriteLine("Tiene una Bateria: " + this.pila);
            Console.WriteLine("");
    }
        public void setpilaput()
    {   this.pila = true;
            Console.WriteLine("La La computadora portatil ahora posee una bateria");
            Console.WriteLine("Tiene una Bateria: " + this.pila);
            Console.WriteLine("");
        
    }
}
    //Clase hija
    public class Consola : Plataforma
    {
        public Consola(string nombre, string tipo, Boolean estado) : base(nombre, tipo, estado)
        {
            this.nombre = nombre;
            this.tipo = tipo;
            this.encendido = estado;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {

            ComputadoraPortatil computadora1 = new ComputadoraPortatil("Acer Aspire", "Laptop", false, 100);
            computadora1.Detalles();

            Consola consola1 = new Consola("Playstation 4", "Consola de Sobremesa", false);
            consola1.Detalles();

            Console.WriteLine("Deseas encender la computadora portatil? (s/n)");
            string respuesta = Console.ReadLine();
            if (respuesta == "s")
            {
                computadora1.Encender();
            }
            else
            {
                Console.WriteLine("La computadora portatil sigue apagada");
                Console.WriteLine("");
            }
            Console.WriteLine("Deseas encender la consola? (s/n)");
            respuesta = Console.ReadLine();
            if (respuesta == "s")
            {
                consola1.Encender();
            }
            else
            {
                Console.WriteLine("La consola sigue apagada");
                Console.WriteLine("");
            }
            Console.WriteLine("Deseas sacarle la bateria a la laptop? (s/n)");
            respuesta = Console.ReadLine();
            if (respuesta == "s")
            {
                computadora1.setpilaremove(true);
            Console.WriteLine("Deseas ponerle la bateria a la laptop? (s/n)");
            respuesta = Console.ReadLine();
            if (respuesta == "s")
            {
                computadora1.setpilaput();
            }
            else
            {
                Console.WriteLine("La laptop sigue sin su bateria");
                Console.WriteLine("Tiene una Bateria");
                Console.WriteLine("");
            }
        }
            else
            {
                Console.WriteLine("La laptop sigue con su bateria");
                Console.WriteLine("Tiene una Bateria");
                Console.WriteLine("");
            }
        }
    }


