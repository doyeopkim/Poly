#include <iostream>
#include <string>
#include "AirlineBook.h"
#include "Console.h"
#include "Schedule.h"
#include "Seat.h"
using namespace std;

int Console::Menu() { // 메뉴 선택
	int menu;
	cout << endl << "예약하기:1, 예약취소:2, 예약보기:3, 예약검색:4 끝내기:0\n무엇을 하시겠습니까? : ";
	cin >> menu;
	if (0 > menu || menu > 4) // 메뉴선택이 범위를 벗어난다면
	{
		while (true)
		{
			cout << "잘못된 입력입니다. 다시입력해 주십시오 : ";
			cin >> menu;
			if (0 <= menu <= 4) // 0~4의 값이 입력되면 반복 멈춤
			{
				break;
			}
		}
	}
	return menu;
}
int Console::Time() { // 시간 선택
	int time;
	cout << "원하시는 시간대를 입력해 주세요(7, 12, 17) : ";
	cin >> time;
	if (time != 7 && time != 12 && time != 17) // 시간선택이 범위를 벗어난다면
	{
		while (true)
		{
			cout << "잘못된 입력입니다. 다시입력해 주십시오 : ";
			cin >> time;
			if ( time == 7 || time == 12 || time == 17 ) // 7, 12, 17의 값이 입력되면 반복 멈춤
			{
				break;
			}
		}
	}
	if (time == 7) // 입력받은 시간은 1, 2, 3으로 변환
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
string Console::Name() { // 이름 입력
	string name;
	cout << "이름을 입력해 주세요 : ";
	cin >> name;
	return name;
}
int Console::SeatNum() { // 좌석 번호 입력
	int num;
	cout << "예약(취소)하고자 하는 좌석을 입력해 주세요 : ";
	cin >> num;
	if (0 > num || num > 8) // 좌석번호가 범위를 벗어난다면
	{
		while (true)
		{
			cout << "잘못된 입력입니다. 다시입력해 주십시오 : ";
			cin >> num;
			if (1 <= num <= 8) // 1~8의 값이 입력되면 반복 멈춤
			{
				break;
			}
		}
	}
	return num;
}