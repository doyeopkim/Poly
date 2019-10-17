#define _CRT_SECURE_NO_WARNINGS
#include <stdio.h>
#include <string.h>
#include <conio.h>
#include <Windows.h>
#include "DefineFunc.h"

void AddProFunc(struct Grade* st, struct Pro* pro) // 교수 추가 함수
{
	int x = 42;
	int y = 9;
	int i = 0, j = 0, k = 0, count = 0, forcount = 0; // count는이미 존재하는 교수 수
	char addpro[100] = "0"; // 추가할 교수명
	int plusnum; // 추가할 교수 수
	system("cls");
	for (i = 0; i < 100; i++) // 이미 존재하는 교수 계산
	{
		if (!strcmp(pro[i].id, "0"))
		{
		}
		else
		{
			count++;
		}
	}
	system("cls");
	gotoxy(x, y);
	printf("현재 있는 교직원의 수 : %d", count);
	gotoxy(x, y + 1);
	printf("등록할 교수 수를 입력해 주세요 : ");
	scanf("%d", &plusnum);

	count += plusnum;

	while (getchar() != '\n'); // 입력받은 데이터 값이 일치하지 않으면 반복
	if (0 <= count && count <= 100)
	{
		system("cls");
		gotoxy(x + 4, y + 4);
		printf("%d 명을 추가하였습니다. ", plusnum);
		Sleep(700);
		system("cls");
	}

	while (0 > count || count > 100)
	{
		count -= plusnum;
		system("cls");
		gotoxy(x - 5, y + 3);
		printf("교수 수는 0보다 작거나 100명을 넘어갈 수 없습니다. "); //입력 받은 값이 0보다 작거나 100보다 클때
		Sleep(700);
		system("cls");
		gotoxy(x - 5, y + 3);
		printf("등록할 교수의 수를 다시 입력하세요 : ");
		scanf("%d", &plusnum);
		count += plusnum;
		while (getchar() != '\n');

		if (0 <= count && count <= 100) {
			system("cls");
			gotoxy(x + 5, y + 3);
			printf("정상적으로 입력 되었습니다!");
			Sleep(700);
			system("cls");

		}
	} // 0이상 100이하의 값을 받기위한 반복문


	for (j = 0; j < plusnum; j++) // 추가할 교수 수 만큼 반복
	{
		for (i = 0; i < 100; i++)
		{
			if (!strcmp(pro[i].id, "0")) // 교수명이 "0" 일 때
			{
				forcount = 0;
				gotoxy(x + 4, y + 3);
				printf("등록할 교수명을 입력해 주세요 : ");
				scanf("%s", addpro);
				gotoxy(x + 4, y + 4);
				printf("등록된 교수명 : %s", addpro);

				for (k = 0; k < 100; k++)
				{
					if (!strcmp(pro[k].id, addpro))
					{
						system("cls");
						gotoxy(x + 4, y + 3);
						printf("이미 존재하는 ID 입니다.");
						forcount = 1;
						Sleep(700);
						system("cls");
						break;
					}
					else if (!strcmp(st[k].id, addpro))
					{
						system("cls");
						gotoxy(x + 4, y + 3);
						printf("이미 존재하는 ID 입니다.");
						forcount = 1;
						Sleep(700);
						system("cls");
						break;
					}
					else if (!strcmp("admin", addpro))
					{
						system("cls");
						gotoxy(x + 4, y + 3);
						printf("관리자 ID명으로는 생성할 수 없습니다.");
						forcount = 1;
						Sleep(700);
						system("cls");
						break;
					}
					if (k == 99 && forcount == 0)
					{
						strcpy(pro[i].id, addpro);
						system("cls");
						gotoxy(x + 4, y + 3);
						printf("%s 교수가 등록되었습니다.", addpro);
						Sleep(700);
						system("cls");
						break;
					}
				}
				break;
			}
		}
	}

	count = 0;
	for (i = 0; i < 100; i++) // 이미 존재하는 교수 계산
	{
		if (!strcmp(pro[i].id, "0"))
		{
		}
		else
		{
			count++;
		}
	}
	gotoxy(x + 3, y + 2);
	printf("총 교직원의 수 : %d", count);
	gotoxy(x + 3, y + 3);
	printf("현재있는 교수 : ");
	for (i = 0; i < 100; i++) // 현재 존재하는 과목명 출력
	{
		if (!strcmp(pro[i].id, "0"))
		{
		}
		else
		{
			printf("%s ", pro[i].id);
		}
	}
	gotoxy(x + 3, y + 4);
	system("pause");
	system("cls");
}

