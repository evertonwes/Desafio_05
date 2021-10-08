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
    static class Conection
    {
        static private string servidor = "localhost";
        static private string bancoDados = "cadastro";
        static private string usuario = "root";
        static private string senha = "";



        static public string srtConection = $"server={servidor}; database={bancoDados}; User={usuario}; password={senha}";
        
    }
}
