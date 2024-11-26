using System.Data;
using System.Reflection.Metadata;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq; // Necesario para manejar XML...

namespace InterfazXML
{
    public partial class Administrador : Form
    {
        static string file = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "proyectos.xml");

        public Administrador()
        {
            InitializeComponent();

            StartPosition = FormStartPosition.CenterScreen;
            MaximizeBox = false;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;

            if (File.Exists(file))
            {
                UsarXmlReader("Iniciar");
            }
            else
            {
                MessageBox.Show(
                    "El archivo no existe en la ruta especificada: " + file,
                    "Carga Fallida",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        private void UsarXmlReader(string estado)
        {
            if (estado != "Iniciar")
            {

                if (File.Exists(file))
                {
                    XDocument document = XDocument.Load(file);

                    if (estado == "Cargar")
                    {
                        XmlReader xmlReader = XmlReader.Create(file);

                        // Crear una tabla para almacenar los datos...
                        DataTable tabla = new DataTable();

                        tabla.Columns.Add("Nombre", typeof(string));
                        tabla.Columns.Add("Fecha de Creación", typeof(string));

                        // Consultar los elementos <proyecto> del XML...
                        var proyectos = from proyecto in document.Descendants("proyecto")
                                        select new
                                        {
                                            Nombre = proyecto.Attribute("nombre")?.Value,
                                            Fecha = proyecto.Attribute("fecha")?.Value,
                                        };

                        // Llenar tabla con los datos obtenidos del XML...
                        foreach (var proyecto in proyectos)
                        {
                            tabla.Rows.Add(proyecto.Nombre, proyecto.Fecha);
                        }

                        // Asignar la tabla al DataGridView...
                        GridViewArchivo.DataSource = tabla;

                        while (xmlReader.Read())
                        {
                            // Cada nodo representa una etiqueta, en este caso debe ser del tipo nodo XML...
                            if ((xmlReader.NodeType == XmlNodeType.Element) && (xmlReader.Name == "proyecto"))
                            {
                                // HasAttributes es una comprobación si la etiqueta poseee atributos en este caso "nombre".
                                // Los atributos son los que se encuentran de color celeste dentro de las etiquetas azules.
                                if (xmlReader.HasAttributes)
                                {
                                    MessageBox.Show(xmlReader.GetAttribute(
                                        "nombre") + ". " + xmlReader.GetAttribute("fecha"),
                                        "Atributos",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Information
                                    );
                                }
                            }
                        }
                    }
                    else if (estado == "Actualizar")
                    {
                        if (File.Exists(file))
                        {
                            // Obtener la tabla del DataGridView...
                            DataTable tabla = (DataTable)GridViewArchivo.DataSource;

                            // Recorrer todas las filas de la tabla...
                            foreach (DataRow row in tabla.Rows)
                            {
                                // Buscar la etiqueta <proyecto> en el XML que coincida con el nombre...
                                var proyecto = document.Descendants("proyecto")
                                .FirstOrDefault(p => p.Attribute("nombre")?.Value == row["Nombre"].ToString());

                                if (proyecto != null)
                                {
                                    // Solo actualizamos si hay cambios...
                                    if (proyecto.Attribute("nombre")?.Value != row["Nombre"].ToString())
                                    {
                                        proyecto.SetAttributeValue("nombre", row["Nombre"].ToString());
                                    }
                                    if (proyecto.Attribute("fecha")?.Value != row["Fecha de Creación"].ToString())
                                    {
                                        proyecto.SetAttributeValue("fecha", row["Fecha de Creación"].ToString());
                                    }
                                }
                            }

                            // Guardar el XML actualizado...
                            // document.Save(file);

                            MessageBox.Show("XML actualizado con éxito.");
                        }
                    }

                }
                else
                {
                    MessageBox.Show("El archivo XML no se encuentra en la ruta especificada.");
                }
            }
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            UsarXmlReader("Cargar");
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            UsarXmlReader("Actualizar");
        }
    }
}
