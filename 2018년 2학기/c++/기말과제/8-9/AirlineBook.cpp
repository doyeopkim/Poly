#include <iostream>
#include <string>
#include "AirlineBook.h"
#include "Console.h"
#include "Schedule.h"
#include "Seat.h"
using namespace std;

AirlineBook::AirlineBook() { // �⺻ ������
	schedule = new Schedule[3]; // Schedule ��ü 3�� ����
}
AirlineBook::~AirlineBook() { // �Ҹ���
	delete[] schedule;
}
void AirlineBook::showSchedule(int time) { // ���õ� ������ �����ֱ�
	
	cout << "\n      1����   2����   3����   4����   5����   6����   7����   8����" << endl;
	switch (time+1) { // time���� 1�� ���� �޾����Ƿ� 1�� �ٽ� ����
	case 1:
		cout << "07��:";
		break;
	case 2:
		cout << "12��:";
		break;
	case 3:
		cout << "17��:";
		break;
	}
	schedule[time].show(); // Schedule ��ü�� show() �Լ� ȣ��
	cout << endl;
}
void AirlineBook::showAllSchedule() { // ��� ������ ���
	for (int i = 0; i < 3; i++)
	{
		showSchedule(i);
	}
	cout << endl;
}
Schedule AirlineBook::getSchedule(int time) { // Main���� �Է¹��� �ð��� ������ ����
	return schedule[time];
}