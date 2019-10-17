package test;

public class NamedCircle extends Circle {
	private String name;
	NamedCircle(int radius, String name) {
		super(radius);
		this.name = name;
	}
	
	public void show() {
		System.out.println(name + ", ¹ÝÁö¸§ = " + getRadius());
	}

	public static void main(String[] args) {
		NamedCircle w = new NamedCircle(5, "Waffle");
		w.show();
		
	}
	
}