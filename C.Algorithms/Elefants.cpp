// Расстановка 8и слонов на шахматном поле так, чтобы они не атаковали друг друга
#define _CRT_SECURE_NO_WARNINGS
#include <stdio.h>
#include <conio.h>
#include <stdlib.h>
#include <time.h>

const int n = 8, m = 8;
int board[n][m];
const int k = 8;

void filMat() {
	for (int i = 0; i < n; i++)
		for (int j = 0; j < m; j++)
			board[n][m] = 0;
}

void output() {
	for (int i = 0; i < n; i++) {
		for (int j = 0; j < m; j++)
			printf("%d ", board[n][m]);
		printf("\n");
	}
	printf("\n");
}

void elefants() {
	int row, column;
	for (int s = 0; s < k;) {
		bool c = true;
		row = rand() % 8;
		column = rand() % 8;
		
		for (int i = row, j = column; i < n; i++, j++) {
			if (i > 7 || j > 7)
				break;
			if (board[i][j] == 1) {
				c = false;
				break;
			}
		}

			if (!c)
				break;

			for (int i = row, j = column; i < n; i++, j--) {
				if (i > 7 || j < 0)
					break;
				if (board[i][j] == 1) {
					c = false;
					break;
				}
			}
				

			if (!c)
				break;

			for (int i = row, j = column; i >= 0; i--, j--) {
				if (i < 0 || j < 0)
					break;
				if (board[i][j] == 1) {
					c = false;
					break;
				}
			}
				

			if (!c)
				break;

			for (int i = row, j = column; i >= 0; i--, j++) {
				if (i < 0 || j > 7)
					break;
				if (board[i][j] == 1) {
					c = false;
					break;
				}
			}
				
		
		
		if (c) {
			board[row][column] = 1;
			s++;
		}
			
	}
}

void main() {
	srand(time(0));
	filMat();
	elefants();
	output();
	_getch();
}