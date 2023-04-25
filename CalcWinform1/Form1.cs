using CalcCore.Interfaces;

namespace CalcWinform1
{
    public partial class Form1 : Form
    {
        private ICalc _calc;

        private Queue<Button> botones = new Queue<Button>();

        private Queue<Button> op = new Queue<Button>();

        public Form1(ICalc calc)
        {
            _calc = calc;

            _calc.Procesando += Calc_Procesando_Demo;
            _calc.Termino += Calc_Termino_Demo;

            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {

            var resultado = _calc.Suma(8, 4);

            labelResul.Text = resultado.ToString();

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

                b.Location = new Point(i, i * 40);

                panelCalc.Controls.Add(b);

                botones.Enqueue(b);

            }



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

        private void btnRemoveOps_Click(object sender, EventArgs e)
        {
            if (op.Count > 0)
            {
                Button btnRemoveOps = op.Dequeue();

                panelCalc.Controls.Remove(btnRemoveOps);
            }
        }

        private void btnGenOp_Click(object sender, EventArgs e)
        {
            var bSuma = new Button();
            bSuma.Text = "+";
            bSuma.Location = new Point(80, 60);
            panelCalc.Controls.Add(bSuma);

            var bResta = new Button();
            bResta.Text = "-";
            bResta.Location = new Point(80, 40);
            panelCalc.Controls.Add(bResta);

            var bMulti = new Button();
            bMulti.Text = "*";
            bMulti.Location = new Point(80, 20);
            panelCalc.Controls.Add(bMulti);

            var bDiv = new Button();
            bDiv.Text = "/";
            bDiv.Location = new Point(80, 0);
            panelCalc.Controls.Add(bDiv);


            op.Enqueue(bSuma);
            op.Enqueue(bResta);
            op.Enqueue(bMulti);
            op.Enqueue(bDiv);

        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            var resultado = _calc.Div(8, 4);

            labelResul.Text = resultado.ToString();
        }

        private void btnResta_Click(object sender, EventArgs e)
        {
            var resultado = _calc.Resta(8, 4);

            labelResul.Text = resultado.ToString();
        }

        private void btnMult_Click(object sender, EventArgs e)
        {
            var resultado = _calc.Mult(8, 4);

            labelResul.Text = resultado.ToString();
        }
        //Prueba de Botones Agregados

        //    private void bSuma_Click(object sender, EventArgs e)
        //    {
        //        var bResul = new Label();
        //        bResul.Text = "";
        //        bResul.Location = new Point(190, 30);
        //        panelCalc.Controls.Add(bResul);

        //        var resultado = _calc.Suma(8, 4);
        //        label1.Text = resultado.ToString();
        //    }
        //    private void bResta_Click(object sender, EventArgs e)
        //    {
        //        var bResul = new Label();
        //        bResul.Text = "";
        //        bResul.Location = new Point(190, 30);
        //        panelCalc.Controls.Add(bResul);

        //        var resultado = _calc.Resta(8, 4);
        //        label1.Text = resultado.ToString();
        //    }
        //    private void bMulti_Click(object sender, EventArgs e)
        //    {
        //        var bResul = new Label();
        //        bResul.Text = "";
        //        bResul.Location = new Point(190, 30);
        //        panelCalc.Controls.Add(bResul);

        //        var resultado = _calc.Mult(8, 4);
        //        label1.Text = resultado.ToString();
        //    }
        //    private void bDiv_Click(object sender, EventArgs e)
        //    {
        //        var bResul = new Label();
        //        bResul.Text = "";
        //        bResul.Location = new Point(190, 30);
        //        panelCalc.Controls.Add(bResul);

        //        var resultado = _calc.Div(8, 4);
        //        bResul.Text = resultado.ToString();
        //    }
    }
}