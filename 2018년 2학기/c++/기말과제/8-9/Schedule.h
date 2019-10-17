#ifndef SCHEDULE_H
#define SCHEDULE_H
#include <string>
#include "Seat.h"
using namespace std;

class Schedule {	// ������ Ŭ����
	string name;
	int seatNum;
	Seat* seat; // 8���� ��ü ������ ���� ��ü ������
public:
	Schedule(); // �⺻ ������
	void show(); // �¼� ���
	void book(int seatNum, string name);	// ���� �Լ�
	void cancle(int seatNum, string name);	// ���� ��� �Լ�
	void search(int time, string name); // ���� ã�� �Լ�
};
#endif