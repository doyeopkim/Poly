#ifndef SEAT_H
#define SEAT_H
#include <string>
using namespace std;

class Seat {	// �¼� Ŭ����
	string name;
public:
	Seat() {} // 8���� Seat ��ü �����ϱ����� ������
	void setName(string name); // �̸� �����ϴ� �Լ�
	string getName(); // �̸��� ������ �Լ�
};
#endif