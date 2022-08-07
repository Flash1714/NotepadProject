namespace NotepadProject
{
    public partial class NotepadProject : Form
    {
        System.Data.DataTable table;
        public NotepadProject()
        {
            InitializeComponent();
        }

        private void NotepadProject_Load(object sender, EventArgs e)
        {
            //Initialize data table
            table = new System.Data.DataTable();
            //Add two coloums to the data table
            table.Columns.Add("Title", typeof(String));
            table.Columns.Add("Message", typeof(String));

            // Putting the data in the table on the application
            dataGridView1.DataSource = table;

            //Hiding the messages coloum
            dataGridView1.Columns["Message"].Visible = false;

            //Filling couloum in 
            dataGridView1.Columns["Title"].Width = 285;

        }

        private void bttNew_Click(object sender, EventArgs e)
        {
            //When 'New' button is pressed clear the text boxes
            textTitle.Clear();
            textMessage.Clear();
        }

        private void bttSave_Click(object sender, EventArgs e)
        {
            //When 'Save' button is pressed add the two text boxes into the table 
            table.Rows.Add(textTitle.Text, textMessage.Text);
            
            //Clear the text boxes
            textTitle.Clear();
            textMessage.Clear();

            //Want to add ability to save files permanently when save button is clicked 

        }

        private void bttRead_Click(object sender, EventArgs e)
        {
            int index = dataGridView1.CurrentCell.RowIndex;

            if (index > -1)
            {
                textTitle.Text = table.Rows[index].ItemArray[0].ToString();
                textMessage.Text = table.Rows[index].ItemArray[1].ToString();
            }
        }

        private void bttDelete_Click(object sender, EventArgs e)
        {
            int index = dataGridView1.CurrentCell.RowIndex;

            if (index > -1)
            {
                table.Rows[index].Delete();
            }
        }
    }
}