package CHAPTER_5;

import java.util.Scanner;

public class Phone {
	private String name, tel;
	
	public Phone(String name, String tel) {
		this.name = name;
		this.tel = tel;
	}
	
	public String getName() { return name;}
	public String getTel() { return tel; }

	public static void main(String[] args) {
		String sn, st, bn, bt;
		
		Scanner scan = new Scanner(System.in);
		
		System.out.print("발신자의 이름을 입력하시오 : ");
		bn = scan.next();
		System.out.print("발신자를  전화번호를 입력하시오 : ");
		bt = scan.next();
		System.out.print("수신자의 이름을 입력하시오 : ");
		sn = scan.next();
		System.out.print("수신자를  전화번호를 입력하시오 : ");
		st = scan.next();
		
		
		Phone balsin = new Phone(bn, bt);
		Phone susin = new Phone(sn, st);
		
		System.out.println("발신자 : " + balsin.getName() + " "+ balsin.getTel());
		System.out.println("수신자 : " + susin.getName() + " " + susin.getTel());

	}

}