void DelProFunc(struct Pro* pro) // 교수 삭제 함수
{
	system("cls");
	int x = 42;
	int y = 9;
	int i = 0, j = 0, k = 0, count = 0, forcount = 0, procount = 0; // count는이미 존재하는 교수 수 forcount는 for문에서 존재하지 않는 교수명 출력용
	int delnum; // 삭제할 교수 수
	char delid[1000]; // 삭제할 교수 ID명

	system("cls");
	for (i = 0; i < 100; i++) // 이미 존재하는 교수 계산
	{
		if (!strcmp(pro[i].id, "0"))
		{
		}
		else
		{
			count++;
		}
	}
	procount = count;
	gotoxy(x, y);
	printf("현재 있는 교직원의 수 : %d", count);
	gotoxy(x, y + 1);
	printf("현재있는 교직원 : ");
	for (i = 0; i < 100; i++) // 현재 존재하는 교수명 출력
	{
		if (!strcmp(pro[i].id, "0"))
		{
		}
		else
		{
			printf("%s ", &pro[i].id);
		}
	}

	gotoxy(x, y + 2);
	printf("삭제할 교수 수를 입력해 주세요 : ");
	scanf("%d", &delnum);

	count -= delnum;

	while (getchar() != '\n'); // 입력받은 데이터 값이 일치하지 않으면 반복
	if (0 <= count && count <= 100)
	{
		gotoxy(x, y);
		printf(" 정상적으로 입력 되었습니다!");
		system("cls");
	}

	while (0 > count || count > 100)
	{
		count += delnum;
		system("cls");
		gotoxy(x - 10, y + 3);
		printf("삭제할 교수 수는 0보다 작거나 %d명을 넘어갈 수 없습니다.", procount); //입력 받은 값이 0보다 작거나 존재하는 교수보다 클때
		Sleep(700);
		system("cls");
		gotoxy(x - 5, y + 3);
		printf("삭제할 교수 수를 다시 입력 하세요 : ");
		scanf("%d", &delnum);
		count -= delnum;
		while (getchar() != '\n');

		if (0 <= count && count <= 100) {
			system("cls");
			gotoxy(x + 5, y + 3);
			printf(" 정상적으로 입력 되었습니다!");
			Sleep(700);
			system("cls");
		}
	} // 0이상 100이하의 값을 받기위한 반복문

	if (count == 0) // 모든 교수 삭제 호출 시
	{
		for (i = 0; i < 100; i++)
		{
			strcpy(pro[i].id, "0"); // 교수명을 "0"으로 초기화
		}
		system("cls");
		gotoxy(x, y);
		printf("모든 교직원이 삭제되었습니다.");
		Sleep(700);
		system("cls");
	} // count가 0이면 모든 교수가 없어지므로 모든교수 삭제 출력

	else
	{
		for (j = 0; j < delnum; j++)
		{
			forcount = 0; // for문이 시작할때마다 0으로 초기화
			gotoxy(x + 4, y + 3);
			printf("삭제할 교수명을 입력해 주세요 : ");
			scanf("%s", &delid);
			gotoxy(x + 4, y + 4);
			printf("입력된 교수명 : %s", delid);

			for (i = 0; i < 100; i++)
			{
				if (!strcmp(pro[i].id, delid)) // 입력받은 교수명과 존재하는 교수명이 일치할 때
				{
					if (!strcmp(delid, "0"))
					{
						break;
					}
					strcpy(pro[i].id, "0"); // 교수명을 "0"으로 초기화
					system("cls");
					gotoxy(x + 4, y + 3);
					printf("%s 교수가 삭제되었습니다!", delid);
					Sleep(700);
					system("cls");
					forcount = 1; // 일치하는 교수명이 있다면 1로 초기화
					break;
				}
			}
			if (forcount == 0) //일치하는 교수명이 없다면 다음문장 출력
			{
				system("cls");
				gotoxy(x + 4, y + 3);
				printf("존재하지 않는 교수명입니다");
				Sleep(700);
				system("cls");

			}
		}
	}

	count = 0;
	for (i = 0; i < 100; i++) // 이미 존재하는 교수 계산
	{
		if (!strcmp(pro[i].id, "0"))
		{
		}
		else
		{
			count++;
		}
	}

	gotoxy(x + 3, y + 2);
	printf("총 교직원의 수 : %d", count);
	gotoxy(x + 3, y + 3);
	printf("현재있는 교수 : ");

	for (i = 0; i < 100; i++) // 현재 존재하는 교수명 출력
	{
		if (!strcmp(pro[i].id, "0"))
		{
		}
		else
		{
			printf("%s ", pro[i].id);
		}
	}
	gotoxy(x + 3, y + 4);
	system("pause");
	system("cls");
}

