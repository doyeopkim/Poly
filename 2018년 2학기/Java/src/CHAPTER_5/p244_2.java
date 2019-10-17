package CHAPTER_5;

public class p244_2 {

	public static void main(String[] args) {
		p244_1 obj = new p244_1();
		obj.setName("Tom");
		obj.setBalance(100000);
		System.out.println("이름은 " + obj.getName() + " 통장 잔고는 "
				+ obj.getBalance() + "입니다.");
	}
}