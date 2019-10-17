package CHAPTER_5;

public class p329_2 extends p329_1{
	String color;
	
	public p329_2(int x, int y, int width, int height, String color) {
		super(x, y, width, height);
		System.out.println("ColoredRectangle()");
		this.color = color;
	}

	public static void main(String[] args) {
		p329_2 obj = new p329_2(10, 10, 20, 20, "red");

	}
}