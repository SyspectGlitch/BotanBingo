using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace BotanBingo
{
    public partial class BotanBoard : Form
    {
        private List<string> botanisms = new List<string>();
        private int score;
        static readonly string textFile = @"..\..\Assets\Botanisms.txt";//@"Assets\\botanisms.txt";
        Button[] buttons = new Button[25];

        public BotanBoard()
        {
            InitializeComponent();
            //read list from text file
            if (File.Exists(textFile))
            {
                string[] lines = File.ReadAllLines(textFile);
                foreach (string line in lines)
                {
                    botanisms.Add(line);
                }
                buttons[0] = space1;
                buttons[1] = space2;
                buttons[2] = space3;
                buttons[3] = space4;
                buttons[4] = space5;
                buttons[5] = space6;
                buttons[6] = space7;
                buttons[7] = space8;
                buttons[8] = space9;
                buttons[9] = space10;
                buttons[10] = space11;
                buttons[11] = space12;
                buttons[12] = FreeSpace;
                buttons[13] = space14;
                buttons[14] = space15;
                buttons[15] = space16;
                buttons[16] = space17;
                buttons[17] = space18;
                buttons[18] = space19;
                buttons[19] = space20;
                buttons[20] = space21;
                buttons[21] = space22;
                buttons[22] = space23;
                buttons[23] = space24;
                buttons[24] = space25;
                //assign botanisms at random to buttons and repeat for all buttons except free space (index 12)
                for (int x = 0; x < 25; x++)
                {
                    if (x != 12)
                    {
                        //randomly choose botanism from list
                        var random = new Random();
                        int value = random.Next(0, botanisms.Count);
                        //replace text of button with botanism
                        string select = botanisms[value];
                        buttons[x].Text = select;
                        //delete chosen botanism from list
                        botanisms.RemoveAt(value);
                    }
                }
            }
            else
                CallError("This file doesn't exist");
            
        }

        private void UpdateScore()
        {
            scoreval.Text = score.ToString();
        }

        private void CheckWin()
        {
            if (space1.Enabled == false && space2.Enabled == false && space3.Enabled == false && space4.Enabled == false && space5.Enabled == false)
            {
                Win();
            }
            else if(space6.Enabled == false && space7.Enabled == false && space8.Enabled == false && space9.Enabled == false && space10.Enabled == false)
            {
                Win();
            }
            else if (space11.Enabled == false && space12.Enabled == false && FreeSpace.Enabled == false && space14.Enabled == false && space15.Enabled == false)
            {
                Win();
            }
            else if (space16.Enabled == false && space17.Enabled == false && space18.Enabled == false && space19.Enabled == false && space20.Enabled == false)
            {
                Win();
            }
            else if (space21.Enabled == false && space22.Enabled == false && space23.Enabled == false && space24.Enabled == false && space25.Enabled == false)
            {
                Win();
            }
            else if (space6.Enabled == false && space7.Enabled == false && space8.Enabled == false && space9.Enabled == false && space10.Enabled == false)
            {
                Win();
            }
            else if (space1.Enabled == false && space6.Enabled == false && space11.Enabled == false && space16.Enabled == false && space21.Enabled == false)
            {
                Win();
            }
            else if (space2.Enabled == false && space7.Enabled == false && space12.Enabled == false && space17.Enabled == false && space22.Enabled == false)
            {
                Win();
            }
            else if (space3.Enabled == false && space8.Enabled == false && FreeSpace.Enabled == false && space18.Enabled == false && space23.Enabled == false)
            {
                Win();
            }
            else if (space4.Enabled == false && space9.Enabled == false && space14.Enabled == false && space19.Enabled == false && space24.Enabled == false)
            {
                Win();
            }
            else if (space5.Enabled == false && space10.Enabled == false && space15.Enabled == false && space20.Enabled == false && space25.Enabled == false)
            {
                Win();
            }
            else if (space1.Enabled == false && space7.Enabled == false && FreeSpace.Enabled == false && space19.Enabled == false && space25.Enabled == false)
            {
                Win();
            }
            else if (space5.Enabled == false && space9.Enabled == false && FreeSpace.Enabled == false && space17.Enabled == false && space21.Enabled == false)
            {
                Win();
            }
        }

        private void CallError(string message)
        {
            var error = new Error(message);
            error.ShowDialog();
        }

        private void Win()
        {
            CallError("You Win");
        }

        private void button_Click(object sender, EventArgs e)
        {
            Button button;
            if (sender is Button)
            {
                button = (Button)sender;
                button.BackColor = Color.Red;
                button.Enabled = false;
                score++;
                UpdateScore();
                CheckWin();
            }
        }

        private void space1_Click(object sender, EventArgs e)
        {

        }
    }
}
