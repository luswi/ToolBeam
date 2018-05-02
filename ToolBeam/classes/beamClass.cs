using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ToolBeam.classes
{
    class profileClass
    {
        //Zmienne wykorzystywane do obliczen Klasy profilu
        public double liczbaA { get; set; }
        public double liczbaB { get; set; }
        


        public bool obliczenia(profileClass v)
        {
            bool isSuccess = false;
            if (liczbaA > 0)
            {
                isSuccess = true;
                double odpowiedz;

                odpowiedz = liczbaA + liczbaB;

                MessageBox.Show(Convert.ToString(odpowiedz));
            }
            else
            {
                isSuccess = false;
                //MessageBox.Show("duupa");
            }
            //int liczbaA = 5;
            //int liczbaB = 10;
            //int answer;

            //answer = liczbaA + liczbaB;

            //string pozmianie = Convert.ToString(answer);
            //MessageBox.Show(liczbaA);
            return isSuccess;

        }
        
    }
}
