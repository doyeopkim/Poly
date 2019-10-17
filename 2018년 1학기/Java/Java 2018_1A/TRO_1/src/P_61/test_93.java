package P_61;

import java.util.*;

public class test_93 {

	public static void main(String[] args) {
		
		String name;
		String major;
		String favorite;
		int score1;
		
		Scanner input = new Scanner(System.in);
		
		System.out.print("이름이 무엇입니까? ");
		name = input.nextLine();
		
		System.out.print("학과는 무엇입니까? ");
		major = input.nextLine();
		
		System.out.print("무슨 과목을 좋아합니까? ");
		favorite = input.nextLine();
		
		System.out.print("중간고사 희망 점수는? ");
		score1 = input.nextInt();
		
		System.out.println(major + " " + name + "은" + favorite + "를 좋아하고 " + "중간고사 " + score1 + "점 희망입니다");
		
		}
}