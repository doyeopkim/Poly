#include<iostream>
#include<string>
#include "AirlineBook.h"
#include "Console.h"
#include "Schedule.h"
#include "Seat.h"
using namespace std;

Schedule::Schedule() { // ������
	seat = new Seat[8];
	for (int i = 0; i < 8; i++) // �¼��� �̸��� "---" �����ʱ�ȭ
	{
		seat[i].setName("-----");
	}
}
void Schedule::show() { // �¼� �̸� ���
	for (int i = 0; i < 8; i++)
		cout << " " << seat[i].getName() << "  ";
		cout << endl;
}
void Schedule::book(int seatNum, string name) { // ����
	for (int i = seatNum; i < 8; i++) // �Է¹��� seatNum���� ����
	{
		if (seat[i].getName() == "-----") // ���õ� �¼��� "---"�̶�� �̸��� ����
		{
			seat[seatNum].setName(name); // �̸� ����
			cout << "������ �Ϸ�Ǿ����ϴ�!\n" << endl;
			break;
		}
		else // �̹� ����� �¼��̶�� �������� ���
		{
			cout << "�̹� ����� �¼��Դϴ�." << endl;
			break;
		}
	}
}
void Schedule::cancle(int seatNum, string name) { // ���� ���
	if (name == seat[seatNum].getName()) // �̸��� ���ٸ� ���õ� �¼��� "---"���� �ٽ� �ʱ�ȭ
	{
		seat[seatNum].setName("-----");

		cout << "������ ��ҵǾ����ϴ�!" << endl;
	}
	else // �Էµ� �̸��� ���ٸ� �������� ���
	{
		cout << "���� �̸��Դϴ�." << endl;
	}
}

void Schedule::search(int time, string name) {

	for (int i = 0; i < 8; i++)
	{
		if (name == seat[i].getName())
		{
			i++;
			cout << time << "���� " << i << "������ ���� �Ǿ��ֽ��ϴ�." << endl;
			i--;
		}
	}
}