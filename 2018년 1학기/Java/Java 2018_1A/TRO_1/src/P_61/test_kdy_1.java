package P_61;

import java.util.Scanner;

public class test_kdy_1 {

	public static void main(String[] args) {
	//�̸� 2���� ���� -> �� �� �� �� ��
		
		Scanner input = new Scanner(System.in);
		
		String name;
		int java_s;
		int digong_s;
		int sum;
		String su;
		
		System.out.print("�̸��� �Է��Ͻÿ�: ");
		name = input.nextLine();
		
		System.out.print("�ڹ� ������ �Է��Ͻÿ�: ");
		java_s = input.nextInt();
		
		if(java_s >= 90) {
			su = "��";
		}
		else if(java_s >= 80) {
			su = "��";
		}
		else if(java_s >= 70) {
			su = "��";
		}
		else if(java_s >= 60) {
			su = "��";
		}
		else {
			su = "��";
		}
		
		System.out.println(name + "�� ����� " + su + "�Դϴ�~");
		
		System.out.print("��� ������ �Է��Ͻÿ�: ");
		digong_s = input.nextInt();
		
		
		if(digong_s >= 90) {
			su = "��";
		}
		else if(digong_s >= 80) {
			su = "��";
		}
		else if(digong_s >= 70) {
			su = "��";
		}
		else if(digong_s >= 60) {
			su = "��";
		}
		else {
			su = "��";
		}
		
		sum = (java_s + digong_s) / 2;
		
		System.out.println(name + "�� ����� " + su + "�Դϴ�~ �����" + sum + "�Դϴ�.");
		
	}

}
