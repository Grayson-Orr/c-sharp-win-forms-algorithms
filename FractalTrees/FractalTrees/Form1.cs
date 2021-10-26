using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FractalTrees
{
    public partial class Form1 : Form
    {
        // Constants
        private const int TRIANGLEXSTARTINGX = 400;
        private const int TRIANGLEXSTARTINGY = 50;
        private const int TRIANGLEYSTARTINGX = 700;
        private const int TRIANGLEYSTARTINGY = 550;
        private const int TRIANGLEZSTARTINGX = 100;
        private const int TRIANGLEZSTARTINGY = 550;
        private const int DRAGONSTARTX = 350;
        private const int DRAGONSTARTY = 100;
        private const int DRAGONDIRECTIONX = 100;
        private const int DRAGONDIRECTIONY = 325;
        private const int SNOWFLAKEFIRSTSTARTX = 250;
        private const int SNOWFLAKEFIRSTSTARTY = 350;
        private const int SNOWFLAKEFIRSTENDX = 850;
        private const int SNOWFLAKEFIRSTENDY = 350;
        private const int SNOWFLAKESECONDSTARTX = 550;
        private const int SNOWFLAKESECONDSTARTY = 0;

        // Fields
        private Graphics graphics;
        private Random random;
        private FractalManager fractalManager;
        
        /// <summary>
        /// Form Ctor
        /// </summary>
        public Form1()
        {
            InitializeComponent();
            graphics = CreateGraphics();
            random = new Random();
            fractalManager = new FractalManager(graphics, random);
        }

        /// <summary>
        /// Create Fractal Pattern Button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void createFractalBtn_Click(object sender, EventArgs e)
        {
            graphics.FillRectangle((new SolidBrush(Color.White)), 0, 0, Width, Height); // Fills the forms

            // Optimal depth - 8
            if (radioBtnSierpinski.Checked)
            {
                fractalManager.SierpinskiSieve((int)selectDepthNumeric.Value, 
                    new Point(TRIANGLEXSTARTINGX, TRIANGLEXSTARTINGY), 
                    new Point(TRIANGLEYSTARTINGX, TRIANGLEYSTARTINGY), 
                    new Point(TRIANGLEZSTARTINGX, TRIANGLEZSTARTINGY));
            }

            // Optimal depth - 10
            if (radioBtnSnowflake.Checked)
            {
                fractalManager.KochSnowflake((int)selectDepthNumeric.Value,
                    new Point(SNOWFLAKEFIRSTSTARTX, SNOWFLAKEFIRSTSTARTY),
                    new Point(SNOWFLAKEFIRSTENDX, SNOWFLAKEFIRSTENDY));
                fractalManager.KochSnowflake((int)selectDepthNumeric.Value,
                    new Point(SNOWFLAKEFIRSTENDX, SNOWFLAKEFIRSTENDY),
                    new Point(SNOWFLAKESECONDSTARTX, SNOWFLAKESECONDSTARTY));
                fractalManager.KochSnowflake((int)selectDepthNumeric.Value,
                    new Point(SNOWFLAKESECONDSTARTX, SNOWFLAKESECONDSTARTY),
                    new Point(SNOWFLAKEFIRSTSTARTX, SNOWFLAKEFIRSTSTARTY));
            }

            // Optimal depth - 13
            if (radioBtnDragon.Checked)
            {
                fractalManager.DragonCurve((int)selectDepthNumeric.Value, 
                    new Point(DRAGONSTARTX, DRAGONSTARTY),
                    new Point(DRAGONDIRECTIONX, DRAGONDIRECTIONY), eDirection.LEFT);
            }  
            
            if (radioBtnFlower.Checked)
            {
                fractalManager.TheFlowerOfLife((int)selectDepthNumeric.Value, new Point(300, 50), 500);
            }
        }
    }
}
