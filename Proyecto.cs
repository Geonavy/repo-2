namespace InterfazXML
{
    public class Proyecto
    {
        public string Nombre {  get; set; }
        public string Fecha { get; set; }

        public Proyecto(string nombre, string fecha)
        {
            Nombre = nombre;
            Fecha = fecha;
        }
    }
}
