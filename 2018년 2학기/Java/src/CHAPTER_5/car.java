package CHAPTER_5;

public class car {
	String color = "Red";
	int speed;
	int gear;
	
	@Override
	public String toString() {
		return "[�ڵ����� ������ =" + color + "," + "�ڵ����� �ӵ��� =" + speed + ", "
				+ "�ڵ����� ���� =" + gear + "]";
	}
	
	void changeGear(int g) {
		gear = g;
	}
	
	void speedUp() {
		speed = speed + 80;
	}
	
	void speedDown() {
		speed = speed - 10;
	}
}
