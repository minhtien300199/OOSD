///////////////////////////////////////////////////////////
//  Hinh.cs
//  Implementation of the Class Hinh
//  Generated by Enterprise Architect
//  Created on:      02-Mar-2020 9:56:57 AM
//  Original author: Le Tien
///////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.IO;



using Cau2;
namespace Cau2 {
	public abstract class Hinh {

		protected string Ten;
		protected Cau2.Diem m_diem;

		public Hinh(){

		}

		~Hinh(){

		}

		public abstract double chuvi();

		public Diem diem{
			get{
				return m_diem;
			}
			set{
				m_diem = value;
			}
		}

		public abstract double dientich();

		public string docten(){

			return "";
		}

		public void ganten(){

		}

	}//end Hinh

}//end namespace Cau2