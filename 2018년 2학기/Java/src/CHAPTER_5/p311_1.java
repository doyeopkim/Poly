package CHAPTER_5;

public class p311_1 extends p311{
	private int width;
	private int height;
	
	public int getWidth() {	return width; }
	public void setWidth(int width) {	this.width = width;	}
	public int getHeight() {	return height;	}
	public void setHeight(int height) {	this.height = height;	}
	
	double area() {
		return (double)width * height;
	}
	void draw() {
		System.out.println("(" + this.getX() + "," + this.getY() +
				") 위치에 " + "가로: " + width + "세로 : " + height);
	}
}