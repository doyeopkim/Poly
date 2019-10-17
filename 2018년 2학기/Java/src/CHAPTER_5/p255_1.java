package CHAPTER_5;

public class p255_1 {
	private int channel;
	private int volume;
	private boolean onOff;
	
	p255_1(int c, int v, boolean o) {
		channel = c;
		volume = v;
		onOff = o;
	}
	
	void print() {
		System.out.println("채널은 " + channel + "이고 볼륨은 " + volume + "입니다.");
	}
}
