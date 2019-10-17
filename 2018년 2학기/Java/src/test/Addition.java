package test;

import java.util.Scanner;
import java.util.StringTokenizer;

public class Addition {

	public static void main(String[] args) {
		Scanner sc = new Scanner(System.in);
		String exp = sc.nextLine();
		StringTokenizer st = new StringTokenizer(exp, "+");
		int sum = 0;
		while(st.hasMoreTokens()) {
			String s = st.nextToken();
			s=s.trim();
			sum += Integer.parseInt(s);
		}
		System.out.println("гую╨" + sum);

	}

}