void AddStFunc(struct Grade* st, struct Sub* sub, struct Pro* pro) // 학생 추가 함수
{
	int x = 43;
	int y = 7;
	int i = 0, j = 0, k = 0, count = 0, forcount = 0; // count는이미 존재하는 학생 수
	char addst[100] = "0"; // 추가할 학생명
	int plusnum; // 추가할 학생 수
	system("cls");
	for (i = 0; i < 100; i++) // 이미 존재하는 학생수 계산
	{
		if (!strcmp(st[i].id, "0"))
		{
		}
		else
		{
			count++;
		}
	}

	gotoxy(x, y);
	printf("현재 있는 학생의 수 : %d", count);
	gotoxy(x, y + 1);
	printf("추가할 학생 수를 입력해 주세요 : ");
	scanf("%d", &plusnum);

	count += plusnum;

	while (getchar() != '\n'); // 입력받은 데이터 값이 일치하지 않으면 반복
	if (0 <= count && count <= 100)
	{
		system("cls");
		gotoxy(x + 4, y + 4);
		printf("%d 명을 추가하였습니다. ", plusnum);
		Sleep(700);
		system("cls");
	}

	while (0 > count || count > 100)
	{
		count -= plusnum;

		system("cls");
		gotoxy(x - 10, y + 3);
		printf("학생 수는 0보다 작거나 100명을 넘어갈 수 없습니다."); //입력 받은 값이 0보다 작거나 100보다 클때
		Sleep(700);
		system("cls");
		gotoxy(x - 5, y + 3);
		printf("등록할 학생 수를 다시 입력하세요 : ");
		scanf("%d", &plusnum);
		count += plusnum;
		while (getchar() != '\n');

		if (0 <= count && count <= 100) {
			system("cls");
			gotoxy(x + 5, y + 3);
			printf("정상적으로 입력 되었습니다!");
			Sleep(700);
			system("cls");
		}
	} // 0이상 100이하의 값을 받기위한 반복문



	for (j = 0; j < plusnum; j++) // 추가할 학생 수 만큼 반복
	{
		for (i = 0; i < 100; i++)
		{
			if (!strcmp(st[i].id, "0")) // 학생명이 "0" 일 때
			{
				forcount = 0;
				gotoxy(x + 4, y + 3);
				printf("추가할 학생명을 입력해 주세요 : ");
				scanf("%s", addst);
				gotoxy(x + 4, y + 4);
				printf("입력된 학생명 : %s", addst);

				for (k = 0; k < 100; k++)
				{
					if (!strcmp(st[k].id, addst))
					{
						system("cls");
						gotoxy(x + 4, y + 3);
						printf("이미 존재하는 ID명 입니다.");
						Sleep(700);
						system("cls");
						break;
					}
					else if (!strcmp(pro[k].id, addst))
					{
						system("cls");
						gotoxy(x + 4, y + 3);
						printf("이미 존재하는 ID명 입니다.");
						Sleep(700);
						system("cls");
						break;
					}
					else if (!strcmp("admin", addst))
					{
						system("cls");
						gotoxy(x + 4, y + 3);
						printf("관리자 ID명으로는 생성할 수 없습니다.");
						Sleep(700);
						system("cls");
						break;
					}
					if (k == 99 && forcount == 0)
					{
						strcpy(st[i].id, addst);
						system("cls");
						gotoxy(x + 4, y + 3);
						printf("%s 학생이 추가되었습니다!", addst);
						Sleep(700);
						system("cls");
						break;
					}
				}
				break;
			}
		}
	}

	count = 0; //0으로 다시 초기화
	for (i = 0; i < 100; i++) // 이미 존재하는 학생수 계산
	{
		if (!strcmp(st[i].id, "0"))
		{
		}
		else
		{
			count++;
		}
	}
	gotoxy(x + 4, y + 2);
	printf("총 학생의 수 : %d", count);
	gotoxy(x + 4, y + 3);
	printf("현재있는 학생 : ");
	for (i = 0; i < 100; i++) // 현재 존재하는 과목명 출력
	{
		if (!strcmp(st[i].id, "0"))
		{
		}
		else
		{
			printf("%s ", st[i].id);
		}
	}
	gotoxy(x + 4, y + 4);
	CalculateFunc(st, sub); // 성적이 수정되었을 수 있었기에 다시 계산 함수 호출
	system("pause");
	system("cls");
}

