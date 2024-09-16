namespace cos
{
    public partial class MainPage : ContentPage
    {


        public MainPage()
        {
            InitializeComponent();
        }

        private void OnCounterClicked(object sender, EventArgs e)
        {

            Random r = new Random();
            if (kostka4.IsChecked == true)
            {
                int roll = r.Next(1, 5);
                RollValueLabel.Text = roll.ToString();
            }
            else if (kostka6.IsChecked == true)
            {
                int roll = r.Next(1, 7);
                RollValueLabel.Text = roll.ToString();
            }
        }
    }
}
