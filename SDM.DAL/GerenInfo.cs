using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;

namespace SDM.DAL
{
    /// <summary>
    /// 数据访问类:StudentsInfo
    /// </summary>
    public partial class GerenInfo
    {
        public GerenInfo()
        { }
        #region  BasicMethod

        /// <summary>
        /// 得到最大ID
        /// </summary>
        /*public int GetMaxId()
        {
        return DbHelperSQL.GetMaxID("UserID", "StudentsInfo"); 
        }
        */
        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(int Gerengianhao)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from GerenInfo");
            strSql.Append(" where 编号=@编号");
            SqlParameter[] parameters = {
					new SqlParameter("@编号", SqlDbType.Int,4)
			};
            parameters[0].Value = Gerengianhao;

            return DbHelperSQL.Exists(strSql.ToString(), parameters);
        }


        /// <summary>
        /// 增加一条数据
        /// </summary>
        public int Add(SDM.Model.GerenInfo model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into GerenInfo(");
            strSql.Append("姓名,字,身份证,性别,生日,籍贯,父家庭编号,母家庭编号,子家庭编号)");
            strSql.Append(" values (");
            strSql.Append("@姓名,@字,@身份证,@性别,@生日,@籍贯,@父家庭编号,@母家庭编号,@子家庭编号)");
            strSql.Append(";select @@IDENTITY");
            SqlParameter[] parameters = {
					
					new SqlParameter("@姓名", SqlDbType.NVarChar,50),
					new SqlParameter("@字", SqlDbType.NVarChar,20),
					new SqlParameter("@身份证", SqlDbType.NVarChar,50),
					new SqlParameter("@性别", SqlDbType.NVarChar,20),
					new SqlParameter("@生日", SqlDbType.NVarChar,50),
					new SqlParameter("@籍贯", SqlDbType.NVarChar,50),
					new SqlParameter("@父家庭编号", SqlDbType.NVarChar,50),
                    new SqlParameter("@母家庭编号", SqlDbType.NVarChar,50),
                    new SqlParameter("@子家庭编号", SqlDbType.NVarChar,50)
                                        
                                        };
          
            parameters[0].Value = model.Name;
            parameters[1].Value = model.Zi;
            parameters[2].Value = model.Sfz;
            parameters[3].Value = model.Sex;
            parameters[4].Value = model.shengri;
            parameters[5].Value = model.Jiguan;
            parameters[6].Value = model.Ffbianhao;
            parameters[7].Value = model.Mfbianhao;
            parameters[8].Value = model.Zfbianhao;

            object obj = DbHelperSQL.GetSingle(strSql.ToString(), parameters);
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
        public bool Update(SDM.Model.GerenInfo model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update GerenInfo set ");
            strSql.Append("姓名=@姓名,");
            strSql.Append("字=@字,");
            strSql.Append("身份证=@身份证,");
            strSql.Append("性别=@性别,");
            strSql.Append("生日=@生日,");
            strSql.Append("籍贯=@籍贯,");
            strSql.Append("父家庭编号=@父家庭编号,");
            strSql.Append("母家庭编号=@母家庭编号,");
            strSql.Append("子家庭编号=@子家庭编号");
            strSql.Append(" where 编号=@编号");
            SqlParameter[] parameters = {

					new SqlParameter("@姓名", SqlDbType.NVarChar,50),
					new SqlParameter("@字", SqlDbType.NVarChar,20),
					new SqlParameter("@身份证", SqlDbType.NVarChar,50),
					new SqlParameter("@性别", SqlDbType.NVarChar,20),
					new SqlParameter("@生日", SqlDbType.NVarChar,50),
					new SqlParameter("@籍贯", SqlDbType.NVarChar,50),
					new SqlParameter("@父家庭编号", SqlDbType.NVarChar,50),
                    new SqlParameter("@母家庭编号", SqlDbType.NVarChar,50),
                    new SqlParameter("@子家庭编号", SqlDbType.NVarChar,50),
                    new SqlParameter("@编号", SqlDbType.Int,4),
                                        
                                        };
            parameters[0].Value = model.Name;
            parameters[1].Value = model.Zi;
            parameters[2].Value = model.Sfz;
            parameters[3].Value = model.Sex;
            parameters[4].Value = model.shengri;
            parameters[5].Value = model.Jiguan;
            parameters[6].Value = model.Ffbianhao;
            parameters[7].Value = model.Mfbianhao;
            parameters[8].Value = model.Zfbianhao;
            parameters[9].Value = model.Bianhao;


            int rows = DbHelperSQL.ExecuteSql(strSql.ToString(), parameters);
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
        public bool Delete(int Bianhao)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from GerenInfo ");
            strSql.Append(" where 编号=@编号");
            SqlParameter[] parameters = {
					new SqlParameter("@编号", SqlDbType.Int,4)
			};
            parameters[0].Value = Bianhao;

            int rows = DbHelperSQL.ExecuteSql(strSql.ToString(), parameters);
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
        public bool DeleteList(string Jiating)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from GerenInfo");
            strSql.Append(" where Ffbianhao in (" + Jiating + ")  ");
            int rows = DbHelperSQL.ExecuteSql(strSql.ToString());
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
        public SDM.Model.GerenInfo GetModel(int Bianhao)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  top 1 编号,姓名,字,身份证,性别,生日,籍贯,父家庭编号,母家庭编号,子家庭编号 from GerenInfo ");
            strSql.Append(" where 编号=@编号");
            SqlParameter[] parameters = {
					new SqlParameter("@编号", SqlDbType.Int,4)
			};
            parameters[0].Value = Bianhao;

            SDM.Model.GerenInfo model = new SDM.Model.GerenInfo();
            DataSet ds = DbHelperSQL.Query(strSql.ToString(), parameters);
            if (ds.Tables[0].Rows.Count > 0)
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
        public SDM.Model.GerenInfo DataRowToModel(DataRow row)
        {
            SDM.Model.GerenInfo model = new SDM.Model.GerenInfo();
            if (row != null)
            {
                if (row["编号"] != null && row["编号"].ToString() != "")
                {
                    model.Bianhao = int.Parse(row["编号"].ToString());
                }
                if (row["父家庭编号"] != null)
                {
                    model.Ffbianhao = row["父家庭编号"].ToString();
                }
                if (row["籍贯"] != null)
                {
                    model.Jiguan = row["籍贯"].ToString();
                }
                if (row["母家庭编号"] != null)
                {
                    model.Mfbianhao = row["母家庭编号"].ToString();
                }
                if (row["姓名"] != null)
                {
                    model.Name = row["姓名"].ToString();
                }
                if (row["性别"] != null)
                {
                    model.Sex = row["性别"].ToString();
                }
                if (row["身份证"] != null)
                {
                    model.Sfz = row["身份证"].ToString();
                }
                if (row["生日"] != null)
                {
                    model.shengri = row["生日"].ToString();
                }
                if (row["子家庭信息"] != null)
                {
                    model.Zfbianhao = row["子家庭信息"].ToString();
                }
                if (row["字"] != null)
                {
                    model.Zi = row["字"].ToString();
                }
            }
            return model;
        }

        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetList(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select 编号,姓名,字,身份证,性别,生日,籍贯,父家庭编号,母家庭编号,子家庭编号 ");
            strSql.Append(" FROM GerenInfo ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            return DbHelperSQL.Query(strSql.ToString());
        }

        /// <summary>
        /// 获得前几行数据
        /// </summary>
        public DataSet GetList(int Top, string strWhere, string filedOrder)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select ");
            if (Top > 0)
            {
                strSql.Append(" top " + Top.ToString());
            }
            strSql.Append(" 编号,姓名,字,身份证,性别,生日,籍贯,父家庭编号,母家庭编号,子家庭编号");
            strSql.Append(" FROM GerenInfo ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            strSql.Append(" order by " + filedOrder);
            return DbHelperSQL.Query(strSql.ToString());
        }

        /// <summary>
        /// 获取记录总数
        /// </summary>
        public int GetRecordCount(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) FROM GerenInfo ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
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
            StringBuilder strSql = new StringBuilder();
            strSql.Append("SELECT * FROM ( ");
            strSql.Append(" SELECT ROW_NUMBER() OVER (");
            if (!string.IsNullOrEmpty(orderby.Trim()))
            {
                strSql.Append("order by T." + orderby);
            }
            else
            {
                strSql.Append("order by T.Bianhao desc");
            }
            strSql.Append(")AS Row, T.*  from GerenInfo T ");
            if (!string.IsNullOrEmpty(strWhere.Trim()))
            {
                strSql.Append(" WHERE " + strWhere);
            }
            strSql.Append(" ) TT");
            strSql.AppendFormat(" WHERE TT.Row between {0} and {1}", startIndex, endIndex);
            return DbHelperSQL.Query(strSql.ToString());
        }


        /// <summary>
        /// 分页获取数据列表
        /// </summary>
        public DataSet GetList(int PageSize, int PageIndex, string strWhere)
        {
            SqlParameter[] parameters = {
					new SqlParameter("@tblName", SqlDbType.VarChar, 255),
					new SqlParameter("@fldName", SqlDbType.VarChar, 255),
					new SqlParameter("@PageSize", SqlDbType.Int),
					new SqlParameter("@PageIndex", SqlDbType.Int),
					new SqlParameter("@IsReCount", SqlDbType.Bit),
					new SqlParameter("@OrderType", SqlDbType.Bit),
					new SqlParameter("@strWhere", SqlDbType.VarChar,1000),
					};
            parameters[0].Value = "GerenInfo";
            parameters[1].Value = "编号";
            parameters[2].Value = PageSize;
            parameters[3].Value = PageIndex;
            parameters[4].Value = 0;
            parameters[5].Value = 0;
            parameters[6].Value = strWhere;
            return DbHelperSQL.RunProcedure("UP_GetRecordByPage", parameters, "ds");
        }

        #endregion  BasicMethod
        #region  ExtensionMethod
        /// <summary>
        /// 管理员添加学生信息
        /// </summary>
        /// <param name="UserName"></param>
        /// <param name="UserSex"></param>
        /// <param name="UserNumber"></param>
        /// <param name="UserPass"></param>
        /// <param name="UserXy"></param>
        /// <param name="UserZy"></param>
        /// <param name="UserBj"></param>
        /// <param name="UserAddTime"></param>
        /// <returns></returns>
        public int AddStudentInfoByTrans(string UserName, string UserSex, string UserNumber, string UserPass, string UserXy, string UserZy,string UserBj, string UserAddTime, string zibianhao)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into GerenInfo(");
            strSql.Append("姓名,字,身份证,性别,生日,籍贯,父家庭编号,母家庭编号,子家庭编号)");
            strSql.Append(" values (");
            strSql.Append("@姓名,@字,@身份证,@性别,@生日,@籍贯,@父家庭编号,@母家庭编号,@子家庭编号)");
            SqlParameter[] par = {
                   
					new SqlParameter("@姓名", UserName),
					new SqlParameter("@性别",UserSex ),
					new SqlParameter("@身份证", UserNumber),
                    new SqlParameter("@字", UserPass),
					new SqlParameter("@生日", UserXy),
					new SqlParameter("@籍贯",  UserZy),
					new SqlParameter("@父家庭编号", UserBj),
                    new SqlParameter("@母家庭编号",UserAddTime),
                    new SqlParameter("@子家庭编号", zibianhao)
                                 };
            return DbHelperSQL.ExecuteSql(strSql.ToString(), par);
        }
        /// <summary>
        /// 检测学号是否唯一，在本系统中允许用户名重复，但学号是唯一！
        /// </summary>
        /// <param name="strUserNumber"></param>
        /// <returns></returns>
        public bool Exists(string sfz)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from GerenInfo");
            strSql.Append(" where 身份证=@身份证");
            SqlParameter[] parameters = {
					new SqlParameter("@身份证", SqlDbType.NVarChar,50)
			};
            parameters[0].Value = sfz;
            return DbHelperSQL.Exists(strSql.ToString(), parameters);
        }
        /// <summary>
        /// 根据学生姓名查询
        /// </summary>
        /// <param name="username"></param>
        /// <returns></returns>
        public DataSet GetStudentListByUserName(string username)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("select * from GerenInfo ");
            sql.Append(" where ");
            sql.Append(" 姓名=@姓名");
            SqlParameter[] par = { new SqlParameter("@姓名", username) };
            return DbHelperSQL.Query(sql.ToString(), par);
        }
        /// <summary>
        /// 根据学生院系查询
        /// </summary>
        /// <param name="userxy"></param>
        /// <returns></returns>
        public DataSet GetStudentListByUserXy(string userxy)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("select * from GerenInfo ");
            sql.Append(" where ");
            sql.Append(" 籍贯=@籍贯");
            SqlParameter[] par = { new SqlParameter("@籍贯", userxy) };
            return DbHelperSQL.Query(sql.ToString(), par);
        }
        #endregion  ExtensionMethod
    }
}