void DelStFunc(struct Grade* st, struct Sub* sub) // 학생 삭제 함수
{
	int x = 43;
	int y = 7;
	int i = 0, j = 0, k = 0, count = 0, forcount = 0, stcount = 0; // count는이미 존재하는 학생 수 forcount는 for문에서 존재하지 않는 학생명 출력용
	int delnum; // 삭제할 학생 수
	char delid[1000]; // 삭제할 학생 ID명
	system("cls");
	for (i = 0; i < 100; i++) // 이미 존재하는 학생수 계산
	{
		if (!strcmp(st[i].id, "0"))
		{
		}
		else
		{
			count++;
		}
	}
	stcount = count;
	gotoxy(x, y);
	printf("현재 있는 학생의 수 : %d", count);
	gotoxy(x, y + 1);
	printf("현재있는 학생 : ");
	for (i = 0; i < 100; i++) // 현재 존재하는 학생명 출력
	{
		if (!strcmp(st[i].id, "0"))
		{
		}
		else
		{
			printf("%s ", st[i].id);
		}
	}

	gotoxy(x, y + 2);
	printf("삭제할 학생 수를 입력해 주세요 : ");
	scanf("%d", &delnum);

	count -= delnum;

	while (getchar() != '\n'); // 입력받은 데이터 값이 일치하지 않으면 반복
	if (0 <= count && count <= 100)
	{
		gotoxy(x, y);
		printf("정상적으로 입력 되었습니다!");
		system("cls");
	}

	while (0 > count || count > 100)
	{
		count += delnum;
		system("cls");
		gotoxy(x - 10, y + 3);
		printf("삭제할 학생 수는 0보다 작거나 %d명을 넘어갈 수 없습니다. ", stcount); //입력 받은 값이 0보다 작거나 존재하는 학생 수 보다 클때
		Sleep(700);
		system("cls");
		gotoxy(x - 5, y + 3);
		printf("삭제할 학생의 수를 다시 입력하세요 : ");
		scanf("%d", &delnum);
		count -= delnum;
		while (getchar() != '\n');

		if (0 <= count && count <= 100) {
			system("cls");
			gotoxy(x + 5, y + 3);
			printf(" 정상적으로 입력 되었습니다!");
			Sleep(700);
			system("cls");
		}
	} // 0이상 100이하의 값을 받기위한 반복문

	if (count == 0) // 모든 학생 삭제 호출 시
	{
		for (i = 0; i < 100; i++)
		{
			strcpy(st[i].id, "0"); // 학생명을 "0"으로 초기화

			for (j = 0; j < 100; j++)
			{
				st[i].subject[j] = -1; // 삭제될 학생의 모든 과목의 성적을 -1로 초기화
			}
		}
		system("cls");
		gotoxy(x, y);
		printf("모든 학생이 삭제되었습니다.");
		Sleep(700);
		system("cls");
	} // count가 0이면 모든 학생이 없어지므로 모든학생 삭제 출력

	else
	{
		for (j = 0; j < delnum; j++)
		{
			forcount = 0; // for문이 시작할때마다 0으로 초기화
			gotoxy(x + 4, y + 3);
			printf("삭제할 학생명을 입력해 주세요 : ");
			scanf("%s", &delid);
			gotoxy(x + 4, y + 4);
			printf("입력된 학생명 : %s", delid);

			for (i = 0; i < 100; i++)
			{
				if (!strcmp(st[i].id, delid)) // 입력받은 학생명과 존재하는 학생명이 일치할 때
				{
					if (!strcmp(delid, "0"))
					{
						break;
					}
					for (k = 0; k < 100; k++)
					{
						st[i].subject[k] = -1; // 삭제될 학생의 모든 과목의 성적을 -1로 초기화
					}
					strcpy(st[i].id, "0"); // 학생명을 "0"으로 초기화
					system("cls");
					gotoxy(x + 4, y + 3);
					printf("%s 학생이 삭제되었습니다!", delid);
					Sleep(700);
					system("cls");
					forcount = 1; // 일치하는 학생명이 있다면 1로 초기화
					break;
				}
			}
			if (forcount == 0) //일치하는 학생명이 없다면 다음문장 출력
			{
				system("cls");
				gotoxy(x + 4, y + 3);
				printf("존재하지 않는 학생명입니다");
				Sleep(700);
				system("cls");

			}
		}
	}

	count = 0; //0으로 다시 초기화
	for (i = 0; i < 100; i++) // 이미 존재하는 학생수 계산
	{
		if (!strcmp(st[i].id, "0"))
		{
		}
		else
		{
			count++;
		}
	}
	gotoxy(x + 3, y + 3);
	printf("총 학생의 수 : %d", count);
	gotoxy(x + 3, y + 4);
	printf("현재있는 학생 : ");
	for (i = 0; i < 100; i++) // 현재 존재하는 학생명 출력
	{
		if (!strcmp(st[i].id, "0"))
		{
		}
		else
		{
			printf("%s ", st[i].id);
		}
	}

	gotoxy(x + 3, y + 4);
	CalculateFunc(st, sub); // 성적이 수정되었을 수 있었기에 다시 계산 함수 호출
	system("pause");
	system("cls");
}

