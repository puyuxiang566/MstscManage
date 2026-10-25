using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Data.SQLite;

namespace MstscManage.Helper
{
	public class HostServersDal : SQLiteHelper
	{
		public List<HostServers> ReadAllHost(string GroupingValue, string SearchValue)
		{
			string sql = "SELECT * FROM HostServers where 1=1";
			bool flag = GroupingValue != "全部主机";
			if (flag)
			{
				sql = sql + " and Grouping='" + GroupingValue + "' ";
			}
			sql += SearchValue;
			sql += " order by SortNumber";
			DataTable ServersTable = base.ExecuteDataTable(sql, new object[0]);
			List<HostServers> HostInformation = new List<HostServers>();
			foreach (object obj in ServersTable.Rows)
			{
				DataRow item = (DataRow)obj;
				HostInformation.Add(new HostServers
				{
					Id = item["Id"].ToInt32ByDBNull(0, NumberStyles.Any, null),
					SortNumber = item["SortNumber"].ToInt32ByDBNull(0, NumberStyles.Any, null),
					ServerName = item["ServerName"].ToString(),
					Server = item["Server"].ToString(),
					Port = item["Port"].ToInt32ByDBNull(0, NumberStyles.Any, null),
					Username = item["Username"].ToString(),
					Password = item["Password"].ToString(),
					Description = item["Description"].ToString(),
					ColorDepth = item["ColorDepth"].ToInt32ByDBNull(0, NumberStyles.Any, null),
					DesktopWidth = item["DesktopWidth"].ToInt32ByDBNull(0, NumberStyles.Any, null),
					DesktopHeight = item["DesktopHeight"].ToInt32ByDBNull(0, NumberStyles.Any, null),
					Fullscreen = item["Fullscreen"].ToString().ToBooleanNullable().Value,
					Grouping = item["Grouping"].ToString(),
					RemoteType = item["RemoteType"].ToString()
				});
			}
			return HostInformation;
		}

		public int GetMaxSortNumber()
		{
			return base.ExecuteScalarInt("select max(SortNumber)+1000 from HostServers", new object[0]);
		}

		public int GetUpSortNumber(int id)
		{
			return base.ExecuteScalarInt("select SortNumber-1 from HostServers  where SortNumber<(select SortNumber from HostServers where id=" + id.ToString() + ") order by SortNumber desc limit 0,1", new object[0]);
		}

		public int GetDownSortNumber(int id)
		{
			return base.ExecuteScalarInt("select SortNumber+1 from HostServers  where SortNumber>(select SortNumber from HostServers where id=" + id.ToString() + ") order by SortNumber asc limit 0, 1", new object[0]);
		}

		public bool Save(HostServers Details)
		{
			string sql = "INSERT INTO HostServers( SortNumber, ServerName, Server, Port, Username, Password, Description, ColorDepth, DesktopWidth, DesktopHeight, Fullscreen, Grouping, RemoteType) ";
			sql += "VALUES(@SortNumber, @ServerName, @Server, @Port, @Username, @Password, @Description, @ColorDepth, @DesktopWidth, @DesktopHeight, @Fullscreen, @Grouping, @RemoteType)";
			SQLiteParameter[] parameters = new SQLiteParameter[]
			{
				new SQLiteParameter("@SortNumber", Details.SortNumber),
				new SQLiteParameter("@ServerName", Details.ServerName),
				new SQLiteParameter("@Server", Details.Server),
				new SQLiteParameter("@Port", Details.Port),
				new SQLiteParameter("@Username", Details.Username),
				new SQLiteParameter("@Password", Details.Password),
				new SQLiteParameter("@Description", Details.Description),
				new SQLiteParameter("@ColorDepth", Details.ColorDepth),
				new SQLiteParameter("@DesktopWidth", Details.DesktopWidth),
				new SQLiteParameter("@DesktopHeight", Details.DesktopHeight),
				new SQLiteParameter("@Fullscreen", Details.Fullscreen),
				new SQLiteParameter("@Grouping", Details.Grouping),
				new SQLiteParameter("@RemoteType", Details.RemoteType)
			};
			bool flag = base.ExecuteNonQuery(sql, parameters) > 0;
			if (flag)
			{
				string Sql = "select max(id) from HostServers";
				Details.Id = base.ExecuteScalarInt(Sql, new object[0]);
			}
			return true;
		}

		public bool Update(HostServers Details)
		{
			string sql = "update HostServers SET Id=@Id,SortNumber=@SortNumber,ServerName=@ServerName,Server=@Server,\r\n            Port=@Port,Username=@Username,Password=@Password,description=@Description,ColorDepth=@ColorDepth,desktopwidth=@DesktopWidth,\r\n            desktopheight=@DesktopHeight,Fullscreen=@Fullscreen,Grouping=@Grouping,RemoteType=@RemoteType WHERE Id=@Id";
			SQLiteParameter[] parameters = new SQLiteParameter[]
			{
				new SQLiteParameter("@Id", Details.Id),
				new SQLiteParameter("@SortNumber", Details.SortNumber),
				new SQLiteParameter("@ServerName", Details.ServerName),
				new SQLiteParameter("@Server", Details.Server),
				new SQLiteParameter("@Port", Details.Port),
				new SQLiteParameter("@Username", Details.Username),
				new SQLiteParameter("@Password", Details.Password),
				new SQLiteParameter("@Description", Details.Description),
				new SQLiteParameter("@ColorDepth", Details.ColorDepth),
				new SQLiteParameter("@DesktopWidth", Details.DesktopWidth),
				new SQLiteParameter("@DesktopHeight", Details.DesktopHeight),
				new SQLiteParameter("@Fullscreen", Details.Fullscreen),
				new SQLiteParameter("@Grouping", Details.Grouping),
				new SQLiteParameter("@RemoteType", Details.RemoteType)
			};
			return base.ExecuteNonQuery(sql, parameters) > 0;
		}

		public bool DeleteHost(int id)
		{
			string sql = "DELETE FROM HostServers WHERE Id=" + id.ToString();
			return base.ExecuteNonQuery(sql, new object[0]) > 0;
		}
	}
}
