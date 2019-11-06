using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;

namespace CamadaDAL
{
    public class AcessoDados
    {
        // -------------------------------------------------------------------------------------------------------
        // DECLARAÇÃO DAS VARIÁVEIS
        // -------------------------------------------------------------------------------------------------------
        private OleDbConnection conn;
        private OleDbCommand cmd;
        private OleDbTransaction trans;
        private readonly List<OleDbParameter> ParamList = new List<OleDbParameter>();
		private string _dataBasePath;

		// NEW CONSTRUCTOR
		public AcessoDados(string dataBasePath)
        {
			_dataBasePath = dataBasePath; // backup DATABASE path

			if (!Connect(dataBasePath))
            {
                return;
            }
        }
        
        // OPEN CONNECTION
        private bool Connect(string dataBasePath)
        {
            string connstr = "Provider=Microsoft.Jet.OleDb.4.0; Data Source=" + dataBasePath;
            bool bln = false;
            
            if (conn == null) {
                try
                {
                    //connstr = GetConnectionString();
                    if (connstr != string.Empty)
                    {
                        conn = new OleDbConnection(connstr);
                        bln = true;
                    }
                    else
                    {
                        bln = false;
                    }
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
            
            if (conn.State == ConnectionState.Closed)
            {
                try
                {
                    conn.Open();
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }

            return bln;

        }

        // CLOSE CONNECTION
        public void CloseConn()
        {
            if (conn.State != ConnectionState.Closed)
            {
                conn.Close();
            }
        }

        // CLEAR PARAMETERS
        public void LimparParametros()
        {
            ParamList.Clear();
        }
        
        // ADD PARAMETERS
        public void AdicionarParametros(string nomeParametro, object valorParametro)
        {
            ParamList.Add(new OleDbParameter(nomeParametro, valorParametro));
        }

        // ==============================================================================
        #region DATABASE CRUD COMMANDS

        // EXECUTAR MANIPULACAO
        public void ExecutarManipulacao(CommandType commandType, string nomeStoredProcedureOuTextoSQL)
        {
            try
            {
				if (conn.State == ConnectionState.Closed)
				{
					// try connect
					Connect(_dataBasePath);
					// Check Again
					if (conn.State == ConnectionState.Closed)
						throw new Exception("Sem conexão ao Database...");
				}

				cmd = new OleDbConnection().CreateCommand();
                cmd.Connection = conn;
                cmd.CommandType = commandType;
                cmd.CommandText = nomeStoredProcedureOuTextoSQL;
                cmd.CommandTimeout = 7200;

                ParamList.ForEach(p => cmd.Parameters.Add(p));

                if (!isTran)
                {
                    cmd.ExecuteScalar();
                    CloseConn();
                }
                else
                {
                    cmd.Transaction = trans;
                    cmd.ExecuteScalar();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DataTable ExecutarConsulta(CommandType commandType, string nomeStoredProcedureOuTextoSQL)
        {
            try
            {
                if (conn.State == ConnectionState.Closed)
                {
					// try connect
					Connect(_dataBasePath);
					// Check Again
					if (conn.State == ConnectionState.Closed)
						throw new Exception("Sem conexão ao Database...");
				}

				cmd = new OleDbConnection().CreateCommand();
                cmd.Connection = conn;
                cmd.CommandType = commandType;
                cmd.CommandText = nomeStoredProcedureOuTextoSQL;
                cmd.CommandTimeout = 7200;

                if (isTran) cmd.Transaction = trans;

                ParamList.ForEach(p => cmd.Parameters.Add(p));

                OleDbDataAdapter da = new OleDbDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                if (!isTran) CloseConn();

                return dt;

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

		#endregion

		// ==============================================================================
		#region TRANSACTION

		// BEGIN TRANSACTION
		public void BeginTransaction()
        {
            if (isTran) return;

            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }

            trans = conn.BeginTransaction();
            isTran = true;

        }

        // COMMIT TRANSACTION
        public void CommitTransaction()
        {
            if (!isTran) return;
            trans.Commit();
            conn.Close();
            trans = null;
            isTran = false;
        }

        // ROOLBACK TRANSACTION
        public void RollBackTransaction()
        {
            if (!isTran) return;
            trans.Rollback();
            conn.Close();
            trans = null;
            isTran = false;
        }

        // PROPERTY ISTRAN
        public bool isTran { get; set; }

        #endregion

    }
}
