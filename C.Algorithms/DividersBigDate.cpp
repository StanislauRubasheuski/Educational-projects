
#define _CRT_SECURE_NO_WARNINGS 
#include <stdio.h> 
#include <conio.h> 



void main() {
	int n = 1000000;
	int max = 1, num = 1;
//***************************************************************************************
	if (n <= 1000) {
		for (int i = n * 0.5; i <= n; i++) {
			int sum = 1;
			if (i % 2 == 0) {
				for (int j = 2; j <= i; j++) {
					if (i % j == 0)
						sum += j;
				}
			}
			if (max < sum) {
				max = sum;
				num = i;
			}
		}
	}
//****************************************************************************************
	if (n > 1000 && n <= 100000) {
		for (int l = n * 0.8; l <= n; l++) {
			int sum = 1;
			if (l % 12 == 0) {
				for (int k = 2; k <= l; k++) {
					if (l % k == 0)
						sum += k;
				}
			}
			if (max < sum) {
				max = sum;
				num = l;
			}
		}
	}
//****************************************************************************************
	if (n > 100000) {
		for (int i = n * 0.97; i <= n; i++) {
			int sum = 1;
			if (i % 120 == 0) {
				for (int j = 2; j <= i; j++) {
					if (i % j == 0)
						sum += j;
				}
			}
			if (max < sum) {
				max = sum;
				num = i;
			}
		}
	}
//****************************************************************************************
	printf("Number %d with sum of dividers %d", num, max);
	_getch();
}
