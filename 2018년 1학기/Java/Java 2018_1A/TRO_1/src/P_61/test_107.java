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
		
		System.out.print("�̸��� �Է��Ͻÿ�: ");
		name = input.nextLine();
		
		System.out.print("�ڹ� ������ �Է��Ͻÿ�: ");
		java_s = input.nextInt();
		
		System.out.print("�����а��� ������ �Է��Ͻÿ�: ");
		digong_s = input.nextInt();
		
		sum = java_s + digong_s;
		result = sum / 2;
		
		if (result >= 80)
			System.out.println(name + "�� " + "java " + java_s + "�� " + "�����а��� " + digong_s + "������ " + "������" + sum + "���̰� ����� " + result + "������ ����� " + "����Դϴ�~");
		else if (result >= 60)
			System.out.println(name + "�� " + "java " + java_s + "�� " + "�����а��� " + digong_s + "������ " + "������" + sum + "���̰� ����� " + result + "������ ����� " + "�����Դϴ�~");
		else
			System.out.println(name + "�� " + "java " + java_s + "�� " + "�����а��� " + digong_s + "������ " + "������" + sum + "���̰� ����� " + result + "������ ����� " + "�ǰ��Դϴ�~");
	}
}