package CHAPTER_5;

public class p277_2 {
	final static int STUDENTS = 5;

	public static void main(String[] args) {
		int[] scores = new int[STUDENTS];
		p277_1 obj = new p277_1();
		obj.getValues(scores);
		System.out.println("∆Ú±’¿∫ = " + obj.getAverage(scores));
	}
}