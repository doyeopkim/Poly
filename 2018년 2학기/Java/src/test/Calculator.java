package test;

import java.util.Scanner;

abstract class Calculator {
	protected int a,b;
	abstract protected int calc();
	protected void input() {
		Scanner sc = new Scanner(System.in);
		System.out.print("���� 2���� �Է��ϼ���>>");
		a = sc.nextInt();
		b = sc.nextInt();
	}
	
	public void run() {
		input();
		int res = calc();
		System.out.println("���� ���� " + res);
	}

}