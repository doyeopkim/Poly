#ifndef CONSOLE_H
#define CONSOLE_H
#include<string>
using namespace std;

class Console {	// �ܼ� Ŭ����
public:
	static int Menu();	// �޴��Է�(����) �Լ�
	static int Time();	// �ð��Է�(����) �Լ�
	static string Name();	// �̸��Է� �Լ�
	static int SeatNum();	// �¼��Է¼���) �Լ�
};
#endif