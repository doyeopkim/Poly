#define _CRT_SECURE_NO_WARNINGS
#include <stdio.h>
#include <string.h>
#include <conio.h>
#include <Windows.h>
#include "DefineFunc.h"

void FileSaveFunc(struct Grade* st, struct Sub* sub, struct Pro* pro) // ���� ��� �Լ�
{
	int i, j;
	FILE *stclose = fopen("c:\\1\\st.txt", "wt"); // �л� ID �� �н�����
	FILE *proclose = fopen("c:\\1\\pro.txt", "wt"); // ���� ID �� �н�����
	FILE *subnclose = fopen("c:\\1\\subjectname.txt", "wt"); // �����
	FILE *subclose = fopen("c:\\1\\subject.txt", "wt"); // ����

	for (i = 0; i < 100; i++)
	{
		if (!strcmp(sub[i].subjectname, "0")) // ����� �������
		{
		}
		else
		{

			fprintf(subnclose, "%s ", sub[i].subjectname);// sub[i].subjectname �� �����
		}

		if (!strcmp(st[i].id, "0")) // �л� ID��, ��й�ȣ ���� ���
		{
		}
		else
		{
			fprintf(stclose, "%s %s\n", st[i].id, st[i].password);
		}

		if (!strcmp(pro[i].id, "0")) // ���� ID��, ��й�ȣ ���� ���
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

			else // ���� ���� ���
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

void LoginFunc(struct Grade* st, struct Sub* sub, struct Pro* pro) // �α��� �Լ�
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
	printf("���� �α����� �� �ֽʽÿ� ����");
	gotoxy(x1 - 2, y1 + 2);
	printf("       ���̵�   : ");
	scanf("%s", inputid);
	gotoxy(x1 - 2, y1 + 3);
	printf("       ��й�ȣ : ");
	scanf("%s", inputpw);


	/* ��й�ȣ ����� �������� ���� (����ũž���� �۵���)
	while (1)
	{
	key = _getch();  // �� ���� �Է¹���
	if (key == 13)  // ���� Ű�� ����
	break;

	if (key != '\0' && Keycount == 0)
	{
	putchar('*');  // ȭ�鿡 �� ǥ��
	inputpw[i] = (char)key; // ���ۿ� ���� �����ϰ� ī��Ʈ 1 ����
	Keycount++;
	}

	else if (key != '\0' && Keycount != 0)
	{
	putchar('*');  // ȭ�鿡 �� ǥ��
	inputpw[i] = (char)key;   // ���ۿ� ���� �����ϰ� ī��Ʈ 1 ����
	inputpw[i - Keycount] = inputpw[i];
	Keycount++;
	}
	i++;
	}
	inputpw[Keycount] = '\0';

	printf("\n%s %s\n", inputid, inputpw);
	*/
	while (1) //����  
	{
		if (strcmp(adminid, inputid) == 0 && strcmp(adminpw, inputpw) == 0)
		{
			//system("cls"); //ȭ��â�� �����ϴ� �Լ�  
			AdminMenuFunc();
			gotoxy(x2, y2);
			printf("�������Դϴ�. ������ �Ͻðڽ��ϱ�? : ");
			scanf("%s", &selMenu);
			fflush(stdin); //���۸� ����� �Լ�  
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
				printf("�߸��� �Է��Դϴ�. �ٽ� �Է����ֽʽÿ�.\n");
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
					pro[i].callnum = 1; // �ش� ���� ȣ��� �ε��� ���� 1�� �ʱ�ȭ
					ProMenuFunc();
					gotoxy(x2 + 2, y2);
					printf("%s ������ �ȳ��ϼ���. ������ �Ͻðڽ��ϱ�? : ", inputid);
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
					st[i].callnum = 1; // �ش� �л� ȣ��� �ε��� ���� 1�� �ʱ�ȭ
					//system("cls"); //ȭ��â�� �����ϴ� �Լ�  
					StMenuFunc();
					gotoxy(x2 + 7, y2 - 4);
					printf("%s �л��� �ȳ��ϼ���. ������ �Ͻðڽ��ϱ�? : ", inputid);
					scanf("%s", &selMenu);
					fflush(stdin); //���۸� ����� �Լ�  
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
						printf("�߸��� �Է��Դϴ�. �ٽ� �Է����ֽʽÿ�.");
						Sleep(700);
						break;
					}
					system("pause"); //���α׷��� ��� �ݺ� �� �� �ְ��ϴ� �Լ�  
				}
			}
			if (forcount == 0)
			{
				system("cls");
				gotoxy(x1, y1 + 6);
				printf("ID �Ǵ� ��й�ȣ�� Ʋ�Ƚ��ϴ�.");
				Sleep(700);
				system("cls");
				LoginFunc(st, sub, pro);
			}
		}
	}
}

