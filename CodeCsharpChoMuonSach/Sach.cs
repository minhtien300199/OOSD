///////////////////////////////////////////////////////////
//  Sach.cs
//  Implementation of the Class Sach
//  Generated by Enterprise Architect
//  Created on:      02-Mar-2020 1:55:36 PM
//  Original author: Le Tien
///////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.IO;



namespace ChoMuonSach {
	public class Sach {

		private string GhiChu;
		private int Sachid;
		private string TacGia;
		private string TenSach;

		public Sach(){

		}

		~Sach(){

		}

		public string GhiChu{
			get{
				return GhiChu;
			}
			set{
				GhiChu = value;
			}
		}

		public int Sachid{
			get{
				return Sachid;
			}
			set{
				Sachid = value;
			}
		}

		public string TacGia{
			get{
				return TacGia;
			}
			set{
				TacGia = value;
			}
		}

		public string TenSach{
			get{
				return TenSach;
			}
			set{
				TenSach = value;
			}
		}

	}//end Sach

}//end namespace ChoMuonSach