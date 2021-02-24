using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace conexão
{
    class Conecxão
    {
        //"server=localhost;port=3307;User Id=root;database=acr_2v; password=usbw

       private String server, port, id, database, password;

        public Conecxão(String server,String port,String id,String database,String password)
        {
            this.server = server;
            this.port = port;
            this.password = password;
            this.id = id;
            this.database = database;
        }

        public String getconexao()
        {
            String retorno = "server="+server+";port="+port+";User Id="+id+";database="+database+"; password="+password;
            return retorno;
        }
        
    }
}