void LogoutFunc(struct Grade* st, struct Sub* sub, struct Pro* pro) // �α� �ƿ� �Լ�
{
	int i = 0;

	for (i = 0; i < 100; i++) // �α׾ƿ� �����Ƿ�  �л� ���� ȣ��, ��й�ȣ ����� �ش� �ε��� ���� ����ϱ� ���� ������ �ٽ� 0���� �ʱ�ȭ
	{
		st[i].callnum = 0; // �л�
		pro[i].callnum = 0; // ����
	}
	system("cls");
	LoginFunc(st, sub, pro);
}

void ChangePasswordFunc(struct Grade* st, struct Sub* sub, struct Pro* pro) // ��й�ȣ ���� �Լ�
{
	int x = 43;
	int y = 9;
	int i;
	int procall = -1, stcall = -1;
	char orpw[100], cp[100], rcp[100];

	for (i = 0; i < 100; i++) // �迭 ���� ����
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
		printf("��й�ȣ�� �Է��� �ּ��� : ");
		scanf("%s", &orpw);

		if (!strcmp(st[stcall].password, orpw))
		{
			gotoxy(x, y + 1);
			printf("�� ��� ��ȣ�� �Է��� �ּ��� : ");
			scanf("%s", &cp);
			gotoxy(x, y + 2);
			printf("�� ��� ��ȣ�� �ٽ� �Է����ּ��� : ");
			scanf("%s", &rcp);
			printf("\n");
			fflush(stdin);

			if (!strcmp(st[stcall].password, orpw))
			{
				system("cls");
				strcpy(st[stcall].password, rcp);
				gotoxy(x, y);
				printf("��й�ȣ�� ���� �Ǿ����ϴ�!");
				gotoxy(x, y + 1);
				printf("�α׾ƿ� �ϰڽ��ϴ�.");
				Sleep(700);
				system("cls");
				LoginFunc(st, sub, pro);
			}

			else
			{
				system("cls");
				gotoxy(x, y);
				printf("�� ��й�ȣ�� ��ġ���� �ʽ��ϴ�.");
				system("cls");
			}
		}

		else
		{
			system("cls");
			gotoxy(x, y);
			printf("��й�ȣ�� ��ġ���� �ʽ��ϴ�.");
			system("cls");
		}
	}

	if (procall != -1)
	{
		gotoxy(x, y);
		printf("��й�ȣ�� �Է��� �ּ��� : ");
		scanf("%s", &orpw);

		if (!strcmp(pro[procall].password, orpw))
		{
			gotoxy(x, y + 1);
			printf("�� ��� ��ȣ�� �Է��� �ּ��� : ");
			scanf("%s", &cp);
			gotoxy(x, y + 2);
			printf("�� ��� ��ȣ�� �ٽ� �Է����ּ��� : ");
			scanf("%s", &rcp);
			printf("\n");
			fflush(stdin);

			if (!strcmp(rcp, cp))
			{
				system("cls");
				strcpy(pro[procall].password, rcp);
				gotoxy(x, y);
				printf("��й�ȣ�� ���� �Ǿ����ϴ�!");
				gotoxy(x, y + 1);
				printf("�α׾ƿ� �ϰڽ��ϴ�.");
				Sleep(700);
				system("cls");
				LoginFunc(st, sub, pro);
			}

			else
			{
				system("cls");
				gotoxy(x, y);
				printf("�� ��й�ȣ�� ��ġ���� �ʽ��ϴ�.");
				system("cls");
			}
		}
	}

	else
	{
		system("cls");
		gotoxy(x, y);
		printf("��й�ȣ�� ��ġ���� �ʽ��ϴ�.");
		system("cls");
	}
}

void CalculateFunc(struct Grade* st, struct Sub* sub) // ����, ������ �����ϴ� �Լ�
{
	int i = 0, j = 0;
	int count = 0;

	for (int i = 0; i < 100; i++) // �ٽð���� �� �������� �հ�,����� �������� �ʵ��� �ʱ�ȭ
	{
		st[i].sum = NULL;
		st[i].avg = 0;
	}

	for (i = 0; i < 100; i++) { // �հ�, ��� ���ϴ� for��
		for (j = 0; j < 100; j++)
		{
			if (st[i].subject[j] != -1) // ���������� -1�� �ƴϰ�
			{
				count++; // ���� �Էµ� ���� ��
				if (st[i].avg == 0)// ����� 0�̶�� ������ �� ����
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
			st[i].avg = st[i].sum / count; // ���� �� ��ŭ ����
		}
		count = 0; // for�� ���� ������ 0���� �ʱ�ȭ
	}

	fflush(stdin);

	for (i = 0; i < 100; i++) // �л� ��
	{
		for (j = 0; j < 100; j++) // ���� ��
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