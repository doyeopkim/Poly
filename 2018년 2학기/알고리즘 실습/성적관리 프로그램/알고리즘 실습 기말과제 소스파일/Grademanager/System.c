#define _CRT_SECURE_NO_WARNINGS
#include <stdio.h>
#include <string.h>
#include <conio.h>
#include <Windows.h>
#include "DefineFunc.h"

void FileSaveFunc(struct Grade* st, struct Sub* sub, struct Pro* pro) // 파일 출력 함수
{
	int i, j;
	FILE *stclose = fopen("c:\\1\\st.txt", "wt"); // 학생 ID 및 패스워드
	FILE *proclose = fopen("c:\\1\\pro.txt", "wt"); // 교수 ID 및 패스워드
	FILE *subnclose = fopen("c:\\1\\subjectname.txt", "wt"); // 과목명
	FILE *subclose = fopen("c:\\1\\subject.txt", "wt"); // 성적

	for (i = 0; i < 100; i++)
	{
		if (!strcmp(sub[i].subjectname, "0")) // 과목명 파일출력
		{
		}
		else
		{

			fprintf(subnclose, "%s ", sub[i].subjectname);// sub[i].subjectname 은 과목명
		}

		if (!strcmp(st[i].id, "0")) // 학생 ID명, 비밀번호 파일 출력
		{
		}
		else
		{
			fprintf(stclose, "%s %s\n", st[i].id, st[i].password);
		}

		if (!strcmp(pro[i].id, "0")) // 교수 ID명, 비밀번호 파일 출력
		{
		}
		else
		{
			fprintf(proclose, "%s %s\n", pro[i].id, pro[i].password);
		}

		for (j = 0; j < 100; j++)
		{
			if (!strcmp(sub[j].subjectname, "0"))
			{
			}

			else // 성적 파일 출력
			{
				if (st[i].subject[j] != -1)
				{
					fprintf(subclose, "%d ", st[i].subject[j]);
				}
				else
				{
					fprintf(subclose, "-1 ", st[i].subject[j]);
				}
			}
		}
		fprintf(subclose, "\n");
	}
	fclose(stclose);
	fclose(proclose);
	fclose(subnclose);
	fclose(subclose);
}

