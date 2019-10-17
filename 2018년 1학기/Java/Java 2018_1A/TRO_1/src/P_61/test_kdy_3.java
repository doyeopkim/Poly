package P_61;

public class test_kdy_3 {

	public static void main(String[] args) {
		// 금주의 로또 번호는 ?
		
		int l1=(int) (Math.random()*45) +1;
		
		int l2=(int) (Math.random()*45) +1;		
		
		int l3=(int) (Math.random()*45) +1;
		
		int l4=(int) (Math.random()*45) +1;
		
		int l5=(int) (Math.random()*45) +1;
		
		int l6=(int) (Math.random()*45) +1;
		
		int i = 1;
		
		while (i < 2) {
			if ( l1 != l2 && l1 != l3 && l1 != l4 && l1 != l5 && l1 != l6 &&
					l2 != l3 && l2 != l4 && l2 != l5 && l2 != l6 &&
					l3 != l4 && l3 != l5 && l3 != l6 &&
					l4 != l5 && l4 != l6 && l5 != l6){
			System.out.print(l1+ " ");
			System.out.print(l2+ " ");
			System.out.print(l3+ " ");
			System.out.print(l4+ " ");
			System.out.print(l5+ " ");
			System.out.print(l6);
			i++;
			}
		
		else
			continue;
	}
			

	}

}