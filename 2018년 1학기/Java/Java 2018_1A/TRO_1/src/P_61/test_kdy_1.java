package P_61;

import java.util.Scanner;

public class test_kdy_1 {

	public static void main(String[] args) {
	//이름 2과목 점수 -> 수 우 미 양 가
		
		Scanner input = new Scanner(System.in);
		
		String name;
		int java_s;
		int digong_s;
		int sum;
		String su;
		
		System.out.print("이름을 입력하시오: ");
		name = input.nextLine();
		
		System.out.print("자바 점수를 입력하시오: ");
		java_s = input.nextInt();
		
		if(java_s >= 90) {
			su = "수";
		}
		else if(java_s >= 80) {
			su = "우";
		}
		else if(java_s >= 70) {
			su = "미";
		}
		else if(java_s >= 60) {
			su = "양";
		}
		else {
			su = "가";
		}
		
		System.out.println(name + "의 등급은 " + su + "입니다~");
		
		System.out.print("디공 점수를 입력하시오: ");
		digong_s = input.nextInt();
		
		
		if(digong_s >= 90) {
			su = "수";
		}
		else if(digong_s >= 80) {
			su = "우";
		}
		else if(digong_s >= 70) {
			su = "미";
		}
		else if(digong_s >= 60) {
			su = "양";
		}
		else {
			su = "가";
		}
		
		sum = (java_s + digong_s) / 2;
		
		System.out.println(name + "의 등급은 " + su + "입니다~ 평균은" + sum + "입니다.");
		
	}

}
