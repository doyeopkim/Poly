package CHAPTER_5;

public class Point {
	/*int x,y;
	public Point(int x, int y) {
		this.x = x;
		this.y = y;
	}
	public String toString() {
		return "Point(" + x + ',' + y + ")";
	}
	
	public boolean equals(Point p) {
		if(x==p.x && y==p.y)
			return true;
		else 
			return false;
	}
	*/
	int width, height;
	
	public Rect(int width, int height) {
		this.width = width;
		this.height = height;
	}
	
	public boolean equals(Rect p) {
		if(width*height == p.width * p.height)
			return true;
		else 
			return false;
	}
	
	public static void main(String[] args) {
		/*Point a = new Point(2,3);
		Point b = new Point(2,3);
		Point c = new Point(3,4);
		if(a==b)
			System.out.println("a==b");
		if(a.equals(b))
			System.out.println("a is equal to b");
		if(a.equals(c))
			System.out.println("a is equal to c");
			*/
		Rect a = new Rect(2,3);
		Rect b = new Rect(2,3);
		Rect c = new Rect(3,4);
		
		if(a.equals(b))
			System.out.println("a is equal to b");
		if(a.equals(c))
			System.out.println("a is equal to c");
		if(a.equals(c))
			System.out.println("b is equal to c");
		
		
		
		
		
		
		//System.out.println(p.toString());
		//System.out.println(p);
	
	//System.out.println(p.getClass().getName());
	//System.out.println(p.hashCode());
	//System.out.println(p.toString());

}
}
