namespace BMI.Models
{
    public class BMI : BaseModel
    {
        private string _resultText;

        public float Height { get; set; }
        public float Weight { get; set; }
        public float Result => ((Weight / Height) / Height) * 10000;
        public string ResultText { 
            get 
            {
                string rangeText;

                if (Result <= 16)
                    rangeText = "Delgadez Severa";
                else if( Result> 16 && Result <= 17)
                    rangeText = "Delgadez Moderada";
                else if (Result > 17 && Result <= 18.5)
                    rangeText = "Delgadez Leve";
                else if (Result > 18.5 && Result <= 25)
                    rangeText = "Normal";
                else if (Result > 25 && Result <= 30)
                    rangeText = "Sobrepeso";
                else if (Result > 30 && Result <= 35)
                    rangeText = "Obeso clase 1";
                else if (Result > 35 && Result <= 40)
                    rangeText = "Obeso clase 2";
                else
                    rangeText = "Obeso clase 3";

                return $"BMI: {rangeText}";
            } 
        }
    }
}
