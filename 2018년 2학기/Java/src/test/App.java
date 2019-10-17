package test;

class Adder extends Calculator {
	public int calc() { return a+b;}
}
	
class Subtracter extends Calculator {
	public int calc() { return a-b;}
}

public class App {
	
	public static void main(String[] args) {
		Adder adder = new Adder();
		Subtracter sub = new Subtracter();

	}

}