void AddSubFunc(struct Grade* st, struct Sub* sub) // 과목 추가 함수 추가
{
	int x = 42;
	int y = 9;
	int i = 0, j = 0, k = 0, count = 0, forcount = 0; // count는이미 존재하는 과목 수 forcount는 for문에서 존재하지 않는 과목명 출력용
	char addsub[100] = "0"; // 추가할 과목명
	int plusnum; // 추가할 과목 수
	system("cls");
	for (i = 0; i < 100; i++) // 이미 존재하는 과목수 계산
	{
		if (!strcmp(sub[i].subjectname, "0"))
		{
		}
		else
		{
			count++;
		}
	}
	system("cls");
	gotoxy(x, y);
	printf("현재 있는 과목의 수 : %d", count);
	gotoxy(x, y + 1);
	printf("추가 할 과목 수를 입력해 주세요 : ");
	scanf("%d", &plusnum);

	count += plusnum;

	while (getchar() != '\n'); // 입력받은 데이터 값이 일치하지 않으면 반복
	if (0 <= count && count <= 100)
	{
		system("cls");
		gotoxy(x + 4, y + 4);
		printf("%d 개를 추가하였습니다. ", plusnum);
		Sleep(700);
		system("cls");
	}

	while (0 > count || count > 100)
	{
		count -= plusnum;
		system("cls");
		gotoxy(x - 10, y + 3);
		printf("과목 수는 0보다 작거나 100개를 넘어갈 수 없습니다. "); //입력 받은 값이 0보다 작거나 100보다 클때
		Sleep(700);
		system("cls");
		gotoxy(x - 5, y + 3);
		printf("추가할 과목의 수를 다시 입력하세요 : "); scanf("%d", &plusnum);
		count += plusnum;
		while (getchar() != '\n');

		if (0 <= count && count <= 100) {
			system("cls");
			gotoxy(x + 5, y + 3);
			printf("정상적으로 입력 되었습니다!");
			Sleep(700);;
			system("cls");
		}
	} // 0이상 100이하의 값을 받기위한 반복문


	for (j = 0; j < plusnum; j++) // 추가할 과목 수 만큼 반복
	{
		for (i = 0; i < 100; i++)
		{
			if (!strcmp(sub[i].subjectname, "0")) // 과목명이 "0" 일 때
			{
				forcount = 0; // for문이 시작할때마다 0으로 초기화
				gotoxy(x + 4, y + 3);
				printf("추가할 과목명을 입력해 주세요 : ");
				scanf("%s", addsub);
				gotoxy(x + 4, y + 4);
				printf("입력된 과목명 : %s", addsub);

				for (k = 0; k < 100; k++)
				{
					if (!strcmp(sub[k].subjectname, addsub))
					{
						system("cls");
						gotoxy(x + 4, y + 3);
						printf("이미 존재하는 과목명 입니다.");
						Sleep(700);
						system("cls");
						forcount = 1;
						break;
					}
				}
				if (forcount == 0)
				{
					strcpy(sub[i].subjectname, addsub);
					system("cls");
					gotoxy(x + 4, y + 3);
					printf("%s 과목이 추가되었습니다!", addsub);
					Sleep(700);
					system("cls");
					break;
				}
				break;
			}
		}
	}

	count = 0; //0으로 다시 초기화
	for (i = 0; i < 100; i++) // 이미 존재하는 과목수 계산
	{
		if (!strcmp(sub[i].subjectname, "0"))
		{
		}
		else
		{
			count++;
		}
	}

	gotoxy(x + 3, y + 2);
	printf("총 과목의 수 : %d", count);
	gotoxy(x + 3, y + 3);
	printf("현재있는 과목 : ");
	for (i = 0; i < 100; i++) // 현재 존재하는 과목명 출력
	{
		if (!strcmp(sub[i].subjectname, "0"))
		{
		}
		else
		{
			printf("%s ", sub[i].subjectname);
		}
	}
	gotoxy(x + 3, y + 4);
	CalculateFunc(st, sub); // 성적이 수정되었을 수 있었기에 다시 계산 함수 호출
	system("pause");
	system("cls");
}

