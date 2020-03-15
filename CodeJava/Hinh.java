package Cau2;


/**
 * @author Le Tien
 * @version 1.0
 * @created 02-Mar-2020 10:01:59 AM
 */
public abstract class Hinh {

	protected string Ten;
	protected Diem m_diem[];

	public Hinh(){

	}

	public void finalize() throws Throwable {

	}

	public abstract double chuvi();

	public abstract double dientich();

	public string docten(){
		return "";
	}

	public void ganten(){

	}

	public Diem[] getdiem(){
		return m_diem;
	}

	/**
	 * 
	 * @param newVal
	 */
	public void setdiem(Diem newVal[]){
		m_diem = newVal;
	}

}