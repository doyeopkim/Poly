package CHAPTER_5;

public class p279_1 {
	int width, length, height;
	int volume;
	
	p279_1(int w, int l, int h) {
		width = w;
		length = l;
		height = h;
		volume = w * l * h;
	}
	
	p279_1 whosLargest(p279_1 box1, p279_1 box2) {
		if (box1.volume > box2.volume)
			return box1;
		else
			return box2;
	}

}
