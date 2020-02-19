using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SLA
{
    class Connection
    {
        //12/02/2020 - Amonrá ,Guilherme - Metodo da classe que retorna o caminho da conexão
        public static string ConnectionPath()
        {
            return @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\amon.rkdomeneguet\Documents\Visual Studio 2015\Projects\SLA\SLA\BD_LOCACAO.mdf;Integrated Security=True; Connect Timeout = 30";
        }
    }
}