package P_61;

import java.util.Scanner;

public class test_kdy_2 {

	public static void main(String[] args) {
		
		Scanner input = new Scanner(System.in);
		
		String name;
		int java_s;
		int digong_s;
		double sum;
		String su;
		
		
		
		System.out.print("이름을 입력하시오: ");
		name = input.nextLine();
		
		System.out.print("자바 점수를 입력하시오: ");
		java_s = input.nextInt();
		
		switch(java_s) {
		case 100:
		case 99:
		case 98:
		case 97:
		case 96:
		case 95:
			su = "A+";
		break;
		
		case 94:
		case 93:
		case 92:
		case 91:
		case 90:	
			su = "A";
		break;
		
		case 89:
		case 88:
		case 87:
		case 86:
		case 85:
			su = "B+";
		break;
		
		case 84:
		case 83:
		case 82:
		case 81:
		case 80:		
			su = "B";
		break;
		
		case 79:
		case 78:
		case 77:
		case 76:
		case 75:
			su = "C+";
		break;
			
		case 74:
		case 73:
		case 72:
		case 71:
		case 70:
			su = "C";
		break;
		
		case 69:
		case 68:
		case 67:
		case 66:
		case 65:
			su = "D+";
		break;
		case 64:
		case 63:
		case 62:
		case 61:
		case 60:
			su = "D";
		break;
		
		default:
			su = "F";
		break;
		}
		System.out.println(name + "의 자바 " + su + "학점 입니다.");
		
		System.out.print("디공 점수를 입력하시오: ");
		digong_s = input.nextInt();
		
		switch(digong_s) {
		case 100:
		case 99:
		case 98:
		case 97:
		case 96:
		case 95:
			su = "A+";
		break;
		
		case 94:
		case 93:
		case 92:
		case 91:
		case 90:	
			su = "A";
		break;
		
		case 89:
		case 88:
		case 87:
		case 86:
		case 85:
			su = "B+";
		break;
		
		case 84:
		case 83:
		case 82:
		case 81:
		case 80:		
			su = "B";
		break;
		
		case 79:
		case 78:
		case 77:
		case 76:
		case 75:
			su = "C+";
		break;
			
		case 74:
		case 73:
		case 72:
		case 71:
		case 70:
			su = "C";
		break;
		
		case 69:
		case 68:
		case 67:
		case 66:
		case 65:
			su = "D+";
		break;
		case 64:
		case 63:
		case 62:
		case 61:
		case 60:
			su = "D";
		break;
		
		default:
			su = "F";
		break;
		}
		
		sum = (java_s + digong_s) / 2;
		
		System.out.println(name + "의 디공 " + su + "학점 입니다. 평균은 " + sum + "입니다");
		
			
	}
}