public class TipoLicencia
{
    public string Tipo { get; set; }
    public string Descripcion { get; set; }

    public TipoLicencia(string tipo, string descripcion)
    {
        Tipo = tipo;
        Descripcion = descripcion;
    }
}


