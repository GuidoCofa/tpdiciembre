public class Torneos{
    public int idTorneo {get; set;}
    public int idEquipo {get; set;}
    public string NombreTorneo {get; set;}

    public Torneos(){}

 public Torneos(int IdTorneo, int IdEquipo, string nombreTorneo){
        idTorneo = IdTorneo;
        idEquipo = IdEquipo;
        NombreTorneo = nombreTorneo;

    }

}