using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDM.Model
{
    public partial class jiating
    {
        public jiating()
		{}
		#region Model
		private int _jiating;
		private string _hkszd;
		private string _miaoshu;
		/// <summary>
		/// 
		/// </summary>
		public int Jiating
		{
			set{ _jiating=value;}
			get{return _jiating;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Hkszd
		{
			set{ _hkszd=value;}
			get{return _hkszd;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Miaoshu
		{
			set{ _miaoshu=value;}
			get{return _miaoshu;}
		}
		#endregion Model

	}
    }

