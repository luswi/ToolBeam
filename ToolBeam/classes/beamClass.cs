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
        public bool rbBending { get; set; }
        public bool rbCompression { get; set; }
        public bool rbBendingCompression { get; set; }
        public double force { get; set; }
        public double alphaN { get; set; }
        public double alpha { get; set; }
        public double aVar { get; set; }
        public double psi { get; set; }
        public double psiCalc { get; set; }

        //
        public void psiFunction()
        {
            //MessageBox.Show("sprezysty ?");
            psi = ((2.0 * force * 1000) / (aVar * 100.0 * fyVar) - 1.0);
            if (psi > -1)
            {
                psiCalc = ((42 * epsilon) / (0.67 + 0.33 * psi));
                MessageBox.Show(Convert.ToString(psiCalc));
                
            }
            else if (psi <= -1)
            {
                psiCalc = (62 * epsilon * (1.0 + Math.Abs(psi)) * (Math.Sqrt(Math.Abs(psi))));
                MessageBox.Show(Convert.ToString(psiCalc));
            }
        }

        public bool iCalc(profileClass v)
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


                //=============================Bending======================//
                if(rbBending == true)
                {
                    // Epsilon calc
                    epsilon = Math.Round(Math.Sqrt(235 / fyVar), 2);
                    // Web calc
                    // c/t = (h-2(t.f+r))/t.w
                    web = Math.Round(((hVar - 2 * (tfVar + rVar)) / twVar), 2);
                    
                    // Web slendernsess check
                    if (web <= 72 * epsilon)
                    {
                        webClass = "Class 1";
                        
                    }
                    else if (web <= 83 * epsilon)
                    {
                        webClass = "Class 2";
                    }
                    else if (web <= 124 * epsilon)
                    {
                        webClass = "Class 3";
                    }
                    else if (web > 124 * epsilon)
                    {
                        webClass = "Class 4";
                    }
                    // Flange calc
                    // c/t = (0.5(b-t.w-2r))/t.f
                    flange = Math.Round(((0.5 * (bVar - twVar - 2 * rVar)) / tfVar), 2);
                    // Flange slenderness check
                    if (flange <= 9 * epsilon)
                    {
                        flangeClass = "Class 1";
                    }
                    else if (flange <= 10 * epsilon)
                    {
                        flangeClass = "Class 2";
                    }
                    else if (flange <= 14 * epsilon)
                    {
                        flangeClass = "Class 3";
                    }
                    else if (flange > 14 * epsilon)
                    {
                        flangeClass = "Class 4";
                    }
                }
                //=============================Compression======================//
                else if (rbCompression == true)
                {
                    // Epsilon calc
                    epsilon = Math.Round(Math.Sqrt(235 / fyVar), 2);
                    // Web calc
                    // c/t = (h-2(t.f+r))/t.w
                    web = Math.Round(((hVar - 2 * (tfVar + rVar)) / twVar), 2);
                    // Web slendernsess check
                    if (web <= 33 * epsilon)
                    {
                        webClass = "Class 1";
                    }
                    else if (web <= 38 * epsilon)
                    {
                        webClass = "Class 2";
                    }
                    else if (web <= 42 * epsilon)
                    {
                        webClass = "Class 3";
                    }
                    else if (web > 42 * epsilon)
                    {
                        webClass = "Class 4";
                    }
                    // Flange calc
                    // c/t = (0.5(b-t.w-2r))/t.f
                    flange = Math.Round(((0.5 * (bVar - twVar - 2 * rVar)) / tfVar), 2);
                    // Flange slenderness check
                    if (flange <= 9 * epsilon)
                    {
                        flangeClass = "Class 1";
                    }
                    else if (flange <= 10 * epsilon)
                    {
                        flangeClass = "Class 2";
                    }
                    else if (flange <= 14 * epsilon)
                    {
                        flangeClass = "Class 3";
                    }
                    else if (flange > 14 * epsilon)
                    {
                        flangeClass = "Class 4";
                    }
                }
                //=============================Bending&Compression======================//
                else if (rbBendingCompression == true)
                {


                    // Epsilon calc
                    epsilon = Math.Round(Math.Sqrt(235 / fyVar), 2);
                    // Flange calc
                    // c/t = (0.5(b-t.w-2r))/t.f
                    flange = Math.Round(((0.5 * (bVar - twVar - 2 * rVar)) / tfVar), 2);
                    // Flange slenderness check
                    if (flange <= 9 * epsilon)
                    {
                        flangeClass = "Class 1";
                    }
                    else if (flange <= 10 * epsilon)
                    {
                        flangeClass = "Class 2";
                    }
                    else if (flange <= 14 * epsilon)
                    {
                        flangeClass = "Class 3";
                    }
                    else if (flange > 14 * epsilon)
                    {
                        flangeClass = "Class 4";
                    }
                    // Web calc
                    //Krok1 sprawdzamy warunki smuklosci jak dla scianki osiowo sciskanej - dla najbardziej niekorzystnego rozkladu naprezen,
                    //aby sprawdzic czy sa potrzebne bardziej szczegolowe obliczenia
                    //
                    //
                    // c/t = (h-2(t.f+r))/t.w
                    web = Math.Round(((hVar - 2 * (tfVar + rVar)) / twVar), 2);
                    // Web slendernsess check
                    if (web <= 33 * epsilon)
                    {
                        webClass = "Class 1";
                    }
                    else if (web <= 38 * epsilon)
                    {
                        webClass = "Class 2";
                    }
                    else if (web <= 42 * epsilon)
                    {
                        webClass = "Class 3";
                    }
                    else if (web > 42 * epsilon)
                    {
                        webClass = "Class 4";
                        // Trzeba sprawdzic szczegolowo i udowodnic, ze srodnik nie nalezy do klasy 4. Zakladamy plastyczny rozklad naprezen.
                        alphaN = Math.Round(((force * 1000) / (twVar * fyVar)), 2);
                        MessageBox.Show(Convert.ToString(alphaN));
                        // alpha = (c + alphaN)/2c
                        alpha = ((hVar - 2 * (tfVar + rVar)) + alphaN) / (2 * (hVar - 2 * (tfVar + rVar)));
                        MessageBox.Show(Convert.ToString(alpha));
                        if (alpha > 0)
                        {

                            if (alpha > 0.5)
                            {
                                //sprawdzanie dla klasy 1 i 2
                                double licz1 = (396 * epsilon) / ((13 * alpha) - 1);
                                double licz2 = (456 * epsilon) / ((13 * alpha) - 1);
                                if (licz1 >= web)
                                {
                                    MessageBox.Show("klasa1");
                                }
                                else if (licz2 >= web)
                                {
                                    MessageBox.Show("klasa2");

                                }
                                else
                                //srodnik nie spelnia warunkow klasy 2. Nalezy wyznaczyc smuklosc graniczna scianki klasy 3 przyjmujac sprezysty rozklad naprezen.
                                {
                                    psiFunction();
                                    
                                }

                            }
                        else if (alpha <= 0.5)
                            {
                                //sprawdzanie dla klasy 1 i 2
                                double licz1 = (36 * epsilon) / alpha;
                                double licz2 = (41.5 * epsilon) / alpha;
                                if (licz1 >= web)
                                {
                                    MessageBox.Show("klasa1");
                                }
                                else if (licz2 >= web)
                                {
                                    MessageBox.Show("klasa2");
                                }
                                else
                                {
                                    psiFunction();
                                }

                            }

                        }
                        

}

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
