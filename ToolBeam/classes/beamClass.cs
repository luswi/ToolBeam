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
        public double epsilon { get; set; }
        public double web { get; set; }
        public double rVar { get; set; }
        public double twVar { get; set; }
        public string webClass { get; set; }
        public double flange { get; set; }
        public string flangeClass { get; set; }

        public bool calculations(profileClass v)
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

                //double epsilon;

                //epsilon calc
                epsilon = Math.Sqrt(235/fyVar);
                //web calc
                // c/t = (h-2(t.f+r))/t.w
                web = (hVar - 2 * (tfVar + rVar)) / twVar;
                //web slendernsess check
                if (web <= 72*epsilon)
                {
                    webClass = "klasa 1";
                }
                else if (web <= 83*epsilon)
                {
                    webClass = "klasa 2";
                }
                else if (web <= 124*epsilon)
                {
                    webClass = "klasa 3";
                }
                else if (web > 124*epsilon)
                {
                    webClass = "klasa 4";
                }
                // flange calc
                // c/t = (0.5(b-t.w-2r))/t.f
                flange = (0.5*(bVar - twVar - 2 * rVar)) / tfVar;
                // flange slenderness check
                if (flange <= 9*epsilon)
                {
                    flangeClass = "Klasa 1";
                }
                else if (flange <= 10*epsilon)
                {
                    flangeClass = "Klasa 2";
                }
                else if (flange <= 14*epsilon)
                {
                    flangeClass = "Klasa 3";
                }
                else if (flange > 14*epsilon)
                {
                    flangeClass = "Klasa 4";
                }



                //double odpowiedz;

                //odpowiedz = hVar + bVar;

                //MessageBox.Show(Convert.ToString(odpowiedz));
                //MessageBox.Show(Convert.ToString(epsilon));
                //MessageBox.Show(Convert.ToString(fyVar));
                //MessageBox.Show(Convert.ToString(fuVar));
                

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
