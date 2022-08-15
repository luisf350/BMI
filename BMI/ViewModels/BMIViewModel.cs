namespace BMI.ViewModels
{
    public class BMIViewModel : BaseViewModel
    {
        public Models.BMI BMI { get; set; }

        public BMIViewModel()
        {
            BMI = new Models.BMI
            {
                Height = 180,
                Weight = 73
            };
        }
    }
}
