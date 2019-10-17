package test;

import java.util.Scanner;

public class Phonetest {

	public static void main(String[] args) {
		System.out.print("이름과 전화번호 입력 >> ");
		Scanner sc = new Scanner(System.in);
		String name = sc.next();
		String tel = sc.next();
		Phone a = new Phone(name, tel);
		
		System.out.print("이름과 전화번호 입력 >> ");
		Scanner scn = new Scanner(System.in);
		String name1 = scn.next();
		String tel1 = scn.next();
		Phone b = new Phone(name1, tel1);
		
		System.out.println(a.getName() + "의 번호 " + a.getTel());
		System.out.println(b.getName() + "의 번호 " + b.getTel());
		
		

	}

}
