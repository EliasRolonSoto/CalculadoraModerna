using CalcCore.Interfaces;

namespace CalcWinform1
{
    public partial class Form1 : Form
    {
        private ICalc _calc;

        private Queue<Button> botones = new Queue<Button>();

        public Form1(ICalc calc)
        {
            _calc = calc;

            _calc.Procesando += Calc_Procesando_Demo;
            _calc.Termino += Calc_Termino_Demo;

            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {

            var resultado = _calc.Suma(1, 1);

            label1.Text = resultado.ToString();

        }

        private void Calc_Procesando_Demo(object sender, EventArgs e)

        {
            Estado.Text = "procesando....";
        }
        private void Calc_Termino_Demo(object sender, EventArgs e)

        {
            Estado.Text = "Terminó.";
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {

            for (int i = 0; i < 10; i++)
            {

                var b = new Button();
                b.Text = i.ToString();

                b.Location = new Point(i * 40, i * 40);

                panelCalc.Controls.Add(b);

                botones.Enqueue(b);

            }
            var bAdd = new Button();
            bAdd.Text = "+";
        }


        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            Estado.Text = $"Resize! {DateTime.Now.ToLongTimeString()}";
        }



        private void panelCalc_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            if (botones.Count > 0)
            {
                Button btnRemover = botones.Dequeue();

                panelCalc.Controls.Remove(btnRemover);
            }

        }
    }
}