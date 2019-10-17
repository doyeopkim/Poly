package CHAPTER_5;

public class p293_2 {

	public static void main(String[] args) {
		p293_1 e1, e2, e3;
		e1 = new p293_1("±èÃ¶¼ö", 35000);
		e2 = new p293_1("ÃÖ¼öÃ¶", 50000);
		e3 = new p293_1("±èÃ¶È£", 20000);
		
		int n = p293_1.getCount();
		System.out.println("ÇöÀçÀÇ Á÷¿ø¼ö=" + n);

	}

}
