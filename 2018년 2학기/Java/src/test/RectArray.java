package test;

import java.util.Scanner;

public class RectArray {

	public static void main(String[] args) {
		
		Rect r[] = new Rect[4];
		for(int i=0; i<r.length; i++) {
			System.out.print(i+1);
			System.out.println(" �ʺ�� ���� >>");
			Scanner sc = new Scanner(System.in);
			int width = sc.nextInt();
			int height = sc.nextInt();
			r[i] = new Rect(width, height);
			}
		
		System.out.println("�����Ͽ����ϴ�.");
		int sum = 0;
		for(int i=0; i<r.length; i++) {
			sum += r[i].getArea();	
		}
		
		System.out.println("�簢�� ��ü�� ���� " + sum);
	}

}
