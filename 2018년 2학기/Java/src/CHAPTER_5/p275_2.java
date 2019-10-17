package CHAPTER_5;

public class p275_2 {

	public static void main(String[] args) {
		p275_1 obj = new p275_1();
		
		System.out.println("obj.value = " + obj.value);
		obj.inc(obj);
		System.out.println("obj.value = " + obj.value);

	}

}
