using System;
namespace SDM.Model
{
    /// <summary>
    /// StudentsInfo:实体类(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Serializable]
    public partial class GerenInfo
    {
        public GerenInfo()
        { }
        #region Model
        private int _bianhao;
        private string _name;
        private string _zi;
        private string _sfz;
        private string _sex;
        private string  _shengri;
        private string _jiguan;
        private string _ffbianhao;
        private string _mfbianhao;
        private string _zfbianhao;
        /// <summary>
        /// 
        /// </summary>
        public int Bianhao
        {
            set { _bianhao = value; }
            get { return _bianhao; }
        }
      
        /// <summary>
        /// 
        /// </summary>
        public string Name
        {
            set { _name = value; }
            get { return _name; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string Zi
        {
            set { _zi = value; }
            get { return _zi; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string Sfz
        {
            set { _sfz = value; }
            get { return _sfz; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string Sex
        {
            set { _sex = value; }
            get { return _sex; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string  shengri
        {
            set { _shengri = value; }
            get { return _shengri; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string Jiguan
        {
            set { _jiguan = value; }
            get { return _jiguan; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string Ffbianhao
        {
            set { _ffbianhao = value; }
            get { return _ffbianhao; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string Mfbianhao
        {
            set { _mfbianhao = value; }
            get { return _mfbianhao; }
        }
        public string Zfbianhao
        {
            set { _zfbianhao = value; }
            get { return _zfbianhao; }
        }
        #endregion Model

    }
}

