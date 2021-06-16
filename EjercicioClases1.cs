using System;

//Ejercicio 1
// Metodos que tiene que tener: 
// Prestar: aumenta el atributo correspondiente cada vez  que se realiza un
// prestamo de un libro. No se pueden pedir prestados libros si no hay copias disponibles para prestar
// devuelve true si la operacion se realizo correctamente y false si no.
// Devolver: que disminuye el atributo correspondiente cuando se devuelve un libro. No se pueden devolver libros que no hayan sido prestados. Devuelve true si la operacion se realizo
// correctamente y false si no

// To String metodo para mostrar datos de libros, 
// este metodo se hereda de object y debemos modificarlo para adaptarlo a la clase Libro
// escribir programa para probar el funcionamiento de la clase libro

Libro libro1 = new Libro("Harry Potter y el prisionero de Azkaban", "J.K. Rowling", 1, 0);

Console.WriteLine(libro1.NombreLibro());

libro1.Prestar();

Console.WriteLine(libro1.NumeroCopiasDisponibles);
Console.WriteLine(libro1.NumeroCopiasPrestadas);

libro1.Devolver();
Console.WriteLine(libro1.NumeroCopiasDisponibles);
Console.WriteLine(libro1.NumeroCopiasPrestadas);




//ORDEN DENTRO DE CLASE: 1° atributos 2° constructor 3° metodos

public class Libro 
{

    private string TituloLibro;
    private string Autor;
    public short NumeroCopiasDisponibles;
    public short NumeroCopiasPrestadas;
    public Libro (string titulo, string autor, short copiasDisp, short copiasPrest) {

        this.TituloLibro = titulo;
        this.Autor = autor;
        this.NumeroCopiasDisponibles = copiasDisp;
        this.NumeroCopiasPrestadas = copiasPrest;
            
    }
    public string NombreLibro() {
        return $"El libro se llama {this.TituloLibro}";
    }
    
    public void Prestar() 
    {   
        if(this.NumeroCopiasDisponibles > 0) 
        {
            this.NumeroCopiasDisponibles --;
            this.NumeroCopiasPrestadas ++; 
            Console.WriteLine("true");
        } else {
            Console.WriteLine("false");
        }
        
    }
    public void Devolver() 
    {   
        if(this.NumeroCopiasPrestadas > 0) 
        {
            this.NumeroCopiasDisponibles ++;
            this.NumeroCopiasPrestadas --; 
            Console.WriteLine("true");
        } else {
            Console.WriteLine("false");
        }
        
    }

}


