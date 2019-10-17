#define _CRT_SECURE_NO_WARNINGS
#include <stdio.h>
#include <string.h>
#include <conio.h>
#include <Windows.h>
#include "DefineFunc.h"

void ProOutputFunc(struct Grade* st, struct Sub* sub)
{

	int x = 0;
	int y = 9;
	int i = 0, j = 0;

	gotoxy(x + 5, y - 6);
	printf("●성적 현황●");
	gotoxy(x + 5, y - 5);
	printf("[교 수 모 드]");
	gotoxy(x, y - 2);
	printf(" %8s |", "이름"); // 성적 출력문

	for (i = 0; i < 100; i++) // 이미 존재하는 과목수 계산
	{
		if (!strcmp(sub[i].subjectname, "0")) // 과목명이 "0"이 아닐 때 까지 출력
		{
		}
		else
		{

			printf("%5s |  %5s | ", sub[i].subjectname, "학점");// sub[i].subjectname 은 과목명
		}
	}
	printf("%5s | %5s  |\n", "합계", "평균");


	for (j = 0; j < 100; j++)
	{
		if (!strcmp(st[j].id, "0")) // id가 "0"이 아니라면 id출력
		{
		}
		else
		{
			gotoxy(x, y - 1);
			printf(" %8s |", st[j].id);
		}

		for (i = 0; i < 100; i++)
		{
			if (st[j].subject[i] != -1) // 성적이 -1이 아니라면 성적 출력
			{
				printf("%5d |%5s   | ", st[j].subject[i], st[j].rating[i]); // 성적 출력
			}

			if (!strcmp(sub[i].subjectname, "0"))
			{
			}
			else // subjectname가 "0"이 아니고
			{
				if (st[j].subject[i] == -1) // 과목점수가 -1일 때
				{
					if (!strcmp(st[j].id, "0"))
					{
					}
					else // id가 "0"이 아니면
					{
						//gotoxy(x, y - 1);
						printf("%5s| %5s | ", "미입력", "미입력"); // 미입력 성적 출력
					}
				}
			}
		}

		if (st[j].sum != NULL)
		{
			printf("%5d | %6.2f | \n", st[j].sum, st[j].avg); // 합계, 평균 출력
		}

		if (!strcmp(st[j].id, "0"))
		{
		}
		else  // id가 0이 아니고
		{
			if (st[j].sum == NULL) // sum값이 NULL이면
			{
				printf("%5s| %5s | \n", "미입력", "미입력"); // sum이 NULL이면 미입력 성적 출력
			}
		}
		y++;
	}
	system("pause");
	system("cls");
}

void StOutputFunc(struct Grade* st, struct Sub* sub)
{
	int x = 0;
	int y = 9;
	int i = 0, j = 0;
	int call = 0;
	gotoxy(x + 5, y - 6);
	printf("●성적 현황●");
	gotoxy(x + 5, y - 5);
	printf("[학 생 모 드]");
	gotoxy(x, y - 2);
	printf(" %8s |", "이름"); // 성적 출력문

	for (i = 0; i < 100; i++)
	{
		if (st[i].callnum == 1)
		{
			call = i;
			break;
		}
	}

	for (i = 0; i < 100; i++) // 이미 존재하는 과목수 계산
	{
		if (!strcmp(sub[i].subjectname, "0")) // 과목명이 "0"이 아닐 때 까지 출력
		{
		}
		else
		{

			printf("%5s |  %5s | ", sub[i].subjectname, "학점");// sub[i].subjectname 은 과목명
		}
	}

	printf("%5s | %5s  |\n", "합계", "평균");

	printf(" %8s |", st[call].id); // id 출력문

	for (i = 0; i < 100; i++)
	{
		if (st[call].subject[i] != -1) // 성적이 -1이 아니라면 성적 출력
		{

			printf("%5d |%5s   | ", st[call].subject[i], st[call].rating[i]); // 성적 출력
		}

		if (!strcmp(sub[i].subjectname, "0"))
		{
		}
		else // subjectname가 "0"이 아니고
		{
			if (st[call].subject[i] == -1) // 과목점수가 -1일 때
			{
				if (!strcmp(st[call].id, "0"))
				{
				}
				else // id가 "0"이 아니면
				{
					//gotoxy(x + 11, y - 1);
					printf("%5s| %5s | ", "미입력", "미입력"); // 미입력 성적 출력
				}
			}
		}
	}

	if (st[call].sum != NULL)
	{
		printf("%5d | %6.2f | \n", st[call].sum, st[call].avg); // 합계, 평균 출력
	}

	if (!strcmp(st[call].id, "0"))
	{
	}
	else  // id가 0이 아니고
	{
		if (st[call].sum == NULL) // sum값이 NULL이면
		{
			//gotoxy(x + 11, y - 1);
			printf("%5s| %5s | \n", "미입력", "미입력"); // sum이 NULL이면 미입력 성적 출력
		}
	}
	system("pause");
	system("cls");
}

