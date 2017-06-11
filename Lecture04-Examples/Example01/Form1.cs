using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Example01
{
    public partial class Form1 : Form
    {
        private Scene currenScene;

        public Form1()
        {
            InitializeComponent();
            this.currenScene = new Scene(this.scenepictureBox);
        }

        private void yesButton_Click(object sender, EventArgs e)
        {
            this.MakeDecision(1);
        }

        private void noButton_Click(object sender, EventArgs e)
        {
            this.MakeDecision(2);
        }

        private void MakeDecision(int decision)
        {
            switch (this.currenScene.Number)
            {
                case 1:
                    this.currenScene.ChangeTo(2);
                case 2:
                    if (decision == 1)
                        this.currenScene.ChangeTo(8);
                    else
                        this.currenScene.ChangeTo(3);
                    break;

                case 3:
                    if (decision == 1)
                        this.currenScene.ChangeTo(8);
                    else
                        this.currenScene.ChangeTo(3);
                    break;

                case 4:
                    if (decision == 1)
                        this.currenScene.ChangeTo(8);
                    else
                        this.currenScene.ChangeTo(3);
                    break;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void sceneictureBox_Click(object sender, EventArgs e)
        {
        }
    }
}