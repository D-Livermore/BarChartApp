using BarChartApp;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
    }

    private void buttonSubmit_Click(object sender, EventArgs e)
    {
        string input = textBoxData.Text;
        string[] inputs = input.Split(',');

        float[] data = new float[inputs.Length];
        for (int i = 0; i < inputs.Length; i++)
        {
            if (float.TryParse(inputs[i], out float value))
            {
                data[i] = value;
            }
            else
            {
                MessageBox.Show("Invalid number: " + inputs[i]);
                return;
            }
        }

        barChartControl.SetData(data);
    }

    private void textBoxData_TextChanged(object sender, EventArgs e)
    {

    }
}