void SearchProFunc(struct Pro* pro) // 교수 조회 함수
{
	int x = 45;
	int y = 9;
	int i;
	gotoxy(x, y);
	printf("현재있는 교직원 : ");
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
	printf("\n\n");
	system("pause");
	system("cls");
}

void SearchStFunc(struct Grade* st) // 학생 조회 함수
{
	int x = 45;
	int y = 9;
	int i;
	gotoxy(x, y);
	printf("현재있는 학생들 : ");
	for (i = 0; i < 100; i++) // 현재 존재하는 교수명 출력
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
	system("pause");
	system("cls");
}

void AllInputFunc(struct Grade* st, struct Sub* sub) // 전체 성적 입력 함수
{
	int x = 42;
	int y = 9;
	int i = 0, j = 0;

	for (i = 0; i < 100; i++) //과목수 까지 반복
	{
		if (!strcmp(st[i].id, "0")) // 학생명이 "0"값이면 브레이크
		{
		}

		else
		{
			gotoxy(x, y);
			printf("▶▶ %s학생의 성적을 입력해 주십시오 ◀◀", st[i].id);

			for (j = 0; j < 100; j++)
			{
				if (!strcmp(sub[j].subjectname, "0"))
				{
					break;
				}
				gotoxy(x + 5, y + 1);
				printf("%s 성적 : ", sub[j].subjectname); //과목명
				scanf("%d", &st[i].subject[j]);

				while (getchar() != '\n'); // 입력받은 데이터 값이 일치하지 않으면 반복

				if (0 <= st[i].subject[j] && st[i].subject[j] <= 100) {
					system("cls");
					gotoxy(x, y + 3);
					printf("정상적으로 입력 되었습니다!");
					Sleep(700);
					system("cls");
				}

				while (0 > st[i].subject[j] || st[i].subject[j] > 100)
				{
					system("cls");
					gotoxy(x, y + 3);
					printf("0에서 100사이의 수를 입력하시오 : "); //입력 받은 값이 0보다 작거나 100보다 클때
					scanf("%d", &st[i].subject[j]);
					while (getchar() != '\n');

					if (0 <= st[i].subject[j] && st[i].subject[j] <= 100) {
						system("cls");
						gotoxy(x, y + 3);
						printf("정상적으로 입력 되었습니다!");
						Sleep(700);
						system("cls");
					}
				} // 0이상 100이하의 값을 받기위한 반복문
			}
		}
	}
	CalculateFunc(st, sub);
	fflush(stdin);
	system("pause");
	system("cls");
}

