#include <iostream>
#include <string>
#include "AirlineBook.h"
using namespace std;

// 검색메뉴 추가, 스토리 보드

int main() {
	AirlineBook airline; // airline 객체 생성
	int select = 0;	// 메뉴선택 변수
	int time,seatNum;	// 입력받은 시간, 좌석번호를 저장할 변수
	string name;	// 입력받은 이름을 저장할 변수

	cout << "***** 한성항공에 오신것을 환영합니다 *****\n" << endl;

	while (select < 5) { // 메뉴가 3개이므로 4보다 작을 때 까지

		select = Console::Menu(); // 메뉴 출력 및 입력
		switch (select) {
		case 1:
		{
			time = Console::Time() -1; // 시간 입력 [-1은 배열은 0번지 부터 시작하므로]
			airline.showSchedule(time); // 해당 시간 좌석 출력
			seatNum = Console::SeatNum() -1; // 좌석번호 입력 [-1은 배열은 0번지 부터 시작하므로]
			name = Console::Name(); // 이름 입력
			airline.getSchedule(time).book(seatNum, name); // 해당 시간대의 좌석번호에 이름 저장
		}
		break;
		case 2:
		{
			time = Console::Time() -1; // 시간 입력 [-1은 배열은 0번지 부터 시작하므로]
			airline.showSchedule(time); // 해당 시간 좌석 출력
			seatNum = Console::SeatNum() -1; // 좌석번호 입력 [-1은 배열은 0번지 부터 시작하므로]
			name = Console::Name(); // 이름 입력
			airline.getSchedule(time).cancle(seatNum, name); // 해당 시간대에 좌석번호의 이름 삭제
		}
		break;
		case 3: // 전체 보기
			airline.showAllSchedule(); // 모든 스케쥴 출력
			break;
		case 4:
		{
			name = Console::Name(); // 이름 입력
			airline.getSchedule(0).search(7, name); // 7시 예약이름 찾기
			airline.getSchedule(1).search(12, name); // 12시 예약이름 찾기
			airline.getSchedule(2).search(17, name); // 17시 예약이름 찾기
		}
		break;
		case 0: // 시스템 종료
			cout << "예약 시스템을 종료합니다" << endl;
			return 0;
		}
	}
}