package test;

import java.util.Scanner;
import java.util.StringTokenizer;

public class WordCount {

	public static void main(String[] args) {
		Scanner sc = new Scanner(System.in);
		
		while(true) {
			String s = sc.nextLine();
			if(s.equals("exit")) {
				System.out.println("�����մϴ�.");
				break;
			}
			StringTokenizer st = new StringTokenizer(s, " ");
			System.out.println("���� ������ " + st.countTokens());
		}

	}

}
