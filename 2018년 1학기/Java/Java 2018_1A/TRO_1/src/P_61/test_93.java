package P_61;

import java.util.*;

public class test_93 {

	public static void main(String[] args) {
		
		String name;
		String major;
		String favorite;
		int score1;
		
		Scanner input = new Scanner(System.in);
		
		System.out.print("�̸��� �����Դϱ�? ");
		name = input.nextLine();
		
		System.out.print("�а��� �����Դϱ�? ");
		major = input.nextLine();
		
		System.out.print("���� ������ �����մϱ�? ");
		favorite = input.nextLine();
		
		System.out.print("�߰���� ��� ������? ");
		score1 = input.nextInt();
		
		System.out.println(major + " " + name + "��" + favorite + "�� �����ϰ� " + "�߰���� " + score1 + "�� ����Դϴ�");
		
		}
}