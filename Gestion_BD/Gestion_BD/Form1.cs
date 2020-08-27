using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestion_BD
{
    public partial class Form1 : Form
    {
        private BD_Connect _bdConnect;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnConnexionDB_Click(object sender, EventArgs e)
        {
            _bdConnect = new BD_Connect();
        }

        private void btnDecoDB_Click(object sender, EventArgs e)
        {
            _bdConnect.closeConnection();
        }

        private void btnListDB_Click(object sender, EventArgs e)
        {
            List<string> _listDB = new List<string>();
            _listDB = _bdConnect.showDatabases();
            foreach (string db in _listDB)
            {
                cbListDB.Items.Add(db);
            }
        }
    }
}
