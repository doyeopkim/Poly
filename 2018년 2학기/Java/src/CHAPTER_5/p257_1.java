package CHAPTER_5;

public class p257_1 {
	private int width;
	private int length;
	private int height;
	private int volume;

	
	p257_1(int w, int l, int h) {
		width = w;
		length = l;
		height = h;
		volume = width * length * height;
	}
	
	public int getVolume() {	return volume;	}
	

}
