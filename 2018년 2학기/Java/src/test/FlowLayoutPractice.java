package test;

import javax.swing.*;
import java.awt.*;

public class FlowLayoutPractice extends JFrame {
	public FlowLayoutPractice() {
		super("FlowLayout Practice");
		this.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
		Container cp = getContentPane();
		
		cp.setLayout(new FlowLayout());
		cp.add(new JLabel("100"));
		cp.add(new JLabel(" + "));
		cp.add(new JLabel("200"));
		cp.add(new JButton(" = "));
		cp.add(new JLabel("300"));
		
		setSize(400,100);
		setVisible(true);
	}

	public static void main(String[] args) {
		new FlowLayout();

	}

}
