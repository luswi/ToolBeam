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
        // Variables used for calculations
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
        //public string cbtest { get; set; }

        public bool calculations(profileClass v)
        {
            bool isSuccess = false;
            if (bVar > 0)
            {
                isSuccess = true;
                // Materials database
                if(tfVar <= 40)
                {
                    switch (material)
                    {
                        case "S235":
                            fyVar = 235;
                            fuVar = 360;
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
                // End material database

                // Epsilon calc
                epsilon = Math.Sqrt(235/fyVar);
                // Web calc
                // c/t = (h-2(t.f+r))/t.w
                web = (hVar - 2 * (tfVar + rVar)) / twVar;
                // Web slendernsess check
                if (web <= 72*epsilon)
                {
                    webClass = "Class 1";
                }
                else if (web <= 83*epsilon)
                {
                    webClass = "Class 2";
                }
                else if (web <= 124*epsilon)
                {
                    webClass = "Class 3";
                }
                else if (web > 124*epsilon)
                {
                    webClass = "Class 4";
                }
                // Flange calc
                // c/t = (0.5(b-t.w-2r))/t.f
                flange = (0.5*(bVar - twVar - 2 * rVar)) / tfVar;
                // Flange slenderness check
                if (flange <= 9*epsilon)
                {
                    flangeClass = "Class 1";
                }
                else if (flange <= 10*epsilon)
                {
                    flangeClass = "Class 2";
                }
                else if (flange <= 14*epsilon)
                {
                    flangeClass = "Class 3";
                }
                else if (flange > 14*epsilon)
                {
                    flangeClass = "Class 4";
                }

            }
            else
            {
                isSuccess = false;
                
            }
            
            return isSuccess;

        }

        
    }
}
