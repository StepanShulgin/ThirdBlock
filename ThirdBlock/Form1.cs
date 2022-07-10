namespace ThirdBlock
{
    public partial class Form1 : Form
    {
        int index = 0;
        Tree myTree = new Tree(200);
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int w = pictureBox1.ClientSize.Width;
            int h = pictureBox1.ClientSize.Height;
            myTree.AddNumLevel(9, w, h);
           

        }

        private void PrintTreeInBox(object sender, PaintEventArgs e)
        {
           
            
            if (index == 1)
            {
                myTree.PaintTree(e);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            index = 1;
            pictureBox1.Refresh();
        }
    }
}