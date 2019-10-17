package CHAPTER_5;

public class p286_1 {

	public static void main(String[] args) {
		p286 c1 = new p286("S600", "white", 80);
		p286 c2 = new p286("E500", "blue", 20);
		int n = p286.numbers;	// 정적 변수
		System.out.println("지금까지 생성된 자동차 수 = " + n);
	}
}