package P_61;

import java.util.Scanner;

public class test_106 {

	public static void main(String[] args) {
		
		int x, y, max;
		
		Scanner input = new Scanner(System.in);
		System.out.print("ù��° ����: ");
		x = input.nextInt();
		
		System.out.print("�ι�° ����: ");
		y = input.nextInt();
		
		if (x > y)
			max = x;
		else
			max = y;
		
		if (max % 2 == 0) {
			System.out.println("ū ���� " + max + "�̰� ¦���Դϴ�.");
		}
		
		else {
			System.out.println("ū ���� " + max + "�̰� Ȧ���Դϴ�.");
		}
		
	}
}