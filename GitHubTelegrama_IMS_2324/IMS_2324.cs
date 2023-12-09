namespace GitHubTelegrama_IMS_2324
{
    public partial class IMS_2324 : Form
    {
        public IMS_2324()
        {
            InitializeComponent();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string textoTelegrama;
            char tipoTelegrama = ' ';
            int numPalabras = 0;
            double coste;
            //Leo el telegrama IMS_2324
            textoTelegrama = txtTelegrama.Text;
            // telegrama urgente? IMS_2324
            if (cbUrgente.Checked)
                tipoTelegrama = 'u';
            //Obtengo el número de palabras que forma el telegrama IMS_2324
            numPalabras = textoTelegrama.Length;
            //Si el telegrama es ordinario IMS_2324
            if (tipoTelegrama == 'o')
                if (numPalabras <= 10)
                    coste = 25;
                else
                    coste = 0.5 * numPalabras;
            else
            //Si el telegrama es urgente IMS_2324
            if (tipoTelegrama == 'u')
                if (numPalabras <= 10)
                    coste = 5;
                else
                    coste = 5 + 0.75 * (numPalabras - 10);
            else
                coste = 0;
            txtPrecio.Text = coste.ToString() + " euros";
        }
    }
}