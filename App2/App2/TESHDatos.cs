using System;
//using SQLite;
using SQLite;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App2
{
    [Table("MisDatos")]
    public class TESHDatos
    {
        int matricula;
        string nombre;
        string apellidos;
        string direccion;
        string telefono;
        string carrera;
        string semestre;
        string correo;
        string github;

        [PrimaryKey,Unique,MaxLength(10)]
        public int Matricula
        {
            get { return matricula; }
            set { matricula = value; }
        }
        [Column("Nombre"),MaxLength(20)]
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        [Column("Apellidos"), MaxLength(40)]
        public string Apellidos
        {
            get { return apellidos; }
            set { apellidos = value; }
        }
        [Column("Direccion"), MaxLength(40)]
        public string Direccion
        {
            get { return direccion; }
            set { direccion = value; }
        }
        [Column("Telefono"), MaxLength(10)]
        public string Telefono
        {
            get { return telefono; }
            set { telefono = value; }
        }
        [Column("Carrera"), MaxLength(10)]
        public string Carrera
        {
            get { return carrera; }
            set { carrera = value; }
        }
        [Column("Semestre"), MaxLength(10)]
        public string Semestre
        {
            get { return semestre; }
            set { semestre = value; }
        }
        [Column("Correo"), MaxLength(10)]
        public string Correo
        {
            get { return correo; }
            set { correo = value; }
        }
        [Column("GitHub"), MaxLength(10)]
        public string Github
        {
            get { return github; }
            set { github = value; }
        }
    }
}

