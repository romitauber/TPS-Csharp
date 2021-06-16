using System;

//Ejercicio 2

// Se quiere modelar un curso de ComunidadIT
// El curso tendrá un nombre, una cantidad max de alumnos, un profe y un listado de alumnos
// tanto el profe como el alumno se guarda DNI Nombre Apellido Fecha de Nacimiento(lo cambio por edad)
// Profesor guarda tamb los años de experiencia
// Alumno especifica si tiene o no trabajo
// Realizar programa que permita cargar un curso y al final muestre todo el detalle

Curso comunidadIT = new Curso ("Desarrollo en .NET", 35);

Profesor profe1 = new Profesor("Martin", "Comparetto", 35, 10);

Alumno alumn1 = new Alumno("Romina", "Tauber", 28, "Si");

comunidadIT.DatosCurso();


public class Curso {

    public string NombreCurso;
    public short MaxAlumnos;

    public Curso(string nombreCurso, short maxAlumnos)
    {
        NombreCurso = nombreCurso;
        MaxAlumnos = maxAlumnos;
    
    }

    public virtual void DatosCurso() => Console.WriteLine($"El curso {this.NombreCurso} tiene un cupo máximo de {this.MaxAlumnos} alumnos.");
}


public class Integrantes {
    public string Nombre;
    public string Apellido;
    public short Edad;


}

public class Profesor : Integrantes {
    
    public short AñosExperiencia;

    public Profesor(string nombre, string apellido, short edad, short añosExperiencia)
    {
        Nombre = nombre;
        Apellido = apellido;
        Edad = edad;
        AñosExperiencia = añosExperiencia;
    }

}

public class Alumno : Integrantes {

    public string CondicionLaboral;

    public Alumno(string nombre, string apellido, short edad, string condicionLaboral)
    {
        Nombre = nombre;
        Apellido = apellido;
        Edad = edad;
        CondicionLaboral = condicionLaboral;
    }
}


