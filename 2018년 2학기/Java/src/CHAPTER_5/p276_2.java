package CHAPTER_5;

public class p276_2 {

	public static void main(String[] args) {
		
		int[] list = { 1, 2, 3, 4, 5 };
		p276_1 obj = new p276_1();
		
		obj.inc(list);
		
		for (int i = 0; i <list.length; i++)
			System.out.print(list[i] + " ");
	}
}