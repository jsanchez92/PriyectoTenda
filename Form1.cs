using System.Data;
using System.Data.SqlClient;
namespace Tienda
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            VerficarConexion();
        }

        void VerficarConexion() {
            try
            {
                SqlConnection Sqlcon = new SqlConnection();
                Sqlcon.ConnectionString = Utils.Connexion.Cn;
                Sqlcon.Open();

                string Query = "select * from producto";

                //  Comando para ejecutar la Query

                SqlCommand cmd = new SqlCommand(Query, Sqlcon);
                cmd.CommandType = CommandType.Text;

                SqlDataAdapter sqldt = new SqlDataAdapter( cmd);
                DataTable dt = new DataTable();
                sqldt.Fill(dt);

                //MessageBox.Show("Conexión exitosa.");
            }
            catch (Exception E)
            {
                MessageBox.Show(E.Message);
            }
            


        }

    }
}