void ChoiceInputFunc(struct Grade* st, struct Sub* sub) // 선택 성적 입력 함수
{
	int x = 42;
	int y = 9;
	int i = 0, j = 0, k = 0, subcount = 0, stucount = 0, forcount = 0; // subcount,stucount는이미 존재하는 과목,학생 수 forcount는 for문에서 존재하지 않는 과목명 출력용
	int addnum, addnum1; // 삭제할 과목 수
	char yn, yn1; // y/n
	char addsub[1000]; // 입력할 과목명
	char addstu[1000]; // 성적을 입력할 학생명
	int addst[100] = { 0 }; // 입력할 학생 임시 저장용

	for (i = 0; i < 100; i++) // 함수 호출할 때마다 초기화
	{
		addst[i] = 0;
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


	// 모든 학생 성적 입력 묻기 -> 모든 학생 아닐시 모든 과목 성적입력 묻기
	// -> 모든 과목 입력 아닐시 과목명 입력받고 입력

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
		printf("입력할 과목 수를 입력해 주세요 : ");
		scanf("%d", &addnum);


		subcount -= addnum;

		while (getchar() != '\n'); // 입력받은 데이터 값이 일치하지 않으면 반복
		if (0 <= subcount && subcount <= 100)
		{
			system("cls");
			gotoxy(x, y + 2);
			printf("정상적으로 입력 되었습니다!");
			Sleep(700);
			system("cls");

		}

		while (0 > subcount || subcount > 100)
		{
			subcount += addnum;
			gotoxy(x, y + 3);
			printf("입력할 과목 수는 0보다 작거나 100개를 넘어갈 수 없습니다.");//입력 받은 값이 0보다 작거나 100보다 클때
			Sleep(700);
			system("cls");
			gotoxy(x, y + 3);
			printf("과목 수를 다시 입력하세요 :");
			scanf("%d", &addnum);
			subcount -= addnum;
			while (getchar() != '\n');

			if (0 <= subcount && subcount <= 100) {
				system("cls");
				gotoxy(x, y + 3);
				printf("정상적으로 입력 되었습니다!");
			}
		} // 0이상 100이하의 값을 받기위한 반복문
		for (j = 0; j < addnum; j++)
		{
			forcount = 0; // for문이 시작할때마다 0으로 초기화
			gotoxy(x, y + 3);
			printf("입력할 과목을 입력해 주세요 : ");
			scanf("%s", &addsub);
			gotoxy(x, y + 4);
			printf("입력된 과목명 : %s\n", addsub);
			Sleep(700);

			for (i = 0; i < 100; i++)
			{
				if (!strcmp(sub[i].subjectname, addsub)) // 입력받은 과목명과 존재하는 과목명이 일치할 때
				{
					for (k = 0; k < 100; k++)
					{
						if (!strcmp(st[k].id, "0"))
						{
						}
						else // 학생의 id가 "0" 이 아니라면
						{
							system("cls");
							gotoxy(x, y + 3);
							printf("%s 학생의 %s 성적을 입력해주세요 :", st[k].id, sub[i].subjectname);
							scanf("%d", &st[k].subject[i]); //
							forcount = 1; // 일치하는 과목명이 있다면 1로 초기화
						}
					}
					system("cls");
					gotoxy(x, y + 3);
					printf("모든 학생의 해당 과목 성적이 입력되었습니다!");
					Sleep(700);
					system("cls");

				}
			}
			if (forcount == 0) //일치하는 과목명이 없다면 다음문장 출력
			{
				system("cls");
				gotoxy(x, y + 3);
				printf("존재하지 않는 과목명입니다");
				Sleep(700);
			}
		}
	}

	else if (yn == 'N' || yn == 'n')
	{
		system("cls");
		gotoxy(x, y);
		printf("현재있는 학생 수 : %d", stucount);
		gotoxy(x, y + 1);
		printf("입력할 학생 수를 입력해 주세요 : ");
		scanf("%d", &addnum);

		stucount -= addnum;

		while (getchar() != '\n'); // 입력받은 데이터 값이 일치하지 않으면 반복
		if (0 <= stucount && stucount <= 100)
		{
			system("cls");
			gotoxy(x, y + 3);
			printf("정상적으로 입력 되었습니다!");
			Sleep(700);
		}

		while (0 > stucount || stucount > 100)
		{
			system("cls");
			gotoxy(x, y + 3);
			stucount += addnum;
			printf("입력할 학생수는 0보다 작거나 100명을 넘어갈 수 없습니다."); //입력 받은 값이 0보다 작거나 100보다 클때
			Sleep(700);
			system("cls");
			gotoxy(x, y + 3);
			printf("학생 수를 다시 입력하세요 :");
			scanf("%d", &addnum);
			stucount -= addnum;
			while (getchar() != '\n');

			if (0 <= stucount && stucount <= 100) {
				system("cls");
				gotoxy(x, y + 3);
				printf("정상적으로 입력 되었습니다!");
				Sleep(700);
			}
		} // 0이상 100이하의 값을 받기위한 반복문

		for (j = 0; j < addnum; j++)
		{
			forcount = 0; // for문이 시작할때마다 0으로 초기화

			system("cls");
			gotoxy(x, y + 3);
			printf("성적을 입력할 학생명을 입력해 주세요 : ");
			scanf("%s", &addstu);
			gotoxy(x, y + 4);
			printf("입력된 학생명 : %s\n", addstu);
			Sleep(700);

			for (i = 0; i < 100; i++)
			{
				if (!strcmp(st[i].id, addstu)) // 입력받은 학생명과 존재하는 학생명이 일치할 때
				{
					addst[i] = 1; // i번지 학생 임시 저장
					forcount = 1;
					break;
				}
			}
			if (forcount == 0) //일치하는 학생명이 없다면 다음문장 출력
			{
				system("cls");
				gotoxy(x, y + 3);
				printf("존재하지 않는 학생명입니다");
				Sleep(700);
			}
		}

		getchar(); // 버퍼 지우기
		system("cls");
		gotoxy(x, y + 3);
		printf("모든 성적을 입력하시겠습니까? Y/N : ");
		scanf("%c", &yn1);

		if (yn1 == 'Y' || yn1 == 'y')
		{
			for (i = 0; i < 100; i++)
			{
				forcount = 0; // for문이 시작할때마다 0으로 초기화

				if (!strcmp(sub[i].subjectname, "0"))
				{
				}
				else // 과목명이 "0"이 아니고
				{
					for (k = 0; k < 100; k++)
					{
						if (addst[k] == 1) // 선택된 학생이고
						{
							system("cls");
							gotoxy(x, y + 3);
							printf("%s 학생의 %s 성적을 입력해주세요 :", st[k].id, sub[i].subjectname);
							st[k].subject[i] = -1;
							scanf("%d", &st[k].subject[i]); // 성적입력

							while (getchar() != '\n'); // 입력받은 데이터 값이 일치하지 않으면 반복

							if (0 <= st[k].subject[i] && st[k].subject[i] <= 100)
							{
								system("cls");
								gotoxy(x, y + 3);
								printf("정상적으로 입력 되었습니다!");
								Sleep(700);
							}

							while (0 > st[k].subject[i] || st[k].subject[i] > 100)
							{
								system("cls");
								gotoxy(x, y + 3);
								printf("0에서 100사이의 수를 입력하시오 : "); //입력 받은 값이 0보다 작거나 100보다 클때
								scanf("%d", &st[k].subject[i]);

								while (getchar() != '\n');

								if (0 <= st[k].subject[i] && st[k].subject[i] <= 100) {
									system("cls");
									gotoxy(x, y + 3);
									printf("정상적으로 입력 되었습니다!");
									Sleep(700);
								}
							} // 0이상 100이하의 값을 받기위한 반복문

							forcount = 1; // 일치하는 과목명이 있다면 1로 초기화
						}
					}
					if (forcount == 0) //일치하는 과목명이 없다면 다음문장 출력
					{
						system("cls");
						gotoxy(x, y + 3);
						printf("존재하지 않는 과목명입니다");
						Sleep(700);
					}
				}
			}
			system("cls");
			gotoxy(x, y + 3);
			printf("해당 학생의 모든 과목 성적이 입력되었습니다!");
			Sleep(700);
		}

		else if (yn1 == 'N' || yn1 == 'n')
		{
			system("cls");
			gotoxy(x, y + 3);
			printf("현재있는 과목 수 : %d", subcount);
			gotoxy(x, y + 4);
			printf("입력할 과목 수를 입력해 주세요 : ");
			scanf("%d", &addnum1);
			printf("\n\n");

			subcount -= addnum1;

			while (getchar() != '\n'); // 입력받은 데이터 값이 일치하지 않으면 반복
			if (0 <= subcount && subcount <= 100)
			{
				system("cls");
				gotoxy(x, y + 3);
				printf("정상적으로 입력 되었습니다!");
				Sleep(700);
			}

			while (0 > subcount || subcount > 100)
			{
				subcount += addnum1;
				gotoxy(x, y + 3);
				printf("입력할 과목수는 0보다 작거나 100개를 넘어갈 수 없습니다."); //입력 받은 값이 0보다 작거나 100보다 클때
				Sleep(700);
				system("cls");
				gotoxy(x, y + 3);
				printf("과목 수를 다시 입력하세요 : ");
				scanf("%d", &addnum1);
				subcount -= addnum1;
				while (getchar() != '\n');

				if (0 <= subcount && subcount <= 100) {
					system("cls");
					gotoxy(x, y + 3);
					printf("정상적으로 입력 되었습니다!");
				}
			} // 0이상 100이하의 값을 받기위한 반복문

			for (j = 0; j < addnum1; j++)
			{
				forcount = 0; // for문이 시작할때마다 0으로 초기화
				system("cls");
				gotoxy(x, y + 3);
				printf("입력할 과목을 입력해 주세요 : ");
				scanf("%s", &addsub);
				gotoxy(x, y + 4);
				printf("입력된 과목명 : %s\n", addsub);
				Sleep(700);

				for (i = 0; i < 100; i++)
				{
					if (!strcmp(sub[i].subjectname, addsub)) // 입력받은 과목명과 존재하는 과목명이 일치할 때
					{
						for (k = 0; k < 100; k++)
						{
							if (addst[k] == 1) // 선택된 학생이면
							{
								system("cls");
								gotoxy(x, y + 3);
								printf("%s 학생의 %s 성적을 입력해주세요 :", st[k].id, sub[i].subjectname);
								scanf("%d", &st[k].subject[i]);

								while (getchar() != '\n'); // 입력받은 데이터 값이 일치하지 않으면 반복

								if (0 <= st[k].subject[i] && st[k].subject[i] <= 100)
								{
									system("cls");
									gotoxy(x, y + 3);
									printf("정상적으로 입력 되었습니다!");
									Sleep(700);
								}

								while (0 > st[k].subject[i] || st[k].subject[i] > 100)
								{
									system("cls");
									gotoxy(x, y + 3);
									printf("0에서 100사이의 수를 입력하시오 : "); //입력 받은 값이 0보다 작거나 100보다 클때
									scanf("%d", &st[k].subject[i]);
									while (getchar() != '\n');

									if (0 <= st[k].subject[i] && st[k].subject[i] <= 100) {
										system("cls");
										gotoxy(x, y + 3);
										printf("정상적으로 입력 되었습니다!");
										Sleep(700);
										break;
									}
								} // 0이상 100이하의 값을 받기위한 반복문
								forcount = 1;
							}
						}
					}
				}
				if (forcount == 0) //일치하는 과목명이 없다면 다음문장 출력
				{
					system("cls");
					gotoxy(x, y + 3);
					printf("존재하지 않는 과목명입니다\n\n");
					Sleep(700);
				}
			}
		}

		else
		{
			system("cls");
			gotoxy(x, y + 3);
			printf("잘못된 입력입니다.\n");
			Sleep(700);
		}
	}

	else
	{
		system("cls");
		gotoxy(x, y + 3);
		printf("잘못된 입력입니다.\n");
		Sleep(700);
	}
	printf("\n\n");
	CalculateFunc(st, sub); // 성적이 수정되었을 수 있었기에 다시 계산 함수 호출
	system("pause");
	system("cls");
}