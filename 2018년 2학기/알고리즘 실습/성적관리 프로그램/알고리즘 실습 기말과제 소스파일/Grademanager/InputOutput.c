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
	printf("�ܼ��� ��Ȳ��");
	gotoxy(x + 5, y - 5);
	printf("[�� �� �� ��]");
	gotoxy(x, y - 2);
	printf(" %8s |", "�̸�"); // ���� ��¹�

	for (i = 0; i < 100; i++) // �̹� �����ϴ� ����� ���
	{
		if (!strcmp(sub[i].subjectname, "0")) // ������� "0"�� �ƴ� �� ���� ���
		{
		}
		else
		{

			printf("%5s |  %5s | ", sub[i].subjectname, "����");// sub[i].subjectname �� �����
		}
	}
	printf("%5s | %5s  |\n", "�հ�", "���");


	for (j = 0; j < 100; j++)
	{
		if (!strcmp(st[j].id, "0")) // id�� "0"�� �ƴ϶�� id���
		{
		}
		else
		{
			gotoxy(x, y - 1);
			printf(" %8s |", st[j].id);
		}

		for (i = 0; i < 100; i++)
		{
			if (st[j].subject[i] != -1) // ������ -1�� �ƴ϶�� ���� ���
			{
				printf("%5d |%5s   | ", st[j].subject[i], st[j].rating[i]); // ���� ���
			}

			if (!strcmp(sub[i].subjectname, "0"))
			{
			}
			else // subjectname�� "0"�� �ƴϰ�
			{
				if (st[j].subject[i] == -1) // ���������� -1�� ��
				{
					if (!strcmp(st[j].id, "0"))
					{
					}
					else // id�� "0"�� �ƴϸ�
					{
						//gotoxy(x, y - 1);
						printf("%5s| %5s | ", "���Է�", "���Է�"); // ���Է� ���� ���
					}
				}
			}
		}

		if (st[j].sum != NULL)
		{
			printf("%5d | %6.2f | \n", st[j].sum, st[j].avg); // �հ�, ��� ���
		}

		if (!strcmp(st[j].id, "0"))
		{
		}
		else  // id�� 0�� �ƴϰ�
		{
			if (st[j].sum == NULL) // sum���� NULL�̸�
			{
				printf("%5s| %5s | \n", "���Է�", "���Է�"); // sum�� NULL�̸� ���Է� ���� ���
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
	printf("�ܼ��� ��Ȳ��");
	gotoxy(x + 5, y - 5);
	printf("[�� �� �� ��]");
	gotoxy(x, y - 2);
	printf(" %8s |", "�̸�"); // ���� ��¹�

	for (i = 0; i < 100; i++)
	{
		if (st[i].callnum == 1)
		{
			call = i;
			break;
		}
	}

	for (i = 0; i < 100; i++) // �̹� �����ϴ� ����� ���
	{
		if (!strcmp(sub[i].subjectname, "0")) // ������� "0"�� �ƴ� �� ���� ���
		{
		}
		else
		{

			printf("%5s |  %5s | ", sub[i].subjectname, "����");// sub[i].subjectname �� �����
		}
	}

	printf("%5s | %5s  |\n", "�հ�", "���");

	printf(" %8s |", st[call].id); // id ��¹�

	for (i = 0; i < 100; i++)
	{
		if (st[call].subject[i] != -1) // ������ -1�� �ƴ϶�� ���� ���
		{

			printf("%5d |%5s   | ", st[call].subject[i], st[call].rating[i]); // ���� ���
		}

		if (!strcmp(sub[i].subjectname, "0"))
		{
		}
		else // subjectname�� "0"�� �ƴϰ�
		{
			if (st[call].subject[i] == -1) // ���������� -1�� ��
			{
				if (!strcmp(st[call].id, "0"))
				{
				}
				else // id�� "0"�� �ƴϸ�
				{
					//gotoxy(x + 11, y - 1);
					printf("%5s| %5s | ", "���Է�", "���Է�"); // ���Է� ���� ���
				}
			}
		}
	}

	if (st[call].sum != NULL)
	{
		printf("%5d | %6.2f | \n", st[call].sum, st[call].avg); // �հ�, ��� ���
	}

	if (!strcmp(st[call].id, "0"))
	{
	}
	else  // id�� 0�� �ƴϰ�
	{
		if (st[call].sum == NULL) // sum���� NULL�̸�
		{
			//gotoxy(x + 11, y - 1);
			printf("%5s| %5s | \n", "���Է�", "���Է�"); // sum�� NULL�̸� ���Է� ���� ���
		}
	}
	system("pause");
	system("cls");
}

void SearchProFunc(struct Pro* pro) // ���� ��ȸ �Լ�
{
	int x = 45;
	int y = 9;
	int i;
	gotoxy(x, y);
	printf("�����ִ� ������ : ");
	for (i = 0; i < 100; i++) // ���� �����ϴ� ������ ���
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

void SearchStFunc(struct Grade* st) // �л� ��ȸ �Լ�
{
	int x = 45;
	int y = 9;
	int i;
	gotoxy(x, y);
	printf("�����ִ� �л��� : ");
	for (i = 0; i < 100; i++) // ���� �����ϴ� ������ ���
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

void AllInputFunc(struct Grade* st, struct Sub* sub) // ��ü ���� �Է� �Լ�
{
	int x = 42;
	int y = 9;
	int i = 0, j = 0;

	for (i = 0; i < 100; i++) //����� ���� �ݺ�
	{
		if (!strcmp(st[i].id, "0")) // �л����� "0"���̸� �극��ũ
		{
		}

		else
		{
			gotoxy(x, y);
			printf("���� %s�л��� ������ �Է��� �ֽʽÿ� ����", st[i].id);

			for (j = 0; j < 100; j++)
			{
				if (!strcmp(sub[j].subjectname, "0"))
				{
					break;
				}
				gotoxy(x + 5, y + 1);
				printf("%s ���� : ", sub[j].subjectname); //�����
				scanf("%d", &st[i].subject[j]);

				while (getchar() != '\n'); // �Է¹��� ������ ���� ��ġ���� ������ �ݺ�

				if (0 <= st[i].subject[j] && st[i].subject[j] <= 100) {
					system("cls");
					gotoxy(x, y + 3);
					printf("���������� �Է� �Ǿ����ϴ�!");
					Sleep(700);
					system("cls");
				}

				while (0 > st[i].subject[j] || st[i].subject[j] > 100)
				{
					system("cls");
					gotoxy(x, y + 3);
					printf("0���� 100������ ���� �Է��Ͻÿ� : "); //�Է� ���� ���� 0���� �۰ų� 100���� Ŭ��
					scanf("%d", &st[i].subject[j]);
					while (getchar() != '\n');

					if (0 <= st[i].subject[j] && st[i].subject[j] <= 100) {
						system("cls");
						gotoxy(x, y + 3);
						printf("���������� �Է� �Ǿ����ϴ�!");
						Sleep(700);
						system("cls");
					}
				} // 0�̻� 100������ ���� �ޱ����� �ݺ���
			}
		}
	}
	CalculateFunc(st, sub);
	fflush(stdin);
	system("pause");
	system("cls");
}

void ChoiceInputFunc(struct Grade* st, struct Sub* sub) // ���� ���� �Է� �Լ�
{
	int x = 42;
	int y = 9;
	int i = 0, j = 0, k = 0, subcount = 0, stucount = 0, forcount = 0; // subcount,stucount���̹� �����ϴ� ����,�л� �� forcount�� for������ �������� �ʴ� ����� ��¿�
	int addnum, addnum1; // ������ ���� ��
	char yn, yn1; // y/n
	char addsub[1000]; // �Է��� �����
	char addstu[1000]; // ������ �Է��� �л���
	int addst[100] = { 0 }; // �Է��� �л� �ӽ� �����

	for (i = 0; i < 100; i++) // �Լ� ȣ���� ������ �ʱ�ȭ
	{
		addst[i] = 0;
	}

	for (i = 0; i < 100; i++) // �̹� �����ϴ� ����, �л� �� ���
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
	printf("�����ִ� �л� : ");
	for (i = 0; i < 100; i++) // ���� �����ϴ� ����� ���
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
	printf("�����ִ� ���� : ");
	for (i = 0; i < 100; i++) // ���� �����ϴ� ����� ���
	{
		if (!strcmp(sub[i].subjectname, "0"))
		{
		}
		else
		{
			printf("%s ", sub[i].subjectname);
		}
	}


	// ��� �л� ���� �Է� ���� -> ��� �л� �ƴҽ� ��� ���� �����Է� ����
	// -> ��� ���� �Է� �ƴҽ� ����� �Է¹ް� �Է�

	getchar(); // ���� �����
	gotoxy(x, y + 2);
	printf("��� �л��� �����Ͻðڽ��ϱ�? Y/N : ");
	scanf("%c", &yn);

	if (yn == 'Y' || yn == 'y')
	{
		system("cls");
		gotoxy(x, y);
		printf("�����ִ� ���� �� : %d", subcount);
		gotoxy(x, y + 1);
		printf("�Է��� ���� ���� �Է��� �ּ��� : ");
		scanf("%d", &addnum);


		subcount -= addnum;

		while (getchar() != '\n'); // �Է¹��� ������ ���� ��ġ���� ������ �ݺ�
		if (0 <= subcount && subcount <= 100)
		{
			system("cls");
			gotoxy(x, y + 2);
			printf("���������� �Է� �Ǿ����ϴ�!");
			Sleep(700);
			system("cls");

		}

		while (0 > subcount || subcount > 100)
		{
			subcount += addnum;
			gotoxy(x, y + 3);
			printf("�Է��� ���� ���� 0���� �۰ų� 100���� �Ѿ �� �����ϴ�.");//�Է� ���� ���� 0���� �۰ų� 100���� Ŭ��
			Sleep(700);
			system("cls");
			gotoxy(x, y + 3);
			printf("���� ���� �ٽ� �Է��ϼ��� :");
			scanf("%d", &addnum);
			subcount -= addnum;
			while (getchar() != '\n');

			if (0 <= subcount && subcount <= 100) {
				system("cls");
				gotoxy(x, y + 3);
				printf("���������� �Է� �Ǿ����ϴ�!");
			}
		} // 0�̻� 100������ ���� �ޱ����� �ݺ���
		for (j = 0; j < addnum; j++)
		{
			forcount = 0; // for���� �����Ҷ����� 0���� �ʱ�ȭ
			gotoxy(x, y + 3);
			printf("�Է��� ������ �Է��� �ּ��� : ");
			scanf("%s", &addsub);
			gotoxy(x, y + 4);
			printf("�Էµ� ����� : %s\n", addsub);
			Sleep(700);

			for (i = 0; i < 100; i++)
			{
				if (!strcmp(sub[i].subjectname, addsub)) // �Է¹��� ������ �����ϴ� ������� ��ġ�� ��
				{
					for (k = 0; k < 100; k++)
					{
						if (!strcmp(st[k].id, "0"))
						{
						}
						else // �л��� id�� "0" �� �ƴ϶��
						{
							system("cls");
							gotoxy(x, y + 3);
							printf("%s �л��� %s ������ �Է����ּ��� :", st[k].id, sub[i].subjectname);
							scanf("%d", &st[k].subject[i]); //
							forcount = 1; // ��ġ�ϴ� ������� �ִٸ� 1�� �ʱ�ȭ
						}
					}
					system("cls");
					gotoxy(x, y + 3);
					printf("��� �л��� �ش� ���� ������ �ԷµǾ����ϴ�!");
					Sleep(700);
					system("cls");

				}
			}
			if (forcount == 0) //��ġ�ϴ� ������� ���ٸ� �������� ���
			{
				system("cls");
				gotoxy(x, y + 3);
				printf("�������� �ʴ� ������Դϴ�");
				Sleep(700);
			}
		}
	}

	else if (yn == 'N' || yn == 'n')
	{
		system("cls");
		gotoxy(x, y);
		printf("�����ִ� �л� �� : %d", stucount);
		gotoxy(x, y + 1);
		printf("�Է��� �л� ���� �Է��� �ּ��� : ");
		scanf("%d", &addnum);

		stucount -= addnum;

		while (getchar() != '\n'); // �Է¹��� ������ ���� ��ġ���� ������ �ݺ�
		if (0 <= stucount && stucount <= 100)
		{
			system("cls");
			gotoxy(x, y + 3);
			printf("���������� �Է� �Ǿ����ϴ�!");
			Sleep(700);
		}

		while (0 > stucount || stucount > 100)
		{
			system("cls");
			gotoxy(x, y + 3);
			stucount += addnum;
			printf("�Է��� �л����� 0���� �۰ų� 100���� �Ѿ �� �����ϴ�."); //�Է� ���� ���� 0���� �۰ų� 100���� Ŭ��
			Sleep(700);
			system("cls");
			gotoxy(x, y + 3);
			printf("�л� ���� �ٽ� �Է��ϼ��� :");
			scanf("%d", &addnum);
			stucount -= addnum;
			while (getchar() != '\n');

			if (0 <= stucount && stucount <= 100) {
				system("cls");
				gotoxy(x, y + 3);
				printf("���������� �Է� �Ǿ����ϴ�!");
				Sleep(700);
			}
		} // 0�̻� 100������ ���� �ޱ����� �ݺ���

		for (j = 0; j < addnum; j++)
		{
			forcount = 0; // for���� �����Ҷ����� 0���� �ʱ�ȭ

			system("cls");
			gotoxy(x, y + 3);
			printf("������ �Է��� �л����� �Է��� �ּ��� : ");
			scanf("%s", &addstu);
			gotoxy(x, y + 4);
			printf("�Էµ� �л��� : %s\n", addstu);
			Sleep(700);

			for (i = 0; i < 100; i++)
			{
				if (!strcmp(st[i].id, addstu)) // �Է¹��� �л���� �����ϴ� �л����� ��ġ�� ��
				{
					addst[i] = 1; // i���� �л� �ӽ� ����
					forcount = 1;
					break;
				}
			}
			if (forcount == 0) //��ġ�ϴ� �л����� ���ٸ� �������� ���
			{
				system("cls");
				gotoxy(x, y + 3);
				printf("�������� �ʴ� �л����Դϴ�");
				Sleep(700);
			}
		}

		getchar(); // ���� �����
		system("cls");
		gotoxy(x, y + 3);
		printf("��� ������ �Է��Ͻðڽ��ϱ�? Y/N : ");
		scanf("%c", &yn1);

		if (yn1 == 'Y' || yn1 == 'y')
		{
			for (i = 0; i < 100; i++)
			{
				forcount = 0; // for���� �����Ҷ����� 0���� �ʱ�ȭ

				if (!strcmp(sub[i].subjectname, "0"))
				{
				}
				else // ������� "0"�� �ƴϰ�
				{
					for (k = 0; k < 100; k++)
					{
						if (addst[k] == 1) // ���õ� �л��̰�
						{
							system("cls");
							gotoxy(x, y + 3);
							printf("%s �л��� %s ������ �Է����ּ��� :", st[k].id, sub[i].subjectname);
							st[k].subject[i] = -1;
							scanf("%d", &st[k].subject[i]); // �����Է�

							while (getchar() != '\n'); // �Է¹��� ������ ���� ��ġ���� ������ �ݺ�

							if (0 <= st[k].subject[i] && st[k].subject[i] <= 100)
							{
								system("cls");
								gotoxy(x, y + 3);
								printf("���������� �Է� �Ǿ����ϴ�!");
								Sleep(700);
							}

							while (0 > st[k].subject[i] || st[k].subject[i] > 100)
							{
								system("cls");
								gotoxy(x, y + 3);
								printf("0���� 100������ ���� �Է��Ͻÿ� : "); //�Է� ���� ���� 0���� �۰ų� 100���� Ŭ��
								scanf("%d", &st[k].subject[i]);

								while (getchar() != '\n');

								if (0 <= st[k].subject[i] && st[k].subject[i] <= 100) {
									system("cls");
									gotoxy(x, y + 3);
									printf("���������� �Է� �Ǿ����ϴ�!");
									Sleep(700);
								}
							} // 0�̻� 100������ ���� �ޱ����� �ݺ���

							forcount = 1; // ��ġ�ϴ� ������� �ִٸ� 1�� �ʱ�ȭ
						}
					}
					if (forcount == 0) //��ġ�ϴ� ������� ���ٸ� �������� ���
					{
						system("cls");
						gotoxy(x, y + 3);
						printf("�������� �ʴ� ������Դϴ�");
						Sleep(700);
					}
				}
			}
			system("cls");
			gotoxy(x, y + 3);
			printf("�ش� �л��� ��� ���� ������ �ԷµǾ����ϴ�!");
			Sleep(700);
		}

		else if (yn1 == 'N' || yn1 == 'n')
		{
			system("cls");
			gotoxy(x, y + 3);
			printf("�����ִ� ���� �� : %d", subcount);
			gotoxy(x, y + 4);
			printf("�Է��� ���� ���� �Է��� �ּ��� : ");
			scanf("%d", &addnum1);
			printf("\n\n");

			subcount -= addnum1;

			while (getchar() != '\n'); // �Է¹��� ������ ���� ��ġ���� ������ �ݺ�
			if (0 <= subcount && subcount <= 100)
			{
				system("cls");
				gotoxy(x, y + 3);
				printf("���������� �Է� �Ǿ����ϴ�!");
				Sleep(700);
			}

			while (0 > subcount || subcount > 100)
			{
				subcount += addnum1;
				gotoxy(x, y + 3);
				printf("�Է��� ������� 0���� �۰ų� 100���� �Ѿ �� �����ϴ�."); //�Է� ���� ���� 0���� �۰ų� 100���� Ŭ��
				Sleep(700);
				system("cls");
				gotoxy(x, y + 3);
				printf("���� ���� �ٽ� �Է��ϼ��� : ");
				scanf("%d", &addnum1);
				subcount -= addnum1;
				while (getchar() != '\n');

				if (0 <= subcount && subcount <= 100) {
					system("cls");
					gotoxy(x, y + 3);
					printf("���������� �Է� �Ǿ����ϴ�!");
				}
			} // 0�̻� 100������ ���� �ޱ����� �ݺ���

			for (j = 0; j < addnum1; j++)
			{
				forcount = 0; // for���� �����Ҷ����� 0���� �ʱ�ȭ
				system("cls");
				gotoxy(x, y + 3);
				printf("�Է��� ������ �Է��� �ּ��� : ");
				scanf("%s", &addsub);
				gotoxy(x, y + 4);
				printf("�Էµ� ����� : %s\n", addsub);
				Sleep(700);

				for (i = 0; i < 100; i++)
				{
					if (!strcmp(sub[i].subjectname, addsub)) // �Է¹��� ������ �����ϴ� ������� ��ġ�� ��
					{
						for (k = 0; k < 100; k++)
						{
							if (addst[k] == 1) // ���õ� �л��̸�
							{
								system("cls");
								gotoxy(x, y + 3);
								printf("%s �л��� %s ������ �Է����ּ��� :", st[k].id, sub[i].subjectname);
								scanf("%d", &st[k].subject[i]);

								while (getchar() != '\n'); // �Է¹��� ������ ���� ��ġ���� ������ �ݺ�

								if (0 <= st[k].subject[i] && st[k].subject[i] <= 100)
								{
									system("cls");
									gotoxy(x, y + 3);
									printf("���������� �Է� �Ǿ����ϴ�!");
									Sleep(700);
								}

								while (0 > st[k].subject[i] || st[k].subject[i] > 100)
								{
									system("cls");
									gotoxy(x, y + 3);
									printf("0���� 100������ ���� �Է��Ͻÿ� : "); //�Է� ���� ���� 0���� �۰ų� 100���� Ŭ��
									scanf("%d", &st[k].subject[i]);
									while (getchar() != '\n');

									if (0 <= st[k].subject[i] && st[k].subject[i] <= 100) {
										system("cls");
										gotoxy(x, y + 3);
										printf("���������� �Է� �Ǿ����ϴ�!");
										Sleep(700);
										break;
									}
								} // 0�̻� 100������ ���� �ޱ����� �ݺ���
								forcount = 1;
							}
						}
					}
				}
				if (forcount == 0) //��ġ�ϴ� ������� ���ٸ� �������� ���
				{
					system("cls");
					gotoxy(x, y + 3);
					printf("�������� �ʴ� ������Դϴ�\n\n");
					Sleep(700);
				}
			}
		}

		else
		{
			system("cls");
			gotoxy(x, y + 3);
			printf("�߸��� �Է��Դϴ�.\n");
			Sleep(700);
		}
	}

	else
	{
		system("cls");
		gotoxy(x, y + 3);
		printf("�߸��� �Է��Դϴ�.\n");
		Sleep(700);
	}
	printf("\n\n");
	CalculateFunc(st, sub); // ������ �����Ǿ��� �� �־��⿡ �ٽ� ��� �Լ� ȣ��
	system("pause");
	system("cls");
}