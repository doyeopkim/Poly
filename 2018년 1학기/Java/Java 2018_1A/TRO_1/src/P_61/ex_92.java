package P_61;

import java.util.Scanner; // Scanner 클래스 포함

public class ex_92 {

	public static void main(String[] args) {
		
		Scanner input = new Scanner(System.in);
		int x; // 첫 번째 숫자 저장
		int y; // 두 번째 숫자 저장
		int sum; // 합을 저장
		
		System.out.print("첫번째 숫자를 입력하시오: "); // 입력 안내 출력
		x = input.nextInt(); // 사용자로부터 첫 번쨰 숫자를 읽는다.
		
		System.out.print("두번째 숫자를 입력하시오: "); // 입력 안내 출력
		y = input.nextInt(); // 사용자로부터 두 번째 숫자를 읽는다.
		
		sum = x + y; // 두 개의 숫자를 더한다.
		
		System.out.println(sum); // 합을 출력한다.
		
	}
}