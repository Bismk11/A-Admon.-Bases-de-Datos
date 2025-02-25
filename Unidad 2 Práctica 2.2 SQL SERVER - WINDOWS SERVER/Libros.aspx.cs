using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BibliotecaWeb
{
    public partial class Libros : System.Web.UI.Page
    {
        //Método para cargar los libros en el GridView
        private void BindGrid()
        {
            string connString = System.Configuration.ConfigurationManager.ConnectionStrings["ConectarDB"].ConnectionString;
            using (SqlConnection conn = new SqlConnection(connString))
            {
                string query = "SELECT * FROM Libros";
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                System.Data.DataTable dt = new System.Data.DataTable();
                da.Fill(dt);
                gvLibros.DataSource = dt;
                gvLibros.DataBind();
            }
        }

        //Cargar datos cuando la página se carga
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                BindGrid();
            }
        }

        protected void btnRegistrar_Click(object sender, EventArgs e)
        {
            string connString = System.Configuration.ConfigurationManager.ConnectionStrings["ConectarDB"].ConnectionString;
            using (SqlConnection conn = new SqlConnection(connString))
            {
                string query = "INSERT INTO Libros (ISBN, Titulo, NumeroEdicion, AnnoPublicacion, NombreAutores, PaisPublicacion, Sinopsis, Carrera, Materia) " +
                               "VALUES (@ISBN, @Titulo, @NumeroEdicion, @AnnoPublicacion, @NombreAutores, @PaisPublicacion, @Sinopsis, @Carrera, @Materia)";

                SqlCommand cmd = new SqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@ISBN", txtISBN.Text);
                cmd.Parameters.AddWithValue("@Titulo", txtTitulo.Text);
                cmd.Parameters.AddWithValue("@NumeroEdicion", int.Parse(txtNoEdicion.Text));
                cmd.Parameters.AddWithValue("@AnnoPublicacion", int.Parse(txtPublicacion.Text));
                cmd.Parameters.AddWithValue("@NombreAutores", txtAutores.Text);
                cmd.Parameters.AddWithValue("@PaisPublicacion", txtPais.Text);
                cmd.Parameters.AddWithValue("@Sinopsis", txtaSinopsis.Value);
                cmd.Parameters.AddWithValue("@Carrera", txtCarrera.Text);
                cmd.Parameters.AddWithValue("@Materia", txtMateria.Text);

                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();

                BindGrid(); //Actualiza el GridView después de agregar el libro
            }
        }
    }
}