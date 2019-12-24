using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
namespace SDM.DAL
{
    public partial class jiating
    {
        public jiating()
		{}
		#region  BasicMethod

		public bool Exists(int jiatingid)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from JiatingInfo");
			strSql.Append(" where 家庭编号=@家庭编号");
			SqlParameter[] parameters = {
					new SqlParameter("@家庭编号", SqlDbType.Int,4)
			};
			parameters[0].Value = jiatingid;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int Add(SDM.Model.jiating model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into JiatingInfo(");
			strSql.Append("户口所在地,描述)");
			strSql.Append(" values (");
			strSql.Append("@户口所在地,@描述)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@户口所在地", SqlDbType.NVarChar,250),
					new SqlParameter("@描述", SqlDbType.NVarChar,250)};
			parameters[0].Value = model.Hkszd;
			parameters[1].Value = model.Miaoshu;

			object obj = DbHelperSQL.GetSingle(strSql.ToString(),parameters);
			if (obj == null)
			{
				return 0;
			}
			else
			{
				return Convert.ToInt32(obj);
			}
		}
		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(SDM.Model.jiating model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update JiatingInfo set ");
			strSql.Append("户口所在地=@户口所在地,");
			strSql.Append("描述=@描述");
			strSql.Append(" where 家庭编号=@家庭编号");
			SqlParameter[] parameters = {
					new SqlParameter("@户口所在地", SqlDbType.NVarChar,250),
					new SqlParameter("@描述", SqlDbType.NVarChar,250),
					new SqlParameter("@家庭编号", SqlDbType.Int,4)};
			parameters[0].Value = model.Hkszd;
			parameters[1].Value = model.Miaoshu;
			parameters[2].Value = model.Jiating;

			int rows=DbHelperSQL.ExecuteSql(strSql.ToString(),parameters);
			if (rows > 0)
			{
				return true;
			}
			else
			{
				return false;
			}
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool Delete(int jiatingid)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from JiatingInfo ");
			strSql.Append(" where 家庭编号=@家庭编号");
			SqlParameter[] parameters = {
					new SqlParameter("@家庭编号", SqlDbType.Int,4)
			};
			parameters[0].Value = jiatingid;

			int rows=DbHelperSQL.ExecuteSql(strSql.ToString(),parameters);
			if (rows > 0)
			{
				return true;
			}
			else
			{
				return false;
			}
		}
		/// <summary>
		/// 批量删除数据
		/// </summary>
		public bool DeleteList(string AdminIDlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from JiatingInfo ");
			strSql.Append(" where 户口所在地in ("+AdminIDlist + ")  ");
			int rows=DbHelperSQL.ExecuteSql(strSql.ToString());
			if (rows > 0)
			{
				return true;
			}
			else
			{
				return false;
			}
		}


		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public SDM.Model.jiating GetModel(int AdminID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 家庭编号,户口所在地,描述 from JiatingInfo ");
			strSql.Append(" where 家庭编号=@家庭编号");
			SqlParameter[] parameters = {
					new SqlParameter("@家庭编号", SqlDbType.Int,4)
			};
			parameters[0].Value = AdminID;

			SDM.Model.jiating model=new SDM.Model.jiating();
			DataSet ds=DbHelperSQL.Query(strSql.ToString(),parameters);
			if(ds.Tables[0].Rows.Count>0)
			{
				return DataRowToModel(ds.Tables[0].Rows[0]);
			}
			else
			{
				return null;
			}
		}


		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public SDM.Model.jiating DataRowToModel(DataRow row)
		{
			SDM.Model.jiating model=new SDM.Model.jiating();
			if (row != null)
			{
				if(row["家庭编号"]!=null && row["家庭编号"].ToString()!="")
				{
					model.Jiating=int.Parse(row["家庭编号"].ToString());
				}
				if(row["户口所在地"]!=null)
				{
					model.Hkszd=row["户口所在地"].ToString();
				}
				if(row["描述"]!=null)
				{
					model.Miaoshu=row["描述"].ToString();
				}
			}
			return model;
		}

		/// <summary>
		/// 获得数据列表
		/// </summary>
		public DataSet GetList(string strWhere)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select 家庭编号,户口所在地,描述 ");
			strSql.Append(" FROM JiatingInfo ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			return DbHelperSQL.Query(strSql.ToString());
		}

		/// <summary>
		/// 获得前几行数据
		/// </summary>
		public DataSet GetList(int Top,string strWhere,string filedOrder)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select ");
			if(Top>0)
			{
				strSql.Append(" top "+Top.ToString());
			}
			strSql.Append(" 家庭编号,户口所在地,描述 ");
			strSql.Append(" FROM JiatingInfo ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			strSql.Append(" order by " + filedOrder);
			return DbHelperSQL.Query(strSql.ToString());
		}

		/// <summary>
		/// 获取记录总数
		/// </summary>
		public int GetRecordCount(string strWhere)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) FROM JiatingInfo ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			object obj = DbHelperSQL.GetSingle(strSql.ToString());
			if (obj == null)
			{
				return 0;
			}
			else
			{
				return Convert.ToInt32(obj);
			}
		}
		/// <summary>
		/// 分页获取数据列表
		/// </summary>
		public DataSet GetListByPage(string strWhere, string orderby, int startIndex, int endIndex)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("SELECT * FROM ( ");
			strSql.Append(" SELECT ROW_NUMBER() OVER (");
			if (!string.IsNullOrEmpty(orderby.Trim()))
			{
				strSql.Append("order by T." + orderby );
			}
			else
			{
				strSql.Append("order by T.AdminID desc");
			}
			strSql.Append(")AS Row, T.*  from AdminInfo T ");
			if (!string.IsNullOrEmpty(strWhere.Trim()))
			{
				strSql.Append(" WHERE " + strWhere);
			}
			strSql.Append(" ) TT");
			strSql.AppendFormat(" WHERE TT.Row between {0} and {1}", startIndex, endIndex);
			return DbHelperSQL.Query(strSql.ToString());
		}

		
    
    	
		
       
		#endregion  ExtensionMethod

    }
}
