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
        public int tfVar { get; set; }
        public string material { get; set; }
        public double hVar { get; set; }
        public double bVar { get; set; }
        


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
                            double fyVarS235 = 235;
                            double fuVarS235 = 360;
                            MessageBox.Show(Convert.ToString(fyVarS235));
                            break;
                        case "S275":
                            double fyVarS275 = 275;
                            double fuVarS275 = 360;
                            break;
                        case "S355":
                            double fyVarS355 = 355;
                            double fuVarS355 = 490;
                            break;
                        case "S450":
                            double fyVarS450 = 440;
                            double fuVarS450 = 550;
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
                            double fyVarS235 = 215;
                            double fuVarS235 = 360;
                            MessageBox.Show(Convert.ToString(fyVarS235));
                            break;
                        case "S275":
                            double fyVarS275 = 255;
                            double fuVarS275 = 410;
                            break;
                        case "S355":
                            double fyVarS355 = 335;
                            double fuVarS355 = 470;
                            break;
                        case "S450":
                            double fyVarS450 = 410;
                            double fuVarS450 = 550;
                            break;
                        default:
                            MessageBox.Show("Nic nie podano");
                            break;
                    }
                }
                


                double odpowiedz;

                odpowiedz = hVar + bVar;

                MessageBox.Show(Convert.ToString(odpowiedz));
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
