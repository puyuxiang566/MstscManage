using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Globalization;
using System.IO;
using System.Data.SQLite;

namespace MstscManage.Helper
{
	public class SQLiteHelper
	{
		public SQLiteConnection GetSQLiteConnection()
		{
			return new SQLiteConnection("Data Source=" + SQLiteHelper.DatabaseName + ";Pooling=True");
		}

		public void EnsureDatabaseExists()
		{
			string dbPath = SQLiteHelper.DatabaseName;
			bool needCreate = false;
			if (!File.Exists(dbPath))
			{
				needCreate = true;
			}
			else
			{
				try
				{
					using (FileStream fs = new FileStream(dbPath, FileMode.Open, FileAccess.Read))
					{
						byte[] header = new byte[16];
						int read = fs.Read(header, 0, 16);
						if (read < 16)
						{
							needCreate = true;
						}
						else
						{
							string headerStr = System.Text.Encoding.ASCII.GetString(header);
							if (!headerStr.StartsWith("SQLite format 3"))
							{
								needCreate = true;
							}
						}
					}
				}
				catch
				{
					needCreate = true;
				}
			}

			if (needCreate)
			{
				try
				{
					if (File.Exists(dbPath))
					{
						string backupPath = dbPath + ".backup." + DateTime.Now.ToString("yyyyMMddHHmmss");
						File.Move(dbPath, backupPath);
					}
				}
				catch { }

			using (SQLiteConnection conn = this.GetSQLiteConnection())
			{
				conn.Open();
				string createTableSql = @"CREATE TABLE IF NOT EXISTS HostServers (
						Id INTEGER PRIMARY KEY AUTOINCREMENT,
						SortNumber INTEGER,
						ServerName TEXT,
						Server TEXT,
						Port INTEGER,
						Username TEXT,
						Password TEXT,
						Description TEXT,
						ColorDepth INTEGER,
						DesktopWidth INTEGER,
						DesktopHeight INTEGER,
						Fullscreen INTEGER,
						Grouping TEXT,
						RemoteType TEXT
					);";
					using (SQLiteCommand cmd = new SQLiteCommand(createTableSql, conn))
					{
						cmd.ExecuteNonQuery();
					}
				}
			}
		}

		public List<string> GetTableList()
		{
			DataTable MasterTable = this.ExecuteDataTable("select * from sqlite_sequence ", new object[0]);
			List<string> TableList = new List<string>();
			foreach (object obj in MasterTable.Rows)
			{
				DataRow item = (DataRow)obj;
				string Name = item["name"].ToString();
				TableList.Add(Name);
			}
			return TableList;
		}

		public void ChangePassword(string newPassword)
		{
		}

		private void PrepareCommand(SQLiteCommand cmd, SQLiteConnection conn, string cmdText, params object[] p)
		{
			bool flag = conn.State == ConnectionState.Closed;
			if (flag)
			{
				conn.Open();
			}
			cmd.Parameters.Clear();
			cmd.Connection = conn;
			cmd.CommandText = cmdText;
			cmd.CommandType = CommandType.Text;
			cmd.CommandTimeout = 30;
			bool flag2 = p != null;
			if (flag2)
			{
				foreach (object item in p)
				{
					cmd.Parameters.AddWithValue(string.Empty, item);
				}
			}
		}

