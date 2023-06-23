using System.Linq.Expressions;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace controlDeErrores_Garcia
{
    public partial class Form1 : Form
    {
        private string apiURL;
        private HttpClient httpClient;
        public Form1()
        {
            InitializeComponent();
            apiURL = "https://localhost:44326";
            httpClient = new HttpClient();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadingGIF.Visible = false;
        }
        private async Task<string> obtenerSaludo(string nombre)
        {
                using (var respuesta = await httpClient.GetAsync($"{apiURL}/saludos/{nombre}"))
                {
                    var saludo = await respuesta.Content.ReadAsStringAsync();
                    return saludo;
                }           
        }

        private async void BtnIniciar_Click(object sender, EventArgs e)
        {


            LoadingGIF.Visible = true;
            await Esperar();
            string nombre = textBox1.Text;
            try
            {
                string saludo = await obtenerSaludo(nombre);
                MessageBox.Show(saludo);
            }
            catch(HttpRequestException ex)
            {
                MessageBox.Show(ex.Message);
            }
            
            LoadingGIF.Visible = true;
        }
        private async Task Esperar()
        {
            await Task.Delay(5000);
        }
    }
}