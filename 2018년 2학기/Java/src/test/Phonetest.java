package test;

import java.util.Scanner;

public class Phonetest {

	public static void main(String[] args) {
		System.out.print("�̸��� ��ȭ��ȣ �Է� >> ");
		Scanner sc = new Scanner(System.in);
		String name = sc.next();
		String tel = sc.next();
		Phone a = new Phone(name, tel);
		
		System.out.print("�̸��� ��ȭ��ȣ �Է� >> ");
		Scanner scn = new Scanner(System.in);
		String name1 = scn.next();
		String tel1 = scn.next();
		Phone b = new Phone(name1, tel1);
		
		System.out.println(a.getName() + "�� ��ȣ " + a.getTel());
		System.out.println(b.getName() + "�� ��ȣ " + b.getTel());
		
		

	}

}
