package P_61;

public class ex_80 {

	public static void main(String[] args) {
		
		int x = 0x0fff;
		int y = 0xfff0;
		System.out.printf("%x", (x & y));
		System.out.printf("%x", (x | y));
		System.out.printf("%x", (x ^ y));
		System.out.printf("%x", ~x);
		System.out.printf("%x", (x << 4));
		System.out.printf("%x", (x >> 4));
		System.out.printf("%x", (-1 >>> 4));
	}

}
