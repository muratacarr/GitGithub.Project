using Microsoft.Data.Sqlite;

namespace WorkApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(textBox1.Text) && !string.IsNullOrEmpty(textBox2.Text))
            {
                // pathe nasýl ulaþabilirsiniz ? 
                // 
                SqliteConnection connection = new SqliteConnection("");
                SqliteCommand command = new SqliteCommand();
                command.CommandText = "select * from Users where username =@username";

                
            }
        }
    }
}