package CHAPTER_5;

public class p286 {
	private String model;
	private String color;
	private int speed;
	
	// �ڵ����� �ø��� ��ȣ
	private int id;
	static int numbers = 0;
	
	public p286(String m, String c, int s) {
		model = m;
		color = c;
		speed = s;
			// �ڵ����� ������ �����ϰ�  id�� �����Ѵ�.
		id = ++numbers;
	}

}
