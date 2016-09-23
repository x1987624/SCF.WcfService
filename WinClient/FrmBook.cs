using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using SCF.Common;
using SCF.Model;

namespace WinClient
{
    public partial class FrmBook : Form
    {
        public FrmBook()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            BookServiceRef.BookServiceClient bookSvrClient = new BookServiceRef.BookServiceClient();

            textBoxMsg.Text = bookSvrClient.Search(string.Empty, string.Empty);

            List<Books> books = XMLHelper.DeSerializer<List<Books>>(textBoxMsg.Text);

            gridBooks.DataSource = books;
        }
    }
}
