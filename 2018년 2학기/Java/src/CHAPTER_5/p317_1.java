package CHAPTER_5;

public class p317_1 extends p317 {
	private int bonus;
	
	public p317_1(String name, String address, int salary, int rrn,
			int bonus) {
		super(name, address, salary, rrn);
		this.bonus = bonus;
	}

	void test() {
		System.out.println("name="+name);
		System.out.println("address"+address);
		System.out.println("salary="+salary);
		//	System.out.println("rrn="+rrn);
	}
}
