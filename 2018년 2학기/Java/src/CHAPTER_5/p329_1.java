package CHAPTER_5;

public class p329_1 extends p329{
	private int width;
	private int height;
	
	public p329_1(int x, int y, int width, int height) {
		super(x, y);
		System.out.println("Rectangle()");
		this.width = width;
		this.height = height;
	}
	
	double calcArea() {
		return width * height;
	}

}
