using Microsoft.VisualBasic;
using System; 
using System.Windows.Forms; 

namespace MyWindowApp;

public partial class Form1 : Form
{
    private Button clickButton; 

    public Form1()
    {
        clickButton = new Button
        {
            Text = "Click Me"
        };

        clickButton.Click += ClickButton_Click;

        Controls.Add(clickButton);
    }

    private void ClickButton_Click(object sender, EventArgs e)
    {
        MessageBox.Show("Button clicked");
    }
}
