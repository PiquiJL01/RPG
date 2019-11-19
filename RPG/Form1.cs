using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Engine;

namespace RPG
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            Player player = new Player("Hero", 1, 10, 5, 5, 2, 5, 2, 5, 2, 5, 2, 5, 2, 50);


        }
    }
}
