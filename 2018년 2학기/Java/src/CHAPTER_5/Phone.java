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
		
		System.out.print("�߽����� �̸��� �Է��Ͻÿ� : ");
		bn = scan.next();
		System.out.print("�߽��ڸ�  ��ȭ��ȣ�� �Է��Ͻÿ� : ");
		bt = scan.next();
		System.out.print("�������� �̸��� �Է��Ͻÿ� : ");
		sn = scan.next();
		System.out.print("�����ڸ�  ��ȭ��ȣ�� �Է��Ͻÿ� : ");
		st = scan.next();
		
		
		Phone balsin = new Phone(bn, bt);
		Phone susin = new Phone(sn, st);
		
		System.out.println("�߽��� : " + balsin.getName() + " "+ balsin.getTel());
		System.out.println("������ : " + susin.getName() + " " + susin.getTel());

	}

}
