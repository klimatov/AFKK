using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;


namespace AFKK
{
    public partial class Form1 : Form
    {
        [DllImport("User32.dll")]
        static extern bool GetCursorPos(ref Point lpPoint);

        // глобальные переменные, в которых будут храниться координаты

        static protected long totalPixels = 0;

        static protected int currX;

        static protected int currY;

        static protected int diffX;

        static protected int diffY;
        
        //импортируем mouse_event(): 
        [DllImport("User32.dll")]
        static extern void mouse_event(MouseFlags dwFlags, int dx, int dy, int dwData, UIntPtr dwExtraInfo);
        
        //для удобства использования создаем перечисление с необходимыми флагами (константами), которые определяют действия мыши: 
        [Flags]
        enum MouseFlags
        {
            Move = 0x0001, LeftDown = 0x0002, LeftUp = 0x0004, RightDown = 0x0008,
            RightUp = 0x0010, Absolute = 0x8000
        };


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //и использование - клик правой примерно в центре экрана
            // обновление информации происходит каждые 10 мс
            Point defPnt = new Point();
            // заполняем defPnt информацией о координатах мышки
            GetCursorPos(ref defPnt);

            

            // если курсор не перемещался
          if (currX == defPnt.X || currY == defPnt.Y)
          {
                // выводим информацию в окно
                txtXX.Text = "X = " + defPnt.X.ToString();
                txtYY.Text = "Y = " + defPnt.Y.ToString();

                // переводим координаты в формат мики (65535 ширина)
                var x = (defPnt.X + 2) * 65535 / 1600;
                var y = (defPnt.Y + 2) * 65535 / 900;

                // двигаем мышку
                mouse_event(MouseFlags.Absolute | MouseFlags.Move, x, y, 0, UIntPtr.Zero);

                // запоминаем текущие координаты, для отслеживания изменений
                currX = defPnt.X+1;
                currY = defPnt.Y+1;
            } else
            {
                txtXX.Text = "Moving";
                txtYY.Text = "Moving";

                // запоминаем текущие координаты, для отслеживания изменений
                currX = defPnt.X;
                currY = defPnt.Y;
            }



            //Random rnd1 = new Random();
            //const int x = Cursor.Position.X;
            //const int y = Cursor.Position.Y;
            //Point p = new Point(MousePosition.X + 1, MousePosition.Y - 1);  //эту траекторию представил просто для примера
            //Cursor.Position = p;
        }
    }
}
