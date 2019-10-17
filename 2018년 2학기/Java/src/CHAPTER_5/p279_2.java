package CHAPTER_5;

public class p279_2 {

	public static void main(String[] args) {
		p279_1 obj1 = new p279_1(10, 20, 50);
		p279_1 obj2 = new p279_1(10, 30, 30);
		
		p279_1 largest = obj1.whosLargest(obj1, obj2);
		System.out.println("(" + largest.width + "," + largest.length
				+ "," + largest.height + ")");
	}
}