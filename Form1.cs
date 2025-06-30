namespace WF_1_Hw
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            string
                msg1 = "Heyo there, my name is Omina!",
                msg2 = "I'm 17 y.o.",
                msg3 = "I like to draw, sleep and eat.",
                msg4 = "I really love my cats: Molly and Milky, and sometimes i think i would't even be able to imagine my life without them, because sometimes everything just proves that THEY are my life."; ;

            MessageBox.Show(msg1, "My name", MessageBoxButtons.OK, MessageBoxIcon.Information);
            MessageBox.Show(msg2, "My age", MessageBoxButtons.OK, MessageBoxIcon.Information);
            MessageBox.Show(msg3, "My favourite thngs to do.", MessageBoxButtons.OK, MessageBoxIcon.Information);
            MessageBox.Show(msg4, "Someones i love.", MessageBoxButtons.OK, MessageBoxIcon.Information);
            MessageBox.Show(Convert.ToString((msg1.Length+msg2.Length+msg3.Length+msg4.Length)/4), "Average amound of words per window.", MessageBoxButtons.OK, MessageBoxIcon.Information);


        }
    }
}