void LoginFunc(struct Grade* st, struct Sub* sub, struct Pro* pro) // 로그인 함수
{
	int x2 = 32;
	int	y2 = 24;
	char selMenu[2];
	char inputid[10] = { "\0" };
	char inputpw[10] = { "\0" };
	char adminid[10] = "admin";
	char adminpw[10] = "1234";
	int key = 0;
	int Keycount = 0;
	int i = 0;
	int forcount = 0;
	int pwcount = 0;
	int a;
	int k = 0;
	int x1 = 45;
	int y1 = 4;
	gotoxy(x1, y1);
	printf("▶▶ 로그인을 해 주십시오 ◀◀");
	gotoxy(x1 - 2, y1 + 2);
	printf("       아이디   : ");
	scanf("%s", inputid);
	gotoxy(x1 - 2, y1 + 3);
	printf("       비밀번호 : ");
	scanf("%s", inputpw);


	/* 비밀번호 숨기는 과정에서 오류 (데스크탑에선 작동함)
	while (1)
	{
	key = _getch();  // 한 글자 입력받음
	if (key == 13)  // 엔터 키면 종료
	break;

	if (key != '\0' && Keycount == 0)
	{
	putchar('*');  // 화면에 별 표시
	inputpw[i] = (char)key; // 버퍼에 글자 저장하고 카운트 1 증가
	Keycount++;
	}

	else if (key != '\0' && Keycount != 0)
	{
	putchar('*');  // 화면에 별 표시
	inputpw[i] = (char)key;   // 버퍼에 글자 저장하고 카운트 1 증가
	inputpw[i - Keycount] = inputpw[i];
	Keycount++;
	}
	i++;
	}
	inputpw[Keycount] = '\0';

	printf("\n%s %s\n", inputid, inputpw);
	*/
	while (1) //본문  
	{
		if (strcmp(adminid, inputid) == 0 && strcmp(adminpw, inputpw) == 0)
		{
			//system("cls"); //화면창을 정리하는 함수  
			AdminMenuFunc();
			gotoxy(x2, y2);
			printf("관리자입니다. 무엇을 하시겠습니까? : ");
			scanf("%s", &selMenu);
			fflush(stdin); //버퍼를 지우는 함수  
			system("cls");
			printf("%s %s", inputid, inputpw);
			switch (selMenu[0])
			{
			case '1':
				SearchProFunc(pro);
				break;
			case '2':
				AddProFunc(st, pro);
				break;
			case '3':
				DelProFunc(pro);
				break;
			case '4':
				AddSubFunc(st, sub);
				break;
			case '5':
				DelSubFunc(st, sub);
				break;
			case '6':
				AddStFunc(st, sub, pro);
				break;
			case '7':
				DelStFunc(st, sub);
				break;
			case '8':
				LogoutFunc(st, sub, pro);
				break;
			case '0':
				FileSaveFunc(st, sub, pro);
				exit(1);
			default:
				printf("잘못된 입력입니다. 다시 입력해주십시오.\n");
				break;
			}
		}

		else
		{
			for (i = 0; i < 100; i++)
			{
				if (!strcmp(pro[i].id, inputid) && !strcmp(pro[i].password, inputpw))
				{
					forcount = 1;
					pro[i].callnum = 1; // 해당 교수 호출시 인덱스 값을 1로 초기화
					ProMenuFunc();
					gotoxy(x2 + 2, y2);
					printf("%s 교수님 안녕하세요. 무엇을 하시겠습니까? : ", inputid);
					scanf("%s", &selMenu);
					fflush(stdin);
					system("cls");
					switch (selMenu[0])
					{
					case '1':
						SearchStFunc(st);
						break;
					case '2':
						AllInputFunc(st, sub);
						break;
					case '3':
						ChoiceInputFunc(st, sub);
						break;
					case '4':
						DelGradeFunc(st, sub);
						break;
					case '5':
						ProOutputFunc(st, sub);
						break;
					case '6':
						ChangePasswordFunc(st, sub, pro);
						break;
					case '7':
						LogoutFunc(st, sub, pro);
						break;
					case '0':
						FileSaveFunc(st, sub, pro);
						exit(1);
					}
				}

				else if (!strcmp(st[i].id, inputid) && !strcmp(st[i].password, inputpw))
				{
					forcount = 1;
					st[i].callnum = 1; // 해당 학생 호출시 인덱스 값을 1로 초기화
					//system("cls"); //화면창을 정리하는 함수  
					StMenuFunc();
					gotoxy(x2 + 7, y2 - 4);
					printf("%s 학생님 안녕하세요. 무엇을 하시겠습니까? : ", inputid);
					scanf("%s", &selMenu);
					fflush(stdin); //버퍼를 지우는 함수  
					system("cls");
					switch (selMenu[0])
					{
					case '1':
						StOutputFunc(st, sub);
						break;
					case '2':
						ChangePasswordFunc(st, sub, pro);
						break;
					case '3':
						LogoutFunc(st, sub, pro);
						break;
					case '0':
						FileSaveFunc(st, sub, pro);
						exit(1);
					default:
						system("cls");
						gotoxy(x1, y1 + 6);
						printf("잘못된 입력입니다. 다시 입력해주십시오.");
						Sleep(700);
						break;
					}
					system("pause"); //프로그램이 계속 반복 할 수 있게하는 함수  
				}
			}
			if (forcount == 0)
			{
				system("cls");
				gotoxy(x1, y1 + 6);
				printf("ID 또는 비밀번호가 틀렸습니다.");
				Sleep(700);
				system("cls");
				LoginFunc(st, sub, pro);
			}
		}
	}
}

void LogoutFunc(struct Grade* st, struct Sub* sub, struct Pro* pro) // 로그 아웃 함수
{
	int i = 0;

	for (i = 0; i < 100; i++) // 로그아웃 했으므로  학생 성적 호출, 비밀번호 변경시 해당 인덱스 값을 기억하기 위한 변수를 다시 0으로 초기화
	{
		st[i].callnum = 0; // 학생
		pro[i].callnum = 0; // 교수
	}
	system("cls");
	LoginFunc(st, sub, pro);
}

