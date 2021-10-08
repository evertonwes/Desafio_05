using MySql;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MySqlConexaoCsharp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            if (Conectar())
                MessageBox.Show("Conexão Bem Sucedida!");
        }

        private bool Conectar()
        {
            var result = false;

            try
            {
                using (var cn = new MySqlConnection(Conection.srtConection))
                {
                    cn.Open();
                    result = true;
                }                                              
            }
            catch (Exception ex)
            {
                result = false;
                MessageBox.Show("Error: " + ex.Message);
            }

            return result;
        }
    }
}
