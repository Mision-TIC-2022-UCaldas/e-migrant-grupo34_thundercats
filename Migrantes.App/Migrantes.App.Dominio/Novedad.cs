using System;
namespace Migrantes.App.Dominio
{
    public class Novedad
    {
        public int Id { get; set; }
        public int DiasActiva { get; set; }
        public DateTime FechaNovedad { get; set; }
        public string TextoExplicativo { get; set; }
        public bool EstaActiva { get; set; }
    }
}
