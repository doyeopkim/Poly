package test;

import java.util.Scanner;

public class RectArray {

	public static void main(String[] args) {
		
		Rect r[] = new Rect[4];
		for(int i=0; i<r.length; i++) {
			System.out.print(i+1);
			System.out.println(" 너비와 높이 >>");
			Scanner sc = new Scanner(System.in);
			int width = sc.nextInt();
			int height = sc.nextInt();
			r[i] = new Rect(width, height);
			}
		
		System.out.println("저장하였습니다.");
		int sum = 0;
		for(int i=0; i<r.length; i++) {
			sum += r[i].getArea();	
		}
		
		System.out.println("사각형 전체의 합은 " + sum);
	}

}
