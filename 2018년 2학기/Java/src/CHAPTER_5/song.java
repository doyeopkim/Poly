package CHAPTER_5;

public class song {
	private String title;
	
	public song(String title) {
		this.title = title;
	}
	
	public String getTitle() {
		return title;
	}
	
	public static void main(String[] args) {
		song yoursong = new song("vv");
		song mysong = new song("ss");
		
		System.out.println("���� �뷡 ������ " + yoursong.getTitle() + " ���� �뷡 ������ " + mysong.getTitle());

	}
}
