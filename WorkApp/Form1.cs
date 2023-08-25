using System.Data.SQLite;

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
            string projectDirectory = Path.GetFullPath(Path.Combine(Directory.GetCurrentDirectory(), @"..\..\.."));
            DirectoryInfo directoryInfo = new DirectoryInfo(projectDirectory);
            var folders = directoryInfo.GetDirectories();
            var dbDirectory = folders.FirstOrDefault(p => p.Name == "Db");

            if (!string.IsNullOrEmpty(textBox1.Text) && !string.IsNullOrEmpty(textBox2.Text) && dbDirectory != null)
            {
                // pathe nasýl ulaþabilirsiniz ? 
                // 
                MessageBox.Show("Db dosya yolu : " + dbDirectory.FullName);
                var dbFiles = dbDirectory.GetFiles();
                var db = dbFiles.FirstOrDefault(p => p.Extension == ".db");

                SQLiteConnection connection = new SQLiteConnection(@"Data Source=" + db);
                SQLiteCommand command = connection.CreateCommand();
                SQLiteDataReader dataReader;
                connection.Open();
                command.CommandText = "SELECT * FROM Person";
                dataReader = command.ExecuteReader();

                while (dataReader.Read())
                {
                    MessageBox.Show(dataReader.GetInt32(0).ToString()+ " " + dataReader.GetString(1).ToString());
                }

                connection.Close();


            }
        }
    }
}