using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MouseMovementCS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void SairButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void IniciarButton_Click(object sender, EventArgs e)
        {
            {
                int altura = Screen.PrimaryScreen.Bounds.Height / 2 - 10;
                int comprimento = Screen.PrimaryScreen.Bounds.Width;
                double diametro = Math.PI * 2.0;

                //Move Mouse
                var mouseMovement = Task.Run(async () =>
                {
                    while (true)
                    { 
                        for (int x = 0; x < comprimento; x++)
                        {
                            int y = altura * Convert.ToInt32(Math.Sin(diametro)) * x / comprimento + altura;
                            System.Drawing.Point mouseMent = new System.Drawing.Point(x, y);
                            Cursor.Position = mouseMent;
                        }
                        await Task.Delay(1500);
                    }
                });
            }
        }
    }
}
