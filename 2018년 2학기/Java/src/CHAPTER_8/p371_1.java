package CHAPTER_8;

import javax.swing.*;
import java.awt.FlowLayout;

public class p371_1 extends JFrame{
	public p371_1() {
		setSize(300, 200);
		setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
		setTitle("MyFrame");
	
	setLayout(new FlowLayout());
	JButton button = new JButton("¹öÆ°");
	this.add(button);
	setVisible(true);
	}
}