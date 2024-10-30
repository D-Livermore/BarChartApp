using BarChartApp;

partial class Form1
{
    private System.ComponentModel.IContainer components = null;

    private TextBox textBoxData;
    private Button buttonSubmit;
    private BarChartControl barChartControl;

    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
        textBoxData = new TextBox();
        buttonSubmit = new Button();
        barChartControl = new BarChartControl();
        label1 = new Label();
        SuspendLayout();

        textBoxData.Location = new Point(318, 20);
        textBoxData.Name = "textBoxData";
        textBoxData.Size = new Size(381, 31);
        textBoxData.TabIndex = 0;
        textBoxData.TextChanged += textBoxData_TextChanged;

        buttonSubmit.Location = new Point(717, 20);
        buttonSubmit.Name = "buttonSubmit";
        buttonSubmit.Size = new Size(98, 31);
        buttonSubmit.TabIndex = 1;
        buttonSubmit.Text = "Submit";
        buttonSubmit.Click += buttonSubmit_Click;

        barChartControl.Location = new Point(30, 86);
        barChartControl.Name = "barChartControl";
        barChartControl.Size = new Size(762, 564);
        barChartControl.TabIndex = 2;

        label1.AutoSize = true;
        label1.Location = new Point(19, 19);
        label1.Name = "label1";
        label1.Size = new Size(293, 25);
        label1.TabIndex = 3;
        label1.Text = "Enter values seperated by a comma";

        ClientSize = new Size(837, 662);
        Controls.Add(label1);
        Controls.Add(textBoxData);
        Controls.Add(buttonSubmit);
        Controls.Add(barChartControl);
        Name = "Form1";
        Text = "Bar Chart Application";
        ResumeLayout(false);
        PerformLayout();
    }

    private Label label1;
}
