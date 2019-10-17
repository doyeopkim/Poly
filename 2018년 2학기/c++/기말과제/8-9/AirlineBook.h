#ifndef AIRLINEBOOK_H
#define AIRLINEBOOK_H
#include "Console.h"
#include "Schedule.h"
using namespace std;

class AirlineBook {	// ���� Ŭ����
	Schedule* schedule; // 3���� ��ü ������ ���� ��ü ������
public:
	AirlineBook();	// ��ü 3�� ������ ������
	~AirlineBook(); // �Ҹ���
	void showSchedule(int time);	// �Է¹��� �ð��� ������ ��� �Լ�
	void showAllSchedule();	//��� ������ ��� �Լ�
	Schedule getSchedule(int time);	// Main���� �Է¹��� �ð��� ������ ������ �Լ�
};
#endif