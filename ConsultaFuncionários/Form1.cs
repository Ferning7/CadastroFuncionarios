namespace ConsultaFuncionários
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            MetodosFuncionarios metodos = new MetodosFuncionarios();
            if(!txtNome.Text.Equals("") && txtSalario.Text.Equals(""))

            metodos.GravarFuncionario();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {

        }
    }
}
