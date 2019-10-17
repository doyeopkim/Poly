#include <iostream>
#include <string>
#include "AirlineBook.h"
using namespace std;

// �˻��޴� �߰�, ���丮 ����

int main() {
	AirlineBook airline; // airline ��ü ����
	int select = 0;	// �޴����� ����
	int time,seatNum;	// �Է¹��� �ð�, �¼���ȣ�� ������ ����
	string name;	// �Է¹��� �̸��� ������ ����

	cout << "***** �Ѽ��װ��� ���Ű��� ȯ���մϴ� *****\n" << endl;

	while (select < 5) { // �޴��� 3���̹Ƿ� 4���� ���� �� ����

		select = Console::Menu(); // �޴� ��� �� �Է�
		switch (select) {
		case 1:
		{
			time = Console::Time() -1; // �ð� �Է� [-1�� �迭�� 0���� ���� �����ϹǷ�]
			airline.showSchedule(time); // �ش� �ð� �¼� ���
			seatNum = Console::SeatNum() -1; // �¼���ȣ �Է� [-1�� �迭�� 0���� ���� �����ϹǷ�]
			name = Console::Name(); // �̸� �Է�
			airline.getSchedule(time).book(seatNum, name); // �ش� �ð����� �¼���ȣ�� �̸� ����
		}
		break;
		case 2:
		{
			time = Console::Time() -1; // �ð� �Է� [-1�� �迭�� 0���� ���� �����ϹǷ�]
			airline.showSchedule(time); // �ش� �ð� �¼� ���
			seatNum = Console::SeatNum() -1; // �¼���ȣ �Է� [-1�� �迭�� 0���� ���� �����ϹǷ�]
			name = Console::Name(); // �̸� �Է�
			airline.getSchedule(time).cancle(seatNum, name); // �ش� �ð��뿡 �¼���ȣ�� �̸� ����
		}
		break;
		case 3: // ��ü ����
			airline.showAllSchedule(); // ��� ������ ���
			break;
		case 4:
		{
			name = Console::Name(); // �̸� �Է�
			airline.getSchedule(0).search(7, name); // 7�� �����̸� ã��
			airline.getSchedule(1).search(12, name); // 12�� �����̸� ã��
			airline.getSchedule(2).search(17, name); // 17�� �����̸� ã��
		}
		break;
		case 0: // �ý��� ����
			cout << "���� �ý����� �����մϴ�" << endl;
			return 0;
		}
	}
}