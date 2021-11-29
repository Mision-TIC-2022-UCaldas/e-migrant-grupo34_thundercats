namespace Migrantes.App.Dominio{

    public enum Rol {
        Migrante,
        Entidad,
        Admin
    }

    public class Usuario{

        public int Id {get;set;}
        public string Username {get;set;}
        public string Password {get;set;}
        public Rol Rol {get;set;}
        public Persona Persona { get; set; }
        public bool EstaActivo{get;set;}
    }
}
