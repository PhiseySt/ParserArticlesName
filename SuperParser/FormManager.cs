using SuperParser.Core;
using SuperParser.Core.Freelansim;
using SuperParser.Core.Habr;
using System;
using System.Windows.Forms;
using SuperParser.Sites;
using SuperParser.Sites.Habr;

namespace SuperParser
{
    public partial class FormManager : Form
    {
        private readonly ParserWorker<string[]> _parserHabr;
        private readonly ParserWorker<string[]> _parserFreelansim;
        private readonly ParserWorker<string[]> _parserPcs;
        public FormManager()
        {
            InitializeComponent();
            _parserHabr = new ParserWorker<string[]>(new HabrParser());
            _parserHabr.OnComplited += Parser_OnComplited;
            _parserHabr.OnNewData += Parser_OnNewData;

            _parserFreelansim = new ParserWorker<string[]>(new FreelansimParser());
            _parserFreelansim.OnComplited += Parser_OnComplited;
            _parserFreelansim.OnNewData += Parser_OnNewData;

            _parserPcs = new ParserWorker<string[]>(new ProgrammingCsParser());
            _parserPcs.OnComplited += Parser_OnComplited;
            _parserPcs.OnNewData += Parser_OnNewData;
        }

        public void Parser_OnComplited(object o) => MessageBox.Show("Работа завершена!");
        public void Parser_OnNewData(object o, string[] str) => ResultTextBox.Items.AddRange(str);

        private void buttonClear_Click(object sender, EventArgs e) => ResultTextBox.Items.Clear();

        private void buttonClose_Click(object sender, EventArgs e)
        {
            _parserHabr.Stop();
            _parserFreelansim.Stop();
            _parserPcs.Stop();
        }

        private void buttonHabr_Click(object sender, EventArgs e)
        {
            _parserHabr.Settings = new HabrSettings((int)numericUpDownStart.Value, (int)numericUpDownEnd.Value);
            _parserHabr.Start();
        }

        private void buttonFreelansim_Click(object sender, EventArgs e)
        {
            _parserFreelansim.Settings = new FreelansimSettings((int)numericUpDownStart.Value, (int)numericUpDownEnd.Value);
            _parserFreelansim.Start();
        }

        private void buttonPCS_Click(object sender, EventArgs e)
        {
            _parserPcs.Settings = new ProgrammingCSharpSettings((int)numericUpDownStart.Value, (int)numericUpDownEnd.Value);
            _parserPcs.Start();
        }

    }
}