void ChangePasswordFunc(struct Grade* st, struct Sub* sub, struct Pro* pro) // 비밀번호 변경 함수
{
	int x = 43;
	int y = 9;
	int i;
	int procall = -1, stcall = -1;
	char orpw[100], cp[100], rcp[100];

	for (i = 0; i < 100; i++) // 배열 번지 저장
	{
		if (st[i].callnum == 1)
		{
			stcall = i;
			break;
		}

		if (pro[i].callnum == 1)
		{
			procall = i;
			break;
		}
	}

	if (stcall != -1)
	{
		gotoxy(x, y);
		printf("비밀번호를 입력해 주세요 : ");
		scanf("%s", &orpw);

		if (!strcmp(st[stcall].password, orpw))
		{
			gotoxy(x, y + 1);
			printf("새 비밀 번호를 입력해 주세요 : ");
			scanf("%s", &cp);
			gotoxy(x, y + 2);
			printf("새 비밀 번호를 다시 입력해주세요 : ");
			scanf("%s", &rcp);
			printf("\n");
			fflush(stdin);

			if (!strcmp(st[stcall].password, orpw))
			{
				system("cls");
				strcpy(st[stcall].password, rcp);
				gotoxy(x, y);
				printf("비밀번호가 변경 되었습니다!");
				gotoxy(x, y + 1);
				printf("로그아웃 하겠습니다.");
				Sleep(700);
				system("cls");
				LoginFunc(st, sub, pro);
			}

			else
			{
				system("cls");
				gotoxy(x, y);
				printf("새 비밀번호가 일치하지 않습니다.");
				system("cls");
			}
		}

		else
		{
			system("cls");
			gotoxy(x, y);
			printf("비밀번호가 일치하지 않습니다.");
			system("cls");
		}
	}

	if (procall != -1)
	{
		gotoxy(x, y);
		printf("비밀번호를 입력해 주세요 : ");
		scanf("%s", &orpw);

		if (!strcmp(pro[procall].password, orpw))
		{
			gotoxy(x, y + 1);
			printf("새 비밀 번호를 입력해 주세요 : ");
			scanf("%s", &cp);
			gotoxy(x, y + 2);
			printf("새 비밀 번호를 다시 입력해주세요 : ");
			scanf("%s", &rcp);
			printf("\n");
			fflush(stdin);

			if (!strcmp(rcp, cp))
			{
				system("cls");
				strcpy(pro[procall].password, rcp);
				gotoxy(x, y);
				printf("비밀번호가 변경 되었습니다!");
				gotoxy(x, y + 1);
				printf("로그아웃 하겠습니다.");
				Sleep(700);
				system("cls");
				LoginFunc(st, sub, pro);
			}

			else
			{
				system("cls");
				gotoxy(x, y);
				printf("새 비밀번호가 일치하지 않습니다.");
				system("cls");
			}
		}
	}

	else
	{
		system("cls");
		gotoxy(x, y);
		printf("비밀번호가 일치하지 않습니다.");
		system("cls");
	}
}

void CalculateFunc(struct Grade* st, struct Sub* sub) // 점수, 학점을 저장하는 함수
{
	int i = 0, j = 0;
	int count = 0;

	for (int i = 0; i < 100; i++) // 다시계산할 때 기존성적 합계,평균이 누적되지 않도록 초기화
	{
		st[i].sum = NULL;
		st[i].avg = 0;
	}

	for (i = 0; i < 100; i++) { // 합계, 평균 구하는 for문
		for (j = 0; j < 100; j++)
		{
			if (st[i].subject[j] != -1) // 과목점수가 -1이 아니고
			{
				count++; // 성적 입력된 과목 수
				if (st[i].avg == 0)// 평균이 0이라면 과목을 다 더함
				{
					st[i].sum += st[i].subject[j];
				}
			}
		}
		if (count == 0)
		{
			st[i].avg = 0;
		}
		else
		{
			st[i].avg = st[i].sum / count; // 과목 수 만큼 나눔
		}
		count = 0; // for문 끝날 때마다 0으로 초기화
	}

	fflush(stdin);

	for (i = 0; i < 100; i++) // 학생 수
	{
		for (j = 0; j < 100; j++) // 과목 수
		{
			if (st[i].subject[j] > 95)
			{
				st[i].rating[j] = "A+";
			}
			else if (st[i].subject[j] > 90 && st[i].subject[j] <= 95)
			{
				st[i].rating[j] = "A";
			}
			else if (st[i].subject[j] > 85 && st[i].subject[j] <= 90)
			{
				st[i].rating[j] = "B+";
			}
			else if (st[i].subject[j] > 80 && st[i].subject[j] <= 85)
			{
				st[i].rating[j] = "B";
			}
			else if (st[i].subject[j] > 75 && st[i].subject[j] <= 80)
			{
				st[i].rating[j] = "C+";
			}
			else if (st[i].subject[j] > 70 && st[i].subject[j] <= 75)
			{
				st[i].rating[j] = "C";
			}
			else if (st[i].subject[j] > 65 && st[i].subject[j] <= 70)
			{
				st[i].rating[j] = "D+";
			}
			else if (st[i].subject[j] > 60 && st[i].subject[j] <= 65)
			{
				st[i].rating[j] = "D";
			}
			else
			{
				st[i].rating[j] = "F";
			}
		}
	}
}