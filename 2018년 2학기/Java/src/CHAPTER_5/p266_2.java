package CHAPTER_5;

public class p266_2 {

	public static void main(String[] args) {
		p266_1 t1 = new p266_1();
		System.out.println("기본 생성자 호출 후 시간: " + t1.toString());
		
		p266_1 t2 = new p266_1(13, 27, 6);
		System.out.println("두번째 생성자 호출 후 시간: " + t2.toString());
		
		p266_1 t3 = new p266_1(99, 66, 77);
		System.out.println("올바르지 않은 시간 설정 후 시간 : " + t3.toString());

	}

}