		public DataSet ExecuteDataset(string cmdText, params object[] p)
		{
			DataSet ds = new DataSet();
			using (SQLiteConnection conn = this.GetSQLiteConnection())
			{
				SQLiteCommand cmd = new SQLiteCommand();
				this.PrepareCommand(cmd, conn, cmdText, p);
				SQLiteDataReader reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);
				DataTable dt = new DataTable();
				dt.Load(reader);
				ds.Tables.Add(dt);
			}
			return ds;
		}

		public DataTable ExecuteDataTable(string cmdText, params object[] p)
		{
			DataSet ds = this.ExecuteDataset(cmdText, p);
			bool flag = ds.Tables.Count > 0;
			DataTable result;
			if (flag)
			{
				result = ds.Tables[0];
			}
			else
			{
				result = null;
			}
			return result;
		}

		public DataTable ExecuteDataTable_FullTable(string TableName)
		{
			string commandText = "SELECT * FROM " + TableName;
			return this.ExecuteDataTable(commandText, new object[0]);
		}

		public DataRow ExecuteDataRow(string cmdText, params object[] p)
		{
			DataSet ds = this.ExecuteDataset(cmdText, p);
			bool flag = ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0;
			DataRow result;
			if (flag)
			{
				result = ds.Tables[0].Rows[0];
			}
			else
			{
				result = null;
			}
			return result;
		}

		public int ExecuteNonQuery(string cmdText, SQLiteParameter[] Parameters)
		{
			SQLiteCommand cmd = new SQLiteCommand();
			int result;
			using (SQLiteConnection conn = this.GetSQLiteConnection())
			{
				SQLiteHelper.PrepareCommand(cmd, conn, cmdText, Parameters);
				result = cmd.ExecuteNonQuery();
			}
			return result;
		}

		private static void PrepareCommand(SQLiteCommand cmd, SQLiteConnection conn, string sqlStr, params SQLiteParameter[] p)
		{
			try
			{
				bool flag = conn.State != ConnectionState.Open;
				if (flag)
				{
					conn.Open();
				}
				cmd.Parameters.Clear();
				cmd.Connection = conn;
				cmd.CommandText = sqlStr;
				cmd.CommandType = CommandType.Text;
				cmd.CommandTimeout = 30;
				bool flag2 = p != null;
				if (flag2)
				{
					foreach (SQLiteParameter parm in p)
					{
						cmd.Parameters.AddWithValue(parm.ParameterName, parm.Value);
					}
				}
			}
			catch (Exception)
			{
			}
		}

		public int ExecuteNonQuery(string cmdText, params object[] p)
		{
			SQLiteCommand cmd = new SQLiteCommand();
			int result;
			using (SQLiteConnection conn = this.GetSQLiteConnection())
			{
				this.PrepareCommand(cmd, conn, cmdText, p);
				result = cmd.ExecuteNonQuery();
			}
			return result;
		}

		public SQLiteDataReader ExecuteReader(string cmdText, params object[] p)
		{
			SQLiteCommand cmd = new SQLiteCommand();
			SQLiteConnection conn = this.GetSQLiteConnection();
			this.PrepareCommand(cmd, conn, cmdText, p);
			SQLiteDataReader reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);
			return reader;
		}

		public object ExecuteScalar(string cmdText, params object[] p)
		{
			SQLiteCommand cmd = new SQLiteCommand();
			object result;
			using (SQLiteConnection conn = this.GetSQLiteConnection())
			{
				this.PrepareCommand(cmd, conn, cmdText, p);
				result = cmd.ExecuteScalar();
			}
			return result;
		}

		public string ExecuteScalarString(string cmdText, params object[] p)
		{
			object value = this.ExecuteScalar(cmdText, p);
			bool flag = !Convert.IsDBNull(value) && value != null;
			string result;
			if (flag)
			{
				result = value.ToString();
			}
			else
			{
				result = "";
			}
			return result;
		}

		public int ExecuteScalarInt(string cmdText, params object[] p)
		{
			object value = this.ExecuteScalar(cmdText, p);
			return value.ToInt32ByDBNull(0, NumberStyles.Any, null);
		}

		public DataSet ExecutePager(ref int recordCount, int pageIndex, int pageSize, string cmdText, string countText, params object[] p)
		{
			bool flag = recordCount < 0;
			if (flag)
			{
				recordCount = int.Parse(this.ExecuteScalar(countText, p).ToString());
			}
			DataSet ds = new DataSet();
			using (SQLiteConnection connection = this.GetSQLiteConnection())
			{
				SQLiteCommand command = new SQLiteCommand();
				this.PrepareCommand(command, connection, cmdText, p);
				SQLiteDataReader reader = command.ExecuteReader(CommandBehavior.CloseConnection);
				DataTable dt = new DataTable();
				dt.Load(reader);
				ds.Tables.Add(dt);
			}
			return ds;
		}

		private string InsertHead { get; set; }

		private string[] Separators { get; set; }

		private string InsertCmdText { get; set; }

		private int ColCount { get; set; }

		private string[] Fields { get; set; }

		public void InitFields(DataTable dt)
		{
			List<string> myFields = new List<string>();
			List<string> mySeparators = new List<string>();
			List<string> valueVars = new List<string>();
			this.ColCount = dt.Columns.Count;
			for (int i = 0; i < this.ColCount; i++)
			{
				string colName = dt.Columns[i].ColumnName;
				myFields.Add(colName);
				mySeparators.Add(this.GetSeperator(dt.Columns[i].DataType.ToString()));
				valueVars.Add("@" + colName);
			}
			string NameItem = "[" + string.Join("],[", myFields.ToArray()) + "]";
			this.InsertHead = string.Format("insert into {0} ({1})", dt.TableName, NameItem);
			this.Separators = mySeparators.ToArray();
			this.InsertCmdText = string.Format("{0} values ({1})", this.InsertHead, string.Join(",", valueVars.ToArray()));
			this.Fields = myFields.ToArray();
		}

		private string GetSeperator(string typeName)
		{
			return (typeName == "System.String") ? "'" : typeName;
		}

		public string GenInsertSql(DataRow dr)
		{
			List<string> strs = new List<string>();
			for (int i = 0; i < this.ColCount; i++)
			{
				bool flag = DBNull.Value == dr[i];
				if (flag)
				{
					strs.Add("null");
				}
				else
				{
					strs.Add(string.Format("{0}{1}{0}", this.Separators[i], dr[i].ToString()));
				}
			}
			return string.Format("{0} values ({1})", this.InsertHead, string.Join(",", strs.ToArray()));
		}

		private void ImportToSqliteBatch(DataTable DataSource)
		{
			this.InitFields(DataSource);
			using (SQLiteConnection conn = this.GetSQLiteConnection())
			{
				using (SQLiteCommand insertCmd = conn.CreateCommand())
				{
					insertCmd.CommandText = this.InsertCmdText;
					conn.Open();
					SQLiteTransaction tranction = conn.BeginTransaction();
					foreach (object obj in DataSource.Rows)
					{
						DataRow dr = (DataRow)obj;
						for (int i = 0; i < this.ColCount; i++)
						{
							object o = null;
							string paraName = "@" + this.Fields[i];
							bool flag = DBNull.Value != dr[this.Fields[i]];
							if (flag)
							{
								o = dr[this.Fields[i]];
							}
							insertCmd.Parameters.AddWithValue(paraName, o);
						}
						insertCmd.ExecuteNonQuery();
					}
					tranction.Commit();
				}
			}
		}

		private static string DatabaseName = System.Windows.Forms.Application.StartupPath + "\\MstscManage.db";

	}
}
