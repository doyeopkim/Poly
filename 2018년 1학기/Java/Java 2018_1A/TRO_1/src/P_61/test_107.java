package P_61;

import java.util.Scanner;

public class test_107 {

	public static void main(String[] args) {
		final int targetSales = 1000;
		
		String name;
		int java_s;
		int digong_s;
		double sum;
		double result;
		
		Scanner input = new Scanner(System.in);
		
		System.out.print("이름을 입력하시오: ");
		name = input.nextLine();
		
		System.out.print("자바 점수를 입력하시오: ");
		java_s = input.nextInt();
		
		System.out.print("디지털공학 점수를 입력하시오: ");
		digong_s = input.nextInt();
		
		sum = java_s + digong_s;
		result = sum / 2;
		
		if (result >= 80)
			System.out.println(name + "은 " + "java " + java_s + "점 " + "디지털공학 " + digong_s + "점으로 " + "총점은" + sum + "점이고 평균은 " + result + "점으로 등급은 " + "우수입니다~");
		else if (result >= 60)
			System.out.println(name + "은 " + "java " + java_s + "점 " + "디지털공학 " + digong_s + "점으로 " + "총점은" + sum + "점이고 평균은 " + result + "점으로 등급은 " + "보통입니다~");
		else
			System.out.println(name + "은 " + "java " + java_s + "점 " + "디지털공학 " + digong_s + "점으로 " + "총점은" + sum + "점이고 평균은 " + result + "점으로 등급은 " + "실격입니다~");
	}
}