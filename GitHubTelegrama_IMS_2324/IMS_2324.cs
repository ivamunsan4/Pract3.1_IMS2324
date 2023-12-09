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
            char tipoTelegrama = 'o';
            int numPalabras = 0;
            double coste;
            //Leo el telegrama IMS_2324
            textoTelegrama = txtTelegrama.Text;
            // telegrama urgente? IMS_2324
            if (cbUrgente.Checked)
                tipoTelegrama = 'u';
            //Obtengo el número de palabras que forma el telegrama IMS_2324
            //Primero defino los delimitadores de palabras IMS_2324
            char[] delimitadores = new char[] { ' ', '\r', '\n' };
            //Cuento el número de palabras.
            numPalabras = textoTelegrama.Split(delimitadores, StringSplitOptions.RemoveEmptyEntries).Length;
            //numPalabras = textoTelegrama.Length; IMS_2324
            //Si el telegrama es ordinario IMS_2324
            if (tipoTelegrama == 'o') //IMS_2324
                if (numPalabras <= 10)
                    coste = 2.5;
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