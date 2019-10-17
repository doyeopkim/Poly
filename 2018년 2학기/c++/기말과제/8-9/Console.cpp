#include <iostream>
#include <string>
#include "AirlineBook.h"
#include "Console.h"
#include "Schedule.h"
#include "Seat.h"
using namespace std;

int Console::Menu() { // �޴� ����
	int menu;
	cout << endl << "�����ϱ�:1, �������:2, ���ຸ��:3, ����˻�:4 ������:0\n������ �Ͻðڽ��ϱ�? : ";
	cin >> menu;
	if (0 > menu || menu > 4) // �޴������� ������ ����ٸ�
	{
		while (true)
		{
			cout << "�߸��� �Է��Դϴ�. �ٽ��Է��� �ֽʽÿ� : ";
			cin >> menu;
			if (0 <= menu <= 4) // 0~4�� ���� �ԷµǸ� �ݺ� ����
			{
				break;
			}
		}
	}
	return menu;
}
int Console::Time() { // �ð� ����
	int time;
	cout << "���Ͻô� �ð��븦 �Է��� �ּ���(7, 12, 17) : ";
	cin >> time;
	if (time != 7 && time != 12 && time != 17) // �ð������� ������ ����ٸ�
	{
		while (true)
		{
			cout << "�߸��� �Է��Դϴ�. �ٽ��Է��� �ֽʽÿ� : ";
			cin >> time;
			if ( time == 7 || time == 12 || time == 17 ) // 7, 12, 17�� ���� �ԷµǸ� �ݺ� ����
			{
				break;
			}
		}
	}
	if (time == 7) // �Է¹��� �ð��� 1, 2, 3���� ��ȯ
	{
		time = 1;
	}
	else if (time == 12)
	{
		time = 2;
	}
	else if (time == 17)
	{
		time = 3;
	}
	return time;
}
string Console::Name() { // �̸� �Է�
	string name;
	cout << "�̸��� �Է��� �ּ��� : ";
	cin >> name;
	return name;
}
int Console::SeatNum() { // �¼� ��ȣ �Է�
	int num;
	cout << "����(���)�ϰ��� �ϴ� �¼��� �Է��� �ּ��� : ";
	cin >> num;
	if (0 > num || num > 8) // �¼���ȣ�� ������ ����ٸ�
	{
		while (true)
		{
			cout << "�߸��� �Է��Դϴ�. �ٽ��Է��� �ֽʽÿ� : ";
			cin >> num;
			if (1 <= num <= 8) // 1~8�� ���� �ԷµǸ� �ݺ� ����
			{
				break;
			}
		}
	}
	return num;
}