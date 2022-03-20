using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Optimum
{
    internal class VisualDisplayOfTheVariableField
    {
        private int X;
        private int Y;
        private Size LabelSize = new Size(60, 20);
        private Size TextBoxSize = new Size(40, 20);
        private List<Label> VariablesNames = new List<Label>();
        private List<TextBox> Names = new List<TextBox>();
        private List<Label> VariablesValues = new List<Label>();
        private List<TextBox> Values = new List<TextBox>();
        private int Count;

        public VisualDisplayOfTheVariableField()
        {
            this.Count = 0;
            this.X = 10;
            this.Y = 10;
        }

        public void AddElement()
        {
            this.Count++;

            VariablesNames.Add(CreateLabel("Var name:"));
            this.X += 70;

            Names.Add(CreateTextBox());
            this.X += 50;

            VariablesValues.Add(CreateLabel("Value:"));
            this.X += 70;

            Values.Add(CreateTextBox());


            this.X = 10;
            this.Y += 30;


        }

        public void RemoveElement()
        {
            VariablesNames.RemoveAt(Count - 1);
            Names.RemoveAt(Count - 1);
            VariablesValues.RemoveAt(Count - 1);
            Values.RemoveAt(Count - 1);
            Count--;
            Y -= 30;
        }

        public void SetElement(Label VarName, TextBox Name, Label VarValue, TextBox Value)
        {

        }

        public Point GetCoords()
        {
            return new Point(X, Y);
        }

        public Label GetVariableName(int index)
        {
            return this.VariablesNames[index];
        }

        public TextBox GetName(int index)
        {
            return this.Names[index];
        }

        public Label GetVariableValue(int index)
        {
            return VariablesValues[index];
        }

        public TextBox GetValue(int index)
        {
            return this.Values[index];
        }
        private Label CreateLabel(string text)
        {
            Label tmp = new Label();
            tmp.Text = text;
            tmp.Size = this.LabelSize;
            tmp.Location = GetCoords();
            tmp.Font = new Font(new FontFamily("Lucida Console"), (float)12.25, FontStyle.Italic);
            return tmp;
        }

        private TextBox CreateTextBox()
        {
            TextBox tmp = new TextBox();
            tmp.Size = this.TextBoxSize;
            tmp.Location = GetCoords();
            tmp.Font = new Font(new FontFamily("Lucida Console"), (float)12.25, FontStyle.Italic);
            return tmp;
        }

        public int GetCount()
        {
            return this.Count;
        }
    }
}
