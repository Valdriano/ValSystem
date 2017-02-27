using System;

namespace ValSystem.Connection
{
    class Versao : Connections, IVersao
    {
        public void V1000()
        {
            try
            {
                //Tabela Versão 
                Cmd( "CREATE TABLE Versao (VersaoApp VarChar(30), VersaoDB VarChar(30), DataAtualizacaoApp DateTime, DataAtualizacaoDB DateTime" );

            }
            catch ( Exception ex )
            {

                throw new Exception( ex.Message );
            }
        }
    }
}
