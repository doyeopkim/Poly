#include<iostream>
#include<string>
#include "AirlineBook.h"
#include "Console.h"
#include "Schedule.h"
#include "Seat.h"
using namespace std;

Schedule::Schedule() { // 생성자
	seat = new Seat[8];
	for (int i = 0; i < 8; i++) // 좌석의 이름을 "---" 으로초기화
	{
		seat[i].setName("-----");
	}
}
void Schedule::show() { // 좌석 이름 출력
	for (int i = 0; i < 8; i++)
		cout << " " << seat[i].getName() << "  ";
		cout << endl;
}
void Schedule::book(int seatNum, string name) { // 예약
	for (int i = seatNum; i < 8; i++) // 입력받은 seatNum부터 시작
	{
		if (seat[i].getName() == "-----") // 선택된 좌석이 "---"이라면 이름을 저장
		{
			seat[seatNum].setName(name); // 이름 저장
			cout << "예약이 완료되었습니다!\n" << endl;
			break;
		}
		else // 이미 예약된 좌석이라면 다음문장 출력
		{
			cout << "이미 예약된 좌석입니다." << endl;
			break;
		}
	}
}
void Schedule::cancle(int seatNum, string name) { // 예약 취소
	if (name == seat[seatNum].getName()) // 이름과 같다면 선택된 좌석을 "---"으로 다시 초기화
	{
		seat[seatNum].setName("-----");

		cout << "예약이 취소되었습니다!" << endl;
	}
	else // 입력된 이름이 없다면 다음문장 출력
	{
		cout << "없는 이름입니다." << endl;
	}
}

void Schedule::search(int time, string name) {

	for (int i = 0; i < 8; i++)
	{
		if (name == seat[i].getName())
		{
			i++;
			cout << time << "시의 " << i << "번석이 예약 되어있습니다." << endl;
			i--;
		}
	}
}