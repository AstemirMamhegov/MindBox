using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MDIForm
{
    public partial class FrmMain : Form
    {

        private List<DTOState> _listState = new List<DTOState>();
        private string _pathToFileState = string.Empty;


        public FrmMain()
        {
            InitializeComponent();
            
        }


        private void FrmMain_Load(object sender, EventArgs e)
        {

            _pathToFileState = System.IO.Directory.GetCurrentDirectory() + "\\state.txt";

            if (File.Exists(_pathToFileState))
            {

                _listState = LoadStateList();

                foreach (DTOState state in _listState)
                {

                    СhildForm childForm = new СhildForm();
                    
                    childForm.StartPosition = FormStartPosition.Manual;
                    childForm.Location = state.Location;
                    childForm.MdiParent = this;
                    childForm.Size = state.Size;
                    childForm.Show();

                    string title = $"Форма {state.Index} [Координаты: {state.Location.ToString()}] [Размеры: {state.Size.ToString()}]";

                    childForm.Text = title;

                }


            }


        }


        private void CreateFormToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Int32 count = this.MdiChildren.Count();

            СhildForm childForm = new СhildForm();
            childForm.Text = "Форма " + count;
            childForm.MdiParent = this;
            childForm.Show();

        }


        private void FrmMain_FormClosing(object sender, FormClosingEventArgs e)
        {

            List<Form> listForms = this.MdiChildren.ToList();

            _listState.Clear();

            Int32 index = 0;
            foreach (Form item in listForms)
            {
                
                DTOState state = new DTOState(index, item.Location, item.Size);
                _listState.Add(state);

                index++;
            }

            Store();

        }

        private void Store()
        {

            var stream = new MemoryStream();
            var ser = new DataContractJsonSerializer(typeof(List<DTOState>));

            ser.WriteObject(stream, _listState);
            stream.Position = 0;

            var sr = new StreamReader(stream);

            File.WriteAllBytes(_pathToFileState, Encoding.ASCII.GetBytes(sr.ReadToEnd()));

        }

        private List<DTOState> LoadStateList()
        {

            var stream = new MemoryStream(File.ReadAllBytes(_pathToFileState));
            stream.Position = 0;

            var ser = new DataContractJsonSerializer(typeof(List<DTOState>));

            return (List<DTOState>)ser.ReadObject(stream);

        }



    }
}
