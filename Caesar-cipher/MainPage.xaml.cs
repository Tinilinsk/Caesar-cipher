namespace Caesar_cipher
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();
        }

        private void Szyfruj(object sender, EventArgs e)
        {
            int length = 0;
            OutPut.Text = "";
            string text = InPutText.Text;
            string key = InPutKey.Text;

            if (!string.IsNullOrEmpty(text) && !string.IsNullOrEmpty(key))
            {
                int numklucz = Int32.Parse(key) % 26;
                length = text.Length;

                for (int i = 0; i < length; i++)
                {
                    

                    if (text[i] >= 'a' && text[i] <= 'z')
                    {
                        int offset = (text[i] - 'a' + numklucz) % 26;

                        if (offset < 0)
                        {
                            offset += 26;
                        }


                        char result = (char)('a' + offset);
                        OutPut.Text += result;
                    }
                    else
                    {
                        OutPut.Text += text[i];
                    }
                }
            }
            else
            {
                DisplayAlert("Alert", "All fields must be filled in", "OK");
            }


        }
    }

}
