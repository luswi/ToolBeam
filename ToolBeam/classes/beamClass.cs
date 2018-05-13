using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ToolBeam.classes
{
    public class profileClass
    {
        //Zmienne wykorzystywane do obliczen Klasy profilu
        public double tfVar { get; set; }
        public string material { get; set; }
        public double hVar { get; set; }
        public double bVar { get; set; }
        public double fyVar { get; set; }
        public double fuVar { get; set; }
        public string tescik { get; set; }
       

        public bool obliczenia(profileClass v)
        {
            bool isSuccess = false;
            if (bVar > 0)
            {
                isSuccess = true;
                // materials database
                if(tfVar <= 40)
                {
                    switch (material)
                    {
                        case "S235":
                            fyVar = 235;
                            fuVar = 360;
                            //double fyVarS235 = 235;
                            //double fuVarS235 = 360;
                            //MessageBox.Show(Convert.ToString(fyVarS235));
                            break;
                        case "S275":
                            fyVar = 275;
                            fuVar = 360;
                            break;
                        case "S355":
                            fyVar = 355;
                            fuVar = 490;
                            break;
                        case "S450":
                            fyVar = 440;
                            fuVar = 550;
                            break;
                        default:
                            MessageBox.Show("Nic nie podano");
                            break;
                    }
                }
                else
                {
                    switch (material)
                    {
                        case "S235":
                            fyVar = 215;
                            fuVar = 360;
                            //MessageBox.Show(Convert.ToString(fyVarS235));
                            break;
                        case "S275":
                            fyVar = 255;
                            fuVar = 410;
                            break;
                        case "S355":
                            fyVar = 335;
                            fuVar = 470;
                            break;
                        case "S450":
                            fyVar = 410;
                            fuVar = 550;
                            break;
                        default:
                            MessageBox.Show("Nic nie podano");
                            break;
                    }
                }
                // end material database

                double epsilon;

                //epsilon = Math.Sqrt(10/4);
                epsilon = Math.Sqrt(fuVar/fyVar);

                double odpowiedz;

                odpowiedz = hVar + bVar;

                MessageBox.Show(Convert.ToString(odpowiedz));
                MessageBox.Show(Convert.ToString(epsilon));
                MessageBox.Show(Convert.ToString(fyVar));
                MessageBox.Show(Convert.ToString(fuVar));
           

            }
            else
            {
                isSuccess = false;
                
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
