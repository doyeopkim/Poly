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
		
		System.out.println("너의 노래 제목은 " + yoursong.getTitle() + " 나의 노래 제목은 " + mysong.getTitle());

	}
}
