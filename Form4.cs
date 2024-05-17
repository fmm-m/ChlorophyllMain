using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chlorophyl_Prototype
{
    public partial class Form4 : Form
    {
        Dictionary<int, string> lessonHeaders = new Dictionary<int, string>();
        Dictionary<int, string> lessonContent = new Dictionary<int, string>();
        int imageReference = 0;
        List<string> imagesList = new List<string>();



        private void loadForm(Form f)
        {
            f.Owner = this;
            f.StartPosition = FormStartPosition.Manual;
            f.Location = this.Location;
            f.Show();
            this.Hide();
            
        }
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            FormBorderStyle = FormBorderStyle.None;
            WindowState = FormWindowState.Maximized;
            lessonHeaders.Add(1, "Lesson #1. What is programming?");
            lessonHeaders.Add(2, "Lesson #2. Interacting with the world");
            lessonHeaders.Add(3, "Lesson #3. Vegetables and Variables!");
            lessonHeaders.Add(4, "Lesson #4. Conditional statements: Don't kill anyone.");
            lessonHeaders.Add(5, "Lesson #5. Looping and Planting");
            lessonHeaders.Add(6, "The Final challenge...");

            lessonTitle.Text = lessonHeaders[Form2.lessonNumber];

            lessonContent.Add(1, "Welcome to Chlorophyll! And welcome to your very first Garden. Through the course of 6 lessons, you will learn how to quickly and efficiently plant, sort, and manage your Garden! \nWhen broken down into its core components, programming is a lot like gardening. \n\n To the right, there is a big ol' area, allowing you to drag and drop code blocks wherever you want. But for now, it just has some diagrams.");
            lessonContent.Add(2, "Imagine you have 5 packets of seeds. Carrot, Potato, Celery, Onion, and Cucumber. Each seed bag contains a different amount of seeds, maybe there's half-a-dozen carrot seeds, and 27 cucumber seeds! Finally, there's a little tag on it saying whether or not it's a root vegetable. Each of these parts represent a different type of data that a computer can interpret. \n\nThe Name of the vegetable is called a STRING (str). A string is any amount of text, from a single letter to an entire paragraph!\n\nThe Amount of seeds is called an INTEGER (int). An integer is a fancy computer term for any whole number, negative or positive.\n\nFinally, whether or not it's a root vegetable is called a BOOLEAN (bool). A Boolean value is either True or False, no inbetween.");
            lessonContent.Add(3, "Placeholder text for lesson 3");
            lessonContent.Add(4, "Placeholder text for lesson 4");
            lessonContent.Add(5, "Placeholder text for lesson 5");
            lessonContent.Add(6, "Placeholder text for lesson 6");

            content.Text = lessonContent[Form2.lessonNumber];

            if (Form2.lessonNumber == 1)
            {
                imagesList.Add(@"H:\Programming\Chlorophyl Prototype\Chlorophyl Prototype\Programming overview.png");
                imagesList.Add(@"H:\Programming\Chlorophyl Prototype\Chlorophyl Prototype\whenClicked.png");
            }
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            loadForm(f1);
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
            imageReference++;
            if (imageReference == imagesList.Count)
            {
                imageReference = 0;
            }
            if (imagesList.Count > 0)
            {
                pictureBox1.Image = Image.FromFile(imagesList[imageReference]);
            }

        }
    }
}
