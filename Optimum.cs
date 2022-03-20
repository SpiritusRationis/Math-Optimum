using System;
using System.Collections.Generic;
using System.IO;
using System.Threading;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace Optimum
{
    public partial class Optimum : Form
    {
        private VisualDisplayOfTheVariableField VisualVar = new VisualDisplayOfTheVariableField();
        private int R = 1;
        private NelderMeadMethod method;
        public Optimum()
        {
            InitializeComponent();
            AddVar();
        }

        public void SetR()
        {
            InfoSLabel.Text = R.ToString();
        }

        public void AddVar()
        {
            VisualVar.AddElement();
            VarPanel.Controls.Add(VisualVar.GetVariableName(VisualVar.GetCount() - 1));
            VarPanel.Controls.Add(VisualVar.GetName(VisualVar.GetCount() - 1));
            VarPanel.Controls.Add(VisualVar.GetVariableValue(VisualVar.GetCount() - 1));
            VarPanel.Controls.Add(VisualVar.GetValue(VisualVar.GetCount() - 1));
            R++;
            SetR();
        }

        public void Remove()
        {
            VarPanel.Controls.Remove(VisualVar.GetVariableName(VisualVar.GetCount() - 1));
            VarPanel.Controls.Remove(VisualVar.GetName(VisualVar.GetCount() - 1));
            VarPanel.Controls.Remove(VisualVar.GetVariableValue(VisualVar.GetCount() - 1));
            VarPanel.Controls.Remove(VisualVar.GetValue(VisualVar.GetCount() - 1));
            VisualVar.RemoveElement();
            R--;
            SetR();
        }

        public void RemoveAll()
        {
            while (VisualVar.GetCount() > 0)
            {
                Remove();
            }
        }

        public void RemoveVar()
        {
            if (VisualVar.GetCount() < 2)
            {
                MessageBox.Show("To calculate expressions without variables, use the calculator", "Optimum", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                Remove();
            }
        }

        public Data GetData()
        {
            string Function;
            List<string> VarName = new List<string>();
            List<double> VarValue = new List<double>();

            Function = FuncInput.Text;

            if (Function == "")
                throw new Exception("Function is empty!");

            for (int i = 0; i < VisualVar.GetCount(); i++)
            {
                VarName.Add(VisualVar.GetName(i).Text);
                VarValue.Add(Convert.ToDouble(VisualVar.GetValue(i).Text));
            }

            return new Data(Function, VarName, VarValue);
        }

        public void SetData(Data data)
        {
            RemoveAll();

            FuncInput.Text = data.Function;

            for (int i = 0; i < data.VarValue.Count; i++)
            {
                AddVar();
                VisualVar.GetName(i).Text = data.VarName[i];
                VisualVar.GetValue(i).Text = data.VarValue[i].ToString();
            }
        }

        public void DownloadInputData()
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "File of extensible markup language (*.xml)|*.xml";
            saveFileDialog.DefaultExt = ".xml";
            saveFileDialog.FileName = "Function_" + DateTime.Now.Year + "-" + DateTime.Now.Month + "-" + DateTime.Now.Day + " " + DateTime.Now.Hour + "-" + DateTime.Now.Minute + "-" + DateTime.Now.Second;

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                Data data = GetData();

                using (FileStream stream = new FileStream(saveFileDialog.FileName, FileMode.OpenOrCreate))
                {
                    XmlSerializer xmlSerializer = new XmlSerializer(typeof(Data));
                    xmlSerializer.Serialize(stream, data);
                }
            }
        }

        public void UploadInputData()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "File of extensible markup language (*.xml)|*.xml";
            openFileDialog.DefaultExt = ".xml";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                using (FileStream stream = new FileStream(openFileDialog.FileName, FileMode.Open))
                {
                    XmlSerializer xmlSerializer = new XmlSerializer(typeof(Data));
                    Data data = xmlSerializer.Deserialize(stream) as Data;
                    SetData(data);
                }
            }
        }

        public void DownloadOutputData()
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Text file (*.txt)|*.txt";
            saveFileDialog.DefaultExt = ".txt";
            saveFileDialog.FileName = "Report_" + DateTime.Now.Year + "-" + DateTime.Now.Month + "-" + DateTime.Now.Day + " " + DateTime.Now.Hour + "-" + DateTime.Now.Minute + "-" + DateTime.Now.Second;

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {


                using (FileStream stream = new FileStream(saveFileDialog.FileName, FileMode.OpenOrCreate))
                {
                    using (StreamWriter sw = new StreamWriter(stream))
                    {
                        sw.Write(OutText.Text);
                    }
                }
            }
        }

        public void UploadOutputData()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Text files (*.txt)|*.txt";
            openFileDialog.DefaultExt = ".txt";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                using (FileStream stream = new FileStream(openFileDialog.FileName, FileMode.Open))
                {
                    using (StreamReader sr = new StreamReader(stream))
                    {
                        OutText.Text = sr.ReadToEnd();
                    }
                }
            }
        }

        public bool Check(bool view = true)
        {
            try
            {
                Function func = new Function(GetData());
                SpatialPoint sp = func.GetSpatialPoint();
                if (view)
                    OutText.Text = func.f(sp).ToString();
                return true;
            }
            catch (Exception)
            {
                MessageBox.Show("The input string was not in the correct format!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

        }

        public void Computing()
        {
            if (!Check(false))
                return;
            try
            {
                method = new NelderMeadMethod(GetData(), Convert.ToDouble(EpseelonBox.Text));
                method.Completed += Complete;
                ComputingButton.Enabled = false;

                Thread thread = new Thread(method.MethodOfNelderMead);
                thread.Start();
            }
            catch (Exception)
            {
                MessageBox.Show("The input string was not in the correct format!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ComputingButton.Enabled = true;
            }

        }

        public void Abort()
        {
            if(method != null)
                method.Cancel();
            ComputingButton.Enabled = true;
        }

        private void Complete(bool cancelled)
        {
            Action action = () =>
            {
                string message = cancelled ? "Process aborted" : "Process completed";
                MessageBox.Show(message, "Optimum", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ComputingButton.Enabled = true;

                if (method.GetResult() == null || method.GetDescription() == null)
                    return;

                SpatialPoint[] Result = method.GetResult();

                OutText.Text = "";
                OutText.Text += method.GetDescription();
                OutText.Text += Environment.NewLine;
                OutText.Text += "Result: " + Environment.NewLine;

                for (int i = 0; i < Result.Length; i++)
                {
                    OutText.Text += Result[i].ToString() + Environment.NewLine;
                }
            };

            if (InvokeRequired)
                Invoke(action);
            else
                action();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            AddVar();
        }

        private void RemoveButton_Click(object sender, EventArgs e)
        {
            RemoveVar();
        }

        private void CheckButton_Click(object sender, EventArgs e)
        {
            Check();
        }

        private void AbortButton_Click(object sender, EventArgs e)
        {
            Abort();
        }

        private void ComputingButton_Click(object sender, EventArgs e)
        {
            Computing();
        }

        private void openFileOfFunctionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UploadInputData();
        }

        private void openFileOfResultToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UploadOutputData();
        }

        private void saveFileOfFunctionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DownloadInputData();
        }

        private void saveFileOfResultToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DownloadOutputData();
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Help().Show();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new About().Show();
        }
    }
}