void DelSubFunc(struct Grade* st, struct Sub* sub) // 과목 제거 함수
{
	int x = 42;
	int y = 9;
	int i = 0, j = 0, k = 0, count = 0, forcount = 0, subcount = 0; // count는이미 존재하는 과목 수 forcount는 for문에서 존재하지 않는 과목명 출력용
	int delnum; // 삭제할 과목 수
	char delsub[11]; // 삭제할 과목명
	system("cls");
	for (i = 0; i < 100; i++) // 이미 존재하는 과목수 계산
	{
		if (!strcmp(sub[i].subjectname, "0"))
		{
		}
		else
		{
			count++;
		}
	}
	subcount = count;
	system("cls");
	gotoxy(x, y);
	printf("현재 있는 과목의 수 : %d", count);
	gotoxy(x, y + 1);
	printf("현재있는 과목 : ");
	for (i = 0; i < 100; i++) // 현재 존재하는 과목명 출력
	{
		if (!strcmp(sub[i].subjectname, "0"))
		{
		}
		else
		{
			printf("%s ", sub[i].subjectname);
		}
	}

	gotoxy(x, y + 2);
	printf("삭제할 과목 수를 입력해 주세요 : ");
	scanf("%d", &delnum);

	count -= delnum;

	while (getchar() != '\n'); // 입력받은 데이터 값이 일치하지 않으면 반복
	if (0 <= count && count <= 100)
	{
		gotoxy(x, y + 1);
		printf("정상적으로 입력 되었습니다!");
		Sleep(700);
		system("cls");
	}

	while (0 > count || count > 100)
	{
		count += delnum;
		system("cls");
		gotoxy(x - 10, y + 3);
		printf("삭제할 과목 수는 0보다 작거나 %d개를 넘어갈 수 없습니다. ", subcount); //입력 받은 값이 0보다 작거나 존재하는 과목 수 보다 클때
		Sleep(700);
		system("cls");
		gotoxy(x - 5, y + 3);
		printf("삭제할 과목의 수를 다시 입력하세요 : "); scanf("%d", &delnum);
		count -= delnum;
		while (getchar() != '\n');

		if (0 <= count && count <= 100) {
			system("cls");
			gotoxy(x + 5, y + 3);
			printf("정상적으로 입력 되었습니다!");
			Sleep(700);
			system("cls");
		}
	} // 0이상 100이하의 값을 받기위한 반복문

	if (count == 0) // 모든 과목 삭제 호출 시
	{
		for (i = 0; i < 100; i++)
		{
			for (k = 0; k < 100; k++)
			{
				st[i].subject[k] = -1; // 모든 학생의 과목 성적을 다시 -1로 초기화
			}
			strcpy(sub[i].subjectname, "0"); // 과목명을 "0"으로 초기화
		}
		system("cls");
		gotoxy(x, y);
		printf("모든 과목이 삭제되었습니다.");
		Sleep(700);
		system("cls");
	} // count가 0이면 모든 과목이 없어지므로 모든과목 삭제 출력

	else
	{
		for (j = 0; j < delnum; j++)
		{
			forcount = 0; // for문이 시작할때마다 0으로 초기화
			gotoxy(x + 4, y + 3);
			printf("삭제할 과목을 입력해 주세요 : ");
			scanf("%s", &delsub);
			gotoxy(x + 4, y + 4);
			printf("입력된 과목명 : %s", delsub);

			for (i = 0; i < 100; i++)
			{
				if (!strcmp(sub[i].subjectname, delsub)) // 입력받은 과목명과 존재하는 과목명이 일치할 때
				{
					if (!strcmp(delsub, "0"))
					{
						break;
					}
					for (k = 0; k < 100; k++)
					{
						st[k].subject[i] = -1; // 모든 학생의 삭제될 과목의 성적을 -1로 초기화
					}
					strcpy(sub[i].subjectname, "0"); // 과목명을 "0"으로 초기화
					system("cls");
					gotoxy(x + 4, y + 3);
					printf("%s 과목이 삭제되었습니다!", delsub);
					Sleep(700);
					system("cls");
					forcount = 1; // 일치하는 과목명이 있다면 1로 초기화
					break;
				}
			}
			if (forcount == 0) //일치하는 과목명이 없다면 다음문장 출력
			{
				system("cls");
				gotoxy(x + 4, y + 3);
				printf("존재하지 않는 과목명입니다");
				Sleep(700);
				system("cls");
			}
		}
	}

	count = 0; //0으로 다시 초기화
	for (i = 0; i < 100; i++) // 이미 존재하는 과목수 계산
	{
		if (!strcmp(sub[i].subjectname, "0"))
		{
		}
		else
		{
			count++;
		}
	}
	gotoxy(x + 4, y + 2);
	printf("총 과목의 수 : %d", count);
	gotoxy(x + 4, y + 3);
	printf("현재있는 과목 : ");
	for (i = 0; i < 100; i++) // 현재 존재하는 과목명 출력
	{
		if (!strcmp(sub[i].subjectname, "0"))
		{
		}
		else
		{
			printf("%s ", sub[i].subjectname);
		}
	}
	gotoxy(x + 3, y + 4);
	CalculateFunc(st, sub); // 성적이 수정되었을 수 있었기에 다시 계산 함수 호출
	system("pause");
	system("cls");
}

