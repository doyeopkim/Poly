package CHAPTER_5;

public class car {
	String color = "Red";
	int speed;
	int gear;
	
	@Override
	public String toString() {
		return "[자동차의 색상은 =" + color + "," + "자동차의 속도는 =" + speed + ", "
				+ "자동차의 기어는 =" + gear + "]";
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
