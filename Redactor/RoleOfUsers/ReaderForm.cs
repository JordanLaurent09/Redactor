using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Redactor.RoleOfUsers
{
    public partial class ReaderForm : Form
    {
        public User ReaderUser { get; set; }
        public ReaderForm(User reader)
        {
            InitializeComponent();
            ReaderUser = reader;
        }
    }
}
