package test;

public class songtest {

	public static void main(String[] args) {
		Song mySong = new Song("Let it go");
		Song yourSong = new Song("������Ÿ��");
		System.out.println("�� �뷡�� " + mySong.getTitle());
		System.out.println("�� �뷡�� " + yourSong.getTitle());

	}

}