void DelGradeFunc(struct Grade* st, struct Sub* sub) // 성적 삭제 함수
{
	system("cls");
	int x = 42;
	int y = 9;
	int i = 0, j = 0, k = 0, subcount = 0, stucount = 0, forcount = 0, nstcount = 0, nsubcount = 0; // subcount,stucount는이미 존재하는 과목,학생 수 forcount는 for문에서 존재하지 않는 과목명 출력용
	int delnum, delnum1; // 삭제할 과목 수
	char yn, yn1; // y/n
	char delsub[1000]; // 삭제할 과목명
	char delstu[1000]; // 성적을 삭제할 학생명
	int delst[100] = { 0 }; // 삭제할 학생 임시 저장용

	for (i = 0; i < 100; i++) // 함수 호출할 때마다 초기화
	{
		delst[i] = 0;
	}

	for (i = 0; i < 100; i++) // 이미 존재하는 과목, 학생 수 계산
	{
		if (!strcmp(sub[i].subjectname, "0"))
		{
		}
		else
		{
			subcount++;
		}
		if (!strcmp(st[i].id, "0"))
		{
		}
		else
		{
			stucount++;
		}
	}
	nstcount = stucount;
	nsubcount = subcount;
	gotoxy(x, y);
	printf("현재있는 학생 : ");
	for (i = 0; i < 100; i++) // 현재 존재하는 과목명 출력
	{
		if (!strcmp(st[i].id, "0"))
		{
		}
		else
		{
			printf("%s ", st[i].id);
		}
	}

	gotoxy(x, y + 1);
	printf("현재있는 과목 : ");
	for (i = 0; i < 100; i++) // 현재 존재하는 과목명 출력
	{
		if (!strcmp(sub[i].subjectname, "0"))
		{
		}
		else
		{
			printf("%s ", sub[i].subjectname);
		}
	}


	// 모든 학생 성적 삭제 묻기 -> 모든 학생 아닐시 모든 과목 성적삭제 묻기
	// -> 모든 과목 삭제 아닐시 과목명 입력받고 삭제

	getchar(); // 버퍼 지우기
	gotoxy(x, y + 2);
	printf("모든 학생을 선택하시겠습니까? Y/N : ");
	scanf("%c", &yn);

	if (yn == 'Y' || yn == 'y')
	{
		system("cls");
		gotoxy(x, y);
		printf("현재있는 과목 수 : %d", subcount);
		gotoxy(x, y + 1);
		printf("삭제할 과목 수를 입력해 주세요 : ");
		scanf("%d", &delnum);


		subcount -= delnum;

		while (getchar() != '\n'); // 입력받은 데이터 값이 일치하지 않으면 반복
		if (0 <= subcount && subcount <= 100)
		{
			system("cls");
			gotoxy(x + 5, y + 3);
			printf("정상적으로 입력 되었습니다!");
			Sleep(700);
			system("cls");
		}

		while (0 > subcount || subcount > 100)
		{
			subcount += delnum;
			system("cls");
			gotoxy(x - 10, y + 3);
			printf("삭제할 과목 수는 0보다 작거나 %d개를 넘어갈 수 없습니다. ", nsubcount); //입력 받은 값이 0보다 작거나 존재하는 과목 수 보다 클때
			Sleep(700);
			system("cls");
			gotoxy(x - 5, y + 3);
			printf("삭제할 과목의 수를 다시 입력하세요 : "); scanf("%d", &delnum);
			subcount -= delnum;
			while (getchar() != '\n');

			if (0 <= subcount && subcount <= 100) {
				system("cls");
				gotoxy(x + 5, y + 3);
				printf("정상적으로 입력 되었습니다!");
				Sleep(700);
				system("cls");
			}
		} // 0이상 100이하의 값을 받기위한 반복문

		if (subcount == 0) // 모든 과목 삭제 호출 시
		{
			for (i = 0; i < 100; i++)
			{
				for (k = 0; k < 100; k++)
				{
					st[i].subject[k] = -1; // 모든 학생의 과목 성적을 다시 -1로 초기화
				}
			}
			system("cls");
			gotoxy(x, y + 1);
			printf("모든 학생의 모든 과목 성적이 삭제되었습니다.");
			Sleep(700);
		} // subcount가 0이면 모든 과목이 없어지므로 모든과목 삭제 출력

		else
		{
			for (j = 0; j < delnum; j++)
			{
				system("cls");
				gotoxy(x, y);
				printf("삭제할 과목을 입력해 주세요 : ");
				scanf("%s", &delsub);
				gotoxy(x, y + 1);
				printf("입력된 과목명 : %s\n", delsub);

				forcount = 0; // for문이 시작할때마다 0으로 초기화

				for (i = 0; i < 100; i++)
				{
					if (!strcmp(sub[i].subjectname, delsub)) // 입력받은 과목명과 존재하는 과목명이 일치할 때
					{
						for (k = 0; k < 100; k++)
						{
							st[k].subject[i] = -1; // 모든 학생의 삭제될 과목의 성적을 -1로 초기화
						}
						system("cls");
						gotoxy(x + 4, y + 3);
						printf("모든 학생의 해당 과목 성적이 삭제되었습니다!");
						Sleep(700);
						system("cls");
						forcount = 1; // 일치하는 과목명이 있다면 1로 초기화
						break;
					}
				}
				if (forcount == 0) //일치하는 과목명이 없다면 다음문장 출력
				{
					system("cls");
					gotoxy(x + 4, y + 3);
					printf("존재하지 않는 과목명입니다");
					Sleep(700);
					system("cls");
				}
			}
		}
	}

	else if (yn == 'N' || yn == 'n')
	{
		system("cls");
		gotoxy(x, y);
		printf("현재있는 학생 수 : %d", stucount);
		gotoxy(x, y + 1);
		printf("삭제할 학생 수를 입력해 주세요 : ");
		scanf("%d", &delnum);

		stucount -= delnum;

		while (getchar() != '\n'); // 입력받은 데이터 값이 일치하지 않으면 반복
		if (0 <= stucount && stucount <= 100)
		{
			system("cls");
			gotoxy(x + 5, y + 3);
			printf("정상적으로 입력 되었습니다!");
			Sleep(700);
			system("cls");
		}

		while (0 > stucount || stucount > 100)
		{
			stucount += delnum;
			system("cls");
			gotoxy(x - 10, y + 3);
			printf("삭제할 학생 수는 0보다 작거나 %d명을 넘어갈 수 없습니다. ", nstcount); //입력 받은 값이 0보다 작거나 존재하는 학생 수 보다 클때
			Sleep(700);
			system("cls");
			gotoxy(x - 5, y + 3);
			printf("삭제할 학생의 수를 다시 입력하세요 : "); scanf("%d", &delnum);
			stucount -= delnum;
			while (getchar() != '\n');

			if (0 <= stucount && stucount <= 100) {
				system("cls");
				gotoxy(x + 5, y + 3);
				printf("정상적으로 입력 되었습니다!");
				Sleep(700);
				system("cls");
			}
		} // 0이상 100이하의 값을 받기위한 반복문

		for (j = 0; j < delnum; j++)
		{
			system("cls");
			gotoxy(x, y);
			printf("삭제할 학생명을 입력해 주세요 : ");
			scanf("%s", &delstu);
			gotoxy(x, y + 1);
			printf("입력된 학생명 : %s", delstu);

			forcount = 0; // for문이 시작할때마다 0으로 초기화

			for (i = 0; i < 100; i++)
			{
				if (!strcmp(st[i].id, delstu)) // 입력받은 학생명과 존재하는 학생명이 일치할 때
				{
					if (!strcmp(delstu, "0"))
					{
						break;
					}
					delst[i] = 1; // i번지 학생 임시 저장
					forcount = 1;
					break;
				}
			}
			if (forcount == 0) //일치하는 학생명이 없다면 다음문장 출력
			{
				system("cls");
				gotoxy(x + 4, y + 3);
				printf("존재하지 않는 학생명입니다");
				Sleep(700);
				system("cls");
			}
		}

		getchar(); // 버퍼 지우기
		system("cls");
		gotoxy(x + 4, y + 3);
		printf("모든 성적을 지우시겠습니까? Y/N : ");
		scanf("%c", &yn1);

		if (yn1 == 'Y' || yn1 == 'y')
		{
			for (i = 0; i < 100; i++)
			{
				if (delst[i] == 1)
				{
					for (j = 0; j < 100; j++)
					{
						st[i].subject[j] = -1; // 과목점수를 -1로 초기화
					}
				}
			}
			system("cls");
			gotoxy(x + 4, y + 3);
			printf("해당 학생의 모든 과목 성적이 삭제되었습니다!");
		}

		else if (yn1 == 'N' || yn1 == 'n')
		{
			system("cls");
			gotoxy(x, y);
			printf("현재있는 과목 수 : %d", subcount);
			gotoxy(x, y + 1);
			printf("삭제할 과목 수를 입력해 주세요 : ");
			scanf("%d", &delnum1);

			subcount -= delnum1;

			while (getchar() != '\n'); // 입력받은 데이터 값이 일치하지 않으면 반복
			if (0 <= subcount && subcount <= 100)
			{
				system("cls");
				gotoxy(x + 5, y + 3);
				printf("정상적으로 입력 되었습니다!");
				Sleep(1000);
				system("cls");
			}

			while (0 > subcount || subcount > 100)
			{
				subcount += delnum1;
				system("cls");
				gotoxy(x - 10, y + 3);
				printf("삭제할 과목 수 는 0보다 작거나 %d를 넘어갈 수 없습니다. ", nsubcount); //입력 받은 값이 0보다 작거나 존재하는 과목 수 보다 클때
				Sleep(700);
				system("cls");
				gotoxy(x - 5, y + 3);
				printf("삭제할 과목 수를 다시 입력하세요 : ");
				scanf("%d", &delnum1);
				subcount -= delnum1;
				while (getchar() != '\n');

				if (0 <= subcount && subcount <= 100) {
					system("cls");
					gotoxy(x + 5, y + 3);
					printf("정상적으로 입력 되었습니다!");
					Sleep(700);
					system("cls");
				}
			} // 0이상 100이하의 값을 받기위한 반복문

			for (j = 0; j < delnum1; j++)
			{
				system("cls");
				gotoxy(x, y);
				printf("삭제할 과목을 입력해 주세요 : ");
				scanf("%s", &delsub);
				gotoxy(x, y + 1);
				printf("입력된 과목명 : %s", delsub);

				forcount = 0; // for문이 시작할때마다 0으로 초기화

				for (i = 0; i < 100; i++)
				{
					if (!strcmp(sub[i].subjectname, delsub)) // 입력받은 과목명과 존재하는 과목명이 일치할 때
					{
						if (!strcmp(delsub, "0"))
						{
							break;
						}
						for (k = 0; k < 100; k++)
						{
							if (delst[k] == 1)
							{
								st[k].subject[i] = -1; // 과목점수를 -1로 초기화
								gotoxy(x, y);
								printf("해당 학생의 해당 과목 성적이 삭제되었습니다!");
								forcount = 1; // 일치하는 과목명이 있다면 1로 초기화
								break;
							}
						}
					}
				}
				if (forcount == 0) //일치하는 과목명이 없다면 다음문장 출력
				{
					system("cls");
					gotoxy(x + 4, y + 3);
					printf("존재하지 않는 과목명입니다");
					Sleep(700);
					system("cls");
				}
			}
		}

		else
		{
			system("cls");
			gotoxy(x + 4, y + 3);
			printf("잘못된 입력입니다.");
			Sleep(700);
			system("cls");
		}
	}

	else
	{
		system("cls");
		gotoxy(x + 4, y + 3);
		printf("잘못된 입력입니다.");
		Sleep(700);
		system("cls");
	}

	CalculateFunc(st, sub); // 성적이 수정되었을 수 있었기에 다시 계산 함수 호출
	system("pause");
	system("cls");
}