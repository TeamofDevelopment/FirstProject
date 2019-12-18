using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using Word = Microsoft.Office.Interop.Word;

namespace KOMANDA_A
{
    public partial class Form5 : Form
    {
        private readonly string TemplateFileName = @"‪C:\Users\PC\Desktop\коллектив\zadanie_l2_09.02.03\Шаблон договора.docx";
        public Form5()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*var wordApp = new Word.Application();
            wordApp.Visible = false;
            var wordDocument = wordApp.Documents.Open(TemplateFileName);*/
        }
    }
}
