package CHAPTER_5;

public class p286 {
	private String model;
	private String color;
	private int speed;
	
	// 자동차의 시리얼 번호
	private int id;
	static int numbers = 0;
	
	public p286(String m, String c, int s) {
		model = m;
		color = c;
		speed = s;
			// 자동차의 개수를 증가하고  id에 대입한다.
		id = ++numbers;
	}

}
