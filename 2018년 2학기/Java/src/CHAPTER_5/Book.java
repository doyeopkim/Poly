package CHAPTER_5;

public class Book {
	String title;
	String author;
	
	public Book(String t, String a) {
		title = t;
		author = a;
	}
	
	@Override
	public String toString() {
		return "å�� " + title + " �۰��� " + author;
	}
	
}
