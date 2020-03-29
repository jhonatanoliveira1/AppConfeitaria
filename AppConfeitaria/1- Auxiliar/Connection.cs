using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppConfeitaria
{
    class Connection
    {
        //14/02/2020 -Jhonatan de Oliveira- Metodo da classe que retorna o caminho da conexão
        public static string ConnectionPath()
        {
            return @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\jhony\source\repos\AppConfeitaria\AppConfeitaria\BD_APPCONFEITARIA.mdf;Integrated Security=True; Connect Timeout = 30";
        }
    }
}

