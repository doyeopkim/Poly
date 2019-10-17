package CHAPTER_5;

public class p311_2 {

	public static void main(String[] args) {
		p311_1 r1 = new p311_1();
		p311_1 r2 = new p311_1();
		
		r1.setX(5);
		r1.setY(3);
		r1.setWidth(10);
		r1.setHeight(20);
		
		r2.setX(8);
		r2.setY(9);
		r2.setWidth(10);
		r2.setHeight(20);
		
		r1.print();
		r1.draw();
		r2.print();
		r2.draw();
	}
}